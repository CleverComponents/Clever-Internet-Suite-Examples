using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using CleverComponents.InetSuite;

namespace SMime
{
	/// <summary>
	/// Summary description for certlistfrm.
	/// </summary>
	public class CertListForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnInstall;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ListBox lbList;
		private CertificateStore certificates;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CertListForm()
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

		void FillList() {
			lbList.Items.Clear();
			foreach(Certificate cert in certificates.Items) {
				string s = cert.IssuedTo;
				if(cert.Email != "")
					s += " (" + cert.Email + ")";
				lbList.Items.Add(s);
			}
		}

		public static void ShowCertificates(CertificateStore list) {
			CertListForm dlg = new CertListForm();
			dlg.certificates = list;
			dlg.FillList();
			dlg.ShowDialog();
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbList = new System.Windows.Forms.ListBox();
			this.btnInstall = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbList
			// 
			this.lbList.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbList.Location = new System.Drawing.Point(0, 0);
			this.lbList.Name = "lbList";
			this.lbList.Size = new System.Drawing.Size(384, 160);
			this.lbList.TabIndex = 0;
			// 
			// btnInstall
			// 
			this.btnInstall.Location = new System.Drawing.Point(16, 176);
			this.btnInstall.Name = "btnInstall";
			this.btnInstall.Size = new System.Drawing.Size(75, 23);
			this.btnInstall.TabIndex = 1;
			this.btnInstall.Text = "Install";
			this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnClose.Location = new System.Drawing.Point(296, 176);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			// 
			// CertListForm
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(384, 208);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnInstall);
			this.Controls.Add(this.lbList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CertListForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "certlistfrm";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnInstall_Click(object sender, System.EventArgs e) {
			if(lbList.SelectedIndex > -1) {
				certificates.Install(certificates.Items[lbList.SelectedIndex]);
				MessageBox.Show("The message certificate has been installed.");
			}
		}
	}
}
