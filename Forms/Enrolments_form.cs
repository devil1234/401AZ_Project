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
using _401AZ_PROJECT.Classes_Methods.Enrolments;
using _401AZ_PROJECT.Classes_Methods.Students.Students;
using _401AZ_PROJECT.Classes_Methods.TimeTable;

namespace _401AZ_PROJECT
{
    public partial class Enrolments_form : Form
    {

        readonly DataManager DM = new DataManager();
        readonly Enrolment enrol = new Enrolment();
        readonly Student student = new Student();
        readonly TimeTable tm = new TimeTable();
        readonly DateStart ds = new DateStart();
        readonly DateEnd de = new DateEnd();

        public Enrolments_form()
        {
            InitializeComponent();
        }

        // A method to convert to suitable DateTime for columns where is required
        private static void ShortFormDateFormat(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    StringBuilder dateString = new StringBuilder();
                    DateTime theDate = DateTime.Parse(formatting.Value.ToString());

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

        private void Enrolments_form_Load(object sender, EventArgs e)
        {
            Dgv_Enrolments.DataSource = DM.ToDataTable(enrol.GetEnrolments());
            PopulateForm();
        }

        private void Dgv_Enrolments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.Dgv_Enrolments.Columns[e.ColumnIndex].Name == "StartDate")
            {
                ShortFormDateFormat(e);
            }

            if (this.Dgv_Enrolments.Columns[e.ColumnIndex].Name == "EndDate")
            {
                ShortFormDateFormat(e);
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Dgv_Enrolments.DataSource = DM.ToDataTable(enrol.GetEnrolments());
            PopulateForm();
        }

        private void PopulateForm()
        {
            if (Dgv_Enrolments.SelectedRows.Count > 0)
            {
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
        }

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
        }

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

            PopulateForm();
        }

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

