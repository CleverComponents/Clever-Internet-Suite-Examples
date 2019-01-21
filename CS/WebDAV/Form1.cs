using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace WebDAV
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edtHost;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edtUser;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox edtPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbDepth;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnGoUp;
		private System.Windows.Forms.Button btnCapabilities;
		private System.Windows.Forms.Button btnGetAllProps;
		private System.Windows.Forms.Button btnModifyProp;
		private System.Windows.Forms.Button btnMakeDir;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnLock;
		private System.Windows.Forms.Button btnUnlock;
		private System.Windows.Forms.Button btnCopyMove;
		private System.Windows.Forms.Button btnDownload;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private CleverComponents.InetSuite.WebDav webDav1;
		private System.Windows.Forms.ListView lvResources;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			cbDepth.SelectedIndex = 0;
			resources = new StringCollection();
			locks = new StringCollection();

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
			CleverComponents.InetSuite.WebDavNameSpace webDavNameSpace1 = new CleverComponents.InetSuite.WebDavNameSpace();
			this.label1 = new System.Windows.Forms.Label();
			this.edtHost = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edtUser = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbDepth = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lvResources = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnGoUp = new System.Windows.Forms.Button();
			this.btnCapabilities = new System.Windows.Forms.Button();
			this.btnGetAllProps = new System.Windows.Forms.Button();
			this.btnModifyProp = new System.Windows.Forms.Button();
			this.btnMakeDir = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnLock = new System.Windows.Forms.Button();
			this.btnUnlock = new System.Windows.Forms.Button();
			this.btnCopyMove = new System.Windows.Forms.Button();
			this.btnDownload = new System.Windows.Forms.Button();
			this.btnUpload = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.webDav1 = new CleverComponents.InetSuite.WebDav();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Host";
			// 
			// edtHost
			// 
			this.edtHost.Location = new System.Drawing.Point(64, 16);
			this.edtHost.Name = "edtHost";
			this.edtHost.Size = new System.Drawing.Size(328, 20);
			this.edtHost.TabIndex = 1;
			this.edtHost.Text = "http://localhost/WebDAV/";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "User";
			// 
			// edtUser
			// 
			this.edtUser.Location = new System.Drawing.Point(64, 48);
			this.edtUser.Name = "edtUser";
			this.edtUser.Size = new System.Drawing.Size(112, 20);
			this.edtUser.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(208, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Password";
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(272, 48);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.PasswordChar = '*';
			this.edtPassword.Size = new System.Drawing.Size(120, 20);
			this.edtPassword.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Depth";
			// 
			// cbDepth
			// 
			this.cbDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDepth.Items.AddRange(new object[] {
            "Default",
            "Resource Only",
            "Resource and Children",
            "Infinity"});
			this.cbDepth.Location = new System.Drawing.Point(64, 80);
			this.cbDepth.Name = "cbDepth";
			this.cbDepth.Size = new System.Drawing.Size(112, 21);
			this.cbDepth.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 118);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "Resources";
			// 
			// lvResources
			// 
			this.lvResources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.lvResources.FullRowSelect = true;
			this.lvResources.HideSelection = false;
			this.lvResources.Location = new System.Drawing.Point(16, 136);
			this.lvResources.Name = "lvResources";
			this.lvResources.Size = new System.Drawing.Size(376, 264);
			this.lvResources.TabIndex = 9;
			this.lvResources.UseCompatibleStateImageBehavior = false;
			this.lvResources.View = System.Windows.Forms.View.Details;
			this.lvResources.DoubleClick += new System.EventHandler(this.lvResources_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Path";
			this.columnHeader1.Width = 350;
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(408, 16);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(88, 23);
			this.btnOpen.TabIndex = 10;
			this.btnOpen.Text = "Open";
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnGoUp
			// 
			this.btnGoUp.Location = new System.Drawing.Point(408, 48);
			this.btnGoUp.Name = "btnGoUp";
			this.btnGoUp.Size = new System.Drawing.Size(88, 23);
			this.btnGoUp.TabIndex = 11;
			this.btnGoUp.Text = "Go Up";
			this.btnGoUp.Click += new System.EventHandler(this.btnGoUp_Click);
			// 
			// btnCapabilities
			// 
			this.btnCapabilities.Location = new System.Drawing.Point(408, 88);
			this.btnCapabilities.Name = "btnCapabilities";
			this.btnCapabilities.Size = new System.Drawing.Size(88, 23);
			this.btnCapabilities.TabIndex = 12;
			this.btnCapabilities.Text = "Capabilities";
			this.btnCapabilities.Click += new System.EventHandler(this.btnCapabilities_Click);
			// 
			// btnGetAllProps
			// 
			this.btnGetAllProps.Location = new System.Drawing.Point(408, 120);
			this.btnGetAllProps.Name = "btnGetAllProps";
			this.btnGetAllProps.Size = new System.Drawing.Size(88, 23);
			this.btnGetAllProps.TabIndex = 13;
			this.btnGetAllProps.Text = "Get All Props";
			this.btnGetAllProps.Click += new System.EventHandler(this.btnGetAllProps_Click);
			// 
			// btnModifyProp
			// 
			this.btnModifyProp.Location = new System.Drawing.Point(408, 152);
			this.btnModifyProp.Name = "btnModifyProp";
			this.btnModifyProp.Size = new System.Drawing.Size(88, 23);
			this.btnModifyProp.TabIndex = 14;
			this.btnModifyProp.Text = "Modify Prop";
			this.btnModifyProp.Click += new System.EventHandler(this.btnModifyProp_Click);
			// 
			// btnMakeDir
			// 
			this.btnMakeDir.Location = new System.Drawing.Point(408, 184);
			this.btnMakeDir.Name = "btnMakeDir";
			this.btnMakeDir.Size = new System.Drawing.Size(88, 23);
			this.btnMakeDir.TabIndex = 15;
			this.btnMakeDir.Text = "Make Dir";
			this.btnMakeDir.Click += new System.EventHandler(this.btnMakeDir_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(408, 216);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(88, 23);
			this.btnDelete.TabIndex = 16;
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnLock
			// 
			this.btnLock.Location = new System.Drawing.Point(408, 248);
			this.btnLock.Name = "btnLock";
			this.btnLock.Size = new System.Drawing.Size(88, 23);
			this.btnLock.TabIndex = 17;
			this.btnLock.Text = "Lock Resource";
			this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
			// 
			// btnUnlock
			// 
			this.btnUnlock.Location = new System.Drawing.Point(408, 280);
			this.btnUnlock.Name = "btnUnlock";
			this.btnUnlock.Size = new System.Drawing.Size(88, 23);
			this.btnUnlock.TabIndex = 18;
			this.btnUnlock.Text = "Unlock";
			this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
			// 
			// btnCopyMove
			// 
			this.btnCopyMove.Location = new System.Drawing.Point(408, 312);
			this.btnCopyMove.Name = "btnCopyMove";
			this.btnCopyMove.Size = new System.Drawing.Size(88, 23);
			this.btnCopyMove.TabIndex = 19;
			this.btnCopyMove.Text = "Copy / Move";
			this.btnCopyMove.Click += new System.EventHandler(this.btnCopyMove_Click);
			// 
			// btnDownload
			// 
			this.btnDownload.Location = new System.Drawing.Point(408, 344);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(88, 23);
			this.btnDownload.TabIndex = 20;
			this.btnDownload.Text = "Download";
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(408, 376);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(88, 23);
			this.btnUpload.TabIndex = 21;
			this.btnUpload.Text = "Upload";
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// webDav1
			// 
			this.webDav1.CharSet = null;
			this.webDav1.LockOwner = null;
			this.webDav1.LockTimeOut = "Infinite, Second-86400";
			webDavNameSpace1.NameSpace = "DAV:";
			webDavNameSpace1.Prefix = "D";
			this.webDav1.NameSpaces.Add(webDavNameSpace1);
			this.webDav1.TlsFlags = ((CleverComponents.InetSuite.Sspi.TlsFlags)((CleverComponents.InetSuite.Sspi.TlsFlags.UseSSL2 | CleverComponents.InetSuite.Sspi.TlsFlags.UseSSL3)));
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 414);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.btnDownload);
			this.Controls.Add(this.btnCopyMove);
			this.Controls.Add(this.btnUnlock);
			this.Controls.Add(this.btnLock);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnMakeDir);
			this.Controls.Add(this.btnModifyProp);
			this.Controls.Add(this.btnGetAllProps);
			this.Controls.Add(this.btnCapabilities);
			this.Controls.Add(this.btnGoUp);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.lvResources);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbDepth);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.edtPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.edtUser);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.edtHost);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "Web DAV client";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(new ExceptionHandler().OnThreadException);
			Application.Run(new Form1());
		}

		string currentDir;
		StringCollection resources;
		StringCollection locks;

		private void btnOpen_Click(object sender, System.EventArgs e) {
			webDav1.UserName = edtUser.Text;
			webDav1.Password = edtPassword.Text;

			webDav1.Depth = (WebDavDepth)cbDepth.SelectedIndex;
			webDav1.ListDir(edtHost.Text);
			currentDir = edtHost.Text;

			lvResources.Items.Clear();

			foreach(WebDavProperty prop in webDav1.ResourceProperties) {
				ListViewItem item = lvResources.Items.Add(prop.Uri);
			}
		}

		private void btnGoUp_Click(object sender, System.EventArgs e) {
			string s = edtHost.Text;
			if(StringUtils.IsEmpty(s)) return;

			if(s[s.Length - 1] == '/') {
				s = s.Substring(0, s.Length - 1);
			}
			int ind = s.LastIndexOf('/');
			if(ind > -1) {
				s = s.Substring(0, ind + 1);
			}
			edtHost.Text = s;
			currentDir = edtHost.Text;
			btnOpen_Click(null, null);
		}

		private void btnCapabilities_Click(object sender, System.EventArgs e) {
			webDav1.UserName = edtUser.Text;
			webDav1.Password = edtPassword.Text;

			string url = edtHost.Text;
			if(lvResources.SelectedItems.Count > 0) {
				url = lvResources.SelectedItems[0].Text;
			}

			webDav1.GetCapabilities(url);

			StringCollectionEx list = new StringCollectionEx();

			list.Add("WebDav Class: " + webDav1.Capabilities.WebDavClass);

			list.Add("");
			list.Add("Allowed Methods:");
			list.AddRange(webDav1.Capabilities.AllowedMethods);

			list.Add("");
			list.Add("Public Methods:");
			list.AddRange(webDav1.Capabilities.PublicMethods);

			ViewPropsForm dlg = new ViewPropsForm();

			dlg.Text = "WebDAV Capabilities";
			dlg.textBox1.Lines = list.ToArray();
			dlg.textBox1.Select(0, 0);

			dlg.ShowDialog();
		}

		private void btnGetAllProps_Click(object sender, System.EventArgs e) {
			webDav1.UserName = edtUser.Text;
			webDav1.Password = edtPassword.Text;

			if(cbDepth.SelectedIndex == 0) {
				webDav1.Depth = WebDavDepth.ResourceOnly;
			}
			else {
				webDav1.Depth = (WebDavDepth)cbDepth.SelectedIndex;
			}

			string url = edtHost.Text;
			if(lvResources.SelectedItems.Count > 0) {
				url = lvResources.SelectedItems[0].Text;
			}

			webDav1.GetAllProperties(url);
			webDav1.GetActiveLocks(url);

			StringCollectionEx list = new StringCollectionEx();
			list.Add(url);
			list.Add("");
			list.Add("Properties:");

			foreach(WebDavProperty prop in webDav1.ResourceProperties) {
				list.Add(prop.Name + " = " + prop.Value);
			}

			list.Add("");
			list.Add("Active Locks:");

			foreach(WebDavLock item in webDav1.ActiveLocks) {
				list.Add("Owner: " + item.Owner);
				list.Add("Lock Token: " + item.LockToken);
				list.Add("Lock Type: " + item.LockType);
				list.Add("Lock Timeout: " + item.TimeOut);
			}

			ViewPropsForm dlg = new ViewPropsForm();
			dlg.Text = "View Resource Properties";
			dlg.textBox1.Lines = list.ToArray();
			dlg.textBox1.Select(0, 0);

			dlg.ShowDialog();
		}

		private void btnModifyProp_Click(object sender, System.EventArgs e) {
			webDav1.UserName = edtUser.Text;
			webDav1.Password = edtPassword.Text;
			webDav1.Depth = (WebDavDepth)cbDepth.SelectedIndex;

			string url = edtHost.Text;
			if(lvResources.SelectedItems.Count > 0) {
				url = lvResources.SelectedItems[0].Text;
			}

			ModifyPropForm dlg = new ModifyPropForm();

			dlg.lblResource.Text = url;
			switch(dlg.ShowDialog()) {
				case DialogResult.Yes:
					webDav1.SetProperties(url, new string[] { dlg.edtName.Text }, new string[] { dlg.edtValue.Text });
					MessageBox.Show("Property '" + dlg.edtName.Text + "' added / modified.");
					break;
				case DialogResult.No:
					webDav1.RemoveProperties(url, new string[] { dlg.edtName.Text });
					MessageBox.Show("Property '" + dlg.edtName.Text + "' removed.");
					break;
			}
		}

		private void btnMakeDir_Click(object sender, System.EventArgs e) {
			webDav1.UserName = edtUser.Text;
			webDav1.Password = edtPassword.Text;
			webDav1.Depth = (WebDavDepth)cbDepth.SelectedIndex;

			string newDir = edtHost.Text;
			if(lvResources.SelectedItems.Count > 0) {
				newDir = lvResources.SelectedItems[0].Text;
			}

			MakeDirForm dlg = new MakeDirForm();
			dlg.edtValue.Text = newDir;
			if(dlg.ShowDialog() == DialogResult.OK) {
				webDav1.MakeDir(dlg.edtValue.Text);
				btnOpen_Click(null, null);
			}
		}

		private void btnDelete_Click(object sender, System.EventArgs e) {
			webDav1.UserName = edtUser.Text;
			webDav1.Password = edtPassword.Text;
			webDav1.Depth = (WebDavDepth)cbDepth.SelectedIndex;

			if(lvResources.SelectedItems.Count == 0) {
				throw new Exception("Please select a resource");
			}

			string url = lvResources.SelectedItems[0].Text;

			if(MessageBox.Show("Do you want to delete " + url + " ?",
				"Delete Resource", MessageBoxButtons.YesNo) == DialogResult.Yes) {
				webDav1.Delete(url);
				btnOpen_Click(null, null);
			}
		}

		private void btnLock_Click(object sender, System.EventArgs e) {
			webDav1.UserName = edtUser.Text;
			webDav1.Password = edtPassword.Text;

			webDav1.Depth = (WebDavDepth)cbDepth.SelectedIndex;
			webDav1.LockOwner = "WebDAV tester";
			webDav1.LockScope = WebDavLockScope.Exclusive;

			string url = edtHost.Text;
			if(lvResources.SelectedItems.Count > 0) {
				url = lvResources.SelectedItems[0].Text;
			}

			string lockToken = webDav1.Lock(url);
			resources.Add(url);
			locks.Add(lockToken);

			MessageBox.Show("The " + url + " resource has been locked successfully.\r\n\r\n Lock Token = " + lockToken);
		}

		private void btnUnlock_Click(object sender, System.EventArgs e) {
			webDav1.UserName = edtUser.Text;
			webDav1.Password = edtPassword.Text;

			webDav1.Depth = (WebDavDepth)cbDepth.SelectedIndex;
			webDav1.LockOwner = "WebDAV tester";
			webDav1.LockScope = WebDavLockScope.Exclusive;

			string url = edtHost.Text;
			if(lvResources.SelectedItems.Count > 0) {
				url = lvResources.SelectedItems[0].Text;
			}

			for (int i = 0; i < resources.Count; i++) {
				if (String.Compare(resources[i], url, true) == 0) {
					webDav1.Unlock(url, locks[i]);
				}
			}

			MessageBox.Show("The " + url + " resource has been unlocked.");
		}

		private void btnCopyMove_Click(object sender, System.EventArgs e) {
			webDav1.UserName = edtUser.Text;
			webDav1.Password = edtPassword.Text;
			webDav1.Depth = (WebDavDepth)cbDepth.SelectedIndex;

			string url = edtHost.Text;
			if(lvResources.SelectedItems.Count > 0) {
				url = lvResources.SelectedItems[0].Text;
			}

			CopyMoveForm dlg = new CopyMoveForm();
			dlg.edtSource.Text = url;
			if(dlg.ShowDialog() == DialogResult.OK) {
				if(dlg.cbIsMove.Checked) {
					webDav1.Move(dlg.edtSource.Text, dlg.edtDestination.Text);
				}
				else {
					webDav1.Copy(dlg.edtSource.Text, dlg.edtDestination.Text);
				}

				btnOpen_Click(null, null);
			}
		}

		private void btnDownload_Click(object sender, System.EventArgs e) {
			webDav1.UserName = edtUser.Text;
			webDav1.Password = edtPassword.Text;
			webDav1.Depth = (WebDavDepth)cbDepth.SelectedIndex;

			string url = edtHost.Text;
			if(lvResources.SelectedItems.Count > 0) {
				url = lvResources.SelectedItems[0].Text;
			}

			if(saveFileDialog1.ShowDialog() == DialogResult.OK) {
				using(Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.CreateNew)) {
					webDav1.Get(url, stream);
				}
				MessageBox.Show("The resource has been downloaded and stored in to " + saveFileDialog1.FileName);
			}
		}

		private void btnUpload_Click(object sender, System.EventArgs e) {
			webDav1.UserName = edtUser.Text;
			webDav1.Password = edtPassword.Text;
			webDav1.Depth = (WebDavDepth)cbDepth.SelectedIndex;

			string url = edtHost.Text;
			if(lvResources.SelectedItems.Count > 0) {
				url = lvResources.SelectedItems[0].Text;
			}

			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				using(Stream stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read)) {
					webDav1.Put(url + "/" + Path.GetFileName(openFileDialog1.FileName), stream);
				}

				btnOpen_Click(null, null);
				MessageBox.Show("The file has been uploaded in to " + url);
			}
		}

		private void lvResources_DoubleClick(object sender, System.EventArgs e) {
			if(lvResources.SelectedItems.Count > 0) {
				edtHost.Text = lvResources.SelectedItems[0].Text;
			}
			btnOpen_Click(null, null);
		}
	}

	public class ExceptionHandler {
		public void OnThreadException(object sender, System.Threading.ThreadExceptionEventArgs t) {
			MessageBox.Show(t.Exception.Message);
		}
	}
}
