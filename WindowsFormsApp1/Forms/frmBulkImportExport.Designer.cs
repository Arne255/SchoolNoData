namespace WindowsFormsApp1.Forms
{
    partial class frmBulkImportExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBulkImportExport));
            this.btn_BulkImport_Secondary = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.btn_Back_Third = new System.Windows.Forms.Button();
            this.button2_Secondary = new System.Windows.Forms.Button();
            this.MainListView = new System.Windows.Forms.ListView();
            this.columnHeader47 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader48 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader53 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader54 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label42 = new System.Windows.Forms.Label();
            this.btnUpload_Secondary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BulkImport_Secondary
            // 
            this.btn_BulkImport_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btn_BulkImport_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btn_BulkImport_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BulkImport_Secondary.Location = new System.Drawing.Point(1147, 319);
            this.btn_BulkImport_Secondary.Name = "btn_BulkImport_Secondary";
            this.btn_BulkImport_Secondary.Size = new System.Drawing.Size(205, 57);
            this.btn_BulkImport_Secondary.TabIndex = 7;
            this.btn_BulkImport_Secondary.Text = "Bulk Import";
            this.btn_BulkImport_Secondary.UseVisualStyleBackColor = false;
            this.btn_BulkImport_Secondary.Click += new System.EventHandler(this.btn_BulkImport_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Microsoft New Tai Lue", 60F, System.Drawing.FontStyle.Bold);
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.label32.Location = new System.Drawing.Point(9, 15);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(822, 105);
            this.label32.TabIndex = 18;
            this.label32.Text = "Bulk Import / Export";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(1192, 12);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(162, 98);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 20;
            this.pictureBox11.TabStop = false;
            // 
            // btn_Back_Third
            // 
            this.btn_Back_Third.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(22)))), ((int)(((byte)(47)))));
            this.btn_Back_Third.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btn_Back_Third.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Back_Third.Location = new System.Drawing.Point(1232, 636);
            this.btn_Back_Third.Name = "btn_Back_Third";
            this.btn_Back_Third.Size = new System.Drawing.Size(120, 48);
            this.btn_Back_Third.TabIndex = 21;
            this.btn_Back_Third.Text = "Terug";
            this.btn_Back_Third.UseVisualStyleBackColor = false;
            this.btn_Back_Third.Click += new System.EventHandler(this.btn_Admin_frmBulkImportExport_Close_frmSettings_Click);
            // 
            // button2_Secondary
            // 
            this.button2_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.button2_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.button2_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2_Secondary.Location = new System.Drawing.Point(1240, 252);
            this.button2_Secondary.Name = "button2_Secondary";
            this.button2_Secondary.Size = new System.Drawing.Size(114, 57);
            this.button2_Secondary.TabIndex = 7;
            this.button2_Secondary.Text = "Tutorial";
            this.button2_Secondary.UseVisualStyleBackColor = false;
            // 
            // MainListView
            // 
            this.MainListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.MainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader47,
            this.columnHeader48,
            this.columnHeader53,
            this.columnHeader54,
            this.columnHeader3,
            this.columnHeader2});
            this.MainListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MainListView.ForeColor = System.Drawing.Color.White;
            this.MainListView.FullRowSelect = true;
            this.MainListView.HideSelection = false;
            this.MainListView.Location = new System.Drawing.Point(18, 317);
            this.MainListView.Name = "MainListView";
            this.MainListView.Size = new System.Drawing.Size(1109, 372);
            this.MainListView.TabIndex = 22;
            this.MainListView.UseCompatibleStateImageBehavior = false;
            this.MainListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader47
            // 
            this.columnHeader47.Text = "CardUID";
            this.columnHeader47.Width = 0;
            // 
            // columnHeader48
            // 
            this.columnHeader48.Text = "Naam";
            this.columnHeader48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader48.Width = 172;
            // 
            // columnHeader53
            // 
            this.columnHeader53.Text = "Voornaam";
            this.columnHeader53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader53.Width = 204;
            // 
            // columnHeader54
            // 
            this.columnHeader54.Text = "Gemeente Één";
            this.columnHeader54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader54.Width = 205;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gemeente Twee";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Klas";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 210;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.label42.Location = new System.Drawing.Point(12, 251);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(974, 63);
            this.label42.TabIndex = 23;
            this.label42.Text = "Studenten die zullen toegevoed worden";
            // 
            // btnUpload_Secondary
            // 
            this.btnUpload_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnUpload_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnUpload_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpload_Secondary.Location = new System.Drawing.Point(1217, 382);
            this.btnUpload_Secondary.Name = "btnUpload_Secondary";
            this.btnUpload_Secondary.Size = new System.Drawing.Size(135, 69);
            this.btnUpload_Secondary.TabIndex = 7;
            this.btnUpload_Secondary.Text = "Upload";
            this.btnUpload_Secondary.UseVisualStyleBackColor = false;
            this.btnUpload_Secondary.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // frmBulkImportExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1368, 705);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.MainListView);
            this.Controls.Add(this.btn_Back_Third);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.btnUpload_Secondary);
            this.Controls.Add(this.button2_Secondary);
            this.Controls.Add(this.btn_BulkImport_Secondary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmBulkImportExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBulkImportExport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBulkImportExport_FormClosed);
            this.Load += new System.EventHandler(this.frmBulkImportExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_BulkImport_Secondary;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Button btn_Back_Third;
        private System.Windows.Forms.Button button2_Secondary;
        private System.Windows.Forms.ListView MainListView;
        private System.Windows.Forms.ColumnHeader columnHeader47;
        private System.Windows.Forms.ColumnHeader columnHeader48;
        private System.Windows.Forms.ColumnHeader columnHeader53;
        private System.Windows.Forms.ColumnHeader columnHeader54;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button btnUpload_Secondary;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}