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
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.mmBody = New System.Windows.Forms.TextBox()
        Me.edtSubject = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.edtTo = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.edtFrom = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.edtDnsTxtValue = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.edtDnsTxtName = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.mmPrivateKey = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.edtSignFields = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.edtDkimSelector = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.edtDkimDomain = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.edtPassword = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.edtUser = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.edtPort = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.edtServer = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.smtp1 = New CleverComponents.InetSuite.Smtp()
        Me.mailMessage1 = New CleverComponents.InetSuite.MailMessage()
        Me.dkim1 = New CleverComponents.InetSuite.Dkim()
        CType(Me.smtp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mailMessage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(514, 462)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 59
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'mmBody
        '
        Me.mmBody.Location = New System.Drawing.Point(12, 391)
        Me.mmBody.Multiline = True
        Me.mmBody.Name = "mmBody"
        Me.mmBody.Size = New System.Drawing.Size(577, 65)
        Me.mmBody.TabIndex = 58
        Me.mmBody.Text = "This is a sample email with DKIM signature."
        '
        'edtSubject
        '
        Me.edtSubject.Location = New System.Drawing.Point(86, 365)
        Me.edtSubject.Name = "edtSubject"
        Me.edtSubject.Size = New System.Drawing.Size(503, 20)
        Me.edtSubject.TabIndex = 57
        Me.edtSubject.Text = "Sample message with DKIM signature"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(9, 368)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(43, 13)
        Me.label13.TabIndex = 56
        Me.label13.Text = "Subject"
        '
        'edtTo
        '
        Me.edtTo.Location = New System.Drawing.Point(86, 339)
        Me.edtTo.Name = "edtTo"
        Me.edtTo.Size = New System.Drawing.Size(503, 20)
        Me.edtTo.TabIndex = 55
        Me.edtTo.Text = "johndoe@domain.com"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(9, 342)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(20, 13)
        Me.label12.TabIndex = 54
        Me.label12.Text = "To"
        '
        'edtFrom
        '
        Me.edtFrom.Location = New System.Drawing.Point(86, 313)
        Me.edtFrom.Name = "edtFrom"
        Me.edtFrom.Size = New System.Drawing.Size(503, 20)
        Me.edtFrom.TabIndex = 53
        Me.edtFrom.Text = "steve@example.com"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(9, 316)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(30, 13)
        Me.label11.TabIndex = 52
        Me.label11.Text = "From"
        '
        'edtDnsTxtValue
        '
        Me.edtDnsTxtValue.Location = New System.Drawing.Point(86, 273)
        Me.edtDnsTxtValue.Name = "edtDnsTxtValue"
        Me.edtDnsTxtValue.Size = New System.Drawing.Size(503, 20)
        Me.edtDnsTxtValue.TabIndex = 51
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(9, 276)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(73, 13)
        Me.label10.TabIndex = 50
        Me.label10.Text = "DNS txt value"
        '
        'edtDnsTxtName
        '
        Me.edtDnsTxtName.Location = New System.Drawing.Point(86, 247)
        Me.edtDnsTxtName.Name = "edtDnsTxtName"
        Me.edtDnsTxtName.Size = New System.Drawing.Size(503, 20)
        Me.edtDnsTxtName.TabIndex = 49
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(9, 250)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(73, 13)
        Me.label9.TabIndex = 48
        Me.label9.Text = "DNS txt name"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(167, 205)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 47
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(86, 205)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 46
        Me.btnLoad.Text = "Load..."
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'mmPrivateKey
        '
        Me.mmPrivateKey.Location = New System.Drawing.Point(86, 134)
        Me.mmPrivateKey.Multiline = True
        Me.mmPrivateKey.Name = "mmPrivateKey"
        Me.mmPrivateKey.Size = New System.Drawing.Size(503, 65)
        Me.mmPrivateKey.TabIndex = 45
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(9, 137)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(61, 13)
        Me.label8.TabIndex = 44
        Me.label8.Text = "Private Key"
        '
        'edtSignFields
        '
        Me.edtSignFields.Location = New System.Drawing.Point(86, 108)
        Me.edtSignFields.Name = "edtSignFields"
        Me.edtSignFields.Size = New System.Drawing.Size(503, 20)
        Me.edtSignFields.TabIndex = 43
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(9, 111)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(68, 13)
        Me.label7.TabIndex = 42
        Me.label7.Text = "Fields to sign"
        '
        'edtDkimSelector
        '
        Me.edtDkimSelector.Location = New System.Drawing.Point(402, 82)
        Me.edtDkimSelector.Name = "edtDkimSelector"
        Me.edtDkimSelector.Size = New System.Drawing.Size(187, 20)
        Me.edtDkimSelector.TabIndex = 41
        Me.edtDkimSelector.Text = "sample"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(325, 85)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(74, 13)
        Me.label6.TabIndex = 40
        Me.label6.Text = "DKIM selector"
        '
        'edtDkimDomain
        '
        Me.edtDkimDomain.Location = New System.Drawing.Point(86, 82)
        Me.edtDkimDomain.Name = "edtDkimDomain"
        Me.edtDkimDomain.Size = New System.Drawing.Size(187, 20)
        Me.edtDkimDomain.TabIndex = 39
        Me.edtDkimDomain.Text = "example.com"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(9, 85)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(71, 13)
        Me.label5.TabIndex = 38
        Me.label5.Text = "DKIM domain"
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(402, 36)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtPassword.Size = New System.Drawing.Size(187, 20)
        Me.edtPassword.TabIndex = 37
        Me.edtPassword.Text = "clevertester"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(325, 39)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(53, 13)
        Me.label4.TabIndex = 36
        Me.label4.Text = "Password"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(402, 10)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(187, 20)
        Me.edtUser.TabIndex = 35
        Me.edtUser.Text = "CleverTester"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(325, 13)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(29, 13)
        Me.label3.TabIndex = 34
        Me.label3.Text = "User"
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(86, 36)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(55, 20)
        Me.edtPort.TabIndex = 33
        Me.edtPort.Text = "25"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(9, 39)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(26, 13)
        Me.label2.TabIndex = 32
        Me.label2.Text = "Port"
        '
        'edtServer
        '
        Me.edtServer.Location = New System.Drawing.Point(86, 10)
        Me.edtServer.Name = "edtServer"
        Me.edtServer.Size = New System.Drawing.Size(187, 20)
        Me.edtServer.TabIndex = 31
        Me.edtServer.Text = "localhost"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(9, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 13)
        Me.label1.TabIndex = 30
        Me.label1.Text = "Server"
        '
        'mailMessage1
        '
        Me.mailMessage1.Date = New Date(2017, 9, 3, 21, 13, 40, 837)
        Me.mailMessage1.Dkim = Me.dkim1
        '
        'dkim1
        '
        Me.dkim1.SignatureExpiration = New Date(CType(0, Long))
        Me.dkim1.SignatureTimestamp = New Date(CType(0, Long))
        Me.dkim1.SignedHeaderFields = New String() {"Date", "From", "To", "Subject", "MIME-Version", "Content-Type"}
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 493)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.mmBody)
        Me.Controls.Add(Me.edtSubject)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.edtTo)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.edtFrom)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.edtDnsTxtValue)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.edtDnsTxtName)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.mmPrivateKey)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.edtSignFields)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.edtDkimSelector)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.edtDkimDomain)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.edtUser)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.edtPort)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.edtServer)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send E-mail with DKIM signature - Sample"
        CType(Me.smtp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mailMessage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents openFileDialog1 As OpenFileDialog
    Private WithEvents btnSend As Button
    Private WithEvents mmBody As TextBox
    Private WithEvents edtSubject As TextBox
    Private WithEvents label13 As Label
    Private WithEvents edtTo As TextBox
    Private WithEvents label12 As Label
    Private WithEvents edtFrom As TextBox
    Private WithEvents label11 As Label
    Private WithEvents edtDnsTxtValue As TextBox
    Private WithEvents label10 As Label
    Private WithEvents edtDnsTxtName As TextBox
    Private WithEvents label9 As Label
    Private WithEvents btnGenerate As Button
    Private WithEvents btnLoad As Button
    Private WithEvents mmPrivateKey As TextBox
    Private WithEvents label8 As Label
    Private WithEvents edtSignFields As TextBox
    Private WithEvents label7 As Label
    Private WithEvents edtDkimSelector As TextBox
    Private WithEvents label6 As Label
    Private WithEvents edtDkimDomain As TextBox
    Private WithEvents label5 As Label
    Private WithEvents edtPassword As TextBox
    Private WithEvents label4 As Label
    Private WithEvents edtUser As TextBox
    Private WithEvents label3 As Label
    Private WithEvents edtPort As TextBox
    Private WithEvents label2 As Label
    Private WithEvents edtServer As TextBox
    Private WithEvents label1 As Label
    Private WithEvents smtp1 As CleverComponents.InetSuite.Smtp
    Private WithEvents mailMessage1 As CleverComponents.InetSuite.MailMessage
    Private WithEvents dkim1 As CleverComponents.InetSuite.Dkim
End Class
