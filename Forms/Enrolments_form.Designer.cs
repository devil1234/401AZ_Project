namespace _401AZ_PROJECT
{
    partial class Enrolments_form
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
            this.Dgv_Enrolments = new System.Windows.Forms.DataGridView();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.btn_InsertNew = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.btn_EnableSearchById = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_SaveNew = new System.Windows.Forms.Button();
            this.Dtp_DateStart = new System.Windows.Forms.DateTimePicker();
            this.Dtp_DateEnd = new System.Windows.Forms.DateTimePicker();
            this.Lbl_DateStart = new System.Windows.Forms.Label();
            this.Lbl_DateEnd = new System.Windows.Forms.Label();
            this.Lbl_ClassId = new System.Windows.Forms.Label();
            this.Lbl_StudentIdSearch = new System.Windows.Forms.Label();
            this.Lbl_Student_FName = new System.Windows.Forms.Label();
            this.Lbl_Student_LName = new System.Windows.Forms.Label();
            this.Cb_Student_FName = new System.Windows.Forms.ComboBox();
            this.Cb_Student_LName = new System.Windows.Forms.ComboBox();
            this.Btn_search_student_by_id = new System.Windows.Forms.Button();
            this.Cb_ClassId = new System.Windows.Forms.ComboBox();
            this.Lbl_Classroom = new System.Windows.Forms.Label();
            this.Cb_Classroom = new System.Windows.Forms.ComboBox();
            this.Cb_Subject = new System.Windows.Forms.ComboBox();
            this.Lbl_Subject = new System.Windows.Forms.Label();
            this.Lbl_TeacherId = new System.Windows.Forms.Label();
            this.Cb_TeacherId = new System.Windows.Forms.ComboBox();
            this.Txtb_StudentId_Search = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.Cb_StudentId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Enrolments)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Enrolments
            // 
            this.Dgv_Enrolments.AllowUserToAddRows = false;
            this.Dgv_Enrolments.AllowUserToDeleteRows = false;
            this.Dgv_Enrolments.AllowUserToOrderColumns = true;
            this.Dgv_Enrolments.AllowUserToResizeColumns = false;
            this.Dgv_Enrolments.AllowUserToResizeRows = false;
            this.Dgv_Enrolments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Enrolments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Enrolments.Location = new System.Drawing.Point(12, 260);
            this.Dgv_Enrolments.Name = "Dgv_Enrolments";
            this.Dgv_Enrolments.ReadOnly = true;
            this.Dgv_Enrolments.RowHeadersWidth = 51;
            this.Dgv_Enrolments.RowTemplate.Height = 24;
            this.Dgv_Enrolments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Enrolments.Size = new System.Drawing.Size(1536, 550);
            this.Dgv_Enrolments.TabIndex = 0;
            this.Dgv_Enrolments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dgv_Enrolments_CellFormatting);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Cancel.Location = new System.Drawing.Point(1225, 222);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(159, 28);
            this.Btn_Cancel.TabIndex = 34;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Visible = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btn_InsertNew
            // 
            this.btn_InsertNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InsertNew.Location = new System.Drawing.Point(1055, 72);
            this.btn_InsertNew.Name = "btn_InsertNew";
            this.btn_InsertNew.Size = new System.Drawing.Size(159, 28);
            this.btn_InsertNew.TabIndex = 33;
            this.btn_InsertNew.Text = "Insert New";
            this.btn_InsertNew.UseVisualStyleBackColor = false;
            this.btn_InsertNew.Click += new System.EventHandler(this.btn_InsertNew_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Refresh.Location = new System.Drawing.Point(1390, 222);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(159, 28);
            this.Btn_Refresh.TabIndex = 32;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // btn_EnableSearchById
            // 
            this.btn_EnableSearchById.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_EnableSearchById.Location = new System.Drawing.Point(1390, 157);
            this.btn_EnableSearchById.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EnableSearchById.Name = "btn_EnableSearchById";
            this.btn_EnableSearchById.Size = new System.Drawing.Size(159, 58);
            this.btn_EnableSearchById.TabIndex = 31;
            this.btn_EnableSearchById.Text = "Search by Student ID";
            this.btn_EnableSearchById.UseVisualStyleBackColor = false;
            this.btn_EnableSearchById.Click += new System.EventHandler(this.btn_EnableSearchById_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete.Location = new System.Drawing.Point(1055, 222);
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
            this.Btn_Save.Location = new System.Drawing.Point(1055, 180);
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
            this.Btn_Update.Location = new System.Drawing.Point(1055, 144);
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
            this.Btn_SaveNew.Enabled = false;
            this.Btn_SaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_SaveNew.Location = new System.Drawing.Point(1055, 108);
            this.Btn_SaveNew.Name = "Btn_SaveNew";
            this.Btn_SaveNew.Size = new System.Drawing.Size(159, 28);
            this.Btn_SaveNew.TabIndex = 27;
            this.Btn_SaveNew.Text = "Save New";
            this.Btn_SaveNew.UseVisualStyleBackColor = false;
            this.Btn_SaveNew.Visible = false;
            this.Btn_SaveNew.Click += new System.EventHandler(this.Btn_SaveNew_Click);
            // 
            // Dtp_DateStart
            // 
            this.Dtp_DateStart.Enabled = false;
            this.Dtp_DateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DateStart.Location = new System.Drawing.Point(159, 78);
            this.Dtp_DateStart.Name = "Dtp_DateStart";
            this.Dtp_DateStart.Size = new System.Drawing.Size(146, 27);
            this.Dtp_DateStart.TabIndex = 35;
            // 
            // Dtp_DateEnd
            // 
            this.Dtp_DateEnd.Enabled = false;
            this.Dtp_DateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DateEnd.Location = new System.Drawing.Point(159, 126);
            this.Dtp_DateEnd.Name = "Dtp_DateEnd";
            this.Dtp_DateEnd.Size = new System.Drawing.Size(146, 27);
            this.Dtp_DateEnd.TabIndex = 36;
            // 
            // Lbl_DateStart
            // 
            this.Lbl_DateStart.AutoSize = true;
            this.Lbl_DateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DateStart.Location = new System.Drawing.Point(21, 85);
            this.Lbl_DateStart.Name = "Lbl_DateStart";
            this.Lbl_DateStart.Size = new System.Drawing.Size(96, 20);
            this.Lbl_DateStart.TabIndex = 37;
            this.Lbl_DateStart.Text = "Date Start";
            // 
            // Lbl_DateEnd
            // 
            this.Lbl_DateEnd.AutoSize = true;
            this.Lbl_DateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DateEnd.Location = new System.Drawing.Point(21, 133);
            this.Lbl_DateEnd.Name = "Lbl_DateEnd";
            this.Lbl_DateEnd.Size = new System.Drawing.Size(87, 20);
            this.Lbl_DateEnd.TabIndex = 38;
            this.Lbl_DateEnd.Text = "Date End";
            // 
            // Lbl_ClassId
            // 
            this.Lbl_ClassId.AutoSize = true;
            this.Lbl_ClassId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ClassId.Location = new System.Drawing.Point(21, 34);
            this.Lbl_ClassId.Name = "Lbl_ClassId";
            this.Lbl_ClassId.Size = new System.Drawing.Size(82, 20);
            this.Lbl_ClassId.TabIndex = 39;
            this.Lbl_ClassId.Text = "Class ID";
            // 
            // Lbl_StudentIdSearch
            // 
            this.Lbl_StudentIdSearch.AutoSize = true;
            this.Lbl_StudentIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_StudentIdSearch.Location = new System.Drawing.Point(385, 226);
            this.Lbl_StudentIdSearch.Name = "Lbl_StudentIdSearch";
            this.Lbl_StudentIdSearch.Size = new System.Drawing.Size(163, 20);
            this.Lbl_StudentIdSearch.TabIndex = 41;
            this.Lbl_StudentIdSearch.Text = "Student ID Search";
            this.Lbl_StudentIdSearch.Visible = false;
            // 
            // Lbl_Student_FName
            // 
            this.Lbl_Student_FName.AutoSize = true;
            this.Lbl_Student_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Student_FName.Location = new System.Drawing.Point(385, 85);
            this.Lbl_Student_FName.Name = "Lbl_Student_FName";
            this.Lbl_Student_FName.Size = new System.Drawing.Size(172, 20);
            this.Lbl_Student_FName.TabIndex = 42;
            this.Lbl_Student_FName.Text = "Student First Name";
            // 
            // Lbl_Student_LName
            // 
            this.Lbl_Student_LName.AutoSize = true;
            this.Lbl_Student_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Student_LName.Location = new System.Drawing.Point(385, 131);
            this.Lbl_Student_LName.Name = "Lbl_Student_LName";
            this.Lbl_Student_LName.Size = new System.Drawing.Size(170, 20);
            this.Lbl_Student_LName.TabIndex = 43;
            this.Lbl_Student_LName.Text = "Student Last Name";
            // 
            // Cb_Student_FName
            // 
            this.Cb_Student_FName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Student_FName.Enabled = false;
            this.Cb_Student_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Student_FName.FormattingEnabled = true;
            this.Cb_Student_FName.Location = new System.Drawing.Point(589, 80);
            this.Cb_Student_FName.Name = "Cb_Student_FName";
            this.Cb_Student_FName.Size = new System.Drawing.Size(212, 28);
            this.Cb_Student_FName.TabIndex = 45;
            // 
            // Cb_Student_LName
            // 
            this.Cb_Student_LName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Student_LName.Enabled = false;
            this.Cb_Student_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Student_LName.FormattingEnabled = true;
            this.Cb_Student_LName.Location = new System.Drawing.Point(589, 123);
            this.Cb_Student_LName.Name = "Cb_Student_LName";
            this.Cb_Student_LName.Size = new System.Drawing.Size(212, 28);
            this.Cb_Student_LName.TabIndex = 46;
            // 
            // Btn_search_student_by_id
            // 
            this.Btn_search_student_by_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_search_student_by_id.Location = new System.Drawing.Point(808, 218);
            this.Btn_search_student_by_id.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_search_student_by_id.Name = "Btn_search_student_by_id";
            this.Btn_search_student_by_id.Size = new System.Drawing.Size(159, 28);
            this.Btn_search_student_by_id.TabIndex = 47;
            this.Btn_search_student_by_id.Text = "Search";
            this.Btn_search_student_by_id.UseVisualStyleBackColor = false;
            this.Btn_search_student_by_id.Visible = false;
            this.Btn_search_student_by_id.Click += new System.EventHandler(this.Btn_search_student_by_id_Click);
            // 
            // Cb_ClassId
            // 
            this.Cb_ClassId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_ClassId.Enabled = false;
            this.Cb_ClassId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_ClassId.FormattingEnabled = true;
            this.Cb_ClassId.Location = new System.Drawing.Point(159, 30);
            this.Cb_ClassId.Name = "Cb_ClassId";
            this.Cb_ClassId.Size = new System.Drawing.Size(146, 28);
            this.Cb_ClassId.TabIndex = 50;
            // 
            // Lbl_Classroom
            // 
            this.Lbl_Classroom.AutoSize = true;
            this.Lbl_Classroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Classroom.Location = new System.Drawing.Point(21, 188);
            this.Lbl_Classroom.Name = "Lbl_Classroom";
            this.Lbl_Classroom.Size = new System.Drawing.Size(99, 20);
            this.Lbl_Classroom.TabIndex = 51;
            this.Lbl_Classroom.Text = "Classroom";
            // 
            // Cb_Classroom
            // 
            this.Cb_Classroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Classroom.Enabled = false;
            this.Cb_Classroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Classroom.FormattingEnabled = true;
            this.Cb_Classroom.Location = new System.Drawing.Point(159, 180);
            this.Cb_Classroom.Name = "Cb_Classroom";
            this.Cb_Classroom.Size = new System.Drawing.Size(146, 28);
            this.Cb_Classroom.TabIndex = 52;
            // 
            // Cb_Subject
            // 
            this.Cb_Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Subject.Enabled = false;
            this.Cb_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Subject.FormattingEnabled = true;
            this.Cb_Subject.Location = new System.Drawing.Point(589, 168);
            this.Cb_Subject.Name = "Cb_Subject";
            this.Cb_Subject.Size = new System.Drawing.Size(212, 28);
            this.Cb_Subject.TabIndex = 53;
            // 
            // Lbl_Subject
            // 
            this.Lbl_Subject.AutoSize = true;
            this.Lbl_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Subject.Location = new System.Drawing.Point(385, 176);
            this.Lbl_Subject.Name = "Lbl_Subject";
            this.Lbl_Subject.Size = new System.Drawing.Size(72, 20);
            this.Lbl_Subject.TabIndex = 54;
            this.Lbl_Subject.Text = "Subject";
            // 
            // Lbl_TeacherId
            // 
            this.Lbl_TeacherId.AutoSize = true;
            this.Lbl_TeacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TeacherId.Location = new System.Drawing.Point(18, 226);
            this.Lbl_TeacherId.Name = "Lbl_TeacherId";
            this.Lbl_TeacherId.Size = new System.Drawing.Size(102, 20);
            this.Lbl_TeacherId.TabIndex = 55;
            this.Lbl_TeacherId.Text = "Teacher ID";
            // 
            // Cb_TeacherId
            // 
            this.Cb_TeacherId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_TeacherId.Enabled = false;
            this.Cb_TeacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_TeacherId.FormattingEnabled = true;
            this.Cb_TeacherId.Location = new System.Drawing.Point(159, 222);
            this.Cb_TeacherId.Name = "Cb_TeacherId";
            this.Cb_TeacherId.Size = new System.Drawing.Size(146, 28);
            this.Cb_TeacherId.TabIndex = 56;
            // 
            // Txtb_StudentId_Search
            // 
            this.Txtb_StudentId_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_StudentId_Search.Location = new System.Drawing.Point(589, 219);
            this.Txtb_StudentId_Search.Name = "Txtb_StudentId_Search";
            this.Txtb_StudentId_Search.Size = new System.Drawing.Size(212, 27);
            this.Txtb_StudentId_Search.TabIndex = 57;
            this.Txtb_StudentId_Search.Visible = false;
            this.Txtb_StudentId_Search.TextChanged += new System.EventHandler(this.Txtb_StudentId_TextChanged);
            this.Txtb_StudentId_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtb_StudentId_KeyDown);
            this.Txtb_StudentId_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtb_StudentId_KeyPress);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(385, 38);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(98, 20);
            this.lbl.TabIndex = 58;
            this.lbl.Text = "Student ID";
            // 
            // Cb_StudentId
            // 
            this.Cb_StudentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_StudentId.Enabled = false;
            this.Cb_StudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_StudentId.FormattingEnabled = true;
            this.Cb_StudentId.Location = new System.Drawing.Point(589, 30);
            this.Cb_StudentId.Name = "Cb_StudentId";
            this.Cb_StudentId.Size = new System.Drawing.Size(212, 28);
            this.Cb_StudentId.TabIndex = 59;
            // 
            // Enrolments_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 822);
            this.Controls.Add(this.Cb_StudentId);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.Txtb_StudentId_Search);
            this.Controls.Add(this.Cb_TeacherId);
            this.Controls.Add(this.Lbl_TeacherId);
            this.Controls.Add(this.Lbl_Subject);
            this.Controls.Add(this.Cb_Subject);
            this.Controls.Add(this.Cb_Classroom);
            this.Controls.Add(this.Lbl_Classroom);
            this.Controls.Add(this.Cb_ClassId);
            this.Controls.Add(this.Btn_search_student_by_id);
            this.Controls.Add(this.Cb_Student_LName);
            this.Controls.Add(this.Cb_Student_FName);
            this.Controls.Add(this.Lbl_Student_LName);
            this.Controls.Add(this.Lbl_Student_FName);
            this.Controls.Add(this.Lbl_StudentIdSearch);
            this.Controls.Add(this.Lbl_ClassId);
            this.Controls.Add(this.Lbl_DateEnd);
            this.Controls.Add(this.Lbl_DateStart);
            this.Controls.Add(this.Dtp_DateEnd);
            this.Controls.Add(this.Dtp_DateStart);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.btn_InsertNew);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.btn_EnableSearchById);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_SaveNew);
            this.Controls.Add(this.Dgv_Enrolments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Enrolments_form";
            this.Text = "Enrolments";
            this.Load += new System.EventHandler(this.Enrolments_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Enrolments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Enrolments;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button btn_InsertNew;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Button btn_EnableSearchById;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_SaveNew;
        private System.Windows.Forms.DateTimePicker Dtp_DateStart;
        private System.Windows.Forms.DateTimePicker Dtp_DateEnd;
        private System.Windows.Forms.Label Lbl_DateStart;
        private System.Windows.Forms.Label Lbl_DateEnd;
        private System.Windows.Forms.Label Lbl_ClassId;
        private System.Windows.Forms.Label Lbl_StudentIdSearch;
        private System.Windows.Forms.Label Lbl_Student_FName;
        private System.Windows.Forms.Label Lbl_Student_LName;
        private System.Windows.Forms.ComboBox Cb_Student_FName;
        private System.Windows.Forms.ComboBox Cb_Student_LName;
        private System.Windows.Forms.Button Btn_search_student_by_id;
        private System.Windows.Forms.ComboBox Cb_ClassId;
        private System.Windows.Forms.Label Lbl_Classroom;
        private System.Windows.Forms.ComboBox Cb_Classroom;
        private System.Windows.Forms.ComboBox Cb_Subject;
        private System.Windows.Forms.Label Lbl_Subject;
        private System.Windows.Forms.Label Lbl_TeacherId;
        private System.Windows.Forms.ComboBox Cb_TeacherId;
        private System.Windows.Forms.TextBox Txtb_StudentId_Search;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox Cb_StudentId;
    }
}