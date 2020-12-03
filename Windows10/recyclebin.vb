Public Class recyclebin
    Dim xx As Integer = 130
    Dim yy As Integer = 160
    Dim OrginalPoint As Point = Nothing
    Public oDragPoint As Point = Nothing
    Public oCurrentPictureBox As PictureBox = Nothing
    Dim myPanel As Panel = Nothing
    Public txtBox As TextBox = Nothing

    Public Dragabble As Boolean = True
    Dim show As Boolean = True

    Dim PictureBoxCounter As Integer = 0
    Dim selectedPictureBox As PictureBox = Nothing
    Dim selectedTxtBox As TextBox = Nothing
    Dim disableTexBoxes As Boolean = True

    Dim customsize As Integer = 50

    Dim myDict As New Dictionary(Of String, Point)
    Dim mylist As List(Of String)
    Dim k As Integer = 0
    Public Sub AddDeletedPicture(type As String, name As String, myPoint As Point)

        Dragabble = False
        OrginalPoint = myPoint
        PictureBoxCounter = PictureBoxCounter + 1
        oCurrentPictureBox = New PictureBox

        txtBox = New TextBox

        oCurrentPictureBox.Name = type + PictureBoxCounter.ToString
        'MessageBox.Show(name)


        'oCurrentPictureBox.Location = Me.PointToClient(Windows.Forms.Cursor.Position)
        If (yy < 1350) Then
            oCurrentPictureBox.Location = New System.Drawing.Point(xx, yy)
            yy = yy + 65
        Else
            oCurrentPictureBox.Location = New System.Drawing.Point(xx, yy)
            yy = 130
            xx = xx + 70
        End If
        'oCurrentPictureBox.Location = New System.Drawing.Point(myPanel.Location.Y, myPanel.Location.X)

        oCurrentPictureBox.Size = New System.Drawing.Size(customsize, customsize)
        oCurrentPictureBox.MaximumSize = New System.Drawing.Size(150, 150)
        oCurrentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        oCurrentPictureBox.ContextMenuStrip = ContextMenuStrip1
        oCurrentPictureBox.BackColor = Color.Transparent

        txtBox.Name = "txtbox" + oCurrentPictureBox.Name.ToString
        'txtBox.Text = name + PictureBoxCounter.ToString
        txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        txtBox.BackColor = System.Drawing.Color.White
        'txtBox.Location = Me.PointToClient(Windows.Forms.Cursor.Position)
        'txtBox.Location = New System.Drawing.Point(oCurrentPictureBox.Location.X - 10 + 100, oCurrentPictureBox.Location.Y + 500 + customsize)
        txtBox.Location = New System.Drawing.Point(oCurrentPictureBox.Location.X, oCurrentPictureBox.Location.Y + customsize)
        txtBox.Width = 60
        txtBox.MaximumSize = New System.Drawing.Size(75, 40)
        txtBox.ForeColor = Color.Black


        Select Case True
            Case type.Contains("folder")
                'MessageBox.Show("here in folder")
                oCurrentPictureBox.Image = My.Resources._70
                txtBox.Text = name + PictureBoxCounter.ToString
            Case type.Contains("txt")
                'MessageBox.Show("here in txt")
                oCurrentPictureBox.Image = My.Resources.TXT
                txtBox.Text = name + PictureBoxCounter.ToString
            Case type.Contains("word2016")
                'MessageBox.Show("here in folder")
                oCurrentPictureBox.Image = My.Resources.word2016
                txtBox.Text = name + PictureBoxCounter.ToString
            Case type.Contains("powerpoint")
                'MessageBox.Show("here in txt")
                oCurrentPictureBox.Image = My.Resources.powerpoint
                txtBox.Text = name + PictureBoxCounter.ToString
            Case type.StartsWith("winzip")
                oCurrentPictureBox.Image = My.Resources.winzip
                txtBox.Text = name + PictureBoxCounter.ToString
            Case type.StartsWith("winrar")
                oCurrentPictureBox.Image = My.Resources.winRAR
                txtBox.Text = name + PictureBoxCounter.ToString
            Case Else
                MessageBox.Show("here else")
                oCurrentPictureBox.Image = My.Resources.winzip
                txtBox.Text = name + PictureBoxCounter.ToString
        End Select
        'Cursor.Position = New Drawing.Point(Cursor.Position.X + 30, Cursor.Position.Y)


        ' Add events to the new picturebox we just created so that it can be moved again later
        AddHandler oCurrentPictureBox.MouseDown, AddressOf Event_MouseDown
        'AddHandler oCurrentPictureBox.MouseMove, AddressOf Event_MouseMove
        'AddHandler oCurrentPictureBox.MouseUp, AddressOf Event_MouseUp
        'AddHandler txtBox.LostFocus, AddressOf Event_LostFocus

        Me.Controls.Add(oCurrentPictureBox)
        Me.Controls.Add(txtBox)






    End Sub
    Private Sub Event_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If TypeOf sender Is PictureBox Then
            'Cursor.Position = New Drawing.Point(Cursor.Position.X - 100, Cursor.Position.Y)
            selectedPictureBox = sender
            selectedTxtBox = Me.Controls.Item("txtbox" + sender.Name.ToString)

            'oCurrentPictureBox.BringToFront()

            If e.Button = MouseButtons.Left Then

                ' Move existing picturebox
                oCurrentPictureBox = sender
                oCurrentPictureBox.BorderStyle = BorderStyle.FixedSingle
                txtBox = Me.Controls.Item("txtbox" + oCurrentPictureBox.Name)
                oDragPoint = New Point(e.X, e.Y)

            End If




            If e.Button = MouseButtons.Right Then

                'MessageBox.Show(oCurrentPictureBox.Name)
                selectedPictureBox = sender
                selectedTxtBox = Me.Controls.Item("txtbox" + sender.Name.ToString)
            End If



            ' Bring picturebox to front after it has been added to the form to ensure it is on top of all other controls in the controls collection

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        main.Show()

    End Sub

    Private Sub recyclebin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub recyclebin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        Dim pt As String
        Dim t As String

        pt = selectedPictureBox.Name.ToString
        t = selectedTxtBox.Text.ToString
        'MessageBox.Show(pt)
        Dim result As Integer = MessageBox.Show("Are you sure you want to permanently delete this file?", "حذف الملف", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then
            'MessageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            'MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then

            Me.selectedPictureBox.Dispose()
            Me.selectedTxtBox.Dispose()
            oDragPoint = Nothing

            OrginalPoint = Nothing

            selectedPictureBox.Dispose()
            selectedTxtBox.Dispose()
        End If
    End Sub

    Private Sub RestoeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoeToolStripMenuItem.Click

        main.RestorePicture(selectedPictureBox.Name, selectedTxtBox.Text, OrginalPoint, True)
        'selectedPictureBox.Location = OrginalPoint
        'selectedTxtBox.Location = New Point(OrginalPoint.X, OrginalPoint.Y + selectedPictureBox.Height)
        'main.Controls.Add(selectedPictureBox)
        'main.Controls.Add(selectedTxtBox)
        'selectedPictureBox.ContextMenuStrip = main.ContextMenuStrip2
        'Add events to the new picturebox we just created so that it can be moved again later
        'AddHandler oCurrentPictureBox.MouseDown, AddressOf main.Event_MouseDown
        'AddHandler oCurrentPictureBox.MouseMove, AddressOf main.Event_MouseMove
        'AddHandler oCurrentPictureBox.MouseUp, AddressOf main.Event_MouseUp
        'AddHandler txtBox.LostFocus, AddressOf main.Event_LostFocus
        yy = yy - 65

        Me.selectedPictureBox.Dispose()
        Me.selectedTxtBox.Dispose()
        oDragPoint = Nothing

        selectedTxtBox = Nothing
        selectedTxtBox = Nothing
        OrginalPoint = Nothing




    End Sub
End Class