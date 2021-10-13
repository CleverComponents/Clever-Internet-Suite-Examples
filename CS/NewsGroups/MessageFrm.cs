using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using CleverComponents.InetSuite;

namespace NewsGroups
{
	/// <summary>
	/// Summary description for MessageFrm.
	/// </summary>
	public class MessageFrm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edtSubject;
		private System.Windows.Forms.TextBox edtFrom;
		private System.Windows.Forms.Button btnPost;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox memText;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MessageFrm()
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
				if(components != null)
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.edtFrom = new System.Windows.Forms.TextBox();
			this.edtSubject = new System.Windows.Forms.TextBox();
			this.memText = new System.Windows.Forms.TextBox();
			this.btnPost = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "From";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Subject";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Text";
			// 
			// edtFrom
			// 
			this.edtFrom.Location = new System.Drawing.Point(80, 16);
			this.edtFrom.Name = "edtFrom";
			this.edtFrom.Size = new System.Drawing.Size(400, 20);
			this.edtFrom.TabIndex = 5;
			this.edtFrom.Text = "newsuser@company.mail";
			// 
			// edtSubject
			// 
			this.edtSubject.Location = new System.Drawing.Point(80, 48);
			this.edtSubject.Name = "edtSubject";
			this.edtSubject.Size = new System.Drawing.Size(400, 20);
			this.edtSubject.TabIndex = 6;
			this.edtSubject.Text = "Test Subject";
			// 
			// memText
			// 
			this.memText.Location = new System.Drawing.Point(16, 96);
			this.memText.Multiline = true;
			this.memText.Name = "memText";
			this.memText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memText.Size = new System.Drawing.Size(464, 168);
			this.memText.TabIndex = 7;
			this.memText.Text = "My test newsgroup post";
			// 
			// btnPost
			// 
			this.btnPost.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnPost.Location = new System.Drawing.Point(304, 272);
			this.btnPost.Name = "btnPost";
			this.btnPost.Size = new System.Drawing.Size(75, 23);
			this.btnPost.TabIndex = 8;
			this.btnPost.Text = "Post";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(400, 272);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			// 
			// MessageFrm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(498, 304);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnPost);
			this.Controls.Add(this.memText);
			this.Controls.Add(this.edtSubject);
			this.Controls.Add(this.edtFrom);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "MessageFrm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Message Details";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		public static bool PostNew(MailMessage article) {
			MessageFrm dlg = new MessageFrm();
			if (dlg.ShowDialog() == DialogResult.OK) {
				article.BuildMessage(dlg.memText.Text, "");
				article.Subject = dlg.edtSubject.Text;
				article.From.FullAddress = dlg.edtFrom.Text;

				return true;
			}
			return false;
		}

		public static bool ReplyTo(MailMessage article) {
			MessageFrm dlg = new MessageFrm();
			dlg.btnPost.Text = "Reply";

			string txt = "\r\n" + StringUtils.GetStringsAsString(article.MessageText);
			txt += txt.Replace("\r\n", "\r\n >");
			txt = "\r\n" + txt;
			dlg.memText.Text = txt;

			if (article.Subject.ToLower().IndexOf("re:") != 0)
				dlg.edtSubject.Text = "Re: " + article.Subject;

			string[] refs = article.References;

			if (dlg.ShowDialog() == DialogResult.OK) {
				article.BuildMessage(dlg.memText.Text, "");
				article.Subject = dlg.edtSubject.Text;
				article.From.FullAddress = dlg.edtFrom.Text;
				article.References = refs;

				return true;
			}
			return false;
		}
	}
}
