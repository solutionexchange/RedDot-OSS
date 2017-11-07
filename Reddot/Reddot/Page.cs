using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Reddot
{
    class Page
    {
        private string _Guid;

        public string Guid
        {
            get { return _Guid; }
            set { _Guid = value; }
        }

        public Page( XmlNode Node )
        {
            Guid = Node.Attributes["guid"].Value.ToString();
        }
    }
}
