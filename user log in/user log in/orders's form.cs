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
    public partial class orders_s_form : Form
    {
        public orders_s_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customer_name = textBox2.Text;
            string design_name = textBox1.Text;
            string mobile_no = textBox3.Text;
            MessageBox.Show(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text  );
            myhost.Service1 new_order = new myhost.Service1();
            new_order.get_order(design_name, customer_name, mobile_no);
            MessageBox.Show("Order Placed");


        }
    }
}
