Public Class apps_3
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MsgBox("تم حذف البرنامج!")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main.Show()
    End Sub

    Private Sub apps_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(700, 500)
    End Sub

    Private Sub apps_3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class