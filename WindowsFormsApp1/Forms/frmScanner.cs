using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.DA;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Helper;
using System.Collections;

namespace WindowsFormsApp1.Forms
{
    public partial class frmScanner : Form
    {
        DateTime dateTime;
        public Student SelectedStudent;
        public string Selected;
        public string CustomReason;
        bool isValidA = false;
        bool isTheLateValid = false;

        ArrayList lastResult = null;
        ArrayList AutomaticArray = null;

        bool notified = false;

        public bool timeout = false;
        public string CurrentCardUID;

        public frmScanner()
        {
            InitializeComponent();
            DontDestroy.UI.DisplayLayout(this);

            lblName.Text = "";
            lblLastName.Text = "";
            lblKlas.Text = "";
            lblTownshipOne.Text = "";
            lblTownshipTwo.Text = "";

            ViewModelLatesHistory.Items.Clear();
            btnCancel_Secondary.Hide();

            LoadReasons();
        }

        public frmScanner(Student student)
        {
            InitializeComponent();
            DontDestroy.UI.DisplayLayout(this);

            lblName.Text = "";
            lblLastName.Text = "";
            lblKlas.Text = "";
            lblTownshipOne.Text = "";
            lblTownshipTwo.Text = "";

            Console.WriteLine(student.CardUID);
            FillData(student);
            SetLateHistory(student);
            SelectedStudent = student;
            LoadReasons();
        }


        private void SetLateHistory(Student student)
        {
            ViewModelLatesHistory.Items.Clear();
            btnCancel_Secondary.Show();

            Console.WriteLine("Getting lates...");
            List<Late> lates = StudentDA.GetLatesFromStudent(student);

            Console.WriteLine(student.CardUID);
            Console.WriteLine(lates.Count);

            foreach (Late late in lates)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = late.LateID.ToString();
                listViewItem.SubItems.Add("");

                if (late.ReasonIsCustom)
                {
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add(late.ReasonText.ToString());
                }
                else
                {
                    listViewItem.SubItems.Add(late.ReasonText.ToString());
                    listViewItem.SubItems.Add("");
                }

                if (late.ReasonIsValid)
                {
                    listViewItem.SubItems.Add("Ja");
                }
                else
                {
                    listViewItem.SubItems.Add("Nee");
                }

                listViewItem.SubItems.Add(late.LateDate.ToString("HH:mm"));
                listViewItem.SubItems.Add(late.LateDate.ToString("dd/MM/yyyy"));

                ViewModelLatesHistory.Items.Add(listViewItem);
            }
        }

