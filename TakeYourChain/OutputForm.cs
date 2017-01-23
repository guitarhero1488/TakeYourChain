﻿using System.Windows.Forms;

namespace TakeYourChain
{
    public partial class OutputForm : Form
    {
        public OutputForm()
        {
            InitializeComponent();
        }

        private void OutputForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                for (int i = 0; i < Seeker.list.Count; i++)
                {
                    outputDgv.Rows.Add();
                    outputDgv[0, i].Value = "Route " + i;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void outputDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                for (int i = 0; i < outputDgv.Columns.Count; i++)
                {
                    outputDgv[1, i].Value = "";
                }
                int index = outputDgv.CurrentCell.RowIndex;
                int count = 0;
                foreach (Link link in Seeker.list[index].Links)
                {
                    if (count >= Seeker.list.Count)
                    {
                        outputDgv.Rows.Add();
                        outputDgv[1, count].Value = link.originalArt + " " + link.originalName + " => " + link.analogueArt + " " + link.analogueName;
                    }
                    else
                    {
                        outputDgv[1, count].Value = link.originalArt + " " + link.originalName + " => " + link.analogueArt + " " + link.analogueName;
                    }
                    count++;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
