using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using CleverComponents.InetSuite;

namespace FtpClientProxy
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.TextBox edtServer;
		private System.Windows.Forms.TextBox edtUser;
		private System.Windows.Forms.TextBox edtPassword;
		private System.Windows.Forms.TextBox edtStartDir;
		private System.Windows.Forms.TextBox edtPort;
		private System.Windows.Forms.CheckBox cbPassiveMode;
		private System.Windows.Forms.CheckBox cbAsciiMode;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnOpenDir;
		private System.Windows.Forms.Button btnGoUp;
		private System.Windows.Forms.Button btnDownload;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.Button btnAbort;
		private System.Windows.Forms.ListBox lbList;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox edtProxyServer;
		private System.Windows.Forms.TextBox edtProxyPort;
		private System.Windows.Forms.TextBox edtProxyUser;
		private System.Windows.Forms.TextBox edtProxyPassword;
		private System.Windows.Forms.ComboBox cbProxyType;
		private CleverComponents.InetSuite.Ftp ftp1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			cbProxyType.SelectedIndex = 4;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.edtServer = new System.Windows.Forms.TextBox();
			this.edtUser = new System.Windows.Forms.TextBox();
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.edtStartDir = new System.Windows.Forms.TextBox();
			this.edtPort = new System.Windows.Forms.TextBox();
			this.cbPassiveMode = new System.Windows.Forms.CheckBox();
			this.cbAsciiMode = new System.Windows.Forms.CheckBox();
			this.lbList = new System.Windows.Forms.ListBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnOpenDir = new System.Windows.Forms.Button();
			this.btnGoUp = new System.Windows.Forms.Button();
			this.btnDownload = new System.Windows.Forms.Button();
			this.btnUpload = new System.Windows.Forms.Button();
			this.btnAbort = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.edtProxyServer = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.edtProxyPort = new System.Windows.Forms.TextBox();
			this.edtProxyUser = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.edtProxyPassword = new System.Windows.Forms.TextBox();
			this.cbProxyType = new System.Windows.Forms.ComboBox();
			this.ftp1 = new CleverComponents.InetSuite.Ftp();
			((System.ComponentModel.ISupportInitialize)(this.ftp1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP/Host";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "User";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Start Dir";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(224, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(416, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Port";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 184);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Remote Host";
			// 
			// edtServer
			// 
			this.edtServer.Location = new System.Drawing.Point(72, 16);
			this.edtServer.Name = "edtServer";
			this.edtServer.Size = new System.Drawing.Size(328, 20);
			this.edtServer.TabIndex = 7;
			this.edtServer.Text = "localhost";
			// 
			// edtUser
			// 
			this.edtUser.Location = new System.Drawing.Point(72, 40);
			this.edtUser.Name = "edtUser";
			this.edtUser.Size = new System.Drawing.Size(112, 20);
			this.edtUser.TabIndex = 8;
			this.edtUser.Text = "clevertester";
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(288, 40);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.PasswordChar = '*';
			this.edtPassword.Size = new System.Drawing.Size(112, 20);
			this.edtPassword.TabIndex = 9;
			this.edtPassword.Text = "clevertester";
			// 
			// edtStartDir
			// 
			this.edtStartDir.Location = new System.Drawing.Point(72, 64);
			this.edtStartDir.Name = "edtStartDir";
			this.edtStartDir.Size = new System.Drawing.Size(328, 20);
			this.edtStartDir.TabIndex = 10;
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(456, 16);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(64, 20);
			this.edtPort.TabIndex = 11;
			this.edtPort.Text = "21";
			// 
			// cbPassiveMode
			// 
			this.cbPassiveMode.Location = new System.Drawing.Point(416, 40);
			this.cbPassiveMode.Name = "cbPassiveMode";
			this.cbPassiveMode.Size = new System.Drawing.Size(104, 24);
			this.cbPassiveMode.TabIndex = 12;
			this.cbPassiveMode.Text = "Passive Mode";
			// 
			// cbAsciiMode
			// 
			this.cbAsciiMode.Location = new System.Drawing.Point(416, 64);
			this.cbAsciiMode.Name = "cbAsciiMode";
			this.cbAsciiMode.Size = new System.Drawing.Size(104, 24);
			this.cbAsciiMode.TabIndex = 13;
			this.cbAsciiMode.Text = "Ascii Mode";
			// 
			// lbList
			// 
			this.lbList.Location = new System.Drawing.Point(16, 200);
			this.lbList.Name = "lbList";
			this.lbList.Size = new System.Drawing.Size(504, 212);
			this.lbList.Sorted = true;
			this.lbList.TabIndex = 14;
			this.lbList.DoubleClick += new System.EventHandler(this.btnOpenDir_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(544, 16);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 16;
			this.btnLogin.Text = "Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.Location = new System.Drawing.Point(544, 48);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(75, 23);
			this.btnLogout.TabIndex = 17;
			this.btnLogout.Text = "Logout";
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnOpenDir
			// 
			this.btnOpenDir.Location = new System.Drawing.Point(544, 144);
			this.btnOpenDir.Name = "btnOpenDir";
			this.btnOpenDir.Size = new System.Drawing.Size(75, 23);
			this.btnOpenDir.TabIndex = 18;
			this.btnOpenDir.Text = "Open Dir";
			this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
			// 
			// btnGoUp
			// 
			this.btnGoUp.Location = new System.Drawing.Point(544, 176);
			this.btnGoUp.Name = "btnGoUp";
			this.btnGoUp.Size = new System.Drawing.Size(75, 23);
			this.btnGoUp.TabIndex = 19;
			this.btnGoUp.Text = "Go Up";
			this.btnGoUp.Click += new System.EventHandler(this.btnGoUp_Click);
			// 
			// btnDownload
			// 
			this.btnDownload.Location = new System.Drawing.Point(544, 232);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(75, 23);
			this.btnDownload.TabIndex = 22;
			this.btnDownload.Text = "Download...";
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(544, 264);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(75, 23);
			this.btnUpload.TabIndex = 23;
			this.btnUpload.Text = "Upload...";
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// btnAbort
			// 
			this.btnAbort.Location = new System.Drawing.Point(544, 384);
			this.btnAbort.Name = "btnAbort";
			this.btnAbort.Size = new System.Drawing.Size(75, 23);
			this.btnAbort.TabIndex = 26;
			this.btnAbort.Text = "Abort";
			this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(0, 420);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(640, 16);
			this.progressBar1.TabIndex = 27;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.OverwritePrompt = false;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(16, 96);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(512, 1);
			this.panel1.TabIndex = 29;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 16);
			this.label7.TabIndex = 30;
			this.label7.Text = "Proxy Server";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 128);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 16);
			this.label8.TabIndex = 31;
			this.label8.Text = "Proxy User";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(16, 152);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 16);
			this.label9.TabIndex = 32;
			this.label9.Text = "Proxy Type";
			// 
			// edtProxyServer
			// 
			this.edtProxyServer.Location = new System.Drawing.Point(96, 104);
			this.edtProxyServer.Name = "edtProxyServer";
			this.edtProxyServer.Size = new System.Drawing.Size(240, 20);
			this.edtProxyServer.TabIndex = 33;
			this.edtProxyServer.Text = "localhost";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(360, 104);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 16);
			this.label10.TabIndex = 34;
			this.label10.Text = "Proxy Port";
			// 
			// edtProxyPort
			// 
			this.edtProxyPort.Location = new System.Drawing.Point(432, 104);
			this.edtProxyPort.Name = "edtProxyPort";
			this.edtProxyPort.Size = new System.Drawing.Size(88, 20);
			this.edtProxyPort.TabIndex = 35;
			this.edtProxyPort.Text = "21";
			// 
			// edtProxyUser
			// 
			this.edtProxyUser.Location = new System.Drawing.Point(96, 128);
			this.edtProxyUser.Name = "edtProxyUser";
			this.edtProxyUser.Size = new System.Drawing.Size(184, 20);
			this.edtProxyUser.TabIndex = 36;
			this.edtProxyUser.Text = "clevertester";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(304, 128);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 16);
			this.label11.TabIndex = 37;
			this.label11.Text = "Proxy Password";
			// 
			// edtProxyPassword
			// 
			this.edtProxyPassword.Location = new System.Drawing.Point(392, 128);
			this.edtProxyPassword.Name = "edtProxyPassword";
			this.edtProxyPassword.PasswordChar = '*';
			this.edtProxyPassword.Size = new System.Drawing.Size(128, 20);
			this.edtProxyPassword.TabIndex = 38;
			this.edtProxyPassword.Text = "123";
			// 
			// cbProxyType
			// 
			this.cbProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbProxyType.Items.AddRange(new object[] {
            "None",
            "UserSite",
            "Site",
            "Open",
            "UserPass",
            "Transparent"});
			this.cbProxyType.Location = new System.Drawing.Point(96, 152);
			this.cbProxyType.Name = "cbProxyType";
			this.cbProxyType.Size = new System.Drawing.Size(240, 21);
			this.cbProxyType.TabIndex = 39;
			// 
			// ftp1
			// 
			this.ftp1.Port = 21;
			this.ftp1.Progress += new CleverComponents.InetSuite.ProgressEventHandler(this.ftp1_Progress);
			this.ftp1.DirectoryListing += new CleverComponents.InetSuite.DirectoryListingEventHandler(this.ftp1_DirectoryListing);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(640, 438);
			this.Controls.Add(this.cbProxyType);
			this.Controls.Add(this.edtProxyPassword);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.edtProxyUser);
			this.Controls.Add(this.edtProxyPort);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.edtProxyServer);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btnAbort);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.btnDownload);
			this.Controls.Add(this.btnGoUp);
			this.Controls.Add(this.btnOpenDir);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.lbList);
			this.Controls.Add(this.cbAsciiMode);
			this.Controls.Add(this.cbPassiveMode);
			this.Controls.Add(this.edtPort);
			this.Controls.Add(this.edtStartDir);
			this.Controls.Add(this.edtPassword);
			this.Controls.Add(this.edtUser);
			this.Controls.Add(this.edtServer);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.ftp1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btnLogin_Click(object sender, System.EventArgs e) {
			if (ftp1.Active) {
				MessageBox.Show("You are already connected. Please click Logout to disconnect.");
				return;
			}

			try {
				ftp1.Port = Convert.ToInt32(edtPort.Text);
				ftp1.Server = edtServer.Text;
				ftp1.UserName = edtUser.Text;
				ftp1.Password = edtPassword.Text;
				ftp1.PassiveMode = cbPassiveMode.Checked;
				ftp1.TransferType = cbAsciiMode.Checked ? FtpTransferType.Ascii : FtpTransferType.Binary;

				ftp1.ProxySettings.Server = edtProxyServer.Text;
				ftp1.ProxySettings.Port = Convert.ToInt32(edtProxyPort.Text);
				ftp1.ProxySettings.UserName = edtProxyUser.Text;
				ftp1.ProxySettings.Password = edtProxyPassword.Text;
				ftp1.ProxySettings.ProxyType = (FtpProxyType)cbProxyType.SelectedIndex;

				ftp1.Open();

				DoOpenDir(edtStartDir.Text);
				UpdateStatus();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void DoOpenDir(string ADir) {
			string dir = ADir.TrimStart('/');
			if (!StringUtils.IsEmpty(dir)) {
				ftp1.ChangeCurrentDir(dir);
			}

			FillDirList();
		}

		private void FillDirList() {
			lbList.Items.Clear();
			ftp1.GetDirectoryListing();
			edtStartDir.Text = ftp1.CurrentDir;
		}

		private void UpdateStatus() {
			Text = ftp1.Active ? "Ftp Clinet - Connected" : "Ftp Clinet";
		}

		private void btnLogout_Click(object sender, System.EventArgs e) {
			ftp1.Close();
			lbList.Items.Clear();
			UpdateStatus();
		}

		private void btnOpenDir_Click(object sender, System.EventArgs e) {
			if (!ftp1.Active) return;

			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] == '/')) {
				DoOpenDir(lbList.Items[lbList.SelectedIndex].ToString());
			}
		}

		private void btnGoUp_Click(object sender, System.EventArgs e) {
			if (!ftp1.Active) return;

			ftp1.ChangeToParentDir();
			FillDirList();
		}

		private void btnDownload_Click(object sender, System.EventArgs e) {
			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] != '/')) {

				saveFileDialog1.FileName = lbList.Items[lbList.SelectedIndex].ToString();
				if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
					progressBar1.Minimum = 0;
					progressBar1.Maximum = (int)ftp1.GetFileSize(lbList.Items[lbList.SelectedIndex].ToString());
					progressBar1.Value = 0;
        
					using(FileStream dest = new FileStream(saveFileDialog1.FileName, FileMode.Create)) {
						ftp1.GetFile(lbList.Items[lbList.SelectedIndex].ToString(), dest);
					}
					MessageBox.Show("Done");
				}
			}
		}

		private void btnUpload_Click(object sender, System.EventArgs e) {
			if (!ftp1.Active) return;

			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				progressBar1.Minimum = 0;
				FileInfo fileInf = new FileInfo(openFileDialog1.FileName);
				progressBar1.Maximum = (int)fileInf.Length;
				progressBar1.Value = 0;

				using(FileStream source = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read)) {
					ftp1.PutFile(source, Path.GetFileName(openFileDialog1.FileName));
				}
				MessageBox.Show("Done");

				FillDirList();
			}
		}

		private void btnAbort_Click(object sender, System.EventArgs e) {
			if (ftp1.Active)
				ftp1.Abort();
		}

		private void ftp1_Progress(object sender, CleverComponents.InetSuite.ProgressEventArgs e) {
			if (e.TotalBytes > 0) {
				progressBar1.Maximum = (int)e.TotalBytes;
				progressBar1.Value = (int)e.BytesProceed;
			}
		}

		private void ftp1_DirectoryListing(object sender, CleverComponents.InetSuite.DirectoryListingEventArgs e) {
			string item = ((e.FileInfo.IsDirectory || e.FileInfo.IsLink) ? "/" : "") + e.FileInfo.FileName;
			lbList.Items.Add(item);
		}

	}
}