        private void Btn_search_student_by_id_Click(object sender, EventArgs e)
        {
            Dgv_Enrolments.DataSource = DM.ToDataTable(enrol.GetEnrolmentsByStudentId(Convert.ToInt32(Txtb_StudentId_Search.Text)));
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Dgv_Enrolments.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                int index = Int32.Parse(Dgv_Enrolments.SelectedCells[0].Value.ToString());
                string caption = "Are you sure you want to delete?";
                string message = "Do you want to delete the file with the record Id of" + " " + index + " ?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    enrol.DeleteEnrolment(index);
                    Btn_Refresh.PerformClick();
                }
            }
        }


        private void btn_InsertNew_Click(object sender, EventArgs e)
        {
            //UnpopulateForm();
            Button_Enable();
            PopulateButtons();
        }

        private void PopulateButtons()
        {
            //Student Id
            Cb_StudentId.DataSource = DM.ToDataTable(student.GetStudent_FName_LName());
            Cb_StudentId.DisplayMember = "StudentId";
            Cb_StudentId.ValueMember = "StudentId";
            //Cb_StudentId.SelectedValue = Dgv_Enrolments.SelectedCells[0].Value.ToString();

            //Date Start
            Dtp_DateStart.Text = DateTime.Now.ToString();

            //Date End
            Dtp_DateEnd.Text = DateTime.Now.ToString();

            //Class Id
            Cb_ClassId.DataSource = DM.ToDataTable(tm.GetClasses());
            Cb_ClassId.DisplayMember = "Class_Id";
            Cb_ClassId.ValueMember = "Class_Id";
            //Cb_ClassId.SelectedIndex = 0;

        }

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

        private void Txtb_StudentId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_search_student_by_id.PerformClick();
                Txtb_StudentId_Search.Clear();
            }
        }

        private void Txtb_StudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Button_Disable();
        }

        private void Btn_SaveNew_Click(object sender, EventArgs e)
        {
            //Retrive the StudentId from Combobox 
            var studentId = Int32.Parse(Cb_StudentId.SelectedValue.ToString());

            //Retrieve the ClassId from Combobox
            var ClassId = Int32.Parse(Cb_ClassId.SelectedValue.ToString());


            //check if the Date Start is existing in db, if not insert it and retrieve the id
            var DateStart = Dtp_DateStart.Value.ToShortDateString();
            if(DM.ToDataTable(ds.GetStartDateByDate(Convert.ToDateTime(DateStart))).Rows.Count == 0)
            {
                ds.InsertDateStart(Convert.ToDateTime(DateStart));
            }
            var DateStartId = Int32.Parse(DM.ToDataTable(ds.GetStartDateByDate
                (Convert.ToDateTime(DateStart))).Rows[0].Field<string>("date_start_id"));

            //check if the Date End is existing in db, if not insert it and retrieve the id
            var DateEnd = Dtp_DateEnd.Value.ToShortDateString();
            if (DM.ToDataTable(de.GetEndDateByDate(Convert.ToDateTime(DateEnd))).Rows.Count == 0)
            {
                de.InsertDateEnd(Convert.ToDateTime(DateEnd));
            }
            var DateEndId = Int32.Parse(DM.ToDataTable(de.GetEndDateByDate
                (Convert.ToDateTime(DateEnd))).Rows[0].Field<string>("date_end_id"));

            enrol.InsertEnrolment(studentId,ClassId,DateStartId,DateEndId);
            Btn_Cancel.PerformClick();
            Btn_Refresh.PerformClick();

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (Dgv_Enrolments.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                //hide the buttons
                btn_InsertNew.Visible = false;
                Btn_SaveNew.Visible = false;
                Btn_Update.Visible = false;
                Btn_Delete.Visible = false;
                Btn_Cancel.Visible = true;
                btn_EnableSearchById.Visible = false;
                Btn_Refresh.Visible = false;
                Btn_Save.Visible = true;
                Btn_search_student_by_id.Visible = false;
                Dgv_Enrolments.Enabled = false;
                Dgv_Enrolments.Visible = false;

                //enable boxes
                Cb_ClassId.Enabled = true;
                Cb_StudentId.Enabled = true;
                Dtp_DateStart.Enabled = true;
                Dtp_DateEnd.Enabled = true;

                Lbl_Classroom.Visible = false;
                Cb_Classroom.Visible = false;

                Lbl_TeacherId.Visible = false;
                Cb_TeacherId.Visible = false;

                Lbl_Student_FName.Visible = false;
                Cb_Student_FName.Visible = false;

                Lbl_Student_LName.Visible = false;
                Cb_Student_LName.Visible = false;

                Lbl_Subject.Visible = false;
                Cb_Subject.Visible = false;

                Btn_Update.Enabled = false;
                Btn_Update.Visible = false;

                Btn_Save.Enabled = true;
                Btn_Save.Visible = true;

                Btn_Refresh.Enabled = false;
                Btn_Refresh.Visible = false;

                btn_EnableSearchById.Enabled = false;
                btn_EnableSearchById.Visible = false;

                Btn_Cancel.Visible = true;

                PopulateButtons();
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //Retrive the StudentId from Combobox 
            var studentId = Int32.Parse(Cb_StudentId.SelectedValue.ToString());

            //Retrieve the ClassId from Combobox
            var ClassId = Int32.Parse(Cb_ClassId.SelectedValue.ToString());

            //Update Start Date Based on date time picker and only if is new Start Date
            var StartDate_new = Dtp_DateStart.Value.ToShortDateString();
            if(StartDate_new != Dgv_Enrolments.SelectedCells[6].Value.ToString())
            {
                var StartDate_old = Dgv_Enrolments.SelectedCells[6].Value.ToString();
                ds.UpdateDateStartByDate(Convert.ToDateTime(StartDate_old), Convert.ToDateTime(StartDate_new));
            }
            var StartDateId = Int32.Parse(DM.ToDataTable(ds.GetStartDateByDate
                (Convert.ToDateTime(StartDate_new))).Rows[0].Field<string>("date_start_id"));


            //Update End Date Based on date time picker and only if is new Start Date
            var EndDate_new = Dtp_DateEnd.Value.ToShortDateString();
            if(EndDate_new != Dgv_Enrolments.SelectedCells[7].Value.ToString())
            {
                var EndDate_old = Dgv_Enrolments.SelectedCells[7].Value.ToString();
                de.UpdateDateEndByDate(Convert.ToDateTime(EndDate_old), Convert.ToDateTime(EndDate_new));
            }
            var EndDateId = Int32.Parse(DM.ToDataTable(de.GetEndDateByDate
                 (Convert.ToDateTime(EndDate_new))).Rows[0].Field<string>("date_end_id"));

            //Execute the update with above variables 
            enrol.UpdateEnrolment(studentId, ClassId, StartDateId, EndDateId);

            //Perform click on Cancel Button after update
            Btn_Cancel.PerformClick();
            Btn_Refresh.PerformClick();
        }

        private void Cb_StudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cb_Student_FName.DataSource = Cb_StudentId.DataSource;
            Cb_Student_LName.DataSource = Cb_StudentId.DataSource;
            Cb_Student_FName.DisplayMember = "Student_FName";
            Cb_Student_FName.ValueMember = "StudentId";

            Cb_Student_LName.DisplayMember = "Student_LName";
            Cb_Student_LName.ValueMember = "StudentId";

            Cb_StudentId.DisplayMember = "StudentId";
            Cb_StudentId.ValueMember = "StudentId";

        }
    }
}
