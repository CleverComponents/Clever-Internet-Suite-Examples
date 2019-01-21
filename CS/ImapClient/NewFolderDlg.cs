using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ImapClient
{
	/// <summary>
	/// Summary description for NewFolderDlg.
	/// </summary>
	public class NewFolderDlg : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox edtName;
		public System.Windows.Forms.CheckBox cbIsSubfolder;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public NewFolderDlg()
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
			this.edtName = new System.Windows.Forms.TextBox();
			this.cbIsSubfolder = new System.Windows.Forms.CheckBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "New Folder Name";
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(16, 32);
			this.edtName.Name = "edtName";
			this.edtName.Size = new System.Drawing.Size(280, 20);
			this.edtName.TabIndex = 1;
			this.edtName.Text = "NewName";
			// 
			// cbIsSubfolder
			// 
			this.cbIsSubfolder.Location = new System.Drawing.Point(16, 56);
			this.cbIsSubfolder.Name = "cbIsSubfolder";
			this.cbIsSubfolder.Size = new System.Drawing.Size(280, 24);
			this.cbIsSubfolder.TabIndex = 2;
			this.cbIsSubfolder.Text = "Create as subfolder of the current folder";
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(128, 88);
			this.btnOk.Name = "btnOk";
			this.btnOk.TabIndex = 3;
			this.btnOk.Text = "OK";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(216, 88);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			// 
			// NewFolderDlg
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(312, 126);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.cbIsSubfolder);
			this.Controls.Add(this.edtName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "NewFolderDlg";
			this.ShowInTaskbar = false;
			this.Text = "New Folder";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.NewFolderDlg_Closing);
			this.ResumeLayout(false);

		}
		#endregion

		private void NewFolderDlg_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
			e.Cancel = (this.DialogResult == DialogResult.OK) && (edtName.Text == "");
			if (e.Cancel)
				MessageBox.Show("The value can not be empty");
		}
	}
}
