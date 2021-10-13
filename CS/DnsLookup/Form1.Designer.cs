
namespace DnsLookup
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
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
			this.edtPort = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.memResult = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnResolve = new System.Windows.Forms.Button();
			this.cbNameType = new System.Windows.Forms.ComboBox();
			this.edtName = new System.Windows.Forms.TextBox();
			this.edtTimeOut = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edtDnsServer = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dnsQuery1 = new CleverComponents.InetSuite.DnsQuery();
			this.SuspendLayout();
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(228, 10);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(53, 20);
			this.edtPort.TabIndex = 16;
			this.edtPort.Text = "53";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(199, 13);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(26, 15);
			this.label6.TabIndex = 24;
			this.label6.Text = "Port";
			// 
			// memResult
			// 
			this.memResult.Location = new System.Drawing.Point(26, 130);
			this.memResult.Multiline = true;
			this.memResult.Name = "memResult";
			this.memResult.ReadOnly = true;
			this.memResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memResult.Size = new System.Drawing.Size(400, 160);
			this.memResult.TabIndex = 23;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(26, 106);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 23);
			this.label5.TabIndex = 22;
			this.label5.Text = "Result";
			// 
			// btnResolve
			// 
			this.btnResolve.Location = new System.Drawing.Point(314, 74);
			this.btnResolve.Name = "btnResolve";
			this.btnResolve.Size = new System.Drawing.Size(112, 23);
			this.btnResolve.TabIndex = 21;
			this.btnResolve.Text = "Resolve";
			this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
			// 
			// cbNameType
			// 
			this.cbNameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNameType.Items.AddRange(new object[] {
            "MX (mail servers)",
            "A (IP addresses)",
            "PTR (host names)",
            "NS (name servers)"});
			this.cbNameType.Location = new System.Drawing.Point(114, 74);
			this.cbNameType.Name = "cbNameType";
			this.cbNameType.Size = new System.Drawing.Size(120, 21);
			this.cbNameType.TabIndex = 20;
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(114, 42);
			this.edtName.Name = "edtName";
			this.edtName.Size = new System.Drawing.Size(312, 20);
			this.edtName.TabIndex = 19;
			this.edtName.Text = "microsoft.com";
			// 
			// edtTimeOut
			// 
			this.edtTimeOut.Location = new System.Drawing.Point(354, 10);
			this.edtTimeOut.Name = "edtTimeOut";
			this.edtTimeOut.Size = new System.Drawing.Size(72, 20);
			this.edtTimeOut.TabIndex = 18;
			this.edtTimeOut.Text = "5";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(290, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 15);
			this.label4.TabIndex = 17;
			this.label4.Text = "TimeOut, s";
			// 
			// edtDnsServer
			// 
			this.edtDnsServer.Location = new System.Drawing.Point(114, 10);
			this.edtDnsServer.Name = "edtDnsServer";
			this.edtDnsServer.Size = new System.Drawing.Size(72, 20);
			this.edtDnsServer.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(26, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "Query Type";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(26, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Name to Resolve";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(26, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 15);
			this.label1.TabIndex = 12;
			this.label1.Text = "DNS Server";
			// 
			// dnsQuery1
			// 
			this.dnsQuery1.RootNameServers = null;
			this.dnsQuery1.Server = null;
			this.dnsQuery1.UseIpV6 = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 301);
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
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DNS Query demo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox edtPort;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox memResult;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnResolve;
		private System.Windows.Forms.ComboBox cbNameType;
		private System.Windows.Forms.TextBox edtName;
		private System.Windows.Forms.TextBox edtTimeOut;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edtDnsServer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private CleverComponents.InetSuite.DnsQuery dnsQuery1;
	}
}

