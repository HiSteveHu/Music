<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Setting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setting))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.delete = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.progresspre = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.delete)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(442, 225)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Targets"
        '
        'delete
        '
        Me.delete.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.delete.Location = New System.Drawing.Point(372, 158)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(62, 23)
        Me.delete.TabIndex = 7
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(372, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(314, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Via"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(82, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 23)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "The music files in these folders can be scaned" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can add up to 6 folders"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(8, 129)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(358, 82)
        Me.ListBox1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Add a folder . Its muic files will be scaned"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(100, 26)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(463, 494)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(455, 460)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Scan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(5, 240)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(442, 99)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Format"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(304, 30)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(62, 25)
        Me.CheckBox4.TabIndex = 4
        Me.CheckBox4.Text = "AAC"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(304, 61)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(67, 25)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "WAV"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(23, 61)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(68, 25)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "FLAC"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(23, 30)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(187, 25)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "MP3 (MPEG Layer-3)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.progresspre)
        Me.TabPage2.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(455, 460)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Play"
        '
        'progresspre
        '
        Me.progresspre.AutoSize = True
        Me.progresspre.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.progresspre.Location = New System.Drawing.Point(8, 16)
        Me.progresspre.Name = "progresspre"
        Me.progresspre.Size = New System.Drawing.Size(357, 25)
        Me.progresspre.TabIndex = 0
        Me.progresspre.Text = "Previewing when scrolling the progress bar"
        Me.progresspre.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(455, 460)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "About"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(140, 438)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "© 2017   Dekstop Tech. Cor."
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button5.Location = New System.Drawing.Point(21, 270)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(412, 40)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Open Source"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button4.Location = New System.Drawing.Point(21, 224)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(412, 40)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Reference Licenses"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(199, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Music"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Music"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(162, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(463, 494)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Setting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Setting"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents delete As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents progresspre As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
End Class
