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
    public partial class ManualReg : Form
    {
        public ManualReg(string SessionName)
        {
            InitializeComponent();
            label6.Text = SessionName;
        }
        
        //public Image byteArraytoImage(byte[] byteArrayIn)
        //{
        //    //public Image byteArrayToImage(byte[], byteArrayIn)
        //    System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
        //    Image img = (Image)converter.ConvertFrom(byteArrayIn);

        //    return img;
        //    //    System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
        //    //    Image img = (Image)converter.ConvertFrom(byteArrayIn);
        //    //    return img;
        //    ////    MemoryStream ms = new MemoryStream(byteArrayIn);
        //    //    Image returnImage = Image.FromStream(ms);
        //    //    return returnImage;
        //}

        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            //SqlCommand cmd = new SqlCommand();
            //cmd = new SqlCommand("SELECT Student_RegNo FROM Total_Attendance_db  WHERE Student_RegNo = '" + txtReg.Text.Trim() + "'");
            //cmd.ExecuteNonQuery();

            ////SqlDataAdapter SD = new SqlDataAdapter(query, sqlcon);
            ////DataTable dtb = new DataTable();
            ////SDA.Fill(dtb);
            sqlcon.Open();
            //string query1 = "SELECT * FROM Total_Student_db WHERE Student_RegNo ='" + txtReg.Text.Trim() + "' ";
            //SqlDataAdapter SDA1 = new SqlDataAdapter(query1, sqlcon);
            //DataTable dtb1 = new DataTable();
            //SDA1.Fill(dtb1);

            string query = "SELECT * FROM Total_Attendance_db WHERE Student_RegNo ='" + txtReg.Text.Trim() + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);
            sqlcon.Close();



            if (dtb.Rows.Count > 0)
            {
                sqlcon.Open();
                string name = label6.Text;
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("UPDATE Total_Attendance_db set " + name + " = '1' WHERE Student_RegNo = '" + txtReg.Text.Trim() + "'", sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                //MessageBox.Show("Attendance Recorded");
                


             
                    string fullname = dtb.Rows[0]["Student_Fullname"].ToString();
                    string Number = dtb.Rows[0]["Student_RegNo"].ToString();
                    string attendance = dtb.Rows[0]["Percentage"].ToString();
                    string total = dtb.Rows[0]["Total"].ToString();


                    string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    picBox.Image = Image.FromFile(paths + dtb.Rows[0]["SImagePath"].ToString());

                    Image picture = picBox.Image;
                ATTP att = new ATTP(fullname, Number, attendance, total, picture);
                att.Show();


                //StudentPopup SPO = new StudentPopup(fullname, Number, attendance, total, picture);
                //SPO.Show();


                //"INSERT INTO Total_Attendance_db(" + colName + ") VALUES ('1') WHERE Student_RegNo = '" + txtReg.Text.Trim() + "' ";
                //SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
                //SDA.SelectCommand.ExecuteNonQuery();

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
        
            
           
             
            sqlcon.Open();
            string query = "SELECT * FROM Student_db WHERE Student_RegNo = '" + txtReg.Text.Trim() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            SDA.Fill(dtb);

            if (dtb.Rows.Count == 1)
            {
                label2.Text = "Hello  " + dtb.Rows[0]["Student_Fullname"].ToString();
                //string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                //picBox.Image = Image.FromFile(paths + dtb.Rows[0]["SImagepath"].ToString());

                //Byte[] img = (Byte[])dtb.Rows[0]["Student_image"];



                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                picBox.Image = Image.FromFile(paths + dtb.Rows[0]["SImagePath"].ToString());
                //{
                //    picBox.Image = null;
                //}
                //else
                //{
                //    //    byteArraytoImage(byte[] byteArrayIn);
                //    //    Byte[] image = System.Convert.FromBase64String(base64ImageString);
                //    //    using (MemoryStream ms = new MemoryStream(bytes))
                //    //        picBox.Image = Image.FromStream(ms);

                //    //Image newImage = byteArraytoImage(img);
                //    ////picBox.ImageLocation = imglocation;

                //    //MemoryStream MS = new MemoryStream(img);
                //    //FileStream obj_FileStream = new FileStream(img, FileMode.OpenOrCreate, FileAccess.Read);
                //    //picBox.Image = Image.FromStream(MS);
                //    ////obj_FileStream.Read(img, 0, Convert.ToInt32(obj_FileStream.Length));
                //    //byte[] fileData = null;
                //    //using (var binaryReader = new BinaryReader(Request.File[0].InputStream));
                //    //ImageConverter imageConverter = new System.Drawing.ImageConverter();
                //    //System.Drawing.Image image = imageConverter.ConvertFrom(img) as System.Drawing.Image;
                //    ////image.Save(System.Drawing.Imaging.ImageFormat.Jpeg);

                //    Image newImage = byteArraytoImage(img);
                //    picBox.Image = newImage;

                //}









                picBox.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label1.Text = "     We Apologize once Again For any incovenience";
                label4.Text = "     Please Click Below To Confirm Your Attendance";
                label5.Hide();
                label1.Hide();
                //txtSession.Hide();
                txtReg.Hide();
                button1.Hide();
                button2.Hide();
                button3.Show();
            }
            else
            {
                MessageBox.Show("Registration Number Not Recognized!");
            }




        
        sqlcon.Close();
        }

        private void ManualReg_Load(object sender, EventArgs e)
        {
            button3.Hide();
            label6.Hide();
            label3.Hide();
            label4.Hide();
            picBox.Hide();
            label3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ManualEntry ME = new ManualEntry(label6.Text);
            ME.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtReg_TextChanged(object sender, EventArgs e)
        {

        }


        //private void button5_Click(object sender, EventArgs e)
        //{
        //    sqlcon.Open();
        //    string query = "SELECT * FROM Total_Attendance_db WHERE Student_RegNo ='" + txtReg.Text.Trim() + "' ";
        //    SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
        //    DataTable dtb = new DataTable();
        //    SDA.Fill(dtb);



        //    if (dtb.Rows.Count == 1)
        //    {
        //        label7.Text = "Hello  " + dtb.Rows[0]["Total"].ToString();
                
        //    }
        //    else
        //    {
        //        MessageBox.Show("Unrecognized Reg. Number");
        //    }
        //        sqlcon.Close();

        //}

        private void button6_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string name = label6.Text;
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("UPDATE Total_Attendance_db set Total = (((Session1 + Session2 + Session3 + Session4)/4)*100)", sqlcon);
            int N =  cmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Total Calculated");
            //sqlcon.Open();
            //string query = "SELECT (sess10 + sess11 + sess12+ sess13) AS Total, (((sess10 + sess11 + sess12 + sess13)/4) * 100) AS Percentage FROM Total_Attendance_db "; 
            //SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            //DataTable dtb = new DataTable();
            //SDA.Fill(dtb);
            //sqlcon.Close();
            //MessageBox.Show("Total Calculated");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

