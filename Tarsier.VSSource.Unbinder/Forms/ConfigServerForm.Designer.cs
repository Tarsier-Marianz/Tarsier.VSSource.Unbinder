namespace Tarsier.VSSource.Unbinder {
    partial class ConfigServerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigServerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.tabControlConfig = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.chkTruncatePath = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkAppDataTempFolder = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkNewProfile = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkEnableIncludeFile = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkAutoUnbind = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAutoSaveProfile = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pBoxVersionCompare = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRootPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.imageListTab = new System.Windows.Forms.ImageList(this.components);
            this.btnApply = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxVersionCompare)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(6, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SFTP Credentials";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(83, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Credentials use to connect SFTP server.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(86, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(259, 21);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(86, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(259, 21);
            this.txtUsername.TabIndex = 4;
            // 
            // tabControlConfig
            // 
            this.tabControlConfig.Controls.Add(this.tabPage1);
            this.tabControlConfig.Controls.Add(this.tabPage2);
            this.tabControlConfig.ImageList = this.imageListTab;
            this.tabControlConfig.ItemSize = new System.Drawing.Size(71, 30);
            this.tabControlConfig.Location = new System.Drawing.Point(8, 12);
            this.tabControlConfig.Name = "tabControlConfig";
            this.tabControlConfig.SelectedIndex = 0;
            this.tabControlConfig.Size = new System.Drawing.Size(384, 353);
            this.tabControlConfig.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.chkTruncatePath);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.chkAppDataTempFolder);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.chkNewProfile);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.chkEnableIncludeFile);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.chkAutoUnbind);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chkAutoSaveProfile);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(38, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(322, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Truncate all directory display";
            // 
            // chkTruncatePath
            // 
            this.chkTruncatePath.AutoSize = true;
            this.chkTruncatePath.Checked = true;
            this.chkTruncatePath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTruncatePath.Location = new System.Drawing.Point(19, 269);
            this.chkTruncatePath.Name = "chkTruncatePath";
            this.chkTruncatePath.Size = new System.Drawing.Size(94, 17);
            this.chkTruncatePath.TabIndex = 11;
            this.chkTruncatePath.Tag = "TruncatePath";
            this.chkTruncatePath.Text = "Truncate Path";
            this.chkTruncatePath.UseVisualStyleBackColor = true;
            this.chkTruncatePath.CheckedChanged += new System.EventHandler(this.Checkboxes_CheckedChanged);
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(38, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(322, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Temporary folder will be created into Application Data.";
            // 
            // chkAppDataTempFolder
            // 
            this.chkAppDataTempFolder.AutoSize = true;
            this.chkAppDataTempFolder.Checked = true;
            this.chkAppDataTempFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAppDataTempFolder.Location = new System.Drawing.Point(19, 223);
            this.chkAppDataTempFolder.Name = "chkAppDataTempFolder";
            this.chkAppDataTempFolder.Size = new System.Drawing.Size(152, 17);
            this.chkAppDataTempFolder.TabIndex = 10;
            this.chkAppDataTempFolder.Tag = "AppDataTempFolder";
            this.chkAppDataTempFolder.Text = "%AppData% Temp Folder";
            this.chkAppDataTempFolder.UseVisualStyleBackColor = true;
            this.chkAppDataTempFolder.CheckedChanged += new System.EventHandler(this.Checkboxes_CheckedChanged);
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(38, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(322, 29);
            this.label11.TabIndex = 7;
            this.label11.Text = "Execute New Profile automatically after finished saving uploaded files.";
            // 
            // chkNewProfile
            // 
            this.chkNewProfile.AutoSize = true;
            this.chkNewProfile.Checked = true;
            this.chkNewProfile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNewProfile.Location = new System.Drawing.Point(19, 167);
            this.chkNewProfile.Name = "chkNewProfile";
            this.chkNewProfile.Size = new System.Drawing.Size(122, 17);
            this.chkNewProfile.TabIndex = 9;
            this.chkNewProfile.Tag = "ExecuteNewProfile";
            this.chkNewProfile.Text = "Execute New Profile";
            this.chkNewProfile.UseVisualStyleBackColor = true;
            this.chkNewProfile.CheckedChanged += new System.EventHandler(this.Checkboxes_CheckedChanged);
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(38, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(322, 29);
            this.label10.TabIndex = 5;
            this.label10.Text = "Automatically delete all included files during unbinding.";
            // 
            // chkEnableIncludeFile
            // 
            this.chkEnableIncludeFile.AutoSize = true;
            this.chkEnableIncludeFile.Checked = true;
            this.chkEnableIncludeFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableIncludeFile.Location = new System.Drawing.Point(19, 111);
            this.chkEnableIncludeFile.Name = "chkEnableIncludeFile";
            this.chkEnableIncludeFile.Size = new System.Drawing.Size(126, 17);
            this.chkEnableIncludeFile.TabIndex = 8;
            this.chkEnableIncludeFile.Tag = "EnableIncludeFile";
            this.chkEnableIncludeFile.Text = "Enable Included Files";
            this.chkEnableIncludeFile.UseVisualStyleBackColor = true;
            this.chkEnableIncludeFile.CheckedChanged += new System.EventHandler(this.Checkboxes_CheckedChanged);
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(38, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(322, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "Automatically unbind all valid source control found while scanning files.";
            // 
            // chkAutoUnbind
            // 
            this.chkAutoUnbind.AutoSize = true;
            this.chkAutoUnbind.Location = new System.Drawing.Point(19, 60);
            this.chkAutoUnbind.Name = "chkAutoUnbind";
            this.chkAutoUnbind.Size = new System.Drawing.Size(85, 17);
            this.chkAutoUnbind.TabIndex = 7;
            this.chkAutoUnbind.Tag = "AutoUnbind";
            this.chkAutoUnbind.Text = "Auto Unbind";
            this.chkAutoUnbind.UseVisualStyleBackColor = true;
            this.chkAutoUnbind.CheckedChanged += new System.EventHandler(this.Checkboxes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Automatically create and save workspace after scanning files.";
            // 
            // chkAutoSaveProfile
            // 
            this.chkAutoSaveProfile.AutoSize = true;
            this.chkAutoSaveProfile.Location = new System.Drawing.Point(19, 16);
            this.chkAutoSaveProfile.Name = "chkAutoSaveProfile";
            this.chkAutoSaveProfile.Size = new System.Drawing.Size(134, 17);
            this.chkAutoSaveProfile.TabIndex = 6;
            this.chkAutoSaveProfile.Tag = "AutoSaveProfile";
            this.chkAutoSaveProfile.Text = "Automatic Save Profile";
            this.chkAutoSaveProfile.UseVisualStyleBackColor = true;
            this.chkAutoSaveProfile.CheckedChanged += new System.EventHandler(this.Checkboxes_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pBoxVersionCompare);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtRootPath);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtHostname);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.ImageIndex = 2;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Server Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(65, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pBoxVersionCompare
            // 
            this.pBoxVersionCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxVersionCompare.Image = ((System.Drawing.Image)(resources.GetObject("pBoxVersionCompare.Image")));
            this.pBoxVersionCompare.Location = new System.Drawing.Point(65, 60);
            this.pBoxVersionCompare.Name = "pBoxVersionCompare";
            this.pBoxVersionCompare.Size = new System.Drawing.Size(16, 16);
            this.pBoxVersionCompare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBoxVersionCompare.TabIndex = 11;
            this.pBoxVersionCompare.TabStop = false;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(87, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Location where to save latest version of files.";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(87, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 42);
            this.label6.TabIndex = 6;
            this.label6.Text = "Host IP address or domain of the server.\r\n(e.g ): 192.168.0.2\r\n           yourdom" +
    "ain.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Root Path:";
            // 
            // txtRootPath
            // 
            this.txtRootPath.Location = new System.Drawing.Point(90, 105);
            this.txtRootPath.Name = "txtRootPath";
            this.txtRootPath.Size = new System.Drawing.Size(261, 21);
            this.txtRootPath.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hostname:";
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(92, 36);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(259, 21);
            this.txtHostname.TabIndex = 2;
            // 
            // imageListTab
            // 
            this.imageListTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTab.ImageStream")));
            this.imageListTab.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTab.Images.SetKeyName(0, "folder-network-horizontal-open.png");
            this.imageListTab.Images.SetKeyName(1, "gear.png");
            this.imageListTab.Images.SetKeyName(2, "globe-network-ethernet.png");
            this.imageListTab.Images.SetKeyName(3, "network-firewall.png");
            this.imageListTab.Images.SetKeyName(4, "network-clouds.png");
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Location = new System.Drawing.Point(236, 371);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(317, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ConfigServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 403);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tabControlConfig);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigServerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.ConfigServerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlConfig.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxVersionCompare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControlConfig;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAutoSaveProfile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRootPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkAutoUnbind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkEnableIncludeFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkNewProfile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkAppDataTempFolder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkTruncatePath;
        private System.Windows.Forms.ImageList imageListTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pBoxVersionCompare;
    }
}