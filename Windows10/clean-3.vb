Public Class clean_3
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        clean_4.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main.Show()

    End Sub

    Private Sub clean_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub clean_3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        clean_4.Show()
        Me.Hide()
    End Sub
End Class