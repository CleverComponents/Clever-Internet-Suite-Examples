using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using CleverComponents.InetSuite;

namespace FtpClient
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
		private System.Windows.Forms.Label label7;
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
		private System.Windows.Forms.Button btnMakeDir;
		private System.Windows.Forms.Button btnDownload;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.Button btnDeleteFile;
		private System.Windows.Forms.Button btnRename;
		private System.Windows.Forms.Button btnAbort;
		private System.Windows.Forms.ListBox lbList;
		private System.Windows.Forms.TextBox memLog;
		private System.Windows.Forms.Button btnRemoveDir;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
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

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
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
			this.label7 = new System.Windows.Forms.Label();
			this.edtServer = new System.Windows.Forms.TextBox();
			this.edtUser = new System.Windows.Forms.TextBox();
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.edtStartDir = new System.Windows.Forms.TextBox();
			this.edtPort = new System.Windows.Forms.TextBox();
			this.cbPassiveMode = new System.Windows.Forms.CheckBox();
			this.cbAsciiMode = new System.Windows.Forms.CheckBox();
			this.lbList = new System.Windows.Forms.ListBox();
			this.memLog = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnOpenDir = new System.Windows.Forms.Button();
			this.btnGoUp = new System.Windows.Forms.Button();
			this.btnMakeDir = new System.Windows.Forms.Button();
			this.btnRemoveDir = new System.Windows.Forms.Button();
			this.btnDownload = new System.Windows.Forms.Button();
			this.btnUpload = new System.Windows.Forms.Button();
			this.btnDeleteFile = new System.Windows.Forms.Button();
			this.btnRename = new System.Windows.Forms.Button();
			this.btnAbort = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
			this.label6.Location = new System.Drawing.Point(16, 96);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Remote Host";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 320);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "Log";
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
			this.lbList.Location = new System.Drawing.Point(16, 112);
			this.lbList.Name = "lbList";
			this.lbList.Size = new System.Drawing.Size(504, 199);
			this.lbList.Sorted = true;
			this.lbList.TabIndex = 14;
			this.lbList.DoubleClick += new System.EventHandler(this.btnOpenDir_Click);
			// 
			// memLog
			// 
			this.memLog.Location = new System.Drawing.Point(16, 336);
			this.memLog.Multiline = true;
			this.memLog.Name = "memLog";
			this.memLog.ReadOnly = true;
			this.memLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.memLog.Size = new System.Drawing.Size(504, 80);
			this.memLog.TabIndex = 15;
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
			this.btnOpenDir.Location = new System.Drawing.Point(544, 96);
			this.btnOpenDir.Name = "btnOpenDir";
			this.btnOpenDir.Size = new System.Drawing.Size(75, 23);
			this.btnOpenDir.TabIndex = 18;
			this.btnOpenDir.Text = "Open Dir";
			this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
			// 
			// btnGoUp
			// 
			this.btnGoUp.Location = new System.Drawing.Point(544, 128);
			this.btnGoUp.Name = "btnGoUp";
			this.btnGoUp.Size = new System.Drawing.Size(75, 23);
			this.btnGoUp.TabIndex = 19;
			this.btnGoUp.Text = "Go Up";
			this.btnGoUp.Click += new System.EventHandler(this.btnGoUp_Click);
			// 
			// btnMakeDir
			// 
			this.btnMakeDir.Location = new System.Drawing.Point(544, 168);
			this.btnMakeDir.Name = "btnMakeDir";
			this.btnMakeDir.Size = new System.Drawing.Size(75, 23);
			this.btnMakeDir.TabIndex = 20;
			this.btnMakeDir.Text = "Make Dir...";
			this.btnMakeDir.Click += new System.EventHandler(this.btnMakeDir_Click);
			// 
			// btnRemoveDir
			// 
			this.btnRemoveDir.Location = new System.Drawing.Point(544, 200);
			this.btnRemoveDir.Name = "btnRemoveDir";
			this.btnRemoveDir.Size = new System.Drawing.Size(75, 23);
			this.btnRemoveDir.TabIndex = 21;
			this.btnRemoveDir.Text = "Remove Dir";
			this.btnRemoveDir.Click += new System.EventHandler(this.btnRemoveDir_Click);
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
			// btnDeleteFile
			// 
			this.btnDeleteFile.Location = new System.Drawing.Point(544, 312);
			this.btnDeleteFile.Name = "btnDeleteFile";
			this.btnDeleteFile.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteFile.TabIndex = 24;
			this.btnDeleteFile.Text = "Delete File";
			this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
			// 
			// btnRename
			// 
			this.btnRename.Location = new System.Drawing.Point(544, 344);
			this.btnRename.Name = "btnRename";
			this.btnRename.Size = new System.Drawing.Size(75, 23);
			this.btnRename.TabIndex = 25;
			this.btnRename.Text = "Rename...";
			this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
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
			// ftp1
			// 
			this.ftp1.DirectoryListing += new CleverComponents.InetSuite.DirectoryListingEventHandler(this.ftp1_DirectoryListing);
			this.ftp1.CommandSent += new CleverComponents.InetSuite.TcpTextEventHandler(this.ftp1_CommandSent);
			this.ftp1.ResponseReceived += new CleverComponents.InetSuite.TcpListEventHandler(this.ftp1_ResponseReceived);
			this.ftp1.Progress += new CleverComponents.InetSuite.ProgressEventHandler(this.ftp1_Progress);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(640, 438);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btnAbort);
			this.Controls.Add(this.btnRename);
			this.Controls.Add(this.btnDeleteFile);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.btnDownload);
			this.Controls.Add(this.btnRemoveDir);
			this.Controls.Add(this.btnMakeDir);
			this.Controls.Add(this.btnGoUp);
			this.Controls.Add(this.btnOpenDir);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.memLog);
			this.Controls.Add(this.lbList);
			this.Controls.Add(this.cbAsciiMode);
			this.Controls.Add(this.cbPassiveMode);
			this.Controls.Add(this.edtPort);
			this.Controls.Add(this.edtStartDir);
			this.Controls.Add(this.edtPassword);
			this.Controls.Add(this.edtUser);
			this.Controls.Add(this.edtServer);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FTP Client";
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

		private void btnLogin_Click(object sender, System.EventArgs e)
		{
			if (ftp1.Active)
			{
				MessageBox.Show("You are already connected. Please click Logout to disconnect.");
				return;
			}

			try
			{
				ftp1.Port = Convert.ToInt32(edtPort.Text);
				ftp1.Server = edtServer.Text;
				ftp1.UserName = edtUser.Text;
				ftp1.Password = edtPassword.Text;
				ftp1.PassiveMode = cbPassiveMode.Checked;
				ftp1.TransferType = cbAsciiMode.Checked ? FtpTransferType.Ascii : FtpTransferType.Binary;
				ftp1.Open();

				if (StringUtils.IsEmpty(edtStartDir.Text))
				{
					edtStartDir.Text = ftp1.CurrentDir;
				}
				if (!StringUtils.IsEmpty(edtStartDir.Text) && edtStartDir.Text.StartsWith(@"/"))
				{
					DoOpenDir(edtStartDir.Text);
				}
				UpdateStatus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DoOpenDir(string ADir)
		{
			string dir = ADir.StartsWith(@"//") ? ADir.Substring(1) : ADir;
			ftp1.ChangeCurrentDir(@"/");
			ftp1.ChangeCurrentDir(dir);
			FillDirList();
		}

		private void FillDirList()
		{
			lbList.Items.Clear();
			ftp1.GetDirectoryListing("");
			edtStartDir.Text = ftp1.CurrentDir;
		}

		private void UpdateStatus()
		{
			Text = ftp1.Active ? "Ftp Clinet - Connected" : "Ftp Clinet";
		}

		private void btnLogout_Click(object sender, System.EventArgs e)
		{
			ftp1.Close();
			lbList.Items.Clear();
			UpdateStatus();
		}

		private void btnOpenDir_Click(object sender, System.EventArgs e)
		{
			if (!ftp1.Active) return;

			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] == '/'))
			{
				DoOpenDir(ftp1.CurrentDir + lbList.Items[lbList.SelectedIndex].ToString());
			}
		}

		private void btnGoUp_Click(object sender, System.EventArgs e)
		{
			if (!ftp1.Active) return;

			ftp1.ChangeToParentDir();
			FillDirList();
		}

		private void btnMakeDir_Click(object sender, System.EventArgs e)
		{
			if (!ftp1.Active) return;

			string s = NewDialog.ShowNewDialog("New Dir Name", "NewName");
			if (s != "")
			{
				ftp1.MakeDir(s);
				FillDirList();
			}
		}

		private void btnRemoveDir_Click(object sender, System.EventArgs e)
		{
			if (!ftp1.Active) return;

			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] == '/'))
			{

				if (MessageBox.Show("Do you wish to delete the "
					+ lbList.Items[lbList.SelectedIndex].ToString() + " directory ?", "Remove Directory",
					MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					ftp1.RemoveDir(ftp1.CurrentDir + lbList.Items[lbList.SelectedIndex].ToString());
					FillDirList();
				}
			}
		}

		private void btnDownload_Click(object sender, System.EventArgs e)
		{
			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] != '/'))
			{

				saveFileDialog1.FileName = lbList.Items[lbList.SelectedIndex].ToString();
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					int size = (int)ftp1.GetFileSize(lbList.Items[lbList.SelectedIndex].ToString());
					int position = 0;

					if (File.Exists(saveFileDialog1.FileName))
					{
						DialogResult fileExistsResult = FileExistsDialog.ShowFileDialog(saveFileDialog1.FileName);
						if (fileExistsResult == DialogResult.Cancel) return;

						FileInfo fileInf = new FileInfo(saveFileDialog1.FileName);
						if ((fileExistsResult == DialogResult.No) && (size > fileInf.Length))
						{
							position = (int)fileInf.Length;
						}
					}

					progressBar1.Minimum = 0;
					progressBar1.Maximum = size;
					progressBar1.Value = position;

					using (FileStream dest = new FileStream(saveFileDialog1.FileName, FileMode.Create))
					{
						ftp1.GetFile(lbList.Items[lbList.SelectedIndex].ToString(), dest, position, -1);
					}
					MessageBox.Show("Done");
				}
			}
		}

		private void btnUpload_Click(object sender, System.EventArgs e)
		{
			if (!ftp1.Active) return;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				int position = 0;
				string fileName = Path.GetFileName(openFileDialog1.FileName);

				FileInfo fileInf = new FileInfo(openFileDialog1.FileName);

				if (ftp1.FileExists(fileName))
				{
					DialogResult fileExistsResult = FileExistsDialog.ShowFileDialog(fileName);

					if (fileExistsResult == DialogResult.Cancel) return;

					if (fileExistsResult == DialogResult.No)
					{
						position = (int)ftp1.GetFileSize(fileName);

						if ((int)fileInf.Length <= position)
						{
							position = 0;
						}
					}
				}

				progressBar1.Minimum = 0;
				progressBar1.Maximum = (int)fileInf.Length;
				progressBar1.Value = position;

				using (FileStream source = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
				{
					ftp1.PutFile(source, fileName, position, -1);
				}
				MessageBox.Show("Done");

				FillDirList();
			}
		}

		private void btnDeleteFile_Click(object sender, System.EventArgs e)
		{
			if (!ftp1.Active) return;

			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] != '/'))
			{

				if (MessageBox.Show("Do you wish to delete the "
					+ lbList.Items[lbList.SelectedIndex].ToString() + " file ?", "Delete file",
					MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					ftp1.Delete(lbList.Items[lbList.SelectedIndex].ToString());
					FillDirList();
				}
			}
		}

		private void btnRename_Click(object sender, System.EventArgs e)
		{
			if (!ftp1.Active) return;

			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] != '/'))
			{

				string s = NewDialog.ShowNewDialog("New File Name", lbList.Items[lbList.SelectedIndex].ToString());

				if ((s != "") && (s != lbList.Items[lbList.SelectedIndex].ToString()))
				{
					ftp1.Rename(lbList.Items[lbList.SelectedIndex].ToString(), s);
					FillDirList();
				}
			}
		}

		private void btnAbort_Click(object sender, System.EventArgs e)
		{
			if (ftp1.Active)
				ftp1.Abort();
		}

		private void ftp1_Progress(object sender, CleverComponents.InetSuite.ProgressEventArgs e)
		{
			if (e.TotalBytes > 0)
			{
				progressBar1.Maximum = (int)e.TotalBytes;
				progressBar1.Value = (int)e.BytesProceed;
			}
		}

		private void ftp1_DirectoryListing(object sender, CleverComponents.InetSuite.DirectoryListingEventArgs e)
		{
			string item = ((e.FileInfo.IsDirectory || e.FileInfo.IsLink) ? "/" : "") + e.FileInfo.FileName;
			lbList.Items.Add(item);
		}

		private void ftp1_CommandSent(object sender, CleverComponents.InetSuite.TcpTextEventArgs e)
		{
			memLog.Text += e.Text.Trim() + "\r\n";
			memLog.Select(memLog.Text.Length, 0);
			memLog.ScrollToCaret();
		}

		private void ftp1_ResponseReceived(object sender, CleverComponents.InetSuite.TcpListEventArgs e)
		{
			memLog.Text += e.List.ToString().Trim() + "\r\n";
			memLog.Select(memLog.Text.Length, 0);
			memLog.ScrollToCaret();
		}
	}
}
