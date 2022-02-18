﻿namespace _401AZ_PROJECT
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
            this.Btn_teachers = new System.Windows.Forms.Button();
            this.Btn_timetables = new System.Windows.Forms.Button();
            this.Btn_enrolments = new System.Windows.Forms.Button();
            this.Btn_students = new System.Windows.Forms.Button();
            this.Btn_teaching_material = new System.Windows.Forms.Button();
            this.Lbl_Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_teachers
            // 
            this.Btn_teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_teachers.Location = new System.Drawing.Point(12, 219);
            this.Btn_teachers.Name = "Btn_teachers";
            this.Btn_teachers.Size = new System.Drawing.Size(671, 52);
            this.Btn_teachers.TabIndex = 0;
            this.Btn_teachers.Text = "Teachers Manager";
            this.Btn_teachers.UseVisualStyleBackColor = true;
            this.Btn_teachers.Click += new System.EventHandler(this.Btn_Teachers_Click);
            // 
            // Btn_timetables
            // 
            this.Btn_timetables.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_timetables.Location = new System.Drawing.Point(12, 106);
            this.Btn_timetables.Name = "Btn_timetables";
            this.Btn_timetables.Size = new System.Drawing.Size(671, 52);
            this.Btn_timetables.TabIndex = 1;
            this.Btn_timetables.Text = "Time Tables Manager";
            this.Btn_timetables.UseVisualStyleBackColor = true;
            this.Btn_timetables.Click += new System.EventHandler(this.Btn_Timetables_Click);
            // 
            // Btn_enrolments
            // 
            this.Btn_enrolments.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_enrolments.Location = new System.Drawing.Point(12, 163);
            this.Btn_enrolments.Name = "Btn_enrolments";
            this.Btn_enrolments.Size = new System.Drawing.Size(671, 52);
            this.Btn_enrolments.TabIndex = 2;
            this.Btn_enrolments.Text = "Enrolments Manager";
            this.Btn_enrolments.UseVisualStyleBackColor = true;
            this.Btn_enrolments.Click += new System.EventHandler(this.Btn_Enrolments_Click);
            // 
            // Btn_students
            // 
            this.Btn_students.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_students.Location = new System.Drawing.Point(11, 276);
            this.Btn_students.Name = "Btn_students";
            this.Btn_students.Size = new System.Drawing.Size(671, 52);
            this.Btn_students.TabIndex = 3;
            this.Btn_students.Text = "Students Manager";
            this.Btn_students.UseVisualStyleBackColor = true;
            this.Btn_students.Click += new System.EventHandler(this.Btn_Students_Click);
            // 
            // Btn_teaching_material
            // 
            this.Btn_teaching_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_teaching_material.Location = new System.Drawing.Point(12, 333);
            this.Btn_teaching_material.Name = "Btn_teaching_material";
            this.Btn_teaching_material.Size = new System.Drawing.Size(671, 52);
            this.Btn_teaching_material.TabIndex = 4;
            this.Btn_teaching_material.Text = "Teaching Materials Manager";
            this.Btn_teaching_material.UseVisualStyleBackColor = true;
            this.Btn_teaching_material.Click += new System.EventHandler(this.Btn_Teaching_Material_Click);
            // 
            // Lbl_Welcome
            // 
            this.Lbl_Welcome.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Welcome.Location = new System.Drawing.Point(3, 19);
            this.Lbl_Welcome.Name = "Lbl_Welcome";
            this.Lbl_Welcome.Size = new System.Drawing.Size(689, 75);
            this.Lbl_Welcome.TabIndex = 5;
            this.Lbl_Welcome.Text = "Welcome to Harris & Sons Education Consulting LTD. DBMS!";
            this.Lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(691, 398);
            this.Controls.Add(this.Lbl_Welcome);
            this.Controls.Add(this.Btn_teaching_material);
            this.Controls.Add(this.Btn_students);
            this.Controls.Add(this.Btn_enrolments);
            this.Controls.Add(this.Btn_timetables);
            this.Controls.Add(this.Btn_teachers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Project";
            this.ShowIcon = false;
            this.Text = "Database Management System Harris Sons Education";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_teachers;
        private System.Windows.Forms.Button Btn_timetables;
        private System.Windows.Forms.Button Btn_enrolments;
        private System.Windows.Forms.Button Btn_students;
        private System.Windows.Forms.Button Btn_teaching_material;
        private System.Windows.Forms.Label Lbl_Welcome;
    }
}