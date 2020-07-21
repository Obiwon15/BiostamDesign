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
using System.Globalization;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Xml.Serialization;
using DPFP;
using DPFP.Capture;



namespace BiostamDesign
{
    public partial class Examination : Form, DPFP.Capture.EventHandler
    {
        public Examination(string att, string duraName, string course)
        {
            InitializeComponent();

            AttLabel.Text = att;
            //Sesslabel.Text = colName;
            DuraLabel.Text = duraName;
            SessionName.Text = course;


        }


        private void Examination_Load(object sender, EventArgs e)
        {
            picBox.Hide();
           // SessionName.Hide();
        }





        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");


        public DPFP.Capture.EventHandler EventHandler;
        public DPFP.Template Template;
        private DPFP.Capture.Capture Capturer;
        public delegate void OnTemplateEventHandler(DPFP.Template template);
        public DPFP.Processing.DataPurpose Purpose;
        public DPFP.Processing.DataPurpose Verify;

        private DPFP.Verification.Verification Verificator;
        //private DPFP.Processing.Enrollment Enroller;
        public Dictionary<DPFP.Template, object> Samples = new Dictionary<DPFP.Template, object>();
        delegate void Function();
        private bool isVerificationComplete = false;
        public event StatusChangedEventHandler VerificationStatusChanged;

        public byte[] imgs;

        DPFP.Capture.SampleConversion sp = new DPFP.Capture.SampleConversion();
        DPFP.Capture.Capture cp = new DPFP.Capture.Capture();
        DPFP.Sample sample = new DPFP.Sample();

        SqlCommand cmd = new SqlCommand();

        public Image byteArraytoImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image imgs = Image.FromStream(ms, true);
            return imgs;
        }


