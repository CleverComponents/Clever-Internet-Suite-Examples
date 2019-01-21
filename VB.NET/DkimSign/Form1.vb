Imports System.IO
Imports CleverComponents.InetSuite

Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        edtSignFields.Text = String.Join(",", dkim1.SignedHeaderFields)
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            dkim1.ImportPrivateKey(openFileDialog1.FileName)

            Dim reader As StreamReader = File.OpenText(openFileDialog1.FileName)
            mmPrivateKey.Text = reader.ReadToEnd()
            reader.Close()

            edtDnsTxtName.Text = ""
            edtDnsTxtValue.Text = ""
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        dkim1.Domain = edtDkimDomain.Text
        dkim1.Selector = edtDkimSelector.Text

        dkim1.GenerateSigningKey(512)

        Dim list As StringCollectionEx = New StringCollectionEx()
        dkim1.ExportPrivateKey(list)
        mmPrivateKey.Lines = list.ToArray()

        dkim1.GenerateDnsRecord()

        edtDnsTxtName.Text = dkim1.DnsRecord.Name
        edtDnsTxtValue.Text = dkim1.DnsRecord.Value
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If smtp1.Active Then Return

        dkim1.Domain = edtDkimDomain.Text
        dkim1.Selector = edtDkimSelector.Text
        dkim1.SignedHeaderFields = StringUtils.GetStringArray(edtSignFields.Text, ","c)

        dkim1.ImportPrivateKey(mmPrivateKey.Lines)

        mailMessage1.BuildMessage(mmBody.Text, "")
        mailMessage1.From.FullAddress = edtFrom.Text
        mailMessage1.ToList.EmailAddresses = edtTo.Text
        mailMessage1.Subject = edtSubject.Text

        smtp1.Server = edtServer.Text
        smtp1.Port = Convert.ToInt32(edtPort.Text)

        smtp1.UserName = edtUser.Text
        smtp1.Password = edtPassword.Text

        smtp1.Open()
        Try
            smtp1.Send(mailMessage1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            smtp1.Close()
        End Try

        MessageBox.Show("The signed message was sent successfully.")
    End Sub
End Class
