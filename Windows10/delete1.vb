Public Class delete1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        new_volume.Show()


    End Sub

    Private Sub delete1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub delete1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class