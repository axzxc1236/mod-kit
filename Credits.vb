Public Class Credits

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LinkLabel1.Text = "baskrs的網站"
        Label2.Text = "http://bspk.rs/MC/"
        PictureBox1.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("http://i.minus.com/iZQU3aiRYx7Vb.jpg")))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LinkLabel1.Text = "Inventory Tweaks模組原網"
        Label2.Text = "http://www.minecraftforum.net/topic/1720872-"
        PictureBox1.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("http://i.minus.com/ibshmuKxlYJJKh.jpg")))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LinkLabel1.Text = "Voxelmap模組原網"
        Label2.Text = "http://www.planetminecraft.com/mod/zans-minimap/"
        PictureBox1.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("http://i.minus.com/ibyiK9lD4cAdBt.jpg")))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LinkLabel1.Text = "Damage Indicators模組原網"
        Label2.Text = "http://www.minecraftforum.net/topic/1536685-"
        PictureBox1.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("http://i.minus.com/iksG8cCA7romb.jpg")))
    End Sub

    Private Sub Credits_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub Credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
        LinkLabel1.Text = ""
        Label2.Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(Label2.Text)
    End Sub
End Class