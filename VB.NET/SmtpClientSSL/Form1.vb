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
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents edtTo As System.Windows.Forms.TextBox
    Friend WithEvents memBody As System.Windows.Forms.TextBox
    Friend WithEvents edtSubject As System.Windows.Forms.TextBox
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents edtFrom As System.Windows.Forms.TextBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents cbUseTLS As System.Windows.Forms.CheckBox
    Friend WithEvents edtPort As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents edtPassword As System.Windows.Forms.TextBox
    Friend WithEvents edtUser As System.Windows.Forms.TextBox
    Friend WithEvents edtServer As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Smtp1 As CleverComponents.InetSuite.Smtp
    Friend WithEvents MailMessage1 As CleverComponents.InetSuite.MailMessage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnSend = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.edtTo = New System.Windows.Forms.TextBox()
        Me.memBody = New System.Windows.Forms.TextBox()
        Me.edtSubject = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.edtFrom = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.cbUseTLS = New System.Windows.Forms.CheckBox()
        Me.edtPort = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.edtPassword = New System.Windows.Forms.TextBox()
        Me.edtUser = New System.Windows.Forms.TextBox()
        Me.edtServer = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Smtp1 = New CleverComponents.InetSuite.Smtp()
        Me.MailMessage1 = New CleverComponents.InetSuite.MailMessage()
        CType(Me.Smtp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(273, 313)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(144, 23)
        Me.btnSend.TabIndex = 51
        Me.btnSend.Text = "Send"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(17, 161)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(48, 23)
        Me.label5.TabIndex = 58
        Me.label5.Text = "Subject"
        '
        'edtTo
        '
        Me.edtTo.Location = New System.Drawing.Point(81, 137)
        Me.edtTo.Name = "edtTo"
        Me.edtTo.Size = New System.Drawing.Size(336, 20)
        Me.edtTo.TabIndex = 48
        Me.edtTo.Text = "johndoe@domain.com"
        '
        'memBody
        '
        Me.memBody.Location = New System.Drawing.Point(17, 185)
        Me.memBody.Multiline = True
        Me.memBody.Name = "memBody"
        Me.memBody.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memBody.Size = New System.Drawing.Size(400, 112)
        Me.memBody.TabIndex = 50
        Me.memBody.Text = resources.GetString("memBody.Text")
        '
        'edtSubject
        '
        Me.edtSubject.Location = New System.Drawing.Point(81, 161)
        Me.edtSubject.Name = "edtSubject"
        Me.edtSubject.Size = New System.Drawing.Size(336, 20)
        Me.edtSubject.TabIndex = 49
        Me.edtSubject.Text = "ABC Company: New Catalog"
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(17, 137)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(48, 23)
        Me.label8.TabIndex = 57
        Me.label8.Text = "To"
        '
        'edtFrom
        '
        Me.edtFrom.Location = New System.Drawing.Point(81, 113)
        Me.edtFrom.Name = "edtFrom"
        Me.edtFrom.Size = New System.Drawing.Size(336, 20)
        Me.edtFrom.TabIndex = 47
        Me.edtFrom.Text = "CleverTester@company.mail"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(17, 113)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(48, 23)
        Me.label7.TabIndex = 56
        Me.label7.Text = "From"
        '
        'cbUseTLS
        '
        Me.cbUseTLS.Checked = True
        Me.cbUseTLS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbUseTLS.Location = New System.Drawing.Point(313, 33)
        Me.cbUseTLS.Name = "cbUseTLS"
        Me.cbUseTLS.Size = New System.Drawing.Size(104, 24)
        Me.cbUseTLS.TabIndex = 44
        Me.cbUseTLS.Text = "Use SSL / TLS"
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(81, 33)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(48, 20)
        Me.edtPort.TabIndex = 43
        Me.edtPort.Text = "25"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(17, 33)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(48, 16)
        Me.label4.TabIndex = 55
        Me.label4.Text = "Port"
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(297, 65)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtPassword.Size = New System.Drawing.Size(120, 20)
        Me.edtPassword.TabIndex = 46
        Me.edtPassword.Text = "clevertester"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(81, 65)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(128, 20)
        Me.edtUser.TabIndex = 45
        Me.edtUser.Text = "CleverTester"
        '
        'edtServer
        '
        Me.edtServer.Location = New System.Drawing.Point(81, 9)
        Me.edtServer.Name = "edtServer"
        Me.edtServer.Size = New System.Drawing.Size(336, 20)
        Me.edtServer.TabIndex = 42
        Me.edtServer.Text = "localhost"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(225, 65)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 16)
        Me.label3.TabIndex = 54
        Me.label3.Text = "Password"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(17, 65)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 16)
        Me.label2.TabIndex = 53
        Me.label2.Text = "User"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(17, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 16)
        Me.label1.TabIndex = 52
        Me.label1.Text = "Server"
        '
        'Smtp1
        '
        '
        'MailMessage1
        '
        Me.MailMessage1.Date = New Date(2007, 1, 13, 17, 21, 46, 952)
        Me.MailMessage1.From.Email = ""
        Me.MailMessage1.From.Name = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(434, 344)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.edtTo)
        Me.Controls.Add(Me.memBody)
        Me.Controls.Add(Me.edtSubject)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.edtFrom)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.cbUseTLS)
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
        Me.Text = "SMTP Client with SSL / TLS support"
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

        Smtp1.Server = edtServer.Text
        Smtp1.Port = Convert.ToInt32(edtPort.Text)

        Smtp1.UserName = edtUser.Text
        Smtp1.Password = edtPassword.Text
        If cbUseTLS.Checked Then
            Smtp1.UseTls = ClientTlsMode.Automatic
        Else
            Smtp1.UseTls = ClientTlsMode.None
        End If

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

    Private Sub Smtp1_VerifyServer(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.VerifyPeerEventArgs) Handles Smtp1.VerifyServer
        If (Not e.Verified) Then
            If (MessageBox.Show(e.StatusText + ControlChars.Cr + ControlChars.Lf + _
            "Do you wish to proceed ?", "Verify certificate", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                e.Verified = True
            End If
        End If
    End Sub
End Class
