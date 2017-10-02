Imports System.IO

Public NotInheritable Class Previewpicture

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Height = My.Computer.Screen.Bounds.Height \ 2
        PictureBox1.Width = PictureBox1.Height
        PictureBox1.Left = My.Computer.Screen.Bounds.Width \ 2 - PictureBox1.Width \ 2
        PictureBox1.Top = My.Computer.Screen.Bounds.Height \ 2 - PictureBox1.Height \ 2
        Dim mp3 = TagLib.File.Create(files(Main.musiclist.SelectedIndex))
        If mp3.Tag.Pictures.Length >= 1 Then
            Dim bin = DirectCast(mp3.Tag.Pictures(0).Data.Data, Byte())
            PictureBox1.Image = Image.FromStream(New MemoryStream(bin)).GetThumbnailImage(800, 800, Nothing, System.IntPtr.Zero)
            Main.PreviewPictureBox.Image = Image.FromStream(New MemoryStream(bin)).GetThumbnailImage(800, 800, Nothing, System.IntPtr.Zero)
        End If
        If mp3.Tag.Title = "" Then
            Label6.Text = Main.musiclist.SelectedItem
        Else
            Label6.Text = mp3.Tag.Title
        End If

        If mp3.Tag.Album = "" Then
            Label9.Text = "Unknown"
        Else
            Label9.Text = mp3.Tag.Album
        End If

        If mp3.Tag.Artists(0) = "" Then
            Label11.Text = "Unknown"
        Else
            Label11.Text = mp3.Tag.Artists(0)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Me.Dispose(True)
    End Sub

    Private Sub Previewpicture_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Close()
        Me.Dispose(True)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        Me.Dispose(True)
    End Sub
End Class
