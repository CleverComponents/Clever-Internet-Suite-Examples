using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using CleverComponents.InetSuite;

namespace SMime
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edtFrom;
		private System.Windows.Forms.TextBox edtToList;
		private System.Windows.Forms.TextBox edtSubject;
		private System.Windows.Forms.Button btnNewMessage;
		private System.Windows.Forms.Button btnViewCertificates;
		private System.Windows.Forms.Button btnSign;
		private System.Windows.Forms.Button btnVerify;
		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.Button btnDecrypt;
		private System.Windows.Forms.Button btnSignEncrypt;
		private System.Windows.Forms.Button btnVerifyDecrypt;
		private System.Windows.Forms.CheckBox cbDetachedSignature;
		private System.Windows.Forms.CheckBox cbIncludeCertificate;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.TextBox memText;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private CleverComponents.InetSuite.SMimeMessage sMimeMessage1;
		private CleverComponents.InetSuite.CertificateStore certificateStore1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			edtFrom.Text = GetCertDialog.DefaultEmail;
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.edtFrom = new System.Windows.Forms.TextBox();
			this.edtToList = new System.Windows.Forms.TextBox();
			this.edtSubject = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.memText = new System.Windows.Forms.TextBox();
			this.btnNewMessage = new System.Windows.Forms.Button();
			this.btnViewCertificates = new System.Windows.Forms.Button();
			this.btnSign = new System.Windows.Forms.Button();
			this.btnVerify = new System.Windows.Forms.Button();
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.btnDecrypt = new System.Windows.Forms.Button();
			this.btnSignEncrypt = new System.Windows.Forms.Button();
			this.btnVerifyDecrypt = new System.Windows.Forms.Button();
			this.cbDetachedSignature = new System.Windows.Forms.CheckBox();
			this.cbIncludeCertificate = new System.Windows.Forms.CheckBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.sMimeMessage1 = new CleverComponents.InetSuite.SMimeMessage();
			this.certificateStore1 = new CleverComponents.InetSuite.CertificateStore();
			((System.ComponentModel.ISupportInitialize)(this.sMimeMessage1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "From";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "To List";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Subject";
			// 
			// edtFrom
			// 
			this.edtFrom.Location = new System.Drawing.Point(72, 72);
			this.edtFrom.Name = "edtFrom";
			this.edtFrom.Size = new System.Drawing.Size(432, 20);
			this.edtFrom.TabIndex = 3;
			this.edtFrom.Text = "test@myhost.com";
			// 
			// edtToList
			// 
			this.edtToList.Location = new System.Drawing.Point(72, 96);
			this.edtToList.Name = "edtToList";
			this.edtToList.Size = new System.Drawing.Size(432, 20);
			this.edtToList.TabIndex = 4;
			this.edtToList.Text = "john@nexthost.com,doe@thirdhost.com";
			// 
			// edtSubject
			// 
			this.edtSubject.Location = new System.Drawing.Point(72, 120);
			this.edtSubject.Name = "edtSubject";
			this.edtSubject.Size = new System.Drawing.Size(432, 20);
			this.edtSubject.TabIndex = 5;
			this.edtSubject.Text = "Clever SMime Message Parser Test";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Body";
			// 
			// memText
			// 
			this.memText.Location = new System.Drawing.Point(8, 168);
			this.memText.Multiline = true;
			this.memText.Name = "memText";
			this.memText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memText.Size = new System.Drawing.Size(496, 112);
			this.memText.TabIndex = 8;
			this.memText.Text = "This is SMIME test message built using Clever Message Parser";
			// 
			// btnNewMessage
			// 
			this.btnNewMessage.Location = new System.Drawing.Point(8, 296);
			this.btnNewMessage.Name = "btnNewMessage";
			this.btnNewMessage.Size = new System.Drawing.Size(96, 23);
			this.btnNewMessage.TabIndex = 14;
			this.btnNewMessage.Text = "New Message";
			this.btnNewMessage.Click += new System.EventHandler(this.btnNewMessage_Click);
			// 
			// btnViewCertificates
			// 
			this.btnViewCertificates.Location = new System.Drawing.Point(8, 328);
			this.btnViewCertificates.Name = "btnViewCertificates";
			this.btnViewCertificates.Size = new System.Drawing.Size(96, 23);
			this.btnViewCertificates.TabIndex = 15;
			this.btnViewCertificates.Text = "View Certificates";
			this.btnViewCertificates.Click += new System.EventHandler(this.btnViewCertificates_Click);
			// 
			// btnSign
			// 
			this.btnSign.Location = new System.Drawing.Point(112, 296);
			this.btnSign.Name = "btnSign";
			this.btnSign.Size = new System.Drawing.Size(75, 23);
			this.btnSign.TabIndex = 16;
			this.btnSign.Text = "Sign...";
			this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
			// 
			// btnVerify
			// 
			this.btnVerify.Location = new System.Drawing.Point(112, 328);
			this.btnVerify.Name = "btnVerify";
			this.btnVerify.Size = new System.Drawing.Size(75, 23);
			this.btnVerify.TabIndex = 17;
			this.btnVerify.Text = "Verify...";
			this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Location = new System.Drawing.Point(192, 296);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
			this.btnEncrypt.TabIndex = 18;
			this.btnEncrypt.Text = "Encrypt...";
			this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Location = new System.Drawing.Point(192, 328);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
			this.btnDecrypt.TabIndex = 19;
			this.btnDecrypt.Text = "Decrypt...";
			this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
			// 
			// btnSignEncrypt
			// 
			this.btnSignEncrypt.Location = new System.Drawing.Point(272, 296);
			this.btnSignEncrypt.Name = "btnSignEncrypt";
			this.btnSignEncrypt.Size = new System.Drawing.Size(96, 23);
			this.btnSignEncrypt.TabIndex = 20;
			this.btnSignEncrypt.Text = "Sign/Encrypt...";
			this.btnSignEncrypt.Click += new System.EventHandler(this.btnSignEncrypt_Click);
			// 
			// btnVerifyDecrypt
			// 
			this.btnVerifyDecrypt.Location = new System.Drawing.Point(272, 328);
			this.btnVerifyDecrypt.Name = "btnVerifyDecrypt";
			this.btnVerifyDecrypt.Size = new System.Drawing.Size(96, 23);
			this.btnVerifyDecrypt.TabIndex = 21;
			this.btnVerifyDecrypt.Text = "Verify/Decrypt...";
			this.btnVerifyDecrypt.Click += new System.EventHandler(this.btnVerifyDecrypt_Click);
			// 
			// cbDetachedSignature
			// 
			this.cbDetachedSignature.Checked = true;
			this.cbDetachedSignature.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbDetachedSignature.Location = new System.Drawing.Point(376, 296);
			this.cbDetachedSignature.Name = "cbDetachedSignature";
			this.cbDetachedSignature.Size = new System.Drawing.Size(128, 24);
			this.cbDetachedSignature.TabIndex = 22;
			this.cbDetachedSignature.Text = "Detached Signature";
			this.cbDetachedSignature.CheckedChanged += new System.EventHandler(this.cbDetachedSignature_CheckedChanged);
			// 
			// cbIncludeCertificate
			// 
			this.cbIncludeCertificate.Checked = true;
			this.cbIncludeCertificate.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbIncludeCertificate.Location = new System.Drawing.Point(376, 328);
			this.cbIncludeCertificate.Name = "cbIncludeCertificate";
			this.cbIncludeCertificate.Size = new System.Drawing.Size(128, 24);
			this.cbIncludeCertificate.TabIndex = 23;
			this.cbIncludeCertificate.Text = "Include Certificate";
			this.cbIncludeCertificate.CheckedChanged += new System.EventHandler(this.cbDetachedSignature_CheckedChanged);
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "Emails (*.eml)|*.eml|All (*.*)|*.*";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "Emails (*.eml)|*.eml|All (*.*)|*.*";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(472, 16);
			this.label7.TabIndex = 26;
			this.label7.Text = "This demo creates and signs / encodes the mail message and stores it to file on t" +
				"he disk.";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(464, 32);
			this.label8.TabIndex = 27;
			this.label8.Text = "If you have a mail message, already stored on the  disk, you can load it and decr" +
				"ypt / verify  the message  digital signature.  Please see Readme.txt for more de" +
				"tails.";
			// 
			// sMimeMessage1
			// 
			this.sMimeMessage1.Date = new System.DateTime(2006, 5, 5, 17, 31, 12, 0);
			this.sMimeMessage1.From.Email = "";
			this.sMimeMessage1.From.Name = "";
			this.sMimeMessage1.GetSigningCertificate += new CleverComponents.InetSuite.GetCertificateEventHandler(this.sMimeMessage1_GetSigningCertificate);
			this.sMimeMessage1.GetEncryptionCertificate += new CleverComponents.InetSuite.GetCertificateEventHandler(this.sMimeMessage1_GetEncryptionCertificate);
			// 
			// certificateStore1
			// 
			this.certificateStore1.ValidFrom = new System.DateTime(2010, 7, 23, 1, 35, 20, 231);
			this.certificateStore1.ValidTo = new System.DateTime(2011, 7, 23, 1, 35, 20, 231);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(514, 360);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbIncludeCertificate);
			this.Controls.Add(this.cbDetachedSignature);
			this.Controls.Add(this.btnVerifyDecrypt);
			this.Controls.Add(this.btnSignEncrypt);
			this.Controls.Add(this.btnDecrypt);
			this.Controls.Add(this.btnEncrypt);
			this.Controls.Add(this.btnVerify);
			this.Controls.Add(this.btnSign);
			this.Controls.Add(this.btnViewCertificates);
			this.Controls.Add(this.btnNewMessage);
			this.Controls.Add(this.memText);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.edtSubject);
			this.Controls.Add(this.edtToList);
			this.Controls.Add(this.edtFrom);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "SMIME Message";
			((System.ComponentModel.ISupportInitialize)(this.sMimeMessage1)).EndInit();
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
			Application.Run(new MainForm());
		}

		private void NewMessage() {
			edtFrom.Text = GetCertDialog.DefaultEmail;
			edtToList.Text = "";
			edtSubject.Text = "";
			memText.Text = "";
		}

		private void BuildMessage() {
			sMimeMessage1.BuildMessage(memText.Text, "");
			sMimeMessage1.From.FullAddress = edtFrom.Text;
			sMimeMessage1.ToList.EmailAddresses = edtToList.Text;
			sMimeMessage1.Subject = edtSubject.Text;
		}

		private void FillControls() {
			edtFrom.Text = sMimeMessage1.From.FullAddress;
			edtToList.Text = sMimeMessage1.ToList.EmailAddresses;
			edtSubject.Text = sMimeMessage1.Subject;
		    memText.Lines = sMimeMessage1.MessageText;
		}

		private void cbDetachedSignature_CheckedChanged(object sender, System.EventArgs e) {
			sMimeMessage1.IsDetachedSignature = cbDetachedSignature.Checked;
			sMimeMessage1.IsIncludeCertificate = cbIncludeCertificate.Checked;
		}

		private void btnNewMessage_Click(object sender, System.EventArgs e) {
			NewMessage();
		}

		private void btnViewCertificates_Click(object sender, System.EventArgs e) {
			CertListForm.ShowCertificates(sMimeMessage1.Certificates);
		}

		private void btnSign_Click(object sender, System.EventArgs e) {
			if(saveFileDialog.ShowDialog() == DialogResult.OK) {
				BuildMessage();
				sMimeMessage1.Sign();

				using(StreamWriter w = new StreamWriter(saveFileDialog.FileName)) {
					w.Write(StringUtils.GetStringsAsString(sMimeMessage1.MessageSource));
				}

				MessageBox.Show("The signed message is saved to " + saveFileDialog.FileName);
			}
		}

		private void btnVerify_Click(object sender, System.EventArgs e) {
			if(openFileDialog.ShowDialog() == DialogResult.OK) {
				NewMessage();
				using(StreamReader sr = File.OpenText(openFileDialog.FileName)) {
					sMimeMessage1.MessageSource = StringUtils.GetStringArray(sr.ReadToEnd());
				}

				sMimeMessage1.Verify();
				FillControls();
				MessageBox.Show("The signed message " + openFileDialog.FileName + " is verified.");
			}
		}

		private void btnEncrypt_Click(object sender, System.EventArgs e) {
			if(saveFileDialog.ShowDialog() == DialogResult.OK) {
				BuildMessage();
				sMimeMessage1.Encrypt();

				using(StreamWriter w = new StreamWriter(saveFileDialog.FileName)) {
					w.Write(StringUtils.GetStringsAsString(sMimeMessage1.MessageSource));
				}
				MessageBox.Show("The encrypted message is saved to " + saveFileDialog.FileName);
			}
		}

		private void btnDecrypt_Click(object sender, System.EventArgs e) {
			if(openFileDialog.ShowDialog() == DialogResult.OK) {
				NewMessage();
				using(StreamReader sr = File.OpenText(openFileDialog.FileName)) {
					sMimeMessage1.MessageSource = StringUtils.GetStringArray(sr.ReadToEnd());
				}

				sMimeMessage1.Decrypt();
				FillControls();
				MessageBox.Show("The encrypted message " + openFileDialog.FileName + " is decrypted.");
			}
		}

		private void btnSignEncrypt_Click(object sender, System.EventArgs e) {
			if(saveFileDialog.ShowDialog() == DialogResult.OK) {
				BuildMessage();
				sMimeMessage1.Sign();
				sMimeMessage1.Encrypt();

				using(StreamWriter w = new StreamWriter(saveFileDialog.FileName)) {
					w.Write(StringUtils.GetStringsAsString(sMimeMessage1.MessageSource));
				}
				MessageBox.Show("The encrypted and signed message is saved to " + saveFileDialog.FileName);
			}
		}

		private void btnVerifyDecrypt_Click(object sender, System.EventArgs e) {
			if(openFileDialog.ShowDialog() == DialogResult.OK) {
				NewMessage();
				using(StreamReader sr = File.OpenText(openFileDialog.FileName)) {
					sMimeMessage1.MessageSource = StringUtils.GetStringArray(sr.ReadToEnd());
				}
				sMimeMessage1.DecryptAndVerify();
				FillControls();
				MessageBox.Show("The secured message " + openFileDialog.FileName + " is decrypted and verified.");
			}
		}

		private void sMimeMessage1_GetEncryptionCertificate(object sender, GetCertificateEventArgs e) {
			GetCertDialog dlg = new GetCertDialog();

			dlg.Text = "Get encryption certificate";

			if (dlg.ShowDialog() == DialogResult.OK) {
				certificateStore1.Open(dlg.edtStore.Text);
				e.Certificate = certificateStore1.CertificateByEmail(dlg.edtEmail.Text);
				e.Handled = true;
			}
		}

		private void sMimeMessage1_GetSigningCertificate(object sender, GetCertificateEventArgs e) {
			GetCertDialog dlg = new GetCertDialog();

			dlg.Text = "Get signing certificate";

			if (dlg.ShowDialog() == DialogResult.OK) {
				certificateStore1.Open(dlg.edtStore.Text);
				e.Certificate = certificateStore1.CertificateByEmail(dlg.edtEmail.Text);
				e.Handled = true;
			}
		}

	}

	public class ExceptionHandler {
		public void OnThreadException(object sender, System.Threading.ThreadExceptionEventArgs t) {
			MessageBox.Show(t.Exception.Message);
		}
	}
}
