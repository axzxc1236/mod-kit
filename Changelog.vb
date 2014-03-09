Public Class Changelog

    Private Sub Changelog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Form1.Show()
    End Sub
End Class