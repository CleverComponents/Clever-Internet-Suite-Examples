using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace SmtpClientProxy
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox edtPort;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edtPassword;
		private System.Windows.Forms.TextBox edtUser;
		private System.Windows.Forms.TextBox edtServer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox memBody;
		private System.Windows.Forms.TextBox edtSubject;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox edtFrom;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSend;
		private CleverComponents.InetSuite.Smtp smtp1;
		private CleverComponents.InetSuite.MailMessage mailMessage1;
		private System.Windows.Forms.TextBox edtTo;
		private TextBox edtProxyPort;
		private Label label6;
		private TextBox edtProxyServer;
		private Label label9;
		private HttpProxy httpProxy1;

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
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.edtPort = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.edtUser = new System.Windows.Forms.TextBox();
			this.edtServer = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.memBody = new System.Windows.Forms.TextBox();
			this.edtSubject = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.edtFrom = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.edtTo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSend = new System.Windows.Forms.Button();
			this.smtp1 = new CleverComponents.InetSuite.Smtp();
			this.mailMessage1 = new CleverComponents.InetSuite.MailMessage();
			this.edtProxyPort = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.edtProxyServer = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.httpProxy1 = new CleverComponents.InetSuite.HttpProxy();
			((System.ComponentModel.ISupportInitialize)(this.smtp1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).BeginInit();
			this.SuspendLayout();
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(80, 34);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(48, 20);
			this.edtPort.TabIndex = 2;
			this.edtPort.Text = "25";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(9, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.TabIndex = 21;
			this.label4.Text = "Port";
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(80, 86);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.PasswordChar = '*';
			this.edtPassword.Size = new System.Drawing.Size(182, 20);
			this.edtPassword.TabIndex = 5;
			this.edtPassword.Text = "clevertester";
			// 
			// edtUser
			// 
			this.edtUser.Location = new System.Drawing.Point(80, 60);
			this.edtUser.Name = "edtUser";
			this.edtUser.Size = new System.Drawing.Size(182, 20);
			this.edtUser.TabIndex = 4;
			this.edtUser.Text = "CleverTester";
			// 
			// edtServer
			// 
			this.edtServer.Location = new System.Drawing.Point(80, 8);
			this.edtServer.Name = "edtServer";
			this.edtServer.Size = new System.Drawing.Size(209, 20);
			this.edtServer.TabIndex = 1;
			this.edtServer.Text = "smpt.example.com";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(9, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 16);
			this.label3.TabIndex = 20;
			this.label3.Text = "Password";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(9, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 19;
			this.label2.Text = "User";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(9, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 16);
			this.label1.TabIndex = 18;
			this.label1.Text = "SMTP Host";
			// 
			// memBody
			// 
			this.memBody.Location = new System.Drawing.Point(12, 206);
			this.memBody.Multiline = true;
			this.memBody.Name = "memBody";
			this.memBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memBody.Size = new System.Drawing.Size(584, 165);
			this.memBody.TabIndex = 9;
			this.memBody.Text = resources.GetString("memBody.Text");
			// 
			// edtSubject
			// 
			this.edtSubject.Location = new System.Drawing.Point(80, 180);
			this.edtSubject.Name = "edtSubject";
			this.edtSubject.Size = new System.Drawing.Size(516, 20);
			this.edtSubject.TabIndex = 8;
			this.edtSubject.Text = "ABC Company: New Catalog";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(9, 157);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 13);
			this.label8.TabIndex = 39;
			this.label8.Text = "To";
			// 
			// edtFrom
			// 
			this.edtFrom.Location = new System.Drawing.Point(80, 128);
			this.edtFrom.Name = "edtFrom";
			this.edtFrom.Size = new System.Drawing.Size(516, 20);
			this.edtFrom.TabIndex = 6;
			this.edtFrom.Text = "CleverTester@company.mail";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(9, 131);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 16);
			this.label7.TabIndex = 38;
			this.label7.Text = "From";
			// 
			// edtTo
			// 
			this.edtTo.Location = new System.Drawing.Point(80, 154);
			this.edtTo.Name = "edtTo";
			this.edtTo.Size = new System.Drawing.Size(516, 20);
			this.edtTo.TabIndex = 7;
			this.edtTo.Text = "johndoe@domain.com";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(9, 183);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 15);
			this.label5.TabIndex = 41;
			this.label5.Text = "Subject";
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(479, 387);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(117, 23);
			this.btnSend.TabIndex = 10;
			this.btnSend.Text = "Send";
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// smtp1
			// 
			this.smtp1.ConnectTimeOut = 0;
			// 
			// mailMessage1
			// 
			this.mailMessage1.Date = new System.DateTime(2007, 1, 10, 23, 13, 23, 984);
			this.mailMessage1.From.Email = "";
			this.mailMessage1.From.Name = "";
			// 
			// edtProxyPort
			// 
			this.edtProxyPort.Location = new System.Drawing.Point(387, 34);
			this.edtProxyPort.Name = "edtProxyPort";
			this.edtProxyPort.Size = new System.Drawing.Size(48, 20);
			this.edtProxyPort.TabIndex = 43;
			this.edtProxyPort.Text = "8080";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(316, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 16);
			this.label6.TabIndex = 45;
			this.label6.Text = "Port";
			// 
			// edtProxyServer
			// 
			this.edtProxyServer.Location = new System.Drawing.Point(387, 8);
			this.edtProxyServer.Name = "edtProxyServer";
			this.edtProxyServer.Size = new System.Drawing.Size(209, 20);
			this.edtProxyServer.TabIndex = 42;
			this.edtProxyServer.Text = "proxy";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(316, 11);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(63, 16);
			this.label9.TabIndex = 44;
			this.label9.Text = "Proxy Host";
			// 
			// httpProxy1
			// 
			this.httpProxy1.ConnectTimeOut = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(609, 422);
			this.Controls.Add(this.edtProxyPort);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.edtProxyServer);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.edtTo);
			this.Controls.Add(this.memBody);
			this.Controls.Add(this.edtSubject);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.edtFrom);
			this.Controls.Add(this.label7);
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
			this.Text = "SMTP Client over HTTP Connect Proxy";
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
			Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(new ExceptionHandler().OnThreadException);
			Application.Run(new Form1());
		}

		private void btnSend_Click(object sender, System.EventArgs e)
		{
			if (smtp1.Active) return;

			httpProxy1.Server = edtProxyServer.Text;
			httpProxy1.Port = Convert.ToInt32(edtProxyPort.Text);

			smtp1.Proxy = httpProxy1;

			smtp1.Server = edtServer.Text;
			smtp1.Port = Convert.ToInt32(edtPort.Text);
			smtp1.UserName = edtUser.Text;
			smtp1.Password = edtPassword.Text;

			smtp1.Open();
			try
			{
				mailMessage1.BuildMessage(memBody.Text, "");
				mailMessage1.From.FullAddress = edtFrom.Text;
				mailMessage1.ToList.EmailAddresses = edtTo.Text;
				mailMessage1.Subject = edtSubject.Text;

				smtp1.Send(mailMessage1);

				MessageBox.Show("The message was sent successfully.");
			}
			finally
			{
				smtp1.Close();
			}
		}
	}

	public class ExceptionHandler
	{
		public void OnThreadException(object sender, System.Threading.ThreadExceptionEventArgs t)
		{
			MessageBox.Show(t.Exception.Message);
		}
	}
}
