<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCheckMail = New System.Windows.Forms.Button()
        Me.edtPassword = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.edtUser = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.edtPort = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.edtServer = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.lbMessages = New System.Windows.Forms.ListBox()
        Me.mailMessage1 = New CleverComponents.InetSuite.MailMessage()
        Me.dkim1 = New CleverComponents.InetSuite.Dkim()
        Me.pop3 = New CleverComponents.InetSuite.Pop3()
        CType(Me.mailMessage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pop3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCheckMail
        '
        Me.btnCheckMail.Location = New System.Drawing.Point(91, 82)
        Me.btnCheckMail.Name = "btnCheckMail"
        Me.btnCheckMail.Size = New System.Drawing.Size(124, 23)
        Me.btnCheckMail.TabIndex = 40
        Me.btnCheckMail.Text = "Check Mail"
        Me.btnCheckMail.UseVisualStyleBackColor = True
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(483, 37)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtPassword.Size = New System.Drawing.Size(111, 20)
        Me.edtPassword.TabIndex = 39
        Me.edtPassword.Text = "clevertester"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(424, 40)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(53, 13)
        Me.label4.TabIndex = 38
        Me.label4.Text = "Password"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(235, 37)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(161, 20)
        Me.edtUser.TabIndex = 37
        Me.edtUser.Text = "CleverTester"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(186, 40)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(29, 13)
        Me.label3.TabIndex = 36
        Me.label3.Text = "User"
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(91, 37)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(55, 20)
        Me.edtPort.TabIndex = 35
        Me.edtPort.Text = "110"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(14, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(26, 13)
        Me.label2.TabIndex = 34
        Me.label2.Text = "Port"
        '
        'edtServer
        '
        Me.edtServer.Location = New System.Drawing.Point(91, 11)
        Me.edtServer.Name = "edtServer"
        Me.edtServer.Size = New System.Drawing.Size(503, 20)
        Me.edtServer.TabIndex = 33
        Me.edtServer.Text = "localhost"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(14, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 13)
        Me.label1.TabIndex = 32
        Me.label1.Text = "Server"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(14, 124)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(55, 13)
        Me.label5.TabIndex = 42
        Me.label5.Text = "Messages"
        '
        'lbMessages
        '
        Me.lbMessages.FormattingEnabled = True
        Me.lbMessages.Location = New System.Drawing.Point(17, 150)
        Me.lbMessages.Name = "lbMessages"
        Me.lbMessages.Size = New System.Drawing.Size(577, 186)
        Me.lbMessages.TabIndex = 41
        '
        'mailMessage1
        '
        Me.mailMessage1.Date = New Date(2017, 9, 3, 21, 13, 40, 837)
        Me.mailMessage1.Dkim = Me.dkim1
        Me.mailMessage1.From.Email = ""
        Me.mailMessage1.From.Name = ""
        '
        'dkim1
        '
        Me.dkim1.SignatureExpiration = New Date(CType(0, Long))
        Me.dkim1.SignatureTimestamp = New Date(CType(0, Long))
        Me.dkim1.SignedHeaderFields = New String() {"Date", "From", "To", "Subject", "MIME-Version", "Content-Type"}
        '
        'pop3
        '
        Me.pop3.MailMessage = Me.mailMessage1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 346)
        Me.Controls.Add(Me.btnCheckMail)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.edtUser)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.edtPort)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.edtServer)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.lbMessages)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send E-mail with DKIM signature - Sample"
        CType(Me.mailMessage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pop3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnCheckMail As Button
    Private WithEvents edtPassword As TextBox
    Private WithEvents label4 As Label
    Private WithEvents edtUser As TextBox
    Private WithEvents label3 As Label
    Private WithEvents edtPort As TextBox
    Private WithEvents label2 As Label
    Private WithEvents edtServer As TextBox
    Private WithEvents label1 As Label
    Private WithEvents label5 As Label
    Private WithEvents lbMessages As ListBox
    Private WithEvents mailMessage1 As CleverComponents.InetSuite.MailMessage
    Private WithEvents dkim1 As CleverComponents.InetSuite.Dkim
    Private WithEvents pop3 As CleverComponents.InetSuite.Pop3
End Class
