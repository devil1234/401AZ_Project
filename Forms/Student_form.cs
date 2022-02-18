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
    public partial class Student_form : Form
    {
        readonly DataManager DM = new DataManager();
        readonly Student st = new Student();
        readonly FirstNames fn = new FirstNames();
        readonly LastName ln = new LastName();
        readonly DOB dob = new DOB();
        readonly Genders genders = new Genders();
        readonly Emails em = new Emails();
        readonly StudentParentsDetail spd = new StudentParentsDetail();
        readonly Address adr = new Address();

        public Student_form()
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
            Dgv_Students.DataSource = DM.ToDataTable(st.GetStudentsByID(Convert.ToInt32(Txtb_StudentId.Text)));
        }

        private void Student_form_Load(object sender, EventArgs e)
        {
            Dgv_Students.DataSource = DM.ToDataTable(st.GetStudents());
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
            Dgv_Students.DataSource = DM.ToDataTable(st.GetStudents());
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
            Cb_Gender.DataSource = DM.ToDataTable(genders.GetGenders());
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
            var StudentFName = TxtB_StudentFName.Text;
            if (DM.ToDataTable(fn.GetFirstNameIdByFName(StudentFName)).Rows.Count == 0)
            {
                fn.InsertFirstName(StudentFName);
            }
            var StudentFNameId = Int32.Parse(DM.ToDataTable(fn.GetFirstNameIdByFName(StudentFName)).Rows[0].Field<string>("first_name_id"));

            //Retrive the Student LName from txtbox, insert it into db with checks and retrieve the id
            var StudentLName = Txtb_StudentLName.Text;
            if (DM.ToDataTable(ln.GetLastNameIdByLName(StudentLName)).Rows.Count == 0)
            {
                ln.InsertLastName(StudentLName);
            }
            var StudentLNameId = Int32.Parse(DM.ToDataTable(ln.GetLastNameIdByLName(StudentLName)).Rows[0].Field<string>("last_name_id"));

            //Retrive the Student DOB from DateTimePicker, insert it into db with checks and retrieve the id
            var DOB = Dtp_DOB.Value.ToShortDateString();
            if (DM.ToDataTable(dob.GetDoBIdByDoBDate(Convert.ToDateTime(DOB))).Rows.Count == 0)
            {
                dob.InsertDoB(Convert.ToDateTime(DOB));
            }
            var dobId = Int32.Parse(DM.ToDataTable(dob.GetDoBIdByDoBDate
                (Convert.ToDateTime(DOB))).Rows[0].Field<string>("dob_id"));

            //Retrive the Student Gender from ComboBox
            var GenderId = Int32.Parse(Cb_Gender.SelectedValue.ToString());

            //Retrive the Student email from txtbox, insert it into db with checks and retrieve the id
            var StudentEmail = Txtb_email.Text;
            if (DM.ToDataTable(em.GetEmailIdByEmail(StudentEmail)).Rows.Count == 0)
            {
                em.InsertEmail(StudentEmail);
            }
            var StudentEmailId = Int32.Parse(DM.ToDataTable(em.GetEmailIdByEmail
                (StudentEmail)).Rows[0].Field<string>("e_mail_id"));

            //Retrieve parent details from txtboxes,insert with checks and retrieve the id
            var ParentFname = Txtb_ParentFName.Text;
            var ParentLname = TxtB_ParentLName.Text;
            var ParentPN = Txtb_ParentPN.Text;
            if(DM.ToDataTable(spd.GetParentDetailsByFName(ParentFname)).Rows.Count == 0)
            {
                spd.InsertParentsDetails(ParentFname, ParentLname, ParentPN);
            }
            var ParentId = Int32.Parse(DM.ToDataTable(spd.GetParentDetailsByFName
                (ParentFname)).Rows[0].Field<string>("ParentId"));

            //Retrieve address details from txtboxes, insert with checks and retrieve the id
            var AddressStreet = Txtb_AddressStreet.Text;
            var AddressCity = Txtb_AddressCity.Text;
            var AddressRegion = Txtb_AddressRegion.Text;
            var AddressPostCode = Txtb_AddressPostCode.Text;
            if (DM.ToDataTable(adr.GetAddressesByCity(AddressCity)).Rows.Count == 0)
            {
                adr.InsertAddressDetails(AddressStreet, AddressCity, AddressRegion, AddressPostCode);
            }
            var AddressId = Int32.Parse(DM.ToDataTable(adr.GetAddressesByCity
                (AddressCity)).Rows[0].Field<string>("AddressId"));

            //Insert the Student Details
            st.InsertStudent(StudentFNameId, StudentLNameId, dobId, GenderId, StudentEmailId, ParentId, AddressId);
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
                    st.DeleteStudent(index);
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
            var StudentId = Int32.Parse(Dgv_Students.SelectedCells[0].Value.ToString());

            //Update Student FName
            var StudentFName_new = TxtB_StudentFName.Text;
            if(StudentFName_new != null)
            {
                var StudentFname_old = Dgv_Students.SelectedCells[1].Value.ToString();
                fn.UpdateFName(StudentFname_old, StudentFName_new);
            }
            var StudentFNameId = Int32.Parse(DM.ToDataTable(fn.GetFirstNameIdByFName
                (StudentFName_new)).Rows[0].Field<string>("first_name_id"));

            //Update Student LName
            var StudentLName_new = Txtb_StudentLName.Text;
            if (StudentLName_new != null)
            {
                var StudentLname_old = Dgv_Students.SelectedCells[2].Value.ToString();
                ln.UpdateLName(StudentLname_old, StudentLName_new);
            }
            var StudentLNameId = Int32.Parse(DM.ToDataTable(ln.GetLastNameIdByLName
                (StudentLName_new)).Rows[0].Field<string>("last_name_id"));

            //Update DOB
            var dob_new = Dtp_DOB.Value.ToShortDateString();
            if (dob_new != Dgv_Students.SelectedCells[3].Value.ToString())
            {
                var dob_old = Dgv_Students.SelectedCells[3].Value.ToString();
                dob.UpdateDoB(Convert.ToDateTime(dob_old), Convert.ToDateTime(dob_new));
            }
            var dobId = Int32.Parse(DM.ToDataTable(dob.GetDoBIdByDoBDate
                (Convert.ToDateTime(dob_new))).Rows[0].Field<string>("dob_id"));

            //Update Gender
            var GenderId = Int32.Parse(Cb_Gender.SelectedValue.ToString());

            //Update Email
            var Email_new = Txtb_email.Text;
            if (Email_new != null)
            {
                var email_old = Dgv_Students.SelectedCells[5].Value.ToString();
                em.UpdateEmail(email_old, Email_new);
            }
            var StudentEmailId = Int32.Parse(DM.ToDataTable(em.GetEmailIdByEmail
                (Email_new)).Rows[0].Field<string>("e_mail_id"));

            //Parent Details
            //Retrieve the text from txtboxes and passed on update function
            var parentId = Int32.Parse(Dgv_Students.SelectedCells[6].Value.ToString());
            var ParentFname_new = Txtb_ParentFName.Text;
            var ParentLname_new = Txtb_ParentFName.Text;
            var ParentPN_new = Txtb_ParentPN.Text;
            spd.UpdateParentDetails(parentId, ParentFname_new, ParentLname_new, ParentPN_new);

            //Address Details
            //For addressId exist two methods can be retrivied
            var addressId = Int32.Parse(Dgv_Students.SelectedCells[10].Value.ToString());
            var AddressStreet = Txtb_AddressStreet.Text;
            var AddressCity = Txtb_AddressCity.Text;
            var AddressRegion = Txtb_AddressRegion.Text;
            var AddressPostcode = Txtb_AddressPostCode.Text;
            adr.UpdateAddressDetails(addressId, AddressStreet, AddressCity, AddressRegion, AddressPostcode);

            //Update the student details
            st.UpdateStudent(StudentId, StudentFNameId, StudentLNameId, dobId, GenderId, StudentEmailId, parentId, addressId);

            Btn_Cancel.PerformClick();
            
        }
    }
}
