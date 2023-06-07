using Microsoft.VisualBasic;
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
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1.Forms
{
    public partial class frmReasonsList : Form
    {
        public frmReasonsList()
        {
            InitializeComponent();
        }

        private void btn_Admin_frmReasonsList_Close_frmSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            this.Hide();
            frmSettings.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //NameId veranderen + MessageBox laten weten dat kleur van listview niet mee zal opgeslaan worden
            //NameId veranderen + MessageBox laten weten dat kleur van listview niet mee zal opgeslaan worden
            //NameId veranderen + MessageBox laten weten dat kleur van listview niet mee zal opgeslaan worden
            //NameId veranderen + MessageBox laten weten dat kleur van listview niet mee zal opgeslaan worden
        }

        private void frmReasonsList_Load(object sender, EventArgs e)
        {
            DontDestroy.UI.DisplayLayout(this);

            LoadListView();

        }

        private void LoadListView()
        {
            ListViewMain.Items.Clear();

            List<Reason> reasons = ReasonDA.GetReasons();

            foreach (Reason reason in reasons)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reason.ReasonID.ToString();
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(reason.ReasonText.ToString());
                //listViewItem.SubItems.Add(reason.IsValid.ToString());
                if (reason.IsValid)
                {
                    listViewItem.SubItems.Add("Ja");
                }
                else
                {
                    listViewItem.SubItems.Add("Nee");
                }

                if (reason.IsCustom)
                {
                    listViewItem.SubItems.Add("Ja");
                }
                else
                {
                    listViewItem.SubItems.Add("Nee");
                }
                //listViewItem.SubItems.Add(reason.IsCustom.ToString());
                ListViewMain.Items.Add(listViewItem);
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            string ReasonText = Interaction.InputBox("ReasonText");
            DialogResult dialogResult = MessageBox.Show("IsValid?", "IsValid", MessageBoxButtons.YesNo);

            //Creating Reason
            Reason reason = new Reason();
            reason.ReasonText = ReasonText;

            if (dialogResult == DialogResult.Yes)
            {
                reason.IsValid = true;
                reason.IsCustom = false;
                ReasonDA.UploadReason(reason);
            }
            else
            {
                reason.IsValid = false;
                reason.IsCustom = false;
                ReasonDA.UploadReason(reason);
            }

            LoadListView();
        }

        private void btn_frmReasons_RemoveReason_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ben je zeker dat je dit wil verwijderen? De redenen zullen bij de leerlingen van toepassing komen te vervallen.", "ben je zeker dat je dit wil verwijderen? De redenen zullen bij de leerlingen van toepassing komen te vervallen.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (dialogResult != DialogResult.Yes)
                return;


            for (int i = ListViewMain.SelectedItems.Count - 1; i >= 0; i--)
            {
                Reason reason = new Reason();
                reason.ReasonID = Convert.ToInt32(ListViewMain.SelectedItems[i].Text);

                ReasonDA.RemoveReason(reason); //might have to make function where it removes these (if multiple selected) in one query and this could be out of the loop then
                ListViewMain.SelectedItems[i].Remove();
            }
        }

        private void frmReasonsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();

        }

        private void btnSetCustom_Secondary_Click(object sender, EventArgs e)
        {
            for (int i = ListViewMain.SelectedItems.Count - 1; i >= 0; i--)
            {
                Reason reason = new Reason();
                reason.ReasonID = Convert.ToInt32(ListViewMain.Items[i].Text);
                reason.IsCustom = true;
                ReasonDA.UpdateReasonCustom(reason);
                ListViewMain.SelectedItems[i].SubItems[4].Text = "Ja";
            }
        }

        private void btnSetNonCustom_Secondary_Click(object sender, EventArgs e)
        {
            for (int i = ListViewMain.SelectedItems.Count - 1; i >= 0; i--)
            {
                Reason reason = new Reason();
                reason.ReasonID = Convert.ToInt32(ListViewMain.SelectedItems[i].Text);
                reason.IsCustom = false;    
                ReasonDA.UpdateReasonCustom(reason);
                ListViewMain.SelectedItems[i].SubItems[4].Text = "Nee";
            }
        }

        private void btnSetInvalid_Secondary_Click(object sender, EventArgs e)
        {
            for (int i = ListViewMain.SelectedItems.Count - 1; i >= 0; i--)
            {
                Reason reason = new Reason();
                reason.ReasonID = Convert.ToInt32(ListViewMain.SelectedItems[i].Text);
                reason.IsValid = false;
                ReasonDA.UpdateReasonCustom(reason);
                ListViewMain.SelectedItems[i].SubItems[3].Text = "Nee";
            }
        }

        private void btnSetValid_Secondary_Click(object sender, EventArgs e)
        {
            for (int i = ListViewMain.SelectedItems.Count - 1; i >= 0; i--)
            {
                Reason reason = new Reason();
                reason.ReasonID = Convert.ToInt32(ListViewMain.SelectedItems[i].Text);
                reason.IsValid = true;
                ReasonDA.UpdateReasonCustom(reason);
                ListViewMain.SelectedItems[i].SubItems[3].Text = "Ja";
            }
        }
    }
}
