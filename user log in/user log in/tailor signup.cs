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
    public partial class tailor_signup : Form
    {
        public tailor_signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myhost.Service1 myservice2 = new myhost.Service1();
            myservice2.tailor_registrattion(textBox1.Text, textBox2.Text, textBox3.Text,textBox4.Text , textBox5.Text);
            MessageBox.Show("Tailor Registered");
            tailor_login new_form = new tailor_login();
            new_form.Show();
            this.Hide();
        }
    }
}
