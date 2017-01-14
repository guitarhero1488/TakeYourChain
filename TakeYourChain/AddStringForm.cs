using System;
using System.Windows.Forms;

namespace TakeYourChain
{
    public partial class AddStringForm : Form
    {
        public AddStringForm()
        {
            InitializeComponent();
        }

        private void addStringBtn_Click(object sender, EventArgs e)
        {
            string[] parameters = new string[] { origArtTb.Text, origNameTb.Text, analArtTb.Text, analNameTb.Text, trustTb.Text };
            Connector.AddRow(parameters);
        }
    }
}
