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
    Friend WithEvents memResult As System.Windows.Forms.TextBox
    Friend WithEvents cbShowText As System.Windows.Forms.CheckBox
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents edtUrl As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Http1 As CleverComponents.InetSuite.Http
    Friend WithEvents HtmlParser1 As CleverComponents.InetSuite.HtmlParser
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.memResult = New System.Windows.Forms.TextBox()
        Me.cbShowText = New System.Windows.Forms.CheckBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.edtUrl = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Http1 = New CleverComponents.InetSuite.Http()
        Me.HtmlParser1 = New CleverComponents.InetSuite.HtmlParser()
        Me.SuspendLayout()
        '
        'memResult
        '
        Me.memResult.BackColor = System.Drawing.SystemColors.Window
        Me.memResult.Location = New System.Drawing.Point(0, 96)
        Me.memResult.Multiline = True
        Me.memResult.Name = "memResult"
        Me.memResult.ReadOnly = True
        Me.memResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memResult.Size = New System.Drawing.Size(448, 264)
        Me.memResult.TabIndex = 11
        '
        'cbShowText
        '
        Me.cbShowText.Location = New System.Drawing.Point(56, 72)
        Me.cbShowText.Name = "cbShowText"
        Me.cbShowText.Size = New System.Drawing.Size(104, 24)
        Me.cbShowText.TabIndex = 10
        Me.cbShowText.Text = "Show text only"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(368, 40)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(56, 23)
        Me.button1.TabIndex = 9
        Me.button1.Text = "GET"
        '
        'edtUrl
        '
        Me.edtUrl.Location = New System.Drawing.Point(56, 40)
        Me.edtUrl.Name = "edtUrl"
        Me.edtUrl.Size = New System.Drawing.Size(304, 20)
        Me.edtUrl.TabIndex = 8
        Me.edtUrl.Text = "http://www.microsoft.com"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 16)
        Me.label2.TabIndex = 7
        Me.label2.Text = "URL"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(424, 24)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Type in the URL and click the 'GET' button to retreive the page specified by URL." &
    ""
        '
        'HtmlParser1
        '
        Me.HtmlParser1.ParseMethod = CleverComponents.InetSuite.ParseMethod.TextOnly
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 358)
        Me.Controls.Add(Me.memResult)
        Me.Controls.Add(Me.cbShowText)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.edtUrl)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HTTP GET demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        memResult.Text = ""

        Try
            If cbShowText.Checked Then
                HtmlParser1.Parse(Http1.Get(edtUrl.Text))
            Else
                memResult.Text = Http1.Get(edtUrl.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub 'button1_Click

    Private Sub HtmlParser1_ParseTag(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.ParseTagEventArgs) Handles HtmlParser1.ParseTag
        If e.Tag.Text.Trim() <> "" Then
            memResult.Text += e.Tag.Text
        End If
    End Sub
End Class
