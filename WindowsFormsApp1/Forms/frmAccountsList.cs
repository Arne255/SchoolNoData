using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DA;
using WindowsFormsApp1.Helper;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    public partial class frmAccountsList : Form
    {

        public frmAccountsList()
        {
            InitializeComponent();
            DontDestroy.UI.DisplayLayout(this);

            List<Account> Accounts = AccountDA.GetAccounts();
            LoadListView(Accounts);
        }

        private void btn_Admin_frmAccountsList_Close_frmSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            this.Hide();
            frmSettings.Show();
        }

        public void LoadListView(List<Account> accounts)
        {
            MainListView.Items.Clear();


            foreach (Account account in accounts)
            {

                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = account.ID.ToString();
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(account.Username);
                listViewItem.SubItems.Add(account.Hash.ToString());
                if (account.IsAdmin)
                {
                    listViewItem.SubItems.Add("Ja");
                }
                else
                {
                    listViewItem.SubItems.Add("Nee");
                }
                if (account.IsEnabled)
                {
                    listViewItem.SubItems.Add("Ja");
                }
                else
                {
                    listViewItem.SubItems.Add("Nee");
                }


                MainListView.Items.Add(listViewItem);
            }
        }


        private void btnLateListSearch_Click(object sender, EventArgs e)
        {
            List<Account> Accounts = AccountDA.GetAccounts();
            LoadListView(Accounts);
        }

        private void Timer_ResetListView_Tick(object sender, EventArgs e)
        {
            MainListView.Columns[0].Width = 0;
            MainListView.Columns[1].Width = 0;
        }

        private void btnEnableAdmîn_Click(object sender, EventArgs e)
        {
            if (MainListView.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ben je zeker dat je: " + MainListView.SelectedItems.Count + " account(s) wilt admin maken?", "Account(s) admin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = MainListView.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        int ID = Convert.ToInt32(MainListView.SelectedItems[i].Text);
                        string Username = MainListView.SelectedItems[i].SubItems[2].Text;
                        string Hash = MainListView.SelectedItems[i].SubItems[3].Text;
                        Console.WriteLine(Username + " Is now admin!");


                        //Create Account Based On Values From MainListView
                        Account account = new Account(ID, Username, Hash, false, false);

                        MainListView.SelectedItems[i].SubItems[4].Text = "Ja";
                        AccountDA.changeAdminValue(account, true);
                    }
                }
            }
        }

        private void btnEnableAccount_Click(object sender, EventArgs e)
        {
            if (MainListView.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ben je zeker dat je: " + MainListView.SelectedItems.Count + " account(s) wilt activeren?", "Account(s) activeren", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = MainListView.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        int ID = Convert.ToInt32(MainListView.SelectedItems[i].Text);
                        string Username = MainListView.SelectedItems[i].SubItems[2].Text;
                        string Hash = MainListView.SelectedItems[i].SubItems[3].Text;
                        Console.WriteLine(Username + " Is now enabled!");

                        //Create Account Based On Values From MainListView
                        Account account = new Account(ID, Username, Hash, false, false);
                        AccountDA.changeEnabledValue(account, true);
                        MainListView.SelectedItems[i].SubItems[5].Text = "Ja";
                    }
                }
            }
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Om een account toe te voegen zal je op de login pagina moeten doen.", "account toe voegen");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MainListView.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ben je zeker dat je: " + MainListView.SelectedItems.Count + " account(s) wilt verwijderen?", "Account(s) verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = MainListView.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        int ID = Convert.ToInt32(MainListView.SelectedItems[i].Text);
                        string Username = MainListView.SelectedItems[i].SubItems[2].Text;
                        string Hash = MainListView.SelectedItems[i].SubItems[3].Text;

                        Console.WriteLine(Username + " Is now enabled!");

                        //Create Account Based On Values From MainListView
                        Account account = new Account(ID, Username, Hash, false, false);

                        Console.WriteLine(account.Username + " Is Removed!");
                        AccountDA.RemoveAccount(account);
                        MainListView.SelectedItems[i].Remove();
                    }
                }
            }
        }

        private void btnDisableAdmîn_Click(object sender, EventArgs e)
        {
            if (MainListView.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ben je zeker dat je admin van: " + MainListView.SelectedItems.Count + " account(s) weghalen?", "Account(s) admin removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = MainListView.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        int ID = Convert.ToInt32(MainListView.SelectedItems[i].Text);
                        string Username = MainListView.SelectedItems[i].SubItems[2].Text;
                        string Hash = MainListView.SelectedItems[i].SubItems[3].Text;
                        Console.WriteLine(Username + "'s admin premissions were revoked!");

                        //Create Account Based On Values From MainListView
                        Account account = new Account(ID, Username, Hash, false, false);
                        MainListView.SelectedItems[i].SubItems[4].Text = "Nee";
                        AccountDA.changeAdminValue(account, false);
                    }
                }
            }
        }

        private void btnDisableAccount_Click(object sender, EventArgs e)
        {
            if (MainListView.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ben je zeker dat je: " + MainListView.SelectedItems.Count + " account(s) wilt deactiveren?", "Account(s) deactiveren", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = MainListView.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        int ID = Convert.ToInt32(MainListView.SelectedItems[i].Text);
                        string Username = MainListView.SelectedItems[i].SubItems[2].Text;
                        string Hash = MainListView.SelectedItems[i].SubItems[3].Text;
                        Account account = new Account(ID, Username, Hash, false, false);

                        Console.WriteLine(account.Username + " Is now deactivated!");
                        AccountDA.changeEnabledValue(account, false);
                        MainListView.SelectedItems[i].SubItems[5].Text = "Nee";
                    }
                }
            }
        }

        private void frmAccountsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();
        }
    }
}
