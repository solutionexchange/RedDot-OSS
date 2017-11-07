using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace Reddot
{

    class RQLException: ApplicationException
    {
        private string _Response;

        public string Response
        {
            get { return _Response; }
            set { _Response = value; }
        }

        public RQLException( Object Error )
        {
            Response = Error.ToString();
        }
    }
}
