namespace TakeYourChain
{
    partial class SearchForm
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
            this.startSearchBtn = new System.Windows.Forms.Button();
            this.sourceArtNameTb = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.depthLbl = new System.Windows.Forms.Label();
            this.depthTb = new System.Windows.Forms.TextBox();
            this.targetArtNameTb = new System.Windows.Forms.TextBox();
            this.fromLbl = new System.Windows.Forms.Label();
            this.toLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startSearchBtn
            // 
            this.startSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startSearchBtn.Location = new System.Drawing.Point(120, 96);
            this.startSearchBtn.Name = "startSearchBtn";
            this.startSearchBtn.Size = new System.Drawing.Size(140, 30);
            this.startSearchBtn.TabIndex = 4;
            this.startSearchBtn.Text = "Start";
            this.startSearchBtn.UseVisualStyleBackColor = true;
            this.startSearchBtn.Click += new System.EventHandler(this.startSearchBtn_Click);
            // 
            // sourceArtNameTb
            // 
            this.sourceArtNameTb.Location = new System.Drawing.Point(40, 35);
            this.sourceArtNameTb.Name = "sourceArtNameTb";
            this.sourceArtNameTb.Size = new System.Drawing.Size(250, 20);
            this.sourceArtNameTb.TabIndex = 1;
            this.sourceArtNameTb.Text = "KL9/Knecht";
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(9, 12);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(256, 13);
            this.searchLbl.TabIndex = 2;
            this.searchLbl.Text = "Enter the article or name of source and target details:";
            // 
            // depthLbl
            // 
            this.depthLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.depthLbl.AutoSize = true;
            this.depthLbl.Location = new System.Drawing.Point(319, 38);
            this.depthLbl.Name = "depthLbl";
            this.depthLbl.Size = new System.Drawing.Size(36, 13);
            this.depthLbl.TabIndex = 3;
            this.depthLbl.Text = "Depth";
            // 
            // depthTb
            // 
            this.depthTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.depthTb.Location = new System.Drawing.Point(322, 61);
            this.depthTb.Name = "depthTb";
            this.depthTb.Size = new System.Drawing.Size(50, 20);
            this.depthTb.TabIndex = 3;
            this.depthTb.Text = "5";
            // 
            // targetArtNameTb
            // 
            this.targetArtNameTb.Location = new System.Drawing.Point(40, 61);
            this.targetArtNameTb.Name = "targetArtNameTb";
            this.targetArtNameTb.Size = new System.Drawing.Size(250, 20);
            this.targetArtNameTb.TabIndex = 2;
            this.targetArtNameTb.Text = "03310/Febi";
            // 
            // fromLbl
            // 
            this.fromLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromLbl.AutoSize = true;
            this.fromLbl.Location = new System.Drawing.Point(9, 38);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(27, 13);
            this.fromLbl.TabIndex = 3;
            this.fromLbl.Text = "from";
            // 
            // toLbl
            // 
            this.toLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(9, 64);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(16, 13);
            this.toLbl.TabIndex = 3;
            this.toLbl.Text = "to";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 131);
            this.Controls.Add(this.depthTb);
            this.Controls.Add(this.toLbl);
            this.Controls.Add(this.fromLbl);
            this.Controls.Add(this.depthLbl);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.targetArtNameTb);
            this.Controls.Add(this.sourceArtNameTb);
            this.Controls.Add(this.startSearchBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "5";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startSearchBtn;
        private System.Windows.Forms.TextBox sourceArtNameTb;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Label depthLbl;
        private System.Windows.Forms.TextBox depthTb;
        private System.Windows.Forms.TextBox targetArtNameTb;
        private System.Windows.Forms.Label fromLbl;
        private System.Windows.Forms.Label toLbl;
    }
}