Imports CleverComponents.InetSuite

Public Class Form1
    Private changing As Boolean

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If imap.Active Then
            Return
        End If

        oAuth.AuthUrl = "https://accounts.google.com/o/oauth2/auth"
        oAuth.TokenUrl = "https://accounts.google.com/o/oauth2/token"
        oAuth.RedirectUrl = "http://localhost"
        oAuth.ClientID = "421475025220-6khpgoldbdsi60fegvjdqk2bk4v19ss2.apps.googleusercontent.com"
        oAuth.ClientSecret = "_4HJyAVUmH_iVrPB8pOJXjR1"
        oAuth.Scope = "https://mail.google.com/"

        imap.Server = "imap.gmail.com"
        imap.Port = 993
        imap.UseTls = ClientTlsMode.Implicit

        imap.UserName = edtUser.Text

        imap.Authorization = oAuth.GetAuthorization

        imap.Open()

        FillFolderList
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        imap.Close()
        tvFolders.Items.Clear()
        lvMessages.Items.Clear()
        ClearMessage
    End Sub

    Private Sub tvFolders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tvFolders.SelectedIndexChanged
        If changing Then
            Return
        End If

        changing = True
        Try
            EnableControls(False)

            If ((tvFolders.SelectedIndex > -1) AndAlso imap.Active) Then
                imap.SelectMailBox(tvFolders.Items(tvFolders.SelectedIndex).ToString)
            End If

            FillMessages
        Finally
            changing = False
            EnableControls(True)
        End Try
    End Sub

    Private Sub lvMessages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvMessages.SelectedIndexChanged
        If changing Then
            Return
        End If

        changing = True
        Try
            EnableControls(False)
            If (imap.Active AndAlso (lvMessages.SelectedItems.Count > 0)) Then

                imap.RetrieveMessage(Convert.ToInt32(lvMessages.SelectedItems(0).SubItems(4).Text), mailMessage)

                edtFrom.Text = mailMessage.From.FullAddress
                edtSubject.Text = mailMessage.Subject
                memBody.Lines = mailMessage.MessageText
            Else
                ClearMessage
            End If

        Finally
            changing = False
            EnableControls(True)
        End Try
    End Sub

    Private Sub FillMessages()
        lvMessages.Items.Clear()
        ClearMessage()

        If Not imap.Active Then
            Return
        End If

        Dim i As Integer = 1
        Do While (i <= imap.CurrentMailBox.ExistsMessages)
            imap.RetrieveHeader(i, mailMessage)
            Dim item As ListViewItem = lvMessages.Items.Add(mailMessage.Subject)
            item.SubItems.Add(mailMessage.From.FullAddress)
            item.SubItems.Add(mailMessage.Date.ToString)
            item.SubItems.Add(imap.GetMessageSize(i).ToString)
            item.SubItems.Add(i.ToString)
            i = (i + 1)
        Loop
    End Sub

    Private Sub ClearMessage()
        edtFrom.Text = ""
        edtSubject.Text = ""
        memBody.Text = ""
    End Sub

    Private Sub FillFolderList()
        tvFolders.Items.Clear()
        lvMessages.Items.Clear()
        ClearMessage

        Dim mailboxes() As String = imap.GetMailBoxes

        Dim i As Integer = 0
        Do While (i < mailboxes.Length)
            Dim item As String = mailboxes(i).ToString
            If (String.Compare("[Gmail]", item) <> 0) Then
                tvFolders.Items.Add(item)
            End If

            i = (i + 1)
        Loop
    End Sub

    Private Sub EnableControls(ByVal enabled As Boolean)
        btnLogin.Enabled = enabled
        btnLogout.Enabled = enabled
        tvFolders.Enabled = enabled
        lvMessages.Enabled = enabled
        edtFrom.Enabled = enabled
        edtSubject.Enabled = enabled
        memBody.Enabled = enabled

        Application.UseWaitCursor = Not enabled
    End Sub
End Class
