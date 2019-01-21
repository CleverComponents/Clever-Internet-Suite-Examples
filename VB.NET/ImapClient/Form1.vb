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
    Private subscribeStatus As New Hashtable

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnPurge As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnAppend As System.Windows.Forms.Button
    Friend WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnUnsubscribe As System.Windows.Forms.Button
    Friend WithEvents btnSubscribe As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnDeleteFolder As System.Windows.Forms.Button
    Friend WithEvents btnNewFolder As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents memLog As System.Windows.Forms.TextBox
    Friend WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents tvFolders As System.Windows.Forms.ListBox
    Friend WithEvents lvMessages As System.Windows.Forms.ListView
    Friend WithEvents columnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents columnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents edtFirstUnseen As System.Windows.Forms.TextBox
    Friend WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents edtRecent As System.Windows.Forms.TextBox
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents edtAll As System.Windows.Forms.TextBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents edtSubscribed As System.Windows.Forms.TextBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents edtTimeOut As System.Windows.Forms.TextBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents edtPort As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents cbUseSPA As System.Windows.Forms.CheckBox
    Friend WithEvents edtPassword As System.Windows.Forms.TextBox
    Friend WithEvents edtUser As System.Windows.Forms.TextBox
    Friend WithEvents edtServer As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Imap41 As CleverComponents.InetSuite.Imap4
    Friend WithEvents MailMessage1 As CleverComponents.InetSuite.MailMessage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnPurge = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnCopy = New System.Windows.Forms.Button
        Me.btnAppend = New System.Windows.Forms.Button
        Me.columnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.btnUnsubscribe = New System.Windows.Forms.Button
        Me.btnSubscribe = New System.Windows.Forms.Button
        Me.btnFind = New System.Windows.Forms.Button
        Me.btnDeleteFolder = New System.Windows.Forms.Button
        Me.btnNewFolder = New System.Windows.Forms.Button
        Me.btnLogout = New System.Windows.Forms.Button
        Me.btnLogin = New System.Windows.Forms.Button
        Me.memLog = New System.Windows.Forms.TextBox
        Me.label10 = New System.Windows.Forms.Label
        Me.tvFolders = New System.Windows.Forms.ListBox
        Me.lvMessages = New System.Windows.Forms.ListView
        Me.columnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.edtFirstUnseen = New System.Windows.Forms.TextBox
        Me.label9 = New System.Windows.Forms.Label
        Me.edtRecent = New System.Windows.Forms.TextBox
        Me.label8 = New System.Windows.Forms.Label
        Me.edtAll = New System.Windows.Forms.TextBox
        Me.label7 = New System.Windows.Forms.Label
        Me.edtSubscribed = New System.Windows.Forms.TextBox
        Me.label6 = New System.Windows.Forms.Label
        Me.edtTimeOut = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.edtPort = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.cbUseSPA = New System.Windows.Forms.CheckBox
        Me.edtPassword = New System.Windows.Forms.TextBox
        Me.edtUser = New System.Windows.Forms.TextBox
        Me.edtServer = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.Imap41 = New CleverComponents.InetSuite.Imap4
        Me.MailMessage1 = New CleverComponents.InetSuite.MailMessage
        Me.groupBox1.SuspendLayout()
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPurge
        '
        Me.btnPurge.Location = New System.Drawing.Point(536, 360)
        Me.btnPurge.Name = "btnPurge"
        Me.btnPurge.Size = New System.Drawing.Size(96, 23)
        Me.btnPurge.TabIndex = 55
        Me.btnPurge.Text = "Purge Deleted"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(536, 328)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 23)
        Me.btnDelete.TabIndex = 54
        Me.btnDelete.Text = "Delete"
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(536, 296)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(96, 23)
        Me.btnCopy.TabIndex = 53
        Me.btnCopy.Text = "Copy"
        '
        'btnAppend
        '
        Me.btnAppend.Location = New System.Drawing.Point(536, 264)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(96, 23)
        Me.btnAppend.TabIndex = 52
        Me.btnAppend.Text = "Append..."
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Subject"
        Me.columnHeader2.Width = 100
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "No"
        Me.columnHeader1.Width = 50
        '
        'btnUnsubscribe
        '
        Me.btnUnsubscribe.Location = New System.Drawing.Point(536, 224)
        Me.btnUnsubscribe.Name = "btnUnsubscribe"
        Me.btnUnsubscribe.Size = New System.Drawing.Size(96, 23)
        Me.btnUnsubscribe.TabIndex = 51
        Me.btnUnsubscribe.Text = "Unsubscribe"
        '
        'btnSubscribe
        '
        Me.btnSubscribe.Location = New System.Drawing.Point(536, 192)
        Me.btnSubscribe.Name = "btnSubscribe"
        Me.btnSubscribe.Size = New System.Drawing.Size(96, 23)
        Me.btnSubscribe.TabIndex = 50
        Me.btnSubscribe.Text = "Subscribe"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(536, 160)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(96, 23)
        Me.btnFind.TabIndex = 49
        Me.btnFind.Text = "Find..."
        '
        'btnDeleteFolder
        '
        Me.btnDeleteFolder.Location = New System.Drawing.Point(536, 128)
        Me.btnDeleteFolder.Name = "btnDeleteFolder"
        Me.btnDeleteFolder.Size = New System.Drawing.Size(96, 23)
        Me.btnDeleteFolder.TabIndex = 48
        Me.btnDeleteFolder.Text = "Delete Folder"
        '
        'btnNewFolder
        '
        Me.btnNewFolder.Location = New System.Drawing.Point(536, 96)
        Me.btnNewFolder.Name = "btnNewFolder"
        Me.btnNewFolder.Size = New System.Drawing.Size(96, 23)
        Me.btnNewFolder.TabIndex = 47
        Me.btnNewFolder.Text = "New Folder..."
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(536, 48)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(96, 23)
        Me.btnLogout.TabIndex = 46
        Me.btnLogout.Text = "Logout"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(536, 16)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(96, 23)
        Me.btnLogin.TabIndex = 45
        Me.btnLogin.Text = "Login"
        '
        'memLog
        '
        Me.memLog.Location = New System.Drawing.Point(16, 312)
        Me.memLog.Multiline = True
        Me.memLog.Name = "memLog"
        Me.memLog.ReadOnly = True
        Me.memLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.memLog.Size = New System.Drawing.Size(504, 72)
        Me.memLog.TabIndex = 44
        Me.memLog.Text = ""
        '
        'label10
        '
        Me.label10.Location = New System.Drawing.Point(16, 296)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(48, 16)
        Me.label10.TabIndex = 43
        Me.label10.Text = "Log"
        '
        'tvFolders
        '
        Me.tvFolders.Location = New System.Drawing.Point(16, 104)
        Me.tvFolders.Name = "tvFolders"
        Me.tvFolders.Size = New System.Drawing.Size(152, 186)
        Me.tvFolders.TabIndex = 40
        '
        'lvMessages
        '
        Me.lvMessages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3, Me.columnHeader4})
        Me.lvMessages.FullRowSelect = True
        Me.lvMessages.HideSelection = False
        Me.lvMessages.Location = New System.Drawing.Point(184, 184)
        Me.lvMessages.Name = "lvMessages"
        Me.lvMessages.Size = New System.Drawing.Size(336, 104)
        Me.lvMessages.TabIndex = 42
        Me.lvMessages.View = System.Windows.Forms.View.Details
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "From"
        Me.columnHeader3.Width = 100
        '
        'columnHeader4
        '
        Me.columnHeader4.Text = "Flags"
        Me.columnHeader4.Width = 80
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.edtFirstUnseen)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.edtRecent)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.edtAll)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.edtSubscribed)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Location = New System.Drawing.Point(184, 96)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(336, 80)
        Me.groupBox1.TabIndex = 41
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Folder Details"
        '
        'edtFirstUnseen
        '
        Me.edtFirstUnseen.Location = New System.Drawing.Point(256, 48)
        Me.edtFirstUnseen.Name = "edtFirstUnseen"
        Me.edtFirstUnseen.Size = New System.Drawing.Size(64, 20)
        Me.edtFirstUnseen.TabIndex = 7
        Me.edtFirstUnseen.Text = ""
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(152, 48)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(88, 16)
        Me.label9.TabIndex = 6
        Me.label9.Text = "First Unseen"
        '
        'edtRecent
        '
        Me.edtRecent.Location = New System.Drawing.Point(256, 24)
        Me.edtRecent.Name = "edtRecent"
        Me.edtRecent.Size = New System.Drawing.Size(64, 20)
        Me.edtRecent.TabIndex = 5
        Me.edtRecent.Text = ""
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(152, 24)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(96, 16)
        Me.label8.TabIndex = 4
        Me.label8.Text = "Recent Messages"
        '
        'edtAll
        '
        Me.edtAll.Location = New System.Drawing.Point(80, 48)
        Me.edtAll.Name = "edtAll"
        Me.edtAll.Size = New System.Drawing.Size(64, 20)
        Me.edtAll.TabIndex = 3
        Me.edtAll.Text = ""
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(8, 48)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(72, 16)
        Me.label7.TabIndex = 2
        Me.label7.Text = "All Messages"
        '
        'edtSubscribed
        '
        Me.edtSubscribed.Location = New System.Drawing.Point(80, 24)
        Me.edtSubscribed.Name = "edtSubscribed"
        Me.edtSubscribed.Size = New System.Drawing.Size(64, 20)
        Me.edtSubscribed.TabIndex = 1
        Me.edtSubscribed.Text = ""
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(8, 24)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(64, 16)
        Me.label6.TabIndex = 0
        Me.label6.Text = "Subscribed"
        '
        'edtTimeOut
        '
        Me.edtTimeOut.Location = New System.Drawing.Point(392, 64)
        Me.edtTimeOut.Name = "edtTimeOut"
        Me.edtTimeOut.Size = New System.Drawing.Size(128, 20)
        Me.edtTimeOut.TabIndex = 39
        Me.edtTimeOut.Text = "60"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(312, 64)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(72, 16)
        Me.label5.TabIndex = 38
        Me.label5.Text = "TimeOut, s"
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(392, 40)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(128, 20)
        Me.edtPort.TabIndex = 37
        Me.edtPort.Text = "143"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(312, 40)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(48, 16)
        Me.label4.TabIndex = 36
        Me.label4.Text = "Port"
        '
        'cbUseSPA
        '
        Me.cbUseSPA.Location = New System.Drawing.Point(312, 16)
        Me.cbUseSPA.Name = "cbUseSPA"
        Me.cbUseSPA.Size = New System.Drawing.Size(216, 24)
        Me.cbUseSPA.TabIndex = 34
        Me.cbUseSPA.Text = "Use Secure Password Authentication"
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(80, 64)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.Size = New System.Drawing.Size(216, 20)
        Me.edtPassword.TabIndex = 33
        Me.edtPassword.Text = "clevertester"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(80, 40)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(216, 20)
        Me.edtUser.TabIndex = 32
        Me.edtUser.Text = "CleverTester"
        '
        'edtServer
        '
        Me.edtServer.Location = New System.Drawing.Point(80, 16)
        Me.edtServer.Name = "edtServer"
        Me.edtServer.Size = New System.Drawing.Size(216, 20)
        Me.edtServer.TabIndex = 31
        Me.edtServer.Text = "localhost"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 64)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 16)
        Me.label3.TabIndex = 30
        Me.label3.Text = "Password"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 16)
        Me.label2.TabIndex = 29
        Me.label2.Text = "User"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 16)
        Me.label1.TabIndex = 28
        Me.label1.Text = "Server"
        '
        'Imap41
        '
        Me.Imap41.Port = 143
        '
        'MailMessage1
        '
        Me.MailMessage1.Date = New Date(2006, 5, 8, 14, 47, 52, 62)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 398)
        Me.Controls.Add(Me.btnPurge)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnAppend)
        Me.Controls.Add(Me.btnUnsubscribe)
        Me.Controls.Add(Me.btnSubscribe)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnDeleteFolder)
        Me.Controls.Add(Me.btnNewFolder)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.memLog)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.tvFolders)
        Me.Controls.Add(Me.lvMessages)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.edtTimeOut)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.edtPort)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.cbUseSPA)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.edtUser)
        Me.Controls.Add(Me.edtServer)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "IMAP Client"
        Me.groupBox1.ResumeLayout(False)
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If Imap41.Active Then
            MessageBox.Show("You are already connected. Please click Logout to disconnect.")
            Return
        End If

        Try
            Imap41.Server = edtServer.Text
            Imap41.Port = Convert.ToInt32(edtPort.Text)
            Imap41.UserName = edtUser.Text
            Imap41.Password = edtPassword.Text
            Imap41.UseSasl = cbUseSPA.Checked

            Imap41.TimeOut = Convert.ToInt32(edtTimeOut.Text) * 1000
            Imap41.Open()

            GetFolderList()

            UpdateStatus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub 'btnLogin_Click


    Private Sub GetFolderList()
        subscribeStatus.Clear()
        tvFolders.Items.Clear()
        lvMessages.Items.Clear()

        edtSubscribed.Text = ""
        edtAll.Text = ""
        edtRecent.Text = ""
        edtFirstUnseen.Text = ""

        Dim mailboxes As String() = Imap41.GetMailBoxes()

        Dim subscribed As String() = Imap41.GetSubscribedMailBoxes()

        Dim i As Integer
        For i = 0 To mailboxes.Length - 1
            Dim item As String = mailboxes(i)
            tvFolders.Items.Add(item)
            subscribeStatus.Add(item, Array.IndexOf(subscribed, item) > -1)
        Next i
    End Sub 'GetFolderList


    Private Sub UpdateStatus()
        If Imap41.Active Then
            Me.Text = "IMAP Clinet - Connected"
        Else
            Me.Text = "IMAP Clinet"
        End If
    End Sub 'UpdateStatus


    Private Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Imap41.Close()

        subscribeStatus.Clear()
        tvFolders.Items.Clear()
        lvMessages.Items.Clear()

        edtSubscribed.Text = ""
        edtAll.Text = ""
        edtRecent.Text = ""
        edtFirstUnseen.Text = ""

        UpdateStatus()
    End Sub 'btnLogout_Click


    Private Sub btnNewFolder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewFolder.Click
        If Not Imap41.Active Then
            Return
        End If
        Dim dlg As New NewFolderDlg
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If dlg.cbIsSubfolder.Checked And tvFolders.SelectedIndex > -1 Then
                Imap41.CreateMailBox((tvFolders.SelectedItem.ToString() + Imap41.MailBoxSeparator + dlg.edtName.Text))
            Else
                Imap41.CreateMailBox(dlg.edtName.Text)
            End If

            GetFolderList()
        End If
    End Sub 'btnNewFolder_Click


    Private Sub btnDeleteFolder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeleteFolder.Click
        If Not Imap41.Active Then
            Return
        End If
        If tvFolders.SelectedIndex > -1 Then
            If MessageBox.Show(String.Format("Do you wish to delete the {0} folder ?", tvFolders.SelectedItem.ToString()), "Delete folder", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Imap41.DeleteMailBox(tvFolders.SelectedItem.ToString())
                GetFolderList()
            End If
        End If
    End Sub 'btnDeleteFolder_Click


    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If Not Imap41.Active Then
            Return
        End If
        If tvFolders.SelectedIndex < 0 Then
            Return
        End If
        Dim dlg As New SearchDlg

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim result As String() = Imap41.SearchMessages(dlg.GetSearchCriteria())

            If result.Length = 0 Then
                MessageBox.Show("No messages found.")
            Else
                MessageBox.Show(String.Format("Found {0} message(s)." + ControlChars.Cr + ControlChars.Lf + " Message numbers: " + ControlChars.Cr + ControlChars.Lf + "{1}", result.Length, StringUtils.GetStringsAsString(result)))
            End If
        End If
    End Sub 'btnFind_Click


    Private Sub btnSubscribe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubscribe.Click
        If Not Imap41.Active Then
            Return
        End If
        If tvFolders.SelectedIndex > -1 And Not CBool(subscribeStatus(tvFolders.SelectedItem)) Then
            Imap41.SubscribeMailBox(tvFolders.SelectedItem.ToString())
            subscribeStatus(tvFolders.SelectedItem) = True
            tvFolders_SelectedIndexChanged(Nothing, Nothing)
            MessageBox.Show(String.Format("The folder {0} has been subscribed.", tvFolders.SelectedItem.ToString()))
        End If
    End Sub 'btnSubscribe_Click


    Private Sub btnUnsubscribe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUnsubscribe.Click
        If Not Imap41.Active Then
            Return
        End If
        If tvFolders.SelectedIndex > -1 And CBool(subscribeStatus(tvFolders.SelectedItem)) Then
            Imap41.UnsubscribeMailBox(tvFolders.SelectedItem.ToString())
            subscribeStatus(tvFolders.SelectedItem) = False
            tvFolders_SelectedIndexChanged(Nothing, Nothing)
            MessageBox.Show(String.Format("The folder {0} has been unsubscribed.", tvFolders.SelectedItem.ToString()))
        End If
    End Sub 'btnUnsubscribe_Click


    Private Sub btnAppend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAppend.Click
        If Not Imap41.Active Then
            Return
        End If
        If tvFolders.SelectedIndex > -1 Then
            If MessageFrm.ComposeMessage(MailMessage1) Then
                Imap41.AppendMessage(tvFolders.SelectedItem.ToString(), MailMessage1, MailMessageFlags.None)
                tvFolders_SelectedIndexChanged(Nothing, Nothing)
            End If
        End If
    End Sub 'btnAppend_Click


    Private Sub btnCopy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        If Not Imap41.Active Then
            Return
        End If
        If lvMessages.SelectedItems.Count = 1 Then

            Dim dest As String = CopyDlg.ShowCopyDialog(Imap41.GetMailBoxes())
            If dest <> "" Then
                Imap41.CopyMessage(Convert.ToInt32(lvMessages.SelectedItems(0).Text), dest)
                GetFolderList()
            End If
        End If
    End Sub 'btnCopy_Click


    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Not Imap41.Active Then
            Return
        End If
        If tvFolders.SelectedIndex > -1 And lvMessages.SelectedItems.Count = 1 Then
            Imap41.DeleteMessage(Convert.ToInt32(lvMessages.SelectedItems(0).Text))
            tvFolders_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub 'btnDelete_Click


    Private Sub btnPurge_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPurge.Click
        If Not Imap41.Active Then
            Return
        End If
        If tvFolders.SelectedIndex > -1 Then
            If MessageBox.Show("Purge all marked as deleted messages in selected folder ?", "Purge", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Imap41.PurgeMessages()
                tvFolders_SelectedIndexChanged(Nothing, Nothing)
            End If
        End If
    End Sub 'btnPurge_Click


    Private Sub tvFolders_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvFolders.SelectedIndexChanged
        If tvFolders.SelectedIndex < 0 Then
            Return
        End If
        Imap41.SelectMailBox(tvFolders.Items(tvFolders.SelectedIndex).ToString())

        edtSubscribed.Text = subscribeStatus(tvFolders.Items(tvFolders.SelectedIndex)).ToString()
        edtAll.Text = Imap41.CurrentMailBox.ExistsMessages.ToString()
        edtRecent.Text = Imap41.CurrentMailBox.RecentMessages.ToString()
        edtFirstUnseen.Text = Imap41.CurrentMailBox.FirstUnseen.ToString()

        GetMessageList()
    End Sub 'tvFolders_SelectedIndexChanged


    Private Sub GetMessageList()
        lvMessages.Items.Clear()

        Dim i As Integer
        For i = 1 To Imap41.CurrentMailBox.ExistsMessages
            Imap41.RetrieveHeader(i, MailMessage1)

            Dim item As ListViewItem = lvMessages.Items.Add(i.ToString())
            item.SubItems.Add(MailMessage1.Subject)
            item.SubItems.Add(MailMessage1.From.FullAddress)

            Dim flags As Integer = Imap41.GetMessageFlags(i)
            Dim s As String = ""

            If (flags And CInt(MailMessageFlags.Answered)) > 0 Then
                s += "Answered,"
            End If
            If (flags And CInt(MailMessageFlags.Flagged)) > 0 Then
                s += "Flagged,"
            End If
            If (flags And CInt(MailMessageFlags.Deleted)) > 0 Then
                s += "Deleted,"
            End If
            If (flags And CInt(MailMessageFlags.Seen)) > 0 Then
                s += "Seen,"
            End If
            If (flags And CInt(MailMessageFlags.Draft)) > 0 Then
                s += "Draft,"
            End If
            If (flags And CInt(MailMessageFlags.Recent)) > 0 Then
                s += "Recent,"
            End If
            item.SubItems.Add(s)
        Next i
    End Sub 'GetMessageList


    Private Sub lvMessages_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvMessages.DoubleClick
        If Not Imap41.Active Then
            Return
        End If
        If lvMessages.SelectedItems.Count > 0 Then
            Imap41.RetrieveMessage(Convert.ToInt32(lvMessages.SelectedItems(0).Text), MailMessage1)
            Imap41.SetMessageFlags(Convert.ToInt32(lvMessages.SelectedItems(0).Text), SetFlagsMethod.Add, MailMessageFlags.Seen)
            MessageFrm.ShowMessage(MailMessage1)
            tvFolders_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub 'lvMessages_DoubleClick

    Private Sub Imap41_ResponseReceived(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.TcpListEventArgs) Handles Imap41.ResponseReceived
        If e.List.Count > 0 Then
            memLog.Text += e.List.Item(0).ToString() + ControlChars.Cr + ControlChars.Lf
            memLog.Select(memLog.Text.Length, 0)
            memLog.ScrollToCaret()
        End If
    End Sub

    Private Sub Imap41_CommandSent(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.TcpTextEventArgs) Handles Imap41.CommandSent
        memLog.Text += e.Text.Trim() + ControlChars.Cr + ControlChars.Lf
        memLog.Select(memLog.Text.Length, 0)
        memLog.ScrollToCaret()
    End Sub
End Class
