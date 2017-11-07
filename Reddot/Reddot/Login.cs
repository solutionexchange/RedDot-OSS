using System;
using System.Collections.Generic;
using System.Text;

namespace Reddot
{
    class Login: RQLRequest
    {
        private string _Username;
        private string _Password;

        public Login( string Username, string Password )
        {
            _Username = Username;
            _Password = Password;

            
                        
        }
    }
}
