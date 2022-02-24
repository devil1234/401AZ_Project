using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _401AZ_PROJECT.Models;

namespace _401AZ_PROJECT.Forms
{
    /// <summary>
    /// Class StudentForm.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class StudentForm : Form
    {
        /// <summary>
        /// The initializes the classes required for this form to work
        /// </summary>
        private readonly DataManager _dm = new DataManager();
        private readonly Student _st = new Student();
        private readonly FirstNames _fn = new FirstNames();
        private readonly LastName _ln = new LastName();
        private readonly Dob _dob = new Dob();
        private readonly Genders _genders = new Genders();
        private readonly Emails _em = new Emails();
        private readonly StudentParentsDetail _spd = new StudentParentsDetail();
        private readonly Address _adr = new Address();

        /// <summary>
        /// Initializes a new instance of the <see cref="StudentForm" /> class.
        /// </summary>
        public StudentForm()
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
        /// Handles the TextChanged event of the Txtb_StudentId control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Txtb_StudentId_TextChanged(object sender, EventArgs e)
        {
            Btn_search_student.Enabled = !string.IsNullOrWhiteSpace(Txtb_StudentId.Text);
        }

        /// <summary>
        /// Handles the Click event of the Btn_search_student control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_search_student_Click(object sender, EventArgs e)
        {
            Dgv_Students.DataSource = _dm.ToDataTable(_st.GetStudentsById(Convert.ToInt32(Txtb_StudentId.Text)));
        }

        /// <summary>
        /// Handles the Load event of the Student_form control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Student_form_Load(object sender, EventArgs e)
        {
            Dgv_Students.DataSource = _dm.ToDataTable(_st.GetStudents());
            Populate_Form();
        }

        /// <summary>
        /// Handles the Click event of the Btn_EnableSearch control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_EnableSearch_Click(object sender, EventArgs e)
        {
            switch (Btn_search_student.Visible)
            {
                case false:
                    Txtb_StudentId.Enabled = true;
                    Txtb_StudentId.Text = null;
                    Btn_search_student.Visible = true;
                    break;
                default:
                    Txtb_StudentId.Enabled = false;
                    Btn_search_student.Visible = false;
                    Btn_Refresh.PerformClick();
                    break;
            }
        }

        /// <summary>
        /// Handles the KeyDown event of the Txtb_StudentId control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs" /> instance containing the event data.</param>
        private void Txtb_StudentId_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Btn_search_student.PerformClick();
                    Txtb_StudentId.Clear();
                    break;
            }
        }

        /// <summary>
        /// Handles the Click event of the Btn_Refresh control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Dgv_Students.DataSource = _dm.ToDataTable(_st.GetStudents());
            Populate_Form();
        }

        /// <summary>
        /// Handles the SelectionChanged event of the Dgv_Students control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Dgv_Students_SelectionChanged(object sender, EventArgs e)
        {
            switch (Dgv_Students.SelectedRows.Count > 0)
            {
                case true:
                    Btn_Update.Enabled = true;
                    Btn_Delete.Enabled = true;
                    Populate_Form();
                    break;
                default:
                    Btn_Update.Enabled = false;
                    Btn_Delete.Enabled = false;
                    Unpopulate_Form();
                    break;
            }
        }

        /// <summary>
        /// Populates the form.
        /// </summary>
        private void Populate_Form()
        {
            switch (Dgv_Students.SelectedRows.Count <= 0)
            {
                case true:
                    return;
            }
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

        /// <summary>
        /// Unpopulates the form.
        /// </summary>
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

        /// <summary>
        /// Handles the CellFormatting event of the Dgv_Students control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellFormattingEventArgs" /> instance containing the event data.</param>
        private void Dgv_Students_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (Dgv_Students.Columns[e.ColumnIndex].Name)
            {
                case "Dob":
                    ShortFormDateFormat(e);
                    break;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the Txtb_StudentId control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs" /> instance containing the event data.</param>
        private void Txtb_StudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (char.IsControl(e.KeyChar))
            {
                case false when !char.IsDigit(e.KeyChar):
                    e.Handled = true;
                    break;
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
            switch (Dgv_Students.SelectedRows.Count <= 0)
            {
                case true:
                    return;
                default:
                    Cb_Gender.Text = Dgv_Students.SelectedCells[4].Value.ToString();
                    break;
            }
        }

        /// <summary>
        /// Buttons to enable.
        /// </summary>
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

        /// <summary>
        /// Buttons to disable.
        /// </summary>
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
            //Retrive the Student FName from txtbox, insert it into db with checks and retrieve the id
            var studentFName = TxtB_StudentFName.Text;
            switch (studentFName)
            {
                case null:
                    MessageBox.Show(@"The student first name cannot be empty! Please fill the box!", @"Warning!!!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
            }
            if (_dm.ToDataTable(_fn.GetFirstNameIdByFirstName(studentFName)).Rows.Count == 0)
            {
                try
                {
                    _fn.InsertFirstName(studentFName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
            var studentFNameId = Int32.Parse(_dm.ToDataTable(_fn.GetFirstNameIdByFirstName(studentFName)).Rows[0].Field<string>("FirstNameId"));

            //Retrive the Student LName from txtbox, insert it into db with checks and retrieve the id
            var studentLName = Txtb_StudentLName.Text;
            switch (studentLName)
            {
                case null:
                    MessageBox.Show(@"The student last name cannot be empty! Please fill the box!", @"Warning!!!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
            }
            if (_dm.ToDataTable(_ln.GetLastNameIdByLName(studentLName)).Rows.Count == 0)
            {
                try
                {
                    _ln.InsertLastName(studentLName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
            var studentLNameId = Int32.Parse(_dm.ToDataTable(_ln.GetLastNameIdByLName(studentLName)).Rows[0].Field<string>("LastNameId"));

            //Retrive the Student DOB from DateTimePicker, insert it into db with checks and retrieve the id
            var dob = Dtp_DOB.Value.ToShortDateString();
            if (_dm.ToDataTable(_dob.GetDoBIdByDoBDate(Convert.ToDateTime(dob))).Rows.Count == 0)
            {
                _dob.InsertDoB(Convert.ToDateTime(dob));
            }
            var dobId = Int32.Parse(_dm.ToDataTable(_dob.GetDoBIdByDoBDate
                (Convert.ToDateTime(dob))).Rows[0].Field<string>("DobId"));

            //Retrieve the Student Gender from ComboBox
            var genderId = Int32.Parse(Cb_Gender.SelectedValue.ToString());

            //Retrieve the Student email from txtbox, insert it into db with checks and retrieve the id
            var studentEmail = Txtb_email.Text;
            switch (studentEmail)
            {
                case null:
                    MessageBox.Show(@"The student e-mail cannot be empty! Please fill the box!", @"Warning!!!", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
            }
            if (!_dm.IsValidEmail(studentEmail))
            {
                MessageBox.Show(@"Please use a valid e-mail address!!!", @"Warning!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (_dm.ToDataTable(_em.GetEmailIdByEmail(studentEmail)).Rows.Count == 0)
            {
                try
                {
                    _em.InsertEmail(studentEmail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
            var studentEmailId = Int32.Parse(_dm.ToDataTable(_em.GetEmailIdByEmail
                (studentEmail)).Rows[0].Field<string>("EMailId"));

            //Retrieve parent details from txtboxes,insert with checks and retrieve the id
            var parentFname = Txtb_ParentFName.Text;
            var parentLname = TxtB_ParentLName.Text;
            var parentPn = Txtb_ParentPN.Text;
            if (parentFname == null || parentLname == null || parentPn == null)
            {
                MessageBox.Show(@"The parent details cannot be empty!!! Please fill all the boxes!!!", @"Warning!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if(_dm.ToDataTable(_spd.GetParentDetailsByFName(parentFname)).Rows.Count == 0)
            {
                try
                {
                    _spd.InsertParentsDetails(parentFname, parentLname, parentPn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
            var parentId = Int32.Parse(_dm.ToDataTable(_spd.GetParentDetailsByFName
                (parentFname)).Rows[0].Field<string>("ParentId"));

            //Retrieve address details from txtboxes, insert with checks and retrieve the id
            var addressStreet = Txtb_AddressStreet.Text;
            var addressCity = Txtb_AddressCity.Text;
            var addressRegion = Txtb_AddressRegion.Text;
            var addressPostCode = Txtb_AddressPostCode.Text;
            if (addressStreet == null || addressCity == null || addressRegion == null || addressPostCode == null)
            {
                MessageBox.Show(@"The student address details cannot be empty!!! Please fill all the boxes!!!", @"Warning!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (_dm.ToDataTable(_adr.GetAddressesByCity(addressCity)).Rows.Count == 0)
            {
                try
                {
                    _adr.InsertAddressDetails(addressStreet, addressCity, addressRegion, addressPostCode);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
            var addressId = Int32.Parse(_dm.ToDataTable(_adr.GetAddressesByCity
                (addressCity)).Rows[0].Field<string>("AddressId"));

            //Insert the Student Details
            try
            {
                _st.InsertStudent(studentFNameId, studentLNameId, dobId, genderId, studentEmailId, parentId, addressId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            Btn_Cancel.PerformClick();
        }

        //A method to delete the Student record by StudentId
        /// <summary>
        /// Handles the Click event of the Btn_Delete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Dgv_Students.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                var index = Int32.Parse(Dgv_Students.SelectedCells[0].Value.ToString());
                var caption = "Are you sure you want to delete?";
                var message = "Do you want to delete the Student with the record Id of" + " " + index + " ?";
                var buttons = MessageBoxButtons.YesNo;
                var result = MessageBox.Show(message, caption, buttons);

                switch (result)
                {
                    case DialogResult.Yes:
                        _st.DeleteStudent(index);
                        Btn_Refresh.PerformClick();
                        break;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the Btn_Update control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        /// Set the form and buttons when update button is clicked
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

        /// <summary>
        /// Handles the Click event of the Btn_Save control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //Retrieve the StudentId
            var studentId = Int32.Parse(Dgv_Students.SelectedCells[0].Value.ToString());

            //Update Student FName
            var studentFNameNew = TxtB_StudentFName.Text;

            if(studentFNameNew != null)
            {
                var studentFnameOld = Dgv_Students.SelectedCells[1].Value.ToString();
                _fn.UpdateFirstName(studentFnameOld, studentFNameNew);
            }
            var studentFNameId = Int32.Parse(_dm.ToDataTable(_fn.GetFirstNameIdByFirstName
                (studentFNameNew)).Rows[0].Field<string>("FirstNameId"));

            //Update Student LName
            var studentLNameNew = Txtb_StudentLName.Text;
            if (studentLNameNew != null)
            {
                var studentLnameOld = Dgv_Students.SelectedCells[2].Value.ToString();
                _ln.UpdateLName(studentLnameOld, studentLNameNew);
            }
            var studentLNameId = Int32.Parse(_dm.ToDataTable(_ln.GetLastNameIdByLName
                (studentLNameNew)).Rows[0].Field<string>("LastNameId"));

            //Update DOB
            var dobNew = Dtp_DOB.Value.ToShortDateString();
            if (dobNew != Dgv_Students.SelectedCells[3].Value.ToString())
            {
                var dobOld = Dgv_Students.SelectedCells[3].Value.ToString();
                _dob.UpdateDoB(Convert.ToDateTime(dobOld), Convert.ToDateTime(dobNew));
            }
            var dobId = Int32.Parse(_dm.ToDataTable(_dob.GetDoBIdByDoBDate
                (Convert.ToDateTime(dobNew))).Rows[0].Field<string>("DobId"));

            //Update Gender
            var genderId = Int32.Parse(Cb_Gender.SelectedValue.ToString());

            //Update Email
            var emailNew = Txtb_email.Text;
            if (!_dm.IsValidEmail(emailNew))
            {
                MessageBox.Show(@"Please use a valid e-mail address!!!", @"Warning!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (emailNew != null)
            {
                var emailOld = Dgv_Students.SelectedCells[5].Value.ToString();
                _em.UpdateEmail(emailOld, emailNew);
            }
            var studentEmailId = Int32.Parse(_dm.ToDataTable(_em.GetEmailIdByEmail
                (emailNew)).Rows[0].Field<string>("EMailId"));

            //Parent Details
            //Retrieve the text from txtboxes and passed on update function
            var parentId = Int32.Parse(Dgv_Students.SelectedCells[6].Value.ToString());
            var parentFnameNew = Txtb_ParentFName.Text;
            var parentLnameNew = TxtB_ParentLName.Text;
            var parentPnNew = Txtb_ParentPN.Text;
            if (parentFnameNew == null || parentLnameNew == null || parentPnNew == null)
            {
                MessageBox.Show(@"The parent details cannot be empty!!! Please fill all the boxes!!!", @"Warning!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            _spd.UpdateParentDetails(parentId, parentFnameNew, parentLnameNew, parentPnNew);

            //Address Details
            var addressId = Int32.Parse(Dgv_Students.SelectedCells[10].Value.ToString());
            var addressStreet = Txtb_AddressStreet.Text;
            var addressCity = Txtb_AddressCity.Text;
            var addressRegion = Txtb_AddressRegion.Text;
            var addressPostcode = Txtb_AddressPostCode.Text;
            if (addressStreet == null || addressCity == null || addressRegion == null || addressPostcode == null)
            {
                MessageBox.Show(@"The student address details cannot be empty!!! Please fill all the boxes!!!", @"Warning!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            _adr.UpdateAddressDetails(addressId, addressStreet, addressCity, addressRegion, addressPostcode);

            //Update the student details
            _st.UpdateStudent(studentId, studentFNameId, studentLNameId, dobId, genderId, studentEmailId, parentId, addressId);

            Btn_Cancel.PerformClick();
            
        }
    }
}
