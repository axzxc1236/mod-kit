Public Class Download
    Private Sub Download_shown(sender As Object, e As EventArgs) Handles MyBase.Load
        'create mod-kit dictionary
        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.CurrentDirectory & "\mod-kit") Then My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.CurrentDirectory & "\mod-kit")
        '172voxel.bat
        If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory & "\mod-kit\172voxel.bat") Then
            System.IO.File.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "\mod-kit\172voxel.bat", "cd mod-kit" & vbCrLf & "if exist tmp rd /s /q tmp" & vbCrLf & "7za d tmp.jar META-INF\*" & vbCrLf & "7za x mod.zip -otmp" & vbCrLf & "7za a tmp.jar .\tmp\*")
        End If
        'unzip.bat
        If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory & "\mod-kit\unzip.bat") Then
            System.IO.File.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "\mod-kit\unzip.bat", "cd mod-kit" & vbCrLf & "7za.exe x Forge.jar -oForge -y")
        End If
        'encode_converter.bat
        If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory & "\mod-kit\encode_converter.bat") Then
            System.IO.File.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "\mod-kit\encode_converter.bat", "cd mod-kit" & vbCrLf & "wget.exe https://github.com/axzxc1236/encode_converter/releases/download/0.1/encode_converter.exe --no-check-certificate -Oencode_converter.exe")
        End If


        Label2.Text = "下載wget中"
        If Not My.Computer.FileSystem.FileExists(Environment.CurrentDirectory & "\mod-kit\wget.exe") Then My.Computer.Network.DownloadFile("http://users.ugent.be/~bpuype/wget/wget.exe", Environment.CurrentDirectory & "\mod-kit\wget.exe", "", "", False, 100000, True)
        Do While FileLen(Environment.CurrentDirectory & "\mod-kit\wget.exe") <> 401408
            My.Computer.Network.DownloadFile("http://users.ugent.be/~bpuype/wget/wget.exe", Environment.CurrentDirectory & "\mod-kit\wget.exe", "", "", False, 100000, True)
        Loop
        Label2.Text = "偵測到wget"

        Label3.Text = "下載7za中"
        If Not My.Computer.FileSystem.FileExists(Environment.CurrentDirectory & "\mod-kit\7za.exe") Then My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/s/07mw2d3o2v8xkq2/7za.exe", Environment.CurrentDirectory & "\mod-kit\7za.exe", "", "", False, 100000, True)
        Do While FileLen(Environment.CurrentDirectory & "\mod-kit\7za.exe") <> 587776
            My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/s/07mw2d3o2v8xkq2/7za.exe", Environment.CurrentDirectory & "\mod-kit\7za.exe", "", "", False, 100000, True)
        Loop
        Label3.Text = "偵測到7za"

        Label4.Text = "下載encode converter中"
        If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory & "\mod.kit\encode_converter.exe") Then Shell("cmd /c mod-kit\encode_converter.bat", AppWinStyle.Hide, True)
        Do While FileLen(My.Computer.FileSystem.CurrentDirectory & "\mod-kit\encode_converter.exe") <> 29696
            Shell("cmd /c mod-kit\encode_converter.bat", AppWinStyle.Hide, True)
        Loop
        Label4.Text = "偵測到encode converter"



        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Hide()
        Main.Show()
    End Sub
End Class
