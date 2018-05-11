using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_log_in
{
    public partial class Customer_Signup : Form
    {
        public Customer_Signup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            myhost.Service1 ser = new myhost.Service1();
            ser.Customer_username(txtUsername.Text, txtPassword.Text, txtMobile.Text, txtAddress.Text, txtEmail.Text);
            MessageBox.Show("Customer Registered!");
        }
    }
}
