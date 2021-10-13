using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace MailProgress
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
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.TextBox edtServer;
		private System.Windows.Forms.TextBox edtUser;
		private System.Windows.Forms.TextBox edtPassword;
		private System.Windows.Forms.TextBox edtFrom;
		private System.Windows.Forms.TextBox edtTo;
		private System.Windows.Forms.TextBox memBody;
		private System.Windows.Forms.Label lblProgress;
		private System.Windows.Forms.TextBox edtAttachment;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Button btnReceive;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
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
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblProgress = new System.Windows.Forms.Label();
			this.edtServer = new System.Windows.Forms.TextBox();
			this.edtUser = new System.Windows.Forms.TextBox();
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.edtFrom = new System.Windows.Forms.TextBox();
			this.edtTo = new System.Windows.Forms.TextBox();
			this.memBody = new System.Windows.Forms.TextBox();
			this.edtAttachment = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnSend = new System.Windows.Forms.Button();
			this.btnReceive = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
			this.label1.Text = "Server";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "User";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "From";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 115);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "To";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Message";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 235);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 17);
			this.label7.TabIndex = 6;
			this.label7.Text = "Attachment";
			// 
			// lblProgress
			// 
			this.lblProgress.Location = new System.Drawing.Point(16, 296);
			this.lblProgress.Name = "lblProgress";
			this.lblProgress.Size = new System.Drawing.Size(48, 16);
			this.lblProgress.TabIndex = 7;
			this.lblProgress.Text = "%";
			// 
			// edtServer
			// 
			this.edtServer.Location = new System.Drawing.Point(80, 16);
			this.edtServer.Name = "edtServer";
			this.edtServer.Size = new System.Drawing.Size(272, 20);
			this.edtServer.TabIndex = 8;
			this.edtServer.Text = "localhost";
			// 
			// edtUser
			// 
			this.edtUser.Location = new System.Drawing.Point(80, 40);
			this.edtUser.Name = "edtUser";
			this.edtUser.Size = new System.Drawing.Size(120, 20);
			this.edtUser.TabIndex = 9;
			this.edtUser.Text = "CleverTester";
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(80, 64);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.PasswordChar = '*';
			this.edtPassword.Size = new System.Drawing.Size(120, 20);
			this.edtPassword.TabIndex = 10;
			this.edtPassword.Text = "clevertester";
			// 
			// edtFrom
			// 
			this.edtFrom.Location = new System.Drawing.Point(80, 88);
			this.edtFrom.Name = "edtFrom";
			this.edtFrom.Size = new System.Drawing.Size(272, 20);
			this.edtFrom.TabIndex = 11;
			this.edtFrom.Text = "CleverTester@company.mail";
			// 
			// edtTo
			// 
			this.edtTo.Location = new System.Drawing.Point(80, 112);
			this.edtTo.Name = "edtTo";
			this.edtTo.Size = new System.Drawing.Size(272, 20);
			this.edtTo.TabIndex = 12;
			this.edtTo.Text = "CleverTester@company.mail";
			// 
			// memBody
			// 
			this.memBody.Location = new System.Drawing.Point(80, 136);
			this.memBody.Multiline = true;
			this.memBody.Name = "memBody";
			this.memBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memBody.Size = new System.Drawing.Size(272, 88);
			this.memBody.TabIndex = 13;
			this.memBody.Text = "Message text follows here";
			// 
			// edtAttachment
			// 
			this.edtAttachment.Location = new System.Drawing.Point(80, 232);
			this.edtAttachment.Name = "edtAttachment";
			this.edtAttachment.Size = new System.Drawing.Size(232, 20);
			this.edtAttachment.TabIndex = 14;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(320, 232);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(32, 23);
			this.btnBrowse.TabIndex = 15;
			this.btnBrowse.Text = "...";
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(80, 264);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 16;
			this.btnSend.Text = "Send";
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// btnReceive
			// 
			this.btnReceive.Location = new System.Drawing.Point(176, 264);
			this.btnReceive.Name = "btnReceive";
			this.btnReceive.Size = new System.Drawing.Size(75, 23);
			this.btnReceive.TabIndex = 17;
			this.btnReceive.Text = "Receive";
			this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(277, 264);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 18;
			this.btnStop.Text = "Stop";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(64, 296);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(288, 16);
			this.progressBar1.TabIndex = 19;
			// 
			// pop31
			// 
			this.pop31.Progress += new CleverComponents.InetSuite.ProgressEventHandler(this.pop31_Progress);
			// 
			// smtp1
			// 
			this.smtp1.Progress += new CleverComponents.InetSuite.ProgressEventHandler(this.smtp1_Progress);
			// 
			// mailMessage1
			// 
			this.mailMessage1.Date = new System.DateTime(2006, 5, 4, 22, 40, 1, 608);
			this.mailMessage1.SaveAttachment += new CleverComponents.InetSuite.GetBodyStreamEventHandler(this.mailMessage1_SaveAttachment);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(368, 326);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnReceive);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.edtAttachment);
			this.Controls.Add(this.memBody);
			this.Controls.Add(this.edtTo);
			this.Controls.Add(this.edtFrom);
			this.Controls.Add(this.edtPassword);
			this.Controls.Add(this.edtUser);
			this.Controls.Add(this.edtServer);
			this.Controls.Add(this.lblProgress);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mail Send / Receive Progress";
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

		private void btnSend_Click(object sender, System.EventArgs e) {
			if (smtp1.Active || pop31.Active) {
				MessageBox.Show("Message sending / retrieving is in progress");
				return;
			}

			if (StringUtils.IsEmpty(edtAttachment.Text)) {
				mailMessage1.BuildMessage(memBody.Text, String.Empty);
			}
			else {
				mailMessage1.BuildMessage(memBody.Text, new string[] { edtAttachment.Text });
			}

			mailMessage1.Subject = "Message Subject";
			mailMessage1.From.FullAddress = edtFrom.Text;
			mailMessage1.ToList.EmailAddresses = edtTo.Text;

			progressBar1.Value = 0;
			lblProgress.Text = "%";

			smtp1.Server = edtServer.Text;
			smtp1.UserName = edtUser.Text;
			smtp1.Password = edtPassword.Text;

			try {
				smtp1.Open();
				smtp1.Send(mailMessage1);
				smtp1.Close();

				lblProgress.Text = "100 %";

				MessageBox.Show("Done");
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
				smtp1.Close();
			}
		}

		private void btnReceive_Click(object sender, System.EventArgs e) {
			if (smtp1.Active || pop31.Active) {
				MessageBox.Show("Message sending / retrieving is in progress");
				return;
			}

			progressBar1.Value = 0;
			lblProgress.Text = "%";

			pop31.Server = edtServer.Text;
			pop31.UserName = edtUser.Text;
			pop31.Password = edtPassword.Text;

			try {
				pop31.Open();

				if (pop31.MessageCount == 0) {
					MessageBox.Show("There are no messages in the mailbox");
					pop31.Close();
					return;
				}

				pop31.Retrieve(1, mailMessage1); //retrieve first mail message

				edtFrom.Text = mailMessage1.From.FullAddress;
				edtTo.Text = mailMessage1.ToList.EmailAddresses;
				memBody.Lines = mailMessage1.MessageText;

				pop31.Close();

				lblProgress.Text = "100 %";
				MessageBox.Show(String.Format("The first message was received. Total messages: {0}", pop31.MessageCount));
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
				pop31.Close();
			}
		}

		private void btnStop_Click(object sender, System.EventArgs e) {
			smtp1.Close();
			pop31.Close();
		}

		private void btnBrowse_Click(object sender, System.EventArgs e) {
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
				edtAttachment.Text = openFileDialog1.FileName;
		}

		private void pop31_Progress(object sender, CleverComponents.InetSuite.ProgressEventArgs e) {
			if (e.TotalBytes < e.BytesProceed) return;

			progressBar1.Maximum = (int)e.TotalBytes;
			progressBar1.Value = (int)e.BytesProceed;
			decimal d = System.Math.Round((decimal)(progressBar1.Value * 100 / progressBar1.Maximum));
			lblProgress.Text = string.Format("{0} %", d.ToString());
			Application.DoEvents();
		}

		private void smtp1_Progress(object sender, CleverComponents.InetSuite.ProgressEventArgs e) {
			if (e.TotalBytes < e.BytesProceed) return;

			progressBar1.Maximum = (int)e.TotalBytes;
			progressBar1.Value = (int)e.BytesProceed;
			decimal d = System.Math.Round((decimal)(progressBar1.Value * 100 / progressBar1.Maximum));
			lblProgress.Text = string.Format("{0} %", d.ToString());
			Application.DoEvents();
		}

		private void mailMessage1_SaveAttachment(object sender, CleverComponents.InetSuite.GetBodyStreamEventArgs e) {
			edtAttachment.Text = e.Body.FileName;
		}
	}
}
