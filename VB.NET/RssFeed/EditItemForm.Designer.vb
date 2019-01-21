<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditItemForm
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
		Me.button2 = New System.Windows.Forms.Button
		Me.button1 = New System.Windows.Forms.Button
		Me.edtGuid = New System.Windows.Forms.TextBox
		Me.label5 = New System.Windows.Forms.Label
		Me.edtPubDate = New System.Windows.Forms.DateTimePicker
		Me.label4 = New System.Windows.Forms.Label
		Me.edtDescription = New System.Windows.Forms.TextBox
		Me.label3 = New System.Windows.Forms.Label
		Me.edtLink = New System.Windows.Forms.TextBox
		Me.label2 = New System.Windows.Forms.Label
		Me.edtTitle = New System.Windows.Forms.TextBox
		Me.label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		'
		'button2
		'
		Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.button2.Location = New System.Drawing.Point(285, 156)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(75, 23)
		Me.button2.TabIndex = 23
		Me.button2.Text = "Cancel"
		Me.button2.UseVisualStyleBackColor = True
		'
		'button1
		'
		Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.button1.Location = New System.Drawing.Point(178, 156)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(75, 23)
		Me.button1.TabIndex = 22
		Me.button1.Text = "OK"
		Me.button1.UseVisualStyleBackColor = True
		'
		'edtGuid
		'
		Me.edtGuid.Location = New System.Drawing.Point(87, 117)
		Me.edtGuid.Name = "edtGuid"
		Me.edtGuid.Size = New System.Drawing.Size(273, 20)
		Me.edtGuid.TabIndex = 21
		Me.edtGuid.Text = "New_version_released"
		'
		'label5
		'
		Me.label5.AutoSize = True
		Me.label5.Location = New System.Drawing.Point(21, 120)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(34, 13)
		Me.label5.TabIndex = 20
		Me.label5.Text = "GUID"
		'
		'edtPubDate
		'
		Me.edtPubDate.Location = New System.Drawing.Point(87, 91)
		Me.edtPubDate.Name = "edtPubDate"
		Me.edtPubDate.Size = New System.Drawing.Size(200, 20)
		Me.edtPubDate.TabIndex = 19
		'
		'label4
		'
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(21, 95)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(52, 13)
		Me.label4.TabIndex = 18
		Me.label4.Text = "Pub Date"
		'
		'edtDescription
		'
		Me.edtDescription.Location = New System.Drawing.Point(87, 65)
		Me.edtDescription.Name = "edtDescription"
		Me.edtDescription.Size = New System.Drawing.Size(273, 20)
		Me.edtDescription.TabIndex = 17
		Me.edtDescription.Text = "New version released."
		'
		'label3
		'
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(21, 68)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(60, 13)
		Me.label3.TabIndex = 16
		Me.label3.Text = "Description"
		'
		'edtLink
		'
		Me.edtLink.Location = New System.Drawing.Point(87, 39)
		Me.edtLink.Name = "edtLink"
		Me.edtLink.Size = New System.Drawing.Size(273, 20)
		Me.edtLink.TabIndex = 15
		Me.edtLink.Text = "http://www.sample.com/news.html"
		'
		'label2
		'
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(21, 42)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(27, 13)
		Me.label2.TabIndex = 14
		Me.label2.Text = "Link"
		'
		'edtTitle
		'
		Me.edtTitle.Location = New System.Drawing.Point(87, 13)
		Me.edtTitle.Name = "edtTitle"
		Me.edtTitle.Size = New System.Drawing.Size(273, 20)
		Me.edtTitle.TabIndex = 13
		Me.edtTitle.Text = "News Title"
		'
		'label1
		'
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(21, 16)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(27, 13)
		Me.label1.TabIndex = 12
		Me.label1.Text = "Title"
		'
		'EditItemForm
		'
		Me.AcceptButton = Me.button1
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.button2
		Me.ClientSize = New System.Drawing.Size(381, 192)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.edtGuid)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.edtPubDate)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.edtDescription)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.edtLink)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.edtTitle)
		Me.Controls.Add(Me.label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Name = "EditItemForm"
		Me.Text = "RSS News Item"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Public WithEvents edtGuid As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Public WithEvents edtPubDate As System.Windows.Forms.DateTimePicker
    Private WithEvents label4 As System.Windows.Forms.Label
    Public WithEvents edtDescription As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Public WithEvents edtLink As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Public WithEvents edtTitle As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
