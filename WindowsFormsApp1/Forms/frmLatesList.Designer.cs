namespace WindowsFormsApp1.Forms
{
    partial class frmLatesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLatesList));
            this.MainListView = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLateList = new System.Windows.Forms.Label();
            this.btnModify_Secondary = new System.Windows.Forms.Button();
            this.btn_Back_Third = new System.Windows.Forms.Button();
            this.btnRemove_Secondary = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCustomReason = new System.Windows.Forms.ComboBox();
            this.cmbIsValid = new System.Windows.Forms.ComboBox();
            this.cmbReason = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbClassName = new System.Windows.Forms.ComboBox();
            this.cmbTownshipNameTwo = new System.Windows.Forms.ComboBox();
            this.cmbTownshipNameOne = new System.Windows.Forms.ComboBox();
            this.cmbClassDegree = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Search_Secondary = new System.Windows.Forms.Button();
            this.tmrResetListView = new System.Windows.Forms.Timer(this.components);
            this.btnExport_Secondary = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // MainListView
            // 
            this.MainListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.MainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader2,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader16,
            this.columnHeader15,
            this.columnHeader3,
            this.columnHeader17,
            this.columnHeader19,
            this.columnHeader18,
            this.columnHeader1});
            this.MainListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainListView.ForeColor = System.Drawing.Color.White;
            this.MainListView.FullRowSelect = true;
            this.MainListView.HideSelection = false;
            this.MainListView.Location = new System.Drawing.Point(18, 317);
            this.MainListView.Name = "MainListView";
            this.MainListView.Size = new System.Drawing.Size(1109, 372);
            this.MainListView.TabIndex = 13;
            this.MainListView.UseCompatibleStateImageBehavior = false;
            this.MainListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "LateID";
            this.columnHeader11.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Voornaam";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 103;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Achternaam";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 117;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Klas";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 66;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Graad";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 71;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Gemeente Één";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 149;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gemeente Twee";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 158;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Reden";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader17.Width = 76;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Andere reden";
            this.columnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader19.Width = 138;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Is Geldig";
            this.columnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader18.Width = 93;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 134;
            // 
            // lblLateList
            // 
            this.lblLateList.AutoSize = true;
            this.lblLateList.BackColor = System.Drawing.Color.Transparent;
            this.lblLateList.Font = new System.Drawing.Font("Microsoft New Tai Lue", 60F, System.Drawing.FontStyle.Bold);
            this.lblLateList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.lblLateList.Location = new System.Drawing.Point(9, 15);
            this.lblLateList.Name = "lblLateList";
            this.lblLateList.Size = new System.Drawing.Size(490, 105);
            this.lblLateList.TabIndex = 15;
            this.lblLateList.Text = "Te Laat Lijst";
            this.lblLateList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModify_Secondary
            // 
            this.btnModify_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnModify_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnModify_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModify_Secondary.Location = new System.Drawing.Point(1172, 368);
            this.btnModify_Secondary.Name = "btnModify_Secondary";
            this.btnModify_Secondary.Size = new System.Drawing.Size(180, 48);
            this.btnModify_Secondary.TabIndex = 5;
            this.btnModify_Secondary.Text = "Aanpassen";
            this.btnModify_Secondary.UseVisualStyleBackColor = false;
            this.btnModify_Secondary.Click += new System.EventHandler(this.btnModify_Secondary_Click);
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
            this.btn_Back_Third.Click += new System.EventHandler(this.btn_frmLatesList_Close_frmMenu_Click);
            // 
            // btnRemove_Secondary
            // 
            this.btnRemove_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnRemove_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnRemove_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove_Secondary.Location = new System.Drawing.Point(1172, 422);
            this.btnRemove_Secondary.Name = "btnRemove_Secondary";
            this.btnRemove_Secondary.Size = new System.Drawing.Size(180, 48);
            this.btnRemove_Secondary.TabIndex = 5;
            this.btnRemove_Secondary.Text = "Verwijder";
            this.btnRemove_Secondary.UseVisualStyleBackColor = false;
            this.btnRemove_Secondary.Click += new System.EventHandler(this.btn_frmLateList_RemoveLate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerTo);
            this.groupBox1.Controls.Add(this.dateTimePickerFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLimit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbCustomReason);
            this.groupBox1.Controls.Add(this.cmbIsValid);
            this.groupBox1.Controls.Add(this.cmbReason);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbClassName);
            this.groupBox1.Controls.Add(this.cmbTownshipNameTwo);
            this.groupBox1.Controls.Add(this.cmbTownshipNameOne);
            this.groupBox1.Controls.Add(this.cmbClassDegree);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.groupBox1.Location = new System.Drawing.Point(18, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1336, 147);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(1142, 53);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(188, 20);
            this.dateTimePickerTo.TabIndex = 20;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(1142, 26);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(188, 20);
            this.dateTimePickerFrom.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label2.Location = new System.Drawing.Point(1041, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tot Datum:";
            // 
            // txtLimit
            // 
            this.txtLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtLimit.Location = new System.Drawing.Point(1035, 101);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(87, 32);
            this.txtLimit.TabIndex = 15;
            this.txtLimit.TextChanged += new System.EventHandler(this.txtLimit_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label4.Location = new System.Drawing.Point(1031, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Limit:";
            // 
            // cmbCustomReason
            // 
            this.cmbCustomReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbCustomReason.FormattingEnabled = true;
            this.cmbCustomReason.Location = new System.Drawing.Point(771, 100);
            this.cmbCustomReason.Name = "cmbCustomReason";
            this.cmbCustomReason.Size = new System.Drawing.Size(161, 32);
            this.cmbCustomReason.TabIndex = 13;
            this.cmbCustomReason.TextChanged += new System.EventHandler(this.cmbCustomReason_TextChanged);
            // 
            // cmbIsValid
            // 
            this.cmbIsValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbIsValid.FormattingEnabled = true;
            this.cmbIsValid.Location = new System.Drawing.Point(938, 101);
            this.cmbIsValid.Name = "cmbIsValid";
            this.cmbIsValid.Size = new System.Drawing.Size(91, 32);
            this.cmbIsValid.TabIndex = 13;
            this.cmbIsValid.TextChanged += new System.EventHandler(this.cmbIsValid_TextChanged);
            // 
            // cmbReason
            // 
            this.cmbReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new System.Drawing.Point(654, 101);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(111, 32);
            this.cmbReason.TabIndex = 13;
            this.cmbReason.SelectedIndexChanged += new System.EventHandler(this.cmbReason_SelectedIndexChanged);
            this.cmbReason.TextChanged += new System.EventHandler(this.cmbReason_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label5.Location = new System.Drawing.Point(1034, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Van Datum:";
            // 
            // cmbClassName
            // 
            this.cmbClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbClassName.FormattingEnabled = true;
            this.cmbClassName.Location = new System.Drawing.Point(219, 100);
            this.cmbClassName.Name = "cmbClassName";
            this.cmbClassName.Size = new System.Drawing.Size(92, 32);
            this.cmbClassName.TabIndex = 13;
            this.cmbClassName.TextChanged += new System.EventHandler(this.cmbClassName_TextChanged);
            // 
            // cmbTownshipNameTwo
            // 
            this.cmbTownshipNameTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbTownshipNameTwo.FormattingEnabled = true;
            this.cmbTownshipNameTwo.Location = new System.Drawing.Point(530, 100);
            this.cmbTownshipNameTwo.Name = "cmbTownshipNameTwo";
            this.cmbTownshipNameTwo.Size = new System.Drawing.Size(118, 32);
            this.cmbTownshipNameTwo.TabIndex = 13;
            this.cmbTownshipNameTwo.TextChanged += new System.EventHandler(this.cmbTownshipName_TextChanged);
            // 
            // cmbTownshipNameOne
            // 
            this.cmbTownshipNameOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbTownshipNameOne.FormattingEnabled = true;
            this.cmbTownshipNameOne.Location = new System.Drawing.Point(406, 100);
            this.cmbTownshipNameOne.Name = "cmbTownshipNameOne";
            this.cmbTownshipNameOne.Size = new System.Drawing.Size(118, 32);
            this.cmbTownshipNameOne.TabIndex = 13;
            this.cmbTownshipNameOne.TextChanged += new System.EventHandler(this.cmbTownshipName_TextChanged);
            // 
            // cmbClassDegree
            // 
            this.cmbClassDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbClassDegree.FormattingEnabled = true;
            this.cmbClassDegree.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbClassDegree.Location = new System.Drawing.Point(317, 100);
            this.cmbClassDegree.Name = "cmbClassDegree";
            this.cmbClassDegree.Size = new System.Drawing.Size(84, 32);
            this.cmbClassDegree.TabIndex = 13;
            this.cmbClassDegree.TextChanged += new System.EventHandler(this.cmbClassDegree_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label3.Location = new System.Drawing.Point(526, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 48);
            this.label3.TabIndex = 12;
            this.label3.Text = "Gemeente\r\nTwee:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label10.Location = new System.Drawing.Point(934, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Is Geldig:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(402, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 48);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gemeente\r\nÉén:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label7.Location = new System.Drawing.Point(317, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Graad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label8.Location = new System.Drawing.Point(767, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Andere redenen:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label11.Location = new System.Drawing.Point(650, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Reden:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label12.Location = new System.Drawing.Point(215, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 24);
            this.label12.TabIndex = 12;
            this.label12.Text = "Klas:";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSurname.Location = new System.Drawing.Point(100, 101);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(113, 29);
            this.txtSurname.TabIndex = 11;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label13.Location = new System.Drawing.Point(96, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 24);
            this.label13.TabIndex = 12;
            this.label13.Text = "Achternaam:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtName.Location = new System.Drawing.Point(12, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(82, 29);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label14.Location = new System.Drawing.Point(8, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 24);
            this.label14.TabIndex = 12;
            this.label14.Text = "Naam:";
            // 
            // btn_Search_Secondary
            // 
            this.btn_Search_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btn_Search_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btn_Search_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search_Secondary.Location = new System.Drawing.Point(18, 266);
            this.btn_Search_Secondary.Name = "btn_Search_Secondary";
            this.btn_Search_Secondary.Size = new System.Drawing.Size(118, 45);
            this.btn_Search_Secondary.TabIndex = 5;
            this.btn_Search_Secondary.Text = "Zoek";
            this.btn_Search_Secondary.UseVisualStyleBackColor = false;
            this.btn_Search_Secondary.Click += new System.EventHandler(this.btn_frmLateList_Search_Click);
            // 
            // tmrResetListView
            // 
            this.tmrResetListView.Enabled = true;
            this.tmrResetListView.Interval = 1000;
            this.tmrResetListView.Tick += new System.EventHandler(this.tmrResetListView_Tick);
            // 
            // btnExport_Secondary
            // 
            this.btnExport_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnExport_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnExport_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport_Secondary.Location = new System.Drawing.Point(1133, 576);
            this.btnExport_Secondary.Name = "btnExport_Secondary";
            this.btnExport_Secondary.Size = new System.Drawing.Size(219, 48);
            this.btnExport_Secondary.TabIndex = 5;
            this.btnExport_Secondary.Text = "Exporteer XLS";
            this.btnExport_Secondary.UseVisualStyleBackColor = false;
            this.btnExport_Secondary.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(1192, 12);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(162, 98);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            // 
            // frmLatesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 701);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.MainListView);
            this.Controls.Add(this.btn_Back_Third);
            this.Controls.Add(this.lblLateList);
            this.Controls.Add(this.btn_Search_Secondary);
            this.Controls.Add(this.btnModify_Secondary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemove_Secondary);
            this.Controls.Add(this.btnExport_Secondary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmLatesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LateList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLatesList_FormClosed);
            this.Load += new System.EventHandler(this.frmLatesList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.ListView MainListView;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Label lblLateList;
        private System.Windows.Forms.Button btnModify_Secondary;
        private System.Windows.Forms.Button btn_Back_Third;
        private System.Windows.Forms.Button btnRemove_Secondary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCustomReason;
        private System.Windows.Forms.ComboBox cmbIsValid;
        private System.Windows.Forms.ComboBox cmbReason;
        private System.Windows.Forms.ComboBox cmbClassDegree;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Search_Secondary;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox cmbTownshipNameOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClassName;
        private System.Windows.Forms.Timer tmrResetListView;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnExport_Secondary;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cmbTownshipNameTwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
    }
}