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

        cbUseTls.SelectedIndex = 1
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
    Friend WithEvents FtpServer1 As CleverComponents.InetSuite.FtpServer
    Friend WithEvents FtpFileHandler1 As CleverComponents.InetSuite.FtpFileHandler
    Friend WithEvents cbUseTls As System.Windows.Forms.ComboBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents memLog As System.Windows.Forms.TextBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents edtRootDir As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents edtPort As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents CertificateStore1 As CleverComponents.InetSuite.CertificateStore
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim FtpUserAccountItem1 As CleverComponents.InetSuite.FtpUserAccountItem = New CleverComponents.InetSuite.FtpUserAccountItem()
        Me.FtpServer1 = New CleverComponents.InetSuite.FtpServer()
        Me.FtpFileHandler1 = New CleverComponents.InetSuite.FtpFileHandler()
        Me.cbUseTls = New System.Windows.Forms.ComboBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.memLog = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.edtRootDir = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.edtPort = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.CertificateStore1 = New CleverComponents.InetSuite.CertificateStore()
        Me.SuspendLayout()
        '
        'FtpServer1
        '
        Me.FtpServer1.CaseInsensitive = True
        Me.FtpServer1.Extensions = New String() {"SIZE", "REST STREAM", "MDTM"}
        FtpUserAccountItem1.DisplayName = "Clever Tester"
        FtpUserAccountItem1.Password = "clevertester"
        FtpUserAccountItem1.UserName = "CleverTester"
        Me.FtpServer1.UserAccounts.AddRange(New CleverComponents.InetSuite.UserAccountItem() {FtpUserAccountItem1})
        '
        'FtpFileHandler1
        '
        Me.FtpFileHandler1.Server = Me.FtpServer1
        '
        'cbUseTls
        '
        Me.cbUseTls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUseTls.Items.AddRange(New Object() {"None", "Implicit", "Allow Explicit", "Require Explicit"})
        Me.cbUseTls.Location = New System.Drawing.Point(296, 152)
        Me.cbUseTls.Name = "cbUseTls"
        Me.cbUseTls.Size = New System.Drawing.Size(121, 21)
        Me.cbUseTls.TabIndex = 17
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(201, 155)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(89, 23)
        Me.label7.TabIndex = 24
        Me.label7.Text = "SSL / TLS Mode"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(16, 56)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(408, 48)
        Me.label6.TabIndex = 23
        Me.label6.Text = "This server uses self-signed server certificate to establish the SSL connection. " &
    "In real application you will need to request a certificate from trusted issuer o" &
    "r use your own self-signed certificate."
        '
        'memLog
        '
        Me.memLog.Location = New System.Drawing.Point(0, 264)
        Me.memLog.Multiline = True
        Me.memLog.Name = "memLog"
        Me.memLog.ReadOnly = True
        Me.memLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memLog.Size = New System.Drawing.Size(440, 136)
        Me.memLog.TabIndex = 22
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(16, 240)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(48, 23)
        Me.label5.TabIndex = 21
        Me.label5.Text = "Log"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(147, 210)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 20
        Me.btnStop.Text = "Stop"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(66, 210)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 19
        Me.btnStart.Text = "Start"
        '
        'edtRootDir
        '
        Me.edtRootDir.Location = New System.Drawing.Point(66, 184)
        Me.edtRootDir.Name = "edtRootDir"
        Me.edtRootDir.Size = New System.Drawing.Size(350, 20)
        Me.edtRootDir.TabIndex = 18
        Me.edtRootDir.Text = "C:\CleverFtpServer\"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 184)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 23)
        Me.label4.TabIndex = 16
        Me.label4.Text = "Root Dir"
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(66, 152)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(78, 20)
        Me.edtPort.TabIndex = 15
        Me.edtPort.Text = "990"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 155)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(32, 23)
        Me.label3.TabIndex = 14
        Me.label3.Text = "Port"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 112)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(408, 23)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Please use the ""CleverTester"" user name and ""clevertester"" password to log-in."
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(416, 32)
        Me.label1.TabIndex = 12
        Me.label1.Text = "This is a sample FTP SSL / TLS server. You can use any SSL-enabled FTP client (su" &
    "ch as TclFTP or SurgeFTP client to connect to this server."
        '
        'CertificateStore1
        '
        Me.CertificateStore1.ValidFrom = New Date(2017, 8, 26, 11, 57, 31, 828)
        Me.CertificateStore1.ValidTo = New Date(2018, 8, 26, 11, 57, 31, 828)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 400)
        Me.Controls.Add(Me.cbUseTls)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clever FTP Server"
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

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Try
            Select Case cbUseTls.SelectedIndex
                Case 0
                    FtpServer1.UseTls = ServerTlsMode.None
                Case 1
                    FtpServer1.UseTls = ServerTlsMode.Implicit
                Case 2
                    FtpServer1.UseTls = ServerTlsMode.ExplicitAllow
                Case 3
                    FtpServer1.UseTls = ServerTlsMode.ExplicitRequire
            End Select

            FtpServer1.Port = Convert.ToInt32(edtPort.Text)
            FtpServer1.RootDir = edtRootDir.Text
            Directory.CreateDirectory(FtpServer1.RootDir)
            FtpServer1.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        FtpServer1.Stop()
    End Sub

    Private Sub FtpServer1_Authenticate(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.FtpAuthenticateEventArgs) Handles FtpServer1.Authenticate
        PutLogMessage("Authenticate user: " + e.UserName)
    End Sub

    Private Sub FtpServer1_CommandReceived(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.TcpCommandEventArgs) Handles FtpServer1.CommandReceived
        PutLogMessage("Command: " + e.CommandParams.RawCommand)
    End Sub

    Private Sub FtpServer1_ConnectionAccepted(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.ConnectionAcceptedEventArgs) Handles FtpServer1.ConnectionAccepted
        PutLogMessage("Accept Connection. Host: " + e.Connection.PeerIP.ToString())
    End Sub

    Private Sub FtpServer1_ConnectionClosed(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.ConnectionEventArgs) Handles FtpServer1.ConnectionClosed
        PutLogMessage("Close Connection. Host: " + e.Connection.PeerIP.ToString())
    End Sub

    Private Sub FtpServer1_ResponseSent(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.TcpResponseEventArgs) Handles FtpServer1.ResponseSent
        PutLogMessage("Reply: " + e.Response)
    End Sub

    Private Sub FtpServer1_Started(ByVal sender As Object, ByVal e As System.EventArgs) Handles FtpServer1.Started
        PutLogMessage("==================" + ControlChars.Cr + ControlChars.Lf + "Start Server")
    End Sub

    Private Sub FtpServer1_Stopped(ByVal sender As Object, ByVal e As System.EventArgs) Handles FtpServer1.Stopped
        PutLogMessage("Stop Server")
    End Sub

    Private Sub FtpServer1_GetCertificate(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.GetCertificateEventArgs) Handles FtpServer1.GetCertificate
        If CertificateStore1.Items.Count = 0 Then
            Dim cert As Certificate = CertificateStore1.CreateSelfSigned("CN=CleverTester,O=CleverComponents,E=CleverTester@company.mail", 0)
            CertificateStore1.Items.Add(cert)
        End If

        e.Certificate = CertificateStore1.Items(0)
        e.Handled = True
    End Sub
End Class
