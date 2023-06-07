using Microsoft.VisualBasic;
using System;
using System.Collections;
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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    public partial class frmModifyLate : Form
    {
        bool isValid;
        bool isCustom;
        Reason ReasonCollect;
        string CustomReasonText = "";
        int LateID = -1;

        Late oldLate;

        private frmLatesList parentForm;

        public frmModifyLate(Late late, frmLatesList parentForm)
        {
            InitializeComponent();

            this.parentForm = parentForm;

            LateID = late.LateID;
            oldLate = late;
            DontDestroy.UI.DisplayLayout(this);

            LoadReasons();
            lblLateName.Text = late.Name + " " + late.Surname;
        }
        
        private void LoadReasons()
        {
            lstbReden.Items.Clear();
            lstbZonderReden.Items.Clear();

            lstbReden.DisplayMember = "ReasonText";
            lstbZonderReden.DisplayMember = "ReasonText";

            List<Reason> reasons = ReasonDA.GetReasons();
            for (int i = 0; i < reasons.Count; i++)
            {
                if (reasons[i].IsValid && (!reasons[i].IsCustom))
                {
                    lstbReden.Items.Add(reasons[i]);
                }
                else if (!reasons[i].IsCustom)
                {
                    lstbZonderReden.Items.Add(reasons[i]);
                }
            }
        }

        private void lstbReden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbReden.SelectedIndex == -1) { return; }
            lstbZonderReden.SelectedIndex = -1;
            isValid = true;
            isCustom = false;
            ReasonCollect = ((Reason)lstbReden.SelectedItem);
        }

        private void btnAndereGeldig_Click(object sender, EventArgs e)
        {
            isValid = true;
            isCustom = true;
            lstbReden.SelectedIndex = -1;
            lstbZonderReden.SelectedIndex = -1;
            CustomReasonText = Interaction.InputBox("Geldige Reden: ");
            grpReason.Text = "Geldige Reden: " + CustomReasonText;
        }

        private void btnAndereNietGeldig_Click(object sender, EventArgs e)
        {
            isValid = false;
            isCustom = true;
            lstbReden.SelectedIndex = -1;
            lstbZonderReden.SelectedIndex = -1;
            CustomReasonText = Interaction.InputBox("Ongeldige Reden: ");
            grpReason.Text = "Ongeldige Reden: " + CustomReasonText;
        }

        private void lstbZonderReden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbZonderReden.SelectedIndex == -1) { return; }
            lstbReden.SelectedIndex = -1;
            isValid = false;
            isCustom = false;
            ReasonCollect = ((Reason)lstbZonderReden.SelectedItem);
        }

        private void btnOpslaan_Secondary_Click(object sender, EventArgs e)
        {
            //TWO OPTIONS TO ACCOUNT FOR:

            //BEFORE: NOT VALID, AFTER: VALID
            if (oldLate.ReasonIsValid && !isValid)
            {
                //Console.WriteLine("Increase + Try Add Sanction");
                //Increase + Try Add Sanction
                string studentCardUID = oldLate.CardUID;
                Student student = new Student();
                student.CardUID = studentCardUID;

                LateCounterDA.IncreaseCount(student);

                //Check if automatic sanctions need to be added
                ArrayList automaticArray = AutomaticSanctionDA.GetSettings();
                ArrayList lateCountResult = LateCounterDA.Find(student);
                if ((bool)lateCountResult[0])
                {
                    for (int i = 0; i < automaticArray.Count; i++)
                    {
                        int frequency = (int)((ArrayList)automaticArray[i])[0];
                        int status = (int)((ArrayList)automaticArray[i])[2];
                        string sanctionType = (string)((ArrayList)automaticArray[i])[1];
                        if ((Convert.ToInt32(lateCountResult[2])) == frequency && status == 1)
                        {
                            //Add Sanction
                            Sanction newSanction = new Sanction();
                            newSanction.CardUID = studentCardUID;
                            newSanction.Soort = sanctionType;
                            newSanction.SanctionDatum = DateTime.Now;
                            newSanction.InitLateID = oldLate.LateID;
                            SanctionDA.UploadSanction(newSanction);
                            MessageBox.Show("( " + sanctionType + " ) Deze student zal een sanctie krijgen aangezien er geen geldige reden is. bij deze te laat regel.");
                        }
                    }
                }
            }

            //BEFORE: VALID, AFTER: NOT VALID
            if (!oldLate.ReasonIsValid && isValid)
            {
                //Console.WriteLine("Decrease + Try Remove Sanction");
                //Decrease + Try Remove Sanction

                Late late = new Late();
                late.LateID = LateID;
                //DELETE from Sanctions Based ON initLateID = LateID
                SanctionDA.DeleteSanctionBasedOnLateInitID(late);
                string studentCardUID = oldLate.CardUID;
                Student student = new Student();
                student.CardUID = studentCardUID;

                LateCounterDA.DecreaseCount(student);

            }

            if (isCustom)
            {
                //Check If Reason Exists...
                //Check If Reason Exists...
                //Check If Reason Exists...
                Reason customReason = new Reason();
                customReason.ReasonText = CustomReasonText;
                customReason.IsValid = isValid;

             
                customReason.IsCustom = true;
                int Check_ReasonID = ReasonDA.GetCustomReasonIDByTextAndIsValid(customReason);

                if (Check_ReasonID == -1)
                {
                    ReasonDA.UploadReason(customReason);

                    List<Reason> reasons = ReasonDA.GetReasons();

                    foreach (Reason reason in reasons)
                    {
                        if (reason.ReasonText == CustomReasonText && reason.IsCustom)
                        {

                            Late late = new Late();
                            late.LateID = LateID;
                            late.ReasonID = reason.ReasonID;
                            LateDA.UpdateLateReasonID(late);
                        }
                    }


                    ReasonCollect = customReason;
                }
                else
                {
                    customReason.ReasonID = Check_ReasonID;
                    Late late = new Late();
                    late.LateID = LateID;
                    late.ReasonID = Check_ReasonID;
                    LateDA.UpdateLateReasonID(late);
                }
            }
            else
            {
                Late late = new Late();
                late.LateID = LateID;
                late.ReasonID = ReasonCollect.ReasonID;
                LateDA.UpdateLateReasonID(late);
            }



            this.parentForm.LoadFilters();
            this.parentForm.LoadListView();
            this.Close();
        }

        private void frmModifyLate_Load(object sender, EventArgs e)
        {

        }

        private void frmModifyLate_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();

        }
    }
}
