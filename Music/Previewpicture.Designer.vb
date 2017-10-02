<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Previewpicture
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Previewpicture))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(184, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(9, 328)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 21)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Artist"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(9, 349)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 21)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Album"
        '
        'Label6
        '
        Me.Label6.AutoEllipsis = True
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(9, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "None"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Black
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(9, 8)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(526, 27)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "×"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Previewpicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(544, 403)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Previewpicture"
        Me.Opacity = 0.93R
        Me.Padding = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AboutBox1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button8 As Button
End Class
