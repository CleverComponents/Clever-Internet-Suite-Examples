using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace ImapClientSSL
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox edtPassword;
		private System.Windows.Forms.TextBox edtUser;
		private System.Windows.Forms.TextBox edtServer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edtPort;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox cbUseTLS;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.ListBox tvFolders;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListView lvMessages;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox edtFrom;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox edtSubject;
		private System.Windows.Forms.TextBox memBody;
		private CleverComponents.InetSuite.Imap4 imap41;
		private CleverComponents.InetSuite.MailMessage mailMessage1;
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
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.edtUser = new System.Windows.Forms.TextBox();
			this.edtServer = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.edtPort = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbUseTLS = new System.Windows.Forms.CheckBox();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.tvFolders = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lvMessages = new System.Windows.Forms.ListView();
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label7 = new System.Windows.Forms.Label();
			this.edtFrom = new System.Windows.Forms.TextBox();
			this.edtSubject = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.memBody = new System.Windows.Forms.TextBox();
			this.imap41 = new CleverComponents.InetSuite.Imap4();
			this.mailMessage1 = new CleverComponents.InetSuite.MailMessage();
			((System.ComponentModel.ISupportInitialize)(this.imap41)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).BeginInit();
			this.SuspendLayout();
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(312, 72);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.PasswordChar = '*';
			this.edtPassword.Size = new System.Drawing.Size(104, 20);
			this.edtPassword.TabIndex = 5;
			this.edtPassword.Text = "clevertester";
			// 
			// edtUser
			// 
			this.edtUser.Location = new System.Drawing.Point(60, 72);
			this.edtUser.Name = "edtUser";
			this.edtUser.Size = new System.Drawing.Size(124, 20);
			this.edtUser.TabIndex = 4;
			this.edtUser.Text = "CleverTester";
			// 
			// edtServer
			// 
			this.edtServer.Location = new System.Drawing.Point(60, 16);
			this.edtServer.Name = "edtServer";
			this.edtServer.Size = new System.Drawing.Size(356, 20);
			this.edtServer.TabIndex = 1;
			this.edtServer.Text = "localhost";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(252, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Password";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "User";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Server";
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(60, 40);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(68, 20);
			this.edtPort.TabIndex = 2;
			this.edtPort.Text = "993";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.TabIndex = 12;
			this.label4.Text = "Port";
			// 
			// cbUseTLS
			// 
			this.cbUseTLS.Checked = true;
			this.cbUseTLS.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbUseTLS.Location = new System.Drawing.Point(312, 40);
			this.cbUseTLS.Name = "cbUseTLS";
			this.cbUseTLS.Size = new System.Drawing.Size(104, 24);
			this.cbUseTLS.TabIndex = 3;
			this.cbUseTLS.Text = "Use SSL / TLS";
			// 
			// btnLogout
			// 
			this.btnLogout.Location = new System.Drawing.Point(432, 48);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(96, 23);
			this.btnLogout.TabIndex = 7;
			this.btnLogout.Text = "Logout";
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(432, 16);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(96, 23);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// tvFolders
			// 
			this.tvFolders.Location = new System.Drawing.Point(16, 128);
			this.tvFolders.Name = "tvFolders";
			this.tvFolders.Size = new System.Drawing.Size(152, 264);
			this.tvFolders.TabIndex = 8;
			this.tvFolders.SelectedIndexChanged += new System.EventHandler(this.tvFolders_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 22;
			this.label5.Text = "Imap Folders";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(192, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 23;
			this.label6.Text = "Messages";
			// 
			// lvMessages
			// 
			this.lvMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.lvMessages.FullRowSelect = true;
			this.lvMessages.HideSelection = false;
			this.lvMessages.Location = new System.Drawing.Point(176, 128);
			this.lvMessages.Name = "lvMessages";
			this.lvMessages.Size = new System.Drawing.Size(352, 104);
			this.lvMessages.TabIndex = 9;
			this.lvMessages.UseCompatibleStateImageBehavior = false;
			this.lvMessages.View = System.Windows.Forms.View.Details;
			this.lvMessages.SelectedIndexChanged += new System.EventHandler(this.lvMessages_SelectedIndexChanged);
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
			this.columnHeader4.Text = "Date";
			this.columnHeader4.Width = 80;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Size";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(184, 248);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 23);
			this.label7.TabIndex = 25;
			this.label7.Text = "From";
			// 
			// edtFrom
			// 
			this.edtFrom.Location = new System.Drawing.Point(232, 248);
			this.edtFrom.Name = "edtFrom";
			this.edtFrom.ReadOnly = true;
			this.edtFrom.Size = new System.Drawing.Size(296, 20);
			this.edtFrom.TabIndex = 10;
			// 
			// edtSubject
			// 
			this.edtSubject.Location = new System.Drawing.Point(232, 272);
			this.edtSubject.Name = "edtSubject";
			this.edtSubject.ReadOnly = true;
			this.edtSubject.Size = new System.Drawing.Size(296, 20);
			this.edtSubject.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(184, 272);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 23);
			this.label8.TabIndex = 27;
			this.label8.Text = "Subject";
			// 
			// memBody
			// 
			this.memBody.Location = new System.Drawing.Point(184, 296);
			this.memBody.Multiline = true;
			this.memBody.Name = "memBody";
			this.memBody.ReadOnly = true;
			this.memBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memBody.Size = new System.Drawing.Size(344, 96);
			this.memBody.TabIndex = 12;
			// 
			// imap41
			// 
			this.imap41.VerifyServer += new CleverComponents.InetSuite.VerifyPeerEventHandler(this.imap41_VerifyServer);
			// 
			// mailMessage1
			// 
			this.mailMessage1.Date = new System.DateTime(2007, 1, 10, 13, 51, 45, 827);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(546, 408);
			this.Controls.Add(this.memBody);
			this.Controls.Add(this.edtSubject);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.edtFrom);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lvMessages);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tvFolders);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.cbUseTLS);
			this.Controls.Add(this.edtPort);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.edtPassword);
			this.Controls.Add(this.edtUser);
			this.Controls.Add(this.edtServer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IMAP4 Client with SSL / TLS support";
			((System.ComponentModel.ISupportInitialize)(this.imap41)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).EndInit();
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
			Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(new ExceptionHandler().OnThreadException);
			Application.Run(new Form1());
		}

		bool certificateVerified;

		private void imap41_VerifyServer(object sender, CleverComponents.InetSuite.VerifyPeerEventArgs e) {
			if(!e.Verified) {
				e.Verified = certificateVerified;
			}
			if(!e.Verified && (MessageBox.Show(e.StatusText + "\r\n Do you wish to proceed ?", "Verify certificate",
				MessageBoxButtons.YesNo) == DialogResult.Yes)) {
				e.Verified = true;
				certificateVerified = true;
			}
		}

		private void tvFolders_SelectedIndexChanged(object sender, System.EventArgs e) {
			if (tvFolders.SelectedIndex > -1 && imap41.Active) {
				imap41.SelectMailBox(tvFolders.Items[tvFolders.SelectedIndex].ToString());
			}

			FillMessages();
		}

		private void FillMessages() {
			lvMessages.Items.Clear();
			ClearMessage();

			for (int i = 1; i <= imap41.CurrentMailBox.ExistsMessages; i++) {
				imap41.RetrieveHeader(i, mailMessage1);

				ListViewItem item = lvMessages.Items.Add(mailMessage1.Subject);
				item.SubItems.Add(mailMessage1.From.FullAddress);
				item.SubItems.Add(mailMessage1.Date.ToString());
				item.SubItems.Add(imap41.GetMessageSize(i).ToString());
				item.SubItems.Add(i.ToString());
			}
		}

		private void ClearMessage() {
			edtFrom.Text = "";
			edtSubject.Text = "";
			memBody.Text = "";
		}

		private void btnLogin_Click(object sender, System.EventArgs e) {
			if(imap41.Active) return;

			certificateVerified = false;

			imap41.Server = edtServer.Text;
			imap41.Port = Convert.ToInt32(edtPort.Text);
			imap41.UseTls = cbUseTLS.Checked ? ClientTlsMode.Automatic : ClientTlsMode.None;

			imap41.UserName = edtUser.Text;
			imap41.Password = edtPassword.Text;

			imap41.Open();

			FillFolderList();
		}

		private void FillFolderList() {
			tvFolders.Items.Clear();
			lvMessages.Items.Clear();

			edtFrom.Text = "";
			edtSubject.Text = "";
			memBody.Text = "";

			string[] mailboxes = imap41.GetMailBoxes();

			for (int i = 0; i < mailboxes.Length; i++) {
				string item = mailboxes[i].ToString();
				tvFolders.Items.Add(item);
			}
		}

		private void btnLogout_Click(object sender, System.EventArgs e) {
			imap41.Close();
			tvFolders.Items.Clear();
			lvMessages.Items.Clear();
			ClearMessage();
		}

		private void lvMessages_SelectedIndexChanged(object sender, System.EventArgs e) {
			if (imap41.Active && lvMessages.SelectedItems.Count > 0) {
				imap41.RetrieveMessage(Convert.ToInt32(lvMessages.SelectedItems[0].SubItems[4].Text), mailMessage1);

				edtFrom.Text = mailMessage1.From.FullAddress;
				edtSubject.Text = mailMessage1.Subject;
				memBody.Lines = mailMessage1.MessageText;
			}
			else {
				ClearMessage();
			}
		}
	}

	public class ExceptionHandler {
		public void OnThreadException(object sender, System.Threading.ThreadExceptionEventArgs t) {
			MessageBox.Show(t.Exception.Message);
		}
	}
}
