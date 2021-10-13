Public Class ExportForm
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
    Public WithEvents cbIncludeAll As System.Windows.Forms.CheckBox
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnOk As System.Windows.Forms.Button
    Public WithEvents edtPassword As System.Windows.Forms.TextBox
    Public WithEvents edtFileName As System.Windows.Forms.TextBox
    Public WithEvents edtName As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbIncludeAll = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.edtPassword = New System.Windows.Forms.TextBox()
        Me.edtFileName = New System.Windows.Forms.TextBox()
        Me.edtName = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbIncludeAll
        '
        Me.cbIncludeAll.AutoSize = True
        Me.cbIncludeAll.Location = New System.Drawing.Point(84, 109)
        Me.cbIncludeAll.Name = "cbIncludeAll"
        Me.cbIncludeAll.Size = New System.Drawing.Size(169, 17)
        Me.cbIncludeAll.TabIndex = 18
        Me.cbIncludeAll.Text = "Include All certificates in chain"
        Me.cbIncludeAll.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(202, 132)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(82, 132)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 16
        Me.btnOk.Text = "OK"
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(84, 83)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.Size = New System.Drawing.Size(120, 20)
        Me.edtPassword.TabIndex = 15
        Me.edtPassword.Text = "123"
        '
        'edtFileName
        '
        Me.edtFileName.Location = New System.Drawing.Point(84, 51)
        Me.edtFileName.Name = "edtFileName"
        Me.edtFileName.Size = New System.Drawing.Size(256, 20)
        Me.edtFileName.TabIndex = 14
        Me.edtFileName.Text = "cert.pfx"
        '
        'edtName
        '
        Me.edtName.Location = New System.Drawing.Point(84, 19)
        Me.edtName.Name = "edtName"
        Me.edtName.ReadOnly = True
        Me.edtName.Size = New System.Drawing.Size(256, 20)
        Me.edtName.TabIndex = 13
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(20, 83)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 23)
        Me.label3.TabIndex = 12
        Me.label3.Text = "Password"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(20, 51)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 23)
        Me.label2.TabIndex = 11
        Me.label2.Text = "File Name"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(20, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(56, 23)
        Me.label1.TabIndex = 10
        Me.label1.Text = "Certificate"
        '
        'ExportForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 174)
        Me.Controls.Add(Me.cbIncludeAll)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.edtFileName)
        Me.Controls.Add(Me.edtName)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ExportForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Certificate Export Dialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

End Class
