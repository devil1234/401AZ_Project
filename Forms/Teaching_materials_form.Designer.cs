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
            this.Num_TeacherId = new System.Windows.Forms.NumericUpDown();
            this.Btn_DeleteRecord = new System.Windows.Forms.Button();
            this.sv_Download = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_TeachingMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_TeacherId)).BeginInit();
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
            this.Dgv_TeachingMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_TeachingMaterials.Location = new System.Drawing.Point(12, 107);
            this.Dgv_TeachingMaterials.MultiSelect = false;
            this.Dgv_TeachingMaterials.Name = "Dgv_TeachingMaterials";
            this.Dgv_TeachingMaterials.ReadOnly = true;
            this.Dgv_TeachingMaterials.RowHeadersWidth = 51;
            this.Dgv_TeachingMaterials.RowTemplate.Height = 24;
            this.Dgv_TeachingMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_TeachingMaterials.Size = new System.Drawing.Size(1210, 653);
            this.Dgv_TeachingMaterials.TabIndex = 0;
            // 
            // Btn_Upload
            // 
            this.Btn_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Upload.Location = new System.Drawing.Point(1239, 107);
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
            this.Btn_Download.Location = new System.Drawing.Point(1239, 167);
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
            this.Lbl_TeacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TeacherId.Location = new System.Drawing.Point(8, 18);
            this.Lbl_TeacherId.Name = "Lbl_TeacherId";
            this.Lbl_TeacherId.Size = new System.Drawing.Size(102, 20);
            this.Lbl_TeacherId.TabIndex = 4;
            this.Lbl_TeacherId.Text = "Teacher_Id";
            this.Lbl_TeacherId.Visible = false;
            // 
            // Btn_ChooseFile
            // 
            this.Btn_ChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChooseFile.Location = new System.Drawing.Point(1239, 26);
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
            this.Btn_Cancel.Location = new System.Drawing.Point(1239, 646);
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
            this.Lbl_Description.Location = new System.Drawing.Point(8, 53);
            this.Lbl_Description.Name = "Lbl_Description";
            this.Lbl_Description.Size = new System.Drawing.Size(143, 51);
            this.Lbl_Description.TabIndex = 8;
            this.Lbl_Description.Text = "File Description";
            this.Lbl_Description.Visible = false;
            // 
            // Txt_Description
            // 
            this.Txt_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Description.Location = new System.Drawing.Point(165, 53);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Size = new System.Drawing.Size(1057, 27);
            this.Txt_Description.TabIndex = 9;
            this.Txt_Description.Text = "No Description";
            this.Txt_Description.Visible = false;
            // 
            // Num_TeacherId
            // 
            this.Num_TeacherId.Location = new System.Drawing.Point(165, 18);
            this.Num_TeacherId.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.Num_TeacherId.Minimum = new decimal(new int[] {
            50001,
            0,
            0,
            0});
            this.Num_TeacherId.Name = "Num_TeacherId";
            this.Num_TeacherId.ReadOnly = true;
            this.Num_TeacherId.Size = new System.Drawing.Size(127, 22);
            this.Num_TeacherId.TabIndex = 10;
            this.Num_TeacherId.Value = new decimal(new int[] {
            50001,
            0,
            0,
            0});
            this.Num_TeacherId.Visible = false;
            // 
            // Btn_DeleteRecord
            // 
            this.Btn_DeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteRecord.Location = new System.Drawing.Point(1239, 586);
            this.Btn_DeleteRecord.Name = "Btn_DeleteRecord";
            this.Btn_DeleteRecord.Size = new System.Drawing.Size(176, 54);
            this.Btn_DeleteRecord.TabIndex = 11;
            this.Btn_DeleteRecord.Text = "Delete file";
            this.Btn_DeleteRecord.UseVisualStyleBackColor = true;
            this.Btn_DeleteRecord.Click += new System.EventHandler(this.Btn_DeleteRecord_Click);
            // 
            // sv_Download
            // 
            // 
            // Teaching_materials_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1427, 772);
            this.Controls.Add(this.Btn_DeleteRecord);
            this.Controls.Add(this.Num_TeacherId);
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
            ((System.ComponentModel.ISupportInitialize)(this.Num_TeacherId)).EndInit();
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
        private System.Windows.Forms.NumericUpDown Num_TeacherId;
        private System.Windows.Forms.Button Btn_DeleteRecord;
        private System.Windows.Forms.SaveFileDialog sv_Download;
    }
}