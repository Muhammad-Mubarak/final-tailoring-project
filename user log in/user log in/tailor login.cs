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
    public partial class tailor_login : Form
    {
        public tailor_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myhost.Service1 myservice0 = new myhost.Service1();
            string username = textBox1.Text;
            string password = textBox2.Text;
            bool isfound;
            bool isfoundpass;
          myservice0.isvalid_tailor(username, password, out isfound, out isfoundpass);
            if(isfound == true && isfoundpass == true)
            {

                tailor_after_login new_form = new tailor_after_login();
                new_form.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
            
            
            

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tailor_signup new_form = new tailor_signup();
            this.Hide();
            new_form.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 new_form = new Form1();
            new_form.Show();
            this.Hide();


        }
    }
}
