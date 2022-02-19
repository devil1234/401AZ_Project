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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Students.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.Lbl_StudentDetails.Size = new System.Drawing.Size(149, 24);
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
            this.Lbl_StudentId.Size = new System.Drawing.Size(84, 17);
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
            this.Txtb_StudentId.Size = new System.Drawing.Size(159, 23);
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
            this.TxtB_StudentFName.Size = new System.Drawing.Size(159, 23);
            this.TxtB_StudentFName.TabIndex = 2;
            // 
            // Lbl_StudentFname
            // 
            this.Lbl_StudentFname.AutoSize = true;
            this.Lbl_StudentFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_StudentFname.Location = new System.Drawing.Point(12, 36);
            this.Lbl_StudentFname.Name = "Lbl_StudentFname";
            this.Lbl_StudentFname.Size = new System.Drawing.Size(147, 17);
            this.Lbl_StudentFname.TabIndex = 37;
            this.Lbl_StudentFname.Text = "Student First Name";
            // 
            // Lbl_StudentLName
            // 
            this.Lbl_StudentLName.AutoSize = true;
            this.Lbl_StudentLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_StudentLName.Location = new System.Drawing.Point(13, 69);
            this.Lbl_StudentLName.Name = "Lbl_StudentLName";
            this.Lbl_StudentLName.Size = new System.Drawing.Size(146, 17);
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
            this.Txtb_StudentLName.Size = new System.Drawing.Size(159, 23);
            this.Txtb_StudentLName.TabIndex = 3;
            // 
            // Lbl_Dob
            // 
            this.Lbl_Dob.AutoSize = true;
            this.Lbl_Dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dob.Location = new System.Drawing.Point(13, 110);
            this.Lbl_Dob.Name = "Lbl_Dob";
            this.Lbl_Dob.Size = new System.Drawing.Size(100, 17);
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
            this.Dtp_DOB.Size = new System.Drawing.Size(159, 23);
            this.Dtp_DOB.TabIndex = 4;
            // 
            // Lbl_gender
            // 
            this.Lbl_gender.AutoSize = true;
            this.Lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_gender.Location = new System.Drawing.Point(13, 142);
            this.Lbl_gender.Name = "Lbl_gender";
            this.Lbl_gender.Size = new System.Drawing.Size(62, 17);
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
            this.Cb_Gender.Size = new System.Drawing.Size(159, 24);
            this.Cb_Gender.TabIndex = 5;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Email.Location = new System.Drawing.Point(389, 9);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(117, 17);
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
            this.Txtb_email.Size = new System.Drawing.Size(257, 23);
            this.Txtb_email.TabIndex = 6;
            // 
            // Lbl_Parent_FName
            // 
            this.Lbl_Parent_FName.AutoSize = true;
            this.Lbl_Parent_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Parent_FName.Location = new System.Drawing.Point(389, 70);
            this.Lbl_Parent_FName.Name = "Lbl_Parent_FName";
            this.Lbl_Parent_FName.Size = new System.Drawing.Size(139, 17);
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
            this.Txtb_ParentFName.Size = new System.Drawing.Size(257, 23);
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
            this.TxtB_ParentLName.Size = new System.Drawing.Size(257, 23);
            this.TxtB_ParentLName.TabIndex = 9;
            // 
            // Lbl_ParentLName
            // 
            this.Lbl_ParentLName.AutoSize = true;
            this.Lbl_ParentLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ParentLName.Location = new System.Drawing.Point(389, 102);
            this.Lbl_ParentLName.Name = "Lbl_ParentLName";
            this.Lbl_ParentLName.Size = new System.Drawing.Size(138, 17);
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
            this.Lbl_ParentId.Size = new System.Drawing.Size(71, 16);
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
            this.Cb_ParentId.Size = new System.Drawing.Size(257, 24);
            this.Cb_ParentId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(909, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Address ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(909, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Adress Street";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(909, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Adress City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(909, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Adress Region";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(909, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Adress Postcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "Parent Phone Number";
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
            this.Cb_AddressId.Size = new System.Drawing.Size(257, 24);
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
            this.Txtb_AddressStreet.Size = new System.Drawing.Size(257, 23);
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
            this.Txtb_AddressCity.Size = new System.Drawing.Size(257, 23);
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
            this.Txtb_AddressRegion.Size = new System.Drawing.Size(257, 23);
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
            this.Txtb_AddressPostCode.Size = new System.Drawing.Size(257, 23);
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
            this.Txtb_ParentPN.Size = new System.Drawing.Size(257, 23);
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
            // Student_form
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The label2
        /// </summary>
        private System.Windows.Forms.Label label2;
        /// <summary>
        /// The label3
        /// </summary>
        private System.Windows.Forms.Label label3;
        /// <summary>
        /// The label4
        /// </summary>
        private System.Windows.Forms.Label label4;
        /// <summary>
        /// The label5
        /// </summary>
        private System.Windows.Forms.Label label5;
        /// <summary>
        /// The label6
        /// </summary>
        private System.Windows.Forms.Label label6;
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