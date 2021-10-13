Public Class GetCertDialog
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        edtEmail.Text = DefaultEmail
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
    Public Shared DefaultEmail As String = "myname@mycompany.com"

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnMessage As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Public WithEvents edtStore As System.Windows.Forms.TextBox
    Public WithEvents edtEmail As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.edtStore = New System.Windows.Forms.TextBox()
        Me.edtEmail = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMessage
        '
        Me.btnMessage.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMessage.Location = New System.Drawing.Point(193, 65)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(112, 23)
        Me.btnMessage.TabIndex = 11
        Me.btnMessage.Text = "Get From Message"
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(105, 65)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 10
        Me.btnOk.Text = "OK"
        '
        'edtStore
        '
        Me.edtStore.Location = New System.Drawing.Point(105, 33)
        Me.edtStore.Name = "edtStore"
        Me.edtStore.Size = New System.Drawing.Size(200, 20)
        Me.edtStore.TabIndex = 9
        Me.edtStore.Text = "MY"
        '
        'edtEmail
        '
        Me.edtEmail.Location = New System.Drawing.Point(105, 9)
        Me.edtEmail.Name = "edtEmail"
        Me.edtEmail.Size = New System.Drawing.Size(200, 20)
        Me.edtEmail.TabIndex = 8
        Me.edtEmail.Text = "textBox1"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(9, 33)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(88, 23)
        Me.label2.TabIndex = 7
        Me.label2.Text = "Store Name"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(9, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(88, 23)
        Me.label1.TabIndex = 6
        Me.label1.Text = "E-mail Address"
        '
        'GetCertDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(314, 96)
        Me.Controls.Add(Me.btnMessage)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.edtStore)
        Me.Controls.Add(Me.edtEmail)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GetCertDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Get Certificate Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

End Class
