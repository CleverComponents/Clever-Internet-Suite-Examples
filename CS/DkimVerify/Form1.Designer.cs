namespace DkimVerify {
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
			this.btnCheckMail = new System.Windows.Forms.Button();
			this.mailMessage1 = new CleverComponents.InetSuite.MailMessage();
			this.dkim1 = new CleverComponents.InetSuite.Dkim();
			this.pop3 = new CleverComponents.InetSuite.Pop3();
			this.lbMessages = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pop3)).BeginInit();
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
			this.edtServer.Size = new System.Drawing.Size(503, 20);
			this.edtServer.TabIndex = 1;
			this.edtServer.Text = "localhost";
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(89, 35);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(55, 20);
			this.edtPort.TabIndex = 3;
			this.edtPort.Text = "110";
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
			this.edtUser.Location = new System.Drawing.Point(233, 35);
			this.edtUser.Name = "edtUser";
			this.edtUser.Size = new System.Drawing.Size(161, 20);
			this.edtUser.TabIndex = 5;
			this.edtUser.Text = "CleverTester";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(184, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "User";
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(481, 35);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.PasswordChar = '*';
			this.edtPassword.Size = new System.Drawing.Size(111, 20);
			this.edtPassword.TabIndex = 7;
			this.edtPassword.Text = "clevertester";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(422, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Password";
			// 
			// btnCheckMail
			// 
			this.btnCheckMail.Location = new System.Drawing.Point(89, 80);
			this.btnCheckMail.Name = "btnCheckMail";
			this.btnCheckMail.Size = new System.Drawing.Size(124, 23);
			this.btnCheckMail.TabIndex = 29;
			this.btnCheckMail.Text = "Check Mail";
			this.btnCheckMail.UseVisualStyleBackColor = true;
			this.btnCheckMail.Click += new System.EventHandler(this.btnCheckMail_Click);
			// 
			// mailMessage1
			// 
			this.mailMessage1.Date = new System.DateTime(2017, 9, 3, 21, 13, 40, 837);
			this.mailMessage1.Dkim = this.dkim1;
			this.mailMessage1.From.Email = "";
			this.mailMessage1.From.Name = "";
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
			// pop3
			// 
			this.pop3.MailMessage = this.mailMessage1;
			// 
			// lbMessages
			// 
			this.lbMessages.FormattingEnabled = true;
			this.lbMessages.Location = new System.Drawing.Point(15, 148);
			this.lbMessages.Name = "lbMessages";
			this.lbMessages.Size = new System.Drawing.Size(577, 186);
			this.lbMessages.TabIndex = 30;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 122);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 31;
			this.label5.Text = "Messages";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 346);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lbMessages);
			this.Controls.Add(this.btnCheckMail);
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
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pop3)).EndInit();
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
		private System.Windows.Forms.Button btnCheckMail;
		private CleverComponents.InetSuite.MailMessage mailMessage1;
		private CleverComponents.InetSuite.Dkim dkim1;
		private CleverComponents.InetSuite.Pop3 pop3;
		private System.Windows.Forms.ListBox lbMessages;
		private System.Windows.Forms.Label label5;
	}
}

