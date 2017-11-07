/*
 * Created by SharpDevelop.
 * User: Nick
 * Date: 2/22/2007
 * Time: 8:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Xml;
using System.Xml.Schema;
using System.Collections;

namespace RQLCodeGenUI
{
	/// <summary>
	/// Description of SchemaOptimizer.
	/// </summary>
	public class SchemaOptimizer
	{
		private XmlSchema oldSchema;
		private XmlSchema newSchema;
		private Hashtable newTypes;
		
		public SchemaOptimizer() {}
		
		public XmlSchema Optimize(XmlSchema oldSchema)
		{
			this.oldSchema = oldSchema;
			this.newSchema = new XmlSchema();
			this.newTypes = new Hashtable();
			
			XmlSchemaElement oldRootElement = null;
			foreach (XmlSchemaObject schemaObject in this.oldSchema.Items)
			{
				if (schemaObject.GetType() == typeof(XmlSchemaElement))
				{
					oldRootElement = (XmlSchemaElement)schemaObject;
					break;
				} //if
			} //foreach
			
			XmlSchemaElement newRootElement = Optimize(oldRootElement);
			
			this.newSchema.Items.Add(newRootElement);
			foreach (Object newType in this.newTypes.Values)
			{
				this.newSchema.Items.Add((XmlSchemaObject)newType);
			} //foreach
			
			XmlSchemaSet schemaSet = new XmlSchemaSet();
			schemaSet.Add(this.newSchema);
			schemaSet.Compile();
			
			return this.newSchema;
		}
		
		private XmlSchemaElement Optimize(XmlSchemaElement element)
		{
			XmlSchemaComplexType oldType = (XmlSchemaComplexType)element.ElementSchemaType;
			string typeName = GetTypeName(element);
			XmlSchemaComplexType newType = (XmlSchemaComplexType)newTypes[typeName];
			if (newType == null)
			{
				newType = new XmlSchemaComplexType();
				newType.Name = typeName;
				newTypes.Add(typeName, newType);
			} //if
			
			XmlSchemaElement newElement = new XmlSchemaElement();
			newElement.Name = element.Name.ToLower();
			//newElement.MinOccurs = 0;
			newElement.SchemaTypeName = new XmlQualifiedName(typeName);
			
			if (oldType.Particle != null)
			{
				XmlSchemaSequence particle = (XmlSchemaSequence)oldType.Particle;
				if (newType.Particle == null)
				{
					newType.Particle = new XmlSchemaAll();
				} //if
				foreach (XmlSchemaObject schemaObject in particle.Items)
				{
					if (schemaObject.GetType() == typeof(XmlSchemaElement))
					{
						//process the element to make sure its type is taken care of...
						XmlSchemaElement nextElement = Optimize((XmlSchemaElement)schemaObject);
						//but don't add it again if it's already in THIS type
						if (!ParticleContainsElement((XmlSchemaAll)newType.Particle, nextElement.Name))
						{
							((XmlSchemaAll)newType.Particle).Items.Add(nextElement);
						} //if
					} //if
				} //foreach
			} //if
			
			foreach (XmlSchemaObject schemaObject in oldType.Attributes)
			{
				if (schemaObject.GetType() == typeof(XmlSchemaAttribute))
				{
					XmlSchemaAttribute attribute = (XmlSchemaAttribute)schemaObject;
					if (!TypeContainsAttribute(newType, attribute.Name))
					{
						XmlSchemaAttribute newAttribute = new XmlSchemaAttribute();
						newAttribute.Name = attribute.Name;
						newAttribute.Use = XmlSchemaUse.Optional;
						newAttribute.SchemaTypeName = new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");
						newType.Attributes.Add(newAttribute);
					} //if
				} //if
			} //foreach
			
			return newElement;
		} //method Optimize
		
		private string GetTypeName(XmlSchemaElement element)
		{
			string lowerCase = element.Name.ToLower();
			return lowerCase.Substring(0,1)+lowerCase.Substring(1);
		} //method GetTypeName
		
		private bool ParticleContainsElement(XmlSchemaAll particle, string elementName)
		{
			foreach (XmlSchemaObject schemaObject in particle.Items)
			{
				if (schemaObject.GetType() == typeof(XmlSchemaElement))
				{
					XmlSchemaElement element = (XmlSchemaElement)schemaObject;
					if (element.Name == elementName)
					{
						return true;
					} //if
				} //if
			} //foreach
			
			return false;
		} //method ParticleContainsElement
		
		private bool TypeContainsAttribute(XmlSchemaComplexType type, string attributeName)
		{
			foreach (XmlSchemaObject schemaObject in type.Attributes)
			{
				if (schemaObject.GetType() == typeof(XmlSchemaAttribute))
				{
					XmlSchemaAttribute attribute = (XmlSchemaAttribute)schemaObject;
					if (attribute.Name == attributeName)
					{
						return true;
					} //if
				} //if
			} //foreach
			
			return false;
		} //method TypeContainsAttribute
	}
}
