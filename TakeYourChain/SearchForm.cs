using System;
using System.Windows.Forms;

namespace TakeYourChain
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void startSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int depth = Convert.ToInt32(depthTb.Text);
                Seeker.InitList(sourceArtNameTb.Text, targetArtNameTb.Text, depth);
                OutputForm output = new OutputForm();
                output.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
