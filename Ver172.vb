Public Class Ver172
    Private Sub Ver172_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.Show()
    End Sub

    Private Sub Ver172_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        'mod1 - Forge
        ComboBox1.Items.Add("latest")
        ComboBox1.Items.Add("Recommand")
        For i = Val(My.Resources.mods_ver_172.forge172latest) To Val(My.Resources.mods_ver_172.forge172min) Step -1
            ComboBox1.Items.Add("10.12.0." & i)
        Next
        ComboBox1.Items.Remove("10.12.0.1038")
        ComboBox1.Items.Remove("10.12.0.1037")
        ComboBox1.Items.Remove("10.12.0.1036")
        ComboBox1.Items.Remove("10.12.0.1035")
        ComboBox1.Items.Remove("10.12.0.978")
        ComboBox1.Text = "latest"

        'mod2 - Inventory tweaks
        ComboBox2.Items.Add("latest")
        For i = Val(My.Resources.mods_ver_172.Invtweak172latest) To Val(My.Resources.mods_ver_172.Invtweak172min) Step -1
            ComboBox2.Items.Add("1.57-dev-" & i)
        Next
        ComboBox2.Items.Remove("1.57-dev-99")
        ComboBox2.Text = "latest"

        'mod3 - Voxelmap
        Label3.Visible = False
        ComboBox3.Visible = False

        'mod4 - Damage Indicators
        ComboBox4.Items.Add("latest")
        For i = Val(My.Resources.mods_ver_172.DI172latest) To Val(My.Resources.mods_ver_172.DI172min) Step -1
            ComboBox4.Items.Add("3.0." & i)
        Next
        ComboBox4.Items.Remove("3.0.1")
        ComboBox4.Text = "latest"

        'mod5 - bspkrsCore
        ComboBox5.Visible = False
        Label5.Visible = False

        'mod6 - ArmorStatusHUD
        ComboBox6.Items.Add("latest")
        For i = Val(My.Resources.mods_ver_172.ASHUD172latest) To Val(My.Resources.mods_ver_172.ASHUD172min) Step -1
            ComboBox6.Items.Add("1." & i)
        Next
        ComboBox6.Text = "latest"

        'mod7 - DirectionHUD
        ComboBox7.Items.Add("latest")
        For i = Val(My.Resources.mods_ver_172.DHUD172latest) To Val(My.Resources.mods_ver_172.DHUD172min) Step -1
            ComboBox7.Items.Add("1." & i)
        Next
        ComboBox7.Text = "latest"

        'mod8 - StatusEffectHUD
        ComboBox8.Items.Add("latest")
        For i = Val(My.Resources.mods_ver_172.SEHUD172latest) To Val(My.Resources.mods_ver_172.SEHUD172min) Step -1
            ComboBox8.Items.Add("1." & i)
        Next
        ComboBox8.Text = "latest"

        'mod9 - InGameInfoXML
        ComboBox9.Items.Add("latest")
        For i = Val(My.Resources.mods_ver_172.InGameInfo172latest) To 40 Step -1
            ComboBox9.Items.Add("2.6.0." & i)
        Next
        For i = 39 To Val(My.Resources.mods_ver_172.InGameInfo172min) Step -1
            ComboBox9.Items.Add("2.5.1." & i)
        Next
        ComboBox9.Text = "latest"

        ComboBox2.Enabled = False
        ComboBox4.Enabled = False
        ComboBox6.Enabled = False
        ComboBox7.Enabled = False
        ComboBox8.Enabled = False
        ComboBox9.Enabled = False

        CheckBox6.Enabled = False
        CheckBox7.Enabled = False
        CheckBox8.Enabled = False

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            ComboBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            CheckBox9.Enabled = False

            CheckBox2.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
        Else
            ComboBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox9.Enabled = True
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then ComboBox2.Enabled = True
        If CheckBox2.Checked = False Then ComboBox2.Enabled = False
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then ComboBox3.Enabled = True
        If CheckBox3.Checked = False Then ComboBox3.Enabled = False
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            ComboBox4.Enabled = True
        Else
            ComboBox4.Enabled = False
        End If
    End Sub


    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True

        Else

            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False

            ComboBox6.Enabled = False
            ComboBox7.Enabled = False
            ComboBox8.Enabled = False

            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
        End If
    End Sub
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = False Then ComboBox6.Enabled = False
        If CheckBox6.Checked = True Then ComboBox6.Enabled = True
    End Sub
    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = False Then ComboBox7.Enabled = False
        If CheckBox7.Checked = True Then ComboBox7.Enabled = True
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = False Then ComboBox8.Enabled = False
        If CheckBox8.Checked = True Then ComboBox8.Enabled = True
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = False Then ComboBox9.Enabled = False
        If CheckBox9.Checked = True Then ComboBox9.Enabled = True
    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False And
            CheckBox4.Checked = False And CheckBox5.Checked = False And CheckBox6.Checked = False And
            CheckBox7.Checked = False And CheckBox8.Checked = False And CheckBox9.Checked = False Then
            MsgBox("沒有選取任何東西")
        Else
            If CheckBox1.Checked = True Then
                'forge
                If My.Computer.FileSystem.DirectoryExists(Main.Text & "\mods") Then
                    Dim choose As SByte
                    choose = MsgBox("建議先刪除mods資料夾(避免崩潰)再繼續，要繼續嗎?", MsgBoxStyle.YesNo)
                    If choose = 6 Then Call install()
                Else
                    Call install()
                End If
            Else
                'vanilla
                Call install_vanilla()
            End If
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True
        CheckBox5.Checked = True
        CheckBox6.Checked = True
        CheckBox7.Checked = True
        CheckBox8.Checked = True
        CheckBox9.Checked = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False

    End Sub



    Sub install()
        If ComboBox1.Text = "latest" Then ComboBox1.Text = "10.12.0." & My.Resources.mods_ver_172.forge172latest
        If ComboBox1.Text = "Recommand" Then ComboBox1.Text = "10.12.0." & My.Resources.mods_ver_172.forge172recommand

        If My.Computer.FileSystem.DirectoryExists(Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text) Then
            Dim choose As SByte
            choose = MsgBox("偵測到選擇的Forge版本已存在，需要重新安裝Forge?", MsgBoxStyle.YesNo)
            If choose = 6 Then
                If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory & "\mod-kit\Forge.jar") Then My.Computer.FileSystem.DeleteFile(Environment.CurrentDirectory & "\mod-kit\Forge.jar")
                If My.Computer.FileSystem.DirectoryExists(Environment.CurrentDirectory & "\mod-kit\Forge") Then My.Computer.FileSystem.DeleteDirectory(Environment.CurrentDirectory & "\mod-kit\Forge", FileIO.DeleteDirectoryOption.DeleteAllContents)
                If My.Computer.FileSystem.DirectoryExists(Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text) Then My.Computer.FileSystem.DeleteDirectory(Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text, FileIO.DeleteDirectoryOption.DeleteAllContents)
                If My.Computer.FileSystem.DirectoryExists(Main.TextBox1.Text & "\libraries\net\minecraftforge\minecraftforge\" & ComboBox1.Text) Then My.Computer.FileSystem.DeleteDirectory(Main.TextBox1.Text & "\libraries\net\minecraftforge\minecraftforge\" & ComboBox1.Text, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
        End If

        Dim count, current As Short
        If CheckBox1.Enabled = True And CheckBox1.Checked = True Then count += 1
        If CheckBox2.Enabled = True And CheckBox2.Checked = True Then count += 1
        If CheckBox3.Enabled = True And CheckBox3.Checked = True Then count += 1
        If CheckBox4.Enabled = True And CheckBox4.Checked = True Then count += 1
        If CheckBox5.Enabled = True And CheckBox5.Checked = True Then count += 1
        If CheckBox6.Enabled = True And CheckBox6.Checked = True Then count += 1
        If CheckBox7.Enabled = True And CheckBox7.Checked = True Then count += 1
        If CheckBox8.Enabled = True And CheckBox8.Checked = True Then count += 1
        If Not My.Computer.FileSystem.FileExists(Main.TextBox1.Text & "\libraries\org\scala-lang\scala-compiler\2.10.2\scala-compiler-2.10.2.jar") Then count += 1
        If Not My.Computer.FileSystem.FileExists(Main.TextBox1.Text & "\libraries\org\scala-lang\scala-library\2.10.2\scala-library-2.10.2.jar") Then count += 1
        If Not My.Computer.FileSystem.FileExists(Main.TextBox1.Text & "\libraries\net\minecraftforge\minecraftforge\" & ComboBox1.Text & "\minecraftforge-" & ComboBox1.Text & ".jar") Then count += 1

        If Not My.Computer.FileSystem.FileExists(Main.TextBox1.Text & "\libraries\org\scala-lang\scala-compiler\2.10.2\scala-compiler-2.10.2.jar") Then
            Me.Text = current & " of " & count & "-安裝scala-compiler"
            My.Computer.Network.DownloadFile("http://repo.maven.apache.org/maven2/org/scala-lang/scala-compiler/2.10.2/scala-compiler-2.10.2.jar", Main.TextBox1.Text & "\libraries\org\scala-lang\scala-compiler\2.10.2\scala-compiler-2.10.2.jar")
            current += 1
        End If

        If Not My.Computer.FileSystem.FileExists(Main.TextBox1.Text & "\libraries\org\scala-lang\scala-library\2.10.2\scala-library-2.10.2.jar") Then
            Me.Text = current & " of " & count & "-安裝scala-library"
            My.Computer.Network.DownloadFile("http://repo.maven.apache.org/maven2/org/scala-lang/scala-library/2.10.2/scala-library-2.10.2.jar", Main.TextBox1.Text & "\libraries\org\scala-lang\scala-compiler\2.10.2\scala-compiler-2.10.2.jar")
            current += 1
        End If

        If CheckBox1.Enabled = True And Not My.Computer.FileSystem.DirectoryExists(Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text) Then
            Me.Text = current & " of " & count & "-安裝Forge"
            My.Computer.FileSystem.CreateDirectory(Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text)
            My.Computer.Network.DownloadFile("http://s3.amazonaws.com/Minecraft.Download/versions/1.7.2/1.7.2.jar", Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text & "\1.7.2-Forge" & ComboBox1.Text & ".jar")
            My.Computer.Network.DownloadFile("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.7.2-" & ComboBox1.Text & "/forge-1.7.2-" & ComboBox1.Text & "-installer.jar", Environment.CurrentDirectory & "\mod-kit\Forge.jar", "", "", False, 100000, True)
            FileCopy("unzip.bat", Environment.CurrentDirectory & "\mod-kit\unzip.bat")
            Shell("cmd /c mod-kit\unzip.bat", AppWinStyle.Hide, True)
            My.Computer.FileSystem.MoveFile(Environment.CurrentDirectory & "\mod-kit\Forge\forge-1.7.2-" & ComboBox1.Text & "-universal.jar", Main.TextBox1.Text & "\libraries\net\minecraftforge\minecraftforge\" & ComboBox1.Text & "\minecraftforge-" & ComboBox1.Text & ".jar")
            My.Computer.FileSystem.MoveFile(Environment.CurrentDirectory & "\mod-kit\Forge\install_profile.json", Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text & "\1.7.2-Forge" & ComboBox1.Text & ".json")

            For i = 0 To 11
                DeleteLine(Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text & "\1.7.2-Forge" & ComboBox1.Text & ".json", 1)
            Next
            DeleteLine(Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text & "\1.7.2-Forge" & ComboBox1.Text & ".json", 206)

            current += 1
        End If

        If CheckBox2.Enabled And CheckBox2.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Inventory tweaks"
            If ComboBox2.Text = "latest" Then ComboBox2.Text = "1.57-dev-" & My.Resources.mods_ver_172.Invtweak172latest
            Call download("http://build.technicpack.net/job/Inventory-Tweaks/" & Val(My.Resources.mods_ver_172.Invtweak172latest) & "/artifact/build/libs/InventoryTweaks-" & ComboBox2.Text & ".jar", Main.TextBox1.Text & "\mods\" & "InventoryTweaks-" & ComboBox2.Text & ".jar", current)
        End If

        If CheckBox3.Enabled And CheckBox3.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Voxelmap"
            Call download("https://dl.dropboxusercontent.com/s/boitpzvszpbsqfx/voxelmap-1.7.2-1.0.jar?dl=1&token_hash=AAF1ZA2AhwjhslkjEfT9kSk_qqfxduqviI4JGhgtg7M9Bw", Main.TextBox1.Text & "\mods\" & "voxelmap-1.7.2-1.0.jar", current)
        End If

        If CheckBox4.Enabled And CheckBox4.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Damage Indicators"
            If ComboBox4.Text = "latest" Then ComboBox4.Text = "3.0." & My.Resources.mods_ver_172.DI172latest
            Call download("https://dl.dropboxusercontent.com/u/74770478/%5B1.7.2%5DDamageIndicatorsMod-" & ComboBox4.Text & ".jar", Main.TextBox1.Text & "\mods\" & "[1.7.2]DamageIndicatorsMod-" & ComboBox4.Text & ".jar", current)
        End If

        If CheckBox5.Enabled And CheckBox5.Checked = True Then
            Me.Text = current & " of " & count & "-安裝bspkrsCore"
            Call download("http://bspk.rs/MC/bspkrsCore/[1.7.2]bspkrsCore-universal-6.0(1.7.2).jar", Main.TextBox1.Text & "\mods\[1.7.2]bspkrsCore-universal-6.0(1.7.2).jar", current)
        End If

        If CheckBox6.Enabled And CheckBox6.Checked = True Then
            Me.Text = current & " of " & count & "-安裝ArmorStatusHUD"
            If ComboBox6.Text = "latest" Then ComboBox6.Text = "1." & My.Resources.mods_ver_172.ASHUD172latest
            Call download("http://bspk.rs/MC/ArmorStatusHUD/[1.7.2]ArmorStatusHUD-client-" & ComboBox6.Text & "(1.7.2).jar", Main.TextBox1.Text & "\mods\[1.7.2]ArmorStatusHUD-client-" & ComboBox6.Text & "(1.7.2).jar", current)
        End If

        If CheckBox7.Enabled And CheckBox7.Checked = True Then
            Me.Text = current & " of " & count & "-安裝DirectionHUD"
            If ComboBox7.Text = "latest" Then ComboBox7.Text = "1." & My.Resources.mods_ver_172.DHUD172latest
            Call download("http://bspk.rs/MC/DirectionHUD/[1.7.2]DirectionHUD-client-" & ComboBox7.Text & "(1.7.2).jar", Main.TextBox1.Text & "\mods\" & "[1.7.2]DirectionHUD-client-" & ComboBox7.Text & "(1.7.2).jar", current)
        End If

        If CheckBox8.Enabled And CheckBox8.Checked = True Then
            Me.Text = current & " of " & count & "-安裝StatusEffectHUD"
            If ComboBox8.Text = "latest" Then ComboBox8.Text = "1." & My.Resources.mods_ver_172.SEHUD172latest
            Call download("http://bspk.rs/MC/StatusEffectHUD/[1.7.2]StatusEffectHUD-client-" & ComboBox8.Text & "(1.7.2).jar", Main.TextBox1.Text & "\mods\" & "[1.7.2]StatusEffectHUD-client-" & ComboBox8.Text & "(1.7.2).jar", current)
        End If

        If CheckBox9.Enabled And CheckBox9.Checked = True Then
            Me.Text = current & " of " & count & "-安裝InGameInfoXML"
            If ComboBox9.Text = "latest" Then ComboBox9.Text = "2.6.0." & My.Resources.mods_ver_172.InGameInfo172latest
            Call download("http://mc.lunatri.us/files/mods/forge/InGameInfoXML/[1.7.2]InGameInfoXML-" & ComboBox9.Text & ".jar", Main.TextBox1.Text & "\mods\[1.7.2]InGameInfoXML-" & ComboBox9.Text & ".jar", current)
        End If

        MsgBox("Done!")

    End Sub

    Sub install_vanilla()
        My.Computer.Network.DownloadFile("http://s3.amazonaws.com/Minecraft.Download/versions/1.7.2/1.7.2.jar", Environment.CurrentDirectory & "\mod-kit\tmp.jar", "", "", False, 100000, True)
        My.Computer.Network.DownloadFile("http://static.planetminecraft.com/files/resource_media/mod/1410/zanmap172k.zip", Environment.CurrentDirectory & "\mod-kit\mod.zip", "", "", False, 100000, True)
        FileCopy("172voxel.bat", Environment.CurrentDirectory & "\mod-kit\172voxel.bat")
        Shell("cmd /c mod-kit\172voxel.bat", AppWinStyle.Hide, True)

        'the code below doesn't work,I don't know why!

        'Shell(Environment.CurrentDirectory & "\mod-kit\7za.exe -y d " & Environment.CurrentDirectory & "\mod-kit\tmp.jar META-INF\*", AppWinStyle.Hide, True)
        'Shell(Environment.CurrentDirectory & "\mod-kit\7za.exe -y x " & Environment.CurrentDirectory & "\mod-kit\mod.zip -o" & Environment.CurrentDirectory & "\tmp", AppWinStyle.Hide, True)
        'Shell(Environment.CurrentDirectory & "\mod-kit\7za.exe -y a " & Environment.CurrentDirectory & "\mod-kit\tmp.jar tmp\*.*", AppWinStyle.Hide, True)

        If My.Computer.FileSystem.DirectoryExists(Main.TextBox1.Text & "\versions\mod-kit\") Then My.Computer.FileSystem.DeleteDirectory(Main.TextBox1.Text & "\versions\mod-kit\", FileIO.DeleteDirectoryOption.DeleteAllContents)

        My.Computer.FileSystem.CopyFile(Environment.CurrentDirectory & "\mod-kit\tmp.jar", Main.TextBox1.Text & "\versions\mod-kit\mod-kit.jar")
        My.Computer.Network.DownloadFile("http://s3.amazonaws.com/Minecraft.Download/versions/1.7.2/1.7.2.json", Main.TextBox1.Text & "\versions\mod-kit\mod-kit.json")

        My.Computer.FileSystem.WriteAllText(Main.TextBox1.Text & "\versions\mod-kit\mod-kit.json", My.Computer.FileSystem.ReadAllText(Main.TextBox1.Text & "\versions\mod-kit\mod-kit.json").Replace("""" & "id" & """" & ": " & """" & "1.7.2" & """", """" & "id" & """" & ": " & """" & "1.7.2-mod-kit" & """"), False)
        My.Computer.FileSystem.WriteAllText(Main.TextBox1.Text & "\versions\mod-kit\mod-kit.json", My.Computer.FileSystem.ReadAllText(Main.TextBox1.Text & "\versions\mod-kit\mod-kit.json").Replace("  " & """" & "minimumLauncherVersion" & """" & ": 9," & Chr(10), ""), False)
        My.Computer.FileSystem.WriteAllText(Main.TextBox1.Text & "\versions\mod-kit\mod-kit.json", My.Computer.FileSystem.ReadAllText(Main.TextBox1.Text & "\versions\mod-kit\mod-kit.json").Replace("Main" & """", "Main," & """" & vbCrLf & "  " & """" & "minimumLauncherVersion" & """" & ": 9"), False)
        My.Computer.FileSystem.WriteAllText(Main.TextBox1.Text & "\versions\mod-kit\mod-kit.json", My.Computer.FileSystem.ReadAllText(Main.TextBox1.Text & "\versions\mod-kit\mod-kit.json").Replace("      " & """" & "natives" & """" & ": {" & Chr(10) & "        " & """" & "osx" & ": " & """" & "natives-osx" & """" & Chr(10) & "      " & "}," & Chr(10) & "      " & """" & "extract" & """" & ": {" & Chr(10) & "        " & """" & "exclude" & """" & ": [" & Chr(10) & "          " & """" & "META-INF/" & """" & Chr(10) & "        " & "]" & Chr(10) & "      " & "}," & Chr(10) & "      " & """" & "rules" & """" & ": [" & Chr(10) & "        " & "{" & Chr(10) & "          " & """" & "action" & """" & ": " & """" & "allow" & """" & "," & Chr(10) & "          " & """" & "os" & """" & ": {" & Chr(10) & "            " & """" & "name" & """" & ": " & """" & "osx" & """" & Chr(10) & "          " & "}" & Chr(10) & "        " & "}" & Chr(10) & "      " & "},",
                                                                                                                                                                                                     """" & "rules" & """" & ": [" & Chr(10) & "        {" & Chr(10) & "          " & """" & "action" & """" & ": " & """" & "allow" & """" & "," & Chr(10) & "          " & """" & "os" & """" & ": {" & Chr(10) & "            " & """" & "name" & """" & ": " & """" & "osx" & """" & Chr(10) & "          " & "}" & Chr(10) & "        " & "}" & Chr(10) & "      " & "]," & Chr(10) & "      " & """" & "natives" & """" & ": {" & Chr(10) & "        " & """" & "osx" & """" & ": " & """" & "natives-osx" & """" & Chr(10) & "      " & "}," & Chr(10) & "      " & """" & "extract" & """" & ": {" & Chr(10) & "        " & """" & "exclude" & """" & ": [" & Chr(10) & "          " & """" & "META-INF/" & """" & Chr(10) & "        " & "]" & Chr(10) & "      " & "}"), False)


        MsgBox("Done!")
    End Sub
    
    Sub download(ByVal address As String, ByVal path As String, ByVal current As SByte)
        My.Computer.Network.DownloadFile(address, path, "", "", False, 100000, True)
        current += 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FileCopy("unzip.bat", Environment.CurrentDirectory & "\mod-kit\unzip.bat")
        Shell("cmd /c mod-kit\unzip.bat", AppWinStyle.Hide, True)
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

End Class