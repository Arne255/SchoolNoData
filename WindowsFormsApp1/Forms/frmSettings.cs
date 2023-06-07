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
using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1.Forms
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btn_Admin_frmSettings_Close_frmMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.Show();
        }

        private void btn_Admin_frmSettings_Open_frmModerateStudents_Click(object sender, EventArgs e)
        {
            frmModerateStudentsList frmModerateStudentsList = new frmModerateStudentsList();
            this.Hide();
            frmModerateStudentsList.Show();
        }

        private void btn_Admin_frmSettings_Open_frmReasonsList_Click(object sender, EventArgs e)
        {
            frmReasonsList frmReasonsList = new frmReasonsList();
            this.Hide();
            frmReasonsList.Show();
        }

        private void btn_Admin_frmSettings_Open_frmCardsList_Click(object sender, EventArgs e)
        {
        }

        private void btn_Admin_frmSettings_Open_frmClassesList_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Admin_frmSettings_Open_frmAccountsList_Click(object sender, EventArgs e)
        {
            frmAccountsList frmAccountsList = new frmAccountsList();
            this.Hide();
            frmAccountsList.Show();
        }

        private void btn_Admin_frmSettings_Open_frmUserInterface_Click(object sender, EventArgs e)
        {
            frmUserInterface frmUserInterface = new frmUserInterface();
            this.Hide();
            frmUserInterface.Show();
        }

        private void btn_Admin_frmSettings_Open_frmAutomaticSanctions_Click(object sender, EventArgs e)
        {
            frmAutomaticSanctions frmAutomaticSanctions = new frmAutomaticSanctions();
            this.Hide();
            frmAutomaticSanctions.Show();
        }

        private void btn_Admin_frmSettings_Open_frmBulkImportExport_Click(object sender, EventArgs e)
        {
            frmBulkImportExport frmBulkImportExport = new frmBulkImportExport();
            this.Hide();
            frmBulkImportExport.Show();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            DontDestroy.UI.DisplayLayout(this);
        }

        private void frmSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();
        }
    }
}
