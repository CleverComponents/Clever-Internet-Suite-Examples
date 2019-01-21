using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CertMgr
{
	/// <summary>
	/// Summary description for importfrm.
	/// </summary>
	public class ImportForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		public System.Windows.Forms.TextBox edtFileName;
		public System.Windows.Forms.TextBox edtPassword;
		public System.Windows.Forms.TextBox edtStoreName;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ImportForm()
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
			this.edtFileName = new System.Windows.Forms.TextBox();
			this.edtStoreName = new System.Windows.Forms.TextBox();
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "File Name";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// edtFileName
			// 
			this.edtFileName.Location = new System.Drawing.Point(80, 16);
			this.edtFileName.Name = "edtFileName";
			this.edtFileName.Size = new System.Drawing.Size(240, 20);
			this.edtFileName.TabIndex = 2;
			this.edtFileName.Text = "cert.pfx";
			// 
			// edtStoreName
			// 
			this.edtStoreName.Location = new System.Drawing.Point(16, 112);
			this.edtStoreName.Name = "edtStoreName";
			this.edtStoreName.ReadOnly = true;
			this.edtStoreName.Size = new System.Drawing.Size(304, 20);
			this.edtStoreName.TabIndex = 3;
			this.edtStoreName.Text = "";
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(80, 48);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.Size = new System.Drawing.Size(112, 20);
			this.edtPassword.TabIndex = 4;
			this.edtPassword.Text = "123";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(304, 32);
			this.label3.TabIndex = 5;
			this.label3.Text = "The certificate will be imported and installed in to the currently loaded System " +
				"Store:";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(200, 144);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(80, 144);
			this.btnOk.Name = "btnOk";
			this.btnOk.TabIndex = 9;
			this.btnOk.Text = "OK";
			// 
			// ImportForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(344, 182);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.edtPassword);
			this.Controls.Add(this.edtStoreName);
			this.Controls.Add(this.edtFileName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "ImportForm";
			this.ShowInTaskbar = false;
			this.Text = "Certificate Import Dialog";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
