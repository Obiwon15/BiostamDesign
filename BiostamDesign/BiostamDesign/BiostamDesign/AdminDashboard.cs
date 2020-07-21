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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            sidePanel.Height = button1.Height;
            sidePanel2.Height = button1.Height;
            sidePanel.Top = button1.Top;
            sidePanel2.Top = button1.Top;
            lecturerRegister1.Visible = false;
            lecturerDetails1.Visible = false;
            adminRegister1.Visible = false;
            //studentsDetails1.Visible = false;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void studentRecord1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentRegister STR = new studentRegister();
            STR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button1.Height;
            sidePanel2.Height = button1.Height;
            sidePanel.Top = button1.Top;
            sidePanel2.Top = button1.Top;
            lecturerRegister1.Visible = false;
            lecturerDetails1.Visible = false;
            //studentsDetails1.Visible = false;



            // aDashboard1.BringToFront();
        }

        private void aDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button2.Height;
            sidePanel2.Height = button2.Height;
            sidePanel.Top = button2.Top;
            sidePanel2.Top = button2.Top;
            lecturerDetails1.Visible = true;
            adminRegister1.Visible = false;
            lecturerDetails1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button5.Height;
            sidePanel2.Height = button5.Height;
            sidePanel.Top = button5.Top;
            sidePanel2.Top = button5.Top;
            //studentsDetails1.Visible = true;
            //studentsDetails1.BringToFront();
            
            studentsDetails STD = new studentsDetails();
            this.Hide();
            STD.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button4.Height;
            sidePanel2.Height = button4.Height;
            sidePanel.Top = button4.Top;
            sidePanel2.Top = button4.Top;
            lecturerRegister1.Visible = true;
            adminRegister1.Visible = false;
            lecturerRegister1.BringToFront();
            
        }

        private void lecturerDetails1_Load(object sender, EventArgs e)
        {
         
        }

        private void lecturerRegister1_Load(object sender, EventArgs e)
        {

        }

        private void lecturerRegister1_Load_1(object sender, EventArgs e)
        {

        }

        private void lecturerDetails1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button16.Height;
            sidePanel2.Height = button16.Height;
            sidePanel.Top = button16.Top;
            sidePanel2.Top = button16.Top;
            adminRegister1.Visible = true;
            lecturerDetails1.Visible = false;
            lecturerRegister1.Visible = false;
            adminRegister1.BringToFront();
        }
    }
}
