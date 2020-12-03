Public Class format_3
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        format_4.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.Show()
        Me.Hide()
    End Sub

    Private Sub format_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub format_3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class