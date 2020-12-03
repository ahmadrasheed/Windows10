Public Class storage_1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        storage_2.show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main.Show()
    End Sub

    Private Sub storage_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub storage_1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class