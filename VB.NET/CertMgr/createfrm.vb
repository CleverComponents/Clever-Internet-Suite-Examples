Public Class CreateCertForm
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
    Public WithEvents edtKeyName As System.Windows.Forms.TextBox
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents edtL As System.Windows.Forms.TextBox
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnOk As System.Windows.Forms.Button
    Public WithEvents edtStoreName As System.Windows.Forms.TextBox
    Public WithEvents edtValidTo As System.Windows.Forms.TextBox
    Public WithEvents edtValidFrom As System.Windows.Forms.TextBox
    Public WithEvents edtSerial As System.Windows.Forms.TextBox
    Private WithEvents edtE As System.Windows.Forms.TextBox
    Private WithEvents edtC As System.Windows.Forms.TextBox
    Private WithEvents edtS As System.Windows.Forms.TextBox
    Private WithEvents edtOU As System.Windows.Forms.TextBox
    Private WithEvents edtO As System.Windows.Forms.TextBox
    Private WithEvents edtCN As System.Windows.Forms.TextBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Public WithEvents cbEmailProtection As System.Windows.Forms.CheckBox
    Public WithEvents cbCodeSigning As System.Windows.Forms.CheckBox
    Public WithEvents cbClientAuth As System.Windows.Forms.CheckBox
    Public WithEvents cbServerAuth As System.Windows.Forms.CheckBox
    Private WithEvents label14 As System.Windows.Forms.Label
    Public WithEvents edtKeyLength As System.Windows.Forms.TextBox
    Private WithEvents label13 As System.Windows.Forms.Label
    Public WithEvents edtFriendlyName As System.Windows.Forms.TextBox
    Private WithEvents label15 As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.edtKeyName = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.edtL = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.edtStoreName = New System.Windows.Forms.TextBox()
        Me.edtValidTo = New System.Windows.Forms.TextBox()
        Me.edtValidFrom = New System.Windows.Forms.TextBox()
        Me.edtSerial = New System.Windows.Forms.TextBox()
        Me.edtE = New System.Windows.Forms.TextBox()
        Me.edtC = New System.Windows.Forms.TextBox()
        Me.edtS = New System.Windows.Forms.TextBox()
        Me.edtOU = New System.Windows.Forms.TextBox()
        Me.edtO = New System.Windows.Forms.TextBox()
        Me.edtCN = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cbEmailProtection = New System.Windows.Forms.CheckBox()
        Me.cbCodeSigning = New System.Windows.Forms.CheckBox()
        Me.cbClientAuth = New System.Windows.Forms.CheckBox()
        Me.cbServerAuth = New System.Windows.Forms.CheckBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.edtKeyLength = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.edtFriendlyName = New System.Windows.Forms.TextBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'edtKeyName
        '
        Me.edtKeyName.Location = New System.Drawing.Point(121, 231)
        Me.edtKeyName.Name = "edtKeyName"
        Me.edtKeyName.Size = New System.Drawing.Size(328, 20)
        Me.edtKeyName.TabIndex = 44
        Me.edtKeyName.Text = "testkeyname-99046937-7D4A-441A-8621-5CDADA8AF9DC"
        '
        'label12
        '
        Me.label12.Location = New System.Drawing.Point(9, 231)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(100, 23)
        Me.label12.TabIndex = 49
        Me.label12.Text = "Key Name"
        '
        'edtL
        '
        Me.edtL.Location = New System.Drawing.Point(121, 131)
        Me.edtL.Name = "edtL"
        Me.edtL.Size = New System.Drawing.Size(104, 20)
        Me.edtL.TabIndex = 39
        Me.edtL.Text = "SF"
        '
        'label11
        '
        Me.label11.Location = New System.Drawing.Point(9, 131)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(100, 23)
        Me.label11.TabIndex = 47
        Me.label11.Text = "Location"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(252, 375)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 59
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(116, 375)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 58
        Me.btnOk.Text = "OK"
        '
        'edtStoreName
        '
        Me.edtStoreName.Location = New System.Drawing.Point(12, 349)
        Me.edtStoreName.Name = "edtStoreName"
        Me.edtStoreName.ReadOnly = True
        Me.edtStoreName.Size = New System.Drawing.Size(437, 20)
        Me.edtStoreName.TabIndex = 57
        '
        'edtValidTo
        '
        Me.edtValidTo.Location = New System.Drawing.Point(345, 205)
        Me.edtValidTo.Name = "edtValidTo"
        Me.edtValidTo.Size = New System.Drawing.Size(104, 20)
        Me.edtValidTo.TabIndex = 43
        '
        'edtValidFrom
        '
        Me.edtValidFrom.Location = New System.Drawing.Point(121, 205)
        Me.edtValidFrom.Name = "edtValidFrom"
        Me.edtValidFrom.Size = New System.Drawing.Size(104, 20)
        Me.edtValidFrom.TabIndex = 42
        '
        'edtSerial
        '
        Me.edtSerial.Location = New System.Drawing.Point(121, 181)
        Me.edtSerial.Name = "edtSerial"
        Me.edtSerial.Size = New System.Drawing.Size(80, 20)
        Me.edtSerial.TabIndex = 41
        Me.edtSerial.Text = "1"
        '
        'edtE
        '
        Me.edtE.Location = New System.Drawing.Point(121, 157)
        Me.edtE.Name = "edtE"
        Me.edtE.Size = New System.Drawing.Size(328, 20)
        Me.edtE.TabIndex = 40
        Me.edtE.Text = "CleverTester@company.mail"
        '
        'edtC
        '
        Me.edtC.Location = New System.Drawing.Point(345, 108)
        Me.edtC.Name = "edtC"
        Me.edtC.Size = New System.Drawing.Size(104, 20)
        Me.edtC.TabIndex = 38
        Me.edtC.Text = "US"
        '
        'edtS
        '
        Me.edtS.Location = New System.Drawing.Point(121, 108)
        Me.edtS.Name = "edtS"
        Me.edtS.Size = New System.Drawing.Size(104, 20)
        Me.edtS.TabIndex = 37
        Me.edtS.Text = "CA"
        '
        'edtOU
        '
        Me.edtOU.Location = New System.Drawing.Point(121, 84)
        Me.edtOU.Name = "edtOU"
        Me.edtOU.Size = New System.Drawing.Size(328, 20)
        Me.edtOU.TabIndex = 36
        Me.edtOU.Text = "Demos"
        '
        'edtO
        '
        Me.edtO.Location = New System.Drawing.Point(121, 60)
        Me.edtO.Name = "edtO"
        Me.edtO.Size = New System.Drawing.Size(328, 20)
        Me.edtO.TabIndex = 35
        Me.edtO.Text = "YourCompany"
        '
        'edtCN
        '
        Me.edtCN.Location = New System.Drawing.Point(121, 36)
        Me.edtCN.Name = "edtCN"
        Me.edtCN.Size = New System.Drawing.Size(328, 20)
        Me.edtCN.TabIndex = 34
        Me.edtCN.Text = "CleverTester"
        '
        'label10
        '
        Me.label10.Location = New System.Drawing.Point(18, 334)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(448, 23)
        Me.label10.TabIndex = 33
        Me.label10.Text = "The new certificate will be created and installed in to the currently loaded Syst" &
    "em Store:"
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(249, 205)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(64, 23)
        Me.label9.TabIndex = 32
        Me.label9.Text = "Valid To"
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(9, 205)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(100, 23)
        Me.label8.TabIndex = 31
        Me.label8.Text = "Valid From"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(9, 181)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(100, 23)
        Me.label7.TabIndex = 30
        Me.label7.Text = "Serial Number"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(9, 157)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(100, 23)
        Me.label6.TabIndex = 29
        Me.label6.Text = "Email"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(257, 108)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(56, 23)
        Me.label5.TabIndex = 28
        Me.label5.Text = "Country"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(9, 108)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(100, 23)
        Me.label4.TabIndex = 27
        Me.label4.Text = "State"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(9, 84)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(104, 23)
        Me.label3.TabIndex = 26
        Me.label3.Text = "Organizational Unit"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(9, 60)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(100, 23)
        Me.label2.TabIndex = 25
        Me.label2.Text = "Organization"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(9, 36)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 23)
        Me.label1.TabIndex = 24
        Me.label1.Text = "Common Name"
        '
        'cbEmailProtection
        '
        Me.cbEmailProtection.AutoSize = True
        Me.cbEmailProtection.Checked = True
        Me.cbEmailProtection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbEmailProtection.Location = New System.Drawing.Point(236, 314)
        Me.cbEmailProtection.Name = "cbEmailProtection"
        Me.cbEmailProtection.Size = New System.Drawing.Size(102, 17)
        Me.cbEmailProtection.TabIndex = 56
        Me.cbEmailProtection.Text = "Email Protection"
        Me.cbEmailProtection.UseVisualStyleBackColor = True
        '
        'cbCodeSigning
        '
        Me.cbCodeSigning.AutoSize = True
        Me.cbCodeSigning.Checked = True
        Me.cbCodeSigning.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCodeSigning.Location = New System.Drawing.Point(236, 291)
        Me.cbCodeSigning.Name = "cbCodeSigning"
        Me.cbCodeSigning.Size = New System.Drawing.Size(89, 17)
        Me.cbCodeSigning.TabIndex = 55
        Me.cbCodeSigning.Text = "Code Signing"
        Me.cbCodeSigning.UseVisualStyleBackColor = True
        '
        'cbClientAuth
        '
        Me.cbClientAuth.AutoSize = True
        Me.cbClientAuth.Checked = True
        Me.cbClientAuth.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbClientAuth.Location = New System.Drawing.Point(121, 314)
        Me.cbClientAuth.Name = "cbClientAuth"
        Me.cbClientAuth.Size = New System.Drawing.Size(77, 17)
        Me.cbClientAuth.TabIndex = 54
        Me.cbClientAuth.Text = "Client Auth"
        Me.cbClientAuth.UseVisualStyleBackColor = True
        '
        'cbServerAuth
        '
        Me.cbServerAuth.AutoSize = True
        Me.cbServerAuth.Checked = True
        Me.cbServerAuth.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbServerAuth.Location = New System.Drawing.Point(121, 291)
        Me.cbServerAuth.Name = "cbServerAuth"
        Me.cbServerAuth.Size = New System.Drawing.Size(82, 17)
        Me.cbServerAuth.TabIndex = 53
        Me.cbServerAuth.Text = "Server Auth"
        Me.cbServerAuth.UseVisualStyleBackColor = True
        '
        'label14
        '
        Me.label14.Location = New System.Drawing.Point(9, 291)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(100, 23)
        Me.label14.TabIndex = 52
        Me.label14.Text = "Key Usage"
        '
        'edtKeyLength
        '
        Me.edtKeyLength.Location = New System.Drawing.Point(121, 257)
        Me.edtKeyLength.Name = "edtKeyLength"
        Me.edtKeyLength.Size = New System.Drawing.Size(80, 20)
        Me.edtKeyLength.TabIndex = 51
        Me.edtKeyLength.Text = "1024"
        '
        'label13
        '
        Me.label13.Location = New System.Drawing.Point(9, 257)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(100, 23)
        Me.label13.TabIndex = 50
        Me.label13.Text = "Key Length"
        '
        'edtFriendlyName
        '
        Me.edtFriendlyName.Location = New System.Drawing.Point(121, 12)
        Me.edtFriendlyName.Name = "edtFriendlyName"
        Me.edtFriendlyName.Size = New System.Drawing.Size(328, 20)
        Me.edtFriendlyName.TabIndex = 1
        Me.edtFriendlyName.Text = "Clever Tester"
        '
        'label15
        '
        Me.label15.Location = New System.Drawing.Point(9, 12)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(100, 23)
        Me.label15.TabIndex = 58
        Me.label15.Text = "Friendly Name"
        '
        'CreateCertForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 409)
        Me.Controls.Add(Me.edtFriendlyName)
        Me.Controls.Add(Me.label15)
        Me.Controls.Add(Me.cbEmailProtection)
        Me.Controls.Add(Me.cbCodeSigning)
        Me.Controls.Add(Me.cbClientAuth)
        Me.Controls.Add(Me.cbServerAuth)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.edtKeyLength)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.edtKeyName)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.edtL)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.edtStoreName)
        Me.Controls.Add(Me.edtValidTo)
        Me.Controls.Add(Me.edtValidFrom)
        Me.Controls.Add(Me.edtSerial)
        Me.Controls.Add(Me.edtE)
        Me.Controls.Add(Me.edtC)
        Me.Controls.Add(Me.edtS)
        Me.Controls.Add(Me.edtOU)
        Me.Controls.Add(Me.edtO)
        Me.Controls.Add(Me.edtCN)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "CreateCertForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Self-Signed Certificate Dialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Function BuildSubjectString() As String
        BuildSubjectString = ""

        If (edtCN.Text <> "") Then
            BuildSubjectString = BuildSubjectString + ",CN=" + edtCN.Text
        End If
        If (edtOU.Text <> "") Then
            BuildSubjectString = BuildSubjectString + ",OU=" + edtOU.Text
        End If
        If (edtO.Text <> "") Then
            BuildSubjectString = BuildSubjectString + ",O=" + edtO.Text
        End If
        If (edtL.Text <> "") Then
            BuildSubjectString = BuildSubjectString + ",L=" + edtL.Text
        End If
        If (edtC.Text <> "") Then
            BuildSubjectString = BuildSubjectString + ",C=" + edtC.Text
        End If
        If (edtE.Text <> "") Then
            BuildSubjectString = BuildSubjectString + ",E=" + edtE.Text
        End If
        If (BuildSubjectString <> "") Then
            BuildSubjectString = Mid(BuildSubjectString, 2, Len(BuildSubjectString))
        End If
    End Function

    Private Sub CreateCertForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        edtValidFrom.Text = DateTime.Now.ToString()
        edtValidTo.Text = DateTime.Now.AddYears(1).ToString()
    End Sub
End Class
