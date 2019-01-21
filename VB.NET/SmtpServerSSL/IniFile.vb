Imports System.Text
Imports System.Runtime.InteropServices

Public Class IniFile
    Private Path As String

    <DllImport("kernel32")> Private Shared Function WritePrivateProfileString(ByVal section As String, ByVal key As String, ByVal val As String, ByVal filePath As String) As Int32
    End Function

    <DllImport("kernel32")> Private Shared Function GetPrivateProfileString(ByVal section As String, ByVal key As String, ByVal def As String, ByVal retVal As StringBuilder, ByVal size As Int32, ByVal filePath As String) As Int32
    End Function

    Public Sub New(ByVal path As String)
        MyBase.New()
        Me.Path = path
    End Sub

    Public Sub IniWriteValue(ByVal section As String, ByVal key As String, ByVal theValue As String)
        WritePrivateProfileString(section, key, theValue, Me.Path)
    End Sub

    Public Function IniReadValue(ByVal section As String, ByVal key As String, ByVal defaultValue As String) As String
        Dim sb As New StringBuilder(2047)
        GetPrivateProfileString(section, key, defaultValue, sb, 2047, Me.Path)
        IniReadValue = sb.ToString()
    End Function
End Class
