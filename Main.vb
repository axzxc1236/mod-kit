Public Class Main

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get orginal minecraft folder path
        TextBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.minecraft"

        Call detect()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        About.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Computer.FileSystem.DirectoryExists(TextBox1.Text) Then
            If Not ComboBox1.Text = "" Then Me.Hide()
            If ComboBox1.Text = "1.7.2" Then Ver172.Show()
            If ComboBox1.Text = "1.6.4" Then Ver164.Show()
        Else
            MsgBox("請先選擇你的.minecraft資料夾")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Credits.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
        Call detect()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Changelog.Show()
    End Sub

    Public Sub detect()
        'detect .minecraft
        If My.Computer.FileSystem.DirectoryExists(TextBox1.Text) Then
            Label2.Text = "☑ 發現(或已指定).minecraft資料夾"
        Else
            Label2.Text = "☒ 沒有發現.minecraft資料夾"
        End If

        'detect launcher_profiles.json
        If My.Computer.FileSystem.FileExists(TextBox1.Text & "\launcher_profiles.json") Then
            Label3.Text = "☑ 曾經使用新版啟動器(發現launcher_profiles.json)"
        Else
            Label3.Text = "☒ 沒有使用過新版啟動器(未發現launcher_profiles.json)"
        End If

        'detect .minecraft\bin
        If My.Computer.FileSystem.DirectoryExists(TextBox1.Text & "\bin") Then
            Label4.Text = "☑ 曾經使用舊版啟動器(發現bin資料夾)"
        Else
            Label4.Text = "☒ 沒有使用過舊版啟動器(沒發現bin資料夾)"
        End If
    End Sub
End Class
