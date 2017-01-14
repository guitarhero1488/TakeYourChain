namespace TakeYourChain
{
    partial class AddStringForm
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
            this.addStringBtn = new System.Windows.Forms.Button();
            this.origArtTb = new System.Windows.Forms.TextBox();
            this.origNameTb = new System.Windows.Forms.TextBox();
            this.analArtTb = new System.Windows.Forms.TextBox();
            this.analNameTb = new System.Windows.Forms.TextBox();
            this.trustTb = new System.Windows.Forms.TextBox();
            this.origArtLbl = new System.Windows.Forms.Label();
            this.origNameLbl = new System.Windows.Forms.Label();
            this.analArtLbl = new System.Windows.Forms.Label();
            this.analNameLbl = new System.Windows.Forms.Label();
            this.trustLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addStringBtn
            // 
            this.addStringBtn.Location = new System.Drawing.Point(110, 142);
            this.addStringBtn.Name = "addStringBtn";
            this.addStringBtn.Size = new System.Drawing.Size(75, 23);
            this.addStringBtn.TabIndex = 6;
            this.addStringBtn.Text = "Add string";
            this.addStringBtn.UseVisualStyleBackColor = true;
            this.addStringBtn.Click += new System.EventHandler(this.addStringBtn_Click);
            // 
            // origArtTb
            // 
            this.origArtTb.Location = new System.Drawing.Point(133, 12);
            this.origArtTb.Name = "origArtTb";
            this.origArtTb.Size = new System.Drawing.Size(147, 20);
            this.origArtTb.TabIndex = 1;
            // 
            // origNameTb
            // 
            this.origNameTb.Location = new System.Drawing.Point(133, 38);
            this.origNameTb.Name = "origNameTb";
            this.origNameTb.Size = new System.Drawing.Size(147, 20);
            this.origNameTb.TabIndex = 2;
            // 
            // analArtTb
            // 
            this.analArtTb.Location = new System.Drawing.Point(133, 64);
            this.analArtTb.Name = "analArtTb";
            this.analArtTb.Size = new System.Drawing.Size(147, 20);
            this.analArtTb.TabIndex = 3;
            // 
            // analNameTb
            // 
            this.analNameTb.Location = new System.Drawing.Point(133, 90);
            this.analNameTb.Name = "analNameTb";
            this.analNameTb.Size = new System.Drawing.Size(147, 20);
            this.analNameTb.TabIndex = 4;
            // 
            // trustTb
            // 
            this.trustTb.Location = new System.Drawing.Point(133, 116);
            this.trustTb.Name = "trustTb";
            this.trustTb.Size = new System.Drawing.Size(147, 20);
            this.trustTb.TabIndex = 5;
            // 
            // origArtLbl
            // 
            this.origArtLbl.AutoSize = true;
            this.origArtLbl.Location = new System.Drawing.Point(12, 15);
            this.origArtLbl.Name = "origArtLbl";
            this.origArtLbl.Size = new System.Drawing.Size(73, 13);
            this.origArtLbl.TabIndex = 2;
            this.origArtLbl.Text = "Original article";
            // 
            // origNameLbl
            // 
            this.origNameLbl.AutoSize = true;
            this.origNameLbl.Location = new System.Drawing.Point(12, 41);
            this.origNameLbl.Name = "origNameLbl";
            this.origNameLbl.Size = new System.Drawing.Size(71, 13);
            this.origNameLbl.TabIndex = 2;
            this.origNameLbl.Text = "Original name";
            // 
            // analArtLbl
            // 
            this.analArtLbl.AutoSize = true;
            this.analArtLbl.Location = new System.Drawing.Point(11, 67);
            this.analArtLbl.Name = "analArtLbl";
            this.analArtLbl.Size = new System.Drawing.Size(83, 13);
            this.analArtLbl.TabIndex = 2;
            this.analArtLbl.Text = "Analogue article";
            // 
            // analNameLbl
            // 
            this.analNameLbl.AutoSize = true;
            this.analNameLbl.Location = new System.Drawing.Point(12, 93);
            this.analNameLbl.Name = "analNameLbl";
            this.analNameLbl.Size = new System.Drawing.Size(81, 13);
            this.analNameLbl.TabIndex = 2;
            this.analNameLbl.Text = "Analogue name";
            // 
            // trustLbl
            // 
            this.trustLbl.AutoSize = true;
            this.trustLbl.Location = new System.Drawing.Point(12, 119);
            this.trustLbl.Name = "trustLbl";
            this.trustLbl.Size = new System.Drawing.Size(31, 13);
            this.trustLbl.TabIndex = 2;
            this.trustLbl.Text = "Trust";
            // 
            // AddStringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 173);
            this.Controls.Add(this.trustLbl);
            this.Controls.Add(this.analNameLbl);
            this.Controls.Add(this.analArtLbl);
            this.Controls.Add(this.origNameLbl);
            this.Controls.Add(this.origArtLbl);
            this.Controls.Add(this.trustTb);
            this.Controls.Add(this.analNameTb);
            this.Controls.Add(this.analArtTb);
            this.Controls.Add(this.origNameTb);
            this.Controls.Add(this.origArtTb);
            this.Controls.Add(this.addStringBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddStringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStringForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStringBtn;
        private System.Windows.Forms.TextBox origArtTb;
        private System.Windows.Forms.TextBox origNameTb;
        private System.Windows.Forms.TextBox analArtTb;
        private System.Windows.Forms.TextBox analNameTb;
        private System.Windows.Forms.TextBox trustTb;
        private System.Windows.Forms.Label origArtLbl;
        private System.Windows.Forms.Label origNameLbl;
        private System.Windows.Forms.Label analArtLbl;
        private System.Windows.Forms.Label analNameLbl;
        private System.Windows.Forms.Label trustLbl;
    }
}