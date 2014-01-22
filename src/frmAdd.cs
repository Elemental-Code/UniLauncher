using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UniLauncher
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }

        private void frmAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void btnLocate_Click(object sender, EventArgs e)
        {
            opnFileDialogLocate.Title = "Open An Executable file";
            opnFileDialogLocate.Filter = "Executable |*.exe";
            opnFileDialogLocate.FilterIndex = 1;
            opnFileDialogLocate.Multiselect = false;

            DialogResult result = opnFileDialogLocate.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFileLocation = opnFileDialogLocate.FileName;

                try
                {
                    txtBoxLocation.Text = selectedFileLocation;
                }
                catch (IOException)
                {

                }
            }
        }

    }
}
