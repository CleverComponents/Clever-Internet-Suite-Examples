using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace SmtpRelay
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
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox edtDNS;
		private System.Windows.Forms.TextBox edtDNSTimeOut;
		private System.Windows.Forms.TextBox edtSender;
		private System.Windows.Forms.TextBox edtRecipient;
		private System.Windows.Forms.TextBox edtSubject;
		private System.Windows.Forms.TextBox memText;
		private System.Windows.Forms.Button btnSend;
		private CleverComponents.InetSuite.SmtpRelay smtpRelay1;
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
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.edtDNS = new System.Windows.Forms.TextBox();
			this.edtDNSTimeOut = new System.Windows.Forms.TextBox();
			this.edtSender = new System.Windows.Forms.TextBox();
			this.edtRecipient = new System.Windows.Forms.TextBox();
			this.edtSubject = new System.Windows.Forms.TextBox();
			this.memText = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.smtpRelay1 = new CleverComponents.InetSuite.SmtpRelay();
			this.mailMessage1 = new CleverComponents.InetSuite.MailMessage();
			((System.ComponentModel.ISupportInitialize)(this.smtpRelay1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(384, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "This demo creates e-mail and sends it directly to the recipient\'s server.";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(400, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Please specify the DNS server IP which will be used for resolving the SMTP server" +
				" address of the recipient";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(392, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "Please note ! Most SMTP servers require that the sender PC must be registered in " +
				"DNS. Otherwise, relaying will be denied to such SMTP servers.";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "DNS server IP";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Sender email";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 179);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Recipinets";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 203);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "Subject of message";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 224);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 16);
			this.label8.TabIndex = 7;
			this.label8.Text = "Message text";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(255, 131);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 16);
			this.label9.TabIndex = 8;
			this.label9.Text = "DNS TimeOut, s";
			// 
			// edtDNS
			// 
			this.edtDNS.Location = new System.Drawing.Point(120, 128);
			this.edtDNS.Name = "edtDNS";
			this.edtDNS.Size = new System.Drawing.Size(100, 20);
			this.edtDNS.TabIndex = 9;
			this.edtDNS.Text = "192.168.0.1";
			// 
			// edtDNSTimeOut
			// 
			this.edtDNSTimeOut.Location = new System.Drawing.Point(344, 128);
			this.edtDNSTimeOut.Name = "edtDNSTimeOut";
			this.edtDNSTimeOut.Size = new System.Drawing.Size(56, 20);
			this.edtDNSTimeOut.TabIndex = 10;
			this.edtDNSTimeOut.Text = "5";
			// 
			// edtSender
			// 
			this.edtSender.Location = new System.Drawing.Point(120, 152);
			this.edtSender.Name = "edtSender";
			this.edtSender.Size = new System.Drawing.Size(280, 20);
			this.edtSender.TabIndex = 11;
			this.edtSender.Text = "CleverTester@company.mail";
			// 
			// edtRecipient
			// 
			this.edtRecipient.Location = new System.Drawing.Point(120, 176);
			this.edtRecipient.Name = "edtRecipient";
			this.edtRecipient.Size = new System.Drawing.Size(280, 20);
			this.edtRecipient.TabIndex = 12;
			this.edtRecipient.Text = "john@domain.com,alex@company.mail";
			// 
			// edtSubject
			// 
			this.edtSubject.Location = new System.Drawing.Point(120, 200);
			this.edtSubject.Name = "edtSubject";
			this.edtSubject.Size = new System.Drawing.Size(280, 20);
			this.edtSubject.TabIndex = 13;
			this.edtSubject.Text = "smtp relaying test";
			// 
			// memText
			// 
			this.memText.Location = new System.Drawing.Point(16, 240);
			this.memText.Multiline = true;
			this.memText.Name = "memText";
			this.memText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memText.Size = new System.Drawing.Size(384, 128);
			this.memText.TabIndex = 14;
			this.memText.Text = "This is a test message";
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(136, 376);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(136, 23);
			this.btnSend.TabIndex = 15;
			this.btnSend.Text = "Send Mail";
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// smtpRelay1
			// 
			this.smtpRelay1.DnsServer = null;
			// 
			// mailMessage1
			// 
			this.mailMessage1.Date = new System.DateTime(2006, 5, 5, 17, 45, 14, 968);
			this.mailMessage1.From.Email = "";
			this.mailMessage1.From.Name = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(424, 414);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.memText);
			this.Controls.Add(this.edtSubject);
			this.Controls.Add(this.edtRecipient);
			this.Controls.Add(this.edtSender);
			this.Controls.Add(this.edtDNSTimeOut);
			this.Controls.Add(this.edtDNS);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "SMTP Relay demo";
			((System.ComponentModel.ISupportInitialize)(this.smtpRelay1)).EndInit();
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

		private void btnSend_Click(object sender, System.EventArgs e) {
			btnSend.Enabled = false;
			try {
				mailMessage1.BuildMessage(memText.Text, "");
				mailMessage1.From.FullAddress = edtSender.Text;
				mailMessage1.ToList.EmailAddresses = edtRecipient.Text;
				mailMessage1.Subject = edtSubject.Text;

				smtpRelay1.DnsServer = edtDNS.Text;
				smtpRelay1.TimeOut = Convert.ToInt32(edtDNSTimeOut.Text) * 1000;
				smtpRelay1.Send(mailMessage1);

				ShowResults();
			}
			finally {
				btnSend.Enabled = true;
			}
		}

		private void ShowResults() {
			RelayStatusForm dlg = new RelayStatusForm();

			foreach (SmtpRelayStatus item in smtpRelay1.StatusList) {
				dlg.textBox1.Text += "======  " + item.Domain + "  ======\r\n";
				dlg.textBox1.Text += "Mail server: " + item.MailServer + "\r\n";
				dlg.textBox1.Text += "Status: " + (item.IsSent ? "Sent" : "Not Sent") + "\r\n";
				dlg.textBox1.Text += "Server response: " + item.ResponseText + "\r\n";
				dlg.textBox1.Text += "Error: " + item.ErrorText + "\r\n\r\n";
			}

			dlg.ShowDialog();
		}
	}

	public class ExceptionHandler {
		public void OnThreadException(object sender, System.Threading.ThreadExceptionEventArgs t) {
			MessageBox.Show(t.Exception.Message);
		}
	}
}
