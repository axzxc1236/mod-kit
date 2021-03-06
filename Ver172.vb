﻿Public Class Ver172
    Private Sub Ver172_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.Show()
    End Sub

    Private Sub Ver172_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        ToolTip1.SetToolTip(CheckBox1, My.Resources.Tooltip.Forge)
        ToolTip1.SetToolTip(CheckBox2, My.Resources.Tooltip.Intevtory_Tweaks)
        ToolTip1.SetToolTip(CheckBox3, My.Resources.Tooltip.Voxelmap)
        ToolTip1.SetToolTip(CheckBox4, My.Resources.Tooltip.Damage_Indicators)
        ToolTip1.SetToolTip(CheckBox5, My.Resources.Tooltip.bspkrsCore)
        ToolTip1.SetToolTip(CheckBox6, My.Resources.Tooltip.ArmorStatusHUD)
        ToolTip1.SetToolTip(CheckBox7, My.Resources.Tooltip.DirectionHUD)
        ToolTip1.SetToolTip(CheckBox8, My.Resources.Tooltip.StatusEffectHUD)
        ToolTip1.SetToolTip(CheckBox9, My.Resources.Tooltip.LunatriusCore)
        ToolTip1.SetToolTip(CheckBox10, My.Resources.Tooltip.InGameInfoXML)
        ToolTip1.SetToolTip(CheckBox11, My.Resources.Tooltip.Waila)
        ToolTip1.SetToolTip(CheckBox12, My.Resources.Tooltip.CraftGuide)

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
        ComboBox2.Items.Add("1.58-dev-118")
        ComboBox2.Items.Add("1.57-dev-117")
        ComboBox2.Items.Add("1.57-116")
        For i = Val(My.Resources.mods_ver_172.Invtweak172latest) To Val(My.Resources.mods_ver_172.Invtweak172min) Step -1
            ComboBox2.Items.Add("1.57-dev-" & i)
        Next
        ComboBox2.Items.Remove("1.57-dev-99")
        ComboBox2.Items.Remove("1.57-dev-116")
        ComboBox2.Text = "latest"

        'mod3 - Voxelmap
        Label3.Visible = False
        ComboBox3.Visible = False

        'mod4 - Damage Indicators
        ComboBox4.Items.Add("latest")
        ComboBox4.Items.Add("3.1.0")
        For i = 9 To Val(My.Resources.mods_ver_172.DI172min) Step -1
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

        'mod9 - LunatriusCore
        ComboBox9.Items.Add("latest")
        ComboBox9.Items.Add("1.0.1." & My.Resources.mods_ver_172.LunaCore172latest)
        ComboBox9.Items.Add("1.0.0.3")
        ComboBox9.Items.Add("1.0.0." & My.Resources.mods_ver_172.LunaCore172min)
        ComboBox9.Text = "latest"

        'mod10 - InGameInfoXML
        ComboBox10.Items.Add("latest")
        For i = Val(My.Resources.mods_ver_172.InGameInfo172latest) To 40 Step -1
            ComboBox10.Items.Add("2.6.0." & i)
        Next
        For i = 39 To Val(My.Resources.mods_ver_172.InGameInfo172min) Step -1
            ComboBox10.Items.Add("2.5.1." & i)
        Next
        ComboBox10.Text = "latest"

        'mod11 - Waila
        Label11.Visible = False
        ComboBox11.Visible = False

        'mod12 - Craftguide
        Label12.Visible = False
        ComboBox12.Visible = False

        ComboBox2.Enabled = False
        ComboBox4.Enabled = False
        ComboBox6.Enabled = False
        ComboBox7.Enabled = False
        ComboBox8.Enabled = False
        ComboBox9.Enabled = False
        ComboBox10.Enabled = False

        CheckBox6.Enabled = False
        CheckBox7.Enabled = False
        CheckBox8.Enabled = False
        CheckBox10.Enabled = False

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
            CheckBox10.Enabled = False
            CheckBox11.Enabled = False
            CheckBox12.Enabled = False

            CheckBox2.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
        Else
            ComboBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox9.Enabled = True
            CheckBox11.Enabled = True
            CheckBox12.Enabled = True
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
        If CheckBox9.Checked = False Then
            ComboBox9.Enabled = False
            CheckBox10.Enabled = False
        Else
            ComboBox9.Enabled = True
            CheckBox10.Enabled = True
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = False Then ComboBox10.Enabled = False
        If CheckBox10.Checked = True Then ComboBox10.Enabled = True
    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try

            If CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False And
                CheckBox4.Checked = False And CheckBox5.Checked = False And CheckBox6.Checked = False And
                CheckBox7.Checked = False And CheckBox8.Checked = False And CheckBox9.Checked = False And
                CheckBox10.Checked = False Then
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

        Catch ex As System.Net.WebException
            MsgBox("無法下載到需要的檔案，程序中止，請稍後重試", 16, "錯誤")
        End Try

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
        CheckBox10.Checked = True
        CheckBox11.Checked = True
        CheckBox12.Checked = True
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
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
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
        current += 1
        If CheckBox1.Enabled = True And CheckBox1.Checked = True And Not My.Computer.FileSystem.DirectoryExists(Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text) Then count += 1
        If CheckBox2.Enabled = True And CheckBox2.Checked = True Then count += 1
        If CheckBox3.Enabled = True And CheckBox3.Checked = True Then count += 1
        If CheckBox4.Enabled = True And CheckBox4.Checked = True Then count += 1
        If CheckBox5.Enabled = True And CheckBox5.Checked = True Then count += 1
        If CheckBox6.Enabled = True And CheckBox6.Checked = True Then count += 1
        If CheckBox7.Enabled = True And CheckBox7.Checked = True Then count += 1
        If CheckBox8.Enabled = True And CheckBox8.Checked = True Then count += 1
        If CheckBox9.Enabled = True And CheckBox9.Checked = True Then count += 1
        If CheckBox10.Enabled = True And CheckBox10.Checked = True Then count += 1
        If CheckBox11.Enabled = True And CheckBox11.Checked = True Then count += 1
        If CheckBox12.Enabled = True And CheckBox12.Checked = True Then count += 1
        If Not My.Computer.FileSystem.FileExists(Main.TextBox1.Text & "\libraries\org\scala-lang\scala-compiler\2.10.2\scala-compiler-2.10.2.jar") Then count += 1
        If Not My.Computer.FileSystem.FileExists(Main.TextBox1.Text & "\libraries\org\scala-lang\scala-library\2.10.2\scala-library-2.10.2.jar") Then count += 1

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

        If CheckBox1.Checked = True And Not My.Computer.FileSystem.DirectoryExists(Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text) Then
            Me.Text = current & " of " & count & "-安裝Forge"
            My.Computer.FileSystem.CreateDirectory(Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text)
            My.Computer.Network.DownloadFile("http://s3.amazonaws.com/Minecraft.Download/versions/1.7.2/1.7.2.jar", Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text & "\1.7.2-Forge" & ComboBox1.Text & ".jar")
            My.Computer.Network.DownloadFile("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.7.2-" & ComboBox1.Text & "/forge-1.7.2-" & ComboBox1.Text & "-installer.jar", Environment.CurrentDirectory & "\mod-kit\Forge.jar", "", "", False, 100000, True)
            Shell("cmd /c mod-kit\unzip.bat", AppWinStyle.Hide, True)
            My.Computer.FileSystem.MoveFile(Environment.CurrentDirectory & "\mod-kit\Forge\forge-1.7.2-" & ComboBox1.Text & "-universal.jar", Main.TextBox1.Text & "\libraries\net\minecraftforge\minecraftforge\" & ComboBox1.Text & "\minecraftforge-" & ComboBox1.Text & ".jar")
            My.Computer.FileSystem.MoveFile(Environment.CurrentDirectory & "\mod-kit\Forge\install_profile.json", Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text & "\1.7.2-Forge" & ComboBox1.Text & ".json")

            For i = 0 To 11
                Common_code.DeleteLine(Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text & "\1.7.2-Forge" & ComboBox1.Text & ".json", 1)
            Next
            Common_code.DeleteLine(Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text & "\1.7.2-Forge" & ComboBox1.Text & ".json", 206)

            'Common_code.replace_json("1.7.2-Forge" & ComboBox1.Text, "", "")
            Common_code.replace_json("1.7.2-Forge" & ComboBox1.Text, "  ", "    ")
            Common_code.replace_json("1.7.2-Forge" & ComboBox1.Text, "    ", "	")
            Common_code.replace_json("1.7.2-Forge" & ComboBox1.Text, """" & "serverreq" & """" & ":true", """" & "serverreq" & """" & ": true")
            Common_code.replace_json("1.7.2-Forge" & ComboBox1.Text, """" & "clientreq" & """" & ":true", """" & "clientreq" & """" & ": true")
            Common_code.replace_json("1.7.2-Forge" & ComboBox1.Text, """" & "comment" & """" & " :", """" & "comment" & """" & ":")
            Common_code.replace_json("1.7.2-Forge" & ComboBox1.Text, """" & "url" & """" & " :", """" & "url" & """" & ":")
            Common_code.replace_json("1.7.2-Forge" & ComboBox1.Text, """" & "checksums" & """" & " : [ " & """" & "6ba65d12cd09d441083262d6f73d2257fec7c663" & """" & ", " & """" & "65de4339eaed1c3675485fb03a3532fecfd8e8cd" & """" & " ],",
                         """" & "checksums" & """" & ": [" & Chr(10) & "				" & """" & "6ba65d12cd09d441083262d6f73d2257fec7c663" & """" & "," & Chr(10) & "				" & """" & "65de4339eaed1c3675485fb03a3532fecfd8e8cd" & """" & Chr(10) & "			" & "],")
            Common_code.replace_json("1.7.2-Forge" & ComboBox1.Text, """" & "checksums" & """" & " : [ " & """" & "64c8b1380cc53d6850823d6e4e7ae984aa44ef9c" & """" & ", " & """" & "99fd0ffb66f3088b0cd1071315fd5eb2b2b070ff" & """" & " ],",
                         """" & "checksums" & """" & ": [" & Chr(10) & "				" & """" & "64c8b1380cc53d6850823d6e4e7ae984aa44ef9c" & """" & "," & Chr(10) & "				" & """" & "99fd0ffb66f3088b0cd1071315fd5eb2b2b070ff" & """" & Chr(10) & "			" & "],")
            Common_code.replace_json("1.7.2-Forge" & ComboBox1.Text, Chr(10) & "}" & Chr(10), Chr(10) & "}")


            Shell("mod-kit\encode_converter.exe " & Main.TextBox1.Text & "\versions\1.7.2-Forge" & ComboBox1.Text & "\1.7.2-Forge" & ComboBox1.Text & ".json", AppWinStyle.Hide, True)



            current += 1
        End If

        If CheckBox2.Enabled And CheckBox2.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Inventory tweaks"
            If ComboBox2.Text = "latest" Then ComboBox2.Text = "1.58-dev-" & My.Resources.mods_ver_172.Invtweak172latest
            Dim ver As SByte
            If ComboBox2.Text.Length = 12 Or ComboBox2.Text.Length = 7 Then ver = ComboBox2.Text.Substring(ComboBox2.Text.Length - 3)
            If ComboBox2.Text.Length = 11 Then ver = ComboBox2.Text.Substring(ComboBox2.Text.Length - 2)
            Common_code.download("http://build.technicpack.net/job/Inventory-Tweaks/" & ver & "/artifact/build/libs/InventoryTweaks-" & ComboBox2.Text & ".jar", Main.TextBox1.Text & "\mods\" & "InventoryTweaks-" & ComboBox2.Text & ".jar")
            current += 1
        End If

        If CheckBox3.Enabled And CheckBox3.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Voxelmap"
            Common_code.download("https://dl.dropboxusercontent.com/s/boitpzvszpbsqfx/voxelmap-1.7.2-1.0.jar", Main.TextBox1.Text & "\mods\" & "voxelmap-1.7.2-1.0.jar")
            current += 1
        End If

        If CheckBox4.Enabled And CheckBox4.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Damage Indicators"
            If ComboBox4.Text = "latest" Then ComboBox4.Text = "3.1.0"
            Common_code.download("https://dl.dropboxusercontent.com/u/74770478/%5B1.7.2%5DDamageIndicatorsMod-" & ComboBox4.Text & ".jar", Main.TextBox1.Text & "\mods\" & "[1.7.2]DamageIndicatorsMod-" & ComboBox4.Text & ".jar")
            current += 1
        End If

        If CheckBox5.Enabled And CheckBox5.Checked = True Then
            Me.Text = current & " of " & count & "-安裝bspkrsCore"
            Common_code.download("http://bspk.rs/MC/bspkrsCore/[1.7.2]bspkrsCore-universal-6.0(1.7.2).jar", Main.TextBox1.Text & "\mods\[1.7.2]bspkrsCore-universal-6.0(1.7.2).jar")
            current += 1
        End If

        If CheckBox6.Enabled And CheckBox6.Checked = True Then
            Me.Text = current & " of " & count & "-安裝ArmorStatusHUD"
            If ComboBox6.Text = "latest" Then ComboBox6.Text = "1." & My.Resources.mods_ver_172.ASHUD172latest
            Common_code.download("http://bspk.rs/MC/ArmorStatusHUD/[1.7.2]ArmorStatusHUD-client-" & ComboBox6.Text & "(1.7.2).jar", Main.TextBox1.Text & "\mods\[1.7.2]ArmorStatusHUD-client-" & ComboBox6.Text & "(1.7.2).jar")
            current += 1
        End If

        If CheckBox7.Enabled And CheckBox7.Checked = True Then
            Me.Text = current & " of " & count & "-安裝DirectionHUD"
            If ComboBox7.Text = "latest" Then ComboBox7.Text = "1." & My.Resources.mods_ver_172.DHUD172latest
            Common_code.download("http://bspk.rs/MC/DirectionHUD/[1.7.2]DirectionHUD-client-" & ComboBox7.Text & "(1.7.2).jar", Main.TextBox1.Text & "\mods\" & "[1.7.2]DirectionHUD-client-" & ComboBox7.Text & "(1.7.2).jar")
            current += 1
        End If

        If CheckBox8.Enabled And CheckBox8.Checked = True Then
            Me.Text = current & " of " & count & "-安裝StatusEffectHUD"
            If ComboBox8.Text = "latest" Then ComboBox8.Text = "1." & My.Resources.mods_ver_172.SEHUD172latest
            Common_code.download("http://bspk.rs/MC/StatusEffectHUD/[1.7.2]StatusEffectHUD-client-" & ComboBox8.Text & "(1.7.2).jar", Main.TextBox1.Text & "\mods\" & "[1.7.2]StatusEffectHUD-client-" & ComboBox8.Text & "(1.7.2).jar")
            current += 1
        End If

        If CheckBox9.Enabled And CheckBox9.Checked = True Then
            Me.Text = current & " of " & count & "-安裝LunatriusCore"
            If ComboBox9.Text = "latest" Then ComboBox9.Text = "1.0.1." & My.Resources.mods_ver_172.LunaCore172latest
            Common_code.download("http://mc.lunatri.us/files/mods/forge/LunatriusCore/[1.7.2]LunatriusCore-universal-" & ComboBox9.Text & ".jar", Main.TextBox1.Text & "\mods\" & "[1.7.2]LunatriusCore-universal-" & ComboBox9.Text & ".jar")
            current += 1
        End If

        If CheckBox10.Enabled And CheckBox10.Checked = True Then
            Me.Text = current & " of " & count & "-安裝InGameInfoXML"
            If ComboBox10.Text = "latest" Then ComboBox10.Text = "2.6.0." & My.Resources.mods_ver_172.InGameInfo172latest
            Common_code.download("http://mc.lunatri.us/files/mods/forge/InGameInfoXML/[1.7.2]InGameInfoXML-" & ComboBox10.Text & ".jar", Main.TextBox1.Text & "\mods\[1.7.2]InGameInfoXML-" & ComboBox10.Text & ".jar")
            current += 1
        End If

        If CheckBox11.Enabled And CheckBox11.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Waila"
            Common_code.download("http://addons.cursecdn.com/files/771/381/Waila_1.4.5.zip", Main.TextBox1.Text & "\mods\Waila-1.4.5_1.7.2.jar")
            current += 1
        End If

        If CheckBox12.Enabled And CheckBox12.Checked = True Then
            Me.Text = current & " of " & count & "-安裝CraftGuide"
            Common_code.download("http://addons.cursecdn.com/files/778/185/CraftGuide-1.6.7.5.zip", Main.TextBox1.Text & "\mods\CraftGuide-1.6.7.5.zip")
            current += 1
        End If

        MsgBox("Done!")

        Me.Name = "Ver172"

    End Sub

    Sub install_vanilla()
        My.Computer.Network.DownloadFile("http://s3.amazonaws.com/Minecraft.Download/versions/1.7.2/1.7.2.jar", Environment.CurrentDirectory & "\mod-kit\tmp.jar", "", "", False, 100000, True)
        My.Computer.Network.DownloadFile("http://static.planetminecraft.com/files/resource_media/mod/1410/zanmap172k.zip", Environment.CurrentDirectory & "\mod-kit\mod.zip", "", "", False, 100000, True)
        Shell("cmd /c mod-kit\172voxel.bat", AppWinStyle.Hide, True)

        If My.Computer.FileSystem.DirectoryExists(Main.TextBox1.Text & "\versions\1.7.2-mod-kit\") Then My.Computer.FileSystem.DeleteDirectory(Main.TextBox1.Text & "\versions\1.7.2-mod-kit\", FileIO.DeleteDirectoryOption.DeleteAllContents)

        My.Computer.FileSystem.CopyFile(Environment.CurrentDirectory & "\mod-kit\tmp.jar", Main.TextBox1.Text & "\versions\1.7.2-mod-kit\1.7.2-mod-kit.jar")
        My.Computer.Network.DownloadFile("http://s3.amazonaws.com/Minecraft.Download/versions/1.7.2/1.7.2.json", Main.TextBox1.Text & "\versions\1.7.2-mod-kit\1.7.2-mod-kit.json")

        Common_code.replace_json("1.7.2-mod-kit", """" & "id" & """" & ": " & """" & "1.7.2" & """", """" & "id" & """" & ": " & """" & "1.7.2-mod-kit" & """")
        Common_code.replace_json("1.7.2-mod-kit", "  " & """" & "minimumLauncherVersion" & """" & ": 9," & Chr(10), "")
        Common_code.replace_json("1.7.2-mod-kit", "Main" & """", "Main" & """" & "," & Chr(10) & "  " & """" & "minimumLauncherVersion" & """" & ": 9")
        Common_code.replace_json("1.7.2-mod-kit", "      " & """" & "natives" & """" & ": {" & Chr(10) & "        " & """" & "linux" & """" & ": " & """" & "natives-linux" & """" & "," & Chr(10) & "        " & """" & "windows" & """" & ": " & """" & "natives-windows" & """" & Chr(10) & "      " & "}," & Chr(10) & "      " & """" & "extract" & """" & ": {" & Chr(10) & "        " & """" & "exclude" & """" & ": [" & Chr(10) & "          " & """" & "META-INF/" & """" & Chr(10) & "        " & "]" & Chr(10) & "      " & "}," & Chr(10) & "      " & """" & "rules" & """" & ": [" & Chr(10) & "        " & "{" & Chr(10) & "          " & """" & "action" & """" & ": " & """" & "allow" & """" & Chr(10) & "        " & "}," & Chr(10) & "        " & "{" & Chr(10) & "          " & """" & "action" & """" & ": " & """" & "disallow" & """" & "," & Chr(10) & "          " & """" & "os" & """" & ": {" & Chr(10) & "            " & """" & "name" & """" & ": " & """" & "osx" & """" & Chr(10) & "          " & "}" & Chr(10) & "        " & "}" & Chr(10) & "      " & "]",
                                                                                                                                                                                                     "      " & """" & "rules" & """" & ": [" & Chr(10) & "        " & "{" & Chr(10) & "          " & """" & "action" & """" & ": " & """" & "allow" & """" & Chr(10) & "        " & "}," & Chr(10) & "        " & "{" & Chr(10) & "          " & """" & "action" & """" & ": " & """" & "disallow" & """" & "," & Chr(10) & "          " & """" & "os" & """" & ": {" & Chr(10) & "            " & """" & "name" & """" & ": " & """" & "osx" & """" & Chr(10) & "          " & "}" & Chr(10) & "        " & "}" & Chr(10) & "      " & "]," & Chr(10) & "      " & """" & "natives" & """" & ": {" & Chr(10) & "        " & """" & "linux" & """" & ": " & """" & "natives-linux" & """" & "," & Chr(10) & "        " & """" & "windows" & """" & ": " & """" & "natives-windows" & """" & Chr(10) & "      " & "}," & Chr(10) & "      " & """" & "extract" & """" & ": {" & Chr(10) & "        " & """" & "exclude" & """" & ": [" & Chr(10) & "          " & """" & "META-INF/" & """" & Chr(10) & "        " & "]" & Chr(10) & "      " & "}")
        Common_code.replace_json("1.7.2-mod-kit", "      " & """" & "natives" & """" & ": {" & Chr(10) & "        " & """" & "osx" & """" & ": " & """" & "natives-osx" & """" & Chr(10) & "      " & "}," & Chr(10) & "      " & """" & "extract" & """" & ": {" & Chr(10) & "        " & """" & "exclude" & """" & ": [" & Chr(10) & "          " & """" & "META-INF/" & """" & Chr(10) & "        " & "]" & Chr(10) & "      " & "}," & Chr(10) & "      " & """" & "rules" & """" & ": [" & Chr(10) & "        " & "{" & Chr(10) & "          " & """" & "action" & """" & ": " & """" & "allow" & """" & "," & Chr(10) & "          " & """" & "os" & """" & ": {" & Chr(10) & "            " & """" & "name" & """" & ": " & """" & "osx" & """" & Chr(10) & "          " & "}" & Chr(10) & "        " & "}" & Chr(10) & "      " & "]",
                                                                                                                                                                                                     "      " & """" & "rules" & """" & ": [" & Chr(10) & "        " & "{" & Chr(10) & "          " & """" & "action" & """" & ": " & """" & "allow" & """" & "," & Chr(10) & "          " & """" & "os" & """" & ": {" & Chr(10) & "            " & """" & "name" & """" & ": " & """" & "osx" & """" & Chr(10) & "          " & "}" & Chr(10) & "        " & "}" & Chr(10) & "      " & "]," & Chr(10) & "      " & """" & "natives" & """" & ": {" & Chr(10) & "        " & """" & "osx" & """" & ": " & """" & "natives-osx" & """" & Chr(10) & "      " & "}," & Chr(10) & "      " & """" & "extract" & """" & ": {" & Chr(10) & "        " & """" & "exclude" & """" & ": [" & Chr(10) & "          " & """" & "META-INF/" & """" & Chr(10) & "        " & "]" & Chr(10) & "      " & "}")
        Common_code.replace_json("1.7.2-mod-kit", "--" & Chr(10) & "assetsDir", "--assetsDir")
        Common_code.replace_json("1.7.2-mod-kit", "org.lwjgl.lwjgl:lwjgl-platform:2.9.1-" & Chr(10) & Chr(10), "org.lwjgl.lwjgl:lwjgl-platform:2.9.1-")
        Common_code.replace_json("1.7.2-mod-kit", ": 9" & Chr(10) & "}" & Chr(10), ": 9" & Chr(10) & "}")

        Shell("mod-kit\encode_converter.exe " & Main.TextBox1.Text & "\versions\1.7.2-mod-kit\1.7.2-mod-kit.json", AppWinStyle.Hide, True)

        MsgBox("Done!")
    End Sub

End Class