using _401AZ_PROJECT.Models;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace _401AZ_PROJECT
{
    /// <summary>
    /// Class TimetableForm.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class TimetableForm : Form
    {
        /// <summary>
        /// The initializes the classes required for this form to work
        /// </summary>
        private readonly DataManager _dm = new DataManager();
        private readonly TimeTable _timetable = new TimeTable();
        private readonly Days _day = new Days();
        private readonly Teachers _teacher = new Teachers();
        private readonly Classrooms _classroom = new Classrooms();
        private readonly StartTimeDay _std = new StartTimeDay();
        private readonly EndTimeDay _etd = new EndTimeDay();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimetableForm"/> class.
        /// </summary>
        public TimetableForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Handles the TextChanged event of the Txt_class_search control.
        /// Disable or enable Search button based on input
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Txt_class_search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_class_search.Text))
            {
                Btn_search_timetable.Enabled = false;
            }
            else
            {
                Btn_search_timetable.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the Btn_search_timetable control.
        /// Search the database by textbox entry
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_search_timetable_Click(object sender, EventArgs e)
        {
            dgv_classes.DataSource = _dm.ToDataTable(_timetable.GetTimeTableByClassroomName(Txt_class_search.Text));

        }

        /// Load the database data on load
        /// <summary>
        /// Handles the Load event of the Timetable control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Timetable_Load(object sender, EventArgs e)
        {
            dgv_classes.DataSource = _dm.ToDataTable(_timetable.GetTimeTable());
            Populate_Form();
        }

        /// <summary>
        /// Handles the Click event of the Btn_EnableSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_EnableSearch_Click(object sender, EventArgs e)
        {
            if(Btn_search_timetable.Visible == false)
            {
                Txt_class_search.Enabled = true;
                Btn_search_timetable.Visible = true;
            }
            else
            {
                Txt_class_search.Enabled = false;
                Btn_search_timetable.Visible=false;
                Btn_Refresh.PerformClick();
            }


        }

        /// <summary>
        /// Handles the KeyDown event of the Txt_class_search control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void Txt_class_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_search_timetable.PerformClick();
                Txt_class_search.Clear();
            }    
        }

        /// <summary>
        /// Handles the Click event of the Btn_Refresh control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            dgv_classes.DataSource = _dm.ToDataTable(_timetable.GetTimeTable());
            Populate_Form();
        }



        /// <summary>
        /// Handles the SelectionChanged event of the dgv_classes control.
        /// Set the values of boxes based on the selected row
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dgv_classes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_classes.SelectedRows.Count > 0)
            {
                Populate_Form();
            }
            else
            {
                Unpopulate_Form();
            }
        }

        /// <summary>
        /// Populates the form.
        /// </summary>
        private void Populate_Form()
        {
            if (dgv_classes.SelectedRows.Count > 0)
            {
                // Hides the colums
                dgv_classes.Columns["TeacherId"].Visible = false;
                dgv_classes.Columns["DayId"].Visible = false;

                //Class Id text
                Tb_ClassId.Text = dgv_classes.SelectedCells[0].Value.ToString();

                // Day text with combobox
                cb_Day.Items.Insert(0, dgv_classes.SelectedCells[1].Value.ToString());
                cb_Day.SelectedIndex = 0;
                cb_Day.Text = dgv_classes.SelectedCells[1].Value.ToString();

                //Start Time Day
                Dtp_Start_Time.Text = dgv_classes.SelectedCells[2].Value.ToString();

                //End Time Day
                Dtp_End_Time.Text = dgv_classes.SelectedCells[3].Value.ToString();

                //Classroom name
                Txt_class_search.Text = dgv_classes.SelectedCells[4].Value.ToString();

                //Subject
                Txtb_Subject.Text = dgv_classes.SelectedCells[5].Value.ToString();

                //Teacher First name
                Cb_T_Fname.Items.Insert(0, dgv_classes.SelectedCells[6].Value.ToString());
                Cb_T_Fname.SelectedIndex = 0;
                Cb_T_Fname.Text = dgv_classes.SelectedCells[6].Value.ToString();

                //Teacher Last name
                Cb_T_Lname.Items.Insert(0, dgv_classes.SelectedCells[7].Value.ToString());
                Cb_T_Lname.SelectedIndex = 0;
                Cb_T_Lname.Text = dgv_classes.SelectedCells[7].Value.ToString();


                //TeacherId
                Cb_TeacherId.Items.Insert(0, dgv_classes.SelectedCells[8].Value.ToString());
                Cb_TeacherId.SelectedIndex = 0;
                Cb_TeacherId.Text = dgv_classes.SelectedCells[8].Value.ToString();
            }
        }

        /// <summary>
        /// Unpopulates the form.
        /// </summary>
        private void Unpopulate_Form()
        {
            //Class Id text
            Tb_ClassId.Clear();
            // Day text with combobox

            cb_Day.DataSource = null;

            //Start Time Day
            Dtp_Start_Time.Text = null;
           
            //End Time Day
            Dtp_End_Time.Text = null;

            //Classroom name
            Txt_class_search.Text = null;
            
            //Teacher First name
            Cb_T_Fname.DataSource = null;
           
            //Teacher Last name
            Cb_T_Lname.DataSource = null;

            //Subject
            Txtb_Subject.Text = null;

            //TeacherId
            Cb_TeacherId.DataSource = null;

        }

        /// <summary>
        /// Handles the Click event of the btn_InsertNew control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_InsertNew_Click(object sender, EventArgs e)
        {
            Button_Enable();
            PopulateButtons();
        }

        /// <summary>
        /// Populates the buttons.
        /// </summary>
        private void PopulateButtons()
        {
            //cb_Day_id
            cb_Day.DataSource = _dm.ToDataTable(_day.GetDays());
            cb_Day.DisplayMember = "DayName";
            cb_Day.ValueMember = "DayId";
            if (dgv_classes.Rows.Cast<DataGridViewRow>()
                .Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                cb_Day.Text = dgv_classes.SelectedCells[1].Value.ToString();
            }
            
            //Start Time Day
            Dtp_Start_Time.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);

            //End Time Day
            Dtp_End_Time.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);

            //cb_TeacherId
            Cb_TeacherId.DataSource = _dm.ToDataTable(_teacher.GetTeacher_FName_LName());
            Cb_TeacherId.DisplayMember = "TeacherId";
            if (dgv_classes.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                Cb_TeacherId.SelectedValue = Int32.Parse(dgv_classes.SelectedCells[8].Value.ToString());
            }

            //Classroom name
            if (dgv_classes.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
                Txt_class_search.Text = dgv_classes.SelectedCells[4].Value.ToString();

            //Subject
            if (dgv_classes.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
                Txtb_Subject.Text = dgv_classes.SelectedCells[5].Value.ToString();

        }

        /// <summary>
        /// Buttons the enable.
        /// </summary>
        private void Button_Enable()
        {
            //Unpopulate_Form();
            cb_Day.Enabled = true;
            Dtp_Start_Time.Enabled = true;
            Dtp_End_Time.Enabled = true;
            Txt_class_search.Enabled = true;

            Cb_TeacherId.Enabled = true;
            Txtb_Subject.Enabled = true;

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

            btn_EnableSearch.Enabled = false;
            btn_EnableSearch.Visible = false;

            Btn_Cancel.Visible = true;

            dgv_classes.Enabled = false ;
            dgv_classes.Visible = false ;

            Lbl_Timetabledetails.Visible = false;
        }

        /// <summary>
        /// Buttons the disable.
        /// </summary>
        private void Button_Disable()
        {
            Unpopulate_Form();
            cb_Day.Enabled = false;
            Dtp_Start_Time.Enabled = false;
            Dtp_End_Time.Enabled = false;
            Txt_class_search.Enabled = false;

            Cb_TeacherId.Enabled = false;
            Txtb_Subject.Enabled = false;

            btn_InsertNew.Enabled = true;
            btn_InsertNew.Visible = true;

            Btn_Delete.Enabled = true;
            Btn_Delete.Visible = true;

            Btn_Update.Enabled = true;
            Btn_Update.Visible = true;

            Btn_Save.Visible= false;

            Btn_SaveNew.Visible = false;

            Btn_Refresh.Enabled = true;
            Btn_Refresh.Visible = true;

            btn_EnableSearch.Enabled = true;
            btn_EnableSearch.Visible = true;

            Btn_Cancel.Visible = false;

            dgv_classes.Enabled = true;
            dgv_classes.Visible = true;

            Lbl_Timetabledetails.Visible = true;

            Populate_Form();
        }

        /// <summary>
        /// Handles the Click event of the Btn_Cancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Button_Disable();
        }

        /// <summary>
        /// Handles the Click event of the Btn_SaveNew control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_SaveNew_Click(object sender, EventArgs e)
        {

            // Check if the ClassroomName is existing in db, if not insert it and return the id
            var classroomName = Txt_class_search.Text;
            if (_dm.ToDataTable(_classroom.GetClassroomId(classroomName)).Rows.Count == 0)
            {
                _classroom.InsertClassroom(classroomName);
            }
            var classroomId = Int32.Parse(_dm.ToDataTable(_classroom.GetClassroomId(classroomName)).Rows[0].Field<string>("ClassroomId"));


            //Retrive the subject text from textbox
            var subject = Txtb_Subject.Text;
            
            //Retrieve the Teacher Id text from ComboBox
            var teacherId = Int32.Parse(Cb_TeacherId.SelectedValue.ToString());
            
            // Check if the StartTimeDay is existing in db, if not insert it and retrieve the id
            Dtp_Start_Time.Text = null;
                                  var startTimeDay = Dtp_Start_Time.Value.ToLongTimeString();
            if (_dm.ToDataTable(_std.GetStartTimeDayIdByStd(Convert.ToDateTime(startTimeDay))).Rows.Count == 0)
            {
                _std.InsertStartTimeDay(Convert.ToDateTime(startTimeDay));
            }
            var startTimeDayId = Int32.Parse(_dm.ToDataTable(_std.GetStartTimeDayIdByStd(Convert.ToDateTime(startTimeDay))).Rows[0].Field<string>("StartTimeDayId"));

            // Check if the EndTimeDay is existing in db, if not insert it and return the id
            Dtp_End_Time.Text = null;
            var endTimeDay = Dtp_End_Time.Value.ToLongTimeString();
            if (_dm.ToDataTable(_etd.getEndTimeDayIdByEndTimeDays(Convert.ToDateTime(endTimeDay))).Rows.Count == 0)
            {
                _etd.InsertEndTimeDay(Convert.ToDateTime(endTimeDay));
            }
            var endTimeDayId = Int32.Parse(_dm.ToDataTable(_etd.getEndTimeDayIdByEndTimeDays(Convert.ToDateTime(endTimeDay))).Rows[0].Field<string>("EndTimeDayId"));

            var dayId = Int32.Parse(cb_Day.SelectedValue.ToString());


            _timetable.InsertTimetable(classroomId, subject, teacherId, startTimeDayId, endTimeDayId, dayId);
            Btn_Cancel.PerformClick();
            //Btn_Refresh.PerformClick();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Cb_TeacherId control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Cb_TeacherId_SelectedIndexChanged(object sender, EventArgs e)
        {

            Cb_T_Fname.DataSource = Cb_TeacherId.DataSource;
            Cb_T_Lname.DataSource = Cb_TeacherId.DataSource;
            Cb_T_Fname.DisplayMember = "FirstName";
            Cb_T_Fname.ValueMember = "TeacherId";

            Cb_T_Lname.DisplayMember = "LastName";
            Cb_T_Lname.ValueMember = "TeacherId";

            Cb_TeacherId.DisplayMember = "TeacherId";
            Cb_TeacherId.ValueMember = "TeacherId";


        }

        /// <summary>
        /// Handles the Click event of the Btn_Delete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_classes.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                var index = Int32.Parse(dgv_classes.SelectedCells[0].Value.ToString());
                var caption = "Are you sure you want to delete?";
                var message = "Do you want to delete the timetable with the record Id of" + " " + index + " ?";
                var buttons = MessageBoxButtons.YesNo;
                var result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    _timetable.DeleteTimetable(index);
                    Btn_Refresh.PerformClick();
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the Btn_Update control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (dgv_classes.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                Button_Enable();
                //hide the buttons
                btn_InsertNew.Visible = false;
                Btn_SaveNew.Visible = false;
                Btn_Update.Visible = false;
                Btn_Delete.Visible = false;
                Btn_Cancel.Visible = true;
                btn_EnableSearch.Visible = false;
                Btn_Refresh.Visible = false;
                Btn_Save.Visible = true;
                Btn_search_timetable.Visible = false;
                dgv_classes.Enabled = false;
                dgv_classes.Visible = false;
                PopulateButtons();
            }
        }

        /// <summary>
        /// Handles the Click event of the Btn_Save control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //retrive the TimetableId
            var classId = Int32.Parse(Tb_ClassId.Text);

            //UPDTAE THE CLASSROOM NAME based on text and if not null check and retrieve the id
            var classroomNameNew = Txt_class_search.Text;
            if(classroomNameNew != null)
            {
                var classroomNameOld = dgv_classes.SelectedCells[4].Value.ToString();
                _classroom.UpdateClassroom(classroomNameOld, classroomNameNew);
            }
            var classroomId = Int32.Parse(_dm.ToDataTable(_classroom.GetClassroomId
                (classroomNameNew)).Rows[0].Field<string>("ClassroomId"));

            //Retrive the subject text from textbox
            var subject = Txtb_Subject.Text;

            //Retrieve the Teacher Id text from ComboBox
            var teacherId = Int32.Parse(Cb_TeacherId.SelectedValue.ToString());

            //UPDATE START TIME BASED ON COMBOBOX AND ONLY IF IS NEW StartTimeDay
            var startTimeDayNew = Dtp_Start_Time.Value.ToShortTimeString();
            if(startTimeDayNew != dgv_classes.SelectedCells[2].Value.ToString()) 
            {
                var startTimeDayOld = dgv_classes.SelectedCells[2].Value.ToString();
                _std.UpdateStartTimeDayIdByStd(Convert.ToDateTime(startTimeDayOld), Convert.ToDateTime(startTimeDayNew));
            }
            var startTimeDayId = Int32.Parse(_dm.ToDataTable(_std.GetStartTimeDayIdByStd
                (Convert.ToDateTime(startTimeDayNew))).Rows[0].Field<string>("StartTimeDayId"));

            //UPDATE END TIME BASED ON COMBOBOX AND ONLY IF IS NEW EndTimeDay
            var endTimeDayNew = Dtp_End_Time.Value.ToShortTimeString();
            if(endTimeDayNew != dgv_classes.SelectedCells[3].Value.ToString())
            {
                var endTimeDayOld = dgv_classes.SelectedCells[3].Value.ToString();
                _etd.UpdateEndTimeDayIdByEndofTime(Convert.ToDateTime(endTimeDayOld), Convert.ToDateTime(endTimeDayNew));
            }
            var endTimeDayId = Int32.Parse(_dm.ToDataTable(_etd.getEndTimeDayIdByEndTimeDays(Convert.ToDateTime(endTimeDayNew))).Rows[0].Field<string>("EndTimeDayId"));

            //retrive the DayId from Combobox

            //cb_Day.SelectedValue = dgv_classes.SelectedCells[1].Value.ToString();
            var dayId = Int32.Parse(cb_Day.SelectedValue.ToString());
            
            //Execute the Update with above variables
            _timetable.UpdateTimeTable(classId, classroomId, subject, teacherId, startTimeDayId, endTimeDayId, dayId);

            Btn_Cancel.PerformClick();
            Btn_Refresh.PerformClick();
        }

    }
}
