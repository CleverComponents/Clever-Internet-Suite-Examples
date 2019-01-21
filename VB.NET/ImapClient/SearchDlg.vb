Public Class SearchDlg
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
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents edtSearchFor As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents cbSearchIn As System.Windows.Forms.ComboBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.edtSearchFor = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.cbSearchIn = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(190, 113)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        '
        'btnSearch
        '
        Me.btnSearch.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSearch.Location = New System.Drawing.Point(94, 113)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        '
        'edtSearchFor
        '
        Me.edtSearchFor.Location = New System.Drawing.Point(22, 81)
        Me.edtSearchFor.Name = "edtSearchFor"
        Me.edtSearchFor.Size = New System.Drawing.Size(248, 20)
        Me.edtSearchFor.TabIndex = 9
        Me.edtSearchFor.Text = ""
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(22, 65)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 16)
        Me.label2.TabIndex = 8
        Me.label2.Text = "Search For"
        '
        'cbSearchIn
        '
        Me.cbSearchIn.Items.AddRange(New Object() {"FROM", "SUBJECT", "TEXT"})
        Me.cbSearchIn.Location = New System.Drawing.Point(22, 33)
        Me.cbSearchIn.Name = "cbSearchIn"
        Me.cbSearchIn.Size = New System.Drawing.Size(248, 21)
        Me.cbSearchIn.TabIndex = 7
        Me.cbSearchIn.Text = "SUBJECT"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(22, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(64, 16)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Search In"
        '
        'SearchDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 152)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.edtSearchFor)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.cbSearchIn)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "SearchDlg"
        Me.ShowInTaskbar = False
        Me.Text = "Find Message"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub SearchDlg_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Me.DialogResult = Windows.Forms.DialogResult.OK And (cbSearchIn.Text = "" Or edtSearchFor.Text = "")
        If e.Cancel Then
            MessageBox.Show("The search conditions can not be empty")
        End If
    End Sub

    Public Function GetSearchCriteria() As String
        Return cbSearchIn.Text + " " + edtSearchFor.Text
    End Function 'GetSearchCriteria
End Class
