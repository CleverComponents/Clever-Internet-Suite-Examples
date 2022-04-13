using System;
using System.Windows.Forms;
using System.IO;
using CleverComponents.InetSuite;

namespace SFtpServer
{
	public partial class MainForm : Form
	{
		bool isStop;

		public MainForm()
		{
			InitializeComponent();

			tabControl1.SelectedTab = tabServer;
			lblStatus.Visible = false;

			LoadHostKey();
			LoadDefaultSettings();
		}

		delegate void PutLogMessageDelegate(string logMessage);

		void PutLogMessage(string logMessage)
		{
			if (this.IsDisposed) return;

			if (this.InvokeRequired)
			{
				this.Invoke(new PutLogMessageDelegate(PutLogMessage), new object[] { logMessage });
			}
			else
			{
				edtLog.Text += logMessage + "\r\n";
				edtLog.Select(edtLog.Text.Length, 0);
				edtLog.ScrollToCaret();
			}
		}

		private void LoadHostKey()
		{
			if (sFtpServer1.Active) return;

			sFtpServer1.HostKey.Clear();

			sFtpServer1.HostKey.PrivateKeyFile = edtHostKeyFile.Text;
			sFtpServer1.HostKey.PassPhrase = edtHostKeyPassPhrase.Text;

			if (!StringUtils.IsEmpty(edtHostKeyFile.Text) && File.Exists(edtHostKeyFile.Text))
			{
				sFtpServer1.HostKey.Load();
				edtFingerPrint.Text = sFtpServer1.HostKey.FingerPrint;
			}
			else
			{
				edtFingerPrint.Text = "";
			}
		}

		private void LoadDefaultSettings()
		{
			//Host Key
			edtKeyLength.Text = sFtpServer1.HostKey.KeyLength.ToString();

			//SSH Algorithms Tab
			edtKexAlgs.Text = sFtpServer1.Config.GetConfig("kex");
			edtSignatureAlgs.Text = sFtpServer1.Config.GetConfig("hostkey");
			edtEncryptionAlgs.Text = sFtpServer1.Config.GetConfig("cipher.s2c");
			edtDataIntegrityAlgs.Text = sFtpServer1.Config.GetConfig("mac.s2c");

			//Additional Settings Tab
			edtCharSet.Text = sFtpServer1.CharSet;
			edtMaxReturnFiles.Text = sFtpServer1.MaxReturnFiles.ToString();
			edtBatchSize.Text = sFtpServer1.BatchSize.ToString();
			edtMaxWindowSize.Text = sFtpServer1.MaxWindowSize.ToString();
		}

