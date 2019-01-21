Imports CleverComponents.InetSuite

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        cbNameType.SelectedIndex = 0
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
    Friend WithEvents DnsQuery1 As CleverComponents.InetSuite.DnsQuery
    Friend WithEvents edtPort As System.Windows.Forms.TextBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents memResult As System.Windows.Forms.TextBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents btnResolve As System.Windows.Forms.Button
    Friend WithEvents cbNameType As System.Windows.Forms.ComboBox
    Friend WithEvents edtName As System.Windows.Forms.TextBox
    Friend WithEvents edtTimeOut As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents edtDnsServer As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DnsQuery1 = New CleverComponents.InetSuite.DnsQuery
        Me.edtPort = New System.Windows.Forms.TextBox
        Me.label6 = New System.Windows.Forms.Label
        Me.memResult = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.btnResolve = New System.Windows.Forms.Button
        Me.cbNameType = New System.Windows.Forms.ComboBox
        Me.edtName = New System.Windows.Forms.TextBox
        Me.edtTimeOut = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.edtDnsServer = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(209, 15)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(56, 20)
        Me.edtPort.TabIndex = 17
        Me.edtPort.Text = "53"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(185, 15)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(32, 23)
        Me.label6.TabIndex = 24
        Me.label6.Text = "Port"
        '
        'memResult
        '
        Me.memResult.Location = New System.Drawing.Point(17, 135)
        Me.memResult.Multiline = True
        Me.memResult.Name = "memResult"
        Me.memResult.ReadOnly = True
        Me.memResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memResult.Size = New System.Drawing.Size(400, 160)
        Me.memResult.TabIndex = 23
        Me.memResult.Text = ""
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(17, 111)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(40, 23)
        Me.label5.TabIndex = 22
        Me.label5.Text = "Result"
        '
        'btnResolve
        '
        Me.btnResolve.Location = New System.Drawing.Point(305, 79)
        Me.btnResolve.Name = "btnResolve"
        Me.btnResolve.Size = New System.Drawing.Size(112, 23)
        Me.btnResolve.TabIndex = 21
        Me.btnResolve.Text = "Resolve"
        '
        'cbNameType
        '
        Me.cbNameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNameType.Items.AddRange(New Object() {"MX (mail servers)", "A (IP addresses)", "PTR (host names)", "NS (name servers)"})
        Me.cbNameType.Location = New System.Drawing.Point(105, 79)
        Me.cbNameType.Name = "cbNameType"
        Me.cbNameType.Size = New System.Drawing.Size(120, 21)
        Me.cbNameType.TabIndex = 20
        '
        'edtName
        '
        Me.edtName.Location = New System.Drawing.Point(105, 47)
        Me.edtName.Name = "edtName"
        Me.edtName.Size = New System.Drawing.Size(312, 20)
        Me.edtName.TabIndex = 19
        Me.edtName.Text = "microsoft.com"
        '
        'edtTimeOut
        '
        Me.edtTimeOut.Location = New System.Drawing.Point(345, 15)
        Me.edtTimeOut.Name = "edtTimeOut"
        Me.edtTimeOut.Size = New System.Drawing.Size(72, 20)
        Me.edtTimeOut.TabIndex = 18
        Me.edtTimeOut.Text = "5"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(281, 15)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(64, 23)
        Me.label4.TabIndex = 16
        Me.label4.Text = "TimeOut, s"
        '
        'edtDnsServer
        '
        Me.edtDnsServer.Location = New System.Drawing.Point(105, 15)
        Me.edtDnsServer.Name = "edtDnsServer"
        Me.edtDnsServer.Size = New System.Drawing.Size(72, 20)
        Me.edtDnsServer.TabIndex = 15
        Me.edtDnsServer.Text = "192.168.0.1"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(17, 79)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(80, 23)
        Me.label3.TabIndex = 14
        Me.label3.Text = "Query Type"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(17, 47)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(96, 23)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Name to Resolve"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(17, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(88, 23)
        Me.label1.TabIndex = 12
        Me.label1.Text = "DNS Server"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(434, 310)
        Me.Controls.Add(Me.edtPort)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.memResult)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.btnResolve)
        Me.Controls.Add(Me.cbNameType)
        Me.Controls.Add(Me.edtName)
        Me.Controls.Add(Me.edtTimeOut)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.edtDnsServer)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "DNS Query demo"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FillMXResult()
        If DnsQuery1.MailServers.Count = 0 Then
            Return
        End If
        memResult.Text = memResult.Text + "====== Mail Servers ======" + ControlChars.Cr + ControlChars.Lf

        Dim mx As MailServerInfo
        For Each mx In DnsQuery1.MailServers
            memResult.Text = memResult.Text + [String].Format("{0}, Preference {1}, {2}" + ControlChars.Cr + ControlChars.Lf, mx.Name, mx.Preference, mx.IPAddress)
        Next mx

        memResult.Text = memResult.Text + ControlChars.Cr + ControlChars.Lf
    End Sub


    Private Sub FillHostResult()
        If DnsQuery1.Hosts.Count = 0 Then
            Return
        End If
        memResult.Text = memResult.Text + "====== Hosts ======" + ControlChars.Cr + ControlChars.Lf

        Dim host As HostInfo
        For Each host In DnsQuery1.Hosts
            memResult.Text = memResult.Text + [String].Format("{0}, {1}" + ControlChars.Cr + ControlChars.Lf, host.Name, host.IPAddress)
        Next host

        memResult.Text = memResult.Text + ControlChars.Cr + ControlChars.Lf
    End Sub


    Private Sub FillNameServerResult()
        If DnsQuery1.NameServers.Length = 0 Then
            Return
        End If
        memResult.Text = memResult.Text + "====== Name Servers ======" + ControlChars.Cr + ControlChars.Lf
        memResult.Text = memResult.Text + StringUtils.GetStringsAsString(DnsQuery1.NameServers)
        memResult.Text = memResult.Text + ControlChars.Cr + ControlChars.Lf
    End Sub


    Private Sub FillAliasResult()
        If DnsQuery1.Aliases.Length = 0 Then
            Return
        End If
        memResult.Text = memResult.Text + "====== Aliases ======" + ControlChars.Cr + ControlChars.Lf
        memResult.Text = memResult.Text + StringUtils.GetStringsAsString(DnsQuery1.Aliases)
        memResult.Text = memResult.Text + ControlChars.Cr + ControlChars.Lf
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnResolve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResolve.Click
        DnsQuery1.Server = edtDnsServer.Text
        DnsQuery1.Port = Convert.ToInt32(edtPort.Text)
        DnsQuery1.TimeOut = Convert.ToInt32(edtTimeOut.Text) * 1000

        Try
            Select Case cbNameType.SelectedIndex
                Case 0
                    DnsQuery1.ResolveMX(edtName.Text)
                Case 1
                    DnsQuery1.ResolveIP(edtName.Text)
                Case 2
                    DnsQuery1.ResolveHost(edtName.Text)
                Case 3
                    DnsQuery1.ResolveNS(edtName.Text)
            End Select

            memResult.Text = ""

            FillMXResult()
            FillHostResult()
            FillNameServerResult()
            FillAliasResult()

            MessageBox.Show("Done")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
