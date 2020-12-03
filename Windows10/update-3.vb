Public Class update_3




    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MessageBox.Show("عند وجود انترنت سيتم البحث عن تحديث!")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main.Show()
    End Sub

    Private Sub update_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub update_3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class