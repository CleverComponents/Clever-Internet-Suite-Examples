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
    Friend WithEvents FtpServer1 As CleverComponents.InetSuite.FtpServer
    Friend WithEvents FtpFileHandler1 As CleverComponents.InetSuite.FtpFileHandler
    Friend WithEvents ServerGuard1 As CleverComponents.InetSuite.ServerGuard
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents edtAllowedConnections As System.Windows.Forms.TextBox
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents cbWhiteListOnly As System.Windows.Forms.CheckBox
    Friend WithEvents edtWhiteList As System.Windows.Forms.TextBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents edtBlackList As System.Windows.Forms.TextBox
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim FtpUserAccountItem1 As CleverComponents.InetSuite.FtpUserAccountItem = New CleverComponents.InetSuite.FtpUserAccountItem()
        Me.FtpServer1 = New CleverComponents.InetSuite.FtpServer()
        Me.ServerGuard1 = New CleverComponents.InetSuite.ServerGuard()
        Me.FtpFileHandler1 = New CleverComponents.InetSuite.FtpFileHandler()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.edtAllowedConnections = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.cbWhiteListOnly = New System.Windows.Forms.CheckBox()
        Me.edtWhiteList = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.edtBlackList = New System.Windows.Forms.TextBox()
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
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FtpServer1
        '
        Me.FtpServer1.CaseInsensitive = True
        Me.FtpServer1.Extensions = New String() {"SIZE", "REST STREAM", "MDTM"}
        Me.FtpServer1.Guard = Me.ServerGuard1
        Me.FtpServer1.PassiveHost = Nothing
        FtpUserAccountItem1.DisplayName = "Clever Tester"
        FtpUserAccountItem1.Password = "clevertester"
        FtpUserAccountItem1.UserName = "CleverTester"
        Me.FtpServer1.UserAccounts.AddRange(New CleverComponents.InetSuite.UserAccountItem() {FtpUserAccountItem1})
        '
        'FtpFileHandler1
        '
        Me.FtpFileHandler1.Server = Me.FtpServer1
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.edtAllowedConnections)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.cbWhiteListOnly)
        Me.groupBox1.Controls.Add(Me.edtWhiteList)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.edtBlackList)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Location = New System.Drawing.Point(17, 112)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(416, 168)
        Me.groupBox1.TabIndex = 19
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Server Guard settings"
        '
        'edtAllowedConnections
        '
        Me.edtAllowedConnections.Location = New System.Drawing.Point(280, 24)
        Me.edtAllowedConnections.Name = "edtAllowedConnections"
        Me.edtAllowedConnections.Size = New System.Drawing.Size(48, 20)
        Me.edtAllowedConnections.TabIndex = 6
        Me.edtAllowedConnections.Text = "6"
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(8, 24)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(272, 23)
        Me.label8.TabIndex = 22
        Me.label8.Text = "Allowed Connections from the same host per minute"
        '
        'cbWhiteListOnly
        '
        Me.cbWhiteListOnly.Location = New System.Drawing.Point(216, 136)
        Me.cbWhiteListOnly.Name = "cbWhiteListOnly"
        Me.cbWhiteListOnly.Size = New System.Drawing.Size(136, 24)
        Me.cbWhiteListOnly.TabIndex = 9
        Me.cbWhiteListOnly.Text = "Allow Whitelist only"
        '
        'edtWhiteList
        '
        Me.edtWhiteList.Location = New System.Drawing.Point(216, 72)
        Me.edtWhiteList.Multiline = True
        Me.edtWhiteList.Name = "edtWhiteList"
        Me.edtWhiteList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.edtWhiteList.Size = New System.Drawing.Size(184, 64)
        Me.edtWhiteList.TabIndex = 8
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(216, 48)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(80, 23)
        Me.label7.TabIndex = 19
        Me.label7.Text = "White IP List"
        '
        'edtBlackList
        '
        Me.edtBlackList.Location = New System.Drawing.Point(8, 72)
        Me.edtBlackList.Multiline = True
        Me.edtBlackList.Name = "edtBlackList"
        Me.edtBlackList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.edtBlackList.Size = New System.Drawing.Size(184, 64)
        Me.edtBlackList.TabIndex = 7
        Me.edtBlackList.Text = "192.168.0.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "212.121.0.1"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(8, 48)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(80, 23)
        Me.label6.TabIndex = 17
        Me.label6.Text = "Black IP List"
        '
        'memLog
        '
        Me.memLog.Location = New System.Drawing.Point(17, 328)
        Me.memLog.Multiline = True
        Me.memLog.Name = "memLog"
        Me.memLog.ReadOnly = True
        Me.memLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memLog.Size = New System.Drawing.Size(416, 88)
        Me.memLog.TabIndex = 23
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(17, 304)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(48, 23)
        Me.label5.TabIndex = 20
        Me.label5.Text = "Log"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(233, 288)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 22
        Me.btnStop.Text = "Stop"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(129, 288)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 21
        Me.btnStart.Text = "Start"
        '
        'edtRootDir
        '
        Me.edtRootDir.Location = New System.Drawing.Point(89, 72)
        Me.edtRootDir.Name = "edtRootDir"
        Me.edtRootDir.Size = New System.Drawing.Size(328, 20)
        Me.edtRootDir.TabIndex = 18
        Me.edtRootDir.Text = "C:\CleverFtpServer\"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(17, 72)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 23)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Root Dir"
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(89, 48)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(96, 20)
        Me.edtPort.TabIndex = 16
        Me.edtPort.Text = "21"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(17, 48)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(32, 23)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Port"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(17, 24)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(408, 23)
        Me.label2.TabIndex = 14
        Me.label2.Text = "Please use the ""CleverTester"" user name and ""clevertester"" password to log-in."
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(17, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(416, 23)
        Me.label1.TabIndex = 13
        Me.label1.Text = "This is a sample FTP server. You can use any FTP client to connect to this server" &
    "."
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(450, 432)
        Me.Controls.Add(Me.groupBox1)
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
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
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
            ServerGuard1.ConnectionLimit.Max = Convert.ToInt32(edtAllowedConnections.Text)
            ServerGuard1.ConnectionLimit.Period = 60000 '1 minute
            ServerGuard1.BlackIPList = edtBlackList.Lines
            ServerGuard1.WhiteIPList = edtWhiteList.Lines
            ServerGuard1.AllowWhiteListOnly = cbWhiteListOnly.Checked

            ServerGuard1.Reset()

            FtpServer1.Port = Convert.ToInt32(edtPort.Text)
            FtpServer1.RootDir = edtRootDir.Text
            Directory.CreateDirectory(FtpServer1.RootDir)

            FtpServer1.Start()

            edtPort.Enabled = False
            edtRootDir.Enabled = False
            groupBox1.Enabled = False
            btnStart.Enabled = False

            Me.Text = "Clever FTP Server - Started"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        FtpServer1.Stop()

        edtPort.Enabled = True
        edtRootDir.Enabled = True
        groupBox1.Enabled = True
        btnStart.Enabled = True

        Me.Text = "Clever FTP Server"
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
End Class
