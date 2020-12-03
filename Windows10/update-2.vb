Public Class update_2
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        update_3.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        appstest_2.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        storage_1.Show()
        me.hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        me.hide()
        main.Show()

    End Sub

    Private Sub update_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub update_2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class