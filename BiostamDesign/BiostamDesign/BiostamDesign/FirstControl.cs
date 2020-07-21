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
using System.IO;

namespace BiostamDesign
{
    public partial class FirstControl : UserControl
    {
        public FirstControl()
        {
            InitializeComponent();
        }

        public Image byteArraytoImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms, true);
            return returnImage;
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");
        // string imglocation = "";

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Lecturer_db WHERE Username ='" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);

            if (dtb.Rows.Count == 1)
            {


                label2.Text = dtb.Rows[0]["Fullname"].ToString();
                label2.Show();
                label7.Text = "Howdy " + label2.Text;
                label7.Hide();

                Byte[] img = (Byte[])dtb.Rows[0]["IMAGE"];

                if (img == null)
                {
                    picBox.Image = null;
                }
                else
                {


                    MemoryStream MS = new MemoryStream(img);
                    picBox.Image = Image.FromStream(MS);

                }
               

                Image newImage = byteArraytoImage(img);

                txtUsername.Clear();
                txtPassword.Clear();

                StaffDashboard SD = new StaffDashboard(newImage, "Welcome " + label2.Text, label7.Text);

              
              
                SD.Show();
               
            }
            else
            {
                MessageBox.Show("Please Check Your Username and Password");
            }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPass FP = new ForgetPass();
                FP.Show();
        }

        private void FirstControl_Load(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Lecturer_db WHERE Username ='" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);

            if (dtb.Rows.Count == 1)
            {

                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                picBox.Image = Image.FromFile(paths + dtb.Rows[0]["LImagepath"].ToString());
            }
        }
    }
}
