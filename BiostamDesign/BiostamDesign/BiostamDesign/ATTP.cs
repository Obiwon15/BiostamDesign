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
    public partial class ATTP : Form
    {
        public ATTP(string fullname, string Number, string attendance, string total, Image picture)
        {

            InitializeComponent();
            label1.Text = fullname;
            label2.Text = Number;
            pictureBox1.Image = picture;

        }

        private void ATTP_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
