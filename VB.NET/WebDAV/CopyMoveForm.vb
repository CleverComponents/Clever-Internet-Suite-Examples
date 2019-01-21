Public Class CopyMoveForm
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
    Public WithEvents cbIsMove As System.Windows.Forms.CheckBox
    Public WithEvents edtDestination As System.Windows.Forms.TextBox
    Public WithEvents edtSource As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.button2 = New System.Windows.Forms.Button
        Me.button1 = New System.Windows.Forms.Button
        Me.cbIsMove = New System.Windows.Forms.CheckBox
        Me.edtDestination = New System.Windows.Forms.TextBox
        Me.edtSource = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button2.Location = New System.Drawing.Point(296, 97)
        Me.button2.Name = "button2"
        Me.button2.TabIndex = 13
        Me.button2.Text = "Cancel"
        '
        'button1
        '
        Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.button1.Location = New System.Drawing.Point(208, 97)
        Me.button1.Name = "button1"
        Me.button1.TabIndex = 12
        Me.button1.Text = "OK"
        '
        'cbIsMove
        '
        Me.cbIsMove.Location = New System.Drawing.Point(88, 73)
        Me.cbIsMove.Name = "cbIsMove"
        Me.cbIsMove.Size = New System.Drawing.Size(136, 24)
        Me.cbIsMove.TabIndex = 11
        Me.cbIsMove.Text = "Is Move Resource"
        '
        'edtDestination
        '
        Me.edtDestination.Location = New System.Drawing.Point(88, 41)
        Me.edtDestination.Name = "edtDestination"
        Me.edtDestination.Size = New System.Drawing.Size(312, 20)
        Me.edtDestination.TabIndex = 10
        Me.edtDestination.Text = ""
        '
        'edtSource
        '
        Me.edtSource.Location = New System.Drawing.Point(88, 17)
        Me.edtSource.Name = "edtSource"
        Me.edtSource.ReadOnly = True
        Me.edtSource.Size = New System.Drawing.Size(312, 20)
        Me.edtSource.TabIndex = 9
        Me.edtSource.Text = ""
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 41)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 23)
        Me.label2.TabIndex = 8
        Me.label2.Text = "Destination"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 23)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Source"
        '
        'CopyMoveForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 136)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.cbIsMove)
        Me.Controls.Add(Me.edtDestination)
        Me.Controls.Add(Me.edtSource)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "CopyMoveForm"
        Me.Text = "Copy / Move Resource"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
