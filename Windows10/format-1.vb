Public Class format_1


    Private Sub FormatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatToolStripMenuItem.Click

        format_2.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("fuck")

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.Show()
        Me.Hide()
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click
        defragment_1.Show()
        Me.Hide()

    End Sub

    Private Sub format_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub format_1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class