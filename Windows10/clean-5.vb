Public Class clean_5
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MessageBox.Show("تم الانتهاء ")
        Me.Hide()
        main.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main.Show()

    End Sub

    Private Sub clean_5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub clean_5_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class