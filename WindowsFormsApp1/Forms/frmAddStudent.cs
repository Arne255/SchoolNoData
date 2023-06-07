using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.DA;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Helper;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    public partial class frmAddStudent : Form
    {
        public frmModerateStudentsList parentForm;
        public frmAddStudent(frmModerateStudentsList myParentForm)
        {
            InitializeComponent();

            parentForm = myParentForm;
        }

        private void btn_frmAddStudent_AddStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.ClassName = txtClassName.Text;
            student.TownshipNameOne = txtTownshipNameOne.Text;
            student.TownshipNameTwo = txtTownshipNameTwo.Text;
            student.CardUID = txtCardUID.Text;

            StudentDA.UploadStudent(student);


            foreach (ListView listView in parentForm.Controls.OfType<ListView>())
            {
                if (listView == null) { return; }

                parentForm.LoadFilters();
                parentForm.LoadListView();
            }

            txtName.Clear();
            txtSurname.Clear();
            txtClassName.Clear();
            txtTownshipNameOne.Clear();
            txtTownshipNameTwo.Clear();
            txtCardUID.Clear();
            txtName.Focus();
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
