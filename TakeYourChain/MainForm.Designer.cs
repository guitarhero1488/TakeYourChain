namespace TakeYourChain
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBtn = new System.Windows.Forms.Button();
            this.referenceDgv = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addStringBtn = new System.Windows.Forms.ToolStripButton();
            this.removeStringBtn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.referenceDgv)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(295, 259);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(111, 29);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // referenceDgv
            // 
            this.referenceDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.referenceDgv.Location = new System.Drawing.Point(36, 12);
            this.referenceDgv.Name = "referenceDgv";
            this.referenceDgv.Size = new System.Drawing.Size(643, 241);
            this.referenceDgv.TabIndex = 3;
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStringBtn,
            this.removeStringBtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip.Size = new System.Drawing.Size(33, 298);
            this.toolStrip.TabIndex = 4;
            // 
            // addStringBtn
            // 
            this.addStringBtn.AutoSize = false;
            this.addStringBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addStringBtn.Image = global::TakeYourChain.Properties.Resources.add;
            this.addStringBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addStringBtn.Name = "addStringBtn";
            this.addStringBtn.Size = new System.Drawing.Size(30, 30);
            this.addStringBtn.Text = "toolStripButton1";
            this.addStringBtn.Click += new System.EventHandler(this.addStringBtn_Click);
            // 
            // removeStringBtn
            // 
            this.removeStringBtn.AutoSize = false;
            this.removeStringBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeStringBtn.Image = global::TakeYourChain.Properties.Resources.remove;
            this.removeStringBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeStringBtn.Name = "removeStringBtn";
            this.removeStringBtn.Size = new System.Drawing.Size(30, 30);
            this.removeStringBtn.Text = "toolStripButton2";
            this.removeStringBtn.Click += new System.EventHandler(this.removeStringBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 298);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.referenceDgv);
            this.Controls.Add(this.searchBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TakeYourChain";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.referenceDgv)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView referenceDgv;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addStringBtn;
        private System.Windows.Forms.ToolStripButton removeStringBtn;
    }
}

