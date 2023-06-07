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
using Microsoft.VisualBasic;
using WindowsFormsApp1.DA;
using System.Collections;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Forms
{
    public partial class frmAutomaticSanctions : Form
    {
        public frmAutomaticSanctions()
        {
            InitializeComponent();
        }

        private void btn_Admin_frmAutomaticSanctions_Close_frmSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            this.Hide();
            frmSettings.Show();
        }

        private void frmAutomaticSanctions_Load(object sender, EventArgs e)
        {
            DontDestroy.UI.DisplayLayout(this);


            ArrayList arr = AutomaticSanctionDA.GetSettings();

            ArrayList rowOne = (ArrayList)arr[0];
            txtAantalTeLaatOne.Text = rowOne[0].ToString();
            txtSoortOne.Text = rowOne[1].ToString();
            chkStatusOne.Checked = (int)rowOne[2] == 1;

            ArrayList rowTwo = (ArrayList)arr[1];
            txtAantalTeLaatTwo.Text = rowTwo[0].ToString();
            txtSoortTwo.Text = rowTwo[1].ToString();
            chkStatusTwo.Checked = (int)rowTwo[2] == 1;

            ArrayList rowThree = (ArrayList)arr[2];
            txtAantalTeLaatThree.Text = rowThree[0].ToString();
            txtSoortThree.Text = rowThree[1].ToString();
            chkStatusThree.Checked = (int)rowThree[2] == 1;
        }

        private void frmAutomaticSanctions_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string inputMessage = "Vul de drempelwaarde voor het resetten van het aantal keren dat studenten " +
                "te laat zijn geweest in (Gelijk aan of lager wordt gereset naar 0):";
            string inputResult = Interaction.InputBox(inputMessage);

            int input;
            if (int.TryParse(inputResult, out input))
            {
                string confirmMessage = "Weet je zeker dat je het aantal keren dat studenten te laat zijn geweest " +
                    "wilt resetten voor studenten die minder dan of gelijk aan " + input.ToString() + " keer te laat zijn geweest?";
                DialogResult confirmResult = MessageBox.Show(confirmMessage, "btnResetDeels", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    LateCounterDA.ResetCount(input);
                    MessageBox.Show("Het aantal keren dat studenten te laat zijn geweest is gereset voor studenten die " +
                        "minder dan of gelijk aan " + input.ToString() + " keer te laat zijn geweest.");
                }
                else
                {
                    MessageBox.Show("Reset geannuleerd.");
                }
            }
            else
            {
                MessageBox.Show("Ongeldige invoer. Het aantal keren dat studenten te laat zijn geweest is niet gereset.");
            }
        }

        private void btnOpslaan_Secondary_Click(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList();

            arr.Add(new ArrayList() { 0, txtAantalTeLaatOne.Text, txtSoortOne.Text, chkStatusOne.Checked });
            arr.Add(new ArrayList() { 1, txtAantalTeLaatTwo.Text, txtSoortTwo.Text, chkStatusTwo.Checked });
            arr.Add(new ArrayList() { 2, txtAantalTeLaatThree.Text, txtSoortThree.Text, chkStatusThree.Checked });

            AutomaticSanctionDA.SaveSettings(arr);
        }

        private void btnResetAlles_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ben je zeker dat je de telling wilt resetten van iedereen?", "Ben je zeker dat je de telling wilt resetten van iedereen?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            if (dialogResult == DialogResult.Yes) {
                LateCounterDA.ResetCount(9999);
                MessageBox.Show("Alles is verwijderd.");
            }
            else
            {
                MessageBox.Show("Reset geannuleerd.");
            }
        }
    }
}
