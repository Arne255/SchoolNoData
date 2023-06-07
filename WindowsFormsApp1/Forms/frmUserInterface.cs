using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.DA;

using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1.Forms
{
    public partial class frmUserInterface : Form
    {
        public string logoPath;

        public frmUserInterface()
        {
            InitializeComponent();

            lblSettingsUploadFileName.Hide();
        }

        private void btnSettingsLogoOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //ImageLocation = dialog.FileName...
                pct_frmUserinterface_logo.ImageLocation = dialog.FileName;
                logoPath = dialog.FileName;

                string[] strings = dialog.FileName.Split('\\');

                lblSettingsUploadFileName.Text = "Filename: " + strings[strings.Length - 1].ToString();
                lblSettingsUploadFileName.Show();
            }
        }

        private void btn_Admin_frmUserInterface_Close_frmSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            this.Hide();
            frmSettings.Show();
        }

        private void btnExampleTestUserInterface_Click(object sender, EventArgs e)
        {
            //bool result = Database.UploadImage(logo);
            if (logoPath == null) { return; }
            AccountDA.UploadImage(logoPath);

            DontDestroy.UI.GetLogoFromDB();
        }

        private void frmUserInterface_Load(object sender, EventArgs e)
        {
            DontDestroy.UI.DisplayLayout(this);
        }

        private void btnFirstAdmin_Click(object sender, EventArgs e)
        {
            UserInterfaceDA.SetColorTheme(1);
            DontDestroy.UI.ColorTheme = 1;
            DontDestroy.UI.DisplayLayout(this);
        }

        private void btnSecondAdmin_Click(object sender, EventArgs e)
        {
            UserInterfaceDA.SetColorTheme(2);
            DontDestroy.UI.ColorTheme = 2;
            DontDestroy.UI.DisplayLayout(this);
        }

        private void btnThirdAdmin_Click(object sender, EventArgs e)
        {
            UserInterfaceDA.SetColorTheme(3);
            DontDestroy.UI.ColorTheme = 3;
            DontDestroy.UI.DisplayLayout(this);
        }

        private void frmUserInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();
        }
    }
}
