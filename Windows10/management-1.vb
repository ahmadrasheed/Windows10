Public Class management_1
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        partitions.Show()




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main.Show()

    End Sub

    Private Sub management_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class