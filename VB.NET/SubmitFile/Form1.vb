Imports System.Diagnostics

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        Http1.Request = HttpRequest1
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
    Friend WithEvents Http1 As CleverComponents.InetSuite.Http
    Friend WithEvents HttpRequest1 As CleverComponents.InetSuite.HttpRequest
    Friend WithEvents progressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents memResult As System.Windows.Forms.TextBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents edtHost As System.Windows.Forms.TextBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents edtName As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Http1 = New CleverComponents.InetSuite.Http
        Me.HttpRequest1 = New CleverComponents.InetSuite.HttpRequest
        Me.progressBar1 = New System.Windows.Forms.ProgressBar
        Me.memResult = New System.Windows.Forms.TextBox
        Me.label6 = New System.Windows.Forms.Label
        Me.btnStart = New System.Windows.Forms.Button
        Me.edtHost = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.edtName = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel
        Me.label1 = New System.Windows.Forms.Label
        CType(Me.HttpRequest1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Http1
        '
        Me.Http1.Port = 80
        '
        'progressBar1
        '
        Me.progressBar1.Location = New System.Drawing.Point(12, 299)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(392, 16)
        Me.progressBar1.TabIndex = 23
        '
        'memResult
        '
        Me.memResult.Location = New System.Drawing.Point(12, 171)
        Me.memResult.Multiline = True
        Me.memResult.Name = "memResult"
        Me.memResult.ReadOnly = True
        Me.memResult.Size = New System.Drawing.Size(392, 120)
        Me.memResult.TabIndex = 22
        Me.memResult.Text = ""
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(12, 155)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(56, 16)
        Me.label6.TabIndex = 21
        Me.label6.Text = "Response"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 123)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.TabIndex = 20
        Me.btnStart.Text = "&Submit"
        '
        'edtHost
        '
        Me.edtHost.Location = New System.Drawing.Point(12, 91)
        Me.edtHost.Name = "edtHost"
        Me.edtHost.Size = New System.Drawing.Size(392, 20)
        Me.edtHost.TabIndex = 19
        Me.edtHost.Text = "https://www.clevercomponents.com/products/inetsuite/demos/serversubmitfile.asp"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(12, 75)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(48, 16)
        Me.label5.TabIndex = 18
        Me.label5.Text = "Host"
        '
        'edtName
        '
        Me.edtName.Location = New System.Drawing.Point(76, 51)
        Me.edtName.Name = "edtName"
        Me.edtName.Size = New System.Drawing.Size(328, 20)
        Me.edtName.TabIndex = 17
        Me.edtName.Text = "c:\uploads\file.txt"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(12, 51)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 23)
        Me.label2.TabIndex = 16
        Me.label2.Text = "File"
        '
        'linkLabel1
        '
        Me.linkLabel1.Location = New System.Drawing.Point(12, 27)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(400, 23)
        Me.linkLabel1.TabIndex = 15
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "https://www.clevercomponents.com/products/inetsuite/demos/submitfile.asp"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(12, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(152, 16)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Try the original web page at:"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 326)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.memResult)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.edtHost)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.edtName)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Simulate Web Submit File request"
        CType(Me.HttpRequest1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub linkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim sInfo As New ProcessStartInfo(linkLabel1.Text)
        Process.Start(sInfo)
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If Http1.Active Then
            Return
        End If

        HttpRequest1.Clear()
        HttpRequest1.AddSubmitFile("FileName", edtName.Text)

        Try
            memResult.Text = Http1.Post(edtHost.Text)
            Http1.Close()
            MessageBox.Show("Process completed successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Http1_SendProgress(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.ProgressEventArgs) Handles Http1.SendProgress
        If e.TotalBytes > 0 Then
            progressBar1.Minimum = 0
            progressBar1.Maximum = e.TotalBytes
            progressBar1.Value = e.BytesProceed
        End If
    End Sub
End Class
