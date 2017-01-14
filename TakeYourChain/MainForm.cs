using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TakeYourChain
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            referenceDgv.AllowUserToAddRows = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataSet reference = new DataSet();
            Connector.Read();
            referenceDgv.DataSource = Connector.receivedData.Tables[0];
            referenceDgv.Columns["Id"].ReadOnly = true;
        }
        
        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void addStringBtn_Click(object sender, EventArgs e)
        {
            AddStringForm addStringForm = new AddStringForm();
            addStringForm.ShowDialog();
        }

        private void removeStringBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
