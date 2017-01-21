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
            int depth = Convert.ToInt32(depthTb.Text);
            try
            {
                Seeker list = new Seeker(sourceArtNameTb.Text, targetArtNameTb.Text, depth);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
