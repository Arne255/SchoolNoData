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


namespace WindowsFormsApp1.Forms
{
    public partial class frmModerateStudentsList : Form
    {
        frmAddStudent frmAddStudent;

        string _Name;
        string _Surname;
        string _ClassName;
        string _ClassDegree;
        string _TownshipNameOne;
        string _TownshipNameTwo;
        string _PullLimit;



        public frmModerateStudentsList()
        {
            InitializeComponent();

            DontDestroy.UI.DisplayLayout(this);
            _PullLimit = "10";
            txtLimit.Text = "10";
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
                listViewItem.Text = student.CardUID;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (frmAddStudent != null)
            {
                frmAddStudent.Close();
                frmAddStudent = null;
            }

            frmAddStudent = new frmAddStudent(this);
            frmAddStudent.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<Student> studentList = new List<Student>();
            if (ListViewMain.SelectedItems.Count > 0)
            {
                for (int i = ListViewMain.SelectedItems.Count - 1; i >= 0; i--)
                {
                    string studentCardUID = ListViewMain.SelectedItems[i].Text;

                    //Creating Student
                    Student student = new Student();
                    student.CardUID = studentCardUID;
                    studentList.Add(student);

                    ListViewMain.SelectedItems[i].Remove();
                }

                StudentDA.RemoveStudent(studentList);
            }

        }

        private void btnLateListSearch_Click(object sender, EventArgs e)
        {
            LoadListView();
            LoadFilters();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            if (frmAddStudent != null)
            {
                frmAddStudent.Close();
            }
            frmSettings frmSettings = new frmSettings();
            this.Hide();
            frmSettings.Show();
        }

        private void txtLimit_TextChanged(object sender, EventArgs e)
        {
            _PullLimit = txtLimit.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            _Name = txtName.Text;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            _Surname = txtSurname.Text;
        }

        private void cmbClassDegree_TextChanged(object sender, EventArgs e)
        {
            string selectedText = cmbClassDegree.Text;
            _ClassDegree = selectedText;
        }

        private void cmbTownshipNameOne_TextChanged(object sender, EventArgs e)
        {
            string selectedText = cmbTownshipNameOne.Text;
            _TownshipNameOne = selectedText;
        }

        private void cmbClassName_TextChanged(object sender, EventArgs e)
        {
            string selectedText = cmbClassName.Text;
            _ClassName = selectedText;
        }

        private void cmbTownshipNameTwo_TextChanged(object sender, EventArgs e)
        {
            string selectedText = cmbTownshipNameTwo.Text;
            _TownshipNameTwo = selectedText;
        }

        private void frmModerateStudentsList_Load(object sender, EventArgs e)
        {

        }

        private void frmModerateStudentsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            DontDestroy.promptSave();
            Application.Exit();

        }

        private void ListViewMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
