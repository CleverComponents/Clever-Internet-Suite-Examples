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
    Friend WithEvents btnAppend As System.Windows.Forms.Button
    Friend WithEvents memBody As System.Windows.Forms.TextBox
    Friend WithEvents edtSubject As System.Windows.Forms.TextBox
    Friend WithEvents edtTo As System.Windows.Forms.TextBox
    Friend WithEvents edtFrom As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAppend = New System.Windows.Forms.Button()
        Me.memBody = New System.Windows.Forms.TextBox()
        Me.edtSubject = New System.Windows.Forms.TextBox()
        Me.edtTo = New System.Windows.Forms.TextBox()
        Me.edtFrom = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(401, 273)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        '
        'btnAppend
        '
        Me.btnAppend.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAppend.Location = New System.Drawing.Point(305, 273)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(75, 23)
        Me.btnAppend.TabIndex = 18
        Me.btnAppend.Text = "Append"
        '
        'memBody
        '
        Me.memBody.Location = New System.Drawing.Point(17, 105)
        Me.memBody.Multiline = True
        Me.memBody.Name = "memBody"
        Me.memBody.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memBody.Size = New System.Drawing.Size(464, 160)
        Me.memBody.TabIndex = 17
        '
        'edtSubject
        '
        Me.edtSubject.Location = New System.Drawing.Point(81, 57)
        Me.edtSubject.Name = "edtSubject"
        Me.edtSubject.Size = New System.Drawing.Size(400, 20)
        Me.edtSubject.TabIndex = 16
        Me.edtSubject.Text = "Test Subject"
        '
        'edtTo
        '
        Me.edtTo.Location = New System.Drawing.Point(81, 33)
        Me.edtTo.Name = "edtTo"
        Me.edtTo.Size = New System.Drawing.Size(400, 20)
        Me.edtTo.TabIndex = 15
        Me.edtTo.Text = "clevertester@company.mail"
        '
        'edtFrom
        '
        Me.edtFrom.Location = New System.Drawing.Point(81, 9)
        Me.edtFrom.Name = "edtFrom"
        Me.edtFrom.Size = New System.Drawing.Size(400, 20)
        Me.edtFrom.TabIndex = 14
        Me.edtFrom.Text = "clevertester@company.mail"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(17, 89)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(32, 16)
        Me.label4.TabIndex = 13
        Me.label4.Text = "Body"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(17, 57)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 16)
        Me.label3.TabIndex = 12
        Me.label3.Text = "Subject"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(17, 33)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 16)
        Me.label2.TabIndex = 11
        Me.label2.Text = "To"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(17, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(64, 16)
        Me.label1.TabIndex = 10
        Me.label1.Text = "From"
        '
        'MessageFrm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(498, 304)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAppend)
        Me.Controls.Add(Me.memBody)
        Me.Controls.Add(Me.edtSubject)
        Me.Controls.Add(Me.edtTo)
        Me.Controls.Add(Me.edtFrom)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "MessageFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Message Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Shared Sub ShowMessage(ByVal msg As MailMessage) '
        Dim dlg As New MessageFrm
        dlg.btnAppend.Visible = False
        dlg.btnCancel.Text = "Close"

        dlg.edtFrom.ReadOnly = True
        dlg.edtTo.ReadOnly = True
        dlg.edtSubject.ReadOnly = True
        dlg.memBody.ReadOnly = True

        dlg.edtFrom.BackColor = SystemColors.Window
        dlg.edtTo.BackColor = SystemColors.Window
        dlg.edtSubject.BackColor = SystemColors.Window
        dlg.memBody.BackColor = SystemColors.Window

        dlg.edtFrom.Text = msg.From.FullAddress
        dlg.edtTo.Text = msg.ToList.EmailAddresses
        dlg.edtSubject.Text = msg.Subject
        dlg.memBody.Lines = msg.MessageText

        dlg.ShowDialog()
    End Sub 'ShowMessage


    Public Shared Function ComposeMessage(ByVal msg As MailMessage) As Boolean
        Dim dlg As New MessageFrm
        dlg.btnAppend.Visible = True
        dlg.btnCancel.Text = "Cancel"

        dlg.edtFrom.ReadOnly = False
        dlg.edtTo.ReadOnly = False
        dlg.edtSubject.ReadOnly = False
        dlg.memBody.ReadOnly = False

        dlg.edtFrom.Text = "clevertester@company.mail"
        dlg.edtTo.Text = "clevertester@company.mail"
        dlg.edtSubject.Text = "Test Subject"
        dlg.memBody.Text = "Test Body"

        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            msg.BuildMessage(dlg.memBody.Text, "")
            msg.From.FullAddress = dlg.edtFrom.Text
            msg.ToList.EmailAddresses = dlg.edtTo.Text
            msg.Subject = dlg.edtSubject.Text
            Return True
        End If
        Return False
    End Function 'ComposeMessage

End Class
