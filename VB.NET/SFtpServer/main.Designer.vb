<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.label13 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.edtUserRootDir = New System.Windows.Forms.TextBox()
        Me.edtPassword = New System.Windows.Forms.TextBox()
        Me.edtUserName = New System.Windows.Forms.TextBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.edtBlackList = New System.Windows.Forms.TextBox()
        Me.edtAllowedConnections = New System.Windows.Forms.TextBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.cbWhiteListOnly = New System.Windows.Forms.CheckBox()
        Me.tabIPBlocking = New System.Windows.Forms.TabPage()
        Me.edtWhiteList = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cbCanReadLink = New System.Windows.Forms.CheckBox()
        Me.tabSSHAlgorithms = New System.Windows.Forms.TabPage()
        Me.edtDataIntegrityAlgs = New System.Windows.Forms.TextBox()
        Me.edtEncryptionAlgs = New System.Windows.Forms.TextBox()
        Me.edtSignatureAlgs = New System.Windows.Forms.TextBox()
        Me.edtKexAlgs = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.edtMaxWindowSize = New System.Windows.Forms.TextBox()
        Me.edtBatchSize = New System.Windows.Forms.TextBox()
        Me.edtMaxReturnFiles = New System.Windows.Forms.TextBox()
        Me.edtCharSet = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cbCanMakeLink = New System.Windows.Forms.CheckBox()
        Me.tabAdditional = New System.Windows.Forms.TabPage()
        Me.cbCanRemove = New System.Windows.Forms.CheckBox()
        Me.gbUserPermissions = New System.Windows.Forms.GroupBox()
        Me.cbCanRename = New System.Windows.Forms.CheckBox()
        Me.cbCanWrite = New System.Windows.Forms.CheckBox()
        Me.cbCanRead = New System.Windows.Forms.CheckBox()
        Me.cbCanRemoveDir = New System.Windows.Forms.CheckBox()
        Me.cbCanMakeDir = New System.Windows.Forms.CheckBox()
        Me.cbCanList = New System.Windows.Forms.CheckBox()
        Me.edtBannerLanguage = New System.Windows.Forms.TextBox()
        Me.edtBannerMessage = New System.Windows.Forms.TextBox()
        Me.edtLog = New System.Windows.Forms.TextBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.edtRootDir = New System.Windows.Forms.TextBox()
        Me.cbUseIPv6 = New System.Windows.Forms.CheckBox()
        Me.edtBindingHost = New System.Windows.Forms.TextBox()
        Me.edtPort = New System.Windows.Forms.TextBox()
        Me.cbEnableBanner = New System.Windows.Forms.CheckBox()
        Me.tabBanner = New System.Windows.Forms.TabPage()
        Me.label27 = New System.Windows.Forms.Label()
        Me.label26 = New System.Windows.Forms.Label()
        Me.label25 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.label32 = New System.Windows.Forms.Label()
        Me.label30 = New System.Windows.Forms.Label()
        Me.label29 = New System.Windows.Forms.Label()
        Me.label28 = New System.Windows.Forms.Label()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabServer = New System.Windows.Forms.TabPage()
        Me.label31 = New System.Windows.Forms.Label()
        Me.tabHostKey = New System.Windows.Forms.TabPage()
        Me.edtFingerPrint = New System.Windows.Forms.TextBox()
        Me.btnGenerateHostKey = New System.Windows.Forms.Button()
        Me.edtKeyLength = New System.Windows.Forms.TextBox()
        Me.edtKeyType = New System.Windows.Forms.TextBox()
        Me.edtHostKeyPassPhrase = New System.Windows.Forms.TextBox()
        Me.btnLoadHostKey = New System.Windows.Forms.Button()
        Me.edtHostKeyFile = New System.Windows.Forms.TextBox()
        Me.label24 = New System.Windows.Forms.Label()
        Me.label23 = New System.Windows.Forms.Label()
        Me.label22 = New System.Windows.Forms.Label()
        Me.label21 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label19 = New System.Windows.Forms.Label()
        Me.tabAccessControl = New System.Windows.Forms.TabPage()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SFtpServer1 = New CleverComponents.InetSuite.SFtpServer()
        Me.SFtpFileHandler1 = New CleverComponents.InetSuite.SFtpFileHandler()
        Me.ServerGuard1 = New CleverComponents.InetSuite.ServerGuard()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tabIPBlocking.SuspendLayout()
        Me.tabSSHAlgorithms.SuspendLayout()
        Me.tabAdditional.SuspendLayout()
        Me.gbUserPermissions.SuspendLayout()
        Me.tabBanner.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabServer.SuspendLayout()
        Me.tabHostKey.SuspendLayout()
        Me.tabAccessControl.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SFtpServer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(18, 79)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(66, 13)
        Me.label13.TabIndex = 2
        Me.label13.Text = "Black IP List"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label11.Location = New System.Drawing.Point(18, 12)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(195, 17)
        Me.label11.TabIndex = 0
        Me.label11.Text = "The TclServerGuard settings."
        '
        'edtUserRootDir
        '
        Me.edtUserRootDir.Location = New System.Drawing.Point(99, 93)
        Me.edtUserRootDir.Name = "edtUserRootDir"
        Me.edtUserRootDir.Size = New System.Drawing.Size(406, 20)
        Me.edtUserRootDir.TabIndex = 6
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(356, 63)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.Size = New System.Drawing.Size(149, 20)
        Me.edtPassword.TabIndex = 5
        Me.edtPassword.Text = "clevertester"
        '
        'edtUserName
        '
        Me.edtUserName.Location = New System.Drawing.Point(99, 63)
        Me.edtUserName.Name = "edtUserName"
        Me.edtUserName.Size = New System.Drawing.Size(149, 20)
        Me.edtUserName.TabIndex = 4
        Me.edtUserName.Text = "CleverTester"
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(18, 96)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(46, 13)
        Me.label18.TabIndex = 3
        Me.label18.Text = "Root Dir"
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(286, 66)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(53, 13)
        Me.label17.TabIndex = 2
        Me.label17.Text = "Password"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(18, 66)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(60, 13)
        Me.label16.TabIndex = 1
        Me.label16.Text = "User Name"
        '
        'edtBlackList
        '
        Me.edtBlackList.Location = New System.Drawing.Point(21, 95)
        Me.edtBlackList.Multiline = True
        Me.edtBlackList.Name = "edtBlackList"
        Me.edtBlackList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.edtBlackList.Size = New System.Drawing.Size(273, 131)
        Me.edtBlackList.TabIndex = 5
        Me.edtBlackList.Text = "11.22.33.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "44.55.66.77"
        '
        'edtAllowedConnections
        '
        Me.edtAllowedConnections.Location = New System.Drawing.Point(311, 44)
        Me.edtAllowedConnections.Name = "edtAllowedConnections"
        Me.edtAllowedConnections.Size = New System.Drawing.Size(65, 20)
        Me.edtAllowedConnections.TabIndex = 4
        Me.edtAllowedConnections.Text = "6"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(308, 79)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(67, 13)
        Me.label14.TabIndex = 3
        Me.label14.Text = "White IP List"
        '
        'label15
        '
        Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label15.Location = New System.Drawing.Point(18, 12)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(534, 41)
        Me.label15.TabIndex = 0
        Me.label15.Text = "This sample implements the only one user account. You can define all the desired " &
    "users using the TclSFtpServer.UserAccounts property."
        '
        'cbWhiteListOnly
        '
        Me.cbWhiteListOnly.AutoSize = True
        Me.cbWhiteListOnly.Location = New System.Drawing.Point(311, 242)
        Me.cbWhiteListOnly.Name = "cbWhiteListOnly"
        Me.cbWhiteListOnly.Size = New System.Drawing.Size(116, 17)
        Me.cbWhiteListOnly.TabIndex = 7
        Me.cbWhiteListOnly.Text = "Allow Whitelist only"
        Me.cbWhiteListOnly.UseVisualStyleBackColor = True
        '
        'tabIPBlocking
        '
        Me.tabIPBlocking.BackColor = System.Drawing.SystemColors.Control
        Me.tabIPBlocking.Controls.Add(Me.cbWhiteListOnly)
        Me.tabIPBlocking.Controls.Add(Me.edtWhiteList)
        Me.tabIPBlocking.Controls.Add(Me.edtBlackList)
        Me.tabIPBlocking.Controls.Add(Me.edtAllowedConnections)
        Me.tabIPBlocking.Controls.Add(Me.label14)
        Me.tabIPBlocking.Controls.Add(Me.label13)
        Me.tabIPBlocking.Controls.Add(Me.label12)
        Me.tabIPBlocking.Controls.Add(Me.label11)
        Me.tabIPBlocking.Location = New System.Drawing.Point(4, 22)
        Me.tabIPBlocking.Name = "tabIPBlocking"
        Me.tabIPBlocking.Padding = New System.Windows.Forms.Padding(3)
        Me.tabIPBlocking.Size = New System.Drawing.Size(615, 320)
        Me.tabIPBlocking.TabIndex = 4
        Me.tabIPBlocking.Text = "IP Blocking"
        '
        'edtWhiteList
        '
        Me.edtWhiteList.Location = New System.Drawing.Point(311, 95)
        Me.edtWhiteList.Multiline = True
        Me.edtWhiteList.Name = "edtWhiteList"
        Me.edtWhiteList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.edtWhiteList.Size = New System.Drawing.Size(273, 131)
        Me.edtWhiteList.TabIndex = 6
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(18, 47)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(250, 13)
        Me.label12.TabIndex = 1
        Me.label12.Text = "Allowed Connections from the same host per minute"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(18, 48)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Character Set"
        '
        'cbCanReadLink
        '
        Me.cbCanReadLink.AutoSize = True
        Me.cbCanReadLink.Checked = True
        Me.cbCanReadLink.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCanReadLink.Location = New System.Drawing.Point(288, 49)
        Me.cbCanReadLink.Name = "cbCanReadLink"
        Me.cbCanReadLink.Size = New System.Drawing.Size(75, 17)
        Me.cbCanReadLink.TabIndex = 8
        Me.cbCanReadLink.Text = "Read Link"
        Me.cbCanReadLink.UseVisualStyleBackColor = True
        '
        'tabSSHAlgorithms
        '
        Me.tabSSHAlgorithms.BackColor = System.Drawing.SystemColors.Control
        Me.tabSSHAlgorithms.Controls.Add(Me.edtDataIntegrityAlgs)
        Me.tabSSHAlgorithms.Controls.Add(Me.edtEncryptionAlgs)
        Me.tabSSHAlgorithms.Controls.Add(Me.edtSignatureAlgs)
        Me.tabSSHAlgorithms.Controls.Add(Me.edtKexAlgs)
        Me.tabSSHAlgorithms.Controls.Add(Me.label10)
        Me.tabSSHAlgorithms.Controls.Add(Me.label9)
        Me.tabSSHAlgorithms.Controls.Add(Me.label8)
        Me.tabSSHAlgorithms.Controls.Add(Me.label7)
        Me.tabSSHAlgorithms.Controls.Add(Me.label6)
        Me.tabSSHAlgorithms.Location = New System.Drawing.Point(4, 22)
        Me.tabSSHAlgorithms.Name = "tabSSHAlgorithms"
        Me.tabSSHAlgorithms.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSSHAlgorithms.Size = New System.Drawing.Size(615, 320)
        Me.tabSSHAlgorithms.TabIndex = 5
        Me.tabSSHAlgorithms.Text = "SSH Algorithms"
        '
        'edtDataIntegrityAlgs
        '
        Me.edtDataIntegrityAlgs.Location = New System.Drawing.Point(115, 169)
        Me.edtDataIntegrityAlgs.Name = "edtDataIntegrityAlgs"
        Me.edtDataIntegrityAlgs.Size = New System.Drawing.Size(474, 20)
        Me.edtDataIntegrityAlgs.TabIndex = 8
        '
        'edtEncryptionAlgs
        '
        Me.edtEncryptionAlgs.Location = New System.Drawing.Point(115, 139)
        Me.edtEncryptionAlgs.Name = "edtEncryptionAlgs"
        Me.edtEncryptionAlgs.Size = New System.Drawing.Size(474, 20)
        Me.edtEncryptionAlgs.TabIndex = 7
        '
        'edtSignatureAlgs
        '
        Me.edtSignatureAlgs.Location = New System.Drawing.Point(115, 106)
        Me.edtSignatureAlgs.Name = "edtSignatureAlgs"
        Me.edtSignatureAlgs.Size = New System.Drawing.Size(474, 20)
        Me.edtSignatureAlgs.TabIndex = 6
        '
        'edtKexAlgs
        '
        Me.edtKexAlgs.Location = New System.Drawing.Point(115, 74)
        Me.edtKexAlgs.Name = "edtKexAlgs"
        Me.edtKexAlgs.Size = New System.Drawing.Size(474, 20)
        Me.edtKexAlgs.TabIndex = 5
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(18, 172)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(70, 13)
        Me.label10.TabIndex = 4
        Me.label10.Text = "Data Integrity"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(18, 142)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(57, 13)
        Me.label9.TabIndex = 3
        Me.label9.Text = "Encryption"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(18, 109)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(52, 13)
        Me.label8.TabIndex = 2
        Me.label8.Text = "Signature"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(18, 77)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(76, 13)
        Me.label7.TabIndex = 1
        Me.label7.Text = "Key Exchange"
        '
        'label6
        '
        Me.label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label6.Location = New System.Drawing.Point(18, 12)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(571, 54)
        Me.label6.TabIndex = 0
        Me.label6.Text = resources.GetString("label6.Text")
        '
        'edtMaxWindowSize
        '
        Me.edtMaxWindowSize.Location = New System.Drawing.Point(125, 138)
        Me.edtMaxWindowSize.Name = "edtMaxWindowSize"
        Me.edtMaxWindowSize.Size = New System.Drawing.Size(125, 20)
        Me.edtMaxWindowSize.TabIndex = 8
        '
        'edtBatchSize
        '
        Me.edtBatchSize.Location = New System.Drawing.Point(125, 108)
        Me.edtBatchSize.Name = "edtBatchSize"
        Me.edtBatchSize.Size = New System.Drawing.Size(125, 20)
        Me.edtBatchSize.TabIndex = 7
        '
        'edtMaxReturnFiles
        '
        Me.edtMaxReturnFiles.Location = New System.Drawing.Point(125, 77)
        Me.edtMaxReturnFiles.Name = "edtMaxReturnFiles"
        Me.edtMaxReturnFiles.Size = New System.Drawing.Size(125, 20)
        Me.edtMaxReturnFiles.TabIndex = 6
        '
        'edtCharSet
        '
        Me.edtCharSet.Location = New System.Drawing.Point(125, 45)
        Me.edtCharSet.Name = "edtCharSet"
        Me.edtCharSet.Size = New System.Drawing.Size(125, 20)
        Me.edtCharSet.TabIndex = 5
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(18, 141)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(92, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Max Window Size"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(18, 111)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(84, 13)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Data Batch Size"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(18, 80)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(86, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Max Return Files"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.Location = New System.Drawing.Point(18, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(540, 17)
        Me.label1.TabIndex = 0
        Me.label1.Text = "These settings are commonly used for fine tuning the data transferring performanc" &
    "e."
        '
        'cbCanMakeLink
        '
        Me.cbCanMakeLink.AutoSize = True
        Me.cbCanMakeLink.Checked = True
        Me.cbCanMakeLink.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCanMakeLink.Location = New System.Drawing.Point(288, 26)
        Me.cbCanMakeLink.Name = "cbCanMakeLink"
        Me.cbCanMakeLink.Size = New System.Drawing.Size(76, 17)
        Me.cbCanMakeLink.TabIndex = 7
        Me.cbCanMakeLink.Text = "Make Link"
        Me.cbCanMakeLink.UseVisualStyleBackColor = True
        '
        'tabAdditional
        '
        Me.tabAdditional.BackColor = System.Drawing.SystemColors.Control
        Me.tabAdditional.Controls.Add(Me.edtMaxWindowSize)
        Me.tabAdditional.Controls.Add(Me.edtBatchSize)
        Me.tabAdditional.Controls.Add(Me.edtMaxReturnFiles)
        Me.tabAdditional.Controls.Add(Me.edtCharSet)
        Me.tabAdditional.Controls.Add(Me.label5)
        Me.tabAdditional.Controls.Add(Me.label4)
        Me.tabAdditional.Controls.Add(Me.label3)
        Me.tabAdditional.Controls.Add(Me.label2)
        Me.tabAdditional.Controls.Add(Me.label1)
        Me.tabAdditional.Location = New System.Drawing.Point(4, 22)
        Me.tabAdditional.Name = "tabAdditional"
        Me.tabAdditional.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAdditional.Size = New System.Drawing.Size(615, 320)
        Me.tabAdditional.TabIndex = 6
        Me.tabAdditional.Text = "Additional Settings"
        '
        'cbCanRemove
        '
        Me.cbCanRemove.AutoSize = True
        Me.cbCanRemove.Checked = True
        Me.cbCanRemove.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCanRemove.Location = New System.Drawing.Point(160, 95)
        Me.cbCanRemove.Name = "cbCanRemove"
        Me.cbCanRemove.Size = New System.Drawing.Size(66, 17)
        Me.cbCanRemove.TabIndex = 6
        Me.cbCanRemove.Text = "Remove"
        Me.cbCanRemove.UseVisualStyleBackColor = True
        '
        'gbUserPermissions
        '
        Me.gbUserPermissions.Controls.Add(Me.cbCanReadLink)
        Me.gbUserPermissions.Controls.Add(Me.cbCanMakeLink)
        Me.gbUserPermissions.Controls.Add(Me.cbCanRemove)
        Me.gbUserPermissions.Controls.Add(Me.cbCanRename)
        Me.gbUserPermissions.Controls.Add(Me.cbCanWrite)
        Me.gbUserPermissions.Controls.Add(Me.cbCanRead)
        Me.gbUserPermissions.Controls.Add(Me.cbCanRemoveDir)
        Me.gbUserPermissions.Controls.Add(Me.cbCanMakeDir)
        Me.gbUserPermissions.Controls.Add(Me.cbCanList)
        Me.gbUserPermissions.Location = New System.Drawing.Point(99, 128)
        Me.gbUserPermissions.Name = "gbUserPermissions"
        Me.gbUserPermissions.Size = New System.Drawing.Size(406, 128)
        Me.gbUserPermissions.TabIndex = 7
        Me.gbUserPermissions.TabStop = False
        Me.gbUserPermissions.Text = "User Permissions"
        '
        'cbCanRename
        '
        Me.cbCanRename.AutoSize = True
        Me.cbCanRename.Checked = True
        Me.cbCanRename.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCanRename.Location = New System.Drawing.Point(160, 72)
        Me.cbCanRename.Name = "cbCanRename"
        Me.cbCanRename.Size = New System.Drawing.Size(66, 17)
        Me.cbCanRename.TabIndex = 5
        Me.cbCanRename.Text = "Rename"
        Me.cbCanRename.UseVisualStyleBackColor = True
        '
        'cbCanWrite
        '
        Me.cbCanWrite.AutoSize = True
        Me.cbCanWrite.Checked = True
        Me.cbCanWrite.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCanWrite.Location = New System.Drawing.Point(160, 49)
        Me.cbCanWrite.Name = "cbCanWrite"
        Me.cbCanWrite.Size = New System.Drawing.Size(51, 17)
        Me.cbCanWrite.TabIndex = 4
        Me.cbCanWrite.Text = "Write"
        Me.cbCanWrite.UseVisualStyleBackColor = True
        '
        'cbCanRead
        '
        Me.cbCanRead.AutoSize = True
        Me.cbCanRead.Checked = True
        Me.cbCanRead.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCanRead.Location = New System.Drawing.Point(160, 26)
        Me.cbCanRead.Name = "cbCanRead"
        Me.cbCanRead.Size = New System.Drawing.Size(52, 17)
        Me.cbCanRead.TabIndex = 3
        Me.cbCanRead.Text = "Read"
        Me.cbCanRead.UseVisualStyleBackColor = True
        '
        'cbCanRemoveDir
        '
        Me.cbCanRemoveDir.AutoSize = True
        Me.cbCanRemoveDir.Checked = True
        Me.cbCanRemoveDir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCanRemoveDir.Location = New System.Drawing.Point(21, 72)
        Me.cbCanRemoveDir.Name = "cbCanRemoveDir"
        Me.cbCanRemoveDir.Size = New System.Drawing.Size(82, 17)
        Me.cbCanRemoveDir.TabIndex = 2
        Me.cbCanRemoveDir.Text = "Remove Dir"
        Me.cbCanRemoveDir.UseVisualStyleBackColor = True
        '
        'cbCanMakeDir
        '
        Me.cbCanMakeDir.AutoSize = True
        Me.cbCanMakeDir.Checked = True
        Me.cbCanMakeDir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCanMakeDir.Location = New System.Drawing.Point(21, 49)
        Me.cbCanMakeDir.Name = "cbCanMakeDir"
        Me.cbCanMakeDir.Size = New System.Drawing.Size(69, 17)
        Me.cbCanMakeDir.TabIndex = 1
        Me.cbCanMakeDir.Text = "Make Dir"
        Me.cbCanMakeDir.UseVisualStyleBackColor = True
        '
        'cbCanList
        '
        Me.cbCanList.AutoSize = True
        Me.cbCanList.Checked = True
        Me.cbCanList.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCanList.Location = New System.Drawing.Point(21, 26)
        Me.cbCanList.Name = "cbCanList"
        Me.cbCanList.Size = New System.Drawing.Size(42, 17)
        Me.cbCanList.TabIndex = 0
        Me.cbCanList.Text = "List"
        Me.cbCanList.UseVisualStyleBackColor = True
        '
        'edtBannerLanguage
        '
        Me.edtBannerLanguage.Location = New System.Drawing.Point(121, 70)
        Me.edtBannerLanguage.Name = "edtBannerLanguage"
        Me.edtBannerLanguage.Size = New System.Drawing.Size(100, 20)
        Me.edtBannerLanguage.TabIndex = 4
        Me.edtBannerLanguage.Text = "en"
        '
        'edtBannerMessage
        '
        Me.edtBannerMessage.Location = New System.Drawing.Point(121, 40)
        Me.edtBannerMessage.Name = "edtBannerMessage"
        Me.edtBannerMessage.Size = New System.Drawing.Size(469, 20)
        Me.edtBannerMessage.TabIndex = 3
        '
        'edtLog
        '
        Me.edtLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.edtLog.Location = New System.Drawing.Point(3, 180)
        Me.edtLog.Multiline = True
        Me.edtLog.Name = "edtLog"
        Me.edtLog.ReadOnly = True
        Me.edtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.edtLog.Size = New System.Drawing.Size(609, 137)
        Me.edtLog.TabIndex = 12
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(482, 113)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(110, 23)
        Me.btnStop.TabIndex = 11
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(482, 83)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(110, 23)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'edtRootDir
        '
        Me.edtRootDir.Location = New System.Drawing.Point(105, 115)
        Me.edtRootDir.Name = "edtRootDir"
        Me.edtRootDir.Size = New System.Drawing.Size(360, 20)
        Me.edtRootDir.TabIndex = 9
        Me.edtRootDir.Text = "C:\CleverFtpServer\"
        '
        'cbUseIPv6
        '
        Me.cbUseIPv6.AutoSize = True
        Me.cbUseIPv6.Location = New System.Drawing.Point(292, 87)
        Me.cbUseIPv6.Name = "cbUseIPv6"
        Me.cbUseIPv6.Size = New System.Drawing.Size(70, 17)
        Me.cbUseIPv6.TabIndex = 8
        Me.cbUseIPv6.Text = "Use IPv6"
        Me.cbUseIPv6.UseVisualStyleBackColor = True
        '
        'edtBindingHost
        '
        Me.edtBindingHost.Location = New System.Drawing.Point(105, 85)
        Me.edtBindingHost.Name = "edtBindingHost"
        Me.edtBindingHost.Size = New System.Drawing.Size(162, 20)
        Me.edtBindingHost.TabIndex = 7
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(105, 58)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(62, 20)
        Me.edtPort.TabIndex = 6
        Me.edtPort.Text = "22"
        '
        'cbEnableBanner
        '
        Me.cbEnableBanner.AutoSize = True
        Me.cbEnableBanner.Location = New System.Drawing.Point(121, 107)
        Me.cbEnableBanner.Name = "cbEnableBanner"
        Me.cbEnableBanner.Size = New System.Drawing.Size(96, 17)
        Me.cbEnableBanner.TabIndex = 5
        Me.cbEnableBanner.Text = "Enable Banner"
        Me.cbEnableBanner.UseVisualStyleBackColor = True
        '
        'tabBanner
        '
        Me.tabBanner.BackColor = System.Drawing.SystemColors.Control
        Me.tabBanner.Controls.Add(Me.cbEnableBanner)
        Me.tabBanner.Controls.Add(Me.edtBannerLanguage)
        Me.tabBanner.Controls.Add(Me.edtBannerMessage)
        Me.tabBanner.Controls.Add(Me.label27)
        Me.tabBanner.Controls.Add(Me.label26)
        Me.tabBanner.Controls.Add(Me.label25)
        Me.tabBanner.Location = New System.Drawing.Point(4, 22)
        Me.tabBanner.Name = "tabBanner"
        Me.tabBanner.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBanner.Size = New System.Drawing.Size(615, 320)
        Me.tabBanner.TabIndex = 1
        Me.tabBanner.Text = "Banner"
        '
        'label27
        '
        Me.label27.AutoSize = True
        Me.label27.Location = New System.Drawing.Point(18, 73)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(55, 13)
        Me.label27.TabIndex = 2
        Me.label27.Text = "Language"
        '
        'label26
        '
        Me.label26.AutoSize = True
        Me.label26.Location = New System.Drawing.Point(18, 43)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(87, 13)
        Me.label26.TabIndex = 1
        Me.label26.Text = "Banner Message"
        '
        'label25
        '
        Me.label25.AutoSize = True
        Me.label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label25.Location = New System.Drawing.Point(18, 12)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(227, 17)
        Me.label25.TabIndex = 0
        Me.label25.Text = "The SFTP Server Banner Settings."
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(411, 86)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(54, 17)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Started"
        '
        'label32
        '
        Me.label32.AutoSize = True
        Me.label32.Location = New System.Drawing.Point(18, 150)
        Me.label32.Name = "label32"
        Me.label32.Size = New System.Drawing.Size(62, 13)
        Me.label32.TabIndex = 4
        Me.label32.Text = "Activity Log"
        '
        'label30
        '
        Me.label30.AutoSize = True
        Me.label30.Location = New System.Drawing.Point(18, 88)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(29, 13)
        Me.label30.TabIndex = 2
        Me.label30.Text = "Host"
        '
        'label29
        '
        Me.label29.AutoSize = True
        Me.label29.Location = New System.Drawing.Point(18, 61)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(64, 13)
        Me.label29.TabIndex = 1
        Me.label29.Text = "Binding Port"
        '
        'label28
        '
        Me.label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label28.Location = New System.Drawing.Point(18, 12)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(537, 42)
        Me.label28.TabIndex = 0
        Me.label28.Text = "This is a sample SFTP server, which demonstrates the using of the TclSFtpServer, " &
    "TclSFtpFileHandler, and TclServerGuard components."
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabServer)
        Me.tabControl1.Controls.Add(Me.tabBanner)
        Me.tabControl1.Controls.Add(Me.tabHostKey)
        Me.tabControl1.Controls.Add(Me.tabAccessControl)
        Me.tabControl1.Controls.Add(Me.tabIPBlocking)
        Me.tabControl1.Controls.Add(Me.tabSSHAlgorithms)
        Me.tabControl1.Controls.Add(Me.tabAdditional)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Location = New System.Drawing.Point(0, 78)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(623, 346)
        Me.tabControl1.TabIndex = 3
        '
        'tabServer
        '
        Me.tabServer.BackColor = System.Drawing.SystemColors.Control
        Me.tabServer.Controls.Add(Me.edtLog)
        Me.tabServer.Controls.Add(Me.btnStop)
        Me.tabServer.Controls.Add(Me.btnStart)
        Me.tabServer.Controls.Add(Me.edtRootDir)
        Me.tabServer.Controls.Add(Me.cbUseIPv6)
        Me.tabServer.Controls.Add(Me.edtBindingHost)
        Me.tabServer.Controls.Add(Me.edtPort)
        Me.tabServer.Controls.Add(Me.lblStatus)
        Me.tabServer.Controls.Add(Me.label32)
        Me.tabServer.Controls.Add(Me.label31)
        Me.tabServer.Controls.Add(Me.label30)
        Me.tabServer.Controls.Add(Me.label29)
        Me.tabServer.Controls.Add(Me.label28)
        Me.tabServer.Location = New System.Drawing.Point(4, 22)
        Me.tabServer.Name = "tabServer"
        Me.tabServer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabServer.Size = New System.Drawing.Size(615, 320)
        Me.tabServer.TabIndex = 0
        Me.tabServer.Text = "Server"
        '
        'label31
        '
        Me.label31.AutoSize = True
        Me.label31.Location = New System.Drawing.Point(18, 118)
        Me.label31.Name = "label31"
        Me.label31.Size = New System.Drawing.Size(46, 13)
        Me.label31.TabIndex = 3
        Me.label31.Text = "Root Dir"
        '
        'tabHostKey
        '
        Me.tabHostKey.BackColor = System.Drawing.SystemColors.Control
        Me.tabHostKey.Controls.Add(Me.edtFingerPrint)
        Me.tabHostKey.Controls.Add(Me.btnGenerateHostKey)
        Me.tabHostKey.Controls.Add(Me.edtKeyLength)
        Me.tabHostKey.Controls.Add(Me.edtKeyType)
        Me.tabHostKey.Controls.Add(Me.edtHostKeyPassPhrase)
        Me.tabHostKey.Controls.Add(Me.btnLoadHostKey)
        Me.tabHostKey.Controls.Add(Me.edtHostKeyFile)
        Me.tabHostKey.Controls.Add(Me.label24)
        Me.tabHostKey.Controls.Add(Me.label23)
        Me.tabHostKey.Controls.Add(Me.label22)
        Me.tabHostKey.Controls.Add(Me.label21)
        Me.tabHostKey.Controls.Add(Me.label20)
        Me.tabHostKey.Controls.Add(Me.label19)
        Me.tabHostKey.Location = New System.Drawing.Point(4, 22)
        Me.tabHostKey.Name = "tabHostKey"
        Me.tabHostKey.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHostKey.Size = New System.Drawing.Size(615, 320)
        Me.tabHostKey.TabIndex = 2
        Me.tabHostKey.Text = "Host Key"
        '
        'edtFingerPrint
        '
        Me.edtFingerPrint.Location = New System.Drawing.Point(116, 194)
        Me.edtFingerPrint.Name = "edtFingerPrint"
        Me.edtFingerPrint.ReadOnly = True
        Me.edtFingerPrint.Size = New System.Drawing.Size(452, 20)
        Me.edtFingerPrint.TabIndex = 12
        '
        'btnGenerateHostKey
        '
        Me.btnGenerateHostKey.Location = New System.Drawing.Point(222, 155)
        Me.btnGenerateHostKey.Name = "btnGenerateHostKey"
        Me.btnGenerateHostKey.Size = New System.Drawing.Size(110, 23)
        Me.btnGenerateHostKey.TabIndex = 11
        Me.btnGenerateHostKey.Text = "Generate"
        Me.btnGenerateHostKey.UseVisualStyleBackColor = True
        '
        'edtKeyLength
        '
        Me.edtKeyLength.Location = New System.Drawing.Point(116, 157)
        Me.edtKeyLength.Name = "edtKeyLength"
        Me.edtKeyLength.Size = New System.Drawing.Size(100, 20)
        Me.edtKeyLength.TabIndex = 10
        Me.edtKeyLength.Text = "2048"
        '
        'edtKeyType
        '
        Me.edtKeyType.Enabled = False
        Me.edtKeyType.Location = New System.Drawing.Point(116, 127)
        Me.edtKeyType.Name = "edtKeyType"
        Me.edtKeyType.Size = New System.Drawing.Size(100, 20)
        Me.edtKeyType.TabIndex = 9
        Me.edtKeyType.Text = "ssh-rsa"
        '
        'edtHostKeyPassPhrase
        '
        Me.edtHostKeyPassPhrase.Location = New System.Drawing.Point(116, 90)
        Me.edtHostKeyPassPhrase.Name = "edtHostKeyPassPhrase"
        Me.edtHostKeyPassPhrase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtHostKeyPassPhrase.Size = New System.Drawing.Size(100, 20)
        Me.edtHostKeyPassPhrase.TabIndex = 8
        '
        'btnLoadHostKey
        '
        Me.btnLoadHostKey.Location = New System.Drawing.Point(458, 60)
        Me.btnLoadHostKey.Name = "btnLoadHostKey"
        Me.btnLoadHostKey.Size = New System.Drawing.Size(110, 23)
        Me.btnLoadHostKey.TabIndex = 7
        Me.btnLoadHostKey.Text = "Load"
        Me.btnLoadHostKey.UseVisualStyleBackColor = True
        '
        'edtHostKeyFile
        '
        Me.edtHostKeyFile.Location = New System.Drawing.Point(116, 62)
        Me.edtHostKeyFile.Name = "edtHostKeyFile"
        Me.edtHostKeyFile.Size = New System.Drawing.Size(328, 20)
        Me.edtHostKeyFile.TabIndex = 6
        Me.edtHostKeyFile.Text = "host-key-rsa.key"
        '
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.Location = New System.Drawing.Point(18, 197)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(85, 13)
        Me.label24.TabIndex = 5
        Me.label24.Text = "Fingerprint (md5)"
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Location = New System.Drawing.Point(18, 160)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(61, 13)
        Me.label23.TabIndex = 4
        Me.label23.Text = "Key Lenght"
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.Location = New System.Drawing.Point(18, 130)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(52, 13)
        Me.label22.TabIndex = 3
        Me.label22.Text = "Key Type"
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Location = New System.Drawing.Point(18, 93)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(66, 13)
        Me.label21.TabIndex = 2
        Me.label21.Text = "Pass Phrase"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(18, 65)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(69, 13)
        Me.label20.TabIndex = 1
        Me.label20.Text = "Host Key File"
        '
        'label19
        '
        Me.label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label19.Location = New System.Drawing.Point(18, 12)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(520, 41)
        Me.label19.TabIndex = 0
        Me.label19.Text = "You can load an existing private key or generate a new one. A new key is saved to" &
    " the Host Key File. TclSFtpServer supports only RSA host keys."
        '
        'tabAccessControl
        '
        Me.tabAccessControl.BackColor = System.Drawing.SystemColors.Control
        Me.tabAccessControl.Controls.Add(Me.gbUserPermissions)
        Me.tabAccessControl.Controls.Add(Me.edtUserRootDir)
        Me.tabAccessControl.Controls.Add(Me.edtPassword)
        Me.tabAccessControl.Controls.Add(Me.edtUserName)
        Me.tabAccessControl.Controls.Add(Me.label18)
        Me.tabAccessControl.Controls.Add(Me.label17)
        Me.tabAccessControl.Controls.Add(Me.label16)
        Me.tabAccessControl.Controls.Add(Me.label15)
        Me.tabAccessControl.Location = New System.Drawing.Point(4, 22)
        Me.tabAccessControl.Name = "tabAccessControl"
        Me.tabAccessControl.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAccessControl.Size = New System.Drawing.Size(615, 320)
        Me.tabAccessControl.TabIndex = 3
        Me.tabAccessControl.Text = "Access Control"
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox1.Image = Global.SFtpServer.My.Resources.Resources.background_net
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(623, 78)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox1.TabIndex = 2
        Me.pictureBox1.TabStop = False
        '
        'SFtpServer1
        '
        Me.SFtpServer1.Guard = Me.ServerGuard1
        '
        'SFtpFileHandler1
        '
        Me.SFtpFileHandler1.Server = Me.SFtpServer1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 424)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clever SFTP Server"
        Me.tabIPBlocking.ResumeLayout(False)
        Me.tabIPBlocking.PerformLayout()
        Me.tabSSHAlgorithms.ResumeLayout(False)
        Me.tabSSHAlgorithms.PerformLayout()
        Me.tabAdditional.ResumeLayout(False)
        Me.tabAdditional.PerformLayout()
        Me.gbUserPermissions.ResumeLayout(False)
        Me.gbUserPermissions.PerformLayout()
        Me.tabBanner.ResumeLayout(False)
        Me.tabBanner.PerformLayout()
        Me.tabControl1.ResumeLayout(False)
        Me.tabServer.ResumeLayout(False)
        Me.tabServer.PerformLayout()
        Me.tabHostKey.ResumeLayout(False)
        Me.tabHostKey.PerformLayout()
        Me.tabAccessControl.ResumeLayout(False)
        Me.tabAccessControl.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SFtpServer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents label13 As Label
    Private WithEvents label11 As Label
    Private WithEvents edtUserRootDir As TextBox
    Private WithEvents edtPassword As TextBox
    Private WithEvents edtUserName As TextBox
    Private WithEvents label18 As Label
    Private WithEvents label17 As Label
    Private WithEvents label16 As Label
    Private WithEvents edtBlackList As TextBox
    Private WithEvents edtAllowedConnections As TextBox
    Private WithEvents label14 As Label
    Private WithEvents label15 As Label
    Private WithEvents cbWhiteListOnly As CheckBox
    Private WithEvents tabIPBlocking As TabPage
    Private WithEvents edtWhiteList As TextBox
    Private WithEvents label12 As Label
    Private WithEvents label2 As Label
    Private WithEvents cbCanReadLink As CheckBox
    Private WithEvents tabSSHAlgorithms As TabPage
    Private WithEvents edtDataIntegrityAlgs As TextBox
    Private WithEvents edtEncryptionAlgs As TextBox
    Private WithEvents edtSignatureAlgs As TextBox
    Private WithEvents edtKexAlgs As TextBox
    Private WithEvents label10 As Label
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents edtMaxWindowSize As TextBox
    Private WithEvents edtBatchSize As TextBox
    Private WithEvents edtMaxReturnFiles As TextBox
    Private WithEvents edtCharSet As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
    Private WithEvents cbCanMakeLink As CheckBox
    Private WithEvents tabAdditional As TabPage
    Private WithEvents cbCanRemove As CheckBox
    Private WithEvents gbUserPermissions As GroupBox
    Private WithEvents cbCanRename As CheckBox
    Private WithEvents cbCanWrite As CheckBox
    Private WithEvents cbCanRead As CheckBox
    Private WithEvents cbCanRemoveDir As CheckBox
    Private WithEvents cbCanMakeDir As CheckBox
    Private WithEvents cbCanList As CheckBox
    Private WithEvents edtBannerLanguage As TextBox
    Private WithEvents edtBannerMessage As TextBox
    Private WithEvents edtLog As TextBox
    Private WithEvents btnStop As Button
    Private WithEvents btnStart As Button
    Private WithEvents edtRootDir As TextBox
    Private WithEvents cbUseIPv6 As CheckBox
    Private WithEvents edtBindingHost As TextBox
    Private WithEvents edtPort As TextBox
    Private WithEvents cbEnableBanner As CheckBox
    Private WithEvents tabBanner As TabPage
    Private WithEvents label27 As Label
    Private WithEvents label26 As Label
    Private WithEvents label25 As Label
    Private WithEvents lblStatus As Label
    Private WithEvents label32 As Label
    Private WithEvents label30 As Label
    Private WithEvents label29 As Label
    Private WithEvents label28 As Label
    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabServer As TabPage
    Private WithEvents label31 As Label
    Private WithEvents tabHostKey As TabPage
    Private WithEvents edtFingerPrint As TextBox
    Private WithEvents btnGenerateHostKey As Button
    Private WithEvents edtKeyLength As TextBox
    Private WithEvents edtKeyType As TextBox
    Private WithEvents edtHostKeyPassPhrase As TextBox
    Private WithEvents btnLoadHostKey As Button
    Private WithEvents edtHostKeyFile As TextBox
    Private WithEvents label24 As Label
    Private WithEvents label23 As Label
    Private WithEvents label22 As Label
    Private WithEvents label21 As Label
    Private WithEvents label20 As Label
    Private WithEvents label19 As Label
    Private WithEvents tabAccessControl As TabPage
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents SFtpServer1 As CleverComponents.InetSuite.SFtpServer
    Friend WithEvents SFtpFileHandler1 As CleverComponents.InetSuite.SFtpFileHandler
    Friend WithEvents ServerGuard1 As CleverComponents.InetSuite.ServerGuard
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
