using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniLauncher
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadIcons();
        }

        private void loadIcons()
        {
            /* Load icons for tool strip.
            *  This will later be used for themes
            */
            toolStripBtnAddEntry.Image = Image.FromFile
                (Properties.Settings.Default.iconBtnAddEntryLocation);
            toolStripBtnEdit.Image = Image.FromFile
                (Properties.Settings.Default.iconBtnEditLocation);
            toolStripBtnSettings.Image = Image.FromFile
                (Properties.Settings.Default.iconBtnSettingsLocation);
            toolStripBtnAddCategory.Image = Image.FromFile
                (Properties.Settings.Default.iconBtnAddCategoryLocation);
        }

    }
}
