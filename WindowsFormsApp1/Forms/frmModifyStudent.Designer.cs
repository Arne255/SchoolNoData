namespace WindowsFormsApp1.Forms
{
    partial class frmModifyStudent
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
            this.btn_frmModifyStudent_Opslaan_Secondary = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtTownshipNameOne = new System.Windows.Forms.TextBox();
            this.txtTownshipNameTwo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCardUID = new System.Windows.Forms.TextBox();
            this.tmrConnectAndFillInText = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_frmModifyStudent_Opslaan_Secondary
            // 
            this.btn_frmModifyStudent_Opslaan_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btn_frmModifyStudent_Opslaan_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btn_frmModifyStudent_Opslaan_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_frmModifyStudent_Opslaan_Secondary.Location = new System.Drawing.Point(15, 315);
            this.btn_frmModifyStudent_Opslaan_Secondary.Name = "btn_frmModifyStudent_Opslaan_Secondary";
            this.btn_frmModifyStudent_Opslaan_Secondary.Size = new System.Drawing.Size(334, 45);
            this.btn_frmModifyStudent_Opslaan_Secondary.TabIndex = 6;
            this.btn_frmModifyStudent_Opslaan_Secondary.Text = "Opslaan";
            this.btn_frmModifyStudent_Opslaan_Secondary.UseVisualStyleBackColor = false;
            this.btn_frmModifyStudent_Opslaan_Secondary.Click += new System.EventHandler(this.btn_frmModifyStudent_Opslaan_Secondary_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label14.Location = new System.Drawing.Point(12, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 24);
            this.label14.TabIndex = 24;
            this.label14.Text = "Naam:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Achternaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Klas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "GemeenteEen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label4.Location = new System.Drawing.Point(11, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "GemeenteTwee:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtName.Location = new System.Drawing.Point(169, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 29);
            this.txtName.TabIndex = 0;
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtClassName.Location = new System.Drawing.Point(169, 87);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(181, 29);
            this.txtClassName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSurname.Location = new System.Drawing.Point(169, 49);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(181, 29);
            this.txtSurname.TabIndex = 1;
            // 
            // txtTownshipNameOne
            // 
            this.txtTownshipNameOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTownshipNameOne.Location = new System.Drawing.Point(169, 124);
            this.txtTownshipNameOne.Name = "txtTownshipNameOne";
            this.txtTownshipNameOne.Size = new System.Drawing.Size(181, 29);
            this.txtTownshipNameOne.TabIndex = 3;
            // 
            // txtTownshipNameTwo
            // 
            this.txtTownshipNameTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTownshipNameTwo.Location = new System.Drawing.Point(169, 164);
            this.txtTownshipNameTwo.Name = "txtTownshipNameTwo";
            this.txtTownshipNameTwo.Size = new System.Drawing.Size(181, 29);
            this.txtTownshipNameTwo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "CardUID:";
            // 
            // txtCardUID
            // 
            this.txtCardUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCardUID.Location = new System.Drawing.Point(102, 199);
            this.txtCardUID.Name = "txtCardUID";
            this.txtCardUID.Size = new System.Drawing.Size(248, 29);
            this.txtCardUID.TabIndex = 5;
            // 
            // tmrConnectAndFillInText
            // 
            this.tmrConnectAndFillInText.Enabled = true;
            this.tmrConnectAndFillInText.Interval = 1000;
            this.tmrConnectAndFillInText.Tick += new System.EventHandler(this.tmrConnectAndFillInText_Tick);
            // 
            // frmModifyStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 372);
            this.Controls.Add(this.txtCardUID);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_frmModifyStudent_Opslaan_Secondary);
            this.Controls.Add(this.txtTownshipNameTwo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTownshipNameOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmModifyStudent";
            this.Text = "frmModifyStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_frmModifyStudent_Opslaan_Secondary;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtTownshipNameOne;
        private System.Windows.Forms.TextBox txtTownshipNameTwo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCardUID;
        private System.Windows.Forms.Timer tmrConnectAndFillInText;
    }
}