namespace BiostamDesign
{
    partial class SessionPortal
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
            this.Sess_text = new System.Windows.Forms.TextBox();
            this.txtsess = new System.Windows.Forms.Label();
            this.textCourse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.Duration);
            this.groupBox1.Controls.Add(this.txtAlert);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.Sess_text);
            this.groupBox1.Controls.Add(this.txtsess);
            this.groupBox1.Controls.Add(this.textCourse);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 390);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Session Portal";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.Duration.Location = new System.Drawing.Point(238, 281);
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
            this.date.Location = new System.Drawing.Point(238, 165);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(308, 28);
            this.date.TabIndex = 10;
            // 
            // Sess_text
            // 
            this.Sess_text.Location = new System.Drawing.Point(238, 105);
            this.Sess_text.Name = "Sess_text";
            this.Sess_text.Size = new System.Drawing.Size(308, 28);
            this.Sess_text.TabIndex = 9;
            // 
            // txtsess
            // 
            this.txtsess.AutoSize = true;
            this.txtsess.BackColor = System.Drawing.Color.Black;
            this.txtsess.ForeColor = System.Drawing.Color.White;
            this.txtsess.Location = new System.Drawing.Point(27, 112);
            this.txtsess.Name = "txtsess";
            this.txtsess.Size = new System.Drawing.Size(158, 21);
            this.txtsess.TabIndex = 8;
            this.txtsess.Text = "SESSION NAME";
            // 
            // textCourse
            // 
            this.textCourse.Location = new System.Drawing.Point(238, 223);
            this.textCourse.Name = "textCourse";
            this.textCourse.Size = new System.Drawing.Size(308, 28);
            this.textCourse.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "DURATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 230);
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
            this.label2.Location = new System.Drawing.Point(27, 172);
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
            this.button3.Location = new System.Drawing.Point(708, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 52);
            this.button3.TabIndex = 8;
            this.button3.Text = "SAVE DETAILS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(708, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(708, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "BEGIN SESSION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SessionPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "SessionPortal";
            this.Size = new System.Drawing.Size(1044, 436);
            this.Load += new System.EventHandler(this.SessionPortal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Duration;
        private System.Windows.Forms.Label txtAlert;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox Sess_text;
        private System.Windows.Forms.Label txtsess;
        private System.Windows.Forms.TextBox textCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
