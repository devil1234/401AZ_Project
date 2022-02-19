using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using _401AZ_PROJECT.Models;

namespace _401AZ_PROJECT
{
    /// <summary>
    /// Class TeachingMaterialsForm.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class TeachingMaterialsForm : Form
    {
        /// <summary>
        /// The initializes the classes required for this form to work
        /// </summary>
        private readonly DataManager _dm = new DataManager();
        private readonly TeachingMaterials _tm = new TeachingMaterials();
        private readonly Teachers _teacher = new Teachers();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeachingMaterialsForm" /> class.
        /// </summary>
        public TeachingMaterialsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the FileOk event of the Fd_Upload control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="CancelEventArgs" /> instance containing the event data.</param>
        private void Fd_Upload_FileOk(object sender, CancelEventArgs e)
        {
            UInt32 fileSize;
            byte[] rawData;
            FileStream fs;

            var t = new TeachingMaterials();
            var fe = new FileExtension();

            Fd_Upload.Filter = @"all file|*.*";
            var filepath = Fd_Upload.FileName;
            
            t.Filename = Path.GetFileNameWithoutExtension(filepath);
            fe.FileExtension = Path.GetExtension(filepath);
            t.Description = Txt_Description.Text;

            fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            fileSize = Convert.ToUInt32(fs.Length);

            rawData = new byte[fileSize];
            fs.Read(rawData, 0, (Convert.ToInt32(fileSize)));
            fs.Close();

            var teacherId = Int32.Parse(Cb_TeacherId.SelectedValue.ToString());

            if (_dm.ToDataTable(fe.GetFileExtensionId(fe.FileExtension)).Rows.Count == 0)
            {
                fe.InsertFileExtension(fe);
            }

            var fileExtensionId = _dm.ToDataTable(fe.GetFileExtensionId(fe.FileExtension)).Rows[0].Field<string>("FileExtensionId");
            if (Txt_Description.Text.Length < 0)
            {
                Txt_Description.Text = @"No Description";
            }

            try {t.InsertTeachingMaterial(t.Filename, Convert.ToInt32(fileExtensionId), t.Description, rawData, teacherId);}
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }


            Btn_Cancel.PerformClick();
            Btn_Refresh.PerformClick();

        }

        /// <summary>
        /// Hides the buttons.
        /// </summary>
        private void HideButtons()
        {
            Btn_ChooseFile.Visible = true;
            Btn_Download.Visible = false;
            Lbl_TeacherId.Visible = true;
            Cb_TeacherId.Visible = true;
            Cb_TeacherId.Enabled = true;
            Btn_Refresh.Visible = false;
            Btn_Cancel.Visible = true;
            Lbl_Description.Visible = true;
            Txt_Description.Visible = true;
            Btn_Upload.Visible = false;
            Btn_DeleteRecord.Visible = false;
            Lbl_TeacherFName.Visible = true;
            Lbl_TeacherLName.Visible = true;
            Cb_TFName.Visible = true;
            Cb_TLName.Visible = true;
        }

        /// <summary>
        /// Shows the buttons.
        /// </summary>
        private void ShowButtons()
        {
            Btn_ChooseFile.Visible = false;
            Btn_Download.Visible = true;
            Lbl_TeacherId.Visible = false;
            Cb_TeacherId.Visible = false;
            Cb_TeacherId.Enabled = false;
            Btn_Refresh.Visible = true;
            Btn_Cancel.Visible = false;
            Btn_Upload.Visible = true;
            Lbl_Description.Visible = false;
            Txt_Description.Visible = false;
            Btn_DeleteRecord.Visible = true;
            Lbl_TeacherFName.Visible= false;
            Lbl_TeacherLName.Visible = false;
            Cb_TFName.Visible = false;
            Cb_TLName.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the Btn_Upload control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Upload_Click(object sender, EventArgs e)
        {
            Cb_TeacherId.DataSource = _dm.ToDataTable(_teacher.GetTeacher_FName_LName());
            Cb_TeacherId.DisplayMember = "Teacher_Id";
            if (Dgv_TeachingMaterials.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                Cb_TeacherId.SelectedValue = Int32.Parse(Dgv_TeachingMaterials.SelectedCells[4].Value.ToString());
            }
            HideButtons();
        }

        /// <summary>
        /// Handles the Click event of the Btn_ChooseFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_ChooseFile_Click(object sender, EventArgs e)
        {
            Fd_Upload.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Fd_Upload.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the Btn_Cancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            ShowButtons();
        }

        /// <summary>
        /// Handles the Click event of the Btn_Refresh control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Dgv_TeachingMaterials.DataSource = _dm.ToDataTable(_tm.GetTeachingMaterials());
            Dgv_TeachingMaterials.Columns["FileContent"].Visible = false;
        }


