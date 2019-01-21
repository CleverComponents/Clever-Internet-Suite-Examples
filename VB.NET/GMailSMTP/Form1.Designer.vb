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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnSend = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.edtTo = New System.Windows.Forms.TextBox()
        Me.memBody = New System.Windows.Forms.TextBox()
        Me.edtSubject = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.edtFrom = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.smtp1 = New CleverComponents.InetSuite.Smtp()
        Me.mailMessage1 = New CleverComponents.InetSuite.MailMessage()
        Me.oAuth1 = New CleverComponents.InetSuite.OAuth()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.smtp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mailMessage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(477, 363)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(129, 28)
        Me.btnSend.TabIndex = 47
        Me.btnSend.Text = "Send"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(10, 151)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(48, 15)
        Me.label5.TabIndex = 50
        Me.label5.Text = "Subject"
        '
        'edtTo
        '
        Me.edtTo.Location = New System.Drawing.Point(64, 120)
        Me.edtTo.Name = "edtTo"
        Me.edtTo.Size = New System.Drawing.Size(542, 20)
        Me.edtTo.TabIndex = 44
        Me.edtTo.Text = "anderson@domain.com"
        '
        'memBody
        '
        Me.memBody.Location = New System.Drawing.Point(13, 178)
        Me.memBody.Multiline = True
        Me.memBody.Name = "memBody"
        Me.memBody.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memBody.Size = New System.Drawing.Size(593, 176)
        Me.memBody.TabIndex = 46
        Me.memBody.Text = resources.GetString("memBody.Text")
        '
        'edtSubject
        '
        Me.edtSubject.Location = New System.Drawing.Point(64, 148)
        Me.edtSubject.Name = "edtSubject"
        Me.edtSubject.Size = New System.Drawing.Size(542, 20)
        Me.edtSubject.TabIndex = 45
        Me.edtSubject.Text = "ABC Company: New Catalog"
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(10, 123)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(48, 13)
        Me.label8.TabIndex = 49
        Me.label8.Text = "To"
        '
        'edtFrom
        '
        Me.edtFrom.Location = New System.Drawing.Point(64, 92)
        Me.edtFrom.Name = "edtFrom"
        Me.edtFrom.Size = New System.Drawing.Size(542, 20)
        Me.edtFrom.TabIndex = 43
        Me.edtFrom.Text = "user@gmail.com"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(10, 95)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(48, 16)
        Me.label7.TabIndex = 48
        Me.label7.Text = "From"
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox1.Image = Global.GMailSMTP.My.Resources.Resources.background_net
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(618, 78)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox1.TabIndex = 51
        Me.pictureBox1.TabStop = False
        '
        'mailMessage1
        '
        Me.mailMessage1.Date = New Date(2007, 1, 10, 23, 13, 23, 984)
        Me.mailMessage1.From.Email = ""
        Me.mailMessage1.From.Name = ""
        '
        'oAuth1
        '
        Me.oAuth1.AuthUrl = Nothing
        Me.oAuth1.ClientID = Nothing
        Me.oAuth1.ClientSecret = Nothing
        Me.oAuth1.Password = Nothing
        Me.oAuth1.RedirectUrl = Nothing
        Me.oAuth1.Scope = Nothing
        Me.oAuth1.State = Nothing
        Me.oAuth1.TokenUrl = Nothing
        Me.oAuth1.UserName = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 394)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.edtTo)
        Me.Controls.Add(Me.memBody)
        Me.Controls.Add(Me.edtSubject)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.edtFrom)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GMAIL SMTP client with OAuth - Sample"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.smtp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mailMessage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnSend As Button
    Private WithEvents label5 As Label
    Private WithEvents edtTo As TextBox
    Private WithEvents memBody As TextBox
    Private WithEvents edtSubject As TextBox
    Private WithEvents label8 As Label
    Private WithEvents edtFrom As TextBox
    Private WithEvents label7 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents smtp1 As CleverComponents.InetSuite.Smtp
    Private WithEvents mailMessage1 As CleverComponents.InetSuite.MailMessage
    Private WithEvents oAuth1 As CleverComponents.InetSuite.OAuth
End Class
