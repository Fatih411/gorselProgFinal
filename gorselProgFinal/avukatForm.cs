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
    public partial class avukatForm : Form
    {
        public avukatForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "" || dateTimePicker1.Text == "")
            {
                label5.Text = "Tüm Bilgileri Giriniz!";
            }
            else
            {
                
                listBox1.Items.Add(comboBox1.Text + ", " + textBox1.Text + "TL" + ",  " + textBox2.Text.ToUpper() + ", " + dateTimePicker1.Text);
               
                int kalanDay = dateTimePicker1.Value.Day - DateTime.Now.Day;
                if (kalanDay <= 7)
                {
                    listBox2.Items.Add(comboBox1.Text + ", " + textBox1.Text + "TL" + ",  " + textBox2.Text.ToUpper() + ", " + dateTimePicker1.Text);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != 0)
            {
              
                 listBox1.Items.Remove(listBox1.SelectedItem);
            }
               
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != 0)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
           button3.BackColor= Color.LightGray;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGray;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }
        public string labelText = "";
        private void avukatForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Hoşgeldiniz " + labelText;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
