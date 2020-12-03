Public Class storage_2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main.Show()

    End Sub

    Private Sub storage_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub storage_2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class