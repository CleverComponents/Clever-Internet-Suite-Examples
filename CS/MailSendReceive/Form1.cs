using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace MailSendReceive
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox edtUser;
		private System.Windows.Forms.TextBox edtPassword;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox edtPop3Server;
		private System.Windows.Forms.TextBox edtSmtpServer;
		private System.Windows.Forms.Button btnCheckMail;
		private System.Windows.Forms.Button btnComposeMail;
		private System.Windows.Forms.ListBox lbMessages;
		private CleverComponents.InetSuite.Pop3 pop31;
		private CleverComponents.InetSuite.Smtp smtp1;
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.edtPop3Server = new System.Windows.Forms.TextBox();
			this.edtUser = new System.Windows.Forms.TextBox();
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.edtSmtpServer = new System.Windows.Forms.TextBox();
			this.btnComposeMail = new System.Windows.Forms.Button();
			this.btnCheckMail = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.lbMessages = new System.Windows.Forms.ListBox();
			this.pop31 = new CleverComponents.InetSuite.Pop3();
			this.smtp1 = new CleverComponents.InetSuite.Smtp();
			this.mailMessage1 = new CleverComponents.InetSuite.MailMessage();
			((System.ComponentModel.ISupportInitialize)(this.pop31)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.smtp1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "POP server";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "User";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "SMTP server";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(168, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Messages. Double click to view";
			// 
			// edtPop3Server
			// 
			this.edtPop3Server.Location = new System.Drawing.Point(94, 16);
			this.edtPop3Server.Name = "edtPop3Server";
			this.edtPop3Server.Size = new System.Drawing.Size(282, 20);
			this.edtPop3Server.TabIndex = 1;
			this.edtPop3Server.Text = "pop.domain.com";
			// 
			// edtUser
			// 
			this.edtUser.Location = new System.Drawing.Point(94, 64);
			this.edtUser.Name = "edtUser";
			this.edtUser.Size = new System.Drawing.Size(282, 20);
			this.edtUser.TabIndex = 3;
			this.edtUser.Text = "user";
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(94, 88);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.PasswordChar = '*';
			this.edtPassword.Size = new System.Drawing.Size(282, 20);
			this.edtPassword.TabIndex = 4;
			this.edtPassword.Text = "password";
			// 
			// edtSmtpServer
			// 
			this.edtSmtpServer.Location = new System.Drawing.Point(94, 40);
			this.edtSmtpServer.Name = "edtSmtpServer";
			this.edtSmtpServer.Size = new System.Drawing.Size(282, 20);
			this.edtSmtpServer.TabIndex = 2;
			this.edtSmtpServer.Text = "smtp.domain.com";
			// 
			// btnComposeMail
			// 
			this.btnComposeMail.Location = new System.Drawing.Point(213, 120);
			this.btnComposeMail.Name = "btnComposeMail";
			this.btnComposeMail.Size = new System.Drawing.Size(104, 20);
			this.btnComposeMail.TabIndex = 6;
			this.btnComposeMail.Text = "Compose Mail";
			this.btnComposeMail.Click += new System.EventHandler(this.btnComposeMail_Click);
			// 
			// btnCheckMail
			// 
			this.btnCheckMail.Location = new System.Drawing.Point(94, 120);
			this.btnCheckMail.Name = "btnCheckMail";
			this.btnCheckMail.Size = new System.Drawing.Size(104, 20);
			this.btnCheckMail.TabIndex = 5;
			this.btnCheckMail.Text = "Check Mail";
			this.btnCheckMail.Click += new System.EventHandler(this.btnCheckMail_Click);
			// 
			// lbMessages
			// 
			this.lbMessages.Location = new System.Drawing.Point(16, 168);
			this.lbMessages.Name = "lbMessages";
			this.lbMessages.Size = new System.Drawing.Size(360, 147);
			this.lbMessages.TabIndex = 7;
			this.lbMessages.DoubleClick += new System.EventHandler(this.lbMessages_DoubleClick);
			// 
			// mailMessage1
			// 
			this.mailMessage1.Date = new System.DateTime(2006, 5, 4, 23, 33, 9, 265);
			this.mailMessage1.From.Email = "";
			this.mailMessage1.From.Name = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(394, 326);
			this.Controls.Add(this.lbMessages);
			this.Controls.Add(this.btnCheckMail);
			this.Controls.Add(this.btnComposeMail);
			this.Controls.Add(this.edtSmtpServer);
			this.Controls.Add(this.edtPassword);
			this.Controls.Add(this.edtUser);
			this.Controls.Add(this.edtPop3Server);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "SMTP / POP3 client demo";
			((System.ComponentModel.ISupportInitialize)(this.pop31)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.smtp1)).EndInit();
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
			Application.Run(new Form1());
		}

		private void btnCheckMail_Click(object sender, System.EventArgs e) {
			if (smtp1.Active || pop31.Active) return;

			pop31.Server = edtPop3Server.Text;
			pop31.UserName = edtUser.Text;
			pop31.Password = edtPassword.Text;

			try {
				pop31.Open();

				lbMessages.Items.Clear();

				for (int i = 0; i < pop31.MessageCount; i++) {
					pop31.RetrieveHeader(i + 1, mailMessage1);
					if (mailMessage1.Subject == "")
						lbMessages.Items.Add(mailMessage1.From);
					else
						lbMessages.Items.Add(mailMessage1.Subject);
				}

				pop31.Close();

				MessageBox.Show(string.Format("Collecting completed, {0} messages in the mailbox", pop31.MessageCount));
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
				pop31.Close();
			}
		}

		private void btnComposeMail_Click(object sender, System.EventArgs e) {
			if (smtp1.Active || pop31.Active) return;

			MessageFrm dlg = new MessageFrm();

			if (dlg.ShowDialog() == DialogResult.OK) {
				try {
					mailMessage1.BuildMessage(dlg.memBody.Text, "");
					mailMessage1.From.FullAddress = dlg.edtFrom.Text;
					mailMessage1.ToList.EmailAddresses = dlg.edtTo.Text;
					mailMessage1.Subject = dlg.edtSubject.Text;

					smtp1.Server = edtSmtpServer.Text;
					smtp1.UserName = edtUser.Text;
					smtp1.Password = edtPassword.Text;

					smtp1.Open();
					smtp1.Send(mailMessage1);
					smtp1.Close();

					MessageBox.Show("The message was sent successfully");
				}
				catch (Exception ex) {
					MessageBox.Show(ex.Message);
					smtp1.Close();
				}
			}
		}

		private void lbMessages_DoubleClick(object sender, System.EventArgs e) {
			if (pop31.Active || (lbMessages.SelectedIndex < 0)) return;

			pop31.Server = edtPop3Server.Text;
			pop31.UserName = edtUser.Text;
			pop31.Password = edtPassword.Text;

			try {
				pop31.Open();
				pop31.Retrieve(lbMessages.SelectedIndex + 1, mailMessage1);

				MessageFrm dlg = new MessageFrm();

				dlg.edtFrom.Text = mailMessage1.From.FullAddress;
				dlg.edtTo.Text = mailMessage1.ToList.EmailAddresses;
				dlg.edtSubject.Text = mailMessage1.Subject;

				dlg.memBody.Lines = mailMessage1.MessageText;

				dlg.edtFrom.ReadOnly = true;
				dlg.edtTo.ReadOnly = true;
				dlg.edtSubject.ReadOnly = true;
				dlg.memBody.ReadOnly = true;
				dlg.btnSend.Enabled = false;

				dlg.edtFrom.BackColor = SystemColors.Window;
				dlg.edtTo.BackColor = SystemColors.Window;
				dlg.edtSubject.BackColor = SystemColors.Window;
				dlg.memBody.BackColor = SystemColors.Window;

				dlg.ShowDialog();

				pop31.Close();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
				pop31.Close();
			}
		}
	}
}
