namespace WindowsFormsApp1.Forms
{
    partial class frmScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScanner));
            this.btnOpenStudentList_Secondary = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ViewModelLatesHistory = new System.Windows.Forms.ListView();
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpReason = new System.Windows.Forms.GroupBox();
            this.lstbReden = new System.Windows.Forms.ListBox();
            this.btnAndereGeldig_Secondary = new System.Windows.Forms.Button();
            this.btnAndereNietGeldig_Secondary = new System.Windows.Forms.Button();
            this.lstbZonderReden = new System.Windows.Forms.ListBox();
            this.lblMetReden = new System.Windows.Forms.Label();
            this.lblZonderReden = new System.Windows.Forms.Label();
            this.lblScanner = new System.Windows.Forms.Label();
            this.btn_Back_Third = new System.Windows.Forms.Button();
            this.btnOpslaan_Secondary = new System.Windows.Forms.Button();
            this.tmrResetListView = new System.Windows.Forms.Timer(this.components);
            this.tmrScan = new System.Windows.Forms.Timer(this.components);
            this.resetTimeout = new System.Windows.Forms.Timer(this.components);
            this.btnCancel_Secondary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKlas = new System.Windows.Forms.Label();
            this.lblTownshipOne = new System.Windows.Forms.Label();
            this.lblTownshipTwo = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tmrLetUserKnow = new System.Windows.Forms.Timer(this.components);
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.txtAutoScanTwo = new System.Windows.Forms.TextBox();
            this.btnScanTwo_Secondary = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.grpReason.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenStudentList_Secondary
            // 
            this.btnOpenStudentList_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnOpenStudentList_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnOpenStudentList_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenStudentList_Secondary.Location = new System.Drawing.Point(27, 278);
            this.btnOpenStudentList_Secondary.Name = "btnOpenStudentList_Secondary";
            this.btnOpenStudentList_Secondary.Size = new System.Drawing.Size(233, 48);
            this.btnOpenStudentList_Secondary.TabIndex = 5;
            this.btnOpenStudentList_Secondary.Text = "Studenten Lijst";
            this.btnOpenStudentList_Secondary.UseVisualStyleBackColor = false;
            this.btnOpenStudentList_Secondary.Click += new System.EventHandler(this.btnOpenStudentList_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.ViewModelLatesHistory);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.groupBox4.Location = new System.Drawing.Point(490, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(661, 656);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Te laat geschiedenis";
            // 
            // ViewModelLatesHistory
            // 
            this.ViewModelLatesHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.ViewModelLatesHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader28,
            this.columnHeader1,
            this.columnHeader35,
            this.columnHeader23,
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader31});
            this.ViewModelLatesHistory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewModelLatesHistory.ForeColor = System.Drawing.Color.White;
            this.ViewModelLatesHistory.FullRowSelect = true;
            this.ViewModelLatesHistory.HideSelection = false;
            this.ViewModelLatesHistory.Location = new System.Drawing.Point(19, 44);
            this.ViewModelLatesHistory.Name = "ViewModelLatesHistory";
            this.ViewModelLatesHistory.Size = new System.Drawing.Size(624, 551);
            this.ViewModelLatesHistory.TabIndex = 14;
            this.ViewModelLatesHistory.UseCompatibleStateImageBehavior = false;
            this.ViewModelLatesHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "ID";
            this.columnHeader28.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "Reden";
            this.columnHeader35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader35.Width = 191;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Andere Reden";
            this.columnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader23.Width = 150;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Geldig";
            this.columnHeader29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader29.Width = 76;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Tijd";
            this.columnHeader30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader30.Width = 65;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "Datum";
            this.columnHeader31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader31.Width = 134;
            // 
            // grpReason
            // 
            this.grpReason.BackColor = System.Drawing.Color.Transparent;
            this.grpReason.Controls.Add(this.lstbReden);
            this.grpReason.Controls.Add(this.btnAndereGeldig_Secondary);
            this.grpReason.Controls.Add(this.btnAndereNietGeldig_Secondary);
            this.grpReason.Controls.Add(this.lstbZonderReden);
            this.grpReason.Controls.Add(this.lblMetReden);
            this.grpReason.Controls.Add(this.lblZonderReden);
            this.grpReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.grpReason.Location = new System.Drawing.Point(27, 327);
            this.grpReason.Name = "grpReason";
            this.grpReason.Size = new System.Drawing.Size(464, 357);
            this.grpReason.TabIndex = 12;
            this.grpReason.TabStop = false;
            this.grpReason.Text = "Reden";
            // 
            // lstbReden
            // 
            this.lstbReden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.lstbReden.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbReden.ForeColor = System.Drawing.Color.White;
            this.lstbReden.FormattingEnabled = true;
            this.lstbReden.ItemHeight = 31;
            this.lstbReden.Items.AddRange(new object[] {
            "Bus",
            "Fiets",
            "Te laat in klas",
            "Trein",
            "Verkeer",
            "Ziek"});
            this.lstbReden.Location = new System.Drawing.Point(243, 75);
            this.lstbReden.Name = "lstbReden";
            this.lstbReden.Size = new System.Drawing.Size(200, 221);
            this.lstbReden.TabIndex = 10;
            this.lstbReden.SelectedIndexChanged += new System.EventHandler(this.lstbReden_SelectedIndexChanged);
            // 
            // btnAndereGeldig_Secondary
            // 
            this.btnAndereGeldig_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnAndereGeldig_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnAndereGeldig_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAndereGeldig_Secondary.Location = new System.Drawing.Point(243, 300);
            this.btnAndereGeldig_Secondary.Name = "btnAndereGeldig_Secondary";
            this.btnAndereGeldig_Secondary.Size = new System.Drawing.Size(200, 51);
            this.btnAndereGeldig_Secondary.TabIndex = 7;
            this.btnAndereGeldig_Secondary.Text = "Andere";
            this.btnAndereGeldig_Secondary.UseVisualStyleBackColor = false;
            this.btnAndereGeldig_Secondary.Click += new System.EventHandler(this.btnAndereGeldig_Click);
            // 
            // btnAndereNietGeldig_Secondary
            // 
            this.btnAndereNietGeldig_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnAndereNietGeldig_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnAndereNietGeldig_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAndereNietGeldig_Secondary.Location = new System.Drawing.Point(16, 300);
            this.btnAndereNietGeldig_Secondary.Name = "btnAndereNietGeldig_Secondary";
            this.btnAndereNietGeldig_Secondary.Size = new System.Drawing.Size(197, 51);
            this.btnAndereNietGeldig_Secondary.TabIndex = 7;
            this.btnAndereNietGeldig_Secondary.Text = "Andere";
            this.btnAndereNietGeldig_Secondary.UseVisualStyleBackColor = false;
            this.btnAndereNietGeldig_Secondary.Click += new System.EventHandler(this.btnAndereNietGeldig_Click);
            // 
            // lstbZonderReden
            // 
            this.lstbZonderReden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.lstbZonderReden.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbZonderReden.ForeColor = System.Drawing.Color.White;
            this.lstbZonderReden.FormattingEnabled = true;
            this.lstbZonderReden.ItemHeight = 31;
            this.lstbZonderReden.Items.AddRange(new object[] {
            "Bus gemist",
            "Overslapen"});
            this.lstbZonderReden.Location = new System.Drawing.Point(16, 75);
            this.lstbZonderReden.Name = "lstbZonderReden";
            this.lstbZonderReden.Size = new System.Drawing.Size(197, 221);
            this.lstbZonderReden.TabIndex = 10;
            this.lstbZonderReden.SelectedIndexChanged += new System.EventHandler(this.lstbZonderReden_SelectedIndexChanged);
            // 
            // lblMetReden
            // 
            this.lblMetReden.AutoSize = true;
            this.lblMetReden.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetReden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.lblMetReden.Location = new System.Drawing.Point(238, 42);
            this.lblMetReden.Name = "lblMetReden";
            this.lblMetReden.Size = new System.Drawing.Size(81, 26);
            this.lblMetReden.TabIndex = 8;
            this.lblMetReden.Text = "Geldig:";
            // 
            // lblZonderReden
            // 
            this.lblZonderReden.AutoSize = true;
            this.lblZonderReden.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZonderReden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.lblZonderReden.Location = new System.Drawing.Point(16, 42);
            this.lblZonderReden.Name = "lblZonderReden";
            this.lblZonderReden.Size = new System.Drawing.Size(121, 26);
            this.lblZonderReden.TabIndex = 8;
            this.lblZonderReden.Text = "Niet geldig:";
            // 
            // lblScanner
            // 
            this.lblScanner.AutoSize = true;
            this.lblScanner.Font = new System.Drawing.Font("Microsoft New Tai Lue", 60F, System.Drawing.FontStyle.Bold);
            this.lblScanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.lblScanner.Location = new System.Drawing.Point(9, 15);
            this.lblScanner.Name = "lblScanner";
            this.lblScanner.Size = new System.Drawing.Size(342, 105);
            this.lblScanner.TabIndex = 0;
            this.lblScanner.Text = "Scanner";
            this.lblScanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnOpslaan_Secondary
            // 
            this.btnOpslaan_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnOpslaan_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnOpslaan_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpslaan_Secondary.Location = new System.Drawing.Point(509, 629);
            this.btnOpslaan_Secondary.Name = "btnOpslaan_Secondary";
            this.btnOpslaan_Secondary.Size = new System.Drawing.Size(624, 49);
            this.btnOpslaan_Secondary.TabIndex = 7;
            this.btnOpslaan_Secondary.Text = "Opslaan";
            this.btnOpslaan_Secondary.UseVisualStyleBackColor = false;
            this.btnOpslaan_Secondary.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // tmrResetListView
            // 
            this.tmrResetListView.Enabled = true;
            this.tmrResetListView.Tick += new System.EventHandler(this.tmrResetListView_Tick);
            // 
            // tmrScan
            // 
            this.tmrScan.Enabled = true;
            this.tmrScan.Interval = 1;
            this.tmrScan.Tick += new System.EventHandler(this.tmrScan_Tick);
            // 
            // resetTimeout
            // 
            this.resetTimeout.Enabled = true;
            this.resetTimeout.Interval = 1000;
            this.resetTimeout.Tick += new System.EventHandler(this.resetTimeout_Tick);
            // 
            // btnCancel_Secondary
            // 
            this.btnCancel_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnCancel_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnCancel_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel_Secondary.Location = new System.Drawing.Point(270, 279);
            this.btnCancel_Secondary.Name = "btnCancel_Secondary";
            this.btnCancel_Secondary.Size = new System.Drawing.Size(200, 47);
            this.btnCancel_Secondary.TabIndex = 5;
            this.btnCancel_Secondary.Text = "Annuleren";
            this.btnCancel_Secondary.UseVisualStyleBackColor = false;
            this.btnCancel_Secondary.Click += new System.EventHandler(this.btn_frmScanner_Annuleren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(22, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Klas:                 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label2.Location = new System.Drawing.Point(22, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gemeente Één:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label3.Location = new System.Drawing.Point(22, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gemeente Twee:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label4.Location = new System.Drawing.Point(22, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Achternaam:    ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label5.Location = new System.Drawing.Point(22, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Voornaam:       ";
            // 
            // lblKlas
            // 
            this.lblKlas.AutoSize = true;
            this.lblKlas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.lblKlas.Location = new System.Drawing.Point(265, 182);
            this.lblKlas.Name = "lblKlas";
            this.lblKlas.Size = new System.Drawing.Size(0, 26);
            this.lblKlas.TabIndex = 6;
            // 
            // lblTownshipOne
            // 
            this.lblTownshipOne.AutoSize = true;
            this.lblTownshipOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTownshipOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.lblTownshipOne.Location = new System.Drawing.Point(265, 213);
            this.lblTownshipOne.Name = "lblTownshipOne";
            this.lblTownshipOne.Size = new System.Drawing.Size(0, 26);
            this.lblTownshipOne.TabIndex = 6;
            // 
            // lblTownshipTwo
            // 
            this.lblTownshipTwo.AutoSize = true;
            this.lblTownshipTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTownshipTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.lblTownshipTwo.Location = new System.Drawing.Point(265, 244);
            this.lblTownshipTwo.Name = "lblTownshipTwo";
            this.lblTownshipTwo.Size = new System.Drawing.Size(0, 26);
            this.lblTownshipTwo.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.lblLastName.Location = new System.Drawing.Point(265, 151);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(0, 26);
            this.lblLastName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.lblName.Location = new System.Drawing.Point(265, 120);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 26);
            this.lblName.TabIndex = 6;
            // 
            // tmrLetUserKnow
            // 
            this.tmrLetUserKnow.Enabled = true;
            this.tmrLetUserKnow.Tick += new System.EventHandler(this.tmrLetUserKnow_Tick);
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(1192, 12);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(162, 98);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox24.TabIndex = 18;
            this.pictureBox24.TabStop = false;
            // 
            // txtAutoScanTwo
            // 
            this.txtAutoScanTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoScanTwo.Location = new System.Drawing.Point(27, 94);
            this.txtAutoScanTwo.Name = "txtAutoScanTwo";
            this.txtAutoScanTwo.Size = new System.Drawing.Size(295, 26);
            this.txtAutoScanTwo.TabIndex = 19;
            this.txtAutoScanTwo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAutoScanTwo_KeyDown);
            // 
            // btnScanTwo_Secondary
            // 
            this.btnScanTwo_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnScanTwo_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScanTwo_Secondary.Location = new System.Drawing.Point(328, 94);
            this.btnScanTwo_Secondary.Name = "btnScanTwo_Secondary";
            this.btnScanTwo_Secondary.Size = new System.Drawing.Size(142, 26);
            this.btnScanTwo_Secondary.TabIndex = 1;
            this.btnScanTwo_Secondary.Text = "Scan Code";
            this.btnScanTwo_Secondary.UseVisualStyleBackColor = false;
            this.btnScanTwo_Secondary.Click += new System.EventHandler(this.btnScanTwo_Secondary_Click);
            // 
            // frmScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 701);
            this.Controls.Add(this.btnScanTwo_Secondary);
            this.Controls.Add(this.txtAutoScanTwo);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.btnOpslaan_Secondary);
            this.Controls.Add(this.btnCancel_Secondary);
            this.Controls.Add(this.btnOpenStudentList_Secondary);
            this.Controls.Add(this.lblScanner);
            this.Controls.Add(this.btn_Back_Third);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpReason);
            this.Controls.Add(this.lblTownshipTwo);
            this.Controls.Add(this.lblTownshipOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKlas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scanner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmScanner_FormClosed);
            this.Load += new System.EventHandler(this.frmScanner_Load);
            this.groupBox4.ResumeLayout(false);
            this.grpReason.ResumeLayout(false);
            this.grpReason.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.Button btnOpenStudentList_Secondary;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView ViewModelLatesHistory;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.GroupBox grpReason;
        private System.Windows.Forms.ListBox lstbReden;
        private System.Windows.Forms.Button btnAndereGeldig_Secondary;
        private System.Windows.Forms.Button btnAndereNietGeldig_Secondary;
        private System.Windows.Forms.ListBox lstbZonderReden;
        private System.Windows.Forms.Label lblMetReden;
        private System.Windows.Forms.Label lblZonderReden;
        private System.Windows.Forms.Label lblScanner;
        private System.Windows.Forms.Button btn_Back_Third;
        private System.Windows.Forms.Button btnOpslaan_Secondary;
        private System.Windows.Forms.Timer tmrResetListView;
        private System.Windows.Forms.Timer tmrScan;
        private System.Windows.Forms.Timer resetTimeout;
        private System.Windows.Forms.Button btnCancel_Secondary;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKlas;
        private System.Windows.Forms.Label lblTownshipOne;
        private System.Windows.Forms.Label lblTownshipTwo;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Timer tmrLetUserKnow;
        private System.Windows.Forms.TextBox txtAutoScanTwo;
        private System.Windows.Forms.Button btnScanTwo_Secondary;
    }
}