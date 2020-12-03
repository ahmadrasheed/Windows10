Public Class format_2
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        format_3.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.Show()
        Me.Hide()
    End Sub

    Private Sub format_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub format_2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class