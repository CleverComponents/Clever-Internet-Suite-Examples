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
    Friend WithEvents Smtp1 As CleverComponents.InetSuite.Smtp
    Private WithEvents edtProxyPort As TextBox
    Private WithEvents label6 As Label
    Private WithEvents edtProxyServer As TextBox
    Private WithEvents label9 As Label
    Private WithEvents btnSend As Button
    Private WithEvents label5 As Label
    Private WithEvents edtTo As TextBox
    Private WithEvents memBody As TextBox
    Private WithEvents edtSubject As TextBox
    Private WithEvents label8 As Label
    Private WithEvents edtFrom As TextBox
    Private WithEvents label7 As Label
    Private WithEvents edtPort As TextBox
    Private WithEvents label4 As Label
    Private WithEvents edtPassword As TextBox
    Private WithEvents edtUser As TextBox
    Private WithEvents edtServer As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Friend WithEvents HttpProxy1 As HttpProxy
    Friend WithEvents MailMessage1 As CleverComponents.InetSuite.MailMessage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Smtp1 = New CleverComponents.InetSuite.Smtp()
        Me.MailMessage1 = New CleverComponents.InetSuite.MailMessage()
        Me.edtProxyPort = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.edtProxyServer = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.edtTo = New System.Windows.Forms.TextBox()
        Me.memBody = New System.Windows.Forms.TextBox()
        Me.edtSubject = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.edtFrom = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.edtPort = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.edtPassword = New System.Windows.Forms.TextBox()
        Me.edtUser = New System.Windows.Forms.TextBox()
        Me.edtServer = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.HttpProxy1 = New CleverComponents.InetSuite.HttpProxy()
        CType(Me.Smtp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MailMessage1
        '
        Me.MailMessage1.Date = New Date(2007, 1, 13, 17, 21, 46, 952)
        Me.MailMessage1.From.Email = ""
        Me.MailMessage1.From.Name = ""
        '
        'edtProxyPort
        '
        Me.edtProxyPort.Location = New System.Drawing.Point(389, 36)
        Me.edtProxyPort.Name = "edtProxyPort"
        Me.edtProxyPort.Size = New System.Drawing.Size(48, 20)
        Me.edtProxyPort.TabIndex = 63
        Me.edtProxyPort.Text = "8080"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(318, 39)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(48, 16)
        Me.label6.TabIndex = 65
        Me.label6.Text = "Port"
        '
        'edtProxyServer
        '
        Me.edtProxyServer.Location = New System.Drawing.Point(389, 10)
        Me.edtProxyServer.Name = "edtProxyServer"
        Me.edtProxyServer.Size = New System.Drawing.Size(209, 20)
        Me.edtProxyServer.TabIndex = 62
        Me.edtProxyServer.Text = "proxy"
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(318, 13)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(63, 16)
        Me.label9.TabIndex = 64
        Me.label9.Text = "Proxy Host"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(481, 389)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(117, 23)
        Me.btnSend.TabIndex = 54
        Me.btnSend.Text = "Send"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(11, 185)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(48, 15)
        Me.label5.TabIndex = 61
        Me.label5.Text = "Subject"
        '
        'edtTo
        '
        Me.edtTo.Location = New System.Drawing.Point(82, 156)
        Me.edtTo.Name = "edtTo"
        Me.edtTo.Size = New System.Drawing.Size(516, 20)
        Me.edtTo.TabIndex = 51
        Me.edtTo.Text = "johndoe@domain.com"
        '
        'memBody
        '
        Me.memBody.Location = New System.Drawing.Point(14, 208)
        Me.memBody.Multiline = True
        Me.memBody.Name = "memBody"
        Me.memBody.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memBody.Size = New System.Drawing.Size(584, 165)
        Me.memBody.TabIndex = 53
        Me.memBody.Text = resources.GetString("memBody.Text")
        '
        'edtSubject
        '
        Me.edtSubject.Location = New System.Drawing.Point(82, 182)
        Me.edtSubject.Name = "edtSubject"
        Me.edtSubject.Size = New System.Drawing.Size(516, 20)
        Me.edtSubject.TabIndex = 52
        Me.edtSubject.Text = "ABC Company: New Catalog"
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(11, 159)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(48, 13)
        Me.label8.TabIndex = 60
        Me.label8.Text = "To"
        '
        'edtFrom
        '
        Me.edtFrom.Location = New System.Drawing.Point(82, 130)
        Me.edtFrom.Name = "edtFrom"
        Me.edtFrom.Size = New System.Drawing.Size(516, 20)
        Me.edtFrom.TabIndex = 50
        Me.edtFrom.Text = "CleverTester@company.mail"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(11, 133)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(48, 16)
        Me.label7.TabIndex = 59
        Me.label7.Text = "From"
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(82, 36)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(48, 20)
        Me.edtPort.TabIndex = 47
        Me.edtPort.Text = "25"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(11, 39)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(48, 16)
        Me.label4.TabIndex = 58
        Me.label4.Text = "Port"
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(82, 88)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtPassword.Size = New System.Drawing.Size(182, 20)
        Me.edtPassword.TabIndex = 49
        Me.edtPassword.Text = "clevertester"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(82, 62)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(182, 20)
        Me.edtUser.TabIndex = 48
        Me.edtUser.Text = "CleverTester"
        '
        'edtServer
        '
        Me.edtServer.Location = New System.Drawing.Point(82, 10)
        Me.edtServer.Name = "edtServer"
        Me.edtServer.Size = New System.Drawing.Size(209, 20)
        Me.edtServer.TabIndex = 46
        Me.edtServer.Text = "smpt.example.com"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(11, 91)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(54, 16)
        Me.label3.TabIndex = 57
        Me.label3.Text = "Password"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(11, 65)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 16)
        Me.label2.TabIndex = 56
        Me.label2.Text = "User"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(11, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(63, 16)
        Me.label1.TabIndex = 55
        Me.label1.Text = "SMTP Host"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(609, 422)
        Me.Controls.Add(Me.edtProxyPort)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.edtProxyServer)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.edtTo)
        Me.Controls.Add(Me.memBody)
        Me.Controls.Add(Me.edtSubject)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.edtFrom)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.edtPort)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.edtUser)
        Me.Controls.Add(Me.edtServer)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "SMTP Client over HTTP Connect Proxy"
        CType(Me.Smtp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If Smtp1.Active Then
            Exit Sub
        End If

        HttpProxy1.Server = edtProxyServer.Text
        HttpProxy1.Port = Convert.ToInt32(edtProxyPort.Text)

        Smtp1.Proxy = HttpProxy1

        Smtp1.Server = edtServer.Text
        Smtp1.Port = Convert.ToInt32(edtPort.Text)
        Smtp1.UserName = edtUser.Text
        Smtp1.Password = edtPassword.Text

        Smtp1.Open()
        Try
            MailMessage1.BuildMessage(memBody.Text, "")
            MailMessage1.From.FullAddress = edtFrom.Text
            MailMessage1.ToList.EmailAddresses = edtTo.Text
            MailMessage1.Subject = edtSubject.Text

            Smtp1.Send(MailMessage1)

            MessageBox.Show("The message was sent successfully.")
        Finally
            Smtp1.Close()
        End Try
    End Sub

End Class
