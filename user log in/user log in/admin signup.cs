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
    public partial class admin_signup : Form
    {
        public admin_signup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myhost.Service1 new_admin = new myhost.Service1();
            string username = textBox1.Text;
            string password = textBox2.Text;
            new_admin.admin_registration(username, password);

            MessageBox.Show("Admin Registered");
            Admin_login new_entry = new Admin_login();
            this.Hide();
            new_entry.Show();

        }
    }
}
