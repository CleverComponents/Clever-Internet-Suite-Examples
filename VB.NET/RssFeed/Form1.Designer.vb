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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lbNews = New System.Windows.Forms.ListBox()
        Me.edtImageUrl = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.edtGenerator = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.edtWebMaster = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.edtLanguage = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.edtCopyright = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.edtDescription = New System.Windows.Forms.TextBox()
        Me.edtLink = New System.Windows.Forms.TextBox()
        Me.edtTitle = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Rss1 = New CleverComponents.InetSuite.Rss()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(328, 377)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 53
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(328, 348)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 52
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(328, 318)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 51
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(328, 257)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 50
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(328, 228)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 49
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lbNews
        '
        Me.lbNews.FormattingEnabled = True
        Me.lbNews.Location = New System.Drawing.Point(22, 228)
        Me.lbNews.Name = "lbNews"
        Me.lbNews.Size = New System.Drawing.Size(287, 173)
        Me.lbNews.TabIndex = 48
        '
        'edtImageUrl
        '
        Me.edtImageUrl.Location = New System.Drawing.Point(97, 195)
        Me.edtImageUrl.Name = "edtImageUrl"
        Me.edtImageUrl.Size = New System.Drawing.Size(306, 20)
        Me.edtImageUrl.TabIndex = 47
        Me.edtImageUrl.Text = "http://www.sample.com/image.gif"
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(19, 195)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(72, 16)
        Me.label9.TabIndex = 46
        Me.label9.Text = "Image"
        '
        'edtGenerator
        '
        Me.edtGenerator.Location = New System.Drawing.Point(97, 169)
        Me.edtGenerator.Name = "edtGenerator"
        Me.edtGenerator.Size = New System.Drawing.Size(306, 20)
        Me.edtGenerator.TabIndex = 45
        Me.edtGenerator.Text = "Clever Internet Suite 7.2 RSS Component"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(19, 169)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 16)
        Me.label4.TabIndex = 44
        Me.label4.Text = "Generator"
        '
        'edtWebMaster
        '
        Me.edtWebMaster.Location = New System.Drawing.Point(97, 143)
        Me.edtWebMaster.Name = "edtWebMaster"
        Me.edtWebMaster.Size = New System.Drawing.Size(306, 20)
        Me.edtWebMaster.TabIndex = 43
        Me.edtWebMaster.Text = "webmaster@sample.com"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(19, 143)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(72, 16)
        Me.label3.TabIndex = 42
        Me.label3.Text = "Web Master"
        '
        'edtLanguage
        '
        Me.edtLanguage.Location = New System.Drawing.Point(97, 117)
        Me.edtLanguage.Name = "edtLanguage"
        Me.edtLanguage.Size = New System.Drawing.Size(306, 20)
        Me.edtLanguage.TabIndex = 41
        Me.edtLanguage.Text = "en-US"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(19, 117)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 16)
        Me.label2.TabIndex = 40
        Me.label2.Text = "Language"
        '
        'edtCopyright
        '
        Me.edtCopyright.Location = New System.Drawing.Point(97, 91)
        Me.edtCopyright.Name = "edtCopyright"
        Me.edtCopyright.Size = New System.Drawing.Size(306, 20)
        Me.edtCopyright.TabIndex = 39
        Me.edtCopyright.Text = "Copyright 2010 Company Inc."
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(19, 91)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 16)
        Me.label1.TabIndex = 38
        Me.label1.Text = "Copyright"
        '
        'edtDescription
        '
        Me.edtDescription.Location = New System.Drawing.Point(97, 65)
        Me.edtDescription.Name = "edtDescription"
        Me.edtDescription.Size = New System.Drawing.Size(306, 20)
        Me.edtDescription.TabIndex = 37
        Me.edtDescription.Text = "Demo company description"
        '
        'edtLink
        '
        Me.edtLink.Location = New System.Drawing.Point(97, 41)
        Me.edtLink.Name = "edtLink"
        Me.edtLink.Size = New System.Drawing.Size(306, 20)
        Me.edtLink.TabIndex = 36
        Me.edtLink.Text = "http://www.sample.com"
        '
        'edtTitle
        '
        Me.edtTitle.Location = New System.Drawing.Point(97, 17)
        Me.edtTitle.Name = "edtTitle"
        Me.edtTitle.Size = New System.Drawing.Size(306, 20)
        Me.edtTitle.TabIndex = 35
        Me.edtTitle.Text = "Demo Company - News"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(19, 65)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(72, 16)
        Me.label7.TabIndex = 34
        Me.label7.Text = "Description"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(19, 41)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(64, 16)
        Me.label6.TabIndex = 33
        Me.label6.Text = "Link"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(19, 17)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(72, 16)
        Me.label5.TabIndex = 32
        Me.label5.Text = "Title"
        '
        'openFileDialog
        '
        Me.openFileDialog.Filter = "RSS Files (*.xml)|*.xml|All Files (*.*)|*.*"
        '
        'saveFileDialog
        '
        Me.saveFileDialog.Filter = "RSS Files (*.xml)|*.xml|All Files (*.*)|*.*"
        Me.saveFileDialog.OverwritePrompt = False
        '
        'Rss1
        '
        Me.Rss1.Channel.LastBuildDate = New Date(CType(0, Long))
        Me.Rss1.Channel.PubDate = New Date(CType(0, Long))
        Me.Rss1.CharSet = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 419)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lbNews)
        Me.Controls.Add(Me.edtImageUrl)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.edtGenerator)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.edtWebMaster)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.edtLanguage)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.edtCopyright)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.edtDescription)
        Me.Controls.Add(Me.edtLink)
        Me.Controls.Add(Me.edtTitle)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RSS Feed Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents btnLoad As System.Windows.Forms.Button
    Private WithEvents btnClear As System.Windows.Forms.Button
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Private WithEvents lbNews As System.Windows.Forms.ListBox
    Private WithEvents edtImageUrl As System.Windows.Forms.TextBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents edtGenerator As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents edtWebMaster As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents edtLanguage As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents edtCopyright As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents edtDescription As System.Windows.Forms.TextBox
    Private WithEvents edtLink As System.Windows.Forms.TextBox
    Private WithEvents edtTitle As System.Windows.Forms.TextBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Private WithEvents saveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Rss1 As CleverComponents.InetSuite.Rss

End Class
