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

namespace SFTPClient
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			UpdateStatus();
		}

		private void DoOpenDir(string ADir)
		{
			string dir = ADir.StartsWith(@"//") ? ADir.Substring(1) : ADir;
			sFtp1.ChangeCurrentDir(@"/");
			sFtp1.ChangeCurrentDir(dir);
			FillDirList();
		}

		private void FillDirList()
		{
			lbList.Items.Clear();
			sFtp1.GetList();
			lbList.Sorted = false;
			lbList.Sorted = true;
		}

		private void UpdateStatus()
		{
			bool enabled = sFtp1.Active;
			Text = enabled ? "SFTP Clinet (FTP+SSH) - Connected" : "SFTP Clinet (FTP+SSH)";
			btnOpenDir.Enabled = enabled;
			btnGoUp.Enabled = enabled;
			btnMakeDir.Enabled = enabled;
			btnRemoveDir.Enabled = enabled;
			btnDeleteFile.Enabled = enabled;
			btnRename.Enabled = enabled;
			btnDownload.Enabled = enabled;
			btnUpload.Enabled = enabled;
		}

		private int GetProgressBarPos(long position, long size)
		{
			if (position == 0 || size == 0) return 0;
			return (int)System.Math.Round((decimal)position / size * 100);
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (sFtp1.Active)
			{
				throw new Exception("You are already connected. Please click Logout to disconnect.");
			}

			sFtp1.Port = Convert.ToInt32(edtPort.Text);
			sFtp1.Server = edtServer.Text;
			sFtp1.UserName = edtUser.Text;
			sFtp1.Password = edtPassword.Text;
			sFtp1.Open();

			if (StringUtils.IsEmpty(edtStartDir.Text))
			{
				edtStartDir.Text = sFtp1.CurrentDir;
			}
			if (!StringUtils.IsEmpty(edtStartDir.Text) && edtStartDir.Text.StartsWith(@"/"))
			{
				DoOpenDir(edtStartDir.Text);
			}
			UpdateStatus();
			progressBar1.Value = 0;
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			sFtp1.Close();
			lbList.Items.Clear();
			UpdateStatus();
			progressBar1.Value = 0;
		}

		private void btnOpenDir_Click(object sender, EventArgs e)
		{
			if (!sFtp1.Active) return;

			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] == '/'))
			{
				DoOpenDir(sFtp1.CurrentDir + lbList.Items[lbList.SelectedIndex].ToString());
			}
		}

		private void btnGoUp_Click(object sender, EventArgs e)
		{
			sFtp1.ChangeToParentDir();
			FillDirList();
		}

		private void sFtp1_CommandSent(object sender, SFtpCommandEventArgs e)
		{
			if (e.FxpCommand == SFtpCommand.SSH_FXP_READ ||
				e.FxpCommand == SFtpCommand.SSH_FXP_WRITE ||
				e.FxpCommand == SFtpCommand.SSH_FXP_READDIR) return;

			memLog.Text += String.Format("C: {0} ({1} bytes)\r\n", SFtpCommand.GetCommandName(e.FxpCommand), e.Buffer.Length);
			memLog.Select(memLog.Text.Length, 0);
			memLog.ScrollToCaret();
		}

		private void sFtp1_ResponseReceived(object sender, SFtpCommandEventArgs e)
		{
			if (e.FxpCommand == SFtpCommand.SSH_FXP_READ ||
				e.FxpCommand == SFtpCommand.SSH_FXP_WRITE ||
				e.FxpCommand == SFtpCommand.SSH_FXP_READDIR) return;

			memLog.Text += String.Format("S: {0} ({1} bytes)\r\n", SFtpCommand.GetCommandName(e.FxpCommand), e.Buffer.Length);
			memLog.Select(memLog.Text.Length, 0);
			memLog.ScrollToCaret();
		}

		private void sFtp1_DirectoryListing(object sender, SFtpDirectoryListingEventArgs e)
		{
			string item = (e.FileAttrs.IsDir ? "/" : "") + e.FileName;
			lbList.Items.Add(item);
		}

		private void btnMakeDir_Click(object sender, EventArgs e)
		{
			if (!sFtp1.Active) return;

			string s = NewDialog.ShowNewDialog("New Dir Name", "NewName");
			if (s != "")
			{
				sFtp1.MakeDir(s);
				FillDirList();
			}
		}

		private void btnRemoveDir_Click(object sender, EventArgs e)
		{
			if (!sFtp1.Active) return;

			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] == '/'))
			{

				if (MessageBox.Show("Do you wish to delete the "
					+ lbList.Items[lbList.SelectedIndex].ToString() + " directory ?", "Remove Directory",
					MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					sFtp1.RemoveDir(sFtp1.CurrentDir + lbList.Items[lbList.SelectedIndex].ToString());
					FillDirList();
				}
			}
		}

		private void btnDownload_Click(object sender, EventArgs e)
		{
			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] != '/'))
			{

				saveFileDialog1.FileName = lbList.Items[lbList.SelectedIndex].ToString();
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					long size = sFtp1.GetFileSize(lbList.Items[lbList.SelectedIndex].ToString());
					long position = 0;
					if (File.Exists(saveFileDialog1.FileName))
					{
						DialogResult fileExistsResult = FileExistsDialog.ShowFileDialog(saveFileDialog1.FileName);
						if (fileExistsResult == DialogResult.Cancel) return;

						FileInfo fileInf = new FileInfo(saveFileDialog1.FileName);
						if ((fileExistsResult == DialogResult.No) && (size > fileInf.Length))
						{
							position = fileInf.Length;
						}
					}

					progressBar1.Value = GetProgressBarPos(position, size);

					using (FileStream dest = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate))
					{
						sFtp1.GetFile(lbList.Items[lbList.SelectedIndex].ToString(), dest, position, size);
					}
					MessageBox.Show("Done");
				}
			}
		}

		private void sFtp1_Progress(object sender, ProgressEventArgs e)
		{
			progressBar1.Value = GetProgressBarPos(e.BytesProceed, e.TotalBytes);
			Application.DoEvents();
		}

		private void btnUpload_Click(object sender, EventArgs e)
		{
			if (!sFtp1.Active) return;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				long position = 0;
				string fileName = Path.GetFileName(openFileDialog1.FileName);

				FileInfo fileInf = new FileInfo(openFileDialog1.FileName);

				if (sFtp1.FileExists(fileName))
				{
					DialogResult fileExistsResult = FileExistsDialog.ShowFileDialog(fileName);

					if (fileExistsResult == DialogResult.Cancel) return;

					if (fileExistsResult == DialogResult.No)
					{
						position = sFtp1.GetFileSize(fileName);

						if (fileInf.Length <= position)
						{
							position = 0;
						}
					}
				}

				progressBar1.Value = GetProgressBarPos(position, fileInf.Length);

				using (FileStream source = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
				{
					sFtp1.PutFile(source, fileName, position, source.Length);
				}
				FillDirList();

				MessageBox.Show("Done");
			}
		}

		private void btnRename_Click(object sender, EventArgs e)
		{
			if (!sFtp1.Active) return;

			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] != '/'))
			{

				string s = NewDialog.ShowNewDialog("New File Name", lbList.Items[lbList.SelectedIndex].ToString());

				if ((s != "") && (s != lbList.Items[lbList.SelectedIndex].ToString()))
				{
					sFtp1.Rename(lbList.Items[lbList.SelectedIndex].ToString(), s);
					FillDirList();
				}
			}
		}

		private void btnDeleteFile_Click(object sender, EventArgs e)
		{
			if (!sFtp1.Active) return;

			if ((lbList.SelectedIndex > -1) &&
				(lbList.Items[lbList.SelectedIndex].ToString() != "") &&
				(lbList.Items[lbList.SelectedIndex].ToString()[0] != '/'))
			{

				if (MessageBox.Show("Do you wish to delete the "
					+ lbList.Items[lbList.SelectedIndex].ToString() + " file ?", "Delete file",
					MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					sFtp1.Delete(lbList.Items[lbList.SelectedIndex].ToString());
					FillDirList();
				}
			}
		}

		private void sFtp1_ShowBanner(object sender, CleverComponents.InetSuite.Ssh.ShowBannerEventArgs e)
		{
			memLog.Text += "Server Banner: " + e.Message + "\r\n";
		}

		private void sFtp1_VerifyServer(object sender, CleverComponents.InetSuite.Ssh.VerifySshServerEventArgs e)
		{
			e.Verified = (MessageBox.Show("You are trying to connect to " +
				e.Host + " host,\r\n Key Type: " + e.KeyType + "\r\n" + "Finger Print: " + e.FingerPrint
				+ "\r\n\r\n" + "Do you wish to proceed ?", "Verify server", MessageBoxButtons.YesNo) == DialogResult.Yes);
		}
	}
}
