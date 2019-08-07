<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class More
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(More))
        Me.gbAbout = New System.Windows.Forms.GroupBox()
        Me.lbLink = New System.Windows.Forms.LinkLabel()
        Me.lbAutor = New System.Windows.Forms.Label()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.boxPicLogo = New System.Windows.Forms.PictureBox()
        Me.lstOptions = New System.Windows.Forms.ListBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.gbFolderChange = New System.Windows.Forms.GroupBox()
        Me.btnDir = New System.Windows.Forms.Button()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.gbColorChange = New System.Windows.Forms.GroupBox()
        Me.rbPink = New System.Windows.Forms.RadioButton()
        Me.rbRed = New System.Windows.Forms.RadioButton()
        Me.rbViolet = New System.Windows.Forms.RadioButton()
        Me.rbGreen = New System.Windows.Forms.RadioButton()
        Me.rbBlue = New System.Windows.Forms.RadioButton()
        Me.rbYellow = New System.Windows.Forms.RadioButton()
        Me.rbBlack = New System.Windows.Forms.RadioButton()
        Me.gbIcon = New System.Windows.Forms.GroupBox()
        Me.chkIcon = New System.Windows.Forms.CheckBox()
        Me.gbConfig = New System.Windows.Forms.GroupBox()
        Me.gbAbout.SuspendLayout()
        CType(Me.boxPicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFolderChange.SuspendLayout()
        Me.gbColorChange.SuspendLayout()
        Me.gbIcon.SuspendLayout()
        Me.gbConfig.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbAbout
        '
        Me.gbAbout.Controls.Add(Me.lbLink)
        Me.gbAbout.Controls.Add(Me.lbAutor)
        Me.gbAbout.Controls.Add(Me.lbVersion)
        Me.gbAbout.Controls.Add(Me.boxPicLogo)
        Me.gbAbout.Location = New System.Drawing.Point(146, 7)
        Me.gbAbout.Name = "gbAbout"
        Me.gbAbout.Size = New System.Drawing.Size(246, 243)
        Me.gbAbout.TabIndex = 0
        Me.gbAbout.TabStop = False
        Me.gbAbout.Visible = False
        '
        'lbLink
        '
        Me.lbLink.ActiveLinkColor = System.Drawing.Color.DimGray
        Me.lbLink.AutoSize = True
        Me.lbLink.LinkColor = System.Drawing.Color.Black
        Me.lbLink.Location = New System.Drawing.Point(145, 216)
        Me.lbLink.Name = "lbLink"
        Me.lbLink.Size = New System.Drawing.Size(67, 13)
        Me.lbLink.TabIndex = 3
        Me.lbLink.TabStop = True
        Me.lbLink.Text = "Orbes Carlos"
        Me.lbLink.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'lbAutor
        '
        Me.lbAutor.Location = New System.Drawing.Point(27, 211)
        Me.lbAutor.Name = "lbAutor"
        Me.lbAutor.Size = New System.Drawing.Size(122, 23)
        Me.lbAutor.TabIndex = 2
        Me.lbAutor.Text = "Desarrollado en VB por:"
        Me.lbAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbVersion
        '
        Me.lbVersion.Location = New System.Drawing.Point(22, 188)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(200, 23)
        Me.lbVersion.TabIndex = 1
        Me.lbVersion.Text = "Versión:"
        Me.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'boxPicLogo
        '
        Me.boxPicLogo.Image = Global.n.core.My.Resources.Resources.logo
        Me.boxPicLogo.Location = New System.Drawing.Point(22, 9)
        Me.boxPicLogo.Name = "boxPicLogo"
        Me.boxPicLogo.Size = New System.Drawing.Size(200, 200)
        Me.boxPicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.boxPicLogo.TabIndex = 0
        Me.boxPicLogo.TabStop = False
        '
        'lstOptions
        '
        Me.lstOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstOptions.FormattingEnabled = True
        Me.lstOptions.Location = New System.Drawing.Point(12, 14)
        Me.lstOptions.Name = "lstOptions"
        Me.lstOptions.Size = New System.Drawing.Size(128, 236)
        Me.lstOptions.TabIndex = 0
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(317, 256)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 1
        Me.btnApply.Text = "Aplicar"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(236, 256)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.SelectedPath = "./MP3"
        '
        'gbFolderChange
        '
        Me.gbFolderChange.Controls.Add(Me.btnDir)
        Me.gbFolderChange.Controls.Add(Me.txtDir)
        Me.gbFolderChange.Location = New System.Drawing.Point(7, 19)
        Me.gbFolderChange.Name = "gbFolderChange"
        Me.gbFolderChange.Size = New System.Drawing.Size(233, 57)
        Me.gbFolderChange.TabIndex = 0
        Me.gbFolderChange.TabStop = False
        Me.gbFolderChange.Text = "Seleccionar carpeta de reproducción"
        '
        'btnDir
        '
        Me.btnDir.BackColor = System.Drawing.Color.Transparent
        Me.btnDir.BackgroundImage = Global.n.core.My.Resources.Resources.folder
        Me.btnDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDir.FlatAppearance.BorderSize = 0
        Me.btnDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDir.Location = New System.Drawing.Point(199, 18)
        Me.btnDir.Name = "btnDir"
        Me.btnDir.Size = New System.Drawing.Size(23, 23)
        Me.btnDir.TabIndex = 1
        Me.btnDir.Text = "..."
        Me.btnDir.UseVisualStyleBackColor = False
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(7, 20)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(186, 20)
        Me.txtDir.TabIndex = 0
        '
        'gbColorChange
        '
        Me.gbColorChange.Controls.Add(Me.rbPink)
        Me.gbColorChange.Controls.Add(Me.rbRed)
        Me.gbColorChange.Controls.Add(Me.rbViolet)
        Me.gbColorChange.Controls.Add(Me.rbGreen)
        Me.gbColorChange.Controls.Add(Me.rbBlue)
        Me.gbColorChange.Controls.Add(Me.rbYellow)
        Me.gbColorChange.Controls.Add(Me.rbBlack)
        Me.gbColorChange.Location = New System.Drawing.Point(7, 83)
        Me.gbColorChange.Name = "gbColorChange"
        Me.gbColorChange.Size = New System.Drawing.Size(233, 56)
        Me.gbColorChange.TabIndex = 1
        Me.gbColorChange.TabStop = False
        Me.gbColorChange.Text = "Seleccionar color del reproductor"
        '
        'rbPink
        '
        Me.rbPink.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbPink.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.rbPink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rbPink.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbPink.Location = New System.Drawing.Point(193, 21)
        Me.rbPink.Name = "rbPink"
        Me.rbPink.Size = New System.Drawing.Size(24, 24)
        Me.rbPink.TabIndex = 9
        Me.rbPink.Tag = "pink"
        Me.rbPink.UseVisualStyleBackColor = False
        '
        'rbRed
        '
        Me.rbRed.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbRed.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.rbRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rbRed.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbRed.Location = New System.Drawing.Point(163, 21)
        Me.rbRed.Name = "rbRed"
        Me.rbRed.Size = New System.Drawing.Size(24, 24)
        Me.rbRed.TabIndex = 8
        Me.rbRed.Tag = "red"
        Me.rbRed.UseVisualStyleBackColor = False
        '
        'rbViolet
        '
        Me.rbViolet.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbViolet.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.rbViolet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rbViolet.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbViolet.Location = New System.Drawing.Point(133, 21)
        Me.rbViolet.Name = "rbViolet"
        Me.rbViolet.Size = New System.Drawing.Size(24, 24)
        Me.rbViolet.TabIndex = 7
        Me.rbViolet.Tag = "violet"
        Me.rbViolet.UseVisualStyleBackColor = False
        '
        'rbGreen
        '
        Me.rbGreen.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.rbGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rbGreen.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbGreen.Location = New System.Drawing.Point(103, 21)
        Me.rbGreen.Name = "rbGreen"
        Me.rbGreen.Size = New System.Drawing.Size(24, 24)
        Me.rbGreen.TabIndex = 6
        Me.rbGreen.Tag = "green"
        Me.rbGreen.UseVisualStyleBackColor = False
        '
        'rbBlue
        '
        Me.rbBlue.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.rbBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rbBlue.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbBlue.Location = New System.Drawing.Point(73, 21)
        Me.rbBlue.Name = "rbBlue"
        Me.rbBlue.Size = New System.Drawing.Size(24, 24)
        Me.rbBlue.TabIndex = 5
        Me.rbBlue.Tag = "blue"
        Me.rbBlue.UseVisualStyleBackColor = False
        '
        'rbYellow
        '
        Me.rbYellow.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbYellow.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.rbYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rbYellow.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbYellow.Location = New System.Drawing.Point(43, 21)
        Me.rbYellow.Name = "rbYellow"
        Me.rbYellow.Size = New System.Drawing.Size(24, 24)
        Me.rbYellow.TabIndex = 4
        Me.rbYellow.Tag = "orange"
        Me.rbYellow.UseVisualStyleBackColor = False
        '
        'rbBlack
        '
        Me.rbBlack.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbBlack.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.rbBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rbBlack.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbBlack.Checked = True
        Me.rbBlack.Location = New System.Drawing.Point(13, 21)
        Me.rbBlack.Name = "rbBlack"
        Me.rbBlack.Size = New System.Drawing.Size(24, 24)
        Me.rbBlack.TabIndex = 3
        Me.rbBlack.TabStop = True
        Me.rbBlack.Tag = "default"
        Me.rbBlack.UseVisualStyleBackColor = False
        '
        'gbIcon
        '
        Me.gbIcon.Controls.Add(Me.chkIcon)
        Me.gbIcon.Location = New System.Drawing.Point(7, 146)
        Me.gbIcon.Name = "gbIcon"
        Me.gbIcon.Size = New System.Drawing.Size(233, 83)
        Me.gbIcon.TabIndex = 2
        Me.gbIcon.TabStop = False
        Me.gbIcon.Text = "Opciones del sistema"
        '
        'chkIcon
        '
        Me.chkIcon.AutoSize = True
        Me.chkIcon.Location = New System.Drawing.Point(7, 22)
        Me.chkIcon.Name = "chkIcon"
        Me.chkIcon.Size = New System.Drawing.Size(178, 17)
        Me.chkIcon.TabIndex = 0
        Me.chkIcon.Text = "Minimizar en bandeja de sistema"
        Me.chkIcon.UseVisualStyleBackColor = True
        '
        'gbConfig
        '
        Me.gbConfig.Controls.Add(Me.gbIcon)
        Me.gbConfig.Controls.Add(Me.gbColorChange)
        Me.gbConfig.Controls.Add(Me.gbFolderChange)
        Me.gbConfig.Location = New System.Drawing.Point(146, 7)
        Me.gbConfig.Name = "gbConfig"
        Me.gbConfig.Size = New System.Drawing.Size(246, 243)
        Me.gbConfig.TabIndex = 5
        Me.gbConfig.TabStop = False
        '
        'More
        '
        Me.AcceptButton = Me.btnApply
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(406, 288)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.lstOptions)
        Me.Controls.Add(Me.gbConfig)
        Me.Controls.Add(Me.gbAbout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "More"
        Me.Text = "Opciones"
        Me.gbAbout.ResumeLayout(False)
        Me.gbAbout.PerformLayout()
        CType(Me.boxPicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFolderChange.ResumeLayout(False)
        Me.gbFolderChange.PerformLayout()
        Me.gbColorChange.ResumeLayout(False)
        Me.gbIcon.ResumeLayout(False)
        Me.gbIcon.PerformLayout()
        Me.gbConfig.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbAbout As GroupBox
    Friend WithEvents lstOptions As ListBox
    Friend WithEvents btnApply As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents boxPicLogo As PictureBox
    Friend WithEvents lbVersion As Label
    Friend WithEvents lbAutor As Label
    Friend WithEvents lbLink As LinkLabel
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents gbFolderChange As GroupBox
    Friend WithEvents btnDir As Button
    Friend WithEvents txtDir As TextBox
    Friend WithEvents gbColorChange As GroupBox
    Friend WithEvents rbPink As RadioButton
    Friend WithEvents rbRed As RadioButton
    Friend WithEvents rbViolet As RadioButton
    Friend WithEvents rbGreen As RadioButton
    Friend WithEvents rbBlue As RadioButton
    Friend WithEvents rbYellow As RadioButton
    Friend WithEvents rbBlack As RadioButton
    Friend WithEvents gbIcon As GroupBox
    Friend WithEvents chkIcon As CheckBox
    Friend WithEvents gbConfig As GroupBox
End Class
