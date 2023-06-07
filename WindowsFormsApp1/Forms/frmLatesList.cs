using Ganss.Excel;
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
using WindowsFormsApp1.Model;

using WindowsFormsApp1.Helper;
using NPOI.SS.Formula.Functions;


namespace WindowsFormsApp1.Forms
{
    public partial class frmLatesList : Form
    {
        public string studentName;
        public string Surname;
        public string ClassName;
        public string ClassDegree;
        public string TownshipNameOne;
        public string TownshipNameTwo;
        public string ReasonText;
        public string isValid;
        public string isCustom;
        public string Time;
        public string Date;

        public string _PullLimit;


        public frmLatesList()
        {
            InitializeComponent();
            DontDestroy.UI.DisplayLayout(this);

            MainListView.Columns[0].Width = 0;
            MainListView.Columns[1].Width = 0;
            MainListView.Columns[6].Width = 150;
            MainListView.Columns[7].Width = 150;

            _PullLimit = "50";
            txtLimit.Text = "50";

            dateTimePickerFrom.Value = DateTime.Today;
            dateTimePickerTo.Value = DateTime.Today.AddDays(1);

            LoadFilters();
            LoadListView();

        }

        private void btn_frmLatesList_Close_frmMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.Show();
        }


        private void frmLatesList_Load(object sender, EventArgs e)
        {

        }

