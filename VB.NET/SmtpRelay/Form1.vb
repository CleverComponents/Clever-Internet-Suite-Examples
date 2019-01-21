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
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents memText As System.Windows.Forms.TextBox
    Friend WithEvents edtSubject As System.Windows.Forms.TextBox
    Friend WithEvents edtRecipient As System.Windows.Forms.TextBox
    Friend WithEvents edtSender As System.Windows.Forms.TextBox
    Friend WithEvents edtDNSTimeOut As System.Windows.Forms.TextBox
    Friend WithEvents edtDNS As System.Windows.Forms.TextBox
    Friend WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents SmtpRelay1 As CleverComponents.InetSuite.SmtpRelay
    Friend WithEvents MailMessage1 As CleverComponents.InetSuite.MailMessage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnSend = New System.Windows.Forms.Button
        Me.memText = New System.Windows.Forms.TextBox
        Me.edtSubject = New System.Windows.Forms.TextBox
        Me.edtRecipient = New System.Windows.Forms.TextBox
        Me.edtSender = New System.Windows.Forms.TextBox
        Me.edtDNSTimeOut = New System.Windows.Forms.TextBox
        Me.edtDNS = New System.Windows.Forms.TextBox
        Me.label9 = New System.Windows.Forms.Label
        Me.label8 = New System.Windows.Forms.Label
        Me.label7 = New System.Windows.Forms.Label
        Me.label6 = New System.Windows.Forms.Label
        Me.label5 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.SmtpRelay1 = New CleverComponents.InetSuite.SmtpRelay
        Me.MailMessage1 = New CleverComponents.InetSuite.MailMessage
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(136, 376)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(136, 23)
        Me.btnSend.TabIndex = 31
        Me.btnSend.Text = "Send Mail"
        '
        'memText
        '
        Me.memText.Location = New System.Drawing.Point(16, 240)
        Me.memText.Multiline = True
        Me.memText.Name = "memText"
        Me.memText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memText.Size = New System.Drawing.Size(384, 128)
        Me.memText.TabIndex = 30
        Me.memText.Text = "This is a test message"
        '
        'edtSubject
        '
        Me.edtSubject.Location = New System.Drawing.Point(120, 200)
        Me.edtSubject.Name = "edtSubject"
        Me.edtSubject.Size = New System.Drawing.Size(280, 20)
        Me.edtSubject.TabIndex = 29
        Me.edtSubject.Text = "smtp relaying test"
        '
        'edtRecipient
        '
        Me.edtRecipient.Location = New System.Drawing.Point(120, 176)
        Me.edtRecipient.Name = "edtRecipient"
        Me.edtRecipient.Size = New System.Drawing.Size(280, 20)
        Me.edtRecipient.TabIndex = 28
        Me.edtRecipient.Text = "john@domain.com,alex@company.mail"
        '
        'edtSender
        '
        Me.edtSender.Location = New System.Drawing.Point(120, 152)
        Me.edtSender.Name = "edtSender"
        Me.edtSender.Size = New System.Drawing.Size(280, 20)
        Me.edtSender.TabIndex = 27
        Me.edtSender.Text = "CleverTester@company.mail"
        '
        'edtDNSTimeOut
        '
        Me.edtDNSTimeOut.Location = New System.Drawing.Point(344, 128)
        Me.edtDNSTimeOut.Name = "edtDNSTimeOut"
        Me.edtDNSTimeOut.Size = New System.Drawing.Size(56, 20)
        Me.edtDNSTimeOut.TabIndex = 26
        Me.edtDNSTimeOut.Text = "5"
        '
        'edtDNS
        '
        Me.edtDNS.Location = New System.Drawing.Point(120, 128)
        Me.edtDNS.Name = "edtDNS"
        Me.edtDNS.TabIndex = 25
        Me.edtDNS.Text = "192.168.0.1"
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(248, 128)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(88, 16)
        Me.label9.TabIndex = 24
        Me.label9.Text = "DNS TimeOut, s"
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(16, 224)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(80, 16)
        Me.label8.TabIndex = 23
        Me.label8.Text = "Message text"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(16, 200)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(104, 16)
        Me.label7.TabIndex = 22
        Me.label7.Text = "Subject of message"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(16, 176)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(64, 16)
        Me.label6.TabIndex = 21
        Me.label6.Text = "Recipinets"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(16, 152)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(72, 16)
        Me.label5.TabIndex = 20
        Me.label5.Text = "Sender email"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 128)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(80, 16)
        Me.label4.TabIndex = 19
        Me.label4.Text = "DNS server IP"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 80)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(392, 32)
        Me.label3.TabIndex = 18
        Me.label3.Text = "Please note ! Most SMTP servers require that the sender PC must be registered in " & _
        "DNS. Otherwise, relaying will be denied to such SMTP servers."
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(400, 32)
        Me.label2.TabIndex = 17
        Me.label2.Text = "Please specify the DNS server IP which will be used for resolving the SMTP server" & _
        " address of the recipient"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(384, 16)
        Me.label1.TabIndex = 16
        Me.label1.Text = "This demo creates e-mail and sends it directly to the recipient's server."
        '
        'SmtpRelay1
        '
        Me.SmtpRelay1.Port = 25
        '
        'MailMessage1
        '
        Me.MailMessage1.Date = New Date(2006, 5, 8, 16, 13, 25, 859)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 414)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.memText)
        Me.Controls.Add(Me.edtSubject)
        Me.Controls.Add(Me.edtRecipient)
        Me.Controls.Add(Me.edtSender)
        Me.Controls.Add(Me.edtDNSTimeOut)
        Me.Controls.Add(Me.edtDNS)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "SMTP Relay demo"
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnSend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSend.Click
        btnSend.Enabled = False
        Try
            MailMessage1.BuildMessage(memText.Text, "")
            MailMessage1.From.FullAddress = edtSender.Text
            MailMessage1.ToList.EmailAddresses = edtRecipient.Text
            MailMessage1.Subject = edtSubject.Text

            SmtpRelay1.DnsServer = edtDNS.Text
            SmtpRelay1.TimeOut = Convert.ToInt32(edtDNSTimeOut.Text) * 1000
            SmtpRelay1.Send(MailMessage1)
            ShowResults()
        Finally
            btnSend.Enabled = True
        End Try
    End Sub 'btnSend_Click


    Private Sub ShowResults()
        Dim dlg As New RelayStatusForm

        Dim item As SmtpRelayStatus
        For Each item In SmtpRelay1.StatusList
            dlg.textBox1.Text += "======  " + item.Domain + "  ======" + ControlChars.Cr + ControlChars.Lf
            dlg.textBox1.Text += "Mail server: " + item.MailServer + ControlChars.Cr + ControlChars.Lf

            If item.IsSent Then
                dlg.textBox1.Text += "Status: Sent" + ControlChars.Cr + ControlChars.Lf
            Else
                dlg.textBox1.Text += "Status: Not Sent" + ControlChars.Cr + ControlChars.Lf
            End If

            dlg.textBox1.Text += "Server response: " + item.ResponseText + ControlChars.Cr + ControlChars.Lf
            dlg.textBox1.Text += "Error: " + item.ErrorText + ControlChars.Cr + ControlChars.Lf + ControlChars.Cr + ControlChars.Lf
        Next item

        dlg.ShowDialog()
    End Sub 'ShowResults

End Class
