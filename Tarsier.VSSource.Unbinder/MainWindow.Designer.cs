namespace Tarsier.VSSource.Unbinder {
    partial class MainWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStripUploader = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.ridFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.addExtensionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUnbind = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.clearWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hideToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideStatusbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripUploader = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatusFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripUploader = new System.Windows.Forms.ToolStrip();
            this.btnUnbind = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddFiles = new System.Windows.Forms.ToolStripButton();
            this.btnFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefreshProfile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRidSourceExt = new System.Windows.Forms.ToolStripButton();
            this.btnRidSourceFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClearHistory = new System.Windows.Forms.ToolStripButton();
            this.btnClearLogs = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOptions = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.workspaceListBox = new Tarsier.UI.MessageListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelProfileTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFiles = new System.Windows.Forms.TabPage();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList32 = new System.Windows.Forms.ImageList(this.components);
            this.imageList16 = new System.Windows.Forms.ImageList(this.components);
            this.tabPageSummary = new System.Windows.Forms.TabPage();
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.columnHeaderSourceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSourceCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgSources = new System.Windows.Forms.ImageList(this.components);
            this.imageListInfo = new System.Windows.Forms.ImageList(this.components);
            this.panelFilesTop = new System.Windows.Forms.Panel();
            this.lblProfileCaption = new System.Windows.Forms.Label();
            this.tabControlDetails = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.pBoxVersionCompare = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblValidFiles = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblScannedFiles = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageRidFiles = new System.Windows.Forms.TabPage();
            this.listViewRids = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.listLogs = new Tarsier.UI.MessageListBox();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.tmrCheck = new System.Windows.Forms.Timer(this.components);
            this.tipUploader = new System.Windows.Forms.ToolTip(this.components);
            this.bgWorkerUnbind = new System.ComponentModel.BackgroundWorker();
            this.panelLocked = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timerLock = new System.Windows.Forms.Timer(this.components);
            this.panelLockedBody = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStripUploader.SuspendLayout();
            this.statusStripUploader.SuspendLayout();
            this.toolStripUploader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.workspaceListBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelProfileTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageFiles.SuspendLayout();
            this.tabPageSummary.SuspendLayout();
            this.panelFilesTop.SuspendLayout();
            this.tabControlDetails.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxVersionCompare)).BeginInit();
            this.tabPageRidFiles.SuspendLayout();
            this.tabPageLogs.SuspendLayout();
            this.panelLocked.SuspendLayout();
            this.panelLockedBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripUploader
            // 
            this.menuStripUploader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripUploader.Location = new System.Drawing.Point(0, 0);
            this.menuStripUploader.Name = "menuStripUploader";
            this.menuStripUploader.Size = new System.Drawing.Size(759, 24);
            this.menuStripUploader.TabIndex = 2;
            this.menuStripUploader.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.menuItemFiles,
            this.menuItemFolder,
            this.toolStripSeparator12,
            this.ridFilesToolStripMenuItem,
            this.toolStripSeparator13,
            this.addExtensionToolStripMenuItem1,
            this.addFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.optionsToolStripMenuItem1,
            this.toolStripSeparator9,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(219, 6);
            // 
            // menuItemFiles
            // 
            this.menuItemFiles.Image = ((System.Drawing.Image)(resources.GetObject("menuItemFiles.Image")));
            this.menuItemFiles.Name = "menuItemFiles";
            this.menuItemFiles.Size = new System.Drawing.Size(222, 22);
            this.menuItemFiles.Tag = "ADD_FILES";
            this.menuItemFiles.Text = "Add Workspace from File...";
            this.menuItemFiles.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // menuItemFolder
            // 
            this.menuItemFolder.Image = ((System.Drawing.Image)(resources.GetObject("menuItemFolder.Image")));
            this.menuItemFolder.Name = "menuItemFolder";
            this.menuItemFolder.Size = new System.Drawing.Size(222, 22);
            this.menuItemFolder.Tag = "ADD_FOLDER";
            this.menuItemFolder.Text = "Add Workspace from Folder";
            this.menuItemFolder.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(219, 6);
            // 
            // ridFilesToolStripMenuItem
            // 
            this.ridFilesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ridFilesToolStripMenuItem.Enabled = false;
            this.ridFilesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ridFilesToolStripMenuItem.Name = "ridFilesToolStripMenuItem";
            this.ridFilesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.ridFilesToolStripMenuItem.Text = "Rid Source";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(219, 6);
            // 
            // addExtensionToolStripMenuItem1
            // 
            this.addExtensionToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("addExtensionToolStripMenuItem1.Image")));
            this.addExtensionToolStripMenuItem1.Name = "addExtensionToolStripMenuItem1";
            this.addExtensionToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.addExtensionToolStripMenuItem1.Tag = "SOURCE_EXT";
            this.addExtensionToolStripMenuItem1.Text = "   Add Extension";
            this.addExtensionToolStripMenuItem1.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // addFolderToolStripMenuItem
            // 
            this.addFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addFolderToolStripMenuItem.Image")));
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addFolderToolStripMenuItem.Tag = "SOURCE_FOLDER";
            this.addFolderToolStripMenuItem.Text = "   Add Folder";
            this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("optionsToolStripMenuItem1.Image")));
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.optionsToolStripMenuItem1.Tag = "OPTIONS";
            this.optionsToolStripMenuItem1.Text = "Options";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(219, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.exitToolStripMenuItem.Tag = "EXIT";
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUnbind,
            this.toolStripSeparator7,
            this.clearWorkspaceToolStripMenuItem,
            this.clearHistoryToolStripMenuItem,
            this.clearLogsToolStripMenuItem,
            this.toolStripSeparator4,
            this.optionsToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // menuItemUnbind
            // 
            this.menuItemUnbind.Image = ((System.Drawing.Image)(resources.GetObject("menuItemUnbind.Image")));
            this.menuItemUnbind.Name = "menuItemUnbind";
            this.menuItemUnbind.Size = new System.Drawing.Size(162, 22);
            this.menuItemUnbind.Tag = "UNBIND";
            this.menuItemUnbind.Text = "Unbind";
            this.menuItemUnbind.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(159, 6);
            // 
            // clearWorkspaceToolStripMenuItem
            // 
            this.clearWorkspaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearWorkspaceToolStripMenuItem.Image")));
            this.clearWorkspaceToolStripMenuItem.Name = "clearWorkspaceToolStripMenuItem";
            this.clearWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.clearWorkspaceToolStripMenuItem.Tag = "CLEAR_WORKSPACE";
            this.clearWorkspaceToolStripMenuItem.Text = "Clear Workspace";
            this.clearWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearHistoryToolStripMenuItem.Image")));
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.clearHistoryToolStripMenuItem.Tag = "CLEAR_HISTORY";
            this.clearHistoryToolStripMenuItem.Text = "Clear Summary";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // clearLogsToolStripMenuItem
            // 
            this.clearLogsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearLogsToolStripMenuItem.Image")));
            this.clearLogsToolStripMenuItem.Name = "clearLogsToolStripMenuItem";
            this.clearLogsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.clearLogsToolStripMenuItem.Tag = "CLEAR_LOGS";
            this.clearLogsToolStripMenuItem.Text = "Clear Logs";
            this.clearLogsToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(159, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("optionsToolStripMenuItem.Image")));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.optionsToolStripMenuItem.Tag = "OPTIONS";
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileExplorerToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.toolStripSeparator2,
            this.hideToolbarToolStripMenuItem,
            this.hideStatusbarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // profileExplorerToolStripMenuItem
            // 
            this.profileExplorerToolStripMenuItem.CheckOnClick = true;
            this.profileExplorerToolStripMenuItem.Name = "profileExplorerToolStripMenuItem";
            this.profileExplorerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.profileExplorerToolStripMenuItem.Tag = "PROFILE_EXPLORER";
            this.profileExplorerToolStripMenuItem.Text = "Profile Explorer";
            this.profileExplorerToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Checked = true;
            this.logsToolStripMenuItem.CheckOnClick = true;
            this.logsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.logsToolStripMenuItem.Tag = "LOGS";
            this.logsToolStripMenuItem.Text = "Profile Details && Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // hideToolbarToolStripMenuItem
            // 
            this.hideToolbarToolStripMenuItem.Checked = true;
            this.hideToolbarToolStripMenuItem.CheckOnClick = true;
            this.hideToolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideToolbarToolStripMenuItem.Name = "hideToolbarToolStripMenuItem";
            this.hideToolbarToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.hideToolbarToolStripMenuItem.Tag = "TOOLBAR";
            this.hideToolbarToolStripMenuItem.Text = "Toolbar";
            this.hideToolbarToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // hideStatusbarToolStripMenuItem
            // 
            this.hideStatusbarToolStripMenuItem.Checked = true;
            this.hideStatusbarToolStripMenuItem.CheckOnClick = true;
            this.hideStatusbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideStatusbarToolStripMenuItem.Name = "hideStatusbarToolStripMenuItem";
            this.hideStatusbarToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.hideStatusbarToolStripMenuItem.Tag = "STATUSBAR";
            this.hideStatusbarToolStripMenuItem.Text = "Statusbar";
            this.hideStatusbarToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem1.Image")));
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Tag = "HELP";
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Tag = "ABOUT";
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.MenuItems_Click);
            // 
            // statusStripUploader
            // 
            this.statusStripUploader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.progressBar,
            this.lblStatusFile});
            this.statusStripUploader.Location = new System.Drawing.Point(0, 471);
            this.statusStripUploader.Name = "statusStripUploader";
            this.statusStripUploader.Size = new System.Drawing.Size(759, 22);
            this.statusStripUploader.TabIndex = 3;
            this.statusStripUploader.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.Text = "Ready...";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 16);
            // 
            // lblStatusFile
            // 
            this.lblStatusFile.Name = "lblStatusFile";
            this.lblStatusFile.Size = new System.Drawing.Size(118, 17);
            this.lblStatusFile.Text = "toolStripStatusLabel2";
            // 
            // toolStripUploader
            // 
            this.toolStripUploader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUnbind,
            this.toolStripLabel2,
            this.toolStripSeparator3,
            this.btnAddFiles,
            this.btnFolder,
            this.toolStripSeparator6,
            this.btnRefreshProfile,
            this.toolStripSeparator10,
            this.btnRidSourceExt,
            this.btnRidSourceFolder,
            this.toolStripSeparator11,
            this.btnClearHistory,
            this.btnClearLogs,
            this.toolStripLabel1,
            this.toolStripSeparator8,
            this.btnOptions,
            this.btnHelp,
            this.btnExit});
            this.toolStripUploader.Location = new System.Drawing.Point(0, 24);
            this.toolStripUploader.Name = "toolStripUploader";
            this.toolStripUploader.Size = new System.Drawing.Size(759, 25);
            this.toolStripUploader.TabIndex = 4;
            this.toolStripUploader.Text = "toolStrip1";
            // 
            // btnUnbind
            // 
            this.btnUnbind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnbind.Image = ((System.Drawing.Image)(resources.GetObject("btnUnbind.Image")));
            this.btnUnbind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnbind.Name = "btnUnbind";
            this.btnUnbind.Size = new System.Drawing.Size(23, 22);
            this.btnUnbind.Tag = "UNBIND";
            this.btnUnbind.Text = "Unbind";
            this.btnUnbind.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(10, 22);
            this.toolStripLabel2.Text = " ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddFiles.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFiles.Image")));
            this.btnAddFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(23, 22);
            this.btnAddFiles.Tag = "ADD_FILES";
            this.btnAddFiles.Text = "Add workspace from selected file";
            this.btnAddFiles.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnFolder.Image")));
            this.btnFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(23, 22);
            this.btnFolder.Tag = "ADD_FOLDER";
            this.btnFolder.Text = "Add workspace from selected folder";
            this.btnFolder.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefreshProfile
            // 
            this.btnRefreshProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefreshProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshProfile.Image")));
            this.btnRefreshProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshProfile.Name = "btnRefreshProfile";
            this.btnRefreshProfile.Size = new System.Drawing.Size(23, 22);
            this.btnRefreshProfile.Tag = "REFRESH";
            this.btnRefreshProfile.Text = "Reload Workspace";
            this.btnRefreshProfile.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRidSourceExt
            // 
            this.btnRidSourceExt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRidSourceExt.Image = ((System.Drawing.Image)(resources.GetObject("btnRidSourceExt.Image")));
            this.btnRidSourceExt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRidSourceExt.Name = "btnRidSourceExt";
            this.btnRidSourceExt.Size = new System.Drawing.Size(23, 22);
            this.btnRidSourceExt.Tag = "SOURCE_EXT";
            this.btnRidSourceExt.Text = "Add Extension source";
            this.btnRidSourceExt.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnRidSourceFolder
            // 
            this.btnRidSourceFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRidSourceFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnRidSourceFolder.Image")));
            this.btnRidSourceFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRidSourceFolder.Name = "btnRidSourceFolder";
            this.btnRidSourceFolder.Size = new System.Drawing.Size(23, 22);
            this.btnRidSourceFolder.Tag = "SOURCE_FOLDER";
            this.btnRidSourceFolder.Text = "Add Folder source";
            this.btnRidSourceFolder.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnClearHistory.Image")));
            this.btnClearHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(23, 22);
            this.btnClearHistory.Tag = "CLEAR_HISTORY";
            this.btnClearHistory.Text = "Clear Summary";
            this.btnClearHistory.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClearLogs.Image = ((System.Drawing.Image)(resources.GetObject("btnClearLogs.Image")));
            this.btnClearLogs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(23, 22);
            this.btnClearLogs.Tag = "CLEAR_LOGS";
            this.btnClearLogs.Text = "Clear Logs";
            this.btnClearLogs.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(19, 22);
            this.toolStripLabel1.Text = "    ";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOptions
            // 
            this.btnOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(23, 22);
            this.btnOptions.Tag = "OPTIONS";
            this.btnOptions.Text = "Options";
            this.btnOptions.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 22);
            this.btnHelp.Tag = "HELP";
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 22);
            this.btnExit.Tag = "EXIT";
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.panelProfileTop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(759, 422);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.workspaceListBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 398);
            this.panel1.TabIndex = 3;
            // 
            // workspaceListBox
            // 
            this.workspaceListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workspaceListBox.AutoScroll = true;
            this.workspaceListBox.AutoScrollMinSize = new System.Drawing.Size(171, 0);
            this.workspaceListBox.BackColor = System.Drawing.Color.White;
            this.workspaceListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workspaceListBox.Controls.Add(this.panelLocked);
            this.workspaceListBox.DateFont = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workspaceListBox.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workspaceListBox.ForeColor = System.Drawing.Color.Green;
            this.workspaceListBox.HeaderColor = System.Drawing.Color.Black;
            this.workspaceListBox.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.workspaceListBox.Location = new System.Drawing.Point(3, 0);
            this.workspaceListBox.Name = "workspaceListBox";
            this.workspaceListBox.SelectedBackColor = System.Drawing.Color.WhiteSmoke;
            this.workspaceListBox.SelectedIndex = -1;
            this.workspaceListBox.SelectedItem = null;
            this.workspaceListBox.SelectedTextColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.workspaceListBox.SeparatorColor = System.Drawing.Color.WhiteSmoke;
            this.workspaceListBox.Size = new System.Drawing.Size(201, 377);
            this.workspaceListBox.TabIndex = 4;
            this.workspaceListBox.DoubleClick += new System.EventHandler(this.profileListBox_DoubleClick);
            this.workspaceListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.profileListBox_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 24);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Double click workspace item to open.";
            // 
            // panelProfileTop
            // 
            this.panelProfileTop.Controls.Add(this.label1);
            this.panelProfileTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfileTop.Location = new System.Drawing.Point(0, 0);
            this.panelProfileTop.Name = "panelProfileTop";
            this.panelProfileTop.Size = new System.Drawing.Size(206, 24);
            this.panelProfileTop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recent Workspaces";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer2.Panel1.Controls.Add(this.panelFilesTop);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControlDetails);
            this.splitContainer2.Size = new System.Drawing.Size(549, 422);
            this.splitContainer2.SplitterDistance = 258;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFiles);
            this.tabControl1.Controls.Add(this.tabPageSummary);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageListInfo;
            this.tabControl1.ItemSize = new System.Drawing.Size(55, 24);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 234);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageFiles
            // 
            this.tabPageFiles.Controls.Add(this.panelLockedBody);
            this.tabPageFiles.Controls.Add(this.listViewFiles);
            this.tabPageFiles.ImageIndex = 3;
            this.tabPageFiles.Location = new System.Drawing.Point(4, 28);
            this.tabPageFiles.Name = "tabPageFiles";
            this.tabPageFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFiles.Size = new System.Drawing.Size(541, 202);
            this.tabPageFiles.TabIndex = 0;
            this.tabPageFiles.Text = "Files";
            this.tabPageFiles.UseVisualStyleBackColor = true;
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSize,
            this.colModified,
            this.colType});
            this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.LargeImageList = this.imageList32;
            this.listViewFiles.Location = new System.Drawing.Point(3, 3);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(535, 196);
            this.listViewFiles.SmallImageList = this.imageList16;
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 196;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.Width = 82;
            // 
            // colModified
            // 
            this.colModified.Text = "Modified";
            this.colModified.Width = 128;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 113;
            // 
            // imageList32
            // 
            this.imageList32.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList32.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList32.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList16
            // 
            this.imageList16.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList16.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList16.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Controls.Add(this.listViewHistory);
            this.tabPageSummary.ImageIndex = 4;
            this.tabPageSummary.Location = new System.Drawing.Point(4, 28);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSummary.Size = new System.Drawing.Size(541, 202);
            this.tabPageSummary.TabIndex = 1;
            this.tabPageSummary.Text = "Summary";
            this.tabPageSummary.UseVisualStyleBackColor = true;
            // 
            // listViewHistory
            // 
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSourceType,
            this.columnHeaderSourceCount,
            this.columnHeaderDetails});
            this.listViewHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.LargeImageList = this.imageList32;
            this.listViewHistory.Location = new System.Drawing.Point(3, 3);
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(535, 196);
            this.listViewHistory.SmallImageList = this.imgSources;
            this.listViewHistory.TabIndex = 1;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSourceType
            // 
            this.columnHeaderSourceType.Text = "Source Type";
            this.columnHeaderSourceType.Width = 176;
            // 
            // columnHeaderSourceCount
            // 
            this.columnHeaderSourceCount.Text = "Source Count";
            this.columnHeaderSourceCount.Width = 80;
            // 
            // columnHeaderDetails
            // 
            this.columnHeaderDetails.Text = "Details";
            this.columnHeaderDetails.Width = 230;
            // 
            // imgSources
            // 
            this.imgSources.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSources.ImageStream")));
            this.imgSources.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSources.Images.SetKeyName(0, "vs-solution.png");
            this.imgSources.Images.SetKeyName(1, "vs-csproj.png");
            this.imgSources.Images.SetKeyName(2, "vs-vbproj.png");
            this.imgSources.Images.SetKeyName(3, "vs-vssource.png");
            this.imgSources.Images.SetKeyName(4, "vs-unknown.png");
            this.imgSources.Images.SetKeyName(5, "vs-project.png");
            this.imgSources.Images.SetKeyName(6, "vs-profile.png");
            this.imgSources.Images.SetKeyName(7, "plugin.png");
            this.imgSources.Images.SetKeyName(8, "folder--arrow.png");
            // 
            // imageListInfo
            // 
            this.imageListInfo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListInfo.ImageStream")));
            this.imageListInfo.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListInfo.Images.SetKeyName(0, "exclamation-red.png");
            this.imageListInfo.Images.SetKeyName(1, "exclamation-circle.png");
            this.imageListInfo.Images.SetKeyName(2, "tick-circle.png");
            this.imageListInfo.Images.SetKeyName(3, "blue-folder-broken.png");
            this.imageListInfo.Images.SetKeyName(4, "history.png");
            this.imageListInfo.Images.SetKeyName(5, "cloud_version.png");
            this.imageListInfo.Images.SetKeyName(6, "application-profile.png");
            this.imageListInfo.Images.SetKeyName(7, "bug--minus.png");
            this.imageListInfo.Images.SetKeyName(8, "vs-profile.png");
            this.imageListInfo.Images.SetKeyName(9, "flag--exclamation.png");
            // 
            // panelFilesTop
            // 
            this.panelFilesTop.Controls.Add(this.lblProfileCaption);
            this.panelFilesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilesTop.Location = new System.Drawing.Point(0, 0);
            this.panelFilesTop.Name = "panelFilesTop";
            this.panelFilesTop.Size = new System.Drawing.Size(549, 24);
            this.panelFilesTop.TabIndex = 3;
            // 
            // lblProfileCaption
            // 
            this.lblProfileCaption.AutoSize = true;
            this.lblProfileCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileCaption.Location = new System.Drawing.Point(3, 6);
            this.lblProfileCaption.Name = "lblProfileCaption";
            this.lblProfileCaption.Size = new System.Drawing.Size(13, 13);
            this.lblProfileCaption.TabIndex = 1;
            this.lblProfileCaption.Text = "?";
            // 
            // tabControlDetails
            // 
            this.tabControlDetails.Controls.Add(this.tabPageProfile);
            this.tabControlDetails.Controls.Add(this.tabPageRidFiles);
            this.tabControlDetails.Controls.Add(this.tabPageLogs);
            this.tabControlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDetails.ImageList = this.imageListInfo;
            this.tabControlDetails.Location = new System.Drawing.Point(0, 0);
            this.tabControlDetails.Name = "tabControlDetails";
            this.tabControlDetails.SelectedIndex = 0;
            this.tabControlDetails.Size = new System.Drawing.Size(549, 160);
            this.tabControlDetails.TabIndex = 0;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Controls.Add(this.pBoxVersionCompare);
            this.tabPageProfile.Controls.Add(this.lblName);
            this.tabPageProfile.Controls.Add(this.label8);
            this.tabPageProfile.Controls.Add(this.lblPath);
            this.tabPageProfile.Controls.Add(this.label7);
            this.tabPageProfile.Controls.Add(this.lblValidFiles);
            this.tabPageProfile.Controls.Add(this.label5);
            this.tabPageProfile.Controls.Add(this.lblScannedFiles);
            this.tabPageProfile.Controls.Add(this.label2);
            this.tabPageProfile.ImageIndex = 8;
            this.tabPageProfile.Location = new System.Drawing.Point(4, 23);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(541, 133);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.Text = "Workspace Details";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // pBoxVersionCompare
            // 
            this.pBoxVersionCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxVersionCompare.Image = global::Tarsier.VSSource.Unbinder.Properties.Resources.folder_ok;
            this.pBoxVersionCompare.Location = new System.Drawing.Point(517, 8);
            this.pBoxVersionCompare.Name = "pBoxVersionCompare";
            this.pBoxVersionCompare.Size = new System.Drawing.Size(16, 16);
            this.pBoxVersionCompare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBoxVersionCompare.TabIndex = 10;
            this.pBoxVersionCompare.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(90, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(11, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Tag = "CLEAR";
            this.lblName.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Name:";
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.AutoEllipsis = true;
            this.lblPath.Location = new System.Drawing.Point(93, 81);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(406, 22);
            this.lblPath.TabIndex = 7;
            this.lblPath.Tag = "CLEAR";
            this.lblPath.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Path:";
            // 
            // lblValidFiles
            // 
            this.lblValidFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidFiles.Location = new System.Drawing.Point(90, 33);
            this.lblValidFiles.Name = "lblValidFiles";
            this.lblValidFiles.Size = new System.Drawing.Size(430, 16);
            this.lblValidFiles.TabIndex = 3;
            this.lblValidFiles.Tag = "CLEAR";
            this.lblValidFiles.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Valid Files:";
            // 
            // lblScannedFiles
            // 
            this.lblScannedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScannedFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblScannedFiles.Location = new System.Drawing.Point(88, 9);
            this.lblScannedFiles.Name = "lblScannedFiles";
            this.lblScannedFiles.Size = new System.Drawing.Size(398, 16);
            this.lblScannedFiles.TabIndex = 1;
            this.lblScannedFiles.Tag = "CLEAR";
            this.lblScannedFiles.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Scanned Files:";
            // 
            // tabPageRidFiles
            // 
            this.tabPageRidFiles.Controls.Add(this.listViewRids);
            this.tabPageRidFiles.Controls.Add(this.label4);
            this.tabPageRidFiles.ImageIndex = 9;
            this.tabPageRidFiles.Location = new System.Drawing.Point(4, 23);
            this.tabPageRidFiles.Name = "tabPageRidFiles";
            this.tabPageRidFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRidFiles.Size = new System.Drawing.Size(541, 133);
            this.tabPageRidFiles.TabIndex = 2;
            this.tabPageRidFiles.Text = "Rid Sources";
            this.tabPageRidFiles.UseVisualStyleBackColor = true;
            // 
            // listViewRids
            // 
            this.listViewRids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewRids.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderType});
            this.listViewRids.FullRowSelect = true;
            this.listViewRids.LargeImageList = this.imageList32;
            this.listViewRids.Location = new System.Drawing.Point(2, 24);
            this.listViewRids.Name = "listViewRids";
            this.listViewRids.Size = new System.Drawing.Size(535, 104);
            this.listViewRids.SmallImageList = this.imgSources;
            this.listViewRids.TabIndex = 2;
            this.listViewRids.UseCompatibleStateImageBehavior = false;
            this.listViewRids.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 240;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Type";
            this.columnHeaderType.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(8, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(433, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "All folders and files with extension below will be deleted during source unbindin" +
    "g if found.";
            // 
            // tabPageLogs
            // 
            this.tabPageLogs.Controls.Add(this.listLogs);
            this.tabPageLogs.ImageIndex = 7;
            this.tabPageLogs.Location = new System.Drawing.Point(4, 23);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogs.Size = new System.Drawing.Size(541, 133);
            this.tabPageLogs.TabIndex = 1;
            this.tabPageLogs.Text = "Logs";
            this.tabPageLogs.UseVisualStyleBackColor = true;
            // 
            // listLogs
            // 
            this.listLogs.AutoScroll = true;
            this.listLogs.AutoScrollMinSize = new System.Drawing.Size(505, 0);
            this.listLogs.BackColor = System.Drawing.Color.White;
            this.listLogs.DateFont = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLogs.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLogs.HeaderColor = System.Drawing.Color.Black;
            this.listLogs.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.listLogs.Location = new System.Drawing.Point(3, 3);
            this.listLogs.Name = "listLogs";
            this.listLogs.SelectedBackColor = System.Drawing.Color.WhiteSmoke;
            this.listLogs.SelectedIndex = -1;
            this.listLogs.SelectedItem = null;
            this.listLogs.SelectedTextColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listLogs.SeparatorColor = System.Drawing.Color.WhiteSmoke;
            this.listLogs.Size = new System.Drawing.Size(535, 127);
            this.listLogs.TabIndex = 5;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // tmrCheck
            // 
            this.tmrCheck.Enabled = true;
            this.tmrCheck.Interval = 500;
            this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
            // 
            // tipUploader
            // 
            this.tipUploader.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // bgWorkerUnbind
            // 
            this.bgWorkerUnbind.WorkerReportsProgress = true;
            this.bgWorkerUnbind.WorkerSupportsCancellation = true;
            this.bgWorkerUnbind.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerUnbind_DoWork);
            this.bgWorkerUnbind.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerUnbind_ProgressChanged);
            this.bgWorkerUnbind.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerUnbind_RunWorkerCompleted);
            // 
            // panelLocked
            // 
            this.panelLocked.Controls.Add(this.label9);
            this.panelLocked.Controls.Add(this.label6);
            this.panelLocked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLocked.Location = new System.Drawing.Point(0, 0);
            this.panelLocked.Name = "panelLocked";
            this.panelLocked.Size = new System.Drawing.Size(199, 375);
            this.panelLocked.TabIndex = 0;
            this.panelLocked.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(7, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Please be patient";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(4, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 55);
            this.label9.TabIndex = 1;
            this.label9.Text = "Loading data is in progress. Please wait...";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerLock
            // 
            this.timerLock.Interval = 2000;
            this.timerLock.Tick += new System.EventHandler(this.timerLock_Tick);
            // 
            // panelLockedBody
            // 
            this.panelLockedBody.Controls.Add(this.label10);
            this.panelLockedBody.Controls.Add(this.label11);
            this.panelLockedBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLockedBody.Location = new System.Drawing.Point(3, 3);
            this.panelLockedBody.Name = "panelLockedBody";
            this.panelLockedBody.Size = new System.Drawing.Size(535, 196);
            this.panelLockedBody.TabIndex = 6;
            this.panelLockedBody.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(7, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(523, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Please be patient";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(4, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(526, 55);
            this.label10.TabIndex = 1;
            this.label10.Text = "Loading data is in progress. Please wait...";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 493);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripUploader);
            this.Controls.Add(this.statusStripUploader);
            this.Controls.Add(this.menuStripUploader);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripUploader;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarsier VS Source Control Unbinder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.UploadForm_Load);
            this.menuStripUploader.ResumeLayout(false);
            this.menuStripUploader.PerformLayout();
            this.statusStripUploader.ResumeLayout(false);
            this.statusStripUploader.PerformLayout();
            this.toolStripUploader.ResumeLayout(false);
            this.toolStripUploader.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.workspaceListBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelProfileTop.ResumeLayout(false);
            this.panelProfileTop.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFiles.ResumeLayout(false);
            this.tabPageSummary.ResumeLayout(false);
            this.panelFilesTop.ResumeLayout(false);
            this.panelFilesTop.PerformLayout();
            this.tabControlDetails.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxVersionCompare)).EndInit();
            this.tabPageRidFiles.ResumeLayout(false);
            this.tabPageRidFiles.PerformLayout();
            this.tabPageLogs.ResumeLayout(false);
            this.panelLocked.ResumeLayout(false);
            this.panelLockedBody.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripUploader;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemFiles;
        private System.Windows.Forms.ToolStripMenuItem menuItemFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripUploader;
        private System.Windows.Forms.ToolStripMenuItem menuItemUnbind;
        private System.Windows.Forms.ToolStripMenuItem hideToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideStatusbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripUploader;
        private System.Windows.Forms.ToolStripButton btnAddFiles;
        private System.Windows.Forms.ToolStripButton btnFolder;
        private System.Windows.Forms.ToolStripButton btnUnbind;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelProfileTop;
        private System.Windows.Forms.Panel panelFilesTop;
        private System.Windows.Forms.Label lblProfileCaption;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlDetails;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabPageLogs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnOptions;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusFile;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colModified;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.Label lblScannedFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Tarsier.UI.MessageListBox workspaceListBox;
        private System.Windows.Forms.Timer tmrCheck;
        private Tarsier.UI.MessageListBox listLogs;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblValidFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList16;
        private System.Windows.Forms.ImageList imageList32;
        private System.Windows.Forms.ImageList imageListInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem clearLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnClearLogs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem profileExplorerToolStripMenuItem;
        private System.Windows.Forms.PictureBox pBoxVersionCompare;
        private System.Windows.Forms.ToolStripButton btnRefreshProfile;
        private System.Windows.Forms.ToolTip tipUploader;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFiles;
        private System.Windows.Forms.TabPage tabPageSummary;
        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.ColumnHeader columnHeaderSourceType;
        private System.Windows.Forms.ColumnHeader columnHeaderDetails;
        private System.Windows.Forms.ColumnHeader columnHeaderSourceCount;
        private System.Windows.Forms.ToolStripButton btnClearHistory;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.ComponentModel.BackgroundWorker bgWorkerUnbind;
        private System.Windows.Forms.ImageList imgSources;
        private System.Windows.Forms.ToolStripMenuItem clearWorkspaceToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageRidFiles;
        private System.Windows.Forms.ListView listViewRids;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem ridFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton btnRidSourceExt;
        private System.Windows.Forms.ToolStripButton btnRidSourceFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem addExtensionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.Panel panelLocked;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timerLock;
        private System.Windows.Forms.Panel panelLockedBody;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

