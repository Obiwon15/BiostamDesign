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
    public partial class lecturerRegister : UserControl
    {
        public lecturerRegister()
        {
            InitializeComponent();
        }

        


            SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");
            string imglocation = "";

            SqlCommand cmd = new SqlCommand();





            private void lecturerRegister_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'fINGERPRINTdbDataSet.Lecturer_db' table. You can move, or remove it, as needed.
                // this.lecturer_dbTableAdapter.Fill(this.fINGERPRINTdbDataSet.Lecturer_db);

            }

            private void button4_Click(object sender, EventArgs e)
            {
                this.Hide();
                AdminDashboard ADB = new AdminDashboard();
                ADB.Show();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                //byte[] images = null;
                //FileStream Stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                //BinaryReader binr = new BinaryReader(Stream);
                //images = binr.ReadBytes((int)Stream.Length);
                //sqlcon.Open();


                MemoryStream ms = new MemoryStream();
                pbxLecturer.Image.Save(ms, pbxLecturer.Image.RawFormat);
                byte[] images = ms.GetBuffer();
                ms.Close();

                //images = new SqlParameter("@IMAGE", SqlDbType.Image);


                if (txtPassword.Text == txtCoPass.Text)
                {
                    //sqlcon.Open();

                    //cmd.Parameters.Clear();
                    //cmd.Parameters.AddWithValue("@IM", img);
                    //String query = "INSERT INTO Lecturer_db (Fullname, Password, Username, Email, Mobile, Course_Designation, IMAGE) VALUES ('" + txtFullname.Text + "', '" + txtPassword.Text + "', '" + txtUsername.Text + "', '" + txtEmail.Text + "', '" + txtMobile.Text + "', '" + txtCourse.Text + "', @IMAGE )";
                    //cmd = new SqlCommand(query, sqlcon);

                    //cmd.ExecuteNonQuery();
                    //sqlcon.Close();
                    //pbxLecturer.Image = null;

                    sqlcon.Open();
                 OpenFileDialog open = new OpenFileDialog();
                // string folder = "D:\\BImages";
                // string fname = picText.Text + ".jpg";
                //// string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                // string CorrectName = System.IO.Path.Combine(folder,fname);
                //System.IO.File.Copy(open.FileName, paths + "\\Images\\" + CorrectFileName);
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                string CorrectFileName = System.IO.Path.GetFileName(open.FileName);
                label1.Text = CorrectFileName;
                String query = "INSERT INTO Lecturer_db (Fullname, Password, Username, Email, Mobile, Course_Designation, LImagePath, IMAGE) VALUES ('" + txtFullname.Text + "', '" + txtPassword.Text + "', '" + txtUsername.Text + "', '" + txtEmail.Text + "', '" + txtMobile.Text + "', '" + txtCourse.Text + "', '\\images\\ " + label1.Text + "' , @images )";
                    
                    cmd = new SqlCommand(query, sqlcon);
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    int N = cmd.ExecuteNonQuery();


                    MessageBox.Show("Lecturer Succesfully Registered");
                }
                else
                
                {
                    MessageBox.Show("Please Make Sure that your confirm password matches the indicated password");
                }
                sqlcon.Close();
            
            }

            private void button2_Click(object sender, EventArgs e)
            {

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "png files (*.png)|*.png| jpg files (*.jpg)|*.jpg| gif files (*.gif)|*.gif| ALL files(*.*)|*.* ";
                dialog.Title = "Select your passport image";
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    imglocation = dialog.FileName.ToString();
                    pbxLecturer.ImageLocation = imglocation;

                }
            }

            private void button3_Click(object sender, EventArgs e)
            {
                //  string image = "";
                byte[] image = null;
                FileStream Stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader binr = new BinaryReader(Stream);
                image = binr.ReadBytes((int)Stream.Length);

            }

            private void txtPassword_TextChanged(object sender, EventArgs e)
            {

            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "D:\\";
            open.Filter = "png files (*.png)|*.png| jpg files (*.jpg)|*.jpg| gif files (*.gif)|*.gif| ALL files(*.*)|*.* ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    string CorrectFileName = System.IO.Path.GetFileName(open.FileName);
                    System.IO.File.Copy(open.FileName, paths + "\\Images\\" + CorrectFileName);
                }
                imglocation = open.FileName.ToString();
                pbxLecturer.ImageLocation = imglocation;


            }
        }
    }
    }
