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
    public partial class registration_user : Form
    {
        public registration_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myhost.Service1 myservice = new myhost.Service1();
            myservice.Customer_username(textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text);
            MessageBox.Show("User Registered");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 confirm_user = new Form1();
            confirm_user.Show();
            this.Hide();
        }
    }
}
