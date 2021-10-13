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
    Friend WithEvents Http1 As CleverComponents.InetSuite.Http
    Friend WithEvents HtmlParser1 As CleverComponents.InetSuite.HtmlParser
    Friend WithEvents edtPassword As System.Windows.Forms.TextBox
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents edtUser As System.Windows.Forms.TextBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents memResult As System.Windows.Forms.TextBox
    Friend WithEvents cbShowText As System.Windows.Forms.CheckBox
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents edtUrl As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents CertificateStore1 As CleverComponents.InetSuite.CertificateStore
    Friend WithEvents ClientCertificateStore As CleverComponents.InetSuite.CertificateStore
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Http1 = New CleverComponents.InetSuite.Http()
        Me.HtmlParser1 = New CleverComponents.InetSuite.HtmlParser()
        Me.edtPassword = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.edtUser = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.memResult = New System.Windows.Forms.TextBox()
        Me.cbShowText = New System.Windows.Forms.CheckBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.edtUrl = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.CertificateStore1 = New CleverComponents.InetSuite.CertificateStore()
        Me.ClientCertificateStore = New CleverComponents.InetSuite.CertificateStore()
        Me.SuspendLayout()
        '
        'Http1
        '
        Me.Http1.TlsFlags = CType((CleverComponents.InetSuite.Sspi.TlsFlags.UseSSL2 Or CleverComponents.InetSuite.Sspi.TlsFlags.UseSSL3), CleverComponents.InetSuite.Sspi.TlsFlags)
        '
        'HtmlParser1
        '
        Me.HtmlParser1.ParseMethod = CleverComponents.InetSuite.ParseMethod.TextOnly
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(248, 64)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtPassword.Size = New System.Drawing.Size(112, 20)
        Me.edtPassword.TabIndex = 27
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(184, 64)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(64, 16)
        Me.label8.TabIndex = 31
        Me.label8.Text = "Password"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(56, 64)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(104, 20)
        Me.edtUser.TabIndex = 26
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(16, 64)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(48, 16)
        Me.label7.TabIndex = 30
        Me.label7.Text = "User"
        '
        'memResult
        '
        Me.memResult.BackColor = System.Drawing.SystemColors.Window
        Me.memResult.Location = New System.Drawing.Point(0, 128)
        Me.memResult.Multiline = True
        Me.memResult.Name = "memResult"
        Me.memResult.ReadOnly = True
        Me.memResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memResult.Size = New System.Drawing.Size(448, 232)
        Me.memResult.TabIndex = 29
        '
        'cbShowText
        '
        Me.cbShowText.Location = New System.Drawing.Point(56, 96)
        Me.cbShowText.Name = "cbShowText"
        Me.cbShowText.Size = New System.Drawing.Size(104, 24)
        Me.cbShowText.TabIndex = 28
        Me.cbShowText.Text = "Show text only"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(368, 40)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(56, 23)
        Me.button1.TabIndex = 25
        Me.button1.Text = "GET"
        '
        'edtUrl
        '
        Me.edtUrl.Location = New System.Drawing.Point(56, 40)
        Me.edtUrl.Name = "edtUrl"
        Me.edtUrl.Size = New System.Drawing.Size(304, 20)
        Me.edtUrl.TabIndex = 24
        Me.edtUrl.Text = "https://www.paypal.com"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 16)
        Me.label2.TabIndex = 23
        Me.label2.Text = "URL"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(424, 24)
        Me.label1.TabIndex = 22
        Me.label1.Text = "Type in the URL and click the 'GET' button to retreive the page specified by URL." &
    ""
        '
        'CertificateStore1
        '
        Me.CertificateStore1.ValidFrom = New Date(2021, 10, 5, 22, 43, 59, 180)
        Me.CertificateStore1.ValidTo = New Date(2022, 10, 5, 22, 43, 59, 180)
        '
        'ClientCertificateStore
        '
        Me.ClientCertificateStore.ValidFrom = New Date(2021, 10, 5, 22, 43, 59, 184)
        Me.ClientCertificateStore.ValidTo = New Date(2022, 10, 5, 22, 43, 59, 184)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 358)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.edtUser)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.memResult)
        Me.Controls.Add(Me.cbShowText)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.edtUrl)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HTTPS GET demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        memResult.Text = ""
        Http1.UserName = edtUser.Text
        Http1.Password = edtPassword.Text

        Try
            If cbShowText.Checked Then
                HtmlParser1.Parse(Http1.Get(edtUrl.Text))
            Else
                memResult.Text = Http1.Get(edtUrl.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub HtmlParser1_ParseTag(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.ParseTagEventArgs) Handles HtmlParser1.ParseTag
        If e.Tag.Text.Trim() <> "" Then
            memResult.Text += e.Tag.Text
        End If
    End Sub

    Private Function ViewCertificate(ByVal certificate As Certificate) As Boolean
        Dim dlg As New CertForm
        dlg.edtName.Text = certificate.FriendlyName
        dlg.edtIssuedTo.Text = certificate.IssuedTo
        dlg.edtIssuedBy.Text = certificate.IssuedBy
        dlg.edtValidFrom.Text = certificate.ValidFrom.ToString()
        dlg.edtValidTo.Text = certificate.ValidTo.ToString()

        Dim result As DialogResult
        result = dlg.ShowDialog()

        If result = Windows.Forms.DialogResult.Yes Then
            Dim newInstance As Certificate
            newInstance = certificate.Clone()

            CertificateStore1.Items.Add(newInstance)
            CertificateStore1.StoreName = "CA"
            CertificateStore1.Install(newInstance)
            MessageBox.Show("The certificate was installed successfully to " + _
                "Intermediate Certification Authorities (CA)." + ControlChars.Cr + ControlChars.Lf + "Press OK to continue.")
        End If

        ViewCertificate = (result = Windows.Forms.DialogResult.OK) Or (result = Windows.Forms.DialogResult.Yes)
    End Function

    Private Sub Http1_VerifyServer(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.VerifyPeerEventArgs) Handles Http1.VerifyServer
        If Not e.Verified Then
            If MessageBox.Show(e.StatusText + ControlChars.Cr + ControlChars.Lf + _
                "Do you wish to view / install the certificate ?", "Certificate confirmation", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If ViewCertificate(e.Certificate) Then
                    e.Verified = True
                End If
            End If
        End If
    End Sub

    Private Sub Http1_GetCertificate(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.GetCertificateEventArgs) Handles Http1.GetCertificate
        ClientCertificateStore.Close()
        ClientCertificateStore.Open("MY")

        Dim dlg As New SelectCertificateForm
        Dim cert As Certificate

        For Each cert In ClientCertificateStore.Items
            dlg.listBox1.Items.Add(cert.IssuedTo)
        Next cert

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            e.Certificate = ClientCertificateStore.Items(dlg.listBox1.SelectedIndex)
        End If

        e.Handled = True
    End Sub
End Class
