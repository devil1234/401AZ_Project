using _401AZ_PROJECT.Classes_Methods.Teachers.Teacher;
using _401AZ_PROJECT.Classes_Methods.TimeTables;
using _401AZ_PROJECT.Models;
using MySqlConnector;
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
    public partial class Timetable_form : Form
    {

        readonly DataManager DM = new DataManager();
        readonly TimeTable timetable = new TimeTable();
        readonly Days day = new Days();
        readonly Teachers teacher = new Teachers();
        readonly Classrooms classroom = new Classrooms();
        readonly StartTimeDay std = new StartTimeDay();
        readonly EndTimeDay etd = new EndTimeDay();

        public Timetable_form()
        {
            InitializeComponent();
        }

        //Disable or enable Search button based on input
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

        //Search the database by textbox entry
        private void Btn_search_timetable_Click(object sender, EventArgs e)
        {
            dgv_classes.DataSource = DM.ToDataTable(timetable.GetClasses_By_Classroom(Txt_class_search.Text));

        }

        //Load the database data on load
        private void Timetable_Load(object sender, EventArgs e)
        {
            dgv_classes.DataSource = DM.ToDataTable(timetable.GetClasses());
            Populate_Form();
        }

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

        private void Txt_class_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_search_timetable.PerformClick();
                Txt_class_search.Clear();
            }    
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            dgv_classes.DataSource = DM.ToDataTable(timetable.GetClasses());
            Populate_Form();
        }


        //Set the values of boxes based on the selected row
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

        private void Populate_Form()
        {
            if (dgv_classes.SelectedRows.Count > 0)
            {
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

        private void btn_InsertNew_Click(object sender, EventArgs e)
        {
            Button_Enable();
            PopulateButtons();
        }

        private void PopulateButtons()
        {
            //cb_Day_id
            cb_Day.DataSource = DM.ToDataTable(day.GetDays());
            cb_Day.DisplayMember = "Day_Name";
            cb_Day.ValueMember = "Day_Id_pk";
            cb_Day.Text = dgv_classes.SelectedCells[1].Value.ToString();

            //Start Time Day
            Dtp_Start_Time.Text = dgv_classes.SelectedCells[2].Value.ToString();

            //End Time Day
            Dtp_End_Time.Text = dgv_classes.SelectedCells[3].Value.ToString();

            //cb_TeacherId
            Cb_TeacherId.DataSource = DM.ToDataTable(teacher.GetTeacher_FName_LName());
            Cb_TeacherId.DisplayMember = "Teacher_Id";
            if (dgv_classes.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                Cb_TeacherId.SelectedValue = Int32.Parse(dgv_classes.SelectedCells[8].Value.ToString());
            }

            //Classroom name
            Txt_class_search.Text = dgv_classes.SelectedCells[4].Value.ToString();

            //Subject
            Txtb_Subject.Text = dgv_classes.SelectedCells[5].Value.ToString();

        }

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

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Button_Disable();
        }

        private void Btn_SaveNew_Click(object sender, EventArgs e)
        {

            // Check if the ClassroomName is existing in db, if not insert it and return the id
            var classroom_name = Txt_class_search.Text;
            if (DM.ToDataTable(classroom.GetClassroomId(classroom_name)).Rows.Count == 0)
            {
                classroom.InsertClassroom(classroom_name);
            }
            var ClassroomId = Int32.Parse(DM.ToDataTable(classroom.GetClassroomId(classroom_name)).Rows[0].Field<string>("classroom_id"));


            //Retrive the subject text from textbox
            var Subject = Txtb_Subject.Text;
            
            //Retrieve the Teacher Id text from ComboBox
            var teacherId = Int32.Parse(Cb_TeacherId.SelectedValue.ToString());
            
            // Check if the StartTimeDay is existing in db, if not insert it and retrieve the id
            var StartTimeDay = Dtp_Start_Time.Value.ToShortTimeString();
            if (DM.ToDataTable(std.GetStartTimeDayIdByStd(Convert.ToDateTime(StartTimeDay))).Rows.Count == 0)
            {
                std.InsertStartTimeDay(Convert.ToDateTime(StartTimeDay));
            }
            var StartTimeDayId = Int32.Parse(DM.ToDataTable(std.GetStartTimeDayIdByStd(Convert.ToDateTime(StartTimeDay))).Rows[0].Field<string>("start_time_day_id"));

            // Check if the EndTimeDay is existing in db, if not insert it and return the id
            var EndTimeDay = Dtp_End_Time.Value.ToShortTimeString();
            if (DM.ToDataTable(etd.GetEndTimeDayIdByStd(Convert.ToDateTime(EndTimeDay))).Rows.Count == 0)
            {
                etd.InsertEndTimeDay(Convert.ToDateTime(EndTimeDay));
            }
            var EndTimeDayId = Int32.Parse(DM.ToDataTable(etd.GetEndTimeDayIdByStd(Convert.ToDateTime(EndTimeDay))).Rows[0].Field<string>("end_time_day_id"));

            var DayId = Int32.Parse(cb_Day.SelectedValue.ToString());


            timetable.InsertClasses(ClassroomId, Subject, teacherId, StartTimeDayId, EndTimeDayId, DayId);
            Btn_Cancel.PerformClick();
            //Btn_Refresh.PerformClick();
        }

        private void Cb_TeacherId_SelectedIndexChanged(object sender, EventArgs e)
        {

            Cb_T_Fname.DataSource = Cb_TeacherId.DataSource;
            Cb_T_Lname.DataSource = Cb_TeacherId.DataSource;
            Cb_T_Fname.DisplayMember = "First_Name";
            Cb_T_Fname.ValueMember = "Teacher_Id";

            Cb_T_Lname.DisplayMember = "Last_Name";
            Cb_T_Lname.ValueMember = "Teacher_Id";

            Cb_TeacherId.DisplayMember = "Teacher_Id";
            Cb_TeacherId.ValueMember = "Teacher_Id";


        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_classes.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                int index = Int32.Parse(dgv_classes.SelectedCells[0].Value.ToString());
                string caption = "Are you sure you want to delete?";
                string message = "Do you want to delete the timetable with the record Id of" + " " + index + " ?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    timetable.DeleteTimetable(index);
                    Btn_Refresh.PerformClick();
                }
            }
        }

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

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //retrive the TimetableId
            var classId = Int32.Parse(Tb_ClassId.Text);

            //UPDTAE THE CLASSROOM NAME based on text and if not null check and retrieve the id
            var classroom_name_new = Txt_class_search.Text;
            if(classroom_name_new != null)
            {
                var classroom_name_old = dgv_classes.SelectedCells[4].Value.ToString();
                classroom.UpdateClassroom(classroom_name_old, classroom_name_new);
            }
            var ClassroomId = Int32.Parse(DM.ToDataTable(classroom.GetClassroomId
                (classroom_name_new)).Rows[0].Field<string>("classroom_id"));

            //Retrive the subject text from textbox
            var Subject = Txtb_Subject.Text;

            //Retrieve the Teacher Id text from ComboBox
            var teacherId = Int32.Parse(Cb_TeacherId.SelectedValue.ToString());

            //UPDATE START TIME BASED ON COMBOBOX AND ONLY IF IS NEW StartTimeDay
            var StartTimeDay_new = Dtp_Start_Time.Value.ToShortTimeString();
            if(StartTimeDay_new != dgv_classes.SelectedCells[2].Value.ToString()) 
            {
                var StartTimeDay_old = dgv_classes.SelectedCells[2].Value.ToString();
                std.UpdateStartTimeDayIdByStd(Convert.ToDateTime(StartTimeDay_old), Convert.ToDateTime(StartTimeDay_new));
            }
            var StartTimeDayId = Int32.Parse(DM.ToDataTable(std.GetStartTimeDayIdByStd
                (Convert.ToDateTime(StartTimeDay_new))).Rows[0].Field<string>("start_time_day_id"));

            //UPDATE END TIME BASED ON COMBOBOX AND ONLY IF IS NEW EndTimeDay
            var EndTimeDay_new = Dtp_End_Time.Value.ToShortTimeString();
            if(EndTimeDay_new != dgv_classes.SelectedCells[3].Value.ToString())
            {
                var EndTimeDay_old = dgv_classes.SelectedCells[3].Value.ToString();
                etd.UpdateEndTimeDayIdByEtd(Convert.ToDateTime(EndTimeDay_old), Convert.ToDateTime(EndTimeDay_new));
            }
            var EndTimeDayId = Int32.Parse(DM.ToDataTable(etd.GetEndTimeDayIdByStd(Convert.ToDateTime(EndTimeDay_new))).Rows[0].Field<string>("end_time_day_id"));

            //retrive the DayId from Combobox

            //cb_Day.SelectedValue = dgv_classes.SelectedCells[1].Value.ToString();
            var DayId = Int32.Parse(cb_Day.SelectedValue.ToString());

            MessageBox.Show(Convert.ToString(DayId));
            //Execute the Update with above variables
            timetable.UpdateTimeTable(classId, ClassroomId, Subject, teacherId, StartTimeDayId, EndTimeDayId, DayId);

            Btn_Cancel.PerformClick();
            Btn_Refresh.PerformClick();
        }

    }
}