        public void LoadListView()
        {
            MainListView.Items.Clear();

            int PullLimit = 10;
            try
            {
                PullLimit = Convert.ToInt32(_PullLimit);
            }
            catch
            {
                //ERROR
            }

            //FROM DATES TO DATES
            string FromDate = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
            string ToDate = dateTimePickerTo.Value.ToString("yyyy-MM-dd");
            List<Late> lates = LateDA.GetLatesBasedOnSearch(studentName, Surname, ClassName, ClassDegree, TownshipNameOne, TownshipNameTwo, ReasonText, isCustom, isValid, FromDate, ToDate, PullLimit);
            foreach (Late late in lates)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = late.LateID.ToString();
                listViewItem.SubItems.Add(late.CardUID.ToString());
                listViewItem.SubItems.Add(late.Name.ToString());
                listViewItem.SubItems.Add(late.Surname.ToString());
                listViewItem.SubItems.Add(late.ClassName.ToString());

                if (late.ClassName.StartsWith("1") || late.ClassName.StartsWith("2"))
                {
                    listViewItem.SubItems.Add("1");
                }
                else if (late.ClassName.StartsWith("3") || late.ClassName.StartsWith("4"))
                {
                    listViewItem.SubItems.Add("2");
                }
                else if (late.ClassName.StartsWith("5") || late.ClassName.StartsWith("6") || late.ClassName.StartsWith("7"))
                {
                    listViewItem.SubItems.Add("3");
                }
                listViewItem.SubItems.Add(late.TownshipNameOne.ToString());
                listViewItem.SubItems.Add(late.TownshipNameTwo.ToString());

                if (late.ReasonIsCustom)
                {
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add(late.ReasonText);
                }
                else
                {
                    listViewItem.SubItems.Add(late.ReasonText);
                    listViewItem.SubItems.Add("");
                }

                //listViewItem.SubItems.Add(.ToString());

                if (late.ReasonIsValid)
                {
                    listViewItem.SubItems.Add("Ja");
                }
                else
                {
                    listViewItem.SubItems.Add("Nee");
                }

                listViewItem.SubItems.Add(late.LateDate.ToString("dd/MM/yyyy"));
                MainListView.Items.Add(listViewItem);
            }

        }

        private void tmrResetListView_Tick(object sender, EventArgs e)
        {
            MainListView.Columns[0].Width = 0;
            MainListView.Columns[1].Width = 0;
        }

        private void btn_frmLateList_AddLate_Click(object sender, EventArgs e)
        {
        }

        private void btn_frmLateList_RemoveLate_Click(object sender, EventArgs e)
        {
            List<Late> latesList = new List<Late>();
            if (MainListView.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ben je zeker dat je: " + MainListView.SelectedItems.Count + " record(s) wilt verwijderen?", "Items Deleten", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = MainListView.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        int ID = Convert.ToInt32(MainListView.SelectedItems[i].Text);

                        Late late = new Late();
                        late.LateID = ID;
                        //DELETE from Sanctions Based ON initLateID = LateID
                        SanctionDA.DeleteSanctionBasedOnLateInitID(late);
                        string studentCardUID = MainListView.SelectedItems[i].SubItems[1].Text;
                        Student student = new Student();
                        student.CardUID = studentCardUID;
                        LateCounterDA.DecreaseCount(student);

                        latesList.Add(late);
                        MainListView.SelectedItems[i].Remove();
                    }

                    LateDA.RemoveLate(latesList);
                }
            }

        }

        private void btn_frmLateList_Search_Click(object sender, EventArgs e)
        {
            LoadListView();
            LoadFilters();
        }

        public void LoadFilters()
        {
            cmbClassName.Items.Clear();
            cmbTownshipNameOne.Items.Clear();
            cmbTownshipNameTwo.Items.Clear();

            ArrayList arr = StudentDA.GetFilters();

            List<string> ClassNames = ((List<string>)arr[0]);
            List<string> TownshipNamesOne = ((List<string>)arr[1]);
            List<string> TownshipNamesTwo = ((List<string>)arr[2]);

            for (int i = 0; i < ClassNames.Count; i++)
            {
                cmbClassName.Items.Add(ClassNames[i]);
            }

            for (int i = 0; i < TownshipNamesOne.Count; i++)
            {
                cmbTownshipNameOne.Items.Add(TownshipNamesOne[i]);
            }

            for (int i = 0; i < TownshipNamesTwo.Count; i++)
            {
                cmbTownshipNameTwo.Items.Add(TownshipNamesTwo[i]);
            }

        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {
            studentName = txtName.Text;
            txtLimit.Text = "50";
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            Surname = txtSurname.Text;
            txtLimit.Text = "50";

        }

        private void cmbClassName_TextChanged(object sender, EventArgs e)
        {
            ClassName = cmbClassName.Text;
            txtLimit.Text = "50";

        }

        private void cmbClassDegree_TextChanged(object sender, EventArgs e)
        {
            ClassDegree = cmbClassDegree.Text;
            txtLimit.Text = "50";

        }

        private void cmbTownshipName_TextChanged(object sender, EventArgs e)
        {
            TownshipNameOne = cmbTownshipNameOne.Text;
            txtLimit.Text = "50";

        }

        private void cmbReason_TextChanged(object sender, EventArgs e)
        {
            ReasonText = cmbReason.Text;
            cmbCustomReason.SelectedIndex = -1;
            isCustom = "False";

            if (cmbReason.Text.Length == 0)
            {
                isCustom = null;
            }

            txtLimit.Text = "50";

        }

        private void cmbCustomReason_TextChanged(object sender, EventArgs e)
        {
            ReasonText = cmbCustomReason.Text;
            cmbReason.SelectedIndex = -1;
            isCustom = "True";

            if (cmbCustomReason.Text.Length == 0)
            {
                isCustom = null;
            }
            txtLimit.Text = "50";

        }

        private void cmbIsValid_TextChanged(object sender, EventArgs e)
        {
            isValid = cmbIsValid.Text;
            txtLimit.Text = "50";

        }

        private void cmbTime_TextChanged(object sender, EventArgs e)
        {
            txtLimit.Text = "50";

        }

        private void cmbDate_TextChanged(object sender, EventArgs e)
        {
            txtLimit.Text = "50";
        }

        private void txtLimit_TextChanged(object sender, EventArgs e)
        {
            _PullLimit = txtLimit.Text;


        }

        private void cmbReason_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainListView.SelectedItems.Count < 10)
                {
                    DialogResult res = MessageBox.Show("Je hebt minder dan 10 lates geselecteerd, bent u zeker dat u wilt exporteren", "Confirmation", MessageBoxButtons.YesNo);

                    if (res != DialogResult.Yes)
                    {
                        return;
                    }
                }

                List<LateExport> exportList = new List<LateExport>();


                for (int i = 0; i < MainListView.SelectedItems.Count; i++)
                {
                    ListViewItem currentListViewItem = MainListView.SelectedItems[i];
                    string ID = (currentListViewItem.Text);
                    string Name = (currentListViewItem.SubItems[2].Text);
                    string Surname = (currentListViewItem.SubItems[3].Text);
                    string ClassName = (currentListViewItem.SubItems[4].Text);
                    string ClassDegree = (currentListViewItem.SubItems[5].Text);
                    string TownshipName = (currentListViewItem.SubItems[6].Text);
                    string ReasonText = (currentListViewItem.SubItems[7].Text);
                    string OtherReason = (currentListViewItem.SubItems[8].Text);
                    string IsValid = (currentListViewItem.SubItems[9].Text);
                    string Time = (currentListViewItem.SubItems[10].Text);
                    string Date = (currentListViewItem.SubItems[11].Text);

                    LateExport late = new LateExport(
                           ID,
                           Name,
                           Surname,
                           ClassName,
                           ClassDegree,
                           TownshipName,
                           ReasonText,
                           OtherReason,
                           IsValid,
                           Time,
                           Date
                       );


                    exportList.Add(late);
                }

                ExcelMapper mapper = new ExcelMapper();

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel Sheet |*.xlsx";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();

                string filelocation = saveFileDialog1.FileName;

                Console.WriteLine(exportList.Count);

                //mapper.DataFormatter.FormatCellValue(NPOI.SS.UserModel.type);

                mapper.Save(filelocation, exportList, "SheetName", true);
            }
            catch
            {

            }
        }

        private void frmLatesList_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();
        }

        private void btnModify_Secondary_Click(object sender, EventArgs e)
        {
            //Show Modify Form



            for (int i = 0; i < MainListView.SelectedItems.Count; i++)
            {
                int LateID = Convert.ToInt32(MainListView.SelectedItems[i].SubItems[0].Text);

                Late late = new Late();
                late.LateID = LateID;
                late.Name = MainListView.SelectedItems[i].SubItems[2].Text;
                late.Surname = MainListView.SelectedItems[i].SubItems[3].Text;
                late.CardUID = MainListView.SelectedItems[i].SubItems[1].Text;
                if (MainListView.SelectedItems[i].SubItems[10].Text == "Ja")
                {
                    late.ReasonIsValid = true;
                }
                else
                {
                    late.ReasonIsValid = false;
                }
                frmModifyLate frm = new frmModifyLate(late, this);
                frm.Show();
            }
        }
    }
}
