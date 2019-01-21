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
    Friend WithEvents lbMessages As System.Windows.Forms.ListBox
    Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnCheckMail As System.Windows.Forms.Button
    Friend WithEvents btnComposeMail As System.Windows.Forms.Button
    Friend WithEvents edtSmtpServer As System.Windows.Forms.TextBox
    Friend WithEvents edtPassword As System.Windows.Forms.TextBox
    Friend WithEvents edtUser As System.Windows.Forms.TextBox
    Friend WithEvents edtPop3Server As System.Windows.Forms.TextBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Smtp1 As CleverComponents.InetSuite.Smtp
    Friend WithEvents Pop31 As CleverComponents.InetSuite.Pop3
    Friend WithEvents MailMessage1 As CleverComponents.InetSuite.MailMessage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lbMessages = New System.Windows.Forms.ListBox
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btnCheckMail = New System.Windows.Forms.Button
        Me.btnComposeMail = New System.Windows.Forms.Button
        Me.edtSmtpServer = New System.Windows.Forms.TextBox
        Me.edtPassword = New System.Windows.Forms.TextBox
        Me.edtUser = New System.Windows.Forms.TextBox
        Me.edtPop3Server = New System.Windows.Forms.TextBox
        Me.label6 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.Smtp1 = New CleverComponents.InetSuite.Smtp
        Me.Pop31 = New CleverComponents.InetSuite.Pop3
        Me.MailMessage1 = New CleverComponents.InetSuite.MailMessage
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbMessages
        '
        Me.lbMessages.Location = New System.Drawing.Point(16, 168)
        Me.lbMessages.Name = "lbMessages"
        Me.lbMessages.Size = New System.Drawing.Size(360, 147)
        Me.lbMessages.TabIndex = 19
        '
        'btnCheckMail
        '
        Me.btnCheckMail.Location = New System.Drawing.Point(104, 120)
        Me.btnCheckMail.Name = "btnCheckMail"
        Me.btnCheckMail.Size = New System.Drawing.Size(104, 23)
        Me.btnCheckMail.TabIndex = 16
        Me.btnCheckMail.Text = "Check Mail"
        '
        'btnComposeMail
        '
        Me.btnComposeMail.Location = New System.Drawing.Point(264, 120)
        Me.btnComposeMail.Name = "btnComposeMail"
        Me.btnComposeMail.Size = New System.Drawing.Size(104, 23)
        Me.btnComposeMail.TabIndex = 18
        Me.btnComposeMail.Text = "Compose Mail"
        '
        'edtSmtpServer
        '
        Me.edtSmtpServer.Location = New System.Drawing.Point(104, 40)
        Me.edtSmtpServer.Name = "edtSmtpServer"
        Me.edtSmtpServer.Size = New System.Drawing.Size(272, 20)
        Me.edtSmtpServer.TabIndex = 11
        Me.edtSmtpServer.Text = "smtp.domain.com"
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(104, 88)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.Size = New System.Drawing.Size(272, 20)
        Me.edtPassword.TabIndex = 15
        Me.edtPassword.Text = "password"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(104, 64)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(272, 20)
        Me.edtUser.TabIndex = 14
        Me.edtUser.Text = "user"
        '
        'edtPop3Server
        '
        Me.edtPop3Server.Location = New System.Drawing.Point(104, 16)
        Me.edtPop3Server.Name = "edtPop3Server"
        Me.edtPop3Server.Size = New System.Drawing.Size(272, 20)
        Me.edtPop3Server.TabIndex = 9
        Me.edtPop3Server.Text = "pop.domain.com"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(24, 152)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(168, 16)
        Me.label6.TabIndex = 17
        Me.label6.Text = "Messages. Double click to view"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 40)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 16)
        Me.label4.TabIndex = 13
        Me.label4.Text = "SMTP server"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 88)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 16)
        Me.label3.TabIndex = 12
        Me.label3.Text = "Password"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 64)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 16)
        Me.label2.TabIndex = 10
        Me.label2.Text = "User"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(64, 16)
        Me.label1.TabIndex = 8
        Me.label1.Text = "POP server"
        '
        'Smtp1
        '
        Me.Smtp1.Port = 25
        '
        'Pop31
        '
        Me.Pop31.Port = 110
        '
        'MailMessage1
        '
        Me.MailMessage1.Date = New Date(2006, 5, 8, 15, 43, 5, 952)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(394, 326)
        Me.Controls.Add(Me.btnCheckMail)
        Me.Controls.Add(Me.btnComposeMail)
        Me.Controls.Add(Me.edtSmtpServer)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.edtUser)
        Me.Controls.Add(Me.edtPop3Server)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lbMessages)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "SMTP / POP3 client demo"
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCheckMail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckMail.Click
        If Smtp1.Active Or Pop31.Active Then
            Return
        End If
        Pop31.Server = edtPop3Server.Text
        Pop31.UserName = edtUser.Text
        Pop31.Password = edtPassword.Text

        Try
            Pop31.Open()

            lbMessages.Items.Clear()

            Dim i As Integer
            For i = 0 To Pop31.MessageCount - 1
                Pop31.RetrieveHeader(i + 1, MailMessage1)
                If MailMessage1.Subject = "" Then
                    lbMessages.Items.Add(MailMessage1.From)
                Else
                    lbMessages.Items.Add(MailMessage1.Subject)
                End If
            Next i
            Pop31.Close()

            MessageBox.Show(String.Format("Collecting completed, {0} messages in the mailbox", Pop31.MessageCount))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Pop31.Close()
        End Try
    End Sub 'btnCheckMail_Click


    Private Sub btnComposeMail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComposeMail.Click
        If Smtp1.Active Or Pop31.Active Then
            Return
        End If
        Dim dlg As New MessageFrm

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                MailMessage1.BuildMessage(dlg.memBody.Text, "")
                MailMessage1.From.FullAddress = dlg.edtFrom.Text
                MailMessage1.ToList.EmailAddresses = dlg.edtTo.Text
                MailMessage1.Subject = dlg.edtSubject.Text

                Smtp1.Server = edtSmtpServer.Text
                Smtp1.UserName = edtUser.Text
                Smtp1.Password = edtPassword.Text

                Smtp1.Open()
                Smtp1.Send(MailMessage1)
                Smtp1.Close()

                MessageBox.Show("The message was sent successfully")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Smtp1.Close()
            End Try
        End If
    End Sub 'btnComposeMail_Click


    Private Sub lbMessages_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbMessages.DoubleClick
        If Pop31.Active Or lbMessages.SelectedIndex < 0 Then
            Return
        End If
        Pop31.Server = edtPop3Server.Text
        Pop31.UserName = edtUser.Text
        Pop31.Password = edtPassword.Text

        Try
            Pop31.Open()
            Pop31.Retrieve(lbMessages.SelectedIndex + 1, MailMessage1)

            Dim dlg As New MessageFrm

            dlg.edtFrom.Text = MailMessage1.From.FullAddress
            dlg.edtTo.Text = MailMessage1.ToList.EmailAddresses
            dlg.edtSubject.Text = MailMessage1.Subject

            dlg.memBody.Lines = MailMessage1.MessageText

            dlg.edtFrom.ReadOnly = True
            dlg.edtTo.ReadOnly = True
            dlg.edtSubject.ReadOnly = True
            dlg.memBody.ReadOnly = True
            dlg.btnSend.Enabled = False

            dlg.edtFrom.BackColor = SystemColors.Window
            dlg.edtTo.BackColor = SystemColors.Window
            dlg.edtSubject.BackColor = SystemColors.Window
            dlg.memBody.BackColor = SystemColors.Window

            dlg.ShowDialog()

            Pop31.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Pop31.Close()
        End Try
    End Sub 'lbMessages_DoubleClick

End Class
