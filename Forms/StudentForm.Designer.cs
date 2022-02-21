// ***********************************************************************
// Assembly         : 401AZ_PROJECT
// Author           : Stefan-Robert Ursu
// Created          : 02-18-2022
//
// Last Modified By : Stefan-Robert Ursu
// Last Modified On : 02-19-2022
// ***********************************************************************
// <copyright file="StudentForm.Designer.cs" company="Personal Project">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace _401AZ_PROJECT
{
    /// <summary>
    /// Class StudentForm.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class StudentForm
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
            this.Dgv_Students = new System.Windows.Forms.DataGridView();
            this.Lbl_StudentDetails = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_InsertNew = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_SaveNew = new System.Windows.Forms.Button();
            this.Lbl_StudentId = new System.Windows.Forms.Label();
            this.Txtb_StudentId = new System.Windows.Forms.TextBox();
            this.TxtB_StudentFName = new System.Windows.Forms.TextBox();
            this.Lbl_StudentFname = new System.Windows.Forms.Label();
            this.Lbl_StudentLName = new System.Windows.Forms.Label();
            this.Txtb_StudentLName = new System.Windows.Forms.TextBox();
            this.Lbl_Dob = new System.Windows.Forms.Label();
            this.Dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.Lbl_gender = new System.Windows.Forms.Label();
            this.Cb_Gender = new System.Windows.Forms.ComboBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txtb_email = new System.Windows.Forms.TextBox();
            this.Lbl_Parent_FName = new System.Windows.Forms.Label();
            this.Txtb_ParentFName = new System.Windows.Forms.TextBox();
            this.TxtB_ParentLName = new System.Windows.Forms.TextBox();
            this.Lbl_ParentLName = new System.Windows.Forms.Label();
            this.Lbl_ParentId = new System.Windows.Forms.Label();
            this.Cb_ParentId = new System.Windows.Forms.ComboBox();
            this.Lbl_AddressId = new System.Windows.Forms.Label();
            this.Lbl_AddressStreet = new System.Windows.Forms.Label();
            this.Lbl_AddressCity = new System.Windows.Forms.Label();
            this.Lbl_AddressRegion = new System.Windows.Forms.Label();
            this.Lbl_AddressPostcode = new System.Windows.Forms.Label();
            this.Lbl_ParentPhoneNumber = new System.Windows.Forms.Label();
            this.Cb_AddressId = new System.Windows.Forms.ComboBox();
            this.Txtb_AddressStreet = new System.Windows.Forms.TextBox();
            this.Txtb_AddressCity = new System.Windows.Forms.TextBox();
            this.Txtb_AddressRegion = new System.Windows.Forms.TextBox();
            this.Txtb_AddressPostCode = new System.Windows.Forms.TextBox();
            this.Txtb_ParentPN = new System.Windows.Forms.TextBox();
            this.Btn_EnableSearch = new System.Windows.Forms.Button();
            this.Btn_search_student = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Students
            // 
            this.Dgv_Students.AllowUserToAddRows = false;
            this.Dgv_Students.AllowUserToDeleteRows = false;
            this.Dgv_Students.AllowUserToResizeColumns = false;
            this.Dgv_Students.AllowUserToResizeRows = false;
            this.Dgv_Students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Students.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Students.Location = new System.Drawing.Point(9, 235);
            this.Dgv_Students.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Students.Name = "Dgv_Students";
            this.Dgv_Students.ReadOnly = true;
            this.Dgv_Students.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv_Students.RowHeadersVisible = false;
            this.Dgv_Students.RowHeadersWidth = 51;
            this.Dgv_Students.RowTemplate.Height = 24;
            this.Dgv_Students.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Students.Size = new System.Drawing.Size(1696, 730);
            this.Dgv_Students.TabIndex = 1;
            this.Dgv_Students.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dgv_Students_CellFormatting);
            this.Dgv_Students.SelectionChanged += new System.EventHandler(this.Dgv_Students_SelectionChanged);
            // 
            // Lbl_StudentDetails
            // 
            this.Lbl_StudentDetails.AutoSize = true;
            this.Lbl_StudentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_StudentDetails.Location = new System.Drawing.Point(11, 203);
            this.Lbl_StudentDetails.Name = "Lbl_StudentDetails";
            this.Lbl_StudentDetails.Size = new System.Drawing.Size(190, 29);
            this.Lbl_StudentDetails.TabIndex = 4;
            this.Lbl_StudentDetails.Text = "Student Details";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Cancel.Location = new System.Drawing.Point(1380, 202);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(159, 28);
            this.Btn_Cancel.TabIndex = 33;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Visible = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_InsertNew
            // 
            this.Btn_InsertNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_InsertNew.Location = new System.Drawing.Point(1547, 16);
            this.Btn_InsertNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_InsertNew.Name = "Btn_InsertNew";
            this.Btn_InsertNew.Size = new System.Drawing.Size(159, 28);
            this.Btn_InsertNew.TabIndex = 32;
            this.Btn_InsertNew.Text = "Insert New";
            this.Btn_InsertNew.UseVisualStyleBackColor = false;
            this.Btn_InsertNew.Click += new System.EventHandler(this.Btn_InsertNew_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Refresh.Location = new System.Drawing.Point(1547, 202);
            this.Btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(159, 28);
            this.Btn_Refresh.TabIndex = 31;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete.Location = new System.Drawing.Point(1547, 169);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(159, 28);
            this.Btn_Delete.TabIndex = 30;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.Location = new System.Drawing.Point(1547, 121);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(159, 28);
            this.Btn_Save.TabIndex = 29;
            this.Btn_Save.Text = "Update Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Visible = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Update.Location = new System.Drawing.Point(1547, 84);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(159, 28);
            this.Btn_Update.TabIndex = 28;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_SaveNew
            // 
            this.Btn_SaveNew.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_SaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_SaveNew.Location = new System.Drawing.Point(1547, 48);
            this.Btn_SaveNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_SaveNew.Name = "Btn_SaveNew";
            this.Btn_SaveNew.Size = new System.Drawing.Size(159, 28);
            this.Btn_SaveNew.TabIndex = 27;
            this.Btn_SaveNew.Text = "Save New";
            this.Btn_SaveNew.UseVisualStyleBackColor = false;
            this.Btn_SaveNew.Visible = false;
            this.Btn_SaveNew.Click += new System.EventHandler(this.Btn_SaveNew_Click);
            // 
            // Lbl_StudentId
            // 
            this.Lbl_StudentId.AutoSize = true;
            this.Lbl_StudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_StudentId.Location = new System.Drawing.Point(13, 9);
            this.Lbl_StudentId.Name = "Lbl_StudentId";
            this.Lbl_StudentId.Size = new System.Drawing.Size(98, 20);
            this.Lbl_StudentId.TabIndex = 34;
            this.Lbl_StudentId.Text = "Student ID";
            // 
            // Txtb_StudentId
            // 
            this.Txtb_StudentId.Enabled = false;
            this.Txtb_StudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_StudentId.Location = new System.Drawing.Point(213, 6);
            this.Txtb_StudentId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_StudentId.Name = "Txtb_StudentId";
            this.Txtb_StudentId.Size = new System.Drawing.Size(159, 27);
            this.Txtb_StudentId.TabIndex = 1;
            this.Txtb_StudentId.TextChanged += new System.EventHandler(this.Txtb_StudentId_TextChanged);
            this.Txtb_StudentId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtb_StudentId_KeyDown);
            this.Txtb_StudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtb_StudentId_KeyPress);
            // 
            // TxtB_StudentFName
            // 
            this.TxtB_StudentFName.Enabled = false;
            this.TxtB_StudentFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtB_StudentFName.Location = new System.Drawing.Point(213, 33);
            this.TxtB_StudentFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtB_StudentFName.MaxLength = 10;
            this.TxtB_StudentFName.Name = "TxtB_StudentFName";
            this.TxtB_StudentFName.Size = new System.Drawing.Size(159, 27);
            this.TxtB_StudentFName.TabIndex = 2;
            // 
            // Lbl_StudentFname
            // 
            this.Lbl_StudentFname.AutoSize = true;
            this.Lbl_StudentFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_StudentFname.Location = new System.Drawing.Point(12, 36);
            this.Lbl_StudentFname.Name = "Lbl_StudentFname";
            this.Lbl_StudentFname.Size = new System.Drawing.Size(172, 20);
            this.Lbl_StudentFname.TabIndex = 37;
            this.Lbl_StudentFname.Text = "Student First Name";
            // 
            // Lbl_StudentLName
            // 
            this.Lbl_StudentLName.AutoSize = true;
            this.Lbl_StudentLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_StudentLName.Location = new System.Drawing.Point(13, 69);
            this.Lbl_StudentLName.Name = "Lbl_StudentLName";
            this.Lbl_StudentLName.Size = new System.Drawing.Size(170, 20);
            this.Lbl_StudentLName.TabIndex = 38;
            this.Lbl_StudentLName.Text = "Student Last Name";
            // 
            // Txtb_StudentLName
            // 
            this.Txtb_StudentLName.Enabled = false;
            this.Txtb_StudentLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_StudentLName.Location = new System.Drawing.Point(213, 63);
            this.Txtb_StudentLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_StudentLName.MaxLength = 10;
            this.Txtb_StudentLName.Name = "Txtb_StudentLName";
            this.Txtb_StudentLName.Size = new System.Drawing.Size(159, 27);
            this.Txtb_StudentLName.TabIndex = 3;
            // 
            // Lbl_Dob
            // 
            this.Lbl_Dob.AutoSize = true;
            this.Lbl_Dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dob.Location = new System.Drawing.Point(13, 110);
            this.Lbl_Dob.Name = "Lbl_Dob";
            this.Lbl_Dob.Size = new System.Drawing.Size(118, 20);
            this.Lbl_Dob.TabIndex = 40;
            this.Lbl_Dob.Text = "Date of Birth";
            // 
            // Dtp_DOB
            // 
            this.Dtp_DOB.Enabled = false;
            this.Dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DOB.Location = new System.Drawing.Point(213, 105);
            this.Dtp_DOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dtp_DOB.Name = "Dtp_DOB";
            this.Dtp_DOB.Size = new System.Drawing.Size(159, 27);
            this.Dtp_DOB.TabIndex = 4;
            // 
            // Lbl_gender
            // 
            this.Lbl_gender.AutoSize = true;
            this.Lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_gender.Location = new System.Drawing.Point(13, 142);
            this.Lbl_gender.Name = "Lbl_gender";
            this.Lbl_gender.Size = new System.Drawing.Size(70, 20);
            this.Lbl_gender.TabIndex = 42;
            this.Lbl_gender.Text = "Gender";
            // 
            // Cb_Gender
            // 
            this.Cb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Gender.Enabled = false;
            this.Cb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Gender.FormattingEnabled = true;
            this.Cb_Gender.Location = new System.Drawing.Point(213, 142);
            this.Cb_Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_Gender.Name = "Cb_Gender";
            this.Cb_Gender.Size = new System.Drawing.Size(159, 28);
            this.Cb_Gender.TabIndex = 5;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Email.Location = new System.Drawing.Point(389, 9);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(138, 20);
            this.Lbl_Email.TabIndex = 44;
            this.Lbl_Email.Text = "E-Mail Address";
            // 
            // Txtb_email
            // 
            this.Txtb_email.Enabled = false;
            this.Txtb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_email.Location = new System.Drawing.Point(624, 9);
            this.Txtb_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_email.MaxLength = 30;
            this.Txtb_email.Name = "Txtb_email";
            this.Txtb_email.Size = new System.Drawing.Size(257, 27);
            this.Txtb_email.TabIndex = 6;
            // 
            // Lbl_Parent_FName
            // 
            this.Lbl_Parent_FName.AutoSize = true;
            this.Lbl_Parent_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Parent_FName.Location = new System.Drawing.Point(389, 70);
            this.Lbl_Parent_FName.Name = "Lbl_Parent_FName";
            this.Lbl_Parent_FName.Size = new System.Drawing.Size(163, 20);
            this.Lbl_Parent_FName.TabIndex = 46;
            this.Lbl_Parent_FName.Text = "Parent First Name";
            // 
            // Txtb_ParentFName
            // 
            this.Txtb_ParentFName.Enabled = false;
            this.Txtb_ParentFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_ParentFName.Location = new System.Drawing.Point(624, 71);
            this.Txtb_ParentFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_ParentFName.MaxLength = 10;
            this.Txtb_ParentFName.Name = "Txtb_ParentFName";
            this.Txtb_ParentFName.Size = new System.Drawing.Size(257, 27);
            this.Txtb_ParentFName.TabIndex = 8;
            // 
            // TxtB_ParentLName
            // 
            this.TxtB_ParentLName.Enabled = false;
            this.TxtB_ParentLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtB_ParentLName.Location = new System.Drawing.Point(624, 105);
            this.TxtB_ParentLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtB_ParentLName.MaxLength = 10;
            this.TxtB_ParentLName.Name = "TxtB_ParentLName";
            this.TxtB_ParentLName.Size = new System.Drawing.Size(257, 27);
            this.TxtB_ParentLName.TabIndex = 9;
            // 
            // Lbl_ParentLName
            // 
            this.Lbl_ParentLName.AutoSize = true;
            this.Lbl_ParentLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ParentLName.Location = new System.Drawing.Point(389, 102);
            this.Lbl_ParentLName.Name = "Lbl_ParentLName";
            this.Lbl_ParentLName.Size = new System.Drawing.Size(161, 20);
            this.Lbl_ParentLName.TabIndex = 48;
            this.Lbl_ParentLName.Text = "Parent Last Name";
            // 
            // Lbl_ParentId
            // 
            this.Lbl_ParentId.AutoSize = true;
            this.Lbl_ParentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ParentId.Location = new System.Drawing.Point(389, 42);
            this.Lbl_ParentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ParentId.Name = "Lbl_ParentId";
            this.Lbl_ParentId.Size = new System.Drawing.Size(89, 20);
            this.Lbl_ParentId.TabIndex = 52;
            this.Lbl_ParentId.Text = "Parent ID";
            // 
            // Cb_ParentId
            // 
            this.Cb_ParentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_ParentId.Enabled = false;
            this.Cb_ParentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_ParentId.FormattingEnabled = true;
            this.Cb_ParentId.Location = new System.Drawing.Point(624, 39);
            this.Cb_ParentId.Margin = new System.Windows.Forms.Padding(4);
            this.Cb_ParentId.Name = "Cb_ParentId";
            this.Cb_ParentId.Size = new System.Drawing.Size(257, 28);
            this.Cb_ParentId.TabIndex = 7;
            // 
            // Lbl_AddressId
            // 
            this.Lbl_AddressId.AutoSize = true;
            this.Lbl_AddressId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddressId.Location = new System.Drawing.Point(909, 12);
            this.Lbl_AddressId.Name = "Lbl_AddressId";
            this.Lbl_AddressId.Size = new System.Drawing.Size(103, 20);
            this.Lbl_AddressId.TabIndex = 54;
            this.Lbl_AddressId.Text = "Address ID";
            // 
            // Lbl_AddressStreet
            // 
            this.Lbl_AddressStreet.AutoSize = true;
            this.Lbl_AddressStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddressStreet.Location = new System.Drawing.Point(909, 44);
            this.Lbl_AddressStreet.Name = "Lbl_AddressStreet";
            this.Lbl_AddressStreet.Size = new System.Drawing.Size(135, 20);
            this.Lbl_AddressStreet.TabIndex = 55;
            this.Lbl_AddressStreet.Text = "Address Street";
            // 
            // Lbl_AddressCity
            // 
            this.Lbl_AddressCity.AutoSize = true;
            this.Lbl_AddressCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddressCity.Location = new System.Drawing.Point(909, 81);
            this.Lbl_AddressCity.Name = "Lbl_AddressCity";
            this.Lbl_AddressCity.Size = new System.Drawing.Size(117, 20);
            this.Lbl_AddressCity.TabIndex = 56;
            this.Lbl_AddressCity.Text = "Address City";
            // 
            // Lbl_AddressRegion
            // 
            this.Lbl_AddressRegion.AutoSize = true;
            this.Lbl_AddressRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddressRegion.Location = new System.Drawing.Point(909, 112);
            this.Lbl_AddressRegion.Name = "Lbl_AddressRegion";
            this.Lbl_AddressRegion.Size = new System.Drawing.Size(142, 20);
            this.Lbl_AddressRegion.TabIndex = 57;
            this.Lbl_AddressRegion.Text = "Address Region";
            // 
            // Lbl_AddressPostcode
            // 
            this.Lbl_AddressPostcode.AutoSize = true;
            this.Lbl_AddressPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddressPostcode.Location = new System.Drawing.Point(909, 142);
            this.Lbl_AddressPostcode.Name = "Lbl_AddressPostcode";
            this.Lbl_AddressPostcode.Size = new System.Drawing.Size(162, 20);
            this.Lbl_AddressPostcode.TabIndex = 58;
            this.Lbl_AddressPostcode.Text = "Address Postcode";
            // 
            // Lbl_ParentPhoneNumber
            // 
            this.Lbl_ParentPhoneNumber.AutoSize = true;
            this.Lbl_ParentPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ParentPhoneNumber.Location = new System.Drawing.Point(389, 142);
            this.Lbl_ParentPhoneNumber.Name = "Lbl_ParentPhoneNumber";
            this.Lbl_ParentPhoneNumber.Size = new System.Drawing.Size(193, 20);
            this.Lbl_ParentPhoneNumber.TabIndex = 59;
            this.Lbl_ParentPhoneNumber.Text = "Parent Phone Number";
            // 
            // Cb_AddressId
            // 
            this.Cb_AddressId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_AddressId.Enabled = false;
            this.Cb_AddressId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_AddressId.FormattingEnabled = true;
            this.Cb_AddressId.Location = new System.Drawing.Point(1088, 7);
            this.Cb_AddressId.Margin = new System.Windows.Forms.Padding(4);
            this.Cb_AddressId.Name = "Cb_AddressId";
            this.Cb_AddressId.Size = new System.Drawing.Size(257, 28);
            this.Cb_AddressId.TabIndex = 61;
            // 
            // Txtb_AddressStreet
            // 
            this.Txtb_AddressStreet.Enabled = false;
            this.Txtb_AddressStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_AddressStreet.Location = new System.Drawing.Point(1088, 41);
            this.Txtb_AddressStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_AddressStreet.MaxLength = 30;
            this.Txtb_AddressStreet.Name = "Txtb_AddressStreet";
            this.Txtb_AddressStreet.Size = new System.Drawing.Size(257, 27);
            this.Txtb_AddressStreet.TabIndex = 11;
            // 
            // Txtb_AddressCity
            // 
            this.Txtb_AddressCity.Enabled = false;
            this.Txtb_AddressCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_AddressCity.Location = new System.Drawing.Point(1088, 75);
            this.Txtb_AddressCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_AddressCity.MaxLength = 30;
            this.Txtb_AddressCity.Name = "Txtb_AddressCity";
            this.Txtb_AddressCity.Size = new System.Drawing.Size(257, 27);
            this.Txtb_AddressCity.TabIndex = 12;
            // 
            // Txtb_AddressRegion
            // 
            this.Txtb_AddressRegion.Enabled = false;
            this.Txtb_AddressRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_AddressRegion.Location = new System.Drawing.Point(1088, 106);
            this.Txtb_AddressRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_AddressRegion.MaxLength = 30;
            this.Txtb_AddressRegion.Name = "Txtb_AddressRegion";
            this.Txtb_AddressRegion.Size = new System.Drawing.Size(257, 27);
            this.Txtb_AddressRegion.TabIndex = 13;
            // 
            // Txtb_AddressPostCode
            // 
            this.Txtb_AddressPostCode.Enabled = false;
            this.Txtb_AddressPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_AddressPostCode.Location = new System.Drawing.Point(1088, 139);
            this.Txtb_AddressPostCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_AddressPostCode.MaxLength = 7;
            this.Txtb_AddressPostCode.Name = "Txtb_AddressPostCode";
            this.Txtb_AddressPostCode.Size = new System.Drawing.Size(257, 27);
            this.Txtb_AddressPostCode.TabIndex = 14;
            // 
            // Txtb_ParentPN
            // 
            this.Txtb_ParentPN.Enabled = false;
            this.Txtb_ParentPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_ParentPN.Location = new System.Drawing.Point(624, 137);
            this.Txtb_ParentPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtb_ParentPN.MaxLength = 30;
            this.Txtb_ParentPN.Name = "Txtb_ParentPN";
            this.Txtb_ParentPN.Size = new System.Drawing.Size(257, 27);
            this.Txtb_ParentPN.TabIndex = 10;
            // 
            // Btn_EnableSearch
            // 
            this.Btn_EnableSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_EnableSearch.Location = new System.Drawing.Point(1381, 15);
            this.Btn_EnableSearch.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_EnableSearch.Name = "Btn_EnableSearch";
            this.Btn_EnableSearch.Size = new System.Drawing.Size(159, 58);
            this.Btn_EnableSearch.TabIndex = 67;
            this.Btn_EnableSearch.Text = "Search By Student ID";
            this.Btn_EnableSearch.UseVisualStyleBackColor = false;
            this.Btn_EnableSearch.Click += new System.EventHandler(this.Btn_EnableSearch_Click);
            // 
            // Btn_search_student
            // 
            this.Btn_search_student.Enabled = false;
            this.Btn_search_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_search_student.Location = new System.Drawing.Point(1381, 84);
            this.Btn_search_student.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_search_student.Name = "Btn_search_student";
            this.Btn_search_student.Size = new System.Drawing.Size(159, 28);
            this.Btn_search_student.TabIndex = 68;
            this.Btn_search_student.Text = "Search";
            this.Btn_search_student.UseVisualStyleBackColor = false;
            this.Btn_search_student.Visible = false;
            this.Btn_search_student.Click += new System.EventHandler(this.Btn_search_student_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 977);
            this.Controls.Add(this.Btn_search_student);
            this.Controls.Add(this.Btn_EnableSearch);
            this.Controls.Add(this.Txtb_ParentPN);
            this.Controls.Add(this.Txtb_AddressPostCode);
            this.Controls.Add(this.Txtb_AddressRegion);
            this.Controls.Add(this.Txtb_AddressCity);
            this.Controls.Add(this.Txtb_AddressStreet);
            this.Controls.Add(this.Cb_AddressId);
            this.Controls.Add(this.Lbl_ParentPhoneNumber);
            this.Controls.Add(this.Lbl_AddressPostcode);
            this.Controls.Add(this.Lbl_AddressRegion);
            this.Controls.Add(this.Lbl_AddressCity);
            this.Controls.Add(this.Lbl_AddressStreet);
            this.Controls.Add(this.Lbl_AddressId);
            this.Controls.Add(this.Cb_ParentId);
            this.Controls.Add(this.Lbl_ParentId);
            this.Controls.Add(this.TxtB_ParentLName);
            this.Controls.Add(this.Lbl_ParentLName);
            this.Controls.Add(this.Txtb_ParentFName);
            this.Controls.Add(this.Lbl_Parent_FName);
            this.Controls.Add(this.Txtb_email);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Cb_Gender);
            this.Controls.Add(this.Lbl_gender);
            this.Controls.Add(this.Dtp_DOB);
            this.Controls.Add(this.Lbl_Dob);
            this.Controls.Add(this.Txtb_StudentLName);
            this.Controls.Add(this.Lbl_StudentLName);
            this.Controls.Add(this.Lbl_StudentFname);
            this.Controls.Add(this.TxtB_StudentFName);
            this.Controls.Add(this.Txtb_StudentId);
            this.Controls.Add(this.Lbl_StudentId);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_InsertNew);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_SaveNew);
            this.Controls.Add(this.Lbl_StudentDetails);
            this.Controls.Add(this.Dgv_Students);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.ShowIcon = false;
            this.Text = "Students Manager";
            this.Load += new System.EventHandler(this.Student_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The DGV students
        /// </summary>
        private System.Windows.Forms.DataGridView Dgv_Students;
        /// <summary>
        /// The label student details
        /// </summary>
        private System.Windows.Forms.Label Lbl_StudentDetails;
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
        /// The label student identifier
        /// </summary>
        private System.Windows.Forms.Label Lbl_StudentId;
        /// <summary>
        /// The TXTB student identifier
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_StudentId;
        /// <summary>
        /// The text b student f name
        /// </summary>
        private System.Windows.Forms.TextBox TxtB_StudentFName;
        /// <summary>
        /// The label student fname
        /// </summary>
        private System.Windows.Forms.Label Lbl_StudentFname;
        /// <summary>
        /// The label student l name
        /// </summary>
        private System.Windows.Forms.Label Lbl_StudentLName;
        /// <summary>
        /// The TXTB student l name
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_StudentLName;
        /// <summary>
        /// The label dob
        /// </summary>
        private System.Windows.Forms.Label Lbl_Dob;
        /// <summary>
        /// The DTP dob
        /// </summary>
        private System.Windows.Forms.DateTimePicker Dtp_DOB;
        /// <summary>
        /// The label gender
        /// </summary>
        private System.Windows.Forms.Label Lbl_gender;
        /// <summary>
        /// The cb gender
        /// </summary>
        private System.Windows.Forms.ComboBox Cb_Gender;
        /// <summary>
        /// The label email
        /// </summary>
        private System.Windows.Forms.Label Lbl_Email;
        /// <summary>
        /// The TXTB email
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_email;
        /// <summary>
        /// The label parent f name
        /// </summary>
        private System.Windows.Forms.Label Lbl_Parent_FName;
        /// <summary>
        /// The TXTB parent f name
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_ParentFName;
        /// <summary>
        /// The text b parent l name
        /// </summary>
        private System.Windows.Forms.TextBox TxtB_ParentLName;
        /// <summary>
        /// The label parent l name
        /// </summary>
        private System.Windows.Forms.Label Lbl_ParentLName;
        /// <summary>
        /// The label parent identifier
        /// </summary>
        private System.Windows.Forms.Label Lbl_ParentId;
        /// <summary>
        /// The cb parent identifier
        /// </summary>
        private System.Windows.Forms.ComboBox Cb_ParentId;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label Lbl_AddressId;
        /// <summary>
        /// The label2
        /// </summary>
        private System.Windows.Forms.Label Lbl_AddressStreet;
        /// <summary>
        /// The label3
        /// </summary>
        private System.Windows.Forms.Label Lbl_AddressCity;
        /// <summary>
        /// The label4
        /// </summary>
        private System.Windows.Forms.Label Lbl_AddressRegion;
        /// <summary>
        /// The label5
        /// </summary>
        private System.Windows.Forms.Label Lbl_AddressPostcode;
        /// <summary>
        /// The label6
        /// </summary>
        private System.Windows.Forms.Label Lbl_ParentPhoneNumber;
        /// <summary>
        /// The cb address identifier
        /// </summary>
        private System.Windows.Forms.ComboBox Cb_AddressId;
        /// <summary>
        /// The TXTB address street
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_AddressStreet;
        /// <summary>
        /// The TXTB address city
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_AddressCity;
        /// <summary>
        /// The TXTB address region
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_AddressRegion;
        /// <summary>
        /// The TXTB address post code
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_AddressPostCode;
        /// <summary>
        /// The TXTB parent pn
        /// </summary>
        private System.Windows.Forms.TextBox Txtb_ParentPN;
        /// <summary>
        /// The BTN enable search
        /// </summary>
        private System.Windows.Forms.Button Btn_EnableSearch;
        /// <summary>
        /// The BTN search student
        /// </summary>
        private System.Windows.Forms.Button Btn_search_student;
    }
}