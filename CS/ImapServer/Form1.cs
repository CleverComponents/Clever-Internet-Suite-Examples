using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace ImapServer
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
		private Imap4Server imap4Server1;
		private Imap4FileHandler imap4FileHandler1;
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
			this.imap4Server1 = new CleverComponents.InetSuite.Imap4Server();
			this.imap4FileHandler1 = new CleverComponents.InetSuite.Imap4FileHandler();
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
			this.label5.Location = new System.Drawing.Point(16, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 23);
			this.label5.TabIndex = 18;
			this.label5.Text = "Log";
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(176, 144);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 17;
			this.btnStop.Text = "Stop";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(80, 144);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 16;
			this.btnStart.Text = "Start";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// edtRootDir
			// 
			this.edtRootDir.Location = new System.Drawing.Point(80, 112);
			this.edtRootDir.Name = "edtRootDir";
			this.edtRootDir.Size = new System.Drawing.Size(336, 20);
			this.edtRootDir.TabIndex = 15;
			this.edtRootDir.Text = "C:\\CleverMailBox\\";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 14;
			this.label4.Text = "Root Dir";
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(80, 80);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(168, 20);
			this.edtPort.TabIndex = 13;
			this.edtPort.Text = "143";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 23);
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
			this.label1.Text = "This is a sample IMAP server. You can use any mail client with IMAP support to co" +
    "nnect to this server.";
			// 
			// imap4Server1
			// 
			mailUserAccountItem1.Password = "clevertester";
			mailUserAccountItem1.UserName = "CleverTester";
			this.imap4Server1.UserAccounts.AddRange(new CleverComponents.InetSuite.UserAccountItem[] {
            mailUserAccountItem1});
			this.imap4Server1.Authenticate += new CleverComponents.InetSuite.Imap4AuthenticateEventHandler(this.imap4Server1_Authenticate);
			this.imap4Server1.CommandReceived += new CleverComponents.InetSuite.TcpCommandEventHandler(this.imap4Server1_CommandReceived);
			this.imap4Server1.ResponseSent += new CleverComponents.InetSuite.TcpResponseEventHandler(this.imap4Server1_ResponseSent);
			this.imap4Server1.Started += new System.EventHandler(this.imap4Server1_Started);
			this.imap4Server1.Stopped += new System.EventHandler(this.imap4Server1_Stopped);
			this.imap4Server1.ConnectionAccepted += new CleverComponents.InetSuite.ConnectionAcceptedEventHandler(this.imap4Server1_ConnectionAccepted);
			this.imap4Server1.ConnectionClosed += new CleverComponents.InetSuite.ConnectionEventHandler(this.imap4Server1_ConnectionClosed);
			// 
			// imap4FileHandler1
			// 
			this.imap4FileHandler1.Server = this.imap4Server1;
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
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clever IMAP4 Server";
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
				imap4Server1.Port = Convert.ToInt32(edtPort.Text);
				imap4FileHandler1.MailBoxDir = edtRootDir.Text;
				Directory.CreateDirectory(AddTrailingBackSlash(imap4FileHandler1.MailBoxDir));
				Directory.CreateDirectory(AddTrailingBackSlash(imap4FileHandler1.MailBoxDir) + "CleverTester\\");
				imap4Server1.Start();
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
		}

		private void btnStop_Click(object sender, System.EventArgs e) {
			imap4Server1.Stop();
		}

		private void imap4Server1_Started(object sender, EventArgs e) {
			PutLogMessage("==================\r\nStart Server");
		}

		private void imap4Server1_Stopped(object sender, EventArgs e) {
			PutLogMessage("Stop Server");
		}

		private void imap4Server1_ConnectionAccepted(object sender, ConnectionAcceptedEventArgs e) {
			PutLogMessage("Accept Connection. Host: " + e.Connection.PeerIP);
		}

		private void imap4Server1_ConnectionClosed(object sender, ConnectionEventArgs e) {
			PutLogMessage("Close Connection. Host: " + e.Connection.PeerIP);
		}

		private void imap4Server1_CommandReceived(object sender, TcpCommandEventArgs e) {
			PutLogMessage("Command: " + e.CommandParams.Command + " " + e.CommandParams.Parameters);
		}

		private void imap4Server1_ResponseSent(object sender, TcpResponseEventArgs e) {
			PutLogMessage("Reply: " + e.Response);
		}

		private void imap4Server1_Authenticate(object sender, Imap4AuthenticateEventArgs e) {
			if (e.Account != null) {
				PutLogMessage("Authenticate user: " + e.Account.UserName);
			}
		}
	}
}
