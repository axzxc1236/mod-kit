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
End Class