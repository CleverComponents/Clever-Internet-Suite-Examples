using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Collections.Specialized;
using CleverComponents.InetSuite;

namespace MSExchange
{
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.TextBox edtFrom;
		private System.Windows.Forms.TextBox edtSubject;
		private System.Windows.Forms.RichTextBox memText;
		private System.Windows.Forms.RichTextBox memHtml;
		private System.Windows.Forms.ListBox lbAttachments;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox edtPickup;
		private System.Windows.Forms.TextBox edtTo;
		private CleverComponents.InetSuite.MailMessage mailMessage1;
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			InitializeComponent();
			memText.Lines = new string[] {
				"This is MIME test message built using Clever Message Parser"
			};
			memHtml.Lines = new string[] {
				"<html>",
				"<body>",
				"<p>This is MIME test message built using Clever Message Parser</p>",
				"</body>",
				"</html>"
			};
		}

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
			this.edtFrom = new System.Windows.Forms.TextBox();
			this.edtTo = new System.Windows.Forms.TextBox();
			this.edtSubject = new System.Windows.Forms.TextBox();
			this.edtPickup = new System.Windows.Forms.TextBox();
			this.memText = new System.Windows.Forms.RichTextBox();
			this.memHtml = new System.Windows.Forms.RichTextBox();
			this.lbAttachments = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSend = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.mailMessage1 = new CleverComponents.InetSuite.MailMessage();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(496, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "This demo demonstrates how to send MIME mail message using Microsoft Exchange ser" +
    "ver";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "From";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "To";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Subject";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Plain Text";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(272, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Plain Html";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 248);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Attachments";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 336);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(152, 23);
			this.label8.TabIndex = 7;
			this.label8.Text = "Exchange drop/pickup folder";
			// 
			// edtFrom
			// 
			this.edtFrom.Location = new System.Drawing.Point(120, 32);
			this.edtFrom.Name = "edtFrom";
			this.edtFrom.Size = new System.Drawing.Size(384, 20);
			this.edtFrom.TabIndex = 0;
			this.edtFrom.Text = "test@myhost.com";
			// 
			// edtTo
			// 
			this.edtTo.Location = new System.Drawing.Point(120, 56);
			this.edtTo.Name = "edtTo";
			this.edtTo.Size = new System.Drawing.Size(384, 20);
			this.edtTo.TabIndex = 1;
			this.edtTo.Text = "john@nexthost.com";
			// 
			// edtSubject
			// 
			this.edtSubject.Location = new System.Drawing.Point(120, 80);
			this.edtSubject.Name = "edtSubject";
			this.edtSubject.Size = new System.Drawing.Size(384, 20);
			this.edtSubject.TabIndex = 2;
			this.edtSubject.Text = "Clever Message Parser Test";
			// 
			// edtPickup
			// 
			this.edtPickup.Location = new System.Drawing.Point(168, 336);
			this.edtPickup.Name = "edtPickup";
			this.edtPickup.Size = new System.Drawing.Size(336, 20);
			this.edtPickup.TabIndex = 8;
			this.edtPickup.Text = "C:\\Inetpub\\mailroot\\Pickup";
			// 
			// memText
			// 
			this.memText.DetectUrls = false;
			this.memText.Location = new System.Drawing.Point(16, 128);
			this.memText.Name = "memText";
			this.memText.Size = new System.Drawing.Size(240, 112);
			this.memText.TabIndex = 3;
			this.memText.Text = "";
			// 
			// memHtml
			// 
			this.memHtml.DetectUrls = false;
			this.memHtml.Location = new System.Drawing.Point(264, 128);
			this.memHtml.Name = "memHtml";
			this.memHtml.Size = new System.Drawing.Size(240, 112);
			this.memHtml.TabIndex = 4;
			this.memHtml.Text = "";
			// 
			// lbAttachments
			// 
			this.lbAttachments.Location = new System.Drawing.Point(16, 264);
			this.lbAttachments.Name = "lbAttachments";
			this.lbAttachments.Size = new System.Drawing.Size(320, 56);
			this.lbAttachments.TabIndex = 5;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(344, 264);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Add...";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(344, 296);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(280, 368);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(104, 23);
			this.btnNew.TabIndex = 9;
			this.btnNew.Text = "New Message";
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(400, 368);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(104, 23);
			this.btnSend.TabIndex = 10;
			this.btnSend.Text = "Send Message";
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// mailMessage1
			// 
			this.mailMessage1.Date = new System.DateTime(2006, 5, 5, 16, 21, 37, 750);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(520, 408);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lbAttachments);
			this.Controls.Add(this.memHtml);
			this.Controls.Add(this.memText);
			this.Controls.Add(this.edtPickup);
			this.Controls.Add(this.edtSubject);
			this.Controls.Add(this.edtTo);
			this.Controls.Add(this.edtFrom);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MS SMTP Mail Sender";
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		private void btnAdd_Click(object sender, System.EventArgs e) {
			if(openFileDialog.ShowDialog() == DialogResult.OK)
				lbAttachments.Items.Add(openFileDialog.FileName);
		}

		private void btnClear_Click(object sender, System.EventArgs e) {
			lbAttachments.Items.Clear();
		}

		private void btnNew_Click(object sender, System.EventArgs e) {
			edtFrom.Text = "";
			edtTo.Text = "";
			edtSubject.Text = "";
			memText.Lines = new string[] {};
			memHtml.Lines = new string[] {
				"<html>",
				"<body>",
				"</body>",
				"</html>",
			};
			lbAttachments.Items.Clear();
		}

		private string GenerateFileName(string path) {
			string result = path;
			if((result != "") && (result[result.Length - 1] != '\\'))
				result += "\\";
			DateTime now = DateTime.Now;
			return result +  String.Format("{0}{1}{2}{3}{4}{5}.eml",
				now.Month.ToString("X2"),
				now.Day.ToString("X2"),
				now.Hour.ToString("X2"),
				now.Minute.ToString("X2"),
				now.Second.ToString("X2"),
				now.Millisecond.ToString("X2"));
		}

		private string[] GetAttachments() {
			string[] result = new string[lbAttachments.Items.Count];

			for(int i = 0; i < lbAttachments.Items.Count; i++)
				result[i] = (string)lbAttachments.Items[i];
			return result;
		}

		private void btnSend_Click(object sender, System.EventArgs e) {
			mailMessage1.BuildMessage(memText.Text, memHtml.Text, null, GetAttachments());
			mailMessage1.From.FullAddress = edtFrom.Text;
			mailMessage1.ToList.EmailAddresses = edtTo.Text;
			mailMessage1.Subject = edtSubject.Text;

			using(StreamWriter w = new StreamWriter(GenerateFileName(edtPickup.Text))) {
				w.Write(StringUtils.GetStringsAsString(mailMessage1.MessageSource));
			}

			MessageBox.Show("The message has been queued for sending by the Microsoft SMTP service.");
		}
	}
}
