using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.IO;

namespace BiostamDesign
{
    public partial class StudentPopup : Form
    {
        public StudentPopup(string fullname, string Number, string attendance, string total, Image picture, string course)
        {

            InitializeComponent();
            //this.picture = picture;

            label2.Text = course;
            label1.Text = fullname + "'s  Details";
            labelFullname.Text = fullname;
            labelRegNo.Text = Number;

            labelAtt.Text = attendance;
            label6.Text = total;
           

            picBox.Image = picture;
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        void mypic() {
         
            string query = "SELECT * FROM Student_db WHERE Student_RegNo = '" + labelRegNo.Text.Trim() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);
            sqlcon.Open();
            if (dtb.Rows.Count == 1)
            {


                //string Email = dtb.Rows[0]["Student_Email"].ToString();
                labelGe.Text = dtb.Rows[0]["Sponsor_Email"].ToString();
                labelGp.Text = dtb.Rows[0]["Sponsor_Mobile"].ToString();

                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                picBox.Image = Image.FromFile(paths + dtb.Rows[0]["SImagePath"].ToString());

            }
        }

        private void StudentPopup_Load(object sender, EventArgs e)
        {

            mypic();
            double m = Convert.ToInt32(labelAtt.Text);
            if ( m > 60)
            {
                //sqlcon.Open();
                string name = label2.Text;
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("UPDATE EXamination_db set " + name + " = '1' WHERE Student_RegNo = '" + labelRegNo.Text.Trim() + "'", sqlcon);
                cmd.ExecuteNonQuery();
                //  sqlcon.Close();
                //MessageBox.Show("Attendance Recorded");
                labelAtt.ForeColor = Color.Green;
                labelAtt.Text = labelAtt.Text + "!";
                label3.Text = "Attendance Successfully Recorded. We Wish You Examination Success!";
                label3.ForeColor = Color.Green;
               // label5.ForeColor = Color.Green;
            }
            else
            {
                labelAtt.ForeColor = Color.Red;
                labelAtt.Text = labelAtt.Text + "!";
                label3.Text = "Sorry. Due to Low Attendance Rate, You are Not Eligible for this Exam!";
                label3.ForeColor = Color.Red;
               // label3.Show();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void labelAtt_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
   }
    

