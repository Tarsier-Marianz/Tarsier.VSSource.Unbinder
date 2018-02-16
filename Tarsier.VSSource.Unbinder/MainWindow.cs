﻿using Tarsier.VSSource.Unbinder.Constants;
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
        private IconListManager _iconListManager;
        private Workspaces _workspacse;
        private UnbindHistory _history;
        private Logs _logs;
        private Workspace _selectedWorkspace = null;
        private History _selectedHistory = null;
        private AddFile _loadFile = AddFile.FILES;

        private string[] _files;
        private string _intialDirectory = string.Empty;
        private string _directory = string.Empty;
        private string _folder = string.Empty;
        private bool _executeNewWorkspace = false;
        private bool _automaticSaveWorkspace = true;
        private bool _autoUnBind = true;
        private bool _truncatePath = false;
        private bool _isLoading = false;
        private int _fileIndex = 0;
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
            workspaceListBox.Items.Clear();
            _workspacse.Initialize(workspaceListBox);
            _logs.Initialize(listLogs);

        }
        private void InitHistory(string profileName) {
            _history = new UnbindHistory(Database.HISTORY);
            tabPageHistory.Text = "History";
            if(!string.IsNullOrEmpty(profileName)) {
                listViewHistory.Items.Clear();
                _history.Initialize(listViewHistory, profileName);
                tabPageHistory.Text = (listViewHistory.Items.Count > 0) ? string.Format("History [{0}]", listViewHistory.Items.Count) : "History";
            }
        }
        private void Action(string tag) {
            switch(tag) {
                case "NEW_PROF":
                    NewProfile();
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
                case "CLEAR_LOGS":
                    if(_logs != null) {
                        if(MessageBox.Show("Logs will be deleted permanently!\nAre you sure you want to clear all logs?", "Clear Logs", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) {
                            _logs.ClearAllLog();
                            _logs.Initialize(listLogs);
                        }
                    }
                    break;
                case "CLEAR_HISTORY":
                    listViewHistory.Items.Clear();
                    break;
                default:
                    break;
            }
        }

        private void NewProfile() {
            lblProfileCaption.Text = string.Empty;
            tabPageFiles.Text = "Files";
            tabPageHistory.Text = "History";
            lblStatus.Text = "Ready...";
            lblStatusFile.Text = string.Empty;
            progressBar.Visible = false;
            pBoxVersionCompare.Image = null;
            listViewFiles.Items.Clear();
            listViewHistory.Items.Clear();
            _selectedWorkspace = null;
            _selectedHistory = null;
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
                        FileCount = _scannedFiles,
                        ValidFiles = _validFiles,
                        Directory = _directory,
                        Comment = string.Empty
                    };
                    _workspacse.Add(_selectedWorkspace);
                } else {
                    _workspacse.Add(_selectedWorkspace);
                }
            }
        }

        private void AddFiles(AddFile file) {
            _loadFile = file;
            if(file == AddFile.FILES) {
                using(OpenFileDialog opd = new OpenFileDialog()) {
                    opd.Filter = Dialogs.GetFilters(Filters.SUPPORTED_FILES);
                    opd.Multiselect = true;
                    if(opd.ShowDialog().Equals(DialogResult.OK)) {
                        _files = opd.FileNames;
                        if(_files.Length > 1) {
                            StartLoadFiles(true);
                        }else {
                            FileInfo info = new FileInfo(_files[0]);
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
                        }
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
            if(_loadFile == AddFile.FILES) {
                LoadFiles(e);
            } else {
                if(Directory.Exists(_directory)) {
                    _files = Directory.GetFiles(_directory, "*.*", SearchOption.AllDirectories);
                    LoadFiles(e);
                }
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
                }
            }
            lblScannedFiles.Text = _scannedFiles + "";
            lblValidFiles.Text = _validFiles + "";
            tabPageFiles.Text = string.Format("Files [{0}]", listViewFiles.Items.Count);
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
           
            SetProfileDetails();
            lblStatusFile.Text = (_truncatePath) ? _folder.TruncatePath() : _folder;
            lblStatus.Text = "Finished...";
            progressBar.Value = 0;
            progressBar.Visible = false;
            _isLoading = false;
            ToolBarMenusVisibility(true);
            
            if(_sourceEntries.Count> 0) {
                _logs.Add(string.Format("Loading {0} files from folder {1}.", _sourceEntries.Count, _folder), "Events", "Load Profile", ParseMessageType.File);
                _logs.Initialize(listLogs);
            }
            if(_automaticSaveWorkspace) {
                SaveProfile();
                InitWorkspace();
            }
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
                            _directory = _selectedWorkspace.Directory;
                            _folder = _selectedWorkspace.Name;
                            if(!string.IsNullOrEmpty(_directory)) {
                                _loadFile = AddFile.FOLDER;
                                StartLoadFiles(false);
                                InitHistory(_selectedWorkspace.Name);
                            }
                        }
                    } else {
                        _selectedWorkspace = null;
                    }
                }
            }
        }

        private void ToolBarMenusVisibility(bool state) {
             btnSaveProfile.Enabled = btnAddFiles.Enabled = btnFolder.Enabled =  btnUpload.Enabled =
               newProfileToolStripMenuItem.Enabled = saveProfileToolStripMenuItem.Enabled = addFileToolStripMenuItem.Enabled =
               loadFromFolderToolStripMenuItem.Enabled = loadFileFromExeToolStripMenuItem.Enabled = uploadToolStripMenuItem.Enabled = state;
        }
        private void tmrCheck_Tick(object sender, EventArgs e) {
            //ToolBarMenusVisibility(!_isLoading);
            btnUpload.Enabled = uploadToolStripMenuItem.Enabled = listViewFiles.Items.Count > 0;
            btnClearHistory.Enabled = clearHistoryToolStripMenuItem.Enabled = (tabControl1.SelectedIndex == 1 && listViewHistory.Items.Count > 0);
        }

        private void SetProfileDetails() {
           /*
            if(string.IsNullOrEmpty(_folder)) {
                lblPath.Text = string.Empty;
                lblPath.Image = Resources.exclamation_red;
            } else {
                lblPath.Image = null;
                lblPath.Text = _folder;
            }*/
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
        }
    }
}