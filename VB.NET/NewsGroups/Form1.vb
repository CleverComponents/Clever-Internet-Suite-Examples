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
    Private isLoading As Boolean = False

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents memBody As System.Windows.Forms.TextBox
    Friend WithEvents tvArticles As System.Windows.Forms.TreeView
    Friend WithEvents btnReply As System.Windows.Forms.Button
    Friend WithEvents btnPostNew As System.Windows.Forms.Button
    Friend WithEvents btnGetArticles As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents cbNewsGroup As System.Windows.Forms.ComboBox
    Friend WithEvents edtNewsServer As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Nntp1 As CleverComponents.InetSuite.Nntp
    Friend WithEvents MailMessage1 As CleverComponents.InetSuite.MailMessage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.memBody = New System.Windows.Forms.TextBox()
        Me.tvArticles = New System.Windows.Forms.TreeView()
        Me.btnReply = New System.Windows.Forms.Button()
        Me.btnPostNew = New System.Windows.Forms.Button()
        Me.btnGetArticles = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.cbNewsGroup = New System.Windows.Forms.ComboBox()
        Me.edtNewsServer = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Nntp1 = New CleverComponents.InetSuite.Nntp()
        Me.MailMessage1 = New CleverComponents.InetSuite.MailMessage()
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'memBody
        '
        Me.memBody.Location = New System.Drawing.Point(23, 223)
        Me.memBody.Multiline = True
        Me.memBody.Name = "memBody"
        Me.memBody.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memBody.Size = New System.Drawing.Size(432, 144)
        Me.memBody.TabIndex = 19
        '
        'tvArticles
        '
        Me.tvArticles.Location = New System.Drawing.Point(23, 119)
        Me.tvArticles.Name = "tvArticles"
        Me.tvArticles.Size = New System.Drawing.Size(432, 97)
        Me.tvArticles.TabIndex = 18
        '
        'btnReply
        '
        Me.btnReply.Enabled = False
        Me.btnReply.Location = New System.Drawing.Point(383, 87)
        Me.btnReply.Name = "btnReply"
        Me.btnReply.Size = New System.Drawing.Size(75, 23)
        Me.btnReply.TabIndex = 17
        Me.btnReply.Text = "Reply..."
        '
        'btnPostNew
        '
        Me.btnPostNew.Enabled = False
        Me.btnPostNew.Location = New System.Drawing.Point(295, 87)
        Me.btnPostNew.Name = "btnPostNew"
        Me.btnPostNew.Size = New System.Drawing.Size(75, 23)
        Me.btnPostNew.TabIndex = 16
        Me.btnPostNew.Text = "Post New..."
        '
        'btnGetArticles
        '
        Me.btnGetArticles.Enabled = False
        Me.btnGetArticles.Location = New System.Drawing.Point(111, 87)
        Me.btnGetArticles.Name = "btnGetArticles"
        Me.btnGetArticles.Size = New System.Drawing.Size(75, 23)
        Me.btnGetArticles.TabIndex = 15
        Me.btnGetArticles.Text = "Get Articles"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(23, 87)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 14
        Me.btnConnect.Text = "Connect"
        '
        'cbNewsGroup
        '
        Me.cbNewsGroup.Enabled = False
        Me.cbNewsGroup.Location = New System.Drawing.Point(103, 47)
        Me.cbNewsGroup.Name = "cbNewsGroup"
        Me.cbNewsGroup.Size = New System.Drawing.Size(352, 21)
        Me.cbNewsGroup.TabIndex = 13
        '
        'edtNewsServer
        '
        Me.edtNewsServer.Location = New System.Drawing.Point(103, 15)
        Me.edtNewsServer.Name = "edtNewsServer"
        Me.edtNewsServer.Size = New System.Drawing.Size(352, 20)
        Me.edtNewsServer.TabIndex = 12
        Me.edtNewsServer.Text = "msnews.microsoft.com"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(23, 47)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 16)
        Me.label2.TabIndex = 11
        Me.label2.Text = "News Group"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(23, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 16)
        Me.label1.TabIndex = 10
        Me.label1.Text = "News Server"
        '
        'Nntp1
        '
        '
        'MailMessage1
        '
        Me.MailMessage1.Date = New Date(2006, 5, 8, 15, 53, 23, 374)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 382)
        Me.Controls.Add(Me.memBody)
        Me.Controls.Add(Me.tvArticles)
        Me.Controls.Add(Me.btnReply)
        Me.Controls.Add(Me.btnPostNew)
        Me.Controls.Add(Me.btnGetArticles)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.cbNewsGroup)
        Me.Controls.Add(Me.edtNewsServer)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "News Group Reader"
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnConnect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        cbNewsGroup.Enabled = False
        btnGetArticles.Enabled = False
        btnPostNew.Enabled = False
        btnReply.Enabled = False
        tvArticles.Enabled = False
        memBody.Enabled = False
        cbNewsGroup.Enabled = False

        Try
            Nntp1.Close()
            Nntp1.Server = edtNewsServer.Text
            Nntp1.Open()

            Dim list As String() = Nntp1.GetGroups()

            Dim s As String = cbNewsGroup.Text
            cbNewsGroup.Items.Clear()
            Dim i As Integer
            For i = 0 To list.Length - 1
                cbNewsGroup.Items.Add(list(i))
            Next i
            cbNewsGroup.Text = s

            cbNewsGroup.Enabled = True
            btnGetArticles.Enabled = True
            btnPostNew.Enabled = True
            btnReply.Enabled = True
            tvArticles.Enabled = True
            memBody.Enabled = True
            cbNewsGroup.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub 'btnConnect_Click


    Private Sub btnGetArticles_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGetArticles.Click
        btnGetArticles.Enabled = False
        btnPostNew.Enabled = False
        btnReply.Enabled = False
        tvArticles.Enabled = False
        memBody.Enabled = False
        isLoading = True

        Try
            tvArticles.Nodes.Clear()
            memBody.Text = ""

            Nntp1.SelectGroup(cbNewsGroup.Text)
            Nntp1.GroupOverview()
        Finally
            isLoading = False
            btnGetArticles.Enabled = True
            btnPostNew.Enabled = True
            btnReply.Enabled = True
            tvArticles.Enabled = True
            memBody.Enabled = True
        End Try
    End Sub 'btnGetArticles_Click


    Private Sub btnPostNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPostNew.Click
        If MessageFrm.PostNew(MailMessage1) Then
            Nntp1.PostArticle(MailMessage1, "", cbNewsGroup.Text)
        End If
    End Sub 'btnPostNew_Click


    Private Sub btnReply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReply.Click
        If tvArticles.SelectedNode Is Nothing Then
            MessageBox.Show("Select article first")
            Return
        End If

        Nntp1.GetArticle(tvArticles.SelectedNode.Tag.ToString(), MailMessage1)

        If MessageFrm.ReplyTo(MailMessage1) Then
            Nntp1.PostArticle(MailMessage1, tvArticles.SelectedNode.Tag.ToString(), cbNewsGroup.Text)
        End If
    End Sub 'btnReply_Click


    Private Function FindNodeByMessageID(ByVal list As TreeNodeCollection, ByVal messageID As String) As TreeNode
        Dim node As TreeNode
        For Each node In list
            If node.Tag.ToString() = messageID Then
                Return node
            End If
            Dim subNode As TreeNode = FindNodeByMessageID(node.Nodes, messageID)
            If Not (subNode Is Nothing) Then
                Return subNode
            End If
        Next node
        Return Nothing
    End Function 'FindNodeByMessageID


    Private Sub tvArticles_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvArticles.AfterSelect
        If isLoading Or e.Node Is Nothing Then
            Return
        End If
        isLoading = True
        Try
            memBody.Lines = Nntp1.GetBody(e.Node.Tag.ToString())
        Finally
            isLoading = False
        End Try
    End Sub 'tvArticles_AfterSelect

    Private Sub Nntp1_GroupOverviewing(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.GroupOverviewEventArgs) Handles Nntp1.GroupOverviewing
        Dim node As TreeNode = Nothing

        Try
            If e.ArticleInfo.References.Length > 0 Then
                node = FindNodeByMessageID(tvArticles.Nodes, e.ArticleInfo.References((e.ArticleInfo.References.Length - 1)))
            End If
        Catch
        End Try
        Dim newNode As TreeNode
        If Not (node Is Nothing) Then
            newNode = node.Nodes.Add((e.ArticleInfo.Subject + " from " + e.ArticleInfo.From.FullAddress))
        Else
            newNode = tvArticles.Nodes.Add((e.ArticleInfo.Subject + " from " + e.ArticleInfo.From.FullAddress))
        End If
        newNode.Tag = e.ArticleInfo.MessageID
    End Sub
End Class
