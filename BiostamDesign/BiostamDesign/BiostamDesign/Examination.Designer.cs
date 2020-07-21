namespace BiostamDesign
{
    partial class Examination
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DuraLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AttLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pbxVerify = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SessionName = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DuraLabel
            // 
            this.DuraLabel.AutoSize = true;
            this.DuraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuraLabel.Location = new System.Drawing.Point(139, 220);
            this.DuraLabel.Name = "DuraLabel";
            this.DuraLabel.Size = new System.Drawing.Size(78, 20);
            this.DuraLabel.TabIndex = 66;
            this.DuraLabel.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Experiencing FingerPrint Difficulties?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(238, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 36);
            this.label1.TabIndex = 64;
            this.label1.Text = "Please place your thumb on the scanner to begin enrollment";
            // 
            // AttLabel
            // 
            this.AttLabel.AutoSize = true;
            this.AttLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttLabel.Location = new System.Drawing.Point(436, 5);
            this.AttLabel.Name = "AttLabel";
            this.AttLabel.Size = new System.Drawing.Size(125, 24);
            this.AttLabel.TabIndex = 63;
            this.AttLabel.Text = "Examination";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(555, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 30);
            this.button2.TabIndex = 62;
            this.button2.Text = "Manual Input";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pbxVerify
            // 
            this.pbxVerify.BackColor = System.Drawing.Color.Transparent;
            this.pbxVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxVerify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxVerify.Location = new System.Drawing.Point(480, 96);
            this.pbxVerify.Name = "pbxVerify";
            this.pbxVerify.Size = new System.Drawing.Size(202, 267);
            this.pbxVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxVerify.TabIndex = 61;
            this.pbxVerify.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(482, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 60;
            this.button1.Text = "End Session";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Reg No:";
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(480, 390);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(100, 20);
            this.txtRegNo.TabIndex = 73;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MidnightBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Location = new System.Drawing.Point(332, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 30);
            this.button4.TabIndex = 68;
            this.button4.Text = "Start Capture";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button4_KeyPress_1);
            // 
            // SessionName
            // 
            this.SessionName.AutoSize = true;
            this.SessionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionName.Location = new System.Drawing.Point(139, 287);
            this.SessionName.Name = "SessionName";
            this.SessionName.Size = new System.Drawing.Size(119, 20);
            this.SessionName.TabIndex = 71;
            this.SessionName.Text = "SessionName";
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox.Location = new System.Drawing.Point(785, 162);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(150, 145);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 72;
            this.picBox.TabStop = false;
            // 
            // Examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 613);
            this.ControlBox = false;
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.SessionName);
            this.Controls.Add(this.DuraLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AttLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pbxVerify);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.button4);
            this.Name = "Examination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examination";
            this.Load += new System.EventHandler(this.Examination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DuraLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AttLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pbxVerify;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label SessionName;
        private System.Windows.Forms.PictureBox picBox;
    }
}