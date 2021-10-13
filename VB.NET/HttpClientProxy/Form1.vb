Imports CleverComponents.InetSuite

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        cbProxyType.SelectedIndex = 0

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
    Private WithEvents cbProxyType As System.Windows.Forms.ComboBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents edtPassword As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents edtUser As System.Windows.Forms.TextBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents edtProxyPassword As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents edtProxyPort As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents edtProxyUser As System.Windows.Forms.TextBox
    Private WithEvents edtProxyServer As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents memResult As System.Windows.Forms.TextBox
    Private WithEvents cbShowText As System.Windows.Forms.CheckBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents edtUrl As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents HtmlParser1 As CleverComponents.InetSuite.HtmlParser
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Http1 = New CleverComponents.InetSuite.Http()
        Me.HtmlParser1 = New CleverComponents.InetSuite.HtmlParser()
        Me.cbProxyType = New System.Windows.Forms.ComboBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.edtPassword = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.edtUser = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.edtProxyPassword = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.edtProxyPort = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.edtProxyUser = New System.Windows.Forms.TextBox()
        Me.edtProxyServer = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.memResult = New System.Windows.Forms.TextBox()
        Me.cbShowText = New System.Windows.Forms.CheckBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.edtUrl = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
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
        'cbProxyType
        '
        Me.cbProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProxyType.FormattingEnabled = True
        Me.cbProxyType.Items.AddRange(New Object() {"HTTP Proxy", "SOCKS4 Firewall", "SOCKS5 Firewall"})
        Me.cbProxyType.Location = New System.Drawing.Point(88, 93)
        Me.cbProxyType.Name = "cbProxyType"
        Me.cbProxyType.Size = New System.Drawing.Size(176, 21)
        Me.cbProxyType.TabIndex = 39
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(16, 96)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(60, 13)
        Me.label9.TabIndex = 38
        Me.label9.Text = "Proxy Type"
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(248, 56)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtPassword.Size = New System.Drawing.Size(112, 20)
        Me.edtPassword.TabIndex = 25
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(184, 56)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(64, 16)
        Me.label8.TabIndex = 37
        Me.label8.Text = "Password"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(56, 56)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(104, 20)
        Me.edtUser.TabIndex = 24
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(16, 56)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(48, 16)
        Me.label7.TabIndex = 36
        Me.label7.Text = "User"
        '
        'edtProxyPassword
        '
        Me.edtProxyPassword.Location = New System.Drawing.Point(288, 143)
        Me.edtProxyPassword.Name = "edtProxyPassword"
        Me.edtProxyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtProxyPassword.Size = New System.Drawing.Size(136, 20)
        Me.edtProxyPassword.TabIndex = 30
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(288, 119)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(64, 16)
        Me.label6.TabIndex = 35
        Me.label6.Text = "Proxy Port"
        '
        'edtProxyPort
        '
        Me.edtProxyPort.Location = New System.Drawing.Point(368, 119)
        Me.edtProxyPort.Name = "edtProxyPort"
        Me.edtProxyPort.Size = New System.Drawing.Size(56, 20)
        Me.edtProxyPort.TabIndex = 27
        Me.edtProxyPort.Text = "8080"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(200, 143)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(88, 16)
        Me.label5.TabIndex = 34
        Me.label5.Text = "Proxy Password"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 143)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(64, 16)
        Me.label4.TabIndex = 33
        Me.label4.Text = "Proxy User"
        '
        'edtProxyUser
        '
        Me.edtProxyUser.Location = New System.Drawing.Point(88, 143)
        Me.edtProxyUser.Name = "edtProxyUser"
        Me.edtProxyUser.Size = New System.Drawing.Size(100, 20)
        Me.edtProxyUser.TabIndex = 28
        '
        'edtProxyServer
        '
        Me.edtProxyServer.Location = New System.Drawing.Point(88, 119)
        Me.edtProxyServer.Name = "edtProxyServer"
        Me.edtProxyServer.Size = New System.Drawing.Size(176, 20)
        Me.edtProxyServer.TabIndex = 26
        Me.edtProxyServer.Text = "proxyserver"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 119)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(72, 16)
        Me.label3.TabIndex = 29
        Me.label3.Text = "Poxy Server"
        '
        'memResult
        '
        Me.memResult.BackColor = System.Drawing.SystemColors.Window
        Me.memResult.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.memResult.Location = New System.Drawing.Point(0, 214)
        Me.memResult.Multiline = True
        Me.memResult.Name = "memResult"
        Me.memResult.ReadOnly = True
        Me.memResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memResult.Size = New System.Drawing.Size(448, 212)
        Me.memResult.TabIndex = 32
        '
        'cbShowText
        '
        Me.cbShowText.Location = New System.Drawing.Point(56, 167)
        Me.cbShowText.Name = "cbShowText"
        Me.cbShowText.Size = New System.Drawing.Size(104, 24)
        Me.cbShowText.TabIndex = 31
        Me.cbShowText.Text = "Show text only"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(368, 32)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(56, 23)
        Me.button1.TabIndex = 23
        Me.button1.Text = "GET"
        '
        'edtUrl
        '
        Me.edtUrl.Location = New System.Drawing.Point(56, 32)
        Me.edtUrl.Name = "edtUrl"
        Me.edtUrl.Size = New System.Drawing.Size(304, 20)
        Me.edtUrl.TabIndex = 22
        Me.edtUrl.Text = "http://www.microsoft.com"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 32)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 16)
        Me.label2.TabIndex = 21
        Me.label2.Text = "URL"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(424, 24)
        Me.label1.TabIndex = 20
        Me.label1.Text = "Type in the URL and click the 'GET' button to retreive the page specified by URL." &
    ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 426)
        Me.Controls.Add(Me.cbProxyType)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.edtUser)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.edtProxyPassword)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.edtProxyPort)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.edtProxyUser)
        Me.Controls.Add(Me.edtProxyServer)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.memResult)
        Me.Controls.Add(Me.cbShowText)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.edtUrl)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HTTP GET demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        memResult.Text = ""

        Http1.UserName = edtUser.Text
        Http1.Password = edtPassword.Text

        Http1.FirewallSettings.Server = ""
        Http1.ProxySettings.Server = ""

        If cbProxyType.SelectedIndex = 0 Then
            Http1.ProxySettings.Server = edtProxyServer.Text
            Http1.ProxySettings.Port = Convert.ToInt32(edtProxyPort.Text)
            Http1.ProxySettings.UserName = edtProxyUser.Text
            Http1.ProxySettings.Password = edtProxyPassword.Text
        Else
            If cbProxyType.SelectedIndex = 1 Then
                Http1.FirewallSettings.FirewallType = FirewallType.Socks4
            Else
                Http1.FirewallSettings.FirewallType = FirewallType.Socks5
            End If

            Http1.FirewallSettings.Server = edtProxyServer.Text
            Http1.FirewallSettings.Port = Convert.ToInt32(edtProxyPort.Text)
            Http1.FirewallSettings.UserName = edtProxyUser.Text
            Http1.FirewallSettings.Password = edtProxyPassword.Text
        End If

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

    Private Sub cbProxyType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProxyType.SelectedIndexChanged
        If cbProxyType.SelectedIndex = 0 Then
            edtProxyPort.Text = "8080"
        Else
            edtProxyPort.Text = "1080"
        End If
    End Sub
End Class
