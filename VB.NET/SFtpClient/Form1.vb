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
    Friend WithEvents btnRename As System.Windows.Forms.Button
    Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnDeleteFile As System.Windows.Forms.Button
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents btnRemoveDir As System.Windows.Forms.Button
    Friend WithEvents btnMakeDir As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents memLog As System.Windows.Forms.TextBox
    Friend WithEvents lbList As System.Windows.Forms.ListBox
    Friend WithEvents edtPort As System.Windows.Forms.TextBox
    Friend WithEvents edtPassword As System.Windows.Forms.TextBox
    Friend WithEvents edtUser As System.Windows.Forms.TextBox
    Friend WithEvents edtServer As System.Windows.Forms.TextBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents SFtp1 As CleverComponents.InetSuite.SFtp
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnDeleteFile = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnRemoveDir = New System.Windows.Forms.Button()
        Me.btnMakeDir = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.memLog = New System.Windows.Forms.TextBox()
        Me.lbList = New System.Windows.Forms.ListBox()
        Me.edtPort = New System.Windows.Forms.TextBox()
        Me.edtPassword = New System.Windows.Forms.TextBox()
        Me.edtUser = New System.Windows.Forms.TextBox()
        Me.edtServer = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SFtp1 = New CleverComponents.InetSuite.SFtp()
        Me.SuspendLayout()
        '
        'progressBar1
        '
        Me.progressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressBar1.Location = New System.Drawing.Point(0, 396)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(640, 16)
        Me.progressBar1.TabIndex = 55
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(544, 258)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(75, 23)
        Me.btnRename.TabIndex = 53
        Me.btnRename.Text = "Rename..."
        '
        'saveFileDialog1
        '
        Me.saveFileDialog1.OverwritePrompt = False
        '
        'btnDeleteFile
        '
        Me.btnDeleteFile.Location = New System.Drawing.Point(544, 229)
        Me.btnDeleteFile.Name = "btnDeleteFile"
        Me.btnDeleteFile.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteFile.TabIndex = 52
        Me.btnDeleteFile.Text = "Delete File"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(544, 200)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 51
        Me.btnUpload.Text = "Upload..."
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(544, 171)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(75, 23)
        Me.btnDownload.TabIndex = 50
        Me.btnDownload.Text = "Download..."
        '
        'btnRemoveDir
        '
        Me.btnRemoveDir.Location = New System.Drawing.Point(544, 111)
        Me.btnRemoveDir.Name = "btnRemoveDir"
        Me.btnRemoveDir.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveDir.TabIndex = 49
        Me.btnRemoveDir.Text = "Remove Dir"
        '
        'btnMakeDir
        '
        Me.btnMakeDir.Location = New System.Drawing.Point(544, 82)
        Me.btnMakeDir.Name = "btnMakeDir"
        Me.btnMakeDir.Size = New System.Drawing.Size(75, 23)
        Me.btnMakeDir.TabIndex = 48
        Me.btnMakeDir.Text = "Make Dir..."
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(544, 48)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 45
        Me.btnLogout.Text = "Logout"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(544, 16)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 44
        Me.btnLogin.Text = "Login"
        '
        'memLog
        '
        Me.memLog.Location = New System.Drawing.Point(19, 312)
        Me.memLog.Multiline = True
        Me.memLog.Name = "memLog"
        Me.memLog.ReadOnly = True
        Me.memLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.memLog.Size = New System.Drawing.Size(504, 80)
        Me.memLog.TabIndex = 43
        '
        'lbList
        '
        Me.lbList.Location = New System.Drawing.Point(19, 82)
        Me.lbList.Name = "lbList"
        Me.lbList.Size = New System.Drawing.Size(504, 199)
        Me.lbList.Sorted = True
        Me.lbList.TabIndex = 42
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(456, 16)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(64, 20)
        Me.edtPort.TabIndex = 39
        Me.edtPort.Text = "21"
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(288, 40)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtPassword.Size = New System.Drawing.Size(112, 20)
        Me.edtPassword.TabIndex = 37
        Me.edtPassword.Text = "clevertester"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(72, 40)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(112, 20)
        Me.edtUser.TabIndex = 36
        Me.edtUser.Text = "clevertester"
        '
        'edtServer
        '
        Me.edtServer.Location = New System.Drawing.Point(72, 16)
        Me.edtServer.Name = "edtServer"
        Me.edtServer.Size = New System.Drawing.Size(328, 20)
        Me.edtServer.TabIndex = 35
        Me.edtServer.Text = "localhost"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(16, 293)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(32, 16)
        Me.label7.TabIndex = 34
        Me.label7.Text = "Log"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(16, 63)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(100, 16)
        Me.label6.TabIndex = 33
        Me.label6.Text = "Remote Host"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(416, 16)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(40, 16)
        Me.label5.TabIndex = 32
        Me.label5.Text = "Port"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(224, 40)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 16)
        Me.label4.TabIndex = 31
        Me.label4.Text = "Password"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(48, 16)
        Me.label2.TabIndex = 29
        Me.label2.Text = "User"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 16)
        Me.label1.TabIndex = 28
        Me.label1.Text = "IP/Host"
        '
        'SFtp1
        '
        Me.SFtp1.Password = Nothing
        Me.SFtp1.UserKey.PassPhrase = Nothing
        Me.SFtp1.UserKey.PrivateKeyFile = Nothing
        Me.SFtp1.UserName = Nothing
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(640, 414)
        Me.Controls.Add(Me.btnDeleteFile)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnRemoveDir)
        Me.Controls.Add(Me.btnMakeDir)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.memLog)
        Me.Controls.Add(Me.lbList)
        Me.Controls.Add(Me.edtPort)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.edtUser)
        Me.Controls.Add(Me.edtServer)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.btnRename)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub DoGoUp()
        SFtp1.ChangeToParentDir()
        FillDirList()
    End Sub

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

            DoOpenDir("")
            UpdateStatus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DoOpenDir(ByVal ADir As String)
        Dim dir As String = ADir.TrimStart("/")
        If Not StringUtils.IsEmpty(dir) Then
            SFtp1.ChangeCurrentDir(dir)
        End If
        FillDirList()
    End Sub 'DoOpenDir

    Private Sub FillDirList()
        lbList.Items.Clear()
        lbList.Items.Add("..")
        SFtp1.GetList("")
    End Sub 'FillDirList

    Private Sub UpdateStatus()
        If SFtp1.Active Then
            Text = "SFTP Clinet (FTP+SSH) - Connected"
        Else
            Text = "SFTP Clinet (FTP+SSH)"
        End If
    End Sub 'UpdateStatus

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        SFtp1.Close()
        lbList.Items.Clear()
        UpdateStatus()
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

        If lbList.SelectedIndex > -1 And lbList.Items(lbList.SelectedIndex).ToString() <> "" And Mid(lbList.Items(lbList.SelectedIndex).ToString(), 1, 1) = "/" Then

            If MessageBox.Show("Do you wish to delete the " + lbList.Items(lbList.SelectedIndex).ToString() + " directory ?", "Remove Directory", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                SFtp1.RemoveDir((SFtp1.CurrentDir + lbList.Items(lbList.SelectedIndex).ToString()))
                FillDirList()
            End If
        End If
    End Sub

    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click
        If lbList.SelectedIndex > -1 And lbList.Items(lbList.SelectedIndex).ToString() <> "" And Mid(lbList.Items(lbList.SelectedIndex).ToString(), 1, 1) <> "/" And lbList.Items(lbList.SelectedIndex).ToString() <> ".." Then

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

                Dim dest As New FileStream(saveFileDialog1.FileName, FileMode.Create)
                SFtp1.GetFile(lbList.Items(lbList.SelectedIndex).ToString(), dest, position, size)
                dest.Close()
                MessageBox.Show("Done")
            End If
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

            Dim source As New FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read)
            SFtp1.PutFile(source, fileName, position, -1)
            source.Close()

            MessageBox.Show("Done")

            FillDirList()
        End If
    End Sub

    Private Sub btnDeleteFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteFile.Click
        If Not SFtp1.Active Then
            Return
        End If
        If lbList.SelectedIndex > -1 And lbList.Items(lbList.SelectedIndex).ToString() <> "" And Mid(lbList.Items(lbList.SelectedIndex).ToString(), 1, 1) <> "/" And lbList.Items(lbList.SelectedIndex).ToString() <> ".." Then

            If MessageBox.Show("Do you wish to delete the " + lbList.Items(lbList.SelectedIndex).ToString() + " file ?", "Delete file", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                SFtp1.Delete(lbList.Items(lbList.SelectedIndex).ToString())
                FillDirList()
            End If
        End If
    End Sub

    Private Sub btnRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRename.Click
        If Not SFtp1.Active Then
            Return
        End If
        If lbList.SelectedIndex > -1 And lbList.Items(lbList.SelectedIndex).ToString() <> "" And Mid(lbList.Items(lbList.SelectedIndex).ToString(), 1, 1) <> "/" Then

            Dim dlg As New NewDialog
            Dim s As String = dlg.ShowNewDialog("New File Name", lbList.Items(lbList.SelectedIndex).ToString())

            If s <> "" And s <> lbList.Items(lbList.SelectedIndex).ToString() Then
                SFtp1.Rename(lbList.Items(lbList.SelectedIndex).ToString(), s)
                FillDirList()
            End If
        End If
    End Sub

    Private Sub lbList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbList.DoubleClick
        If Not SFtp1.Active Then
            Return
        End If

        If (lbList.SelectedIndex > -1) And (lbList.Items(lbList.SelectedIndex).ToString() <> "") Then

            If (Mid(lbList.Items(lbList.SelectedIndex).ToString(), 1, 1) = "/") Then
                DoOpenDir(lbList.Items(lbList.SelectedIndex).ToString())
            ElseIf (lbList.Items(lbList.SelectedIndex).ToString() = "..") Then
                DoGoUp()
            End If
        End If
    End Sub

    Private Sub Ftp1_DirectoryListing(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.DirectoryListingEventArgs)
        Dim str As String = e.FileInfo.FileName

        If e.FileInfo.IsDirectory Or e.FileInfo.IsLink Then
            str = "/" + str
        End If

        lbList.Items.Add(str)
    End Sub

    Private Sub SFtp1_CommandSent(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.SFtpCommandEventArgs) Handles SFtp1.CommandSent
        memLog.Text += e.FxpCommand.ToString() + " is sent" + ControlChars.Cr + ControlChars.Lf
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

    Private Sub SFtp1_Progress(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.ProgressEventArgs) Handles SFtp1.Progress
        If e.TotalBytes > 0 Then
            progressBar1.Maximum = e.TotalBytes
            progressBar1.Value = e.BytesProceed
        End If
    End Sub

    Private Sub SFtp1_ShowBanner(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.Ssh.ShowBannerEventArgs) Handles SFtp1.ShowBanner
        memLog.Text += "S: " + e.Message
    End Sub

    Private Sub SFtp1_VerifyServer(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.Ssh.VerifySshPeerEventArgs) Handles SFtp1.VerifyServer
        If (Not e.Verified) Then
            If (MessageBox.Show("You are trying to connect to " + e.Host + " host" + ControlChars.Cr + ControlChars.Lf + _
                                "Key Type: " + e.KeyType + ControlChars.Cr + ControlChars.Lf + _
                                "Finger Print: " + e.FingerPrint + ControlChars.Cr + ControlChars.Lf + ControlChars.Cr + ControlChars.Lf + _
                                "Do you wish to proceed ?", "Verify server", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                e.Verified = True
            End If
        End If
    End Sub

    Private Sub SFtp1_ResponseReceived(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.SFtpCommandEventArgs) Handles SFtp1.ResponseReceived
        memLog.Text += e.FxpCommand.ToString() + " is received" + ControlChars.Cr + ControlChars.Lf
        memLog.Select(memLog.Text.Length, 0)
        memLog.ScrollToCaret()
    End Sub

    Private Sub Form1_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        UpdateStatus()
    End Sub
End Class
