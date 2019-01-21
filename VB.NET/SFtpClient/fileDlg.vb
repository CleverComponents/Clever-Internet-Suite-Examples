Public Class FileExistsDialog
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
    Friend WithEvents btnResume As System.Windows.Forms.Button
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnResume = New System.Windows.Forms.Button
        Me.btnReplace = New System.Windows.Forms.Button
        Me.lblCaption = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(267, 72)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'btnResume
        '
        Me.btnResume.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnResume.Location = New System.Drawing.Point(107, 72)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.TabIndex = 6
        Me.btnResume.Text = "Resume"
        '
        'btnReplace
        '
        Me.btnReplace.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnReplace.Location = New System.Drawing.Point(19, 72)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.TabIndex = 5
        Me.btnReplace.Text = "Replace"
        '
        'lblCaption
        '
        Me.lblCaption.Location = New System.Drawing.Point(19, 16)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(320, 48)
        Me.lblCaption.TabIndex = 4
        Me.lblCaption.Text = "label1"
        '
        'FileExistsDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 110)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnResume)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.lblCaption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FileExistsDialog"
        Me.ShowInTaskbar = False
        Me.Text = "File Exists Dialog"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Function ShowFileDialog(ByVal fileName As String) As DialogResult
        lblCaption.Text = String.Format("File already exists {0}", fileName)
        Return ShowDialog()
    End Function

End Class