        private void lstbReden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedStudent == null) { lstbReden.SelectedIndex = -1; return; }
            if (lstbReden.SelectedIndex == -1) { return; }
            lstbZonderReden.SelectedIndex = -1;
            dateTime = DateAndTime.Now;

            if (Selected == null)
            {
                //NEW
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = "(Not Confirmed)";
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(((Reason)lstbReden.SelectedItem).ReasonText + "*");
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add("Ja");
                listViewItem.SubItems.Add(DontDestroy.GetTime(dateTime));
                listViewItem.SubItems.Add(DontDestroy.GetDate(dateTime));
                ViewModelLatesHistory.Items.Add(listViewItem);
            }
            else
            {
                //REMOVE NEW
                ViewModelLatesHistory.Items.RemoveAt(ViewModelLatesHistory.Items.Count - 1);
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = "???";
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(((Reason)lstbReden.SelectedItem).ReasonText + "*");
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add("Ja");
                listViewItem.SubItems.Add(DontDestroy.GetTime(dateTime));
                listViewItem.SubItems.Add(DontDestroy.GetDate(dateTime));
                ViewModelLatesHistory.Items.Add(listViewItem);
            }

            Selected = "reden";

            //DialogResult dialogResult = MessageBox.Show("Krijgt de student werkstudie? (" + lstbReden.Items[lstbReden.SelectedIndex] + ")", "Werkstudie", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
            //Console.WriteLine(dialogResult);
            grpReason.Text = "Reden - " + ((Reason)lstbReden.SelectedItem).ReasonText + "*";

            //ADD REASON
            isTheLateValid = true;
        }

        private void lstbZonderReden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedStudent == null) { lstbZonderReden.SelectedIndex = -1; return; }

            if (lstbZonderReden.SelectedIndex == -1) { return; }
            lstbReden.SelectedIndex = -1;
            dateTime = DateAndTime.Now;

            if (Selected == null)
            {
                //NEW
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = "???";
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(((Reason)lstbZonderReden.SelectedItem).ReasonText + "*");
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add("Nee");
                listViewItem.SubItems.Add(DontDestroy.GetTime(dateTime));
                listViewItem.SubItems.Add(DontDestroy.GetDate(dateTime));
                ViewModelLatesHistory.Items.Add(listViewItem);
            }
            else
            {
                //REMOVE NEW
                ViewModelLatesHistory.Items.RemoveAt(ViewModelLatesHistory.Items.Count - 1);
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = "???";
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(((Reason)lstbZonderReden.SelectedItem).ReasonText + "*");
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add("Nee");
                listViewItem.SubItems.Add(DontDestroy.GetTime(dateTime));
                listViewItem.SubItems.Add(DontDestroy.GetDate(dateTime));
                ViewModelLatesHistory.Items.Add(listViewItem);
            }

            Selected = "zonderReden";

            //DialogResult dialogResult = MessageBox.Show("Krijgt de student werkstudie? (" + lstbZonderReden.Items[lstbZonderReden.SelectedIndex] + ")", "Werkstudie", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
            //Console.WriteLine(dialogResult);
            grpReason.Text = "Reden - " + ((Reason)lstbZonderReden.SelectedItem).ReasonText + "*";

            isTheLateValid = false;
        }


        private void btn_frmScanner_Open_frmStudentsList_Click(object sender, EventArgs e)
        {
            frmStudentsList frmStudentsList = new frmStudentsList();
            this.Close();
            frmStudentsList.Show();
        }

        private void btnAndereGeldig_Click(object sender, EventArgs e)
        {
            if (SelectedStudent == null) { return; }
            isValidA = true;
            isTheLateValid = true;
            lstbReden.SelectedIndex = -1;
            lstbZonderReden.SelectedIndex = -1;

            CustomReason = Interaction.InputBox("Geldige Reden: ");

            grpReason.Text = "Reden - Geldig: " + CustomReason + "*";
            dateTime = DateAndTime.Now;

            if (Selected == null)
            {
                //NEW
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = "???";
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(CustomReason + "*");
                listViewItem.SubItems.Add("Ja");
                listViewItem.SubItems.Add(DontDestroy.GetTime(dateTime));
                listViewItem.SubItems.Add(DontDestroy.GetDate(dateTime));
                ViewModelLatesHistory.Items.Add(listViewItem);
            }
            else
            {
                //REMOVE NEW
                ViewModelLatesHistory.Items.RemoveAt(ViewModelLatesHistory.Items.Count - 1);
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = "???";
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(CustomReason + "*");
                listViewItem.SubItems.Add("Ja");
                listViewItem.SubItems.Add(DontDestroy.GetTime(dateTime));
                listViewItem.SubItems.Add(DontDestroy.GetDate(dateTime));
                ViewModelLatesHistory.Items.Add(listViewItem);
            }

            Selected = "redenAndere";
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
        private void ClearData()
        {
            btnCancel_Secondary.Hide();
            lstbReden.ClearSelected();
            lstbZonderReden.ClearSelected();
            grpReason.Text = "Reden";
            lblName.Text = "";
            lblLastName.Text = "";
            lblKlas.Text = "";
            lblTownshipOne.Text = "";
            lblTownshipTwo.Text = "";
            Selected = null;
            ViewModelLatesHistory.Items.Clear();
            SelectedStudent = null;
        }
        
        private void btnAndereNietGeldig_Click(object sender, EventArgs e)
        {
            if (SelectedStudent == null) { return; }
            isValidA = false;
            isTheLateValid = false;
            lstbReden.SelectedIndex = -1;
            lstbZonderReden.SelectedIndex = -1;


            CustomReason = Interaction.InputBox("Niet Geldig: ");
            CustomReason = CustomReason.Trim();


            string newWordWithoutSpaces = "";
            for (int i = 0; i < CustomReason.Length; i++)
            {
                char currentChar = CustomReason[i];

                if (i >= 1)
                {
                    char lastChar = CustomReason[i - 1];

                    if (lastChar == ' ' && currentChar == ' ')
                    {
                        //don't do anything
                    }
                    else
                    {
                        newWordWithoutSpaces += currentChar;
                    }

                    lastChar = currentChar;
                }
                else
                {
                    newWordWithoutSpaces += currentChar;
                }

            }
            //Console.WriteLine(newWordWithoutSpaces);
            CustomReason = newWordWithoutSpaces;
            grpReason.Text = "Reden - Niet Geldig: " + CustomReason + "*";
            dateTime = DateAndTime.Now;

            if (Selected == null)
            {
                //NEW
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = "???";
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(CustomReason + "*");
                listViewItem.SubItems.Add("Nee");
                listViewItem.SubItems.Add(DontDestroy.GetTime(dateTime));
                listViewItem.SubItems.Add(DontDestroy.GetDate(dateTime));
                ViewModelLatesHistory.Items.Add(listViewItem);
            }
            else
            {
                //REMOVE NEW
                ViewModelLatesHistory.Items.RemoveAt(ViewModelLatesHistory.Items.Count - 1);
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = "???";
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(CustomReason + "*");
                listViewItem.SubItems.Add("Nee");
                listViewItem.SubItems.Add(DontDestroy.GetTime(dateTime));
                listViewItem.SubItems.Add(DontDestroy.GetDate(dateTime));
                ViewModelLatesHistory.Items.Add(listViewItem);
            }

            Selected = "zonderRedenAndere";
        }

        private void tmrResetListView_Tick(object sender, EventArgs e)
        {
            ViewModelLatesHistory.Columns[0].Width = 0;
            ViewModelLatesHistory.Columns[1].Width = 0;
        }

        private void tmrScan_Tick(object sender, EventArgs e)
        {
            if (SelectedStudent != null) { return; }
            if (notified) { notified = false; }
            CurrentCardUID = DontDestroy.GetUID();
            if (CurrentCardUID == null) { return; }
            if (timeout == false && CurrentCardUID.Length == "000000000000000000".Length)
            {
                Student student = StudentDA.GetStudentFromCardUID(CurrentCardUID);
                if (student != null)
                {
                    SelectedStudent = student;
                    FillData(student);
                    SetLateHistory(student);
                }

                timeout = true;
            }
        }

        private void FillData(Student student)
        {
            lblName.Text = student.Name;
            lblLastName.Text =  student.Surname;
            lblKlas.Text = student.ClassName;
            lblTownshipOne.Text = student.TownshipNameOne;
            lblTownshipTwo.Text = student.TownshipNameTwo;
        }

        private void resetTimeout_Tick(object sender, EventArgs e)
        {
            timeout = false;
        }

        private void btn_frmScanner_Annuleren_Click(object sender, EventArgs e)
        {
            ClearData();
            txtAutoScanTwo.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Hide();
            frm.Show();
        }

        private void btnOpenStudentList_Click(object sender, EventArgs e)
        {
            frmStudentsList frm = new frmStudentsList();
            this.Hide();
            frm.Show();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if (SelectedStudent != null)
            {
                int ReasonID = -1;
                if (Selected == "reden")
                {
                    ReasonID = ((Reason)(lstbReden.SelectedItem)).ReasonID;
                }
                else if (Selected == "zonderReden")
                {
                    ReasonID = ((Reason)(lstbZonderReden.SelectedItem)).ReasonID;
                }
                else if (CustomReason != null)
                {
                    //Check If Reason Exists...

                    Reason customReason = new Reason();
                    customReason.ReasonText = CustomReason;
                    customReason.IsValid = isValidA;
                    int Check_ReasonID = ReasonDA.GetCustomReasonIDByTextAndIsValid(customReason);

                   

                    if (Check_ReasonID == -1)
                    {
                        if (Selected == "redenAndere")
                        {
                            customReason.IsCustom = true;
                            ReasonDA.UploadReason(customReason);
                        }
                        else
                        {
                            customReason.IsCustom = true;
                            ReasonDA.UploadReason(customReason);
                        }

                        List<Reason> reasons = ReasonDA.GetReasons();

                        foreach (Reason reason in reasons)
                        {
                            if (reason.ReasonText == CustomReason && reason.IsCustom)
                            {
                                ReasonID = reason.ReasonID;
                            }
                        }
                    }
                    else
                    {
                        ReasonID = Check_ReasonID;
                    }

                }
                else
                {
                    return;
                }



                //Creating Late
                Late late = new Late();
                late.CardUID = SelectedStudent.CardUID;
                late.ReasonID = ReasonID;
                late.LateDate = dateTime;
                LateDA.UploadLate(late);




                if (lastResult != null)
                {
                    if (!isTheLateValid)
                    {
                        if ((bool)lastResult[0])
                        {
                            LateCounterDA.IncreaseCount(SelectedStudent);


                            for (int i = 0; i < AutomaticArray.Count; i++)
                            {
                                int frequency = (int)((ArrayList)AutomaticArray[i])[0];
                                int Status = (int)((ArrayList)AutomaticArray[i])[2];
                                if ((Convert.ToInt32(lastResult[2]) + 1) == frequency && Status == 1)
                                {
                                    Console.WriteLine("Sanction!!!");
                                    ArrayList result = LateDA.GetLatestLateID(late);
                                    for (int x = 0; x < result.Count; x++)
                                    {
                                        Console.WriteLine("Result[" + x + "]: " + result[x]);
                                    }

                                    if ((bool)result[0])
                                    {
                                        int lateID = (int)result[1];
                                        Sanction sanction = new Sanction();
                                        sanction.CardUID = SelectedStudent.CardUID;
                                        sanction.Soort = ((ArrayList)AutomaticArray[i])[1].ToString();
                                        sanction.SanctionDatum = dateTime;
                                        sanction.InitLateID = lateID;
                                        Console.WriteLine(SelectedStudent.CardUID);
                                        Console.WriteLine(((ArrayList)AutomaticArray[i])[1].ToString());
                                        Console.WriteLine(dateTime);
                                        SanctionDA.UploadSanction(sanction);
                                    }


                                }
                            }

                            ArrayList lastElementWithStatus1 = null;
                            for (int i = AutomaticArray.Count - 1; i >= 0; i--)
                            {
                                int status = (int)((ArrayList)AutomaticArray[i])[2];
                                if (status == 1)
                                {
                                    lastElementWithStatus1 = (ArrayList)AutomaticArray[i];
                                    break;
                                }
                            }

                            if (lastElementWithStatus1 != null)
                            {
                                int lastElementFrequency = (int)lastElementWithStatus1[0];
                                if ((Convert.ToInt32(lastResult[2]) + 1) == lastElementFrequency)
                                {
                                    // Currently Hit Highest Count, Resetting...
                                    Student student = new Student();
                                    student.CardUID = SelectedStudent.CardUID;
                                    LateCounterDA.ResetCountFromStudent(student);
                                }
                            }

                        }
                        else
                        {
                            LateCounterDA.CreateCount(SelectedStudent);
                        }
                    }
                }


                SetLateHistory(SelectedStudent);

                ClearData();
                txtAutoScanTwo.Clear();
                txtAutoScanTwo.Focus();
            }
        }

        private void frmScanner_Load(object sender, EventArgs e)
        {

        }

        private void frmScanner_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();
        }

        private void tmrLetUserKnow_Tick(object sender, EventArgs e)
        {
            if (!notified && SelectedStudent != null)
            {
                notified = true;
                //Check If Person has been late... [True/False, ID, Amount Of Times]
                ArrayList Result = LateCounterDA.Find(SelectedStudent);
                lastResult = Result;
                AutomaticArray = AutomaticSanctionDA.GetSettings();


                if ((bool)Result[0])
                {
                    for (int i = 0; i < AutomaticArray.Count; i++)
                    {
                        int frequency = (int)((ArrayList)AutomaticArray[i])[0];
                        int Status = (int)((ArrayList)AutomaticArray[i])[2];
                        string Soort = (string)((ArrayList)AutomaticArray[i])[1];
                        if ((Convert.ToInt32(Result[2]) + 1) == frequency && Status == 1)
                        {
                            MessageBox.Show("( " + Soort + " ) Deze student zal een sanctie krijgen als er geen geldige reden is. Want hij is momenteel (" + (Convert.ToInt32(Result[2]).ToString() + " + Nu) --> " + (Convert.ToInt32(Result[2]) + 1).ToString() + " ongeldig keer te laat geweest."));
                        }
                    }
                    //Console.WriteLine(Result[2].ToString());
                }
            }
        }

        private void txtAutoScanTwo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Student student = StudentDA.GetStudentFromCardUID(txtAutoScanTwo.Text);
                if (student != null && timeout == false && SelectedStudent == null)
                {
                    Console.WriteLine(student.CardUID);
                    timeout = true;
                    SetLateHistory(student);
                    FillData(student);
                    SelectedStudent = student;
                }
            }
        }

        private void btnScanTwo_Secondary_Click(object sender, EventArgs e)
        {
            Student student = StudentDA.GetStudentFromCardUID(txtAutoScanTwo.Text);
            if (student != null && timeout == false && SelectedStudent == null)
            {
                Console.WriteLine(student.CardUID);
                timeout = true;
                SetLateHistory(student);
                FillData(student);
                SelectedStudent = student;
            }
        }
    }
}
