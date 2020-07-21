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
    public partial class ExamLogin : UserControl
    {
        public ExamLogin()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");
        // string imglocation = "";


        private void ExamLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Lecturer_db WHERE Username ='" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);

            if (dtb.Rows.Count == 1)
            {


                //label2.Text = dtb.Rows[0]["Fullname"].ToString();
                //label2.Show();
                //label7.Text = "Howdy " + label2.Text;
                //label7.Hide();

                //Byte[] img = (Byte[])dtb.Rows[0]["IMAGE"];

                //if (img == null)
                //{
                //    picBox.Image = null;
                //}
                //else
                //{


                //    MemoryStream MS = new MemoryStream(img);
                //    picBox.Image = Image.FromStream(MS);

                //}
                this.Hide();

                //Image newImage = byteArraytoImage(img);

                txtUsername.Clear();
                txtPassword.Clear();

                ExaminationPortal EXP = new ExaminationPortal(/*newImage, "Welcome " + label2.Text, label7.Text*/);

                EXP.Show();

            }
            else
            {
                MessageBox.Show("Please Check Your Username and Password");
            }
        }
    }
}
