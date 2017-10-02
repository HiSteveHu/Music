Imports System.IO
Public Class Refreshmusic
    Public Function refreshmusic()
        Dim needscan As Boolean
        Main.Playing.Hide()
        Main.musiclist.Items.Clear()
        musicnum = 0
        needscan = False
        For f = 0 To 5
            If folder(f) <> "" Then needscan = True
        Next
        If needscan = False Then Exit Function
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
                        Main.musiclist.Items.Add(musicname)
                        musicnum = musicnum + 1
                        Main.Label21.Text = musicnum
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
                        Main.musiclist.Items.Add(musicname)
                        musicnum = musicnum + 1
                        Main.Label21.Text = musicnum
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
                        Main.musiclist.Items.Add(musicname)
                        musicnum = musicnum + 1
                        Main.Label21.Text = musicnum
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
                        Main.musiclist.Items.Add(musicname)
                        musicnum = musicnum + 1
                        Main.Label21.Text = musicnum
                    Next
                End If
                Label21.Text = Str(files.Length)
            End If
        Next

        If Main.musiclist.Items.Count = 0 Then
            Main.Blank.Show()
            Main.play.Enabled = False
            Main.pause.Enabled = False
            Main.nextmusic.Enabled = False
            Main.lastmusic.Enabled = False
            Main.soundset.Enabled = False
        Else
            Main.Blank.Hide()
            Main.play.Enabled = True
            Main.pause.Enabled = True
            Main.nextmusic.Enabled = True
            Main.lastmusic.Enabled = True
            Main.soundset.Enabled = True
        End If
    End Function
End Class
