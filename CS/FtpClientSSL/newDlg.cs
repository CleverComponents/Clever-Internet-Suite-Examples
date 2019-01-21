using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FtpClientSSL
{
	/// <summary>
	/// Summary description for newDlg.
	/// </summary>
	public class NewDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox edtName;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public NewDialog()
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
			this.lblName = new System.Windows.Forms.Label();
			this.edtName = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(16, 16);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(184, 16);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "label1";
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(16, 32);
			this.edtName.Name = "edtName";
			this.edtName.Size = new System.Drawing.Size(240, 20);
			this.edtName.TabIndex = 1;
			this.edtName.Text = "NewName";
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(80, 64);
			this.btnOk.Name = "btnOk";
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "OK";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(176, 64);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			// 
			// NewDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(274, 104);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.edtName);
			this.Controls.Add(this.lblName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "NewDialog";
			this.ShowInTaskbar = false;
			this.Text = "newDlg";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.NewDialog_Closing);
			this.ResumeLayout(false);

		}
		#endregion

		private void NewDialog_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
			e.Cancel = (edtName.Text == "") && (this.DialogResult == DialogResult.OK);
			if (e.Cancel)
				MessageBox.Show("The value can not be empty");
		}

		public static string ShowNewDialog(string caption, string theValue) {
			NewDialog dlg = new NewDialog();

			dlg.Text = caption;
			dlg.lblName.Text = caption;
			dlg.edtName.Text = theValue;
			if (dlg.ShowDialog() == DialogResult.OK) {
				return dlg.edtName.Text;
			}

			return "";
		}
	}
}
