namespace TakeYourChain
{
    partial class OutputForm
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
            this.outputDgv = new System.Windows.Forms.DataGridView();
            this.RoutesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.outputDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // outputDgv
            // 
            this.outputDgv.AllowUserToAddRows = false;
            this.outputDgv.AllowUserToDeleteRows = false;
            this.outputDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoutesCol,
            this.ContentCol});
            this.outputDgv.Location = new System.Drawing.Point(12, 12);
            this.outputDgv.Name = "outputDgv";
            this.outputDgv.ReadOnly = true;
            this.outputDgv.Size = new System.Drawing.Size(460, 187);
            this.outputDgv.TabIndex = 0;
            this.outputDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outputDgv_CellClick);
            // 
            // RoutesCol
            // 
            this.RoutesCol.FillWeight = 50F;
            this.RoutesCol.HeaderText = "Routes";
            this.RoutesCol.Name = "RoutesCol";
            this.RoutesCol.ReadOnly = true;
            this.RoutesCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ContentCol
            // 
            this.ContentCol.FillWeight = 98.47716F;
            this.ContentCol.HeaderText = "Content";
            this.ContentCol.Name = "ContentCol";
            this.ContentCol.ReadOnly = true;
            this.ContentCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.outputDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OutputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Output";
            this.Load += new System.EventHandler(this.OutputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView outputDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoutesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentCol;
    }
}