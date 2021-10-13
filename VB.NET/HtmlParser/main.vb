Imports System.IO
Imports CleverComponents.InetSuite

Public Class MainForm
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
    Friend WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabLinks As System.Windows.Forms.TabPage
    Friend WithEvents edtUrlName As System.Windows.Forms.TextBox
    Friend WithEvents edtUrlTarget As System.Windows.Forms.TextBox
    Friend WithEvents edtUrlHref As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents lbLinks As System.Windows.Forms.ListBox
    Friend WithEvents tabImages As System.Windows.Forms.TabPage
    Friend WithEvents edtImageHeight As System.Windows.Forms.TextBox
    Friend WithEvents edtImageWidth As System.Windows.Forms.TextBox
    Friend WithEvents edtImageAlt As System.Windows.Forms.TextBox
    Friend WithEvents edtImageSrc As System.Windows.Forms.TextBox
    Friend WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents lbImages As System.Windows.Forms.ListBox
    Friend WithEvents tabForms As System.Windows.Forms.TabPage
    Friend WithEvents edtFormMethod As System.Windows.Forms.TextBox
    Friend WithEvents edtFormName As System.Windows.Forms.TextBox
    Friend WithEvents edtFormEncType As System.Windows.Forms.TextBox
    Friend WithEvents edtFormAction As System.Windows.Forms.TextBox
    Friend WithEvents label15 As System.Windows.Forms.Label
    Friend WithEvents label14 As System.Windows.Forms.Label
    Friend WithEvents label13 As System.Windows.Forms.Label
    Friend WithEvents label12 As System.Windows.Forms.Label
    Friend WithEvents label11 As System.Windows.Forms.Label
    Friend WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents lbFormControls As System.Windows.Forms.ListBox
    Friend WithEvents lbForms As System.Windows.Forms.ListBox
    Friend WithEvents tabText As System.Windows.Forms.TabPage
    Friend WithEvents lbText As System.Windows.Forms.ListBox
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents HtmlParser1 As CleverComponents.InetSuite.HtmlParser
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabLinks = New System.Windows.Forms.TabPage()
        Me.edtUrlName = New System.Windows.Forms.TextBox()
        Me.edtUrlTarget = New System.Windows.Forms.TextBox()
        Me.edtUrlHref = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lbLinks = New System.Windows.Forms.ListBox()
        Me.tabImages = New System.Windows.Forms.TabPage()
        Me.edtImageHeight = New System.Windows.Forms.TextBox()
        Me.edtImageWidth = New System.Windows.Forms.TextBox()
        Me.edtImageAlt = New System.Windows.Forms.TextBox()
        Me.edtImageSrc = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.lbImages = New System.Windows.Forms.ListBox()
        Me.tabForms = New System.Windows.Forms.TabPage()
        Me.edtFormMethod = New System.Windows.Forms.TextBox()
        Me.edtFormName = New System.Windows.Forms.TextBox()
        Me.edtFormEncType = New System.Windows.Forms.TextBox()
        Me.edtFormAction = New System.Windows.Forms.TextBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.lbFormControls = New System.Windows.Forms.ListBox()
        Me.lbForms = New System.Windows.Forms.ListBox()
        Me.tabText = New System.Windows.Forms.TabPage()
        Me.lbText = New System.Windows.Forms.ListBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.HtmlParser1 = New CleverComponents.InetSuite.HtmlParser()
        Me.tabControl.SuspendLayout()
        Me.tabLinks.SuspendLayout()
        Me.tabImages.SuspendLayout()
        Me.tabForms.SuspendLayout()
        Me.tabText.SuspendLayout()
        Me.SuspendLayout()
        '
        'openFileDialog
        '
        Me.openFileDialog.Filter = "Html Files|*.htm|All Files|*.*"
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabLinks)
        Me.tabControl.Controls.Add(Me.tabImages)
        Me.tabControl.Controls.Add(Me.tabForms)
        Me.tabControl.Controls.Add(Me.tabText)
        Me.tabControl.Location = New System.Drawing.Point(20, 16)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(480, 272)
        Me.tabControl.TabIndex = 2
        '
        'tabLinks
        '
        Me.tabLinks.Controls.Add(Me.edtUrlName)
        Me.tabLinks.Controls.Add(Me.edtUrlTarget)
        Me.tabLinks.Controls.Add(Me.edtUrlHref)
        Me.tabLinks.Controls.Add(Me.label4)
        Me.tabLinks.Controls.Add(Me.label3)
        Me.tabLinks.Controls.Add(Me.label2)
        Me.tabLinks.Controls.Add(Me.label1)
        Me.tabLinks.Controls.Add(Me.lbLinks)
        Me.tabLinks.Location = New System.Drawing.Point(4, 22)
        Me.tabLinks.Name = "tabLinks"
        Me.tabLinks.Size = New System.Drawing.Size(472, 246)
        Me.tabLinks.TabIndex = 0
        Me.tabLinks.Text = "Links"
        '
        'edtUrlName
        '
        Me.edtUrlName.Location = New System.Drawing.Point(368, 216)
        Me.edtUrlName.Name = "edtUrlName"
        Me.edtUrlName.ReadOnly = True
        Me.edtUrlName.Size = New System.Drawing.Size(88, 20)
        Me.edtUrlName.TabIndex = 3
        '
        'edtUrlTarget
        '
        Me.edtUrlTarget.Location = New System.Drawing.Point(272, 216)
        Me.edtUrlTarget.Name = "edtUrlTarget"
        Me.edtUrlTarget.ReadOnly = True
        Me.edtUrlTarget.Size = New System.Drawing.Size(88, 20)
        Me.edtUrlTarget.TabIndex = 2
        '
        'edtUrlHref
        '
        Me.edtUrlHref.Location = New System.Drawing.Point(16, 216)
        Me.edtUrlHref.Name = "edtUrlHref"
        Me.edtUrlHref.ReadOnly = True
        Me.edtUrlHref.Size = New System.Drawing.Size(248, 20)
        Me.edtUrlHref.TabIndex = 1
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(368, 200)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(100, 23)
        Me.label4.TabIndex = 4
        Me.label4.Text = "Name"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(272, 200)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(100, 23)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Target"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 200)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(100, 23)
        Me.label2.TabIndex = 2
        Me.label2.Text = "URL"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Link Tags"
        '
        'lbLinks
        '
        Me.lbLinks.Location = New System.Drawing.Point(16, 32)
        Me.lbLinks.Name = "lbLinks"
        Me.lbLinks.Size = New System.Drawing.Size(440, 160)
        Me.lbLinks.TabIndex = 0
        '
        'tabImages
        '
        Me.tabImages.Controls.Add(Me.edtImageHeight)
        Me.tabImages.Controls.Add(Me.edtImageWidth)
        Me.tabImages.Controls.Add(Me.edtImageAlt)
        Me.tabImages.Controls.Add(Me.edtImageSrc)
        Me.tabImages.Controls.Add(Me.label9)
        Me.tabImages.Controls.Add(Me.label8)
        Me.tabImages.Controls.Add(Me.label7)
        Me.tabImages.Controls.Add(Me.label6)
        Me.tabImages.Controls.Add(Me.label5)
        Me.tabImages.Controls.Add(Me.lbImages)
        Me.tabImages.Location = New System.Drawing.Point(4, 22)
        Me.tabImages.Name = "tabImages"
        Me.tabImages.Size = New System.Drawing.Size(472, 246)
        Me.tabImages.TabIndex = 1
        Me.tabImages.Text = "Images"
        Me.tabImages.Visible = False
        '
        'edtImageHeight
        '
        Me.edtImageHeight.Location = New System.Drawing.Point(328, 216)
        Me.edtImageHeight.Name = "edtImageHeight"
        Me.edtImageHeight.ReadOnly = True
        Me.edtImageHeight.Size = New System.Drawing.Size(128, 20)
        Me.edtImageHeight.TabIndex = 4
        '
        'edtImageWidth
        '
        Me.edtImageWidth.Location = New System.Drawing.Point(328, 168)
        Me.edtImageWidth.Name = "edtImageWidth"
        Me.edtImageWidth.ReadOnly = True
        Me.edtImageWidth.Size = New System.Drawing.Size(128, 20)
        Me.edtImageWidth.TabIndex = 2
        '
        'edtImageAlt
        '
        Me.edtImageAlt.Location = New System.Drawing.Point(16, 216)
        Me.edtImageAlt.Name = "edtImageAlt"
        Me.edtImageAlt.ReadOnly = True
        Me.edtImageAlt.Size = New System.Drawing.Size(304, 20)
        Me.edtImageAlt.TabIndex = 3
        '
        'edtImageSrc
        '
        Me.edtImageSrc.Location = New System.Drawing.Point(16, 168)
        Me.edtImageSrc.Name = "edtImageSrc"
        Me.edtImageSrc.ReadOnly = True
        Me.edtImageSrc.Size = New System.Drawing.Size(304, 20)
        Me.edtImageSrc.TabIndex = 1
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(328, 200)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(100, 23)
        Me.label9.TabIndex = 5
        Me.label9.Text = "Height"
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(328, 152)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(100, 23)
        Me.label8.TabIndex = 4
        Me.label8.Text = "Width"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(16, 200)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(100, 23)
        Me.label7.TabIndex = 3
        Me.label7.Text = "Alt"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(16, 152)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(100, 23)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Src"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(16, 8)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(100, 23)
        Me.label5.TabIndex = 1
        Me.label5.Text = "Image Tags"
        '
        'lbImages
        '
        Me.lbImages.Location = New System.Drawing.Point(16, 32)
        Me.lbImages.Name = "lbImages"
        Me.lbImages.Size = New System.Drawing.Size(440, 108)
        Me.lbImages.TabIndex = 0
        '
        'tabForms
        '
        Me.tabForms.Controls.Add(Me.edtFormMethod)
        Me.tabForms.Controls.Add(Me.edtFormName)
        Me.tabForms.Controls.Add(Me.edtFormEncType)
        Me.tabForms.Controls.Add(Me.edtFormAction)
        Me.tabForms.Controls.Add(Me.label15)
        Me.tabForms.Controls.Add(Me.label14)
        Me.tabForms.Controls.Add(Me.label13)
        Me.tabForms.Controls.Add(Me.label12)
        Me.tabForms.Controls.Add(Me.label11)
        Me.tabForms.Controls.Add(Me.label10)
        Me.tabForms.Controls.Add(Me.lbFormControls)
        Me.tabForms.Controls.Add(Me.lbForms)
        Me.tabForms.Location = New System.Drawing.Point(4, 22)
        Me.tabForms.Name = "tabForms"
        Me.tabForms.Size = New System.Drawing.Size(472, 246)
        Me.tabForms.TabIndex = 2
        Me.tabForms.Text = "Forms"
        Me.tabForms.Visible = False
        '
        'edtFormMethod
        '
        Me.edtFormMethod.Location = New System.Drawing.Point(312, 216)
        Me.edtFormMethod.Name = "edtFormMethod"
        Me.edtFormMethod.ReadOnly = True
        Me.edtFormMethod.Size = New System.Drawing.Size(144, 20)
        Me.edtFormMethod.TabIndex = 5
        '
        'edtFormName
        '
        Me.edtFormName.Location = New System.Drawing.Point(312, 168)
        Me.edtFormName.Name = "edtFormName"
        Me.edtFormName.ReadOnly = True
        Me.edtFormName.Size = New System.Drawing.Size(144, 20)
        Me.edtFormName.TabIndex = 3
        '
        'edtFormEncType
        '
        Me.edtFormEncType.Location = New System.Drawing.Point(16, 216)
        Me.edtFormEncType.Name = "edtFormEncType"
        Me.edtFormEncType.ReadOnly = True
        Me.edtFormEncType.Size = New System.Drawing.Size(280, 20)
        Me.edtFormEncType.TabIndex = 4
        '
        'edtFormAction
        '
        Me.edtFormAction.Location = New System.Drawing.Point(16, 168)
        Me.edtFormAction.Name = "edtFormAction"
        Me.edtFormAction.ReadOnly = True
        Me.edtFormAction.Size = New System.Drawing.Size(280, 20)
        Me.edtFormAction.TabIndex = 2
        '
        'label15
        '
        Me.label15.Location = New System.Drawing.Point(312, 200)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(100, 23)
        Me.label15.TabIndex = 7
        Me.label15.Text = "Method"
        '
        'label14
        '
        Me.label14.Location = New System.Drawing.Point(312, 152)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(100, 23)
        Me.label14.TabIndex = 6
        Me.label14.Text = "Form Name"
        '
        'label13
        '
        Me.label13.Location = New System.Drawing.Point(16, 200)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(100, 23)
        Me.label13.TabIndex = 5
        Me.label13.Text = "Enc Type"
        '
        'label12
        '
        Me.label12.Location = New System.Drawing.Point(16, 152)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(100, 23)
        Me.label12.TabIndex = 4
        Me.label12.Text = "Action"
        '
        'label11
        '
        Me.label11.Location = New System.Drawing.Point(312, 8)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(100, 23)
        Me.label11.TabIndex = 3
        Me.label11.Text = "Controls"
        '
        'label10
        '
        Me.label10.Location = New System.Drawing.Point(16, 8)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(100, 23)
        Me.label10.TabIndex = 2
        Me.label10.Text = "Form Tags"
        '
        'lbFormControls
        '
        Me.lbFormControls.Location = New System.Drawing.Point(312, 32)
        Me.lbFormControls.Name = "lbFormControls"
        Me.lbFormControls.Size = New System.Drawing.Size(144, 108)
        Me.lbFormControls.TabIndex = 1
        '
        'lbForms
        '
        Me.lbForms.Location = New System.Drawing.Point(16, 32)
        Me.lbForms.Name = "lbForms"
        Me.lbForms.Size = New System.Drawing.Size(280, 108)
        Me.lbForms.TabIndex = 0
        '
        'tabText
        '
        Me.tabText.Controls.Add(Me.lbText)
        Me.tabText.Location = New System.Drawing.Point(4, 22)
        Me.tabText.Name = "tabText"
        Me.tabText.Size = New System.Drawing.Size(472, 246)
        Me.tabText.TabIndex = 3
        Me.tabText.Text = "Text"
        Me.tabText.Visible = False
        '
        'lbText
        '
        Me.lbText.Location = New System.Drawing.Point(16, 16)
        Me.lbText.Name = "lbText"
        Me.lbText.Size = New System.Drawing.Size(440, 212)
        Me.lbText.TabIndex = 0
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(20, 296)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 3
        Me.btnOpen.Text = "Open File"
        '
        'HtmlParser1
        '
        Me.HtmlParser1.ParseMethod = CleverComponents.InetSuite.ParseMethod.All
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 334)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.tabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Html Parser sample"
        Me.tabControl.ResumeLayout(False)
        Me.tabLinks.ResumeLayout(False)
        Me.tabLinks.PerformLayout()
        Me.tabImages.ResumeLayout(False)
        Me.tabImages.PerformLayout()
        Me.tabForms.ResumeLayout(False)
        Me.tabForms.PerformLayout()
        Me.tabText.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Sub AssignListBox(ByVal [source] As HtmlTagList, ByVal listBox As ListBox)
        listBox.Items.Clear()
        Dim tag As HtmlTag
        For Each tag In [source]
            listBox.Items.Add(tag.TagSource)
        Next tag
    End Sub 'AssignListBox

    Sub btnOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        If openFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            lbText.Items.Clear()
            Dim reader As StreamReader = File.OpenText(openFileDialog.FileName)
            HtmlParser1.Parse(reader.ReadToEnd())
            AssignListBox(HtmlParser1.Links, lbLinks)
            AssignListBox(HtmlParser1.Images, lbImages)
            AssignListBox(HtmlParser1.Forms, lbForms)
        End If
    End Sub 'btnOpen_Click


    Sub lbLinks_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbLinks.SelectedIndexChanged
        Dim item As HtmlLink = HtmlParser1.Links.Item(lbLinks.SelectedIndex)
        edtUrlHref.Text = item.Href
        edtUrlTarget.Text = item.Target
        edtUrlName.Text = item.name
    End Sub 'lbLinks_SelectedIndexChanged


    Sub lbImages_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbImages.SelectedIndexChanged
        Dim item As HtmlImage = HtmlParser1.Images.Item(lbImages.SelectedIndex)
        edtImageSrc.Text = item.Src
        edtImageAlt.Text = item.Alt
        edtImageWidth.Text = item.Width.ToString()
        edtImageHeight.Text = item.Height.ToString()
    End Sub 'lbImages_SelectedIndexChanged


    Sub lbForms_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbForms.SelectedIndexChanged
        Dim item As HtmlForm = HtmlParser1.Forms.Item(lbForms.SelectedIndex)
        edtFormAction.Text = item.action
        edtFormEncType.Text = item.EncType
        edtFormName.Text = item.FormName
        edtFormMethod.Text = item.Method
        AssignListBox(item.Controls, lbFormControls)
    End Sub 'lbForms_SelectedIndexChanged


    Private Sub HtmlParser1_ParseTag(ByVal sender As Object, ByVal e As CleverComponents.InetSuite.ParseTagEventArgs) Handles HtmlParser1.ParseTag
        If e.Tag.IsText And Not e.Tag.Text.Trim().Equals("") Then
            lbText.Items.Add(e.Tag.Text)
        End If
    End Sub
End Class
