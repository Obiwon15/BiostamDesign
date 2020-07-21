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
using System.Net;
using System.Net.Mail;

namespace BiostamDesign
{
    public partial class spmessage : Form
    {
        public static string to;
        public spmessage()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");
        private void spmessage_Load(object sender, EventArgs e)
        {
            textBox2.Hide();
            MessageBody.Hide();
            label1.Hide();
            label3.Hide();
            button1.Hide();
            label4.Hide();
            button2.Hide();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            string from, pass, messageBody;

            MailMessage message = new MailMessage();
            to = (label4.Text).ToString();
            from = "eceattendance01@gmail.com";
            pass = "BIOSTAM124";
            messageBody = (MessageBody.Text).ToString();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Message From Your Lecturer";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Message Sent Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Lecturer_db WHERE Password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);

            if (dtb.Rows.Count == 1)
            {
                textBox2.Show();
                MessageBody.Show();
                label1.Show();
                label3.Show();
                button1.Show();
                button2.Show();
            }
            else
            {
                MessageBox.Show("Please Input Correct Password!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Student_db WHERE Student_RegNo = '" + textBox2.Text.Trim() + "' OR Student_Fullname = '" + textBox2.Text.Trim() + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);

            if (dtb.Rows.Count == 1)
            {
                label4.Text = dtb.Rows[0]["Sponsor_Email"].ToString();
                label4.Show();
            }
            else
            {
                label4.Text = "Please Input Correct Student Name or Reg.No";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