        /// <summary>
        /// Handles the Load event of the Teaching_materials_form control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Teaching_materials_form_Load(object sender, EventArgs e)
        {
            Dgv_TeachingMaterials.DataSource = _dm.ToDataTable(_tm.GetTeachingMaterials());
            Dgv_TeachingMaterials.Columns["FileContent"].Visible = false;
            Dgv_TeachingMaterials.Columns["TeacherId"].Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the Btn_DeleteRecord control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_DeleteRecord_Click(object sender, EventArgs e)
        {
            if (Dgv_TeachingMaterials.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                var index = Int32.Parse(Dgv_TeachingMaterials.SelectedCells[0].Value.ToString());
                var caption = "Are you sure you want to delete?";
                var message = "Do you want to delete the file with the record Id of" + " " + index + " ?";
                var buttons = MessageBoxButtons.YesNo;
                var result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    _tm.DeleteTeachingMaterial(index);
                    Btn_Refresh.PerformClick();
                }
            }

        }

        /// <summary>
        /// Handles the Click event of the Btn_Download control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Btn_Download_Click(object sender, EventArgs e)
        {
            if(Dgv_TeachingMaterials.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {

                //Show progress bar and labels
                pb1.Visible = true;
                LblProgress.Visible = true;
                Btn_Download.Enabled = false;
                var fnNoExt = Dgv_TeachingMaterials.SelectedCells[1].Value.ToString();
                var fe = Dgv_TeachingMaterials.SelectedCells[2].Value.ToString();

                saveFileDialog.Filter = fnNoExt + fe + @"|*" + fe;
                saveFileDialog.Title = @"Get a file from database";
                saveFileDialog.FileName = fnNoExt + fe;
                saveFileDialog.DefaultExt = fe;

                saveFileDialog.ShowDialog();


            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Cb_TeacherId control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Cb_TeacherId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cb_TFName.DataSource = Cb_TeacherId.DataSource;
            Cb_TLName.DataSource = Cb_TeacherId.DataSource;
            Cb_TFName.DisplayMember = "FirstName";
            Cb_TFName.ValueMember = "TeacherId";

            Cb_TLName.DisplayMember = "LastName";
            Cb_TLName.ValueMember = "TeacherId";

            Cb_TeacherId.DisplayMember = "TeacherId";
            Cb_TeacherId.ValueMember = "TeacherId";
        }

        /// <summary>
        /// Handles the DoWork event of the bw control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DoWorkEventArgs" /> instance containing the event data.</param>
        private async void bw_DoWork(object sender, DoWorkEventArgs e)
        {

            var i = Int32.Parse(Dgv_TeachingMaterials.SelectedCells[0].Value.ToString());
            var downloadData = _tm.GetFileContentByTeachingId(i);
            var fileContentLenght = _tm.GetFileContentByTeachingId(i).FileContent.Length;
            
            FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
            fs.Seek(0, SeekOrigin.End);
            await fs.WriteAsync(downloadData.FileContent, 0, fileContentLenght);

            //File.WriteAllBytes(saveFileDialog.FileName, downloadData.FileContent);
        }

        /// <summary>
        /// Handles the RunWorkerCompleted event of the bw control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RunWorkerCompletedEventArgs" /> instance containing the event data.</param>
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Btn_Download.Enabled = true;
            pb1.Visible = false;
            LblProgress.Visible = false;
            MessageBox.Show(@"Download Completed!", @"Download");
        }

        /// <summary>
        /// Handles the FileOk event of the saveFileDialog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="CancelEventArgs" /> instance containing the event data.</param>
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

            bw.RunWorkerAsync();
        }

        /// <summary>
        /// Handles the ProgressChanged event of the bw control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ProgressChangedEventArgs" /> instance containing the event data.</param>
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb1.Value = e.ProgressPercentage;
        }
    }
}
