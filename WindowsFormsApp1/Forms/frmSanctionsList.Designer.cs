namespace WindowsFormsApp1.Forms
{
    partial class frmSanctionsList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanctionsList));
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.MainListView = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label18 = new System.Windows.Forms.Label();
            this.btn_Back_Third = new System.Windows.Forms.Button();
            this.btnExport_Secondary = new System.Windows.Forms.Button();
            this.btnRemoveSanction_Secondary = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDegree = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbClassName = new System.Windows.Forms.ComboBox();
            this.cmbSoort = new System.Windows.Forms.ComboBox();
            this.btnLateListSearch_Secondary = new System.Windows.Forms.Button();
            this.btnOpenStudentList_Secondary = new System.Windows.Forms.Button();
            this.btnAanpassen_Secondary = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(1192, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(162, 98);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
            // 
            // MainListView
            // 
            this.MainListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.MainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader2,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader25,
            this.columnHeader22,
            this.columnHeader24,
            this.columnHeader1});
            this.MainListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainListView.ForeColor = System.Drawing.Color.White;
            this.MainListView.FullRowSelect = true;
            this.MainListView.HideSelection = false;
            this.MainListView.Location = new System.Drawing.Point(18, 317);
            this.MainListView.Name = "MainListView";
            this.MainListView.Size = new System.Drawing.Size(910, 372);
            this.MainListView.TabIndex = 13;
            this.MainListView.UseCompatibleStateImageBehavior = false;
            this.MainListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 0;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Voornaam";
            this.columnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader20.Width = 120;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Achternaam";
            this.columnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader21.Width = 167;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Soort";
            this.columnHeader25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader25.Width = 226;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Klas";
            this.columnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader22.Width = 63;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Graad";
            this.columnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader24.Width = 116;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 178;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft New Tai Lue", 60F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.label18.Location = new System.Drawing.Point(9, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(491, 105);
            this.label18.TabIndex = 15;
            this.label18.Text = "Sanctie Lijst";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Back_Third
            // 
            this.btn_Back_Third.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(22)))), ((int)(((byte)(47)))));
            this.btn_Back_Third.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btn_Back_Third.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Back_Third.Location = new System.Drawing.Point(1232, 636);
            this.btn_Back_Third.Name = "btn_Back_Third";
            this.btn_Back_Third.Size = new System.Drawing.Size(120, 48);
            this.btn_Back_Third.TabIndex = 5;
            this.btn_Back_Third.Text = "Terug";
            this.btn_Back_Third.UseVisualStyleBackColor = false;
            this.btn_Back_Third.Click += new System.EventHandler(this.btn_frmSanctionList_Close_frmMenu_Click);
            // 
            // btnExport_Secondary
            // 
            this.btnExport_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnExport_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnExport_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport_Secondary.Location = new System.Drawing.Point(1133, 582);
            this.btnExport_Secondary.Name = "btnExport_Secondary";
            this.btnExport_Secondary.Size = new System.Drawing.Size(219, 48);
            this.btnExport_Secondary.TabIndex = 5;
            this.btnExport_Secondary.Text = "Exporteer XLS";
            this.btnExport_Secondary.UseVisualStyleBackColor = false;
            this.btnExport_Secondary.Click += new System.EventHandler(this.btnExport_Secondary_Click);
            // 
            // btnRemoveSanction_Secondary
            // 
            this.btnRemoveSanction_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnRemoveSanction_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnRemoveSanction_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveSanction_Secondary.Location = new System.Drawing.Point(1174, 425);
            this.btnRemoveSanction_Secondary.Name = "btnRemoveSanction_Secondary";
            this.btnRemoveSanction_Secondary.Size = new System.Drawing.Size(180, 48);
            this.btnRemoveSanction_Secondary.TabIndex = 5;
            this.btnRemoveSanction_Secondary.Text = "Verwijder";
            this.btnRemoveSanction_Secondary.UseVisualStyleBackColor = false;
            this.btnRemoveSanction_Secondary.Click += new System.EventHandler(this.btnRemoveSanction_Secondary_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerTo);
            this.groupBox2.Controls.Add(this.dateTimePickerFrom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtLimit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbDegree);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtSurname);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmbClassName);
            this.groupBox2.Controls.Add(this.cmbSoort);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.groupBox2.Location = new System.Drawing.Point(18, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1291, 128);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // txtLimit
            // 
            this.txtLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtLimit.Location = new System.Drawing.Point(756, 70);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(111, 32);
            this.txtLimit.TabIndex = 27;
            this.txtLimit.TextChanged += new System.EventHandler(this.txtLimit_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label4.Location = new System.Drawing.Point(752, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Limit:";
            // 
            // cmbDegree
            // 
            this.cmbDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbDegree.FormattingEnabled = true;
            this.cmbDegree.Items.AddRange(new object[] {
            "3",
            "2",
            "1"});
            this.cmbDegree.Location = new System.Drawing.Point(659, 70);
            this.cmbDegree.Name = "cmbDegree";
            this.cmbDegree.Size = new System.Drawing.Size(91, 32);
            this.cmbDegree.TabIndex = 24;
            this.cmbDegree.TextChanged += new System.EventHandler(this.cmbDegree_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label6.Location = new System.Drawing.Point(265, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Soort:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label7.Location = new System.Drawing.Point(655, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Graad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label12.Location = new System.Drawing.Point(546, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "Klas:";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSurname.Location = new System.Drawing.Point(128, 73);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(135, 29);
            this.txtSurname.TabIndex = 14;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label13.Location = new System.Drawing.Point(124, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 24);
            this.label13.TabIndex = 21;
            this.label13.Text = "Achternaam:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtName.Location = new System.Drawing.Point(22, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 29);
            this.txtName.TabIndex = 15;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label14.Location = new System.Drawing.Point(18, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 24);
            this.label14.TabIndex = 22;
            this.label14.Text = "Naam:";
            // 
            // cmbClassName
            // 
            this.cmbClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbClassName.FormattingEnabled = true;
            this.cmbClassName.Location = new System.Drawing.Point(550, 70);
            this.cmbClassName.Name = "cmbClassName";
            this.cmbClassName.Size = new System.Drawing.Size(99, 32);
            this.cmbClassName.TabIndex = 25;
            this.cmbClassName.TextChanged += new System.EventHandler(this.cmbClassName_TextChanged);
            // 
            // cmbSoort
            // 
            this.cmbSoort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbSoort.FormattingEnabled = true;
            this.cmbSoort.Location = new System.Drawing.Point(269, 70);
            this.cmbSoort.Name = "cmbSoort";
            this.cmbSoort.Size = new System.Drawing.Size(271, 32);
            this.cmbSoort.TabIndex = 26;
            this.cmbSoort.TextChanged += new System.EventHandler(this.cmbSoort_TextChanged);
            // 
            // btnLateListSearch_Secondary
            // 
            this.btnLateListSearch_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnLateListSearch_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnLateListSearch_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLateListSearch_Secondary.Location = new System.Drawing.Point(17, 266);
            this.btnLateListSearch_Secondary.Name = "btnLateListSearch_Secondary";
            this.btnLateListSearch_Secondary.Size = new System.Drawing.Size(118, 45);
            this.btnLateListSearch_Secondary.TabIndex = 20;
            this.btnLateListSearch_Secondary.Text = "Zoek";
            this.btnLateListSearch_Secondary.UseVisualStyleBackColor = false;
            this.btnLateListSearch_Secondary.Click += new System.EventHandler(this.btnLateListSearch_Secondary_Click);
            // 
            // btnOpenStudentList_Secondary
            // 
            this.btnOpenStudentList_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnOpenStudentList_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnOpenStudentList_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenStudentList_Secondary.Location = new System.Drawing.Point(1119, 317);
            this.btnOpenStudentList_Secondary.Name = "btnOpenStudentList_Secondary";
            this.btnOpenStudentList_Secondary.Size = new System.Drawing.Size(233, 48);
            this.btnOpenStudentList_Secondary.TabIndex = 21;
            this.btnOpenStudentList_Secondary.Text = "Studenten Lijst";
            this.btnOpenStudentList_Secondary.UseVisualStyleBackColor = false;
            this.btnOpenStudentList_Secondary.Click += new System.EventHandler(this.btnOpenStudentList_Secondary_Click);
            // 
            // btnAanpassen_Secondary
            // 
            this.btnAanpassen_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnAanpassen_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnAanpassen_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAanpassen_Secondary.Location = new System.Drawing.Point(1174, 371);
            this.btnAanpassen_Secondary.Name = "btnAanpassen_Secondary";
            this.btnAanpassen_Secondary.Size = new System.Drawing.Size(180, 48);
            this.btnAanpassen_Secondary.TabIndex = 5;
            this.btnAanpassen_Secondary.Text = "Aanpassen";
            this.btnAanpassen_Secondary.UseVisualStyleBackColor = false;
            this.btnAanpassen_Secondary.Click += new System.EventHandler(this.btnAanpassen_Secondary_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(1087, 53);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(188, 20);
            this.dateTimePickerTo.TabIndex = 29;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(1087, 26);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(188, 20);
            this.dateTimePickerFrom.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label3.Location = new System.Drawing.Point(980, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tot Datum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label5.Location = new System.Drawing.Point(973, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Van Datum:";
            // 
            // frmSanctionsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 701);
            this.Controls.Add(this.btnOpenStudentList_Secondary);
            this.Controls.Add(this.btnLateListSearch_Secondary);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.MainListView);
            this.Controls.Add(this.btn_Back_Third);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAanpassen_Secondary);
            this.Controls.Add(this.btnRemoveSanction_Secondary);
            this.Controls.Add(this.btnExport_Secondary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmSanctionsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSancties";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSanctionsList_FormClosed);
            this.Load += new System.EventHandler(this.frmSanctionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.ListView MainListView;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_Back_Third;
        private System.Windows.Forms.Button btnExport_Secondary;
        private System.Windows.Forms.Button btnRemoveSanction_Secondary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLateListSearch_Secondary;
        private System.Windows.Forms.ComboBox cmbDegree;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbClassName;
        private System.Windows.Forms.ComboBox cmbSoort;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnOpenStudentList_Secondary;
        private System.Windows.Forms.Button btnAanpassen_Secondary;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}