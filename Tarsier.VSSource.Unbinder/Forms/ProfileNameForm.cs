using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tarsier.VSSource.Unbinder.Forms {
    public partial class ProfileNameForm : Form {
        public string ProfileName {
            get { return txtName.Text.Trim(); }
        }
        public string Comment {
            get { return txtComment.Text.Trim(); }
        }
        public ProfileNameForm() {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e) {
            btnOK.Enabled = txtName.Text.Trim().Length > 0;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode.Equals(Keys.Enter)) {
                btnOK.PerformClick();
            }
        }
    }
}
