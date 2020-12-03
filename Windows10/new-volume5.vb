Public Class new_volume5
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        new_volume6.show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main.Show()

    End Sub

    Private Sub new_volume5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub new_volume5_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class