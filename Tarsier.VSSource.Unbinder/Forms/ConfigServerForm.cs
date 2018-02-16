using Tarsier.VSSource.Unbinder.Helpers;
using Tarsier.VSSource.Unbinder.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tarsier.Regedit;
using Tarsier.Security;

namespace Tarsier.VSSource.Unbinder {
    public partial class ConfigServerForm : Form {
        public ConfigServerForm(int tabIndex=0) {
            InitializeComponent();
            InitConfig(tabIndex);
        }
        private void InitConfig(int tabIndex) {
            tabControlConfig.SelectedIndex = tabIndex;
            chkTruncatePath.Checked =RegConfig.Get<bool>("TruncatePath");
            chkAppDataTempFolder.Checked = RegConfig.Get<bool>("AppDataTempFolder");
            chkNewProfile.Checked = RegConfig.Get<bool>("ExecuteNewProfile");
            chkEnableIncludeFile.Checked = RegConfig.Get<bool>("EnableIncludeFile");
            chkAutoUnbind.Checked = RegConfig.Get<bool>("AutoUnbind");
            chkAutoSaveProfile.Checked = RegConfig.Get<bool>("AutoSaveProfile");
            txtHostname.Text = RegConfig.Get<string>("Hostname");
            txtRootPath.Text = RegConfig.Get<string>("RootPath");
            UploadCredentials credential = RegConfig.Get<UploadCredentials>("Credentials");
            if(credential != null) {
                txtUsername.Text = credential.Username;
                txtPassword.Text = SimpleEncryption.Decrypt( credential.Password);
            }
        }

        private void SaveConfig() {
            RegConfig.Set<string>("RootPath", Elements.TrimRemotePath(txtRootPath.Text.Trim()));
            RegConfig.Set<string>("Hostname", txtHostname.Text.Trim());
            UploadCredentials credential = new UploadCredentials() { Username = txtUsername.Text.Trim(), Password = SimpleEncryption.Encrypt( txtPassword.Text.Trim()) };
            RegConfig.Set<UploadCredentials>("Credentials", credential);
        }
        private void btnApply_Click(object sender, EventArgs e) {
            SaveConfig();
        }

        private void Checkboxes_CheckedChanged(object sender, EventArgs e) {
            CheckBox chk = sender as CheckBox;
            if(chk != null) {
                if(chk.Tag != null) {
                    RegConfig.Set<bool>(chk.Tag.ToString(), chk.Checked);
                }
            }
        }
        
        private void ConfigServerForm_Load(object sender, EventArgs e) {
            btnApply.Focus();
        }
    }
}
