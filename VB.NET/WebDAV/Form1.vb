Imports System.IO
Imports System.Collections.Specialized
Imports CleverComponents.InetSuite

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        cbDepth.SelectedIndex = 0

        resources = New StringCollection()
        locks = New StringCollection()

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
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents btnCopyMove As System.Windows.Forms.Button
    Friend WithEvents btnUnlock As System.Windows.Forms.Button
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnMakeDir As System.Windows.Forms.Button
    Friend WithEvents btnModifyProp As System.Windows.Forms.Button
    Friend WithEvents btnGetAllProps As System.Windows.Forms.Button
    Friend WithEvents btnCapabilities As System.Windows.Forms.Button
    Friend WithEvents btnGoUp As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents lvResources As System.Windows.Forms.ListView
    Friend WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents cbDepth As System.Windows.Forms.ComboBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents edtPassword As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents edtUser As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents edtHost As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents WebDav1 As CleverComponents.InetSuite.WebDav
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnUpload = New System.Windows.Forms.Button
        Me.btnDownload = New System.Windows.Forms.Button
        Me.btnCopyMove = New System.Windows.Forms.Button
        Me.btnUnlock = New System.Windows.Forms.Button
        Me.btnLock = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnMakeDir = New System.Windows.Forms.Button
        Me.btnModifyProp = New System.Windows.Forms.Button
        Me.btnGetAllProps = New System.Windows.Forms.Button
        Me.btnCapabilities = New System.Windows.Forms.Button
        Me.btnGoUp = New System.Windows.Forms.Button
        Me.btnOpen = New System.Windows.Forms.Button
        Me.lvResources = New System.Windows.Forms.ListView
        Me.columnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.label5 = New System.Windows.Forms.Label
        Me.cbDepth = New System.Windows.Forms.ComboBox
        Me.label4 = New System.Windows.Forms.Label
        Me.edtPassword = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.edtUser = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.edtHost = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.WebDav1 = New CleverComponents.InetSuite.WebDav
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(408, 375)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(88, 23)
        Me.btnUpload.TabIndex = 43
        Me.btnUpload.Text = "Upload"
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(408, 343)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(88, 23)
        Me.btnDownload.TabIndex = 42
        Me.btnDownload.Text = "Download"
        '
        'btnCopyMove
        '
        Me.btnCopyMove.Location = New System.Drawing.Point(408, 311)
        Me.btnCopyMove.Name = "btnCopyMove"
        Me.btnCopyMove.Size = New System.Drawing.Size(88, 23)
        Me.btnCopyMove.TabIndex = 41
        Me.btnCopyMove.Text = "Copy / Move"
        '
        'btnUnlock
        '
        Me.btnUnlock.Location = New System.Drawing.Point(408, 279)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(88, 23)
        Me.btnUnlock.TabIndex = 40
        Me.btnUnlock.Text = "Unlock"
        '
        'btnLock
        '
        Me.btnLock.Location = New System.Drawing.Point(408, 247)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(88, 23)
        Me.btnLock.TabIndex = 39
        Me.btnLock.Text = "Lock Resource"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(408, 215)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 23)
        Me.btnDelete.TabIndex = 38
        Me.btnDelete.Text = "Delete"
        '
        'btnMakeDir
        '
        Me.btnMakeDir.Location = New System.Drawing.Point(408, 183)
        Me.btnMakeDir.Name = "btnMakeDir"
        Me.btnMakeDir.Size = New System.Drawing.Size(88, 23)
        Me.btnMakeDir.TabIndex = 37
        Me.btnMakeDir.Text = "Make Dir"
        '
        'btnModifyProp
        '
        Me.btnModifyProp.Location = New System.Drawing.Point(408, 151)
        Me.btnModifyProp.Name = "btnModifyProp"
        Me.btnModifyProp.Size = New System.Drawing.Size(88, 23)
        Me.btnModifyProp.TabIndex = 36
        Me.btnModifyProp.Text = "Modify Prop"
        '
        'btnGetAllProps
        '
        Me.btnGetAllProps.Location = New System.Drawing.Point(408, 119)
        Me.btnGetAllProps.Name = "btnGetAllProps"
        Me.btnGetAllProps.Size = New System.Drawing.Size(88, 23)
        Me.btnGetAllProps.TabIndex = 35
        Me.btnGetAllProps.Text = "Get All Props"
        '
        'btnCapabilities
        '
        Me.btnCapabilities.Location = New System.Drawing.Point(408, 87)
        Me.btnCapabilities.Name = "btnCapabilities"
        Me.btnCapabilities.Size = New System.Drawing.Size(88, 23)
        Me.btnCapabilities.TabIndex = 34
        Me.btnCapabilities.Text = "Capabilities"
        '
        'btnGoUp
        '
        Me.btnGoUp.Location = New System.Drawing.Point(408, 47)
        Me.btnGoUp.Name = "btnGoUp"
        Me.btnGoUp.Size = New System.Drawing.Size(88, 23)
        Me.btnGoUp.TabIndex = 33
        Me.btnGoUp.Text = "Go Up"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(408, 15)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(88, 23)
        Me.btnOpen.TabIndex = 32
        Me.btnOpen.Text = "Open"
        '
        'lvResources
        '
        Me.lvResources.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1})
        Me.lvResources.FullRowSelect = True
        Me.lvResources.HideSelection = False
        Me.lvResources.Location = New System.Drawing.Point(16, 135)
        Me.lvResources.Name = "lvResources"
        Me.lvResources.Size = New System.Drawing.Size(376, 264)
        Me.lvResources.TabIndex = 31
        Me.lvResources.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "Path"
        Me.columnHeader1.Width = 350
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(16, 111)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(64, 23)
        Me.label5.TabIndex = 30
        Me.label5.Text = "Resources"
        '
        'cbDepth
        '
        Me.cbDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepth.Items.AddRange(New Object() {"Default", "Resource Only", "Resource and Children", "Infinity"})
        Me.cbDepth.Location = New System.Drawing.Point(64, 79)
        Me.cbDepth.Name = "cbDepth"
        Me.cbDepth.Size = New System.Drawing.Size(112, 21)
        Me.cbDepth.TabIndex = 29
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 79)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(40, 23)
        Me.label4.TabIndex = 28
        Me.label4.Text = "Depth"
        '
        'edtPassword
        '
        Me.edtPassword.Location = New System.Drawing.Point(272, 47)
        Me.edtPassword.Name = "edtPassword"
        Me.edtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.edtPassword.Size = New System.Drawing.Size(120, 20)
        Me.edtPassword.TabIndex = 27
        Me.edtPassword.Text = ""
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(208, 47)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 23)
        Me.label3.TabIndex = 26
        Me.label3.Text = "Password"
        '
        'edtUser
        '
        Me.edtUser.Location = New System.Drawing.Point(64, 47)
        Me.edtUser.Name = "edtUser"
        Me.edtUser.Size = New System.Drawing.Size(112, 20)
        Me.edtUser.TabIndex = 25
        Me.edtUser.Text = ""
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 47)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 23)
        Me.label2.TabIndex = 24
        Me.label2.Text = "User"
        '
        'edtHost
        '
        Me.edtHost.Location = New System.Drawing.Point(64, 15)
        Me.edtHost.Name = "edtHost"
        Me.edtHost.Size = New System.Drawing.Size(328, 20)
        Me.edtHost.TabIndex = 23
        Me.edtHost.Text = "http://localhost/WebDAV/"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 23)
        Me.label1.TabIndex = 22
        Me.label1.Text = "Host"
        '
        'WebDav1
        '
        Me.WebDav1.CharSet = Nothing
        Me.WebDav1.LockOwner = Nothing
        Me.WebDav1.LockTimeOut = "Infinite, Second-86400"
        Me.WebDav1.Port = 80
        Me.WebDav1.TlsFlags = CType((CleverComponents.InetSuite.Sspi.TlsFlags.UseSSL2 Or CleverComponents.InetSuite.Sspi.TlsFlags.UseSSL3), CleverComponents.InetSuite.Sspi.TlsFlags)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 414)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnCopyMove)
        Me.Controls.Add(Me.btnUnlock)
        Me.Controls.Add(Me.btnLock)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnMakeDir)
        Me.Controls.Add(Me.btnModifyProp)
        Me.Controls.Add(Me.btnGetAllProps)
        Me.Controls.Add(Me.btnCapabilities)
        Me.Controls.Add(Me.btnGoUp)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.lvResources)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.cbDepth)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.edtPassword)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.edtUser)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.edtHost)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Web DAV client"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private currentDir As String
    Private resources As StringCollection
    Private locks As StringCollection

    Private Sub AssignDepth()
        Select Case cbDepth.SelectedIndex
            Case 0
                WebDav1.Depth = WebDavDepth.Default
            Case 1
                WebDav1.Depth = WebDavDepth.ResourceOnly
            Case 2
                WebDav1.Depth = WebDavDepth.ResourceAndChildren
            Case 3
                WebDav1.Depth = WebDavDepth.Infinity
        End Select
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        WebDav1.UserName = edtUser.Text
        WebDav1.Password = edtPassword.Text

        AssignDepth()

        WebDav1.ListDir(edtHost.Text)
        currentDir = edtHost.Text

        lvResources.Items.Clear()

        Dim i As Integer
        For i = 0 To WebDav1.ResourceProperties.Count - 1
            lvResources.Items.Add(WebDav1.ResourceProperties(i).Uri)
        Next i
    End Sub

    Private Sub btnGoUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoUp.Click
        Dim s As String = edtHost.Text
        If StringUtils.IsEmpty(s) Then
            Exit Sub
        End If

        If Mid(s, Len(s), 1) = "/" Then
            s = Mid(s, 1, Len(s) - 1)
        End If
        Dim ind As Integer = InStrRev(s, "/")
        If ind > 0 Then
            s = Mid(s, 1, ind)
        End If
        edtHost.Text = s
        currentDir = edtHost.Text

        btnOpen_Click(Nothing, Nothing)
    End Sub

    Private Sub btnCapabilities_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapabilities.Click
        WebDav1.UserName = edtUser.Text
        WebDav1.Password = edtPassword.Text

        Dim url As String = edtHost.Text
        If lvResources.SelectedItems.Count > 0 Then
            url = lvResources.SelectedItems(0).Text
        End If

        WebDav1.GetCapabilities(url)

        Dim list As New StringCollectionEx

        list.Add("WebDav Class: " + WebDav1.Capabilities.WebDavClass)

        list.Add("")
        list.Add("Allowed Methods:")
        list.AddRange(WebDav1.Capabilities.AllowedMethods)

        list.Add("")
        list.Add("Public Methods:")
        list.AddRange(WebDav1.Capabilities.PublicMethods)

        Dim dlg As New ViewPropsForm

        dlg.Text = "WebDAV Capabilities"
        dlg.textBox1.Lines = list.ToArray()
        dlg.textBox1.Select(0, 0)

        dlg.ShowDialog()
    End Sub

    Private Sub btnGetAllProps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAllProps.Click
        WebDav1.UserName = edtUser.Text
        WebDav1.Password = edtPassword.Text

        If cbDepth.SelectedIndex = 0 Then
            WebDav1.Depth = WebDavDepth.ResourceOnly
        Else
            AssignDepth()
        End If

        Dim url As String = edtHost.Text
        If lvResources.SelectedItems.Count > 0 Then
            url = lvResources.SelectedItems(0).Text
        End If

        WebDav1.GetAllProperties(url)
        WebDav1.GetActiveLocks(url)

        Dim list As New StringCollectionEx
        list.Add(url)
        list.Add("")
        list.Add("Properties:")

        Dim i As Integer
        For i = 0 To WebDav1.ResourceProperties.Count - 1
            list.Add(WebDav1.ResourceProperties(i).Name + " = " + WebDav1.ResourceProperties(i).Value)
        Next i

        list.Add("")
        list.Add("Active Locks:")

        For i = 0 To WebDav1.ActiveLocks.Count - 1
            Dim item As WebDavLock = WebDav1.ActiveLocks(i)

            list.Add("Owner: " + item.Owner)
            list.Add("Lock Token: " + item.LockToken)
            list.Add("Lock Type: " + item.LockType)
            list.Add("Lock Timeout: " + item.TimeOut)
        Next i

        Dim dlg As New ViewPropsForm
        dlg.Text = "View Resource Properties"
        dlg.textBox1.Lines = list.ToArray()
        dlg.textBox1.Select(0, 0)

        dlg.ShowDialog()
    End Sub

    Private Sub btnModifyProp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifyProp.Click
        WebDav1.UserName = edtUser.Text
        WebDav1.Password = edtPassword.Text
        AssignDepth()

        Dim url As String = edtHost.Text
        If lvResources.SelectedItems.Count > 0 Then
            url = lvResources.SelectedItems(0).Text
        End If

        Dim dlg As New ModifyPropForm

        dlg.lblResource.Text = url

        Select Case dlg.ShowDialog()
            Case Windows.Forms.DialogResult.Yes
                Dim Names As String() = {dlg.edtName.Text}
                Dim Vals As String() = {dlg.edtValue.Text}
                WebDav1.SetProperties(url, Names, Vals)
                MessageBox.Show("Property '" + dlg.edtName.Text + "' added / modified.")
            Case Windows.Forms.DialogResult.No
                Dim Names As String() = {dlg.edtName.Text}
                WebDav1.RemoveProperties(url, Names)
                MessageBox.Show("Property '" + dlg.edtName.Text + "' removed.")
        End Select
    End Sub

    Private Sub btnMakeDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeDir.Click
        WebDav1.UserName = edtUser.Text
        WebDav1.Password = edtPassword.Text
        AssignDepth()

        Dim newDir As String = edtHost.Text
        If lvResources.SelectedItems.Count > 0 Then
            newDir = lvResources.SelectedItems(0).Text
        End If

        Dim dlg As New MakeDirForm
        dlg.edtValue.Text = newDir
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            WebDav1.MakeDir(dlg.edtValue.Text)
            btnOpen_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        WebDav1.UserName = edtUser.Text
        WebDav1.Password = edtPassword.Text
        AssignDepth()

        If lvResources.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a resource")
            Exit Sub
        End If

        Dim url As String = lvResources.SelectedItems(0).Text

        If MessageBox.Show("Do you want to delete " + url + " ?", _
            "Delete Resource", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            WebDav1.Delete(url)
            btnOpen_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLock.Click
        WebDav1.UserName = edtUser.Text
        WebDav1.Password = edtPassword.Text

        AssignDepth()
        WebDav1.LockOwner = "WebDAV tester"
        WebDav1.LockScope = WebDavLockScope.Exclusive

        Dim url As String = edtHost.Text
        If lvResources.SelectedItems.Count > 0 Then
            url = lvResources.SelectedItems(0).Text
        End If

        Dim lockToken As String = WebDav1.Lock(url)
        resources.Add(url)
        locks.Add(lockToken)

        MessageBox.Show("The " + url + " resource has been locked successfully." + _
            ControlChars.Cr + ControlChars.Lf + ControlChars.Cr + ControlChars.Lf + "Lock Token = " + lockToken)
    End Sub

    Private Sub btnUnlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnlock.Click
        WebDav1.UserName = edtUser.Text
        WebDav1.Password = edtPassword.Text

        AssignDepth()
        WebDav1.LockOwner = "WebDAV tester"
        WebDav1.LockScope = WebDavLockScope.Exclusive

        Dim url As String = edtHost.Text
        If lvResources.SelectedItems.Count > 0 Then
            url = lvResources.SelectedItems(0).Text
        End If

        Dim i As Int32
        For i = 0 To resources.Count - 1
            If String.Compare(resources(i), url, True) = 0 Then
                WebDav1.Unlock(url, locks(i))
            End If
        Next i

        MessageBox.Show("The " + url + " resource has been unlocked.")
    End Sub

    Private Sub btnCopyMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyMove.Click
        WebDav1.UserName = edtUser.Text
        WebDav1.Password = edtPassword.Text
        AssignDepth()

        Dim url As String = edtHost.Text
        If lvResources.SelectedItems.Count > 0 Then
            url = lvResources.SelectedItems(0).Text
        End If

        Dim dlg As New CopyMoveForm
        dlg.edtSource.Text = url
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If dlg.cbIsMove.Checked Then
                WebDav1.Move(dlg.edtSource.Text, dlg.edtDestination.Text)
            Else
                WebDav1.Copy(dlg.edtSource.Text, dlg.edtDestination.Text)
            End If
            btnOpen_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click
        WebDav1.UserName = edtUser.Text
        WebDav1.Password = edtPassword.Text
        AssignDepth()

        Dim url As String = edtHost.Text
        If lvResources.SelectedItems.Count > 0 Then
            url = lvResources.SelectedItems(0).Text
        End If

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim stream As New FileStream(SaveFileDialog1.FileName, FileMode.CreateNew)
            WebDav1.Get(url, stream)
            stream.Close()
            MessageBox.Show("The resource has been downloaded and stored in to " + SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        WebDav1.UserName = edtUser.Text
        WebDav1.Password = edtPassword.Text
        AssignDepth()

        Dim url As String = edtHost.Text
        If lvResources.SelectedItems.Count > 0 Then
            url = lvResources.SelectedItems(0).Text
        End If

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim stream As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
            WebDav1.Put(url + "/" + Path.GetFileName(OpenFileDialog1.FileName), stream)
            stream.Close()

            btnOpen_Click(Nothing, Nothing)
            MessageBox.Show("The file has been uploaded in to " + url)
        End If
    End Sub

    Private Sub lvResources_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvResources.DoubleClick
        If lvResources.SelectedItems.Count > 0 Then
            edtHost.Text = lvResources.SelectedItems(0).Text
        End If
        btnOpen_Click(Nothing, Nothing)
    End Sub
End Class
