using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugBid_
{
    class LoginControl
    {
        public void submit(string uname, string password)
        {
            DateTime dt = new DateTime();
            DBConnector newGet = new DBConnector();
            User user = newGet.getUser(uname);
            newGet.saveLogin(uname, dt);
        
            //username and password validation
            //if(validation = true)
            //{

            //}

        }

        public bool validation(string uname)
        {

            return true;
        }
    }
}
