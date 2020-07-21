using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiostamDesign
{
    public partial class PassVer : Form
    {
        public PassVer(string randomCode, string Email)
        {
            InitializeComponent();
            label8.Text = randomCode;
            label9.Text = Email;
        }

        private void PassVer_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            textBox2.Hide(); 
            textBox3.Hide();
            button1.Hide();
            //button2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {  
           //if (label8.Text == (textBox1.Text).ToString()) ;
           // {
                textBox2.Focus();
                label1.Show();
                label3.Show();
                label7.Show();
                textBox2.Show();
                textBox3.Show();
                button1.Show();
                button2.Show();
           // }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
