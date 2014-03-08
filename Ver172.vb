Public Class Ver172

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            ComboBox1.Enabled = False

            CheckBox2.Enabled = False
            CheckBox4.Enabled = False

            CheckBox2.Checked = False
            CheckBox4.Checked = False
        Else
            ComboBox1.Enabled = True

            CheckBox2.Enabled = True
            CheckBox4.Enabled = True
        End If
    End Sub

    Private Sub Ver172_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Show()
    End Sub

    Private Sub Ver172_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        'combo1
        ComboBox1.Items.Add("latest")
        ComboBox1.Items.Add("Recommand")
        For i = Val(My.Resources.mods_ver.forge172latest) To Val(My.Resources.mods_ver.forge172min) Step -1
            ComboBox1.Items.Add("10.12.0." & i)
        Next
        ComboBox1.Text = "latest"

        'combo2
        ComboBox2.Items.Add("latest")
        For i = Val(My.Resources.mods_ver.Invtweak172latest) To Val(My.Resources.mods_ver.Invtweak172min) Step -1
            ComboBox2.Items.Add("1.57-dev-" & i)
        Next
        ComboBox2.Items.Remove("1.57-dev-99")
        ComboBox2.Text = "latest"

        'combo3
        Label3.Visible = False
        ComboBox3.Visible = False

        'combo4
        ComboBox4.Items.Add("latest")
        For i = 8 To 0 Step -1
            ComboBox4.Items.Add("v3.0." & i)
        Next
        ComboBox4.Items.Remove("v3.0.1")
        ComboBox4.Text = "latest"





        ComboBox2.Enabled = False
        ComboBox4.Enabled = False
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
        If My.Computer.FileSystem.DirectoryExists(Form1.TextBox1.Text) Then
            If MsgBox("建議先刪除mods資料夾(避免崩潰)再繼續，要繼續嗎?", MsgBoxStyle.YesNo) = 6 Then
                Call install()
            End If
        Else
            Call install()
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
        If CheckBox1.Enabled = True And CheckBox1.Checked = True Then count = count + 1
        If CheckBox2.Enabled = True And CheckBox2.Checked = True Then count = count + 1
        If CheckBox3.Enabled = True And CheckBox3.Checked = True Then count = count + 1
        If CheckBox4.Enabled = True And CheckBox4.Checked = True Then count = count + 1
        If Not My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\libraries\org\scala-lang\scala-compiler\2.10.2\scala-compiler-2.10.2.jar") Then count = count + 1
        If Not My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\libraries\org\scala-lang\scala-library\2.10.2\scala-library-2.10.2.jar") Then count = count + 1
        If Not My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\libraries\net\minecraftforge\minecraftforge\" & ComboBox1.Text & "\minecraftforge-" & ComboBox1.Text & ".jar") Then count = count + 1

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
        End If

        If CheckBox2.Enabled And CheckBox2.Checked = True Then
            If ComboBox2.Text = "latest" Then ComboBox2.Text = "1.57-dev-" & My.Resources.mods_ver.Invtweak172latest
            If My.Computer.FileSystem.FileExists(Form1.TextBox1.Text & "\mods\InventoryTweaks-" & ComboBox2.Text & ".jar") Then My.Computer.FileSystem.DeleteFile(Form1.TextBox1.Text & "\mods" & "InventoryTweaks-" & ComboBox2.Text & ".jar")
            My.Computer.Network.DownloadFile("http://build.technicpack.net/job/Inventory-Tweaks/" & Val(My.Resources.mods_ver.Invtweak172latest) & "/artifact/build/libs/InventoryTweaks-" & ComboBox2.Text & ".jar",
                                              Form1.TextBox1.Text & "\mods\" & "InventoryTweaks-" & ComboBox2.Text & ".jar")
        End If

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
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
    End Sub
End Class