using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;
using CleverComponents.InetSuite.CryptApi;

namespace CertMgr {
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form {
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbName;
		private System.Windows.Forms.ListView lvCertificates;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreateSelfSigned;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private CleverComponents.InetSuite.CertificateStore certificateStore1;
		private Button btnCreateSigned;
		private ComboBox cbLocation;
		private Label label1;
		private bool isOpened = false;

		public Form1() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			cbLocation.SelectedIndex = 0;

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbName = new System.Windows.Forms.ComboBox();
			this.lvCertificates = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnImport = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreateSelfSigned = new System.Windows.Forms.Button();
			this.certificateStore1 = new CleverComponents.InetSuite.CertificateStore();
			this.btnCreateSigned = new System.Windows.Forms.Button();
			this.cbLocation = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(14, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "System Store Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Certificates";
			// 
			// cbName
			// 
			this.cbName.Items.AddRange(new object[] {
            "MY",
            "CA",
            "ROOT",
            "ADDRESSBOOK"});
			this.cbName.Location = new System.Drawing.Point(141, 42);
			this.cbName.Name = "cbName";
			this.cbName.Size = new System.Drawing.Size(184, 21);
			this.cbName.TabIndex = 4;
			this.cbName.Text = "MY";
			// 
			// lvCertificates
			// 
			this.lvCertificates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.lvCertificates.FullRowSelect = true;
			this.lvCertificates.HideSelection = false;
			this.lvCertificates.Location = new System.Drawing.Point(16, 88);
			this.lvCertificates.MultiSelect = false;
			this.lvCertificates.Name = "lvCertificates";
			this.lvCertificates.Size = new System.Drawing.Size(408, 232);
			this.lvCertificates.TabIndex = 5;
			this.lvCertificates.UseCompatibleStateImageBehavior = false;
			this.lvCertificates.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Issued To";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Issued By";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Expiration Date";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Friendly Name";
			this.columnHeader4.Width = 100;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Email";
			this.columnHeader5.Width = 100;
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(440, 16);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(112, 23);
			this.btnLoad.TabIndex = 6;
			this.btnLoad.Text = "Load Store";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(440, 48);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(112, 23);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close Store";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(440, 88);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(112, 23);
			this.btnExport.TabIndex = 8;
			this.btnExport.Text = "Export to PFX...";
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(440, 120);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(112, 23);
			this.btnImport.TabIndex = 9;
			this.btnImport.Text = "Import from PFX...";
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(440, 239);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(112, 23);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCreateSelfSigned
			// 
			this.btnCreateSelfSigned.Location = new System.Drawing.Point(440, 268);
			this.btnCreateSelfSigned.Name = "btnCreateSelfSigned";
			this.btnCreateSelfSigned.Size = new System.Drawing.Size(112, 23);
			this.btnCreateSelfSigned.TabIndex = 11;
			this.btnCreateSelfSigned.Text = "Create Self-Signed";
			this.btnCreateSelfSigned.Click += new System.EventHandler(this.btnCreateSelfSigned_Click);
			// 
			// certificateStore1
			// 
			this.certificateStore1.ValidFrom = new System.DateTime(2009, 8, 17, 12, 15, 16, 656);
			this.certificateStore1.ValidTo = new System.DateTime(2010, 8, 17, 12, 15, 16, 656);
			// 
			// btnCreateSigned
			// 
			this.btnCreateSigned.Location = new System.Drawing.Point(440, 297);
			this.btnCreateSigned.Name = "btnCreateSigned";
			this.btnCreateSigned.Size = new System.Drawing.Size(112, 23);
			this.btnCreateSigned.TabIndex = 12;
			this.btnCreateSigned.Text = "Create Signed";
			this.btnCreateSigned.Click += new System.EventHandler(this.btnCreateSigned_Click);
			// 
			// cbLocation
			// 
			this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLocation.Items.AddRange(new object[] {
            "Current User",
            "Local Machine"});
			this.cbLocation.Location = new System.Drawing.Point(141, 15);
			this.cbLocation.Name = "cbLocation";
			this.cbLocation.Size = new System.Drawing.Size(184, 21);
			this.cbLocation.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(14, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 23);
			this.label1.TabIndex = 13;
			this.label1.Text = "System Store Location";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(570, 334);
			this.Controls.Add(this.cbLocation);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCreateSigned);
			this.Controls.Add(this.btnCreateSelfSigned);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.lvCertificates);
			this.Controls.Add(this.cbName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new Form1());
		}

		private void LoadCertificateList() {
			lvCertificates.Items.Clear();
			foreach (Certificate cert in certificateStore1.Items) {
				ListViewItem item = lvCertificates.Items.Add(cert.IssuedTo);
				item.SubItems.Add(cert.IssuedBy);
				item.SubItems.Add(cert.ValidTo.ToString());
				item.SubItems.Add(cert.FriendlyName);
				item.SubItems.Add(cert.Email);
			}
		}

		private void InstallCerts() {
			foreach (Certificate cert in certificateStore1.Items) {
				if (!certificateStore1.IsInstalled(cert)) {
					certificateStore1.Install(cert);
				}
			}
		}

		private void PrepareStore(CreateCertForm dlg) {
			certificateStore1.ValidFrom = Convert.ToDateTime(dlg.edtValidFrom.Text);
			certificateStore1.ValidTo = Convert.ToDateTime(dlg.edtValidTo.Text);
			certificateStore1.KeyName = dlg.edtKeyName.Text;
			certificateStore1.KeyLength = Convert.ToInt32(dlg.edtKeyLength.Text);

			StringCollectionEx usage = new StringCollectionEx();
			if (dlg.cbServerAuth.Checked)
				usage.Add(CertificateEnhancedUsage.OID_PKIX_KP_SERVER_AUTH);
			if (dlg.cbClientAuth.Checked)
				usage.Add(CertificateEnhancedUsage.OID_PKIX_KP_CLIENT_AUTH);
			if (dlg.cbCodeSigning.Checked)
				usage.Add(CertificateEnhancedUsage.OID_PKIX_KP_CODE_SIGNING);
			if (dlg.cbEmailProtection.Checked)
				usage.Add(CertificateEnhancedUsage.OID_PKIX_KP_EMAIL_PROTECTION);

			certificateStore1.EnhancedKeyUsage = usage.ToArray();

			if (!certificateStore1.KeyExists(certificateStore1.KeyName))
				certificateStore1.CreateKey(certificateStore1.KeyName);
		}

		private void btnLoad_Click(object sender, System.EventArgs e) {
			btnClose_Click(null, null);

			CertificateStoreLocation location = (cbLocation.SelectedIndex == 0) ?
				CertificateStoreLocation.CurrentUser : CertificateStoreLocation.LocalMachine;
			certificateStore1.Open(cbName.Text, location);
			LoadCertificateList();
			isOpened = true;
		}

		private void btnClose_Click(object sender, System.EventArgs e) {
			certificateStore1.Close();
			LoadCertificateList();
			isOpened = false;
		}

		private void btnExport_Click(object sender, System.EventArgs e) {
			if (lvCertificates.SelectedIndices.Count == 0) return;

			Certificate cert = certificateStore1.Items[lvCertificates.SelectedIndices[0]];
			ExportForm dlg = new ExportForm();

			dlg.edtName.Text = cert.FriendlyName;
			if (StringUtils.IsEmpty(dlg.edtName.Text)) {
				dlg.edtName.Text = cert.IssuedTo;
			}

			if (dlg.ShowDialog() == DialogResult.OK) {
				certificateStore1.ExportToPFX(cert, dlg.edtFileName.Text, dlg.edtPassword.Text, dlg.cbIncludeAll.Checked);
			}
		}

		private void btnImport_Click(object sender, System.EventArgs e) {
			if (!isOpened) return;

			ImportForm dlg = new ImportForm();
			dlg.edtStoreName.Text = cbLocation.Text + "; " + cbName.Text;

			if (dlg.ShowDialog() == DialogResult.OK) {
				certificateStore1.ImportFromPFX(dlg.edtFileName.Text, dlg.edtPassword.Text);

				InstallCerts();
				btnLoad_Click(null, null);
			}
		}

		private void btnDelete_Click(object sender, System.EventArgs e) {
			if (lvCertificates.SelectedIndices.Count == 0) return;

			Certificate cert = certificateStore1.Items[lvCertificates.SelectedIndices[0]];
			certificateStore1.Uninstall(cert);
			certificateStore1.Items.RemoveAt(lvCertificates.SelectedIndices[0]);

			btnLoad_Click(null, null);
		}

		private void btnCreateSelfSigned_Click(object sender, System.EventArgs e) {
			if (!isOpened) return;

			CreateCertForm dlg = new CreateCertForm();
			dlg.edtStoreName.Text = cbLocation.Text + "; " + cbName.Text;

			if (dlg.ShowDialog() == DialogResult.OK) {
				PrepareStore(dlg);

				Certificate cert = certificateStore1.CreateSelfSigned(dlg.BuildSubjectString(), Convert.ToInt32(dlg.edtSerial.Text));
				certificateStore1.Items.Add(cert);
				cert.FriendlyName = dlg.edtFriendlyName.Text;

				InstallCerts();

				btnLoad_Click(null, null);
			}
		}

		private void btnCreateSigned_Click(object sender, EventArgs e) {
			if (!isOpened) return;

			if (lvCertificates.SelectedIndices.Count == 0) return;

			CreateCertForm dlg = new CreateCertForm();
			dlg.edtStoreName.Text = cbLocation.Text + "; " + cbName.Text;

			if (dlg.ShowDialog() == DialogResult.OK) {
				PrepareStore(dlg);

			Certificate issuer = certificateStore1.Items[lvCertificates.SelectedIndices[0]];
				Certificate cert = certificateStore1.CreateSigned(issuer, dlg.BuildSubjectString(), Convert.ToInt32(dlg.edtSerial.Text));
				certificateStore1.Items.Add(cert);
				cert.FriendlyName = dlg.edtFriendlyName.Text;

				InstallCerts();

				btnLoad_Click(null, null);
			}
		}
	}
}
