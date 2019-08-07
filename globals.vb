
Module globals
    Public app = New Dictionary(Of String, String) From {
        {"dir", My.Application.Info.DirectoryPath + "\MP3\"},
        {"version", "1.0.0"},
        {"color", "default"},
        {"order", "none"},
        {"tray", "hidden"}
    }

    Public list() As String
    Public pause As Boolean = False
    Public opt As Integer = 0
End Module
