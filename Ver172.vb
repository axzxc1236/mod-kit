Public Class Ver172

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            ComboBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False

            CheckBox2.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
        Else
            ComboBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
        End If
    End Sub

    Private Sub Ver172_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Show()
    End Sub

    Private Sub Ver172_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog

        'mod1 - Forge
        ComboBox1.Items.Add("latest")
        ComboBox1.Items.Add("Recommand")
        For i = Val(My.Resources.mods_ver.forge172latest) To Val(My.Resources.mods_ver.forge172min) Step -1
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
        For i = Val(My.Resources.mods_ver.Invtweak172latest) To Val(My.Resources.mods_ver.Invtweak172min) Step -1
            ComboBox2.Items.Add("1.57-dev-" & i)
        Next
        ComboBox2.Items.Remove("1.57-dev-99")
        ComboBox2.Text = "latest"

        'mod3 - Voxelmap
        Label3.Visible = False
        ComboBox3.Visible = False

        'mod4 - Damage Indicators
        ComboBox4.Items.Add("latest")
        For i = Val(My.Resources.mods_ver.DI172latest) To Val(My.Resources.mods_ver.DI172min) Step -1
            ComboBox4.Items.Add("3.0." & i)
        Next
        ComboBox4.Items.Remove("3.0.1")
        ComboBox4.Text = "latest"

        'mod5 - bspkrsCore
        ComboBox5.Visible = False
        Label5.Visible = False

        'mod6 - ArmorStatusHUD
        ComboBox6.Items.Add("latest")
        For i = Val(My.Resources.mods_ver.ASHUD172latest) To Val(My.Resources.mods_ver.ASHUD172min) Step -1
            ComboBox6.Items.Add("1." & i)
        Next
        ComboBox6.Text = "latest"

        'mod7 - DirectionHUD
        ComboBox7.Items.Add("latest")
        For i = Val(My.Resources.mods_ver.DHUD172latest) To Val(My.Resources.mods_ver.DHUD172min) Step -1
            ComboBox7.Items.Add("1." & i)
        Next
        ComboBox7.Text = "latest"

        'mod8 - StatusEffectHUD
        ComboBox8.Items.Add("latest")
        For i = Val(My.Resources.mods_ver.SEHUD172latest) To Val(My.Resources.mods_ver.SEHUD172min) Step -1
            ComboBox8.Items.Add("1." & i)
        Next
        ComboBox8.Text = "latest"




        ComboBox2.Enabled = False
        ComboBox4.Enabled = False
        ComboBox6.Enabled = False
        ComboBox7.Enabled = False
        ComboBox8.Enabled = False

        CheckBox6.Enabled = False
        CheckBox7.Enabled = False
        CheckBox8.Enabled = False

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            ComboBox2.Enabled = True
        Else
            ComboBox2.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            ComboBox3.Enabled = True
        Else
            ComboBox3.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            'forge
            If My.Computer.FileSystem.DirectoryExists(Form1.Text & "\mods") Then
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

    End Sub

    Sub install()
        If ComboBox1.Text = "latest" Then ComboBox1.Text = "10.12.0." & My.Resources.mods_ver.forge172latest
        If ComboBox1.Text = "Recommand" Then ComboBox1.Text = "10.12.0." & My.Resources.mods_ver.forge172recommand

        If My.Computer.FileSystem.DirectoryExists(Form1.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text) Then
            Dim choose As SByte
            choose = MsgBox("偵測到選擇的Forge版本已存在，需要重新安裝Forge?", MsgBoxStyle.YesNo)
            If choose = 6 Then
                My.Computer.FileSystem.DeleteDirectory(Form1.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text, FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteDirectory(Form1.TextBox1.Text & "\libraries\net\minecraftforge\minecraftforge\" & ComboBox1.Text, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
        End If

        Dim count, current As Short
        current = 1
        If CheckBox1.Enabled = True And CheckBox1.Checked = True Then count += 1
        If CheckBox2.Enabled = True And CheckBox2.Checked = True Then count += 1
        If CheckBox3.Enabled = True And CheckBox3.Checked = True Then count += 1
        If CheckBox4.Enabled = True And CheckBox4.Checked = True Then count += 1
        If CheckBox5.Enabled = True And CheckBox5.Checked = True Then count += 1
        If CheckBox6.Enabled = True And CheckBox6.Checked = True Then count += 1
        If CheckBox7.Enabled = True And CheckBox7.Checked = True Then count += 1
        If CheckBox8.Enabled = True And CheckBox8.Checked = True Then count += 1
        If Not My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\libraries\org\scala-lang\scala-compiler\2.10.2\scala-compiler-2.10.2.jar") Then count += 1
        If Not My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\libraries\org\scala-lang\scala-library\2.10.2\scala-library-2.10.2.jar") Then count += 1
        If Not My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\libraries\net\minecraftforge\minecraftforge\" & ComboBox1.Text & "\minecraftforge-" & ComboBox1.Text & ".jar") Then count += 1

        If Not My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\libraries\org\scala-lang\scala-compiler\2.10.2\scala-compiler-2.10.2.jar") Then
            Me.Name = current & " of " & count & "安裝scala-compiler"
            My.Computer.Network.DownloadFile("http://repo.maven.apache.org/maven2/org/scala-lang/scala-compiler/2.10.2/scala-compiler-2.10.2.jar", Form1.TextBox1.Text & "\libraries\org\scala-lang\scala-compiler\2.10.2\scala-compiler-2.10.2.jar")
            current += 1
        End If

        If Not My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\libraries\org\scala-lang\scala-library\2.10.2\scala-library-2.10.2.jar") Then
            Me.Name = current & " of " & count & "安裝scala-library"
            My.Computer.Network.DownloadFile("http://repo.maven.apache.org/maven2/org/scala-lang/scala-library/2.10.2/scala-library-2.10.2.jar", Form1.TextBox1.Text & "\libraries\org\scala-lang\scala-compiler\2.10.2\scala-compiler-2.10.2.jar")
            current += 1
        End If

        If CheckBox1.Enabled = True And Not My.Computer.FileSystem.DirectoryExists(Form1.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text) Then
            Me.Name = current & " of " & count & "安裝Forge"
            My.Computer.FileSystem.CreateDirectory(Form1.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text)
            My.Computer.Network.DownloadFile("http://s3.amazonaws.com/Minecraft.Download/versions/1.7.2/1.7.2.jar", Form1.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text & "\1.7.2-Forge" & ComboBox1.Text & ".jar")
            My.Computer.Network.DownloadFile("https://raw.github.com/MinecraftForge/FML/master/jsons/1.7.2.json", Form1.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text & "\1.7.2-Forge" & ComboBox1.Text & ".json")
            My.Computer.Network.DownloadFile("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.7.2-" & ComboBox1.Text & "/forge-1.7.2-" & ComboBox1.Text & "-universal.jar", Form1.TextBox1.Text & "\libraries\net\minecraftforge\minecraftforge\" & ComboBox1.Text & "\minecraftforge-" & ComboBox1.Text & ".jar", "", "", False, 100000, True)
            current += 1
        End If

        If CheckBox2.Enabled And CheckBox2.Checked = True Then
            Me.Name = current & " of " & count & "安裝Inventory tweaks"
            If ComboBox2.Text = "latest" Then ComboBox2.Text = "1.57-dev-" & My.Resources.mods_ver.Invtweak172latest
            If My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\mods\InventoryTweaks-" & ComboBox2.Text & ".jar") Then My.Computer.FileSystem.DeleteFile(Form1.TextBox1.Text & "\mods\" & "InventoryTweaks-" & ComboBox2.Text & ".jar")
            My.Computer.Network.DownloadFile("http://build.technicpack.net/job/Inventory-Tweaks/" & Val(My.Resources.mods_ver.Invtweak172latest) & "/artifact/build/libs/InventoryTweaks-" & ComboBox2.Text & ".jar",
                                              Form1.TextBox1.Text & "\mods\" & "InventoryTweaks-" & ComboBox2.Text & ".jar")
            current += 1
        End If

        If CheckBox3.Enabled And CheckBox3.Checked = True Then
            Me.Name = current & " of " & count & "安裝Voxelmap"
            If My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\mods\" & "voxelmap-1.7.2-1.0.jar") Then My.Computer.FileSystem.DeleteFile(Form1.TextBox1.Text & "\mods\" & "voxelmap-1.7.2-1.0.jar")
            My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/s/boitpzvszpbsqfx/voxelmap-1.7.2-1.0.jar?dl=1&token_hash=AAF1ZA2AhwjhslkjEfT9kSk_qqfxduqviI4JGhgtg7M9Bw",
                                             Form1.TextBox1.Text & "\mods\" & "voxelmap-1.7.2-1.0.jar")
            current += 1
        End If

        If CheckBox4.Enabled And CheckBox4.Checked = True Then
            Me.Name = current & " of " & count & "安裝Damage Indicators"
            If ComboBox4.Text = "latest" Then ComboBox4.Text = "3.0." & My.Resources.mods_ver.DI172latest
            If My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\mods\[1.7.2]DamageIndicatorsMod-" & ComboBox4.Text & ".jar") Then My.Computer.FileSystem.DeleteFile(Form1.TextBox1.Text & "\mods\" & "[1.7.2]DamageIndicatorsMod-" & ComboBox4.Text & ".jar")
            My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/u/74770478/%5B1.7.2%5DDamageIndicatorsMod-" & ComboBox4.Text & ".jar",
                                              Form1.TextBox1.Text & "\mods\" & "[1.7.2]DamageIndicatorsMod-" & ComboBox4.Text & ".jar")
            current += 1
        End If

        If CheckBox5.Enabled And CheckBox5.Checked = True Then
            Me.Name = current & " of " & count & "安裝bspkrsCore"
            If My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\mods\[1.7.2]bspkrsCore-universal-6.0(1.7.2).jar") Then My.Computer.FileSystem.DeleteFile(Form1.TextBox1.Text & "\mods\" & "[1.7.2]bspkrsCore-universal-6.0(1.7.2).jar")
            My.Computer.Network.DownloadFile("http://bspk.rs/MC/bspkrsCore/[1.7.2]bspkrsCore-universal-6.0(1.7.2).jar",
                                              Form1.TextBox1.Text & "\mods\[1.7.2]bspkrsCore-universal-6.0(1.7.2).jar")
            current += 1
        End If

        If CheckBox6.Enabled And CheckBox6.Checked = True Then
            Me.Name = current & " of " & count & "安裝ArmorStatusHUD"
            If ComboBox6.Text = "latest" Then ComboBox6.Text = "1." & My.Resources.mods_ver.ASHUD172latest
            If My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\mods\[1.7.2]ArmorStatusHUD-client-" & ComboBox6.Text & "(1.7.2).jar") Then My.Computer.FileSystem.DeleteFile(Form1.TextBox1.Text & "\mods\[1.7.2]ArmorStatusHUD-client-" & ComboBox6.Text & "(1.7.2).jar")
            My.Computer.Network.DownloadFile("http://bspk.rs/MC/ArmorStatusHUD/[1.7.2]ArmorStatusHUD-client-" & ComboBox6.Text & "(1.7.2).jar",
                                              Form1.TextBox1.Text & "\mods\[1.7.2]ArmorStatusHUD-client-" & ComboBox6.Text & "(1.7.2).jar")
            current += 1
        End If

        If CheckBox7.Enabled And CheckBox7.Checked = True Then
            Me.Name = current & " of " & count & "安裝DirectionHUD"
            If ComboBox7.Text = "latest" Then ComboBox7.Text = "1." & My.Resources.mods_ver.DHUD172latest
            If My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\mods\[1.7.2]DirectionHUD-client-" & ComboBox7.Text & "(1.7.2).jar") Then My.Computer.FileSystem.DeleteFile(Form1.TextBox1.Text & "\mods\" & "[1.7.2]DirectionHUD-client-" & ComboBox7.Text & "(1.7.2).jar")
            My.Computer.Network.DownloadFile("http://bspk.rs/MC/DirectionHUD/[1.7.2]DirectionHUD-client-" & ComboBox7.Text & "(1.7.2).jar",
                                              Form1.TextBox1.Text & "\mods\" & "[1.7.2]DirectionHUD-client-" & ComboBox7.Text & "(1.7.2).jar")
            current += 1
        End If

        If CheckBox8.Enabled And CheckBox8.Checked = True Then
            Me.Name = current & " of " & count & "安裝StatusEffectHUD"
            If ComboBox8.Text = "latest" Then ComboBox8.Text = "1." & My.Resources.mods_ver.SEHUD172latest
            If My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\mods\[1.7.2]StatusEffectHUD-client-" & ComboBox8.Text & "(1.7.2).jar") Then My.Computer.FileSystem.DeleteFile(Form1.TextBox1.Text & "\mods\" & "[1.7.2]StatusEffectHUD-client-" & ComboBox8.Text & "(1.7.2).jar")
            My.Computer.Network.DownloadFile("http://bspk.rs/MC/StatusEffectHUD/[1.7.2]StatusEffectHUD-client-" & ComboBox8.Text & "(1.7.2).jar",
                                              Form1.TextBox1.Text & "\mods\" & "[1.7.2]StatusEffectHUD-client-" & ComboBox8.Text & "(1.7.2).jar", "", "", False, 100000, True)
            current += 1
        End If



        MsgBox("Done!")

    End Sub

    Sub install_vanilla()
        If My.Computer.FileSystem.DirectoryExists(Environment.CurrentDirectory & "\mod-kit\") Then My.Computer.FileSystem.DeleteDirectory(Environment.CurrentDirectory & "\mod-kit\", FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/s/07mw2d3o2v8xkq2/7za.exe?dl=1&token_hash=AAEVhq1Ho3nIxdlSgCPmXJFw-QK6eC6Qjrxj9R2Lf27EBA", Environment.CurrentDirectory & "\mod-kit\7za.exe", "", "", False, 100000, True)
        My.Computer.Network.DownloadFile("http://s3.amazonaws.com/Minecraft.Download/versions/1.7.2/1.7.2.jar", Environment.CurrentDirectory & "\mod-kit\tmp.jar", "", "", False, 100000, True)
        My.Computer.Network.DownloadFile("http://static.planetminecraft.com/files/resource_media/mod/1410/zanmap172j.zip", Environment.CurrentDirectory & "\mod-kit\mod.zip", "", "", False, 100000, True)
        FileCopy("172voxel.bat", Environment.CurrentDirectory & "\mod-kit\172voxel.bat")
        Shell("cmd /c mod-kit\172voxel.bat", AppWinStyle.Hide, True)

        'the code below doesn't work,I don't know why!

        'Shell(Environment.CurrentDirectory & "\mod-kit\7za.exe -y d " & Environment.CurrentDirectory & "\mod-kit\tmp.jar META-INF\*", AppWinStyle.Hide, True)
        'Shell(Environment.CurrentDirectory & "\mod-kit\7za.exe -y x " & Environment.CurrentDirectory & "\mod-kit\mod.zip -o" & Environment.CurrentDirectory & "\tmp", AppWinStyle.Hide, True)
        'Shell(Environment.CurrentDirectory & "\mod-kit\7za.exe -y a " & Environment.CurrentDirectory & "\mod-kit\tmp.jar tmp\*.*", AppWinStyle.Hide, True)

        If My.Computer.FileSystem.DirectoryExists(Form1.TextBox1.Text & "\versions\mod-kit\") Then My.Computer.FileSystem.DeleteDirectory(Form1.TextBox1.Text & "\versions\mod-kit\", FileIO.DeleteDirectoryOption.DeleteAllContents)

        My.Computer.FileSystem.CopyFile(Environment.CurrentDirectory & "\mod-kit\tmp.jar", Form1.TextBox1.Text & "\versions\mod-kit\mod-kit.jar")
        My.Computer.Network.DownloadFile("http://s3.amazonaws.com/Minecraft.Download/versions/1.7.2/1.7.2.json", Form1.TextBox1.Text & "\versions\mod-kit\mod-kit.json")

        My.Computer.FileSystem.WriteAllText(Form1.TextBox1.Text & "\versions\mod-kit\mod-kit.json", My.Computer.FileSystem.ReadAllText(Form1.TextBox1.Text & "\versions\mod-kit\mod-kit.json").Replace("1.7.2", "mod-kit"), False)

        MsgBox("Done!")
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            ComboBox4.Enabled = True
        Else
        ComboBox4.Enabled = False
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
End Class