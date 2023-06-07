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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn_frmMenu_Open_frmScanner_Click(object sender, EventArgs e)
        {
            frmScanner frmScanner = new frmScanner();
            frmScanner.Show();
            this.Hide();
        }

        private void btn_frmMenu_Open_frmLatesList_Click(object sender, EventArgs e)
        {
            frmLatesList frmLatesList = new frmLatesList();
            this.Hide();
            //this.Close();
            frmLatesList.Show();
        }

        private void btn_frmMenu_Open_frmStudentsList_Click(object sender, EventArgs e)
        {
            frmStudentsList frmStudentsList = new frmStudentsList();
            //this.Close();
            this.Hide();
            frmStudentsList.Show();
        }

        private void btn_frmMenu_Open_frmSanctionList_Click(object sender, EventArgs e)
        {
            frmSanctionsList frmSanctionList = new frmSanctionsList();
            //this.Close();
            frmSanctionList.Show();
            this.Hide();

        }

        private void btn_Admin_frmMenu_Open_frmSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            //this.Close();
            frmSettings.Show();
            this.Hide();

        }

        private void btn_frmMenu_Logout_frmLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            //this.Close();
            frmLogin.Show();
            this.Hide();

        }

        private void btn_frmMenu_Open_frmToDoList_Click(object sender, EventArgs e)
        {
            frmToDoList frmToDoList = new frmToDoList();
            //this.Close();
            frmToDoList.Show();
            this.Hide();

        }

        private void btn_frmMenu_Open_frmEarlyOnSchool_Click(object sender, EventArgs e)
        {
            frmEarlyOnSchool frmEarlyOnSchool = new frmEarlyOnSchool();
            //this.Close();
            this.Hide();
            frmEarlyOnSchool.Show();
        }

        //private void frmMenu_Load(object sender, EventArgs e)
        //{
        //    StaticHolder.UI.DisplayLayout(this);

        //    //Console.WriteLine(StaticHolder.UI.account.Username + " | " + StaticHolder.UI.account.Hash + " | " + StaticHolder.UI.account.isAdmin);
        //}

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();
        }

        private void frmMenu_Activated(object sender, EventArgs e)
        {
            DontDestroy.UI.DisplayLayout(this);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_frmMenu_SlaOnlineOp_frmMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Je zal opnieuw zo een melding als dit krijgen wanneer de database opgeslaan is.");
            Backup.SaveOnline();
            MessageBox.Show("Gegevens Online Opgeslaan!");
        }
    }
}
