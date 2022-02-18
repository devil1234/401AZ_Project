using _401AZ_PROJECT.Classes_Methods.Addresses;
using _401AZ_PROJECT.Classes_Methods.Students.StudentParentsDetails;
using _401AZ_PROJECT.Classes_Methods.Students.Students;
using _401AZ_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _401AZ_PROJECT
{
    public partial class StudentForm : Form
    {
        readonly DataManager _dm = new DataManager();
        readonly Student _st = new Student();
        readonly FirstNames _fn = new FirstNames();
        readonly LastName _ln = new LastName();
        readonly Dob _dob = new Dob();
        readonly Genders _genders = new Genders();
        readonly Emails _em = new Emails();
        readonly StudentParentsDetail _spd = new StudentParentsDetail();
        readonly Address _adr = new Address();

        public StudentForm()
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

        private void Txtb_StudentId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txtb_StudentId.Text))
            {
                Btn_search_student.Enabled = false;
            }
            else
            {
                Btn_search_student.Enabled = true;
            }
        }

        private void Btn_search_student_Click(object sender, EventArgs e)
        {
            Dgv_Students.DataSource = _dm.ToDataTable(_st.GetStudentsById(Convert.ToInt32(Txtb_StudentId.Text)));
        }

        private void Student_form_Load(object sender, EventArgs e)
        {
            Dgv_Students.DataSource = _dm.ToDataTable(_st.GetStudents());
            Populate_Form();
        }

        private void Btn_EnableSearch_Click(object sender, EventArgs e)
        {
            if (Btn_search_student.Visible == false)
            {
                Txtb_StudentId.Enabled = true;
                Btn_search_student.Visible = true;
            }
            else
            {
                Txtb_StudentId.Enabled = false;
                Btn_search_student.Visible = false;
                Btn_Refresh.PerformClick();
            }
        }

        private void Txtb_StudentId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_search_student.PerformClick();
                Txtb_StudentId.Clear();
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Dgv_Students.DataSource = _dm.ToDataTable(_st.GetStudents());
            Populate_Form();
        }

        private void Dgv_Students_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_Students.SelectedRows.Count > 0)
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
            if(Dgv_Students.SelectedRows.Count > 0)
            {
                //Hide Columns
                Dgv_Students.Columns["ParentId"].Visible = false;
                Dgv_Students.Columns["AddressId"].Visible = false;

                //Student ID Txtbox
                Txtb_StudentId.Text = Dgv_Students.SelectedCells[0].Value.ToString();

                //Student FName
                TxtB_StudentFName.Text = Dgv_Students.SelectedCells[1].Value.ToString();

                //Student LName
                Txtb_StudentLName.Text = Dgv_Students.SelectedCells[2].Value.ToString();

                //Student DOB
                Dtp_DOB.Text = Dgv_Students.SelectedCells[3].Value.ToString();

                //Student Gender
                Cb_Gender.Items.Insert(0, Dgv_Students.SelectedCells[4].Value.ToString());
                Cb_Gender.SelectedIndex = 0;
                Cb_Gender.Text = Dgv_Students.SelectedCells[4].Value.ToString();

                //Student Email
                Txtb_email.Text = Dgv_Students.SelectedCells[5].Value.ToString();

                //ParentId
                Cb_ParentId.Items.Insert(0, Dgv_Students.SelectedCells[6].Value.ToString());
                Cb_ParentId.SelectedIndex = 0;
                Cb_ParentId.Text = Dgv_Students.SelectedCells[6].Value.ToString();

                //Parent Fname
                Txtb_ParentFName.Text = Dgv_Students.SelectedCells[7].Value.ToString();

                //Parent LName
                TxtB_ParentLName.Text = Dgv_Students.SelectedCells[8].Value.ToString();

                //Parent Phone Number
                Txtb_ParentPN.Text = Dgv_Students.SelectedCells[9].Value.ToString();

                //AddressId
                Cb_AddressId.Items.Insert(0, Dgv_Students.SelectedCells[10].Value.ToString());
                Cb_AddressId.SelectedIndex = 0;
                Cb_AddressId.Text = Dgv_Students.SelectedCells[10].Value.ToString();

                //Address Street 
                Txtb_AddressStreet.Text = Dgv_Students.SelectedCells[11].Value.ToString();

                //Address City
                Txtb_AddressCity.Text = Dgv_Students.SelectedCells[12].Value.ToString();

                //Address Region
                Txtb_AddressRegion.Text = Dgv_Students.SelectedCells[13].Value.ToString();

                //Address Postcode
                Txtb_AddressPostCode.Text = Dgv_Students.SelectedCells[14].Value.ToString();
            }
        }

        public void Unpopulate_Form()
        {
            //Student ID Txtbox
            Txtb_StudentId.Text = null;

            //Student FName
            TxtB_StudentFName.Text = null;

            //Student LName
            Txtb_StudentLName.Text = null;

            //Student DOB
            Dtp_DOB.Text = null;

            //Student Gender
            Cb_Gender.DataSource = null;

            //Student Email
            Txtb_email.Text = null;

            //ParentId
            Cb_ParentId.DataSource = null;
            Cb_ParentId.Text = null;

            //Parent Fname
            Txtb_ParentFName.Text = null;

            //Parent LName
            TxtB_ParentLName.Text = null;

            //Parent Phone Number
            Txtb_ParentPN.Text = null;

            //AddressId
            Cb_AddressId.DataSource = null;
            Cb_AddressId.Text = null;

            //Address Street 
            Txtb_AddressStreet.Text = null;

            //Address City
            Txtb_AddressCity.Text = null;

            //Address Region
            Txtb_AddressRegion.Text = null;

            //Address Postcode
            Txtb_AddressPostCode.Text = null;
        }

        private void Dgv_Students_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.Dgv_Students.Columns[e.ColumnIndex].Name == "DOB")
            {
                ShortFormDateFormat(e);
            }
        }

        private void Txtb_StudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_InsertNew_Click(object sender, EventArgs e)
        {
            Button_Enable();
            Unpopulate_Form();
            PopulateButtons();
        }

        private void PopulateButtons()
        {
            //DateTimePicker Date Of Birth
            Dtp_DOB.Text = DateTime.Now.ToString();

            //Gender ComboBox
            Cb_Gender.DataSource = _dm.ToDataTable(_genders.GetGenders());
            Cb_Gender.DisplayMember = "Gender";
            Cb_Gender.ValueMember = "gender_id";
            Cb_Gender.Text = Dgv_Students.SelectedCells[4].Value.ToString();
        }

        private void Button_Enable()
        {
            //Student FName
            TxtB_StudentFName.Enabled = true;
            //Student LName
            Txtb_StudentLName.Enabled = true;
            //Student DOB
            Dtp_DOB.Enabled = true;
            //Student Gender
            Cb_Gender.Enabled = true;
            //Student Email
            Txtb_email.Enabled = true;
            //Parent Fname
            Txtb_ParentFName.Enabled = true;
            //Parent LName
            TxtB_ParentLName.Enabled = true;
            //Parent Phone Number
            Txtb_ParentPN.Enabled = true;
            //Address Street 
            Txtb_AddressStreet.Enabled = true;
            //Address City
            Txtb_AddressCity.Enabled = true;
            //Address Region
            Txtb_AddressRegion.Enabled = true;
            //Address Postcode
            Txtb_AddressPostCode.Enabled = true;
            //Btn Insert New
            Btn_InsertNew.Visible = false;
            //Btn Delete
            Btn_Delete.Visible = false;
            //Btn Update
            Btn_Update.Visible = false;
            //Btn SaveNew
            Btn_SaveNew.Visible = true;
            //Btn Refresh
            Btn_Refresh.Visible = false;
            //Btn EnableSearch
            Btn_EnableSearch.Visible = false;
            //Btn Cancel
            Btn_Cancel.Visible = true;
            //DataGridView
            Dgv_Students.Visible = false;
            //Lbl Student Details
            Lbl_StudentDetails.Visible = false;
        }

        private void Button_Disable()
        {
            Unpopulate_Form();
            //Student FName
            TxtB_StudentFName.Enabled = false;
            //Student LName
            Txtb_StudentLName.Enabled = false;
            //Student DOB
            Dtp_DOB.Enabled = false;
            //Student Gender
            Cb_Gender.Enabled = false;
            //Student Email
            Txtb_email.Enabled = false;
            //Parent Fname
            Txtb_ParentFName.Enabled = false;
            //Parent LName
            TxtB_ParentLName.Enabled = false;
            //Parent Phone Number
            Txtb_ParentPN.Enabled = false;
            //Address Street 
            Txtb_AddressStreet.Enabled = false;
            //Address City
            Txtb_AddressCity.Enabled = false;
            //Address Region
            Txtb_AddressRegion.Enabled = false;
            //Address Postcode
            Txtb_AddressPostCode.Enabled = false;
            //Btn Insert New
            Btn_InsertNew.Visible = true;
            //Btn Delete
            Btn_Delete.Visible = true;
            //Btn Update
            Btn_Update.Visible = true;
            //Btn SaveNew
            Btn_SaveNew.Visible = false;
            //Btn Save
            Btn_Save.Visible = false;
            //Btn Refresh
            Btn_Refresh.Visible = true;
            //Btn EnableSearch
            Btn_EnableSearch.Visible = true;
            //Btn Cancel
            Btn_Cancel.Visible = false;
            //DataGridView
            Dgv_Students.Visible = true;

            //Lbl Student Details
            Lbl_StudentDetails.Visible = true;

            //Populate the textboxes and comboboxes
            Populate_Form();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Button_Disable();
        }

        private void Btn_SaveNew_Click(object sender, EventArgs e)
        {
            //Retrive the Student FName from txtbox, insert it into db with checks and retrieve the id
            var studentFName = TxtB_StudentFName.Text;
            if (_dm.ToDataTable(_fn.GetFirstNameIdByFName(studentFName)).Rows.Count == 0)
            {
                _fn.InsertFirstName(studentFName);
            }
            var studentFNameId = Int32.Parse(_dm.ToDataTable(_fn.GetFirstNameIdByFName(studentFName)).Rows[0].Field<string>("first_name_id"));

            //Retrive the Student LName from txtbox, insert it into db with checks and retrieve the id
            var studentLName = Txtb_StudentLName.Text;
            if (_dm.ToDataTable(_ln.GetLastNameIdByLName(studentLName)).Rows.Count == 0)
            {
                _ln.InsertLastName(studentLName);
            }
            var studentLNameId = Int32.Parse(_dm.ToDataTable(_ln.GetLastNameIdByLName(studentLName)).Rows[0].Field<string>("last_name_id"));

            //Retrive the Student DOB from DateTimePicker, insert it into db with checks and retrieve the id
            var dob = Dtp_DOB.Value.ToShortDateString();
            if (_dm.ToDataTable(_dob.GetDoBIdByDoBDate(Convert.ToDateTime(dob))).Rows.Count == 0)
            {
                _dob.InsertDoB(Convert.ToDateTime(dob));
            }
            var dobId = Int32.Parse(_dm.ToDataTable(_dob.GetDoBIdByDoBDate
                (Convert.ToDateTime(dob))).Rows[0].Field<string>("dob_id"));

            //Retrive the Student Gender from ComboBox
            var genderId = Int32.Parse(Cb_Gender.SelectedValue.ToString());

            //Retrive the Student email from txtbox, insert it into db with checks and retrieve the id
            var studentEmail = Txtb_email.Text;
            if (_dm.ToDataTable(_em.GetEmailIdByEmail(studentEmail)).Rows.Count == 0)
            {
                _em.InsertEmail(studentEmail);
            }
            var studentEmailId = Int32.Parse(_dm.ToDataTable(_em.GetEmailIdByEmail
                (studentEmail)).Rows[0].Field<string>("e_mail_id"));

            //Retrieve parent details from txtboxes,insert with checks and retrieve the id
            var parentFname = Txtb_ParentFName.Text;
            var parentLname = TxtB_ParentLName.Text;
            var parentPn = Txtb_ParentPN.Text;
            if(_dm.ToDataTable(_spd.GetParentDetailsByFName(parentFname)).Rows.Count == 0)
            {
                _spd.InsertParentsDetails(parentFname, parentLname, parentPn);
            }
            var parentId = Int32.Parse(_dm.ToDataTable(_spd.GetParentDetailsByFName
                (parentFname)).Rows[0].Field<string>("ParentId"));

            //Retrieve address details from txtboxes, insert with checks and retrieve the id
            var addressStreet = Txtb_AddressStreet.Text;
            var addressCity = Txtb_AddressCity.Text;
            var addressRegion = Txtb_AddressRegion.Text;
            var addressPostCode = Txtb_AddressPostCode.Text;
            if (_dm.ToDataTable(_adr.GetAddressesByCity(addressCity)).Rows.Count == 0)
            {
                _adr.InsertAddressDetails(addressStreet, addressCity, addressRegion, addressPostCode);
            }
            var addressId = Int32.Parse(_dm.ToDataTable(_adr.GetAddressesByCity
                (addressCity)).Rows[0].Field<string>("AddressId"));

            //Insert the Student Details
            _st.InsertStudent(studentFNameId, studentLNameId, dobId, genderId, studentEmailId, parentId, addressId);
            Btn_Cancel.PerformClick();
        }

        //A method to delete the Student record by StudentId
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Dgv_Students.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                int index = Int32.Parse(Dgv_Students.SelectedCells[0].Value.ToString());
                string caption = "Are you sure you want to delete?";
                string message = "Do you want to delete the Student with the record Id of" + " " + index + " ?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    _st.DeleteStudent(index);
                    Btn_Refresh.PerformClick();
                }
            }
        }

        // Set the form and buttons when update button is clicked
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (Dgv_Students.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                Button_Enable();
                //hide the buttons
                Btn_InsertNew.Visible = false;
                Btn_SaveNew.Visible = false;
                Btn_Update.Visible = false;
                Btn_Delete.Visible = false;
                Btn_Cancel.Visible = true;
                Btn_EnableSearch.Visible = false;
                Btn_Refresh.Visible = false;
                Btn_Save.Visible = true;
                Btn_search_student.Visible = false;
                Dgv_Students.Visible = false;

                //enable boxes
                PopulateButtons();
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //Retrieve the StudentId
            var studentId = Int32.Parse(Dgv_Students.SelectedCells[0].Value.ToString());

            //Update Student FName
            var studentFNameNew = TxtB_StudentFName.Text;
            if(studentFNameNew != null)
            {
                var studentFnameOld = Dgv_Students.SelectedCells[1].Value.ToString();
                _fn.UpdateFName(studentFnameOld, studentFNameNew);
            }
            var studentFNameId = Int32.Parse(_dm.ToDataTable(_fn.GetFirstNameIdByFName
                (studentFNameNew)).Rows[0].Field<string>("first_name_id"));

            //Update Student LName
            var studentLNameNew = Txtb_StudentLName.Text;
            if (studentLNameNew != null)
            {
                var studentLnameOld = Dgv_Students.SelectedCells[2].Value.ToString();
                _ln.UpdateLName(studentLnameOld, studentLNameNew);
            }
            var studentLNameId = Int32.Parse(_dm.ToDataTable(_ln.GetLastNameIdByLName
                (studentLNameNew)).Rows[0].Field<string>("last_name_id"));

            //Update DOB
            var dobNew = Dtp_DOB.Value.ToShortDateString();
            if (dobNew != Dgv_Students.SelectedCells[3].Value.ToString())
            {
                var dobOld = Dgv_Students.SelectedCells[3].Value.ToString();
                _dob.UpdateDoB(Convert.ToDateTime(dobOld), Convert.ToDateTime(dobNew));
            }
            var dobId = Int32.Parse(_dm.ToDataTable(_dob.GetDoBIdByDoBDate
                (Convert.ToDateTime(dobNew))).Rows[0].Field<string>("dob_id"));

            //Update Gender
            var genderId = Int32.Parse(Cb_Gender.SelectedValue.ToString());

            //Update Email
            var emailNew = Txtb_email.Text;
            if (emailNew != null)
            {
                var emailOld = Dgv_Students.SelectedCells[5].Value.ToString();
                _em.UpdateEmail(emailOld, emailNew);
            }
            var studentEmailId = Int32.Parse(_dm.ToDataTable(_em.GetEmailIdByEmail
                (emailNew)).Rows[0].Field<string>("e_mail_id"));

            //Parent Details
            //Retrieve the text from txtboxes and passed on update function
            var parentId = Int32.Parse(Dgv_Students.SelectedCells[6].Value.ToString());
            var parentFnameNew = Txtb_ParentFName.Text;
            var parentLnameNew = Txtb_ParentFName.Text;
            var parentPnNew = Txtb_ParentPN.Text;
            _spd.UpdateParentDetails(parentId, parentFnameNew, parentLnameNew, parentPnNew);

            //Address Details
            //For addressId exist two methods can be retrivied
            var addressId = Int32.Parse(Dgv_Students.SelectedCells[10].Value.ToString());
            var addressStreet = Txtb_AddressStreet.Text;
            var addressCity = Txtb_AddressCity.Text;
            var addressRegion = Txtb_AddressRegion.Text;
            var addressPostcode = Txtb_AddressPostCode.Text;
            _adr.UpdateAddressDetails(addressId, addressStreet, addressCity, addressRegion, addressPostcode);

            //Update the student details
            _st.UpdateStudent(studentId, studentFNameId, studentLNameId, dobId, genderId, studentEmailId, parentId, addressId);

            Btn_Cancel.PerformClick();
            
        }
    }
}
