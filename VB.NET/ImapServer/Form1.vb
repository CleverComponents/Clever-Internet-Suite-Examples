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
    Friend WithEvents memLog As System.Windows.Forms.TextBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents edtRootDir As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents edtPort As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents Imap4Server1 As CleverComponents.InetSuite.Imap4Server
    Friend WithEvents Imap4FileHandler1 As CleverComponents.InetSuite.Imap4FileHandler
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim MailUserAccountItem1 As CleverComponents.InetSuite.MailUserAccountItem = New CleverComponents.InetSuite.MailUserAccountItem
        Me.memLog = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnStart = New System.Windows.Forms.Button
        Me.edtRootDir = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.edtPort = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.Imap4Server1 = New CleverComponents.InetSuite.Imap4Server
        Me.Imap4FileHandler1 = New CleverComponents.InetSuite.Imap4FileHandler
        Me.SuspendLayout()
        '
        'memLog
        '
        Me.memLog.Location = New System.Drawing.Point(0, 192)
        Me.memLog.Multiline = True
        Me.memLog.Name = "memLog"
        Me.memLog.ReadOnly = True
        Me.memLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memLog.Size = New System.Drawing.Size(440, 136)
        Me.memLog.TabIndex = 29
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(16, 168)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(48, 23)
        Me.label5.TabIndex = 28
        Me.label5.Text = "Log"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(176, 144)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 27
        Me.btnStop.Text = "Stop"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(80, 144)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 26
        Me.btnStart.Text = "Start"
        '
        'edtRootDir
        '
        Me.edtRootDir.Location = New System.Drawing.Point(80, 112)
        Me.edtRootDir.Name = "edtRootDir"
        Me.edtRootDir.Size = New System.Drawing.Size(336, 20)
        Me.edtRootDir.TabIndex = 25
        Me.edtRootDir.Text = "C:\CleverMailBox\"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 112)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 23)
        Me.label4.TabIndex = 24
        Me.label4.Text = "Root Dir"
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(80, 80)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(168, 20)
        Me.edtPort.TabIndex = 23
        Me.edtPort.Text = "143"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 80)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(32, 23)
        Me.label3.TabIndex = 22
        Me.label3.Text = "Port"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 48)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(408, 23)
        Me.label2.TabIndex = 21
        Me.label2.Text = "Please use the ""CleverTester"" user name and ""clevertester"" password to log-in."
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(416, 29)
        Me.label1.TabIndex = 20
        Me.label1.Text = "This is a sample IMAP server. You can use any mail client with IMAP support to co" & _
            "nnect to this server."
        '
        'Imap4Server1
        '
        Me.Imap4Server1.Port = 143
        Me.Imap4Server1.ServerName = "Clever Internet Suite IMAP4 service"
        MailUserAccountItem1.DisplayName = ""
        MailUserAccountItem1.Password = "clevertester"
        MailUserAccountItem1.UserName = "CleverTester"
        Me.Imap4Server1.UserAccounts.AddRange(New CleverComponents.InetSuite.UserAccountItem() {MailUserAccountItem1})
        '
        'Imap4FileHandler1
        '
        Me.Imap4FileHandler1.Server = Me.Imap4Server1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 326)
        Me.Controls.Add(Me.memLog)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.edtRootDir)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.edtPort)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Clever IMAP4 Server"
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

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Try
            Imap4Server1.Port = Convert.ToInt32(edtPort.Text)
            Imap4FileHandler1.MailBoxDir = edtRootDir.Text
            Directory.CreateDirectory(AddTrailingBackSlash(Imap4FileHandler1.MailBoxDir))
            Directory.CreateDirectory(AddTrailingBackSlash(Imap4FileHandler1.MailBoxDir) + "CleverTester\")
            Imap4Server1.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Imap4Server1.Stop()
    End Sub

    Private Sub Imap4Server1_Started(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imap4Server1.Started
        PutLogMessage("==================" + ControlChars.Cr + ControlChars.Lf + "Start Server")
    End Sub

    Private Sub Imap4Server1_Stopped(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imap4Server1.Stopped
        PutLogMessage("Stop Server")
    End Sub

    Private Sub Imap4Server1_ConnectionAccepted(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.ConnectionAcceptedEventArgs) Handles Imap4Server1.ConnectionAccepted
        PutLogMessage("Accept Connection. Host: " + e.Connection.PeerIP.ToString())
    End Sub

    Private Sub Imap4Server1_ConnectionClosed(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.ConnectionEventArgs) Handles Imap4Server1.ConnectionClosed
        PutLogMessage("Close Connection. Host: " + e.Connection.PeerIP.ToString())
    End Sub

    Private Sub Imap4Server1_CommandReceived(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.TcpCommandEventArgs) Handles Imap4Server1.CommandReceived
        PutLogMessage("Command: " + e.CommandParams.Command + " " + e.CommandParams.Parameters)
    End Sub

    Private Sub Imap4Server1_ResponseSent(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.TcpResponseEventArgs) Handles Imap4Server1.ResponseSent
        PutLogMessage("Reply: " + e.Response)
    End Sub

    Private Sub Imap4Server1_Authenticate(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.Imap4AuthenticateEventArgs) Handles Imap4Server1.Authenticate
        If Not (e.Account Is Nothing) Then
            PutLogMessage("Authenticate user: " + e.Account.UserName)
        End If
    End Sub
End Class
