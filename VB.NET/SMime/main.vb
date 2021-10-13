Imports System.IO
Imports CleverComponents.InetSuite

Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        edtFrom.Text = GetCertDialog.DefaultEmail
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
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents saveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents memText As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents edtSubject As System.Windows.Forms.TextBox
    Friend WithEvents edtToList As System.Windows.Forms.TextBox
    Friend WithEvents edtFrom As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents cbIncludeCertificate As System.Windows.Forms.CheckBox
    Friend WithEvents cbDetachedSignature As System.Windows.Forms.CheckBox
    Friend WithEvents btnVerifyDecrypt As System.Windows.Forms.Button
    Friend WithEvents btnSignEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnVerify As System.Windows.Forms.Button
    Friend WithEvents btnSign As System.Windows.Forms.Button
    Friend WithEvents btnViewCertificates As System.Windows.Forms.Button
    Friend WithEvents btnNewMessage As System.Windows.Forms.Button
    Friend WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SMimeMessage1 As CleverComponents.InetSuite.SMimeMessage
    Friend WithEvents CertificateStore1 As CleverComponents.InetSuite.CertificateStore
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.label8 = New System.Windows.Forms.Label()
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.label7 = New System.Windows.Forms.Label()
        Me.memText = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.edtSubject = New System.Windows.Forms.TextBox()
        Me.edtToList = New System.Windows.Forms.TextBox()
        Me.edtFrom = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cbIncludeCertificate = New System.Windows.Forms.CheckBox()
        Me.cbDetachedSignature = New System.Windows.Forms.CheckBox()
        Me.btnVerifyDecrypt = New System.Windows.Forms.Button()
        Me.btnSignEncrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.btnViewCertificates = New System.Windows.Forms.Button()
        Me.btnNewMessage = New System.Windows.Forms.Button()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SMimeMessage1 = New CleverComponents.InetSuite.SMimeMessage()
        Me.CertificateStore1 = New CleverComponents.InetSuite.CertificateStore()
        CType(Me.SMimeMessage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(17, 32)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(464, 32)
        Me.label8.TabIndex = 47
        Me.label8.Text = "If you have a mail message, already stored on the  disk, you can load it and decr" &
    "ypt / verify  the message  digital signature.  Please see Readme.txt for more de" &
    "tails."
        '
        'saveFileDialog
        '
        Me.saveFileDialog.Filter = "Emails (*.eml)|*.eml|All (*.*)|*.*"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(17, 8)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(472, 16)
        Me.label7.TabIndex = 46
        Me.label7.Text = "This demo creates and signs / encodes the mail message and stores it to file on t" &
    "he disk."
        '
        'memText
        '
        Me.memText.Location = New System.Drawing.Point(9, 168)
        Me.memText.Multiline = True
        Me.memText.Name = "memText"
        Me.memText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memText.Size = New System.Drawing.Size(496, 112)
        Me.memText.TabIndex = 35
        Me.memText.Text = "This is SMIME test message built using Clever Message Parser"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(9, 144)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(100, 23)
        Me.label4.TabIndex = 34
        Me.label4.Text = "Body"
        '
        'edtSubject
        '
        Me.edtSubject.Location = New System.Drawing.Point(73, 120)
        Me.edtSubject.Name = "edtSubject"
        Me.edtSubject.Size = New System.Drawing.Size(432, 20)
        Me.edtSubject.TabIndex = 33
        Me.edtSubject.Text = "Clever SMime Message Parser Test"
        '
        'edtToList
        '
        Me.edtToList.Location = New System.Drawing.Point(73, 96)
        Me.edtToList.Name = "edtToList"
        Me.edtToList.Size = New System.Drawing.Size(432, 20)
        Me.edtToList.TabIndex = 32
        Me.edtToList.Text = "john@nexthost.com,doe@thirdhost.com"
        '
        'edtFrom
        '
        Me.edtFrom.Location = New System.Drawing.Point(73, 72)
        Me.edtFrom.Name = "edtFrom"
        Me.edtFrom.Size = New System.Drawing.Size(432, 20)
        Me.edtFrom.TabIndex = 31
        Me.edtFrom.Text = "test@myhost.com"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(9, 120)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 23)
        Me.label3.TabIndex = 30
        Me.label3.Text = "Subject"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(9, 96)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 23)
        Me.label2.TabIndex = 29
        Me.label2.Text = "To List"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(9, 72)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(64, 23)
        Me.label1.TabIndex = 28
        Me.label1.Text = "From"
        '
        'cbIncludeCertificate
        '
        Me.cbIncludeCertificate.Checked = True
        Me.cbIncludeCertificate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbIncludeCertificate.Location = New System.Drawing.Point(377, 328)
        Me.cbIncludeCertificate.Name = "cbIncludeCertificate"
        Me.cbIncludeCertificate.Size = New System.Drawing.Size(128, 24)
        Me.cbIncludeCertificate.TabIndex = 45
        Me.cbIncludeCertificate.Text = "Include Certificate"
        '
        'cbDetachedSignature
        '
        Me.cbDetachedSignature.Checked = True
        Me.cbDetachedSignature.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbDetachedSignature.Location = New System.Drawing.Point(377, 296)
        Me.cbDetachedSignature.Name = "cbDetachedSignature"
        Me.cbDetachedSignature.Size = New System.Drawing.Size(128, 24)
        Me.cbDetachedSignature.TabIndex = 44
        Me.cbDetachedSignature.Text = "Detached Signature"
        '
        'btnVerifyDecrypt
        '
        Me.btnVerifyDecrypt.Location = New System.Drawing.Point(273, 328)
        Me.btnVerifyDecrypt.Name = "btnVerifyDecrypt"
        Me.btnVerifyDecrypt.Size = New System.Drawing.Size(96, 23)
        Me.btnVerifyDecrypt.TabIndex = 43
        Me.btnVerifyDecrypt.Text = "Verify/Decrypt..."
        '
        'btnSignEncrypt
        '
        Me.btnSignEncrypt.Location = New System.Drawing.Point(273, 296)
        Me.btnSignEncrypt.Name = "btnSignEncrypt"
        Me.btnSignEncrypt.Size = New System.Drawing.Size(96, 23)
        Me.btnSignEncrypt.TabIndex = 42
        Me.btnSignEncrypt.Text = "Sign/Encrypt..."
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(193, 328)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnDecrypt.TabIndex = 41
        Me.btnDecrypt.Text = "Decrypt..."
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(193, 296)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnEncrypt.TabIndex = 40
        Me.btnEncrypt.Text = "Encrypt..."
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(113, 328)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(75, 23)
        Me.btnVerify.TabIndex = 39
        Me.btnVerify.Text = "Verify..."
        '
        'btnSign
        '
        Me.btnSign.Location = New System.Drawing.Point(113, 296)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(75, 23)
        Me.btnSign.TabIndex = 38
        Me.btnSign.Text = "Sign..."
        '
        'btnViewCertificates
        '
        Me.btnViewCertificates.Location = New System.Drawing.Point(9, 328)
        Me.btnViewCertificates.Name = "btnViewCertificates"
        Me.btnViewCertificates.Size = New System.Drawing.Size(96, 23)
        Me.btnViewCertificates.TabIndex = 37
        Me.btnViewCertificates.Text = "View Certificates"
        '
        'btnNewMessage
        '
        Me.btnNewMessage.Location = New System.Drawing.Point(9, 296)
        Me.btnNewMessage.Name = "btnNewMessage"
        Me.btnNewMessage.Size = New System.Drawing.Size(96, 23)
        Me.btnNewMessage.TabIndex = 36
        Me.btnNewMessage.Text = "New Message"
        '
        'openFileDialog
        '
        Me.openFileDialog.Filter = "Emails (*.eml)|*.eml|All (*.*)|*.*"
        '
        'SMimeMessage1
        '
        Me.SMimeMessage1.Date = New Date(2006, 5, 8, 16, 3, 26, 30)
        '
        'CertificateStore1
        '
        Me.CertificateStore1.ValidFrom = New Date(2010, 7, 27, 12, 58, 59, 753)
        Me.CertificateStore1.ValidTo = New Date(2011, 7, 27, 12, 58, 59, 753)
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(514, 360)
        Me.Controls.Add(Me.memText)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.edtSubject)
        Me.Controls.Add(Me.edtToList)
        Me.Controls.Add(Me.edtFrom)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cbIncludeCertificate)
        Me.Controls.Add(Me.cbDetachedSignature)
        Me.Controls.Add(Me.btnVerifyDecrypt)
        Me.Controls.Add(Me.btnSignEncrypt)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.btnViewCertificates)
        Me.Controls.Add(Me.btnNewMessage)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMIME Message"
        CType(Me.SMimeMessage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub NewMessage()
        edtFrom.Text = GetCertDialog.DefaultEmail
        edtToList.Text = ""
        edtSubject.Text = ""
        memText.Text = ""
    End Sub 'NewMessage


    Private Sub BuildMessage()
        SMimeMessage1.BuildMessage(memText.Text, "")
        SMimeMessage1.From.FullAddress = edtFrom.Text
        SMimeMessage1.ToList.EmailAddresses = edtToList.Text
        SMimeMessage1.Subject = edtSubject.Text
    End Sub 'BuildMessage


    Private Sub FillControls()
        edtFrom.Text = SMimeMessage1.From.FullAddress
        edtToList.Text = SMimeMessage1.ToList.EmailAddresses
        edtSubject.Text = SMimeMessage1.Subject
        memText.Lines = SMimeMessage1.MessageText
    End Sub 'FillControls


    Private Sub btnNewMessage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewMessage.Click
        NewMessage()
    End Sub 'btnNewMessage_Click


    Private Sub btnViewCertificates_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnViewCertificates.Click
        CertListForm.ShowCertificates(SMimeMessage1.Certificates)
    End Sub 'btnViewCertificates_Click


    Private Sub btnSign_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSign.Click
        SMimeMessage1.IsDetachedSignature = cbDetachedSignature.Checked
        If cbIncludeCertificate.Checked Then
            SMimeMessage1.IncludeCertificateOption = Security.Cryptography.X509Certificates.X509IncludeOption.WholeChain
        Else
            SMimeMessage1.IncludeCertificateOption = Security.Cryptography.X509Certificates.X509IncludeOption.None
        End If

        If saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            BuildMessage()
            SMimeMessage1.Sign()

            Dim w As New StreamWriter(saveFileDialog.FileName)
            w.Write(StringUtils.GetStringsAsString(SMimeMessage1.MessageSource))
            w.Close()

            MessageBox.Show(("The signed message is saved to " + saveFileDialog.FileName))
        End If
    End Sub 'btnSign_Click


    Private Sub btnVerify_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVerify.Click
        If openFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            NewMessage()
            Dim sr As StreamReader = File.OpenText(openFileDialog.FileName)
            SMimeMessage1.MessageSource = StringUtils.GetStringArray(sr.ReadToEnd())
            sr.Close()

            SMimeMessage1.Verify()
            FillControls()
            MessageBox.Show(("The signed message " + openFileDialog.FileName + " is verified."))
        End If
    End Sub 'btnVerify_Click


    Private Sub btnEncrypt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        SMimeMessage1.IsDetachedSignature = cbDetachedSignature.Checked
        If cbIncludeCertificate.Checked Then
            SMimeMessage1.IncludeCertificateOption = Security.Cryptography.X509Certificates.X509IncludeOption.WholeChain
        Else
            SMimeMessage1.IncludeCertificateOption = Security.Cryptography.X509Certificates.X509IncludeOption.None
        End If

        If saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            BuildMessage()
            SMimeMessage1.Encrypt()

            Dim w As New StreamWriter(saveFileDialog.FileName)
            w.Write(StringUtils.GetStringsAsString(SMimeMessage1.MessageSource))
            w.Close()

            MessageBox.Show(("The encrypted message is saved to " + saveFileDialog.FileName))
        End If
    End Sub 'btnEncrypt_Click


    Private Sub btnDecrypt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        If openFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            NewMessage()
            Dim sr As StreamReader = File.OpenText(openFileDialog.FileName)
            SMimeMessage1.MessageSource = StringUtils.GetStringArray(sr.ReadToEnd())
            sr.Close()

            SMimeMessage1.Decrypt()
            FillControls()
            MessageBox.Show(("The encrypted message " + openFileDialog.FileName + " is decrypted."))
        End If
    End Sub 'btnDecrypt_Click


    Private Sub btnSignEncrypt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSignEncrypt.Click
        SMimeMessage1.IsDetachedSignature = cbDetachedSignature.Checked
        If cbIncludeCertificate.Checked Then
            SMimeMessage1.IncludeCertificateOption = Security.Cryptography.X509Certificates.X509IncludeOption.WholeChain
        Else
            SMimeMessage1.IncludeCertificateOption = Security.Cryptography.X509Certificates.X509IncludeOption.None
        End If

        If saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            BuildMessage()
            SMimeMessage1.Sign()
            SMimeMessage1.Encrypt()

            Dim w As New StreamWriter(saveFileDialog.FileName)
            w.Write(StringUtils.GetStringsAsString(SMimeMessage1.MessageSource))
            w.Close()

            MessageBox.Show(("The encrypted and signed message is saved to " + saveFileDialog.FileName))
        End If
    End Sub 'btnSignEncrypt_Click


    Private Sub btnVerifyDecrypt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVerifyDecrypt.Click
        If openFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            NewMessage()
            Dim sr As StreamReader = File.OpenText(openFileDialog.FileName)
            SMimeMessage1.MessageSource = StringUtils.GetStringArray(sr.ReadToEnd())
            sr.Close()
            SMimeMessage1.DecryptAndVerify()
            FillControls()
            MessageBox.Show(("The secured message " + openFileDialog.FileName + " is decrypted and verified."))
        End If
    End Sub 'btnVerifyDecrypt_Click

    Private Sub SMimeMessage1_GetEncryptionCertificate(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.GetCertificateEventArgs) Handles SMimeMessage1.GetEncryptionCertificate
        Dim dlg As New GetCertDialog

        dlg.Text = "Get encryption certificate"
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CertificateStore1.Open(dlg.edtStore.Text)
            e.Certificate = CertificateStore1.CertificateByEmail(dlg.edtEmail.Text)
            e.Handled = True
        End If
    End Sub

    Private Sub SMimeMessage1_GetSigningCertificate(ByVal sender As System.Object, ByVal e As CleverComponents.InetSuite.GetCertificateEventArgs) Handles SMimeMessage1.GetSigningCertificate
        Dim dlg As New GetCertDialog

        dlg.Text = "Get signing certificate"
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CertificateStore1.Open(dlg.edtStore.Text)
            e.Certificate = CertificateStore1.CertificateByEmail(dlg.edtEmail.Text)
            e.Handled = True
        End If
    End Sub
End Class
