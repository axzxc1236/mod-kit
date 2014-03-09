Public Class About

    Private Sub About_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.Show()
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        Label1.Text = "這是一款由21999125(21)" & vbCrLf & "開發的minecraft小工具。" & vbCrLf & vbCrLf
        Label1.Text = Label1.Text & "別看這款工具很簡單，" & vbCrLf & "光1.7.2就花了我許多的時間去開發" & vbCrLf & "(也是我第一個開發的版本)" & vbCrLf
        Label1.Text = Label1.Text & "我希望這款工具被開發出來" & vbCrLf & "能夠幫助到你"
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/axzxc1236/mod-kit")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("http://home.gamer.com.tw/homeindex.php?owner=X21999125X")
    End Sub
End Class