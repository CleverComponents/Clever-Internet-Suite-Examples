Imports CleverComponents.InetSuite

Public Class CertListForm
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
    Private certificates As CertificateStore

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnInstall As System.Windows.Forms.Button
    Friend WithEvents lbList As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnInstall = New System.Windows.Forms.Button
        Me.lbList = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnClose.Location = New System.Drawing.Point(296, 181)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        '
        'btnInstall
        '
        Me.btnInstall.Location = New System.Drawing.Point(16, 181)
        Me.btnInstall.Name = "btnInstall"
        Me.btnInstall.TabIndex = 4
        Me.btnInstall.Text = "Install"
        '
        'lbList
        '
        Me.lbList.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbList.Location = New System.Drawing.Point(0, 0)
        Me.lbList.Name = "lbList"
        Me.lbList.Size = New System.Drawing.Size(384, 160)
        Me.lbList.TabIndex = 3
        '
        'CertListForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 208)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnInstall)
        Me.Controls.Add(Me.lbList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CertListForm"
        Me.Text = "certlistfrm"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Sub FillList()
        lbList.Items.Clear()
        Dim cert As Certificate
        For Each cert In certificates.Items
            Dim s As String = cert.IssuedTo
            If cert.Email <> "" Then
                s += " (" + cert.Email + ")"
            End If
            lbList.Items.Add(s)
        Next cert
    End Sub 'FillList


    Public Shared Sub ShowCertificates(ByVal list As CertificateStore)
        Dim dlg As New CertListForm
        dlg.certificates = list
        dlg.FillList()
        dlg.ShowDialog()
    End Sub 'ShowCertificates

    Private Sub btnInstall_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInstall.Click
        If lbList.SelectedIndex > -1 Then
            certificates.Install(certificates.Items(lbList.SelectedIndex))
            MessageBox.Show("The message certificate has been installed.")
        End If
    End Sub 'btnInstall_Click

End Class
