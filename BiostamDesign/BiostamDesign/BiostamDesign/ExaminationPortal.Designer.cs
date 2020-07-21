namespace BiostamDesign
{
    partial class ExaminationPortal
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Duration = new System.Windows.Forms.ComboBox();
            this.txtAlert = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.txtsess = new System.Windows.Forms.Label();
            this.textCourse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Controls.Add(this.Duration);
            this.groupBox1.Controls.Add(this.txtAlert);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.txtsess);
            this.groupBox1.Controls.Add(this.textCourse);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 390);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Session Portal";
            // 
            // Duration
            // 
            this.Duration.FormattingEnabled = true;
            this.Duration.Items.AddRange(new object[] {
            "1 Hour",
            "2 Hours",
            "3 Hours",
            "4 Hours",
            "5 Hours"});
            this.Duration.Location = new System.Drawing.Point(238, 264);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(308, 29);
            this.Duration.TabIndex = 12;
            // 
            // txtAlert
            // 
            this.txtAlert.AutoSize = true;
            this.txtAlert.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlert.ForeColor = System.Drawing.Color.Green;
            this.txtAlert.Location = new System.Drawing.Point(27, 347);
            this.txtAlert.Name = "txtAlert";
            this.txtAlert.Size = new System.Drawing.Size(64, 24);
            this.txtAlert.TabIndex = 11;
            this.txtAlert.Text = "Alert!";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(238, 106);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(308, 28);
            this.date.TabIndex = 10;
            // 
            // txtsess
            // 
            this.txtsess.AutoSize = true;
            this.txtsess.BackColor = System.Drawing.Color.Black;
            this.txtsess.ForeColor = System.Drawing.Color.White;
            this.txtsess.Location = new System.Drawing.Point(27, 112);
            this.txtsess.Name = "txtsess";
            this.txtsess.Size = new System.Drawing.Size(0, 21);
            this.txtsess.TabIndex = 8;
            // 
            // textCourse
            // 
            this.textCourse.Location = new System.Drawing.Point(238, 184);
            this.textCourse.Name = "textCourse";
            this.textCourse.Size = new System.Drawing.Size(308, 28);
            this.textCourse.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "EXAM DURATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "COURSE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "DATE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 28);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "SESSION ID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(712, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 52);
            this.button3.TabIndex = 12;
            this.button3.Text = "SAVE DETAILS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(712, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "BEGIN EXAM SESSION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExaminationPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "ExaminationPortal";
            this.Size = new System.Drawing.Size(914, 430);
            this.Load += new System.EventHandler(this.ExaminationPortal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Duration;
        private System.Windows.Forms.Label txtAlert;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label txtsess;
        private System.Windows.Forms.TextBox textCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}
