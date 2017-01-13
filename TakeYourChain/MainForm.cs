using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeYourChain
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            referenceTableAdapter.Fill(this.referenceBaseDataSet.Reference);
        }

        private void referenceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.referenceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.referenceBaseDataSet);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }
    }
}
