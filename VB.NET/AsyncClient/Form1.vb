Imports CleverComponents.InetSuite

Public Class Form1

    Private Delegate Sub WriteTerminalDelegate(ByVal msg As String)

    Private Sub WriteTerminal(ByVal msg As String)
        If Me.IsDisposed Then
            Exit Sub
        End If

        If Me.InvokeRequired Then
            Me.Invoke(New WriteTerminalDelegate(AddressOf WriteTerminal), New Object() {msg})
        Else
            textBox1.Text = textBox1.Text + msg + ControlChars.Cr + ControlChars.Lf
            textBox1.Select(textBox1.Text.Length, 0)
            textBox1.ScrollToCaret()
        End If
    End Sub


    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        AsyncClient1.Server = edtHost.Text
        AsyncClient1.Port = Convert.ToInt32(edtPort.Text)
        AsyncClient1.Open()
        textBox1.Focus()
    End Sub

    Private Sub AsyncClient1_Connected(ByVal sender As System.Object, ByVal e As EventArgs) Handles AsyncClient1.Connected
        WriteTerminal("Connected to " + AsyncClient1.Server + "(" + AsyncClient1.Port.ToString + ")" + vbCrLf)
    End Sub

    Private Sub AsyncClient1_Disconnected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsyncClient1.Disconnected
        WriteTerminal("Connection closed" + vbCrLf)
    End Sub

    Private Sub AsyncClient1_Read(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsyncClient1.Read
        Using str As New StringStream()
            AsyncClient1.ReadData(str)
            If Not StringUtils.IsEmpty(str.DataString) Then
                WriteTerminal(str.DataString.Trim() + vbCr + vbLf)
            End If
        End Using
    End Sub

    Private Sub textBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBox1.KeyPress
        If Not AsyncClient1.Active Then
            Return
        End If

        Dim s As String = e.KeyChar.ToString()

        If e.KeyChar = ControlChars.Cr Then
            s = vbCr + vbLf
        End If

        Using str As New StringStream(s)
            AsyncClient1.WriteData(str)
        End Using
    End Sub
End Class
