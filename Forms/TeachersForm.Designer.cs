// ***********************************************************************
// Assembly         : 401AZ_PROJECT
// Author           : Stefan-Robert Ursu
// Created          : 02-18-2022
//
// Last Modified By : Stefan-Robert Ursu
// Last Modified On : 02-19-2022
// ***********************************************************************
// <copyright file="TeachersForm.Designer.cs" company="Personal Project">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace _401AZ_PROJECT.Forms
{
    /// <summary>
    /// Class TeachersForm.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class TeachersForm
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
            this.Btn_search_teacher = new System.Windows.Forms.Button();
            this.Btn_EnableSearch = new System.Windows.Forms.Button();
            this.Txtb_AddressPostCode = new System.Windows.Forms.TextBox();
            this.Txtb_AddressRegion = new System.Windows.Forms.TextBox();
            this.Txtb_AddressCity = new System.Windows.Forms.TextBox();
            this.Txtb_AddressStreet = new System.Windows.Forms.TextBox();
            this.Cb_AddressId = new System.Windows.Forms.ComboBox();
            this.Lbl_AddressId = new System.Windows.Forms.Label();
            this.Txtb_email = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Cb_Gender = new System.Windows.Forms.ComboBox();
            this.Lbl_gender = new System.Windows.Forms.Label();
            this.Dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Dob = new System.Windows.Forms.Label();
            this.Txtb_TeacherLName = new System.Windows.Forms.TextBox();
            this.Lbl_TeacherLName = new System.Windows.Forms.Label();
            this.Lbl_TeacherFname = new System.Windows.Forms.Label();
            this.TxtB_TeacherFName = new System.Windows.Forms.TextBox();
            this.Txtb_TeacherId = new System.Windows.Forms.TextBox();
            this.Lbl_TeacherId = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_InsertNew = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_SaveNew = new System.Windows.Forms.Button();
            this.Lbl_TeacherDetails = new System.Windows.Forms.Label();
            this.Dgv_Teachers = new System.Windows.Forms.DataGridView();
            this.Lbl_AddressPostCode = new System.Windows.Forms.Label();
            this.Lbl_AddressRegion = new System.Windows.Forms.Label();
            this.Lbl_AddressCity = new System.Windows.Forms.Label();
            this.Lbl_AddressStreet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Teachers)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_search_teacher
            // 
            this.Btn_search_teacher.Enabled = false;
            this.Btn_search_teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_search_teacher.Location = new System.Drawing.Point(1207, 79);
            this.Btn_search_teacher.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_search_teacher.Name = "Btn_search_teacher";
            this.Btn_search_teacher.Size = new System.Drawing.Size(159, 28);
            this.Btn_search_teacher.TabIndex = 97;
            this.Btn_search_teacher.Text = "Search";
            this.Btn_search_teacher.UseVisualStyleBackColor = false;
            this.Btn_search_teacher.Visible = false;
            this.Btn_search_teacher.Click += new System.EventHandler(this.Btn_search_teacher_Click);
            // 
            // Btn_EnableSearch
            // 
            this.Btn_EnableSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_EnableSearch.Location = new System.Drawing.Point(1207, 13);
            this.Btn_EnableSearch.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_EnableSearch.Name = "Btn_EnableSearch";
            this.Btn_EnableSearch.Size = new System.Drawing.Size(159, 58);
            this.Btn_EnableSearch.TabIndex = 96;
            this.Btn_EnableSearch.Text = "Search By Teacher ID";
            this.Btn_EnableSearch.UseVisualStyleBackColor = false;
            this.Btn_EnableSearch.Click += new System.EventHandler(this.Btn_EnableSearch_Click);
            // 
            // Txtb_AddressPostCode
            // 
            this.Txtb_AddressPostCode.Enabled = false;
            this.Txtb_AddressPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_AddressPostCode.Location = new System.Drawing.Point(653, 170);
            this.Txtb_AddressPostCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_AddressPostCode.MaxLength = 7;
            this.Txtb_AddressPostCode.Name = "Txtb_AddressPostCode";
            this.Txtb_AddressPostCode.Size = new System.Drawing.Size(257, 27);
            this.Txtb_AddressPostCode.TabIndex = 80;
            // 
            // Txtb_AddressRegion
            // 
            this.Txtb_AddressRegion.Enabled = false;
            this.Txtb_AddressRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_AddressRegion.Location = new System.Drawing.Point(653, 134);
            this.Txtb_AddressRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_AddressRegion.MaxLength = 30;
            this.Txtb_AddressRegion.Name = "Txtb_AddressRegion";
            this.Txtb_AddressRegion.Size = new System.Drawing.Size(257, 27);
            this.Txtb_AddressRegion.TabIndex = 79;
            // 
            // Txtb_AddressCity
            // 
            this.Txtb_AddressCity.Enabled = false;
            this.Txtb_AddressCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_AddressCity.Location = new System.Drawing.Point(653, 100);
            this.Txtb_AddressCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_AddressCity.MaxLength = 30;
            this.Txtb_AddressCity.Name = "Txtb_AddressCity";
            this.Txtb_AddressCity.Size = new System.Drawing.Size(257, 27);
            this.Txtb_AddressCity.TabIndex = 78;
            // 
            // Txtb_AddressStreet
            // 
            this.Txtb_AddressStreet.Enabled = false;
            this.Txtb_AddressStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_AddressStreet.Location = new System.Drawing.Point(653, 68);
            this.Txtb_AddressStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_AddressStreet.MaxLength = 30;
            this.Txtb_AddressStreet.Name = "Txtb_AddressStreet";
            this.Txtb_AddressStreet.Size = new System.Drawing.Size(257, 27);
            this.Txtb_AddressStreet.TabIndex = 77;
            // 
            // Cb_AddressId
            // 
            this.Cb_AddressId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_AddressId.Enabled = false;
            this.Cb_AddressId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_AddressId.FormattingEnabled = true;
            this.Cb_AddressId.Location = new System.Drawing.Point(653, 38);
            this.Cb_AddressId.Margin = new System.Windows.Forms.Padding(4);
            this.Cb_AddressId.Name = "Cb_AddressId";
            this.Cb_AddressId.Size = new System.Drawing.Size(257, 28);
            this.Cb_AddressId.TabIndex = 95;
            // 
            // Lbl_AddressId
            // 
            this.Lbl_AddressId.AutoSize = true;
            this.Lbl_AddressId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddressId.Location = new System.Drawing.Point(472, 45);
            this.Lbl_AddressId.Name = "Lbl_AddressId";
            this.Lbl_AddressId.Size = new System.Drawing.Size(103, 20);
            this.Lbl_AddressId.TabIndex = 94;
            this.Lbl_AddressId.Text = "Address ID";
            // 
            // Txtb_email
            // 
            this.Txtb_email.Enabled = false;
            this.Txtb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_email.Location = new System.Drawing.Point(653, 7);
            this.Txtb_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_email.MaxLength = 30;
            this.Txtb_email.Name = "Txtb_email";
            this.Txtb_email.Size = new System.Drawing.Size(257, 27);
            this.Txtb_email.TabIndex = 76;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Email.Location = new System.Drawing.Point(469, 10);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(138, 20);
            this.Lbl_Email.TabIndex = 93;
            this.Lbl_Email.Text = "E-Mail Address";
            // 
            // Cb_Gender
            // 
            this.Cb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Gender.Enabled = false;
            this.Cb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Gender.FormattingEnabled = true;
            this.Cb_Gender.Location = new System.Drawing.Point(228, 140);
            this.Cb_Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_Gender.Name = "Cb_Gender";
            this.Cb_Gender.Size = new System.Drawing.Size(159, 28);
            this.Cb_Gender.TabIndex = 75;
            // 
            // Lbl_gender
            // 
            this.Lbl_gender.AutoSize = true;
            this.Lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_gender.Location = new System.Drawing.Point(14, 147);
            this.Lbl_gender.Name = "Lbl_gender";
            this.Lbl_gender.Size = new System.Drawing.Size(70, 20);
            this.Lbl_gender.TabIndex = 92;
            this.Lbl_gender.Text = "Gender";
            // 
            // Dtp_DOB
            // 
            this.Dtp_DOB.Enabled = false;
            this.Dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DOB.Location = new System.Drawing.Point(228, 101);
            this.Dtp_DOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dtp_DOB.Name = "Dtp_DOB";
            this.Dtp_DOB.Size = new System.Drawing.Size(159, 27);
            this.Dtp_DOB.TabIndex = 73;
            // 
            // Lbl_Dob
            // 
            this.Lbl_Dob.AutoSize = true;
            this.Lbl_Dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dob.Location = new System.Drawing.Point(14, 109);
            this.Lbl_Dob.Name = "Lbl_Dob";
            this.Lbl_Dob.Size = new System.Drawing.Size(118, 20);
            this.Lbl_Dob.TabIndex = 91;
            this.Lbl_Dob.Text = "Date of Birth";
            // 
            // Txtb_TeacherLName
            // 
            this.Txtb_TeacherLName.Enabled = false;
            this.Txtb_TeacherLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_TeacherLName.Location = new System.Drawing.Point(228, 61);
            this.Txtb_TeacherLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_TeacherLName.MaxLength = 10;
            this.Txtb_TeacherLName.Name = "Txtb_TeacherLName";
            this.Txtb_TeacherLName.Size = new System.Drawing.Size(159, 27);
            this.Txtb_TeacherLName.TabIndex = 72;
            // 
            // Lbl_TeacherLName
            // 
            this.Lbl_TeacherLName.AutoSize = true;
            this.Lbl_TeacherLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TeacherLName.Location = new System.Drawing.Point(14, 64);
            this.Lbl_TeacherLName.Name = "Lbl_TeacherLName";
            this.Lbl_TeacherLName.Size = new System.Drawing.Size(174, 20);
            this.Lbl_TeacherLName.TabIndex = 90;
            this.Lbl_TeacherLName.Text = "Teacher Last Name";
            // 
            // Lbl_TeacherFname
            // 
            this.Lbl_TeacherFname.AutoSize = true;
            this.Lbl_TeacherFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TeacherFname.Location = new System.Drawing.Point(13, 34);
            this.Lbl_TeacherFname.Name = "Lbl_TeacherFname";
            this.Lbl_TeacherFname.Size = new System.Drawing.Size(176, 20);
            this.Lbl_TeacherFname.TabIndex = 89;
            this.Lbl_TeacherFname.Text = "Teacher First Name";
            // 
            // TxtB_TeacherFName
            // 
            this.TxtB_TeacherFName.Enabled = false;
            this.TxtB_TeacherFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtB_TeacherFName.Location = new System.Drawing.Point(228, 31);
            this.TxtB_TeacherFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtB_TeacherFName.MaxLength = 10;
            this.TxtB_TeacherFName.Name = "TxtB_TeacherFName";
            this.TxtB_TeacherFName.Size = new System.Drawing.Size(159, 27);
            this.TxtB_TeacherFName.TabIndex = 71;
            // 
            // Txtb_TeacherId
            // 
            this.Txtb_TeacherId.Enabled = false;
            this.Txtb_TeacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_TeacherId.Location = new System.Drawing.Point(228, 1);
            this.Txtb_TeacherId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_TeacherId.Name = "Txtb_TeacherId";
            this.Txtb_TeacherId.Size = new System.Drawing.Size(159, 27);
            this.Txtb_TeacherId.TabIndex = 70;
            this.Txtb_TeacherId.TextChanged += new System.EventHandler(this.Txtb_TeacherId_TextChanged);
            this.Txtb_TeacherId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtb_TeacherId_KeyDown);
            this.Txtb_TeacherId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtb_TeacherId_KeyPress);
            // 
            // Lbl_TeacherId
            // 
            this.Lbl_TeacherId.AutoSize = true;
            this.Lbl_TeacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TeacherId.Location = new System.Drawing.Point(13, 7);
            this.Lbl_TeacherId.Name = "Lbl_TeacherId";
            this.Lbl_TeacherId.Size = new System.Drawing.Size(102, 20);
            this.Lbl_TeacherId.TabIndex = 88;
            this.Lbl_TeacherId.Text = "Teacher ID";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Cancel.Location = new System.Drawing.Point(1208, 196);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(159, 28);
            this.Btn_Cancel.TabIndex = 87;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Visible = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_InsertNew
            // 
            this.Btn_InsertNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_InsertNew.Location = new System.Drawing.Point(1373, 11);
            this.Btn_InsertNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_InsertNew.Name = "Btn_InsertNew";
            this.Btn_InsertNew.Size = new System.Drawing.Size(159, 28);
            this.Btn_InsertNew.TabIndex = 86;
            this.Btn_InsertNew.Text = "Insert New";
            this.Btn_InsertNew.UseVisualStyleBackColor = false;
            this.Btn_InsertNew.Click += new System.EventHandler(this.Btn_InsertNew_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Refresh.Location = new System.Drawing.Point(1373, 197);
            this.Btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(159, 28);
            this.Btn_Refresh.TabIndex = 85;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Enabled = false;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete.Location = new System.Drawing.Point(1373, 164);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(159, 28);
            this.Btn_Delete.TabIndex = 84;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.Location = new System.Drawing.Point(1373, 116);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(159, 28);
            this.Btn_Save.TabIndex = 83;
            this.Btn_Save.Text = "Update Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Visible = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Enabled = false;
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Update.Location = new System.Drawing.Point(1373, 79);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(159, 28);
            this.Btn_Update.TabIndex = 82;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_SaveNew
            // 
            this.Btn_SaveNew.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_SaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_SaveNew.Location = new System.Drawing.Point(1373, 43);
            this.Btn_SaveNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_SaveNew.Name = "Btn_SaveNew";
            this.Btn_SaveNew.Size = new System.Drawing.Size(159, 28);
            this.Btn_SaveNew.TabIndex = 81;
            this.Btn_SaveNew.Text = "Save New";
            this.Btn_SaveNew.UseVisualStyleBackColor = false;
            this.Btn_SaveNew.Visible = false;
            this.Btn_SaveNew.Click += new System.EventHandler(this.Btn_SaveNew_Click);
            // 
            // Lbl_TeacherDetails
            // 
            this.Lbl_TeacherDetails.AutoSize = true;
            this.Lbl_TeacherDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TeacherDetails.Location = new System.Drawing.Point(12, 200);
            this.Lbl_TeacherDetails.Name = "Lbl_TeacherDetails";
            this.Lbl_TeacherDetails.Size = new System.Drawing.Size(198, 29);
            this.Lbl_TeacherDetails.TabIndex = 74;
            this.Lbl_TeacherDetails.Text = "Teacher Details";
            // 
            // Dgv_Teachers
            // 
            this.Dgv_Teachers.AllowUserToAddRows = false;
            this.Dgv_Teachers.AllowUserToDeleteRows = false;
            this.Dgv_Teachers.AllowUserToResizeColumns = false;
            this.Dgv_Teachers.AllowUserToResizeRows = false;
            this.Dgv_Teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Teachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Teachers.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Teachers.Location = new System.Drawing.Point(12, 241);
            this.Dgv_Teachers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Teachers.Name = "Dgv_Teachers";
            this.Dgv_Teachers.ReadOnly = true;
            this.Dgv_Teachers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv_Teachers.RowHeadersVisible = false;
            this.Dgv_Teachers.RowHeadersWidth = 51;
            this.Dgv_Teachers.RowTemplate.Height = 24;
            this.Dgv_Teachers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Teachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Teachers.Size = new System.Drawing.Size(1520, 594);
            this.Dgv_Teachers.TabIndex = 69;
            this.Dgv_Teachers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dgv_Teachers_CellFormatting);
            this.Dgv_Teachers.SelectionChanged += new System.EventHandler(this.Dgv_Teachers_SelectionChanged);
            // 
            // Lbl_AddressPostCode
            // 
            this.Lbl_AddressPostCode.AutoSize = true;
            this.Lbl_AddressPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddressPostCode.Location = new System.Drawing.Point(469, 173);
            this.Lbl_AddressPostCode.Name = "Lbl_AddressPostCode";
            this.Lbl_AddressPostCode.Size = new System.Drawing.Size(162, 20);
            this.Lbl_AddressPostCode.TabIndex = 101;
            this.Lbl_AddressPostCode.Text = "Address Postcode";
            // 
            // Lbl_AddressRegion
            // 
            this.Lbl_AddressRegion.AutoSize = true;
            this.Lbl_AddressRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddressRegion.Location = new System.Drawing.Point(469, 137);
            this.Lbl_AddressRegion.Name = "Lbl_AddressRegion";
            this.Lbl_AddressRegion.Size = new System.Drawing.Size(142, 20);
            this.Lbl_AddressRegion.TabIndex = 100;
            this.Lbl_AddressRegion.Text = "Address Region";
            // 
            // Lbl_AddressCity
            // 
            this.Lbl_AddressCity.AutoSize = true;
            this.Lbl_AddressCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddressCity.Location = new System.Drawing.Point(469, 106);
            this.Lbl_AddressCity.Name = "Lbl_AddressCity";
            this.Lbl_AddressCity.Size = new System.Drawing.Size(117, 20);
            this.Lbl_AddressCity.TabIndex = 99;
            this.Lbl_AddressCity.Text = "Address City";
            // 
            // Lbl_AddressStreet
            // 
            this.Lbl_AddressStreet.AutoSize = true;
            this.Lbl_AddressStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddressStreet.Location = new System.Drawing.Point(469, 74);
            this.Lbl_AddressStreet.Name = "Lbl_AddressStreet";
            this.Lbl_AddressStreet.Size = new System.Drawing.Size(135, 20);
            this.Lbl_AddressStreet.TabIndex = 98;
            this.Lbl_AddressStreet.Text = "Address Street";
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 846);
            this.Controls.Add(this.Lbl_AddressPostCode);
            this.Controls.Add(this.Lbl_AddressRegion);
            this.Controls.Add(this.Lbl_AddressCity);
            this.Controls.Add(this.Lbl_AddressStreet);
            this.Controls.Add(this.Btn_search_teacher);
            this.Controls.Add(this.Btn_EnableSearch);
            this.Controls.Add(this.Txtb_AddressPostCode);
            this.Controls.Add(this.Txtb_AddressRegion);
            this.Controls.Add(this.Txtb_AddressCity);
            this.Controls.Add(this.Txtb_AddressStreet);
            this.Controls.Add(this.Cb_AddressId);
            this.Controls.Add(this.Lbl_AddressId);
            this.Controls.Add(this.Txtb_email);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Cb_Gender);
            this.Controls.Add(this.Lbl_gender);
            this.Controls.Add(this.Dtp_DOB);
            this.Controls.Add(this.Lbl_Dob);
            this.Controls.Add(this.Txtb_TeacherLName);
            this.Controls.Add(this.Lbl_TeacherLName);
            this.Controls.Add(this.Lbl_TeacherFname);
            this.Controls.Add(this.TxtB_TeacherFName);
            this.Controls.Add(this.Txtb_TeacherId);
            this.Controls.Add(this.Lbl_TeacherId);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_InsertNew);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_SaveNew);
            this.Controls.Add(this.Lbl_TeacherDetails);
            this.Controls.Add(this.Dgv_Teachers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TeachersForm";
            this.ShowIcon = false;
            this.Text = "Teachers Manager";
            this.Load += new System.EventHandler(this.Teachers_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Teachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The BTN search teacher
        /// </summary>
        private System.Windows.Forms.Button Btn_search_teacher;
        /// <summary>
        /// The BTN enable search
        /// </summary>
        private System.Windows.Forms.Button Btn_EnableSearch;
        /// <summary>
        /// The TXTB address post code
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_AddressPostCode;
        /// <summary>
        /// The TXTB address region
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_AddressRegion;
        /// <summary>
        /// The TXTB address city
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_AddressCity;
        /// <summary>
        /// The TXTB address street
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_AddressStreet;
        /// <summary>
        /// The cb address identifier
        /// </summary>
        private System.Windows.Forms.ComboBox Cb_AddressId;
        /// <summary>
        /// The label address identifier
        /// </summary>
        private System.Windows.Forms.Label Lbl_AddressId;
        /// <summary>
        /// The TXTB email
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_email;
        /// <summary>
        /// The label email
        /// </summary>
        private System.Windows.Forms.Label Lbl_Email;
        /// <summary>
        /// The cb gender
        /// </summary>
        private System.Windows.Forms.ComboBox Cb_Gender;
        /// <summary>
        /// The label gender
        /// </summary>
        private System.Windows.Forms.Label Lbl_gender;
        /// <summary>
        /// The DTP dob
        /// </summary>
        private System.Windows.Forms.DateTimePicker Dtp_DOB;
        /// <summary>
        /// The label dob
        /// </summary>
        private System.Windows.Forms.Label Lbl_Dob;
        /// <summary>
        /// The TXTB teacher l name
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_TeacherLName;
        /// <summary>
        /// The label teacher l name
        /// </summary>
        private System.Windows.Forms.Label Lbl_TeacherLName;
        /// <summary>
        /// The label teacher fname
        /// </summary>
        private System.Windows.Forms.Label Lbl_TeacherFname;
        /// <summary>
        /// The text b teacher f name
        /// </summary>
        private System.Windows.Forms.TextBox TxtB_TeacherFName;
        /// <summary>
        /// The TXTB teacher identifier
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_TeacherId;
        /// <summary>
        /// The label teacher identifier
        /// </summary>
        private System.Windows.Forms.Label Lbl_TeacherId;
        /// <summary>
        /// The BTN cancel
        /// </summary>
        private System.Windows.Forms.Button Btn_Cancel;
        /// <summary>
        /// The BTN insert new
        /// </summary>
        private System.Windows.Forms.Button Btn_InsertNew;
        /// <summary>
        /// The BTN refresh
        /// </summary>
        private System.Windows.Forms.Button Btn_Refresh;
        /// <summary>
        /// The BTN delete
        /// </summary>
        private System.Windows.Forms.Button Btn_Delete;
        /// <summary>
        /// The BTN save
        /// </summary>
        private System.Windows.Forms.Button Btn_Save;
        /// <summary>
        /// The BTN update
        /// </summary>
        private System.Windows.Forms.Button Btn_Update;
        /// <summary>
        /// The BTN save new
        /// </summary>
        private System.Windows.Forms.Button Btn_SaveNew;
        /// <summary>
        /// The label teacher details
        /// </summary>
        private System.Windows.Forms.Label Lbl_TeacherDetails;
        /// <summary>
        /// The DGV teachers
        /// </summary>
        private System.Windows.Forms.DataGridView Dgv_Teachers;
        /// <summary>
        /// The label address post code
        /// </summary>
        private System.Windows.Forms.Label Lbl_AddressPostCode;
        /// <summary>
        /// The label address region
        /// </summary>
        private System.Windows.Forms.Label Lbl_AddressRegion;
        /// <summary>
        /// The label address city
        /// </summary>
        private System.Windows.Forms.Label Lbl_AddressCity;
        /// <summary>
        /// The label address street
        /// </summary>
        private System.Windows.Forms.Label Lbl_AddressStreet;
    }
}