Public Class partitions
    Private Sub DeleteVolumesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteVolumesToolStripMenuItem.Click
        Me.Hide()
        delete1.show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        MessageBox.Show("ليس في هذا الدرس")
    End Sub

    Private Sub ChangeDriveLetterAndPathesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeDriveLetterAndPathesToolStripMenuItem.Click
        MessageBox.Show("ليس في هذا الدرس")
    End Sub

    Private Sub FormatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatToolStripMenuItem.Click
        MessageBox.Show("ليس في هذا الدرس")
    End Sub

    Private Sub partitions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub partitions_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class