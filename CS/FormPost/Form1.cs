using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;


namespace FormPost
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox edtName;
		private System.Windows.Forms.TextBox edtBirthdate;
		private System.Windows.Forms.TextBox edtAccount;
		private System.Windows.Forms.TextBox edtHost;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox memResult;
		private CleverComponents.InetSuite.Http http1;
		private CleverComponents.InetSuite.HttpRequest httpRequest1;
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

			httpRequest1.AddFormField("Name", "");
			httpRequest1.AddFormField("Birthdate", "");
			httpRequest1.AddFormField("Account", "");

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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.edtName = new System.Windows.Forms.TextBox();
			this.edtBirthdate = new System.Windows.Forms.TextBox();
			this.edtAccount = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.edtHost = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.memResult = new System.Windows.Forms.TextBox();
			this.http1 = new CleverComponents.InetSuite.Http();
			this.httpRequest1 = new CleverComponents.InetSuite.HttpRequest();
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
			this.linkLabel1.Size = new System.Drawing.Size(376, 23);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "https://www.clevercomponents.com/products/inetsuite/demos/formpost.asp";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Birthdate";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Account";
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(80, 48);
			this.edtName.Name = "edtName";
			this.edtName.Size = new System.Drawing.Size(328, 20);
			this.edtName.TabIndex = 5;
			this.edtName.Text = "John Doe";
			// 
			// edtBirthdate
			// 
			this.edtBirthdate.Location = new System.Drawing.Point(80, 72);
			this.edtBirthdate.Name = "edtBirthdate";
			this.edtBirthdate.Size = new System.Drawing.Size(328, 20);
			this.edtBirthdate.TabIndex = 6;
			this.edtBirthdate.Text = "10/10/77";
			// 
			// edtAccount
			// 
			this.edtAccount.Location = new System.Drawing.Point(80, 96);
			this.edtAccount.Name = "edtAccount";
			this.edtAccount.Size = new System.Drawing.Size(328, 20);
			this.edtAccount.TabIndex = 7;
			this.edtAccount.Text = "123456";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Host";
			// 
			// edtHost
			// 
			this.edtHost.Location = new System.Drawing.Point(16, 144);
			this.edtHost.Name = "edtHost";
			this.edtHost.Size = new System.Drawing.Size(392, 20);
			this.edtHost.TabIndex = 9;
			this.edtHost.Text = "https://www.clevercomponents.com/products/inetsuite/demos/serverformpost.asp";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(16, 176);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 10;
			this.btnStart.Text = "&Submit";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 208);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "Response";
			// 
			// memResult
			// 
			this.memResult.Location = new System.Drawing.Point(16, 224);
			this.memResult.Multiline = true;
			this.memResult.Name = "memResult";
			this.memResult.ReadOnly = true;
			this.memResult.Size = new System.Drawing.Size(392, 88);
			this.memResult.TabIndex = 12;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(424, 326);
			this.Controls.Add(this.memResult);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.edtHost);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.edtAccount);
			this.Controls.Add(this.edtBirthdate);
			this.Controls.Add(this.edtName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Simulate Web Form POST request";
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

			httpRequest1.Items.FormFieldByName("Name").FieldValue = edtName.Text;
			httpRequest1.Items.FormFieldByName("Birthdate").FieldValue = edtBirthdate.Text;
			httpRequest1.Items.FormFieldByName("Account").FieldValue = edtAccount.Text;

			try {
				memResult.Text = http1.Post(edtHost.Text);
				http1.Close();
				MessageBox.Show("Process completed successfully.");
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
	}
}
