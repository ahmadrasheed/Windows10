Public Class new_volume
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub NewSimpleVolumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSimpleVolumeToolStripMenuItem.Click
        Me.Hide()
        new_volume1.Show()
    End Sub

    Private Sub NewSpannedVolumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSpannedVolumeToolStripMenuItem.Click
        MessageBox.Show("ليس في هذا الدرس")
    End Sub

    Private Sub NewStripedVolumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStripedVolumeToolStripMenuItem.Click
        MessageBox.Show("ليس في هذا الدرس")
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("ليس في هذا الدرس")
    End Sub

    Private Sub new_volume_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub new_volume_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class