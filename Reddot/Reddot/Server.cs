using System;
using System.Collections.Generic;
using System.Text;

namespace Reddot
{
    class Server
    {
        private string _Username;
        private string _Password;

        RDCMSXMLServer.RDCMSXMLServer CMS;

        public Server()
        {
            CMS = new RDCMSXMLServer.RDCMSXMLServer();
        }

        public RQLResponse Request( RQLRequest Request )
        {
            Object Error = String.Empty;
            Object Info = String.Empty;

            string Response = CMS.Execute( Request.ToString(), ref Error, ref Info );

            if ( !String.IsNullOrEmpty( Error.ToString() ) )
            {
                throw new RQLException( Error );
            }

            return new RQLResponse( Response );
        }

        public bool Login( string Username, string Password )
        {
            _Username = Username;
            _Password = Password;

            try
            {
                Login LoginRequest = new Login( Username, Password );
                RQLResponse LoginResponse = Request( (RQLRequest)LoginRequest );

                

            }
            catch
            {
                return false;
            }

            return true;

            
        }

    }
}
