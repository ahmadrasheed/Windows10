Public Class defragment_2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main.Show()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MessageBox.Show("سيتم الغاء تجزئة هذا التقسيم")
    End Sub

    Private Sub defragment_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub defragment_2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class