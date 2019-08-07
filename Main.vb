Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports WMPLib


Public Class Main
    Private a As New WindowsMediaPlayer
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    Private Sub checkOrder()
        If globals.app("order") = "none" Then
            chkRepeat.Checked = False
            chkShuffle.Checked = False
        End If
        If globals.app("order") = "repeat" Then
            chkRepeat.Checked = True
            chkShuffle.Checked = False
        End If
        If globals.app("order") = "shuffle" Then
            chkShuffle.Checked = True
            chkRepeat.Checked = False
        End If
    End Sub
    Private Sub nextTheme()
        Dim cant As Integer = list.Count
        If globals.app("order") = "repeat" Then
            opt = opt + 1
            If opt > cant - 1 Then
                opt = 0
            End If
            lbDisplay.Text = list(opt)
            Dim w As New WindowsMediaPlayer
            Dim m As IWMPMedia = w.newMedia(globals.app("dir") + list(opt))
            If m IsNot Nothing Then
                lbTime.Text = m.durationString
            End If
            a.controls.play()
        End If

        If globals.app("order") = "shuffle" Then
            Randomize()
            Dim now As Integer = opt
            opt = CInt(Int((cant * Rnd())))

            While opt > cant - 1 Or Not opt <> now
                opt = CInt(Int((cant * Rnd())))
            End While

            lbDisplay.Text = list(opt)
            Dim w As New WindowsMediaPlayer
            Dim m As IWMPMedia = w.newMedia(globals.app("dir") + list(opt))
            If m IsNot Nothing Then
                lbTime.Text = m.durationString
            End If
            a.controls.play()
        End If
    End Sub
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Icono de notificacion
        If globals.app("tray") = "visible" Then
            NotifyIcon.Visible = True
        Else
            NotifyIcon.Visible = False
            Me.ShowInTaskbar = True
        End If

        'Carga de archivos
        Dim folder As New DirectoryInfo(globals.app("dir"))
        Dim text As String = ""
        Dim n As Integer = 0

        'Orden de reproduccion
        checkOrder()

        'Carga color de fondo
        Select Case globals.app("color")
            Case "default"
                Me.BackColor = Color.FromArgb(22, 22, 22)
                lbDisplay.BackColor = Color.FromArgb(60, 60, 60)
                lbTime.BackColor = Color.FromArgb(60, 60, 60)
                btnPlay.BackgroundImage = My.Resources.btnPlay
                btnPause.BackgroundImage = My.Resources.btnPause
                btnStop.BackgroundImage = My.Resources.btnStop
                btnNext.BackgroundImage = My.Resources.btnNext
                btnPrev.BackgroundImage = My.Resources.btnPrev
                btnMin.BackgroundImage = My.Resources.btnMin
                btnClose.BackgroundImage = My.Resources.btnClose
                btnHelp.BackgroundImage = My.Resources.btnHelp
                chkRepeat.BackgroundImage = My.Resources.repeat
                chkShuffle.BackgroundImage = My.Resources.shuffle
                For Each control In Me.Controls
                    If control.Tag = "volume" Then
                        control.BackColor = Color.FromArgb(60, 60, 60)
                    End If
                Next
            Case "orange"
                Me.BackColor = Color.FromArgb(248, 161, 27)
                lbDisplay.BackColor = Color.FromArgb(225, 107, 14)
                lbTime.BackColor = Color.FromArgb(225, 107, 14)
                btnPlay.BackgroundImage = My.Resources.btnPlayOrange
                btnPause.BackgroundImage = My.Resources.btnPauseOrange
                btnStop.BackgroundImage = My.Resources.btnStopOrange
                btnNext.BackgroundImage = My.Resources.btnNextOrange
                btnPrev.BackgroundImage = My.Resources.btnPrevOrange
                btnMin.BackgroundImage = My.Resources.btnMinOrange
                btnClose.BackgroundImage = My.Resources.btnCloseOrange
                btnHelp.BackgroundImage = My.Resources.btnHelpOrange
                chkRepeat.BackgroundImage = My.Resources.repeatOrange
                chkShuffle.BackgroundImage = My.Resources.shuffleOrange
                For Each control In Me.Controls
                    If control.Tag = "volume" Then
                        control.BackColor = Color.FromArgb(225, 107, 14)
                    End If
                Next
            Case "blue"
                Me.BackColor = Color.FromArgb(0, 162, 232)
                lbDisplay.BackColor = Color.FromArgb(0, 135, 193)
                lbTime.BackColor = Color.FromArgb(0, 135, 193)
                btnPlay.BackgroundImage = My.Resources.btnPlayBlue
                btnPause.BackgroundImage = My.Resources.btnPauseBlue
                btnStop.BackgroundImage = My.Resources.btnStopBlue
                btnNext.BackgroundImage = My.Resources.btnNextBlue
                btnPrev.BackgroundImage = My.Resources.btnPrevBlue
                btnMin.BackgroundImage = My.Resources.btnMinBlue
                btnClose.BackgroundImage = My.Resources.btnCloseBlue
                btnHelp.BackgroundImage = My.Resources.btnHelpBlue
                chkRepeat.BackgroundImage = My.Resources.repeatBlue
                chkShuffle.BackgroundImage = My.Resources.shuffleBlue
                For Each control In Me.Controls
                    If control.Tag = "volume" Then
                        control.BackColor = Color.FromArgb(0, 135, 193)
                    End If
                Next
            Case "green"
                Me.BackColor = Color.FromArgb(119, 228, 61)
                lbDisplay.BackColor = Color.FromArgb(80, 189, 22)
                lbTime.BackColor = Color.FromArgb(80, 189, 22)
                btnPlay.BackgroundImage = My.Resources.btnPlayGreen
                btnPause.BackgroundImage = My.Resources.btnPauseGreen
                btnStop.BackgroundImage = My.Resources.btnStopGreen
                btnNext.BackgroundImage = My.Resources.btnNextGreen
                btnPrev.BackgroundImage = My.Resources.btnPrevGreen
                btnMin.BackgroundImage = My.Resources.btnMinGreen
                btnClose.BackgroundImage = My.Resources.btnCloseGreen
                btnHelp.BackgroundImage = My.Resources.btnHelpGreen
                chkRepeat.BackgroundImage = My.Resources.repeatGreen
                chkShuffle.BackgroundImage = My.Resources.shuffleGreen
                For Each control In Me.Controls
                    If control.Tag = "volume" Then
                        control.BackColor = Color.FromArgb(80, 189, 22)
                    End If
                Next
            Case "violet"
                Me.BackColor = Color.FromArgb(179, 20, 231)
                lbDisplay.BackColor = Color.FromArgb(145, 0, 192)
                lbTime.BackColor = Color.FromArgb(145, 0, 192)
                btnPlay.BackgroundImage = My.Resources.btnPlayViolet
                btnPause.BackgroundImage = My.Resources.btnPauseViolet
                btnStop.BackgroundImage = My.Resources.btnStopViolet
                btnNext.BackgroundImage = My.Resources.btnNextViolet
                btnPrev.BackgroundImage = My.Resources.btnPrevViolet
                btnMin.BackgroundImage = My.Resources.btnMinViolet
                btnClose.BackgroundImage = My.Resources.btnCloseViolet
                btnHelp.BackgroundImage = My.Resources.btnHelpViolet
                chkRepeat.BackgroundImage = My.Resources.repeatViolet
                chkShuffle.BackgroundImage = My.Resources.shuffleViolet
                For Each control In Me.Controls
                    If control.Tag = "volume" Then
                        control.BackColor = Color.FromArgb(145, 0, 192)
                    End If
                Next
            Case "red"
                Me.BackColor = Color.FromArgb(240, 73, 32)
                lbDisplay.BackColor = Color.FromArgb(201, 39, 0)
                lbTime.BackColor = Color.FromArgb(201, 39, 0)
                btnPlay.BackgroundImage = My.Resources.btnPlayRed
                btnPause.BackgroundImage = My.Resources.btnPauseRed
                btnStop.BackgroundImage = My.Resources.btnStopRed
                btnNext.BackgroundImage = My.Resources.btnNextRed
                btnPrev.BackgroundImage = My.Resources.btnPrevRed
                btnMin.BackgroundImage = My.Resources.btnMinRed
                btnClose.BackgroundImage = My.Resources.btnCloseRed
                btnHelp.BackgroundImage = My.Resources.btnHelpRed
                chkRepeat.BackgroundImage = My.Resources.repeatRed
                chkShuffle.BackgroundImage = My.Resources.shuffleRed
                For Each control In Me.Controls
                    If control.Tag = "volume" Then
                        control.BackColor = Color.FromArgb(201, 39, 0)
                    End If
                Next
            Case "pink"
                Me.BackColor = Color.FromArgb(250, 137, 241)
                lbDisplay.BackColor = Color.FromArgb(211, 84, 201)
                lbTime.BackColor = Color.FromArgb(211, 84, 201)
                btnPlay.BackgroundImage = My.Resources.btnPlayPink
                btnPause.BackgroundImage = My.Resources.btnPausePink
                btnStop.BackgroundImage = My.Resources.btnStopPink
                btnNext.BackgroundImage = My.Resources.btnNextPink
                btnPrev.BackgroundImage = My.Resources.btnPrevPink
                btnMin.BackgroundImage = My.Resources.btnMinPink
                btnClose.BackgroundImage = My.Resources.btnClosePink
                btnHelp.BackgroundImage = My.Resources.btnHelpPink
                chkRepeat.BackgroundImage = My.Resources.repeatPink
                chkShuffle.BackgroundImage = My.Resources.shufflePink
                For Each control In Me.Controls
                    If control.Tag = "volume" Then
                        control.BackColor = Color.FromArgb(211, 84, 201)
                    End If
                Next
        End Select

        For Each file As FileInfo In folder.GetFiles()
            If file.Name.Substring(file.Name.Count - 3) = "mp3" Or file.Name.Substring(file.Name.Count - 3) = "MP3" Then
                ReDim Preserve list(n)
                list(n) = file.Name
                n = n + 1
            End If
        Next
        If n > 0 Then
            lbDisplay.Text = list(opt)
        Else
            lbDisplay.Text = "No se encontraron archivos MP3"
            globals.list = Nothing
        End If
    End Sub
    Public Sub RefreshMain()
        Form_Load(Me, Nothing)
    End Sub
    Private Sub btnClose_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClose.MouseDown
        btnClose.Top = btnClose.Top + 1
    End Sub

    Private Sub btnClose_MouseUp(sender As Object, e As MouseEventArgs) Handles btnClose.MouseUp
        btnClose.Top = btnClose.Top - 1
        Me.Close()
    End Sub

    Private Sub btnMin_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMin.MouseDown
        btnMin.Top = btnMin.Top + 1
    End Sub

    Private Sub btnMin_MouseUp(sender As Object, e As MouseEventArgs) Handles btnMin.MouseUp
        btnMin.Top = btnMin.Top - 1
        Me.WindowState = FormWindowState.Minimized
        If globals.app("tray") = "visible" Then
            Me.ShowInTaskbar = False
            NotifyIcon.Visible = True
        Else
            Me.ShowInTaskbar = True
            NotifyIcon.Visible = False
        End If
    End Sub


    Private Sub btnPlay_MouseDown(sender As Object, e As MouseEventArgs) Handles btnPlay.MouseDown
        If globals.list IsNot Nothing Then
            If list IsNot Nothing Then
                a.controls.stop()
                a.URL = globals.app("dir") + list(opt)
                lbTime.Text = a.currentMedia.durationString
                a.controls.play()

                Dim w As New WindowsMediaPlayer
                Dim m As IWMPMedia = w.newMedia(globals.app("dir") + list(opt))

                Timer.Start()

                If m IsNot Nothing Then
                    lbTime.Text = m.durationString
                End If
                w.close()
            End If
        End If
    End Sub


    Private Sub btnBack_MouseDown(sender As Object, e As MouseEventArgs) Handles btnPrev.MouseDown
        If globals.list IsNot Nothing Then
            opt = opt - 1
            If opt < 0 Then
                opt = 0
            End If
            lbDisplay.Text = list(opt)
            Dim w As New WindowsMediaPlayer
            Dim m As IWMPMedia = w.newMedia(globals.app("dir") + list(opt))
            If m IsNot Nothing Then
                lbTime.Text = m.durationString
            End If

            If a.playState = 3 Then
                a.controls.stop()
                a.URL = globals.app("dir") + list(opt)
                a.controls.play()
            End If
        End If
    End Sub

    Private Sub btnNext_MouseDown(sender As Object, e As MouseEventArgs) Handles btnNext.MouseDown
        If globals.list IsNot Nothing Then
            opt = opt + 1
            If opt > list.Count - 1 Then
                opt = list.Count - 1
            End If
            lbDisplay.Text = list(opt)
            Dim w As New WindowsMediaPlayer
            Dim m As IWMPMedia = w.newMedia(globals.app("dir") + list(opt))
            If m IsNot Nothing Then
                lbTime.Text = m.durationString
            End If

            If a.playState = 3 Then
                a.controls.stop()
                a.URL = globals.app("dir") + list(opt)
                a.controls.play()
            End If
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim st, mt As String
        Dim s As Integer = Integer.Parse(lbTime.Text.Substring(3))
        Dim m As Integer = Integer.Parse(lbTime.Text.Substring(0, 2))

        If s = 0 And m = 0 Then
            a.controls.stop()
        Else
            s -= 1
            If s < 0 Then
                m -= 1
                s = 59
            End If
        End If

        If s < 10 Then
            st = "0" + s.ToString
        Else
            st = s.ToString
        End If

        If m < 10 Then
            mt = "0" + m.ToString
        Else
            mt = m.ToString
        End If

        lbTime.Text = mt + ":" + st

        If lbTime.Text = "00:00" Then
            nextTheme()
        End If
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        If a.playState = 2 Then
            a.controls.currentPosition = a.controls.currentPosition()
            a.controls.play()
            Timer.Start()
        Else
            a.controls.pause()
            Timer.Stop()
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        a.controls.stop()
        Timer.Stop()
        Dim w As New WindowsMediaPlayer
        Dim m As IWMPMedia = w.newMedia(globals.app("dir") + list(opt))
        If m IsNot Nothing Then
            lbTime.Text = m.durationString
        End If
    End Sub

    Private Sub btnVol0_Click(sender As Object, e As EventArgs) Handles btnVol0.Click
        a.settings.volume = 0
        btnVol0.BackColor = Color.Gray
        btnVol1.BackColor = Color.LightGray
        btnVol2.BackColor = Color.LightGray
        btnVol3.BackColor = Color.LightGray
        btnVol4.BackColor = Color.LightGray
        btnVol5.BackColor = Color.LightGray
        btnVol6.BackColor = Color.LightGray
        btnVol7.BackColor = Color.LightGray
        btnVol8.BackColor = Color.LightGray
        btnVol9.BackColor = Color.LightGray
        btnVol10.BackColor = Color.LightGray
    End Sub

    Private Sub btnVol1_Click(sender As Object, e As EventArgs) Handles btnVol1.Click
        a.settings.volume = 10
        btnVol0.BackColor = Color.Gray
        btnVol1.BackColor = Color.Gray
        btnVol2.BackColor = Color.LightGray
        btnVol3.BackColor = Color.LightGray
        btnVol4.BackColor = Color.LightGray
        btnVol5.BackColor = Color.LightGray
        btnVol6.BackColor = Color.LightGray
        btnVol7.BackColor = Color.LightGray
        btnVol8.BackColor = Color.LightGray
        btnVol9.BackColor = Color.LightGray
        btnVol10.BackColor = Color.LightGray
    End Sub

    Private Sub btnVol2_Click(sender As Object, e As EventArgs) Handles btnVol2.Click
        a.settings.volume = 20
        btnVol0.BackColor = Color.Gray
        btnVol1.BackColor = Color.Gray
        btnVol2.BackColor = Color.Gray
        btnVol3.BackColor = Color.LightGray
        btnVol4.BackColor = Color.LightGray
        btnVol5.BackColor = Color.LightGray
        btnVol6.BackColor = Color.LightGray
        btnVol7.BackColor = Color.LightGray
        btnVol8.BackColor = Color.LightGray
        btnVol9.BackColor = Color.LightGray
        btnVol10.BackColor = Color.LightGray
    End Sub

    Private Sub btnVol3_Click(sender As Object, e As EventArgs) Handles btnVol3.Click
        a.settings.volume = 30
        btnVol0.BackColor = Color.Gray
        btnVol1.BackColor = Color.Gray
        btnVol2.BackColor = Color.Gray
        btnVol3.BackColor = Color.Gray
        btnVol4.BackColor = Color.LightGray
        btnVol5.BackColor = Color.LightGray
        btnVol6.BackColor = Color.LightGray
        btnVol7.BackColor = Color.LightGray
        btnVol8.BackColor = Color.LightGray
        btnVol9.BackColor = Color.LightGray
        btnVol10.BackColor = Color.LightGray
    End Sub
    Private Sub btnVol4_Click(sender As Object, e As EventArgs) Handles btnVol4.Click
        a.settings.volume = 40
        btnVol0.BackColor = Color.Gray
        btnVol1.BackColor = Color.Gray
        btnVol2.BackColor = Color.Gray
        btnVol3.BackColor = Color.Gray
        btnVol4.BackColor = Color.Gray
        btnVol5.BackColor = Color.LightGray
        btnVol6.BackColor = Color.LightGray
        btnVol7.BackColor = Color.LightGray
        btnVol8.BackColor = Color.LightGray
        btnVol9.BackColor = Color.LightGray
        btnVol10.BackColor = Color.LightGray
    End Sub
    Private Sub btnVol5_Click(sender As Object, e As EventArgs) Handles btnVol5.Click
        a.settings.volume = 50
        btnVol0.BackColor = Color.Gray
        btnVol1.BackColor = Color.Gray
        btnVol2.BackColor = Color.Gray
        btnVol3.BackColor = Color.Gray
        btnVol4.BackColor = Color.Gray
        btnVol5.BackColor = Color.Gray
        btnVol6.BackColor = Color.LightGray
        btnVol7.BackColor = Color.LightGray
        btnVol8.BackColor = Color.LightGray
        btnVol9.BackColor = Color.LightGray
        btnVol10.BackColor = Color.LightGray
    End Sub
    Private Sub btnVol6_Click(sender As Object, e As EventArgs) Handles btnVol6.Click
        a.settings.volume = 60
        btnVol0.BackColor = Color.Gray
        btnVol1.BackColor = Color.Gray
        btnVol2.BackColor = Color.Gray
        btnVol3.BackColor = Color.Gray
        btnVol4.BackColor = Color.Gray
        btnVol5.BackColor = Color.Gray
        btnVol6.BackColor = Color.Gray
        btnVol7.BackColor = Color.LightGray
        btnVol8.BackColor = Color.LightGray
        btnVol9.BackColor = Color.LightGray
        btnVol10.BackColor = Color.LightGray
    End Sub
    Private Sub btnVol7_Click(sender As Object, e As EventArgs) Handles btnVol7.Click
        a.settings.volume = 70
        btnVol0.BackColor = Color.Gray
        btnVol1.BackColor = Color.Gray
        btnVol2.BackColor = Color.Gray
        btnVol3.BackColor = Color.Gray
        btnVol4.BackColor = Color.Gray
        btnVol5.BackColor = Color.Gray
        btnVol6.BackColor = Color.Gray
        btnVol7.BackColor = Color.Gray
        btnVol8.BackColor = Color.LightGray
        btnVol9.BackColor = Color.LightGray
        btnVol10.BackColor = Color.LightGray
    End Sub
    Private Sub btnVol8_Click(sender As Object, e As EventArgs) Handles btnVol8.Click
        a.settings.volume = 80
        btnVol0.BackColor = Color.Gray
        btnVol1.BackColor = Color.Gray
        btnVol2.BackColor = Color.Gray
        btnVol3.BackColor = Color.Gray
        btnVol4.BackColor = Color.Gray
        btnVol5.BackColor = Color.Gray
        btnVol6.BackColor = Color.Gray
        btnVol7.BackColor = Color.Gray
        btnVol8.BackColor = Color.Gray
        btnVol9.BackColor = Color.LightGray
        btnVol10.BackColor = Color.LightGray
    End Sub
    Private Sub btnVol9_Click(sender As Object, e As EventArgs) Handles btnVol9.Click
        a.settings.volume = 90
        btnVol0.BackColor = Color.Gray
        btnVol1.BackColor = Color.Gray
        btnVol2.BackColor = Color.Gray
        btnVol3.BackColor = Color.Gray
        btnVol4.BackColor = Color.Gray
        btnVol5.BackColor = Color.Gray
        btnVol6.BackColor = Color.Gray
        btnVol7.BackColor = Color.Gray
        btnVol8.BackColor = Color.Gray
        btnVol9.BackColor = Color.Gray
        btnVol10.BackColor = Color.LightGray
    End Sub
    Private Sub btnVol10_Click(sender As Object, e As EventArgs) Handles btnVol10.Click
        a.settings.volume = 100
        btnVol0.BackColor = Color.Gray
        btnVol1.BackColor = Color.Gray
        btnVol2.BackColor = Color.Gray
        btnVol3.BackColor = Color.Gray
        btnVol4.BackColor = Color.Gray
        btnVol5.BackColor = Color.Gray
        btnVol6.BackColor = Color.Gray
        btnVol7.BackColor = Color.Gray
        btnVol8.BackColor = Color.Gray
        btnVol9.BackColor = Color.Gray
        btnVol10.BackColor = Color.Gray
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dim f As New More
        f.ShowDialog()
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub chkRepeat_CheckedChanged(sender As Object, e As EventArgs) Handles chkRepeat.CheckedChanged
        If chkRepeat.Checked = True Then
            chkShuffle.Checked = False
        End If
        globals.app("order") = "repeat"
    End Sub

    Private Sub chkShuffle_CheckedChanged(sender As Object, e As EventArgs) Handles chkShuffle.CheckedChanged
        If chkShuffle.Checked = True Then
            chkRepeat.Checked = False
        End If
        globals.app("order") = "shuffle"
    End Sub
End Class
