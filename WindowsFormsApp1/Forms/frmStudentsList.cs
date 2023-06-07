using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
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
    public partial class frmStudentsList : Form
    {
        string _Name;
        string _Surname;
        string _ClassName;
        string _ClassDegree;
        string _TownshipNameOne;
        string _TownshipNameTwo;
        string _PullLimit;

        public frmStudentsList()
        {
            InitializeComponent();

            DontDestroy.UI.DisplayLayout(this);
            _PullLimit = "50";
            txtLimit.Text = "50";
            LoadFilters();
            LoadListView();
        }
        


        private void btn_frmStudentsList_Close_frmMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.Show();
        }

        private void btn_frmStudentsList_Open_frmScanner_Click(object sender, EventArgs e)
        {
            if (ListViewMain.SelectedItems.Count <= 0)
                return;

            try
            {
                frmScanner frmScanner = new frmScanner(GetSelectedStudent());
                this.Hide();
                frmScanner.Show();
            }
            catch
            {
                MessageBox.Show("Error, student is niet geldig!");
            }

        }

        private void btnExportSelected_Click(object sender, EventArgs e)
        {
            //NameId veranderen + MessageBox laten weten dat kleur van listview niet mee zal opgeslaan worden
            //NameId veranderen + MessageBox laten weten dat kleur van listview niet mee zal opgeslaan worden
            //NameId veranderen + MessageBox laten weten dat kleur van listview niet mee zal opgeslaan worden
            //NameId veranderen + MessageBox laten weten dat kleur van listview niet mee zal opgeslaan worden
        }

       
        private void tmrListViewStudentList_Tick(object sender, EventArgs e)
        {
            ListViewMain.Columns[0].Width = 0;
            ListViewMain.Columns[1].Width = 0;
        }

        private void btnLateListSearch_Click(object sender, EventArgs e)
        {
            LoadFilters();
            LoadListView();
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

        public void LoadListView()
        {
            ListViewMain.Items.Clear();

            int PullLimit = 10;
            try
            {
                PullLimit = Convert.ToInt32(_PullLimit);
            }
            catch
            {
                //ERROR
            }

            List<Student> students = StudentDA.GetStudentsBasedOnSearch(_Name, _Surname, _ClassName, _ClassDegree, _TownshipNameOne, _TownshipNameTwo, PullLimit);

            foreach (Student student in students)
            {

                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = student.CardUID.ToString();
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(student.Name.ToString());
                listViewItem.SubItems.Add(student.Surname.ToString());
                listViewItem.SubItems.Add(student.ClassName.ToString());
                if (student.ClassName.StartsWith("1") || student.ClassName.StartsWith("2"))
                {
                    listViewItem.SubItems.Add("1");
                }
                else if (student.ClassName.StartsWith("3") || student.ClassName.StartsWith("4"))
                {
                    listViewItem.SubItems.Add("2");
                }
                else if (student.ClassName.StartsWith("5") || student.ClassName.StartsWith("6") || student.ClassName.StartsWith("7"))
                {
                    listViewItem.SubItems.Add("3");
                }
                listViewItem.SubItems.Add(student.TownshipNameOne.ToString());
                listViewItem.SubItems.Add(student.TownshipNameTwo.ToString());
                ListViewMain.Items.Add(listViewItem);
            }
        }


        private void txtLimit_TextChanged(object sender, EventArgs e)
        {
            _PullLimit = txtLimit.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            _Name = txtName.Text;
            txtLimit.Text = "50";
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            _Surname = txtSurname.Text;
            txtLimit.Text = "50";
        }

        private void cmbClassDegree_TextChanged(object sender, EventArgs e)
        {
            _ClassDegree = cmbClassDegree.Text;
            txtLimit.Text = "50";
        }

        private void cmbTownshipNameOne_TextChanged(object sender, EventArgs e)
        {
            _TownshipNameOne = cmbTownshipNameOne.Text;
            txtLimit.Text = "50";
        }

        private void cmbClassName_TextChanged(object sender, EventArgs e)
        {
            _ClassName = cmbClassName.Text;
            txtLimit.Text = "50";
        }

        private void cmbTownshipNameTwo_TextChanged(object sender, EventArgs e)
        {
            _TownshipNameTwo = cmbTownshipNameTwo.Text;
            txtLimit.Text = "50";
        }

        private void frmStudentsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();
        }

        private void btn_Sanction(object sender, EventArgs e)
        {
            if (ListViewMain.SelectedItems.Count <= 0) { return; }


            try
            {
                frmSanctieSoort frmSanctieSoort = new frmSanctieSoort(GetSelectedStudent(), this);
                frmSanctieSoort.Show();
            }
            catch
            {
                MessageBox.Show("Error, student is niet geldig!");
            }
        }

        private void frmStudentsList_Load(object sender, EventArgs e)
        {

        }

        private Student GetSelectedStudent()
        {
            Student student = new Student();

            student.CardUID = ListViewMain.SelectedItems[0].Text; //CardUID
            student.Name = ListViewMain.SelectedItems[0].SubItems[2].Text; //Name
            student.Surname = ListViewMain.SelectedItems[0].SubItems[3].Text; //Surname
            student.ClassName = ListViewMain.SelectedItems[0].SubItems[4].Text; //ClassName
            student.TownshipNameOne = ListViewMain.SelectedItems[0].SubItems[6].Text; //TownshipNameOne
            student.TownshipNameTwo = ListViewMain.SelectedItems[0].SubItems[7].Text; //TownshipNameTwo

            return student;
        }

        private void btnAanpassen_Secondary_Click(object sender, EventArgs e)
        {
            for (int i = ListViewMain.SelectedItems.Count - 1; i >= 0; i--)
            {

                ListViewItem item = ListViewMain.SelectedItems[i];
                string CardUID = item.Text;
                string Name = item.SubItems[2].Text;
                string Surname = item.SubItems[3].Text;
                string ClassName = item.SubItems[4].Text;
                //int ClassDegree = Convert.ToInt32(item.SubItems[5].Text);
                string TownshipNameOne = item.SubItems[6].Text;
                string TownshipNameTwo = item.SubItems[7].Text;

                Student student = new Student();
                student.CardUID = CardUID;
                student.Name = Name;
                student.Surname = Surname;
                student.ClassName = ClassName;
                student.TownshipNameOne = TownshipNameOne;
                student.TownshipNameTwo = TownshipNameTwo;

                frmModifyStudent frmModifyStudent = new frmModifyStudent(student, this);
                frmModifyStudent.Show();
            }
        }
    }
}
