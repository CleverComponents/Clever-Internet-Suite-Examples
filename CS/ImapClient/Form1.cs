using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace ImapClient
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox edtServer;
		private System.Windows.Forms.TextBox edtUser;
		private System.Windows.Forms.TextBox edtPassword;
		private System.Windows.Forms.CheckBox cbUseSPA;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edtPort;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox edtTimeOut;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox edtSubscribed;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox edtAll;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox edtRecent;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox edtFirstUnseen;
		private System.Windows.Forms.ListView lvMessages;
		private System.Windows.Forms.ListBox tvFolders;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox memLog;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnNewFolder;
		private System.Windows.Forms.Button btnDeleteFolder;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnSubscribe;
		private System.Windows.Forms.Button btnUnsubscribe;
		private System.Windows.Forms.Button btnAppend;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnPurge;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private CleverComponents.InetSuite.Imap4 imap41;
		private CleverComponents.InetSuite.MailMessage mailMessage1;
		private Hashtable subscribeStatus = new Hashtable();

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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.edtServer = new System.Windows.Forms.TextBox();
			this.edtUser = new System.Windows.Forms.TextBox();
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.cbUseSPA = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edtPort = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.edtTimeOut = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.edtFirstUnseen = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.edtRecent = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.edtAll = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.edtSubscribed = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lvMessages = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.tvFolders = new System.Windows.Forms.ListBox();
			this.label10 = new System.Windows.Forms.Label();
			this.memLog = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnNewFolder = new System.Windows.Forms.Button();
			this.btnDeleteFolder = new System.Windows.Forms.Button();
			this.btnFind = new System.Windows.Forms.Button();
			this.btnSubscribe = new System.Windows.Forms.Button();
			this.btnUnsubscribe = new System.Windows.Forms.Button();
			this.btnAppend = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnPurge = new System.Windows.Forms.Button();
			this.imap41 = new CleverComponents.InetSuite.Imap4();
			this.mailMessage1 = new CleverComponents.InetSuite.MailMessage();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "User";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			// 
			// edtServer
			// 
			this.edtServer.Location = new System.Drawing.Point(80, 16);
			this.edtServer.Name = "edtServer";
			this.edtServer.Size = new System.Drawing.Size(216, 20);
			this.edtServer.TabIndex = 3;
			this.edtServer.Text = "localhost";
			// 
			// edtUser
			// 
			this.edtUser.Location = new System.Drawing.Point(80, 40);
			this.edtUser.Name = "edtUser";
			this.edtUser.Size = new System.Drawing.Size(216, 20);
			this.edtUser.TabIndex = 4;
			this.edtUser.Text = "CleverTester";
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(80, 64);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.Size = new System.Drawing.Size(216, 20);
			this.edtPassword.TabIndex = 5;
			this.edtPassword.Text = "clevertester";
			// 
			// cbUseSPA
			// 
			this.cbUseSPA.Location = new System.Drawing.Point(312, 16);
			this.cbUseSPA.Name = "cbUseSPA";
			this.cbUseSPA.Size = new System.Drawing.Size(216, 24);
			this.cbUseSPA.TabIndex = 6;
			this.cbUseSPA.Text = "Use Secure Password Authentication";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(312, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Port";
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(392, 40);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(128, 20);
			this.edtPort.TabIndex = 9;
			this.edtPort.Text = "143";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(312, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "TimeOut, s";
			// 
			// edtTimeOut
			// 
			this.edtTimeOut.Location = new System.Drawing.Point(392, 64);
			this.edtTimeOut.Name = "edtTimeOut";
			this.edtTimeOut.Size = new System.Drawing.Size(128, 20);
			this.edtTimeOut.TabIndex = 11;
			this.edtTimeOut.Text = "60";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.edtFirstUnseen);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.edtRecent);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.edtAll);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.edtSubscribed);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(184, 96);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(336, 80);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Folder Details";
			// 
			// edtFirstUnseen
			// 
			this.edtFirstUnseen.Location = new System.Drawing.Point(256, 48);
			this.edtFirstUnseen.Name = "edtFirstUnseen";
			this.edtFirstUnseen.Size = new System.Drawing.Size(64, 20);
			this.edtFirstUnseen.TabIndex = 7;
			this.edtFirstUnseen.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(152, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 16);
			this.label9.TabIndex = 6;
			this.label9.Text = "First Unseen";
			// 
			// edtRecent
			// 
			this.edtRecent.Location = new System.Drawing.Point(256, 24);
			this.edtRecent.Name = "edtRecent";
			this.edtRecent.Size = new System.Drawing.Size(64, 20);
			this.edtRecent.TabIndex = 5;
			this.edtRecent.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(152, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(96, 16);
			this.label8.TabIndex = 4;
			this.label8.Text = "Recent Messages";
			// 
			// edtAll
			// 
			this.edtAll.Location = new System.Drawing.Point(80, 48);
			this.edtAll.Name = "edtAll";
			this.edtAll.Size = new System.Drawing.Size(64, 20);
			this.edtAll.TabIndex = 3;
			this.edtAll.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 16);
			this.label7.TabIndex = 2;
			this.label7.Text = "All Messages";
			// 
			// edtSubscribed
			// 
			this.edtSubscribed.Location = new System.Drawing.Point(80, 24);
			this.edtSubscribed.Name = "edtSubscribed";
			this.edtSubscribed.Size = new System.Drawing.Size(64, 20);
			this.edtSubscribed.TabIndex = 1;
			this.edtSubscribed.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.TabIndex = 0;
			this.label6.Text = "Subscribed";
			// 
			// lvMessages
			// 
			this.lvMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						 this.columnHeader1,
																						 this.columnHeader2,
																						 this.columnHeader3,
																						 this.columnHeader4});
			this.lvMessages.FullRowSelect = true;
			this.lvMessages.HideSelection = false;
			this.lvMessages.Location = new System.Drawing.Point(184, 184);
			this.lvMessages.Name = "lvMessages";
			this.lvMessages.Size = new System.Drawing.Size(336, 104);
			this.lvMessages.TabIndex = 14;
			this.lvMessages.View = System.Windows.Forms.View.Details;
			this.lvMessages.DoubleClick += new System.EventHandler(this.lvMessages_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "No";
			this.columnHeader1.Width = 50;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Subject";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "From";
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Flags";
			this.columnHeader4.Width = 80;
			// 
			// tvFolders
			// 
			this.tvFolders.Location = new System.Drawing.Point(16, 104);
			this.tvFolders.Name = "tvFolders";
			this.tvFolders.Size = new System.Drawing.Size(152, 186);
			this.tvFolders.TabIndex = 12;
			this.tvFolders.SelectedIndexChanged += new System.EventHandler(this.tvFolders_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 296);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 16);
			this.label10.TabIndex = 15;
			this.label10.Text = "Log";
			// 
			// memLog
			// 
			this.memLog.Location = new System.Drawing.Point(16, 312);
			this.memLog.Multiline = true;
			this.memLog.Name = "memLog";
			this.memLog.ReadOnly = true;
			this.memLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.memLog.Size = new System.Drawing.Size(504, 72);
			this.memLog.TabIndex = 16;
			this.memLog.Text = "";
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(536, 16);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(96, 23);
			this.btnLogin.TabIndex = 17;
			this.btnLogin.Text = "Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.Location = new System.Drawing.Point(536, 48);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(96, 23);
			this.btnLogout.TabIndex = 18;
			this.btnLogout.Text = "Logout";
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnNewFolder
			// 
			this.btnNewFolder.Location = new System.Drawing.Point(536, 96);
			this.btnNewFolder.Name = "btnNewFolder";
			this.btnNewFolder.Size = new System.Drawing.Size(96, 23);
			this.btnNewFolder.TabIndex = 19;
			this.btnNewFolder.Text = "New Folder...";
			this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
			// 
			// btnDeleteFolder
			// 
			this.btnDeleteFolder.Location = new System.Drawing.Point(536, 128);
			this.btnDeleteFolder.Name = "btnDeleteFolder";
			this.btnDeleteFolder.Size = new System.Drawing.Size(96, 23);
			this.btnDeleteFolder.TabIndex = 20;
			this.btnDeleteFolder.Text = "Delete Folder";
			this.btnDeleteFolder.Click += new System.EventHandler(this.btnDeleteFolder_Click);
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(536, 160);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(96, 23);
			this.btnFind.TabIndex = 21;
			this.btnFind.Text = "Find...";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnSubscribe
			// 
			this.btnSubscribe.Location = new System.Drawing.Point(536, 192);
			this.btnSubscribe.Name = "btnSubscribe";
			this.btnSubscribe.Size = new System.Drawing.Size(96, 23);
			this.btnSubscribe.TabIndex = 22;
			this.btnSubscribe.Text = "Subscribe";
			this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
			// 
			// btnUnsubscribe
			// 
			this.btnUnsubscribe.Location = new System.Drawing.Point(536, 224);
			this.btnUnsubscribe.Name = "btnUnsubscribe";
			this.btnUnsubscribe.Size = new System.Drawing.Size(96, 23);
			this.btnUnsubscribe.TabIndex = 23;
			this.btnUnsubscribe.Text = "Unsubscribe";
			this.btnUnsubscribe.Click += new System.EventHandler(this.btnUnsubscribe_Click);
			// 
			// btnAppend
			// 
			this.btnAppend.Location = new System.Drawing.Point(536, 264);
			this.btnAppend.Name = "btnAppend";
			this.btnAppend.Size = new System.Drawing.Size(96, 23);
			this.btnAppend.TabIndex = 24;
			this.btnAppend.Text = "Append...";
			this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(536, 296);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(96, 23);
			this.btnCopy.TabIndex = 25;
			this.btnCopy.Text = "Copy";
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(536, 328);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(96, 23);
			this.btnDelete.TabIndex = 26;
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnPurge
			// 
			this.btnPurge.Location = new System.Drawing.Point(536, 360);
			this.btnPurge.Name = "btnPurge";
			this.btnPurge.Size = new System.Drawing.Size(96, 23);
			this.btnPurge.TabIndex = 27;
			this.btnPurge.Text = "Purge Deleted";
			this.btnPurge.Click += new System.EventHandler(this.btnPurge_Click);
			// 
			// imap41
			// 
			this.imap41.Port = 143;
			this.imap41.CommandSent += new CleverComponents.InetSuite.TcpTextEventHandler(this.imap41_CommandSent);
			this.imap41.ResponseReceived += new CleverComponents.InetSuite.TcpListEventHandler(this.imap41_ResponseReceived);
			// 
			// mailMessage1
			// 
			this.mailMessage1.Date = new System.DateTime(2006, 5, 4, 21, 9, 17, 733);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(648, 398);
			this.Controls.Add(this.btnPurge);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.btnAppend);
			this.Controls.Add(this.btnUnsubscribe);
			this.Controls.Add(this.btnSubscribe);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.btnDeleteFolder);
			this.Controls.Add(this.btnNewFolder);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.memLog);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.tvFolders);
			this.Controls.Add(this.lvMessages);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.edtTimeOut);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.edtPort);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbUseSPA);
			this.Controls.Add(this.edtPassword);
			this.Controls.Add(this.edtUser);
			this.Controls.Add(this.edtServer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "IMAP Client";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).EndInit();
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

		private void btnLogin_Click(object sender, System.EventArgs e) {
			if (imap41.Active) {
				MessageBox.Show("You are already connected. Please click Logout to disconnect.");
				return;
			}

			try {
				imap41.Server = edtServer.Text;
				imap41.Port = Convert.ToInt32(edtPort.Text);
				imap41.UserName = edtUser.Text;
				imap41.Password = edtPassword.Text;
				imap41.UseSasl = cbUseSPA.Checked;
				imap41.TimeOut = Convert.ToInt32(edtTimeOut.Text) * 1000;
				imap41.Open();

				GetFolderList();

				UpdateStatus();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void GetFolderList() {
			subscribeStatus.Clear();
			tvFolders.Items.Clear();
			lvMessages.Items.Clear();

			edtSubscribed.Text = "";
			edtAll.Text = "";
			edtRecent.Text = "";
			edtFirstUnseen.Text = "";

			string[] mailboxes = imap41.GetMailBoxes();

			string[] subscribed = imap41.GetSubscribedMailBoxes();

			for (int i = 0; i < mailboxes.Length; i++) {
				string item = mailboxes[i].ToString();
				tvFolders.Items.Add(item);
				subscribeStatus.Add(item, (Array.IndexOf(subscribed, item) > -1));
			}
		}

		private void UpdateStatus() {
			Text = imap41.Active ? "IMAP Clinet - Connected" : "IMAP Clinet";
		}

		private void btnLogout_Click(object sender, System.EventArgs e) {
			imap41.Close();

			subscribeStatus.Clear();
			tvFolders.Items.Clear();
			lvMessages.Items.Clear();

			edtSubscribed.Text = "";
			edtAll.Text = "";
			edtRecent.Text = "";
			edtFirstUnseen.Text = "";

			UpdateStatus();
		}

		private void btnNewFolder_Click(object sender, System.EventArgs e) {
			if (!imap41.Active) return;

			NewFolderDlg dlg = new NewFolderDlg();
			if (dlg.ShowDialog() == DialogResult.OK) {
				if (dlg.cbIsSubfolder.Checked && (tvFolders.SelectedIndex > -1)) {
					imap41.CreateMailBox(tvFolders.SelectedItem.ToString()
						+ imap41.MailBoxSeparator + dlg.edtName.Text);
				}
				else {
					imap41.CreateMailBox(dlg.edtName.Text);
				}

				GetFolderList();
			}
		}

		private void btnDeleteFolder_Click(object sender, System.EventArgs e) {
			if (!imap41.Active) return;

			if (tvFolders.SelectedIndex > -1) {
				if (MessageBox.Show(string.Format("Do you wish to delete the {0} folder ?",
					tvFolders.SelectedItem.ToString()), "Delete folder",
					MessageBoxButtons.YesNo) == DialogResult.Yes) {
					imap41.DeleteMailBox(tvFolders.SelectedItem.ToString());
					GetFolderList();
				}
			}
		}

		private void btnFind_Click(object sender, System.EventArgs e) {
			if (!imap41.Active) return;
    
			if (tvFolders.SelectedIndex < 0) return;

			SearchDlg dlg = new SearchDlg();

			if (dlg.ShowDialog() == DialogResult.OK) {
				IList result = imap41.SearchMessages(dlg.GetSearchCriteria());

				if (result == null || result.Count == 0) {
					MessageBox.Show("No messages found.");
				}
				else {
					MessageBox.Show(string.Format("Found {0} message(s).\r\n"
						+ " Message numbers: \r\n{1}", result.Count, StringUtils.GetStringsAsString(result)));
				}
			}
		}

		private void btnSubscribe_Click(object sender, System.EventArgs e) {
			if (!imap41.Active) return;
    
			if ((tvFolders.SelectedIndex > -1) && !(bool)subscribeStatus[tvFolders.SelectedItem]) {
				imap41.SubscribeMailBox(tvFolders.SelectedItem.ToString());
				subscribeStatus[tvFolders.SelectedItem] = true;
				tvFolders_SelectedIndexChanged(null, null);
				MessageBox.Show(string.Format("The folder {0} has been subscribed.", tvFolders.SelectedItem.ToString()));
			}
		}

		private void btnUnsubscribe_Click(object sender, System.EventArgs e) {
			if (!imap41.Active) return;
    
			if ((tvFolders.SelectedIndex > -1) && (bool)subscribeStatus[tvFolders.SelectedItem]) {
				imap41.UnsubscribeMailBox(tvFolders.SelectedItem.ToString());
				subscribeStatus[tvFolders.SelectedItem] = false;
				tvFolders_SelectedIndexChanged(null, null);
				MessageBox.Show(string.Format("The folder {0} has been unsubscribed.", tvFolders.SelectedItem.ToString()));
			}
		}

		private void btnAppend_Click(object sender, System.EventArgs e) {
			if (!imap41.Active) return;

			if (tvFolders.SelectedIndex > -1) {
				if (MessageFrm.ComposeMessage(mailMessage1)) {
					imap41.AppendMessage(tvFolders.SelectedItem.ToString(), mailMessage1, MailMessageFlags.None);
					tvFolders_SelectedIndexChanged(null, null);
				}
			}
		}

		private void btnCopy_Click(object sender, System.EventArgs e) {
			if (!imap41.Active) return;
    
			if (lvMessages.SelectedItems.Count == 1) {
				
				string dest = CopyDlg.ShowCopyDialog(imap41.GetMailBoxes());
				if (dest != "") {
					imap41.CopyMessage(Convert.ToInt32(lvMessages.SelectedItems[0].Text), dest);
					GetFolderList();
				}
			}
		}

		private void btnDelete_Click(object sender, System.EventArgs e) {
			if (!imap41.Active) return;

			if ((tvFolders.SelectedIndex > -1) && (lvMessages.SelectedItems.Count == 1)) {
				imap41.DeleteMessage(Convert.ToInt32(lvMessages.SelectedItems[0].Text));
				tvFolders_SelectedIndexChanged(null, null);
			}
		}

		private void btnPurge_Click(object sender, System.EventArgs e) {
			if (!imap41.Active) return;

			if (tvFolders.SelectedIndex > -1) {
				if (MessageBox.Show("Purge all marked as deleted messages in selected folder ?", "Purge",
					MessageBoxButtons.YesNo) == DialogResult.Yes) {
					imap41.PurgeMessages();
					tvFolders_SelectedIndexChanged(null, null);
				}
			}
		}

		private void tvFolders_SelectedIndexChanged(object sender, System.EventArgs e) {
			if (tvFolders.SelectedIndex < 0) return;

			imap41.SelectMailBox(tvFolders.Items[tvFolders.SelectedIndex].ToString());

			edtSubscribed.Text = subscribeStatus[tvFolders.Items[tvFolders.SelectedIndex]].ToString();
			edtAll.Text = imap41.CurrentMailBox.ExistsMessages.ToString();
			edtRecent.Text = imap41.CurrentMailBox.RecentMessages.ToString();
			edtFirstUnseen.Text = imap41.CurrentMailBox.FirstUnseen.ToString();

			GetMessageList();
		}

		private void GetMessageList() {
			lvMessages.Items.Clear();

			for (int i = 1; i <= imap41.CurrentMailBox.ExistsMessages; i++) {
				imap41.RetrieveHeader(i, mailMessage1);

				ListViewItem item = lvMessages.Items.Add(i.ToString());
				item.SubItems.Add(mailMessage1.Subject);
				item.SubItems.Add(mailMessage1.From.FullAddress);

				MailMessageFlags flags = imap41.GetMessageFlags(i);
				string s = "";

				if ((flags & MailMessageFlags.Answered) == MailMessageFlags.Answered)
					s += "Answered,";
				if ((flags & MailMessageFlags.Flagged) == MailMessageFlags.Flagged)
					s += "Flagged,";
				if ((flags & MailMessageFlags.Deleted) == MailMessageFlags.Deleted)
					s += "Deleted,";
				if ((flags & MailMessageFlags.Seen) == MailMessageFlags.Seen)
					s += "Seen,";
				if ((flags & MailMessageFlags.Draft) == MailMessageFlags.Draft)
					s += "Draft,";
				if ((flags & MailMessageFlags.Recent) == MailMessageFlags.Recent)
					s += "Recent,";

				item.SubItems.Add(s);
			}
		}

		private void lvMessages_DoubleClick(object sender, System.EventArgs e) {
			if (!imap41.Active) return;
    
			if (lvMessages.SelectedItems.Count >0 ) {
				imap41.RetrieveMessage(Convert.ToInt32(lvMessages.SelectedItems[0].Text), mailMessage1);
				imap41.SetMessageFlags(Convert.ToInt32(lvMessages.SelectedItems[0].Text),
					SetFlagsMethod.Add, MailMessageFlags.Seen);

				MessageFrm.ShowMessage(mailMessage1);
				tvFolders_SelectedIndexChanged(null, null);
			}
		}

		private void imap41_CommandSent(object sender, CleverComponents.InetSuite.TcpTextEventArgs e) {
			memLog.Text += e.Text.Trim() + "\r\n";
			memLog.Select(memLog.Text.Length, 0);
			memLog.ScrollToCaret();
		}

		private void imap41_ResponseReceived(object sender, CleverComponents.InetSuite.TcpListEventArgs e) {
			if (e.List.Count > 0) {
				memLog.Text += e.List[0] + "\r\n";
				memLog.Select(memLog.Text.Length, 0);
				memLog.ScrollToCaret();
			}
		}
	}
}
