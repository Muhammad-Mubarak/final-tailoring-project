using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// this form is user's form;

namespace user_log_in
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string passsword = textBox2.Text;
            myhost.Service1 myservice = new myhost.Service1();
            bool isfound;
            bool isfoundpass;
             myservice.isvalid(username, passsword,out isfound,out isfoundpass);
            if(isfound == true && isfoundpass == true)
            {
                MessageBox.Show("Valid_user");
                user_after_login new_user = new user_after_login();
                new_user.Show();
                this.Hide();
                

            }
            else
            {
                MessageBox.Show("Invalid User");
            }

             //myservice.isvalid(username, passsword, out isfound, out isfoundpass);
            //MessageBox.Show("Valid");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registration_user new_user = new registration_user();
            this.Hide();
            new_user.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tailor_login entry = new tailor_login();
            this.Hide();
            entry.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_login entry_admin = new Admin_login();
            this.Hide();
            entry_admin.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Signup c = new Customer_Signup();
            c.Show();
            this.Hide();
        }
    }
}
