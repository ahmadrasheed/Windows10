Imports System.ComponentModel

Public Class computer_properties
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        me.hide()
        main.Show()

    End Sub

    Private Sub computer_properties_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub computer_properties_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed



    End Sub

    Private Sub computer_properties_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub computer_properties_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class