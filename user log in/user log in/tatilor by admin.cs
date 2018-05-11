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
    public partial class tatilor_by_admin : Form
    {
        public tatilor_by_admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myhost.Service1 new_ser = new myhost.Service1();

            List<myhost.tailor> temp = new List<myhost.tailor>();
            temp = new_ser.get_tailor().Cast<myhost.tailor>().ToList();

            //MessageBox.Show(temp[0].Name + " " + temp[0].Description); 


            dataGridView1.DataSource = temp;
            dataGridView1.Refresh();
        }
    }
}
