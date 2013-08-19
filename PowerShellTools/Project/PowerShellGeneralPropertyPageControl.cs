﻿using System;
using System.Windows.Forms;

namespace PowerShellTools.Project
{
    public partial class PowerShellGeneralPropertyPageControl : UserControl
    {
        public PowerShellGeneralPropertyPageControl(PowerShellGeneralPropertyPage project)
        {
            InitializeComponent();
        }

        private void chkSignOutput_CheckedChanged(object sender, EventArgs e)
        {
            btnCodeSigningCert.Enabled = chkSignOutput.Checked;
        }

        public bool SignOutput
        {
            get { return chkSignOutput.Checked;  }
            set { chkSignOutput.Checked = value; }
        }

        public string CodeSigningCert
        {
            get
            {
                return txtCodeSigningCert.Text;
            }
            set
            {
                txtCodeSigningCert.Text = value;
            }
        }

        public string OutputDirectory
        {
            get { return txtOutputDirectory.Text; }
            set { txtOutputDirectory.Text = value; }
        }

        private void btnOutputDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.ShowNewFolderButton = true;
                fbd.Description = Resources.OutputDirectory_Description;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    OutputDirectory = fbd.SelectedPath;
                }
            }

        }
    }
}
