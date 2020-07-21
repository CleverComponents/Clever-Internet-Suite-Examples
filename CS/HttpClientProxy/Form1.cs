using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace HttpClientProxy
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
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox edtProxyServer;
		private System.Windows.Forms.TextBox edtProxyUser;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox edtProxyPort;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox edtProxyPassword;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox edtUser;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox edtPassword;
		private CleverComponents.InetSuite.Http http1;
		private CleverComponents.InetSuite.HtmlParser htmlParser1;
		private Label label9;
		private ComboBox cbProxyType;
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

			cbProxyType.SelectedIndex = 0;
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
			this.label3 = new System.Windows.Forms.Label();
			this.edtProxyServer = new System.Windows.Forms.TextBox();
			this.edtProxyUser = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.edtProxyPort = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.edtProxyPassword = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.edtUser = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.http1 = new CleverComponents.InetSuite.Http();
			this.htmlParser1 = new CleverComponents.InetSuite.HtmlParser();
			this.label9 = new System.Windows.Forms.Label();
			this.cbProxyType = new System.Windows.Forms.ComboBox();
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
			this.edtUrl.Text = "http://www.microsoft.com";
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
			this.cbShowText.Location = new System.Drawing.Point(56, 175);
			this.cbShowText.Name = "cbShowText";
			this.cbShowText.Size = new System.Drawing.Size(104, 24);
			this.cbShowText.TabIndex = 10;
			this.cbShowText.Text = "Show text only";
			// 
			// memResult
			// 
			this.memResult.BackColor = System.Drawing.SystemColors.Window;
			this.memResult.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.memResult.Location = new System.Drawing.Point(0, 214);
			this.memResult.Multiline = true;
			this.memResult.Name = "memResult";
			this.memResult.ReadOnly = true;
			this.memResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memResult.Size = new System.Drawing.Size(448, 212);
			this.memResult.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Poxy Server";
			// 
			// edtProxyServer
			// 
			this.edtProxyServer.Location = new System.Drawing.Point(88, 127);
			this.edtProxyServer.Name = "edtProxyServer";
			this.edtProxyServer.Size = new System.Drawing.Size(176, 20);
			this.edtProxyServer.TabIndex = 6;
			this.edtProxyServer.Text = "proxyserver";
			// 
			// edtProxyUser
			// 
			this.edtProxyUser.Location = new System.Drawing.Point(88, 151);
			this.edtProxyUser.Name = "edtProxyUser";
			this.edtProxyUser.Size = new System.Drawing.Size(100, 20);
			this.edtProxyUser.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 151);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "Proxy User";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(200, 151);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 16);
			this.label5.TabIndex = 12;
			this.label5.Text = "Proxy Password";
			// 
			// edtProxyPort
			// 
			this.edtProxyPort.Location = new System.Drawing.Point(368, 127);
			this.edtProxyPort.Name = "edtProxyPort";
			this.edtProxyPort.Size = new System.Drawing.Size(56, 20);
			this.edtProxyPort.TabIndex = 7;
			this.edtProxyPort.Text = "8080";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(288, 127);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.TabIndex = 14;
			this.label6.Text = "Proxy Port";
			// 
			// edtProxyPassword
			// 
			this.edtProxyPassword.Location = new System.Drawing.Point(288, 151);
			this.edtProxyPassword.Name = "edtProxyPassword";
			this.edtProxyPassword.PasswordChar = '*';
			this.edtProxyPassword.Size = new System.Drawing.Size(136, 20);
			this.edtProxyPassword.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 16);
			this.label7.TabIndex = 15;
			this.label7.Text = "User";
			// 
			// edtUser
			// 
			this.edtUser.Location = new System.Drawing.Point(56, 64);
			this.edtUser.Name = "edtUser";
			this.edtUser.Size = new System.Drawing.Size(104, 20);
			this.edtUser.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(184, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 16);
			this.label8.TabIndex = 17;
			this.label8.Text = "Password";
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(248, 64);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.PasswordChar = '*';
			this.edtPassword.Size = new System.Drawing.Size(112, 20);
			this.edtPassword.TabIndex = 5;
			// 
			// http1
			// 
			this.http1.Port = 80;
			this.http1.TlsFlags = ((CleverComponents.InetSuite.Sspi.TlsFlags)((CleverComponents.InetSuite.Sspi.TlsFlags.UseSSL2 | CleverComponents.InetSuite.Sspi.TlsFlags.UseSSL3)));
			// 
			// htmlParser1
			// 
			this.htmlParser1.ParseMethod = CleverComponents.InetSuite.ParseMethod.TextOnly;
			this.htmlParser1.ParseTag += new CleverComponents.InetSuite.ParseTagEventHandler(this.htmlParser1_ParseTag);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(16, 104);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "Proxy Type";
			// 
			// cbProxyType
			// 
			this.cbProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbProxyType.FormattingEnabled = true;
			this.cbProxyType.Items.AddRange(new object[] {
            "HTTP Proxy",
            "SOCKS4 Firewall",
            "SOCKS5 Firewall"});
			this.cbProxyType.Location = new System.Drawing.Point(88, 101);
			this.cbProxyType.Name = "cbProxyType";
			this.cbProxyType.Size = new System.Drawing.Size(176, 21);
			this.cbProxyType.TabIndex = 19;
			this.cbProxyType.SelectedIndexChanged += new System.EventHandler(this.cbProxyType_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 426);
			this.Controls.Add(this.cbProxyType);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.edtPassword);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.edtUser);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.edtProxyPassword);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.edtProxyPort);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.edtProxyUser);
			this.Controls.Add(this.edtProxyServer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.memResult);
			this.Controls.Add(this.cbShowText);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.edtUrl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "HTTP GET demo";
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

			http1.UserName = edtUser.Text;
			http1.Password = edtPassword.Text;

			http1.FirewallSettings.Server = "";
			http1.ProxySettings.Server = "";

			if (cbProxyType.SelectedIndex == 0) {
				http1.ProxySettings.Server = edtProxyServer.Text;
				http1.ProxySettings.Port = Convert.ToInt32(edtProxyPort.Text);
				http1.ProxySettings.UserName = edtProxyUser.Text;
				http1.ProxySettings.Password = edtProxyPassword.Text;
			}
			else {
				if (cbProxyType.SelectedIndex == 1) {
					http1.FirewallSettings.FirewallType = FirewallType.Socks4;
				}
				else {
					http1.FirewallSettings.FirewallType = FirewallType.Socks5;
				}

				http1.FirewallSettings.Server = edtProxyServer.Text;
				http1.FirewallSettings.Port = Convert.ToInt32(edtProxyPort.Text);
				http1.FirewallSettings.UserName = edtProxyUser.Text;
				http1.FirewallSettings.Password = edtProxyPassword.Text;
			}

			try {
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

		private void cbProxyType_SelectedIndexChanged(object sender, EventArgs e) {
			if (cbProxyType.SelectedIndex == 0) {
				edtProxyPort.Text = "8080";
			}
			else {
				edtProxyPort.Text = "1080";
			}
		}
	}
}
