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

using System.Net;
using System.Net.Mail;
using System.Diagnostics;
using System.Reflection;
using System.Globalization;
using System.Configuration;
using System.Text.RegularExpressions;
//using ClosedXML.Excel;



namespace BiostamDesign
{
    public partial class AttendanceTable : Form
    {

        //SqlDataAdapter sda;
        //SqlCommandBuilder scb;
        //DataTable dt;


        public AttendanceTable()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");
        private void txtReg_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Total_Attendance_db WHERE Student_Fullname LIKE '%" + keyword + "%' OR Student_RegNo LIKE '%" + keyword + "%'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //public void fill_grid()
        //{

        //    SqlCommand cmd = sqlcon.CreateCommand();
        //    cmd.CommandType = CommandType.Text;

        //    cmd.CommandText = @"SELECT * From Total_Attendance_db";
        //    cmd.ExecuteNonQuery();

        //    dt = new DataTable();
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);

        //    sda.Fill(dt);
        //    dataGridView1.DataSource = dt;
           

        //}


        private void button1_Click(object sender, EventArgs e)
        {


            this.Close();
        }



        private void AttendanceTable_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 'fINGERPRINTdbDataSet3.Total_Attendance_db' table.You can move, or remove it, as needed.
            this.total_Attendance_dbTableAdapter.Fill(this.fINGERPRINTdbDataSet3.Total_Attendance_db);
            //Total();
            //dataGridView1.DataSource = RetrieveDetail();

        }

        //private DataTable RetrieveDetail()
        //{
        //    DataTable dtAtt = new DataTable();
        //    string constring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(constring))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("SELECT * FROM Total_Attendance_db", sqlcon))
        //        {
        //            con.Open();
        //            SqlDataAdapter reader = cmd.ExecuteReader();
        //        }
        //    }
        //        return dtAtt;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AttendanceTable ATT = new AttendanceTable();
            ATT.Show();
        }

        private void button0_6_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            // string name = label6.Text;
            //SqlCommand cmd = new SqlCommand();
            //cmd = new SqlCommand("UPDATE Total_Attendance_db set Total = (((sess10 + sess11 + sess12 + sess13)/4)*100) ", sqlcon);
            //cmd.ExecuteNonQuery();
            string query = "ALTER TABLE Total_Attendance_db ADD Total AS ((sess10 + sess11 + sess12 + sess13)/4)*100 INT";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            // SDA.SelectCommand.ExecuteNonQuery();
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);
            sqlcon.Close();
            MessageBox.Show("Total Calculated");
        }

        private void button6_Click(object sender, EventArgs e)
        {

         
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {


                SqlCommand cmd = new SqlCommand(@"UPDATE Total_Attendance_db set Total ='" + dataGridView1.Rows[i].Cells[12].Value + "', Average ='" + dataGridView1.Rows[i].Cells[13].Value + "', Percentage ='" + dataGridView1.Rows[i].Cells[14].Value + "' WHERE Student_RegNo ='" + dataGridView1.Rows[i].Cells[0].Value + "'", sqlcon);

                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();
            }
        }

           
        void Total()
        {
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Total_Attendance_db", sqlcon);
            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //sqlcon.Open();
            //attGrid.DataSource = dt;


            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                int n = item.Index;
                int a = dataGridView1.Columns.Count;
                int b = a - 6;

                double m = Convert.ToInt32(dataGridView1.Rows[n].Cells[2].Value);

                double r = Convert.ToInt32(dataGridView1.Rows[n].Cells[3].Value);

                double o = Convert.ToInt32(dataGridView1.Rows[n].Cells[4].Value);

                double p = Convert.ToInt32(dataGridView1.Rows[n].Cells[5].Value);

                double q = Convert.ToInt32(dataGridView1.Rows[n].Cells[6].Value);

                double v = Convert.ToInt32(dataGridView1.Rows[n].Cells[7].Value);

                double w = Convert.ToInt32(dataGridView1.Rows[n].Cells[8].Value);

                double x = Convert.ToInt32(dataGridView1.Rows[n].Cells[9].Value);

                double y = Convert.ToInt32(dataGridView1.Rows[n].Cells[10].Value);
            
                double z = Convert.ToInt32(dataGridView1.Rows[n].Cells[11].Value);

                double s = m + r + o + p + q + v + w + x + y + z;
                double t = s / 10;
                double u = t * 100;


                    dataGridView1.Rows[n].Cells[12].Value = s;
                    dataGridView1.Rows[n].Cells[13].Value = t;
                    dataGridView1.Rows[n].Cells[14].Value = u;
                }
                //sqlcon.Close();



                //   attGrid.Rows[n].Cells[9].Value = "0";
                //   attGrid.Rows[n].Cells[9].Value = ((int.Parse(attGrid.Rows[n].Cells[3].Value.ToString()) +
                //float.Parse(attGrid.Rows[n].Cells[4].Value.ToString()) +
                //float.Parse(attGrid.Rows[n].Cells[5].Value.ToString()) +
                //float.Parse(attGrid.Rows[n].Cells[6].Value.ToString()) +
                //float.Parse(attGrid.Rows[n].Cells[7].Value.ToString()))/b).ToString();

                //   attGrid.Rows[n].Cells[10].Value = "0";
                //   attGrid.Rows[n].Cells[10].Value = (((Double.Parse(attGrid.Rows[n].Cells[3].Value.ToString()) +
                //int.Parse(attGrid.Rows[n].Cells[4].Value.ToString()) +
                //int.Parse(attGrid.Rows[n].Cells[5].Value.ToString()) +
                //int.Parse(attGrid.Rows[n].Cells[6].Value.ToString()) +
                //int.Parse(attGrid.Rows[n].Cells[7].Value.ToString()))/ b)*100).ToString();



            }

        private void button4_Click(object sender, EventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                TextWriter writer = new StreamWriter(@"C:\Users\Sylvanus\Documents\Final Year Project\Update 4\BiostamDesign\BiostamDesign\Attendance\Text.txt");

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        writer.Write("\t " + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("------------------------------------------------------------");
                }
                writer.Close();

                OpenFileDialog dlg = new OpenFileDialog();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string txtpath = dlg.FileName.ToString();
                    Attachment1.Text = txtpath;
                }

                string from, pass, messageBody, to;
                messageBody = dataGridView1.ToString();

                MessageBox.Show("Data exported!");

                MailMessage message = new MailMessage();
                to = (txtEmail.Text).ToString();
                from = "eceattendance01@gmail.com";
                pass = "BIOSTAM124";
                message.Attachments.Add(new Attachment(Attachment1.Text));

                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = " BIOSTAMS Attendance Table ";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Email Sent Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();


        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx|Excel Files(2013)|*.xlsx| Excel Files(2016)|*.xlsx";
            //if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            //{
            //Microsoft
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }







        //}
        //private void button4_Click(object sender, EventArgs e)
        //{
        //  

        //}

        //private void attGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
