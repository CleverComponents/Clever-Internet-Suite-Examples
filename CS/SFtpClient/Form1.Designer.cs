namespace SFTPClient {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
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
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.edtPort = new System.Windows.Forms.TextBox();
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.edtUser = new System.Windows.Forms.TextBox();
			this.edtServer = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnRename = new System.Windows.Forms.Button();
			this.btnDeleteFile = new System.Windows.Forms.Button();
			this.btnUpload = new System.Windows.Forms.Button();
			this.btnDownload = new System.Windows.Forms.Button();
			this.btnRemoveDir = new System.Windows.Forms.Button();
			this.btnMakeDir = new System.Windows.Forms.Button();
			this.memLog = new System.Windows.Forms.TextBox();
			this.lbList = new System.Windows.Forms.ListBox();
			this.label6 = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.sFtp1 = new CleverComponents.InetSuite.SFtp();
			this.label3 = new System.Windows.Forms.Label();
			this.edtStartDir = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnOpenDir = new System.Windows.Forms.Button();
			this.btnGoUp = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.sFtp1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLogout
			// 
			this.btnLogout.Location = new System.Drawing.Point(544, 41);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(75, 23);
			this.btnLogout.TabIndex = 27;
			this.btnLogout.Text = "Logout";
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(544, 12);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 26;
			this.btnLogin.Text = "Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(456, 12);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(64, 20);
			this.edtPort.TabIndex = 22;
			this.edtPort.Text = "22";
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(288, 36);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.PasswordChar = '*';
			this.edtPassword.Size = new System.Drawing.Size(112, 20);
			this.edtPassword.TabIndex = 24;
			this.edtPassword.Text = "clevertester";
			// 
			// edtUser
			// 
			this.edtUser.Location = new System.Drawing.Point(72, 36);
			this.edtUser.Name = "edtUser";
			this.edtUser.Size = new System.Drawing.Size(112, 20);
			this.edtUser.TabIndex = 23;
			this.edtUser.Text = "CleverTester";
			// 
			// edtServer
			// 
			this.edtServer.Location = new System.Drawing.Point(72, 12);
			this.edtServer.Name = "edtServer";
			this.edtServer.Size = new System.Drawing.Size(328, 20);
			this.edtServer.TabIndex = 21;
			this.edtServer.Text = "localhost";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(224, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 16);
			this.label4.TabIndex = 20;
			this.label4.Text = "Password";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 19;
			this.label2.Text = "User";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 18;
			this.label1.Text = "IP/Host";
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(-4, 368);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(638, 16);
			this.progressBar1.TabIndex = 40;
			// 
			// btnRename
			// 
			this.btnRename.Location = new System.Drawing.Point(544, 332);
			this.btnRename.Name = "btnRename";
			this.btnRename.Size = new System.Drawing.Size(75, 23);
			this.btnRename.TabIndex = 35;
			this.btnRename.Text = "Rename...";
			this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
			// 
			// btnDeleteFile
			// 
			this.btnDeleteFile.Location = new System.Drawing.Point(544, 303);
			this.btnDeleteFile.Name = "btnDeleteFile";
			this.btnDeleteFile.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteFile.TabIndex = 34;
			this.btnDeleteFile.Text = "Delete File";
			this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(544, 259);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(75, 23);
			this.btnUpload.TabIndex = 33;
			this.btnUpload.Text = "Upload...";
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// btnDownload
			// 
			this.btnDownload.Location = new System.Drawing.Point(544, 230);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(75, 23);
			this.btnDownload.TabIndex = 32;
			this.btnDownload.Text = "Download...";
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// btnRemoveDir
			// 
			this.btnRemoveDir.Location = new System.Drawing.Point(544, 183);
			this.btnRemoveDir.Name = "btnRemoveDir";
			this.btnRemoveDir.Size = new System.Drawing.Size(75, 23);
			this.btnRemoveDir.TabIndex = 31;
			this.btnRemoveDir.Text = "Remove Dir";
			this.btnRemoveDir.Click += new System.EventHandler(this.btnRemoveDir_Click);
			// 
			// btnMakeDir
			// 
			this.btnMakeDir.Location = new System.Drawing.Point(544, 154);
			this.btnMakeDir.Name = "btnMakeDir";
			this.btnMakeDir.Size = new System.Drawing.Size(75, 23);
			this.btnMakeDir.TabIndex = 30;
			this.btnMakeDir.Text = "Make Dir...";
			this.btnMakeDir.Click += new System.EventHandler(this.btnMakeDir_Click);
			// 
			// memLog
			// 
			this.memLog.Location = new System.Drawing.Point(16, 275);
			this.memLog.Multiline = true;
			this.memLog.Name = "memLog";
			this.memLog.ReadOnly = true;
			this.memLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.memLog.Size = new System.Drawing.Size(504, 80);
			this.memLog.TabIndex = 37;
			// 
			// lbList
			// 
			this.lbList.Location = new System.Drawing.Point(16, 105);
			this.lbList.Name = "lbList";
			this.lbList.Size = new System.Drawing.Size(504, 147);
			this.lbList.Sorted = true;
			this.lbList.TabIndex = 36;
			this.lbList.DoubleClick += new System.EventHandler(this.btnOpenDir_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 89);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 28;
			this.label6.Text = "Remote Host";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.OverwritePrompt = false;
			// 
			// sFtp1
			// 
			this.sFtp1.ConnectTimeOut = 0;
			this.sFtp1.Password = null;
			this.sFtp1.UserName = null;
			this.sFtp1.CommandSent += new CleverComponents.InetSuite.SFtpCommandEventHandler(this.sFtp1_CommandSent);
			this.sFtp1.ResponseReceived += new CleverComponents.InetSuite.SFtpCommandEventHandler(this.sFtp1_ResponseReceived);
			this.sFtp1.Progress += new CleverComponents.InetSuite.ProgressEventHandler(this.sFtp1_Progress);
			this.sFtp1.DirectoryListing += new CleverComponents.InetSuite.SFtpDirectoryListingEventHandler(this.sFtp1_DirectoryListing);
			this.sFtp1.VerifyServer += new CleverComponents.InetSuite.Ssh.VerifySshServerEventHandler(this.sFtp1_VerifyServer);
			this.sFtp1.ShowBanner += new CleverComponents.InetSuite.Ssh.ShowBannerEventHandler(this.sFtp1_ShowBanner);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 41;
			this.label3.Text = "Start Dir";
			// 
			// edtStartDir
			// 
			this.edtStartDir.Location = new System.Drawing.Point(72, 62);
			this.edtStartDir.Name = "edtStartDir";
			this.edtStartDir.Size = new System.Drawing.Size(328, 20);
			this.edtStartDir.TabIndex = 25;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(415, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 43;
			this.label5.Text = "Port";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(16, 259);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(25, 13);
			this.label8.TabIndex = 44;
			this.label8.Text = "Log";
			// 
			// btnOpenDir
			// 
			this.btnOpenDir.Location = new System.Drawing.Point(544, 85);
			this.btnOpenDir.Name = "btnOpenDir";
			this.btnOpenDir.Size = new System.Drawing.Size(75, 23);
			this.btnOpenDir.TabIndex = 28;
			this.btnOpenDir.Text = "Open Dir";
			this.btnOpenDir.UseVisualStyleBackColor = true;
			this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
			// 
			// btnGoUp
			// 
			this.btnGoUp.Location = new System.Drawing.Point(544, 114);
			this.btnGoUp.Name = "btnGoUp";
			this.btnGoUp.Size = new System.Drawing.Size(75, 23);
			this.btnGoUp.TabIndex = 29;
			this.btnGoUp.Text = "Go Up";
			this.btnGoUp.UseVisualStyleBackColor = true;
			this.btnGoUp.Click += new System.EventHandler(this.btnGoUp_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 383);
			this.Controls.Add(this.btnGoUp);
			this.Controls.Add(this.btnOpenDir);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.edtStartDir);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btnRename);
			this.Controls.Add(this.btnDeleteFile);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.btnDownload);
			this.Controls.Add(this.btnRemoveDir);
			this.Controls.Add(this.btnMakeDir);
			this.Controls.Add(this.memLog);
			this.Controls.Add(this.lbList);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.edtPort);
			this.Controls.Add(this.edtPassword);
			this.Controls.Add(this.edtUser);
			this.Controls.Add(this.edtServer);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SFTP Client";
			((System.ComponentModel.ISupportInitialize)(this.sFtp1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox edtPort;
		private System.Windows.Forms.TextBox edtPassword;
		private System.Windows.Forms.TextBox edtUser;
		private System.Windows.Forms.TextBox edtServer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button btnRename;
		private System.Windows.Forms.Button btnDeleteFile;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.Button btnDownload;
		private System.Windows.Forms.Button btnRemoveDir;
		private System.Windows.Forms.Button btnMakeDir;
		private System.Windows.Forms.TextBox memLog;
		private System.Windows.Forms.ListBox lbList;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private CleverComponents.InetSuite.SFtp sFtp1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox edtStartDir;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnOpenDir;
		private System.Windows.Forms.Button btnGoUp;
	}
}

