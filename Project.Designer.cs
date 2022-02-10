namespace _401AZ_PROJECT
{
    partial class Project
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
            this.btn_teachers = new System.Windows.Forms.Button();
            this.btn_timetables = new System.Windows.Forms.Button();
            this.btn_enrolments = new System.Windows.Forms.Button();
            this.btn_students = new System.Windows.Forms.Button();
            this.btn_teaching_material = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_teachers
            // 
            this.btn_teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teachers.Location = new System.Drawing.Point(13, 190);
            this.btn_teachers.Name = "btn_teachers";
            this.btn_teachers.Size = new System.Drawing.Size(755, 58);
            this.btn_teachers.TabIndex = 0;
            this.btn_teachers.Text = "Teachers";
            this.btn_teachers.UseVisualStyleBackColor = true;
            // 
            // btn_timetables
            // 
            this.btn_timetables.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timetables.Location = new System.Drawing.Point(13, 62);
            this.btn_timetables.Name = "btn_timetables";
            this.btn_timetables.Size = new System.Drawing.Size(755, 58);
            this.btn_timetables.TabIndex = 1;
            this.btn_timetables.Text = "Time Tables";
            this.btn_timetables.UseVisualStyleBackColor = true;
            this.btn_timetables.Click += new System.EventHandler(this.btn_timetables_Click);
            // 
            // btn_enrolments
            // 
            this.btn_enrolments.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enrolments.Location = new System.Drawing.Point(13, 126);
            this.btn_enrolments.Name = "btn_enrolments";
            this.btn_enrolments.Size = new System.Drawing.Size(755, 58);
            this.btn_enrolments.TabIndex = 2;
            this.btn_enrolments.Text = "Enrolments";
            this.btn_enrolments.UseVisualStyleBackColor = true;
            // 
            // btn_students
            // 
            this.btn_students.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_students.Location = new System.Drawing.Point(11, 254);
            this.btn_students.Name = "btn_students";
            this.btn_students.Size = new System.Drawing.Size(755, 58);
            this.btn_students.TabIndex = 3;
            this.btn_students.Text = "Students";
            this.btn_students.UseVisualStyleBackColor = true;
            // 
            // btn_teaching_material
            // 
            this.btn_teaching_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teaching_material.Location = new System.Drawing.Point(13, 318);
            this.btn_teaching_material.Name = "btn_teaching_material";
            this.btn_teaching_material.Size = new System.Drawing.Size(755, 58);
            this.btn_teaching_material.TabIndex = 4;
            this.btn_teaching_material.Text = "Teaching Materials";
            this.btn_teaching_material.UseVisualStyleBackColor = true;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(780, 456);
            this.Controls.Add(this.btn_teaching_material);
            this.Controls.Add(this.btn_students);
            this.Controls.Add(this.btn_enrolments);
            this.Controls.Add(this.btn_timetables);
            this.Controls.Add(this.btn_teachers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Project";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Database Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_teachers;
        private System.Windows.Forms.Button btn_timetables;
        private System.Windows.Forms.Button btn_enrolments;
        private System.Windows.Forms.Button btn_students;
        private System.Windows.Forms.Button btn_teaching_material;
    }
}