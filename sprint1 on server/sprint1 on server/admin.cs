using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sprint1_on_server
{
    public class admin
    {
        private string name;
        private string password;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}