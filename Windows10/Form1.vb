Public Class Form1
    Dim oDragPoint As Point = Nothing
    Dim oCurrentPictureBox As PictureBox = Nothing
    Dim myPanel As Panel = Nothing
    Dim txtBox As TextBox = Nothing


    Dim PictureBoxCounter As Integer = 0
    Dim selectedPictureBox As PictureBox = Nothing
    Dim selectedTxtBox As TextBox = Nothing
    Dim disableTexBoxes As Boolean = True

    Private Sub AddPicture()

        PictureBoxCounter = PictureBoxCounter + 1
        oCurrentPictureBox = New PictureBox
        myPanel = New Panel
        txtBox = New TextBox


        'myPanel.Name = "panel" + PictureBoxCounter.ToString
        'myPanel.Location = Me.PointToClient(Windows.Forms.Cursor.Position)
        ''myPanel.Location = New System.Drawing.Point(500, 200)

        'myPanel.Width = 100
        'myPanel.Height = 150
        'myPanel.BackColor = Color.Gray



        'Me.Controls.Add(myPanel)


        oCurrentPictureBox.Name = PictureBoxCounter.ToString
        oCurrentPictureBox.Image = Image.FromFile("c:\users\sa\desktop\70.png")
        oCurrentPictureBox.Location = Me.PointToClient(Windows.Forms.Cursor.Position)
        'oCurrentPictureBox.Location = New System.Drawing.Point(myPanel.Location.Y, myPanel.Location.X)

        oCurrentPictureBox.Width = 60
        oCurrentPictureBox.Height = 60
        oCurrentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        oCurrentPictureBox.ContextMenuStrip = ContextMenuStrip1
        oCurrentPictureBox.BackColor = Color.Transparent


        oCurrentPictureBox.BringToFront()
        Me.Controls.Add(oCurrentPictureBox)




        txtBox.Name = "txtbox" + PictureBoxCounter.ToString
        txtBox.Text = "new folder" + PictureBoxCounter.ToString
        txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        txtBox.BackColor = System.Drawing.Color.White
        'txtBox.Location = Me.PointToClient(Windows.Forms.Cursor.Position)
        txtBox.Location = New System.Drawing.Point(oCurrentPictureBox.Location.X - 10 + 100, oCurrentPictureBox.Location.Y + 500)


        txtBox.MaximumSize = New System.Drawing.Size(120, 40)
        Me.Controls.Add(txtBox)







        'Add picturebox and txtBox to panel

        'myPanel.Controls.Add(oCurrentPictureBox)
        'myPanel.Controls.Add(txtBox)





        ' Add events to the new picturebox we just created so that it can be moved again later
        AddHandler oCurrentPictureBox.MouseDown, AddressOf Event_MouseDown
        AddHandler oCurrentPictureBox.MouseMove, AddressOf Event_MouseMove
        AddHandler oCurrentPictureBox.MouseUp, AddressOf Event_MouseUp




        ' Add picturebox and panel  to form
        'Me.Controls.Add(myPanel)



    End Sub


    Private Sub Event_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If TypeOf sender Is PictureBox Then
            ' Move existing picturebox
            oCurrentPictureBox = sender
            txtBox = Me.Controls.Item("txtbox" + oCurrentPictureBox.Name)
            If e.Button = MouseButtons.Right Then
                'MessageBox.Show(oCurrentPictureBox.Name)
                selectedPictureBox = oCurrentPictureBox
                selectedTxtBox = Me.Controls.Item("txtbox" + PictureBoxCounter.ToString)
            End If


            oDragPoint = New Point(e.X, e.Y)



            'oCurrentPictureBox.BringToFront()
            'oDragPoint = New Point(e.X, e.Y)
        Else
            ' Create a new picturebox
            'oCurrentPictureBox = New PictureBox

            'oCurrentPictureBox.Image = Image.FromFile("c:\users\sa\desktop\70.png")
            'oCurrentPictureBox.Location = Me.PointToClient(Windows.Forms.Cursor.Position)
            'oCurrentPictureBox.Width = 70
            'oCurrentPictureBox.Height = 70
            'oCurrentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            'oCurrentPictureBox.ContextMenuStrip = ContextMenuStrip1



            ' Add events to the new picturebox we just created so that it can be moved again later
            'AddHandler oCurrentPictureBox.MouseDown, AddressOf Event_MouseDown
            'AddHandler oCurrentPictureBox.MouseMove, AddressOf Event_MouseMove
            'AddHandler oCurrentPictureBox.MouseUp, AddressOf Event_MouseUp





            '' Add picturebox to form
            'Me.Controls.Add(oCurrentPictureBox)

            ' Bring picturebox to front after it has been added to the form to ensure it is on top of all other controls in the controls collection
            'oCurrentPictureBox.BringToFront()
        End If
    End Sub

    Private Sub Event_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If oCurrentPictureBox IsNot Nothing Then
            ' Move picture box wherever the mouse moves
            Dim oMouseCursorPoint As Point = Me.PointToClient(Windows.Forms.Cursor.Position)
            oCurrentPictureBox.Location = New Point(oMouseCursorPoint.X - oDragPoint.X, oMouseCursorPoint.Y - oDragPoint.Y)
            txtBox.Location = New Point(oMouseCursorPoint.X - oDragPoint.X - 10, oMouseCursorPoint.Y - oDragPoint.Y + 69)
        End If
    End Sub

    Private Sub Event_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        '' Drop picturebox and stop moving it around
        oCurrentPictureBox = Nothing
        txtBox = Nothing
        oDragPoint = Nothing
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        selectedPictureBox.Dispose()
        selectedTxtBox.Dispose()





    End Sub

    Private Sub NewPictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPictureToolStripMenuItem.Click
        AddPicture()
    End Sub






    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim txtBox As Control
        For Each txtBox In Me.Controls
            If (txtBox.GetType() Is GetType(TextBox)) Then
                txtBox.Enabled = False
            End If
        Next
    End Sub





    Private Sub RenameToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem1.Click
        MessageBox.Show("rename is ok")
        'TextBox1.Enabled = True
        'TextBox1.Select()
        selectedTxtBox.Enabled = True
        selectedTxtBox.Select()
        'selectedTxtBox.Dispose()
    End Sub
End Class