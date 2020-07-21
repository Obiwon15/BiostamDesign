using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace BiostamDesign
{
    public partial class ForgetPass : Form
    {
        string randomCode;
        public static string to;
        public ForgetPass()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ForgetPass_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "eceattendance01@gmail.com";
            pass = "BIOSTAM124";
            messageBody = "Your Reset Code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = " Password Reset Code ";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Sent Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //txtEmail.Clear();
            PassVer PV = new PassVer(randomCode,txtEmail.Text);
            PV.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
