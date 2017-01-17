using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Seeker.SearchChain(sourceArtNameTb.Text, targetArtNameTb.Text, depthTb.Text);
        }
    }
}
