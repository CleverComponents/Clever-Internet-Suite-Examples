using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace HttpClientSSL
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edtUrl;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox cbShowText;
		private System.Windows.Forms.TextBox memResult;
		private CleverComponents.InetSuite.Http http1;
		private CleverComponents.InetSuite.HtmlParser htmlParser1;
		private System.Windows.Forms.TextBox edtPassword;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox edtUser;
		private System.Windows.Forms.Label label7;
		private CleverComponents.InetSuite.CertificateStore certificateStore1;
		private CleverComponents.InetSuite.CertificateStore clientCertificateStore;
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
			this.edtUrl = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.cbShowText = new System.Windows.Forms.CheckBox();
			this.memResult = new System.Windows.Forms.TextBox();
			this.http1 = new CleverComponents.InetSuite.Http();
			this.htmlParser1 = new CleverComponents.InetSuite.HtmlParser();
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.edtUser = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.certificateStore1 = new CleverComponents.InetSuite.CertificateStore();
			this.clientCertificateStore = new CleverComponents.InetSuite.CertificateStore();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(424, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Type in the URL and click the \'GET\' button to retreive the page specified by URL." +
    "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "URL";
			// 
			// edtUrl
			// 
			this.edtUrl.Location = new System.Drawing.Point(56, 40);
			this.edtUrl.Name = "edtUrl";
			this.edtUrl.Size = new System.Drawing.Size(304, 20);
			this.edtUrl.TabIndex = 2;
			this.edtUrl.Text = "https://www.paypal.com";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(368, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "GET";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cbShowText
			// 
			this.cbShowText.Location = new System.Drawing.Point(56, 96);
			this.cbShowText.Name = "cbShowText";
			this.cbShowText.Size = new System.Drawing.Size(104, 24);
			this.cbShowText.TabIndex = 6;
			this.cbShowText.Text = "Show text only";
			// 
			// memResult
			// 
			this.memResult.BackColor = System.Drawing.SystemColors.Window;
			this.memResult.Location = new System.Drawing.Point(0, 128);
			this.memResult.Multiline = true;
			this.memResult.Name = "memResult";
			this.memResult.ReadOnly = true;
			this.memResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memResult.Size = new System.Drawing.Size(448, 232);
			this.memResult.TabIndex = 7;
			// 
			// http1
			// 
			this.http1.CharSet = null;
			this.http1.GetCertificate += new CleverComponents.InetSuite.GetCertificateEventHandler(this.http1_GetCertificate);
			this.http1.VerifyServer += new CleverComponents.InetSuite.VerifyPeerEventHandler(this.http1_VerifyServer);
			// 
			// htmlParser1
			// 
			this.htmlParser1.ParseMethod = CleverComponents.InetSuite.ParseMethod.TextOnly;
			this.htmlParser1.ParseTag += new CleverComponents.InetSuite.ParseTagEventHandler(this.htmlParser1_ParseTag);
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(248, 64);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.PasswordChar = '*';
			this.edtPassword.Size = new System.Drawing.Size(112, 20);
			this.edtPassword.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(184, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 16);
			this.label8.TabIndex = 21;
			this.label8.Text = "Password";
			// 
			// edtUser
			// 
			this.edtUser.Location = new System.Drawing.Point(56, 64);
			this.edtUser.Name = "edtUser";
			this.edtUser.Size = new System.Drawing.Size(104, 20);
			this.edtUser.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 16);
			this.label7.TabIndex = 20;
			this.label7.Text = "User";
			// 
			// certificateStore1
			// 
			this.certificateStore1.ValidFrom = new System.DateTime(2020, 3, 8, 21, 12, 21, 90);
			this.certificateStore1.ValidTo = new System.DateTime(2021, 3, 8, 21, 12, 21, 90);
			// 
			// clientCertificateStore
			// 
			this.clientCertificateStore.ValidFrom = new System.DateTime(2020, 3, 8, 21, 12, 21, 95);
			this.clientCertificateStore.ValidTo = new System.DateTime(2021, 3, 8, 21, 12, 21, 95);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 358);
			this.Controls.Add(this.edtPassword);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.edtUser);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.memResult);
			this.Controls.Add(this.cbShowText);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.edtUrl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HTTPS GET demo";
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

		private void button1_Click(object sender, System.EventArgs e) {
			memResult.Text = "";

			try {
				http1.UserName = edtUser.Text;
				http1.Password = edtPassword.Text;

				if(cbShowText.Checked)
					htmlParser1.Parse(http1.Get(edtUrl.Text));
				else
					memResult.Text = http1.Get(edtUrl.Text);
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void htmlParser1_ParseTag(object sender, CleverComponents.InetSuite.ParseTagEventArgs e) {
			if(e.Tag.Text.Trim() != "")
				memResult.Text += e.Tag.Text;
		}

		private bool ViewCertificate(Certificate certificate) {
			CertForm dlg = new CertForm();
			dlg.edtName.Text = certificate.FriendlyName;
			dlg.edtIssuedTo.Text = certificate.IssuedTo;
			dlg.edtIssuedBy.Text = certificate.IssuedBy;
			dlg.edtValidFrom.Text = certificate.ValidFrom.ToString();
			dlg.edtValidTo.Text = certificate.ValidTo.ToString();

			DialogResult result = dlg.ShowDialog();
			if(result == DialogResult.Yes) {
				Certificate newInstance = certificate.Clone();
				certificateStore1.Items.Add(newInstance);
				certificateStore1.StoreName = "CA";
				certificateStore1.Install(newInstance);
				MessageBox.Show("The certificate was installed successfully to "
					+ "Intermediate Certification Authorities (CA).\r\nPress OK to continue.");
			}
			return (result == DialogResult.OK) || (result == DialogResult.Yes);
		}

		private void http1_VerifyServer(object sender, CleverComponents.InetSuite.VerifyPeerEventArgs e) {
			if(!e.Verified && (MessageBox.Show(e.StatusText + "\r\n Do you wish to view / install the certificate ?", "Certificate confirmation",
				MessageBoxButtons.YesNo) == DialogResult.Yes)) {
				if(ViewCertificate(e.Certificate)) {
					e.Verified = true;
				}
			}
		}

		private void http1_GetCertificate(object sender, CleverComponents.InetSuite.GetCertificateEventArgs e) {
			clientCertificateStore.Close();
			clientCertificateStore.Open("MY");

			SelectCertificateForm dlg = new SelectCertificateForm();

			foreach(Certificate cert in clientCertificateStore.Items) {
				dlg.listBox1.Items.Add(cert.IssuedTo);
			}

			if(dlg.ShowDialog() == DialogResult.OK) {
				e.Certificate = clientCertificateStore.Items[dlg.listBox1.SelectedIndex];
			}
			e.Handled = true;
		}
	}
}
