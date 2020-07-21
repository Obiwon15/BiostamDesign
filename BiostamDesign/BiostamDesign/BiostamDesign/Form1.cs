using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BiostamDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(loading));
            t.Start();

            InitializeComponent();

            for (int i = 0; i <= 400; i++)
                Thread.Sleep(4);
            t.Abort();

                
            sidePanel.Height = button1.Height;
            sidePanel2.Height = button1.Height;
            sidePanel.Top = button1.Top;
            sidePanel2.Top = button1.Top;
            homeControl1.BringToFront();

        }
        void loading()
        {
            Splash1 SPL = new Splash1();
            Application.Run(SPL);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button3.Height;
            sidePanel2.Height = button3.Height;
            sidePanel.Top = button3.Top;
            sidePanel2.Top = button3.Top;
           adminLogin1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button1.Height;
            sidePanel2.Height = button1.Height;
            sidePanel.Top = button1.Top;
            sidePanel2.Top = button1.Top;
            homeControl1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button4.Height;
            sidePanel2.Height = button4.Height;
            sidePanel.Top = button4.Top;
            sidePanel2.Top = button4.Top;
            firstControl1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void firstControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void adminLogin1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //vScrollBar1.Maximum = 100;
            //vScrollBar1.Minimum = 0;
            //vScrollBar1.Value = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button6.Height;
            sidePanel2.Height = button6.Height;
            sidePanel.Top = button6.Top;
            sidePanel2.Top = button6.Top;
           feedback2.BringToFront();
            //this.Hide();
            //AdminDashboard ADB = new AdminDashboard();
            //ADB.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void studentRecord1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button2.Height;
            sidePanel2.Height = button2.Height;
            sidePanel.Top = button2.Top;
            sidePanel2.Top = button2.Top;
           viewAtt1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button5.Height;
            sidePanel2.Height = button5.Height;
            sidePanel.Top = button5.Top;
            sidePanel2.Top = button5.Top;
            examLogin1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void feedback2_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 FRM = new Form1();
            FRM.Show();
        }
    }
}
