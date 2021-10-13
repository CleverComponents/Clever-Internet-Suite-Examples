Imports System.Threading
Imports System.IO
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
    Friend WithEvents edtRelayDir As System.Windows.Forms.TextBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents cbUseLogin As System.Windows.Forms.CheckBox
    Friend WithEvents memLog As System.Windows.Forms.TextBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents edtMailboxDir As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents edtPort As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents SmtpServer1 As CleverComponents.InetSuite.SmtpServer
    Friend WithEvents SmtpFileHandler1 As CleverComponents.InetSuite.SmtpFileHandler
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim MailUserAccountItem1 As CleverComponents.InetSuite.MailUserAccountItem = New CleverComponents.InetSuite.MailUserAccountItem()
        Me.edtRelayDir = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.cbUseLogin = New System.Windows.Forms.CheckBox()
        Me.memLog = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.edtMailboxDir = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.edtPort = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SmtpServer1 = New CleverComponents.InetSuite.SmtpServer()
        Me.SmtpFileHandler1 = New CleverComponents.InetSuite.SmtpFileHandler()
        Me.SuspendLayout()
        '
        'edtRelayDir
        '
        Me.edtRelayDir.Location = New System.Drawing.Point(104, 144)
        Me.edtRelayDir.Name = "edtRelayDir"
        Me.edtRelayDir.Size = New System.Drawing.Size(320, 20)
        Me.edtRelayDir.TabIndex = 45
        Me.edtRelayDir.Text = "C:\CleverMailBox\RelayQueue\"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(16, 144)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(56, 23)
        Me.label6.TabIndex = 44
        Me.label6.Text = "Relay Dir"
        '
        'cbUseLogin
        '
        Me.cbUseLogin.Checked = True
        Me.cbUseLogin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbUseLogin.Location = New System.Drawing.Point(104, 176)
        Me.cbUseLogin.Name = "cbUseLogin"
        Me.cbUseLogin.Size = New System.Drawing.Size(296, 24)
        Me.cbUseLogin.TabIndex = 43
        Me.cbUseLogin.Text = "Use Authentication - LOGIN / CRAM-MD5 / NTLM"
        '
        'memLog
        '
        Me.memLog.Location = New System.Drawing.Point(0, 256)
        Me.memLog.Multiline = True
        Me.memLog.Name = "memLog"
        Me.memLog.ReadOnly = True
        Me.memLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memLog.Size = New System.Drawing.Size(440, 120)
        Me.memLog.TabIndex = 42
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(16, 224)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(48, 23)
        Me.label5.TabIndex = 41
        Me.label5.Text = "Log"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(232, 208)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 40
        Me.btnStop.Text = "Stop"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(104, 208)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 39
        Me.btnStart.Text = "Start"
        '
        'edtMailboxDir
        '
        Me.edtMailboxDir.Location = New System.Drawing.Point(104, 120)
        Me.edtMailboxDir.Name = "edtMailboxDir"
        Me.edtMailboxDir.Size = New System.Drawing.Size(320, 20)
        Me.edtMailboxDir.TabIndex = 38
        Me.edtMailboxDir.Text = "C:\CleverMailBox\"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 120)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 23)
        Me.label4.TabIndex = 37
        Me.label4.Text = "Mailbox Dir"
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(104, 88)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(168, 20)
        Me.edtPort.TabIndex = 36
        Me.edtPort.Text = "25"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 88)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(32, 23)
        Me.label3.TabIndex = 35
        Me.label3.Text = "Port"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 48)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(408, 32)
        Me.label2.TabIndex = 34
        Me.label2.Text = "Please use the ""CleverTester"" user name and ""clevertester"" password to log-in. Th" &
    "e user e-mail: CleverTester@company.mail"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(416, 29)
        Me.label1.TabIndex = 33
        Me.label1.Text = "This is a sample SMTP server. You can use any mail client with SMTP support to co" &
    "nnect to this server."
        '
        'SmtpServer1
        '
        Me.SmtpServer1.HelpText = New String() {"Commands Supported:", "HELO EHLO AUTH HELP QUIT MAIL NOOP RSET RCPT DATA STARTTLS"}
        MailUserAccountItem1.DisplayName = "Clever Tester"
        MailUserAccountItem1.Email = "CleverTester@company.mail"
        MailUserAccountItem1.Password = "clevertester"
        MailUserAccountItem1.UserName = "CleverTester"
        Me.SmtpServer1.UserAccounts.AddRange(New CleverComponents.InetSuite.UserAccountItem() {MailUserAccountItem1})
        '
        'SmtpFileHandler1
        '
        Me.SmtpFileHandler1.MailBoxDir = Nothing
        Me.SmtpFileHandler1.RelayDir = Nothing
        Me.SmtpFileHandler1.Server = Me.SmtpServer1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 376)
        Me.Controls.Add(Me.edtRelayDir)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.cbUseLogin)
        Me.Controls.Add(Me.memLog)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.edtMailboxDir)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.edtPort)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clever SMTP Server"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Delegate Sub PutLogMessageDelegate(ByVal logMessage As String)

    Private Sub PutLogMessage(ByVal logMessage As String)
        If Me.IsDisposed Then
            Exit Sub
        End If

        If Me.InvokeRequired Then
            Me.Invoke(New PutLogMessageDelegate(AddressOf PutLogMessage), New Object() {logMessage})
        Else
            memLog.Text = memLog.Text + logMessage + ControlChars.Cr + ControlChars.Lf
            memLog.Select(memLog.Text.Length, 0)
            memLog.ScrollToCaret()
        End If
    End Sub

    Private Function AddTrailingBackSlash(ByVal path As String) As String
        AddTrailingBackSlash = path
        If (Not StringUtils.IsEmpty(path)) Then
            If Mid(path, Len(path), 1) <> "\" Then
                AddTrailingBackSlash = path + "\"
            End If
        End If
    End Function

    Private Function GetSettingsFile() As String
        GetSettingsFile = AddTrailingBackSlash(edtMailboxDir.Text) + "smtp.dat"
    End Function

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Try
            SmtpServer1.UseAuth = cbUseLogin.Checked
            SmtpServer1.Port = Convert.ToInt32(edtPort.Text)

            SmtpFileHandler1.MailBoxDir = edtMailboxDir.Text
            SmtpFileHandler1.RelayDir = edtRelayDir.Text

            Directory.CreateDirectory(AddTrailingBackSlash(SmtpFileHandler1.MailBoxDir) + "CleverTester\")
            Directory.CreateDirectory(AddTrailingBackSlash(SmtpFileHandler1.RelayDir))

            SmtpServer1.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        SmtpServer1.Stop()
    End Sub

    Private Sub SmtpServer1_ConnectionAccepted(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.ConnectionAcceptedEventArgs) Handles SmtpServer1.ConnectionAccepted
        PutLogMessage("Accept Connection. Host: " + e.Connection.PeerIP.ToString())
    End Sub

    Private Sub SmtpServer1_ConnectionClosed(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.ConnectionEventArgs) Handles SmtpServer1.ConnectionClosed
        PutLogMessage("Close Connection. Host: " + e.Connection.PeerIP.ToString())
    End Sub

    Private Sub SmtpServer1_LoginAuthenticate(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.SmtpAuthenticateEventArgs) Handles SmtpServer1.Authenticate
        PutLogMessage("Authenticate user: " + e.UserName)
    End Sub

    Private Sub SmtpServer1_CommandReceived(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.TcpCommandEventArgs) Handles SmtpServer1.CommandReceived
        PutLogMessage("Command: " + e.CommandParams.RawCommand)
    End Sub

    Private Sub SmtpServer1_ResponseSent(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.TcpResponseEventArgs) Handles SmtpServer1.ResponseSent
        PutLogMessage("Reply: " + e.Response)
    End Sub

    Private Sub SmtpServer1_Started(ByVal sender As Object, ByVal e As System.EventArgs) Handles SmtpServer1.Started
        PutLogMessage("==================" + ControlChars.Cr + ControlChars.Lf + "Start Server")
    End Sub

    Private Sub SmtpServer1_Stopped(ByVal sender As Object, ByVal e As System.EventArgs) Handles SmtpServer1.Stopped
        PutLogMessage("Stop Server")
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ini As New IniFile(GetSettingsFile())
        Try
            SmtpFileHandler1.Counter = Convert.ToInt32(ini.IniReadValue("SMTP", "Counter", "1"))
        Catch ex As Exception
            SmtpFileHandler1.Counter = 1
        End Try
    End Sub

    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim ini As New IniFile(GetSettingsFile())
        ini.IniWriteValue("SMTP", "Counter", SmtpFileHandler1.Counter.ToString())
    End Sub
End Class
