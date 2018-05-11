using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace user_log_in
{
    public partial class user_after_login : Form
    {
        public user_after_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 new_form = new Form1();
            new_form.Show();
            this.Hide();
         }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          /*  myhost.Service1 new_service = new myhost.Service1();
            myhost.design_data new_design = new myhost.design_data();

            new_service.get_design();
            List<myhost.design_data> new_designs = new List<myhost.design_data>();
            dataGridView1.DataSource = new_designs;
            */



           

            

            




            



        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            /* myhost.Service1 new_ser = new myhost.Service1();
              // List<myhost.design_data> new_data = new List<myhost.design_data>();
              /* dataGridView1.DataSource = new_ser.get_design();
               DataTable table = new DataTable();
               table.Columns.Add(dataGridView1.DataSource = new_ser.get_design());
               
            BindingSource new_bind = new BindingSource();
            new_bind.Add(new_ser.get_design());
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSize = true;
            dataGridView1.DataSource = new_bind;
            */



        }

        private void button2_Click(object sender, EventArgs e)
        {
            myhost.Service1 new_ser = new myhost.Service1();

            List<myhost.designs> temp = new List<myhost.designs>();
            temp = new_ser.get_design().Cast<myhost.designs>().ToList();

            //MessageBox.Show(temp[0].Name + " " + temp[0].Description); 


            dataGridView1.DataSource = temp;
            dataGridView1.Refresh();


            //BindingSource new_bind = new BindingSource();
            //new_bind.Add(temp);
            //dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.AutoSize = false;
            //dataGridView1.DataSource = new_bind;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            orders_s_form new_orders = new orders_s_form();
            new_orders.Show();
            this.Hide();

        }
    }
}
