Module Common_code
    Sub download(ByVal address As String, ByVal path As String)
        My.Computer.Network.DownloadFile(address, path, "", "", False, 100000, True)
    End Sub

    Public Sub DeleteLine(ByRef FileAddress As String, ByRef line As Integer)
        'the code is a copy of the code here
        'orginal:http://www.dreamincode.net/forums/topic/62488-code-for-delete-a-line-from-text-file/page__view__findpost__p__411311?s=b79e4c8d4e7a0e952d902dd2b02a551f

        Dim TheFileLines As New List(Of String)
        TheFileLines.AddRange(System.IO.File.ReadAllLines(FileAddress))
        ' if line is beyond end of list the exit sub
        If line >= TheFileLines.Count Then Exit Sub
        TheFileLines.RemoveAt(line)
        System.IO.File.WriteAllLines(FileAddress, TheFileLines.ToArray)
    End Sub

    Sub replace_json(ByRef json_name As String, ByRef replace1 As String, ByRef replace2 As String)
        My.Computer.FileSystem.WriteAllText(Main.TextBox1.Text & "\versions\" & json_name & "\" & json_name & ".json", My.Computer.FileSystem.ReadAllText(Main.TextBox1.Text & "\versions\" & json_name & "\" & json_name & ".json").Replace(replace1, replace2), False)
    End Sub
End Module
