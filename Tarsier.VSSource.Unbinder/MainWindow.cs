using Tarsier.VSSource.Unbinder.Constants;
using Tarsier.VSSource.Unbinder.Controllers;
using Tarsier.VSSource.Unbinder.Enums;
using Tarsier.VSSource.Unbinder.Forms;
using Tarsier.VSSource.Unbinder.Helpers;
using Tarsier.VSSource.Unbinder.Models;
using Tarsier.VSSource.Unbinder.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Tarsier.Extensions;
using Tarsier.Regedit;
using Tarsier.UI;
using Tarsier.UI.Icons;
using Tarsier.Sources;
using Tarsier.Sources.Enumeration;
using Tarsier.Sources.Events;

namespace Tarsier.VSSource.Unbinder {
    public partial class MainWindow : Form {
        private SourceUnbinder _unbinder = new SourceUnbinder();
        private SourceControlAnalyzer _controlAnalyzer = new SourceControlAnalyzer();
        private List<FileEntry> _sourceEntries = new List<FileEntry>();
        private List<RidSource> _listSources = new List<RidSource>();
        private List<FileInfo> _filesToRid = new List<FileInfo>();
        private IconListManager _iconListManager;
        private Workspaces _workspacse;
        private UnbindHistory _history;
        private RidSources _ridSources;
        private Logs _logs;
        private Workspace _selectedWorkspace = null;
        private AddFile _loadFile = AddFile.FILES;

        private string[] _files;
        private string _intialDirectory = string.Empty;
        private string _directory = string.Empty;
        private string _folder = string.Empty;
        private string _workspaceTable = string.Empty;
        private bool _executeNewWorkspace = false;
        private bool _automaticSaveWorkspace = true;
        private bool _autoUnBind = true;
        private bool _truncatePath = false;
        private bool _isLoading = false;
        private int _validFiles = 0;
        private int _scannedFiles = 0;

        public MainWindow() {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = true;
            Text = new AppInfo().AssemblyTitle;
        }

        #region -Private Methods -

