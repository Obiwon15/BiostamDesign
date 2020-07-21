using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace BiostamDesign
{
    public partial class StudentRecord : UserControl
    {
        public StudentRecord()
        {
            InitializeComponent();
        }
        //public Image byteArraytoImage(byte[] byteArrayIn)
        //{
        //    MemoryStream MS = new MemoryStream(byteArrayIn);
        //    Image returnImage = Image.FromStream(MS, true);
        //    return returnImage;
        //}

        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void StudentAttendance_Load(object sender, EventArgs e)
        {
            //  vScrollBar1.Maximum = 100;
            //vScrollBar1.Minimum = 0;

            //vScrollBar1.Value = 0;

            label4.Hide();
            label6.Hide();

            label8.Hide();
            label9.Hide();
            label10.Hide();
            label13.Hide();
            label14.Hide();
            labelFullname.Hide();
            labelRegNo.Hide();
            labelAtt.Hide();
            labelGe.Hide();
            labelGp.Hide();
            textBox1.Focus();
            label7.Hide();
            label12.Hide();
            label15.Hide();
            label16.Hide();
            label17.Hide();
            label18.Hide();
            label19.Hide();
            label20.Hide();
            label21.Hide();
            label22.Hide();
            label23.Hide();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
          
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
           // panel1.Location = new Point(vScrollBar1.Value);

        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            sqlcon.Open();
            string query = "SELECT * FROM Student_db WHERE Student_RegNo = '" + textBox1.Text.Trim() + "' OR Student_Fullname = '" + textBox1.Text.Trim() + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);

            if (dtb.Rows.Count == 1)
            {

                labelFullname.Text = dtb.Rows[0]["Student_Fullname"].ToString();
                labelRegNo.Text = dtb.Rows[0]["Student_RegNo"].ToString();
                labelGe.Text = dtb.Rows[0]["Sponsor_Email"].ToString();
                labelGp.Text = dtb.Rows[0]["Sponsor_Mobile"].ToString();
                label6.Text = dtb.Rows[0]["Student_Email"].ToString();
                label20.Text = dtb.Rows[0]["Student_Mobile"].ToString();
                label19.Text = dtb.Rows[0]["Student_Address"].ToString();
                label21.Text = dtb.Rows[0]["Student_Gender"].ToString();
                label22.Text = dtb.Rows[0]["Student_DOB"].ToString();
                label23.Text = dtb.Rows[0]["Student_Level"].ToString();
                label11.Text = dtb.Rows[0]["Sponsor_Name"].ToString();
                label4.Show();
                label6.Show();
                label8.Show();
                label9.Show();
                label10.Show();
                label13.Show();
                label14.Show();
                labelFullname.Show();
                labelRegNo.Show();
                label7.Show();
                label12.Show();
                label15.Show();
                label16.Show();
                label17.Show();
                label18.Show();
                label19.Show();
                label20.Show();
                label21.Show();
                label22.Show();
                label23.Show();
                //labelAtt.Hide();
                labelGe.Show();
                labelGp.Show();
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                picBox.Image = Image.FromFile(paths + dtb.Rows[0]["SImagePath"].ToString());

            }
            sqlcon.Close();
            }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void labelGe_Click(object sender, EventArgs e)
        {

        }

        private void labelGp_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void labelRegNo_Click(object sender, EventArgs e)
        {

        }

        private void labelAtt_Click(object sender, EventArgs e)
        {

        }

        private void labelFullname_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void picBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "SELECT * FROM Student_db WHERE Student_RegNo = '" + textBox1.Text.Trim() + "' OR Student_Fullname = '" + textBox1.Text.Trim() + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);

            if (dtb.Rows.Count == 1)
            {

                labelFullname.Text = dtb.Rows[0]["Student_Fullname"].ToString();
                labelRegNo.Text = dtb.Rows[0]["Student_RegNo"].ToString();
                labelGe.Text = dtb.Rows[0]["Sponsor_Email"].ToString();
                labelGp.Text = dtb.Rows[0]["Sponsor_Mobile"].ToString();
                label6.Text = dtb.Rows[0]["Student_Email"].ToString();
                label20.Text = dtb.Rows[0]["Student_Mobile"].ToString();
                label19.Text = dtb.Rows[0]["Student_Address"].ToString();
                label21.Text = dtb.Rows[0]["Student_Gender"].ToString();
                label22.Text = dtb.Rows[0]["Student_DOB"].ToString();
                label23.Text = dtb.Rows[0]["Student_Level"].ToString();
                label11.Text = dtb.Rows[0]["Sponsor_Name"].ToString();
                label4.Show();
                label6.Show();
                label8.Show();
                label9.Show();
                label10.Show();
                label13.Show();
                label14.Show();
                labelFullname.Show();
                labelRegNo.Show();
                label7.Show();
                label12.Show();
                label15.Show();
                label16.Show();
                label17.Show();
                label18.Show();
                label19.Show();
                label20.Show();
                label21.Show();
                label22.Show();
                label23.Show();
                //labelAtt.Hide();
                labelGe.Show();
                labelGp.Show();
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                picBox.Image = Image.FromFile(paths + dtb.Rows[0]["SImagePath"].ToString());

            }
            sqlcon.Close();
        }
    }
}
