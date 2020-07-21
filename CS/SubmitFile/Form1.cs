using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace SubmitFile
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox edtName;
		private System.Windows.Forms.TextBox edtHost;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox memResult;
		private CleverComponents.InetSuite.Http http1;
		private CleverComponents.InetSuite.HttpRequest httpRequest1;
		private System.Windows.Forms.ProgressBar progressBar1;
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

			http1.Request = httpRequest1;
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
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.edtName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.edtHost = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.memResult = new System.Windows.Forms.TextBox();
			this.http1 = new CleverComponents.InetSuite.Http();
			this.httpRequest1 = new CleverComponents.InetSuite.HttpRequest();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.httpRequest1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Try the original web page at:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(16, 24);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(400, 23);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "https://www.clevercomponents.com/products/inetsuite/demos/submitfile.asp";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 14);
			this.label2.TabIndex = 2;
			this.label2.Text = "File";
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(53, 50);
			this.edtName.Name = "edtName";
			this.edtName.Size = new System.Drawing.Size(355, 20);
			this.edtName.TabIndex = 5;
			this.edtName.Text = "c:\\uploads\\file.txt";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Host";
			// 
			// edtHost
			// 
			this.edtHost.Location = new System.Drawing.Point(16, 92);
			this.edtHost.Name = "edtHost";
			this.edtHost.Size = new System.Drawing.Size(392, 20);
			this.edtHost.TabIndex = 9;
			this.edtHost.Text = "https://www.clevercomponents.com/products/inetsuite/demos/serversubmitfile.asp";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(16, 118);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 10;
			this.btnStart.Text = "&Submit";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 155);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "Response";
			// 
			// memResult
			// 
			this.memResult.Location = new System.Drawing.Point(16, 174);
			this.memResult.Multiline = true;
			this.memResult.Name = "memResult";
			this.memResult.ReadOnly = true;
			this.memResult.Size = new System.Drawing.Size(392, 130);
			this.memResult.TabIndex = 12;
			// 
			// http1
			// 
			this.http1.CharSet = null;
			this.http1.SendProgress += new CleverComponents.InetSuite.ProgressEventHandler(this.http1_SendProgress);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(16, 311);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(392, 16);
			this.progressBar1.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(424, 339);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.memResult);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.edtHost);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.edtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Simulate Web Submit File request";
			((System.ComponentModel.ISupportInitialize)(this.httpRequest1)).EndInit();
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

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
			ProcessStartInfo sInfo = new ProcessStartInfo(linkLabel1.Text);
			Process.Start(sInfo);
		}

		private void btnStart_Click(object sender, System.EventArgs e) {
			if (http1.Active) return;

			httpRequest1.Clear();
			httpRequest1.AddSubmitFile("FileName", edtName.Text);

			try {
				memResult.Text = http1.Post(edtHost.Text);
				http1.Close();
				MessageBox.Show("Process completed successfully.");
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void http1_SendProgress(object sender, CleverComponents.InetSuite.ProgressEventArgs e) {
			if(e.TotalBytes > 0) {
				progressBar1.Minimum = 0;
				progressBar1.Maximum = (int)e.TotalBytes;
				progressBar1.Value = (int)e.BytesProceed;
			}
		}
	}
}
