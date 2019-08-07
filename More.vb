Public Class More
    Private Sub More_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbVersion.Text = "Versión: " + app("version")
        lstOptions.Items.Add("Configuración")
        lstOptions.Items.Add("Acerca de n.core")
        lstOptions.SelectedIndex = 0
        txtDir.Text = globals.app("dir")

        For Each control As RadioButton In gbColorChange.Controls
            If globals.app("color") = control.Tag Then
                control.Checked = True
            End If
        Next
        If globals.app("tray") = "visible" Then
            chkIcon.Checked = True
        End If
    End Sub

    Private Sub lstOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOptions.SelectedIndexChanged
        If lstOptions.SelectedIndex = 0 Then
            gbAbout.Visible = False
            gbConfig.Visible = True
        End If
        If lstOptions.SelectedIndex = 1 Then
            gbAbout.Visible = True
            gbConfig.Visible = False
        End If
    End Sub

    Private Sub btnDir_Click(sender As Object, e As EventArgs) Handles btnDir.Click
        If FolderBrowserDialog.ShowDialog() = DialogResult.OK Then
            txtDir.Text = FolderBrowserDialog.SelectedPath + "\"
        End If
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        If txtDir.Text IsNot "" Then
            globals.app("dir") = txtDir.Text
        End If
        For Each control As RadioButton In gbColorChange.Controls
            If control.Checked = True Then
                globals.app("color") = control.Tag
            End If
        Next
        If chkIcon.Checked = True Then
            globals.app("tray") = "visible"
        Else
            globals.app("tray") = "hidden"
        End If
        Main.RefreshMain()
        Me.Close()
    End Sub

    Private Sub lbLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbLink.LinkClicked
        System.Diagnostics.Process.Start("www.orbescarlos.com.ar")
    End Sub
End Class