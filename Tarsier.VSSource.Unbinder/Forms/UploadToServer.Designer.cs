namespace Tarsier.VSSource.Unbinder.Forms {
    partial class UploadToServer {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadToServer));
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.uploadProgress = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.tmrClose = new System.Windows.Forms.Timer(this.components);
            this.listBoxResponse = new System.Windows.Forms.ListBox();
            this.tmrChecker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // uploadProgress
            // 
            this.uploadProgress.Location = new System.Drawing.Point(21, 41);
            this.uploadProgress.Name = "uploadProgress";
            this.uploadProgress.Size = new System.Drawing.Size(435, 23);
            this.uploadProgress.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(21, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Initializing...";
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(368, 12);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(88, 23);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "0 of 0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrClose
            // 
            this.tmrClose.Interval = 1200;
            this.tmrClose.Tick += new System.EventHandler(this.tmrClose_Tick);
            // 
            // listBoxResponse
            // 
            this.listBoxResponse.FormattingEnabled = true;
            this.listBoxResponse.Location = new System.Drawing.Point(21, 120);
            this.listBoxResponse.Name = "listBoxResponse";
            this.listBoxResponse.Size = new System.Drawing.Size(435, 56);
            this.listBoxResponse.TabIndex = 3;
            // 
            // tmrChecker
            // 
            this.tmrChecker.Interval = 10;
            // 
            // UploadToServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 83);
            this.Controls.Add(this.listBoxResponse);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.uploadProgress);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadToServer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uploading to remote server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ProgressBar uploadProgress;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Timer tmrClose;
        private System.Windows.Forms.ListBox listBoxResponse;
        private System.Windows.Forms.Timer tmrChecker;
    }
}