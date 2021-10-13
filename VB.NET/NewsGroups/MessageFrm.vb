Imports CleverComponents.InetSuite

Public Class MessageFrm
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
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPost As System.Windows.Forms.Button
    Friend WithEvents memText As System.Windows.Forms.TextBox
    Friend WithEvents edtSubject As System.Windows.Forms.TextBox
    Friend WithEvents edtFrom As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.memText = New System.Windows.Forms.TextBox()
        Me.edtSubject = New System.Windows.Forms.TextBox()
        Me.edtFrom = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(400, 272)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        '
        'btnPost
        '
        Me.btnPost.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnPost.Location = New System.Drawing.Point(304, 272)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(75, 23)
        Me.btnPost.TabIndex = 16
        Me.btnPost.Text = "Post"
        '
        'memText
        '
        Me.memText.Location = New System.Drawing.Point(16, 96)
        Me.memText.Multiline = True
        Me.memText.Name = "memText"
        Me.memText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memText.Size = New System.Drawing.Size(464, 168)
        Me.memText.TabIndex = 15
        Me.memText.Text = "My test newsgroup post"
        '
        'edtSubject
        '
        Me.edtSubject.Location = New System.Drawing.Point(80, 48)
        Me.edtSubject.Name = "edtSubject"
        Me.edtSubject.Size = New System.Drawing.Size(400, 20)
        Me.edtSubject.TabIndex = 14
        Me.edtSubject.Text = "Test Subject"
        '
        'edtFrom
        '
        Me.edtFrom.Location = New System.Drawing.Point(80, 16)
        Me.edtFrom.Name = "edtFrom"
        Me.edtFrom.Size = New System.Drawing.Size(400, 20)
        Me.edtFrom.TabIndex = 13
        Me.edtFrom.Text = "newsuser@company.mail"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 80)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(32, 16)
        Me.label4.TabIndex = 12
        Me.label4.Text = "Text"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 48)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 16)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Subject"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 16)
        Me.label2.TabIndex = 10
        Me.label2.Text = "From"
        '
        'MessageFrm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(498, 304)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.memText)
        Me.Controls.Add(Me.edtSubject)
        Me.Controls.Add(Me.edtFrom)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "MessageFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Message Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Shared Function PostNew(ByVal article As MailMessage) As Boolean
        Dim dlg As New MessageFrm
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            article.BuildMessage(dlg.memText.Text, "")
            article.Subject = dlg.edtSubject.Text
            article.From.FullAddress = dlg.edtFrom.Text

            Return True
        End If
        Return False
    End Function 'PostNew


    Public Shared Function ReplyTo(ByVal article As MailMessage) As Boolean
        Dim dlg As New MessageFrm
        dlg.btnPost.Text = "Reply"

        Dim txt As String = ControlChars.Cr + ControlChars.Lf + StringUtils.GetStringsAsString(article.MessageText)
        txt += txt.Replace(ControlChars.Cr + ControlChars.Lf, ControlChars.Cr + ControlChars.Lf + " >")
        txt = ControlChars.Cr + ControlChars.Lf + txt
        dlg.memText.Text = txt

        If article.Subject.ToLower().IndexOf("re:") <> 0 Then
            dlg.edtSubject.Text = "Re: " + article.Subject
        End If
        Dim refs As String = StringUtils.GetStringsAsString(article.References)

        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            article.BuildMessage(dlg.memText.Text, "")
            article.Subject = dlg.edtSubject.Text
            article.From.FullAddress = dlg.edtFrom.Text
            article.References = StringUtils.GetStringArray(refs)

            Return True
        End If
        Return False
    End Function 'ReplyTo

End Class
