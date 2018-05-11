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
    public partial class admin_adding_user : Form
    {
        public admin_adding_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myhost.Service1 myservice = new myhost.Service1();
            myservice.Customer_username(textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text);
            MessageBox.Show("User Registered");
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_after_login exisisting = new admin_after_login();
            exisisting.Show();
            this.Hide();

        }
    }
}
