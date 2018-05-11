using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;


namespace user_log_in
{
    public partial class upload_form : Form
    {
        public string filepath;
        public upload_form()
        {
            InitializeComponent();
        }

      
       private void button1_Click(object sender, EventArgs e)
        {
            myhost.Service1 new_ser = new myhost.Service1();
            MemoryStream new_mem = new MemoryStream();

            // Image to send.
            Image image = Image.FromFile(this.filepath); // Get the selected image through file path.

            // Converting image to memory stream. 
            image.Save(new_mem, image.RawFormat);
            byte[] imageBytes = new_mem.ToArray();

            // Convert byte[] to Base64 String.
            string imgBase64 = Convert.ToBase64String(imageBytes);

            // Description.
            string description = richTextBox1.Text;

            MessageBox.Show(imgBase64 + " " + textBox1.Text + " " + richTextBox1.Text + " " + textBox3.Text + " " + textBox2.Text);
            // Sending to server.
            new_ser.add_design(imgBase64, textBox1.Text, description, textBox3.Text, textBox2.Text);
        } 

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                this.filepath = ofd.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tailor_login new_form = new tailor_login();
            new_form.Show();
            this.Hide();

        }
    }
}
