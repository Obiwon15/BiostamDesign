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
    public partial class ManualEntry : Form
    {
        public ManualEntry(string SessionName)
        {
            InitializeComponent();
            label3.Text = SessionName;
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManualEntry_Load(object sender, EventArgs e)
        {
            label3.Hide();
            label2.Hide();
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Lecturer_db WHERE Password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);

            if (dtb.Rows.Count == 1)
            {
                this.Hide();
                ManualReg MR = new ManualReg(label3.Text);
                MR.Show();
            }
            else
            {
                MessageBox.Show("Oops! Seems Your Password was not Recognized");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
