Imports System.Windows.Forms
Imports System.IO
Imports System.ComponentModel

Public Class Setting
    Public Function rfmusic()
        Main.Label21.Text = "0"
        Main.Playpart.Ctlcontrols.stop()


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
            End If
        Next

        If Main.musiclist.Items.Count = 0 Then
            Main.Blank.Show()
            Main.play.Enabled = False
            Main.pause.Enabled = False

            Main.soundset.Enabled = False
        Else
            Main.Blank.Hide()
            Main.play.Enabled = True
            Main.pause.Enabled = True

            Main.soundset.Enabled = True
        End If

    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fdblank As Boolean
        fdblank = True
        For i = 0 To 5
            If folder(i) <> "" Then
                ListBox1.Items.Add(folder(i))
                fdblank = False
            End If
        Next
        If fdblank = True Then
            delete.Enabled = False
        End If


        If mp3 = True Then
            CheckBox1.CheckState = CheckState.Checked
        End If
        If wav = True Then
            CheckBox3.CheckState = CheckState.Checked
        End If
        If flac = True Then
            CheckBox2.CheckState = CheckState.Checked
        End If
        If aac = True Then
            CheckBox4.CheckState = CheckState.Checked
        End If

        If progress_pre = True Then
            progresspre.Checked = True
        Else
            progresspre.Checked = False
        End If
        Label3.Text = My.Application.Info.Version.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter a Path", vbOKOnly, "Error")
            Exit Sub
        End If
        If Directory.Exists(TextBox1.Text) = False Then
            MsgBox("Wrong Path", vbOKOnly, "Error")
            Exit Sub
        End If
        For i = 0 To 5
            If folder(i) = "" Then
                folder(i) = TextBox1.Text
                ListBox1.Items.Add(folder(i))
                delete.Enabled = True
                Exit Sub
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles delete.Click
        folder(ListBox1.SelectedIndex) = ""
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        If ListBox1.Items.Count = 0 Then
            delete.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles progresspre.CheckedChanged
        If progresspre.Checked = True Then
            progress_pre = True
        Else
            progress_pre = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Reli.ShowDialog()
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            mp3 = True
        Else
            mp3 = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            flac = True
        Else
            flac = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            aac = True
        Else
            aac = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            wav = True
        Else
            wav = False
        End If
    End Sub

    Private Sub Setting_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub Setting_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        rfmusic()
    End Sub
End Class
