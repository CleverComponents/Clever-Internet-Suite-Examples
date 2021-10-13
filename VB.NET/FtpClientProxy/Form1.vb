Imports System.IO
Imports CleverComponents.InetSuite

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        cbProxyType.SelectedIndex = 4
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
    Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cbProxyType As System.Windows.Forms.ComboBox
    Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents edtProxyPassword As System.Windows.Forms.TextBox
    Friend WithEvents label11 As System.Windows.Forms.Label
    Friend WithEvents edtProxyUser As System.Windows.Forms.TextBox
    Friend WithEvents edtProxyPort As System.Windows.Forms.TextBox
    Friend WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents edtProxyServer As System.Windows.Forms.TextBox
    Friend WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents progressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnAbort As System.Windows.Forms.Button
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents btnGoUp As System.Windows.Forms.Button
    Friend WithEvents btnOpenDir As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lbList As System.Windows.Forms.ListBox
    Friend WithEvents cbAsciiMode As System.Windows.Forms.CheckBox
    Friend WithEvents cbPassiveMode As System.Windows.Forms.CheckBox
    Friend WithEvents edtPort As System.Windows.Forms.TextBox
    Friend WithEvents edtStartDir As System.Windows.Forms.TextBox
    Friend WithEvents edtPassword As System.Windows.Forms.TextBox
    Friend WithEvents edtUser As System.Windows.Forms.TextBox
    Friend WithEvents edtServer As System.Windows.Forms.TextBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Ftp1 As CleverComponents.InetSuite.Ftp
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cbProxyType = New System.Windows.Forms.ComboBox()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.edtProxyPassword = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.edtProxyUser = New System.Windows.Forms.TextBox()
        Me.edtProxyPort = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.edtProxyServer = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnAbort = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnGoUp = New System.Windows.Forms.Button()
        Me.btnOpenDir = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lbList = New System.Windows.Forms.ListBox()
        Me.cbAsciiMode = New System.Windows.Forms.CheckBox()
        Me.cbPassiveMode = New System.Windows.Forms.CheckBox()
        Me.edtPort = New System.Windows.Forms.TextBox()
        Me.edtStartDir = New System.Windows.Forms.TextBox()
        Me.edtPassword = New System.Windows.Forms.TextBox()
        Me.edtUser = New System.Windows.Forms.TextBox()
        Me.edtServer = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Ftp1 = New CleverComponents.InetSuite.Ftp()
        CType(Me.Ftp1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbProxyType
        '
        Me.cbProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProxyType.Items.AddRange(New Object() {"None", "UserSite", "Site", "Open", "UserPass", "Transparent"})
        Me.cbProxyType.Location = New System.Drawing.Point(96, 152)
        Me.cbProxyType.Name = "cbProxyType"
        Me.cbProxyType.Size = New System.Drawing.Size(240, 21)
        Me.cbProxyType.TabIndex = 72
        '
        'saveFileDialog1
        '
        Me.saveFileDialog1.OverwritePrompt = False
        '
        'edtProxyPassword
        '
        Me.edtProxyPassword.Location = New System.Drawing.Point(392, 128)
        Me.edtProxyPassword.Name = "edtProxyPassword"
        Me.edtProxyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtProxyPassword.Size = New System.Drawing.Size(128, 20)
        Me.edtProxyPassword.TabIndex = 71
        Me.edtProxyPassword.Text = "clevertester"
        '
        'label11
        '
        Me.label11.Location = New System.Drawing.Point(304, 128)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(88, 16)
        Me.label11.TabIndex = 70
        Me.label11.Text = "Proxy Password"
        '
        'edtProxyUser
        '
        Me.edtProxyUser.Location = New System.Drawing.Point(96, 128)
        Me.edtProxyUser.Name = "edtProxyUser"
        Me.edtProxyUser.Size = New System.Drawing.Size(184, 20)
        Me.edtProxyUser.TabIndex = 69
        Me.edtProxyUser.Text = "clevertester"
        '
        'edtProxyPort
        '
        Me.edtProxyPort.Location = New System.Drawing.Point(432, 104)
        Me.edtProxyPort.Name = "edtProxyPort"
        Me.edtProxyPort.Size = New System.Drawing.Size(88, 20)
        Me.edtProxyPort.TabIndex = 68
        Me.edtProxyPort.Text = "21"
        '
        'label10
        '
        Me.label10.Location = New System.Drawing.Point(360, 104)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(72, 16)
        Me.label10.TabIndex = 67
        Me.label10.Text = "Proxy Port"
        '
        'edtProxyServer
        '
        Me.edtProxyServer.Location = New System.Drawing.Point(96, 104)
        Me.edtProxyServer.Name = "edtProxyServer"
        Me.edtProxyServer.Size = New System.Drawing.Size(240, 20)
        Me.edtProxyServer.TabIndex = 66
        Me.edtProxyServer.Text = "localhost"
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(16, 152)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(72, 16)
        Me.label9.TabIndex = 65
        Me.label9.Text = "Proxy Type"
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(16, 128)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(72, 16)
        Me.label8.TabIndex = 64
        Me.label8.Text = "Proxy User"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(16, 104)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(72, 16)
        Me.label7.TabIndex = 63
        Me.label7.Text = "Proxy Server"
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Location = New System.Drawing.Point(16, 96)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(512, 1)
        Me.panel1.TabIndex = 62
        '
        'progressBar1
        '
        Me.progressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressBar1.Location = New System.Drawing.Point(0, 420)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(640, 16)
        Me.progressBar1.TabIndex = 61
        '
        'btnAbort
        '
        Me.btnAbort.Location = New System.Drawing.Point(544, 384)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(75, 23)
        Me.btnAbort.TabIndex = 60
        Me.btnAbort.Text = "Abort"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(544, 264)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 59
        Me.btnUpload.Text = "Upload..."
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(544, 232)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(75, 23)
        Me.btnDownload.TabIndex = 58
        Me.btnDownload.Text = "Download..."
        '
        'btnGoUp
        '
        Me.btnGoUp.Location = New System.Drawing.Point(544, 176)
        Me.btnGoUp.Name = "btnGoUp"
        Me.btnGoUp.Size = New System.Drawing.Size(75, 23)
        Me.btnGoUp.TabIndex = 57
        Me.btnGoUp.Text = "Go Up"
        '
        'btnOpenDir
        '
        Me.btnOpenDir.Location = New System.Drawing.Point(544, 144)
        Me.btnOpenDir.Name = "btnOpenDir"
        Me.btnOpenDir.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenDir.TabIndex = 56
        Me.btnOpenDir.Text = "Open Dir"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(544, 48)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 55
        Me.btnLogout.Text = "Logout"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(544, 16)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 54
        Me.btnLogin.Text = "Login"
        '
        'lbList
        '
        Me.lbList.Location = New System.Drawing.Point(16, 200)
        Me.lbList.Name = "lbList"
        Me.lbList.Size = New System.Drawing.Size(504, 212)
        Me.lbList.Sorted = True
        Me.lbList.TabIndex = 53
        '
        'cbAsciiMode
        '
        Me.cbAsciiMode.Location = New System.Drawing.Point(416, 64)
        Me.cbAsciiMode.Name = "cbAsciiMode"
        Me.cbAsciiMode.Size = New System.Drawing.Size(104, 24)
        Me.cbAsciiMode.TabIndex = 52
        Me.cbAsciiMode.Text = "Ascii Mode"
        '
        'cbPassiveMode
        '
        Me.cbPassiveMode.Location = New System.Drawing.Point(416, 40)
        Me.cbPassiveMode.Name = "cbPassiveMode"
        Me.cbPassiveMode.Size = New System.Drawing.Size(104, 24)
        Me.cbPassiveMode.TabIndex = 51
        Me.cbPassiveMode.Text = "Passive Mode"
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(456, 16)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(64, 20)
        Me.edtPort.TabIndex = 50
        Me.edtPort.Text = "21"
        '
        'edtStartDir
        '
        Me.edtStartDir.Location = New System.Drawing.Point(72, 64)
        Me.edtStartDir.Name = "edtStartDir"
        Me.edtStartDir.Size = New System.Drawing.Size(328, 20)
        Me.edtStartDir.TabIndex = 49
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(288, 40)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtPassword.Size = New System.Drawing.Size(112, 20)
        Me.edtPassword.TabIndex = 48
        Me.edtPassword.Text = "clevertester"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(72, 40)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(112, 20)
        Me.edtUser.TabIndex = 47
        Me.edtUser.Text = "clevertester"
        '
        'edtServer
        '
        Me.edtServer.Location = New System.Drawing.Point(72, 16)
        Me.edtServer.Name = "edtServer"
        Me.edtServer.Size = New System.Drawing.Size(328, 20)
        Me.edtServer.TabIndex = 46
        Me.edtServer.Text = "localhost"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(16, 184)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(100, 16)
        Me.label6.TabIndex = 45
        Me.label6.Text = "Remote Host"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(416, 16)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(40, 16)
        Me.label5.TabIndex = 44
        Me.label5.Text = "Port"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(224, 40)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 16)
        Me.label4.TabIndex = 43
        Me.label4.Text = "Password"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 64)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(48, 16)
        Me.label3.TabIndex = 42
        Me.label3.Text = "Start Dir"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(48, 16)
        Me.label2.TabIndex = 41
        Me.label2.Text = "User"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 16)
        Me.label1.TabIndex = 40
        Me.label1.Text = "IP/Host"
        '
        'Ftp1
        '
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(640, 438)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.edtProxyUser)
        Me.Controls.Add(Me.edtProxyPort)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.edtProxyServer)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.btnAbort)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnGoUp)
        Me.Controls.Add(Me.btnOpenDir)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lbList)
        Me.Controls.Add(Me.cbAsciiMode)
        Me.Controls.Add(Me.cbPassiveMode)
        Me.Controls.Add(Me.edtPort)
        Me.Controls.Add(Me.edtStartDir)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.edtUser)
        Me.Controls.Add(Me.edtServer)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cbProxyType)
        Me.Controls.Add(Me.edtProxyPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FTP Client Proxy"
        CType(Me.Ftp1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If Ftp1.Active Then
            MessageBox.Show("You are already connected. Please click Logout to disconnect.")
            Return
        End If

        Try
            Ftp1.Port = Convert.ToInt32(edtPort.Text)
            Ftp1.Server = edtServer.Text
            Ftp1.UserName = edtUser.Text
            Ftp1.Password = edtPassword.Text
            Ftp1.PassiveMode = cbPassiveMode.Checked

            If cbAsciiMode.Checked Then
                Ftp1.TransferType = FtpTransferType.Ascii
            Else
                Ftp1.TransferType = FtpTransferType.Binary
            End If

            Ftp1.ProxySettings.Server = edtProxyServer.Text
            Ftp1.ProxySettings.Port = Convert.ToInt32(edtProxyPort.Text)
            Ftp1.ProxySettings.UserName = edtProxyUser.Text
            Ftp1.ProxySettings.Password = edtProxyPassword.Text
            Ftp1.ProxySettings.ProxyType = CType(cbProxyType.SelectedIndex, FtpProxyType)

            Ftp1.Open()

            If StringUtils.IsEmpty(edtStartDir.Text) Then
                edtStartDir.Text = Ftp1.CurrentDir
            End If
            If Not StringUtils.IsEmpty(edtStartDir.Text) And edtStartDir.Text.StartsWith("/") Then
                DoOpenDir(edtStartDir.Text)
            End If
            UpdateStatus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DoOpenDir(ByVal ADir As String)
        Dim dir As String = ADir
        If ADir.StartsWith("//") Then
            dir = ADir.Substring(1)
        End If
        Ftp1.ChangeCurrentDir("/")
        Ftp1.ChangeCurrentDir(dir)
        FillDirList()
    End Sub 'DoOpenDir

    Private Sub FillDirList()
        lbList.Items.Clear()
        Ftp1.GetDirectoryListing("")
        edtStartDir.Text = Ftp1.CurrentDir
    End Sub 'FillDirList

    Private Sub UpdateStatus()
        If Ftp1.Active Then
            Text = "Ftp Clinet - Connected"
        Else
            Text = "Ftp Clinet"
        End If
    End Sub 'UpdateStatus

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Ftp1.Close()
        lbList.Items.Clear()
        UpdateStatus()
    End Sub

    Private Sub btnOpenDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenDir.Click
        If Not Ftp1.Active Then
            Return
        End If
        If lbList.SelectedIndex > -1 And lbList.Items(lbList.SelectedIndex).ToString() <> "" And Mid(lbList.Items(lbList.SelectedIndex).ToString(), 1, 1) = "/" Then
            DoOpenDir(Ftp1.CurrentDir + lbList.Items(lbList.SelectedIndex).ToString())
        End If
    End Sub

    Private Sub btnGoUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoUp.Click
        If Not Ftp1.Active Then
            Return
        End If
        Ftp1.ChangeToParentDir()
        FillDirList()
    End Sub

    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click
        If lbList.SelectedIndex > -1 And lbList.Items(lbList.SelectedIndex).ToString() <> "" And Mid(lbList.Items(lbList.SelectedIndex).ToString(), 1, 1) <> "/" Then

            saveFileDialog1.FileName = lbList.Items(lbList.SelectedIndex).ToString()
            If saveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                progressBar1.Minimum = 0
                progressBar1.Maximum = Ftp1.GetFileSize(lbList.Items(lbList.SelectedIndex).ToString())
                progressBar1.Value = 0

                Dim dest As New FileStream(saveFileDialog1.FileName, FileMode.Create)
                Ftp1.GetFile(lbList.Items(lbList.SelectedIndex).ToString(), dest)
                dest.Close()
                MessageBox.Show("Done")
            End If
        End If
    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        If Not Ftp1.Active Then
            Return
        End If
        If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            progressBar1.Minimum = 0
            Dim fileInf As New FileInfo(openFileDialog1.FileName)
            progressBar1.Maximum = CInt(fileInf.Length)
            progressBar1.Value = 0

            Dim source As New FileStream(openFileDialog1.FileName, FileMode.Open)
            Ftp1.PutFile(source, Path.GetFileName(openFileDialog1.FileName))
            source.Close()
            MessageBox.Show("Done")

            FillDirList()
        End If
    End Sub

    Private Sub btnAbort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbort.Click
        If Ftp1.Active Then
            Ftp1.Abort()
        End If
    End Sub

    Private Sub lbList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbList.DoubleClick
        btnOpenDir_Click(Nothing, Nothing)
    End Sub

    Private Sub Ftp1_DirectoryListing(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.DirectoryListingEventArgs) Handles Ftp1.DirectoryListing
        Dim str As String = e.FileInfo.FileName

        If e.FileInfo.IsDirectory Or e.FileInfo.IsLink Then
            str = "/" + str
        End If

        lbList.Items.Add(str)
    End Sub

    Private Sub Ftp1_Progress(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.ProgressEventArgs) Handles Ftp1.Progress
        If e.TotalBytes > 0 Then
            progressBar1.Maximum = e.TotalBytes
            progressBar1.Value = e.BytesProceed
        End If
    End Sub
End Class
