namespace _401AZ_PROJECT
{
    partial class Timetable_form
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
            this.mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            this.mySqlDataAdapter2 = new MySqlConnector.MySqlDataAdapter();
            this.dgv_classes = new System.Windows.Forms.DataGridView();
            this.Lbl_ClassNameSearch = new System.Windows.Forms.Label();
            this.Txt_class_search = new System.Windows.Forms.TextBox();
            this.Btn_search_timetable = new System.Windows.Forms.Button();
            this.Btn_SaveNew = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.btn_EnableSearch = new System.Windows.Forms.Button();
            this.Lbl_ClassID = new System.Windows.Forms.Label();
            this.Lbl_Day = new System.Windows.Forms.Label();
            this.Lbl_StartTime = new System.Windows.Forms.Label();
            this.Lbl_EndTimeDay = new System.Windows.Forms.Label();
            this.Tb_ClassId = new System.Windows.Forms.TextBox();
            this.cb_Day = new System.Windows.Forms.ComboBox();
            this.Dtp_Start_Time = new System.Windows.Forms.DateTimePicker();
            this.Dtp_End_Time = new System.Windows.Forms.DateTimePicker();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Lbl_Teacher_First_Name = new System.Windows.Forms.Label();
            this.Lbl_Teacher_Last_Name = new System.Windows.Forms.Label();
            this.Lbl_Subject = new System.Windows.Forms.Label();
            this.Cb_T_Fname = new System.Windows.Forms.ComboBox();
            this.Cb_T_Lname = new System.Windows.Forms.ComboBox();
            this.btn_InsertNew = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Lbl_TeacherId = new System.Windows.Forms.Label();
            this.Cb_TeacherId = new System.Windows.Forms.ComboBox();
            this.Txtb_Subject = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).BeginInit();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateBatchSize = 0;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // mySqlDataAdapter2
            // 
            this.mySqlDataAdapter2.DeleteCommand = null;
            this.mySqlDataAdapter2.InsertCommand = null;
            this.mySqlDataAdapter2.SelectCommand = null;
            this.mySqlDataAdapter2.UpdateBatchSize = 0;
            this.mySqlDataAdapter2.UpdateCommand = null;
            // 
            // dgv_classes
            // 
            this.dgv_classes.AllowUserToAddRows = false;
            this.dgv_classes.AllowUserToDeleteRows = false;
            this.dgv_classes.AllowUserToResizeColumns = false;
            this.dgv_classes.AllowUserToResizeRows = false;
            this.dgv_classes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_classes.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_classes.GridColor = System.Drawing.Color.DarkBlue;
            this.dgv_classes.Location = new System.Drawing.Point(12, 222);
            this.dgv_classes.Name = "dgv_classes";
            this.dgv_classes.ReadOnly = true;
            this.dgv_classes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_classes.RowHeadersWidth = 51;
            this.dgv_classes.RowTemplate.Height = 24;
            this.dgv_classes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_classes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_classes.Size = new System.Drawing.Size(1543, 523);
            this.dgv_classes.TabIndex = 0;
            this.dgv_classes.SelectionChanged += new System.EventHandler(this.dgv_classes_SelectionChanged);
            // 
            // Lbl_ClassNameSearch
            // 
            this.Lbl_ClassNameSearch.AutoSize = true;
            this.Lbl_ClassNameSearch.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ClassNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Lbl_ClassNameSearch.Location = new System.Drawing.Point(13, 195);
            this.Lbl_ClassNameSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ClassNameSearch.Name = "Lbl_ClassNameSearch";
            this.Lbl_ClassNameSearch.Size = new System.Drawing.Size(150, 20);
            this.Lbl_ClassNameSearch.TabIndex = 1;
            this.Lbl_ClassNameSearch.Text = "Classroom name";
            // 
            // Txt_class_search
            // 
            this.Txt_class_search.Enabled = false;
            this.Txt_class_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Txt_class_search.Location = new System.Drawing.Point(200, 188);
            this.Txt_class_search.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_class_search.Name = "Txt_class_search";
            this.Txt_class_search.Size = new System.Drawing.Size(117, 27);
            this.Txt_class_search.TabIndex = 2;
            this.Txt_class_search.TextChanged += new System.EventHandler(this.Txt_class_search_TextChanged);
            this.Txt_class_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_class_search_KeyDown);
            // 
            // Btn_search_timetable
            // 
            this.Btn_search_timetable.Enabled = false;
            this.Btn_search_timetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_search_timetable.Location = new System.Drawing.Point(325, 188);
            this.Btn_search_timetable.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_search_timetable.Name = "Btn_search_timetable";
            this.Btn_search_timetable.Size = new System.Drawing.Size(159, 28);
            this.Btn_search_timetable.TabIndex = 3;
            this.Btn_search_timetable.Text = "Search";
            this.Btn_search_timetable.UseVisualStyleBackColor = false;
            this.Btn_search_timetable.Visible = false;
            this.Btn_search_timetable.Click += new System.EventHandler(this.Btn_search_timetable_Click);
            // 
            // Btn_SaveNew
            // 
            this.Btn_SaveNew.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_SaveNew.Enabled = false;
            this.Btn_SaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_SaveNew.Location = new System.Drawing.Point(1060, 75);
            this.Btn_SaveNew.Name = "Btn_SaveNew";
            this.Btn_SaveNew.Size = new System.Drawing.Size(159, 28);
            this.Btn_SaveNew.TabIndex = 5;
            this.Btn_SaveNew.Text = "Save New";
            this.Btn_SaveNew.UseVisualStyleBackColor = false;
            this.Btn_SaveNew.Visible = false;
            this.Btn_SaveNew.Click += new System.EventHandler(this.Btn_SaveNew_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Update.Location = new System.Drawing.Point(1060, 111);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(159, 28);
            this.Btn_Update.TabIndex = 6;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.Location = new System.Drawing.Point(1060, 147);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(159, 28);
            this.Btn_Save.TabIndex = 7;
            this.Btn_Save.Text = "Update Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Visible = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete.Location = new System.Drawing.Point(1060, 189);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(159, 28);
            this.Btn_Delete.TabIndex = 8;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btn_EnableSearch
            // 
            this.btn_EnableSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_EnableSearch.Location = new System.Drawing.Point(1395, 124);
            this.btn_EnableSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EnableSearch.Name = "btn_EnableSearch";
            this.btn_EnableSearch.Size = new System.Drawing.Size(159, 58);
            this.btn_EnableSearch.TabIndex = 9;
            this.btn_EnableSearch.Text = "Search by Classroom";
            this.btn_EnableSearch.UseVisualStyleBackColor = false;
            this.btn_EnableSearch.Click += new System.EventHandler(this.Btn_EnableSearch_Click);
            // 
            // Lbl_ClassID
            // 
            this.Lbl_ClassID.AutoSize = true;
            this.Lbl_ClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Lbl_ClassID.Location = new System.Drawing.Point(13, 43);
            this.Lbl_ClassID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ClassID.Name = "Lbl_ClassID";
            this.Lbl_ClassID.Size = new System.Drawing.Size(82, 20);
            this.Lbl_ClassID.TabIndex = 10;
            this.Lbl_ClassID.Text = "Class ID";
            // 
            // Lbl_Day
            // 
            this.Lbl_Day.AutoSize = true;
            this.Lbl_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Lbl_Day.Location = new System.Drawing.Point(13, 83);
            this.Lbl_Day.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Day.Name = "Lbl_Day";
            this.Lbl_Day.Size = new System.Drawing.Size(42, 20);
            this.Lbl_Day.TabIndex = 11;
            this.Lbl_Day.Text = "Day";
            // 
            // Lbl_StartTime
            // 
            this.Lbl_StartTime.AutoSize = true;
            this.Lbl_StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Lbl_StartTime.Location = new System.Drawing.Point(13, 115);
            this.Lbl_StartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_StartTime.Name = "Lbl_StartTime";
            this.Lbl_StartTime.Size = new System.Drawing.Size(97, 20);
            this.Lbl_StartTime.TabIndex = 12;
            this.Lbl_StartTime.Text = "Start Time";
            // 
            // Lbl_EndTimeDay
            // 
            this.Lbl_EndTimeDay.AutoSize = true;
            this.Lbl_EndTimeDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Lbl_EndTimeDay.Location = new System.Drawing.Point(13, 147);
            this.Lbl_EndTimeDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_EndTimeDay.Name = "Lbl_EndTimeDay";
            this.Lbl_EndTimeDay.Size = new System.Drawing.Size(88, 20);
            this.Lbl_EndTimeDay.TabIndex = 13;
            this.Lbl_EndTimeDay.Text = "End Time";
            // 
            // Tb_ClassId
            // 
            this.Tb_ClassId.AllowDrop = true;
            this.Tb_ClassId.Enabled = false;
            this.Tb_ClassId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Tb_ClassId.Location = new System.Drawing.Point(200, 39);
            this.Tb_ClassId.Name = "Tb_ClassId";
            this.Tb_ClassId.ReadOnly = true;
            this.Tb_ClassId.Size = new System.Drawing.Size(117, 27);
            this.Tb_ClassId.TabIndex = 14;
            // 
            // cb_Day
            // 
            this.cb_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Day.Enabled = false;
            this.cb_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cb_Day.Location = new System.Drawing.Point(200, 75);
            this.cb_Day.Name = "cb_Day";
            this.cb_Day.Size = new System.Drawing.Size(117, 28);
            this.cb_Day.TabIndex = 15;
            // 
            // Dtp_Start_Time
            // 
            this.Dtp_Start_Time.Enabled = false;
            this.Dtp_Start_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Dtp_Start_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_Start_Time.Location = new System.Drawing.Point(200, 110);
            this.Dtp_Start_Time.Name = "Dtp_Start_Time";
            this.Dtp_Start_Time.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dtp_Start_Time.ShowUpDown = true;
            this.Dtp_Start_Time.Size = new System.Drawing.Size(117, 27);
            this.Dtp_Start_Time.TabIndex = 16;
            // 
            // Dtp_End_Time
            // 
            this.Dtp_End_Time.Enabled = false;
            this.Dtp_End_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Dtp_End_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_End_Time.Location = new System.Drawing.Point(200, 147);
            this.Dtp_End_Time.Name = "Dtp_End_Time";
            this.Dtp_End_Time.ShowUpDown = true;
            this.Dtp_End_Time.Size = new System.Drawing.Size(117, 27);
            this.Dtp_End_Time.TabIndex = 17;
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Refresh.Location = new System.Drawing.Point(1395, 189);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(159, 28);
            this.Btn_Refresh.TabIndex = 18;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Lbl_Teacher_First_Name
            // 
            this.Lbl_Teacher_First_Name.AutoSize = true;
            this.Lbl_Teacher_First_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Lbl_Teacher_First_Name.Location = new System.Drawing.Point(507, 75);
            this.Lbl_Teacher_First_Name.Name = "Lbl_Teacher_First_Name";
            this.Lbl_Teacher_First_Name.Size = new System.Drawing.Size(176, 20);
            this.Lbl_Teacher_First_Name.TabIndex = 19;
            this.Lbl_Teacher_First_Name.Text = "Teacher First Name";
            // 
            // Lbl_Teacher_Last_Name
            // 
            this.Lbl_Teacher_Last_Name.AutoSize = true;
            this.Lbl_Teacher_Last_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Lbl_Teacher_Last_Name.Location = new System.Drawing.Point(507, 109);
            this.Lbl_Teacher_Last_Name.Name = "Lbl_Teacher_Last_Name";
            this.Lbl_Teacher_Last_Name.Size = new System.Drawing.Size(174, 20);
            this.Lbl_Teacher_Last_Name.TabIndex = 20;
            this.Lbl_Teacher_Last_Name.Text = "Teacher Last Name";
            // 
            // Lbl_Subject
            // 
            this.Lbl_Subject.AutoSize = true;
            this.Lbl_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Lbl_Subject.Location = new System.Drawing.Point(507, 148);
            this.Lbl_Subject.Name = "Lbl_Subject";
            this.Lbl_Subject.Size = new System.Drawing.Size(72, 20);
            this.Lbl_Subject.TabIndex = 21;
            this.Lbl_Subject.Text = "Subject";
            // 
            // Cb_T_Fname
            // 
            this.Cb_T_Fname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_T_Fname.Enabled = false;
            this.Cb_T_Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Cb_T_Fname.FormattingEnabled = true;
            this.Cb_T_Fname.Location = new System.Drawing.Point(707, 72);
            this.Cb_T_Fname.Name = "Cb_T_Fname";
            this.Cb_T_Fname.Size = new System.Drawing.Size(225, 28);
            this.Cb_T_Fname.TabIndex = 22;
            // 
            // Cb_T_Lname
            // 
            this.Cb_T_Lname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_T_Lname.Enabled = false;
            this.Cb_T_Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Cb_T_Lname.FormattingEnabled = true;
            this.Cb_T_Lname.Location = new System.Drawing.Point(707, 106);
            this.Cb_T_Lname.Name = "Cb_T_Lname";
            this.Cb_T_Lname.Size = new System.Drawing.Size(225, 28);
            this.Cb_T_Lname.TabIndex = 23;
            // 
            // btn_InsertNew
            // 
            this.btn_InsertNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InsertNew.Location = new System.Drawing.Point(1060, 39);
            this.btn_InsertNew.Name = "btn_InsertNew";
            this.btn_InsertNew.Size = new System.Drawing.Size(159, 28);
            this.btn_InsertNew.TabIndex = 25;
            this.btn_InsertNew.Text = "Insert New";
            this.btn_InsertNew.UseVisualStyleBackColor = false;
            this.btn_InsertNew.Click += new System.EventHandler(this.btn_InsertNew_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Cancel.Location = new System.Drawing.Point(1230, 189);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(159, 28);
            this.Btn_Cancel.TabIndex = 26;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Visible = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Lbl_TeacherId
            // 
            this.Lbl_TeacherId.AutoSize = true;
            this.Lbl_TeacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TeacherId.Location = new System.Drawing.Point(507, 42);
            this.Lbl_TeacherId.Name = "Lbl_TeacherId";
            this.Lbl_TeacherId.Size = new System.Drawing.Size(102, 20);
            this.Lbl_TeacherId.TabIndex = 27;
            this.Lbl_TeacherId.Text = "Teacher ID";
            // 
            // Cb_TeacherId
            // 
            this.Cb_TeacherId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_TeacherId.Enabled = false;
            this.Cb_TeacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_TeacherId.FormattingEnabled = true;
            this.Cb_TeacherId.Location = new System.Drawing.Point(707, 35);
            this.Cb_TeacherId.Name = "Cb_TeacherId";
            this.Cb_TeacherId.Size = new System.Drawing.Size(225, 28);
            this.Cb_TeacherId.TabIndex = 28;
            this.Cb_TeacherId.SelectedIndexChanged += new System.EventHandler(this.Cb_TeacherId_SelectedIndexChanged);
            // 
            // Txtb_Subject
            // 
            this.Txtb_Subject.Enabled = false;
            this.Txtb_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Subject.Location = new System.Drawing.Point(707, 148);
            this.Txtb_Subject.Name = "Txtb_Subject";
            this.Txtb_Subject.Size = new System.Drawing.Size(225, 27);
            this.Txtb_Subject.TabIndex = 29;
            // 
            // Timetable_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 756);
            this.Controls.Add(this.Txtb_Subject);
            this.Controls.Add(this.Cb_TeacherId);
            this.Controls.Add(this.Lbl_TeacherId);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.btn_InsertNew);
            this.Controls.Add(this.Cb_T_Lname);
            this.Controls.Add(this.Cb_T_Fname);
            this.Controls.Add(this.Lbl_Subject);
            this.Controls.Add(this.Lbl_Teacher_Last_Name);
            this.Controls.Add(this.Lbl_Teacher_First_Name);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Dtp_End_Time);
            this.Controls.Add(this.Dtp_Start_Time);
            this.Controls.Add(this.cb_Day);
            this.Controls.Add(this.Tb_ClassId);
            this.Controls.Add(this.Lbl_EndTimeDay);
            this.Controls.Add(this.Lbl_StartTime);
            this.Controls.Add(this.Lbl_Day);
            this.Controls.Add(this.Lbl_ClassID);
            this.Controls.Add(this.btn_EnableSearch);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_SaveNew);
            this.Controls.Add(this.Btn_search_timetable);
            this.Controls.Add(this.Txt_class_search);
            this.Controls.Add(this.Lbl_ClassNameSearch);
            this.Controls.Add(this.dgv_classes);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Timetable_form";
            this.ShowIcon = false;
            this.Text = "Time tables manager";
            this.Load += new System.EventHandler(this.Timetable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter2;
        private System.Windows.Forms.DataGridView dgv_classes;
        private System.Windows.Forms.Label Lbl_ClassNameSearch;
        private System.Windows.Forms.TextBox Txt_class_search;
        private System.Windows.Forms.Button Btn_search_timetable;
        private System.Windows.Forms.Button Btn_SaveNew;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button btn_EnableSearch;
        private System.Windows.Forms.Label Lbl_ClassID;
        private System.Windows.Forms.Label Lbl_Day;
        private System.Windows.Forms.Label Lbl_StartTime;
        private System.Windows.Forms.Label Lbl_EndTimeDay;
        private System.Windows.Forms.TextBox Tb_ClassId;
        private System.Windows.Forms.ComboBox cb_Day;
        private System.Windows.Forms.DateTimePicker Dtp_Start_Time;
        private System.Windows.Forms.DateTimePicker Dtp_End_Time;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Label Lbl_Teacher_First_Name;
        private System.Windows.Forms.Label Lbl_Teacher_Last_Name;
        private System.Windows.Forms.Label Lbl_Subject;
        private System.Windows.Forms.ComboBox Cb_T_Fname;
        private System.Windows.Forms.ComboBox Cb_T_Lname;
        private System.Windows.Forms.Button btn_InsertNew;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label Lbl_TeacherId;
        private System.Windows.Forms.ComboBox Cb_TeacherId;
        private System.Windows.Forms.TextBox Txtb_Subject;
    }
}