using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BiostamDesign
{
    public partial class StaffDashboard : Form
    {
        public StaffDashboard(Image IMAGE, string Fullname, string greet)
        {

            InitializeComponent();
            
            sidePanel.Height = button1.Height;
            sidePanel2.Height = button1.Height;
            sidePanel.Top = button1.Top;
            sidePanel2.Top = button1.Top;
            sessionPortal1.Visible = false;
            viewAtt1.Visible = false;
            studentRecord1.Visible = false;
            feedback1.Visible = false;
            examinationPortal1.Visible = false;
            // dashboard1.BringToFront();

            pictureBox4.Image = IMAGE;
            labelWelcom.Text = Fullname;
            label1.Text = greet;
            dashPic.Image = IMAGE;

            //labelWelcom.Text = Fullname;
            //pbxSession.Image = IMAGE;
        }


        private void button8_Click(object sender, EventArgs e)
        {
           
            PasswordChange PC = new PasswordChange();
            PC.Show();
        }

        private void StaffDashboard_Load(object sender, EventArgs e)
        {
            //Dashboard DAB = new Dashboard( IMAGE, Fullname);
            //DAB.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button4.Height;
            sidePanel2.Height = button4.Height;
            sidePanel.Top = button4.Top;
            sidePanel2.Top = button4.Top;
            sessionPortal1.Visible = true;
            examinationPortal1.Visible = false;
            sessionPortal1.BringToFront();
           // sessionPortal1.BringToFront();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button1.Height;
            sidePanel2.Height = button1.Height;
            sidePanel.Top = button1.Top;
            sidePanel2.Top = button1.Top;
            sessionPortal1.Visible = false;
            examinationPortal1.Visible = false;
            viewAtt1.Visible = false;
            studentRecord1.Visible = false;
            //dashboard1.BringToFront();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        
        }

        private void viewAtt1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button3.Height;
            sidePanel2.Height = button3.Height;
            sidePanel.Top = button3.Top;
            sidePanel2.Top = button3.Top;
            viewAtt1.Visible = true;
            viewAtt1.BringToFront();
            sessionPortal1.Visible = false;
            examinationPortal1.Visible = false;
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
            sessionPortal1.Visible = false;
            examinationPortal1.Visible = false;
            viewAtt1.Visible = false;
            studentRecord1.Visible = true;
            studentRecord1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button6.Height;
            sidePanel2.Height = button6.Height;
            sidePanel.Top = button6.Top;
            sidePanel2.Top = button6.Top;
            sessionPortal1.Visible = false;
            examinationPortal1.Visible = false;
            viewAtt1.Visible = false;
            studentRecord1.Visible = false;
            feedback1.Visible = true;
            feedback1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button5.Height;
            sidePanel2.Height = button5.Height;
            sidePanel.Top = button5.Top;
            sidePanel2.Top = button5.Top;
            sessionPortal1.Visible = false;
            viewAtt1.Visible = false;
            studentRecord1.Visible = false;
            feedback1.Visible = false;
            examinationPortal1.Visible = true;
            examinationPortal1.BringToFront();
        }

        private void examinationPortal1_Load(object sender, EventArgs e)
        {

        }

        private void feedback1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button4.Height;
            sidePanel2.Height = button4.Height;
            sidePanel.Top = button4.Top;
            sidePanel2.Top = button4.Top;
            sessionPortal1.Visible = true;
            examinationPortal1.Visible = false;
            sessionPortal1.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button2.Height;
            sidePanel2.Height = button2.Height;
            sidePanel.Top = button2.Top;
            sidePanel2.Top = button2.Top;
            sessionPortal1.Visible = false;
            examinationPortal1.Visible = false;
            viewAtt1.Visible = false;
            studentRecord1.Visible = true;
            studentRecord1.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            stmessage stm = new stmessage();
            stm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            spmessage spm = new spmessage();
            spm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            calattend calc = new calattend();
            calc.Show();
        }

        private void feedback1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
