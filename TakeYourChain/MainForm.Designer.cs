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
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.referenceDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Location = new System.Drawing.Point(300, 224);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 30);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // referenceDgv
            // 
            this.referenceDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.referenceDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.referenceDgv.Location = new System.Drawing.Point(5, 12);
            this.referenceDgv.Name = "referenceDgv";
            this.referenceDgv.Size = new System.Drawing.Size(674, 200);
            this.referenceDgv.TabIndex = 2;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Green;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.updateBtn.Location = new System.Drawing.Point(4, 12);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(44, 22);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Save";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.referenceDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TakeYourChain";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.referenceDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView referenceDgv;
        private System.Windows.Forms.Button updateBtn;
    }
}

