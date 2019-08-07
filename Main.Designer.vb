<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.lbTime = New System.Windows.Forms.Label()
        Me.btnVol0 = New System.Windows.Forms.Button()
        Me.btnVol1 = New System.Windows.Forms.Button()
        Me.btnVol3 = New System.Windows.Forms.Button()
        Me.btnVol5 = New System.Windows.Forms.Button()
        Me.btnVol8 = New System.Windows.Forms.Button()
        Me.lbDisplay = New System.Windows.Forms.Label()
        Me.btnVol7 = New System.Windows.Forms.Button()
        Me.btnVol2 = New System.Windows.Forms.Button()
        Me.btnVol6 = New System.Windows.Forms.Button()
        Me.btnVol4 = New System.Windows.Forms.Button()
        Me.btnVol9 = New System.Windows.Forms.Button()
        Me.btnVol10 = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkShuffle = New System.Windows.Forms.CheckBox()
        Me.chkRepeat = New System.Windows.Forms.CheckBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'lbTime
        '
        Me.lbTime.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lbTime.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbTime.Location = New System.Drawing.Point(218, 36)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(67, 24)
        Me.lbTime.TabIndex = 8
        Me.lbTime.Text = "00:00"
        Me.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVol0
        '
        Me.btnVol0.BackColor = System.Drawing.Color.Gray
        Me.btnVol0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVol0.FlatAppearance.BorderSize = 0
        Me.btnVol0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVol0.Location = New System.Drawing.Point(219, 74)
        Me.btnVol0.Name = "btnVol0"
        Me.btnVol0.Size = New System.Drawing.Size(4, 20)
        Me.btnVol0.TabIndex = 12
        Me.btnVol0.Tag = "volume"
        Me.btnVol0.UseVisualStyleBackColor = False
        '
        'btnVol1
        '
        Me.btnVol1.BackColor = System.Drawing.Color.Gray
        Me.btnVol1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVol1.FlatAppearance.BorderSize = 0
        Me.btnVol1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVol1.Location = New System.Drawing.Point(225, 74)
        Me.btnVol1.Name = "btnVol1"
        Me.btnVol1.Size = New System.Drawing.Size(4, 20)
        Me.btnVol1.TabIndex = 13
        Me.btnVol1.Tag = "volume"
        Me.btnVol1.UseVisualStyleBackColor = False
        '
        'btnVol3
        '
        Me.btnVol3.BackColor = System.Drawing.Color.Gray
        Me.btnVol3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVol3.FlatAppearance.BorderSize = 0
        Me.btnVol3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVol3.Location = New System.Drawing.Point(237, 74)
        Me.btnVol3.Name = "btnVol3"
        Me.btnVol3.Size = New System.Drawing.Size(4, 20)
        Me.btnVol3.TabIndex = 14
        Me.btnVol3.Tag = "volume"
        Me.btnVol3.UseVisualStyleBackColor = False
        '
        'btnVol5
        '
        Me.btnVol5.BackColor = System.Drawing.Color.Gray
        Me.btnVol5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVol5.FlatAppearance.BorderSize = 0
        Me.btnVol5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVol5.Location = New System.Drawing.Point(249, 74)
        Me.btnVol5.Name = "btnVol5"
        Me.btnVol5.Size = New System.Drawing.Size(4, 20)
        Me.btnVol5.TabIndex = 15
        Me.btnVol5.Tag = "volume"
        Me.btnVol5.UseVisualStyleBackColor = False
        '
        'btnVol8
        '
        Me.btnVol8.BackColor = System.Drawing.Color.Gray
        Me.btnVol8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVol8.FlatAppearance.BorderSize = 0
        Me.btnVol8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVol8.Location = New System.Drawing.Point(267, 74)
        Me.btnVol8.Name = "btnVol8"
        Me.btnVol8.Size = New System.Drawing.Size(4, 20)
        Me.btnVol8.TabIndex = 16
        Me.btnVol8.Tag = "volume"
        Me.btnVol8.UseVisualStyleBackColor = False
        '
        'lbDisplay
        '
        Me.lbDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lbDisplay.ForeColor = System.Drawing.Color.White
        Me.lbDisplay.Location = New System.Drawing.Point(12, 36)
        Me.lbDisplay.Name = "lbDisplay"
        Me.lbDisplay.Padding = New System.Windows.Forms.Padding(5)
        Me.lbDisplay.Size = New System.Drawing.Size(200, 24)
        Me.lbDisplay.TabIndex = 11
        Me.lbDisplay.Text = "No se encontraron archivos MP3"
        '
        'btnVol7
        '
        Me.btnVol7.BackColor = System.Drawing.Color.Gray
        Me.btnVol7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVol7.FlatAppearance.BorderSize = 0
        Me.btnVol7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVol7.Location = New System.Drawing.Point(261, 74)
        Me.btnVol7.Name = "btnVol7"
        Me.btnVol7.Size = New System.Drawing.Size(4, 20)
        Me.btnVol7.TabIndex = 17
        Me.btnVol7.Tag = "volume"
        Me.btnVol7.UseVisualStyleBackColor = False
        '
        'btnVol2
        '
        Me.btnVol2.BackColor = System.Drawing.Color.Gray
        Me.btnVol2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVol2.FlatAppearance.BorderSize = 0
        Me.btnVol2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVol2.Location = New System.Drawing.Point(231, 74)
        Me.btnVol2.Name = "btnVol2"
        Me.btnVol2.Size = New System.Drawing.Size(4, 20)
        Me.btnVol2.TabIndex = 18
        Me.btnVol2.Tag = "volume"
        Me.btnVol2.UseVisualStyleBackColor = False
        '
        'btnVol6
        '
        Me.btnVol6.BackColor = System.Drawing.Color.Gray
        Me.btnVol6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVol6.FlatAppearance.BorderSize = 0
        Me.btnVol6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVol6.Location = New System.Drawing.Point(255, 74)
        Me.btnVol6.Name = "btnVol6"
        Me.btnVol6.Size = New System.Drawing.Size(4, 20)
        Me.btnVol6.TabIndex = 19
        Me.btnVol6.Tag = "volume"
        Me.btnVol6.UseVisualStyleBackColor = False
        '
        'btnVol4
        '
        Me.btnVol4.BackColor = System.Drawing.Color.Gray
        Me.btnVol4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVol4.FlatAppearance.BorderSize = 0
        Me.btnVol4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVol4.Location = New System.Drawing.Point(243, 74)
        Me.btnVol4.Name = "btnVol4"
        Me.btnVol4.Size = New System.Drawing.Size(4, 20)
        Me.btnVol4.TabIndex = 20
        Me.btnVol4.Tag = "volume"
        Me.btnVol4.UseVisualStyleBackColor = False
        '
        'btnVol9
        '
        Me.btnVol9.BackColor = System.Drawing.Color.Gray
        Me.btnVol9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVol9.FlatAppearance.BorderSize = 0
        Me.btnVol9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVol9.Location = New System.Drawing.Point(273, 74)
        Me.btnVol9.Name = "btnVol9"
        Me.btnVol9.Size = New System.Drawing.Size(4, 20)
        Me.btnVol9.TabIndex = 21
        Me.btnVol9.Tag = "volume"
        Me.btnVol9.UseVisualStyleBackColor = False
        '
        'btnVol10
        '
        Me.btnVol10.BackColor = System.Drawing.Color.Gray
        Me.btnVol10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVol10.FlatAppearance.BorderSize = 0
        Me.btnVol10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVol10.Location = New System.Drawing.Point(279, 74)
        Me.btnVol10.Name = "btnVol10"
        Me.btnVol10.Size = New System.Drawing.Size(4, 20)
        Me.btnVol10.TabIndex = 22
        Me.btnVol10.Tag = "volume"
        Me.btnVol10.UseVisualStyleBackColor = False
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 5000
        Me.ToolTip.InitialDelay = 400
        Me.ToolTip.ReshowDelay = 100
        '
        'chkShuffle
        '
        Me.chkShuffle.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkShuffle.BackgroundImage = Global.n.core.My.Resources.Resources.shuffle
        Me.chkShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkShuffle.FlatAppearance.BorderSize = 0
        Me.chkShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShuffle.Location = New System.Drawing.Point(40, 1)
        Me.chkShuffle.Name = "chkShuffle"
        Me.chkShuffle.Size = New System.Drawing.Size(28, 28)
        Me.chkShuffle.TabIndex = 25
        Me.chkShuffle.Tag = "shuffle"
        Me.ToolTip.SetToolTip(Me.chkShuffle, "Aleatorio")
        Me.chkShuffle.UseVisualStyleBackColor = True
        '
        'chkRepeat
        '
        Me.chkRepeat.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkRepeat.BackgroundImage = Global.n.core.My.Resources.Resources.repeat
        Me.chkRepeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkRepeat.FlatAppearance.BorderSize = 0
        Me.chkRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkRepeat.Location = New System.Drawing.Point(12, 1)
        Me.chkRepeat.Name = "chkRepeat"
        Me.chkRepeat.Size = New System.Drawing.Size(28, 28)
        Me.chkRepeat.TabIndex = 24
        Me.chkRepeat.Tag = "repeat"
        Me.ToolTip.SetToolTip(Me.chkRepeat, "Bucle")
        Me.chkRepeat.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.BackgroundImage = Global.n.core.My.Resources.Resources.btnStop
        Me.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStop.FlatAppearance.BorderSize = 0
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Location = New System.Drawing.Point(65, 73)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(22, 22)
        Me.btnStop.TabIndex = 10
        Me.ToolTip.SetToolTip(Me.btnStop, "Detener")
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.BackgroundImage = Global.n.core.My.Resources.Resources.btnPause
        Me.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPause.FlatAppearance.BorderSize = 0
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPause.Location = New System.Drawing.Point(99, 73)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(22, 22)
        Me.btnPause.TabIndex = 9
        Me.btnPause.Tag = ""
        Me.ToolTip.SetToolTip(Me.btnPause, "Pausar")
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.BackgroundImage = Global.n.core.My.Resources.Resources.btnPrev
        Me.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrev.FlatAppearance.BorderSize = 0
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Location = New System.Drawing.Point(31, 73)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(22, 22)
        Me.btnPrev.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.btnPrev, "Anterior")
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.BackgroundImage = Global.n.core.My.Resources.Resources.btnNext
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(167, 73)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(22, 22)
        Me.btnNext.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.btnNext, "Próximo")
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.BackgroundImage = Global.n.core.My.Resources.Resources.btnPlay
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlay.FlatAppearance.BorderSize = 0
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Location = New System.Drawing.Point(133, 73)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(22, 22)
        Me.btnPlay.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.btnPlay, "Reproducir")
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "n.core"
        '
        'btnHelp
        '
        Me.btnHelp.BackgroundImage = Global.n.core.My.Resources.Resources.btnHelp
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Location = New System.Drawing.Point(218, 3)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(22, 23)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Tag = "Opciones"
        Me.ToolTip.SetToolTip(Me.btnHelp, "Opciones")
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnMin
        '
        Me.btnMin.BackgroundImage = Global.n.core.My.Resources.Resources.btnMin
        Me.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Location = New System.Drawing.Point(246, 3)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(22, 23)
        Me.btnMin.TabIndex = 5
        Me.btnMin.Tag = "Minimizar"
        Me.ToolTip.SetToolTip(Me.btnMin, "Minimizar")
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.n.core.My.Resources.Resources.btnClose
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(272, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(22, 22)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Tag = "Cerrar"
        Me.ToolTip.SetToolTip(Me.btnClose, "Cerrar")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(297, 107)
        Me.Controls.Add(Me.chkShuffle)
        Me.Controls.Add(Me.chkRepeat)
        Me.Controls.Add(Me.btnVol10)
        Me.Controls.Add(Me.btnVol9)
        Me.Controls.Add(Me.btnVol4)
        Me.Controls.Add(Me.btnVol6)
        Me.Controls.Add(Me.btnVol2)
        Me.Controls.Add(Me.btnVol7)
        Me.Controls.Add(Me.btnVol8)
        Me.Controls.Add(Me.btnVol5)
        Me.Controls.Add(Me.btnVol3)
        Me.Controls.Add(Me.btnVol1)
        Me.Controls.Add(Me.btnVol0)
        Me.Controls.Add(Me.lbDisplay)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPlay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "n.core"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents lbTime As Label
    Friend WithEvents btnPause As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnVol0 As Button
    Friend WithEvents btnVol1 As Button
    Friend WithEvents btnVol3 As Button
    Friend WithEvents btnVol5 As Button
    Friend WithEvents btnVol8 As Button
    Friend WithEvents lbDisplay As Label
    Friend WithEvents btnVol7 As Button
    Friend WithEvents btnVol2 As Button
    Friend WithEvents btnVol6 As Button
    Friend WithEvents btnVol4 As Button
    Friend WithEvents btnVol9 As Button
    Friend WithEvents btnVol10 As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents chkRepeat As CheckBox
    Friend WithEvents chkShuffle As CheckBox
    Friend WithEvents NotifyIcon As NotifyIcon
End Class
