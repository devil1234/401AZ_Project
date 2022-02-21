using System;
using System.Windows.Forms;

namespace _401AZ_PROJECT.Forms
{
    /// <summary>
    /// Class Project.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Project : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        public Project()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Project" /> is open.
        /// </summary>
        /// <value><c>true</c> if open; otherwise, <c>false</c>.</value>
        public bool Open { get; set; }

        /// <summary>
        /// Handles the Click event of the Btn_Timetables control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Timetables_Click(object sender, EventArgs e)
        {
            Hide();
            var timetable = new TimetableForm();
            timetable.ShowDialog();
            Show();
        }

        /// <summary>
        /// Handles the Click event of the Btn_Enrolments control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Enrolments_Click(object sender, EventArgs e)
        {
            Hide();
            var enrolments = new EnrolmentsForm();
            enrolments.ShowDialog();
            Show();
        }

        /// <summary>
        /// Handles the Click event of the Btn_Teachers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Teachers_Click(object sender, EventArgs e)
        {
            Hide();
            var teachersForm = new TeachersForm();
            teachersForm.ShowDialog();
            Show();
        }

        /// <summary>
        /// Handles the Click event of the Btn_Students control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Students_Click(object sender, EventArgs e)
        {
            Hide();
            var studentForm = new StudentForm();
            studentForm.ShowDialog();
            Show();
        }

        /// <summary>
        /// Handles the Click event of the Btn_Teaching_Material control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Teaching_Material_Click(object sender, EventArgs e)
        {
            Hide();
            var teachingMaterials = new TeachingMaterialsForm();
            teachingMaterials.ShowDialog();
            Show();
        }

    }
}
