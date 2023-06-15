using System;
using System.Windows.Forms;

namespace gorselProgFinal
{
    public partial class kayitolForm : Form
    {
        public kayitolForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.PasswordChar = '\0';
            }
            else
            {
                textBox4.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm= new Form1();
            frm.newName= textBox1.Text;
            frm.newPass = textBox4.Text;
            label6.Text = "Kayıt Başarılı";
            frm.ShowDialog();
            this.Hide();
        }
    }
}
