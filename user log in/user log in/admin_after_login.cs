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
    public partial class admin_after_login : Form
    {
        public admin_after_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_login new_form = new Admin_login();
            new_form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myhost.Service1 new_ser = new myhost.Service1();

            List<myhost.customer> temp = new List<myhost.customer>();
            temp = new_ser.get_customer().Cast<myhost.customer>().ToList();


            //MessageBox.Show(temp[0].Name + " " + temp[0].Description); 


            dataGridView1.DataSource = temp;
            dataGridView1.Refresh();



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_adding_user new_entry = new admin_adding_user();
            new_entry.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adding_tailor_by_admin new_tailor = new adding_tailor_by_admin();
            new_tailor.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tatilor_by_admin new_form = new tatilor_by_admin();
            new_form.Show();
            this.Hide();


        }
    }
}
