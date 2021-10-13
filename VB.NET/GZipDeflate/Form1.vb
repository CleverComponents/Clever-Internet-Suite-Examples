Public Class Form1
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
    Friend WithEvents progressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnUncompress As System.Windows.Forms.Button
    Friend WithEvents btnCompress As System.Windows.Forms.Button
    Friend WithEvents btnDestination As System.Windows.Forms.Button
    Friend WithEvents edtDestination As System.Windows.Forms.TextBox
    Friend WithEvents btnSource As System.Windows.Forms.Button
    Friend WithEvents edtSource As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents GZip1 As CleverComponents.InetSuite.GZip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnUncompress = New System.Windows.Forms.Button()
        Me.btnCompress = New System.Windows.Forms.Button()
        Me.btnDestination = New System.Windows.Forms.Button()
        Me.edtDestination = New System.Windows.Forms.TextBox()
        Me.btnSource = New System.Windows.Forms.Button()
        Me.edtSource = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GZip1 = New CleverComponents.InetSuite.GZip()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'progressBar1
        '
        Me.progressBar1.Location = New System.Drawing.Point(1, 240)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(400, 16)
        Me.progressBar1.Step = 1
        Me.progressBar1.TabIndex = 21
        '
        'btnUncompress
        '
        Me.btnUncompress.Location = New System.Drawing.Point(233, 184)
        Me.btnUncompress.Name = "btnUncompress"
        Me.btnUncompress.Size = New System.Drawing.Size(112, 23)
        Me.btnUncompress.TabIndex = 20
        Me.btnUncompress.Text = "Uncompress File"
        '
        'btnCompress
        '
        Me.btnCompress.Location = New System.Drawing.Point(65, 184)
        Me.btnCompress.Name = "btnCompress"
        Me.btnCompress.Size = New System.Drawing.Size(112, 23)
        Me.btnCompress.TabIndex = 19
        Me.btnCompress.Text = "Compress File"
        '
        'btnDestination
        '
        Me.btnDestination.Location = New System.Drawing.Point(353, 144)
        Me.btnDestination.Name = "btnDestination"
        Me.btnDestination.Size = New System.Drawing.Size(24, 23)
        Me.btnDestination.TabIndex = 18
        Me.btnDestination.Text = "..."
        '
        'edtDestination
        '
        Me.edtDestination.Location = New System.Drawing.Point(105, 144)
        Me.edtDestination.Name = "edtDestination"
        Me.edtDestination.Size = New System.Drawing.Size(240, 20)
        Me.edtDestination.TabIndex = 17
        '
        'btnSource
        '
        Me.btnSource.Location = New System.Drawing.Point(353, 112)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(24, 23)
        Me.btnSource.TabIndex = 16
        Me.btnSource.Text = "..."
        '
        'edtSource
        '
        Me.edtSource.Location = New System.Drawing.Point(105, 112)
        Me.edtSource.Name = "edtSource"
        Me.edtSource.Size = New System.Drawing.Size(240, 20)
        Me.edtSource.TabIndex = 15
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(17, 144)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(88, 23)
        Me.label4.TabIndex = 14
        Me.label4.Text = "Destination File"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(17, 112)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(72, 23)
        Me.label3.TabIndex = 13
        Me.label3.Text = "Source File"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(17, 64)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(360, 40)
        Me.label2.TabIndex = 12
        Me.label2.Text = "The deflated file is not compatible with WinZip file format since it does not con" &
    "tain the description header."
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(17, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(360, 40)
        Me.label1.TabIndex = 11
        Me.label1.Text = "This sample demonstrates using the TclGZip component for deflating / inflating da" &
    "ta stream."
        '
        'GZip1
        '
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(402, 256)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.btnUncompress)
        Me.Controls.Add(Me.btnCompress)
        Me.Controls.Add(Me.btnDestination)
        Me.Controls.Add(Me.edtDestination)
        Me.Controls.Add(Me.btnSource)
        Me.Controls.Add(Me.edtSource)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GZip / Deflate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnCompress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompress.Click
        progressBar1.Maximum = 100
        progressBar1.Value = 0
        GZip1.Compress(edtSource.Text, edtDestination.Text)
        MessageBox.Show(String.Format("The file {0} was deflated and stored to {1}", edtSource.Text, edtDestination.Text))
    End Sub

    Private Sub btnUncompress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUncompress.Click
        progressBar1.Maximum = 100
        progressBar1.Value = 0
        GZip1.Uncompress(edtSource.Text, edtDestination.Text)
        MessageBox.Show(String.Format("The file {0} was inflated and stored to {1}", edtSource.Text, edtDestination.Text))
    End Sub

    Private Sub btnSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSource.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            edtSource.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnDestination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDestination.Click
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            edtDestination.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub GZip1_Progress(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.ProgressEventArgs) Handles GZip1.Progress
        progressBar1.Maximum = e.TotalBytes
        progressBar1.Value = e.BytesProceed
    End Sub
End Class
