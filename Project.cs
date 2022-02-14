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

        private void Btn_Timetables_Click(object sender, EventArgs e)
        {
            Timetable_form timetable = new Timetable_form();
            timetable.Show();
        }

        private void Btn_Enrolments_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Teachers_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Students_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Teaching_Material_Click(object sender, EventArgs e)
        {

        }
    }
}
