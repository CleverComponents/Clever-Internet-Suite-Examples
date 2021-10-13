<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.edtHost = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.Port = New System.Windows.Forms.Label()
        Me.edtPort = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.AsyncClient1 = New CleverComponents.InetSuite.AsyncClient()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Host"
        '
        'edtHost
        '
        Me.edtHost.Location = New System.Drawing.Point(115, 17)
        Me.edtHost.Name = "edtHost"
        Me.edtHost.Size = New System.Drawing.Size(251, 20)
        Me.edtHost.TabIndex = 1
        Me.edtHost.Text = "localhost"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(385, 15)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'Port
        '
        Me.Port.AutoSize = True
        Me.Port.Location = New System.Drawing.Point(65, 53)
        Me.Port.Name = "Port"
        Me.Port.Size = New System.Drawing.Size(26, 13)
        Me.Port.TabIndex = 3
        Me.Port.Text = "Port"
        '
        'edtPort
        '
        Me.edtPort.Location = New System.Drawing.Point(115, 50)
        Me.edtPort.Name = "edtPort"
        Me.edtPort.Size = New System.Drawing.Size(100, 20)
        Me.edtPort.TabIndex = 4
        Me.edtPort.Text = "23"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(4, 79)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox1.Size = New System.Drawing.Size(475, 289)
        Me.textBox1.TabIndex = 5
        '
        'AsyncClient1
        '
        Me.AsyncClient1.LocalBinding = Nothing
        Me.AsyncClient1.Server = Nothing
        Me.AsyncClient1.TlsFlags = CleverComponents.InetSuite.Sspi.TlsFlags.None
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 370)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.edtPort)
        Me.Controls.Add(Me.Port)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.edtHost)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asynchronous client sample - TELNET"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents edtHost As System.Windows.Forms.TextBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents Port As System.Windows.Forms.Label
    Friend WithEvents edtPort As System.Windows.Forms.TextBox
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AsyncClient1 As CleverComponents.InetSuite.AsyncClient

End Class
