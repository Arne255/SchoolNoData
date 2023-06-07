namespace WindowsFormsApp1.Forms
{
    partial class frmSanctieSoort
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
            this.txtSanctieSoort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_frmSanctieSoort_Secondary = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSanctieSoort
            // 
            this.txtSanctieSoort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSanctieSoort.Location = new System.Drawing.Point(16, 119);
            this.txtSanctieSoort.Name = "txtSanctieSoort";
            this.txtSanctieSoort.Size = new System.Drawing.Size(330, 29);
            this.txtSanctieSoort.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Sanctie Soort:";
            // 
            // btn_frmSanctieSoort_Secondary
            // 
            this.btn_frmSanctieSoort_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btn_frmSanctieSoort_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btn_frmSanctieSoort_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_frmSanctieSoort_Secondary.Location = new System.Drawing.Point(12, 154);
            this.btn_frmSanctieSoort_Secondary.Name = "btn_frmSanctieSoort_Secondary";
            this.btn_frmSanctieSoort_Secondary.Size = new System.Drawing.Size(334, 45);
            this.btn_frmSanctieSoort_Secondary.TabIndex = 28;
            this.btn_frmSanctieSoort_Secondary.Text = "Toevoegen";
            this.btn_frmSanctieSoort_Secondary.UseVisualStyleBackColor = false;
            this.btn_frmSanctieSoort_Secondary.Click += new System.EventHandler(this.btn_frmSanctieSoort_Secondary_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20F, System.Drawing.FontStyle.Bold);
            this.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.lblStudentName.Location = new System.Drawing.Point(10, 9);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(187, 35);
            this.lblStudentName.TabIndex = 30;
            this.lblStudentName.Text = "Arne De Wolf";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSanctieSoort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 216);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtSanctieSoort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_frmSanctieSoort_Secondary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmSanctieSoort";
            this.Text = "frmSanctieSoort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSanctieSoort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_frmSanctieSoort_Secondary;
        private System.Windows.Forms.Label lblStudentName;
    }
}