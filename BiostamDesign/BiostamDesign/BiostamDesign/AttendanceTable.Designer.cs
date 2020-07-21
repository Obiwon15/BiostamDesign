namespace BiostamDesign
{
    partial class AttendanceTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceTable));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Attachment1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.totalAttendancedbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINGERPRINTdbDataSet3 = new BiostamDesign.FINGERPRINTdbDataSet3();
            this.total_Attendance_dbTableAdapter = new BiostamDesign.FINGERPRINTdbDataSet3TableAdapters.Total_Attendance_dbTableAdapter();
            this.fINGERPRINTdbDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentRegNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUM_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVERAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERCENTAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAttendancedbBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fINGERPRINTdbDataSet3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.totalAttendancedbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.totalAttendancedbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINGERPRINTdbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINGERPRINTdbDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAttendancedbBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINGERPRINTdbDataSet3BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAttendancedbBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(381, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(313, 29);
            this.txtSearch.TabIndex = 52;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtReg_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(193, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Search  Student:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(640, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 62;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(113, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 28);
            this.button2.TabIndex = 63;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.Location = new System.Drawing.Point(740, 62);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 49);
            this.button6.TabIndex = 65;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(381, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 20);
            this.txtEmail.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(216, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 68;
            this.label2.Text = "Email Address:";
            // 
            // Attachment1
            // 
            this.Attachment1.Location = new System.Drawing.Point(615, 85);
            this.Attachment1.Name = "Attachment1";
            this.Attachment1.Size = new System.Drawing.Size(100, 20);
            this.Attachment1.TabIndex = 69;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(381, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 38);
            this.button3.TabIndex = 72;
            this.button3.Text = "Send To Email";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // totalAttendancedbBindingSource
            // 
            this.totalAttendancedbBindingSource.DataMember = "Total_Attendance_db";
            this.totalAttendancedbBindingSource.DataSource = this.fINGERPRINTdbDataSet3;
            // 
            // fINGERPRINTdbDataSet3
            // 
            this.fINGERPRINTdbDataSet3.DataSetName = "FINGERPRINTdbDataSet3";
            this.fINGERPRINTdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // total_Attendance_dbTableAdapter
            // 
            this.total_Attendance_dbTableAdapter.ClearBeforeFill = true;
            // 
            // fINGERPRINTdbDataSet3BindingSource
            // 
            this.fINGERPRINTdbDataSet3BindingSource.DataSource = this.fINGERPRINTdbDataSet3;
            this.fINGERPRINTdbDataSet3BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentRegNoDataGridViewTextBoxColumn,
            this.studentFullnameDataGridViewTextBoxColumn,
            this.session1DataGridViewTextBoxColumn,
            this.session2DataGridViewTextBoxColumn,
            this.session3DataGridViewTextBoxColumn,
            this.session4DataGridViewTextBoxColumn,
            this.session5DataGridViewTextBoxColumn,
            this.session6DataGridViewTextBoxColumn,
            this.session7DataGridViewTextBoxColumn,
            this.session8DataGridViewTextBoxColumn,
            this.session9DataGridViewTextBoxColumn,
            this.session10DataGridViewTextBoxColumn,
            this.SUM_TOTAL,
            this.AVERAGE,
            this.PERCENTAGE});
            this.dataGridView1.DataSource = this.totalAttendancedbBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(23, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(943, 279);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // studentRegNoDataGridViewTextBoxColumn
            // 
            this.studentRegNoDataGridViewTextBoxColumn.DataPropertyName = "Student_RegNo";
            this.studentRegNoDataGridViewTextBoxColumn.HeaderText = "Student_RegNo";
            this.studentRegNoDataGridViewTextBoxColumn.Name = "studentRegNoDataGridViewTextBoxColumn";
            this.studentRegNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentFullnameDataGridViewTextBoxColumn
            // 
            this.studentFullnameDataGridViewTextBoxColumn.DataPropertyName = "Student_Fullname";
            this.studentFullnameDataGridViewTextBoxColumn.HeaderText = "Student_Fullname";
            this.studentFullnameDataGridViewTextBoxColumn.Name = "studentFullnameDataGridViewTextBoxColumn";
            this.studentFullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // session1DataGridViewTextBoxColumn
            // 
            this.session1DataGridViewTextBoxColumn.DataPropertyName = "Session1";
            this.session1DataGridViewTextBoxColumn.HeaderText = "Session1";
            this.session1DataGridViewTextBoxColumn.Name = "session1DataGridViewTextBoxColumn";
            this.session1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // session2DataGridViewTextBoxColumn
            // 
            this.session2DataGridViewTextBoxColumn.DataPropertyName = "Session2";
            this.session2DataGridViewTextBoxColumn.HeaderText = "Session2";
            this.session2DataGridViewTextBoxColumn.Name = "session2DataGridViewTextBoxColumn";
            this.session2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // session3DataGridViewTextBoxColumn
            // 
            this.session3DataGridViewTextBoxColumn.DataPropertyName = "Session3";
            this.session3DataGridViewTextBoxColumn.HeaderText = "Session3";
            this.session3DataGridViewTextBoxColumn.Name = "session3DataGridViewTextBoxColumn";
            this.session3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // session4DataGridViewTextBoxColumn
            // 
            this.session4DataGridViewTextBoxColumn.DataPropertyName = "Session4";
            this.session4DataGridViewTextBoxColumn.HeaderText = "Session4";
            this.session4DataGridViewTextBoxColumn.Name = "session4DataGridViewTextBoxColumn";
            this.session4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // session5DataGridViewTextBoxColumn
            // 
            this.session5DataGridViewTextBoxColumn.DataPropertyName = "Session5";
            this.session5DataGridViewTextBoxColumn.HeaderText = "Session5";
            this.session5DataGridViewTextBoxColumn.Name = "session5DataGridViewTextBoxColumn";
            this.session5DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // session6DataGridViewTextBoxColumn
            // 
            this.session6DataGridViewTextBoxColumn.DataPropertyName = "Session6";
            this.session6DataGridViewTextBoxColumn.HeaderText = "Session6";
            this.session6DataGridViewTextBoxColumn.Name = "session6DataGridViewTextBoxColumn";
            this.session6DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // session7DataGridViewTextBoxColumn
            // 
            this.session7DataGridViewTextBoxColumn.DataPropertyName = "Session7";
            this.session7DataGridViewTextBoxColumn.HeaderText = "Session7";
            this.session7DataGridViewTextBoxColumn.Name = "session7DataGridViewTextBoxColumn";
            this.session7DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // session8DataGridViewTextBoxColumn
            // 
            this.session8DataGridViewTextBoxColumn.DataPropertyName = "Session8";
            this.session8DataGridViewTextBoxColumn.HeaderText = "Session8";
            this.session8DataGridViewTextBoxColumn.Name = "session8DataGridViewTextBoxColumn";
            this.session8DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // session9DataGridViewTextBoxColumn
            // 
            this.session9DataGridViewTextBoxColumn.DataPropertyName = "Session9";
            this.session9DataGridViewTextBoxColumn.HeaderText = "Session9";
            this.session9DataGridViewTextBoxColumn.Name = "session9DataGridViewTextBoxColumn";
            this.session9DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // session10DataGridViewTextBoxColumn
            // 
            this.session10DataGridViewTextBoxColumn.DataPropertyName = "Session10";
            this.session10DataGridViewTextBoxColumn.HeaderText = "Session10";
            this.session10DataGridViewTextBoxColumn.Name = "session10DataGridViewTextBoxColumn";
            this.session10DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SUM_TOTAL
            // 
            this.SUM_TOTAL.HeaderText = "SUM_TOTAL";
            this.SUM_TOTAL.Name = "SUM_TOTAL";
            this.SUM_TOTAL.ReadOnly = true;
            // 
            // AVERAGE
            // 
            this.AVERAGE.HeaderText = "AVERAGE";
            this.AVERAGE.Name = "AVERAGE";
            this.AVERAGE.ReadOnly = true;
            // 
            // PERCENTAGE
            // 
            this.PERCENTAGE.HeaderText = "PERCENTAGE";
            this.PERCENTAGE.Name = "PERCENTAGE";
            this.PERCENTAGE.ReadOnly = true;
            // 
            // totalAttendancedbBindingSource2
            // 
            this.totalAttendancedbBindingSource2.DataMember = "Total_Attendance_db";
            this.totalAttendancedbBindingSource2.DataSource = this.fINGERPRINTdbDataSet3BindingSource1;
            // 
            // fINGERPRINTdbDataSet3BindingSource1
            // 
            this.fINGERPRINTdbDataSet3BindingSource1.DataSource = this.fINGERPRINTdbDataSet3;
            this.fINGERPRINTdbDataSet3BindingSource1.Position = 0;
            // 
            // totalAttendancedbBindingSource1
            // 
            this.totalAttendancedbBindingSource1.DataMember = "Total_Attendance_db";
            this.totalAttendancedbBindingSource1.DataSource = this.fINGERPRINTdbDataSet3BindingSource;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(825, 488);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 31);
            this.button4.TabIndex = 74;
            this.button4.Text = "Export";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(629, 488);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 31);
            this.button5.TabIndex = 75;
            this.button5.Text = "Browse Location";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(113, 490);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(510, 29);
            this.textBox1.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(118, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 22);
            this.label3.TabIndex = 77;
            this.label3.Text = "Browse Location For ExportFile...";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // AttendanceTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 531);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Attachment1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AttendanceTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceTable";
            this.Load += new System.EventHandler(this.AttendanceTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalAttendancedbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINGERPRINTdbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINGERPRINTdbDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAttendancedbBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINGERPRINTdbDataSet3BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAttendancedbBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private FINGERPRINTdbDataSet3 fINGERPRINTdbDataSet3;
        private System.Windows.Forms.BindingSource totalAttendancedbBindingSource;
        private FINGERPRINTdbDataSet3TableAdapters.Total_Attendance_dbTableAdapter total_Attendance_dbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sess23DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sess25DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sess26DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Attachment1;
        private System.Windows.Forms.BindingSource fINGERPRINTdbDataSet3BindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource totalAttendancedbBindingSource1;
        private System.Windows.Forms.BindingSource totalAttendancedbBindingSource2;
        private System.Windows.Forms.BindingSource fINGERPRINTdbDataSet3BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentRegNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn session1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn session2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn session3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn session4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn session5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn session6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn session7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn session8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn session9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn session10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUM_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVERAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERCENTAGE;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}