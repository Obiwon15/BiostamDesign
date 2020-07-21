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
    public partial class calattend : Form
    {
        public calattend()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");
        // string imglocation = "";
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Session_db";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);
            label1.Text = dtb.Rows[0]["Session_Name"].ToString();
            label2.Text = dtb.Rows[1]["Session_Name"].ToString();
            label3.Text = dtb.Rows[2]["Session_Name"].ToString();
            label4.Text = dtb.Rows[3]["Session_Name"].ToString();
            label6.Text = dtb.Rows[4]["Session_Name"].ToString();
            label7.Text = dtb.Rows[5]["Session_Name"].ToString();
            label8.Text = dtb.Rows[6]["Session_Name"].ToString();
            label9.Text = dtb.Rows[7]["Session_Name"].ToString();
            label10.Text = dtb.Rows[8]["Session_Name"].ToString();
            label11.Text = dtb.Rows[9]["Session_Name"].ToString();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();

        }

        private void calattend_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINGERPRINTdbDataSet6.Total_Attendance_db' table. You can move, or remove it, as needed.
            this.total_Attendance_dbTableAdapter.Fill(this.fINGERPRINTdbDataSet6.Total_Attendance_db);
            // TODO: This line of code loads data into the 'fINGERPRINTdbDataSet5.Total_Attendance_db' table. You can move, or remove it, as needed.

            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string name = label6.Text;
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("UPDATE Total_Attendance_db set Total1 = (" + label1.Text + " + " + label2.Text + " + " + label3.Text + " + " + label4.Text + " + " + label6.Text + " + " + label7.Text + " + " + label8.Text + " + " + label9.Text + " + " + label10.Text + " + " + label11.Text + ")", sqlcon);

            int N = cmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Total Calculated");
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Total_Attendance_db WHERE Student_Fullname LIKE '%" + keyword + "%' OR Student_RegNo LIKE '%" + keyword + "%'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string name = label6.Text;
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("UPDATE Total_Attendance_db set Percentage1 = ((CAST((" + label1.Text + " + " + label2.Text + " + " + label3.Text + " + " + label4.Text + " + " + label6.Text + " + " + label7.Text + " + " + label8.Text + " + " + label9.Text + " + " + label10.Text + " + " + label11.Text + ")AS FLOAT)/10)*100)", sqlcon);

            int N = cmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Total Calculated");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            calattend calc = new calattend();

            calc.Show();
                

        }
    }
}
