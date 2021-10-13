Imports System.IO
Imports CleverComponents.InetSuite

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        cbEncoding.SelectedIndex = 1
        cbEncodingFile.SelectedIndex = 1
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
    Friend WithEvents btnDecodeFile As System.Windows.Forms.Button
    Friend WithEvents btnEncodeFile As System.Windows.Forms.Button
    Friend WithEvents cbEncodingFile As System.Windows.Forms.ComboBox
    Friend WithEvents edtDestinationFile As System.Windows.Forms.TextBox
    Friend WithEvents edtSourceFile As System.Windows.Forms.TextBox
    Friend WithEvents btnDecode As System.Windows.Forms.Button
    Friend WithEvents btnEncode As System.Windows.Forms.Button
    Friend WithEvents cbEncoding As System.Windows.Forms.ComboBox
    Friend WithEvents edtDestination As System.Windows.Forms.TextBox
    Friend WithEvents edtSource As System.Windows.Forms.TextBox
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Encoder1 As CleverComponents.InetSuite.Encoder
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnDecodeFile = New System.Windows.Forms.Button()
        Me.btnEncodeFile = New System.Windows.Forms.Button()
        Me.cbEncodingFile = New System.Windows.Forms.ComboBox()
        Me.edtDestinationFile = New System.Windows.Forms.TextBox()
        Me.edtSourceFile = New System.Windows.Forms.TextBox()
        Me.btnDecode = New System.Windows.Forms.Button()
        Me.btnEncode = New System.Windows.Forms.Button()
        Me.cbEncoding = New System.Windows.Forms.ComboBox()
        Me.edtDestination = New System.Windows.Forms.TextBox()
        Me.edtSource = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Encoder1 = New CleverComponents.InetSuite.Encoder()
        Me.SuspendLayout()
        '
        'btnDecodeFile
        '
        Me.btnDecodeFile.Location = New System.Drawing.Point(224, 328)
        Me.btnDecodeFile.Name = "btnDecodeFile"
        Me.btnDecodeFile.Size = New System.Drawing.Size(75, 23)
        Me.btnDecodeFile.TabIndex = 37
        Me.btnDecodeFile.Text = "Decode"
        '
        'btnEncodeFile
        '
        Me.btnEncodeFile.Location = New System.Drawing.Point(120, 328)
        Me.btnEncodeFile.Name = "btnEncodeFile"
        Me.btnEncodeFile.Size = New System.Drawing.Size(75, 23)
        Me.btnEncodeFile.TabIndex = 36
        Me.btnEncodeFile.Text = "Encode"
        '
        'cbEncodingFile
        '
        Me.cbEncodingFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEncodingFile.Items.AddRange(New Object() {"Quoted Printable", "Base 64", "UUE"})
        Me.cbEncodingFile.Location = New System.Drawing.Point(120, 296)
        Me.cbEncodingFile.Name = "cbEncodingFile"
        Me.cbEncodingFile.Size = New System.Drawing.Size(152, 21)
        Me.cbEncodingFile.TabIndex = 35
        '
        'edtDestinationFile
        '
        Me.edtDestinationFile.Location = New System.Drawing.Point(120, 264)
        Me.edtDestinationFile.Name = "edtDestinationFile"
        Me.edtDestinationFile.Size = New System.Drawing.Size(296, 20)
        Me.edtDestinationFile.TabIndex = 34
        Me.edtDestinationFile.Text = "image001_encoded.txt"
        '
        'edtSourceFile
        '
        Me.edtSourceFile.Location = New System.Drawing.Point(120, 240)
        Me.edtSourceFile.Name = "edtSourceFile"
        Me.edtSourceFile.Size = New System.Drawing.Size(296, 20)
        Me.edtSourceFile.TabIndex = 33
        Me.edtSourceFile.Text = "image001.jpg"
        '
        'btnDecode
        '
        Me.btnDecode.Location = New System.Drawing.Point(224, 192)
        Me.btnDecode.Name = "btnDecode"
        Me.btnDecode.Size = New System.Drawing.Size(75, 23)
        Me.btnDecode.TabIndex = 32
        Me.btnDecode.Text = "Decode"
        '
        'btnEncode
        '
        Me.btnEncode.Location = New System.Drawing.Point(120, 192)
        Me.btnEncode.Name = "btnEncode"
        Me.btnEncode.Size = New System.Drawing.Size(75, 23)
        Me.btnEncode.TabIndex = 31
        Me.btnEncode.Text = "Encode"
        '
        'cbEncoding
        '
        Me.cbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEncoding.Items.AddRange(New Object() {"Quoted Printable", "Base 64", "UUE"})
        Me.cbEncoding.Location = New System.Drawing.Point(120, 160)
        Me.cbEncoding.Name = "cbEncoding"
        Me.cbEncoding.Size = New System.Drawing.Size(152, 21)
        Me.cbEncoding.TabIndex = 30
        '
        'edtDestination
        '
        Me.edtDestination.Location = New System.Drawing.Point(120, 128)
        Me.edtDestination.Name = "edtDestination"
        Me.edtDestination.ReadOnly = True
        Me.edtDestination.Size = New System.Drawing.Size(296, 20)
        Me.edtDestination.TabIndex = 29
        '
        'edtSource
        '
        Me.edtSource.Location = New System.Drawing.Point(120, 104)
        Me.edtSource.Name = "edtSource"
        Me.edtSource.Size = New System.Drawing.Size(296, 20)
        Me.edtSource.TabIndex = 28
        Me.edtSource.Text = "sample text to encode"
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(16, 296)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(100, 16)
        Me.label8.TabIndex = 27
        Me.label8.Text = "Encoding Format"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(16, 264)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(100, 16)
        Me.label7.TabIndex = 26
        Me.label7.Text = "Destination File"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(16, 240)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(100, 16)
        Me.label6.TabIndex = 25
        Me.label6.Text = "Source File"
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Location = New System.Drawing.Point(16, 224)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(400, 1)
        Me.panel1.TabIndex = 24
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(16, 160)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(100, 16)
        Me.label5.TabIndex = 23
        Me.label5.Text = "Encoding Format"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 128)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(100, 16)
        Me.label4.TabIndex = 22
        Me.label4.Text = "Result String"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 104)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(100, 16)
        Me.label3.TabIndex = 21
        Me.label3.Text = "Source String"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 56)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(408, 32)
        Me.label2.TabIndex = 20
        Me.label2.Text = "Please select the source and destination files, the required encoding format and " &
    "press the Encode or Decode buttons."
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(408, 32)
        Me.label1.TabIndex = 19
        Me.label1.Text = "This demo demonstrates how to decode / encode a file using the base64, UUE or Quo" &
    "tedPrintable encoding formats."
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 366)
        Me.Controls.Add(Me.btnDecodeFile)
        Me.Controls.Add(Me.btnEncodeFile)
        Me.Controls.Add(Me.cbEncodingFile)
        Me.Controls.Add(Me.edtDestinationFile)
        Me.Controls.Add(Me.edtSourceFile)
        Me.Controls.Add(Me.btnDecode)
        Me.Controls.Add(Me.btnEncode)
        Me.Controls.Add(Me.cbEncoding)
        Me.Controls.Add(Me.edtDestination)
        Me.Controls.Add(Me.edtSource)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnEncode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncode.Click
        On Error GoTo Err
        Encoder1.EncodeMethod = CType(cbEncoding.SelectedIndex + 1, EncodeMethod)
        edtDestination.Text = Encoder1.Encode(edtSource.Text)
        Return
