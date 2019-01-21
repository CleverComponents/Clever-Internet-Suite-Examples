using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CleverComponents.InetSuite;

namespace SFTPClient {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			UpdateStatus();
		}

		private void DoOpenDir(string ADir) {
			string dir = ADir.TrimStart('/');
			if (!StringUtils.IsEmpty(dir)) {
				sFtp1.ChangeCurrentDir(dir);
			}
			FillDirList();
		}

		private void DoGoUp() {
			sFtp1.ChangeToParentDir();
			FillDirList();
		}

		private void FillDirList() {
			lbList.Items.Clear();
			lbList.Items.Add("..");
			sFtp1.GetList("");
		}

		private void UpdateStatus() {
			Text = sFtp1.Active ? "SFTP Clinet (FTP+SSH) - Connected" : "SFTP Clinet (FTP+SSH)";
		}

		private void btnLogin_Click(object sender, EventArgs e) {
			if (sFtp1.Active) {
				throw new Exception("You are already connected. Please click Logout to disconnect.");
			}

			sFtp1.Port = Convert.ToInt32(edtPort.Text);
			sFtp1.Server = edtServer.Text;
			sFtp1.UserName = edtUser.Text;
			sFtp1.Password = edtPassword.Text;
			sFtp1.Open();

			DoOpenDir("");
			UpdateStatus();
		}

		private void btnLogout_Click(object sender, EventArgs e) {
			sFtp1.Close();
			lbList.Items.Clear();
			UpdateStatus();
		}

		private void sFtp1_CommandSent(object sender, SFtpCommandEventArgs e) {
			memLog.Text += e.FxpCommand.ToString() + " is sent\r\n";
			memLog.Select(memLog.Text.Length, 0);
			memLog.ScrollToCaret();
		}

		private void sFtp1_ResponseReceived(object sender, SFtpCommandEventArgs e) {
			memLog.Text += e.FxpCommand.ToString() + " is received\r\n";
			memLog.Select(memLog.Text.Length, 0);
			memLog.ScrollToCaret();
		}

		private void sFtp1_DirectoryListing(object sender, SFtpDirectoryListingEventArgs e) {
			string item = (e.FileAttrs.IsDir ? "/" : "") + e.FileName;
			lbList.Items.Add(item);
		}

		private void lbList_DoubleClick(object sender, EventArgs e) {
			if (!sFtp1.Active) return;

			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "")) {
				if (lbList.Items[lbList.SelectedIndex].ToString()[0] == '/') {
					DoOpenDir(lbList.Items[lbList.SelectedIndex].ToString());
				}
				else if (lbList.Items[lbList.SelectedIndex].ToString() == "..") {
					DoGoUp();
				}
			}
		}

		private void btnMakeDir_Click(object sender, EventArgs e) {
			if (!sFtp1.Active) return;

			string s = NewDialog.ShowNewDialog("New Dir Name", "NewName");
			if (s != "") {
				sFtp1.MakeDir(s);
				FillDirList();
			}
		}

		private void btnRemoveDir_Click(object sender, EventArgs e) {
			if (!sFtp1.Active) return;

			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] == '/')) {

				if (MessageBox.Show("Do you wish to delete the "
					+ lbList.Items[lbList.SelectedIndex].ToString() + " directory ?", "Remove Directory",
					MessageBoxButtons.YesNo) == DialogResult.Yes) {
					sFtp1.RemoveDir(sFtp1.CurrentDir + lbList.Items[lbList.SelectedIndex].ToString());
					FillDirList();
				}
			}
		}

		private void btnDownload_Click(object sender, EventArgs e) {
			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] != '/') &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "..")) {

				saveFileDialog1.FileName = lbList.Items[lbList.SelectedIndex].ToString();
				if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
					int size = (int)sFtp1.GetFileSize(lbList.Items[lbList.SelectedIndex].ToString());
					int position = 0;

					if (File.Exists(saveFileDialog1.FileName)) {
						DialogResult fileExistsResult = FileExistsDialog.ShowFileDialog(saveFileDialog1.FileName);
						if (fileExistsResult == DialogResult.Cancel) return;

						FileInfo fileInf = new FileInfo(saveFileDialog1.FileName);
						if ((fileExistsResult == DialogResult.No) && (size > fileInf.Length)) {
							position = (int)fileInf.Length;
						}
					}

					progressBar1.Minimum = 0;
					progressBar1.Maximum = size;
					progressBar1.Value = position;

					using (FileStream dest = new FileStream(saveFileDialog1.FileName, FileMode.Create)) {
						sFtp1.GetFile(lbList.Items[lbList.SelectedIndex].ToString(), dest, position, size);
					}
					MessageBox.Show("Done");
				}
			}
		}

		private void sFtp1_Progress(object sender, ProgressEventArgs e) {
			if (e.TotalBytes > 0) {
				progressBar1.Maximum = (int)e.TotalBytes;
				progressBar1.Value = (int)e.BytesProceed;
			}
		}

		private void btnUpload_Click(object sender, EventArgs e) {
			if (!sFtp1.Active) return;

			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				int position = 0;
				string fileName = Path.GetFileName(openFileDialog1.FileName);

				FileInfo fileInf = new FileInfo(openFileDialog1.FileName);

				if (sFtp1.FileExists(fileName)) {
					DialogResult fileExistsResult = FileExistsDialog.ShowFileDialog(fileName);

					if (fileExistsResult == DialogResult.Cancel) return;

					if (fileExistsResult == DialogResult.No) {
						position = (int)sFtp1.GetFileSize(fileName);

						if ((int)fileInf.Length <= position) {
							position = 0;
						}
					}
				}

				progressBar1.Minimum = 0;
				progressBar1.Maximum = (int)fileInf.Length;
				progressBar1.Value = position;

				using (FileStream source = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read)) {
					sFtp1.PutFile(source, fileName, position, source.Length);
				}
				MessageBox.Show("Done");

				FillDirList();
			}
		}

		private void btnRename_Click(object sender, EventArgs e) {
			if (!sFtp1.Active) return;

			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] != '/')) {

				string s = NewDialog.ShowNewDialog("New File Name", lbList.Items[lbList.SelectedIndex].ToString());

				if ((s != "") && (s != lbList.Items[lbList.SelectedIndex].ToString())) {
					sFtp1.Rename(lbList.Items[lbList.SelectedIndex].ToString(), s);
					FillDirList();
				}
			}
		}

		private void btnDeleteFile_Click(object sender, EventArgs e) {
			if (!sFtp1.Active) return;

			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] != '/') &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "..")) {

				if (MessageBox.Show("Do you wish to delete the "
					+ lbList.Items[lbList.SelectedIndex].ToString() + " file ?", "Delete file",
					MessageBoxButtons.YesNo) == DialogResult.Yes) {
					sFtp1.Delete(lbList.Items[lbList.SelectedIndex].ToString());
					FillDirList();
				}
			}
		}

		private void sFtp1_ShowBanner(object sender, CleverComponents.InetSuite.Ssh.ShowBannerEventArgs e) {
			memLog.Text += "S: " + e.Message;
		}

		private void sFtp1_VerifyServer(object sender, CleverComponents.InetSuite.Ssh.VerifySshPeerEventArgs e) {
            if (!e.Verified && (MessageBox.Show("You are trying to connect to " + 
				e.Host + " host,\r\n Key Type: " + e.KeyType + "\r\n" + "Finger Print: " + e.FingerPrint
				+ "\r\n\r\n" + "Do you wish to proceed ?", "Verify server", MessageBoxButtons.YesNo) == DialogResult.Yes))	{
              e.Verified = true;			
			}
		}
	}
}
