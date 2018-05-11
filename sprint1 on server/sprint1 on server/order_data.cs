using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sprint1_on_server
{
    public class order_data
    {
        private string customer_name;
        private string Design_name;
        private int mobile;

        public string Customer_name
        {
            get
            {
                return customer_name;
            }

            set
            {
                customer_name = value;
            }
        }

        public string Design_name1
        {
            get
            {
                return Design_name;
            }

            set
            {
                Design_name = value;
            }
        }

        public int Mobile
        {
            get
            {
                return mobile;
            }

            set
            {
                mobile = value;
            }
        }
    }
}