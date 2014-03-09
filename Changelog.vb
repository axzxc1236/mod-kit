Public Class Changelog

    Private Sub Changelog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.Show()
    End Sub

    Private Sub Changelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
    End Sub
End Class