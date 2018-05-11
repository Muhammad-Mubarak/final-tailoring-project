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
    public partial class Customer_Login : Form
    {
        public Customer_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = false;
            bool validS = false;
            myhost.Service1 ser = new myhost.Service1();
            ser.isValidCustomer(txtUserName.Text, txtPassword.Text, out valid, out validS);
            if(valid)
            {
                MessageBox.Show("Welcome!");
            } else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }
    }
}
