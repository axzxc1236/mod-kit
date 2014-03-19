Public Class Ver164

    Private Sub Ver164_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.Show()
    End Sub

    Private Sub Ver164_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        'mod1 - Forge
        ComboBox1.Items.Add("latest")
        For i = 965 To 914 Step -1
            ComboBox1.Items.Add("9.11.1." & i)
        Next
        For i = 913 To 879 Step -1
            ComboBox1.Items.Add("9.11.0." & i)
        Next
        ComboBox1.Items.Remove("9.11.1.962")
        ComboBox1.Items.Remove("9.11.1.959")
        ComboBox1.Items.Remove("9.11.1.958")
        ComboBox1.Items.Remove("9.11.1.957")
        ComboBox1.Items.Remove("9.11.1.956")
        ComboBox1.Items.Remove("9.11.1.955")
        ComboBox1.Items.Remove("9.11.1.954")
        ComboBox1.Items.Remove("9.11.1.950")
        ComboBox1.Items.Remove("9.11.1.936")
        ComboBox1.Items.Remove("9.11.1.932")
        ComboBox1.Items.Remove("9.11.1.929")
        ComboBox1.Items.Remove("9.11.1.927")
        ComboBox1.Items.Remove("9.11.1.890")
        ComboBox1.Items.Remove("9.11.1.889")
        ComboBox1.Items.Remove("9.11.1.888")
        ComboBox1.Items.Remove("9.11.1.887")
        ComboBox1.Text = "latest"

        'mod2 - Inventory tweaks
        ComboBox2.Items.Add("latest")
        ComboBox2.Items.Add("1.57-dev-95")
        ComboBox2.Items.Add("1.57-dev-94")
        For i = 86 To 78 Step -1
            ComboBox2.Items.Add("1.57-dev-b" & i)
        Next
        ComboBox2.Items.Add("1.56-dev-b77")
        For i = 76 To 74 Step -1
            ComboBox2.Items.Add("1.56-dev-b" & i)
        Next
        ComboBox2.Text = "latest"

        'mod3 - Voxelmap
        Label3.Visible = False
        ComboBox3.Visible = False

        'mod4 - Damage Indicators
        ComboBox4.Items.Add("latest")
        For i = 3 To 0 Step -1
            ComboBox4.Items.Add("2.9.2." & i)
        Next
        For i = 9 To 0 Step -1
            ComboBox4.Items.Add("2.9.1." & i)
        Next
        For i = 9 To 0 Step -1
            ComboBox4.Items.Add("2.9.0." & i)
        Next
        For i = 9 To 6 Step -1
            ComboBox4.Items.Add("2.8." & i & ".0")
        Next
        For i = 3 To 0 Step -1
            ComboBox4.Items.Add("2.8.5." & i)
        Next
        For i = 4 To 1 Step -1
            ComboBox4.Items.Add("2.8." & i & ".0")
        Next
        ComboBox4.Items.Add("2.8.0.1")
        ComboBox4.Items.Add("2.8.0.0")
        ComboBox4.Text = "latest"

        'mod5 - bspkrsCore
        ComboBox5.Items.Add("latest")
        For i = 3 To 0 Step -1
            ComboBox5.Items.Add("5." & i)
        Next
        For i = 3 To 0 Step -1
            ComboBox5.Items.Add("4." & i)
        Next
        ComboBox5.Items.Add("3.5")
        ComboBox5.Items.Add("3.4")
        ComboBox5.Text = "latest"

        'mod6 - ArmorStatusHUD
        ComboBox6.Items.Add("latest")
        For i = 15 To 12 Step -1
            ComboBox6.Items.Add("1." & i)
        Next
        ComboBox6.Text = "latest"

        'mod7 - DirectionHUD
        ComboBox7.Items.Add("latest")
        For i = 16 To 14 Step -1
            ComboBox7.Items.Add("1." & i)
        Next
        ComboBox7.Text = "latest"

        'mod8 - StatusEffectHUD
        ComboBox8.Items.Add("latest")
        For i = 19 To 14 Step -1
            ComboBox8.Items.Add("1." & i)
        Next
        ComboBox8.Text = "latest"

        'mod9 - InGameInfoXML
        ComboBox9.Items.Add("latest")
        For i = 36 To 33 Step -1
            ComboBox9.Items.Add("2.5.1." & i)
        Next
        For i = 32 To 30 Step -1
            ComboBox9.Items.Add("2.5.0." & i)
        Next
        For i = 28 To 25 Step -1
            ComboBox9.Items.Add("2.4.1." & i)
        Next
        ComboBox9.Text = "latest"

        ComboBox2.Enabled = False
        ComboBox4.Enabled = False
        ComboBox5.Enabled = False
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
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            CheckBox9.Enabled = False

            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
        Else
            ComboBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
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

            ComboBox5.Enabled = True

        Else

            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False

            ComboBox5.Enabled = False
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False And
            CheckBox4.Checked = False And CheckBox5.Checked = False And CheckBox6.Checked = False And
            CheckBox7.Checked = False And CheckBox8.Checked = False And CheckBox9.Checked = False Then
            MsgBox("沒有選取任何東西")
        Else
                'forge
                If My.Computer.FileSystem.DirectoryExists(Main.Text & "\mods") Then
                    Dim choose As SByte
                    choose = MsgBox("建議先刪除mods資料夾(避免崩潰)再繼續，要繼續嗎?", MsgBoxStyle.YesNo)
                    If choose = 6 Then Call install()
                Else
                    Call install()
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
        If ComboBox1.Text = "latest" Then ComboBox1.Text = "9.11.1.965"
        If ComboBox1.Text = "Recommand" Then ComboBox1.Text = "9.11.1.965"

        If My.Computer.FileSystem.DirectoryExists(Main.TextBox1.Text & "\versions\1.6.4-Forge" & ComboBox1.Text) Then
            Dim choose As SByte
            choose = MsgBox("偵測到選擇的Forge版本已存在，需要重新安裝Forge?", MsgBoxStyle.YesNo)
            If choose = 6 Then
                If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory & "\mod-kit\Forge.jar") Then My.Computer.FileSystem.DeleteFile(Environment.CurrentDirectory & "\mod-kit\Forge.jar")
                If My.Computer.FileSystem.DirectoryExists(Environment.CurrentDirectory & "\mod-kit\Forge") Then My.Computer.FileSystem.DeleteDirectory(Environment.CurrentDirectory & "\mod-kit\Forge", FileIO.DeleteDirectoryOption.DeleteAllContents)
                If My.Computer.FileSystem.DirectoryExists(Main.TextBox1.Text & "\versions\1.6.4-Forge" & ComboBox1.Text) Then My.Computer.FileSystem.DeleteDirectory(Main.TextBox1.Text & "\versions\1.6.4-Forge" & ComboBox1.Text, FileIO.DeleteDirectoryOption.DeleteAllContents)
                If My.Computer.FileSystem.DirectoryExists(Main.TextBox1.Text & "\libraries\net\minecraftforge\minecraftforge\" & ComboBox1.Text) Then My.Computer.FileSystem.DeleteDirectory(Main.TextBox1.Text & "\libraries\net\minecraftforge\minecraftforge\" & ComboBox1.Text, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
        End If

        Dim count, current As Short
        current += 1
        If CheckBox1.Enabled = True And CheckBox1.Checked = True Then count += 1
        If CheckBox2.Enabled = True And CheckBox2.Checked = True Then count += 1
        If CheckBox3.Enabled = True And CheckBox3.Checked = True Then count += 1
        If CheckBox4.Enabled = True And CheckBox4.Checked = True Then count += 1
        If CheckBox5.Enabled = True And CheckBox5.Checked = True Then count += 1
        If CheckBox6.Enabled = True And CheckBox6.Checked = True Then count += 1
        If CheckBox7.Enabled = True And CheckBox7.Checked = True Then count += 1
        If CheckBox8.Enabled = True And CheckBox8.Checked = True Then count += 1
        If CheckBox9.Enabled = True And CheckBox9.Checked = True Then count += 1
        If Not My.Computer.FileSystem.FileExists(Main.TextBox1.Text & "\libraries\org\scala-lang\scala-compiler\2.10.2\scala-compiler-2.10.2.jar") Then count += 1
        If Not My.Computer.FileSystem.FileExists(Main.TextBox1.Text & "\libraries\org\scala-lang\scala-library\2.10.2\scala-library-2.10.2.jar") Then count += 1

        count -= 1

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

        If CheckBox1.Enabled = True And Not My.Computer.FileSystem.DirectoryExists(Main.TextBox1.Text & "\versions\1.6.4-Forge" & ComboBox1.Text) Then
            Me.Text = current & " of " & count & "-安裝Forge"
            My.Computer.FileSystem.CreateDirectory(Main.TextBox1.Text & "\versions\1.6.4-Forge" & ComboBox1.Text)
            My.Computer.Network.DownloadFile("http://s3.amazonaws.com/Minecraft.Download/versions/1.6.4/1.6.4.jar", Main.TextBox1.Text & "\versions\1.6.4-Forge" & ComboBox1.Text & "\1.6.4-Forge" & ComboBox1.Text & ".jar")
            My.Computer.Network.DownloadFile("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.6.4-" & ComboBox1.Text & "/forge-1.6.4-" & ComboBox1.Text & "-installer.jar", Environment.CurrentDirectory & "\mod-kit\Forge.jar", "", "", False, 100000, True)
            Shell("cmd /c mod-kit\unzip.bat", AppWinStyle.Hide, True)
            My.Computer.FileSystem.MoveFile(Environment.CurrentDirectory & "\mod-kit\Forge\forge-1.6.4-" & ComboBox1.Text & "-universal.jar", Main.TextBox1.Text & "\libraries\net\minecraftforge\minecraftforge\" & ComboBox1.Text & "\minecraftforge-" & ComboBox1.Text & ".jar")
            My.Computer.FileSystem.MoveFile(Environment.CurrentDirectory & "\mod-kit\Forge\install_profile.json", Main.TextBox1.Text & "\versions\1.6.4-Forge" & ComboBox1.Text & "\1.6.4-Forge" & ComboBox1.Text & ".json")


            Shell("mod-kit\encode_converter.exe " & Main.TextBox1.Text & "\versions\1.6.4-Forge" & ComboBox1.Text & "\1.6.4-Forge" & ComboBox1.Text & ".json", AppWinStyle.Hide, True)



            current += 1
        End If

        If CheckBox2.Enabled And CheckBox2.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Inventory tweaks"
            If ComboBox2.Text = "latest" Then ComboBox2.Text = "1.57-dev-95"
            Call download("http://build.technicpack.net/job/Inventory-Tweaks/" & ComboBox2.Text.Substring(ComboBox2.Text.Length - 2) & "/artifact/build/libs/InventoryTweaks-" & ComboBox2.Text & ".jar", Main.TextBox1.Text & "\mods\" & "InventoryTweaks-" & ComboBox2.Text & ".jar")
            current += 1
        End If

        If CheckBox3.Enabled And CheckBox3.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Voxelmap"
            Call download("https://dl.dropboxusercontent.com/s/c0ch778cnd9xmb1/ZansMinimap1.6.4.zip", Main.TextBox1.Text & "\mods\" & "ZansMinimap1.6.4.zip")
            current += 1
        End If

        If CheckBox4.Enabled And CheckBox4.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Damage Indicators"
            If ComboBox4.Text = "latest" Then ComboBox4.Text = "2.9.2.3"
            Call download("https://dl.dropboxusercontent.com/u/74770478/1.6.4%20DamageIndicatorsv" & ComboBox4.Text & ".zip", Main.TextBox1.Text & "\mods\" & "[1.6.4]DamageIndicatorsMod-" & ComboBox4.Text & ".zip")
            current += 1
        End If

        If CheckBox5.Enabled And CheckBox5.Checked = True Then
            Me.Text = current & " of " & count & "-安裝bspkrsCore"
            If ComboBox4.Text = "latest" Then ComboBox5.Text = "5.3"
            Call download("http://bspk.rs/MC/bspkrsCore/[1.6.4]bspkrsCorev" & ComboBox5.Text & ".zip", Main.TextBox1.Text & "\mods\[1.6.4]bspkrsCorev" & ComboBox5.Text & ".zip")
            current += 1
        End If

        If CheckBox6.Enabled And CheckBox6.Checked = True Then
            Me.Text = current & " of " & count & "-安裝ArmorStatusHUD"
            If ComboBox6.Text = "latest" Then ComboBox6.Text = "1.15"
            Call download("http://bspk.rs/MC/ArmorStatusHUD/[1.6.4]ArmorStatusHUDv" & ComboBox6.Text & ".zip", Main.TextBox1.Text & "\mods\[1.6.4]ArmorStatusHUDv" & ComboBox6.Text & ".zip")
            current += 1
        End If

        If CheckBox7.Enabled And CheckBox7.Checked = True Then
            Me.Text = current & " of " & count & "-安裝DirectionHUD"
            If ComboBox7.Text = "latest" Then ComboBox7.Text = "1.16"
            Call download("http://bspk.rs/MC/DirectionHUD/[1.6.4]DirectionHUDv" & ComboBox7.Text & ".zip", Main.TextBox1.Text & "\mods\" & "[1.6.4]DirectionHUDv" & ComboBox7.Text & ".zip")
            current += 1
        End If

        If CheckBox8.Enabled And CheckBox8.Checked = True Then
            Me.Text = current & " of " & count & "-安裝StatusEffectHUD"
            If ComboBox8.Text = "latest" Then ComboBox8.Text = "1.19"
            Call download("http://bspk.rs/MC/StatusEffectHUD/[1.6.4]StatusEffectHUDv" & ComboBox8.Text & ".zip", Main.TextBox1.Text & "\mods\" & "[1.6.4]StatusEffectHUDv" & ComboBox8.Text & ".zip")
            current += 1
        End If

        If CheckBox9.Enabled And CheckBox9.Checked = True Then
            Me.Text = current & " of " & count & "-安裝InGameInfoXML"
            If CheckBox9.Text = "latest" Then ComboBox9.Text = "2.5.1.36"
            Call download("http://mc.lunatri.us/files/mods/forge/InGameInfoXML/[1.6.4]InGameInfoXML-" & ComboBox9.Text & ".jar", Main.TextBox1.Text & "\mods\[1.6.4]InGameInfoXML-" & CheckBox9.Text & ".jar")
            current += 1
        End If

        MsgBox("Done!")

        Me.Name = "Ver164"
    End Sub

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
End Class