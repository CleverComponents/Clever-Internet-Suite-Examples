Imports CleverComponents.InetSuite

Public Class Form1
    Private Sub btnCheckMail_Click(sender As Object, e As EventArgs) Handles btnCheckMail.Click
        If pop3.Active Then Return

        pop3.Server = edtServer.Text
        pop3.Port = Convert.ToInt32(edtPort.Text)
        pop3.UserName = edtUser.Text
        pop3.Password = edtPassword.Text

        lbMessages.Items.Clear()

        pop3.Open()
        Try
            For i As Integer = 1 To pop3.MessageCount
                Dim result As String = "( NO DKIM ) "

                Try
                    pop3.Retrieve(i)

                    If mailMessage1.Dkim.Signatures.Count > 0 Then
                        result = "( DKIM OK ) "
                    End If

                Catch ex As CryptError
                    result = "( DKIM FAIL ) "
                Catch ex As DkimError
                    result = "( DKIM FAIL ) "
                End Try

                lbMessages.Items.Add(result & mailMessage1.Subject)
            Next

        Finally
            pop3.Close()
        End Try

        MessageBox.Show("Done")
    End Sub
End Class
