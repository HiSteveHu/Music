Imports System.IO

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        playmode = False
        slidemenushow = False
        soundsetshow = False
        playingshow = False
        loopplay = False
        mute = False
        stereo = True
        mp3 = True
        flac = False
        aac = False
        wav = False
        Playpart.settings.volume = 100
        Label5.Text = Playpart.settings.volume
        musiclist.Items.Clear()
        If musiclist.Items.Count = 0 Then
            Blank.Visible = True
        Else
            Blank.Visible = False
        End If
        play.Enabled = False
        pause.Enabled = False

        soundset.Enabled = False

    End Sub
    Public Function rfmusic()
        Label21.Text = "0"
        Playpart.Ctlcontrols.stop()


        For f = 0 To 5
            Dim i As Integer
            Dim n As Long
            If folder(f) <> "" Then
                If mp3 = True Then
                    files = Directory.GetFiles(folder(f), "*.mp3", SearchOption.AllDirectories)
                    For i = 0 To files.Length - 1
                        musicname = ""
                        For n = files(i).Length To 1 Step -1
                            c = Mid(files(i), n, 1)
                            If c = "\" Then
                                musicname = Mid(files(i), n + 1, files(i).Length - n)
                                Exit For
                            End If
                        Next
                        Me.musiclist.Items.Add(musicname)
                        musicnum = musicnum + 1
                        Label21.Text = musicnum
                    Next
                End If
                If flac = True Then
                    files = Directory.GetFiles(folder(f), "*.flac", SearchOption.AllDirectories)
                    For i = 0 To files.Length - 1
                        musicname = ""
                        For n = files(i).Length To 1 Step -1
                            c = Mid(files(i), n, 1)
                            If c = "\" Then
                                musicname = Mid(files(i), n + 1, files(i).Length - n)
                                Exit For
                            End If
                        Next
                        Me.musiclist.Items.Add(musicname)
                        musicnum = musicnum + 1
                        Label21.Text = musicnum
                    Next
                End If
                If aac = True Then
                    files = Directory.GetFiles(folder(f), "*.aac", SearchOption.AllDirectories)
                    For i = 0 To files.Length - 1
                        musicname = ""
                        For n = files(i).Length To 1 Step -1
                            c = Mid(files(i), n, 1)
                            If c = "\" Then
                                musicname = Mid(files(i), n + 1, files(i).Length - n)
                                Exit For
                            End If
                        Next
                        Me.musiclist.Items.Add(musicname)
                        musicnum = musicnum + 1
                        Label21.Text = musicnum
                    Next
                End If
                If wav = True Then
                    files = Directory.GetFiles(folder(f), "*.wav", SearchOption.AllDirectories)
                    For i = 0 To files.Length - 1
                        musicname = ""
                        For n = files(i).Length To 1 Step -1
                            c = Mid(files(i), n, 1)
                            If c = "\" Then
                                musicname = Mid(files(i), n + 1, files(i).Length - n)
                                Exit For
                            End If
                        Next
                        Me.musiclist.Items.Add(musicname)
                        musicnum = musicnum + 1
                        Label21.Text = musicnum
                    Next
                End If
            End If
        Next

        If Me.musiclist.Items.Count = 0 Then
                Me.Blank.Show()
                play.Enabled = False
                pause.Enabled = False

            soundset.Enabled = False
            Else
                Me.Blank.Hide()
                play.Enabled = True
                pause.Enabled = True

            soundset.Enabled = True
            End If

    End Function
    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles musictitle.MouseEnter
        musictitle.BackColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles musictitle.MouseLeave
        musictitle.BackColor = Color.Black
    End Sub

    Private Sub Playing_title_MouseEnter(sender As Object, e As EventArgs) Handles Playing_title.MouseEnter
        musictitle.BackColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If slidemenushow = False Then
            Slidemenu.Show()
            slidemenushow = True
        Else
            Slidemenu.Hide()
            slidemenushow = False
        End If
        Playing.Hide()
        playingshow = False
        soundsetpanel.Hide()
        soundsetshow = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Me.Dispose()
        End
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles musiclist.SelectedIndexChanged

        If musiclist.SelectedIndex >= 0 Then
            Playpart.URL = files(musiclist.SelectedIndex)
            Playpart.Ctlcontrols.play()
            Playing_title.Text = Playpart.currentMedia.name
            playmode = True
            playprogress.Enabled = True
            playnumber = musiclist.SelectedIndex
            'album pic get 
            Dim mp3 = TagLib.File.Create(files(musiclist.SelectedIndex))
            If mp3.Tag.Pictures.Length >= 1 Then
                Dim bin = DirectCast(mp3.Tag.Pictures(0).Data.Data, Byte())
                PreviewPictureBoxmini.Image = Image.FromStream(New MemoryStream(bin)).GetThumbnailImage(100, 100, Nothing, System.IntPtr.Zero)
                PreviewPictureBox.Image = Image.FromStream(New MemoryStream(bin)).GetThumbnailImage(300, 300, Nothing, System.IntPtr.Zero)
            End If

            If mp3.Tag.Title = "" Then
                Label6.Text = musiclist.SelectedItem
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

            If mp3.Tag.AlbumSort = "" Then
                Label13.Text = "Unknown"
            Else
                Label13.Text = mp3.Tag.AlbumSort
            End If

            If Str(mp3.Tag.Track) = "" Then
                Label15.Text = "Unknown"
            Else
                Label15.Text = Str(mp3.Tag.Track)
            End If

            If Str(mp3.Tag.Year) = "" Then
                Label17.Text = "Unknown"
            Else
                Label17.Text = Str(mp3.Tag.Year)
            End If

            TextBox1.Text = files(musiclist.SelectedIndex)


            playprogress.Value = 0
            pause.Show()
            play.Hide()

        End If

    End Sub

    Private Sub pause_Click(sender As Object, e As EventArgs) Handles pause.Click
        play.Show()
        pause.Hide()
        Playpart.Ctlcontrols.pause()
        playmode = False
    End Sub

    Private Sub play_Click(sender As Object, e As EventArgs) Handles play.Click
        pause.Show()
        play.Hide()
        Playpart.Ctlcontrols.play()
        playmode = True
    End Sub

    Private Sub musictitle_Click(sender As Object, e As EventArgs) Handles musictitle.Click
        If playingshow = False Then
            Playing.Show()
            playingshow = True
        Else
            Playing.Hide()
            playingshow = False
        End If
        Slidemenu.Hide()
        slidemenushow = False
        soundsetpanel.Hide()
        soundsetshow = False

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Slidemenu.Hide()
        slidemenushow = False
        Setting.ShowDialog()

    End Sub



    Private Sub Playing_Click(sender As Object, e As EventArgs)
        Playing.Hide()
        playingshow = False

    End Sub

    Private Sub Blank_Click(sender As Object, e As EventArgs)
        Slidemenu.Hide()
        slidemenushow = False
        soundsetpanel.Hide()
        soundsetshow = False
    End Sub

    Private Sub musiclist_Click(sender As Object, e As EventArgs) Handles musiclist.Click
        Slidemenu.Hide()
        slidemenushow = False
        Playing.Hide()
        playingshow = False
        soundsetpanel.Hide()
        soundsetshow = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Slidemenu.Hide()
        slidemenushow = False
        Playing.Hide()
        playingshow = False
        soundsetpanel.Hide()
        soundsetshow = False
    End Sub

    Private Sub soundset_Click(sender As Object, e As EventArgs) Handles soundset.Click
        If soundsetshow = False Then
            soundsetpanel.Show()
            soundsetshow = True
        Else
            soundsetpanel.Hide()
            soundsetshow = False
        End If
        Slidemenu.Hide()
        slidemenushow = False
        Playing.Hide()
    End Sub

    Private Sub volume_Scroll(sender As Object, e As EventArgs)
        Label5.Text = Playpart.settings.volume
        Playpart.settings.volume = volumescroll.Value
    End Sub

    Private Sub flash_Tick(sender As Object, e As EventArgs) Handles flash.Tick

        If Playpart.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            Label19.Text = Playpart.Ctlcontrols.currentPositionString
            If Playpart.currentMedia.duration = 0 Then Exit Sub
            Label20.Text = Playpart.currentMedia.durationString
            Label7.Text = Playpart.currentMedia.durationString
            playprogress.Value = Int(Playpart.Ctlcontrols.currentPosition / Playpart.currentMedia.duration * 100)
        End If
        If Playpart.playState = WMPLib.WMPPlayState.wmppsStopped And loopplay = True Then

            playprogress.Value = 0
            Playpart.Ctlcontrols.play()
        ElseIf Playpart.playState = WMPLib.WMPPlayState.wmppsStopped Then
            pause.Hide()
            play.Show()
            playprogress.Value = 0
            Playpart.Ctlcontrols.stop()
            playmode = False
            playprogress.Enabled = False
        End If


    End Sub

    Private Sub rfmusiclist_Click(sender As Object, e As EventArgs) Handles rfmusiclist.Click
        rfmusic()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        soundsetpanel.Hide()
        soundsetshow = False
    End Sub

    Private Sub loopplay_button_Click(sender As Object, e As EventArgs)
        If loopplay = False Then
            loopplay = True
            loopplay_button.BackColor = Color.Black
        Else
            loopplay = False
            loopplay_button.BackColor = Color.FromArgb(50, 50, 50)
        End If
    End Sub

    Private Sub mute_button_Click(sender As Object, e As EventArgs)
        If mute = False Then
            mute = True
            mute_button.BackColor = Color.Black
            Playpart.settings.mute = True
        Else
            mute = False
            mute_button.BackColor = Color.FromArgb(50, 50, 50)
            Playpart.settings.mute = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        RadioButton2.Checked = False
        stereo = True

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        RadioButton1.Checked = False
        stereo = False
        Playpart.settings.balance = -1
    End Sub

    Private Sub ProgressBar1_MouseEnter(sender As Object, e As EventArgs)
        musictitle.BackColor = Color.Black
    End Sub

    Private Sub PreviewPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles PreviewPictureBoxmini.MouseEnter
        musictitle.BackColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub PreviewPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles PreviewPictureBoxmini.MouseLeave
        musictitle.BackColor = Color.Black
    End Sub

    Private Sub Playing_title_Click(sender As Object, e As EventArgs) Handles Playing_title.Click
        If playingshow = False Then
            Playing.Show()
            playingshow = True
        Else
            Playing.Hide()
            playingshow = False
        End If
        Slidemenu.Hide()
        slidemenushow = False
        soundsetpanel.Hide()
        soundsetshow = False
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)
        Playing.Show()
        Slidemenu.Hide()
        slidemenushow = False
        soundsetpanel.Hide()
        soundsetshow = False
    End Sub

    Private Sub PreviewPictureBoxmini_Click(sender As Object, e As EventArgs) Handles PreviewPictureBoxmini.Click
        If playingshow = False Then
            Playing.Show()
            playingshow = True
        Else
            Playing.Hide()
            playingshow = False
        End If
        Slidemenu.Hide()
        slidemenushow = False
        soundsetpanel.Hide()
        soundsetshow = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        My.Computer.Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub PreviewPictureBox_Click(sender As Object, e As EventArgs)
        Previewpicture.ShowDialog()
    End Sub


    Private Sub playprogress_Scroll_1(sender As Object, e As EventArgs) Handles playprogress.Scroll
        Label19.Text = Str(Int(Playpart.currentMedia.duration * (playprogress.Value / 100)) \ 60) + ":" + Str(Int(Playpart.currentMedia.duration * (playprogress.Value / 100)) Mod 60)
        If progress_pre = True Then
            Playpart.Ctlcontrols.currentPosition = Playpart.currentMedia.duration * (playprogress.Value / 100)
        End If

    End Sub

    Private Sub playprogress_MouseUp(sender As Object, e As MouseEventArgs) Handles playprogress.MouseUp
        Playpart.Ctlcontrols.currentPosition = Playpart.currentMedia.duration * (playprogress.Value / 100)
        Label19.Text = Playpart.Ctlcontrols.currentPositionString
        flash.Enabled = True
    End Sub

    Private Sub playprogress_MouseDown(sender As Object, e As MouseEventArgs) Handles playprogress.MouseDown
        flash.Enabled = False
    End Sub

    Private Sub playprogress_MouseEnter(sender As Object, e As EventArgs) Handles playprogress.MouseEnter
        musictitle.BackColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub playprogress_MouseLeave(sender As Object, e As EventArgs) Handles playprogress.MouseLeave
        musictitle.BackColor = Color.Black
    End Sub

    Private Sub musictitle_Paint(sender As Object, e As PaintEventArgs) Handles musictitle.Paint

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        If playingshow = False Then
            Playing.Show()
            playingshow = True
        Else
            Playing.Hide()
            playingshow = False
        End If
        Slidemenu.Hide()
        slidemenushow = False
        soundsetpanel.Hide()
        soundsetshow = False
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        If playingshow = False Then
            Playing.Show()
            playingshow = True
        Else
            Playing.Hide()
            playingshow = False
        End If
        Slidemenu.Hide()
        slidemenushow = False
        soundsetpanel.Hide()
        soundsetshow = False
    End Sub

    Private Sub nextmusic_Click(sender As Object, e As EventArgs)
        If playnumber + 1 < musiclist.Items.Count Then
            Playpart.URL = files(musiclist.SelectedIndex + 1)
            Playpart.Ctlcontrols.play()
            Playing_title.Text = Playpart.currentMedia.name
            playmode = True
            playprogress.Enabled = True
            playnumber = musiclist.SelectedIndex + 1
            'album pic get 
            Dim mp3 = TagLib.File.Create(files(musiclist.SelectedIndex))
            If mp3.Tag.Pictures.Length >= 1 Then
                Dim bin = DirectCast(mp3.Tag.Pictures(0).Data.Data, Byte())
                PreviewPictureBoxmini.Image = Image.FromStream(New MemoryStream(bin)).GetThumbnailImage(100, 100, Nothing, System.IntPtr.Zero)
                PreviewPictureBox.Image = Image.FromStream(New MemoryStream(bin)).GetThumbnailImage(300, 300, Nothing, System.IntPtr.Zero)
            End If

            If mp3.Tag.Title = "" Then
                Label6.Text = musiclist.SelectedItem
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

            If mp3.Tag.AlbumSort = "" Then
                Label13.Text = "Unknown"
            Else
                Label13.Text = mp3.Tag.AlbumSort
            End If

            If Str(mp3.Tag.Track) = "" Then
                Label15.Text = "Unknown"
            Else
                Label15.Text = Str(mp3.Tag.Track)
            End If

            If Str(mp3.Tag.Year) = "" Then
                Label17.Text = "Unknown"
            Else
                Label17.Text = Str(mp3.Tag.Year)
            End If

            TextBox1.Text = files(musiclist.SelectedIndex)


            playprogress.Value = 0
            pause.Show()
            play.Hide()

        End If

    End Sub

    Private Sub volumescroll_Scroll(sender As Object, e As EventArgs) Handles volumescroll.Scroll
        Label5.Text = Playpart.settings.volume
        Playpart.settings.volume = volumescroll.Value
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton2.Checked = False
        stereo = True
    End Sub

    Private Sub loopplay_button_Click_1(sender As Object, e As EventArgs) Handles loopplay_button.Click
        If loopplay = False Then
            loopplay = True
            loopplay_button.BackColor = Color.Black
        Else
            loopplay = False
            loopplay_button.BackColor = Color.FromArgb(50, 50, 50)
        End If
    End Sub

    Private Sub mute_button_Click_1(sender As Object, e As EventArgs) Handles mute_button.Click
        If mute = False Then
            mute = True
            mute_button.BackColor = Color.Black
            Playpart.settings.mute = True
        Else
            mute = False
            mute_button.BackColor = Color.FromArgb(50, 50, 50)
            Playpart.settings.mute = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        RadioButton1.Checked = False
        stereo = False
        Playpart.settings.balance = -1
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        soundsetpanel.Hide()
        soundsetshow = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Playing.Hide()
        playingshow = True
    End Sub

    Private Sub PreviewPictureBox_Click_1(sender As Object, e As EventArgs) Handles PreviewPictureBox.Click
        If Playpart.playState = WMPLib.WMPPlayState.wmppsPlaying Then Previewpicture.ShowDialog()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub lastmusic_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label19_MouseEnter(sender As Object, e As EventArgs) Handles Label19.MouseEnter
        musictitle.BackColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub Label19_MouseLeave(sender As Object, e As EventArgs) Handles Label19.MouseLeave
        musictitle.BackColor = Color.Black
    End Sub

    Private Sub Label20_MouseEnter(sender As Object, e As EventArgs) Handles Label20.MouseEnter
        musictitle.BackColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub Label20_MouseLeave(sender As Object, e As EventArgs) Handles Label20.MouseLeave
        musictitle.BackColor = Color.Black
    End Sub

    Private Sub FormDock_MouseDown(sender As Object, e As MouseEventArgs) Handles FormDock.MouseDown
        x = e.X : y = e.Y
    End Sub

    Private Sub FormDock_MouseMove(sender As Object, e As MouseEventArgs) Handles FormDock.MouseMove
        If x = e.X And y = e.Y Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Left = Me.Left + e.X - x
            Me.Top = Me.Top + e.Y - y
        End If
        formx = Me.Location.X
        formy = Me.Location.Y
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        x = e.X : y = e.Y
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If x = e.X And y = e.Y Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Left = Me.Left + e.X - x
            Me.Top = Me.Top + e.Y - y
        End If
        formx = Me.Location.X
        formy = Me.Location.Y
    End Sub

    Private Sub formhead_MouseMove(sender As Object, e As MouseEventArgs) Handles formhead.MouseMove
        If x = e.X And y = e.Y Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Left = Me.Left + e.X - x
            Me.Top = Me.Top + e.Y - y
        End If
        formx = Me.Location.X
        formy = Me.Location.Y
    End Sub

    Private Sub formhead_MouseDown(sender As Object, e As MouseEventArgs) Handles formhead.MouseDown
        x = e.X : y = e.Y
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
