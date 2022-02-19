using _401AZ_PROJECT.Models;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _401AZ_PROJECT
{
    /// <summary>
    /// Class TeachersForm.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class TeachersForm : Form
    {
        /// <summary>
        /// The initializes the classes required for this form to work
        /// </summary>
        private readonly DataManager _dm = new DataManager();
        private readonly FirstNames _fn = new FirstNames();
        private readonly LastName _ln = new LastName();
        private readonly Dob _dob = new Dob();
        private readonly Genders _genders = new Genders();
        private readonly Emails _em = new Emails();
        private readonly Address _adr = new Address();
        private readonly Teachers _tc = new Teachers();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeachersForm" /> class.
        /// </summary>
        public TeachersForm()
        {
            InitializeComponent();
        }

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
        /// Handles the TextChanged event of the Txtb_TeacherId control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the Btn_search_teacher control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_search_teacher_Click(object sender, EventArgs e)
        {
            Dgv_Teachers.DataSource = _dm.ToDataTable(_tc.GetTeacherById(Convert.ToInt32(Txtb_TeacherId.Text)));
        }

        /// <summary>
        /// Handles the Load event of the Teachers_form control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Teachers_form_Load(object sender, EventArgs e)
        {
            Dgv_Teachers.DataSource = _dm.ToDataTable(_tc.GetTeachers());
            Populate_Form();
        }

        /// <summary>
        /// Handles the Click event of the Btn_EnableSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the KeyDown event of the Txtb_TeacherId control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs" /> instance containing the event data.</param>
        private void Txtb_TeacherId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_search_teacher.PerformClick();
                Txtb_TeacherId.Clear();
            }
        }

        /// <summary>
        /// Handles the Click event of the Btn_Refresh control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Dgv_Teachers.DataSource = _dm.ToDataTable(_tc.GetTeachers());
            Populate_Form();
        }

        /// <summary>
        /// Handles the SelectionChanged event of the Dgv_Teachers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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

        /// <summary>
        /// Populates the form.
        /// </summary>
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

        /// <summary>
        /// Unpopulates the form.
        /// </summary>
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

        /// <summary>
        /// Handles the CellFormatting event of the Dgv_Teachers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellFormattingEventArgs" /> instance containing the event data.</param>
        private void Dgv_Teachers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Dgv_Teachers.Columns[e.ColumnIndex].Name == "DOB")
            {
                ShortFormDateFormat(e);
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the Txtb_TeacherId control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs" /> instance containing the event data.</param>
        private void Txtb_TeacherId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the Btn_InsertNew control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_InsertNew_Click(object sender, EventArgs e)
        {
            Button_Enable();
            Unpopulate_Form();
            PopulateButtons();
        }

        /// <summary>
        /// Populates the buttons.
        /// </summary>
        private void PopulateButtons()
        {
            //DateTimePicker Date Of Birth
            Dtp_DOB.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);

            //Gender ComboBox
            Cb_Gender.DataSource = _dm.ToDataTable(_genders.GetGenders());
            Cb_Gender.DisplayMember = "Gender";
            Cb_Gender.ValueMember = "GenderId";
            Cb_Gender.Text = Dgv_Teachers.SelectedCells[4].Value.ToString();
        }

        /// <summary>
        /// Buttons the enable.
        /// </summary>
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

        /// <summary>
        /// Buttons the disable.
        /// </summary>
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

        /// <summary>
        /// Handles the Click event of the Btn_Cancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Button_Disable();
        }

        /// <summary>
        /// Handles the Click event of the Btn_SaveNew control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_SaveNew_Click(object sender, EventArgs e)
        {
            var teacherFName = TxtB_TeacherFName.Text;
            if (_dm.ToDataTable(_fn.GetFirstNameIdByFirstName(teacherFName)).Rows.Count == 0)
            {
                _fn.InsertFirstName(teacherFName);
            }
            var teacherFNameId = Int32.Parse(_dm.ToDataTable(_fn.GetFirstNameIdByFirstName(teacherFName)).Rows[0].Field<string>("FirstNameId"));

            var teacherLName = Txtb_TeacherLName.Text;
            if (_dm.ToDataTable(_ln.GetLastNameIdByLName(teacherLName)).Rows.Count == 0)
            {
                _ln.InsertLastName(teacherLName);
            }
            var teacherLNameId = Int32.Parse(_dm.ToDataTable(_ln.GetLastNameIdByLName(teacherLName)).Rows[0].Field<string>("LastNameId"));

            //Retrive the Teacher DOB from DateTimePicker, insert it into db with checks and retrieve the id
            var dob = Dtp_DOB.Value.ToShortDateString();
            if (_dm.ToDataTable(_dob.GetDoBIdByDoBDate(Convert.ToDateTime(dob))).Rows.Count == 0)
            {
                _dob.InsertDoB(Convert.ToDateTime(dob));
            }
            var dobId = Int32.Parse(_dm.ToDataTable(_dob.GetDoBIdByDoBDate
                (Convert.ToDateTime(dob))).Rows[0].Field<string>("DobId"));

            //Retrive the Teacher Gender from ComboBox
            var genderId = Int32.Parse(Cb_Gender.SelectedValue.ToString());

            //Retrive the Teacher email from txtbox, insert it into db with checks and retrieve the id
            var teacherEmail = Txtb_email.Text;
            if (_dm.ToDataTable(_em.GetEmailIdByEmail(teacherEmail)).Rows.Count == 0)
            {
                _em.InsertEmail(teacherEmail);
            }
            var teacherEmailId = Int32.Parse(_dm.ToDataTable(_em.GetEmailIdByEmail
                (teacherEmail)).Rows[0].Field<string>("EMailId"));

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

            //Insert the Teacher Details
            _tc.InsertTeacher(teacherFNameId, teacherLNameId, dobId, genderId, teacherEmailId, addressId);
        }

        /// <summary>
        /// Handles the Click event of the Btn_Delete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Dgv_Teachers.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                var index = Int32.Parse(Dgv_Teachers.SelectedCells[0].Value.ToString());
                var caption = "Are you sure you want to delete?";
                var message = "Do you want to delete the Teacher with the record Id of" + " " + index + " ?";
                var buttons = MessageBoxButtons.YesNo;
                var result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    _tc.DeleteTeacher(index);
                    Btn_Refresh.PerformClick();
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the Btn_Update control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the Btn_Save control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            var teacherId = Int32.Parse(Dgv_Teachers.SelectedCells[0].Value.ToString());

            //Update Teacher FName
            var teacherFNameNew = TxtB_TeacherFName.Text;
            if (teacherFNameNew != null)
            {
                var teacherFnameOld = Dgv_Teachers.SelectedCells[1].Value.ToString();
                _fn.UpdateFirstName(teacherFnameOld, teacherFNameNew);
            }
            var teacherFNameId = Int32.Parse(_dm.ToDataTable(_fn.GetFirstNameIdByFirstName
                (teacherFNameNew)).Rows[0].Field<string>("FirstNameId"));

            //Update Teacher LName
            var teacherLNameNew = Txtb_TeacherLName.Text;
            if (teacherLNameNew != null)
            {
                var teacherLnameOld = Dgv_Teachers.SelectedCells[2].Value.ToString();
                _ln.UpdateLName(teacherLnameOld, teacherLNameNew);
            }
            var teacherLNameId = Int32.Parse(_dm.ToDataTable(_ln.GetLastNameIdByLName
                (teacherLNameNew)).Rows[0].Field<string>("LastNameId"));

            //Update DOB
            var dobNew = Dtp_DOB.Value.ToShortDateString();
            if (dobNew != Dgv_Teachers.SelectedCells[3].Value.ToString())
            {
                var dobOld = Dgv_Teachers.SelectedCells[3].Value.ToString();
                _dob.UpdateDoB(Convert.ToDateTime(dobOld), Convert.ToDateTime(dobNew));
            }
            var dobId = Int32.Parse(_dm.ToDataTable(_dob.GetDoBIdByDoBDate
                (Convert.ToDateTime(dobNew))).Rows[0].Field<string>("DobId"));

            //Update Gender
            var genderId = Int32.Parse(Cb_Gender.SelectedValue.ToString());

            //Update Email
            var emailNew = Txtb_email.Text;
            if (emailNew != null)
            {
                var emailOld = Dgv_Teachers.SelectedCells[5].Value.ToString();
                _em.UpdateEmail(emailOld, emailNew);
            }
            var teacherEmailId = Int32.Parse(_dm.ToDataTable(_em.GetEmailIdByEmail
                (emailNew)).Rows[0].Field<string>("EMailId"));

            //Address Details
            //For addressId exist two methods can be retrivied
            var addressId = Int32.Parse(Dgv_Teachers.SelectedCells[10].Value.ToString());
            var addressStreet = Txtb_AddressStreet.Text;
            var addressCity = Txtb_AddressCity.Text;
            var addressRegion = Txtb_AddressRegion.Text;
            var addressPostcode = Txtb_AddressPostCode.Text;
            _adr.UpdateAddressDetails(addressId, addressStreet, addressCity, addressRegion, addressPostcode);

            //Update the Teacher details
            _tc.UpdateTeacher(teacherId, teacherFNameId, teacherLNameId, dobId, genderId, teacherEmailId, addressId);

            Btn_Cancel.PerformClick();
            Btn_Refresh.PerformClick();
        }
    }
}
