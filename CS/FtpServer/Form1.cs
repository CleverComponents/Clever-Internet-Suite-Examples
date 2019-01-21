using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FtpServer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox edtPort;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edtRootDir;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label label5;
		private CleverComponents.InetSuite.FtpServer ftpServer1;
		private CleverComponents.InetSuite.FtpFileHandler ftpFileHandler1;
		private System.Windows.Forms.TextBox memLog;
		private CleverComponents.InetSuite.ServerGuard serverGuard1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox edtAllowedConnections;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox cbWhiteListOnly;
		private System.Windows.Forms.TextBox edtWhiteList;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox edtBlackList;
		private System.Windows.Forms.Label label6;
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
			CleverComponents.InetSuite.FtpUserAccountItem ftpUserAccountItem2 = new CleverComponents.InetSuite.FtpUserAccountItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.edtPort = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edtRootDir = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.memLog = new System.Windows.Forms.TextBox();
			this.ftpServer1 = new CleverComponents.InetSuite.FtpServer();
			this.serverGuard1 = new CleverComponents.InetSuite.ServerGuard();
			this.ftpFileHandler1 = new CleverComponents.InetSuite.FtpFileHandler();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.edtAllowedConnections = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cbWhiteListOnly = new System.Windows.Forms.CheckBox();
			this.edtWhiteList = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.edtBlackList = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(416, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "This is a sample FTP server. You can use any FTP client to connect to this server" +
				".";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(408, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Please use the \"CleverTester\" user name and \"clevertester\" password to log-in.";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Port";
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(88, 48);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(96, 20);
			this.edtPort.TabIndex = 3;
			this.edtPort.Text = "21";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Root Dir";
			// 
			// edtRootDir
			// 
			this.edtRootDir.Location = new System.Drawing.Point(88, 72);
			this.edtRootDir.Name = "edtRootDir";
			this.edtRootDir.Size = new System.Drawing.Size(328, 20);
			this.edtRootDir.TabIndex = 4;
			this.edtRootDir.Text = "C:\\CleverFtpServer\\";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(128, 288);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 10;
			this.btnStart.Text = "Start";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(232, 288);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 11;
			this.btnStop.Text = "Stop";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 304);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Log";
			// 
			// memLog
			// 
			this.memLog.Location = new System.Drawing.Point(16, 328);
			this.memLog.Multiline = true;
			this.memLog.Name = "memLog";
			this.memLog.ReadOnly = true;
			this.memLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memLog.Size = new System.Drawing.Size(416, 88);
			this.memLog.TabIndex = 12;
			// 
			// ftpServer1
			// 
			this.ftpServer1.CaseInsensitive = true;
			this.ftpServer1.Guard = this.serverGuard1;
			this.ftpServer1.Port = 21;
			this.ftpServer1.ServerName = "Clever Internet Suite FTP service";
			ftpUserAccountItem2.DisplayName = "Clever Tester";
			ftpUserAccountItem2.Password = "clevertester";
			ftpUserAccountItem2.UserName = "CleverTester";
			this.ftpServer1.UserAccounts.AddRange(new CleverComponents.InetSuite.UserAccountItem[] {
            ftpUserAccountItem2});
			this.ftpServer1.Authenticate += new CleverComponents.InetSuite.FtpAuthenticateEventHandler(this.ftpServer1_Authenticate);
			this.ftpServer1.Started += new System.EventHandler(this.ftpServer1_Started);
			this.ftpServer1.ConnectionAccepted += new CleverComponents.InetSuite.ConnectionAcceptedEventHandler(this.ftpServer1_ConnectionAccepted);
			this.ftpServer1.CommandReceived += new CleverComponents.InetSuite.TcpCommandEventHandler(this.ftpServer1_CommandReceived);
			this.ftpServer1.Stopped += new System.EventHandler(this.ftpServer1_Stopped);
			this.ftpServer1.ConnectionClosed += new CleverComponents.InetSuite.ConnectionEventHandler(this.ftpServer1_ConnectionClosed);
			this.ftpServer1.ResponseSent += new CleverComponents.InetSuite.TcpResponseEventHandler(this.ftpServer1_ResponseSent);
			// 
			// ftpFileHandler1
			// 
			this.ftpFileHandler1.Server = this.ftpServer1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.edtAllowedConnections);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.cbWhiteListOnly);
			this.groupBox1.Controls.Add(this.edtWhiteList);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.edtBlackList);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(16, 112);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(416, 168);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Server Guard settings";
			// 
			// edtAllowedConnections
			// 
			this.edtAllowedConnections.Location = new System.Drawing.Point(280, 24);
			this.edtAllowedConnections.Name = "edtAllowedConnections";
			this.edtAllowedConnections.Size = new System.Drawing.Size(48, 20);
			this.edtAllowedConnections.TabIndex = 6;
			this.edtAllowedConnections.Text = "6";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(272, 23);
			this.label8.TabIndex = 22;
			this.label8.Text = "Allowed Connections from the same host per minute";
			// 
			// cbWhiteListOnly
			// 
			this.cbWhiteListOnly.Location = new System.Drawing.Point(216, 136);
			this.cbWhiteListOnly.Name = "cbWhiteListOnly";
			this.cbWhiteListOnly.Size = new System.Drawing.Size(136, 24);
			this.cbWhiteListOnly.TabIndex = 9;
			this.cbWhiteListOnly.Text = "Allow Whitelist only";
			// 
			// edtWhiteList
			// 
			this.edtWhiteList.Location = new System.Drawing.Point(216, 72);
			this.edtWhiteList.Multiline = true;
			this.edtWhiteList.Name = "edtWhiteList";
			this.edtWhiteList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.edtWhiteList.Size = new System.Drawing.Size(184, 64);
			this.edtWhiteList.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(216, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 19;
			this.label7.Text = "White IP List";
			// 
			// edtBlackList
			// 
			this.edtBlackList.Location = new System.Drawing.Point(8, 72);
			this.edtBlackList.Multiline = true;
			this.edtBlackList.Name = "edtBlackList";
			this.edtBlackList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.edtBlackList.Size = new System.Drawing.Size(184, 64);
			this.edtBlackList.TabIndex = 7;
			this.edtBlackList.Text = "192.168.0.*\r\n212.121.0.1";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "Black IP List";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(450, 432);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.memLog);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.edtRootDir);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.edtPort);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "Clever FTP Server";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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

		delegate void PutLogMessageDelegate(string logMessage);

		void PutLogMessage(string logMessage) {
			if(this.IsDisposed) return;

			if(this.InvokeRequired) {
				this.Invoke(new PutLogMessageDelegate(PutLogMessage), new object[] { logMessage });
			}
			else {
				memLog.Text += logMessage + "\r\n";
				memLog.Select(memLog.Text.Length, 0);
				memLog.ScrollToCaret();
			}
		}

		private void btnStart_Click(object sender, System.EventArgs e) {
			try {
				serverGuard1.ConnectionLimit.Max = Convert.ToInt32(edtAllowedConnections.Text);
				serverGuard1.ConnectionLimit.Period = 60000; //1 minute
				serverGuard1.BlackIPList = edtBlackList.Lines;
				serverGuard1.WhiteIPList = edtWhiteList.Lines;
				serverGuard1.AllowWhiteListOnly = cbWhiteListOnly.Checked;

				serverGuard1.Reset();
				
				ftpServer1.Port = Convert.ToInt32(edtPort.Text);
				ftpServer1.RootDir = edtRootDir.Text;
				Directory.CreateDirectory(ftpServer1.RootDir);
				
				ftpServer1.Start();

				edtPort.Enabled = false;
				edtRootDir.Enabled = false;
				groupBox1.Enabled = false;
				btnStart.Enabled = false;

				this.Text = "Clever FTP Server - Started";
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
		}

		private void btnStop_Click(object sender, System.EventArgs e) {
			ftpServer1.Stop();

			edtPort.Enabled = true;
			edtRootDir.Enabled = true;
			groupBox1.Enabled = true;
			btnStart.Enabled = true;

			this.Text = "Clever FTP Server";
		}

		private void ftpServer1_Authenticate(object sender, CleverComponents.InetSuite.FtpAuthenticateEventArgs e) {
			PutLogMessage("Authenticate user: " + e.UserName);
		}

		private void ftpServer1_ConnectionAccepted(object sender, CleverComponents.InetSuite.ConnectionAcceptedEventArgs e) {
			PutLogMessage("Accept Connection. Host: " + e.Connection.PeerIP.ToString());
		}

		private void ftpServer1_ConnectionClosed(object sender, CleverComponents.InetSuite.ConnectionEventArgs e) {
			PutLogMessage("Close Connection. Host: " + e.Connection.PeerIP.ToString());
		}

		private void ftpServer1_Started(object sender, System.EventArgs e) {
			PutLogMessage("==================\r\nStart Server");
		}

		private void ftpServer1_Stopped(object sender, System.EventArgs e) {
			PutLogMessage("Stop Server");
		}

		private void ftpServer1_ResponseSent(object sender, CleverComponents.InetSuite.TcpResponseEventArgs e) {
			PutLogMessage("Reply: " + e.Response);
		}

		private void ftpServer1_CommandReceived(object sender, CleverComponents.InetSuite.TcpCommandEventArgs e) {
			PutLogMessage("Command: " + e.CommandParams.RawCommand);
		}
	}
}
