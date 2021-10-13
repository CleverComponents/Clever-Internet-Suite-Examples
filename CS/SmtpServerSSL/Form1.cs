using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace SmtpServer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox memLog;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edtPort;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox cbUseLogin;
		private CleverComponents.InetSuite.SmtpServer smtpServer1;
		private CleverComponents.InetSuite.SmtpFileHandler smtpFileHandler1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox edtMailboxDir;
		private System.Windows.Forms.TextBox edtRelayDir;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbUseTls;
		private System.Windows.Forms.Label label8;
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

			cbUseTls.SelectedIndex = 3;
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
			CleverComponents.InetSuite.MailUserAccountItem mailUserAccountItem1 = new CleverComponents.InetSuite.MailUserAccountItem();
			this.memLog = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.edtMailboxDir = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edtPort = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbUseLogin = new System.Windows.Forms.CheckBox();
			this.smtpServer1 = new CleverComponents.InetSuite.SmtpServer();
			this.smtpFileHandler1 = new CleverComponents.InetSuite.SmtpFileHandler();
			this.edtRelayDir = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbUseTls = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.certificateStore1 = new CleverComponents.InetSuite.CertificateStore();
			this.SuspendLayout();
			// 
			// memLog
			// 
			this.memLog.Location = new System.Drawing.Point(0, 296);
			this.memLog.Multiline = true;
			this.memLog.Name = "memLog";
			this.memLog.ReadOnly = true;
			this.memLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memLog.Size = new System.Drawing.Size(440, 112);
			this.memLog.TabIndex = 29;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 275);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 14);
			this.label5.TabIndex = 28;
			this.label5.Text = "Log";
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(170, 256);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 27;
			this.btnStop.Text = "Stop";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(83, 256);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 26;
			this.btnStart.Text = "Start";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// edtMailboxDir
			// 
			this.edtMailboxDir.Location = new System.Drawing.Point(83, 168);
			this.edtMailboxDir.Name = "edtMailboxDir";
			this.edtMailboxDir.Size = new System.Drawing.Size(341, 20);
			this.edtMailboxDir.TabIndex = 25;
			this.edtMailboxDir.Text = "C:\\CleverMailBox\\";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 24;
			this.label4.Text = "Mailbox Dir";
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(83, 136);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(72, 20);
			this.edtPort.TabIndex = 23;
			this.edtPort.Text = "25";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 17);
			this.label3.TabIndex = 22;
			this.label3.Text = "Port";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(408, 32);
			this.label2.TabIndex = 21;
			this.label2.Text = "Please use the \"CleverTester\" user name and \"clevertester\" password to log-in. Th" +
    "e user e-mail: CleverTester@company.mail";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(416, 29);
			this.label1.TabIndex = 20;
			this.label1.Text = "This is a sample SMTP SSL / TLS server. You can use any SSL-enabled SMTP client (" +
    "such as TclSmtp or MS Outlook client to connect to this server.";
			// 
			// cbUseLogin
			// 
			this.cbUseLogin.Checked = true;
			this.cbUseLogin.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbUseLogin.Location = new System.Drawing.Point(83, 220);
			this.cbUseLogin.Name = "cbUseLogin";
			this.cbUseLogin.Size = new System.Drawing.Size(296, 24);
			this.cbUseLogin.TabIndex = 30;
			this.cbUseLogin.Text = "Use Authentication - LOGIN / CRAM-MD5 / NTLM";
			// 
			// smtpServer1
			// 
			this.smtpServer1.HelpText = new string[] {
        "Commands Supported:",
        "HELO EHLO AUTH HELP QUIT MAIL NOOP RSET RCPT DATA STARTTLS"};
			this.smtpServer1.ServerName = "Clever Internet Suite SMTP service";
			mailUserAccountItem1.DisplayName = "Clever Tester";
			mailUserAccountItem1.Email = "CleverTester@company.mail";
			mailUserAccountItem1.Password = "clevertester";
			mailUserAccountItem1.UserName = "CleverTester";
			this.smtpServer1.UserAccounts.AddRange(new CleverComponents.InetSuite.UserAccountItem[] {
            mailUserAccountItem1});
			this.smtpServer1.Authenticate += new CleverComponents.InetSuite.SmtpAuthenticateEventHandler(this.smtpServer1_Authenticate);
			this.smtpServer1.CommandReceived += new CleverComponents.InetSuite.TcpCommandEventHandler(this.smtpServer1_CommandReceived);
			this.smtpServer1.ResponseSent += new CleverComponents.InetSuite.TcpResponseEventHandler(this.smtpServer1_ResponseSent);
			this.smtpServer1.GetCertificate += new CleverComponents.InetSuite.GetCertificateEventHandler(this.smtpServer1_GetCertificate);
			this.smtpServer1.Started += new System.EventHandler(this.smtpServer1_Started);
			this.smtpServer1.Stopped += new System.EventHandler(this.smtpServer1_Stopped);
			this.smtpServer1.ConnectionAccepted += new CleverComponents.InetSuite.ConnectionAcceptedEventHandler(this.smtpServer1_ConnectionAccepted);
			this.smtpServer1.ConnectionClosed += new CleverComponents.InetSuite.ConnectionEventHandler(this.smtpServer1_ConnectionClosed);
			// 
			// smtpFileHandler1
			// 
			this.smtpFileHandler1.Counter = 1;
			this.smtpFileHandler1.MailBoxDir = null;
			this.smtpFileHandler1.RelayDir = null;
			this.smtpFileHandler1.Server = this.smtpServer1;
			// 
			// edtRelayDir
			// 
			this.edtRelayDir.Location = new System.Drawing.Point(83, 192);
			this.edtRelayDir.Name = "edtRelayDir";
			this.edtRelayDir.Size = new System.Drawing.Size(341, 20);
			this.edtRelayDir.TabIndex = 32;
			this.edtRelayDir.Text = "C:\\CleverMailBox\\RelayQueue\\";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 195);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 31;
			this.label6.Text = "Relay Dir";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(400, 40);
			this.label7.TabIndex = 33;
			this.label7.Text = "This server uses self-signed server certificate to establish the SSL connection. " +
    "In real application you will need to request a certificate from trusted issuer o" +
    "r use your own self-signed certificate.";
			// 
			// cbUseTls
			// 
			this.cbUseTls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUseTls.Items.AddRange(new object[] {
            "None",
            "Implicit",
            "Allow Explicit",
            "Require Explicit"});
			this.cbUseTls.Location = new System.Drawing.Point(304, 136);
			this.cbUseTls.Name = "cbUseTls";
			this.cbUseTls.Size = new System.Drawing.Size(121, 21);
			this.cbUseTls.TabIndex = 34;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(200, 139);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 16);
			this.label8.TabIndex = 35;
			this.label8.Text = "SSL / TLS Mode";
			// 
			// certificateStore1
			// 
			this.certificateStore1.ValidFrom = new System.DateTime(2008, 8, 17, 13, 58, 6, 250);
			this.certificateStore1.ValidTo = new System.DateTime(2009, 8, 17, 13, 58, 6, 250);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 408);
			this.Controls.Add(this.cbUseTls);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.edtRelayDir);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbUseLogin);
			this.Controls.Add(this.memLog);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.edtMailboxDir);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.edtPort);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clever SMTP Server";
			this.Closed += new System.EventHandler(this.Form1_Closed);
			this.Load += new System.EventHandler(this.Form1_Load);
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

		private string AddTrailingBackSlash(string path) {
			if(!StringUtils.IsEmpty(path) && path[path.Length -1] != '\\') {
				return path + '\\';
			}
			return path;
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
				smtpServer1.UseTls = (ServerTlsMode)cbUseTls.SelectedIndex;
				smtpServer1.UseAuth = cbUseLogin.Checked;
				smtpServer1.Port = Convert.ToInt32(edtPort.Text);

				smtpFileHandler1.MailBoxDir = edtMailboxDir.Text;
				smtpFileHandler1.RelayDir = edtRelayDir.Text;

				Directory.CreateDirectory(AddTrailingBackSlash(smtpFileHandler1.MailBoxDir) + "CleverTester\\");
				Directory.CreateDirectory(AddTrailingBackSlash(smtpFileHandler1.RelayDir));

				smtpServer1.Start();
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
		}

		private void btnStop_Click(object sender, System.EventArgs e) {
			smtpServer1.Stop();
		}

		private void smtpServer1_ConnectionAccepted(object sender, CleverComponents.InetSuite.ConnectionAcceptedEventArgs e) {
			PutLogMessage("Accept Connection. Host: " + e.Connection.PeerIP.ToString());
		}

		private void smtpServer1_ConnectionClosed(object sender, CleverComponents.InetSuite.ConnectionEventArgs e) {
			PutLogMessage("Close Connection. Host: " + e.Connection.PeerIP.ToString());
		}

		private void smtpServer1_Started(object sender, System.EventArgs e) {
			PutLogMessage("==================\r\nStart Server");
		}

		private void smtpServer1_Stopped(object sender, System.EventArgs e) {
			PutLogMessage("Stop Server");
		}

		private string GetSettingsFile() {
			return AddTrailingBackSlash(edtMailboxDir.Text) + "smtp.dat";
		}

		private void Form1_Load(object sender, System.EventArgs e) {
			CleverComponents.Utils.IniFile ini = new CleverComponents.Utils.IniFile(GetSettingsFile());
			try {
				smtpFileHandler1.Counter = Convert.ToInt32(ini.IniReadValue("SMTP", "Counter", "1"));
			}
			catch {
				smtpFileHandler1.Counter = 1;
			}
		}

		private void Form1_Closed(object sender, System.EventArgs e) {
			CleverComponents.Utils.IniFile ini = new CleverComponents.Utils.IniFile(GetSettingsFile());
			ini.IniWriteValue("SMTP", "Counter", smtpFileHandler1.Counter.ToString());
		}

		private void smtpServer1_GetCertificate(object sender, CleverComponents.InetSuite.GetCertificateEventArgs e) {
			if(certificateStore1.Items.Count == 0) {
				Certificate cert = certificateStore1.CreateSelfSigned("CN=CleverTester,O=CleverComponents,E=CleverTester@company.mail", 0);
				certificateStore1.Items.Add(cert);
			}
			e.Certificate = certificateStore1.Items[0];
			e.Handled = true;
		}

		private void smtpServer1_Authenticate(object sender, SmtpAuthenticateEventArgs e) {
			PutLogMessage("Authenticate user: " + e.UserName);
		}

		private void smtpServer1_CommandReceived(object sender, TcpCommandEventArgs e) {
			PutLogMessage("Command: " + e.CommandParams.RawCommand);
		}

		private void smtpServer1_ResponseSent(object sender, TcpResponseEventArgs e) {
			PutLogMessage("Reply: " + e.Response);
		}
	}
}
