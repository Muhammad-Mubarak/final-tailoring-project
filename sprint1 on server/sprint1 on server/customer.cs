using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sprint1_on_server
{
    public class customer
    {
        private string username;
        private string password;
        private string mobile;
        private string address;
        private string email;
        


        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
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

        public string Mobile
        {
            get
            {
                return  mobile;
            }

            set
            {
                mobile = value;
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
    }
}