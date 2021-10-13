using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using CleverComponents.InetSuite;

namespace ImapClient
{
	/// <summary>
	/// Summary description for MessageFrm.
	/// </summary>
	public class MessageFrm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edtFrom;
		private System.Windows.Forms.TextBox edtTo;
		private System.Windows.Forms.TextBox edtSubject;
		private System.Windows.Forms.TextBox memBody;
		private System.Windows.Forms.Button btnAppend;
		private System.Windows.Forms.Button btnCancel;
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.edtFrom = new System.Windows.Forms.TextBox();
			this.edtTo = new System.Windows.Forms.TextBox();
			this.edtSubject = new System.Windows.Forms.TextBox();
			this.memBody = new System.Windows.Forms.TextBox();
			this.btnAppend = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "From";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "To";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Subject";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Body";
			// 
			// edtFrom
			// 
			this.edtFrom.Location = new System.Drawing.Point(80, 8);
			this.edtFrom.Name = "edtFrom";
			this.edtFrom.Size = new System.Drawing.Size(400, 20);
			this.edtFrom.TabIndex = 4;
			this.edtFrom.Text = "clevertester@company.mail";
			// 
			// edtTo
			// 
			this.edtTo.Location = new System.Drawing.Point(80, 32);
			this.edtTo.Name = "edtTo";
			this.edtTo.Size = new System.Drawing.Size(400, 20);
			this.edtTo.TabIndex = 5;
			this.edtTo.Text = "clevertester@company.mail";
			// 
			// edtSubject
			// 
			this.edtSubject.Location = new System.Drawing.Point(80, 56);
			this.edtSubject.Name = "edtSubject";
			this.edtSubject.Size = new System.Drawing.Size(400, 20);
			this.edtSubject.TabIndex = 6;
			this.edtSubject.Text = "Test Subject";
			// 
			// memBody
			// 
			this.memBody.Location = new System.Drawing.Point(16, 104);
			this.memBody.Multiline = true;
			this.memBody.Name = "memBody";
			this.memBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memBody.Size = new System.Drawing.Size(464, 160);
			this.memBody.TabIndex = 7;
			// 
			// btnAppend
			// 
			this.btnAppend.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAppend.Location = new System.Drawing.Point(304, 272);
			this.btnAppend.Name = "btnAppend";
			this.btnAppend.Size = new System.Drawing.Size(75, 23);
			this.btnAppend.TabIndex = 8;
			this.btnAppend.Text = "Append";
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
			this.Controls.Add(this.btnAppend);
			this.Controls.Add(this.memBody);
			this.Controls.Add(this.edtSubject);
			this.Controls.Add(this.edtTo);
			this.Controls.Add(this.edtFrom);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "MessageFrm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Message Details";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		public static void ShowMessage(MailMessage msg) {
			MessageFrm dlg = new MessageFrm();
			dlg.btnAppend.Visible = false;
			dlg.btnCancel.Text = "Close";

			dlg.edtFrom.ReadOnly = true;
			dlg.edtTo.ReadOnly = true;
			dlg.edtSubject.ReadOnly = true;
			dlg.memBody.ReadOnly = true;

			dlg.edtFrom.BackColor = SystemColors.Window;
			dlg.edtTo.BackColor = SystemColors.Window;
			dlg.edtSubject.BackColor = SystemColors.Window;
			dlg.memBody.BackColor = SystemColors.Window;

			dlg.edtFrom.Text = msg.From.FullAddress;
			dlg.edtTo.Text = msg.ToList.EmailAddresses;
			dlg.edtSubject.Text = msg.Subject;
			dlg.memBody.Lines = msg.MessageText;

			dlg.ShowDialog();
		}

		public static bool ComposeMessage(MailMessage msg) {
			MessageFrm dlg = new MessageFrm();
			dlg.btnAppend.Visible = true;
			dlg.btnCancel.Text = "Cancel";

			dlg.edtFrom.ReadOnly = false;
			dlg.edtTo.ReadOnly = false;
			dlg.edtSubject.ReadOnly = false;
			dlg.memBody.ReadOnly = false;

			dlg.edtFrom.Text = "clevertester@company.mail";
			dlg.edtTo.Text = "clevertester@company.mail";
			dlg.edtSubject.Text = "Test Subject";
			dlg.memBody.Text = "Test Body";

			if (dlg.ShowDialog() == DialogResult.OK) {
				msg.BuildMessage(dlg.memBody.Text, "");
				msg.From.FullAddress = dlg.edtFrom.Text;
				msg.ToList.EmailAddresses = dlg.edtTo.Text;
				msg.Subject = dlg.edtSubject.Text;
				return true;
			}
			return false;
		}
	}
}
