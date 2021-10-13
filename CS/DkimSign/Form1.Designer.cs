namespace DkimSign {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.edtServer = new System.Windows.Forms.TextBox();
			this.edtPort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edtUser = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edtDkimDomain = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.edtDkimSelector = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.edtSignFields = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.mmPrivateKey = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.edtDnsTxtName = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.edtDnsTxtValue = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.edtFrom = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.edtTo = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.edtSubject = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.mmBody = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.smtp1 = new CleverComponents.InetSuite.Smtp();
			this.mailMessage1 = new CleverComponents.InetSuite.MailMessage();
			this.dkim1 = new CleverComponents.InetSuite.Dkim();
			((System.ComponentModel.ISupportInitialize)(this.smtp1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server";
			// 
			// edtServer
			// 
			this.edtServer.Location = new System.Drawing.Point(89, 9);
			this.edtServer.Name = "edtServer";
			this.edtServer.Size = new System.Drawing.Size(187, 20);
			this.edtServer.TabIndex = 1;
			this.edtServer.Text = "localhost";
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(89, 35);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(55, 20);
			this.edtPort.TabIndex = 3;
			this.edtPort.Text = "25";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Port";
			// 
			// edtUser
			// 
			this.edtUser.Location = new System.Drawing.Point(405, 9);
			this.edtUser.Name = "edtUser";
			this.edtUser.Size = new System.Drawing.Size(187, 20);
			this.edtUser.TabIndex = 5;
			this.edtUser.Text = "CleverTester";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(328, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "User";
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(405, 35);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.PasswordChar = '*';
			this.edtPassword.Size = new System.Drawing.Size(187, 20);
			this.edtPassword.TabIndex = 7;
			this.edtPassword.Text = "clevertester";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(328, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Password";
			// 
			// edtDkimDomain
			// 
			this.edtDkimDomain.Location = new System.Drawing.Point(89, 81);
			this.edtDkimDomain.Name = "edtDkimDomain";
			this.edtDkimDomain.Size = new System.Drawing.Size(187, 20);
			this.edtDkimDomain.TabIndex = 9;
			this.edtDkimDomain.Text = "example.com";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "DKIM domain";
			// 
			// edtDkimSelector
			// 
			this.edtDkimSelector.Location = new System.Drawing.Point(405, 81);
			this.edtDkimSelector.Name = "edtDkimSelector";
			this.edtDkimSelector.Size = new System.Drawing.Size(187, 20);
			this.edtDkimSelector.TabIndex = 11;
			this.edtDkimSelector.Text = "sample";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(328, 84);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "DKIM selector";
			// 
			// edtSignFields
			// 
			this.edtSignFields.Location = new System.Drawing.Point(89, 107);
			this.edtSignFields.Name = "edtSignFields";
			this.edtSignFields.Size = new System.Drawing.Size(503, 20);
			this.edtSignFields.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 110);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Fields to sign";
			// 
			// mmPrivateKey
			// 
			this.mmPrivateKey.Location = new System.Drawing.Point(89, 133);
			this.mmPrivateKey.Multiline = true;
			this.mmPrivateKey.Name = "mmPrivateKey";
			this.mmPrivateKey.Size = new System.Drawing.Size(503, 65);
			this.mmPrivateKey.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 136);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Private Key";
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(89, 204);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 16;
			this.btnLoad.Text = "Load...";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(170, 204);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 17;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// edtDnsTxtName
			// 
			this.edtDnsTxtName.Location = new System.Drawing.Point(89, 246);
			this.edtDnsTxtName.Name = "edtDnsTxtName";
			this.edtDnsTxtName.Size = new System.Drawing.Size(503, 20);
			this.edtDnsTxtName.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 249);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(73, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "DNS txt name";
			// 
			// edtDnsTxtValue
			// 
			this.edtDnsTxtValue.Location = new System.Drawing.Point(89, 272);
			this.edtDnsTxtValue.Name = "edtDnsTxtValue";
			this.edtDnsTxtValue.Size = new System.Drawing.Size(503, 20);
			this.edtDnsTxtValue.TabIndex = 21;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 275);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(73, 13);
			this.label10.TabIndex = 20;
			this.label10.Text = "DNS txt value";
			// 
			// edtFrom
			// 
			this.edtFrom.Location = new System.Drawing.Point(89, 312);
			this.edtFrom.Name = "edtFrom";
			this.edtFrom.Size = new System.Drawing.Size(503, 20);
			this.edtFrom.TabIndex = 23;
			this.edtFrom.Text = "steve@example.com";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 315);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(30, 13);
			this.label11.TabIndex = 22;
			this.label11.Text = "From";
			// 
			// edtTo
			// 
			this.edtTo.Location = new System.Drawing.Point(89, 338);
			this.edtTo.Name = "edtTo";
			this.edtTo.Size = new System.Drawing.Size(503, 20);
			this.edtTo.TabIndex = 25;
			this.edtTo.Text = "johndoe@domain.com";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(12, 341);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(20, 13);
			this.label12.TabIndex = 24;
			this.label12.Text = "To";
			// 
			// edtSubject
			// 
			this.edtSubject.Location = new System.Drawing.Point(89, 364);
			this.edtSubject.Name = "edtSubject";
			this.edtSubject.Size = new System.Drawing.Size(503, 20);
			this.edtSubject.TabIndex = 27;
			this.edtSubject.Text = "Sample message with DKIM signature";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(12, 367);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(43, 13);
			this.label13.TabIndex = 26;
			this.label13.Text = "Subject";
			// 
			// mmBody
			// 
			this.mmBody.Location = new System.Drawing.Point(15, 390);
			this.mmBody.Multiline = true;
			this.mmBody.Name = "mmBody";
			this.mmBody.Size = new System.Drawing.Size(577, 65);
			this.mmBody.TabIndex = 28;
			this.mmBody.Text = "This is a sample email with DKIM signature.";
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(517, 461);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 29;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// mailMessage1
			// 
			this.mailMessage1.Date = new System.DateTime(2017, 9, 3, 21, 13, 40, 837);
			this.mailMessage1.Dkim = this.dkim1;
			// 
			// dkim1
			// 
			this.dkim1.SignatureExpiration = new System.DateTime(((long)(0)));
			this.dkim1.SignatureTimestamp = new System.DateTime(((long)(0)));
			this.dkim1.SignedHeaderFields = new string[] {
        "Date",
        "From",
        "To",
        "Subject",
        "MIME-Version",
        "Content-Type"};
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 493);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.mmBody);
			this.Controls.Add(this.edtSubject);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.edtTo);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.edtFrom);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.edtDnsTxtValue);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.edtDnsTxtName);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.mmPrivateKey);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.edtSignFields);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.edtDkimSelector);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.edtDkimDomain);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.edtPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.edtUser);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.edtPort);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.edtServer);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Send E-mail with DKIM signature - Sample";
			this.Shown += new System.EventHandler(this.Form1_Shown);
			((System.ComponentModel.ISupportInitialize)(this.smtp1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edtServer;
		private System.Windows.Forms.TextBox edtPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edtUser;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox edtPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edtDkimDomain;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox edtDkimSelector;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox edtSignFields;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox mmPrivateKey;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.TextBox edtDnsTxtName;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox edtDnsTxtValue;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox edtFrom;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox edtTo;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox edtSubject;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox mmBody;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private CleverComponents.InetSuite.Smtp smtp1;
		private CleverComponents.InetSuite.MailMessage mailMessage1;
		private CleverComponents.InetSuite.Dkim dkim1;
	}
}

