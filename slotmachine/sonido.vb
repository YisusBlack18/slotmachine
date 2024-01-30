Imports System.Runtime.InteropServices.ComTypes

Public Class sonido
    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Private oName As String = Nothing

    Public Property Name As String
        Set(value As String)
            oName = value
        End Set
        Get
            Return oName
        End Get
    End Property

    Public Sub Play(ByVal id As Integer, ByVal repeat As Boolean, Optional vol As Integer = 1000)
        If repeat = True Then
            mciSendString("Open " & GetFile(id) & " alias " & oName, CStr(0), 0, 0)
            mciSendString("play " & oName & " repeat", CStr(0), 0, 0)
        Else
            mciSendString("Open " & GetFile(id) & " alias " & oName, CStr(0), 0, 0)
            mciSendString("play " & oName, CStr(0), 0, 0)
        End If
        mciSendString("setaudio " & oName & " volume to " & vol, CStr(0), 0, 0)
    End Sub

    Private Function GetFile(ByVal id As Integer) As String
        Dim path As String = System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().Length - 22)
        Select Case id
            Case 1
                path += "\Sonidos\LosAngelesIsBurning.mp3"
            Case 2
                path += "\Sonidos\spin.wav"
            Case 3
                path += "\Sonidos\win.wav"
        End Select

        path = Chr(34) & path & Chr(34)

        Return path
    End Function

End Class
