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
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.sFtp1 = new CleverComponents.InetSuite.SFtp();
			this.SuspendLayout();
			// 
			// btnLogout
			// 
			this.btnLogout.Location = new System.Drawing.Point(544, 44);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(75, 23);
			this.btnLogout.TabIndex = 26;
			this.btnLogout.Text = "Logout";
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(544, 12);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 25;
			this.btnLogin.Text = "Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(456, 12);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(64, 20);
			this.edtPort.TabIndex = 24;
			this.edtPort.Text = "22";
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(288, 36);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.PasswordChar = '*';
			this.edtPassword.Size = new System.Drawing.Size(112, 20);
			this.edtPassword.TabIndex = 23;
			this.edtPassword.Text = "clevertester";
			// 
			// edtUser
			// 
			this.edtUser.Location = new System.Drawing.Point(72, 36);
			this.edtUser.Name = "edtUser";
			this.edtUser.Size = new System.Drawing.Size(112, 20);
			this.edtUser.TabIndex = 22;
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
			this.progressBar1.Location = new System.Drawing.Point(-4, 395);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(638, 16);
			this.progressBar1.TabIndex = 40;
			// 
			// btnRename
			// 
			this.btnRename.Location = new System.Drawing.Point(544, 251);
			this.btnRename.Name = "btnRename";
			this.btnRename.Size = new System.Drawing.Size(75, 23);
			this.btnRename.TabIndex = 39;
			this.btnRename.Text = "Rename...";
			this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
			// 
			// btnDeleteFile
			// 
			this.btnDeleteFile.Location = new System.Drawing.Point(544, 219);
			this.btnDeleteFile.Name = "btnDeleteFile";
			this.btnDeleteFile.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteFile.TabIndex = 38;
			this.btnDeleteFile.Text = "Delete File";
			this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(544, 190);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(75, 23);
			this.btnUpload.TabIndex = 37;
			this.btnUpload.Text = "Upload...";
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// btnDownload
			// 
			this.btnDownload.Location = new System.Drawing.Point(544, 158);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(75, 23);
			this.btnDownload.TabIndex = 36;
			this.btnDownload.Text = "Download...";
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// btnRemoveDir
			// 
			this.btnRemoveDir.Location = new System.Drawing.Point(544, 108);
			this.btnRemoveDir.Name = "btnRemoveDir";
			this.btnRemoveDir.Size = new System.Drawing.Size(75, 23);
			this.btnRemoveDir.TabIndex = 35;
			this.btnRemoveDir.Text = "Remove Dir";
			this.btnRemoveDir.Click += new System.EventHandler(this.btnRemoveDir_Click);
			// 
			// btnMakeDir
			// 
			this.btnMakeDir.Location = new System.Drawing.Point(544, 76);
			this.btnMakeDir.Name = "btnMakeDir";
			this.btnMakeDir.Size = new System.Drawing.Size(75, 23);
			this.btnMakeDir.TabIndex = 34;
			this.btnMakeDir.Text = "Make Dir...";
			this.btnMakeDir.Click += new System.EventHandler(this.btnMakeDir_Click);
			// 
			// memLog
			// 
			this.memLog.Location = new System.Drawing.Point(16, 299);
			this.memLog.Multiline = true;
			this.memLog.Name = "memLog";
			this.memLog.ReadOnly = true;
			this.memLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.memLog.Size = new System.Drawing.Size(504, 80);
			this.memLog.TabIndex = 31;
			// 
			// lbList
			// 
			this.lbList.Location = new System.Drawing.Point(16, 75);
			this.lbList.Name = "lbList";
			this.lbList.Size = new System.Drawing.Size(504, 199);
			this.lbList.Sorted = true;
			this.lbList.TabIndex = 30;
			this.lbList.DoubleClick += new System.EventHandler(this.lbList_DoubleClick);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 283);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 16);
			this.label7.TabIndex = 29;
			this.label7.Text = "Log";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 59);
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
			this.sFtp1.Password = null;
			this.sFtp1.UserName = null;
			this.sFtp1.CommandSent += new CleverComponents.InetSuite.SFtpCommandEventHandler(this.sFtp1_CommandSent);
			this.sFtp1.ResponseReceived += new CleverComponents.InetSuite.SFtpCommandEventHandler(this.sFtp1_ResponseReceived);
			this.sFtp1.Progress += new CleverComponents.InetSuite.ProgressEventHandler(this.sFtp1_Progress);
			this.sFtp1.VerifyServer += new CleverComponents.InetSuite.Ssh.VerifySshPeerEventHandler(this.sFtp1_VerifyServer);
			this.sFtp1.DirectoryListing += new CleverComponents.InetSuite.SFtpDirectoryListingEventHandler(this.sFtp1_DirectoryListing);
			this.sFtp1.ShowBanner += new CleverComponents.InetSuite.Ssh.ShowBannerEventHandler(this.sFtp1_ShowBanner);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 410);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btnRename);
			this.Controls.Add(this.btnDeleteFile);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.btnDownload);
			this.Controls.Add(this.btnRemoveDir);
			this.Controls.Add(this.btnMakeDir);
			this.Controls.Add(this.memLog);
			this.Controls.Add(this.lbList);
			this.Controls.Add(this.label7);
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
			this.Name = "Form1";
			this.Text = "Form1";
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
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private CleverComponents.InetSuite.SFtp sFtp1;
	}
}

