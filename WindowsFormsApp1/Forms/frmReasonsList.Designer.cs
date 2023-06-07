namespace WindowsFormsApp1.Forms
{
    partial class frmReasonsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReasonsList));
            this.ListViewMain = new System.Windows.Forms.ListView();
            this.columnHeader43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader44 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back_Third = new System.Windows.Forms.Button();
            this.btnAddReason_Secondary = new System.Windows.Forms.Button();
            this.btnRemoveReason_Secondary = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnSetCustom_Secondary = new System.Windows.Forms.Button();
            this.btnSetNonCustom_Secondary = new System.Windows.Forms.Button();
            this.btnSetInvalid_Secondary = new System.Windows.Forms.Button();
            this.btnSetValid_Secondary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewMain
            // 
            this.ListViewMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.ListViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader43,
            this.columnHeader3,
            this.columnHeader44,
            this.columnHeader1,
            this.columnHeader2});
            this.ListViewMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewMain.ForeColor = System.Drawing.Color.White;
            this.ListViewMain.FullRowSelect = true;
            this.ListViewMain.HideSelection = false;
            this.ListViewMain.Location = new System.Drawing.Point(18, 317);
            this.ListViewMain.Name = "ListViewMain";
            this.ListViewMain.Size = new System.Drawing.Size(966, 372);
            this.ListViewMain.TabIndex = 13;
            this.ListViewMain.UseCompatibleStateImageBehavior = false;
            this.ListViewMain.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader43
            // 
            this.columnHeader43.Text = "ID";
            this.columnHeader43.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 0;
            // 
            // columnHeader44
            // 
            this.columnHeader44.Text = "Reden";
            this.columnHeader44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader44.Width = 298;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Geldig:";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 291;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zichtbaar in Menu:";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 368;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 60F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 105);
            this.label1.TabIndex = 15;
            this.label1.Text = "Redenen Lijst";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_Back_Third.Click += new System.EventHandler(this.btn_Admin_frmReasonsList_Close_frmSettings_Click);
            // 
            // btnAddReason_Secondary
            // 
            this.btnAddReason_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnAddReason_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnAddReason_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddReason_Secondary.Location = new System.Drawing.Point(1172, 268);
            this.btnAddReason_Secondary.Name = "btnAddReason_Secondary";
            this.btnAddReason_Secondary.Size = new System.Drawing.Size(180, 48);
            this.btnAddReason_Secondary.TabIndex = 5;
            this.btnAddReason_Secondary.Text = "Toevoegen";
            this.btnAddReason_Secondary.UseVisualStyleBackColor = false;
            this.btnAddReason_Secondary.Click += new System.EventHandler(this.button34_Click);
            // 
            // btnRemoveReason_Secondary
            // 
            this.btnRemoveReason_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnRemoveReason_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnRemoveReason_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveReason_Secondary.Location = new System.Drawing.Point(1172, 322);
            this.btnRemoveReason_Secondary.Name = "btnRemoveReason_Secondary";
            this.btnRemoveReason_Secondary.Size = new System.Drawing.Size(180, 48);
            this.btnRemoveReason_Secondary.TabIndex = 5;
            this.btnRemoveReason_Secondary.Text = "Verwijder";
            this.btnRemoveReason_Secondary.UseVisualStyleBackColor = false;
            this.btnRemoveReason_Secondary.Click += new System.EventHandler(this.btn_frmReasons_RemoveReason_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1192, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(162, 98);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // btnSetCustom_Secondary
            // 
            this.btnSetCustom_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnSetCustom_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnSetCustom_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSetCustom_Secondary.Location = new System.Drawing.Point(1012, 493);
            this.btnSetCustom_Secondary.Name = "btnSetCustom_Secondary";
            this.btnSetCustom_Secondary.Size = new System.Drawing.Size(342, 48);
            this.btnSetCustom_Secondary.TabIndex = 5;
            this.btnSetCustom_Secondary.Text = "onzichtbaar maken in menu";
            this.btnSetCustom_Secondary.UseVisualStyleBackColor = false;
            this.btnSetCustom_Secondary.Click += new System.EventHandler(this.btnSetCustom_Secondary_Click);
            // 
            // btnSetNonCustom_Secondary
            // 
            this.btnSetNonCustom_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnSetNonCustom_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnSetNonCustom_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSetNonCustom_Secondary.Location = new System.Drawing.Point(1012, 547);
            this.btnSetNonCustom_Secondary.Name = "btnSetNonCustom_Secondary";
            this.btnSetNonCustom_Secondary.Size = new System.Drawing.Size(342, 48);
            this.btnSetNonCustom_Secondary.TabIndex = 5;
            this.btnSetNonCustom_Secondary.Text = "zichtbaar maken in menu";
            this.btnSetNonCustom_Secondary.UseVisualStyleBackColor = false;
            this.btnSetNonCustom_Secondary.Click += new System.EventHandler(this.btnSetNonCustom_Secondary_Click);
            // 
            // btnSetInvalid_Secondary
            // 
            this.btnSetInvalid_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnSetInvalid_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnSetInvalid_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSetInvalid_Secondary.Location = new System.Drawing.Point(1172, 378);
            this.btnSetInvalid_Secondary.Name = "btnSetInvalid_Secondary";
            this.btnSetInvalid_Secondary.Size = new System.Drawing.Size(180, 48);
            this.btnSetInvalid_Secondary.TabIndex = 5;
            this.btnSetInvalid_Secondary.Text = "zet ongeldig";
            this.btnSetInvalid_Secondary.UseVisualStyleBackColor = false;
            this.btnSetInvalid_Secondary.Click += new System.EventHandler(this.btnSetInvalid_Secondary_Click);
            // 
            // btnSetValid_Secondary
            // 
            this.btnSetValid_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnSetValid_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnSetValid_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSetValid_Secondary.Location = new System.Drawing.Point(1172, 432);
            this.btnSetValid_Secondary.Name = "btnSetValid_Secondary";
            this.btnSetValid_Secondary.Size = new System.Drawing.Size(180, 48);
            this.btnSetValid_Secondary.TabIndex = 5;
            this.btnSetValid_Secondary.Text = "Zet geldig";
            this.btnSetValid_Secondary.UseVisualStyleBackColor = false;
            this.btnSetValid_Secondary.Click += new System.EventHandler(this.btnSetValid_Secondary_Click);
            // 
            // frmReasonsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 701);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.ListViewMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Back_Third);
            this.Controls.Add(this.btnAddReason_Secondary);
            this.Controls.Add(this.btnSetValid_Secondary);
            this.Controls.Add(this.btnSetNonCustom_Secondary);
            this.Controls.Add(this.btnSetInvalid_Secondary);
            this.Controls.Add(this.btnSetCustom_Secondary);
            this.Controls.Add(this.btnRemoveReason_Secondary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmReasonsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReasonsList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReasonsList_FormClosed);
            this.Load += new System.EventHandler(this.frmReasonsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ListViewMain;
        private System.Windows.Forms.ColumnHeader columnHeader43;
        private System.Windows.Forms.ColumnHeader columnHeader44;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back_Third;
        private System.Windows.Forms.Button btnAddReason_Secondary;
        private System.Windows.Forms.Button btnRemoveReason_Secondary;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSetCustom_Secondary;
        private System.Windows.Forms.Button btnSetNonCustom_Secondary;
        private System.Windows.Forms.Button btnSetInvalid_Secondary;
        private System.Windows.Forms.Button btnSetValid_Secondary;
    }
}