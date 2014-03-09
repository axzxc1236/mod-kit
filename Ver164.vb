Public Class Ver164

    Private Sub Ver164_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.Show()
    End Sub

    Private Sub Ver164_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        'mod1 - Forge
        ComboBox1.Items.Add("latest")
        For i = Val(My.Resources.mods_ver_164.forge164latest) To 914 Step -1
            ComboBox1.Items.Add("9.11.1." & i)
        Next
        For i = 913 To Val(My.Resources.mods_ver_164.forge164min) Step -1
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
        ComboBox2.Items.Add("1.56-dev-95")
        ComboBox2.Items.Add("1.56-dev-94")
        For i = 86 To 78 Step -1
            ComboBox2.Items.Add("1.57-dev-b" & i)
        Next
        ComboBox2.Items.Add("1.56-dev-b77")
        For i = 76 To Val(My.Resources.mods_ver_164.Invtweak164min) Step -1
            ComboBox2.Items.Add("1.56-dev-b" & i)
        Next
        ComboBox2.Text = "latest"

        'mod3 - Voxelmap
        Label3.Visible = False
        ComboBox3.Visible = False

        'mod4 - Damage Indicators
        ComboBox4.Items.Add("latest")
        For i = 3 To 0 Step -1
            ComboBox2.Items.Add("2.9.2." & i)
        Next
        For i = 9 To 0 Step -1
            ComboBox2.Items.Add("2.9.1." & i)
        Next
        For i = 9 To 0 Step -1
            ComboBox2.Items.Add("2.9.0." & i)
        Next
        For i = 9 To 6 Step -1
            ComboBox2.Items.Add("2.8." & i & ".0")
        Next
        For i = 3 To 0 Step -1
            ComboBox2.Items.Add("2.8.5." & i)
        Next
        For i = 4 To 1 Step -1
            ComboBox2.Items.Add("2.8." & i & ".0")
        Next
        ComboBox4.Items.Add("2.8.0.1")
        ComboBox4.Items.Add("2.8.0.0")
        ComboBox4.Text = "latest"

        'mod5 - bspkrsCore
        ComboBox5.Visible = False
        Label5.Visible = False

        'mod6 - ArmorStatusHUD
        ComboBox6.Items.Add("latest")
        For i = Val(My.Resources.mods_ver_164.ASHUD164latest) To Val(My.Resources.mods_ver_164.ASHUD164min) Step -1
            ComboBox6.Items.Add("1." & i)
        Next
        ComboBox6.Text = "latest"

        'mod7 - DirectionHUD
        ComboBox7.Items.Add("latest")
        For i = Val(My.Resources.mods_ver_164.DHUD164latest) To Val(My.Resources.mods_ver_164.DHUD164min) Step -1
            ComboBox7.Items.Add("1." & i)
        Next
        ComboBox7.Text = "latest"

        'mod8 - StatusEffectHUD
        ComboBox8.Items.Add("latest")
        For i = Val(My.Resources.mods_ver_164.SEHUD164latest) To Val(My.Resources.mods_ver_164.SEHUD164min) Step -1
            ComboBox8.Items.Add("1." & i)
        Next
        ComboBox8.Text = "latest"

        'mod9 - InGameInfoXML
        ComboBox9.Items.Add("latest")
        For i = Val(My.Resources.mods_ver_164.InGameInfo164latest) To 40 Step -1
            ComboBox9.Items.Add("2.6.0." & i)
        Next
        For i = 39 To Val(My.Resources.mods_ver_164.InGameInfo164min) Step -1
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
End Class