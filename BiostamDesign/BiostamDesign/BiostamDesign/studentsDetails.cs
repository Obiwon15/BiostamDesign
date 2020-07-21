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

        public partial class studentsDetails : Form
        {
            public studentsDetails()
            {
                InitializeComponent();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }

            private void studentsDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINGERPRINTdbDataSet2.Student_db' table. You can move, or remove it, as needed.
            this.student_dbTableAdapter2.Fill(this.fINGERPRINTdbDataSet2.Student_db);
            // TODO: This line of code loads data into the 'fINGERPRINTdbDataSet1.Student_db' table. You can move, or remove it, as needed.
            this.student_dbTableAdapter1.Fill(this.fINGERPRINTdbDataSet1.Student_db);
            // TODO: This line of code loads data into the 'fINGERPRINTDataSet1.Student_db' table. You can move, or remove it, as needed.
            //this.student_dbTableAdapter.Fill(this.fINGERPRINTDataSet1.Student_db);
            timer1.Start();

            label10.Hide();
            label11.Hide();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 
            public Image byteArraytoImage(byte[] byteArrayIn)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms, true);
                return returnImage;
            }
            //  int stdID;
            SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");

            //private void studentsDetails_Load(object sender, EventArgs e)
            //{
            //    // TODO: This line of code loads data into the 'fINGERPRINTdbDataSet21.Student_db' table. You can move, or remove it, as needed.
            //    this.student_dbTableAdapter1.Fill(this.fINGERPRINTdbDataSet21.Student_db);
            //    // TODO: This line of code loads data into the 'fINGERPRINTdbDataSet1.Student_db' table. You can move, or remove it, as needed.
            //    //this.student_dbTableAdapter.Fill(this.fINGERPRINTdbDataSet1.Student_db);
            //}

            private void button3_Click(object sender, EventArgs e)
            {
             


            }
            private void button2_Click(object sender, EventArgs e)
            {
               

            }
            private void button1_Click(object sender, EventArgs e)
            {
           
            }

            private void button4_Click(object sender, EventArgs e)
            {
              
            }

           

            private void button6_Click_1(object sender, EventArgs e)

            {
                // SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Student_db WHERE Student_Fullname LIKE '&" + keyword + "&' OR Student_RegNo LIKE '&" + keyword + "&' OR Student_Mobile LIKE '&" + keyword + "&' OR Student_Email LIKE '&" + keyword + "&' OR Sponsor_name LIKE '&" + keyword + "&'", sqlcon);
            }

            private void button2_MouseHover(object sender, EventArgs e)
            {
                //   MessageBox.Show("OK");
            }

            private void button1_MouseEnter(object sender, EventArgs e)
            {
                button1.BackColor = Color.Blue;
            }
            private void button1_MouseLeave(object sender, EventArgs e)
            {
                button1.BackColor = Color.PowderBlue;
            }


            private void button4_MouseEnter(object sender, EventArgs e)
            {
                button4.BackColor = Color.Blue;
            }



            private void button2_MouseEnter(object sender, EventArgs e)
            {
                button2.BackColor = Color.Maroon;
            }

            private void button2_MouseLeave(object sender, EventArgs e)
            {
                button2.BackColor = Color.PowderBlue;
            }

            private void button3_MouseEnter(object sender, EventArgs e)
            {
                button3.BackColor = Color.Blue;
            }

            private void button3_MouseLeave(object sender, EventArgs e)
            {
                button3.BackColor = Color.PowderBlue;
            }

            private void button4_MouseLeave(object sender, EventArgs e)
            {
                button4.BackColor = Color.PowderBlue;
            }

            private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
            {
            

            }

         



        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard AD = new AdminDashboard();
            AD.Show();

          
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
            studentsDetails STD = new studentsDetails();
            
            STD.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "" && txtFullname.Text == "" && txtEmail.Text == "" && txtMobile.Text == "" && txtLevel.Text == "" && txtSponsorM.Text == "")
            {
                MessageBox.Show("It Appears that there is nothing to Insert");
            }
            else
            {
                sqlcon.Open();
                String query = "INSERT INTO Student_db (Student_RegNo, Student_Fullname, Student_Level, Student_Mobile, Student_Email, Student_Gender, Sponsor_Mobile) VALUES ( '" + txtFullname.Text + "', '" + txtRegNo.Text + "', '" + txtLevel.Text + "',  '" + txtMobile.Text + "', '" + txtEmail.Text + "', '" + txtGender + "', '" + txtSponsorM.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
                SDA.SelectCommand.ExecuteNonQuery();

                sqlcon.Close();
                MessageBox.Show("Student Succesfully Registered");
                txtSponsorM.Clear();
                txtDob.Clear();
                txtEmail.Clear();
                txtMobile.Clear();
                txtGender.Clear();
                txtRegNo.Clear();
                txtLevel.Clear();
            }



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "" && txtFullname.Text == "" && txtEmail.Text == "" && txtMobile.Text == "" && txtLevel.Text == "" && txtSponsorM.Text == "")
            {
                MessageBox.Show("It Appears that there is nothing to Delete");
            }
            //else if (txtFullname.Text != "Student_Fullname" && txtRegNo.Text != "Student_RegNo" && txtEmail.Text != "Student_Email" && txtMobile.Text != "Student_Mobile" && txtLevel.Text != "Student_Level" && txtSponsorM.Text != "Sponsor_Mobile")
            //{
            //    MessageBox.Show("Sorry, pls try again");
            //}

            else
            {
                DialogResult dialog = MessageBox.Show("Details will be permanently deleted, Are you sure you want to Delete?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    sqlcon.Open();

                    string query = "DELETE FROM Student_db WHERE Student_RegNo ='" + txtRegNo.Text.Trim() + "'";

                    string query2 = "DELETE FROM Total_Attendance_db WHERE Student_RegNo ='" + txtRegNo.Text.Trim() + "'";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
                    SqlDataAdapter SDB = new SqlDataAdapter(query2, sqlcon);

                    DataTable dtb = new DataTable();
                    DataTable dta = new DataTable();

                 

                    SDA.Fill(dtb);
                    SDB.Fill(dta);

                    sqlcon.Close();
                    MessageBox.Show("Deleted successfully");
                    txtFullname.Clear();
                    txtSponsorM.Clear();
                    txtDob.Clear();
                    txtMobile.Clear();
                    txtGender.Clear();
                    txtRegNo.Clear();
                    txtLevel.Clear();
                    txtEmail.Clear();
                }
                else if (dialog == DialogResult.No)
                {
                    MessageBox.Show("Ok");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "" && txtFullname.Text == "" && txtEmail.Text == "" && txtMobile.Text == "" && txtLevel.Text == "" && txtSponsorM.Text == "")
            {
                MessageBox.Show("It Appears that there is nothing to update");
            }
            else
            {
                //sqlcon.Open();
                //SqlCommand cmd = new SqlCommand();
                //cmd = new SqlCommand("UPDATE Student_db set Student_Fullname = '" + txtFullname.Text + "' OR  Student_RegNo = '" + txtRegNo.Text + "' OR Student_Level = '" + txtLevel.Text + "' OR  Student_Mobile = '" + txtMobile.Text + "' OR Student_Email = '" + txtEmail.Text + "' OR Sponsor_Mobile = '" + txtSponsorM.Text + "' WHERE Student_RegNo = '" + txtRegNo.Text + "'", sqlcon);

                //cmd.ExecuteNonQuery();
                //sqlcon.Close();


                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("UPDATE Student_db set  Student_Fullname  =  '" + txtFullname.Text + "', Student_RegNo   = '" + txtRegNo.Text + "', Student_Level = '" + txtLevel.Text + "', Student_Mobile = '" + txtMobile.Text + "', Student_Email = '" + txtEmail.Text + "', Sponsor_Mobile = '" + txtSponsorM.Text + "' WHERE Student_ID = '" + label10.Text + "'", sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Details Updated successfully!");

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "" && txtFullname.Text == "" && txtEmail.Text == "" && txtMobile.Text == "" && txtLevel.Text == "" && txtSponsorM.Text == "")
            {
                MessageBox.Show("It Appears that there is nothing to Clear");
            }
            else
            {
                txtFullname.Clear();
                txtEmail.Clear();
                txtSponsorM.Clear();
                txtDob.Clear();
                txtMobile.Clear();
                txtGender.Clear();
                txtRegNo.Clear();
                txtLevel.Clear();
            }

            //TextWriter writer = new StreamWriter(@"C:\Users\Sylvanus\Documents\Final Year Project\Update 4\BiostamDesign\BiostamDesign\Attendance\Text.txt");

            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //    {
            //        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
            //    }
            //    writer.WriteLine("");
            //    writer.WriteLine("------------------------------------------------------------");
            //}
            //writer.Close();
            //MessageBox.Show("Write successful");
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Student_db WHERE Student_Fullname LIKE '%" + keyword + "%' OR Student_RegNo LIKE '%" + keyword + "%'", sqlcon);
            DataTable dt = new DataTable();
           
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            //SqlCommand cmd = new SqlCommand();
            ////cmd.ExecuteNonQuery();
            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();
            //AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            //while (dr.Read())
            //{
            //    col.Add(dr.GetString(0));
            //}
            //txtSearch.AutoCompleteCustomSource = col;

           
        }

        private void button6_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        //int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //count = studentdbBindingSource3.Count;
            //label9.Text = count.ToString();

            //string query = "SELECT * FROM Student_db";
            //SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            //DataTable dt = new DataTable();
            //SDA.Fill(dt);

            //DataSet ds = new DataSet();

            int colcount = dataGridView1.Columns.Count;
            label9.Text = colcount.ToString();
        }

        private void studentdbBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            txtFullname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRegNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtLevel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtMobile.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDob.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtGender.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtSponsorM.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            label10.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Number = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string level = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string mobile = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string email = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            string DOB = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            string gender = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            string fullname = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string sponsorN = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            string sponsorE = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            string sponsorM = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            //string Att = LectGridView.SelectedRows[0].Cells["Fullname"].Value.ToString();
            //Byte[] img = (Byte[])dataGridView1.SelectedRows[0].Cells[11].Value;
            //Byte[] img = (Byte[])dt.Rows[0]["IMAGE"];

            //Image newImage = byteArraytoImage(img);

            //this.Hide();
            //Details1 DE = new Details1(fullname, Number, level, mobile, email, DOB, gender, sponsorN, sponsorE, sponsorM, newImage);
            //DE.Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
    }
