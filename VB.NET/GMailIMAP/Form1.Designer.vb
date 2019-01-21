<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.memBody = New System.Windows.Forms.TextBox()
        Me.edtSubject = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.edtFrom = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.tvFolders = New System.Windows.Forms.ListBox()
        Me.columnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvMessages = New System.Windows.Forms.ListView()
        Me.columnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.edtUser = New System.Windows.Forms.TextBox()
        Me.imap = New CleverComponents.InetSuite.Imap4()
        Me.mailMessage = New CleverComponents.InetSuite.MailMessage()
        Me.oAuth = New CleverComponents.InetSuite.OAuth()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mailMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox1.Image = Global.GMailIMAP.My.Resources.Resources.background_net
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(623, 78)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox1.TabIndex = 42
        Me.pictureBox1.TabStop = False
        '
        'memBody
        '
        Me.memBody.Location = New System.Drawing.Point(196, 341)
        Me.memBody.Multiline = True
        Me.memBody.Name = "memBody"
        Me.memBody.ReadOnly = True
        Me.memBody.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memBody.Size = New System.Drawing.Size(415, 106)
        Me.memBody.TabIndex = 37
        '
        'edtSubject
        '
        Me.edtSubject.Location = New System.Drawing.Point(247, 312)
        Me.edtSubject.Name = "edtSubject"
        Me.edtSubject.ReadOnly = True
        Me.edtSubject.Size = New System.Drawing.Size(364, 20)
        Me.edtSubject.TabIndex = 36
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(193, 315)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(48, 23)
        Me.label8.TabIndex = 41
        Me.label8.Text = "Subject"
        '
        'edtFrom
        '
        Me.edtFrom.Location = New System.Drawing.Point(247, 285)
        Me.edtFrom.Name = "edtFrom"
        Me.edtFrom.ReadOnly = True
        Me.edtFrom.Size = New System.Drawing.Size(364, 20)
        Me.edtFrom.TabIndex = 35
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(193, 288)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(48, 23)
        Me.label7.TabIndex = 40
        Me.label7.Text = "From"
        '
        'tvFolders
        '
        Me.tvFolders.Location = New System.Drawing.Point(15, 157)
        Me.tvFolders.Name = "tvFolders"
        Me.tvFolders.Size = New System.Drawing.Size(167, 290)
        Me.tvFolders.TabIndex = 33
        '
        'columnHeader5
        '
        Me.columnHeader5.Text = "Size"
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "From"
        Me.columnHeader3.Width = 100
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Subject"
        Me.columnHeader2.Width = 100
        '
        'lvMessages
        '
        Me.lvMessages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader2, Me.columnHeader3, Me.columnHeader4, Me.columnHeader5})
        Me.lvMessages.FullRowSelect = True
        Me.lvMessages.HideSelection = False
        Me.lvMessages.Location = New System.Drawing.Point(196, 157)
        Me.lvMessages.Name = "lvMessages"
        Me.lvMessages.Size = New System.Drawing.Size(415, 115)
        Me.lvMessages.TabIndex = 34
        Me.lvMessages.UseCompatibleStateImageBehavior = False
        Me.lvMessages.View = System.Windows.Forms.View.Details
        '
        'columnHeader4
        '
        Me.columnHeader4.Text = "Date"
        Me.columnHeader4.Width = 80
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(193, 137)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(64, 17)
        Me.label6.TabIndex = 39
        Me.label6.Text = "Messages"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(12, 137)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(80, 17)
        Me.label5.TabIndex = 38
        Me.label5.Text = "GMail Folders"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(529, 97)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(82, 26)
        Me.btnLogout.TabIndex = 31
        Me.btnLogout.Text = "Logout"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(436, 97)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(82, 26)
        Me.btnLogin.TabIndex = 30
        Me.btnLogin.Text = "Login"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(12, 104)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 16)
        Me.label2.TabIndex = 32
        Me.label2.Text = "User"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(58, 101)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(124, 20)
        Me.edtUser.TabIndex = 29
        Me.edtUser.Text = "user@gmail.com"
        '
        'mailMessage
        '
        Me.mailMessage.Date = New Date(2007, 1, 10, 13, 51, 45, 827)
        Me.mailMessage.From.Email = ""
        Me.mailMessage.From.Name = ""
        '
        'oAuth
        '
        Me.oAuth.AuthUrl = Nothing
        Me.oAuth.ClientID = Nothing
        Me.oAuth.ClientSecret = Nothing
        Me.oAuth.Password = Nothing
        Me.oAuth.RedirectUrl = Nothing
        Me.oAuth.Scope = Nothing
        Me.oAuth.State = Nothing
        Me.oAuth.TokenUrl = Nothing
        Me.oAuth.UserName = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 452)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.memBody)
        Me.Controls.Add(Me.edtSubject)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.edtFrom)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.tvFolders)
        Me.Controls.Add(Me.lvMessages)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.edtUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GMAIL IMAP client with OAuth - Sample"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mailMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents memBody As TextBox
    Private WithEvents edtSubject As TextBox
    Private WithEvents label8 As Label
    Private WithEvents edtFrom As TextBox
    Private WithEvents label7 As Label
    Private WithEvents tvFolders As ListBox
    Private WithEvents columnHeader5 As ColumnHeader
    Private WithEvents columnHeader3 As ColumnHeader
    Private WithEvents columnHeader2 As ColumnHeader
    Private WithEvents lvMessages As ListView
    Private WithEvents columnHeader4 As ColumnHeader
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents btnLogout As Button
    Private WithEvents btnLogin As Button
    Private WithEvents label2 As Label
    Private WithEvents edtUser As TextBox
    Private WithEvents imap As CleverComponents.InetSuite.Imap4
    Private WithEvents mailMessage As CleverComponents.InetSuite.MailMessage
    Private WithEvents oAuth As CleverComponents.InetSuite.OAuth
End Class
