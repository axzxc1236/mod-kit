Public Class Ver164

    Private Sub Ver164_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.Show()
    End Sub

    Private Sub Ver164_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        ToolTip1.SetToolTip(CheckBox1, My.Resources.Tooltip.Forge)
        ToolTip1.SetToolTip(CheckBox2, My.Resources.Tooltip.Intevtory_Tweaks)
        ToolTip1.SetToolTip(CheckBox3, My.Resources.Tooltip.Voxelmap)
        ToolTip1.SetToolTip(CheckBox4, My.Resources.Tooltip.Damage_Indicators)
        ToolTip1.SetToolTip(CheckBox5, My.Resources.Tooltip.bspkrsCore)
        ToolTip1.SetToolTip(CheckBox6, My.Resources.Tooltip.ArmorStatusHUD)
        ToolTip1.SetToolTip(CheckBox7, My.Resources.Tooltip.DirectionHUD)
        ToolTip1.SetToolTip(CheckBox8, My.Resources.Tooltip.StatusEffectHUD)
        ToolTip1.SetToolTip(CheckBox9, My.Resources.Tooltip.InGameInfoXML)
        ToolTip1.SetToolTip(CheckBox10, My.Resources.Tooltip.Rei_s_Minimap)
        ToolTip1.SetToolTip(CheckBox11, My.Resources.Tooltip.CraftGuide)
        ToolTip1.SetToolTip(CheckBox12, My.Resources.Tooltip.iChun_Util)
        ToolTip1.SetToolTip(CheckBox13, My.Resources.Tooltip.Mob_Amputation)
        ToolTip1.SetToolTip(CheckBox14, My.Resources.Tooltip.Mob_Dismemberment)
        ToolTip1.SetToolTip(CheckBox15, My.Resources.Tooltip.CodeChickenCore)
        ToolTip1.SetToolTip(CheckBox16, My.Resources.Tooltip.Not_Enough_Items)
        ToolTip1.SetToolTip(CheckBox17, My.Resources.Tooltip.Waila)

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

        'mod10 - Rei's minimap
        Label10.Visible = False
        ComboBox10.Visible = False

        'mod11 - CraftGuide
        ComboBox11.Items.Add("latest")
        For i = 5 To 3 Step -1
            ComboBox11.Items.Add("1.6.7." & i)
        Next
        ComboBox11.Text = "latest"

        'mod12 - iChun Util
        ComboBox12.Items.Add("latest")
        ComboBox12.Items.Add("2.4.0")
        ComboBox12.Items.Add("2.3.0")
        ComboBox12.Items.Add("2.2.0")
        ComboBox12.Items.Add("2.1.0")
        ComboBox12.Items.Add("2.0.0")
        ComboBox12.Text = "latest"

        'mod13 - Mob Amputation
        ComboBox13.Items.Add("latest")
        ComboBox13.Items.Add("2.0.1")
        ComboBox13.Items.Add("2.0.0")
        ComboBox13.Text = "latest"

        'mod14 - Mob Dismemberment
        Label14.Visible = False
        ComboBox14.Visible = False

        'mod15 - CodeChickenCore
        ComboBox15.Items.Add("latest")
        For i = 9 To 6 Step -1
            ComboBox15.Items.Add("0.9.0." & i)
        Next
        ComboBox15.Text = "latest"

        'mod16 - Not Enough Items
        ComboBox16.Items.Add("latest")
        ComboBox16.Items.Add("1.6.1.9")
        ComboBox16.Items.Add("1.6.1.8")
        ComboBox16.Items.Add("1.6.1.5")
        ComboBox16.Text = "latest"

        'mod17 - Waila
        ComboBox17.Items.Add("latest")
        ComboBox17.Items.Add("1.5.1a")
        ComboBox17.Items.Add("1.5.1")
        ComboBox17.Items.Add("1.5.0")
        ComboBox17.Items.Add("1.4.5a")
        ComboBox17.Items.Add("1.4.5")
        ComboBox17.Text = "latest"

        ComboBox2.Enabled = False
        ComboBox4.Enabled = False
        ComboBox5.Enabled = False
        ComboBox6.Enabled = False
        ComboBox7.Enabled = False
        ComboBox8.Enabled = False
        ComboBox9.Enabled = False
        ComboBox10.Enabled = False
        ComboBox11.Enabled = False
        ComboBox12.Enabled = False
        ComboBox13.Enabled = False
        ComboBox14.Enabled = False
        ComboBox15.Enabled = False
        ComboBox16.Enabled = False
        ComboBox17.Enabled = False

        CheckBox6.Enabled = False
        CheckBox7.Enabled = False
        CheckBox8.Enabled = False
        CheckBox13.Enabled = False
        CheckBox14.Enabled = False
        CheckBox16.Enabled = False
        CheckBox17.Enabled = False
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
            CheckBox10.Enabled = False
            CheckBox11.Enabled = False
            CheckBox12.Enabled = False
            CheckBox13.Enabled = False
            CheckBox14.Enabled = False
            CheckBox15.Enabled = False
            CheckBox16.Enabled = False
            CheckBox17.Enabled = False

            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False
            CheckBox13.Checked = False
            CheckBox14.Checked = False
            CheckBox15.Checked = False
            CheckBox16.Checked = False
            CheckBox17.Checked = False
        Else
            ComboBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox9.Enabled = True
            CheckBox10.Enabled = True
            CheckBox11.Enabled = True
            CheckBox12.Enabled = True
            CheckBox15.Enabled = True
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

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = False Then ComboBox10.Enabled = False
        If CheckBox10.Checked = True Then ComboBox10.Enabled = True
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = False Then ComboBox11.Enabled = False
        If CheckBox11.Checked = True Then ComboBox11.Enabled = True
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = False Then
            ComboBox12.Enabled = False
            CheckBox13.Enabled = False
            CheckBox14.Enabled = False
        End If

        If CheckBox12.Checked = True Then
            ComboBox12.Enabled = True
            CheckBox13.Enabled = True
            CheckBox14.Enabled = True
        End If

    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = False Then ComboBox13.Enabled = False
        If CheckBox13.Checked = True Then ComboBox13.Enabled = True
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = False Then ComboBox14.Enabled = False
        If CheckBox14.Checked = True Then ComboBox14.Enabled = True
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = False Then
            ComboBox15.Enabled = False
            CheckBox16.Enabled = False
        End If

        If CheckBox15.Checked = True Then
            ComboBox15.Enabled = True
            CheckBox16.Enabled = True
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = False Then
            ComboBox16.Enabled = False
            CheckBox17.Enabled = False
        End If

        If CheckBox16.Checked = True Then
            ComboBox16.Enabled = True
            CheckBox17.Enabled = True
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked = False Then ComboBox17.Enabled = False
        If CheckBox17.Checked = True Then ComboBox17.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

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
        CheckBox13.Checked = True
        CheckBox14.Checked = True
        CheckBox15.Checked = True
        CheckBox16.Checked = True
        CheckBox17.Checked = True
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
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False

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
        If CheckBox13.Enabled = True And CheckBox13.Checked = True Then count += 1
        If CheckBox14.Enabled = True And CheckBox14.Checked = True Then count += 1
        If CheckBox15.Enabled = True And CheckBox15.Checked = True Then count += 1
        If CheckBox16.Enabled = True And CheckBox16.Checked = True Then count += 1
        If CheckBox17.Enabled = True And CheckBox17.Checked = True Then count += 1
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

        If CheckBox1.Enabled = True And Not My.Computer.FileSystem.DirectoryExists(Main.TextBox1.Text & "\versions\1.6.4-Forge" & ComboBox1.Text) Then
            Me.Text = current & " of " & count & "-安裝Forge"
            My.Computer.FileSystem.CreateDirectory(Main.TextBox1.Text & "\versions\1.6.4-Forge" & ComboBox1.Text)
            My.Computer.Network.DownloadFile("http://s3.amazonaws.com/Minecraft.Download/versions/1.6.4/1.6.4.jar", Main.TextBox1.Text & "\versions\1.6.4-Forge" & ComboBox1.Text & "\1.6.4-Forge" & ComboBox1.Text & ".jar")
            My.Computer.Network.DownloadFile("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.6.4-" & ComboBox1.Text & "/forge-1.6.4-" & ComboBox1.Text & "-installer.jar", Environment.CurrentDirectory & "\mod-kit\Forge.jar", "", "", False, 100000, True)
            Shell("cmd /c mod-kit\unzip.bat", AppWinStyle.Hide, True)
            If ComboBox1.Text.Substring(ComboBox1.Text.Length - 3) >= 960 Then My.Computer.FileSystem.MoveFile(Environment.CurrentDirectory & "\mod-kit\Forge\minecraftforge-universal-1.6.4-" & ComboBox1.Text & "-v164-pregradle.jar", Main.TextBox1.Text & "\libraries\net\minecraftforge\minecraftforge\" & ComboBox1.Text & "\minecraftforge-" & ComboBox1.Text & ".jar")
            If ComboBox1.Text.Substring(ComboBox1.Text.Length - 3) <= 953 Then My.Computer.FileSystem.MoveFile(Environment.CurrentDirectory & "\mod-kit\Forge\minecraftforge-universal-1.6.4-" & ComboBox1.Text & ".jar", Main.TextBox1.Text & "\libraries\net\minecraftforge\minecraftforge\" & ComboBox1.Text & "\minecraftforge-" & ComboBox1.Text & ".jar")
            My.Computer.FileSystem.MoveFile(Environment.CurrentDirectory & "\mod-kit\Forge\install_profile.json", Main.TextBox1.Text & "\versions\1.6.4-Forge" & ComboBox1.Text & "\1.6.4-Forge" & ComboBox1.Text & ".json")

            Common_code.replace_json("1.6.4-Forge" & ComboBox1.Text, "    ", "	")
            Common_code.DeleteLine(Main.TextBox1.Text & "\versions\1.6.4-Forge" & ComboBox1.Text & "\1.6.4-Forge" & ComboBox1.Text & ".json", 1)
            Common_code.replace_json("1.6.4-Forge" & ComboBox1.Text, "							", "@7")
            Common_code.replace_json("1.6.4-Forge" & ComboBox1.Text, "						", "@6")
            Common_code.replace_json("1.6.4-Forge" & ComboBox1.Text, "					", "@5")
            Common_code.replace_json("1.6.4-Forge" & ComboBox1.Text, "				", "@4")
            Common_code.replace_json("1.6.4-Forge" & ComboBox1.Text, "			", "@3")
            Common_code.replace_json("1.6.4-Forge" & ComboBox1.Text, "		", "@2")
            Common_code.replace_json("1.6.4-Forge" & ComboBox1.Text, "	", "")
            Common_code.replace_json("1.6.4-Forge" & ComboBox1.Text, "@2", "	")
            Common_code.replace_json("1.6.4-Forge" & ComboBox1.Text, "@3", "		")
            Common_code.replace_json("1.6.4-Forge" & ComboBox1.Text, "@4", "			")
            Common_code.replace_json("1.6.4-Forge" & ComboBox1.Text, "@5", "				")
            Common_code.replace_json("1.6.4-Forge" & ComboBox1.Text, "@6", "					")
            Common_code.replace_json("1.6.4-Forge" & ComboBox1.Text, "@7", "						")

            For i = 207 To 218
                Common_code.DeleteLine(Main.TextBox1.Text & "\versions\1.6.4-Forge" & ComboBox1.Text & "\1.6.4-Forge" & ComboBox1.Text & ".json", 207)
            Next

            Shell("mod-kit\encode_converter.exe " & Main.TextBox1.Text & "\versions\1.6.4-Forge" & ComboBox1.Text & "\1.6.4-Forge" & ComboBox1.Text & ".json", AppWinStyle.Hide, True)

            current += 1
        End If

        If CheckBox2.Enabled And CheckBox2.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Inventory tweaks"
            If ComboBox2.Text = "latest" Then ComboBox2.Text = "1.57-dev-95"
            Common_code.download("http://build.technicpack.net/job/Inventory-Tweaks/" & ComboBox2.Text.Substring(ComboBox2.Text.Length - 2) & "/artifact/build/libs/InventoryTweaks-" & ComboBox2.Text & ".jar", Main.TextBox1.Text & "\mods\" & "InventoryTweaks-" & ComboBox2.Text & ".jar")
            current += 1
        End If

        If CheckBox3.Enabled And CheckBox3.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Voxelmap"
            Common_code.download("https://dl.dropboxusercontent.com/s/c0ch778cnd9xmb1/ZansMinimap1.6.4.zip", Main.TextBox1.Text & "\mods\" & "ZansMinimap1.6.4.zip")
            current += 1
        End If

        If CheckBox4.Enabled And CheckBox4.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Damage Indicators"
            If ComboBox4.Text = "latest" Then ComboBox4.Text = "2.9.2.3"
            Common_code.download("https://dl.dropboxusercontent.com/u/74770478/1.6.4%20DamageIndicatorsv" & ComboBox4.Text & ".zip", Main.TextBox1.Text & "\mods\" & "[1.6.4]DamageIndicatorsMod-" & ComboBox4.Text & ".zip")
            current += 1
        End If

        If CheckBox5.Enabled And CheckBox5.Checked = True Then
            Me.Text = current & " of " & count & "-安裝bspkrsCore"
            If ComboBox5.Text = "latest" Then ComboBox5.Text = "5.3"
            Common_code.download("http://bspk.rs/MC/bspkrsCore/[1.6.4]bspkrsCorev" & ComboBox5.Text & ".zip", Main.TextBox1.Text & "\mods\[1.6.4]bspkrsCorev" & ComboBox5.Text & ".zip")
            current += 1
        End If

        If CheckBox6.Enabled And CheckBox6.Checked = True Then
            Me.Text = current & " of " & count & "-安裝ArmorStatusHUD"
            If ComboBox6.Text = "latest" Then ComboBox6.Text = "1.15"
            Common_code.download("http://bspk.rs/MC/ArmorStatusHUD/[1.6.4]ArmorStatusHUDv" & ComboBox6.Text & ".zip", Main.TextBox1.Text & "\mods\[1.6.4]ArmorStatusHUDv" & ComboBox6.Text & ".zip")
            current += 1
        End If

        If CheckBox7.Enabled And CheckBox7.Checked = True Then
            Me.Text = current & " of " & count & "-安裝DirectionHUD"
            If ComboBox7.Text = "latest" Then ComboBox7.Text = "1.16"
            Common_code.download("http://bspk.rs/MC/DirectionHUD/[1.6.4]DirectionHUDv" & ComboBox7.Text & ".zip", Main.TextBox1.Text & "\mods\" & "[1.6.4]DirectionHUDv" & ComboBox7.Text & ".zip")
            current += 1
        End If

        If CheckBox8.Enabled And CheckBox8.Checked = True Then
            Me.Text = current & " of " & count & "-安裝StatusEffectHUD"
            If ComboBox8.Text = "latest" Then ComboBox8.Text = "1.19"
            Common_code.download("http://bspk.rs/MC/StatusEffectHUD/[1.6.4]StatusEffectHUDv" & ComboBox8.Text & ".zip", Main.TextBox1.Text & "\mods\" & "[1.6.4]StatusEffectHUDv" & ComboBox8.Text & ".zip")
            current += 1
        End If

        If CheckBox10.Enabled And CheckBox10.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Rei's minimap"
            Common_code.download("https://dl.dropboxusercontent.com/u/34787499/minecraft/1.6.4/%5B1.6.4%5DReiMinimap_v3.4_01.zip", Main.TextBox1.Text & "\mods\[1.6.4]ReiMinimap_v3.4_01.zip")
            current += 1
        End If

        If CheckBox11.Enabled And CheckBox11.Checked = True Then
            Me.Text = current & " of " & count & "-安裝CraftGuide"
            If ComboBox11.Text = "latest" Then ComboBox11.Text = "1.6.7.5"
            If Not ComboBox11.Text = "1.6.7.5" Then Common_code.download("https://dl.dropboxusercontent.com/u/26846767/Minecraft/CraftGuide/1.6.2/CraftGuide-" & ComboBox11.Text & ".zip", Main.TextBox1.Text & "\mods\[1.6.2]CraftGuide-" & ComboBox11.Text & ".zip")
            If ComboBox11.Text = "1.6.7.5" Then Common_code.download("https://dl.dropboxusercontent.com/u/26846767/Minecraft/CraftGuide/1.6.4/CraftGuide-1.6.7.5.zip", Main.TextBox1.Text & "\mods\[1.6.4]CraftGuide-1.6.7.5.zip")
            current += 1
        End If

        If CheckBox12.Enabled And CheckBox12.Checked = True Then
            Me.Text = current & " of " & count & "-安裝iChun Util"
            If ComboBox12.Text = "latest" Then ComboBox12.Text = "2.4.0"
            Common_code.download("http://repo.creeperhost.net/downloads/ichun/util%5EiChunUtil" & ComboBox12.Text & ".zip", Main.TextBox1.Text & "\mods\iChunUtil" & ComboBox12.Text & ".zip")
            current += 1
        End If

        If CheckBox13.Enabled And CheckBox13.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Mob Amputation"
            If ComboBox13.Text = "latest" Then ComboBox13.Text = "2.0.1"
            Common_code.download("http://repo.creeperhost.net/downloads/ichun/files%5EMobAmputation" & ComboBox13.Text & ".zip", Main.TextBox1.Text & "\mods\MobAmputation" & ComboBox13.Text & ".zip")
            current += 1
        End If

        If CheckBox14.Enabled And CheckBox14.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Mob Dismemberment"
            Common_code.download("http://repo.creeperhost.net/downloads/ichun/files%5EMobDismemberment2.0.0.zip", Main.TextBox1.Text & "\mods\MobDismemberment2.0.0.zip")
            current += 1
        End If

        If CheckBox15.Enabled And CheckBox15.Checked = True Then
            Me.Text = current & " of " & count & "-安裝CodeChickenCore"
            If ComboBox15.Text = "latest" Then ComboBox15.Text = "0.9.0.9"
            If Not ComboBox15.Text = "0.9.0.9" Then Common_code.download("http://www.chickenbones.craftsaddle.org/Files/Old_Versions/1.6.4/CodeChickenCore%20" & ComboBox15.Text & ".jar", Main.TextBox1.Text & "\mods\CodeChickenCore " & ComboBox15.Text & ".jar")
            If ComboBox15.Text = "0.9.0.9" Then Common_code.download("http://www.chickenbones.craftsaddle.org/Files/New_Versions/1.6.4/CodeChickenCore%200.9.0.9.jar", Main.TextBox1.Text & "\mods\CodeChickenCore 0.9.0.9.jar")
            current += 1
        End If

        If CheckBox16.Enabled And CheckBox16.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Not Enough Items"
            If ComboBox16.Text = "latest" Then ComboBox16.Text = "1.6.1.9"
            If Not ComboBox16.Text = "1.6.1.9" Then Common_code.download("http://www.chickenbones.craftsaddle.org/Files/Old_Versions/1.6.4/NotEnoughItems%20" & ComboBox16.Text & ".jar", Main.TextBox1.Text & "\mods\NotEnoughItems " & ComboBox16.Text & ".jar")
            If ComboBox16.Text = "1.6.1.9" Then Common_code.download("http://www.chickenbones.craftsaddle.org/Files/New_Versions/1.6.4/NotEnoughItems%201.6.1.9.jar", Main.TextBox1.Text & "\mods\NotEnoughItems 1.6.1.9.jar")
            current += 1
        End If

        If CheckBox17.Enabled And CheckBox17.Checked = True Then
            Me.Text = current & " of " & count & "-安裝Waila"
            If ComboBox17.Text = "latest" Then ComboBox17.Text = "1.5.1a"
            If ComboBox17.Text = "1.5.1a" Then Common_code.download("http://www.curseforge.com/media/files/775/607/Waila_1.5.1a.zip", Main.TextBox1.Text & "\mods\Waila_1.5.1a.zip")
            If ComboBox17.Text = "1.5.1" Then Common_code.download("http://www.curseforge.com/media/files/774/674/Waila_1.5.1.zip", Main.TextBox1.Text & "\mods\Waila_1.5.1.zip")
            If ComboBox17.Text = "1.5.0" Then Common_code.download("http://www.curseforge.com/media/files/774/350/Waila_1.5.0.zip", Main.TextBox1.Text & "\mods\Waila_1.5.0.zip")
            If ComboBox17.Text = "1.4.5a" Then Common_code.download("http://www.curseforge.com/media/files/773/186/Waila_1.4.5a.zip", Main.TextBox1.Text & "\mods\Waila_1.4.5a.zip")
            If ComboBox17.Text = "1.4.5" Then Common_code.download("http://www.curseforge.com/media/files/771/381/Waila_1.4.5.zip", Main.TextBox1.Text & "\mods\Waila_1.4.5.zip")
            current += 1
        End If

        MsgBox("Done!")

        Me.Name = "Ver164"
    End Sub
End Class