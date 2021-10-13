using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace Pop3ClientSSL
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.CheckBox cbUseTLS;
		private System.Windows.Forms.TextBox edtPort;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edtPassword;
		private System.Windows.Forms.TextBox edtUser;
		private System.Windows.Forms.TextBox edtServer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.TextBox memBody;
		private System.Windows.Forms.TextBox edtSubject;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox edtFrom;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListView lvMessages;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnDelete;
		private CleverComponents.InetSuite.Pop3 pop31;
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
			this.cbUseTLS = new System.Windows.Forms.CheckBox();
			this.edtPort = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.edtUser = new System.Windows.Forms.TextBox();
			this.edtServer = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.memBody = new System.Windows.Forms.TextBox();
			this.edtSubject = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.edtFrom = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lvMessages = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label6 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.pop31 = new CleverComponents.InetSuite.Pop3();
			this.mailMessage1 = new CleverComponents.InetSuite.MailMessage();
			((System.ComponentModel.ISupportInitialize)(this.pop31)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).BeginInit();
			this.SuspendLayout();
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
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(62, 40);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(66, 20);
			this.edtPort.TabIndex = 2;
			this.edtPort.Text = "995";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.TabIndex = 21;
			this.label4.Text = "Port";
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
			this.edtUser.Location = new System.Drawing.Point(62, 72);
			this.edtUser.Name = "edtUser";
			this.edtUser.Size = new System.Drawing.Size(122, 20);
			this.edtUser.TabIndex = 4;
			this.edtUser.Text = "CleverTester";
			// 
			// edtServer
			// 
			this.edtServer.Location = new System.Drawing.Point(62, 16);
			this.edtServer.Name = "edtServer";
			this.edtServer.Size = new System.Drawing.Size(354, 20);
			this.edtServer.TabIndex = 1;
			this.edtServer.Text = "localhost";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(253, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 16);
			this.label3.TabIndex = 20;
			this.label3.Text = "Password";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 19;
			this.label2.Text = "User";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 18;
			this.label1.Text = "Server";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(440, 16);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(96, 23);
			this.btnConnect.TabIndex = 6;
			this.btnConnect.Text = "Connect";
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Location = new System.Drawing.Point(440, 64);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(96, 23);
			this.btnDisconnect.TabIndex = 7;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
			// 
			// memBody
			// 
			this.memBody.Location = new System.Drawing.Point(16, 272);
			this.memBody.Multiline = true;
			this.memBody.Name = "memBody";
			this.memBody.ReadOnly = true;
			this.memBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memBody.Size = new System.Drawing.Size(520, 96);
			this.memBody.TabIndex = 13;
			// 
			// edtSubject
			// 
			this.edtSubject.Location = new System.Drawing.Point(72, 248);
			this.edtSubject.Name = "edtSubject";
			this.edtSubject.ReadOnly = true;
			this.edtSubject.Size = new System.Drawing.Size(464, 20);
			this.edtSubject.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 248);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 23);
			this.label8.TabIndex = 34;
			this.label8.Text = "Subject";
			// 
			// edtFrom
			// 
			this.edtFrom.Location = new System.Drawing.Point(72, 224);
			this.edtFrom.Name = "edtFrom";
			this.edtFrom.ReadOnly = true;
			this.edtFrom.Size = new System.Drawing.Size(464, 20);
			this.edtFrom.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 224);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 23);
			this.label7.TabIndex = 33;
			this.label7.Text = "From";
			// 
			// lvMessages
			// 
			this.lvMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
			this.lvMessages.FullRowSelect = true;
			this.lvMessages.HideSelection = false;
			this.lvMessages.Location = new System.Drawing.Point(16, 128);
			this.lvMessages.Name = "lvMessages";
			this.lvMessages.Size = new System.Drawing.Size(400, 88);
			this.lvMessages.TabIndex = 8;
			this.lvMessages.UseCompatibleStateImageBehavior = false;
			this.lvMessages.View = System.Windows.Forms.View.Details;
			this.lvMessages.SelectedIndexChanged += new System.EventHandler(this.lvMessages_SelectedIndexChanged);
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "From";
			this.columnHeader3.Width = 120;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Subject";
			this.columnHeader2.Width = 120;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Date";
			this.columnHeader4.Width = 80;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "UID";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 32;
			this.label6.Text = "Messages";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(440, 136);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(96, 23);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "Delete Message";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// pop31
			// 
			this.pop31.VerifyServer += new CleverComponents.InetSuite.VerifyPeerEventHandler(this.pop31_VerifyServer);
			// 
			// mailMessage1
			// 
			this.mailMessage1.Date = new System.DateTime(2007, 1, 10, 21, 6, 40, 109);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(560, 376);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.memBody);
			this.Controls.Add(this.edtSubject);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.edtFrom);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lvMessages);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnDisconnect);
			this.Controls.Add(this.btnConnect);
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
			this.Text = "POP3 Client with SSL / TLS support";
			((System.ComponentModel.ISupportInitialize)(this.pop31)).EndInit();
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
		bool processing = false;

		private void lvMessages_SelectedIndexChanged(object sender, System.EventArgs e) {
			lock (this) {
				if (processing) return;
				processing = true;
				try {
					if (pop31.Active && lvMessages.SelectedItems.Count > 0) {
						pop31.Retrieve(Convert.ToInt32(lvMessages.SelectedItems[0].SubItems[4].Text) + 1, mailMessage1);

						edtFrom.Text = mailMessage1.From.FullAddress;
						edtSubject.Text = mailMessage1.Subject;
						memBody.Lines = mailMessage1.MessageText;
					}
					else {
						ClearMessage();
					}
				}
				finally {
					processing = false;
				}
			}
		}

		private void btnConnect_Click(object sender, System.EventArgs e) {
			if(pop31.Active) return;

			certificateVerified = false;

			pop31.Server = edtServer.Text;
			pop31.Port = Convert.ToInt32(edtPort.Text);
			pop31.UserName = edtUser.Text;
			pop31.Password = edtPassword.Text;
			pop31.UseTls = cbUseTLS.Checked ? ClientTlsMode.Automatic : ClientTlsMode.None;
			pop31.TimeOut = 5000;

			pop31.Open();

			FillMessages();
		}

		private void FillMessages() {
			lvMessages.Items.Clear();
			ClearMessage();

			for(int i = 0; i < pop31.MessageCount; i++) {
				pop31.RetrieveHeader(i + 1, mailMessage1);

				ListViewItem item = lvMessages.Items.Add(mailMessage1.From.FullAddress);
				item.SubItems.Add(mailMessage1.Subject);
				item.SubItems.Add(mailMessage1.Date.ToString());
				item.SubItems.Add(pop31.GetUID(i + 1).ToString());
				item.SubItems.Add(i.ToString());
			}
		}

		private void ClearMessage() {
			edtFrom.Text = "";
			edtSubject.Text = "";
			memBody.Text = "";
		}

		private void btnDisconnect_Click(object sender, System.EventArgs e) {
			lvMessages.Items.Clear();
			ClearMessage();
			pop31.Close();
		}

		private void btnDelete_Click(object sender, System.EventArgs e) {
			if (pop31.Active && lvMessages.SelectedItems.Count > 0) {
				int ind = Convert.ToInt32(lvMessages.SelectedItems[0].SubItems[4].Text);
				pop31.Delete(ind + 1);
				lvMessages.Items.RemoveAt(ind);
			}
		}

		private void pop31_VerifyServer(object sender, CleverComponents.InetSuite.VerifyPeerEventArgs e) {
			if(!e.Verified) {
				e.Verified = certificateVerified;
			}
			if(!e.Verified && (MessageBox.Show(e.StatusText + "\r\n Do you wish to proceed ?", "Verify certificate",
				MessageBoxButtons.YesNo) == DialogResult.Yes)) {
				e.Verified = true;
				certificateVerified = true;
			}
		}
	}

	public class ExceptionHandler {
		public void OnThreadException(object sender, System.Threading.ThreadExceptionEventArgs t) {
			MessageBox.Show(t.Exception.Message);
		}
	}
}
