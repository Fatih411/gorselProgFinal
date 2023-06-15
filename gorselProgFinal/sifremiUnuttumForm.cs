using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselProgFinal
{
    public partial class sifremiUnuttumForm : Form
    {
        public sifremiUnuttumForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "123"&&textBox1.Text.Length>10)
            {
                groupBox1.Enabled= true;
                label5.Text = "";
                
            }
            else
            {
                label5.Text = "mail adresiniz 10 karakterden oluşmalıdır";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text)
            {
                label6.Text = "Şifreniz başarılı bir şekilde değiştirildi.";
            }
            else
            {
                label6.Text = "Şifreleri aynı giriniz!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
