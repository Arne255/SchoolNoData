namespace WindowsFormsApp1.Forms
{
    partial class frmAccountsList
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
            this.btnAddInfo_Secondary = new System.Windows.Forms.Button();
            this.btnRemove_Secondary = new System.Windows.Forms.Button();
            this.MainListView = new System.Windows.Forms.ListView();
            this.columnHeader58 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader65 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader66 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader68 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label45 = new System.Windows.Forms.Label();
            this.btn_Back_Third = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.Timer_ResetListView = new System.Windows.Forms.Timer(this.components);
            this.btnEnableAccount_Secondary = new System.Windows.Forms.Button();
            this.btnEnableAdmîn_Secondary = new System.Windows.Forms.Button();
            this.btnDisableAccount_Secondary = new System.Windows.Forms.Button();
            this.btnDisableAdmîn_Secondary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddInfo_Secondary
            // 
            this.btnAddInfo_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnAddInfo_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnAddInfo_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddInfo_Secondary.Location = new System.Drawing.Point(1174, 515);
            this.btnAddInfo_Secondary.Name = "btnAddInfo_Secondary";
            this.btnAddInfo_Secondary.Size = new System.Drawing.Size(180, 48);
            this.btnAddInfo_Secondary.TabIndex = 5;
            this.btnAddInfo_Secondary.Text = "Toevoegen";
            this.btnAddInfo_Secondary.UseVisualStyleBackColor = false;
            this.btnAddInfo_Secondary.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // btnRemove_Secondary
            // 
            this.btnRemove_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnRemove_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnRemove_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove_Secondary.Location = new System.Drawing.Point(1174, 569);
            this.btnRemove_Secondary.Name = "btnRemove_Secondary";
            this.btnRemove_Secondary.Size = new System.Drawing.Size(180, 48);
            this.btnRemove_Secondary.TabIndex = 5;
            this.btnRemove_Secondary.Text = "Verwijder";
            this.btnRemove_Secondary.UseVisualStyleBackColor = false;
            this.btnRemove_Secondary.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // MainListView
            // 
            this.MainListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.MainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader58,
            this.columnHeader1,
            this.columnHeader65,
            this.columnHeader66,
            this.columnHeader68,
            this.columnHeader2});
            this.MainListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainListView.ForeColor = System.Drawing.Color.White;
            this.MainListView.FullRowSelect = true;
            this.MainListView.HideSelection = false;
            this.MainListView.Location = new System.Drawing.Point(18, 317);
            this.MainListView.Name = "MainListView";
            this.MainListView.Size = new System.Drawing.Size(793, 372);
            this.MainListView.TabIndex = 13;
            this.MainListView.UseCompatibleStateImageBehavior = false;
            this.MainListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader58
            // 
            this.columnHeader58.Text = "ID";
            this.columnHeader58.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader65
            // 
            this.columnHeader65.Text = "Gebruikersnaam";
            this.columnHeader65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader65.Width = 195;
            // 
            // columnHeader66
            // 
            this.columnHeader66.Text = "Hash";
            this.columnHeader66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader66.Width = 329;
            // 
            // columnHeader68
            // 
            this.columnHeader68.Text = "IsAdmin";
            this.columnHeader68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader68.Width = 145;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IsEnabled";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 117;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Font = new System.Drawing.Font("Microsoft New Tai Lue", 60F, System.Drawing.FontStyle.Bold);
            this.label45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.label45.Location = new System.Drawing.Point(9, 15);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(388, 105);
            this.label45.TabIndex = 15;
            this.label45.Text = "Accounts";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_Back_Third.Click += new System.EventHandler(this.btn_Admin_frmAccountsList_Close_frmSettings_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Location = new System.Drawing.Point(1192, 12);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(162, 98);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 19;
            this.pictureBox11.TabStop = false;
            // 
            // Timer_ResetListView
            // 
            this.Timer_ResetListView.Enabled = true;
            this.Timer_ResetListView.Tick += new System.EventHandler(this.Timer_ResetListView_Tick);
            // 
            // btnEnableAccount_Secondary
            // 
            this.btnEnableAccount_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnEnableAccount_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnEnableAccount_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnableAccount_Secondary.Location = new System.Drawing.Point(1131, 334);
            this.btnEnableAccount_Secondary.Name = "btnEnableAccount_Secondary";
            this.btnEnableAccount_Secondary.Size = new System.Drawing.Size(221, 48);
            this.btnEnableAccount_Secondary.TabIndex = 5;
            this.btnEnableAccount_Secondary.Text = "Enable Account";
            this.btnEnableAccount_Secondary.UseVisualStyleBackColor = false;
            this.btnEnableAccount_Secondary.Click += new System.EventHandler(this.btnEnableAccount_Click);
            // 
            // btnEnableAdmîn_Secondary
            // 
            this.btnEnableAdmîn_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnEnableAdmîn_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnEnableAdmîn_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnableAdmîn_Secondary.Location = new System.Drawing.Point(1131, 218);
            this.btnEnableAdmîn_Secondary.Name = "btnEnableAdmîn_Secondary";
            this.btnEnableAdmîn_Secondary.Size = new System.Drawing.Size(221, 48);
            this.btnEnableAdmîn_Secondary.TabIndex = 5;
            this.btnEnableAdmîn_Secondary.Text = "Enable Admin";
            this.btnEnableAdmîn_Secondary.UseVisualStyleBackColor = false;
            this.btnEnableAdmîn_Secondary.Click += new System.EventHandler(this.btnEnableAdmîn_Click);
            // 
            // btnDisableAccount_Secondary
            // 
            this.btnDisableAccount_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnDisableAccount_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnDisableAccount_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDisableAccount_Secondary.Location = new System.Drawing.Point(1131, 388);
            this.btnDisableAccount_Secondary.Name = "btnDisableAccount_Secondary";
            this.btnDisableAccount_Secondary.Size = new System.Drawing.Size(221, 48);
            this.btnDisableAccount_Secondary.TabIndex = 5;
            this.btnDisableAccount_Secondary.Text = "Disable Account";
            this.btnDisableAccount_Secondary.UseVisualStyleBackColor = false;
            this.btnDisableAccount_Secondary.Click += new System.EventHandler(this.btnDisableAccount_Click);
            // 
            // btnDisableAdmîn_Secondary
            // 
            this.btnDisableAdmîn_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnDisableAdmîn_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnDisableAdmîn_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDisableAdmîn_Secondary.Location = new System.Drawing.Point(1131, 272);
            this.btnDisableAdmîn_Secondary.Name = "btnDisableAdmîn_Secondary";
            this.btnDisableAdmîn_Secondary.Size = new System.Drawing.Size(221, 48);
            this.btnDisableAdmîn_Secondary.TabIndex = 5;
            this.btnDisableAdmîn_Secondary.Text = "Disable Admin";
            this.btnDisableAdmîn_Secondary.UseVisualStyleBackColor = false;
            this.btnDisableAdmîn_Secondary.Click += new System.EventHandler(this.btnDisableAdmîn_Click);
            // 
            // frmAccountsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 701);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.btnDisableAdmîn_Secondary);
            this.Controls.Add(this.btnEnableAdmîn_Secondary);
            this.Controls.Add(this.btnDisableAccount_Secondary);
            this.Controls.Add(this.btnEnableAccount_Secondary);
            this.Controls.Add(this.btnAddInfo_Secondary);
            this.Controls.Add(this.btn_Back_Third);
            this.Controls.Add(this.btnRemove_Secondary);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.MainListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmAccountsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccountsList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAccountsList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Button btnAddInfo_Secondary;
        private System.Windows.Forms.Button btnRemove_Secondary;
        private System.Windows.Forms.ListView MainListView;
        private System.Windows.Forms.ColumnHeader columnHeader58;
        private System.Windows.Forms.ColumnHeader columnHeader65;
        private System.Windows.Forms.ColumnHeader columnHeader66;
        private System.Windows.Forms.ColumnHeader columnHeader68;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button btn_Back_Third;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer Timer_ResetListView;
        private System.Windows.Forms.Button btnEnableAccount_Secondary;
        private System.Windows.Forms.Button btnEnableAdmîn_Secondary;
        private System.Windows.Forms.Button btnDisableAccount_Secondary;
        private System.Windows.Forms.Button btnDisableAdmîn_Secondary;
    }
}