using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace Pop3Server
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
		private System.Windows.Forms.TextBox edtRootDir;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edtPort;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private CleverComponents.InetSuite.Pop3Server pop3Server1;
		private CleverComponents.InetSuite.Pop3FileHandler pop3FileHandler1;
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
			CleverComponents.InetSuite.MailUserAccountItem mailUserAccountItem1 = new CleverComponents.InetSuite.MailUserAccountItem();
			this.memLog = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.edtRootDir = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edtPort = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pop3Server1 = new CleverComponents.InetSuite.Pop3Server();
			this.pop3FileHandler1 = new CleverComponents.InetSuite.Pop3FileHandler();
			this.SuspendLayout();
			// 
			// memLog
			// 
			this.memLog.Location = new System.Drawing.Point(0, 192);
			this.memLog.Multiline = true;
			this.memLog.Name = "memLog";
			this.memLog.ReadOnly = true;
			this.memLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memLog.Size = new System.Drawing.Size(440, 136);
			this.memLog.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 16);
			this.label5.TabIndex = 18;
			this.label5.Text = "Log";
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(152, 144);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 17;
			this.btnStop.Text = "Stop";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(71, 144);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 16;
			this.btnStart.Text = "Start";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// edtRootDir
			// 
			this.edtRootDir.Location = new System.Drawing.Point(71, 112);
			this.edtRootDir.Name = "edtRootDir";
			this.edtRootDir.Size = new System.Drawing.Size(345, 20);
			this.edtRootDir.TabIndex = 15;
			this.edtRootDir.Text = "C:\\CleverMailBox\\";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 16);
			this.label4.TabIndex = 14;
			this.label4.Text = "Root Dir";
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(71, 80);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(75, 20);
			this.edtPort.TabIndex = 13;
			this.edtPort.Text = "110";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 14);
			this.label3.TabIndex = 12;
			this.label3.Text = "Port";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(408, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Please use the \"CleverTester\" user name and \"clevertester\" password to log-in.";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(416, 29);
			this.label1.TabIndex = 10;
			this.label1.Text = "This is a sample POP3 server. You can use any mail client with POP3 support to co" +
				"nnect to this server.";
			// 
			// pop3Server1
			// 
			this.pop3Server1.HelpText = new string[] {
        "Valid commands: USER",
        "PASS",
        "APOP",
        "AUTH",
        "QUIT",
        "NOOP",
        "HELP",
        "STAT",
        "RETR",
        "TOP",
        "DELE",
        "RSET",
        "LIST",
        "UIDL",
        "STLS"};
			this.pop3Server1.ServerName = "Clever Internet Suite POP3 service";
			mailUserAccountItem1.DisplayName = "Clever Tester";
			mailUserAccountItem1.Password = "clevertester";
			mailUserAccountItem1.UserName = "CleverTester";
			this.pop3Server1.UserAccounts.AddRange(new CleverComponents.InetSuite.UserAccountItem[] {
            mailUserAccountItem1});
			this.pop3Server1.Authenticate += new CleverComponents.InetSuite.Pop3AuthenticateEventHandler(this.pop3Server1_Authenticate);
			this.pop3Server1.CommandReceived += new CleverComponents.InetSuite.TcpCommandEventHandler(this.pop3Server1_CommandReceived);
			this.pop3Server1.ResponseSent += new CleverComponents.InetSuite.TcpResponseEventHandler(this.pop3Server1_ResponseSent);
			this.pop3Server1.Started += new System.EventHandler(this.pop3Server1_Started);
			this.pop3Server1.Stopped += new System.EventHandler(this.pop3Server1_Stopped);
			this.pop3Server1.ConnectionAccepted += new CleverComponents.InetSuite.ConnectionAcceptedEventHandler(this.pop3Server1_ConnectionAccepted);
			this.pop3Server1.ConnectionClosed += new CleverComponents.InetSuite.ConnectionEventHandler(this.pop3Server1_ConnectionClosed);
			// 
			// pop3FileHandler1
			// 
			this.pop3FileHandler1.MailBoxDir = null;
			this.pop3FileHandler1.Server = this.pop3Server1;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 326);
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
			this.Text = "Clever POP3 Server";
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
				pop3Server1.Port = Convert.ToInt32(edtPort.Text);
				pop3FileHandler1.MailBoxDir = edtRootDir.Text;
				Directory.CreateDirectory(AddTrailingBackSlash(pop3FileHandler1.MailBoxDir) + "CleverTester\\");
				pop3Server1.Start();
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
		}

		private void btnStop_Click(object sender, System.EventArgs e) {
			pop3Server1.Stop();
		}

		private void pop3Server1_ConnectionAccepted(object sender, CleverComponents.InetSuite.ConnectionAcceptedEventArgs e) {
			PutLogMessage("Accept Connection. Host: " + e.Connection.PeerIP.ToString());
		}

		private void pop3Server1_ConnectionClosed(object sender, CleverComponents.InetSuite.ConnectionEventArgs e) {
			PutLogMessage("Close Connection. Host: " + e.Connection.PeerIP.ToString());
		}

		private void pop3Server1_Authenticate(object sender, CleverComponents.InetSuite.Pop3AuthenticateEventArgs e) {
			PutLogMessage("Authenticate user: " + e.UserName);
		}

		private void pop3Server1_CommandReceived(object sender, CleverComponents.InetSuite.TcpCommandEventArgs e) {
			PutLogMessage("Command: " + e.CommandParams.RawCommand);
		}

		private void pop3Server1_ResponseSent(object sender, CleverComponents.InetSuite.TcpResponseEventArgs e) {
			PutLogMessage("Reply: " + e.Response);
		}

		private void pop3Server1_Started(object sender, System.EventArgs e) {
			PutLogMessage("==================\r\nStart Server");
		}

		private void pop3Server1_Stopped(object sender, System.EventArgs e) {
			PutLogMessage("Stop Server");
		}
	}
}
