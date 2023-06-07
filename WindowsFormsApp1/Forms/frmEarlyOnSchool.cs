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
    public partial class frmEarlyOnSchool : Form
    {
        public frmEarlyOnSchool()
        {
            InitializeComponent();
        }

        private void btn_frmEarlyOnSchool_Close_frmMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.Show();
        }

        private void frmEarlyOnSchool_Load(object sender, EventArgs e)
        {
            DontDestroy.UI.DisplayLayout(this);
        }

        private void frmEarlyOnSchool_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();

        }
    }
}
