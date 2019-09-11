Imports CleverComponents.InetSuite

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
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents memBody As System.Windows.Forms.TextBox
    Friend WithEvents edtSubject As System.Windows.Forms.TextBox
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents edtFrom As System.Windows.Forms.TextBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents lvMessages As System.Windows.Forms.ListView
    Friend WithEvents columnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents columnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents columnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents cbUseTLS As System.Windows.Forms.CheckBox
    Friend WithEvents edtPort As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents edtPassword As System.Windows.Forms.TextBox
    Friend WithEvents edtUser As System.Windows.Forms.TextBox
    Friend WithEvents edtServer As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Pop31 As CleverComponents.InetSuite.Pop3
    Friend WithEvents MailMessage1 As CleverComponents.InetSuite.MailMessage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.memBody = New System.Windows.Forms.TextBox()
        Me.edtSubject = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.edtFrom = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.lvMessages = New System.Windows.Forms.ListView()
        Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.label6 = New System.Windows.Forms.Label()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.cbUseTLS = New System.Windows.Forms.CheckBox()
        Me.edtPort = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.edtPassword = New System.Windows.Forms.TextBox()
        Me.edtUser = New System.Windows.Forms.TextBox()
        Me.edtServer = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Pop31 = New CleverComponents.InetSuite.Pop3()
        Me.MailMessage1 = New CleverComponents.InetSuite.MailMessage()
        CType(Me.Pop31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(440, 136)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 23)
        Me.btnDelete.TabIndex = 43
        Me.btnDelete.Text = "Delete Message"
        '
        'memBody
        '
        Me.memBody.Location = New System.Drawing.Point(16, 272)
        Me.memBody.Multiline = True
        Me.memBody.Name = "memBody"
        Me.memBody.ReadOnly = True
        Me.memBody.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memBody.Size = New System.Drawing.Size(520, 96)
        Me.memBody.TabIndex = 46
        '
        'edtSubject
        '
        Me.edtSubject.Location = New System.Drawing.Point(72, 248)
        Me.edtSubject.Name = "edtSubject"
        Me.edtSubject.ReadOnly = True
        Me.edtSubject.Size = New System.Drawing.Size(464, 20)
        Me.edtSubject.TabIndex = 45
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(16, 248)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(48, 23)
        Me.label8.TabIndex = 53
        Me.label8.Text = "Subject"
        '
        'edtFrom
        '
        Me.edtFrom.Location = New System.Drawing.Point(72, 224)
        Me.edtFrom.Name = "edtFrom"
        Me.edtFrom.ReadOnly = True
        Me.edtFrom.Size = New System.Drawing.Size(464, 20)
        Me.edtFrom.TabIndex = 44
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(16, 224)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(48, 23)
        Me.label7.TabIndex = 52
        Me.label7.Text = "From"
        '
        'lvMessages
        '
        Me.lvMessages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader3, Me.columnHeader2, Me.columnHeader4, Me.columnHeader5})
        Me.lvMessages.FullRowSelect = True
        Me.lvMessages.HideSelection = False
        Me.lvMessages.Location = New System.Drawing.Point(16, 128)
        Me.lvMessages.Name = "lvMessages"
        Me.lvMessages.Size = New System.Drawing.Size(400, 88)
        Me.lvMessages.TabIndex = 42
        Me.lvMessages.UseCompatibleStateImageBehavior = False
        Me.lvMessages.View = System.Windows.Forms.View.Details
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "From"
        Me.columnHeader3.Width = 120
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Subject"
        Me.columnHeader2.Width = 120
        '
        'columnHeader4
        '
        Me.columnHeader4.Text = "Date"
        Me.columnHeader4.Width = 80
        '
        'columnHeader5
        '
        Me.columnHeader5.Text = "UID"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(16, 104)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(64, 23)
        Me.label6.TabIndex = 51
        Me.label6.Text = "Messages"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(440, 64)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(96, 23)
        Me.btnDisconnect.TabIndex = 41
        Me.btnDisconnect.Text = "Disconnect"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(440, 16)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(96, 23)
        Me.btnConnect.TabIndex = 40
        Me.btnConnect.Text = "Connect"
        '
        'cbUseTLS
        '
        Me.cbUseTLS.Checked = True
        Me.cbUseTLS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbUseTLS.Location = New System.Drawing.Point(312, 40)
        Me.cbUseTLS.Name = "cbUseTLS"
        Me.cbUseTLS.Size = New System.Drawing.Size(104, 24)
        Me.cbUseTLS.TabIndex = 37
        Me.cbUseTLS.Text = "Use SSL / TLS"
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(80, 40)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(48, 20)
        Me.edtPort.TabIndex = 36
        Me.edtPort.Text = "995"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 40)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(48, 16)
        Me.label4.TabIndex = 50
        Me.label4.Text = "Port"
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(312, 72)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtPassword.Size = New System.Drawing.Size(104, 20)
        Me.edtPassword.TabIndex = 39
        Me.edtPassword.Text = "clevertester"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(80, 72)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(104, 20)
        Me.edtUser.TabIndex = 38
        Me.edtUser.Text = "CleverTester"
        '
        'edtServer
        '
        Me.edtServer.Location = New System.Drawing.Point(80, 16)
        Me.edtServer.Name = "edtServer"
        Me.edtServer.Size = New System.Drawing.Size(336, 20)
        Me.edtServer.TabIndex = 35
        Me.edtServer.Text = "localhost"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(240, 72)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 16)
        Me.label3.TabIndex = 49
        Me.label3.Text = "Password"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 72)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 16)
        Me.label2.TabIndex = 48
        Me.label2.Text = "User"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 16)
        Me.label1.TabIndex = 47
        Me.label1.Text = "Server"
        '
        'MailMessage1
        '
        Me.MailMessage1.Date = New Date(2007, 1, 13, 16, 33, 42, 717)
        Me.MailMessage1.From.Email = ""
        Me.MailMessage1.From.Name = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 376)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.memBody)
        Me.Controls.Add(Me.edtSubject)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.edtFrom)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.lvMessages)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.cbUseTLS)
        Me.Controls.Add(Me.edtPort)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.edtUser)
        Me.Controls.Add(Me.edtServer)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "POP3 Client with SSL / TLS support"
        CType(Me.Pop31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MailMessage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private certificateVerified As Boolean

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        If Pop31.Active Then
            Exit Sub
        End If

        certificateVerified = False

        Pop31.Server = edtServer.Text
        Pop31.Port = Convert.ToInt32(edtPort.Text)
        Pop31.UserName = edtUser.Text
        Pop31.Password = edtPassword.Text

        If cbUseTLS.Checked Then
            Pop31.UseTls = ClientTlsMode.Automatic
        Else
            Pop31.UseTls = ClientTlsMode.None
        End If

        Pop31.Open()

        FillMessages()
    End Sub

    Private Sub FillMessages()
        lvMessages.Items.Clear()
        ClearMessage()

        Dim i As Integer
        For i = 0 To Pop31.MessageCount - 1
            Pop31.RetrieveHeader(i + 1, MailMessage1)
            Dim item As ListViewItem = lvMessages.Items.Add(MailMessage1.From.FullAddress)

            item.SubItems.Add(MailMessage1.Subject)
            item.SubItems.Add(MailMessage1.Date.ToString())
            item.SubItems.Add(Pop31.GetUID(i + 1).ToString())
            item.SubItems.Add(i.ToString())
        Next i
    End Sub

    Private Sub ClearMessage()
        edtFrom.Text = ""
        edtSubject.Text = ""
        memBody.Text = ""
    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        lvMessages.Items.Clear()
        ClearMessage()
        Pop31.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Pop31.Active And (lvMessages.SelectedItems.Count > 0) Then
            Dim ind As Integer = Convert.ToInt32(lvMessages.SelectedItems(0).SubItems(4).Text)
            Pop31.Delete(ind + 1)
            lvMessages.Items.RemoveAt(ind)
        End If
    End Sub

    Private Sub lvMessages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvMessages.SelectedIndexChanged
        If Pop31.Active And lvMessages.SelectedItems.Count > 0 Then
            Pop31.Retrieve(Convert.ToInt32(lvMessages.SelectedItems(0).SubItems(4).Text) + 1, MailMessage1)

            edtFrom.Text = MailMessage1.From.FullAddress
            edtSubject.Text = MailMessage1.Subject
            memBody.Lines = MailMessage1.MessageText
        Else
            ClearMessage()
        End If
    End Sub

    Private Sub Pop31_VerifyServer(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.VerifyPeerEventArgs) Handles Pop31.VerifyServer
        If Not e.Verified Then
            e.Verified = certificateVerified
        End If

        If (Not e.Verified) Then
            If (MessageBox.Show(e.StatusText + ControlChars.Cr + ControlChars.Lf + _
            "Do you wish to proceed ?", "Verify certificate", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                e.Verified = True
                certificateVerified = True
            End If
        End If
    End Sub
End Class
