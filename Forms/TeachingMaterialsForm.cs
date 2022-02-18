using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using _401AZ_PROJECT.Models;

namespace _401AZ_PROJECT
{
    public partial class TeachingMaterialsForm : Form
    {
        readonly DataManager _dm = new DataManager();
        readonly TeachingMaterials _tm = new TeachingMaterials();
        readonly FileExtension _fe = new FileExtension();
        private readonly Teachers _teacher = new Teachers();

        public TeachingMaterialsForm()
        {
            InitializeComponent();
        }

        private void Fd_Upload_FileOk(object sender, CancelEventArgs e)
        {
            UInt32 fileSize;
            byte[] rawData;
            FileStream fs;


            Fd_Upload.Filter = @"all file|*.*";
            var filepath = Fd_Upload.FileName;
            
            _tm.Filename = Path.GetFileNameWithoutExtension(filepath);
            _fe.FileExtension = Path.GetExtension(filepath);
            _tm.Description = Txt_Description.Text;

            fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            fileSize = Convert.ToUInt32(fs.Length);

            rawData = new byte[fileSize];
            fs.Read(rawData, 0, (Convert.ToInt32(fileSize)));
            fs.Close();

            var teacherId = int.Parse(Cb_TeacherId.SelectedValue.ToString());

            if (_dm.ToDataTable(_fe.GetFileExtensionId(_fe.FileExtension)).Rows.Count == 0)
            {
                _fe.InsertFileExtension(_fe);
            }

            var fileExtensionId = _dm.ToDataTable(_fe.GetFileExtensionId(_fe.FileExtension)).Rows[0].Field<string>("FileExtensionId");
            if (Txt_Description.Text.Length < 0)
            {
                Txt_Description.Text = @"No Description";
            }

            try {_tm.InsertTeachingMaterial(_tm.Filename, Convert.ToInt32(fileExtensionId), _tm.Description, rawData, teacherId);}
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }


            Btn_Cancel.PerformClick();
            Btn_Refresh.PerformClick();

        }

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

        private void Btn_Upload_Click(object sender, EventArgs e)
        {
            Cb_TeacherId.DataSource = _dm.ToDataTable(_teacher.GetTeacher_FName_LName());
            Cb_TeacherId.DisplayMember = "TeacherId";
            if (Dgv_TeachingMaterials.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                Cb_TeacherId.SelectedValue = Int32.Parse(Dgv_TeachingMaterials.SelectedCells[4].Value.ToString());
            }
            HideButtons();
        }

        private void Btn_ChooseFile_Click(object sender, EventArgs e)
        {
            Fd_Upload.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Fd_Upload.ShowDialog();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            ShowButtons();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Dgv_TeachingMaterials.DataSource = _dm.ToDataTable(_tm.GetTeachingMaterials());
            Dgv_TeachingMaterials.Columns["FileContent"].Visible = false;
        }


        private void Teaching_materials_form_Load(object sender, EventArgs e)
        {
            Dgv_TeachingMaterials.DataSource = _dm.ToDataTable(_tm.GetTeachingMaterials());
            Dgv_TeachingMaterials.Columns["FileContent"].Visible = false;
            Dgv_TeachingMaterials.Columns["TeacherId"].Visible = false;
        }

        private void Btn_DeleteRecord_Click(object sender, EventArgs e)
        {
            if (Dgv_TeachingMaterials.Rows.Cast<DataGridViewRow>().Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {
                int index = Int32.Parse(Dgv_TeachingMaterials.SelectedCells[0].Value.ToString());
                string caption = "Are you sure you want to delete?";
                string message = "Do you want to delete the file with the record Id of" + " " + index + " ?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    _tm.DeleteTeachingMaterial(index);
                    Btn_Refresh.PerformClick();
                }
            }

        }

        private void Btn_Download_Click(object sender, EventArgs e)
        {
            if (Dgv_TeachingMaterials.Rows.Cast<DataGridViewRow>()
                .Any(x => x.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null)))
            {

                var index = int.Parse(Dgv_TeachingMaterials.SelectedCells[0].Value.ToString());
                try
                {
                    var downloadFile = _tm.GetTeachingMaterialsWithFileContentByTeachingId(index);
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    var fnNoExt = Dgv_TeachingMaterials.SelectedCells[1].Value.ToString();
                    var fe = Dgv_TeachingMaterials.SelectedCells[2].Value.ToString();
                    saveFileDialog.Filter = fnNoExt + fe + @"|*" + fe;
                    saveFileDialog.Title = @"Get a file from database";
                    saveFileDialog.FileName = fnNoExt + fe;
                    saveFileDialog.DefaultExt = fe;

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        if (saveFileDialog.FileName != "")
                            File.WriteAllBytes(saveFileDialog.FileName, downloadFile.FileContent);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

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
    }
}
