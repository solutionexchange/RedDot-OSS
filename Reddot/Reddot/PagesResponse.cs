using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Reddot
{
    class PagesResponse: RQLResponse
    {


        public Page[] Page
        {
            get
            {
                XmlNodeList PageNodes = this.Dom.FirstChild.ChildNodes;

                Page[] Pages = new Page[PageNodes.Count];

                for ( int i = 0; i < PageNodes.Count; i++ )
                {
                    Pages[i] = new Page( PageNodes[i] );
                }

                return Pages;
            }
        }
    }
}