Err:
        MessageBox.Show(Err.Description)
    End Sub

    Private Sub btnDecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecode.Click
        On Error GoTo Err
        Encoder1.EncodeMethod = CType(cbEncoding.SelectedIndex + 1, EncodeMethod)
        edtDestination.Text = Encoder1.Decode(edtSource.Text)
        Return
Err:
        MessageBox.Show(Err.Description)
    End Sub

    Private Sub btnEncodeFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncodeFile.Click
        On Error GoTo Err
        Dim source As New FileStream(edtSourceFile.Text, FileMode.Open, FileAccess.Read)
        Dim dest As New FileStream(edtDestinationFile.Text, FileMode.Create)
        Encoder1.EncodeMethod = CType(cbEncodingFile.SelectedIndex + 1, EncodeMethod)
        Encoder1.Encode(source, dest)
        dest.Close()
        source.Close()
        MessageBox.Show("Done")
        Return
Err:
        MessageBox.Show(Err.Description)
    End Sub

    Private Sub btnDecodeFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecodeFile.Click
        On Error GoTo Err
        Dim source As New FileStream(edtSourceFile.Text, FileMode.Open, FileAccess.Read)
        Dim dest As New FileStream(edtDestinationFile.Text, FileMode.Create)
        Encoder1.EncodeMethod = CType(cbEncodingFile.SelectedIndex + 1, EncodeMethod)
        Encoder1.Decode(source, dest)
        dest.Close()
        source.Close()
        MessageBox.Show("Done")
        Return
Err:
        MessageBox.Show(Err.Description)
    End Sub
End Class
