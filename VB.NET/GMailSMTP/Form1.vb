Imports CleverComponents.InetSuite

Public Class Form1
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If smtp1.Active Then Return

        oAuth1.AuthUrl = "https://accounts.google.com/o/oauth2/auth"
        oAuth1.TokenUrl = "https://accounts.google.com/o/oauth2/token"
        oAuth1.RedirectUrl = "http://localhost"

        'You need to specify both Client ID and Client Secret of your Google API Project.
        oAuth1.ClientID = "421475025220-6khpgoldbdsi60fegvjdqk2bk4v19ss2.apps.googleusercontent.com"
        oAuth1.ClientSecret = "_4HJyAVUmH_iVrPB8pOJXjR1"

        oAuth1.Scope = "https://mail.google.com/"

        smtp1.Server = "smtp.gmail.com"
        smtp1.Port = 587
        smtp1.UseTls = ClientTlsMode.Explicit

        smtp1.UserName = edtFrom.Text

        smtp1.Authorization = oAuth1.GetAuthorization()

        smtp1.Open()
        Try
            mailMessage1.BuildMessage(memBody.Text, "")
            mailMessage1.From.FullAddress = edtFrom.Text
            mailMessage1.ToList.EmailAddresses = edtTo.Text
            mailMessage1.Subject = edtSubject.Text

            smtp1.Send(mailMessage1)

            MessageBox.Show("The message was sent successfully.")
        Finally
            smtp1.Close()
        End Try
    End Sub
End Class
