Public Class appstest_2


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        apps_3.Show()
        me.hide()
    End Sub

    Private Sub appstest_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub appstest_2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class