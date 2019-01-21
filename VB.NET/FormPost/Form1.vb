Imports System.Diagnostics

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        HttpRequest1.AddFormField("Name", "")
        HttpRequest1.AddFormField("Birthdate", "")
        HttpRequest1.AddFormField("Account", "")

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
    Friend WithEvents memResult As System.Windows.Forms.TextBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents edtHost As System.Windows.Forms.TextBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents edtAccount As System.Windows.Forms.TextBox
    Friend WithEvents edtBirthdate As System.Windows.Forms.TextBox
    Friend WithEvents edtName As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Http1 As CleverComponents.InetSuite.Http
    Friend WithEvents HttpRequest1 As CleverComponents.InetSuite.HttpRequest
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.memResult = New System.Windows.Forms.TextBox
        Me.label6 = New System.Windows.Forms.Label
        Me.btnStart = New System.Windows.Forms.Button
        Me.edtHost = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.edtAccount = New System.Windows.Forms.TextBox
        Me.edtBirthdate = New System.Windows.Forms.TextBox
        Me.edtName = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel
        Me.label1 = New System.Windows.Forms.Label
        Me.Http1 = New CleverComponents.InetSuite.Http
        Me.HttpRequest1 = New CleverComponents.InetSuite.HttpRequest
        CType(Me.HttpRequest1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'memResult
        '
        Me.memResult.Location = New System.Drawing.Point(16, 227)
        Me.memResult.Multiline = True
        Me.memResult.Name = "memResult"
        Me.memResult.ReadOnly = True
        Me.memResult.Size = New System.Drawing.Size(392, 88)
        Me.memResult.TabIndex = 25
        Me.memResult.Text = ""
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(16, 211)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(56, 16)
        Me.label6.TabIndex = 24
        Me.label6.Text = "Response"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(16, 179)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.TabIndex = 23
        Me.btnStart.Text = "&Submit"
        '
        'edtHost
        '
        Me.edtHost.Location = New System.Drawing.Point(16, 147)
        Me.edtHost.Name = "edtHost"
        Me.edtHost.Size = New System.Drawing.Size(392, 20)
        Me.edtHost.TabIndex = 22
        Me.edtHost.Text = "https://www.clevercomponents.com/products/inetsuite/demos/serverformpost.asp"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(16, 131)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(48, 16)
        Me.label5.TabIndex = 21
        Me.label5.Text = "Host"
        '
        'edtAccount
        '
        Me.edtAccount.Location = New System.Drawing.Point(80, 99)
        Me.edtAccount.Name = "edtAccount"
        Me.edtAccount.Size = New System.Drawing.Size(328, 20)
        Me.edtAccount.TabIndex = 20
        Me.edtAccount.Text = "123456"
        '
        'edtBirthdate
        '
        Me.edtBirthdate.Location = New System.Drawing.Point(80, 75)
        Me.edtBirthdate.Name = "edtBirthdate"
        Me.edtBirthdate.Size = New System.Drawing.Size(328, 20)
        Me.edtBirthdate.TabIndex = 19
        Me.edtBirthdate.Text = "10/10/77"
        '
        'edtName
        '
        Me.edtName.Location = New System.Drawing.Point(80, 51)
        Me.edtName.Name = "edtName"
        Me.edtName.Size = New System.Drawing.Size(328, 20)
        Me.edtName.TabIndex = 18
        Me.edtName.Text = "John Doe"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 99)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 23)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Account"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 75)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 23)
        Me.label3.TabIndex = 16
        Me.label3.Text = "Birthdate"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 51)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 23)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Name"
        '
        'linkLabel1
        '
        Me.linkLabel1.Location = New System.Drawing.Point(16, 27)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(376, 23)
        Me.linkLabel1.TabIndex = 14
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "https://www.clevercomponents.com/products/inetsuite/demos/formpost.asp"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(152, 16)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Try the original web page at:"
        '
        'Http1
        '
        Me.Http1.Port = 80
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 326)
        Me.Controls.Add(Me.memResult)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.edtHost)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.edtAccount)
        Me.Controls.Add(Me.edtBirthdate)
        Me.Controls.Add(Me.edtName)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Simulate Web Form POST request"
        CType(Me.HttpRequest1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub linkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
        Dim sInfo As New ProcessStartInfo(linkLabel1.Text)
        Process.Start(sInfo)
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If Http1.Active Then
            Return
        End If
        HttpRequest1.Items.FormFieldByName("Name").FieldValue = edtName.Text
        HttpRequest1.Items.FormFieldByName("Birthdate").FieldValue = edtBirthdate.Text
        HttpRequest1.Items.FormFieldByName("Account").FieldValue = edtAccount.Text

        Try
            Dim response As String()
            response = Http1.Post(edtHost.Text)
            memResult.Lines = response
            Http1.Close()
            MessageBox.Show("Process completed successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
