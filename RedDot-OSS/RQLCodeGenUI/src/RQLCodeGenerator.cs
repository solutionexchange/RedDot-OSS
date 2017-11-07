/*
 * Created by SharpDevelop.
 * User: Nick
 * Date: 2/21/2007
 * Time: 10:13 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Data;
using System.IO;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;
using Microsoft.CSharp;

namespace RQLCodeGenUI
{
	/// <summary>
	/// Description of RQLCodeGenerator.
	/// </summary>
	public class RQLCodeGenerator
	{
		private XmlDocument request;
		private XmlDocument response;
		private CodeNamespace codeNamespace;
		private DirectoryInfo outputDirectory;
		private String className;
		
		public RQLCodeGenerator(string requestStr, string responseStr, string namespaceStr, string className, string outputDirectoryStr)
		{
			request = new XmlDocument();
			response = new XmlDocument();
			request.Load(new StringReader(requestStr));
			response.Load(new StringReader(responseStr));
			
			this.codeNamespace = new CodeNamespace(namespaceStr);
			this.outputDirectory = new DirectoryInfo(outputDirectoryStr);
			this.className = className;
		}
		
		public void GenerateCode()
		{
			XmlSchema requestSchema = GenerateSchemaForDocument(this.request);
			XmlSchema responseSchema = GenerateSchemaForDocument(this.response);
			
			CodeNamespace requestNS = GenerateCodeForSchema(requestSchema);
			CodeNamespace responseNS = GenerateCodeForSchema(responseSchema);
			
			CodeTypeDeclaration rqlClass = new CodeTypeDeclaration(this.className);
			rqlClass.IsClass = true;
			rqlClass.Attributes = MemberAttributes.Public;
			this.codeNamespace.Types.Add(rqlClass);		
			
			CodeTypeDeclaration requestClass = new CodeTypeDeclaration(this.className+"Request");
			requestClass.BaseTypes.Add(new CodeTypeReference("RQLRequestBase"));
			ProcessTemporaryNamespace(requestNS, requestClass);
			requestClass.Members.Add(new CodeMemberField("iodata", "data"));
			requestClass.Members.Add(GenerateGenericProperty("Data", "data", "iodata"));
			
			CodeTypeDeclaration responseClass = new CodeTypeDeclaration(this.className+"Response");
			responseClass.BaseTypes.Add(new CodeTypeReference("RQLResponseBase"));
			ProcessTemporaryNamespace(responseNS, responseClass);
			responseClass.Members.Add(new CodeMemberField("iodata", "data"));
			responseClass.Members.Add(GenerateGenericProperty("Data", "data", "iodata"));
			/*
			responseClass.Members.Add(new CodeMemberField("string", "rqlError"));
			responseClass.Members.Add(GenerateGenericProperty("RqlError", "rqlError"));
			responseClass.Members.Add(new CodeMemberField("string", "rqlInfo"));
			responseClass.Members.Add(GenerateGenericProperty("RqlError", "rqlInfo"));
			*/
			
			rqlClass.Members.Add(requestClass);
			rqlClass.Members.Add(responseClass);
			
			CodeMemberMethod execute = new CodeMemberMethod();
			execute.Attributes = MemberAttributes.Public;
			execute.Name = "Execute";
			execute.ReturnType = new CodeTypeReference(this.className+"Response");
			execute.Parameters.Add(new CodeParameterDeclarationExpression(this.className+"Request", "request"));
			execute.Statements.Add(new CodeVariableDeclarationStatement(this.className+"Response", "response"));
			execute.Statements.Add(new CodeAssignStatement(new CodeVariableReferenceExpression("response"), new CodeObjectCreateExpression(this.className+"Response", new CodeExpression[0])));
			CodeExpression[] executeParams = new CodeExpression[2];
			executeParams[0] = new CodeVariableReferenceExpression("request");
			executeParams[1] = new CodeVariableReferenceExpression("response");
			execute.Statements.Add(new CodeMethodInvokeExpression(new CodeMethodReferenceExpression(new CodeTypeReferenceExpression(typeof(RQL.RQLExecuteUtil)), "Execute"), executeParams));
			execute.Statements.Add(new CodeMethodReturnStatement(new CodeVariableReferenceExpression("response")));
			rqlClass.Members.Add(execute);
			
			WriteCode();
			//WriteSchema(schema);
		} //method GenerateCode();
			
		private CodeMemberProperty GenerateGenericProperty(string name, string field, string type)
		{
			CodeMemberProperty property = new CodeMemberProperty();
			property.Name = name;
			property.Type = new CodeTypeReference(type);
			property.Attributes = MemberAttributes.Public;
			property.GetStatements.Add(new CodeMethodReturnStatement( new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), field) ) );
			property.SetStatements.Add(new CodeAssignStatement( new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), field), 
                                    new CodePropertySetValueReferenceExpression()));
			return property;
		}
		
		private void ProcessTemporaryNamespace(CodeNamespace tempSpace, CodeTypeDeclaration housingClass)
		{
			housingClass.IsClass = true;
			housingClass.Attributes = MemberAttributes.Public;
			foreach (CodeTypeDeclaration clazz in tempSpace.Types)
			{
				foreach (CodeAttributeDeclaration attribute in clazz.CustomAttributes)
				{
					if (attribute.Name == "System.Xml.Serialization.XmlRootAttribute")
					{
						attribute.Arguments.Add(new CodeAttributeArgument("ElementName", new CodePrimitiveExpression(clazz.Name.ToUpper())));
					}
				}
				
				clazz.IsPartial = false;
//				clazz.Name = clazz.Name.Substring(0,1).ToUpper()+clazz.Name.Substring(1);
				foreach (CodeTypeMember member in clazz.Members)
				{
					if (member.GetType() == typeof(CodeMemberProperty))
					{
						CodeMemberProperty prop = (CodeMemberProperty)member;
						prop.Name = prop.Name.Substring(0,1).ToUpper()+prop.Name.Substring(1);
						
						foreach (CodeAttributeDeclaration attribute in prop.CustomAttributes)
						{
							if (attribute.Name == "System.Xml.Serialization.XmlElementAttribute")
							{
								attribute.Arguments.Add(new CodeAttributeArgument("ElementName", new CodePrimitiveExpression(prop.Name.ToUpper())));
							}
							else if (attribute.Name == "System.Xml.Serialization.XmlAttributeAttribute")
							{
								attribute.Arguments.Add(new CodeAttributeArgument("AttributeName", new CodePrimitiveExpression(prop.Name.ToLower())));
							}
							
						}
						
					} //if
//					else if (member.GetType() == typeof(CodeMemberField))
//					{
//						CodeMemberField field = (CodeMemberField)member;
//						field.Type = new CodeTypeReference(field.Type.
//					}
				} //foreach
				housingClass.Members.Add(clazz);
			} //foreach
		} //method ProcesTemporaryNamespace
		
		private XmlSchema GenerateSchemaForDocument(XmlDocument document)
		{	
			XmlSchemaSet schemas = new XmlSchemaSet();
			XmlSchemaInference infer = new XmlSchemaInference();
			infer.Occurrence = XmlSchemaInference.InferenceOption.Relaxed;
			infer.InferSchema(new XmlNodeReader(document), schemas);
			XmlSchema schema = null;
			foreach (XmlSchema s in schemas.Schemas()) {
				schema = s;
				break;
			} //foreach
			schema = OptimizeSchema(schema);
			return schema;
		} //method GenerateSchemaForDocument
		
		private CodeNamespace GenerateCodeForSchema(XmlSchema schema)
		{
			XmlSchemas schemas = new XmlSchemas();
			schemas.Add(schema);
			XmlSchemaImporter imp = new XmlSchemaImporter(schemas);
			CodeNamespace tempSpace = new CodeNamespace();
			XmlCodeExporter exp = new XmlCodeExporter(tempSpace);
			// Iterate schema items (top-level elements only) and generate code for each
			foreach (XmlSchemaObject item in schema.Items)
			{
			  if (item is XmlSchemaElement)
			  {
			    // Import the mapping first
			    XmlTypeMapping map = imp.ImportTypeMapping(new XmlQualifiedName(((XmlSchemaElement)item).Name, schema.TargetNamespace));
			    // Export the code finally
			    exp.ExportTypeMapping(map);
			  } //if
			} //foreach
			return tempSpace;
		} //method GenerateCodeForSchema
		
		private void WriteCode()
		{
			// Code generator to build code with.
			CodeDomProvider generator = new CSharpCodeProvider();
			
			// Generate untouched version
			using ( StreamWriter sw = new StreamWriter(outputDirectory.FullName+"\\"+codeNamespace.Name+"."+this.className+".cs", false ) )
			{
			  generator.GenerateCodeFromNamespace(codeNamespace, sw, new CodeGeneratorOptions());
			} //using
		} //method WriteCode()
		
		private void WriteSchema(XmlSchema schema)
		{
			StreamWriter writer = new StreamWriter(outputDirectory.FullName+"\\schema.xsd", false, System.Text.Encoding.ASCII);
			using (writer)
			{
				schema.Write(writer);
				//writer.WriteLine();
				//writer.WriteLine("<!--");
				//WriteSchemaObjectDebug(writer, newSchema, "");
				//writer.WriteLine("-->");
			} //using
		}
		
		private XmlSchema OptimizeSchema(XmlSchema schema)
		{
			SchemaOptimizer optimizer = new SchemaOptimizer();
			return optimizer.Optimize(schema);
		}
		
		/*
		private void OptimizeSchema(XmlSchema schema, XmlSchemaObject o)
		{
	        foreach (PropertyInfo property in o.GetType().GetProperties())
	        {
	        	if (property.PropertyType == typeof(XmlSchemaObjectCollection))
	            {
	                XmlSchemaObjectCollection childObjectCollection = (XmlSchemaObjectCollection)property.GetValue(o, null);
	                XmlSchemaObjectCollection copy = new XmlSchemaObjectCollection();
	                foreach (XmlSchemaObject schemaObject in childObjectCollection)
	                {
	                	copy.Add(schemaObject);
	                }
	                foreach (XmlSchemaObject schemaObject in copy)
	                {
	                	OptimizeSchema(schema, schemaObject);
	                }
	            }
	            else if (property.Name == "ElementType" || property.Name == "Particle")
	            {
	            	XmlSchemaObject o2 = (XmlSchemaObject)property.GetValue(o, null);
	            	if (o2 != null)
	            	{
	            		if (property.Name == "ElementType" && o2.GetType() == typeof(XmlSchemaComplexType))
	            		{
	            			XmlSchemaElement element = (XmlSchemaElement)o;
	            			XmlSchemaComplexType type = (XmlSchemaComplexType)o2;
	            			if (element.Name == "LOGIN")
	            			{
	            				type.Name = "LOGIN";
	            				schema.Items.Add(type);
	            				//element.ElementSchemaType = null;
	            				element.SchemaType = null;
	            				element.SchemaTypeName = new XmlQualifiedName("LOGIN", null);
	            			}
	            			
	            		}
	            		OptimizeSchema(schema, o2);
	            	}
	            }
	        }
		}
		
		private void WriteSchemaObjectDebug(StreamWriter writer, XmlSchemaObject o, string indentation)
		{
			writer.WriteLine("{0}{1}", indentation, o);
	        foreach (PropertyInfo property in o.GetType().GetProperties())
	        {
	        	if (property.PropertyType == typeof(XmlSchemaObjectCollection))
	            {
	                XmlSchemaObjectCollection childObjectCollection = (XmlSchemaObjectCollection)property.GetValue(o, null);
	                foreach (XmlSchemaObject schemaObject in childObjectCollection)
	                {
	                    WriteSchemaObjectDebug(writer, schemaObject, indentation + "\t");
	                }
	            }
	            else if (property.Name == "ElementSchemaType" || property.Name == "Particle")
	            {
	            	XmlSchemaObject o2 = (XmlSchemaObject)property.GetValue(o, null);
	            	if (o2 != null)
	            		WriteSchemaObjectDebug(writer, o2, indentation + "\t");
	            }
	        }
		}
		*/
		
	}
}
