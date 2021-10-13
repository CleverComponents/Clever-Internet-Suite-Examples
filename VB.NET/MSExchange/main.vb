Imports System.IO
Imports CleverComponents.InetSuite

Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        memText.Lines = New String() {"This is MIME test message built using Clever Message Parser"}
        memHtml.Lines = New String() {"<html>", "<body>", "<p>This is MIME test message built using Clever Message Parser</p>", "</body>", "</html>"}
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
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lbAttachments As System.Windows.Forms.ListBox
    Friend WithEvents memHtml As System.Windows.Forms.RichTextBox
    Friend WithEvents memText As System.Windows.Forms.RichTextBox
    Friend WithEvents edtPickup As System.Windows.Forms.TextBox
    Friend WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents edtSubject As System.Windows.Forms.TextBox
    Friend WithEvents edtTo As System.Windows.Forms.TextBox
    Friend WithEvents edtFrom As System.Windows.Forms.TextBox
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents MailMessage1 As CleverComponents.InetSuite.MailMessage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lbAttachments = New System.Windows.Forms.ListBox()
        Me.memHtml = New System.Windows.Forms.RichTextBox()
        Me.memText = New System.Windows.Forms.RichTextBox()
        Me.edtPickup = New System.Windows.Forms.TextBox()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.edtSubject = New System.Windows.Forms.TextBox()
        Me.edtTo = New System.Windows.Forms.TextBox()
        Me.edtFrom = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.MailMessage1 = New CleverComponents.InetSuite.MailMessage()
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(400, 368)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(104, 23)
        Me.btnSend.TabIndex = 29
        Me.btnSend.Text = "Send Message"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(280, 368)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(104, 23)
        Me.btnNew.TabIndex = 28
        Me.btnNew.Text = "New Message"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(344, 296)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(344, 264)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Add..."
        '
        'lbAttachments
        '
        Me.lbAttachments.Location = New System.Drawing.Point(16, 264)
        Me.lbAttachments.Name = "lbAttachments"
        Me.lbAttachments.Size = New System.Drawing.Size(320, 56)
        Me.lbAttachments.TabIndex = 22
        '
        'memHtml
        '
        Me.memHtml.DetectUrls = False
        Me.memHtml.Location = New System.Drawing.Point(264, 128)
        Me.memHtml.Name = "memHtml"
        Me.memHtml.Size = New System.Drawing.Size(240, 112)
        Me.memHtml.TabIndex = 20
        Me.memHtml.Text = ""
        '
        'memText
        '
        Me.memText.DetectUrls = False
        Me.memText.Location = New System.Drawing.Point(16, 128)
        Me.memText.Name = "memText"
        Me.memText.Size = New System.Drawing.Size(240, 112)
        Me.memText.TabIndex = 17
        Me.memText.Text = ""
        '
        'edtPickup
        '
        Me.edtPickup.Location = New System.Drawing.Point(168, 336)
        Me.edtPickup.Name = "edtPickup"
        Me.edtPickup.Size = New System.Drawing.Size(336, 20)
        Me.edtPickup.TabIndex = 27
        Me.edtPickup.Text = "C:\Inetpub\mailroot\Pickup"
        '
        'edtSubject
        '
        Me.edtSubject.Location = New System.Drawing.Point(120, 80)
        Me.edtSubject.Name = "edtSubject"
        Me.edtSubject.Size = New System.Drawing.Size(384, 20)
        Me.edtSubject.TabIndex = 16
        Me.edtSubject.Text = "Clever Message Parser Test"
        '
        'edtTo
        '
        Me.edtTo.Location = New System.Drawing.Point(120, 56)
        Me.edtTo.Name = "edtTo"
        Me.edtTo.Size = New System.Drawing.Size(384, 20)
        Me.edtTo.TabIndex = 13
        Me.edtTo.Text = "john@nexthost.com"
        '
        'edtFrom
        '
        Me.edtFrom.Location = New System.Drawing.Point(120, 32)
        Me.edtFrom.Name = "edtFrom"
        Me.edtFrom.Size = New System.Drawing.Size(384, 20)
        Me.edtFrom.TabIndex = 11
        Me.edtFrom.Text = "test@myhost.com"
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(16, 336)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(152, 23)
        Me.label8.TabIndex = 26
        Me.label8.Text = "Exchange drop/pickup folder"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(16, 248)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(100, 23)
        Me.label7.TabIndex = 23
        Me.label7.Text = "Attachments"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(272, 104)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(100, 23)
        Me.label6.TabIndex = 21
        Me.label6.Text = "Plain Html"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(16, 112)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(100, 23)
        Me.label5.TabIndex = 19
        Me.label5.Text = "Plain Text"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 80)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(100, 23)
        Me.label4.TabIndex = 18
        Me.label4.Text = "Subject"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 56)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(100, 23)
        Me.label3.TabIndex = 15
        Me.label3.Text = "To"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 32)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(100, 23)
        Me.label2.TabIndex = 14
        Me.label2.Text = "From"
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.Location = New System.Drawing.Point(16, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(496, 24)
        Me.label1.TabIndex = 12
        Me.label1.Text = "This demo demonstrates how to send MIME mail message using Microsoft Exchange ser" &
    "ver"
        '
        'MailMessage1
        '
        Me.MailMessage1.Date = New Date(2006, 5, 8, 15, 47, 49, 562)
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 408)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lbAttachments)
        Me.Controls.Add(Me.memHtml)
        Me.Controls.Add(Me.memText)
        Me.Controls.Add(Me.edtPickup)
        Me.Controls.Add(Me.edtSubject)
        Me.Controls.Add(Me.edtTo)
        Me.Controls.Add(Me.edtFrom)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnSend)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MS SMTP Mail Sender"
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If openFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            lbAttachments.Items.Add(openFileDialog.FileName)
        End If
    End Sub 'btnAdd_Click

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lbAttachments.Items.Clear()
    End Sub 'btnClear_Click


    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNew.Click
        edtFrom.Text = ""
        edtTo.Text = ""
        edtSubject.Text = ""
        memText.Lines = New String() {}
        memHtml.Lines = New String() {"<html>", "<body>", "</body>", "</html>"}
        lbAttachments.Items.Clear()
    End Sub 'btnNew_Click


    Private Function GenerateFileName(ByVal path As String) As String
        If (path <> "") And (Mid(path, Len(path), 1) <> "\") Then
            GenerateFileName = path + "\"
        Else
            GenerateFileName = path
        End If

        Dim now As DateTime = DateTime.Now
        GenerateFileName = GenerateFileName + [String].Format("{0}{1}{2}{3}{4}{5}.eml", now.Month.ToString("X2"), now.Day.ToString("X2"), now.Hour.ToString("X2"), now.Minute.ToString("X2"), now.Second.ToString("X2"), now.Millisecond.ToString("X2"))
    End Function 'GenerateFileName


    Private Function GetAttachments() As String()
        Dim result As String = ""

        Dim s As String
        For Each s In lbAttachments.Items
            result += s + ControlChars.Cr + ControlChars.Lf
        Next s
        Return StringUtils.GetStringArray(result)
    End Function 'GetAttachments


    Private Sub btnSend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSend.Click
        MailMessage1.BuildMessage(memText.Text, memHtml.Text, Nothing, GetAttachments())
        MailMessage1.From.FullAddress = edtFrom.Text
        MailMessage1.ToList.EmailAddresses = edtTo.Text
        MailMessage1.Subject = edtSubject.Text

        Dim w As New StreamWriter(GenerateFileName(edtPickup.Text))
        w.Write(StringUtils.GetStringsAsString(MailMessage1.MessageSource))
        w.Close()

        MessageBox.Show("The message has been queued for sending by the Microsoft SMTP service.")
    End Sub 'btnSend_Click

End Class
