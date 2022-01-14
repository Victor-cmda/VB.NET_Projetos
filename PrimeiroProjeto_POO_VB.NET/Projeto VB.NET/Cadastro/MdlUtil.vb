Module MdlUtil

    Public Function Nome() As String
        Dim titulo As String = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        Return titulo
    End Function
End Module
