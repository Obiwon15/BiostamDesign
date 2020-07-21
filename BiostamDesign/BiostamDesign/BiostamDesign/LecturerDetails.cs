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
    public partial class LecturerDetails : UserControl
    {
        public LecturerDetails()
        {
            
            InitializeComponent();
            LectGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");

        public Image byteArraytoImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms, true);
            return returnImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            //else { 
            //sqlcon.Open();
            //string query = "DELETE FROM Lecturer_db WHERE Username ='" + txtUsername.Text.Trim() + "'";
            //SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            //DataTable dtb = new DataTable();
            //SDA.Fill(dtb);
            //sqlcon.Close();
            //MessageBox.Show("Deleted successfully");
            //txtCourse.Clear();
            //txtEmail.Clear();
            //txtFullname.Clear();
            //txtMobile.Clear();
            //txtPassword.Clear();
            //txtUsername.Clear();
            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PasswordChange pch = new PasswordChange();
            pch.Show();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturerDetails LED = new LecturerDetails();
            LED.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordChange PAC = new PasswordChange();
            PAC.Show();
        }

        private void LecturerDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINGERPRINTdbDataSet.Lecturer_db' table. You can move, or remove it, as needed.
            this.lecturer_dbTableAdapter.Fill(this.fINGERPRINTdbDataSet.Lecturer_db);
        }

        private void LectGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Number = LectGridView.SelectedRows[0].Cells[0].Value.ToString();
            string password = LectGridView.SelectedRows[0].Cells[1].Value.ToString();
            string username = LectGridView.SelectedRows[0].Cells[2].Value.ToString();
            string fullname = LectGridView.SelectedRows[0].Cells[3].Value.ToString();
            //string Att = LectGridView.SelectedRows[0].Cells["Fullname"].Value.ToString();
            Byte[] img = (Byte[])LectGridView.SelectedRows[0].Cells[7].Value;
            //Byte[] img = (Byte[])dt.Rows[0]["IMAGE"];

            Image newImage = byteArraytoImage(img);

            //this.Hide();
            //Details DE = new Details(Number, fullname, newImage);
            //DE.Show();
        }

        private void LectGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = LectGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtFullname.Text = LectGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = LectGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtMobile.Text = LectGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCourse.Text = LectGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Lecturer_db WHERE Fullname LIKE '%" + keyword + "%' OR Username LIKE '%" + keyword + "%'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LectGridView.DataSource = dt;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturerDetails LED = new LecturerDetails();
            LED.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ADB = new AdminDashboard();
            ADB.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtCourse.Text == "" && txtEmail.Text == "" && txtFullname.Text == "" && txtMobile.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("It Appears that there is nothing to update");
            }
            else
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("UPDATE Lecturer_db set Username = '" + txtUsername.Text + "', Fullname = '" + txtFullname.Text + "', Email = '" + txtEmail.Text + "', Mobile = '" + txtMobile.Text + "', Course_Designation = '" + txtCourse.Text + "' WHERE Username = '" + txtUsername.Text + "'", sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Details Updated successfully!");
                txtCourse.Clear();
                txtEmail.Clear();
                txtFullname.Clear();
                txtMobile.Clear();
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtCourse.Text == "" && txtEmail.Text == "" && txtFullname.Text == "" && txtMobile.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("It Appears that there is nothing to Delete");
            }

            else
            {
                DialogResult dialog = MessageBox.Show("Details will be permanently deleted, Are you sure you want to Delete?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    sqlcon.Open();
                    string query = "DELETE FROM Lecturer_db WHERE  Username ='" + txtUsername.Text.Trim() + "'";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
                    DataTable dtb = new DataTable();
                    SDA.Fill(dtb);
                    sqlcon.Close();
                    MessageBox.Show("Deleted successfully");
                    txtCourse.Clear();
                    txtEmail.Clear();
                    txtFullname.Clear();
                    txtMobile.Clear();
                    txtPassword.Clear();
                    txtUsername.Clear();
                }
                else if (dialog == DialogResult.No)
                {
                    MessageBox.Show("You probably made the right chioce, click Ok to continue");
                }
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtCourse.Text == "" && txtEmail.Text == "" && txtFullname.Text == "" && txtMobile.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("It Appears that there is nothing to Insert");
            }
            else
            {
                sqlcon.Open();
                String query = "INSERT INTO Lecturer_db (Fullname, Password, Username, Email, Mobile, Course_Designation) VALUES ('" + txtFullname.Text + "', '" + txtPassword.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtMobile.Text + "', '" + txtCourse.Text + "' )";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
                SDA.SelectCommand.ExecuteNonQuery();

                sqlcon.Close();
                MessageBox.Show("Lecturer Succesfully Registered");
                txtCourse.Clear();
                txtEmail.Clear();
                txtFullname.Clear();
                txtMobile.Clear();
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtCourse.Text == "" && txtEmail.Text == "" && txtFullname.Text == "" && txtMobile.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("It Appears that there is nothing to Clear");
            }
            else
            {
                txtCourse.Clear();
                txtEmail.Clear();
                txtFullname.Clear();
                txtMobile.Clear();
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
