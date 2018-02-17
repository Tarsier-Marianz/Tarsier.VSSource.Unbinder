using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tarsier.VSSource.Unbinder.Forms {
    public partial class SourceForm : Form {
        public string SourceName {
            get { return txtName.Text.Trim(); }
        }
       
        public SourceForm(string source) {
            InitializeComponent();
            if(source == "SOURCE_EXT") {
                labelMsg.Text = "Enter extension (e.g .txt or txt)";
                lblInfo.Text = "File with extension will be deleted if found during unbinding of source control.";
                Text = "Include Extension";
            } else {
                labelMsg.Text = "Enter folder name";
                lblInfo.Text = "Folder will be deleted if found during unbinding of source control.";
                Text = "Include Folder";
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e) {
            btnAdd.Enabled = txtName.Text.Trim().Length > 0;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode.Equals(Keys.Enter)) {
                btnAdd.PerformClick();
            }
        }
    }
}
