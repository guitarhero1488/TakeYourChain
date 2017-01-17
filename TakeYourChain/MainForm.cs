using System;
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
            Connector.Read();
            try
            {
                referenceDgv.DataSource = Connector.receivedData.Tables[0];
                referenceDgv.Columns[0].Width = 100;
                referenceDgv.Columns["Trust"].Width = 50;
                referenceDgv.Columns["Id"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Connector.CloseConnection();
        }
        
        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }        

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Connector.UpdateTable();
        }
    }
}
