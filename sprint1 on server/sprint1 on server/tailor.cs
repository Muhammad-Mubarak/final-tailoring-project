using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sprint1_on_server
{
    public class tailor
    {
        private string name;
        private string password;
        private string address;
        private string mob;
        private string email;
        private string cnic;

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

        public string Mob
        {
            get
            {
                return mob;
            }

            set
            {
                mob = value;
            }
        }

       

       
        

        public string Cnic
        {
            get
            {
                return cnic;
            }

            set
            {
                cnic = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
    }
}