        public bool IsVerificationComplete
        {
            get { return this.isVerificationComplete; }
            set
            {
                if (value != this.isVerificationComplete)
                {
                    this.isVerificationComplete = value;
                    if (this.VerificationStatusChanged != null)
                    {
                        this.VerificationStatusChanged(this, new StatusChangedEventArgs(value));
                    }
                }

            }
        }
        public object VerifiedObject
        {
            get;
            private set;
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            AttLabel.Show();
            //Sesslabel.Show();
            DuraLabel.Show();
            //sessionName.Hide();
            SessionName.Hide();

        }

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample/*, DPFP.Processing.DataPurpose Verification*/)
        {
            //sp.ConvertToPicture(Sample, ref imgs);
            //pbxVerify.Image = imgs;

            Process(Sample);

        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {

        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            imgs = null;
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
                MessageBox.Show("Good");
            else
                MessageBox.Show("Bad");
        }
        public void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate ()
            {
                pbxVerify.Image = new Bitmap(bitmap, pbxVerify.Size);
            }

            ));
        }

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);

            return bitmap;

        }
        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);


            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;

        }
        protected virtual void Init()
        {

            try
            {
                Capturer = new DPFP.Capture.Capture();
                Verificator = new DPFP.Verification.Verification();
                if (null != Capturer)
                    Capturer.EventHandler = this;
            }
            catch
            {
                MessageBox.Show("Can't initiate capture");
            }
        }

        //public void OnTemplate(DPFP.Template template)
        //{
        //    this.Invoke((Action)(delegate ()
        //    {
        //        Template = template;
        //        if (Template == null)
        //            MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment!");
        //    }));
        //}

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
        //private void SetPrompt(string prompt)
        //{
        //    this.Invoke(new Function(delegate ()
        //    {
        //        prompt.Text = prompt;
        //    }
        //    ));
        //}



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        protected void Process(DPFP.Sample Sample)
        {

            DrawPicture(FingerPrintUtility.ConvertSampleToBitmap(Sample));

            DPFP.FeatureSet features = FingerPrintUtility.ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);


            if (features != null)
            {
                try
                {
                    bool verified = false;
                    foreach (DPFP.Template template in this.Samples.Keys)
                    {


                        DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                        Verificator.Verify(features, template, ref result);

                        if (result.Verified)
                        {
                            this.VerifiedObject = Samples[template];
                            verified = true;
                            //MessageBox.Show("verified.");
                            sqlcon.Open();
                            string name = SessionName.Text;
                            SqlCommand cmd = new SqlCommand();
                            cmd = new SqlCommand("UPDATE Examination_db set Attendance = '1' WHERE Student_RegNo = '" + txtRegNo.Text.Trim() + "'", sqlcon);
                            cmd.ExecuteNonQuery();
                            sqlcon.Close();
                            //MessageBox.Show("Attendance Recorded");

                            //SET(" + colName + ") = ('1') WHERE Student_RegNo = '" + txtRegNo.Text.Trim() +"'
                            //cmd.Parameters.AddWithValue("+ colName +", 1);
                            //MessageBox.Show("Scan successful!");


                            string query = "SELECT * FROM Total_Attendance_db WHERE Student_RegNo = '" + txtRegNo.Text.Trim() + "'";
                            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
                            DataTable dtb = new DataTable();
                            SDA.Fill(dtb);

                            if (dtb.Rows.Count == 1)
                            {
                                string fullname = dtb.Rows[0]["Student_Fullname"].ToString();
                                string Number = dtb.Rows[0]["Student_RegNo"].ToString();
                                string attendance = dtb.Rows[0]["Percentage"].ToString();
                                string total = dtb.Rows[0]["Total"].ToString();


                                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                                picBox.Image = Image.FromFile(paths + dtb.Rows[0]["SImagePath"].ToString());

                                Image picture = picBox.Image;


                                StudentPopup SPO = new StudentPopup(fullname, Number, attendance, total, picture, SessionName.Text);
                                SPO.Show();


                            }
                        }
                        
                    }
                    this.IsVerificationComplete = verified;
                    if (!verified)
                    {
                        MessageBox.Show("Fingerprint not recognised.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Cant recognize as a fingerprint.");
            }

            //Template = new DPFP.Template();
            //Template.DeSerialize(MS);
            //if (features != null)
            //{
            //    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
            //    DPFP.Template template = new DPFP.Template();
            //}

            //Template.DeSerialize(MS);
            //DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            //SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            //DataTable dtb = new DataTable();
            //SDA.Fill(dtb);

            //if (dtb.Rows.Count == 1)
            //{
            //    imgs = (Byte[])dtb.Rows[0]["Student_Fingerprint_LTB"];

            //this.Hide();
            //MainForm MF = new MainForm(newImage, "Welcome " + label2.Text);
            //MF.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Ooops somethings wong!");
            //}
        }

        public void ValidateUser()
        {
            sqlcon.Open();
            string query = "SELECT Student_RegNo, Student_Fingerprint_RTB FROM Student_db WHERE Student_RegNo ='" + txtRegNo.Text.Trim() + "'";
            using (SqlCommand cmd = new SqlCommand(query, sqlcon))
            {
                using (SqlDataReader data = cmd.ExecuteReader())
                {
                    while (data.Read())
                    {
                        byte[] imgs = (byte[])data["Student_Fingerprint_RTB"];
                        Samples.Add(new DPFP.Template(new MemoryStream(imgs)), null);


                        //MessageBox.Show("scan successful");
                    }
                }
            }
            sqlcon.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Stop();
            this.IsVerificationComplete = false;
            pbxVerify.Image = null;
            Template = null;


            Samples.Clear();
            txtRegNo.Clear();
            //sqlcon.Open();
            //string query = "SELECT Student_RegNo, Student_Fingerprint_LTB FROM Student_db";



            //SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            //SqlCommandBuilder cbd = new SqlCommandBuilder(SDA);
            ////DataTable dtb = new DataTable();

            //DataSet dtb = new DataSet();   
            //SDA.Fill(dtb);


            ////Image bytimg;

            //if (dtb != null && dtb.Tables != null && dtb.Tables.Count == 1 && dtb.Tables[0].Rows[1]["Student_Fingerprint_LTB"] != System.DBNull.Value)
            //{

            //    //     byte[] images = (byte[])(dtb.Tables[0].Rows[0]["IMAGE"]);

            //byte[] imgs = (byte[])(dtb.Tables[0].Rows[1]["Student_Fingerprint_LTB"]);

            //txtRegNo.Text = dtb.Tables[0].Rows[0]["Student_RegNo"].ToString();







            //cmd = new SqlCommand("SELECT Student_RegNo FROM Student_db  WHERE Student_RegNo = '" + txtReg.Text.Trim() + "'");
            //cmd.ExecuteNonQuery();

            //SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
            //DataTable dtb = new DataTable();
            //SDA.Fill(dtb);


            //Template = new DPFP.Template();
            //byte[] imgs = Template.Bytes;

            //MemoryStream MS = new MemoryStream(imgs);
            //pbxVerify.Image = Image.FromStream(MS);

            //Image newImage = byteArraytoImage(imgs);
            //pbxVerify.Image = Image.FromStream(MS);
            //pbxVerify.Image = newImage;


        }



        private void button1_Click_1(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are You Sure You Want To End Session?", "END SESSION?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {

                timer1.Stop();
                sqlcon.Open();
                string name = SessionName.Text;
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("UPDATE Examination_db set " + name + " = '0' WHERE " + name + " IS NULL ", sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                //MessageBox.Show("Completed");
                this.Close();




                //DialogResult dialogue = MessageBox.Show("Would You Like to Have the Updated Attendance Sent to Your Email?", "Send Update to Email?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (dialogue == DialogResult.Yes)
                //{
                //    //Email code
                //    MessageBox.Show("Email Sent Successfully!");
                //    timer1.Stop();
                //    this.Close();
                //}
                //else if (dialogue == DialogResult.No)
                //{
                //    MessageBox.Show("Alright, Have a Nice day!");
                //    this.Close();
                //}

            }
            else if (dialog == DialogResult.No)
            {
                MessageBox.Show("Ok, Continue...");
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Init();
            Start();
            cp.EventHandler = this;
            ValidateUser();
            //sqlcon.Open();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            ExamManualEntry MEN = new ExamManualEntry(SessionName.Text);
            MEN.Show();
        }

        private void button4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Stop();
            this.IsVerificationComplete = false;
            pbxVerify.Image = null;
            Template = null;


            Samples.Clear();

            txtRegNo.Clear();




        }

     
    }



    }