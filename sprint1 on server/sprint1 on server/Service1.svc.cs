using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Collections;


namespace sprint1_on_server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool isvalid(string username, string password)
        {
            bool flag_1 = false;
            foreach (customer customer_check in customerdata.data_customer)
            {
                if (customer_check.Username == username && customer_check.Password == password)
                {
                    flag_1 = true;
                    return flag_1;
                }

            }
            return flag_1;
        }
        

        public void Customer_username(string username, string password, string mobile, string address, string email)
        {
            customer new_entry = new customer();
            new_entry.Username = username;
            new_entry.Password = password;
            new_entry.Mobile = mobile;
            new_entry.Address = address;
            new_entry.Email = email;
            customerdata.data_customer.Add(new_entry);
        }
       

        public bool isvalid_tailor(string name,string password)
        {
            bool flag_2 = false;
            foreach(tailor check_tailor in tailordata.new_tailor)
            {
                if(check_tailor.Name == name && check_tailor.Password == password)
                {
                    flag_2 = true;
                    
                    return flag_2;
                    
                }

            }

            return flag_2;
        }

        public void tailor_registrattion(string name, string password, string address, string mobile, string cnic)
        {
            tailor new_entry = new tailor();
            new_entry.Name = name;
            new_entry.Password = password;
            new_entry.Mob = mobile;
  
            new_entry.Address = address;
            new_entry.Cnic = cnic;
            tailordata.new_tailor.Add(new_entry);

            
        }


        public void admin_registration(string name, string password)
        {
            admin new_entry = new admin();
            new_entry.Name = name;
            new_entry.Password = password;
            admin_reg.new_admin.Add(new_entry);
            
        }

        public bool isvalid_admin(string name,string password)
        {
            bool flag_3 = false;
            foreach(admin entry_new in admin_reg.new_admin)
            {
                if(entry_new.Name == name && entry_new.Password == password)
                {
                    flag_3 = true;
                    return flag_3;
                    
                }
            }
            return flag_3;
        }

        public void add_design(string picture, string name, string description, string price, string category)
        {
            designs new_design = new designs();
            new_design.Picture = picture;
            new_design.Name = name;
            new_design.Description = description;
            new_design.Gender = category;
            new_design.Price = Int32.Parse(price);
            design_data.new_design.Add(new_design);

        }
       /* public design_data get_name_of_product()
        {
            int index = 1;
            design_data get_name = new design_data();
            string name = (string)design_data.new_design[index];
            get_name.Equals(name);
            return get_name;


            reu= design_data.
        }*/

        /*public design_data get_description()
        {
            int index = 2;
            design_data get_description = new design_data();
            string  description = (string)design_data.new_design[index];
            get_description.Equals(description);
            return get_description;

        }*/

        public List<designs> get_design()
        {

            
            // design_data exisisting_entry = new design_data();
            //List<design_data> list = new List<design_data>();
            List<designs> list = design_data.new_design.Cast<designs>().ToList();


            return list;
         }


       public List<customer> get_customer()
        {
            List<customer> list_customerr = customerdata.data_customer.Cast<customer>().ToList();
            return list_customerr;
        }


        public List<tailor> get_tailor()
        {
            List<tailor> list_tailor = tailordata.new_tailor.Cast<tailor>().ToList();
            return list_tailor;
        }

        public void get_order(string name, string customer_name, string mobile)
        {
            order_data new_order = new order_data();
            new_order.Customer_name = customer_name;
            new_order.Design_name1 = name;
            new_order.Mobile = Int32.Parse(mobile);
            orders.List_orders.Add(new_order);

            
        }

       public List<order_data> order_tailor()
        {
            /* orders existing_order = new orders();
             List<orders> orderss = new List<orders>();
             orderss.Add(existing_order);
             return orderss; */


            List<order_data> list_1 = orders.List_orders.Cast<order_data>().ToList();
            return list_1;

        }

        public bool isValidCustomer(string username, string password)
        {
            foreach(customer c in customerdata.data_customer)
            {
                if(c.Username == username && c.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
    }

