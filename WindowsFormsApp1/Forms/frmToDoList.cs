using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Helper;

using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Forms
{
    public partial class frmToDoList : Form
    {
        public frmToDoList()
        {
            InitializeComponent();
        }

        private void btn_frmToDoList_Close_frmMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.Show();
        }

        private void frmToDoList_Load(object sender, EventArgs e)
        {
            DontDestroy.UI.DisplayLayout(this);

        }

        private void frmToDoList_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();
        }
    }
}
