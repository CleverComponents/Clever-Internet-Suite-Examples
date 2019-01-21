Public Class ImportForm
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
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents label3 As System.Windows.Forms.Label
    Public WithEvents edtPassword As System.Windows.Forms.TextBox
    Public WithEvents edtStoreName As System.Windows.Forms.TextBox
    Public WithEvents edtFileName As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.label3 = New System.Windows.Forms.Label
        Me.edtPassword = New System.Windows.Forms.TextBox
        Me.edtStoreName = New System.Windows.Forms.TextBox
        Me.edtFileName = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(204, 144)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(84, 144)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.TabIndex = 17
        Me.btnOk.Text = "OK"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(20, 80)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(304, 32)
        Me.label3.TabIndex = 16
        Me.label3.Text = "The certificate will be imported and installed in to the currently loaded System " & _
        "Store:"
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(84, 48)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.Size = New System.Drawing.Size(112, 20)
        Me.edtPassword.TabIndex = 15
        Me.edtPassword.Text = "123"
        '
        'edtStoreName
        '
        Me.edtStoreName.Location = New System.Drawing.Point(20, 112)
        Me.edtStoreName.Name = "edtStoreName"
        Me.edtStoreName.ReadOnly = True
        Me.edtStoreName.Size = New System.Drawing.Size(304, 20)
        Me.edtStoreName.TabIndex = 14
        Me.edtStoreName.Text = ""
        '
        'edtFileName
        '
        Me.edtFileName.Location = New System.Drawing.Point(84, 16)
        Me.edtFileName.Name = "edtFileName"
        Me.edtFileName.Size = New System.Drawing.Size(240, 20)
        Me.edtFileName.TabIndex = 13
        Me.edtFileName.Text = "cert.pfx"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(20, 48)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 23)
        Me.label2.TabIndex = 12
        Me.label2.Text = "Password"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(20, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(56, 23)
        Me.label1.TabIndex = 11
        Me.label1.Text = "File Name"
        '
        'ImportForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(344, 182)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.edtStoreName)
        Me.Controls.Add(Me.edtFileName)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ImportForm"
        Me.ShowInTaskbar = False
        Me.Text = "Certificate Import Dialog"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
