Imports System.IO
Imports CleverComponents.InetSuite

Public Class MainForm
    Private IsStop As Boolean

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If (SFtpServer1.Active) Then Return

        LoadHostKey()

        If (Not SFtpServer1.HostKey.HasKey) Then
            GenerateHostKey()
        End If

        AssignSettings()

        ServerGuard1.Reset()
        SFtpServer1.Start()
        lblStatus.Visible = True
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        IsStop = True
        Try
            SFtpServer1.Stop()
            lblStatus.Visible = False

        Finally
            IsStop = False
        End Try
    End Sub

    Private Sub btnLoadHostKey_Click(sender As Object, e As EventArgs) Handles btnLoadHostKey.Click
        If (SFtpServer1.Active) Then Return

        If (OpenFileDialog1.ShowDialog() <> DialogResult.OK) Then Return

        edtHostKeyFile.Text = OpenFileDialog1.FileName

        LoadHostKey()
    End Sub

    Private Sub btnGenerateHostKey_Click(sender As Object, e As EventArgs) Handles btnGenerateHostKey.Click
        GenerateHostKey()
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        tabControl1.SelectedTab = tabServer
        lblStatus.Visible = False

        LoadHostKey()
        LoadDefaultSettings()
    End Sub

    Private Sub LoadHostKey()
        If (SFtpServer1.Active) Then
            Return
        End If

        SFtpServer1.HostKey.Clear()

        SFtpServer1.HostKey.PrivateKeyFile = edtHostKeyFile.Text
        SFtpServer1.HostKey.PassPhrase = edtHostKeyPassPhrase.Text

        If (Not StringUtils.IsEmpty(edtHostKeyFile.Text) And File.Exists(edtHostKeyFile.Text)) Then
            SFtpServer1.HostKey.Load()
            edtFingerPrint.Text = SFtpServer1.HostKey.FingerPrint
        Else
            edtFingerPrint.Text = ""
        End If
    End Sub

    Private Sub LoadDefaultSettings()
        'Host Key
        edtKeyLength.Text = SFtpServer1.HostKey.KeyLength.ToString()

        'SSH Algorithms Tab
        edtKexAlgs.Text = SFtpServer1.Config.GetConfig("kex")
        edtSignatureAlgs.Text = SFtpServer1.Config.GetConfig("hostkey")
        edtEncryptionAlgs.Text = SFtpServer1.Config.GetConfig("cipher.s2c")
        edtDataIntegrityAlgs.Text = SFtpServer1.Config.GetConfig("mac.s2c")

        'Additional Settings Tab
        edtCharSet.Text = SFtpServer1.CharSet
        edtMaxReturnFiles.Text = SFtpServer1.MaxReturnFiles.ToString()
        edtBatchSize.Text = SFtpServer1.BatchSize.ToString()
        edtMaxWindowSize.Text = SFtpServer1.MaxWindowSize.ToString()
    End Sub

    Private Sub GenerateHostKey()
        If (SFtpServer1.Active) Then
            Return
        End If

        If (Not StringUtils.IsEmpty(edtHostKeyFile.Text) And File.Exists(edtHostKeyFile.Text)) Then
            If (MessageBox.Show("The key file """ + edtHostKeyFile.Text + """ already exists. Do you want to replace?",
                    "File Replace Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
        End If

        SFtpServer1.HostKey.KeyLength = Convert.ToInt32(edtKeyLength.Text)
        SFtpServer1.HostKey.Generate()

        If (Not StringUtils.IsEmpty(edtHostKeyFile.Text)) Then
            SFtpServer1.HostKey.Save(edtHostKeyFile.Text)
        End If

        edtFingerPrint.Text = SFtpServer1.HostKey.FingerPrint
    End Sub

    Private Sub AssignSettings()
        If (SFtpServer1.Active) Then Return

        'Server Tab
        SFtpServer1.Port = Convert.ToInt32(edtPort.Text)
        SFtpServer1.LocalBinding = edtBindingHost.Text
        SFtpServer1.UseIpV6 = cbUseIPv6.Checked
        SFtpServer1.RootDir = edtRootDir.Text
        If (Not StringUtils.IsEmpty(SFtpServer1.RootDir)) Then
            Directory.CreateDirectory(FileUtils.AddTrailingBackSlash(SFtpServer1.RootDir))
        End If

        'Banner Tab
        SFtpServer1.Banner = edtBannerMessage.Text
        SFtpServer1.BannerLanguage = edtBannerLanguage.Text
        SFtpServer1.EnableBanner = cbEnableBanner.Checked

        'Access Control Tab
        SFtpServer1.UserAccounts.Clear()
        SFtpServer1.UserAccounts.Add(New SFtpUserAccountItem())
        SFtpServer1.UserAccounts(0).UserName = edtUserName.Text
        SFtpServer1.UserAccounts(0).Password = edtPassword.Text
        SFtpServer1.UserAccounts(0).RootDir = edtUserRootDir.Text
        If (Not StringUtils.IsEmpty(SFtpServer1.UserAccounts(0).RootDir)) Then
            Directory.CreateDirectory(FileUtils.AddTrailingBackSlash(SFtpServer1.UserAccounts(0).RootDir))
        End If

        Dim permissions As SFtpServerPermissions = SFtpServerPermissions.None
        If (cbCanList.Checked) Then permissions = permissions Or SFtpServerPermissions.List
        If (cbCanMakeDir.Checked) Then permissions = permissions Or SFtpServerPermissions.MakeDir
        If (cbCanRemoveDir.Checked) Then permissions = permissions Or SFtpServerPermissions.RemoveDir
        If (cbCanRead.Checked) Then permissions = permissions Or SFtpServerPermissions.Read
        If (cbCanWrite.Checked) Then permissions = permissions Or SFtpServerPermissions.Write
        If (cbCanRename.Checked) Then permissions = permissions Or SFtpServerPermissions.Rename
        If (cbCanRemove.Checked) Then permissions = permissions Or SFtpServerPermissions.Remove
        If (cbCanMakeLink.Checked) Then permissions = permissions Or SFtpServerPermissions.MakeLink
        If (cbCanReadLink.Checked) Then permissions = permissions Or SFtpServerPermissions.ReadLink
        SFtpServer1.UserAccounts(0).Permissions = permissions

        'IP Blocking Tab
        ServerGuard1.ConnectionLimit.Max = Convert.ToInt32(edtAllowedConnections.Text)
        ServerGuard1.ConnectionLimit.Period = 60000 '1 minute
        ServerGuard1.BlackIPList = edtBlackList.Lines
        ServerGuard1.WhiteIPList = edtWhiteList.Lines
        ServerGuard1.AllowWhiteListOnly = cbWhiteListOnly.Checked

        'SSH Algorithms Tab
        SFtpServer1.Config.SetConfig("kex", edtKexAlgs.Text)
        SFtpServer1.Config.SetConfig("hostkey", edtSignatureAlgs.Text)
        SFtpServer1.Config.SetConfig("cipher.s2c", edtEncryptionAlgs.Text)
        SFtpServer1.Config.SetConfig("cipher.c2s", edtEncryptionAlgs.Text)
        SFtpServer1.Config.SetConfig("mac.s2c", edtDataIntegrityAlgs.Text)
        SFtpServer1.Config.SetConfig("mac.c2s", edtDataIntegrityAlgs.Text)

        'Additional Settings Tab
        SFtpServer1.CharSet = edtCharSet.Text
        SFtpServer1.MaxReturnFiles = Convert.ToInt32(edtMaxReturnFiles.Text)
        SFtpServer1.BatchSize = Convert.ToInt32(edtBatchSize.Text)
        SFtpServer1.MaxWindowSize = Convert.ToInt32(edtMaxWindowSize.Text)
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

    Private Delegate Sub PutLogMessageDelegate(ByVal logMessage As String)

    Private Sub PutLogMessage(ByVal logMessage As String)
        If Me.IsDisposed Then
            Exit Sub
        End If

        If Me.InvokeRequired Then
            Me.Invoke(New PutLogMessageDelegate(AddressOf PutLogMessage), New Object() {logMessage})
        Else
            edtLog.Text = edtLog.Text + logMessage + ControlChars.Cr + ControlChars.Lf
            edtLog.Select(edtLog.Text.Length, 0)
            edtLog.ScrollToCaret()
        End If
    End Sub

    Private Sub SFtpServer1_ConnectionAccepted(sender As Object, e As ConnectionAcceptedEventArgs) Handles SFtpServer1.ConnectionAccepted
        PutLogMessage("Accept Connection. Host: " + e.Connection.PeerIP.ToString())
    End Sub

    Private Sub SFtpServer1_ConnectionClosed(sender As Object, e As ConnectionEventArgs) Handles SFtpServer1.ConnectionClosed
        If (Not IsStop) Then
            PutLogMessage("Close Connection. Host: " + e.Connection.PeerIP.ToString())
        End If
    End Sub

    Private Sub SFtpServer1_RequestReceived(sender As Object, e As SFtpServerEventArgs) Handles SFtpServer1.RequestReceived
        If (e.Command = SFtpCommand.SSH_FXP_READ Or
                e.Command = SFtpCommand.SSH_FXP_WRITE Or
                e.Command = SFtpCommand.SSH_FXP_READDIR) Then
            Return
        End If

        PutLogMessage(String.Format("Command[{0}]: {1} ({2} bytes)", e.RequestId, GetCommandName(e.Command), e.Packet.GetLength()))
    End Sub

    Private Sub SFtpServer1_ResponseSent(sender As Object, e As SFtpServerEventArgs) Handles SFtpServer1.ResponseSent
        If (e.Command = SFtpCommand.SSH_FXP_READ Or
                e.Command = SFtpCommand.SSH_FXP_WRITE Or
                e.Command = SFtpCommand.SSH_FXP_READDIR) Then
            Return
        End If

        PutLogMessage(String.Format("Reply[{0}]: {1} ({2} bytes)", e.RequestId, GetCommandName(e.Command), e.Packet.GetLength()))
    End Sub

    Private Sub SFtpServer1_Started(sender As Object, e As EventArgs) Handles SFtpServer1.Started
        PutLogMessage("==================" + ControlChars.Cr + ControlChars.Lf + "Start Server")
    End Sub

    Private Sub SFtpServer1_Stopped(sender As Object, e As EventArgs) Handles SFtpServer1.Stopped
        PutLogMessage("Stop Server")
    End Sub
End Class
