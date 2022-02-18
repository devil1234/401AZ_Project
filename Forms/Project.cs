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

        public bool Open { get; set; }

        private void Btn_Timetables_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimetableForm timetable = new TimetableForm();
            timetable.ShowDialog();
            this.Show();
        }

        private void Btn_Enrolments_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrolmentsForm enrolments = new EnrolmentsForm();
            enrolments.ShowDialog();
            this.Show();
        }

        private void Btn_Teachers_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersForm teachersForm = new TeachersForm();
            teachersForm.ShowDialog();
            this.Show();
        }

        private void Btn_Students_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
            this.Show();
        }

        private void Btn_Teaching_Material_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachingMaterialsForm teachingMaterials = new TeachingMaterialsForm();
            teachingMaterials.ShowDialog();
            this.Show();
        }

    }
}
