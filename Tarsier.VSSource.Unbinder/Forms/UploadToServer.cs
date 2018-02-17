using Tarsier.VSSource.Unbinder.Controllers;
using Tarsier.VSSource.Unbinder.Helpers;
using Tarsier.VSSource.Unbinder.Models;
using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Tarsier.Extensions;
using Tarsier.Regedit;
using Tarsier.Security;
using Tarsier.UI;
using Tarsier.VSSource.Unbinder.Constants;

namespace Tarsier.VSSource.Unbinder.Forms {
    public partial class UploadToServer : Form {
        private string _version = string.Empty;
        private bool _success = false;
        private bool _tempToAppData = false;
        private bool _createDelay = true;
        private string[] _files;
        private string _statusMessage = string.Empty;
        private UploadCredentials _credential = new UploadCredentials();
        private List<string> _errors = new List<string>();
        private List<string> _uploadFiles = new List<string>();
        private Logs _logs;
        public List<string> Errors {
            get { return _errors; }
        }

        public bool IsSuccess {
            get { return _success; }
        }
        public UploadToServer(string[] files, string remoteFolder, string version) {
            InitializeComponent();
            InitSettings();
            InitializeFiles(files, remoteFolder);
        }

        private void InitSettings() {
            _logs = new Logs(Database.WORKSPACES);
            _tempToAppData = RegConfig.Get<bool>("AppDataTempFolder");
            Text = "Unbinding Files from";
        }

      
        private void InitializeFiles(string[] files,string folder) {
            _files = files;
            if(_files.Length > 0) {
                AddLog(string.Format("Zipping {0} files ", _files.Length), "Event", "Zipping Files", ParseMessageType.Compress);
                lblCount.Text = string.Format("0 of {0}", _files.Length);
                uploadProgress.Maximum = _files.Length;
                bgWorker.RunWorkerAsync();
            } else {
                Close();
            }
        }
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e) {
            if(_files.Length > 0) {
                int i = 1;
                using(ZipFile zip = new ZipFile()) {
                    foreach(string filename in _files) {
                        if(bgWorker != null && bgWorker.CancellationPending) {
                            e.Cancel = true;
                            break;
                        }
                        FileInfo info = new FileInfo(filename);
                        
                        bgWorker.ReportProgress(i, info);
                        Thread.Sleep(50);
                        i++;
                    }
                    bgWorker.ReportProgress(i, "Saving compressed files...");
                  
                }
            }


        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            if(e.ProgressPercentage <= uploadProgress.Maximum) {
                uploadProgress.Value = e.ProgressPercentage;
                lblCount.Text = string.Format("{0} of {1}", e.ProgressPercentage, uploadProgress.Maximum);
                if(e.UserState != null) {
                    FileInfo info = e.UserState as FileInfo;
                    if(info != null) {
                        lblStatus.Text = string.Format("Compressing {0} ...", info.Name);
                    } else {
                        lblStatus.Text = e.UserState.ToString();
                    }
                }
            } else {
                
                lblCount.Text = string.Empty;
            }

        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            
            if(e.Error != null) {
                _success = false;
                _errors.Add(e.Error.Message);
                AddLog(string.Format("Finished zipping {0} files with errors: {1} ", _files.Length, e.Error.Message), "Event", "Zipped Files", ParseMessageType.Error);
            } else {
                AddLog(string.Format("Finished zipping {0} files successfully ", _files.Length), "Event", "Zipped Files", ParseMessageType.Compress);
            }
         

        }
        private bool IsCloseLog = true; //avoid repeating action inside timer close
        private void tmrClose_Tick(object sender, EventArgs e) {
            if(IsCloseLog) {
                IsCloseLog = false;
                if(_errors.Count <= 0) {
                    AddLog("Finished uploading files successfully ", "Event", "Upload Success", ParseMessageType.Success);
                }
               
            }
            Close();
        }
        
       

     

        private void AddLog(string description, string category, string method, ParseMessageType type) {
            _statusMessage = description;
            _logs.Add(description, category, method, type);
        }
       
    }
}