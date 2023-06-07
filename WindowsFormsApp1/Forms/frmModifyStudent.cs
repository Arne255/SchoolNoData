using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DA;
using WindowsFormsApp1.Helper;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    public partial class frmModifyStudent : Form
    {
        public string oldUID;
        public frmStudentsList frmStudentsList;
        public frmModerateStudentsList frmModerateStudentsList;

        public bool studentList = true;

        public frmModifyStudent(Student student, frmStudentsList parentForm)
        {
            InitializeComponent();

            oldUID = student.CardUID;

            txtName.Text = student.Name;
            txtSurname.Text = student.Surname;
            txtClassName.Text = student.ClassName;
            txtTownshipNameOne.Text = student.TownshipNameOne;
            txtTownshipNameTwo.Text = student.TownshipNameTwo;
            txtCardUID.Text = student.CardUID;

            frmStudentsList = parentForm;
        }

        public frmModifyStudent(Student student, frmModerateStudentsList parentForm)
        {
            InitializeComponent();

            oldUID = student.CardUID;

            txtName.Text = student.Name;
            txtSurname.Text = student.Surname;
            txtClassName.Text = student.ClassName;
            txtTownshipNameOne.Text = student.TownshipNameOne;
            txtTownshipNameTwo.Text = student.TownshipNameTwo;
            txtCardUID.Text = student.CardUID;

            frmModerateStudentsList = parentForm;
            studentList = false;

        }

        private void btn_frmModifyStudent_Opslaan_Secondary_Click(object sender, EventArgs e)
        {
            string newUID = txtCardUID.Text;

            Student student = new Student();

            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.ClassName = txtClassName.Text;
            student.TownshipNameOne = txtTownshipNameOne.Text;
            student.TownshipNameTwo = txtTownshipNameTwo.Text;
            student.CardUID = newUID;
            StudentDA.UpdateStudent(oldUID, student);

            DontDestroy.UpdateUID(oldUID, newUID, "latecounter");
            DontDestroy.UpdateUID(oldUID, newUID, "lates");
            DontDestroy.UpdateUID(oldUID, newUID, "sanctions");

            if (studentList)
            {
                frmStudentsList.LoadListView();
                frmStudentsList.LoadFilters();
            }
            else
            {
                frmModerateStudentsList.LoadListView();
                frmModerateStudentsList.LoadFilters();
            }

            this.Close();
        }

        private void tmrConnectAndFillInText_Tick(object sender, EventArgs e)
        {
            string UID = DontDestroy.GetUID();

            if (!string.IsNullOrEmpty(UID))
            {
                txtCardUID.Text = UID;
            }
        }
    }
}
