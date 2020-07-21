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
    public partial class adminRegister : UserControl
    {
        public adminRegister()
        {
            InitializeComponent();
        }


        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");
        private void adminRegister_Load(object sender, EventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtConPassword == txtPassword)
            {
                sqlcon.Open();
                String query = "INSERT INTO Admin_db(Fullname, Mobile, Email, Username, Password) VALUES ('" + txtFullname.Text.Trim() + "','" + txtMobile.Text.Trim() + "','" + txtEmail.Text.Trim() + "','" + txtUsername.Text.Trim() + "','" + txtPassword.Text.Trim() + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
                SDA.SelectCommand.ExecuteNonQuery();

                sqlcon.Close();
                MessageBox.Show("Admin successfully Registered");
            }
            else

            {
                MessageBox.Show("Please Make Sure that your confirm password matches the indicated password");
            }
            
        }






        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
