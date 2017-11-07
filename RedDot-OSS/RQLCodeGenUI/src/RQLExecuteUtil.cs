/*
 * Created by SharpDevelop.
 * User: Nick
 * Date: 2/22/2007
 * Time: 3:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections;

namespace RQL
{
	/// <summary>
	/// Description of RQLBase.
	/// </summary>
	public class RQLExecuteUtil
	{
		private static Hashtable propertyInfoMap = new Hashtable();
		
		public static void Execute(RQLRequestBase request, RQLResponseBase response)
		{
			
			PropertyInfo requestProp = (PropertyInfo)propertyInfoMap[request.GetType().ToString()];
			if (requestProp == null)
			{
				requestProp = request.GetType().GetProperty("Data");
				propertyInfoMap[request.GetType().ToString()] = requestProp;
			} //if
			
			PropertyInfo responseProp = (PropertyInfo)propertyInfoMap[response.GetType().ToString()];
			if (responseProp == null)
			{
				responseProp = response.GetType().GetProperty("Data");
				propertyInfoMap[response.GetType().ToString()] = responseProp;
			} //if
			
			XmlSerializer serializer = new XmlSerializer(requestProp.PropertyType);
			//remove namespace declarations in root node
			XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
			ns.Add("", ""); 
			StringWriter sw = new StringWriter();
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.OmitXmlDeclaration = true;
			settings.Indent = false;
			XmlWriter xmlWriter = XmlWriter.Create(sw, settings);
			serializer.Serialize(xmlWriter, requestProp.GetValue(request, null), ns);
			String requestStr = sw.ToString();
			
			object error = String.Empty;
			object info = String.Empty;
			RDCMSXMLServer rql = new RDCMSXMLServer();
			string responseStr = rql.Execute(requestStr, ref error, ref info);
			
			if (responseStr.Length > 0)
			{
				serializer = new XmlSerializer(responseProp.PropertyType);
				responseProp.SetValue(response, serializer.Deserialize(new StringReader(responseStr)), null);
			}
			response.RqlError = (string)error;
			response.RqlInfo = (string)info;
		}
	}
}
