Public Class update_1


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        update_2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Me.Hide()
        main.Show()


    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        MessageBox.Show("هذا الامر لاعادة تشغيل الحاسوب")
    End Sub

    Private Sub PowerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PowerToolStripMenuItem.Click
        MessageBox.Show("هذا الامر لاطفاء الحاسوب")
    End Sub

    Private Sub update_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub update_1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub
End Class