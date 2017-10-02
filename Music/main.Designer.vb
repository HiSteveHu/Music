<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Slidemenu = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.musiclist = New System.Windows.Forms.ListBox()
        Me.rfmusiclist = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.playpartdock = New System.Windows.Forms.Panel()
        Me.play = New System.Windows.Forms.Button()
        Me.musictitle = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PreviewPictureBoxmini = New System.Windows.Forms.PictureBox()
        Me.Playing_title = New System.Windows.Forms.Label()
        Me.playprogress = New System.Windows.Forms.TrackBar()
        Me.soundset = New System.Windows.Forms.Button()
        Me.pause = New System.Windows.Forms.Button()
        Me.formhead = New System.Windows.Forms.Panel()
        Me.FormDock = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.flash = New System.Windows.Forms.Timer(Me.components)
        Me.soundsetpanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.mute_button = New System.Windows.Forms.Button()
        Me.loopplay_button = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.volumescroll = New System.Windows.Forms.TrackBar()
        Me.Playing = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PreviewPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Playpart = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Blank = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Slidemenu.SuspendLayout()
        Me.playpartdock.SuspendLayout()
        Me.musictitle.SuspendLayout()
        CType(Me.PreviewPictureBoxmini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playprogress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.formhead.SuspendLayout()
        Me.FormDock.SuspendLayout()
        Me.soundsetpanel.SuspendLayout()
        CType(Me.volumescroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Playing.SuspendLayout()
        CType(Me.PreviewPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Playpart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Blank.SuspendLayout()
        Me.SuspendLayout()
        '
        'Slidemenu
        '
        Me.Slidemenu.BackColor = System.Drawing.Color.Black
        Me.Slidemenu.Controls.Add(Me.Button7)
        Me.Slidemenu.Controls.Add(Me.Button6)
        Me.Slidemenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Slidemenu.Location = New System.Drawing.Point(0, 72)
        Me.Slidemenu.Name = "Slidemenu"
        Me.Slidemenu.Size = New System.Drawing.Size(175, 98)
        Me.Slidemenu.TabIndex = 2
        Me.Slidemenu.Visible = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Black
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(0, 45)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(175, 45)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Setting"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(0, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(175, 45)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "All Music"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'musiclist
        '
        Me.musiclist.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.musiclist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.musiclist.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.musiclist.ForeColor = System.Drawing.Color.White
        Me.musiclist.FormattingEnabled = True
        Me.musiclist.ItemHeight = 25
        Me.musiclist.Location = New System.Drawing.Point(3, 82)
        Me.musiclist.Margin = New System.Windows.Forms.Padding(5)
        Me.musiclist.Name = "musiclist"
        Me.musiclist.Size = New System.Drawing.Size(796, 450)
        Me.musiclist.TabIndex = 1
        '
        'rfmusiclist
        '
        Me.rfmusiclist.BackColor = System.Drawing.Color.Transparent
        Me.rfmusiclist.BackgroundImage = CType(resources.GetObject("rfmusiclist.BackgroundImage"), System.Drawing.Image)
        Me.rfmusiclist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rfmusiclist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rfmusiclist.FlatAppearance.BorderSize = 0
        Me.rfmusiclist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.rfmusiclist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rfmusiclist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rfmusiclist.Location = New System.Drawing.Point(759, 37)
        Me.rfmusiclist.Name = "rfmusiclist"
        Me.rfmusiclist.Size = New System.Drawing.Size(29, 29)
        Me.rfmusiclist.TabIndex = 6
        Me.rfmusiclist.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "All Music"
        '
        'playpartdock
        '
        Me.playpartdock.BackColor = System.Drawing.Color.Black
        Me.playpartdock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.playpartdock.Controls.Add(Me.play)
        Me.playpartdock.Controls.Add(Me.musictitle)
        Me.playpartdock.Controls.Add(Me.soundset)
        Me.playpartdock.Controls.Add(Me.pause)
        Me.playpartdock.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.playpartdock.Location = New System.Drawing.Point(0, 545)
        Me.playpartdock.Margin = New System.Windows.Forms.Padding(5)
        Me.playpartdock.Name = "playpartdock"
        Me.playpartdock.Size = New System.Drawing.Size(800, 55)
        Me.playpartdock.TabIndex = 1
        '
        'play
        '
        Me.play.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.play.BackgroundImage = CType(resources.GetObject("play.BackgroundImage"), System.Drawing.Image)
        Me.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.play.Cursor = System.Windows.Forms.Cursors.Hand
        Me.play.FlatAppearance.BorderSize = 0
        Me.play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.play.Location = New System.Drawing.Point(680, 0)
        Me.play.Name = "play"
        Me.play.Size = New System.Drawing.Size(60, 55)
        Me.play.TabIndex = 4
        Me.play.UseVisualStyleBackColor = False
        '
        'musictitle
        '
        Me.musictitle.BackColor = System.Drawing.Color.Black
        Me.musictitle.Controls.Add(Me.Label20)
        Me.musictitle.Controls.Add(Me.Label19)
        Me.musictitle.Controls.Add(Me.PreviewPictureBoxmini)
        Me.musictitle.Controls.Add(Me.Playing_title)
        Me.musictitle.Controls.Add(Me.playprogress)
        Me.musictitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.musictitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.musictitle.Location = New System.Drawing.Point(0, 0)
        Me.musictitle.Name = "musictitle"
        Me.musictitle.Size = New System.Drawing.Size(683, 55)
        Me.musictitle.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label20.Font = New System.Drawing.Font("微软雅黑", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(637, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 16)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "00:00"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label19.Font = New System.Drawing.Font("微软雅黑", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(61, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 16)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "00:00"
        '
        'PreviewPictureBoxmini
        '
        Me.PreviewPictureBoxmini.Location = New System.Drawing.Point(0, 0)
        Me.PreviewPictureBoxmini.Name = "PreviewPictureBoxmini"
        Me.PreviewPictureBoxmini.Size = New System.Drawing.Size(55, 55)
        Me.PreviewPictureBoxmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PreviewPictureBoxmini.TabIndex = 0
        Me.PreviewPictureBoxmini.TabStop = False
        '
        'Playing_title
        '
        Me.Playing_title.AutoSize = True
        Me.Playing_title.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Playing_title.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Playing_title.Location = New System.Drawing.Point(61, 5)
        Me.Playing_title.Name = "Playing_title"
        Me.Playing_title.Size = New System.Drawing.Size(46, 20)
        Me.Playing_title.TabIndex = 4
        Me.Playing_title.Text = "None"
        '
        'playprogress
        '
        Me.playprogress.Enabled = False
        Me.playprogress.Location = New System.Drawing.Point(98, 29)
        Me.playprogress.Maximum = 100
        Me.playprogress.Name = "playprogress"
        Me.playprogress.Size = New System.Drawing.Size(533, 45)
        Me.playprogress.TabIndex = 5
        Me.playprogress.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'soundset
        '
        Me.soundset.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.soundset.BackgroundImage = CType(resources.GetObject("soundset.BackgroundImage"), System.Drawing.Image)
        Me.soundset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.soundset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.soundset.FlatAppearance.BorderSize = 0
        Me.soundset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.soundset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.soundset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.soundset.Location = New System.Drawing.Point(740, 0)
        Me.soundset.Name = "soundset"
        Me.soundset.Size = New System.Drawing.Size(60, 55)
        Me.soundset.TabIndex = 7
        Me.soundset.UseVisualStyleBackColor = False
        '
        'pause
        '
        Me.pause.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pause.BackgroundImage = CType(resources.GetObject("pause.BackgroundImage"), System.Drawing.Image)
        Me.pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pause.FlatAppearance.BorderSize = 0
        Me.pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pause.Location = New System.Drawing.Point(680, 0)
        Me.pause.Name = "pause"
        Me.pause.Size = New System.Drawing.Size(60, 55)
        Me.pause.TabIndex = 5
        Me.pause.Text = ""
        Me.pause.UseVisualStyleBackColor = False
        Me.pause.Visible = False
        '
        'formhead
        '
        Me.formhead.BackColor = System.Drawing.Color.Black
        Me.formhead.Controls.Add(Me.FormDock)
        Me.formhead.Controls.Add(Me.Label21)
        Me.formhead.Controls.Add(Me.rfmusiclist)
        Me.formhead.Controls.Add(Me.Label2)
        Me.formhead.Controls.Add(Me.Button1)
        Me.formhead.Dock = System.Windows.Forms.DockStyle.Top
        Me.formhead.Location = New System.Drawing.Point(0, 0)
        Me.formhead.Name = "formhead"
        Me.formhead.Size = New System.Drawing.Size(800, 72)
        Me.formhead.TabIndex = 2
        '
        'FormDock
        '
        Me.FormDock.Controls.Add(Me.Button5)
        Me.FormDock.Controls.Add(Me.Button8)
        Me.FormDock.Controls.Add(Me.Label1)
        Me.FormDock.Location = New System.Drawing.Point(0, 0)
        Me.FormDock.Name = "FormDock"
        Me.FormDock.Size = New System.Drawing.Size(800, 30)
        Me.FormDock.TabIndex = 8
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.CausesValidation = False
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(720, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(30, 30)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "-"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Black
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button8.CausesValidation = False
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(750, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(50, 30)
        Me.Button8.TabIndex = 15
        Me.Button8.Text = "×"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Music"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DimGray
        Me.Label21.Location = New System.Drawing.Point(181, 38)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(24, 27)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "0"
        '
        'flash
        '
        Me.flash.Enabled = True
        Me.flash.Interval = 1000
        '
        'soundsetpanel
        '
        Me.soundsetpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.soundsetpanel.Controls.Add(Me.Label4)
        Me.soundsetpanel.Controls.Add(Me.RadioButton1)
        Me.soundsetpanel.Controls.Add(Me.RadioButton2)
        Me.soundsetpanel.Controls.Add(Me.mute_button)
        Me.soundsetpanel.Controls.Add(Me.loopplay_button)
        Me.soundsetpanel.Controls.Add(Me.Button2)
        Me.soundsetpanel.Controls.Add(Me.Label5)
        Me.soundsetpanel.Controls.Add(Me.volumescroll)
        Me.soundsetpanel.Location = New System.Drawing.Point(511, 390)
        Me.soundsetpanel.Name = "soundsetpanel"
        Me.soundsetpanel.Size = New System.Drawing.Size(268, 154)
        Me.soundsetpanel.TabIndex = 3
        Me.soundsetpanel.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Track"
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.RadioButton1.Checked = True
        Me.RadioButton1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.Location = New System.Drawing.Point(101, 70)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(71, 33)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Stereo"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.RadioButton2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.Location = New System.Drawing.Point(171, 70)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(68, 33)
        Me.RadioButton2.TabIndex = 10
        Me.RadioButton2.Text = "Single"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'mute_button
        '
        Me.mute_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.mute_button.BackgroundImage = CType(resources.GetObject("mute_button.BackgroundImage"), System.Drawing.Image)
        Me.mute_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mute_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mute_button.FlatAppearance.BorderSize = 0
        Me.mute_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.mute_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.mute_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mute_button.Location = New System.Drawing.Point(12, 121)
        Me.mute_button.Name = "mute_button"
        Me.mute_button.Size = New System.Drawing.Size(39, 25)
        Me.mute_button.TabIndex = 8
        Me.mute_button.UseVisualStyleBackColor = False
        '
        'loopplay_button
        '
        Me.loopplay_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.loopplay_button.BackgroundImage = CType(resources.GetObject("loopplay_button.BackgroundImage"), System.Drawing.Image)
        Me.loopplay_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.loopplay_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loopplay_button.FlatAppearance.BorderSize = 0
        Me.loopplay_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.loopplay_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.loopplay_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loopplay_button.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.loopplay_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loopplay_button.Location = New System.Drawing.Point(12, 26)
        Me.loopplay_button.Name = "loopplay_button"
        Me.loopplay_button.Size = New System.Drawing.Size(244, 28)
        Me.loopplay_button.TabIndex = 7
        Me.loopplay_button.Text = "                      Loop"
        Me.loopplay_button.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(268, 20)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "﹀"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(216, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "100"
        '
        'volumescroll
        '
        Me.volumescroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.volumescroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.volumescroll.LargeChange = 1
        Me.volumescroll.Location = New System.Drawing.Point(53, 121)
        Me.volumescroll.Maximum = 100
        Me.volumescroll.Name = "volumescroll"
        Me.volumescroll.Size = New System.Drawing.Size(168, 45)
        Me.volumescroll.TabIndex = 0
        Me.volumescroll.TickFrequency = 100
        Me.volumescroll.Value = 100
        '
        'Playing
        '
        Me.Playing.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Playing.Controls.Add(Me.Button4)
        Me.Playing.Controls.Add(Me.Label7)
        Me.Playing.Controls.Add(Me.PreviewPictureBox)
        Me.Playing.Controls.Add(Me.Button3)
        Me.Playing.Controls.Add(Me.TextBox1)
        Me.Playing.Controls.Add(Me.Label18)
        Me.Playing.Controls.Add(Me.Label17)
        Me.Playing.Controls.Add(Me.Label16)
        Me.Playing.Controls.Add(Me.Label15)
        Me.Playing.Controls.Add(Me.Label14)
        Me.Playing.Controls.Add(Me.Label13)
        Me.Playing.Controls.Add(Me.Label12)
        Me.Playing.Controls.Add(Me.Label11)
        Me.Playing.Controls.Add(Me.Label10)
        Me.Playing.Controls.Add(Me.Label9)
        Me.Playing.Controls.Add(Me.Label8)
        Me.Playing.Controls.Add(Me.Label6)
        Me.Playing.Controls.Add(Me.Playpart)
        Me.Playing.Location = New System.Drawing.Point(0, 228)
        Me.Playing.Name = "Playing"
        Me.Playing.Size = New System.Drawing.Size(408, 316)
        Me.Playing.TabIndex = 9
        Me.Playing.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button4.Location = New System.Drawing.Point(390, 76)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(18, 240)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(114, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 21)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Duration"
        '
        'PreviewPictureBox
        '
        Me.PreviewPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PreviewPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PreviewPictureBox.ErrorImage = CType(resources.GetObject("PreviewPictureBox.ErrorImage"), System.Drawing.Image)
        Me.PreviewPictureBox.InitialImage = CType(resources.GetObject("PreviewPictureBox.InitialImage"), System.Drawing.Image)
        Me.PreviewPictureBox.Location = New System.Drawing.Point(7, 37)
        Me.PreviewPictureBox.Name = "PreviewPictureBox"
        Me.PreviewPictureBox.Size = New System.Drawing.Size(100, 100)
        Me.PreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PreviewPictureBox.TabIndex = 6
        Me.PreviewPictureBox.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(324, 270)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 29)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Copy"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(58, 273)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(260, 22)
        Me.TextBox1.TabIndex = 23
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Gray
        Me.Label18.Location = New System.Drawing.Point(7, 273)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 21)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Path"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(57, 237)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 21)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Year"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Gray
        Me.Label16.Location = New System.Drawing.Point(11, 237)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 21)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Year"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(57, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 21)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Track"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gray
        Me.Label14.Location = New System.Drawing.Point(4, 216)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 21)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Track"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(57, 195)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 21)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Sort"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gray
        Me.Label12.Location = New System.Drawing.Point(14, 195)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 21)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Sort"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(57, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 21)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Artist"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(5, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 21)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Artist"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(57, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 21)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Album"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(-5, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 21)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Album"
        '
        'Label6
        '
        Me.Label6.AutoEllipsis = True
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(113, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "None"
        '
        'Playpart
        '
        Me.Playpart.Dock = System.Windows.Forms.DockStyle.Top
        Me.Playpart.Enabled = True
        Me.Playpart.Location = New System.Drawing.Point(0, 0)
        Me.Playpart.Name = "Playpart"
        Me.Playpart.OcxState = CType(resources.GetObject("Playpart.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Playpart.Size = New System.Drawing.Size(408, 76)
        Me.Playpart.TabIndex = 10
        '
        'Blank
        '
        Me.Blank.BackColor = System.Drawing.Color.DimGray
        Me.Blank.Controls.Add(Me.Label3)
        Me.Blank.Location = New System.Drawing.Point(360, 103)
        Me.Blank.Name = "Blank"
        Me.Blank.Size = New System.Drawing.Size(65, 28)
        Me.Blank.TabIndex = 4
        Me.Blank.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(-3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "None"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Playing)
        Me.Controls.Add(Me.Blank)
        Me.Controls.Add(Me.soundsetpanel)
        Me.Controls.Add(Me.Slidemenu)
        Me.Controls.Add(Me.formhead)
        Me.Controls.Add(Me.playpartdock)
        Me.Controls.Add(Me.musiclist)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Music"
        Me.Slidemenu.ResumeLayout(False)
        Me.playpartdock.ResumeLayout(False)
        Me.musictitle.ResumeLayout(False)
        Me.musictitle.PerformLayout()
        CType(Me.PreviewPictureBoxmini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playprogress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.formhead.ResumeLayout(False)
        Me.formhead.PerformLayout()
        Me.FormDock.ResumeLayout(False)
        Me.FormDock.PerformLayout()
        Me.soundsetpanel.ResumeLayout(False)
        Me.soundsetpanel.PerformLayout()
        CType(Me.volumescroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Playing.ResumeLayout(False)
        Me.Playing.PerformLayout()
        CType(Me.PreviewPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Playpart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Blank.ResumeLayout(False)
        Me.Blank.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents playpartdock As Panel
    Friend WithEvents musiclist As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Playing_title As Label
    Friend WithEvents play As Button
    Friend WithEvents soundset As Button
    Friend WithEvents musictitle As Panel
    Friend WithEvents Slidemenu As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents rfmusiclist As Button
    Friend WithEvents pause As Button
    Friend WithEvents formhead As Panel
    Friend WithEvents PreviewPictureBoxmini As PictureBox
    Friend WithEvents flash As Timer
    Friend WithEvents playprogress As TrackBar
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents soundsetpanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents mute_button As Button
    Friend WithEvents loopplay_button As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents volumescroll As TrackBar
    Friend WithEvents Playing As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PreviewPictureBox As PictureBox
    Friend WithEvents Blank As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Playpart As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents FormDock As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
End Class
