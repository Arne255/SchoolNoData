using NPOI.Util;
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
using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1.Forms
{
    public partial class frmBulkImportExport : Form
    {
        public frmBulkImportExport()
        {
            InitializeComponent();
        }

        private void btn_Admin_frmBulkImportExport_Close_frmSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            this.Hide();
            frmSettings.Show();
        }

        private void frmBulkImportExport_Load(object sender, EventArgs e)
        {
            DontDestroy.UI.DisplayLayout(this);
        }

        private void btn_BulkImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog SelectFile = new OpenFileDialog();
            SelectFile.Filter = "CSV file |*.csv|txt files (*.txt)|*.txt";
            SelectFile.Title = "Upload .CSV file or .txt file";
            SelectFile.ShowDialog();

            try
            {
                MainListView.Items.Clear();

                string text = System.IO.File.ReadAllText(SelectFile.FileName);
                string[] lines = text.Split(Convert.ToChar("\n"));

                List<string> ClassNames = new List<string>();
                List<string> LastNames = new List<string>();
                List<string> FirstNames = new List<string>();
                List<string> TownshipNameOnes = new List<string>();
                List<string> TownshipNameTwos = new List<string>();
                List<string> CardUIDs = new List<string>();


                for (int i = 0; i < lines.Length; i++)
                {
                    string CurrentLine = lines[i];

                    char charBetweenVariables = ';';
                    string[] Klas_Naam_Voornaam_Gemeente_Badge = CurrentLine.Split(charBetweenVariables);
                    //Klas; Naam; Voornaam; Gemeente; Badge

                        if (Klas_Naam_Voornaam_Gemeente_Badge.Length == 5)
                        {
                            if (CardUIDs.Count >= 1 && CardUIDs[CardUIDs.Count - 1] == Klas_Naam_Voornaam_Gemeente_Badge[4])
                            {
                                //Add Gemeente To TownshipTwo
                                TownshipNameTwos[TownshipNameTwos.Count - 1] = (Klas_Naam_Voornaam_Gemeente_Badge[3]);
                                continue;
                            }
                            else
                            {
                                //Add Gemeente To TownshipTwo
                                TownshipNameTwos.Add("");
                            }

                            ClassNames.Add(Klas_Naam_Voornaam_Gemeente_Badge[0]);
                            LastNames.Add(Klas_Naam_Voornaam_Gemeente_Badge[1]);
                            FirstNames.Add(Klas_Naam_Voornaam_Gemeente_Badge[2]);
                            TownshipNameOnes.Add(Klas_Naam_Voornaam_Gemeente_Badge[3]);
                            CardUIDs.Add(Klas_Naam_Voornaam_Gemeente_Badge[4]);
                        }
                }

                for (int i = 0; i < ClassNames.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = CardUIDs[i];
                    listViewItem.SubItems.Add(LastNames[i]);
                    listViewItem.SubItems.Add(FirstNames[i]);
                    listViewItem.SubItems.Add(TownshipNameOnes[i]);
                    listViewItem.SubItems.Add(TownshipNameTwos[i]);
                    listViewItem.SubItems.Add(ClassNames[i]);

                    MainListView.Items.Add(listViewItem);
                }

                Console.WriteLine(ClassNames.Count.ToString());
                Console.WriteLine(TownshipNameOnes.Count.ToString());
                Console.WriteLine(TownshipNameTwos.Count.ToString());
                Console.WriteLine(CardUIDs.Count.ToString());
                MessageBox.Show("Succsefully imported " + CardUIDs.Count.ToString() + " students!");
            }
            catch{}
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            List<string> Badges = new List<string>();
            List<string> LastNames = new List<string>();
            List<string> FirstNames = new List<string>();
            List<string> TownshipNamesOnes = new List<string>();
            List<string> TownshipNamesTwos = new List<string>();
            List<string> ClassNames = new List<string>();

            for (int i = 0; i < MainListView.Items.Count; i++)
            {
                string badge = MainListView.Items[i].Text;
                string LastName = MainListView.Items[i].SubItems[1].Text;
                string FirstName = MainListView.Items[i].SubItems[2].Text;
                string TownshipNamesOne = MainListView.Items[i].SubItems[3].Text;
                string TownshipNamesTwo = MainListView.Items[i].SubItems[4].Text;
                string ClassName = MainListView.Items[i].SubItems[5].Text;

                Badges.Add(badge);
                LastNames.Add(LastName);
                FirstNames.Add(FirstName);
                TownshipNamesOnes.Add(TownshipNamesOne);
                TownshipNamesTwos.Add(TownshipNamesTwo);
                ClassNames.Add(ClassName);
            }

            List < List<string> > Data = new List<List<string>>();

            Data.Add(Badges);
            Data.Add(FirstNames);
            Data.Add(LastNames);
            Data.Add(ClassNames);
            Data.Add(TownshipNamesOnes);
            Data.Add(TownshipNamesTwos);


            StudentDA.TruncateTable();

            if (StudentDA.MassUpload(Data)){
                MessageBox.Show("Upload Completed");
            }
            else
            {
                MessageBox.Show("Upload Failed / Unkown Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

            MainListView.Items.Clear();
        }

        private void frmBulkImportExport_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();
        }
    }
}
