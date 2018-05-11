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
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_signup new_form2 = new admin_signup();
            new_form2.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            myhost.Service1 myser = new myhost.Service1();
            bool isfound;
            bool isfoundpass;
            myser.isvalid_admin(username, password, out isfound, out isfoundpass);
            if (isfound == false && isfoundpass == false)
            {
                MessageBox.Show("invalid admin");
            }
            else
            {
                admin_after_login new_admin = new admin_after_login();
                new_admin.Show();
                this.Hide();

            }
               
            
           
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 new_form = new Form1();
            new_form.Show();
            this.Hide();

        }
    }
}
