using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _401AZ_PROJECT
{
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }

        public bool open { get; set; }

        private void Btn_Timetables_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timetable_form timetable = new Timetable_form();
            timetable.ShowDialog();
            this.Show();
        }

        private void Btn_Enrolments_Click(object sender, EventArgs e)
        {
            this.Hide();
            Enrolments_form enrolments = new Enrolments_form();
            enrolments.ShowDialog();
            this.Show();
        }

        private void Btn_Teachers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teachers_form teachers_Form = new Teachers_form();
            teachers_Form.ShowDialog();
            this.Show();
        }

        private void Btn_Students_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_form student_Form = new Student_form();
            student_Form.ShowDialog();
            this.Show();
        }

        private void Btn_Teaching_Material_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teaching_materials_form teaching_Materials = new Teaching_materials_form();
            teaching_Materials.ShowDialog();
            this.Show();
        }

    }
}
