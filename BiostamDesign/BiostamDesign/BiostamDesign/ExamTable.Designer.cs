namespace BiostamDesign
{
    partial class ExamTable
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_Attendance_dbTableAdapter = new BiostamDesign.FINGERPRINTdbDataSet3TableAdapters.Total_Attendance_dbTableAdapter();
            this.fINGERPRINTdbDataSet3 = new BiostamDesign.FINGERPRINTdbDataSet3();
            this.totalAttendancedbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.attGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fINGERPRINTdbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAttendancedbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(238, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 78;
            this.label2.Text = "Email Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(403, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 20);
            this.txtEmail.TabIndex = 76;
            // 
            // SUM
            // 
            this.SUM.DataPropertyName = "Student_RegNo";
            this.SUM.HeaderText = "SUM_TOTAL";
            this.SUM.Name = "SUM";
            // 
            // total_Attendance_dbTableAdapter
            // 
            this.total_Attendance_dbTableAdapter.ClearBeforeFill = true;
            // 
            // fINGERPRINTdbDataSet3
            // 
            this.fINGERPRINTdbDataSet3.DataSetName = "FINGERPRINTdbDataSet3";
            this.fINGERPRINTdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalAttendancedbBindingSource
            // 
            this.totalAttendancedbBindingSource.DataMember = "Total_Attendance_db";
            this.totalAttendancedbBindingSource.DataSource = this.fINGERPRINTdbDataSet3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 77;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.Location = new System.Drawing.Point(762, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 49);
            this.button6.TabIndex = 75;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(112, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 28);
            this.button2.TabIndex = 74;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(662, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 73;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(345, 433);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 28);
            this.button4.TabIndex = 72;
            this.button4.Text = "Send Update to Email";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(215, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 71;
            this.label5.Text = "Search  Student:";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(403, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(313, 29);
            this.txtSearch.TabIndex = 70;
            // 
            // attGrid
            // 
            this.attGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SUM});
            this.attGrid.Location = new System.Drawing.Point(26, 96);
            this.attGrid.Name = "attGrid";
            this.attGrid.Size = new System.Drawing.Size(943, 329);
            this.attGrid.TabIndex = 69;
            // 
            // ExamTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.attGrid);
            this.Name = "ExamTable";
            this.Text = "ExamTable";
            ((System.ComponentModel.ISupportInitialize)(this.fINGERPRINTdbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAttendancedbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUM;
        private FINGERPRINTdbDataSet3TableAdapters.Total_Attendance_dbTableAdapter total_Attendance_dbTableAdapter;
        private FINGERPRINTdbDataSet3 fINGERPRINTdbDataSet3;
        private System.Windows.Forms.BindingSource totalAttendancedbBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView attGrid;
    }
}