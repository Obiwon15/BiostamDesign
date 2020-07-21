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

using DPFP;
using DPFP.Error;
using DPFP.Capture;


namespace BiostamDesign
{
    public partial class studentRegister : Form, DPFP.Capture.EventHandler
    {
        public studentRegister()
        {
            InitializeComponent();

        }
        string Gender;
        private void studentRegister_Load(object sender, EventArgs e)
        {

        }

            SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");
            string imglocation = "";

            SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();


           
            public DPFP.Capture.EventHandler EventHandler;
            public DPFP.Template Template;
            private DPFP.Capture.Capture Capturer;
            public CaptureFeedback CaptureFeedback;
            public delegate void OnTemplateEventHandler(DPFP.Template template);
            public DPFP.Processing.DataPurpose Purpose;

            private DPFP.Processing.Enrollment Enroller;
            delegate void Function();

            public byte[] imgs;

            private uint TotalFeaturesNeeded;



            DPFP.Capture.SampleConversion sp = new DPFP.Capture.SampleConversion();
            DPFP.Capture.Capture cp = new DPFP.Capture.Capture();
            DPFP.Sample sample = new DPFP.Sample();

        
         
            public void UpdateSamplesNeeded()
            {
                this.Invoke(new Function(delegate ()
                {
                    SamplesNeeded.Text = String.Format("Samples collected : {0}/{1}", this.TotalFeaturesNeeded - Enroller.FeaturesNeeded, this.TotalFeaturesNeeded);
                }));
              
            }

            #region Form Event Handlers:

            public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
            {

            
                Process(Sample);
            }

            public void OnFingerGone(object Capture, string ReaderSerialNumber)
            {

            }

            public void OnFingerTouch(object Capture, string ReaderSerialNumber)
            {

            }

            public void OnReaderConnect(object Capture, string ReaderSerialNumber)
            {

            }

            public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
            {

            }

            public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
            {
               
                if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                    MessageBox.Show("Good scan");
                else
                    MessageBox.Show("Bad scan");
            }
            #endregion



            public void DrawPicture(Bitmap bitmap)
            {
                this.Invoke(new Function(delegate ()
                {
                    pbExtractedImage.Image = new Bitmap(bitmap, pbExtractedImage.Size);
                }

                ));
            }
            protected virtual void Process(DPFP.Sample Sample/*, DPFP.Processing.DataPurpose Purpose*/)
            {
                DrawPicture(FingerPrintUtility.ConvertSampleToBitmap(Sample));
                try
                {
                    DPFP.FeatureSet features = FingerPrintUtility.ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

                    if (features != null)
                        try
                        {
                            Enroller.AddFeatures(features);
                        }
                        catch
                        {
                            MessageBox.Show("Template error");

                        }
                        finally
                        {
                            UpdateSamplesNeeded();
                            switch (Enroller.TemplateStatus)
                            {
                                case DPFP.Processing.Enrollment.Status.Ready:
                                    OnTemplateCollect(Enroller.Template);
                                    Stop();
                                    MessageBox.Show("Enrolled Successfuly");
                                    break;
                                case DPFP.Processing.Enrollment.Status.Failed:
                                    Enroller.Clear();
                                    Stop();
                                    OnTemplateCollect(null);
                                    UpdateSamplesNeeded();
                                    Start();
                                    MessageBox.Show("Enroller Failed");
                                    break;
                            }
                        }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cant recognize as a fingerprint.");
                    UpdateSamplesNeeded();
                }
            }

      
            protected virtual void Init()
            {
               

                try
                {
                    Capturer = new DPFP.Capture.Capture();
                    Enroller = new DPFP.Processing.Enrollment();
                    this.TotalFeaturesNeeded = Enroller.FeaturesNeeded;

                    if (null != Capturer)
                        Capturer.EventHandler = this;
                }
                catch
                {
                    MessageBox.Show("Can't initiate capture");
                }
            }


            private void OnTemplateCollect(DPFP.Template template)
            {

                this.Invoke(new Function(delegate ()
                {
                try
                {
                   
                    Template = template;
                  
                    MemoryStream ms = new MemoryStream();
                    byte[] imgs = template.Bytes;
                    Template.Serialize(ms);
                    this.imgs = ms.ToArray();

               
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment!");
                    }

                }
                ));

            }

