Public Class format_4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.Show()
        Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        format_1.Show()
        Me.Hide()
    End Sub

    Private Sub format_4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub format_4_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class