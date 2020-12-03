Public Class clean_1
    Private Sub clean_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text = "disk cleanup" Then

            clean_2.Show()
            Me.Hide()

        End If



    End Sub

    Private Sub clean_1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main.Show()
    End Sub
End Class