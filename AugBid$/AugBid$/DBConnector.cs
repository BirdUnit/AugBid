using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugBid_
{
    class DBConnector
    {
        public User getUser(string uname)
        {      
            //select username and password from database

            User user = new AugBid_.User("", "");
            return user;
        }

        public void saveLogin(string uname, DateTime time)
        {
            //save login to database
        }

    }
}
