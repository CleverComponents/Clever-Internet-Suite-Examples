Public Class CertForm
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
    Public WithEvents edtValidTo As System.Windows.Forms.TextBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Public WithEvents edtValidFrom As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Public WithEvents edtIssuedBy As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Public WithEvents edtIssuedTo As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Public WithEvents edtName As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.edtValidTo = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.edtValidFrom = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.edtIssuedBy = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.edtIssuedTo = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.edtName = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'button3
        '
        Me.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button3.Location = New System.Drawing.Point(276, 188)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 23)
        Me.button3.TabIndex = 25
        Me.button3.Text = "Cancel"
        '
        'button2
        '
        Me.button2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.button2.Location = New System.Drawing.Point(180, 188)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 24
        Me.button2.Text = "Continue"
        '
        'button1
        '
        Me.button1.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.button1.Location = New System.Drawing.Point(36, 188)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(120, 23)
        Me.button1.TabIndex = 23
        Me.button1.Text = "Install && Continue"
        '
        'edtValidTo
        '
        Me.edtValidTo.Location = New System.Drawing.Point(100, 148)
        Me.edtValidTo.Name = "edtValidTo"
        Me.edtValidTo.ReadOnly = True
        Me.edtValidTo.Size = New System.Drawing.Size(256, 20)
        Me.edtValidTo.TabIndex = 22
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(20, 148)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(80, 23)
        Me.label5.TabIndex = 21
        Me.label5.Text = "Valid To"
        '
        'edtValidFrom
        '
        Me.edtValidFrom.Location = New System.Drawing.Point(100, 116)
        Me.edtValidFrom.Name = "edtValidFrom"
        Me.edtValidFrom.ReadOnly = True
        Me.edtValidFrom.Size = New System.Drawing.Size(256, 20)
        Me.edtValidFrom.TabIndex = 20
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(20, 116)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(80, 23)
        Me.label4.TabIndex = 19
        Me.label4.Text = "Valid From"
        '
        'edtIssuedBy
        '
        Me.edtIssuedBy.Location = New System.Drawing.Point(100, 84)
        Me.edtIssuedBy.Name = "edtIssuedBy"
        Me.edtIssuedBy.ReadOnly = True
        Me.edtIssuedBy.Size = New System.Drawing.Size(256, 20)
        Me.edtIssuedBy.TabIndex = 18
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(20, 84)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(80, 23)
        Me.label3.TabIndex = 17
        Me.label3.Text = "Issued By"
        '
        'edtIssuedTo
        '
        Me.edtIssuedTo.Location = New System.Drawing.Point(100, 52)
        Me.edtIssuedTo.Name = "edtIssuedTo"
        Me.edtIssuedTo.ReadOnly = True
        Me.edtIssuedTo.Size = New System.Drawing.Size(256, 20)
        Me.edtIssuedTo.TabIndex = 16
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(20, 52)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 23)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Issued To"
        '
        'edtName
        '
        Me.edtName.Location = New System.Drawing.Point(100, 20)
        Me.edtName.Name = "edtName"
        Me.edtName.ReadOnly = True
        Me.edtName.Size = New System.Drawing.Size(256, 20)
        Me.edtName.TabIndex = 14
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(20, 20)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 23)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Friendly Name"
        '
        'CertForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(376, 230)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.edtValidTo)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.edtValidFrom)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.edtIssuedBy)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.edtIssuedTo)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.edtName)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "CertForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View / Install certificate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

End Class
