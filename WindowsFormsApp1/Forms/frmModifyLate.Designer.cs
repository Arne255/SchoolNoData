namespace WindowsFormsApp1.Forms
{
    partial class frmModifyLate
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
            this.grpReason = new System.Windows.Forms.GroupBox();
            this.lstbReden = new System.Windows.Forms.ListBox();
            this.btnAndereGeldig_Secondary = new System.Windows.Forms.Button();
            this.btnAndereNietGeldig_Secondary = new System.Windows.Forms.Button();
            this.lstbZonderReden = new System.Windows.Forms.ListBox();
            this.lblMetReden = new System.Windows.Forms.Label();
            this.lblZonderReden = new System.Windows.Forms.Label();
            this.lblLateName = new System.Windows.Forms.Label();
            this.btnOpslaan_Secondary = new System.Windows.Forms.Button();
            this.grpReason.SuspendLayout();
            this.SuspendLayout();
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
            this.grpReason.Location = new System.Drawing.Point(18, 65);
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
            // lblLateName
            // 
            this.lblLateName.AutoSize = true;
            this.lblLateName.BackColor = System.Drawing.Color.Transparent;
            this.lblLateName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20F, System.Drawing.FontStyle.Bold);
            this.lblLateName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(143)))));
            this.lblLateName.Location = new System.Drawing.Point(12, 9);
            this.lblLateName.Name = "lblLateName";
            this.lblLateName.Size = new System.Drawing.Size(187, 35);
            this.lblLateName.TabIndex = 16;
            this.lblLateName.Text = "Arne De Wolf";
            this.lblLateName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpslaan_Secondary
            // 
            this.btnOpslaan_Secondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(74)))));
            this.btnOpslaan_Secondary.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnOpslaan_Secondary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpslaan_Secondary.Location = new System.Drawing.Point(39, 441);
            this.btnOpslaan_Secondary.Name = "btnOpslaan_Secondary";
            this.btnOpslaan_Secondary.Size = new System.Drawing.Size(422, 49);
            this.btnOpslaan_Secondary.TabIndex = 17;
            this.btnOpslaan_Secondary.Text = "Opslaan";
            this.btnOpslaan_Secondary.UseVisualStyleBackColor = false;
            this.btnOpslaan_Secondary.Click += new System.EventHandler(this.btnOpslaan_Secondary_Click);
            // 
            // frmModifyLate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 502);
            this.Controls.Add(this.btnOpslaan_Secondary);
            this.Controls.Add(this.lblLateName);
            this.Controls.Add(this.grpReason);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmModifyLate";
            this.Text = "frmModifyLate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmModifyLate_FormClosed);
            this.Load += new System.EventHandler(this.frmModifyLate_Load);
            this.grpReason.ResumeLayout(false);
            this.grpReason.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReason;
        private System.Windows.Forms.ListBox lstbReden;
        private System.Windows.Forms.Button btnAndereGeldig_Secondary;
        private System.Windows.Forms.Button btnAndereNietGeldig_Secondary;
        private System.Windows.Forms.ListBox lstbZonderReden;
        private System.Windows.Forms.Label lblMetReden;
        private System.Windows.Forms.Label lblZonderReden;
        private System.Windows.Forms.Label lblLateName;
        private System.Windows.Forms.Button btnOpslaan_Secondary;
    }
}