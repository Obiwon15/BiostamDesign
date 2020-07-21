using System.Drawing;

namespace BiostamDesign
{
    partial class StudentPopup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelGe = new System.Windows.Forms.Label();
            this.labelGp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelRegNo = new System.Windows.Forms.Label();
            this.labelAtt = new System.Windows.Forms.Label();
            this.labelFullname = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.labelGe);
            this.panel1.Controls.Add(this.labelGp);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.labelRegNo);
            this.panel1.Controls.Add(this.labelAtt);
            this.panel1.Controls.Add(this.labelFullname);
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 534);
            this.panel1.TabIndex = 54;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(13, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "Students Attendance Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(228, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "Fullname";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(591, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(605, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 59;
            this.label6.Text = "Total";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Total Attendance:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(392, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 20);
            this.label14.TabIndex = 57;
            this.label14.Text = "Guardian Phone:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(392, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 20);
            this.label13.TabIndex = 56;
            this.label13.Text = "Guardian Email:";
            // 
            // labelGe
            // 
            this.labelGe.AutoSize = true;
            this.labelGe.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelGe.Location = new System.Drawing.Point(605, 346);
            this.labelGe.Name = "labelGe";
            this.labelGe.Size = new System.Drawing.Size(36, 23);
            this.labelGe.TabIndex = 55;
            this.labelGe.Text = "GE";
            // 
            // labelGp
            // 
            this.labelGp.AutoSize = true;
            this.labelGp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelGp.Location = new System.Drawing.Point(605, 382);
            this.labelGp.Name = "labelGp";
            this.labelGp.Size = new System.Drawing.Size(37, 23);
            this.labelGp.TabIndex = 54;
            this.labelGp.Text = "GP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(392, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "Attendance Rate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(392, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Reg. Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Name:";
            // 
            // labelRegNo
            // 
            this.labelRegNo.AutoSize = true;
            this.labelRegNo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelRegNo.Location = new System.Drawing.Point(587, 227);
            this.labelRegNo.Name = "labelRegNo";
            this.labelRegNo.Size = new System.Drawing.Size(72, 23);
            this.labelRegNo.TabIndex = 50;
            this.labelRegNo.Text = "RegNo";
            // 
            // labelAtt
            // 
            this.labelAtt.AutoSize = true;
            this.labelAtt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelAtt.Location = new System.Drawing.Point(605, 309);
            this.labelAtt.Name = "labelAtt";
            this.labelAtt.Size = new System.Drawing.Size(120, 23);
            this.labelAtt.TabIndex = 49;
            this.labelAtt.Text = "Attendance";
            this.labelAtt.Click += new System.EventHandler(this.labelAtt_Click);
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullname.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelFullname.Location = new System.Drawing.Point(532, 183);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(94, 23);
            this.labelFullname.TabIndex = 48;
            this.labelFullname.Text = "Fullname";
            // 
            // picBox
            // 
            this.picBox.Image = global::BiostamDesign.Properties.Resources.cap;
            this.picBox.Location = new System.Drawing.Point(57, 74);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(208, 331);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 46;
            this.picBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Name/RegNo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(363, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 31);
            this.label5.TabIndex = 42;
            this.label5.Text = "Students Attendance Record";
            // 
            // StudentPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 520);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StudentPopup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPopup";
            this.Load += new System.EventHandler(this.StudentPopup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelGe;
        private System.Windows.Forms.Label labelGp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelRegNo;
        private System.Windows.Forms.Label labelAtt;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        //private string fullname;
        //private string number;
        //private string total;
        //private Image pic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        //public StudentPopup(string fullname, string number, string total, Image pic)
        //{
        //    this.fullname = fullname;
        //    this.number = number;
        //    this.total = total;
        //    this.pic = pic;
        //}
    }
}