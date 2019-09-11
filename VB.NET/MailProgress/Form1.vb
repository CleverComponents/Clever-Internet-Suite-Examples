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
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnReceive As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents edtAttachment As System.Windows.Forms.TextBox
    Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents memBody As System.Windows.Forms.TextBox
    Friend WithEvents edtTo As System.Windows.Forms.TextBox
    Friend WithEvents edtFrom As System.Windows.Forms.TextBox
    Friend WithEvents edtPassword As System.Windows.Forms.TextBox
    Friend WithEvents edtUser As System.Windows.Forms.TextBox
    Friend WithEvents edtServer As System.Windows.Forms.TextBox
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Smtp1 As CleverComponents.InetSuite.Smtp
    Friend WithEvents Pop31 As CleverComponents.InetSuite.Pop3
    Friend WithEvents MailMessage1 As CleverComponents.InetSuite.MailMessage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnReceive = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.edtAttachment = New System.Windows.Forms.TextBox()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.memBody = New System.Windows.Forms.TextBox()
        Me.edtTo = New System.Windows.Forms.TextBox()
        Me.edtFrom = New System.Windows.Forms.TextBox()
        Me.edtPassword = New System.Windows.Forms.TextBox()
        Me.edtUser = New System.Windows.Forms.TextBox()
        Me.edtServer = New System.Windows.Forms.TextBox()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Smtp1 = New CleverComponents.InetSuite.Smtp()
        Me.Pop31 = New CleverComponents.InetSuite.Pop3()
        Me.MailMessage1 = New CleverComponents.InetSuite.MailMessage()
        CType(Me.Smtp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pop31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'progressBar1
        '
        Me.progressBar1.Location = New System.Drawing.Point(64, 295)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(288, 16)
        Me.progressBar1.TabIndex = 39
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(272, 263)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 38
        Me.btnStop.Text = "Stop"
        '
        'btnReceive
        '
        Me.btnReceive.Location = New System.Drawing.Point(176, 263)
        Me.btnReceive.Name = "btnReceive"
        Me.btnReceive.Size = New System.Drawing.Size(75, 23)
        Me.btnReceive.TabIndex = 37
        Me.btnReceive.Text = "Receive"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(80, 263)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 36
        Me.btnSend.Text = "Send"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(320, 231)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(32, 23)
        Me.btnBrowse.TabIndex = 35
        Me.btnBrowse.Text = "..."
        '
        'edtAttachment
        '
        Me.edtAttachment.Location = New System.Drawing.Point(80, 231)
        Me.edtAttachment.Name = "edtAttachment"
        Me.edtAttachment.Size = New System.Drawing.Size(232, 20)
        Me.edtAttachment.TabIndex = 34
        '
        'memBody
        '
        Me.memBody.Location = New System.Drawing.Point(80, 135)
        Me.memBody.Multiline = True
        Me.memBody.Name = "memBody"
        Me.memBody.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memBody.Size = New System.Drawing.Size(272, 88)
        Me.memBody.TabIndex = 33
        Me.memBody.Text = "Message text follows here"
        '
        'edtTo
        '
        Me.edtTo.Location = New System.Drawing.Point(80, 111)
        Me.edtTo.Name = "edtTo"
        Me.edtTo.Size = New System.Drawing.Size(272, 20)
        Me.edtTo.TabIndex = 32
        Me.edtTo.Text = "CleverTester@company.mail"
        '
        'edtFrom
        '
        Me.edtFrom.Location = New System.Drawing.Point(80, 87)
        Me.edtFrom.Name = "edtFrom"
        Me.edtFrom.Size = New System.Drawing.Size(272, 20)
        Me.edtFrom.TabIndex = 31
        Me.edtFrom.Text = "CleverTester@company.mail"
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(80, 63)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtPassword.Size = New System.Drawing.Size(120, 20)
        Me.edtPassword.TabIndex = 30
        Me.edtPassword.Text = "clevertester"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(80, 39)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(120, 20)
        Me.edtUser.TabIndex = 29
        Me.edtUser.Text = "CleverTester"
        '
        'edtServer
        '
        Me.edtServer.Location = New System.Drawing.Point(80, 15)
        Me.edtServer.Name = "edtServer"
        Me.edtServer.Size = New System.Drawing.Size(272, 20)
        Me.edtServer.TabIndex = 28
        Me.edtServer.Text = "localhost"
        '
        'lblProgress
        '
        Me.lblProgress.Location = New System.Drawing.Point(16, 295)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(48, 16)
        Me.lblProgress.TabIndex = 27
        Me.lblProgress.Text = "%"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(16, 223)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(64, 23)
        Me.label7.TabIndex = 26
        Me.label7.Text = "Attachment"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(16, 135)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(56, 16)
        Me.label6.TabIndex = 25
        Me.label6.Text = "Message"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(16, 111)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(48, 16)
        Me.label5.TabIndex = 24
        Me.label5.Text = "To"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 87)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(64, 16)
        Me.label4.TabIndex = 23
        Me.label4.Text = "From"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 63)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 16)
        Me.label3.TabIndex = 22
        Me.label3.Text = "Password"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 39)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 16)
        Me.label2.TabIndex = 21
        Me.label2.Text = "User"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(64, 16)
        Me.label1.TabIndex = 20
        Me.label1.Text = "Server"
        '
        'MailMessage1
        '
        Me.MailMessage1.Date = New Date(2006, 5, 8, 15, 25, 22, 640)
        Me.MailMessage1.From.Email = ""
        Me.MailMessage1.From.Name = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(368, 326)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnReceive)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.edtAttachment)
        Me.Controls.Add(Me.memBody)
        Me.Controls.Add(Me.edtTo)
        Me.Controls.Add(Me.edtFrom)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.edtUser)
        Me.Controls.Add(Me.edtServer)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.progressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Smtp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pop31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnSend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If Smtp1.Active Or Pop31.Active Then
            MessageBox.Show("Message sending / retrieving is in progress")
            Return
        End If

        If StringUtils.IsEmpty(edtAttachment.Text) Then
            MailMessage1.BuildMessage(memBody.Text, "")
        Else
            MailMessage1.BuildMessage(memBody.Text, StringUtils.GetStringArray(edtAttachment.Text))
        End If

        MailMessage1.Subject = "Message Subject"
        MailMessage1.From.FullAddress = edtFrom.Text
        MailMessage1.ToList.EmailAddresses = edtTo.Text

        progressBar1.Value = 0
        lblProgress.Text = "%"

        Smtp1.Server = edtServer.Text
        Smtp1.UserName = edtUser.Text
        Smtp1.Password = edtPassword.Text

        Try
            Smtp1.Open()
            Smtp1.Send(MailMessage1)
            Smtp1.Close()

            lblProgress.Text = "100 %"

            MessageBox.Show("Done")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Smtp1.Close()
        End Try
    End Sub 'btnSend_Click


    Private Sub btnReceive_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReceive.Click
        If Smtp1.Active Or Pop31.Active Then
            MessageBox.Show("Message sending / retrieving is in progress")
            Return
        End If

        progressBar1.Value = 0
        lblProgress.Text = "%"

        Pop31.Server = edtServer.Text
        Pop31.UserName = edtUser.Text
        Pop31.Password = edtPassword.Text

        Try
            Pop31.Open()

            If Pop31.MessageCount = 0 Then
                MessageBox.Show("There are no messages in the mailbox")
                Pop31.Close()
                Return
            End If

            Pop31.Retrieve(1, MailMessage1)
            edtFrom.Text = MailMessage1.From.FullAddress
            edtTo.Text = MailMessage1.ToList.EmailAddresses
            memBody.Lines = MailMessage1.MessageText

            Pop31.Close()

            lblProgress.Text = "100 %"
            MessageBox.Show(String.Format("The first message was received. Total messages: {0}", Pop31.MessageCount))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Pop31.Close()
        End Try
    End Sub 'btnReceive_Click


    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Smtp1.Close()
        Pop31.Close()
    End Sub 'btnStop_Click


    Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            edtAttachment.Text = openFileDialog1.FileName
        End If
    End Sub 'btnBrowse_Click


    Private Sub Pop31_Progress(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.ProgressEventArgs) Handles Pop31.Progress
        If e.TotalBytes < e.BytesProceed Then
            Return
        End If
        progressBar1.Maximum = e.TotalBytes
        progressBar1.Value = e.BytesProceed
        Dim d As Decimal = System.Math.Round(CDec(progressBar1.Value * 100 / progressBar1.Maximum))
        lblProgress.Text = String.Format("{0} %", d.ToString())
        Application.DoEvents()
    End Sub

    Private Sub Smtp1_Progress(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.ProgressEventArgs) Handles Smtp1.Progress
        If e.TotalBytes < e.BytesProceed Then
            Return
        End If
        progressBar1.Maximum = e.TotalBytes
        progressBar1.Value = e.BytesProceed
        Dim d As Decimal = System.Math.Round(CDec(progressBar1.Value * 100 / progressBar1.Maximum))
        lblProgress.Text = String.Format("{0} %", d.ToString())
        Application.DoEvents()
    End Sub

    Private Sub MailMessage1_SaveAttachment(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.GetBodyStreamEventArgs) Handles MailMessage1.SaveAttachment
        edtAttachment.Text = e.Body.FileName
    End Sub
End Class
