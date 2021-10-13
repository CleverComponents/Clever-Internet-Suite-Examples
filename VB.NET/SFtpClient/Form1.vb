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
    Friend WithEvents progressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents btnGoUp As Button
    Private WithEvents btnOpenDir As Button
    Private WithEvents label8 As Label
    Private WithEvents label5 As Label
    Private WithEvents edtStartDir As TextBox
    Private WithEvents label3 As Label
    Private WithEvents btnRename As Button
    Private WithEvents btnDeleteFile As Button
    Private WithEvents btnUpload As Button
    Private WithEvents btnDownload As Button
    Private WithEvents btnRemoveDir As Button
    Private WithEvents btnMakeDir As Button
    Private WithEvents memLog As TextBox
    Private WithEvents lbList As ListBox
    Private WithEvents label6 As Label
    Private WithEvents btnLogout As Button
    Private WithEvents btnLogin As Button
    Private WithEvents edtPort As TextBox
    Private WithEvents edtPassword As TextBox
    Private WithEvents edtUser As TextBox
    Private WithEvents edtServer As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Friend WithEvents SFtp1 As CleverComponents.InetSuite.SFtp
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SFtp1 = New CleverComponents.InetSuite.SFtp()
        Me.btnGoUp = New System.Windows.Forms.Button()
        Me.btnOpenDir = New System.Windows.Forms.Button()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.edtStartDir = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.btnDeleteFile = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnRemoveDir = New System.Windows.Forms.Button()
        Me.btnMakeDir = New System.Windows.Forms.Button()
        Me.memLog = New System.Windows.Forms.TextBox()
        Me.lbList = New System.Windows.Forms.ListBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.edtPort = New System.Windows.Forms.TextBox()
        Me.edtPassword = New System.Windows.Forms.TextBox()
        Me.edtUser = New System.Windows.Forms.TextBox()
        Me.edtServer = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.SFtp1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'progressBar1
        '
        Me.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progressBar1.Location = New System.Drawing.Point(0, 373)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(640, 16)
        Me.progressBar1.TabIndex = 55
        '
        'saveFileDialog1
        '
        Me.saveFileDialog1.OverwritePrompt = False
        '
        'SFtp1
        '
        Me.SFtp1.Password = Nothing
        Me.SFtp1.UserKey.PassPhrase = Nothing
        Me.SFtp1.UserKey.PrivateKeyFile = Nothing
        Me.SFtp1.UserName = Nothing
        '
        'btnGoUp
        '
        Me.btnGoUp.Location = New System.Drawing.Point(547, 116)
        Me.btnGoUp.Name = "btnGoUp"
        Me.btnGoUp.Size = New System.Drawing.Size(75, 23)
        Me.btnGoUp.TabIndex = 68
        Me.btnGoUp.Text = "Go Up"
        Me.btnGoUp.UseVisualStyleBackColor = True
        '
        'btnOpenDir
        '
        Me.btnOpenDir.Location = New System.Drawing.Point(547, 87)
        Me.btnOpenDir.Name = "btnOpenDir"
        Me.btnOpenDir.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenDir.TabIndex = 66
        Me.btnOpenDir.Text = "Open Dir"
        Me.btnOpenDir.UseVisualStyleBackColor = True
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(19, 261)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(25, 13)
        Me.label8.TabIndex = 79
        Me.label8.Text = "Log"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(418, 17)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(26, 13)
        Me.label5.TabIndex = 78
        Me.label5.Text = "Port"
        '
        'edtStartDir
        '
        Me.edtStartDir.Location = New System.Drawing.Point(75, 64)
        Me.edtStartDir.Name = "edtStartDir"
        Me.edtStartDir.Size = New System.Drawing.Size(328, 20)
        Me.edtStartDir.TabIndex = 63
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(19, 67)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(45, 13)
        Me.label3.TabIndex = 77
        Me.label3.Text = "Start Dir"
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(547, 334)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(75, 23)
        Me.btnRename.TabIndex = 74
        Me.btnRename.Text = "Rename..."
        '
        'btnDeleteFile
        '
        Me.btnDeleteFile.Location = New System.Drawing.Point(547, 305)
        Me.btnDeleteFile.Name = "btnDeleteFile"
        Me.btnDeleteFile.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteFile.TabIndex = 73
        Me.btnDeleteFile.Text = "Delete File"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(547, 261)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 72
        Me.btnUpload.Text = "Upload..."
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(547, 232)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(75, 23)
        Me.btnDownload.TabIndex = 71
        Me.btnDownload.Text = "Download..."
        '
        'btnRemoveDir
        '
        Me.btnRemoveDir.Location = New System.Drawing.Point(547, 185)
        Me.btnRemoveDir.Name = "btnRemoveDir"
        Me.btnRemoveDir.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveDir.TabIndex = 70
        Me.btnRemoveDir.Text = "Remove Dir"
        '
        'btnMakeDir
        '
        Me.btnMakeDir.Location = New System.Drawing.Point(547, 156)
        Me.btnMakeDir.Name = "btnMakeDir"
        Me.btnMakeDir.Size = New System.Drawing.Size(75, 23)
        Me.btnMakeDir.TabIndex = 69
        Me.btnMakeDir.Text = "Make Dir..."
        '
        'memLog
        '
        Me.memLog.Location = New System.Drawing.Point(19, 277)
        Me.memLog.Multiline = True
        Me.memLog.Name = "memLog"
        Me.memLog.ReadOnly = True
        Me.memLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.memLog.Size = New System.Drawing.Size(504, 80)
        Me.memLog.TabIndex = 76
        '
        'lbList
        '
        Me.lbList.Location = New System.Drawing.Point(19, 107)
        Me.lbList.Name = "lbList"
        Me.lbList.Size = New System.Drawing.Size(504, 147)
        Me.lbList.Sorted = True
        Me.lbList.TabIndex = 75
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(19, 91)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(100, 16)
        Me.label6.TabIndex = 67
        Me.label6.Text = "Remote Host"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(547, 43)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 65
        Me.btnLogout.Text = "Logout"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(547, 14)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 64
        Me.btnLogin.Text = "Login"
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(459, 14)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(64, 20)
        Me.edtPort.TabIndex = 60
        Me.edtPort.Text = "22"
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(291, 38)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtPassword.Size = New System.Drawing.Size(112, 20)
        Me.edtPassword.TabIndex = 62
        Me.edtPassword.Text = "clevertester"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(75, 38)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(112, 20)
        Me.edtUser.TabIndex = 61
        Me.edtUser.Text = "CleverTester"
        '
        'edtServer
        '
        Me.edtServer.Location = New System.Drawing.Point(75, 14)
        Me.edtServer.Name = "edtServer"
        Me.edtServer.Size = New System.Drawing.Size(328, 20)
        Me.edtServer.TabIndex = 59
        Me.edtServer.Text = "localhost"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(227, 38)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 16)
        Me.label4.TabIndex = 58
        Me.label4.Text = "Password"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(19, 38)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(48, 16)
        Me.label2.TabIndex = 57
        Me.label2.Text = "User"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(19, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 16)
        Me.label1.TabIndex = 56
        Me.label1.Text = "IP/Host"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(640, 389)
        Me.Controls.Add(Me.btnGoUp)
        Me.Controls.Add(Me.btnOpenDir)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.edtStartDir)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.btnDeleteFile)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnRemoveDir)
        Me.Controls.Add(Me.btnMakeDir)
        Me.Controls.Add(Me.memLog)
        Me.Controls.Add(Me.lbList)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.edtPort)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.edtUser)
        Me.Controls.Add(Me.edtServer)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.progressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SFTP Client"
        CType(Me.SFtp1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form1_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        UpdateStatus()
    End Sub

    Private Sub DoOpenDir(ByVal ADir As String)
        Dim dir As String = ADir
        If ADir.StartsWith("//") Then
            dir = ADir.Substring(1)
        End If
        SFtp1.ChangeCurrentDir("/")
        SFtp1.ChangeCurrentDir(dir)
        FillDirList()
    End Sub 'DoOpenDir

    Private Sub FillDirList()
        lbList.Items.Clear()
        SFtp1.GetList()
    End Sub 'FillDirList

    Private Sub UpdateStatus()
        Dim Active As Boolean = SFtp1.Active

        If Active Then
            Text = "SFTP Clinet (FTP+SSH) - Connected"
        Else
            Text = "SFTP Clinet (FTP+SSH)"
        End If

        btnOpenDir.Enabled = Active
        btnGoUp.Enabled = Active
        btnMakeDir.Enabled = Active
        btnRemoveDir.Enabled = Active
        btnDeleteFile.Enabled = Active
        btnRename.Enabled = Active
        btnDownload.Enabled = Active
        btnUpload.Enabled = Active
    End Sub 'UpdateStatus

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If SFtp1.Active Then
            MessageBox.Show("You are already connected. Please click Logout to disconnect.")
            Return
        End If

        Try
            SFtp1.Port = Convert.ToInt32(edtPort.Text)
            SFtp1.Server = edtServer.Text
            SFtp1.UserName = edtUser.Text
            SFtp1.Password = edtPassword.Text
            SFtp1.Open()

            If StringUtils.IsEmpty(edtStartDir.Text) Then
                edtStartDir.Text = SFtp1.CurrentDir
            End If
            If Not StringUtils.IsEmpty(edtStartDir.Text) And edtStartDir.Text.StartsWith("/") Then
                DoOpenDir(edtStartDir.Text)
            End If
            UpdateStatus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        SFtp1.Close()
        lbList.Items.Clear()
        UpdateStatus()
    End Sub

    Private Sub btnOpenDir_Click(sender As Object, e As EventArgs) Handles btnOpenDir.Click
        If Not SFtp1.Active Then
            Return
        End If

        If (lbList.SelectedIndex > -1) And
            (lbList.Items(lbList.SelectedIndex).ToString() <> "") And
            (Mid(lbList.Items(lbList.SelectedIndex).ToString(), 1, 1) = "/") Then
            DoOpenDir(SFtp1.CurrentDir + lbList.Items(lbList.SelectedIndex).ToString())
        End If
    End Sub

    Private Sub btnGoUp_Click(sender As Object, e As EventArgs) Handles btnGoUp.Click
        SFtp1.ChangeToParentDir()
        FillDirList()
    End Sub

    Private Sub SFtp1_CommandSent(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.SFtpCommandEventArgs) Handles SFtp1.CommandSent
        If (e.FxpCommand = SFtpCommand.SSH_FXP_READ Or
                e.FxpCommand = SFtpCommand.SSH_FXP_WRITE Or
                e.FxpCommand = SFtpCommand.SSH_FXP_READDIR) Then
            Return
        End If

        memLog.Text += String.Format("C: {0} ({1} bytes)" + ControlChars.Cr + ControlChars.Lf, GetCommandName(e.FxpCommand), e.Buffer.Length)
        memLog.Select(memLog.Text.Length, 0)
        memLog.ScrollToCaret()
    End Sub

    Private Sub SFtp1_ResponseReceived(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.SFtpCommandEventArgs) Handles SFtp1.ResponseReceived
        If (e.FxpCommand = SFtpCommand.SSH_FXP_READ Or
                e.FxpCommand = SFtpCommand.SSH_FXP_WRITE Or
                e.FxpCommand = SFtpCommand.SSH_FXP_READDIR) Then
            Return
        End If

        memLog.Text += String.Format("S: {0} ({1} bytes)" + ControlChars.Cr + ControlChars.Lf, GetCommandName(e.FxpCommand), e.Buffer.Length)
        memLog.Select(memLog.Text.Length, 0)
        memLog.ScrollToCaret()
    End Sub

    Private Sub SFtp1_DirectoryListing(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.SFtpDirectoryListingEventArgs) Handles SFtp1.DirectoryListing
        Dim item As String = ""
        If e.FileAttrs.IsDir Then
            item = "/"
        End If
        item += e.FileName
        lbList.Items.Add(item)
    End Sub

    Private Sub btnMakeDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeDir.Click
        If Not SFtp1.Active Then
            Return
        End If

        Dim dlg As New NewDialog
        Dim s As String = dlg.ShowNewDialog("New Dir Name", "NewName")

        If s <> "" Then
            SFtp1.MakeDir(s)
            FillDirList()
        End If
    End Sub

    Private Sub btnRemoveDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveDir.Click
        If Not SFtp1.Active Then
            Return
        End If

        If lbList.SelectedIndex > -1 And lbList.Items(lbList.SelectedIndex).ToString() <> "" And
            Mid(lbList.Items(lbList.SelectedIndex).ToString(), 1, 1) = "/" Then

            If MessageBox.Show("Do you wish to delete the " + lbList.Items(lbList.SelectedIndex).ToString() + " directory ?", "Remove Directory", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                SFtp1.RemoveDir((SFtp1.CurrentDir + lbList.Items(lbList.SelectedIndex).ToString()))
                FillDirList()
            End If
        End If
    End Sub

    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click
        If lbList.SelectedIndex > -1 And
            Mid(lbList.Items(lbList.SelectedIndex).ToString(), 1, 1) <> "/" Then

            saveFileDialog1.FileName = lbList.Items(lbList.SelectedIndex).ToString()
            If saveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim size As Integer = SFtp1.GetFileSize(lbList.Items(lbList.SelectedIndex).ToString())
                Dim position As Integer = 0

                If File.Exists(saveFileDialog1.FileName) Then
                    Dim dlg As New FileExistsDialog
                    Dim fileExistsResult As DialogResult = dlg.ShowFileDialog(saveFileDialog1.FileName)
                    If fileExistsResult = Windows.Forms.DialogResult.Cancel Then
                        Return
                    End If
                    Dim fileInf As New FileInfo(saveFileDialog1.FileName)
                    If fileExistsResult = Windows.Forms.DialogResult.No And size > fileInf.Length Then
                        position = CInt(fileInf.Length)
                    End If
                End If

                progressBar1.Minimum = 0
                progressBar1.Maximum = size
                progressBar1.Value = position

                Using dest As New FileStream(saveFileDialog1.FileName, FileMode.Create)
                    SFtp1.GetFile(lbList.Items(lbList.SelectedIndex).ToString(), dest, position, size)
                End Using
                MessageBox.Show("Done")
            End If
        End If
    End Sub

    Private Sub SFtp1_Progress(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.ProgressEventArgs) Handles SFtp1.Progress
        If e.TotalBytes > 0 Then
            progressBar1.Maximum = e.TotalBytes
            progressBar1.Value = e.BytesProceed
        End If
    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        If Not SFtp1.Active Then
            Return
        End If
        If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim position As Integer = 0
            Dim fileName As String = Path.GetFileName(openFileDialog1.FileName)

            Dim fileInf As New FileInfo(openFileDialog1.FileName)

            If SFtp1.FileExists(fileName) Then
                Dim dlg As New FileExistsDialog
                Dim fileExistsResult As DialogResult = dlg.ShowFileDialog(fileName)

                If fileExistsResult = Windows.Forms.DialogResult.Cancel Then
                    Return
                End If
                If fileExistsResult = Windows.Forms.DialogResult.No Then
                    position = SFtp1.GetFileSize(fileName)

                    If CInt(fileInf.Length) <= position Then
                        position = 0
                    End If
                End If
            End If

            progressBar1.Minimum = 0
            progressBar1.Maximum = CInt(fileInf.Length)
            progressBar1.Value = position

            Using source As New FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read)
                SFtp1.PutFile(source, fileName, position, -1)
            End Using

            FillDirList()

            MessageBox.Show("Done")
        End If
    End Sub

    Private Sub btnRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRename.Click
        If Not SFtp1.Active Then
            Return
        End If
        If lbList.SelectedIndex > -1 And
            lbList.Items(lbList.SelectedIndex).ToString() <> "" And
            Mid(lbList.Items(lbList.SelectedIndex).ToString(), 1, 1) <> "/" Then

            Dim dlg As New NewDialog
            Dim s As String = dlg.ShowNewDialog("New File Name", lbList.Items(lbList.SelectedIndex).ToString())

            If s <> "" And s <> lbList.Items(lbList.SelectedIndex).ToString() Then
                SFtp1.Rename(lbList.Items(lbList.SelectedIndex).ToString(), s)
                FillDirList()
            End If
        End If
    End Sub

    Private Sub btnDeleteFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteFile.Click
        If Not SFtp1.Active Then
            Return
        End If
        If lbList.SelectedIndex > -1 And
            lbList.Items(lbList.SelectedIndex).ToString() <> "" And
            Mid(lbList.Items(lbList.SelectedIndex).ToString(), 1, 1) <> "/" Then

            If MessageBox.Show("Do you wish to delete the " + lbList.Items(lbList.SelectedIndex).ToString() + " file ?", "Delete file", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                SFtp1.Delete(lbList.Items(lbList.SelectedIndex).ToString())
                FillDirList()
            End If
        End If
    End Sub

    Private Sub SFtp1_ShowBanner(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.Ssh.ShowBannerEventArgs) Handles SFtp1.ShowBanner
        memLog.Text += "Server Banner: " + e.Message + ControlChars.Cr + ControlChars.Lf
    End Sub

    Private Sub SFtp1_VerifyServer(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.Ssh.VerifySshServerEventArgs) Handles SFtp1.VerifyServer
        e.Verified = MessageBox.Show("You are trying to connect to " + e.Host + " host" + ControlChars.Cr + ControlChars.Lf +
                                "Key Type: " + e.KeyType + ControlChars.Cr + ControlChars.Lf +
                                "Finger Print: " + e.FingerPrint + ControlChars.Cr + ControlChars.Lf + ControlChars.Cr + ControlChars.Lf +
                                "Do you wish to proceed ?", "Verify server", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub lbList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbList.DoubleClick
        If Not SFtp1.Active Then
            Return
        End If

        If (lbList.SelectedIndex > -1) And
            (lbList.Items(lbList.SelectedIndex).ToString() <> "") And
            (Mid(lbList.Items(lbList.SelectedIndex).ToString(), 1, 1) = "/") Then
            DoOpenDir(SFtp1.CurrentDir + lbList.Items(lbList.SelectedIndex).ToString())
        End If
    End Sub

    Private Function GetCommandName(Fxp As Integer) As String
        Select Case Fxp
            Case SFtpCommand.SSH_FXP_INIT
                Return "SSH_FXP_INIT"
            Case SFtpCommand.SSH_FXP_VERSION
                Return "SSH_FXP_VERSION"
            Case SFtpCommand.SSH_FXP_OPEN
                Return "SSH_FXP_OPEN"
            Case SFtpCommand.SSH_FXP_CLOSE
                Return "SSH_FXP_CLOSE"
            Case SFtpCommand.SSH_FXP_READ
                Return "SSH_FXP_READ"
            Case SFtpCommand.SSH_FXP_WRITE
                Return "SSH_FXP_WRITE"
            Case SFtpCommand.SSH_FXP_LSTAT
                Return "SSH_FXP_LSTAT"
            Case SFtpCommand.SSH_FXP_FSTAT
                Return "SSH_FXP_FSTAT"
            Case SFtpCommand.SSH_FXP_SETSTAT
                Return "SSH_FXP_SETSTAT"
            Case SFtpCommand.SSH_FXP_FSETSTAT
                Return "SSH_FXP_FSETSTAT"
            Case SFtpCommand.SSH_FXP_OPENDIR
                Return "SSH_FXP_OPENDIR"
            Case SFtpCommand.SSH_FXP_READDIR
                Return "SSH_FXP_READDIR"
            Case SFtpCommand.SSH_FXP_REMOVE
                Return "SSH_FXP_REMOVE"
            Case SFtpCommand.SSH_FXP_MKDIR
                Return "SSH_FXP_MKDIR"
            Case SFtpCommand.SSH_FXP_RMDIR
                Return "SSH_FXP_RMDIR"
            Case SFtpCommand.SSH_FXP_REALPATH
                Return "SSH_FXP_REALPATH"
            Case SFtpCommand.SSH_FXP_STAT
                Return "SSH_FXP_STAT"
            Case SFtpCommand.SSH_FXP_RENAME
                Return "SSH_FXP_RENAME"
            Case SFtpCommand.SSH_FXP_READLINK
                Return "SSH_FXP_READLINK"
            Case SFtpCommand.SSH_FXP_SYMLINK
                Return "SSH_FXP_SYMLINK"
            Case SFtpCommand.SSH_FXP_STATUS
                Return "SSH_FXP_STATUS"
            Case SFtpCommand.SSH_FXP_HANDLE
                Return "SSH_FXP_HANDLE"
            Case SFtpCommand.SSH_FXP_DATA
                Return "SSH_FXP_DATA"
            Case SFtpCommand.SSH_FXP_NAME
                Return "SSH_FXP_NAME"
            Case SFtpCommand.SSH_FXP_ATTRS
                Return "SSH_FXP_ATTRS"
            Case SFtpCommand.SSH_FXP_EXTENDED
                Return "SSH_FXP_EXTENDED"
            Case SFtpCommand.SSH_FXP_EXTENDED_REPLY
                Return "SSH_FXP_EXTENDED_REPLY"
        End Select

        Return "UNKNOWN"
    End Function
End Class
