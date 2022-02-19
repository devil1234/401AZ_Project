using _401AZ_PROJECT.Models;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _401AZ_PROJECT
{
    /// <summary>
    /// Class EnrolmentsForm.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class EnrolmentsForm : Form
    {
        private readonly DataManager _dm = new DataManager();
        private readonly Enrolment _enrol = new Enrolment();
        private readonly Student _student = new Student();
        private readonly TimeTable _tm = new TimeTable();
        private readonly DateStart _ds = new DateStart();
        private readonly DateEnd _de = new DateEnd();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnrolmentsForm" /> class.
        /// </summary>
        public EnrolmentsForm()
        {
            InitializeComponent();
        }

        // A method to convert to suitable DateTime for columns where is required
        /// <summary>
        /// Shorts the form date format.
        /// </summary>
        /// <param name="formatting">The <see cref="DataGridViewCellFormattingEventArgs" /> instance containing the event data.</param>
        private static void ShortFormDateFormat(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    var dateString = new StringBuilder();
                    var theDate = DateTime.Parse(formatting.Value.ToString());

                    dateString.Append(theDate.ToShortDateString());
                    formatting.Value = dateString.ToString();
                    formatting.FormattingApplied = true;
                }
                catch (FormatException)
                {
                    formatting.FormattingApplied = false;
                }
            }
        }

        /// <summary>
        /// Handles the Load event of the Enrolments_form control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Enrolments_form_Load(object sender, EventArgs e)
        {
            Dgv_Enrolments.DataSource = _dm.ToDataTable(_enrol.GetEnrolments());
            PopulateForm();
        }

        /// <summary>
        /// Handles the CellFormatting event of the Dgv_Enrolments control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellFormattingEventArgs" /> instance containing the event data.</param>
        private void Dgv_Enrolments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Dgv_Enrolments.Columns[e.ColumnIndex].Name == "StartDate")
            {
                ShortFormDateFormat(e);
            }

            if (Dgv_Enrolments.Columns[e.ColumnIndex].Name == "EndDate")
            {
                ShortFormDateFormat(e);
            }
        }

        /// <summary>
        /// Handles the Click event of the Btn_Refresh control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Dgv_Enrolments.DataSource = _dm.ToDataTable(_enrol.GetEnrolments());
            PopulateForm();
        }

        /// <summary>
        /// Populates the form.
        /// </summary>
        private void PopulateForm()
        {
            if (Dgv_Enrolments.SelectedRows.Count <= 0) return;
            //StudentID
            Cb_StudentId.Items.Insert(0, Dgv_Enrolments.SelectedCells[0].Value.ToString());
            Cb_StudentId.SelectedIndex = 0;
            Cb_StudentId.Text = Dgv_Enrolments.SelectedCells[0].Value.ToString();

            //ClassID
            Cb_ClassId.Items.Insert(0, Dgv_Enrolments.SelectedCells[1].Value.ToString());
            Cb_ClassId.SelectedIndex = 0;
            Cb_ClassId.Text = Dgv_Enrolments.SelectedCells[1].Value.ToString();

            //Student Fname
            Cb_Student_FName.Items.Insert(0, Dgv_Enrolments.SelectedCells[2].Value.ToString());
            Cb_Student_FName.SelectedIndex = 0;
            Cb_Student_FName.Text = Dgv_Enrolments.SelectedCells[2].Value.ToString();

            //Student Lname
            Cb_Student_LName.Items.Insert(0, Dgv_Enrolments.SelectedCells[3].Value.ToString());
            Cb_Student_LName.SelectedIndex = 0;
            Cb_Student_LName.Text = Dgv_Enrolments.SelectedCells[3].Value.ToString();

            //Classroom
            Cb_Classroom.Items.Insert(0, Dgv_Enrolments.SelectedCells[4].Value.ToString());
            Cb_Classroom.SelectedIndex = 0;
            Cb_Classroom.Text = Dgv_Enrolments.SelectedCells[4].Value.ToString();

            //Subject
            Cb_Subject.Items.Insert(0, Dgv_Enrolments.SelectedCells[5].Value.ToString());
            Cb_Subject.SelectedIndex = 0;
            Cb_Subject.Text = Dgv_Enrolments.SelectedCells[5].Value.ToString();

            //Date Start
            Dtp_DateStart.Text = Dgv_Enrolments.SelectedCells[6].Value.ToString();

            //Date End
            Dtp_DateEnd.Text = Dgv_Enrolments.SelectedCells[7].Value.ToString();

            //Teacher ID
            Cb_TeacherId.Items.Insert(0, Dgv_Enrolments.SelectedCells[8].Value.ToString());
            Cb_TeacherId.SelectedIndex = 0;
            Cb_TeacherId.Text = Dgv_Enrolments.SelectedCells[8].Value.ToString();
        }

        /// <summary>
        /// Unpopulates the form.
        /// </summary>
        private void UnpopulateForm()
        {
            //Student ID
            Cb_StudentId.DataSource = null;

            //Class ID
            Cb_ClassId.DataSource = null;

            //Student Fname
            Cb_Student_FName.DataSource = null;

            //Classroom
            Cb_Classroom.DataSource = null;

            //Subject
            Cb_Subject.DataSource = null;

            //Date Start
            Dtp_DateStart.Value = DateTime.Now;

            //Date End
            Dtp_DateEnd.Value = DateTime.Now;

            //teacher Id
            Cb_TeacherId.DataSource = null;
        }

        /// <summary>
        /// Buttons to enable.
        /// </summary>
        private void Button_Enable()
        {
            UnpopulateForm();
            Cb_ClassId.Enabled = true;
            Cb_StudentId.Enabled = true;
            Dtp_DateStart.Enabled = true;
            Dtp_DateEnd.Enabled = true;

            Lbl_Classroom.Visible = false;
            Cb_Classroom.Visible = false;

            Lbl_TeacherId.Visible = false;
            Cb_TeacherId.Visible = false;

            Lbl_Subject.Visible = false;
            Cb_Subject.Visible = false;

            btn_InsertNew.Enabled = false;
            btn_InsertNew.Visible = false;

            Btn_Delete.Enabled = false;
            Btn_Delete.Visible = false;

            Btn_Update.Enabled = false;
            Btn_Update.Visible = false;

            Btn_SaveNew.Enabled = true;
            Btn_SaveNew.Visible = true;

            Btn_Refresh.Enabled = false;
            Btn_Refresh.Visible = false;

            btn_EnableSearchById.Enabled = false;
            btn_EnableSearchById.Visible = false;

            Btn_Cancel.Visible = true;

            Dgv_Enrolments.Visible = false;

            Lbl_EnrolmentsDetails.Visible = false;
        }

        /// <summary>
        /// Buttons to disable.
        /// </summary>
        private void Button_Disable()
        {
            UnpopulateForm();
            Cb_ClassId.Enabled = false;
            Cb_StudentId.Enabled = false;
            Dtp_DateStart.Enabled = false;
            Dtp_DateEnd.Enabled = false;

            Lbl_Classroom.Visible = true;
            Cb_Classroom.Visible = true;

            Lbl_TeacherId.Visible = true;
            Cb_TeacherId.Visible = true;

            Lbl_Student_FName.Visible = true;
            Cb_Student_FName.Visible = true;

            Lbl_Student_LName.Visible = true;
            Cb_Student_LName.Visible = true;

            Lbl_Subject.Visible = true;
            Cb_Subject.Visible = true;

            btn_InsertNew.Enabled = true;
            btn_InsertNew.Visible = true;

            Btn_Delete.Enabled = true;
            Btn_Delete.Visible = true;

            Btn_Update.Enabled = true;
            Btn_Update.Visible = true;

            Btn_SaveNew.Enabled = false;
            Btn_SaveNew.Visible = false;

            Btn_Refresh.Enabled = true;
            Btn_Refresh.Visible = true;

            btn_EnableSearchById.Enabled = true;
            btn_EnableSearchById.Visible = true;

            Btn_Cancel.Visible = false;

            Dgv_Enrolments.Visible = true;

            Btn_Save.Visible = false;

            Lbl_EnrolmentsDetails.Visible = true;

            PopulateForm();
        }

        /// <summary>
        /// Handles the Click event of the btn_EnableSearchById control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btn_EnableSearchById_Click(object sender, EventArgs e)
        {
            if (Btn_search_student_by_id.Visible == false)
            {
                Txtb_StudentId_Search.Visible = true;
                Txtb_StudentId_Search.Text = null;
                Lbl_StudentIdSearch.Visible = true;
                Btn_search_student_by_id.Visible = true;
                Btn_Refresh.Visible = false;
                btn_InsertNew.Visible=false;
                Btn_Update.Visible=false;
                Btn_Delete.Visible=false;
            }
            else
            {
                Txtb_StudentId_Search.Visible = false;
                Lbl_StudentIdSearch.Visible = false;
                Btn_search_student_by_id.Visible = false;
                Btn_Refresh.Visible = true;
                btn_InsertNew.Visible = true;
                Btn_Update.Visible = true;
                Btn_Delete.Visible = true;
                Btn_Refresh.PerformClick();
            }
        }

        /// <summary>
        /// Handles the Click event of the Btn_search_student_by_id control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_search_student_by_id_Click(object sender, EventArgs e)
        {
            Dgv_Enrolments.DataSource = _dm.ToDataTable(_enrol.GetEnrolmentsByStudentId(Convert.ToInt32(Txtb_StudentId_Search.Text)));
        }

        /// <summary>
        /// Handles the Click event of the Btn_Delete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Dgv_Enrolments.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                var index = Int32.Parse(Dgv_Enrolments.SelectedCells[1].Value.ToString());
                var caption = "Are you sure you want to delete?";
                var message = "Do you want to delete the Enrolment with the Class Id of" + " " + index + " ?";
                var buttons = MessageBoxButtons.YesNo;
                var result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    _enrol.DeleteEnrolment(index);
                    Btn_Refresh.PerformClick();
                }
            }
        }


        /// <summary>
        /// Handles the Click event of the btn_InsertNew control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btn_InsertNew_Click(object sender, EventArgs e)
        {
            UnpopulateForm();
            Button_Enable();
            PopulateButtons();
            Btn_Cancel.Location = new Point(790, 149);
        }

        /// <summary>
        /// Populates the buttons.
        /// </summary>
        private void PopulateButtons()
        {
            //Student Id
            Cb_StudentId.DataSource = _dm.ToDataTable(_student.GetStudent_FName_LName());
            Cb_StudentId.DisplayMember = "StudentId";
            Cb_StudentId.ValueMember = "StudentId";

            //Date Start
            Dtp_DateStart.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);

            //Date End
            Dtp_DateEnd.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);

            //Class Id
            Cb_ClassId.DataSource = _dm.ToDataTable(_tm.GetTimeTable());
            Cb_ClassId.DisplayMember = "ClassId";
            Cb_ClassId.ValueMember = "ClassId";

        }

        /// <summary>
        /// Handles the TextChanged event of the Txtb_StudentId control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Txtb_StudentId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txtb_StudentId_Search.Text))
            {
                Btn_search_student_by_id.Enabled = false;
            }
            else
            {
                Btn_search_student_by_id.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the KeyDown event of the Txtb_StudentId control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs" /> instance containing the event data.</param>
        private void Txtb_StudentId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_search_student_by_id.PerformClick();
                Txtb_StudentId_Search.Clear();
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the Txtb_StudentId control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs" /> instance containing the event data.</param>
        private void Txtb_StudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the Btn_Cancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Button_Disable();
            Btn_Cancel.Location = new Point(918, 210);
        }

        /// <summary>
        /// Handles the Click event of the Btn_SaveNew control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_SaveNew_Click(object sender, EventArgs e)
        {
            //Retrive the StudentId from Combobox 
            var studentId = Int32.Parse(Cb_StudentId.SelectedValue.ToString());

            //Retrieve the ClassId from Combobox
            var classId = Int32.Parse(Cb_ClassId.SelectedValue.ToString());

            //check if the Date Start is existing in db, if not insert it and retrieve the id
            var dateStart = Dtp_DateStart.Value.ToShortDateString();
            if(_dm.ToDataTable(_ds.GetStartDateByDate(Convert.ToDateTime(dateStart))).Rows.Count == 0)
            {
                _ds.InsertDateStart(Convert.ToDateTime(dateStart));
            }
            var dateStartId = Int32.Parse(_dm.ToDataTable(_ds.GetStartDateByDate
                (Convert.ToDateTime(dateStart))).Rows[0].Field<string>("DateStartId"));

            //check if the Date End is existing in db, if not insert it and retrieve the id
            var dateEnd = Dtp_DateEnd.Value.ToShortDateString();
            if (_dm.ToDataTable(_de.GetEndDateByDate(Convert.ToDateTime(dateEnd))).Rows.Count == 0)
            {
                _de.InsertDateEnd(Convert.ToDateTime(dateEnd));
            }
            var dateEndId = Int32.Parse(_dm.ToDataTable(_de.GetEndDateByDate
                (Convert.ToDateTime(dateEnd))).Rows[0].Field<string>("DateEndId"));

            _enrol.InsertEnrolment(studentId,classId,dateStartId,dateEndId);
            Btn_Cancel.PerformClick();
            Btn_Refresh.PerformClick();

        }

        /// <summary>
        /// Handles the Click event of the Btn_Update control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (!Dgv_Enrolments.Rows.Cast<DataGridViewRow>()
                    .Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null))) return;
            //hide the buttons
            Button_Enable();

            //enable boxes
            Btn_SaveNew.Enabled = false;
            Btn_SaveNew.Visible = false;

            Btn_Save.Enabled = true;
            Btn_Save.Visible = true;

            Btn_Cancel.Location = new Point(790, 210);
            PopulateButtons();
        }

        /// <summary>
        /// Handles the Click event of the Btn_Save control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //Retrive the StudentId from Combobox 
            var studentId = Int32.Parse(Cb_StudentId.SelectedValue.ToString());

            //Retrieve the ClassId from Combobox
            var classId = Int32.Parse(Cb_ClassId.SelectedValue.ToString());

            //Update Start Date Based on date time picker and only if is new Start Date
            var startDateNew = Dtp_DateStart.Value.ToShortDateString();
            if(startDateNew != Dgv_Enrolments.SelectedCells[6].Value.ToString())
            {
                var startDateOld = Dgv_Enrolments.SelectedCells[6].Value.ToString();
                _ds.UpdateDateStartByDate(Convert.ToDateTime(startDateOld), Convert.ToDateTime(startDateNew));
            }
            var startDateId = Int32.Parse(_dm.ToDataTable(_ds.GetStartDateByDate
                (Convert.ToDateTime(startDateNew))).Rows[0].Field<string>("DateStartId"));


            //Update End Date Based on date time picker and only if is new Start Date
            var endDateNew = Dtp_DateEnd.Value.ToShortDateString();
            if(endDateNew != Dgv_Enrolments.SelectedCells[7].Value.ToString())
            {
                var endDateOld = Dgv_Enrolments.SelectedCells[7].Value.ToString();
                _de.UpdateDateEndByDate(Convert.ToDateTime(endDateOld), Convert.ToDateTime(endDateNew));
            }
            var endDateId = Int32.Parse(_dm.ToDataTable(_de.GetEndDateByDate
                 (Convert.ToDateTime(endDateNew))).Rows[0].Field<string>("DateEndId"));

            //Execute the update with above variables 
            _enrol.UpdateEnrolment(studentId, classId, startDateId, endDateId);

            //Perform click on Cancel Button after update
            Btn_Cancel.PerformClick();
            Btn_Refresh.PerformClick();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Cb_StudentId control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Cb_StudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cb_Student_FName.DataSource = Cb_StudentId.DataSource;
            Cb_Student_LName.DataSource = Cb_StudentId.DataSource;
            Cb_Student_FName.DisplayMember = "FirstName";
            Cb_Student_FName.ValueMember = "StudentId";

            Cb_Student_LName.DisplayMember = "LastName";
            Cb_Student_LName.ValueMember = "StudentId";

            Cb_StudentId.DisplayMember = "StudentId";
            Cb_StudentId.ValueMember = "StudentId";

        }

        /// <summary>
        /// Handles the SelectionChanged event of the Dgv_Enrolments control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Dgv_Enrolments_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_Enrolments.SelectedRows.Count > 0)
            {
                PopulateForm();
            }
            else
            {
                UnpopulateForm();
            }
        }
    }
}
