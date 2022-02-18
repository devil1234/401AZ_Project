namespace _401AZ_PROJECT
{
    partial class Teaching_materials_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgv_TeachingMaterials = new System.Windows.Forms.DataGridView();
            this.Btn_Upload = new System.Windows.Forms.Button();
            this.Btn_Download = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Fd_Upload = new System.Windows.Forms.OpenFileDialog();
            this.Lbl_TeacherId = new System.Windows.Forms.Label();
            this.Btn_ChooseFile = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Lbl_Description = new System.Windows.Forms.Label();
            this.Txt_Description = new System.Windows.Forms.TextBox();
            this.Btn_DeleteRecord = new System.Windows.Forms.Button();
            this.sv_Download = new System.Windows.Forms.SaveFileDialog();
            this.Cb_TeacherId = new System.Windows.Forms.ComboBox();
            this.Lbl_TeacherFName = new System.Windows.Forms.Label();
            this.Cb_TFName = new System.Windows.Forms.ComboBox();
            this.Lbl_TeacherLName = new System.Windows.Forms.Label();
            this.Cb_TLName = new System.Windows.Forms.ComboBox();
            this.Lbl_TMDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TeachingMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_TeachingMaterials
            // 
            this.Dgv_TeachingMaterials.AllowUserToAddRows = false;
            this.Dgv_TeachingMaterials.AllowUserToDeleteRows = false;
            this.Dgv_TeachingMaterials.AllowUserToResizeColumns = false;
            this.Dgv_TeachingMaterials.AllowUserToResizeRows = false;
            this.Dgv_TeachingMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_TeachingMaterials.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_TeachingMaterials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.Dgv_TeachingMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_TeachingMaterials.DefaultCellStyle = dataGridViewCellStyle12;
            this.Dgv_TeachingMaterials.Location = new System.Drawing.Point(12, 150);
            this.Dgv_TeachingMaterials.MultiSelect = false;
            this.Dgv_TeachingMaterials.Name = "Dgv_TeachingMaterials";
            this.Dgv_TeachingMaterials.ReadOnly = true;
            this.Dgv_TeachingMaterials.RowHeadersVisible = false;
            this.Dgv_TeachingMaterials.RowHeadersWidth = 51;
            this.Dgv_TeachingMaterials.RowTemplate.Height = 24;
            this.Dgv_TeachingMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_TeachingMaterials.Size = new System.Drawing.Size(1210, 610);
            this.Dgv_TeachingMaterials.TabIndex = 0;
            // 
            // Btn_Upload
            // 
            this.Btn_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Upload.Location = new System.Drawing.Point(1239, 150);
            this.Btn_Upload.Name = "Btn_Upload";
            this.Btn_Upload.Size = new System.Drawing.Size(176, 54);
            this.Btn_Upload.TabIndex = 1;
            this.Btn_Upload.Text = "Upload file";
            this.Btn_Upload.UseVisualStyleBackColor = true;
            this.Btn_Upload.Click += new System.EventHandler(this.Btn_Upload_Click);
            // 
            // Btn_Download
            // 
            this.Btn_Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Download.Location = new System.Drawing.Point(1239, 210);
            this.Btn_Download.Name = "Btn_Download";
            this.Btn_Download.Size = new System.Drawing.Size(176, 54);
            this.Btn_Download.TabIndex = 2;
            this.Btn_Download.Text = "Download file";
            this.Btn_Download.UseVisualStyleBackColor = true;
            this.Btn_Download.Click += new System.EventHandler(this.Btn_Download_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Refresh.Location = new System.Drawing.Point(1239, 706);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(176, 54);
            this.Btn_Refresh.TabIndex = 3;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Fd_Upload
            // 
            this.Fd_Upload.Title = "Select a file to upload";
            this.Fd_Upload.FileOk += new System.ComponentModel.CancelEventHandler(this.Fd_Upload_FileOk);
            // 
            // Lbl_TeacherId
            // 
            this.Lbl_TeacherId.AutoSize = true;
            this.Lbl_TeacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TeacherId.Location = new System.Drawing.Point(10, 15);
            this.Lbl_TeacherId.Name = "Lbl_TeacherId";
            this.Lbl_TeacherId.Size = new System.Drawing.Size(88, 17);
            this.Lbl_TeacherId.TabIndex = 4;
            this.Lbl_TeacherId.Text = "Teacher ID";
            this.Lbl_TeacherId.Visible = false;
            // 
            // Btn_ChooseFile
            // 
            this.Btn_ChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChooseFile.Location = new System.Drawing.Point(1239, 150);
            this.Btn_ChooseFile.Name = "Btn_ChooseFile";
            this.Btn_ChooseFile.Size = new System.Drawing.Size(176, 54);
            this.Btn_ChooseFile.TabIndex = 6;
            this.Btn_ChooseFile.Text = "Choose File";
            this.Btn_ChooseFile.UseVisualStyleBackColor = true;
            this.Btn_ChooseFile.Visible = false;
            this.Btn_ChooseFile.Click += new System.EventHandler(this.Btn_ChooseFile_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.Location = new System.Drawing.Point(1239, 210);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(176, 54);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Visible = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Lbl_Description
            // 
            this.Lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Description.Location = new System.Drawing.Point(10, 71);
            this.Lbl_Description.Name = "Lbl_Description";
            this.Lbl_Description.Size = new System.Drawing.Size(143, 24);
            this.Lbl_Description.TabIndex = 8;
            this.Lbl_Description.Text = "File Description";
            this.Lbl_Description.Visible = false;
            // 
            // Txt_Description
            // 
            this.Txt_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Description.Location = new System.Drawing.Point(166, 72);
            this.Txt_Description.MaxLength = 255;
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Size = new System.Drawing.Size(1056, 23);
            this.Txt_Description.TabIndex = 9;
            this.Txt_Description.Text = "No Description";
            this.Txt_Description.Visible = false;
            // 
            // Btn_DeleteRecord
            // 
            this.Btn_DeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteRecord.Location = new System.Drawing.Point(1239, 646);
            this.Btn_DeleteRecord.Name = "Btn_DeleteRecord";
            this.Btn_DeleteRecord.Size = new System.Drawing.Size(176, 54);
            this.Btn_DeleteRecord.TabIndex = 11;
            this.Btn_DeleteRecord.Text = "Delete file";
            this.Btn_DeleteRecord.UseVisualStyleBackColor = true;
            this.Btn_DeleteRecord.Click += new System.EventHandler(this.Btn_DeleteRecord_Click);
            // 
            // Cb_TeacherId
            // 
            this.Cb_TeacherId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_TeacherId.Enabled = false;
            this.Cb_TeacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_TeacherId.FormattingEnabled = true;
            this.Cb_TeacherId.Location = new System.Drawing.Point(166, 15);
            this.Cb_TeacherId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_TeacherId.Name = "Cb_TeacherId";
            this.Cb_TeacherId.Size = new System.Drawing.Size(213, 25);
            this.Cb_TeacherId.TabIndex = 29;
            this.Cb_TeacherId.Visible = false;
            this.Cb_TeacherId.SelectedIndexChanged += new System.EventHandler(this.Cb_TeacherId_SelectedIndexChanged);
            // 
            // Lbl_TeacherFName
            // 
            this.Lbl_TeacherFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TeacherFName.Location = new System.Drawing.Point(437, 15);
            this.Lbl_TeacherFName.Name = "Lbl_TeacherFName";
            this.Lbl_TeacherFName.Size = new System.Drawing.Size(116, 51);
            this.Lbl_TeacherFName.TabIndex = 30;
            this.Lbl_TeacherFName.Text = "Teacher First Name";
            this.Lbl_TeacherFName.Visible = false;
            // 
            // Cb_TFName
            // 
            this.Cb_TFName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_TFName.Enabled = false;
            this.Cb_TFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_TFName.FormattingEnabled = true;
            this.Cb_TFName.Location = new System.Drawing.Point(569, 15);
            this.Cb_TFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_TFName.Name = "Cb_TFName";
            this.Cb_TFName.Size = new System.Drawing.Size(163, 25);
            this.Cb_TFName.TabIndex = 31;
            this.Cb_TFName.Visible = false;
            // 
            // Lbl_TeacherLName
            // 
            this.Lbl_TeacherLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TeacherLName.Location = new System.Drawing.Point(770, 15);
            this.Lbl_TeacherLName.Name = "Lbl_TeacherLName";
            this.Lbl_TeacherLName.Size = new System.Drawing.Size(104, 51);
            this.Lbl_TeacherLName.TabIndex = 32;
            this.Lbl_TeacherLName.Text = "Teacher Last Name";
            this.Lbl_TeacherLName.Visible = false;
            // 
            // Cb_TLName
            // 
            this.Cb_TLName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_TLName.Enabled = false;
            this.Cb_TLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_TLName.FormattingEnabled = true;
            this.Cb_TLName.Location = new System.Drawing.Point(880, 15);
            this.Cb_TLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb_TLName.Name = "Cb_TLName";
            this.Cb_TLName.Size = new System.Drawing.Size(163, 25);
            this.Cb_TLName.TabIndex = 33;
            this.Cb_TLName.Visible = false;
            // 
            // Lbl_TMDetails
            // 
            this.Lbl_TMDetails.AutoSize = true;
            this.Lbl_TMDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TMDetails.Location = new System.Drawing.Point(11, 112);
            this.Lbl_TMDetails.Name = "Lbl_TMDetails";
            this.Lbl_TMDetails.Size = new System.Drawing.Size(255, 24);
            this.Lbl_TMDetails.TabIndex = 34;
            this.Lbl_TMDetails.Text = "Teaching Materials Details";
            // 
            // Teaching_materials_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1427, 772);
            this.Controls.Add(this.Lbl_TMDetails);
            this.Controls.Add(this.Cb_TLName);
            this.Controls.Add(this.Lbl_TeacherLName);
            this.Controls.Add(this.Cb_TFName);
            this.Controls.Add(this.Lbl_TeacherFName);
            this.Controls.Add(this.Cb_TeacherId);
            this.Controls.Add(this.Btn_DeleteRecord);
            this.Controls.Add(this.Txt_Description);
            this.Controls.Add(this.Lbl_Description);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_ChooseFile);
            this.Controls.Add(this.Lbl_TeacherId);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Btn_Download);
            this.Controls.Add(this.Btn_Upload);
            this.Controls.Add(this.Dgv_TeachingMaterials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Teaching_materials_form";
            this.ShowIcon = false;
            this.Text = "Teaching Materials";
            this.Load += new System.EventHandler(this.Teaching_materials_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TeachingMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_TeachingMaterials;
        private System.Windows.Forms.Button Btn_Upload;
        private System.Windows.Forms.Button Btn_Download;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.OpenFileDialog Fd_Upload;
        private System.Windows.Forms.Label Lbl_TeacherId;
        private System.Windows.Forms.Button Btn_ChooseFile;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label Lbl_Description;
        private System.Windows.Forms.TextBox Txt_Description;
        private System.Windows.Forms.Button Btn_DeleteRecord;
        private System.Windows.Forms.SaveFileDialog sv_Download;
        private System.Windows.Forms.ComboBox Cb_TeacherId;
        private System.Windows.Forms.Label Lbl_TeacherFName;
        private System.Windows.Forms.ComboBox Cb_TFName;
        private System.Windows.Forms.Label Lbl_TeacherLName;
        private System.Windows.Forms.ComboBox Cb_TLName;
        private System.Windows.Forms.Label Lbl_TMDetails;
    }
}