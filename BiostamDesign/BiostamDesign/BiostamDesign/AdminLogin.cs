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
    public partial class AdminLogin : UserControl
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Admin_db WHERE Username ='" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);
            if (dtb.Rows.Count == 1)
            {

                AdminDashboard AD = new AdminDashboard();
            
                
                AD.Show();

                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Please, Check Your username and Password!");
                //AdLabel.Show();
                //AdLabel.Text = "Please, Check Your username and Password!";
            }





        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPass FP = new ForgetPass();
            FP.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
