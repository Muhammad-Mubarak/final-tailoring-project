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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void Customer_username(string username, string password, string mobile, string address, string email);
        [OperationContract]
        bool isvalid(string username, string password);
        string GetData(int value);

        [OperationContract]
        bool isvalid_tailor(string name, string password);
        [OperationContract]
        void tailor_registrattion(string name, string password, string address, string mobile, string cnic);

        [OperationContract]
        void admin_registration(string name, string password);

        [OperationContract]

        bool isvalid_admin(string name, string password);
        [OperationContract]


        CompositeType GetDataUsingDataContract(CompositeType composite);
        [OperationContract]
        void add_design(string picture, string name, string description,string price, string category);

        [OperationContract]
        /* design_data get_name_of_product();

         [OperationContract]

         design_data get_description(); */

        List<designs> get_design();

        [OperationContract]
        List<customer> get_customer();

        [OperationContract]

        List<tailor> get_tailor();

        [OperationContract]
        void get_order(string name, string customer_name, string mobile);

        [OperationContract]
        List<order_data> order_tailor();
        
        




        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
