using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SMime
{
	/// <summary>
	/// Summary description for getcert.
	/// </summary>
	public class GetCertDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox edtEmail;
		public System.Windows.Forms.TextBox edtStore;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnMessage;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public static string DefaultEmail = "myname@mycompany.com";

		public GetCertDialog()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			edtEmail.Text = DefaultEmail;

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
				DefaultEmail = edtEmail.Text;
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
			this.edtEmail = new System.Windows.Forms.TextBox();
			this.edtStore = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnMessage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "E-mail Address";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Store Name";
			// 
			// edtEmail
			// 
			this.edtEmail.Location = new System.Drawing.Point(104, 8);
			this.edtEmail.Name = "edtEmail";
			this.edtEmail.Size = new System.Drawing.Size(200, 20);
			this.edtEmail.TabIndex = 2;
			this.edtEmail.Text = "textBox1";
			// 
			// edtStore
			// 
			this.edtStore.Location = new System.Drawing.Point(104, 32);
			this.edtStore.Name = "edtStore";
			this.edtStore.Size = new System.Drawing.Size(200, 20);
			this.edtStore.TabIndex = 3;
			this.edtStore.Text = "MY";
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(104, 64);
			this.btnOk.Name = "btnOk";
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "OK";
			// 
			// btnMessage
			// 
			this.btnMessage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnMessage.Location = new System.Drawing.Point(192, 64);
			this.btnMessage.Name = "btnMessage";
			this.btnMessage.Size = new System.Drawing.Size(112, 23);
			this.btnMessage.TabIndex = 5;
			this.btnMessage.Text = "Get From Message";
			// 
			// GetCertDialog
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(314, 96);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnMessage,
																		  this.btnOk,
																		  this.edtStore,
																		  this.edtEmail,
																		  this.label2,
																		  this.label1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GetCertDialog";
			this.Text = "Get Certificate Form";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
