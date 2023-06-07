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
using WindowsFormsApp1.DA;
using WindowsFormsApp1.Model;
using Microsoft.VisualBasic;
using Ganss.Excel;
using System.Collections;

namespace WindowsFormsApp1.Forms
{
    public partial class frmSanctionsList : Form
    {
        public string studentName;
        public string Surname;
        public string Soort;
        public string ClassName;
        public string ClassDegree;
        public string DateFrom;
        public string DateTo;

        public string _PullLimit;
        public frmSanctionsList()
        {
            InitializeComponent();

            _PullLimit = "10";
            txtLimit.Text = "10";
        }

        public frmSanctionsList(Student student, string Soort)
        {
            InitializeComponent();

            _PullLimit = "10";
            txtLimit.Text = "10";

            string ID = student.CardUID;
            Sanction sanction = new Sanction();

            sanction.CardUID = ID;
            sanction.Soort = Soort;
            sanction.SanctionDatum = DateTime.Now;
            sanction.InitLateID = 0;
            SanctionDA.UploadSanction(sanction);
        }

        private void btn_frmSanctionList_Close_frmMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //NameId veranderen + MessageBox laten weten dat kleur van listview niet mee zal opgeslaan worden
            //NameId veranderen + MessageBox laten weten dat kleur van listview niet mee zal opgeslaan worden
            //NameId veranderen + MessageBox laten weten dat kleur van listview niet mee zal opgeslaan worden
            //NameId veranderen + MessageBox laten weten dat kleur van listview niet mee zal opgeslaan worden
        }

        private void frmSanctionList_Load(object sender, EventArgs e)
        {
            DontDestroy.UI.DisplayLayout(this);
            dateTimePickerFrom.Value = DateTime.Today;
            dateTimePickerTo.Value = DateTime.Today.AddDays(1);

            LoadListView();
            LoadFilters();
        }

        public void LoadFilters()
        {
            cmbSoort.Items.Clear();
            cmbClassName.Items.Clear();

            ArrayList arr = SanctionDA.GetFilters();

            List<string> Soorten = ((List<string>)arr[0]);
            List<string> ClassNames = ((List<string>)arr[1]);

            for (int i = 0; i < Soorten.Count; i++)
            {
                cmbSoort.Items.Add(Soorten[i]);
            }

            for (int i = 0; i < ClassNames.Count; i++)
            {
                cmbClassName.Items.Add(ClassNames[i]);
            }
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

            string FromDate = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
            string ToDate = dateTimePickerTo.Value.ToString("yyyy-MM-dd");
            List<Sanction> sanctions = SanctionDA.GetSanctionsBasedOnSearch(studentName, Surname, Soort, ClassName, ClassDegree, FromDate, ToDate, PullLimit);

            foreach (Sanction sanction in sanctions)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = sanction.SanctionID.ToString();
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(sanction.Name.ToString());
                listViewItem.SubItems.Add(sanction.Surname.ToString());
                listViewItem.SubItems.Add(sanction.Soort.ToString());
                listViewItem.SubItems.Add(sanction.ClassName.ToString());

                if (sanction.ClassName.StartsWith("1") || sanction.ClassName.StartsWith("2"))
                {
                    listViewItem.SubItems.Add("1");
                }
                else if (sanction.ClassName.StartsWith("3") || sanction.ClassName.StartsWith("4"))
                {
                    listViewItem.SubItems.Add("2");
                }
                else if (sanction.ClassName.StartsWith("5") || sanction.ClassName.StartsWith("6") || sanction.ClassName.StartsWith("7"))
                {
                    listViewItem.SubItems.Add("3");
                }
                listViewItem.SubItems.Add(sanction.SanctionDatum.ToString("dd/MM/yyyy"));
                //listViewItem.SubItems.Add(sanction.InitLateID.ToString());




                MainListView.Items.Add(listViewItem);
            }

        }

        private void frmSanctionsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            studentName = txtName.Text; 
        }

        private void txtLimit_TextChanged(object sender, EventArgs e)
        {
            _PullLimit = txtLimit.Text;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            Surname = txtSurname.Text;
        }

        private void cmbSoort_TextChanged(object sender, EventArgs e)
        {
            Soort = cmbSoort.Text;
        }

        private void cmbClassName_TextChanged(object sender, EventArgs e)
        {
            ClassName = cmbClassName.Text;
        }

        private void cmbDegree_TextChanged(object sender, EventArgs e)
        {
            ClassDegree = cmbDegree.Text;
        }



        private void btnLateListSearch_Secondary_Click(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void btnRemoveSanction_Secondary_Click(object sender, EventArgs e)
        {
            List<Sanction> sanctionList = new List<Sanction>();
            if (MainListView.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ben je zeker dat je: " + MainListView.SelectedItems.Count + " record(s) wilt verwijderen?", "Items Deleten", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = MainListView.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        int ID = Convert.ToInt32(MainListView.SelectedItems[i].Text);
                        Sanction sanction = new Sanction();
                        sanction.SanctionID = ID;
                        sanctionList.Add(sanction);
                        MainListView.SelectedItems[i].Remove();
                    }

                    SanctionDA.RemoveLate(sanctionList);
                }
            }
        }

        private void btnOpenStudentList_Secondary_Click(object sender, EventArgs e)
        {
            frmStudentsList frm = new frmStudentsList();
            this.Hide();
            frm.Show();
        }

        private void btnExport_Secondary_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainListView.SelectedItems.Count < 10)
                {
                    DialogResult res = MessageBox.Show("Je hebt minder dan 10 records geselecteerd, bent u zeker dat u wilt exporteren", "Confirmation", MessageBoxButtons.YesNo);

                    if (res != DialogResult.Yes)
                    {
                        return;
                    }
                }

                List<SanctieExport> exportList = new List<SanctieExport>();


                for (int i = 0; i < MainListView.SelectedItems.Count; i++)
                {
                    ListViewItem currentListViewItem = MainListView.SelectedItems[i];
                    string ID = (currentListViewItem.Text);
                    string Name = (currentListViewItem.SubItems[2].Text);
                    string Surname = (currentListViewItem.SubItems[3].Text);
                    string Soort = (currentListViewItem.SubItems[4].Text);
                    string ClassName = (currentListViewItem.SubItems[5].Text);
                    string ClassDegree = (currentListViewItem.SubItems[6].Text);
                    string Date = (currentListViewItem.SubItems[7].Text);

                    SanctieExport sanction = new SanctieExport(
                           ID,
                           Name,
                           Surname,
                           Soort,
                           ClassName,
                           ClassDegree,
                           Date
                       );


                    exportList.Add(sanction);
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

        private void btnAanpassen_Secondary_Click(object sender, EventArgs e)
        {
            if (MainListView.SelectedItems.Count <= 0) { return; }
            int ID = Convert.ToInt32(MainListView.SelectedItems[0].Text);
            Sanction sanction = new Sanction();
            sanction.SanctionID = ID;
            string Firstname = MainListView.SelectedItems[0].SubItems[2].Text;
            string Lastname = MainListView.SelectedItems[0].SubItems[3].Text;

            string FullName = Firstname + " " + Lastname;

            try
            {
                frmSanctieSoort frmSanctieSoort = new frmSanctieSoort(FullName, sanction, this);
                frmSanctieSoort.Show();
            }
            catch
            {
                MessageBox.Show("Error, student is niet geldig!");
            }


            if (Soort == "")
                return;

            for (int i = MainListView.SelectedItems.Count - 1; i >= 0; i--)
            {
               

            }

        }

        private void txtDatumFrom_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtFromTo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
