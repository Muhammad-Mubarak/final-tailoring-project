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
    public partial class orders_to_tailors : Form
    {
        public orders_to_tailors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*   myhost.Service1 new_service_bind = new myhost.Service1();
               BindingSource new_binding = new BindingSource();
               new_binding.Add(new_service_bind.order_tailor());
              dataGridView1.DataSource = new_binding;
              */


            myhost.Service1 new_ser = new myhost.Service1();

            List<myhost.order_data> temp = new List<myhost.order_data>();
            temp =new_ser.order_tailor().Cast<myhost.order_data>().ToList();

            //MessageBox.Show(temp[0].Name + " " + temp[0].Description); 


            dataGridView1.DataSource = temp;
            dataGridView1.Refresh();



        }
    }
}
