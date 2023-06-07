using NPOI.SS.Formula.Functions;
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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    public partial class frmSanctieSoort : Form
    {
        public Student student;
        public Form parentForm;
        public frmSanctionsList frmSanctionsList;
        public Sanction sanction;

        public frmSanctieSoort(Student student, Form parentform)
        {
            InitializeComponent();


            this.student = student;

            lblStudentName.Text = student.Name + " " + student.Surname;
            parentForm = parentform;

        }

        public frmSanctieSoort(string FullName, Sanction sanction, frmSanctionsList frmSanctionsList)
        {
            InitializeComponent();


            lblStudentName.Text = FullName;

            btn_frmSanctieSoort_Secondary.Text = "Aanpassen";
            this.frmSanctionsList = frmSanctionsList;
            this.sanction = sanction;
        }

        private void btn_frmSanctieSoort_Secondary_Click(object sender, EventArgs e)
        {
            string Soort = txtSanctieSoort.Text;
            if (Soort == string.Empty)
                return;

            if (btn_frmSanctieSoort_Secondary.Text != "Aanpassen")
            {
                parentForm.Hide();
                this.Hide();

                frmSanctionsList frmSanctionsList = new frmSanctionsList(student, Soort);
                frmSanctionsList.Show();
            }
            else
            {
                sanction.Soort = Soort;
                SanctionDA.UpdateSanction(sanction);
                this.Hide();
                frmSanctionsList.LoadListView();
                frmSanctionsList.LoadFilters();
            }

        }


    }
}
