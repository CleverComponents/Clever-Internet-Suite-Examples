Imports CleverComponents.InetSuite
Imports CleverComponents.InetSuite.CryptApi


Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        cbLocation.SelectedIndex = 0

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
    Private isOpened As Boolean = False
    Private WithEvents cbLocation As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnCreateSigned As System.Windows.Forms.Button
    Private WithEvents btnCreateSelfSigned As System.Windows.Forms.Button
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents btnImport As System.Windows.Forms.Button
    Private WithEvents btnExport As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnLoad As System.Windows.Forms.Button
    Private WithEvents lvCertificates As System.Windows.Forms.ListView
    Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader3 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader4 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader5 As System.Windows.Forms.ColumnHeader
    Private WithEvents cbName As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents CertificateStore1 As CleverComponents.InetSuite.CertificateStore
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CertificateStore1 = New CleverComponents.InetSuite.CertificateStore
        Me.cbLocation = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.btnCreateSigned = New System.Windows.Forms.Button
        Me.btnCreateSelfSigned = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnImport = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnLoad = New System.Windows.Forms.Button
        Me.lvCertificates = New System.Windows.Forms.ListView
        Me.columnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.columnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.cbName = New System.Windows.Forms.ComboBox
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CertificateStore1
        '
        Me.CertificateStore1.ValidFrom = New Date(2008, 8, 18, 17, 2, 23, 906)
        Me.CertificateStore1.ValidTo = New Date(2009, 8, 18, 17, 2, 23, 906)
        '
        'cbLocation
        '
        Me.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLocation.Items.AddRange(New Object() {"Current User", "Local Machine"})
        Me.cbLocation.Location = New System.Drawing.Point(143, 15)
        Me.cbLocation.Name = "cbLocation"
        Me.cbLocation.Size = New System.Drawing.Size(184, 21)
        Me.cbLocation.TabIndex = 16
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(121, 23)
        Me.label1.TabIndex = 26
        Me.label1.Text = "System Store Location"
        '
        'btnCreateSigned
        '
        Me.btnCreateSigned.Location = New System.Drawing.Point(442, 297)
        Me.btnCreateSigned.Name = "btnCreateSigned"
        Me.btnCreateSigned.Size = New System.Drawing.Size(112, 23)
        Me.btnCreateSigned.TabIndex = 25
        Me.btnCreateSigned.Text = "Create Signed"
        '
        'btnCreateSelfSigned
        '
        Me.btnCreateSelfSigned.Location = New System.Drawing.Point(442, 268)
        Me.btnCreateSelfSigned.Name = "btnCreateSelfSigned"
        Me.btnCreateSelfSigned.Size = New System.Drawing.Size(112, 23)
        Me.btnCreateSelfSigned.TabIndex = 24
        Me.btnCreateSelfSigned.Text = "Create Self-Signed"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(442, 239)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 23)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Delete"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(442, 120)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(112, 23)
        Me.btnImport.TabIndex = 22
        Me.btnImport.Text = "Import from PFX..."
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(442, 88)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(112, 23)
        Me.btnExport.TabIndex = 21
        Me.btnExport.Text = "Export to PFX..."
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(442, 48)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 23)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Close Store"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(442, 16)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(112, 23)
        Me.btnLoad.TabIndex = 19
        Me.btnLoad.Text = "Load Store"
        '
        'lvCertificates
        '
        Me.lvCertificates.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3, Me.columnHeader4, Me.columnHeader5})
        Me.lvCertificates.FullRowSelect = True
        Me.lvCertificates.HideSelection = False
        Me.lvCertificates.Location = New System.Drawing.Point(18, 88)
        Me.lvCertificates.MultiSelect = False
        Me.lvCertificates.Name = "lvCertificates"
        Me.lvCertificates.Size = New System.Drawing.Size(408, 232)
        Me.lvCertificates.TabIndex = 18
        Me.lvCertificates.UseCompatibleStateImageBehavior = False
        Me.lvCertificates.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "Issued To"
        Me.columnHeader1.Width = 100
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Issued By"
        Me.columnHeader2.Width = 100
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "Expiration Date"
        '
        'columnHeader4
        '
        Me.columnHeader4.Text = "Friendly Name"
        Me.columnHeader4.Width = 100
        '
        'columnHeader5
        '
        Me.columnHeader5.Text = "Email"
        Me.columnHeader5.Width = 100
        '
        'cbName
        '
        Me.cbName.Items.AddRange(New Object() {"MY", "CA", "ROOT", "ADDRESSBOOK"})
        Me.cbName.Location = New System.Drawing.Point(143, 42)
        Me.cbName.Name = "cbName"
        Me.cbName.Size = New System.Drawing.Size(184, 21)
        Me.cbName.TabIndex = 17
        Me.cbName.Text = "MY"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(18, 64)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 23)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Certificates"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 45)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(112, 23)
        Me.label2.TabIndex = 14
        Me.label2.Text = "System Store Name"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(570, 334)
        Me.Controls.Add(Me.cbLocation)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnCreateSigned)
        Me.Controls.Add(Me.btnCreateSelfSigned)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lvCertificates)
        Me.Controls.Add(Me.cbName)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub InstallCerts()
        Dim cert As Certificate
        For Each cert In CertificateStore1.Items
            If Not CertificateStore1.IsInstalled(cert) Then
                CertificateStore1.Install(cert)
            End If
        Next cert
    End Sub

    Private Sub PrepareStore(ByVal dlg As CreateCertForm)
        CertificateStore1.ValidFrom = Convert.ToDateTime(dlg.edtValidFrom.Text)
        CertificateStore1.ValidTo = Convert.ToDateTime(dlg.edtValidTo.Text)
        CertificateStore1.KeyName = dlg.edtKeyName.Text
        CertificateStore1.KeyLength = Convert.ToInt32(dlg.edtKeyLength.Text)

        Dim usage As New StringCollectionEx()

        If (dlg.cbServerAuth.Checked) Then
            usage.Add(CertificateEnhancedUsage.OID_PKIX_KP_SERVER_AUTH)
        End If
        If (dlg.cbClientAuth.Checked) Then
            usage.Add(CertificateEnhancedUsage.OID_PKIX_KP_CLIENT_AUTH)
        End If
        If (dlg.cbCodeSigning.Checked) Then
            usage.Add(CertificateEnhancedUsage.OID_PKIX_KP_CODE_SIGNING)
        End If
        If (dlg.cbEmailProtection.Checked) Then
            usage.Add(CertificateEnhancedUsage.OID_PKIX_KP_EMAIL_PROTECTION)
        End If

        CertificateStore1.EnhancedKeyUsage = usage.ToArray()

        If Not CertificateStore1.KeyExists(CertificateStore1.KeyName) Then
            CertificateStore1.CreateKey(CertificateStore1.KeyName)
        End If
    End Sub

    Private Sub LoadCertificateList()
        lvCertificates.Items.Clear()
        Dim cert As Certificate
        For Each cert In CertificateStore1.Items
            Dim item As ListViewItem = lvCertificates.Items.Add(cert.IssuedTo)
            item.SubItems.Add(cert.IssuedBy)
            item.SubItems.Add(cert.ValidTo.ToString())
            item.SubItems.Add(cert.FriendlyName)
            item.SubItems.Add(cert.Email)
        Next cert
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        btnClose_Click(Nothing, Nothing)

        Dim location As CertificateStoreLocation
        If cbLocation.SelectedIndex = 0 Then
            location = CertificateStoreLocation.CurrentUser
        Else
            location = CertificateStoreLocation.LocalMachine
        End If

        CertificateStore1.Open(cbName.Text, location)
        LoadCertificateList()
        isOpened = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        CertificateStore1.Close()
        LoadCertificateList()
        isOpened = False
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If lvCertificates.SelectedIndices.Count = 0 Then
            Return
        End If
        Dim cert As Certificate
        cert = CertificateStore1.Items(lvCertificates.SelectedIndices(0))

        Dim dlg As New ExportForm

        dlg.edtName.Text = cert.FriendlyName
        If (StringUtils.IsEmpty(dlg.edtName.Text)) Then
            dlg.edtName.Text = cert.IssuedTo
        End If

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CertificateStore1.ExportToPFX(cert, dlg.edtFileName.Text, dlg.edtPassword.Text, dlg.cbIncludeAll.Checked)
        End If
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        If Not isOpened Then
            Return
        End If
        Dim dlg As New ImportForm
        dlg.edtStoreName.Text = cbLocation.Text + "; " + cbName.Text

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CertificateStore1.ImportFromPFX(dlg.edtFileName.Text, dlg.edtPassword.Text)

            InstallCerts()
            btnLoad_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If lvCertificates.SelectedIndices.Count = 0 Then
            Return
        End If
        Dim cert As Certificate
        cert = CertificateStore1.Items(lvCertificates.SelectedIndices(0))

        CertificateStore1.Uninstall(cert)
        CertificateStore1.Items.RemoveAt(lvCertificates.SelectedIndices(0))

        btnLoad_Click(Nothing, Nothing)
    End Sub

    Private Sub btnCreateSelfSigned_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSelfSigned.Click
        If Not isOpened Then
            Return
        End If
        Dim dlg As New CreateCertForm
        dlg.edtStoreName.Text = cbLocation.Text + "; " + cbName.Text

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrepareStore(dlg)

            Dim cert As Certificate = CertificateStore1.CreateSelfSigned(dlg.BuildSubjectString(), Convert.ToInt32(dlg.edtSerial.Text))
            CertificateStore1.Items.Add(cert)
            cert.FriendlyName = dlg.edtFriendlyName.Text

            InstallCerts()
            btnLoad_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnCreateSigned_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSigned.Click
        If Not isOpened Then
            Return
        End If

        If lvCertificates.SelectedIndices.Count = 0 Then
            Return
        End If

        Dim dlg As New CreateCertForm
        dlg.edtStoreName.Text = cbLocation.Text + "; " + cbName.Text

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrepareStore(dlg)

            Dim issuer As Certificate = CertificateStore1.Items(lvCertificates.SelectedIndices(0))
            Dim cert As Certificate = CertificateStore1.CreateSigned(issuer, dlg.BuildSubjectString(), Convert.ToInt32(dlg.edtSerial.Text))
            CertificateStore1.Items.Add(cert)
            cert.FriendlyName = dlg.edtFriendlyName.Text

            InstallCerts()
            btnLoad_Click(Nothing, Nothing)
        End If
    End Sub
End Class
