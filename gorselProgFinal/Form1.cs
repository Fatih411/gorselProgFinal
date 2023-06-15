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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }  Users gb = new Users();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*string userName = "fatih";
        string password = "12345";*/
        public string newName;
        public string newPass;

        private void button1_Click(object sender, EventArgs e)
        {
            Users gb = new Users();
           
            if (textBox1.Text ==  gb.username&& textBox2.Text == gb.password || textBox1.Text == newName && textBox2.Text == newPass)
            {
                //yapılacak işlemlere yönlendir;
                avukatForm frm = new avukatForm();
                frm.labelText = textBox1.Text;
                frm.ShowDialog();
               
            }
            else
                label3.Text = "Kullanıcı adı veya Sifre yanlış";

            Console.WriteLine(newName+ ", " + newPass);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor= SystemColors.ControlDark;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ControlLight;
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremiUnuttumForm sifreFrm = new sifremiUnuttumForm();
            sifreFrm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayitolForm kytfrm= new kayitolForm();
            kytfrm.Show();
            this.Hide();
            
        }
    }
}
