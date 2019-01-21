Public Class CopyDlg
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
    Friend WithEvents cbFolder As System.Windows.Forms.ComboBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.cbFolder = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(224, 64)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(120, 64)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.TabIndex = 6
        Me.btnOk.Text = "OK"
        '
        'cbFolder
        '
        Me.cbFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFolder.Location = New System.Drawing.Point(16, 32)
        Me.cbFolder.Name = "cbFolder"
        Me.cbFolder.Size = New System.Drawing.Size(288, 21)
        Me.cbFolder.TabIndex = 5
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(176, 16)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Copy current message to:"
        '
        'CopyDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 102)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.cbFolder)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "CopyDlg"
        Me.ShowInTaskbar = False
        Me.Text = "Copy"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Shared Function ShowCopyDialog(ByVal folders As String()) As String
        Dim dlg As New CopyDlg

        Dim i As Integer
        For i = 0 To folders.Length - 1
            dlg.cbFolder.Items.Add(folders(i))
        Next i
        If dlg.cbFolder.Items.Count > 0 Then
            dlg.cbFolder.SelectedIndex = 0
        End If

        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ShowCopyDialog = dlg.cbFolder.SelectedItem.ToString()
        Else
            ShowCopyDialog = ""
        End If
    End Function 'ShowCopyDialog

End Class
