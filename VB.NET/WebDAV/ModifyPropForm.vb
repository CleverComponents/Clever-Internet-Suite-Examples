Public Class ModifyPropForm
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
    Friend WithEvents button3 As System.Windows.Forms.Button
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents button1 As System.Windows.Forms.Button
    Public WithEvents edtValue As System.Windows.Forms.TextBox
    Public WithEvents edtName As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Public WithEvents lblResource As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.button3 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.button1 = New System.Windows.Forms.Button
        Me.edtValue = New System.Windows.Forms.TextBox
        Me.edtName = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.lblResource = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'button3
        '
        Me.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button3.Location = New System.Drawing.Point(224, 96)
        Me.button3.Name = "button3"
        Me.button3.TabIndex = 15
        Me.button3.Text = "Cancel"
        '
        'button2
        '
        Me.button2.DialogResult = System.Windows.Forms.DialogResult.No
        Me.button2.Location = New System.Drawing.Point(128, 96)
        Me.button2.Name = "button2"
        Me.button2.TabIndex = 14
        Me.button2.Text = "Remove"
        '
        'button1
        '
        Me.button1.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.button1.Location = New System.Drawing.Point(32, 96)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 13
        Me.button1.Text = "Set"
        '
        'edtValue
        '
        Me.edtValue.Location = New System.Drawing.Point(104, 64)
        Me.edtValue.Name = "edtValue"
        Me.edtValue.Size = New System.Drawing.Size(200, 20)
        Me.edtValue.TabIndex = 12
        Me.edtValue.Text = "J.J. Johnson"
        '
        'edtName
        '
        Me.edtName.Location = New System.Drawing.Point(104, 40)
        Me.edtName.Name = "edtName"
        Me.edtName.Size = New System.Drawing.Size(200, 20)
        Me.edtName.TabIndex = 11
        Me.edtName.Text = "author"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 64)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 23)
        Me.label2.TabIndex = 10
        Me.label2.Text = "New value"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 40)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 23)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Property Name"
        '
        'lblResource
        '
        Me.lblResource.Location = New System.Drawing.Point(16, 8)
        Me.lblResource.Name = "lblResource"
        Me.lblResource.Size = New System.Drawing.Size(288, 23)
        Me.lblResource.TabIndex = 8
        Me.lblResource.Text = "lblResource"
        '
        'ModifyPropForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 134)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.edtValue)
        Me.Controls.Add(Me.edtName)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lblResource)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ModifyPropForm"
        Me.Text = "Change / Remove Property"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
