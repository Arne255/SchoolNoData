namespace WindowsFormsApp1.Forms
{
    partial class frmModerateStudentsList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModerateStudentsList));
            this.btnAdd_Secondary = new System.Windows.Forms.Button();
            this.btnModify_Secondary = new System.Windows.Forms.Button();
            this.btnRemove_Secondary = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.btn_Back_Third = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.cmbClassDegree = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.cmbClassName = new System.Windows.Forms.ComboBox();
            this.cmbTownshipNameTwo = new System.Windows.Forms.ComboBox();
            this.cmbTownshipNameOne = new System.Windows.Forms.ComboBox();
            this.btnLateListSearch_Secondary = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.tmrResetListView = new System.Windows.Forms.Timer(this.components);
            this.ListViewMain = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd_Secondary
            // 
            this.btnAdd_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnAdd_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnAdd_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd_Secondary.Location = new System.Drawing.Point(1172, 371);
            this.btnAdd_Secondary.Name = "btnAdd_Secondary";
            this.btnAdd_Secondary.Size = new System.Drawing.Size(180, 48);
            this.btnAdd_Secondary.TabIndex = 5;
            this.btnAdd_Secondary.Text = "Toevoegen";
            this.btnAdd_Secondary.UseVisualStyleBackColor = false;
            this.btnAdd_Secondary.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify_Secondary
            // 
            this.btnModify_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnModify_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnModify_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModify_Secondary.Location = new System.Drawing.Point(1172, 422);
            this.btnModify_Secondary.Name = "btnModify_Secondary";
            this.btnModify_Secondary.Size = new System.Drawing.Size(180, 48);
            this.btnModify_Secondary.TabIndex = 5;
            this.btnModify_Secondary.Text = "Aanpassen";
            this.btnModify_Secondary.UseVisualStyleBackColor = false;
            this.btnModify_Secondary.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRemove_Secondary
            // 
            this.btnRemove_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnRemove_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnRemove_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove_Secondary.Location = new System.Drawing.Point(1172, 476);
            this.btnRemove_Secondary.Name = "btnRemove_Secondary";
            this.btnRemove_Secondary.Size = new System.Drawing.Size(180, 48);
            this.btnRemove_Secondary.TabIndex = 5;
            this.btnRemove_Secondary.Text = "Verwijder";
            this.btnRemove_Secondary.UseVisualStyleBackColor = false;
            this.btnRemove_Secondary.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Microsoft New Tai Lue", 60F, System.Drawing.FontStyle.Bold);
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.label35.Location = new System.Drawing.Point(9, 15);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(704, 105);
            this.label35.TabIndex = 15;
            this.label35.Text = "Beheer studenten";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_Back_Third.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txtLimit);
            this.groupBox11.Controls.Add(this.cmbClassDegree);
            this.groupBox11.Controls.Add(this.label4);
            this.groupBox11.Controls.Add(this.label1);
            this.groupBox11.Controls.Add(this.label36);
            this.groupBox11.Controls.Add(this.label38);
            this.groupBox11.Controls.Add(this.label40);
            this.groupBox11.Controls.Add(this.txtSurname);
            this.groupBox11.Controls.Add(this.label41);
            this.groupBox11.Controls.Add(this.txtName);
            this.groupBox11.Controls.Add(this.label42);
            this.groupBox11.Controls.Add(this.cmbClassName);
            this.groupBox11.Controls.Add(this.cmbTownshipNameTwo);
            this.groupBox11.Controls.Add(this.cmbTownshipNameOne);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.groupBox11.Location = new System.Drawing.Point(18, 132);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1137, 128);
            this.groupBox11.TabIndex = 14;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Filters";
            // 
            // txtLimit
            // 
            this.txtLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtLimit.Location = new System.Drawing.Point(1019, 76);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(98, 32);
            this.txtLimit.TabIndex = 30;
            this.txtLimit.TextChanged += new System.EventHandler(this.txtLimit_TextChanged);
            // 
            // cmbClassDegree
            // 
            this.cmbClassDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbClassDegree.FormattingEnabled = true;
            this.cmbClassDegree.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbClassDegree.Location = new System.Drawing.Point(462, 74);
            this.cmbClassDegree.Name = "cmbClassDegree";
            this.cmbClassDegree.Size = new System.Drawing.Size(83, 32);
            this.cmbClassDegree.TabIndex = 13;
            this.cmbClassDegree.TextChanged += new System.EventHandler(this.cmbClassDegree_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label4.Location = new System.Drawing.Point(1015, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Limit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(783, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gemeente Twee:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label36.Location = new System.Drawing.Point(551, 47);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(144, 24);
            this.label36.TabIndex = 12;
            this.label36.Text = "Gemeente Één:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label38.Location = new System.Drawing.Point(458, 47);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(66, 24);
            this.label38.TabIndex = 12;
            this.label38.Text = "Graad:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label40.Location = new System.Drawing.Point(335, 50);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(50, 24);
            this.label40.TabIndex = 12;
            this.label40.Text = "Klas:";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSurname.Location = new System.Drawing.Point(165, 77);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(168, 29);
            this.txtSurname.TabIndex = 11;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label41.Location = new System.Drawing.Point(161, 51);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(117, 24);
            this.label41.TabIndex = 12;
            this.label41.Text = "Achternaam:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtName.Location = new System.Drawing.Point(18, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 29);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label42.Location = new System.Drawing.Point(14, 53);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(65, 24);
            this.label42.TabIndex = 12;
            this.label42.Text = "Naam:";
            // 
            // cmbClassName
            // 
            this.cmbClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbClassName.FormattingEnabled = true;
            this.cmbClassName.Location = new System.Drawing.Point(339, 74);
            this.cmbClassName.Name = "cmbClassName";
            this.cmbClassName.Size = new System.Drawing.Size(117, 32);
            this.cmbClassName.TabIndex = 13;
            this.cmbClassName.TextChanged += new System.EventHandler(this.cmbClassName_TextChanged);
            // 
            // cmbTownshipNameTwo
            // 
            this.cmbTownshipNameTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbTownshipNameTwo.FormattingEnabled = true;
            this.cmbTownshipNameTwo.Location = new System.Drawing.Point(787, 74);
            this.cmbTownshipNameTwo.Name = "cmbTownshipNameTwo";
            this.cmbTownshipNameTwo.Size = new System.Drawing.Size(226, 32);
            this.cmbTownshipNameTwo.TabIndex = 13;
            this.cmbTownshipNameTwo.TextChanged += new System.EventHandler(this.cmbTownshipNameTwo_TextChanged);
            // 
            // cmbTownshipNameOne
            // 
            this.cmbTownshipNameOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbTownshipNameOne.FormattingEnabled = true;
            this.cmbTownshipNameOne.Location = new System.Drawing.Point(555, 74);
            this.cmbTownshipNameOne.Name = "cmbTownshipNameOne";
            this.cmbTownshipNameOne.Size = new System.Drawing.Size(226, 32);
            this.cmbTownshipNameOne.TabIndex = 13;
            this.cmbTownshipNameOne.TextChanged += new System.EventHandler(this.cmbTownshipNameOne_TextChanged);
            // 
            // btnLateListSearch_Secondary
            // 
            this.btnLateListSearch_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnLateListSearch_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnLateListSearch_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLateListSearch_Secondary.Location = new System.Drawing.Point(18, 266);
            this.btnLateListSearch_Secondary.Name = "btnLateListSearch_Secondary";
            this.btnLateListSearch_Secondary.Size = new System.Drawing.Size(118, 45);
            this.btnLateListSearch_Secondary.TabIndex = 19;
            this.btnLateListSearch_Secondary.Text = "Zoek";
            this.btnLateListSearch_Secondary.UseVisualStyleBackColor = false;
            this.btnLateListSearch_Secondary.Click += new System.EventHandler(this.btnLateListSearch_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(1190, 15);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(162, 98);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            // 
            // tmrResetListView
            // 
            this.tmrResetListView.Enabled = true;
            this.tmrResetListView.Interval = 1000;
            // 
            // ListViewMain
            // 
            this.ListViewMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.ListViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader4,
            this.columnHeader8});
            this.ListViewMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ListViewMain.ForeColor = System.Drawing.Color.White;
            this.ListViewMain.FullRowSelect = true;
            this.ListViewMain.HideSelection = false;
            this.ListViewMain.Location = new System.Drawing.Point(18, 317);
            this.ListViewMain.Name = "ListViewMain";
            this.ListViewMain.Size = new System.Drawing.Size(1013, 372);
            this.ListViewMain.TabIndex = 20;
            this.ListViewMain.UseCompatibleStateImageBehavior = false;
            this.ListViewMain.View = System.Windows.Forms.View.Details;
            this.ListViewMain.SelectedIndexChanged += new System.EventHandler(this.ListViewMain_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CardUID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Voornaam";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 162;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Achternaam";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 174;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Klas";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 111;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Graad";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gemeente Één";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 227;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Gemeente Twee";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 228;
            // 
            // frmModerateStudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 701);
            this.Controls.Add(this.ListViewMain);
            this.Controls.Add(this.btnLateListSearch_Secondary);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.btn_Back_Third);
            this.Controls.Add(this.btnAdd_Secondary);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.btnModify_Secondary);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.btnRemove_Secondary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmModerateStudentsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModerateStudents";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmModerateStudentsList_FormClosed);
            this.Load += new System.EventHandler(this.frmModerateStudentsList_Load);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btnAdd_Secondary;
        private System.Windows.Forms.Button btnModify_Secondary;
        private System.Windows.Forms.Button btnRemove_Secondary;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btn_Back_Third;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox cmbClassDegree;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox cmbClassName;
        private System.Windows.Forms.ComboBox cmbTownshipNameOne;
        private System.Windows.Forms.Button btnLateListSearch_Secondary;
        private System.Windows.Forms.Timer tmrResetListView;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView ListViewMain;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTownshipNameTwo;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}