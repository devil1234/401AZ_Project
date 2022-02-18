using _401AZ_PROJECT.Classes_Methods.Addresses;
using _401AZ_PROJECT.Classes_Methods.Teachers.Teacher;
using _401AZ_PROJECT.Models;
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
    public partial class Teachers_form : Form
    {
        readonly DataManager DM = new DataManager();
        readonly FirstNames fn = new FirstNames();
        readonly LastName ln = new LastName();
        readonly DOB dob = new DOB();
        readonly Genders genders = new Genders();
        readonly Emails em = new Emails();
        readonly Address adr = new Address();
        readonly Teachers tc = new Teachers();

        public Teachers_form()
        {
            InitializeComponent();
        }

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

        private void Txtb_TeacherId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txtb_TeacherId.Text))
            {
                Btn_search_teacher.Enabled = false;
            }
            else
            {
                Btn_search_teacher.Enabled = true;
            }
        }

        private void Btn_search_teacher_Click(object sender, EventArgs e)
        {
            Dgv_Teachers.DataSource = DM.ToDataTable(tc.GetTeacherByID(Convert.ToInt32(Txtb_TeacherId.Text)));
        }

        private void Teachers_form_Load(object sender, EventArgs e)
        {
            Dgv_Teachers.DataSource = DM.ToDataTable(tc.GetTeachers());
            Populate_Form();
        }

        private void Btn_EnableSearch_Click(object sender, EventArgs e)
        {
            if (Btn_search_teacher.Visible == false)
            {
                Txtb_TeacherId.Enabled = true;
                Btn_search_teacher.Visible = true;
            }
            else
            {
                Txtb_TeacherId.Enabled = false;
                Txtb_TeacherId.Visible = false;
                Btn_Refresh.PerformClick();
            }
        }

        private void Txtb_TeacherId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_search_teacher.PerformClick();
                Txtb_TeacherId.Clear();
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Dgv_Teachers.DataSource = DM.ToDataTable(tc.GetTeachers());
            Populate_Form();
        }

        private void Dgv_Teachers_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_Teachers.SelectedRows.Count > 0)
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
            //COLUMNS TO HIDE BECAUSE THEY ARE EMTY AND THEY SHOW BECAUSE OF INHERITENCE
            //ParentId , ParentFN, ParenLN, ParentPhoneNumber
            Dgv_Teachers.Columns["ParentId"].Visible = false;
            Dgv_Teachers.Columns["ParentFName"].Visible = false;
            Dgv_Teachers.Columns["ParentLName"].Visible = false;
            Dgv_Teachers.Columns["ParentPhoneNumber"].Visible = false;
            Dgv_Teachers.Columns["AddressId"].Visible = false;

            //Teacher ID Txtbox
            Txtb_TeacherId.Text = Dgv_Teachers.SelectedCells[0].Value.ToString();

            //Teacher FName
            TxtB_TeacherFName.Text = Dgv_Teachers.SelectedCells[1].Value.ToString();

            //Teacher LName
            Txtb_TeacherLName.Text = Dgv_Teachers.SelectedCells[2].Value.ToString();

            //Teacher DOB
            Dtp_DOB.Text = Dgv_Teachers.SelectedCells[3].Value.ToString();

            //Teacher Gender
            Cb_Gender.Items.Insert(0, Dgv_Teachers.SelectedCells[4].Value.ToString());
            Cb_Gender.SelectedIndex = 0;
            Cb_Gender.Text = Dgv_Teachers.SelectedCells[4].Value.ToString();

            //Teacher Email
            Txtb_email.Text = Dgv_Teachers.SelectedCells[5].Value.ToString();

            //AddressId
            Cb_AddressId.Items.Insert(0, Dgv_Teachers.SelectedCells[10].Value.ToString());
            Cb_AddressId.SelectedIndex = 0;
            Cb_AddressId.Text = Dgv_Teachers.SelectedCells[10].Value.ToString();

            //Address Street 
            Txtb_AddressStreet.Text = Dgv_Teachers.SelectedCells[11].Value.ToString();

            //Address City
            Txtb_AddressCity.Text = Dgv_Teachers.SelectedCells[12].Value.ToString();

            //Address Region
            Txtb_AddressRegion.Text = Dgv_Teachers.SelectedCells[13].Value.ToString();

            //Address Postcode
            Txtb_AddressPostCode.Text = Dgv_Teachers.SelectedCells[14].Value.ToString();
        }

        public void Unpopulate_Form()
        {
            //Teacher ID Txtbox
            Txtb_TeacherId.Text = null;

            //Teacher FName
            TxtB_TeacherFName.Text = null;

            //Teacher LName
            Txtb_TeacherLName.Text = null;

            //Teacher DOB
            Dtp_DOB.Text = null;

            //Teacher Gender
            Cb_Gender.DataSource = null;

            //Teacher Email
            Txtb_email.Text = null;

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

        private void Dgv_Teachers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.Dgv_Teachers.Columns[e.ColumnIndex].Name == "DOB")
            {
                ShortFormDateFormat(e);
            }
        }

        private void Txtb_TeacherId_KeyPress(object sender, KeyPressEventArgs e)
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
            Cb_Gender.Text = Dgv_Teachers.SelectedCells[4].Value.ToString();
        }

        private void Button_Enable()
        {
            //Teacher FName
            TxtB_TeacherFName.Enabled = true;
            //Teacher LName
            Txtb_TeacherLName.Enabled = true;
            //Teacher DOB
            Dtp_DOB.Enabled = true;
            //Teacher Gender
            Cb_Gender.Enabled = true;
            //Teacher Email
            Txtb_email.Enabled = true;
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
            Dgv_Teachers.Visible = false;
            //Lbl Teacher Details
            Lbl_TeacherDetails.Visible = false;
        }

        private void Button_Disable()
        {
            Unpopulate_Form();
            //Teacher FName
            TxtB_TeacherFName.Enabled = false;
            //Teacher LName
            Txtb_TeacherLName.Enabled = false;
            //Teacher DOB
            Dtp_DOB.Enabled = false;
            //Teacher Gender
            Cb_Gender.Enabled = false;
            //Teacher Email
            Txtb_email.Enabled = false;
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
            Dgv_Teachers.Visible = true;

            //Lbl Teacher Details
            Lbl_TeacherDetails.Visible = true;

            //Populate the textboxes and comboboxes
            Populate_Form();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Button_Disable();
        }

        private void Btn_SaveNew_Click(object sender, EventArgs e)
        {
            var TeacherFName = TxtB_TeacherFName.Text;
            if (DM.ToDataTable(fn.GetFirstNameIdByFName(TeacherFName)).Rows.Count == 0)
            {
                fn.InsertFirstName(TeacherFName);
            }
            var TeacherFNameId = Int32.Parse(DM.ToDataTable(fn.GetFirstNameIdByFName(TeacherFName)).Rows[0].Field<string>("first_name_id"));

            var TeacherLName = Txtb_TeacherLName.Text;
            if (DM.ToDataTable(ln.GetLastNameIdByLName(TeacherLName)).Rows.Count == 0)
            {
                ln.InsertLastName(TeacherLName);
            }
            var TeacherLNameId = Int32.Parse(DM.ToDataTable(ln.GetLastNameIdByLName(TeacherLName)).Rows[0].Field<string>("last_name_id"));

            //Retrive the Teacher DOB from DateTimePicker, insert it into db with checks and retrieve the id
            var DOB = Dtp_DOB.Value.ToShortDateString();
            if (DM.ToDataTable(dob.GetDoBIdByDoBDate(Convert.ToDateTime(DOB))).Rows.Count == 0)
            {
                dob.InsertDoB(Convert.ToDateTime(DOB));
            }
            var dobId = Int32.Parse(DM.ToDataTable(dob.GetDoBIdByDoBDate
                (Convert.ToDateTime(DOB))).Rows[0].Field<string>("dob_id"));

            //Retrive the Teacher Gender from ComboBox
            var GenderId = Int32.Parse(Cb_Gender.SelectedValue.ToString());

            //Retrive the Teacher email from txtbox, insert it into db with checks and retrieve the id
            var TeacherEmail = Txtb_email.Text;
            if (DM.ToDataTable(em.GetEmailIdByEmail(TeacherEmail)).Rows.Count == 0)
            {
                em.InsertEmail(TeacherEmail);
            }
            var TeacherEmailId = Int32.Parse(DM.ToDataTable(em.GetEmailIdByEmail
                (TeacherEmail)).Rows[0].Field<string>("e_mail_id"));

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

            //Insert the Teacher Details
            tc.InsertTeacher(TeacherFNameId, TeacherLNameId, dobId, GenderId, TeacherEmailId, AddressId);
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Dgv_Teachers.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                int index = Int32.Parse(Dgv_Teachers.SelectedCells[0].Value.ToString());
                string caption = "Are you sure you want to delete?";
                string message = "Do you want to delete the Teacher with the record Id of" + " " + index + " ?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    tc.DeleteTeacher(index);
                    Btn_Refresh.PerformClick();
                }
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (Dgv_Teachers.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
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
                Btn_search_teacher.Visible = false;
                Dgv_Teachers.Visible = false;

                //enable boxes
                PopulateButtons();
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            var TeacherId = Int32.Parse(Dgv_Teachers.SelectedCells[0].Value.ToString());

            //Update Teacher FName
            var TeacherFName_new = TxtB_TeacherFName.Text;
            if (TeacherFName_new != null)
            {
                var TeacherFname_old = Dgv_Teachers.SelectedCells[1].Value.ToString();
                fn.UpdateFName(TeacherFname_old, TeacherFName_new);
            }
            var TeacherFNameId = Int32.Parse(DM.ToDataTable(fn.GetFirstNameIdByFName
                (TeacherFName_new)).Rows[0].Field<string>("first_name_id"));

            //Update Teacher LName
            var TeacherLName_new = Txtb_TeacherLName.Text;
            if (TeacherLName_new != null)
            {
                var TeacherLname_old = Dgv_Teachers.SelectedCells[2].Value.ToString();
                ln.UpdateLName(TeacherLname_old, TeacherLName_new);
            }
            var TeacherLNameId = Int32.Parse(DM.ToDataTable(ln.GetLastNameIdByLName
                (TeacherLName_new)).Rows[0].Field<string>("last_name_id"));

            //Update DOB
            var dob_new = Dtp_DOB.Value.ToShortDateString();
            if (dob_new != Dgv_Teachers.SelectedCells[3].Value.ToString())
            {
                var dob_old = Dgv_Teachers.SelectedCells[3].Value.ToString();
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
                var email_old = Dgv_Teachers.SelectedCells[5].Value.ToString();
                em.UpdateEmail(email_old, Email_new);
            }
            var TeacherEmailId = Int32.Parse(DM.ToDataTable(em.GetEmailIdByEmail
                (Email_new)).Rows[0].Field<string>("e_mail_id"));

            //Address Details
            //For addressId exist two methods can be retrivied
            var addressId = Int32.Parse(Dgv_Teachers.SelectedCells[10].Value.ToString());
            var AddressStreet = Txtb_AddressStreet.Text;
            var AddressCity = Txtb_AddressCity.Text;
            var AddressRegion = Txtb_AddressRegion.Text;
            var AddressPostcode = Txtb_AddressPostCode.Text;
            adr.UpdateAddressDetails(addressId, AddressStreet, AddressCity, AddressRegion, AddressPostcode);

            //Update the Teacher details
            tc.UpdateTeacher(TeacherId, TeacherFNameId, TeacherLNameId, dobId, GenderId, TeacherEmailId, addressId);

            Btn_Cancel.PerformClick();
            Btn_Refresh.PerformClick();
        }
    }
}