        private void InitSettings() {
            FileHelper.CheckAssociation();
            _iconListManager = new IconListManager(imageList16, IconReader.IconSize.Small);
            _intialDirectory = RegConfig.Get<string>("InitialDirectory");
            _truncatePath = RegConfig.Get<bool>("TruncatePath");
            _executeNewWorkspace = RegConfig.Get<bool>("ExecuteNewWorkspace");
            _autoUnBind = RegConfig.Get<bool>("AutoUnbind");
            _automaticSaveWorkspace = RegConfig.Get<bool>("AutoSaveWorkspace");
          
            toolStripUploader.Visible = hideToolbarToolStripMenuItem.Checked = RegConfig.Get<bool>("Toolbar");
            statusStripUploader.Visible = hideStatusbarToolStripMenuItem.Checked = RegConfig.Get<bool>("Statusbar");
            splitContainer2.Panel2Collapsed = !(logsToolStripMenuItem.Checked = RegConfig.Get<bool>("Logs&Details"));
            splitContainer1.Panel1Collapsed = !(profileExplorerToolStripMenuItem.Checked = RegConfig.Get<bool>("ProfileExplorer"));
        }
        private void InitWorkspace() {
            _workspacse = new Workspaces(Database.WORKSPACES);
            _logs = new Logs(Database.WORKSPACES);
            _ridSources = new RidSources(Database.WORKSPACES);
            workspaceListBox.Items.Clear();
            _workspacse.Initialize(workspaceListBox);
            _logs.Initialize(listLogs);
            _ridSources.Initialize(listViewRids);
            _listSources = _ridSources.GetSources();

        }
        private void InitHistory(string profileName) {
            _history = new UnbindHistory(Database.HISTORY);
            tabPageSummary.Text = "Summary";
            if(!string.IsNullOrEmpty(profileName)) {
                listViewHistory.Items.Clear();
                _history.Initialize(listViewHistory, profileName);
                tabPageSummary.Text = (listViewHistory.Items.Count > 0) ? string.Format("Summary [{0}]", listViewHistory.Items.Count) : "Summary";
            }
        }
        private void Action(string tag) {
            switch(tag) {
                case "NEW_PROF":
                    //NewProfile();
                    break;
                case "SAVE_PROF":
                    SaveProfile();
                    break;
                case "ADD_FILES":
                    AddFiles(AddFile.FILES);
                    break;
                case "ADD_FOLDER":
                    AddFiles(AddFile.FOLDER);
                    break;
                case "REFRESH":
                    InitWorkspace();
                    InitHistory(_workspaceTable);
                    break;
                case "UNBIND":
                    Unbind();
                    break;
                case "SERVER_CONFIG":
                case "OPTIONS":
                    using(ConfigServerForm config = new ConfigServerForm(tag.Equals("SERVER_CONFIG") ? 1 : 0)) {
                        if(config.ShowDialog().Equals(DialogResult.OK)) {
                            InitSettings();
                        }
                    }
                    break;
                case "EXIT":
                    Close();
                    break;
                case "ABOUT":
                    using(AboutForm about = new AboutForm()) {
                        about.ShowDialog();
                    }
                    break;
                case "HELP":
                    using(HelpForm help = new HelpForm()) {
                        help.ShowDialog();
                    }
                    break;
                case "TOOLBAR":
                    RegConfig.Set<bool>("Toolbar", hideToolbarToolStripMenuItem.Checked);
                    toolStripUploader.Visible = hideToolbarToolStripMenuItem.Checked;
                    break;
                case "STATUSBAR":
                    RegConfig.Set<bool>("Statusbar", hideStatusbarToolStripMenuItem.Checked);
                    statusStripUploader.Visible = hideStatusbarToolStripMenuItem.Checked;
                    break;
                case "PROFILE_DETAILS":
                    break;
                case "PROFILE_EXPLORER":
                    RegConfig.Set<bool>("ProfileExplorer", profileExplorerToolStripMenuItem.Checked);
                    splitContainer1.Panel1Collapsed = !profileExplorerToolStripMenuItem.Checked;
                    break;
                case "LOGS":
                    RegConfig.Set<bool>("Logs&Details", logsToolStripMenuItem.Checked);
                    splitContainer2.Panel2Collapsed = !logsToolStripMenuItem.Checked;
                    break;
                case "CLEAR_WORKSPACE":
                    if(_workspacse != null) {
                        if(MessageBox.Show("Workspace will be deleted permanently!\nAre you sure you want to clear all workspace?", "Clear Workspace", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) {

                            List<Workspace> ws = _workspacse.GetProfiles();
                            if(ws.Count > 0) {
                                foreach(Workspace w in ws) {
                                    _history.ClearHistory(w.Name.RemoveNonAlphaNumeric().ToLower());
                                }
                            }
                            _workspacse.ClearWorkspaces();
                            InitWorkspace();
                        }
                    }
                    break;
                case "CLEAR_LOGS":
                    if(_logs != null) {
                        if(MessageBox.Show("Logs will be deleted permanently!\nAre you sure you want to clear all logs?", "Clear Logs", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) {
                            _logs.ClearAllLog();
                            _logs.Initialize(listLogs);
                        }
                    }
                    break;
                case "CLEAR_HISTORY":
                    if(_selectedWorkspace != null) {
                        if(MessageBox.Show("History will be deleted permanently!\nAre you sure you want to clear all history?", "Clear History", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) {
                            _history.ClearHistory();
                            InitHistory(_selectedWorkspace.Name);
                        }
                    }
                    break;
                case "SOURCE_EXT":
                case "SOURCE_FOLDER":
                    using(SourceForm s = new SourceForm(tag)) {
                        if(s.ShowDialog().Equals(DialogResult.OK)) {
                            string extension = s.SourceName.StartsWith(".") ? s.SourceName : "." + s.SourceName;
                            RidSource rs = new RidSource() {
                                Name = (tag.Equals("SOURCE_EXT")) ? extension : s.SourceName,
                                Type = (tag.Equals("SOURCE_EXT")) ? "Extension" : "Folder"
                            };
                            _ridSources.Add(rs);
                            _ridSources.Initialize(listViewRids);
                            _listSources = _ridSources.GetSources();
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        
        private void NewProfile() {
            lblProfileCaption.Text = string.Empty;
            tabPageFiles.Text = "Files";
            tabPageSummary.Text = "Summary";
            lblStatus.Text = "Ready...";
            lblStatusFile.Text = string.Empty;
            progressBar.Visible = false;
            pBoxVersionCompare.Image = null;
            listViewFiles.Items.Clear();
            listViewHistory.Items.Clear();
            _selectedWorkspace = null;
            _files = null;
            _scannedFiles = 0;
            _validFiles = 0;
            Elements.ClearProfileDetails(tabPageProfile);
        }


        private void SaveProfile() {
            if(listViewFiles.Items.Count > 0) {
                if(_selectedWorkspace == null) {
                    _selectedWorkspace = new Workspace() {
                        Name = _folder,
                        WorkspaceTable = (_folder.RemoveNonAlphaNumeric() + _directory.RemoveNonAlphaNumeric().GetHashCode()).ToLower(),
                        FileCount = _scannedFiles,
                        ValidFiles = _validFiles,
                        Directory = _directory,
                        Comment = string.Empty
                    };
                }
                _workspaceTable = _selectedWorkspace.WorkspaceTable; 
                _workspacse.Add(_selectedWorkspace);
                InitHistory(_workspaceTable);
                menuItemUnbind.Text = btnUnbind.Text = "Unbind " + _selectedWorkspace.Name;
            }
        }
        private void AddFiles(AddFile file) {
            _loadFile = file;
            if(file == AddFile.FILES) {
                using(OpenFileDialog opd = new OpenFileDialog()) {
                    opd.Filter = Dialogs.GetFilters(Filters.SUPPORTED_FILES);
                    opd.Multiselect = false;
                    if(opd.ShowDialog().Equals(DialogResult.OK)) {
                        _directory = Path.GetDirectoryName(opd.FileName);
                        _folder = Path.GetFileName(_directory);
                        RegConfig.Set<string>("InitialDirectory", _directory);
                        StartLoadFiles(true);
                    }
                }
            } else {
                using(FolderBrowserDialog fbd = new FolderBrowserDialog()) {
                    fbd.Description = Titles.FOLDER_BROWSER;
                    fbd.SelectedPath = _intialDirectory;
                    if(fbd.ShowDialog().Equals(DialogResult.OK)) {
                        _directory = fbd.SelectedPath;
                        _folder = Path.GetFileName(_directory);
                        RegConfig.Set<string>("InitialDirectory", _directory);
                        StartLoadFiles(true);
                    }
                }
            }
        }

        private void Unbind() {
            if(_isLoading) { return; } //do nothing if still loading
            if(_sourceEntries.Count > 0) {
                UpdateProgress(_sourceEntries.Count+_filesToRid.Count, true);
                _unbinder.UnbindProgress += UnbindProgress;
                if(!bgWorkerUnbind.IsBusy) {
                    lblProfileCaption.Text =
                        lblStatus.Text = "Unbinding...";
                    _isLoading = progressBar.Visible = true;
                    ToolBarMenusVisibility(false);
                    bgWorkerUnbind.RunWorkerAsync();
                }
            }
        }
        private void UpdateProgress(int value, bool maximum) {
            if(progressBar.GetCurrentParent().InvokeRequired) {
                progressBar.GetCurrentParent().Invoke((MethodInvoker)delegate () {
                    if(maximum) {
                        progressBar.Maximum = value;
                    } else {
                        progressBar.Value = value;
                    }
                });
            } else {
                if(maximum) {
                    progressBar.Maximum = value;
                } else {
                    progressBar.Value = value;
                }
            }
        }

        private void AddFileList(FileInfo info) {
            ListViewItem item = new ListViewItem(info.Name, _iconListManager.AddFileIcon(info.FullName));
            item.UseItemStyleForSubItems = false;
            item.SubItems.Add(info.Length.ToFileSize());
            item.SubItems.Add(info.LastWriteTime.ToString("yyyy/MM/dd hh:mm:ss tt"));
            item.SubItems.Add(Shell32.GetFileType(info));
            //item.SubItems[0].ForeColor = Color.Blue;
            item.SubItems[1].ForeColor = Color.Gray;
            item.SubItems[2].ForeColor = Color.Gray;
            item.SubItems[3].ForeColor = Color.DarkGray;
            if(listViewFiles.InvokeRequired) {
                listViewFiles.Invoke((MethodInvoker)delegate () {
                    listViewFiles.Items.Add(item);
                });
            } else {
                listViewFiles.Items.Add(item);
            }
            listViewFiles.Invalidate();
        }

        private void StartLoadFiles(bool newProfile) {
            if(!bgWorker.IsBusy) {
                if(newProfile) {
                    NewProfile();
                }
                if(_autoUnBind) {
                    _unbinder.UnbindProgress += UnbindProgress;
                }
                _iconListManager = new IconListManager(imageList16, IconReader.IconSize.Small);
                _iconListManager.ClearLists(); // to refresh Icon from .exe
                ToolBarMenusVisibility(false);
                listViewFiles.Items.Clear();
                lblProfileCaption.Text =
                lblStatus.Text = "Scanning...";
                if(_selectedWorkspace != null) {
                    menuItemUnbind.Text = btnUnbind.Text = "Unbind " + _selectedWorkspace.Name;
                }
                _scannedFiles = 0;
                _validFiles = 0;
                _isLoading = progressBar.Visible = true;
                lblPath.Text = _directory;
                lblName.Text = _folder;
                bgWorker.RunWorkerAsync();
            }
        }
        private void LoadFiles(DoWorkEventArgs e) {
            if(_files.Length > 0) {
                UpdateProgress(_files.Length, true);
                _scannedFiles = 0;
                foreach(string file in _files) {
                    if(bgWorker != null && bgWorker.CancellationPending) {
                        e.Cancel = true;
                        break;
                    }
                    FileInfo info = new FileInfo(file);
                    bgWorker.ReportProgress(_scannedFiles, info);
                    Thread.Sleep(10);
                    _scannedFiles++;
                }
            }
        }
 
        #endregion -Private Methods -

        #region - Control Events -
        private void UploadForm_Load(object sender, EventArgs e) {
            InitSettings();
            NewProfile();
            InitWorkspace();
            InitHistory(string.Empty);
        }

        private void UnbindProgress(object sender, UnbindProgressEvents e) {
            FileEntry entry = e.File;
            string eventType = ParseType.GetStringType(entry.Type);
            if(e.Success) {
                ParseMessageType type = ParseType.GetType(entry.Type);
                _logs.Add(string.Format("Unbinding file: {0} was successfully completed.", entry.Name), "Events", eventType + " " + entry.Name, type);
            }else {
                _logs.Add(string.Format("Unsuccessfull unbinding file: {0} ", entry.Name), "Events", eventType+" "+ entry.Name, ParseMessageType.Error);
            }
        }
        private void Buttons_Click(object sender, EventArgs e) {
            ToolStripButton btn = sender as ToolStripButton;
            if(btn != null) {
                if(btn.Tag != null) {
                    Action(btn.Tag.ToString());
                }
            }
        }

        private void MenuItems_Click(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            if(menu != null) {
                if(menu.Tag != null) {
                    Action(menu.Tag.ToString());
                }
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e) {
            if(Directory.Exists(_directory)) {
                _files = Directory.GetFiles(_directory, "*.*", SearchOption.AllDirectories);
                LoadFiles(e);
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            if(e.ProgressPercentage <= progressBar.Maximum) {
                progressBar.Value = e.ProgressPercentage;
            }

            if(e.UserState != null) {
                FileInfo info = e.UserState as FileInfo;
                if(info != null) {
                    lblStatusFile.Text = info.Name;

                    FileEntry entry = _controlAnalyzer.ValidateSource(info);
                    if(entry != null) {
                        _sourceEntries.Add(entry);
                        AddFileList(info);
                        if(_autoUnBind) {
                            if(_unbinder.UnbindEntry(entry)) {
                            }
                        }
                        _validFiles++;
                    }
                    // Check all rources to get rid
                    foreach(RidSource rs in _listSources) {
                        if(info.Name.EndsWith(rs.Name)) {
                            _filesToRid.Add(info);
                        }
                    }
                }
            }
            lblScannedFiles.Text = _scannedFiles + "";
            lblValidFiles.Text = _validFiles + "";
            tabPageFiles.Text = string.Format("Files [{0}]", listViewFiles.Items.Count);
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if(_autoUnBind) {
                _unbinder.UnbindProgress -= UnbindProgress;
            }
           
            SaveProfile();
            InitWorkspace();

            if(_sourceEntries.Count > 0) {
                _logs.Add(string.Format("Loading {0} files from folder {1}.", _sourceEntries.Count, _folder), "Events", "Load Profile", ParseMessageType.File);
                _logs.Initialize(listLogs);
            }
            if(_autoUnBind) {
                _history.Add(_unbinder.SourceSummary);
            }
            SetProfileDetails();
            lblStatus.Text = "Finished...";
            progressBar.Value = 0;
            progressBar.Visible = false;
            _isLoading = false;
            ToolBarMenusVisibility(true);
        }
        #endregion - Control Events -

        private void profileListBox_DoubleClick(object sender, EventArgs e) {
            if(workspaceListBox.SelectedItemIndices.Count > 0) {
                if(workspaceListBox.SelectedIndex < 0 || workspaceListBox.SelectedItem== null) {
                    return;
                }
                if(!_isLoading) {
                    ParseMessageEventArgs item = workspaceListBox.SelectedItem as ParseMessageEventArgs;
                    if(item != null) {
                        NewProfile();
                        _selectedWorkspace = _workspacse.GetProfile(item.LineHeader);
                        if(_selectedWorkspace != null) {
                            _workspaceTable = _selectedWorkspace.WorkspaceTable;
                            _directory = _selectedWorkspace.Directory;
                            _folder = _selectedWorkspace.Name;
                            if(!string.IsNullOrEmpty(_directory)) {
                                _loadFile = AddFile.FOLDER;
                                StartLoadFiles(false);
                                InitHistory(_workspaceTable);
                            }
                        }
                    } else {
                        _selectedWorkspace = null;
                    }
                }else {
                    panelLocked.Visible = true;
                    timerLock.Enabled = true;
                }
            }
        }

        private void ToolBarMenusVisibility(bool state) {
           btnAddFiles.Enabled = btnFolder.Enabled =  btnUnbind.Enabled= menuItemFiles.Enabled =
               menuItemFolder.Enabled = menuItemUnbind.Enabled = state;
        }
        private void tmrCheck_Tick(object sender, EventArgs e) {
            //ToolBarMenusVisibility(!_isLoading);
            btnUnbind.Enabled = menuItemUnbind.Enabled = (!_isLoading && listViewFiles.Items.Count > 0);
            btnClearHistory.Enabled = clearHistoryToolStripMenuItem.Enabled = (tabControl1.SelectedIndex == 1 && listViewHistory.Items.Count > 0);
        }

        private void SetProfileDetails() {
            lblProfileCaption.Text = _selectedWorkspace.Name;
            lblStatusFile.Text = (_truncatePath) ? _folder.TruncatePath() : _folder;
            lblPath.Text = (_truncatePath) ? _directory.TruncatePath() : _directory;
        }

        private void profileListBox_MouseDoubleClick(object sender, MouseEventArgs e) {
           
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            if(bgWorker.IsBusy) {
                bgWorker.CancelAsync();
                bgWorker.ProgressChanged -= new ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
                bgWorker.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            }
            if(bgWorkerUnbind.IsBusy) {
                bgWorkerUnbind.CancelAsync();
                bgWorkerUnbind.ProgressChanged -= new ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
                bgWorkerUnbind.RunWorkerCompleted -= new RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            }
        }

        private void bgWorkerUnbind_DoWork(object sender, DoWorkEventArgs e) {
            int i = 1;
            foreach(FileEntry entry in _sourceEntries) {
                if(bgWorkerUnbind != null && bgWorkerUnbind.CancellationPending) {
                    e.Cancel = true;
                    break;
                }
                if(_unbinder.UnbindEntry(entry)) {

                }
                bgWorkerUnbind.ReportProgress(i, entry);
                i++;
            }
            foreach(FileInfo fileRid in _filesToRid) {
                if(File.Exists(fileRid.FullName)) {
                    File.Delete(fileRid.FullName);
                }
                bgWorkerUnbind.ReportProgress(i);
                i++;
            }
        }

        private void bgWorkerUnbind_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            if(e.ProgressPercentage <= progressBar.Maximum) {
                progressBar.Value = e.ProgressPercentage;
            }
            if(e.UserState != null) {
                FileEntry entry = e.UserState as FileEntry;
                if(entry != null) {
                    lblStatusFile.Text = entry.Info.FullName;
                }
            }
        }

        private void bgWorkerUnbind_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
           
            lblStatusFile.Text = (_truncatePath) ? _folder.TruncatePath() : _folder;
            lblStatus.Text = "Finished...";
            progressBar.Value = 0;
            progressBar.Visible = false;
            lblProfileCaption.Text = _selectedWorkspace.Name;
            _isLoading = false;
            ToolBarMenusVisibility(true);
            _history.Add(_unbinder.SourceSummary); //Add source summary
            InitHistory(_workspaceTable);

            _unbinder.UnbindProgress -= UnbindProgress;
            _logs.Add(string.Format("Deleting {0} files from folder {1}.", _filesToRid, _folder), "Events", "Delete Files", ParseMessageType.Success);
            _logs.Add(string.Format("Unbinding {0} files from folder {1}.", _sourceEntries.Count, _folder), "Events", "Unbind " + _selectedWorkspace.Name, ParseMessageType.Success);
        }

        private void panelLocked_Paint(object sender, PaintEventArgs e) {

        }

        private void timerLock_Tick(object sender, EventArgs e) {
            panelLocked.Visible = false;
            timerLock.Enabled = false;
        }
    }
}