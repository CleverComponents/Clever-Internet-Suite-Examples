Public Class MakeDirForm
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
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents button1 As System.Windows.Forms.Button
    Public WithEvents edtValue As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.button2 = New System.Windows.Forms.Button
        Me.button1 = New System.Windows.Forms.Button
        Me.edtValue = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button2.Location = New System.Drawing.Point(201, 76)
        Me.button2.Name = "button2"
        Me.button2.TabIndex = 7
        Me.button2.Text = "Cancel"
        '
        'button1
        '
        Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.button1.Location = New System.Drawing.Point(105, 76)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 6
        Me.button1.Text = "OK"
        '
        'edtValue
        '
        Me.edtValue.Location = New System.Drawing.Point(17, 44)
        Me.edtValue.Name = "edtValue"
        Me.edtValue.Size = New System.Drawing.Size(256, 20)
        Me.edtValue.TabIndex = 5
        Me.edtValue.Text = ""
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(17, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(256, 23)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Enter a name for new directory"
        '
        'MakeDirForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 110)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.edtValue)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "MakeDirForm"
        Me.Text = "Make new directory"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
