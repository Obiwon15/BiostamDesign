using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BiostamDesign
{
    public partial class ExaminationPortal : UserControl
    {
        public ExaminationPortal()
        {
            InitializeComponent();
        }


         

            SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

            private void button3_Click(object sender, EventArgs e)
            {
                //if ( Duration.Text != "")
                //{
                //    sqlcon.Open();
                //    string query = "INSERT INTO Exam_db ( Date_Time,Course,Duration) VALUES ('" + date.Text + "', '" + textCourse.Text + "', '" + Duration.Text + "')";
                //    SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
                //    SDA.SelectCommand.ExecuteNonQuery();
                //    sqlcon.Close();
                //    txtAlert.Text = "Session Details Stored Successfully.";
                //    txtAlert.Show();
                //}
                //else
                //{
                //    txtAlert.ForeColor = Color.Red;
                //    txtAlert.Text = "We Think Something Went Wrong. Please Try Again.";
                //    txtAlert.Show();
                //}
            }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string colName = textCourse.Text;
                string query = "ALTER TABLE Examination_db ADD " + colName + " INT";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
                // SDA.SelectCommand.ExecuteNonQuery();
                DataTable dtb = new DataTable();
                SDA.Fill(dtb);

                // Sess_text.Clear();
                // textCourse.Clear();
                MessageBox.Show("SESSION ADDED SUCCESSFULLY");
                sqlcon.Close();

                this.Hide();
                string CourseName = textCourse.Text;
                //string SessName = Sess_text.Text;
                string DuraName = Duration.Text;
                Examination EXA = new Examination(CourseName + " Attendance Enrollment.","Class Duration: " + DuraName, textCourse.Text);
                EXA.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

            private void button2_Click(object sender, EventArgs e)
            {
                this.Hide();

            }

            private void SessionPortal_Load(object sender, EventArgs e)
            {
                txtAlert.Hide();
            }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ExaminationPortal_Load(object sender, EventArgs e)
        {
            txtAlert.Hide();
        }
    }
    }



