namespace WindowsFormsApp1.Forms
{
    partial class frmToDoList
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Arne",
            "Mail sturen naar coach van Arne De Wolf voor afspraak over 5x telaat met reden"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToDoList));
            this.btn_Back_Third = new System.Windows.Forms.Button();
            this.lblLateList = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.listView10 = new System.Windows.Forms.ListView();
            this.columnHeader58 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader65 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader68 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLateListSearch_Secondary = new System.Windows.Forms.Button();
            this.btnRemove_Secondary = new System.Windows.Forms.Button();
            this.btnAdd_Secondary = new System.Windows.Forms.Button();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.btnMarkAsBeingWorkedOn_Secondary = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back_Third
            // 
            this.btn_Back_Third.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(22)))), ((int)(((byte)(47)))));
            this.btn_Back_Third.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btn_Back_Third.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Back_Third.Location = new System.Drawing.Point(1232, 636);
            this.btn_Back_Third.Name = "btn_Back_Third";
            this.btn_Back_Third.Size = new System.Drawing.Size(120, 48);
            this.btn_Back_Third.TabIndex = 20;
            this.btn_Back_Third.Text = "Terug";
            this.btn_Back_Third.UseVisualStyleBackColor = false;
            this.btn_Back_Third.Click += new System.EventHandler(this.btn_frmToDoList_Close_frmMenu_Click);
            // 
            // lblLateList
            // 
            this.lblLateList.AutoSize = true;
            this.lblLateList.BackColor = System.Drawing.Color.Transparent;
            this.lblLateList.Font = new System.Drawing.Font("Microsoft New Tai Lue", 60F, System.Drawing.FontStyle.Bold);
            this.lblLateList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.lblLateList.Location = new System.Drawing.Point(9, 15);
            this.lblLateList.Name = "lblLateList";
            this.lblLateList.Size = new System.Drawing.Size(446, 105);
            this.lblLateList.TabIndex = 21;
            this.lblLateList.Text = "To Do Lijst";
            this.lblLateList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.groupBox1.Location = new System.Drawing.Point(18, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 128);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(222, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(583, 29);
            this.textBox1.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox4.Location = new System.Drawing.Point(14, 69);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(202, 29);
            this.textBox4.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(218, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Omschrijving:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label14.Location = new System.Drawing.Point(10, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 24);
            this.label14.TabIndex = 12;
            this.label14.Text = "Gebruikersnaam:";
            // 
            // listView10
            // 
            this.listView10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.listView10.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader58,
            this.columnHeader65,
            this.columnHeader68});
            this.listView10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView10.ForeColor = System.Drawing.Color.White;
            this.listView10.FullRowSelect = true;
            this.listView10.HideSelection = false;
            this.listView10.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView10.Location = new System.Drawing.Point(18, 317);
            this.listView10.Name = "listView10";
            this.listView10.Size = new System.Drawing.Size(1023, 372);
            this.listView10.TabIndex = 23;
            this.listView10.UseCompatibleStateImageBehavior = false;
            this.listView10.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader58
            // 
            this.columnHeader58.Text = "ID";
            this.columnHeader58.Width = 54;
            // 
            // columnHeader65
            // 
            this.columnHeader65.Text = "Wordt Momenteel Uitgevoerd Door:";
            this.columnHeader65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader65.Width = 324;
            // 
            // columnHeader68
            // 
            this.columnHeader68.Text = "Omschrijving";
            this.columnHeader68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader68.Width = 633;
            // 
            // btnLateListSearch_Secondary
            // 
            this.btnLateListSearch_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnLateListSearch_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnLateListSearch_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLateListSearch_Secondary.Location = new System.Drawing.Point(18, 266);
            this.btnLateListSearch_Secondary.Name = "btnLateListSearch_Secondary";
            this.btnLateListSearch_Secondary.Size = new System.Drawing.Size(118, 45);
            this.btnLateListSearch_Secondary.TabIndex = 24;
            this.btnLateListSearch_Secondary.Text = "Zoek";
            this.btnLateListSearch_Secondary.UseVisualStyleBackColor = false;
            // 
            // btnRemove_Secondary
            // 
            this.btnRemove_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnRemove_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnRemove_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove_Secondary.Location = new System.Drawing.Point(1172, 448);
            this.btnRemove_Secondary.Name = "btnRemove_Secondary";
            this.btnRemove_Secondary.Size = new System.Drawing.Size(180, 48);
            this.btnRemove_Secondary.TabIndex = 27;
            this.btnRemove_Secondary.Text = "Verwijder";
            this.btnRemove_Secondary.UseVisualStyleBackColor = false;
            // 
            // btnAdd_Secondary
            // 
            this.btnAdd_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnAdd_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnAdd_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd_Secondary.Location = new System.Drawing.Point(1174, 394);
            this.btnAdd_Secondary.Name = "btnAdd_Secondary";
            this.btnAdd_Secondary.Size = new System.Drawing.Size(180, 48);
            this.btnAdd_Secondary.TabIndex = 28;
            this.btnAdd_Secondary.Text = "Toevoegen";
            this.btnAdd_Secondary.UseVisualStyleBackColor = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(1192, 12);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(162, 98);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 19;
            this.pictureBox13.TabStop = false;
            // 
            // btnMarkAsBeingWorkedOn_Secondary
            // 
            this.btnMarkAsBeingWorkedOn_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnMarkAsBeingWorkedOn_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnMarkAsBeingWorkedOn_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMarkAsBeingWorkedOn_Secondary.Location = new System.Drawing.Point(1116, 317);
            this.btnMarkAsBeingWorkedOn_Secondary.Name = "btnMarkAsBeingWorkedOn_Secondary";
            this.btnMarkAsBeingWorkedOn_Secondary.Size = new System.Drawing.Size(238, 48);
            this.btnMarkAsBeingWorkedOn_Secondary.TabIndex = 28;
            this.btnMarkAsBeingWorkedOn_Secondary.Text = "Markeer Als Bezig";
            this.btnMarkAsBeingWorkedOn_Secondary.UseVisualStyleBackColor = false;
            // 
            // frmToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 701);
            this.Controls.Add(this.btnRemove_Secondary);
            this.Controls.Add(this.btnMarkAsBeingWorkedOn_Secondary);
            this.Controls.Add(this.btnAdd_Secondary);
            this.Controls.Add(this.btnLateListSearch_Secondary);
            this.Controls.Add(this.listView10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLateList);
            this.Controls.Add(this.btn_Back_Third);
            this.Controls.Add(this.pictureBox13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmToDoList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmToDoList_FormClosed);
            this.Load += new System.EventHandler(this.frmToDoList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button btn_Back_Third;
        private System.Windows.Forms.Label lblLateList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView listView10;
        private System.Windows.Forms.ColumnHeader columnHeader58;
        private System.Windows.Forms.ColumnHeader columnHeader65;
        private System.Windows.Forms.ColumnHeader columnHeader68;
        private System.Windows.Forms.Button btnLateListSearch_Secondary;
        private System.Windows.Forms.Button btnRemove_Secondary;
        private System.Windows.Forms.Button btnAdd_Secondary;
        private System.Windows.Forms.Button btnMarkAsBeingWorkedOn_Secondary;
    }
}