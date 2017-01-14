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
            this.artNameTb = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.depthLbl = new System.Windows.Forms.Label();
            this.depthTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startSearchBtn
            // 
            this.startSearchBtn.Location = new System.Drawing.Point(137, 75);
            this.startSearchBtn.Name = "startSearchBtn";
            this.startSearchBtn.Size = new System.Drawing.Size(66, 23);
            this.startSearchBtn.TabIndex = 0;
            this.startSearchBtn.Text = "Start";
            this.startSearchBtn.UseVisualStyleBackColor = true;
            // 
            // artNameTb
            // 
            this.artNameTb.Location = new System.Drawing.Point(15, 35);
            this.artNameTb.Name = "artNameTb";
            this.artNameTb.Size = new System.Drawing.Size(230, 20);
            this.artNameTb.TabIndex = 1;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(12, 9);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(69, 13);
            this.searchLbl.TabIndex = 2;
            this.searchLbl.Text = "Article/Name";
            // 
            // depthLbl
            // 
            this.depthLbl.AutoSize = true;
            this.depthLbl.Location = new System.Drawing.Point(248, 9);
            this.depthLbl.Name = "depthLbl";
            this.depthLbl.Size = new System.Drawing.Size(36, 13);
            this.depthLbl.TabIndex = 3;
            this.depthLbl.Text = "Depth";
            // 
            // depthTb
            // 
            this.depthTb.Location = new System.Drawing.Point(251, 35);
            this.depthTb.Name = "depthTb";
            this.depthTb.Size = new System.Drawing.Size(81, 20);
            this.depthTb.TabIndex = 4;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 106);
            this.Controls.Add(this.depthTb);
            this.Controls.Add(this.depthLbl);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.artNameTb);
            this.Controls.Add(this.startSearchBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startSearchBtn;
        private System.Windows.Forms.TextBox artNameTb;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Label depthLbl;
        private System.Windows.Forms.TextBox depthTb;
    }
}