            protected void Start()
            {
                if (null != Capturer)
                {
                    try
                    {
                        Capturer.StartCapture();
                    }
                    catch
                    {
                        MessageBox.Show("Can't initiate capture");
                    }
                }
            }
            protected void Stop()
            {
                if (null != Capturer)
                {
                    try
                    {
                        Capturer.StopCapture();
                    }
                    catch
                    {
                        MessageBox.Show("Capture Stop error");
                    }
                }
            }


            private void textBox3_TextChanged(object sender, EventArgs e)
            {

            }

            private void button4_Click(object sender, EventArgs e)
            {
                this.Hide();
                AdminLogin ADL = new AdminLogin();
                ADL.Show();
            }



            private void button1_Click(object sender, EventArgs e)
            {

            }



            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {
               
            }


            private void button3_Click(object sender, EventArgs e)
            {
               
                byte[] image = null;
                FileStream Stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader binr = new BinaryReader(Stream);
                image = binr.ReadBytes((int)Stream.Length);


            }

            private void radioButton1_CheckedChanged(object sender, EventArgs e)
            {

                Gender = "Male";
            }

            private void radioButton2_CheckedChanged(object sender, EventArgs e)
            {
                Gender = "Female";
            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

            private void button5_Click(object sender, EventArgs e)
            {

              

            }
        
            public Image UserFingerprintImage
            {
                get
                {
                    return pbExtractedImage.Image;
                }
                set
                {
                    pbExtractedImage.Image = value;
                }
            }


            private void button8_Click(object sender, EventArgs e)
            {
              
              
            }



        
        

            private void button7_Click(object sender, EventArgs e)
            {




            }

            private void pbUserFinger_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click_1(object sender, EventArgs e)
            {
               
            }

            private void pbxStudent_Click(object sender, EventArgs e)
            {

            }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ADB = new AdminDashboard();
            ADB.Show();
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
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
                pbxStudent.ImageLocation = imglocation;

            }
        }

        private void pbxStudent_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
          
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {

            OnTemplateCollect(Template);
        
            MemoryStream ms = new MemoryStream();
           
            Template.Serialize(ms);
            this.imgs = ms.ToArray();

       


            sqlcon.Open();
            OpenFileDialog Open = new OpenFileDialog();
            string CorrectFileName = System.IO.Path.GetFileName(Open.FileName);

            

            String query = "INSERT INTO Student_db (Student_Fullname, Student_RegNo, Student_Level, Student_Mobile, Student_Email, Student_DOB, Student_Gender, Student_Address, Sponsor_Name, Sponsor_Email, Sponsor_Mobile, DOR, SImagePath, Student_Fingerprint_RTB) VALUES ('" + txtFullname.Text + "', '" + txtRegNo.Text + "', '" + cmbLevel.Text + "',  '" + txtMobile.Text + "', '" + txtEmail.Text + "', '" + txtDOB.Text + "','" + Gender + "', '" + txtAddress.Text + "', '" + txtSponsor.Text + "', '" + txtSponsorE.Text + "', '" + txtSponsorM.Text + "', '" + DOR.Text + "', '\\Images\\" + CorrectFileName + "', @imgs)";

                String query2 = "INSERT INTO Total_Attendance_db (Student_Fullname, Student_RegNo, Student_Fingerprint_RTB) VALUES ( '" + txtFullname.Text + "', '" + txtRegNo.Text + "', @imgs)";


               
                cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.Add(new SqlParameter("@imgs", imgs));

                cmd2 = new SqlCommand(query2, sqlcon);
            //cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd2.Parameters.Add(new SqlParameter("@imgs", imgs));
            int N = cmd.ExecuteNonQuery();
                int M = cmd2.ExecuteNonQuery();

                sqlcon.Close();
            MessageBox.Show("Student Succesfully Registered");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                MessageBox.Show("Student already registered!");
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Stop();
            pbExtractedImage.Image = null;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Init();
            Start();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void txtDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }

    }


