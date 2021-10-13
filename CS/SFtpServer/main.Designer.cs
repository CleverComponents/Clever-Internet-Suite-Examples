
namespace SFtpServer
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabServer = new System.Windows.Forms.TabPage();
			this.edtLog = new System.Windows.Forms.TextBox();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.edtRootDir = new System.Windows.Forms.TextBox();
			this.cbUseIPv6 = new System.Windows.Forms.CheckBox();
			this.edtBindingHost = new System.Windows.Forms.TextBox();
			this.edtPort = new System.Windows.Forms.TextBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.tabBanner = new System.Windows.Forms.TabPage();
			this.cbEnableBanner = new System.Windows.Forms.CheckBox();
			this.edtBannerLanguage = new System.Windows.Forms.TextBox();
			this.edtBannerMessage = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.tabHostKey = new System.Windows.Forms.TabPage();
			this.edtFingerPrint = new System.Windows.Forms.TextBox();
			this.btnGenerateHostKey = new System.Windows.Forms.Button();
			this.edtKeyLength = new System.Windows.Forms.TextBox();
			this.edtKeyType = new System.Windows.Forms.TextBox();
			this.edtHostKeyPassPhrase = new System.Windows.Forms.TextBox();
			this.btnLoadHostKey = new System.Windows.Forms.Button();
			this.edtHostKeyFile = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.tabAccessControl = new System.Windows.Forms.TabPage();
			this.gbUserPermissions = new System.Windows.Forms.GroupBox();
			this.cbCanReadLink = new System.Windows.Forms.CheckBox();
			this.cbCanMakeLink = new System.Windows.Forms.CheckBox();
			this.cbCanRemove = new System.Windows.Forms.CheckBox();
			this.cbCanRename = new System.Windows.Forms.CheckBox();
			this.cbCanWrite = new System.Windows.Forms.CheckBox();
			this.cbCanRead = new System.Windows.Forms.CheckBox();
			this.cbCanRemoveDir = new System.Windows.Forms.CheckBox();
			this.cbCanMakeDir = new System.Windows.Forms.CheckBox();
			this.cbCanList = new System.Windows.Forms.CheckBox();
			this.edtUserRootDir = new System.Windows.Forms.TextBox();
			this.edtPassword = new System.Windows.Forms.TextBox();
			this.edtUserName = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.tabIPBlocking = new System.Windows.Forms.TabPage();
			this.cbWhiteListOnly = new System.Windows.Forms.CheckBox();
			this.edtWhiteList = new System.Windows.Forms.TextBox();
			this.edtBlackList = new System.Windows.Forms.TextBox();
			this.edtAllowedConnections = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.tabSSHAlgorithms = new System.Windows.Forms.TabPage();
			this.edtDataIntegrityAlgs = new System.Windows.Forms.TextBox();
			this.edtEncryptionAlgs = new System.Windows.Forms.TextBox();
			this.edtSignatureAlgs = new System.Windows.Forms.TextBox();
			this.edtKexAlgs = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tabAdditional = new System.Windows.Forms.TabPage();
			this.edtMaxWindowSize = new System.Windows.Forms.TextBox();
			this.edtBatchSize = new System.Windows.Forms.TextBox();
			this.edtMaxReturnFiles = new System.Windows.Forms.TextBox();
			this.edtCharSet = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.sFtpServer1 = new CleverComponents.InetSuite.SFtpServer();
			this.serverGuard1 = new CleverComponents.InetSuite.ServerGuard();
			this.sFtpFileHandler1 = new CleverComponents.InetSuite.SFtpFileHandler();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabServer.SuspendLayout();
			this.tabBanner.SuspendLayout();
			this.tabHostKey.SuspendLayout();
			this.tabAccessControl.SuspendLayout();
			this.gbUserPermissions.SuspendLayout();
			this.tabIPBlocking.SuspendLayout();
			this.tabSSHAlgorithms.SuspendLayout();
			this.tabAdditional.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sFtpServer1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Image = global::SFtpServer.Properties.Resources.background_net;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(623, 78);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabServer);
			this.tabControl1.Controls.Add(this.tabBanner);
			this.tabControl1.Controls.Add(this.tabHostKey);
			this.tabControl1.Controls.Add(this.tabAccessControl);
			this.tabControl1.Controls.Add(this.tabIPBlocking);
			this.tabControl1.Controls.Add(this.tabSSHAlgorithms);
			this.tabControl1.Controls.Add(this.tabAdditional);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 78);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(623, 346);
			this.tabControl1.TabIndex = 1;
			// 
			// tabServer
			// 
			this.tabServer.BackColor = System.Drawing.SystemColors.Control;
			this.tabServer.Controls.Add(this.edtLog);
			this.tabServer.Controls.Add(this.btnStop);
			this.tabServer.Controls.Add(this.btnStart);
			this.tabServer.Controls.Add(this.edtRootDir);
			this.tabServer.Controls.Add(this.cbUseIPv6);
			this.tabServer.Controls.Add(this.edtBindingHost);
			this.tabServer.Controls.Add(this.edtPort);
			this.tabServer.Controls.Add(this.lblStatus);
			this.tabServer.Controls.Add(this.label32);
			this.tabServer.Controls.Add(this.label31);
			this.tabServer.Controls.Add(this.label30);
			this.tabServer.Controls.Add(this.label29);
			this.tabServer.Controls.Add(this.label28);
			this.tabServer.Location = new System.Drawing.Point(4, 22);
			this.tabServer.Name = "tabServer";
			this.tabServer.Padding = new System.Windows.Forms.Padding(3);
			this.tabServer.Size = new System.Drawing.Size(615, 320);
			this.tabServer.TabIndex = 0;
			this.tabServer.Text = "Server";
			// 
			// edtLog
			// 
			this.edtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.edtLog.Location = new System.Drawing.Point(3, 180);
			this.edtLog.Multiline = true;
			this.edtLog.Name = "edtLog";
			this.edtLog.ReadOnly = true;
			this.edtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.edtLog.Size = new System.Drawing.Size(609, 137);
			this.edtLog.TabIndex = 12;
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(482, 113);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(110, 23);
			this.btnStop.TabIndex = 11;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(482, 83);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(110, 23);
			this.btnStart.TabIndex = 10;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// edtRootDir
			// 
			this.edtRootDir.Location = new System.Drawing.Point(105, 115);
			this.edtRootDir.Name = "edtRootDir";
			this.edtRootDir.Size = new System.Drawing.Size(360, 20);
			this.edtRootDir.TabIndex = 9;
			this.edtRootDir.Text = "C:\\CleverFtpServer\\";
			// 
			// cbUseIPv6
			// 
			this.cbUseIPv6.AutoSize = true;
			this.cbUseIPv6.Location = new System.Drawing.Point(292, 87);
			this.cbUseIPv6.Name = "cbUseIPv6";
			this.cbUseIPv6.Size = new System.Drawing.Size(70, 17);
			this.cbUseIPv6.TabIndex = 8;
			this.cbUseIPv6.Text = "Use IPv6";
			this.cbUseIPv6.UseVisualStyleBackColor = true;
			// 
			// edtBindingHost
			// 
			this.edtBindingHost.Location = new System.Drawing.Point(105, 85);
			this.edtBindingHost.Name = "edtBindingHost";
			this.edtBindingHost.Size = new System.Drawing.Size(162, 20);
			this.edtBindingHost.TabIndex = 7;
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(105, 58);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(62, 20);
			this.edtPort.TabIndex = 6;
			this.edtPort.Text = "22";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblStatus.ForeColor = System.Drawing.Color.Red;
			this.lblStatus.Location = new System.Drawing.Point(411, 86);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(54, 17);
			this.lblStatus.TabIndex = 5;
			this.lblStatus.Text = "Started";
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(18, 150);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(62, 13);
			this.label32.TabIndex = 4;
			this.label32.Text = "Activity Log";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(18, 118);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(46, 13);
			this.label31.TabIndex = 3;
			this.label31.Text = "Root Dir";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(18, 88);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(29, 13);
			this.label30.TabIndex = 2;
			this.label30.Text = "Host";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(18, 61);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(64, 13);
			this.label29.TabIndex = 1;
			this.label29.Text = "Binding Port";
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label28.Location = new System.Drawing.Point(18, 12);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(537, 42);
			this.label28.TabIndex = 0;
			this.label28.Text = "This is a sample SFTP server, which demonstrates the using of the TclSFtpServer, " +
    "TclSFtpFileHandler, and TclServerGuard components.";
			// 
			// tabBanner
			// 
			this.tabBanner.BackColor = System.Drawing.SystemColors.Control;
			this.tabBanner.Controls.Add(this.cbEnableBanner);
			this.tabBanner.Controls.Add(this.edtBannerLanguage);
			this.tabBanner.Controls.Add(this.edtBannerMessage);
			this.tabBanner.Controls.Add(this.label27);
			this.tabBanner.Controls.Add(this.label26);
			this.tabBanner.Controls.Add(this.label25);
			this.tabBanner.Location = new System.Drawing.Point(4, 22);
			this.tabBanner.Name = "tabBanner";
			this.tabBanner.Padding = new System.Windows.Forms.Padding(3);
			this.tabBanner.Size = new System.Drawing.Size(615, 320);
			this.tabBanner.TabIndex = 1;
			this.tabBanner.Text = "Banner";
			// 
			// cbEnableBanner
			// 
			this.cbEnableBanner.AutoSize = true;
			this.cbEnableBanner.Location = new System.Drawing.Point(121, 107);
			this.cbEnableBanner.Name = "cbEnableBanner";
			this.cbEnableBanner.Size = new System.Drawing.Size(96, 17);
			this.cbEnableBanner.TabIndex = 5;
			this.cbEnableBanner.Text = "Enable Banner";
			this.cbEnableBanner.UseVisualStyleBackColor = true;
			// 
			// edtBannerLanguage
			// 
			this.edtBannerLanguage.Location = new System.Drawing.Point(121, 70);
			this.edtBannerLanguage.Name = "edtBannerLanguage";
			this.edtBannerLanguage.Size = new System.Drawing.Size(100, 20);
			this.edtBannerLanguage.TabIndex = 4;
			this.edtBannerLanguage.Text = "en";
			// 
			// edtBannerMessage
			// 
			this.edtBannerMessage.Location = new System.Drawing.Point(121, 40);
			this.edtBannerMessage.Name = "edtBannerMessage";
			this.edtBannerMessage.Size = new System.Drawing.Size(469, 20);
			this.edtBannerMessage.TabIndex = 3;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(18, 73);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(55, 13);
			this.label27.TabIndex = 2;
			this.label27.Text = "Language";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(18, 43);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(87, 13);
			this.label26.TabIndex = 1;
			this.label26.Text = "Banner Message";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label25.Location = new System.Drawing.Point(18, 12);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(227, 17);
			this.label25.TabIndex = 0;
			this.label25.Text = "The SFTP Server Banner Settings.";
			// 
			// tabHostKey
			// 
			this.tabHostKey.BackColor = System.Drawing.SystemColors.Control;
			this.tabHostKey.Controls.Add(this.edtFingerPrint);
			this.tabHostKey.Controls.Add(this.btnGenerateHostKey);
			this.tabHostKey.Controls.Add(this.edtKeyLength);
			this.tabHostKey.Controls.Add(this.edtKeyType);
			this.tabHostKey.Controls.Add(this.edtHostKeyPassPhrase);
			this.tabHostKey.Controls.Add(this.btnLoadHostKey);
			this.tabHostKey.Controls.Add(this.edtHostKeyFile);
			this.tabHostKey.Controls.Add(this.label24);
			this.tabHostKey.Controls.Add(this.label23);
			this.tabHostKey.Controls.Add(this.label22);
			this.tabHostKey.Controls.Add(this.label21);
			this.tabHostKey.Controls.Add(this.label20);
			this.tabHostKey.Controls.Add(this.label19);
			this.tabHostKey.Location = new System.Drawing.Point(4, 22);
			this.tabHostKey.Name = "tabHostKey";
			this.tabHostKey.Padding = new System.Windows.Forms.Padding(3);
			this.tabHostKey.Size = new System.Drawing.Size(615, 320);
			this.tabHostKey.TabIndex = 2;
			this.tabHostKey.Text = "Host Key";
			// 
			// edtFingerPrint
			// 
			this.edtFingerPrint.Location = new System.Drawing.Point(116, 194);
			this.edtFingerPrint.Name = "edtFingerPrint";
			this.edtFingerPrint.ReadOnly = true;
			this.edtFingerPrint.Size = new System.Drawing.Size(452, 20);
			this.edtFingerPrint.TabIndex = 12;
			// 
			// btnGenerateHostKey
			// 
			this.btnGenerateHostKey.Location = new System.Drawing.Point(222, 155);
			this.btnGenerateHostKey.Name = "btnGenerateHostKey";
			this.btnGenerateHostKey.Size = new System.Drawing.Size(110, 23);
			this.btnGenerateHostKey.TabIndex = 11;
			this.btnGenerateHostKey.Text = "Generate";
			this.btnGenerateHostKey.UseVisualStyleBackColor = true;
			this.btnGenerateHostKey.Click += new System.EventHandler(this.btnGenerateHostKey_Click);
			// 
			// edtKeyLength
			// 
			this.edtKeyLength.Location = new System.Drawing.Point(116, 157);
			this.edtKeyLength.Name = "edtKeyLength";
			this.edtKeyLength.Size = new System.Drawing.Size(100, 20);
			this.edtKeyLength.TabIndex = 10;
			this.edtKeyLength.Text = "2048";
			// 
			// edtKeyType
			// 
			this.edtKeyType.Enabled = false;
			this.edtKeyType.Location = new System.Drawing.Point(116, 127);
			this.edtKeyType.Name = "edtKeyType";
			this.edtKeyType.Size = new System.Drawing.Size(100, 20);
			this.edtKeyType.TabIndex = 9;
			this.edtKeyType.Text = "ssh-rsa";
			// 
			// edtHostKeyPassPhrase
			// 
			this.edtHostKeyPassPhrase.Location = new System.Drawing.Point(116, 90);
			this.edtHostKeyPassPhrase.Name = "edtHostKeyPassPhrase";
			this.edtHostKeyPassPhrase.PasswordChar = '*';
			this.edtHostKeyPassPhrase.Size = new System.Drawing.Size(100, 20);
			this.edtHostKeyPassPhrase.TabIndex = 8;
			// 
			// btnLoadHostKey
			// 
			this.btnLoadHostKey.Location = new System.Drawing.Point(458, 60);
			this.btnLoadHostKey.Name = "btnLoadHostKey";
			this.btnLoadHostKey.Size = new System.Drawing.Size(110, 23);
			this.btnLoadHostKey.TabIndex = 7;
			this.btnLoadHostKey.Text = "Load";
			this.btnLoadHostKey.UseVisualStyleBackColor = true;
			this.btnLoadHostKey.Click += new System.EventHandler(this.btnLoadHostKey_Click);
			// 
			// edtHostKeyFile
			// 
			this.edtHostKeyFile.Location = new System.Drawing.Point(116, 62);
			this.edtHostKeyFile.Name = "edtHostKeyFile";
			this.edtHostKeyFile.Size = new System.Drawing.Size(328, 20);
			this.edtHostKeyFile.TabIndex = 6;
			this.edtHostKeyFile.Text = "host-key-rsa.key";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(18, 197);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(85, 13);
			this.label24.TabIndex = 5;
			this.label24.Text = "Fingerprint (md5)";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(18, 160);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(61, 13);
			this.label23.TabIndex = 4;
			this.label23.Text = "Key Lenght";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(18, 130);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(52, 13);
			this.label22.TabIndex = 3;
			this.label22.Text = "Key Type";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(18, 93);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(66, 13);
			this.label21.TabIndex = 2;
			this.label21.Text = "Pass Phrase";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(18, 65);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(69, 13);
			this.label20.TabIndex = 1;
			this.label20.Text = "Host Key File";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label19.Location = new System.Drawing.Point(18, 12);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(520, 41);
			this.label19.TabIndex = 0;
			this.label19.Text = "You can load an existing private key or generate a new one. A new key is saved to" +
    " the Host Key File. TclSFtpServer supports only RSA host keys.";
			// 
			// tabAccessControl
			// 
			this.tabAccessControl.BackColor = System.Drawing.SystemColors.Control;
			this.tabAccessControl.Controls.Add(this.gbUserPermissions);
			this.tabAccessControl.Controls.Add(this.edtUserRootDir);
			this.tabAccessControl.Controls.Add(this.edtPassword);
			this.tabAccessControl.Controls.Add(this.edtUserName);
			this.tabAccessControl.Controls.Add(this.label18);
			this.tabAccessControl.Controls.Add(this.label17);
			this.tabAccessControl.Controls.Add(this.label16);
			this.tabAccessControl.Controls.Add(this.label15);
			this.tabAccessControl.Location = new System.Drawing.Point(4, 22);
			this.tabAccessControl.Name = "tabAccessControl";
			this.tabAccessControl.Padding = new System.Windows.Forms.Padding(3);
			this.tabAccessControl.Size = new System.Drawing.Size(615, 320);
			this.tabAccessControl.TabIndex = 3;
			this.tabAccessControl.Text = "Access Control";
			// 
			// gbUserPermissions
			// 
			this.gbUserPermissions.Controls.Add(this.cbCanReadLink);
			this.gbUserPermissions.Controls.Add(this.cbCanMakeLink);
			this.gbUserPermissions.Controls.Add(this.cbCanRemove);
			this.gbUserPermissions.Controls.Add(this.cbCanRename);
			this.gbUserPermissions.Controls.Add(this.cbCanWrite);
			this.gbUserPermissions.Controls.Add(this.cbCanRead);
			this.gbUserPermissions.Controls.Add(this.cbCanRemoveDir);
			this.gbUserPermissions.Controls.Add(this.cbCanMakeDir);
			this.gbUserPermissions.Controls.Add(this.cbCanList);
			this.gbUserPermissions.Location = new System.Drawing.Point(99, 128);
			this.gbUserPermissions.Name = "gbUserPermissions";
			this.gbUserPermissions.Size = new System.Drawing.Size(406, 128);
			this.gbUserPermissions.TabIndex = 7;
			this.gbUserPermissions.TabStop = false;
			this.gbUserPermissions.Text = "User Permissions";
			// 
			// cbCanReadLink
			// 
			this.cbCanReadLink.AutoSize = true;
			this.cbCanReadLink.Checked = true;
			this.cbCanReadLink.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCanReadLink.Location = new System.Drawing.Point(288, 49);
			this.cbCanReadLink.Name = "cbCanReadLink";
			this.cbCanReadLink.Size = new System.Drawing.Size(75, 17);
			this.cbCanReadLink.TabIndex = 8;
			this.cbCanReadLink.Text = "Read Link";
			this.cbCanReadLink.UseVisualStyleBackColor = true;
			// 
			// cbCanMakeLink
			// 
			this.cbCanMakeLink.AutoSize = true;
			this.cbCanMakeLink.Checked = true;
			this.cbCanMakeLink.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCanMakeLink.Location = new System.Drawing.Point(288, 26);
			this.cbCanMakeLink.Name = "cbCanMakeLink";
			this.cbCanMakeLink.Size = new System.Drawing.Size(76, 17);
			this.cbCanMakeLink.TabIndex = 7;
			this.cbCanMakeLink.Text = "Make Link";
			this.cbCanMakeLink.UseVisualStyleBackColor = true;
			// 
			// cbCanRemove
			// 
			this.cbCanRemove.AutoSize = true;
			this.cbCanRemove.Checked = true;
			this.cbCanRemove.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCanRemove.Location = new System.Drawing.Point(160, 95);
			this.cbCanRemove.Name = "cbCanRemove";
			this.cbCanRemove.Size = new System.Drawing.Size(66, 17);
			this.cbCanRemove.TabIndex = 6;
			this.cbCanRemove.Text = "Remove";
			this.cbCanRemove.UseVisualStyleBackColor = true;
			// 
			// cbCanRename
			// 
			this.cbCanRename.AutoSize = true;
			this.cbCanRename.Checked = true;
			this.cbCanRename.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCanRename.Location = new System.Drawing.Point(160, 72);
			this.cbCanRename.Name = "cbCanRename";
			this.cbCanRename.Size = new System.Drawing.Size(66, 17);
			this.cbCanRename.TabIndex = 5;
			this.cbCanRename.Text = "Rename";
			this.cbCanRename.UseVisualStyleBackColor = true;
			// 
			// cbCanWrite
			// 
			this.cbCanWrite.AutoSize = true;
			this.cbCanWrite.Checked = true;
			this.cbCanWrite.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCanWrite.Location = new System.Drawing.Point(160, 49);
			this.cbCanWrite.Name = "cbCanWrite";
			this.cbCanWrite.Size = new System.Drawing.Size(51, 17);
			this.cbCanWrite.TabIndex = 4;
			this.cbCanWrite.Text = "Write";
			this.cbCanWrite.UseVisualStyleBackColor = true;
			// 
			// cbCanRead
			// 
			this.cbCanRead.AutoSize = true;
			this.cbCanRead.Checked = true;
			this.cbCanRead.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCanRead.Location = new System.Drawing.Point(160, 26);
			this.cbCanRead.Name = "cbCanRead";
			this.cbCanRead.Size = new System.Drawing.Size(52, 17);
			this.cbCanRead.TabIndex = 3;
			this.cbCanRead.Text = "Read";
			this.cbCanRead.UseVisualStyleBackColor = true;
			// 
			// cbCanRemoveDir
			// 
			this.cbCanRemoveDir.AutoSize = true;
			this.cbCanRemoveDir.Checked = true;
			this.cbCanRemoveDir.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCanRemoveDir.Location = new System.Drawing.Point(21, 72);
			this.cbCanRemoveDir.Name = "cbCanRemoveDir";
			this.cbCanRemoveDir.Size = new System.Drawing.Size(82, 17);
			this.cbCanRemoveDir.TabIndex = 2;
			this.cbCanRemoveDir.Text = "Remove Dir";
			this.cbCanRemoveDir.UseVisualStyleBackColor = true;
			// 
			// cbCanMakeDir
			// 
			this.cbCanMakeDir.AutoSize = true;
			this.cbCanMakeDir.Checked = true;
			this.cbCanMakeDir.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCanMakeDir.Location = new System.Drawing.Point(21, 49);
			this.cbCanMakeDir.Name = "cbCanMakeDir";
			this.cbCanMakeDir.Size = new System.Drawing.Size(69, 17);
			this.cbCanMakeDir.TabIndex = 1;
			this.cbCanMakeDir.Text = "Make Dir";
			this.cbCanMakeDir.UseVisualStyleBackColor = true;
			// 
			// cbCanList
			// 
			this.cbCanList.AutoSize = true;
			this.cbCanList.Checked = true;
			this.cbCanList.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCanList.Location = new System.Drawing.Point(21, 26);
			this.cbCanList.Name = "cbCanList";
			this.cbCanList.Size = new System.Drawing.Size(42, 17);
			this.cbCanList.TabIndex = 0;
			this.cbCanList.Text = "List";
			this.cbCanList.UseVisualStyleBackColor = true;
			// 
			// edtUserRootDir
			// 
			this.edtUserRootDir.Location = new System.Drawing.Point(99, 93);
			this.edtUserRootDir.Name = "edtUserRootDir";
			this.edtUserRootDir.Size = new System.Drawing.Size(406, 20);
			this.edtUserRootDir.TabIndex = 6;
			// 
			// edtPassword
			// 
			this.edtPassword.Location = new System.Drawing.Point(356, 63);
			this.edtPassword.Name = "edtPassword";
			this.edtPassword.Size = new System.Drawing.Size(149, 20);
			this.edtPassword.TabIndex = 5;
			this.edtPassword.Text = "clevertester";
			// 
			// edtUserName
			// 
			this.edtUserName.Location = new System.Drawing.Point(99, 63);
			this.edtUserName.Name = "edtUserName";
			this.edtUserName.Size = new System.Drawing.Size(149, 20);
			this.edtUserName.TabIndex = 4;
			this.edtUserName.Text = "CleverTester";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(18, 96);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(46, 13);
			this.label18.TabIndex = 3;
			this.label18.Text = "Root Dir";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(286, 66);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(53, 13);
			this.label17.TabIndex = 2;
			this.label17.Text = "Password";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(18, 66);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(60, 13);
			this.label16.TabIndex = 1;
			this.label16.Text = "User Name";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label15.Location = new System.Drawing.Point(18, 12);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(534, 41);
			this.label15.TabIndex = 0;
			this.label15.Text = "This sample implements the only one user account. You can define all the desired " +
    "users using the TclSFtpServer.UserAccounts property.";
			// 
			// tabIPBlocking
			// 
			this.tabIPBlocking.BackColor = System.Drawing.SystemColors.Control;
			this.tabIPBlocking.Controls.Add(this.cbWhiteListOnly);
			this.tabIPBlocking.Controls.Add(this.edtWhiteList);
			this.tabIPBlocking.Controls.Add(this.edtBlackList);
			this.tabIPBlocking.Controls.Add(this.edtAllowedConnections);
			this.tabIPBlocking.Controls.Add(this.label14);
			this.tabIPBlocking.Controls.Add(this.label13);
			this.tabIPBlocking.Controls.Add(this.label12);
			this.tabIPBlocking.Controls.Add(this.label11);
			this.tabIPBlocking.Location = new System.Drawing.Point(4, 22);
			this.tabIPBlocking.Name = "tabIPBlocking";
			this.tabIPBlocking.Padding = new System.Windows.Forms.Padding(3);
			this.tabIPBlocking.Size = new System.Drawing.Size(615, 320);
			this.tabIPBlocking.TabIndex = 4;
			this.tabIPBlocking.Text = "IP Blocking";
			// 
			// cbWhiteListOnly
			// 
			this.cbWhiteListOnly.AutoSize = true;
			this.cbWhiteListOnly.Location = new System.Drawing.Point(311, 242);
			this.cbWhiteListOnly.Name = "cbWhiteListOnly";
			this.cbWhiteListOnly.Size = new System.Drawing.Size(116, 17);
			this.cbWhiteListOnly.TabIndex = 7;
			this.cbWhiteListOnly.Text = "Allow Whitelist only";
			this.cbWhiteListOnly.UseVisualStyleBackColor = true;
			// 
			// edtWhiteList
			// 
			this.edtWhiteList.Location = new System.Drawing.Point(311, 95);
			this.edtWhiteList.Multiline = true;
			this.edtWhiteList.Name = "edtWhiteList";
			this.edtWhiteList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.edtWhiteList.Size = new System.Drawing.Size(273, 131);
			this.edtWhiteList.TabIndex = 6;
			// 
			// edtBlackList
			// 
			this.edtBlackList.Location = new System.Drawing.Point(21, 95);
			this.edtBlackList.Multiline = true;
			this.edtBlackList.Name = "edtBlackList";
			this.edtBlackList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.edtBlackList.Size = new System.Drawing.Size(273, 131);
			this.edtBlackList.TabIndex = 5;
			this.edtBlackList.Text = "11.22.33.*\r\n44.55.66.77";
			// 
			// edtAllowedConnections
			// 
			this.edtAllowedConnections.Location = new System.Drawing.Point(311, 44);
			this.edtAllowedConnections.Name = "edtAllowedConnections";
			this.edtAllowedConnections.Size = new System.Drawing.Size(65, 20);
			this.edtAllowedConnections.TabIndex = 4;
			this.edtAllowedConnections.Text = "6";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(308, 79);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(67, 13);
			this.label14.TabIndex = 3;
			this.label14.Text = "White IP List";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(18, 79);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(66, 13);
			this.label13.TabIndex = 2;
			this.label13.Text = "Black IP List";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(18, 47);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(250, 13);
			this.label12.TabIndex = 1;
			this.label12.Text = "Allowed Connections from the same host per minute";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(18, 12);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(195, 17);
			this.label11.TabIndex = 0;
			this.label11.Text = "The TclServerGuard settings.";
			// 
			// tabSSHAlgorithms
			// 
			this.tabSSHAlgorithms.BackColor = System.Drawing.SystemColors.Control;
			this.tabSSHAlgorithms.Controls.Add(this.edtDataIntegrityAlgs);
			this.tabSSHAlgorithms.Controls.Add(this.edtEncryptionAlgs);
			this.tabSSHAlgorithms.Controls.Add(this.edtSignatureAlgs);
			this.tabSSHAlgorithms.Controls.Add(this.edtKexAlgs);
			this.tabSSHAlgorithms.Controls.Add(this.label10);
			this.tabSSHAlgorithms.Controls.Add(this.label9);
			this.tabSSHAlgorithms.Controls.Add(this.label8);
			this.tabSSHAlgorithms.Controls.Add(this.label7);
			this.tabSSHAlgorithms.Controls.Add(this.label6);
			this.tabSSHAlgorithms.Location = new System.Drawing.Point(4, 22);
			this.tabSSHAlgorithms.Name = "tabSSHAlgorithms";
			this.tabSSHAlgorithms.Padding = new System.Windows.Forms.Padding(3);
			this.tabSSHAlgorithms.Size = new System.Drawing.Size(615, 320);
			this.tabSSHAlgorithms.TabIndex = 5;
			this.tabSSHAlgorithms.Text = "SSH Algorithms";
			// 
			// edtDataIntegrityAlgs
			// 
			this.edtDataIntegrityAlgs.Location = new System.Drawing.Point(115, 169);
			this.edtDataIntegrityAlgs.Name = "edtDataIntegrityAlgs";
			this.edtDataIntegrityAlgs.Size = new System.Drawing.Size(474, 20);
			this.edtDataIntegrityAlgs.TabIndex = 8;
			// 
			// edtEncryptionAlgs
			// 
			this.edtEncryptionAlgs.Location = new System.Drawing.Point(115, 139);
			this.edtEncryptionAlgs.Name = "edtEncryptionAlgs";
			this.edtEncryptionAlgs.Size = new System.Drawing.Size(474, 20);
			this.edtEncryptionAlgs.TabIndex = 7;
			// 
			// edtSignatureAlgs
			// 
			this.edtSignatureAlgs.Location = new System.Drawing.Point(115, 106);
			this.edtSignatureAlgs.Name = "edtSignatureAlgs";
			this.edtSignatureAlgs.Size = new System.Drawing.Size(474, 20);
			this.edtSignatureAlgs.TabIndex = 6;
			// 
			// edtKexAlgs
			// 
			this.edtKexAlgs.Location = new System.Drawing.Point(115, 74);
			this.edtKexAlgs.Name = "edtKexAlgs";
			this.edtKexAlgs.Size = new System.Drawing.Size(474, 20);
			this.edtKexAlgs.TabIndex = 5;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(18, 172);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(70, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "Data Integrity";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(18, 142);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(57, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Encryption";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(18, 109);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "Signature";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(18, 77);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "Key Exchange";
			// 
			// label6
			// 
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(18, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(571, 54);
			this.label6.TabIndex = 0;
			this.label6.Text = resources.GetString("label6.Text");
			// 
			// tabAdditional
			// 
			this.tabAdditional.BackColor = System.Drawing.SystemColors.Control;
			this.tabAdditional.Controls.Add(this.edtMaxWindowSize);
			this.tabAdditional.Controls.Add(this.edtBatchSize);
			this.tabAdditional.Controls.Add(this.edtMaxReturnFiles);
			this.tabAdditional.Controls.Add(this.edtCharSet);
			this.tabAdditional.Controls.Add(this.label5);
			this.tabAdditional.Controls.Add(this.label4);
			this.tabAdditional.Controls.Add(this.label3);
			this.tabAdditional.Controls.Add(this.label2);
			this.tabAdditional.Controls.Add(this.label1);
			this.tabAdditional.Location = new System.Drawing.Point(4, 22);
			this.tabAdditional.Name = "tabAdditional";
			this.tabAdditional.Padding = new System.Windows.Forms.Padding(3);
			this.tabAdditional.Size = new System.Drawing.Size(615, 320);
			this.tabAdditional.TabIndex = 6;
			this.tabAdditional.Text = "Additional Settings";
			// 
			// edtMaxWindowSize
			// 
			this.edtMaxWindowSize.Location = new System.Drawing.Point(125, 138);
			this.edtMaxWindowSize.Name = "edtMaxWindowSize";
			this.edtMaxWindowSize.Size = new System.Drawing.Size(125, 20);
			this.edtMaxWindowSize.TabIndex = 8;
			// 
			// edtBatchSize
			// 
			this.edtBatchSize.Location = new System.Drawing.Point(125, 108);
			this.edtBatchSize.Name = "edtBatchSize";
			this.edtBatchSize.Size = new System.Drawing.Size(125, 20);
			this.edtBatchSize.TabIndex = 7;
			// 
			// edtMaxReturnFiles
			// 
			this.edtMaxReturnFiles.Location = new System.Drawing.Point(125, 77);
			this.edtMaxReturnFiles.Name = "edtMaxReturnFiles";
			this.edtMaxReturnFiles.Size = new System.Drawing.Size(125, 20);
			this.edtMaxReturnFiles.TabIndex = 6;
			// 
			// edtCharSet
			// 
			this.edtCharSet.Location = new System.Drawing.Point(125, 45);
			this.edtCharSet.Name = "edtCharSet";
			this.edtCharSet.Size = new System.Drawing.Size(125, 20);
			this.edtCharSet.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Max Window Size";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Data Batch Size";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Max Return Files";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Character Set";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(18, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(540, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "These settings are commonly used for fine tuning the data transferring performanc" +
    "e.";
			// 
			// sFtpServer1
			// 
			this.sFtpServer1.Banner = null;
			this.sFtpServer1.BannerLanguage = null;
			this.sFtpServer1.Guard = this.serverGuard1;
			this.sFtpServer1.RootDir = null;
			this.sFtpServer1.RequestReceived += new CleverComponents.InetSuite.SFtpServerEventHandler(this.sFtpServer1_RequestReceived);
			this.sFtpServer1.ResponseSent += new CleverComponents.InetSuite.SFtpServerEventHandler(this.sFtpServer1_ResponseSent);
			this.sFtpServer1.Started += new System.EventHandler(this.sFtpServer1_Started);
			this.sFtpServer1.Stopped += new System.EventHandler(this.sFtpServer1_Stopped);
			this.sFtpServer1.ConnectionAccepted += new CleverComponents.InetSuite.ConnectionAcceptedEventHandler(this.sFtpServer1_ConnectionAccepted);
			this.sFtpServer1.ConnectionClosed += new CleverComponents.InetSuite.ConnectionEventHandler(this.sFtpServer1_ConnectionClosed);
			// 
			// sFtpFileHandler1
			// 
			this.sFtpFileHandler1.Server = this.sFtpServer1;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Key files (*.pem)|*.pem|Key files (*.key)|*.key|All (*.*)|*.*";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(623, 424);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clever SFTP Server";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabServer.ResumeLayout(false);
			this.tabServer.PerformLayout();
			this.tabBanner.ResumeLayout(false);
			this.tabBanner.PerformLayout();
			this.tabHostKey.ResumeLayout(false);
			this.tabHostKey.PerformLayout();
			this.tabAccessControl.ResumeLayout(false);
			this.tabAccessControl.PerformLayout();
			this.gbUserPermissions.ResumeLayout(false);
			this.gbUserPermissions.PerformLayout();
			this.tabIPBlocking.ResumeLayout(false);
			this.tabIPBlocking.PerformLayout();
			this.tabSSHAlgorithms.ResumeLayout(false);
			this.tabSSHAlgorithms.PerformLayout();
			this.tabAdditional.ResumeLayout(false);
			this.tabAdditional.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sFtpServer1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabServer;
		private System.Windows.Forms.TabPage tabBanner;
		private System.Windows.Forms.TabPage tabHostKey;
		private System.Windows.Forms.TabPage tabAccessControl;
		private System.Windows.Forms.TabPage tabIPBlocking;
		private System.Windows.Forms.TabPage tabSSHAlgorithms;
		private System.Windows.Forms.TabPage tabAdditional;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox edtCharSet;
		private System.Windows.Forms.TextBox edtMaxWindowSize;
		private System.Windows.Forms.TextBox edtBatchSize;
		private System.Windows.Forms.TextBox edtMaxReturnFiles;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox edtKexAlgs;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox edtSignatureAlgs;
		private System.Windows.Forms.TextBox edtEncryptionAlgs;
		private System.Windows.Forms.TextBox edtDataIntegrityAlgs;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox edtAllowedConnections;
		private System.Windows.Forms.TextBox edtBlackList;
		private System.Windows.Forms.TextBox edtWhiteList;
		private System.Windows.Forms.CheckBox cbWhiteListOnly;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox edtUserName;
		private System.Windows.Forms.GroupBox gbUserPermissions;
		private System.Windows.Forms.TextBox edtUserRootDir;
		private System.Windows.Forms.TextBox edtPassword;
		private System.Windows.Forms.CheckBox cbCanList;
		private System.Windows.Forms.CheckBox cbCanMakeDir;
		private System.Windows.Forms.CheckBox cbCanRemoveDir;
		private System.Windows.Forms.CheckBox cbCanRead;
		private System.Windows.Forms.CheckBox cbCanWrite;
		private System.Windows.Forms.CheckBox cbCanRemove;
		private System.Windows.Forms.CheckBox cbCanRename;
		private System.Windows.Forms.CheckBox cbCanMakeLink;
		private System.Windows.Forms.CheckBox cbCanReadLink;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox edtHostKeyFile;
		private System.Windows.Forms.Button btnLoadHostKey;
		private System.Windows.Forms.TextBox edtHostKeyPassPhrase;
		private System.Windows.Forms.TextBox edtKeyType;
		private System.Windows.Forms.TextBox edtKeyLength;
		private System.Windows.Forms.Button btnGenerateHostKey;
		private System.Windows.Forms.TextBox edtFingerPrint;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox edtBannerMessage;
		private System.Windows.Forms.TextBox edtBannerLanguage;
		private System.Windows.Forms.CheckBox cbEnableBanner;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.TextBox edtPort;
		private System.Windows.Forms.TextBox edtBindingHost;
		private System.Windows.Forms.CheckBox cbUseIPv6;
		private System.Windows.Forms.TextBox edtRootDir;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.TextBox edtLog;
		private CleverComponents.InetSuite.SFtpServer sFtpServer1;
		private CleverComponents.InetSuite.SFtpFileHandler sFtpFileHandler1;
		private CleverComponents.InetSuite.ServerGuard serverGuard1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

