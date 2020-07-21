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
using System.IO;


namespace BiostamDesign
{
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");

        private void PasswordChange_Load(object sender, EventArgs e)
        {
            MyLabel.Hide();
            button2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((txtOldPass.Text == "") && (txtNewPass.Text == ""))
            {
                MyLabel.Show();
                MyLabel.Text = "Please, put in your old and new password!";

            }
            else if (txtNewPass.Text == txtOldPass.Text)
            {
                MyLabel.Show();
                MyLabel.Text = "Please, Your new password cannot be the same as your old password!";

            }
            else if (txtConPass.Text != txtNewPass.Text)
            {
                MyLabel.Show();
                MyLabel.Text = "Please ensure that Your password is well confirmed!";

            }
            else
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("UPDATE Lecturer_db set Password = '" + txtNewPass.Text + "' WHERE  Password = '" + txtOldPass.Text + "'", sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                MyLabel.Show();
                MyLabel.Text = "Password has been changed successfully!";
                txtConPass.Clear();
                txtNewPass.Clear();
                txtOldPass.Clear();

            }
        }
    }
}
