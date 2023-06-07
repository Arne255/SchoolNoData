namespace WindowsFormsApp1.Forms
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnStudentsList_Secondary = new System.Windows.Forms.Button();
            this.grp_LoggedInInfo = new System.Windows.Forms.GroupBox();
            this.lblIngelogdAs = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.btn_Admin_frmMenu_Open_frmSettings = new System.Windows.Forms.Button();
            this.btn_Logout_Third = new System.Windows.Forms.Button();
            this.btnSanctionList_Secondary = new System.Windows.Forms.Button();
            this.btnLateList_Secondary = new System.Windows.Forms.Button();
            this.btnScanner_Secondary = new System.Windows.Forms.Button();
            this.btnToDoList_Secondary = new System.Windows.Forms.Button();
            this.btnEarlyOnSchool_Secondary = new System.Windows.Forms.Button();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveOnline_Secondary = new System.Windows.Forms.Button();
            this.grp_LoggedInInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStudentsList_Secondary
            // 
            this.btnStudentsList_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnStudentsList_Secondary.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentsList_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudentsList_Secondary.Location = new System.Drawing.Point(29, 434);
            this.btnStudentsList_Secondary.Name = "btnStudentsList_Secondary";
            this.btnStudentsList_Secondary.Size = new System.Drawing.Size(238, 48);
            this.btnStudentsList_Secondary.TabIndex = 5;
            this.btnStudentsList_Secondary.Text = "Studenten";
            this.btnStudentsList_Secondary.UseVisualStyleBackColor = false;
            this.btnStudentsList_Secondary.Click += new System.EventHandler(this.btn_frmMenu_Open_frmStudentsList_Click);
            // 
            // grp_LoggedInInfo
            // 
            this.grp_LoggedInInfo.Controls.Add(this.lblIngelogdAs);
            this.grp_LoggedInInfo.Controls.Add(this.lblAccountName);
            this.grp_LoggedInInfo.Location = new System.Drawing.Point(12, 12);
            this.grp_LoggedInInfo.Name = "grp_LoggedInInfo";
            this.grp_LoggedInInfo.Size = new System.Drawing.Size(226, 52);
            this.grp_LoggedInInfo.TabIndex = 19;
            this.grp_LoggedInInfo.TabStop = false;
            // 
            // lblIngelogdAs
            // 
            this.lblIngelogdAs.AutoSize = true;
            this.lblIngelogdAs.BackColor = System.Drawing.Color.Transparent;
            this.lblIngelogdAs.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngelogdAs.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblIngelogdAs.Location = new System.Drawing.Point(6, 16);
            this.lblIngelogdAs.Name = "lblIngelogdAs";
            this.lblIngelogdAs.Size = new System.Drawing.Size(139, 27);
            this.lblIngelogdAs.TabIndex = 0;
            this.lblIngelogdAs.Text = "Ingelogd als:";
            this.lblIngelogdAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountName.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblAccountName.Location = new System.Drawing.Point(145, 16);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(72, 27);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "{USER}";
            this.lblAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Admin_frmMenu_Open_frmSettings
            // 
            this.btn_Admin_frmMenu_Open_frmSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(99)))));
            this.btn_Admin_frmMenu_Open_frmSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Admin_frmMenu_Open_frmSettings.FlatAppearance.BorderSize = 0;
            this.btn_Admin_frmMenu_Open_frmSettings.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin_frmMenu_Open_frmSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Admin_frmMenu_Open_frmSettings.Location = new System.Drawing.Point(29, 490);
            this.btn_Admin_frmMenu_Open_frmSettings.Name = "btn_Admin_frmMenu_Open_frmSettings";
            this.btn_Admin_frmMenu_Open_frmSettings.Size = new System.Drawing.Size(494, 61);
            this.btn_Admin_frmMenu_Open_frmSettings.TabIndex = 4;
            this.btn_Admin_frmMenu_Open_frmSettings.Text = "Instellingen";
            this.btn_Admin_frmMenu_Open_frmSettings.UseVisualStyleBackColor = false;
            this.btn_Admin_frmMenu_Open_frmSettings.Click += new System.EventHandler(this.btn_Admin_frmMenu_Open_frmSettings_Click);
            // 
            // btn_Logout_Third
            // 
            this.btn_Logout_Third.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(22)))), ((int)(((byte)(47)))));
            this.btn_Logout_Third.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout_Third.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Logout_Third.Location = new System.Drawing.Point(1178, 634);
            this.btn_Logout_Third.Name = "btn_Logout_Third";
            this.btn_Logout_Third.Size = new System.Drawing.Size(174, 55);
            this.btn_Logout_Third.TabIndex = 3;
            this.btn_Logout_Third.Text = "Uitloggen";
            this.btn_Logout_Third.UseVisualStyleBackColor = false;
            this.btn_Logout_Third.Click += new System.EventHandler(this.btn_frmMenu_Logout_frmLogin_Click);
            // 
            // btnSanctionList_Secondary
            // 
            this.btnSanctionList_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnSanctionList_Secondary.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanctionList_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSanctionList_Secondary.Location = new System.Drawing.Point(285, 434);
            this.btnSanctionList_Secondary.Name = "btnSanctionList_Secondary";
            this.btnSanctionList_Secondary.Size = new System.Drawing.Size(238, 50);
            this.btnSanctionList_Secondary.TabIndex = 3;
            this.btnSanctionList_Secondary.Text = "Sancties";
            this.btnSanctionList_Secondary.UseVisualStyleBackColor = false;
            this.btnSanctionList_Secondary.Click += new System.EventHandler(this.btn_frmMenu_Open_frmSanctionList_Click);
            // 
            // btnLateList_Secondary
            // 
            this.btnLateList_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnLateList_Secondary.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLateList_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLateList_Secondary.Location = new System.Drawing.Point(285, 374);
            this.btnLateList_Secondary.Name = "btnLateList_Secondary";
            this.btnLateList_Secondary.Size = new System.Drawing.Size(238, 48);
            this.btnLateList_Secondary.TabIndex = 3;
            this.btnLateList_Secondary.Text = "Te Laat Lijst";
            this.btnLateList_Secondary.UseVisualStyleBackColor = false;
            this.btnLateList_Secondary.Click += new System.EventHandler(this.btn_frmMenu_Open_frmLatesList_Click);
            // 
            // btnScanner_Secondary
            // 
            this.btnScanner_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnScanner_Secondary.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanner_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScanner_Secondary.Location = new System.Drawing.Point(29, 374);
            this.btnScanner_Secondary.Name = "btnScanner_Secondary";
            this.btnScanner_Secondary.Size = new System.Drawing.Size(238, 47);
            this.btnScanner_Secondary.TabIndex = 3;
            this.btnScanner_Secondary.Text = "Scanner";
            this.btnScanner_Secondary.UseVisualStyleBackColor = false;
            this.btnScanner_Secondary.Click += new System.EventHandler(this.btn_frmMenu_Open_frmScanner_Click);
            // 
            // btnToDoList_Secondary
            // 
            this.btnToDoList_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnToDoList_Secondary.Enabled = false;
            this.btnToDoList_Secondary.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToDoList_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnToDoList_Secondary.Location = new System.Drawing.Point(23, 640);
            this.btnToDoList_Secondary.Name = "btnToDoList_Secondary";
            this.btnToDoList_Secondary.Size = new System.Drawing.Size(206, 48);
            this.btnToDoList_Secondary.TabIndex = 3;
            this.btnToDoList_Secondary.Text = "To Do List";
            this.btnToDoList_Secondary.UseVisualStyleBackColor = false;
            this.btnToDoList_Secondary.Visible = false;
            this.btnToDoList_Secondary.Click += new System.EventHandler(this.btn_frmMenu_Open_frmToDoList_Click);
            // 
            // btnEarlyOnSchool_Secondary
            // 
            this.btnEarlyOnSchool_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnEarlyOnSchool_Secondary.Enabled = false;
            this.btnEarlyOnSchool_Secondary.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEarlyOnSchool_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEarlyOnSchool_Secondary.Location = new System.Drawing.Point(23, 586);
            this.btnEarlyOnSchool_Secondary.Name = "btnEarlyOnSchool_Secondary";
            this.btnEarlyOnSchool_Secondary.Size = new System.Drawing.Size(206, 48);
            this.btnEarlyOnSchool_Secondary.TabIndex = 3;
            this.btnEarlyOnSchool_Secondary.Text = "Vroeg Op School";
            this.btnEarlyOnSchool_Secondary.UseVisualStyleBackColor = false;
            this.btnEarlyOnSchool_Secondary.Visible = false;
            this.btnEarlyOnSchool_Secondary.Click += new System.EventHandler(this.btn_frmMenu_Open_frmEarlyOnSchool_Click);
            // 
            // pct_logo
            // 
            this.pct_logo.BackColor = System.Drawing.Color.Transparent;
            this.pct_logo.Image = ((System.Drawing.Image)(resources.GetObject("pct_logo.Image")));
            this.pct_logo.Location = new System.Drawing.Point(29, 29);
            this.pct_logo.Name = "pct_logo";
            this.pct_logo.Size = new System.Drawing.Size(494, 277);
            this.pct_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_logo.TabIndex = 18;
            this.pct_logo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btn_Admin_frmMenu_Open_frmSettings);
            this.groupBox1.Controls.Add(this.btnStudentsList_Secondary);
            this.groupBox1.Controls.Add(this.btnSanctionList_Secondary);
            this.groupBox1.Controls.Add(this.btnLateList_Secondary);
            this.groupBox1.Controls.Add(this.pct_logo);
            this.groupBox1.Controls.Add(this.btnScanner_Secondary);
            this.groupBox1.Location = new System.Drawing.Point(417, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 579);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(18, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Probably Removing:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // btnSaveOnline_Secondary
            // 
            this.btnSaveOnline_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnSaveOnline_Secondary.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOnline_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveOnline_Secondary.Location = new System.Drawing.Point(1030, 8);
            this.btnSaveOnline_Secondary.Name = "btnSaveOnline_Secondary";
            this.btnSaveOnline_Secondary.Size = new System.Drawing.Size(322, 47);
            this.btnSaveOnline_Secondary.TabIndex = 3;
            this.btnSaveOnline_Secondary.Text = "Kopieer DB naar Online DB";
            this.btnSaveOnline_Secondary.UseVisualStyleBackColor = false;
            this.btnSaveOnline_Secondary.Visible = false;
            this.btnSaveOnline_Secondary.Click += new System.EventHandler(this.btn_frmMenu_SlaOnlineOp_frmMenu_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_LoggedInInfo);
            this.Controls.Add(this.btn_Logout_Third);
            this.Controls.Add(this.btnToDoList_Secondary);
            this.Controls.Add(this.btnSaveOnline_Secondary);
            this.Controls.Add(this.btnEarlyOnSchool_Secondary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Activated += new System.EventHandler(this.frmMenu_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.grp_LoggedInInfo.ResumeLayout(false);
            this.grp_LoggedInInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStudentsList_Secondary;
        private System.Windows.Forms.GroupBox grp_LoggedInInfo;
        private System.Windows.Forms.Label lblIngelogdAs;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.PictureBox pct_logo;
        private System.Windows.Forms.Button btn_Admin_frmMenu_Open_frmSettings;
        private System.Windows.Forms.Button btn_Logout_Third;
        private System.Windows.Forms.Button btnSanctionList_Secondary;
        private System.Windows.Forms.Button btnLateList_Secondary;
        private System.Windows.Forms.Button btnScanner_Secondary;
        private System.Windows.Forms.Button btnToDoList_Secondary;
        private System.Windows.Forms.Button btnEarlyOnSchool_Secondary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveOnline_Secondary;
    }
}