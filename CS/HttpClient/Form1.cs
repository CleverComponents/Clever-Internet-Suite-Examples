using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace HttpClient
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
			this.cbShowText.Location = new System.Drawing.Point(56, 72);
			this.cbShowText.Name = "cbShowText";
			this.cbShowText.Size = new System.Drawing.Size(104, 24);
			this.cbShowText.TabIndex = 4;
			this.cbShowText.Text = "Show text only";
			// 
			// memResult
			// 
			this.memResult.BackColor = System.Drawing.SystemColors.Window;
			this.memResult.Location = new System.Drawing.Point(0, 96);
			this.memResult.Multiline = true;
			this.memResult.Name = "memResult";
			this.memResult.ReadOnly = true;
			this.memResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memResult.Size = new System.Drawing.Size(448, 264);
			this.memResult.TabIndex = 5;
			// 
			// htmlParser1
			// 
			this.htmlParser1.ParseMethod = CleverComponents.InetSuite.ParseMethod.TextOnly;
			this.htmlParser1.ParseTag += new CleverComponents.InetSuite.ParseTagEventHandler(this.htmlParser1_ParseTag);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 358);
			this.Controls.Add(this.memResult);
			this.Controls.Add(this.cbShowText);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.edtUrl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
	}
}
