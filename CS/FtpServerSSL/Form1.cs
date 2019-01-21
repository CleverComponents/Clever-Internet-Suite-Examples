using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace FtpServerSSL
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
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbUseTls;
		private CleverComponents.InetSuite.CertificateStore certificateStore1;
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

			cbUseTls.SelectedIndex = 1;

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
			CleverComponents.InetSuite.FtpUserAccountItem ftpUserAccountItem1 = new CleverComponents.InetSuite.FtpUserAccountItem();
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
			this.ftpFileHandler1 = new CleverComponents.InetSuite.FtpFileHandler();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbUseTls = new System.Windows.Forms.ComboBox();
			this.certificateStore1 = new CleverComponents.InetSuite.CertificateStore();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(416, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "This is a sample FTP SSL / TLS server. You can use any SSL-enabled FTP client (su" +
				"ch as TclFTP or SurgeFTP client to connect to this server.";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(408, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Please use the \"CleverTester\" user name and \"clevertester\" password to log-in.";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Port";
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(80, 152);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(64, 20);
			this.edtPort.TabIndex = 3;
			this.edtPort.Text = "990";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Root Dir";
			// 
			// edtRootDir
			// 
			this.edtRootDir.Location = new System.Drawing.Point(80, 184);
			this.edtRootDir.Name = "edtRootDir";
			this.edtRootDir.Size = new System.Drawing.Size(336, 20);
			this.edtRootDir.TabIndex = 5;
			this.edtRootDir.Text = "C:\\CleverFtpServer\\";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(80, 216);
			this.btnStart.Name = "btnStart";
			this.btnStart.TabIndex = 6;
			this.btnStart.Text = "Start";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(176, 216);
			this.btnStop.Name = "btnStop";
			this.btnStop.TabIndex = 7;
			this.btnStop.Text = "Stop";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 240);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Log";
			// 
			// memLog
			// 
			this.memLog.Location = new System.Drawing.Point(0, 264);
			this.memLog.Multiline = true;
			this.memLog.Name = "memLog";
			this.memLog.ReadOnly = true;
			this.memLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memLog.Size = new System.Drawing.Size(440, 136);
			this.memLog.TabIndex = 9;
			this.memLog.Text = "";
			// 
			// ftpServer1
			// 
			this.ftpServer1.CaseInsensitive = true;
			this.ftpServer1.Port = 21;
			this.ftpServer1.ServerName = "Clever Internet Suite FTP service";
			ftpUserAccountItem1.DisplayName = "Clever Tester";
			ftpUserAccountItem1.Password = "clevertester";
			ftpUserAccountItem1.UserName = "CleverTester";
			this.ftpServer1.UserAccounts.AddRange(new CleverComponents.InetSuite.UserAccountItem[] {
																									   ftpUserAccountItem1});
			this.ftpServer1.Authenticate += new CleverComponents.InetSuite.FtpAuthenticateEventHandler(this.ftpServer1_Authenticate);
			this.ftpServer1.CommandReceived += new CleverComponents.InetSuite.TcpCommandEventHandler(this.ftpServer1_CommandReceived);
			this.ftpServer1.GetCertificate += new CleverComponents.InetSuite.GetCertificateEventHandler(this.ftpServer1_GetCertificate);
			this.ftpServer1.ConnectionAccepted += new CleverComponents.InetSuite.ConnectionAcceptedEventHandler(this.ftpServer1_ConnectionAccepted);
			this.ftpServer1.Started += new System.EventHandler(this.ftpServer1_Started);
			this.ftpServer1.ConnectionClosed += new CleverComponents.InetSuite.ConnectionEventHandler(this.ftpServer1_ConnectionClosed);
			this.ftpServer1.ResponseSent += new CleverComponents.InetSuite.TcpResponseEventHandler(this.ftpServer1_ResponseSent);
			this.ftpServer1.Stopped += new System.EventHandler(this.ftpServer1_Stopped);
			// 
			// ftpFileHandler1
			// 
			this.ftpFileHandler1.Server = this.ftpServer1;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(408, 48);
			this.label6.TabIndex = 10;
			this.label6.Text = "This server uses self-signed server certificate to establish the SSL connection. " +
				"In real application you will need to request a certificate from trusted issuer o" +
				"r use your own self-signed certificate.";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(184, 152);
			this.label7.Name = "label7";
			this.label7.TabIndex = 11;
			this.label7.Text = "SSL / TLS Mode";
			// 
			// cbUseTls
			// 
			this.cbUseTls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUseTls.Items.AddRange(new object[] {
														  "None",
														  "Implicit",
														  "Allow Explicit",
														  "Require Explicit"});
			this.cbUseTls.Location = new System.Drawing.Point(296, 152);
			this.cbUseTls.Name = "cbUseTls";
			this.cbUseTls.Size = new System.Drawing.Size(121, 21);
			this.cbUseTls.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 400);
			this.Controls.Add(this.cbUseTls);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
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
			this.ResumeLayout(false);

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
				ftpServer1.UseTls = (ServerTlsMode)cbUseTls.SelectedIndex;
				ftpServer1.Port = Convert.ToInt32(edtPort.Text);
				ftpServer1.RootDir = edtRootDir.Text;
				Directory.CreateDirectory(ftpServer1.RootDir);
				ftpServer1.Start();
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
		}

		private void btnStop_Click(object sender, System.EventArgs e) {
			ftpServer1.Stop();
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

		private void ftpServer1_GetCertificate(object sender, CleverComponents.InetSuite.GetCertificateEventArgs e) {
			if(certificateStore1.Items.Count == 0) {
				Certificate cert = certificateStore1.CreateSelfSigned("CN=CleverTester,O=CleverComponents,E=CleverTester@company.mail", 0);
				certificateStore1.Items.Add(cert);
			}
			e.Certificate = certificateStore1.Items[0];
			e.Handled = true;
		}
	}
}
