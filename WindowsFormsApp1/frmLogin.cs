using PCSC;
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
using WindowsFormsApp1.Model;
using WindowsFormsApp1.DA;
using WindowsFormsApp1.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
   
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            if (!DontDestroy.dataLoaded)
            {
                //Loading From Backup:
                //...
                Backup.LoadFromOnline();
                DontDestroy.dataLoaded = true;
            }


            DontDestroy.UI.DisplayLayout(this);
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            frmScanner scanner = new frmScanner();
            scanner.FormClosed += new FormClosedEventHandler(Scanner_closed);
            this.Hide();
            scanner.Show();
        }

        private void Scanner_closed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Scanner Closed!");
            this.Close();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account newAcc = new Account(txtUsername.Text, txtPassword.Text);
            DontDestroy.UI.Account = newAcc;
            txtUsername.Clear();
            txtPassword.Clear();
            int isValid;
            try
            {
                isValid = AccountDA.ValidateAccount(DontDestroy.UI.Account);

                if (isValid == -1) { return; } //Not an Account

                if (isValid == 1) { DontDestroy.UI.Account.IsAdmin = true; } //Admin Account
            }
            catch
            {
                return;
            }

            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.Show();

            //Hash Multiple times for more security.
        }


        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUsername.Focus();
                btnLogin_Click(sender, e);
            }
        }

        private void btnThird_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text)){
                return;
            }


            Account newAcc = new Account(txtUsername.Text, txtPassword.Text);

            txtUsername.Clear();
            txtPassword.Clear();

            if (AccountDA.AddAccount(newAcc) == 0)
            {
                MessageBox.Show("Account moet nog toegestaan worden");
            }else
            {
                MessageBox.Show("Onbekende fout!");
            }

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}