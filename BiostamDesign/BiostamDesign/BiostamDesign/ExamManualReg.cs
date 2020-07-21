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

namespace BiostamDesign
{
    public partial class ExamManualReg : Form
    {
        public ExamManualReg(string label)
        {
            InitializeComponent();
            label6.Text = label;
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");
        private void ExamManualReg_Load(object sender, EventArgs e)
        {

            button3.Hide();
           // label6.Hide();
            label3.Hide();
            label4.Hide();
            picBox.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "SELECT * FROM Student_db WHERE Student_RegNo = '" + txtReg.Text.Trim() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);

            if (dtb.Rows.Count == 1)
            {
                label2.Text = "Hello  " + dtb.Rows[0]["Student_Fullname"].ToString();
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                picBox.Image = Image.FromFile(paths + dtb.Rows[0]["SImagePath"].ToString());
                picBox.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label1.Text = "     We Apologize once Again For any incovenience";
                label4.Text = "     Please Click Below To Confirm Your Attendance";
                label5.Hide();
                label1.Hide();
                //txtSession.Hide();
                txtReg.Hide();
                button1.Hide();
                button2.Hide();
                button3.Show();
            }
            else
            {
                MessageBox.Show("Registration Number Not Recognized!");
            }


            sqlcon.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            string query = "SELECT * FROM Total_Attendance_db WHERE Student_RegNo ='" + txtReg.Text.Trim() + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);
            sqlcon.Close();



            if (dtb.Rows.Count > 0)
            {
                //sqlcon.Open();
                //string name = label6.Text;
                //SqlCommand cmd = new SqlCommand();
                //cmd = new SqlCommand("UPDATE EXamination_db set " + name + " = '1' WHERE Student_RegNo = '" + txtReg.Text.Trim() + "'", sqlcon);
                //cmd.ExecuteNonQuery();
                //sqlcon.Close();
                //MessageBox.Show("Attendance Recorded");






                string fullname = dtb.Rows[0]["Student_Fullname"].ToString();
                string Number = dtb.Rows[0]["Student_RegNo"].ToString();
                string attendance = dtb.Rows[0]["Percentage"].ToString();
                string total = dtb.Rows[0]["Total"].ToString();


                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                picBox.Image = Image.FromFile(paths + dtb.Rows[0]["SImagePath"].ToString());

                Image picture = picBox.Image;
                StudentPopup stp = new StudentPopup(fullname, Number, attendance, total, picture, label6.Text);
                stp.Show();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
