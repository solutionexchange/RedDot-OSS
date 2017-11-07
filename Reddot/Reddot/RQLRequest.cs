using System.Collections.Generic;
using System.Text;
using System.Xml;
using Reddot.RDCMSXMLServer;

namespace Reddot
{
    class RQLRequest
    {
        public XmlDocument Dom;

        public RQLRequest()
        {
            Dom = new XmlDocument();


        }



        public override string ToString()
        {
            return "<IODATA>" + Dom.ToString() + "</IODATA>";
        }



    }
}
