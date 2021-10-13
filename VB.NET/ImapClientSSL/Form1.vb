Imports CleverComponents.InetSuite

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents memBody As System.Windows.Forms.TextBox
    Friend WithEvents edtSubject As System.Windows.Forms.TextBox
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents edtFrom As System.Windows.Forms.TextBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents lvMessages As System.Windows.Forms.ListView
    Friend WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents columnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents columnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents columnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents tvFolders As System.Windows.Forms.ListBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents cbUseTLS As System.Windows.Forms.CheckBox
    Friend WithEvents edtPort As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents edtPassword As System.Windows.Forms.TextBox
    Friend WithEvents edtUser As System.Windows.Forms.TextBox
    Friend WithEvents edtServer As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Imap41 As CleverComponents.InetSuite.Imap4
    Friend WithEvents MailMessage1 As CleverComponents.InetSuite.MailMessage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.memBody = New System.Windows.Forms.TextBox()
        Me.edtSubject = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.edtFrom = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.lvMessages = New System.Windows.Forms.ListView()
        Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.tvFolders = New System.Windows.Forms.ListBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.cbUseTLS = New System.Windows.Forms.CheckBox()
        Me.edtPort = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.edtPassword = New System.Windows.Forms.TextBox()
        Me.edtUser = New System.Windows.Forms.TextBox()
        Me.edtServer = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Imap41 = New CleverComponents.InetSuite.Imap4()
        Me.MailMessage1 = New CleverComponents.InetSuite.MailMessage()
        CType(Me.Imap41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'memBody
        '
        Me.memBody.Location = New System.Drawing.Point(185, 296)
        Me.memBody.Multiline = True
        Me.memBody.Name = "memBody"
        Me.memBody.ReadOnly = True
        Me.memBody.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memBody.Size = New System.Drawing.Size(344, 96)
        Me.memBody.TabIndex = 42
        '
        'edtSubject
        '
        Me.edtSubject.Location = New System.Drawing.Point(233, 272)
        Me.edtSubject.Name = "edtSubject"
        Me.edtSubject.ReadOnly = True
        Me.edtSubject.Size = New System.Drawing.Size(296, 20)
        Me.edtSubject.TabIndex = 41
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(185, 272)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(48, 23)
        Me.label8.TabIndex = 47
        Me.label8.Text = "Subject"
        '
        'edtFrom
        '
        Me.edtFrom.Location = New System.Drawing.Point(233, 248)
        Me.edtFrom.Name = "edtFrom"
        Me.edtFrom.ReadOnly = True
        Me.edtFrom.Size = New System.Drawing.Size(296, 20)
        Me.edtFrom.TabIndex = 40
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(185, 248)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(48, 23)
        Me.label7.TabIndex = 46
        Me.label7.Text = "From"
        '
        'lvMessages
        '
        Me.lvMessages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader2, Me.columnHeader3, Me.columnHeader4, Me.columnHeader5})
        Me.lvMessages.FullRowSelect = True
        Me.lvMessages.HideSelection = False
        Me.lvMessages.Location = New System.Drawing.Point(177, 128)
        Me.lvMessages.Name = "lvMessages"
        Me.lvMessages.Size = New System.Drawing.Size(352, 104)
        Me.lvMessages.TabIndex = 39
        Me.lvMessages.UseCompatibleStateImageBehavior = False
        Me.lvMessages.View = System.Windows.Forms.View.Details
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Subject"
        Me.columnHeader2.Width = 100
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "From"
        Me.columnHeader3.Width = 100
        '
        'columnHeader4
        '
        Me.columnHeader4.Text = "Date"
        Me.columnHeader4.Width = 80
        '
        'columnHeader5
        '
        Me.columnHeader5.Text = "Size"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(193, 104)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(64, 23)
        Me.label6.TabIndex = 45
        Me.label6.Text = "Messages"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(17, 104)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(80, 23)
        Me.label5.TabIndex = 44
        Me.label5.Text = "Imap Folders"
        '
        'tvFolders
        '
        Me.tvFolders.Location = New System.Drawing.Point(17, 128)
        Me.tvFolders.Name = "tvFolders"
        Me.tvFolders.Size = New System.Drawing.Size(152, 264)
        Me.tvFolders.TabIndex = 38
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(433, 48)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(96, 23)
        Me.btnLogout.TabIndex = 35
        Me.btnLogout.Text = "Logout"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(433, 16)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(96, 23)
        Me.btnLogin.TabIndex = 33
        Me.btnLogin.Text = "Login"
        '
        'cbUseTLS
        '
        Me.cbUseTLS.Checked = True
        Me.cbUseTLS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbUseTLS.Location = New System.Drawing.Point(313, 40)
        Me.cbUseTLS.Name = "cbUseTLS"
        Me.cbUseTLS.Size = New System.Drawing.Size(104, 24)
        Me.cbUseTLS.TabIndex = 30
        Me.cbUseTLS.Text = "Use SSL / TLS"
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(81, 40)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(48, 20)
        Me.edtPort.TabIndex = 29
        Me.edtPort.Text = "993"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(17, 40)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(48, 16)
        Me.label4.TabIndex = 43
        Me.label4.Text = "Port"
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(313, 72)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtPassword.Size = New System.Drawing.Size(104, 20)
        Me.edtPassword.TabIndex = 32
        Me.edtPassword.Text = "clevertester"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(81, 72)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(104, 20)
        Me.edtUser.TabIndex = 31
        Me.edtUser.Text = "CleverTester"
        '
        'edtServer
        '
        Me.edtServer.Location = New System.Drawing.Point(81, 16)
        Me.edtServer.Name = "edtServer"
        Me.edtServer.Size = New System.Drawing.Size(336, 20)
        Me.edtServer.TabIndex = 28
        Me.edtServer.Text = "localhost"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(241, 72)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 16)
        Me.label3.TabIndex = 37
        Me.label3.Text = "Password"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(17, 72)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 16)
        Me.label2.TabIndex = 36
        Me.label2.Text = "User"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(17, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 16)
        Me.label1.TabIndex = 34
        Me.label1.Text = "Server"
        '
        'Imap41
        '
        '
        'MailMessage1
        '
        Me.MailMessage1.Date = New Date(2007, 1, 13, 2, 57, 53, 124)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(546, 408)
        Me.Controls.Add(Me.memBody)
        Me.Controls.Add(Me.edtSubject)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.edtFrom)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.lvMessages)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.tvFolders)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.cbUseTLS)
        Me.Controls.Add(Me.edtPort)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.edtUser)
        Me.Controls.Add(Me.edtServer)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMAP4 Client with SSL / TLS support"
        CType(Me.Imap41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private certificateVerified As Boolean

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If Imap41.Active Then
            Exit Sub
        End If

        certificateVerified = False

        Imap41.Server = edtServer.Text
        Imap41.Port = Convert.ToInt32(edtPort.Text)
        If cbUseTLS.Checked Then
            Imap41.UseTls = ClientTlsMode.Automatic
        Else
            Imap41.UseTls = ClientTlsMode.None
        End If

        Imap41.UserName = edtUser.Text
        Imap41.Password = edtPassword.Text

        Imap41.Open()

        FillFolderList()
    End Sub

    Private Sub FillFolderList()
        tvFolders.Items.Clear()
        lvMessages.Items.Clear()

        edtFrom.Text = ""
        edtSubject.Text = ""
        memBody.Text = ""

        Dim mailboxes As String() = Imap41.GetMailBoxes()

        Dim i As Integer
        For i = 0 To mailboxes.Length - 1
            tvFolders.Items.Add(mailboxes(i).ToString())

        Next i
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Imap41.Close()
        tvFolders.Items.Clear()
        lvMessages.Items.Clear()
        ClearMessage()
    End Sub

    Private Sub ClearMessage()
        edtFrom.Text = ""
        edtSubject.Text = ""
        memBody.Text = ""
    End Sub

    Private Sub tvFolders_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvFolders.SelectedIndexChanged
        If (tvFolders.SelectedIndex > -1) And Imap41.Active Then
            Imap41.SelectMailBox(tvFolders.Items(tvFolders.SelectedIndex).ToString())
        End If
        FillMessages()
    End Sub

    Private Sub FillMessages()
        lvMessages.Items.Clear()
        ClearMessage()

        Dim i As Integer
        For i = 1 To Imap41.CurrentMailBox.ExistsMessages
            Imap41.RetrieveHeader(i, MailMessage1)

            Dim item As ListViewItem = lvMessages.Items.Add(MailMessage1.Subject)

            item.SubItems.Add(MailMessage1.From.FullAddress)
            item.SubItems.Add(MailMessage1.Date.ToString())
            item.SubItems.Add(Imap41.GetMessageSize(i).ToString())
            item.SubItems.Add(i.ToString())
        Next i
    End Sub

    Private Sub lvMessages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvMessages.SelectedIndexChanged
        If Imap41.Active And lvMessages.SelectedItems.Count > 0 Then
            Imap41.RetrieveMessage(Convert.ToInt32(lvMessages.SelectedItems(0).SubItems(4).Text), MailMessage1)

            edtFrom.Text = MailMessage1.From.FullAddress
            edtSubject.Text = MailMessage1.Subject
            memBody.Lines = MailMessage1.MessageText
        Else
            ClearMessage()
        End If
    End Sub

    Private Sub Imap41_VerifyServer(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.VerifyPeerEventArgs) Handles Imap41.VerifyServer
        If Not e.Verified Then
            e.Verified = certificateVerified
        End If

        If (Not e.Verified) Then
            If (MessageBox.Show(e.StatusText + ControlChars.Cr + ControlChars.Lf + _
            "Do you wish to proceed ?", "Verify certificate", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                e.Verified = True
                certificateVerified = True
            End If
        End If
    End Sub
End Class
