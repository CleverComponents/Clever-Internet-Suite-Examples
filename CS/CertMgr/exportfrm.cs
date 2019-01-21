using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CertMgr
{
	/// <summary>
	/// Summary description for exportfrm.
	/// </summary>
	public class ExportForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		public System.Windows.Forms.TextBox edtName;
		public System.Windows.Forms.TextBox edtFileName;
		public System.Windows.Forms.TextBox edtPassword;
		public CheckBox cbIncludeAll;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ExportForm()
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
			this.edtName = new System.Windows.Forms.TextBox();
			this.edtFileName = new System.Windows.Forms.TextBox();
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cbIncludeAll = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Certificate";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "File Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(80, 16);
			this.edtName.Name = "edtName";
			this.edtName.ReadOnly = true;
			this.edtName.Size = new System.Drawing.Size(256, 20);
			this.edtName.TabIndex = 3;
			// 
			// edtFileName
			// 
			this.edtFileName.Location = new System.Drawing.Point(80, 48);
			this.edtFileName.Name = "edtFileName";
			this.edtFileName.Size = new System.Drawing.Size(256, 20);
			this.edtFileName.TabIndex = 4;
			this.edtFileName.Text = "cert.pfx";
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(80, 80);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.Size = new System.Drawing.Size(120, 20);
			this.edtPassword.TabIndex = 5;
			this.edtPassword.Text = "123";
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(78, 129);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 7;
			this.btnOk.Text = "OK";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(198, 129);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			// 
			// cbIncludeAll
			// 
			this.cbIncludeAll.AutoSize = true;
			this.cbIncludeAll.Location = new System.Drawing.Point(80, 106);
			this.cbIncludeAll.Name = "cbIncludeAll";
			this.cbIncludeAll.Size = new System.Drawing.Size(169, 17);
			this.cbIncludeAll.TabIndex = 9;
			this.cbIncludeAll.Text = "Include All certificates in chain";
			this.cbIncludeAll.UseVisualStyleBackColor = true;
			// 
			// ExportForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(360, 174);
			this.Controls.Add(this.cbIncludeAll);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.edtPassword);
			this.Controls.Add(this.edtFileName);
			this.Controls.Add(this.edtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "ExportForm";
			this.ShowInTaskbar = false;
			this.Text = "Certificate Export Dialog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
	}
}
