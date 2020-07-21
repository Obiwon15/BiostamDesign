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
    public partial class SessionPortal : UserControl
    {
        public SessionPortal()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Sess_text.Text != "" && Duration.Text != "")
            {
                sqlcon.Open();
                string query = "INSERT INTO Session_db (Session_Name, Date_Time,Course,Duration) VALUES ('" + Sess_text.Text + "', '" + date.Text + "', '" + textCourse.Text + "', '" + Duration.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
                SDA.SelectCommand.ExecuteNonQuery();
                sqlcon.Close();
                txtAlert.Text = "Session Details Stored Successfully.";
                txtAlert.Show();
            }
            else
            {
                txtAlert.ForeColor = Color.Red;
                txtAlert.Text = "We Think Something Went Wrong. Please Try Again.";
                txtAlert.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string SqlCommand = "INSERT INTO Session_db (Session_Name, Date_Time,Course,Duration) VALUES ('" + Sess_text.Text + "', '" + date.Text + "', '" + textCourse.Text + "', '" + Duration.Text + "')";
                // SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
                // SDA.SelectCommand.ExecuteNonQuery();
                string colName = Sess_text.Text;
                string query = "ALTER TABLE Total_Attendance_db ADD " + colName + " INT";
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
                string SessName = Sess_text.Text;
                string DuraName = Duration.Text;
                Attendance ATT = new Attendance(CourseName + " Attendance Enrollment.", "Session Name: " + SessName, "Class Duration: " + DuraName, SessName);
                ATT.Show();
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
    }
}
