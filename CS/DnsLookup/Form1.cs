using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace DnsLookup
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
		private System.Windows.Forms.TextBox edtTimeOut;
		private System.Windows.Forms.TextBox edtDnsServer;
		private System.Windows.Forms.TextBox edtName;
		private System.Windows.Forms.ComboBox cbNameType;
		private System.Windows.Forms.Button btnResolve;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox memResult;
		private CleverComponents.InetSuite.DnsQuery dnsQuery1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox edtPort;
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

			cbNameType.SelectedIndex = 0;
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
			this.edtDnsServer = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edtTimeOut = new System.Windows.Forms.TextBox();
			this.edtName = new System.Windows.Forms.TextBox();
			this.cbNameType = new System.Windows.Forms.ComboBox();
			this.btnResolve = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.memResult = new System.Windows.Forms.TextBox();
			this.dnsQuery1 = new CleverComponents.InetSuite.DnsQuery();
			this.label6 = new System.Windows.Forms.Label();
			this.edtPort = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "DNS Server";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name to Resolve";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Query Type";
			// 
			// edtDnsServer
			// 
			this.edtDnsServer.Location = new System.Drawing.Point(104, 16);
			this.edtDnsServer.Name = "edtDnsServer";
			this.edtDnsServer.Size = new System.Drawing.Size(72, 20);
			this.edtDnsServer.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(280, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "TimeOut, s";
			// 
			// edtTimeOut
			// 
			this.edtTimeOut.Location = new System.Drawing.Point(344, 16);
			this.edtTimeOut.Name = "edtTimeOut";
			this.edtTimeOut.Size = new System.Drawing.Size(72, 20);
			this.edtTimeOut.TabIndex = 5;
			this.edtTimeOut.Text = "5";
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(104, 48);
			this.edtName.Name = "edtName";
			this.edtName.Size = new System.Drawing.Size(312, 20);
			this.edtName.TabIndex = 6;
			this.edtName.Text = "microsoft.com";
			// 
			// cbNameType
			// 
			this.cbNameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNameType.Items.AddRange(new object[] {
            "MX (mail servers)",
            "A (IP addresses)",
            "PTR (host names)",
            "NS (name servers)"});
			this.cbNameType.Location = new System.Drawing.Point(104, 80);
			this.cbNameType.Name = "cbNameType";
			this.cbNameType.Size = new System.Drawing.Size(120, 21);
			this.cbNameType.TabIndex = 7;
			// 
			// btnResolve
			// 
			this.btnResolve.Location = new System.Drawing.Point(304, 80);
			this.btnResolve.Name = "btnResolve";
			this.btnResolve.Size = new System.Drawing.Size(112, 23);
			this.btnResolve.TabIndex = 8;
			this.btnResolve.Text = "Resolve";
			this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Result";
			// 
			// memResult
			// 
			this.memResult.Location = new System.Drawing.Point(16, 136);
			this.memResult.Multiline = true;
			this.memResult.Name = "memResult";
			this.memResult.ReadOnly = true;
			this.memResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memResult.Size = new System.Drawing.Size(400, 160);
			this.memResult.TabIndex = 10;
			// 
			// dnsQuery1
			// 
			this.dnsQuery1.RootNameServers = null;
			this.dnsQuery1.Server = null;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(189, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(26, 15);
			this.label6.TabIndex = 11;
			this.label6.Text = "Port";
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(218, 16);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(53, 20);
			this.edtPort.TabIndex = 4;
			this.edtPort.Text = "53";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(434, 310);
			this.Controls.Add(this.edtPort);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.memResult);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnResolve);
			this.Controls.Add(this.cbNameType);
			this.Controls.Add(this.edtName);
			this.Controls.Add(this.edtTimeOut);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.edtDnsServer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "DNS Query demo";
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

		private void btnResolve_Click(object sender, System.EventArgs e) {
			dnsQuery1.Server = edtDnsServer.Text;
			dnsQuery1.Port = Convert.ToInt32(edtPort.Text);
			dnsQuery1.TimeOut = Convert.ToInt32(edtTimeOut.Text) * 1000;

			try {
				switch (cbNameType.SelectedIndex) {
					case 0: dnsQuery1.ResolveMX(edtName.Text); break;
					case 1: dnsQuery1.ResolveIP(edtName.Text); break;
					case 2: dnsQuery1.ResolveHost(edtName.Text); break;
					case 3: dnsQuery1.ResolveNS(edtName.Text); break;
				}

				memResult.Text = "";

				FillMXResult();
				FillHostResult();
				FillNameServerResult();
				FillAliasResult();

				if (StringUtils.IsEmpty(edtDnsServer.Text)) {
					edtDnsServer.Text = dnsQuery1.Server;
				}

				MessageBox.Show("Done");
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
		private void FillMXResult() {
			if (dnsQuery1.MailServers.Count == 0) return;

			memResult.Text += "====== Mail Servers ======\r\n";
			
			foreach (MailServerInfo mx in dnsQuery1.MailServers) {
				memResult.Text += String.Format("{0}, Preference {1}, {2}\r\n", mx.Name, mx.Preference, mx.IPAddress);
			}

			memResult.Text += "\r\n";
		}

		private void FillHostResult() {
			if (dnsQuery1.Hosts.Count == 0) return;

			memResult.Text += "====== Hosts ======\r\n";
			
			foreach (HostInfo host in dnsQuery1.Hosts) {
				memResult.Text += String.Format("{0}, {1}\r\n", host.Name, host.IPAddress);
			}

			memResult.Text += "\r\n";
		}

		private void FillNameServerResult() {
			if (dnsQuery1.NameServers == null || dnsQuery1.NameServers.Length == 0) return;

			memResult.Text += "====== Name Servers ======\r\n";
			memResult.Text += StringUtils.GetStringsAsString(dnsQuery1.NameServers);
			memResult.Text += "\r\n";
		}

		private void FillAliasResult() {
			if (dnsQuery1.Aliases == null || dnsQuery1.Aliases.Length == 0) return;

			memResult.Text += "====== Aliases ======\r\n";
			memResult.Text += StringUtils.GetStringsAsString(dnsQuery1.Aliases);
			memResult.Text += "\r\n";
		}
	}
}
