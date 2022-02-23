// ***********************************************************************
// Assembly         : 401AZ_PROJECT
// Author           : Stefan-Robert Ursu
// Created          : 02-18-2022
//
// Last Modified By : Stefan-Robert Ursu
// Last Modified On : 02-19-2022
// ***********************************************************************
// <copyright file="Project.Designer.cs" company="Personal Project">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace _401AZ_PROJECT.Forms
{
    /// <summary>
    /// Class Project.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
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
            this.Btn_teachers.Location = new System.Drawing.Point(12, 102);
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
            this.Btn_timetables.Location = new System.Drawing.Point(12, 218);
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
            this.Btn_enrolments.Location = new System.Drawing.Point(12, 276);
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
            this.Btn_students.Location = new System.Drawing.Point(11, 160);
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
            this.Btn_teaching_material.Location = new System.Drawing.Point(12, 334);
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
            this.Lbl_Welcome.Size = new System.Drawing.Size(689, 80);
            this.Lbl_Welcome.TabIndex = 5;
            this.Lbl_Welcome.Text = "Welcome to Harris & Sons Education Consulting LTD. DBMS!";
            this.Lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Management System Harris Sons Education";
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The BTN teachers
        /// </summary>
        private System.Windows.Forms.Button Btn_teachers;
        /// <summary>
        /// The BTN timetables
        /// </summary>
        private System.Windows.Forms.Button Btn_timetables;
        /// <summary>
        /// The BTN enrolments
        /// </summary>
        private System.Windows.Forms.Button Btn_enrolments;
        /// <summary>
        /// The BTN students
        /// </summary>
        private System.Windows.Forms.Button Btn_students;
        /// <summary>
        /// The BTN teaching material
        /// </summary>
        private System.Windows.Forms.Button Btn_teaching_material;
        /// <summary>
        /// The label welcome
        /// </summary>
        private System.Windows.Forms.Label Lbl_Welcome;
    }
}