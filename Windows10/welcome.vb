Imports System.ComponentModel

Public Class welcome

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        main.Show()
        Me.Hide()
    End Sub

    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load








    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub welcome_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub welcome_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        'MessageBox.Show("closing")
        Application.Exit()
    End Sub
End Class