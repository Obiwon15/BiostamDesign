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
using System.Timers;
//using WMPLib;

using DPFP;
using DPFP.Capture;



namespace BiostamDesign
{

    public partial class Attendance : Form, DPFP.Capture.EventHandler
    {
       // WMPLib.WindowsMediaPlayer wplay = new WMPLib.WindowsMediaPlayer();

        //System.Timers.Timer t;
        int h, m, s;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=SYLVAIN\OBIEFUNA;Initial Catalog=FINGERPRINTdb;Integrated Security=True");


        public DPFP.Capture.EventHandler EventHandler;
        public DPFP.Template Template;
        private DPFP.Capture.Capture Capturer;
        public delegate void OnTemplateEventHandler(DPFP.Template template);
        public DPFP.Processing.DataPurpose Purpose;
        public DPFP.Processing.DataPurpose Verify;

        private DPFP.Verification.Verification Verificator;
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

        public Attendance(string att, string colName, string duraName, string name)
        {
            InitializeComponent();
            AttLabel.Text = att;
            Sesslabel.Text = colName;
            DuraLabel.Text = duraName;
            sessionName.Text = name;
           // wplay.URL = @"C:\Users\Sylvanus\Documents\Final Year Project\Update 4\BiostamDesign\BiostamDesign\Resources\02. Send My Love (To Your New Lover) - (www.SongsLover.pk).mp3";
            //wplay.controls.stop();
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
            Sesslabel.Show();
            DuraLabel.Show();
            picBox.Hide();
         

        }


        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample/*, DPFP.Processing.DataPurpose Verification*/)
        {
           
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
            try
            {
                this.Invoke(new Function(delegate ()
                {
                    pbxVerify.Image = new Bitmap(bitmap, pbxVerify.Size);
                }

              ));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
   

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SessionName = sessionName.Text;
            ManualEntry MEN = new ManualEntry(SessionName);
            MEN.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are You Sure You Want To End Session?", "END SESSION?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
               
                    timer1.Stop();
                sqlcon.Open();
                string name = sessionName.Text;
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("UPDATE Total_Attendance_db set " + name + " = '0' WHERE " + name + " IS NULL ", sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
           
                this.Close();


                AttendanceTable ATT = new AttendanceTable();
                ATT.Show();

            }
            else if (dialog == DialogResult.No)
            {
                MessageBox.Show("Ok, Continue...");
            }
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
                //try {
                    bool verified = false;
                    foreach (DPFP.Template template in this.Samples.Keys)
                    {


                        DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                        Verificator.Verify(features, template, ref result);

                        if (result.Verified)
                        {
                            this.VerifiedObject = Samples[template];
                            verified = true;
                         



                            sqlcon.Open();
                            string name = sessionName.Text;
                            SqlCommand cmd = new SqlCommand();
                            cmd = new SqlCommand("UPDATE Total_Attendance_db set " + name + " = '1' WHERE Student_RegNo = '" + txtRegNo.Text.Trim() + "'", sqlcon);
                           int N = cmd.ExecuteNonQuery();
                            sqlcon.Close();


                        string query = "SELECT * FROM Total_Attendance_db WHERE Student_RegNo ='" + txtRegNo.Text.Trim() + "' ";
                        SqlDataAdapter SDA = new SqlDataAdapter(query, sqlcon);
                        DataTable dtb = new DataTable();
                        SDA.Fill(dtb);

                        if (dtb.Rows.Count > 0)
                        {

                            string fullname = dtb.Rows[0]["Student_Fullname"].ToString();
                            string Number = dtb.Rows[0]["Student_RegNo"].ToString();
                            string attendance = dtb.Rows[0]["Percentage"].ToString();
                            string total = dtb.Rows[0]["Total"].ToString();


                            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                            picBox.Image = Image.FromFile(paths + dtb.Rows[0]["SImagePath"].ToString());


                            //MessageBox.Show("Attendance Recorded. Press key c to clear!");

                            Image picture = picBox.Image;
                            ATTP att = new ATTP(fullname, Number, attendance, total, picture);
                            att.Show();
                        }




                    }
                    }
              

                this.IsVerificationComplete = verified;
                if (!verified)
                {
                    MessageBox.Show("Fingerprint not recognised.");
                }
            
            }
            else
            {
                MessageBox.Show("Cant recognize as a fingerprint.");
            }

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
   
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Init();
            Start();
            cp.EventHandler = this;
            ValidateUser();
         

        }


        private void button4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Stop();
            this.IsVerificationComplete = false;
            pbxVerify.Image = null;
            Template = null;


            Samples.Clear();
            txtRegNo.Clear();     

            }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
          {
              s += 1;
              if (s == 60)
              {
                  s = 0;
                  m += 1;
              }
              if (m == 60)
              {
                  m = 0;
                  h += 1;
              }
              if (s < 10)
              {
                  textBox3.Text = "0" + textBox3.Text;
              }
              if (m < 10)
              {
                  textBox2.Text = "0" + textBox2.Text;
              }
              textBox1.Text = h.ToString();
              textBox2.Text = m.ToString();
              textBox3.Text = s.ToString();
              if (textBox1.Text == textBox4.Text && textBox2.Text == textBox5.Text && textBox3.Text == textBox6.Text)
              {
                  timer1.Stop();
               //   wplay.controls.play();
              }

          }));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            label5.Text = "Running...";
            label5.ForeColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
           // wplay.controls.stop();

        }
    }    
    
        }

  
      
 

