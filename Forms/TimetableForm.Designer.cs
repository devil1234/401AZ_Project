﻿namespace _401AZ_PROJECT.Forms
{
    /// <summary>
    /// Class TimetableForm.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class TimetableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            this.mySqlDataAdapter2 = new MySqlConnector.MySqlDataAdapter();
            this.dgv_classes = new System.Windows.Forms.DataGridView();
            this.Lbl_ClassNameSearch = new System.Windows.Forms.Label();
            this.Txt_class_search = new System.Windows.Forms.TextBox();
            this.Btn_search_timetable = new System.Windows.Forms.Button();
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
            this.Lbl_Teacher_LastName = new System.Windows.Forms.Label();
            this.Lbl_Subject = new System.Windows.Forms.Label();
            this.Cb_T_Fname = new System.Windows.Forms.ComboBox();
            this.Cb_T_Lname = new System.Windows.Forms.ComboBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Lbl_TeacherId = new System.Windows.Forms.Label();
            this.Cb_TeacherId = new System.Windows.Forms.ComboBox();
            this.Txtb_Subject = new System.Windows.Forms.TextBox();
            this.Lbl_Timetabledetails = new System.Windows.Forms.Label();
            this.Btn_SaveNew = new System.Windows.Forms.Button();
            this.btn_InsertNew = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_classes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_classes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_classes.Location = new System.Drawing.Point(12, 267);
            this.dgv_classes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_classes.Name = "dgv_classes";
            this.dgv_classes.ReadOnly = true;
            this.dgv_classes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_classes.RowHeadersVisible = false;
            this.dgv_classes.RowHeadersWidth = 51;
            this.dgv_classes.RowTemplate.Height = 24;
            this.dgv_classes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_classes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_classes.Size = new System.Drawing.Size(1543, 478);
            this.dgv_classes.TabIndex = 0;
            this.dgv_classes.SelectionChanged += new System.EventHandler(this.dgv_classes_SelectionChanged);
            // 
            // Lbl_ClassNameSearch
            // 
            this.Lbl_ClassNameSearch.AutoSize = true;
            this.Lbl_ClassNameSearch.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ClassNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Lbl_ClassNameSearch.Location = new System.Drawing.Point(13, 194);
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
            this.Txt_class_search.MaxLength = 10;
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
            // Btn_Update
            // 
            this.Btn_Update.Enabled = false;
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Update.Location = new System.Drawing.Point(1060, 111);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Btn_Save.Location = new System.Drawing.Point(1060, 146);
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
            this.Btn_Delete.Enabled = false;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete.Location = new System.Drawing.Point(1060, 190);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Lbl_Day.Location = new System.Drawing.Point(13, 82);
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
            this.Lbl_StartTime.Location = new System.Drawing.Point(13, 114);
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
            this.Lbl_EndTimeDay.Location = new System.Drawing.Point(13, 146);
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
            this.Tb_ClassId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.cb_Day.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Dtp_Start_Time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Dtp_End_Time.Location = new System.Drawing.Point(200, 146);
            this.Dtp_End_Time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dtp_End_Time.Name = "Dtp_End_Time";
            this.Dtp_End_Time.ShowUpDown = true;
            this.Dtp_End_Time.Size = new System.Drawing.Size(117, 27);
            this.Dtp_End_Time.TabIndex = 17;
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Refresh.Location = new System.Drawing.Point(1395, 190);
            this.Btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // Lbl_Teacher_LastName
            // 
            this.Lbl_Teacher_LastName.AutoSize = true;
            this.Lbl_Teacher_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Lbl_Teacher_LastName.Location = new System.Drawing.Point(507, 110);
            this.Lbl_Teacher_LastName.Name = "Lbl_Teacher_LastName";
            this.Lbl_Teacher_LastName.Size = new System.Drawing.Size(174, 20);
            this.Lbl_Teacher_LastName.TabIndex = 20;
            this.Lbl_Teacher_LastName.Text = "Teacher Last Name";
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
            this.Cb_T_Fname.Location = new System.Drawing.Point(707, 71);
            this.Cb_T_Fname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Cb_T_Lname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_T_Lname.Name = "Cb_T_Lname";
            this.Cb_T_Lname.Size = new System.Drawing.Size(225, 28);
            this.Cb_T_Lname.TabIndex = 23;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Cancel.Location = new System.Drawing.Point(1229, 190);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Cb_TeacherId.Location = new System.Drawing.Point(707, 34);
            this.Cb_TeacherId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Txtb_Subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_Subject.MaxLength = 30;
            this.Txtb_Subject.Name = "Txtb_Subject";
            this.Txtb_Subject.Size = new System.Drawing.Size(225, 27);
            this.Txtb_Subject.TabIndex = 29;
            // 
            // Lbl_Timetabledetails
            // 
            this.Lbl_Timetabledetails.AutoSize = true;
            this.Lbl_Timetabledetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Timetabledetails.Location = new System.Drawing.Point(12, 235);
            this.Lbl_Timetabledetails.Name = "Lbl_Timetabledetails";
            this.Lbl_Timetabledetails.Size = new System.Drawing.Size(216, 29);
            this.Lbl_Timetabledetails.TabIndex = 30;
            this.Lbl_Timetabledetails.Text = "Timetable details";
            // 
            // Btn_SaveNew
            // 
            this.Btn_SaveNew.AutoSize = true;
            this.Btn_SaveNew.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_SaveNew.Enabled = false;
            this.Btn_SaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveNew.Location = new System.Drawing.Point(1060, 77);
            this.Btn_SaveNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_SaveNew.Name = "Btn_SaveNew";
            this.Btn_SaveNew.Size = new System.Drawing.Size(159, 30);
            this.Btn_SaveNew.TabIndex = 5;
            this.Btn_SaveNew.Text = "Save New";
            this.Btn_SaveNew.UseVisualStyleBackColor = false;
            this.Btn_SaveNew.Visible = false;
            this.Btn_SaveNew.Click += new System.EventHandler(this.Btn_SaveNew_Click);
            // 
            // btn_InsertNew
            // 
            this.btn_InsertNew.AutoSize = true;
            this.btn_InsertNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InsertNew.Location = new System.Drawing.Point(1060, 39);
            this.btn_InsertNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_InsertNew.Name = "btn_InsertNew";
            this.btn_InsertNew.Size = new System.Drawing.Size(159, 30);
            this.btn_InsertNew.TabIndex = 25;
            this.btn_InsertNew.Text = "Insert New";
            this.btn_InsertNew.UseVisualStyleBackColor = false;
            this.btn_InsertNew.Click += new System.EventHandler(this.btn_InsertNew_Click);
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 756);
            this.Controls.Add(this.Lbl_Timetabledetails);
            this.Controls.Add(this.Txtb_Subject);
            this.Controls.Add(this.Cb_TeacherId);
            this.Controls.Add(this.Lbl_TeacherId);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.btn_InsertNew);
            this.Controls.Add(this.Cb_T_Lname);
            this.Controls.Add(this.Cb_T_Fname);
            this.Controls.Add(this.Lbl_Subject);
            this.Controls.Add(this.Lbl_Teacher_LastName);
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
            this.Name = "TimetableForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time tables manager";
            this.Load += new System.EventHandler(this.Timetable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// My SQL data adapter1
        /// </summary>
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        /// <summary>
        /// My SQL data adapter2
        /// </summary>
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter2;
        /// <summary>
        /// The DGV classes
        /// </summary>
        private System.Windows.Forms.DataGridView dgv_classes;
        /// <summary>
        /// The label class name search
        /// </summary>
        private System.Windows.Forms.Label Lbl_ClassNameSearch;
        /// <summary>
        /// The text class search
        /// </summary>
        private System.Windows.Forms.TextBox Txt_class_search;
        /// <summary>
        /// The BTN search timetable
        /// </summary>
        private System.Windows.Forms.Button Btn_search_timetable;
        /// <summary>
        /// The BTN update
        /// </summary>
        private System.Windows.Forms.Button Btn_Update;
        /// <summary>
        /// The BTN save
        /// </summary>
        private System.Windows.Forms.Button Btn_Save;
        /// <summary>
        /// The BTN delete
        /// </summary>
        private System.Windows.Forms.Button Btn_Delete;
        /// <summary>
        /// The BTN enable search
        /// </summary>
        private System.Windows.Forms.Button btn_EnableSearch;
        /// <summary>
        /// The label class identifier
        /// </summary>
        private System.Windows.Forms.Label Lbl_ClassID;
        /// <summary>
        /// The label day
        /// </summary>
        private System.Windows.Forms.Label Lbl_Day;
        /// <summary>
        /// The label start time
        /// </summary>
        private System.Windows.Forms.Label Lbl_StartTime;
        /// <summary>
        /// The label end time day
        /// </summary>
        private System.Windows.Forms.Label Lbl_EndTimeDay;
        /// <summary>
        /// The tb class identifier
        /// </summary>
        private System.Windows.Forms.TextBox Tb_ClassId;
        /// <summary>
        /// The cb day
        /// </summary>
        private System.Windows.Forms.ComboBox cb_Day;
        /// <summary>
        /// The DTP start time
        /// </summary>
        private System.Windows.Forms.DateTimePicker Dtp_Start_Time;
        /// <summary>
        /// The DTP end time
        /// </summary>
        private System.Windows.Forms.DateTimePicker Dtp_End_Time;
        /// <summary>
        /// The BTN refresh
        /// </summary>
        private System.Windows.Forms.Button Btn_Refresh;
        /// <summary>
        /// The label teacher first name
        /// </summary>
        private System.Windows.Forms.Label Lbl_Teacher_First_Name;
        /// <summary>
        /// The label teacher last name
        /// </summary>
        private System.Windows.Forms.Label Lbl_Teacher_LastName;
        /// <summary>
        /// The label subject
        /// </summary>
        private System.Windows.Forms.Label Lbl_Subject;
        /// <summary>
        /// The cb t fname
        /// </summary>
        private System.Windows.Forms.ComboBox Cb_T_Fname;
        /// <summary>
        /// The cb t lname
        /// </summary>
        private System.Windows.Forms.ComboBox Cb_T_Lname;
        /// <summary>
        /// The BTN cancel
        /// </summary>
        private System.Windows.Forms.Button Btn_Cancel;
        /// <summary>
        /// The label teacher identifier
        /// </summary>
        private System.Windows.Forms.Label Lbl_TeacherId;
        /// <summary>
        /// The cb teacher identifier
        /// </summary>
        private System.Windows.Forms.ComboBox Cb_TeacherId;
        /// <summary>
        /// The TXTB subject
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_Subject;
        /// <summary>
        /// The label timetabledetails
        /// </summary>
        private System.Windows.Forms.Label Lbl_Timetabledetails;
        /// <summary>
        /// The BTN save new
        /// </summary>
        private System.Windows.Forms.Button Btn_SaveNew;
        /// <summary>
        /// The BTN insert new
        /// </summary>
        private System.Windows.Forms.Button btn_InsertNew;
    }
}