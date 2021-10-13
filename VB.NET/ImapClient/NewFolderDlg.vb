Public Class NewFolderDlg
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
    Public WithEvents cbIsSubfolder As System.Windows.Forms.CheckBox
    Public WithEvents edtName As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.cbIsSubfolder = New System.Windows.Forms.CheckBox()
        Me.edtName = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(216, 88)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(128, 88)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "OK"
        '
        'cbIsSubfolder
        '
        Me.cbIsSubfolder.Location = New System.Drawing.Point(16, 56)
        Me.cbIsSubfolder.Name = "cbIsSubfolder"
        Me.cbIsSubfolder.Size = New System.Drawing.Size(280, 24)
        Me.cbIsSubfolder.TabIndex = 7
        Me.cbIsSubfolder.Text = "Create as subfolder of the current folder"
        '
        'edtName
        '
        Me.edtName.Location = New System.Drawing.Point(16, 32)
        Me.edtName.Name = "edtName"
        Me.edtName.Size = New System.Drawing.Size(280, 20)
        Me.edtName.TabIndex = 6
        Me.edtName.Text = "NewName"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(104, 16)
        Me.label1.TabIndex = 5
        Me.label1.Text = "New Folder Name"
        '
        'NewFolderDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(312, 126)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.cbIsSubfolder)
        Me.Controls.Add(Me.edtName)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "NewFolderDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Folder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub NewFolderDlg_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Me.DialogResult = Windows.Forms.DialogResult.OK And edtName.Text = ""
        If e.Cancel Then
            MessageBox.Show("The value can not be empty")
        End If
    End Sub
End Class