		private void GenerateHostKey()
		{
			if (sFtpServer1.Active) return;

			if (!StringUtils.IsEmpty(edtHostKeyFile.Text) && File.Exists(edtHostKeyFile.Text))
			{
				if (MessageBox.Show("The key file \"" + edtHostKeyFile.Text + "\" already exists. Do you want to replace?",
					"File Replace Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
			}

			sFtpServer1.HostKey.KeyLength = Convert.ToInt32(edtKeyLength.Text);
			sFtpServer1.HostKey.Generate();

			if (!StringUtils.IsEmpty(edtHostKeyFile.Text))
			{
				sFtpServer1.HostKey.Save(edtHostKeyFile.Text);
			}

			edtFingerPrint.Text = sFtpServer1.HostKey.FingerPrint;
		}

		private void AssignSettings()
		{
			if (sFtpServer1.Active) return;

			//Server Tab
			sFtpServer1.Port = Convert.ToInt32(edtPort.Text);
			sFtpServer1.LocalBinding = edtBindingHost.Text;
			sFtpServer1.UseIpV6 = cbUseIPv6.Checked;
			sFtpServer1.RootDir = edtRootDir.Text;
			if (!StringUtils.IsEmpty(sFtpServer1.RootDir))
			{
				Directory.CreateDirectory(FileUtils.AddTrailingBackSlash(sFtpServer1.RootDir));
			}

			//Banner Tab
			sFtpServer1.Banner = edtBannerMessage.Text;
			sFtpServer1.BannerLanguage = edtBannerLanguage.Text;
			sFtpServer1.EnableBanner = cbEnableBanner.Checked;

			//Access Control Tab
			sFtpServer1.UserAccounts.Clear();
			sFtpServer1.UserAccounts.Add(new SFtpUserAccountItem());
			sFtpServer1.UserAccounts[0].UserName = edtUserName.Text;
			sFtpServer1.UserAccounts[0].Password = edtPassword.Text;
			sFtpServer1.UserAccounts[0].RootDir = edtUserRootDir.Text;
			if (!StringUtils.IsEmpty(sFtpServer1.UserAccounts[0].RootDir))
			{
				Directory.CreateDirectory(FileUtils.AddTrailingBackSlash(sFtpServer1.UserAccounts[0].RootDir));
			}

			SFtpServerPermissions permissions = SFtpServerPermissions.None;
			if (cbCanList.Checked) permissions |= SFtpServerPermissions.List;
			if (cbCanMakeDir.Checked) permissions |= SFtpServerPermissions.MakeDir;
			if (cbCanRemoveDir.Checked) permissions |= SFtpServerPermissions.RemoveDir;
			if (cbCanRead.Checked) permissions |= SFtpServerPermissions.Read;
			if (cbCanWrite.Checked) permissions |= SFtpServerPermissions.Write;
			if (cbCanRename.Checked) permissions |= SFtpServerPermissions.Rename;
			if (cbCanRemove.Checked) permissions |= SFtpServerPermissions.Remove;
			if (cbCanMakeLink.Checked) permissions |= SFtpServerPermissions.MakeLink;
			if (cbCanReadLink.Checked) permissions |= SFtpServerPermissions.ReadLink;
			sFtpServer1.UserAccounts[0].Permissions = permissions;

			//IP Blocking Tab
			serverGuard1.ConnectionLimit.Max = Convert.ToInt32(edtAllowedConnections.Text);
			serverGuard1.ConnectionLimit.Period = 60000; //1 minute
			serverGuard1.BlackIPList = edtBlackList.Lines;
			serverGuard1.WhiteIPList = edtWhiteList.Lines;
			serverGuard1.AllowWhiteListOnly = cbWhiteListOnly.Checked;

			//SSH Algorithms Tab
			sFtpServer1.Config.SetConfig("kex", edtKexAlgs.Text);
			sFtpServer1.Config.SetConfig("hostkey", edtSignatureAlgs.Text);
			sFtpServer1.Config.SetConfig("cipher.s2c", edtEncryptionAlgs.Text);
			sFtpServer1.Config.SetConfig("cipher.c2s", edtEncryptionAlgs.Text);
			sFtpServer1.Config.SetConfig("mac.s2c", edtDataIntegrityAlgs.Text);
			sFtpServer1.Config.SetConfig("mac.c2s", edtDataIntegrityAlgs.Text);

			//Additional Settings Tab
			sFtpServer1.CharSet = edtCharSet.Text;
			sFtpServer1.MaxReturnFiles = Convert.ToInt32(edtMaxReturnFiles.Text);
			sFtpServer1.BatchSize = Convert.ToInt32(edtBatchSize.Text);
			sFtpServer1.MaxWindowSize = Convert.ToInt32(edtMaxWindowSize.Text);
		}

		private void sFtpServer1_ConnectionAccepted(object sender, CleverComponents.InetSuite.ConnectionAcceptedEventArgs e)
		{
			PutLogMessage("Accept Connection. Host: " + e.Connection.PeerIP);
		}

		private void sFtpServer1_ConnectionClosed(object sender, CleverComponents.InetSuite.ConnectionEventArgs e)
		{
			if (!isStop)
			{
				PutLogMessage("Close Connection. Host: " + e.Connection.PeerIP);
			}
		}

		private void sFtpServer1_RequestReceived(object sender, CleverComponents.InetSuite.SFtpServerEventArgs e)
		{
			if (e.Command == SFtpCommand.SSH_FXP_READ ||
				e.Command == SFtpCommand.SSH_FXP_WRITE ||
				e.Command == SFtpCommand.SSH_FXP_READDIR) return;

			PutLogMessage(String.Format("Command[{0}]: {1} ({2} bytes)", e.RequestId, SFtpCommand.GetCommandName(e.Command), e.Packet.GetLength()));
		}

		private void sFtpServer1_ResponseSent(object sender, CleverComponents.InetSuite.SFtpServerEventArgs e)
		{
			if (e.Command == SFtpCommand.SSH_FXP_READ ||
				e.Command == SFtpCommand.SSH_FXP_WRITE ||
				e.Command == SFtpCommand.SSH_FXP_READDIR) return;

			PutLogMessage(String.Format("Reply[{0}]: {1} ({2} bytes)", e.RequestId, SFtpCommand.GetCommandName(e.Command), e.Packet.GetLength()));
		}

		private void sFtpServer1_Started(object sender, EventArgs e)
		{
			PutLogMessage("==================\r\nStart Server");
		}

		private void sFtpServer1_Stopped(object sender, EventArgs e)
		{
			PutLogMessage("Stop Server");
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (sFtpServer1.Active) return;

			LoadHostKey();

			if (!sFtpServer1.HostKey.HasKey)
			{
				GenerateHostKey();
			}

			AssignSettings();

			serverGuard1.Reset();
			sFtpServer1.Start();
			lblStatus.Visible = true;
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			isStop = true;
			try
			{
				sFtpServer1.Stop();
				lblStatus.Visible = false;
			}
			finally
			{
				isStop = false;
			}
		}

		private void btnLoadHostKey_Click(object sender, EventArgs e)
		{
			if (sFtpServer1.Active) return;

			if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

			edtHostKeyFile.Text = openFileDialog1.FileName;

			LoadHostKey();
		}

		private void btnGenerateHostKey_Click(object sender, EventArgs e)
		{
			GenerateHostKey();
		}
	}
}
