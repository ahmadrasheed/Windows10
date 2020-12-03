Public Class main

    Public oDragPoint As Point = Nothing
    Public oCurrentPictureBox As PictureBox = Nothing
    Public restoredPictureBox As PictureBox = Nothing
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

    Private Sub listPrint()
        mylist = myDict.Keys.ToList

        mylist.Sort()
        For Each m In mylist
            'MessageBox.Show(m + " " + myDict.Item(m).ToString)
            Console.WriteLine("{0} -> {1}", m, myDict.Item(m))
            'RichTextBox1.AppendText(m + " " + myDict.Item(m).ToString)
        Next
        'RichTextBox1.AppendText("=========== /n  " + myDict.Count.ToString)
    End Sub
    Private Sub arrangeIcons()
        Dim mylistlocation As New List(Of Point)
        mylistlocation = myDict.Values.ToList

        mylist = myDict.Keys.ToList
        mylist.Sort()


        Dim pic As Control
        Dim tbox As TextBox


        For Each pic In Me.Controls
            Dim s = mylist.Item(k).ToString
            MessageBox.Show(s)
            'pic.Location = myDict.Item(s)
            If (pic.GetType() Is GetType(PictureBox)) Then

                'pic.Location = myDict(mylist.Item(k).ToString)

                'pic.Location = New System.Drawing.Point(pic.Location.X, pic.Location.Y + customsize)



                tbox = Me.Controls.Item("txtbox" + pic.Name.ToString)
                tbox.Location = New System.Drawing.Point(pic.Location.X, pic.Location.Y + pic.Height)
            End If
            k = k + 1

        Next
        k = 0
    End Sub
    Private Sub saveLocation()
        'myDict.Add("Ali", New Point(100, 101))
        'myDict.Add("zena", New Point(200, 201))
        'myDict.Add("basim", New Point(400, 401))
        'myDict.Add("dear", New Point())


        'For Each m In mylist
        '    Console.WriteLine("{0} -> {1}", m, myDict.Item(m))
        'Next

        Dim pic As Control
        For Each pic In Me.Controls
            If (pic.GetType() Is GetType(PictureBox)) Then

                If (Not myDict.ContainsKey(pic.Name)) Then
                    myDict.Add(pic.Name, pic.Location)
                End If

            End If
        Next


    End Sub
    Private Sub sortby()

    End Sub




    Public Sub AddPicture(type As String, name As String, Optional myPoint As Point = Nothing, Optional restore As Boolean = False)

        Dragabble = False

        PictureBoxCounter = PictureBoxCounter + 1
        oCurrentPictureBox = New PictureBox

        txtBox = New TextBox

        oCurrentPictureBox.Name = type + PictureBoxCounter.ToString
        'MessageBox.Show(name)

        'oCurrentPictureBox.Location = Me.PointToClient(Windows.Forms.Cursor.Position)
        If (Not myPoint.IsEmpty) Then
            oCurrentPictureBox.Location = New System.Drawing.Point(myPoint.X, myPoint.Y)

        Else
            oCurrentPictureBox.Location = New System.Drawing.Point(50, 100)
        End If
        'oCurrentPictureBox.Location = New System.Drawing.Point(myPanel.Location.Y, myPanel.Location.X)

        oCurrentPictureBox.Size = New System.Drawing.Size(customsize, customsize)
        oCurrentPictureBox.MaximumSize = New System.Drawing.Size(150, 150)
        oCurrentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        oCurrentPictureBox.ContextMenuStrip = ContextMenuStrip2
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

        Me.Controls.Add(oCurrentPictureBox)
        Me.Controls.Add(txtBox)

        If Not restore Then

            ' Add events to the new picturebox we just created so that it can be moved again later
            AddHandler oCurrentPictureBox.MouseDown, AddressOf Event_MouseDown
            AddHandler oCurrentPictureBox.MouseMove, AddressOf Event_MouseMove
            AddHandler oCurrentPictureBox.MouseUp, AddressOf Event_MouseUp
            AddHandler txtBox.LostFocus, AddressOf Event_LostFocus
        End If






        Dragabble = False


        'saveLocation()


    End Sub
    Public Sub RestorePicture(type As String, name As String, Optional myPoint As Point = Nothing, Optional restore As Boolean = False)

        Dragabble = False

        PictureBoxCounter = PictureBoxCounter + 1
        restoredPictureBox = New PictureBox

        txtBox = New TextBox

        restoredPictureBox.Name = type + PictureBoxCounter.ToString
        'MessageBox.Show(name)

        'restoredPictureBox.Location = Me.PointToClient(Windows.Forms.Cursor.Position)
        If (Not myPoint.IsEmpty) Then
            restoredPictureBox.Location = New System.Drawing.Point(myPoint.X, myPoint.Y)

        Else
            restoredPictureBox.Location = New System.Drawing.Point(50, 100)
        End If
        'restoredPictureBox.Location = New System.Drawing.Point(myPanel.Location.Y, myPanel.Location.X)

        restoredPictureBox.Size = New System.Drawing.Size(customsize, customsize)
        restoredPictureBox.MaximumSize = New System.Drawing.Size(150, 150)
        restoredPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        restoredPictureBox.ContextMenuStrip = ContextMenuStrip2
        restoredPictureBox.BackColor = Color.Transparent

        txtBox.Name = "txtbox" + restoredPictureBox.Name.ToString
        'txtBox.Text = name + PictureBoxCounter.ToString
        txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        txtBox.BackColor = System.Drawing.Color.White
        'txtBox.Location = Me.PointToClient(Windows.Forms.Cursor.Position)
        'txtBox.Location = New System.Drawing.Point(restoredPictureBox.Location.X - 10 + 100, restoredPictureBox.Location.Y + 500 + customsize)
        txtBox.Location = New System.Drawing.Point(restoredPictureBox.Location.X, restoredPictureBox.Location.Y + customsize)
        txtBox.Width = 60
        txtBox.MaximumSize = New System.Drawing.Size(75, 40)
        txtBox.ForeColor = Color.Black


        Select Case True
            Case type.Contains("folder")
                'MessageBox.Show("here in folder")
                restoredPictureBox.Image = My.Resources._70
                txtBox.Text = name + PictureBoxCounter.ToString
            Case type.Contains("txt")
                'MessageBox.Show("here in txt")
                restoredPictureBox.Image = My.Resources.TXT
                txtBox.Text = name + PictureBoxCounter.ToString
            Case type.Contains("word2016")
                'MessageBox.Show("here in folder")
                restoredPictureBox.Image = My.Resources.word2016
                txtBox.Text = name + PictureBoxCounter.ToString
            Case type.Contains("powerpoint")
                'MessageBox.Show("here in txt")
                restoredPictureBox.Image = My.Resources.powerpoint
                txtBox.Text = name + PictureBoxCounter.ToString
            Case type.StartsWith("winzip")
                restoredPictureBox.Image = My.Resources.winzip
                txtBox.Text = name + PictureBoxCounter.ToString
            Case type.StartsWith("winrar")
                restoredPictureBox.Image = My.Resources.winRAR
                txtBox.Text = name + PictureBoxCounter.ToString
            Case Else
                MessageBox.Show("here else")
                restoredPictureBox.Image = My.Resources.winzip
                txtBox.Text = name + PictureBoxCounter.ToString
        End Select
        'Cursor.Position = New Drawing.Point(Cursor.Position.X + 30, Cursor.Position.Y)

        Me.Controls.Add(restoredPictureBox)
        Me.Controls.Add(txtBox)

        'If Not restore Then

        '    ' Add events to the new picturebox we just created so that it can be moved again later
        '    AddHandler restoredPictureBox.MouseDown, AddressOf Event_MouseDown
        '    AddHandler restoredPictureBox.MouseMove, AddressOf Event_MouseMove
        '    AddHandler restoredPictureBox.MouseUp, AddressOf Event_MouseUp
        '    AddHandler txtBox.LostFocus, AddressOf Event_LostFocus
        'End If






        Dragabble = False


        'saveLocation()


    End Sub

    '
    'the following for events 

    Public Sub Event_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        If TypeOf sender Is TextBox Then
            Dim t As TextBox = sender
            If t.Text = "" Then
                t.Text = "new folder" + PictureBoxCounter.ToString
            End If
        End If
    End Sub

    Public Sub Event_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown




        If Dragabble = True Then

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
        End If
        Dragabble = True

    End Sub

    Public Sub Event_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If oCurrentPictureBox IsNot Nothing Then
            ' Move picture box wherever the mouse moves
            Dim oMouseCursorPoint As Point = Me.PointToClient(Windows.Forms.Cursor.Position)
            oCurrentPictureBox.Location = New Point(oMouseCursorPoint.X - oDragPoint.X - 5, oMouseCursorPoint.Y - oDragPoint.Y)
            'txtBox.Location = New Point(oMouseCursorPoint.X - oDragPoint.X, oMouseCursorPoint.Y - oDragPoint.Y + 53 + customsize)
            txtBox.Location = New System.Drawing.Point(oCurrentPictureBox.Location.X - 5, oCurrentPictureBox.Location.Y + oCurrentPictureBox.Height)




        End If
    End Sub

    Public Sub Event_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        oDragPoint = Nothing
        '' Drop picturebox and stop moving it around
        If TypeOf sender Is PictureBox Then
            Cursor.Position = New Drawing.Point(Cursor.Position.X - 50, Cursor.Position.Y)

            ' Move existing picturebox
            oCurrentPictureBox = sender
            oCurrentPictureBox.BorderStyle = BorderStyle.None

            oCurrentPictureBox = Nothing

            txtBox = Nothing
            oDragPoint = Nothing

        End If
    End Sub


    Private Sub main_Click(sender As Object, e As EventArgs) Handles Me.Click

        Dragabble = True


        Dim txtBox As Control
        For Each txtBox In Me.Controls
            If (txtBox.GetType() Is GetType(TextBox)) Then
                txtBox.Enabled = False
            End If
        Next
    End Sub



    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        format_1.Show()
        Me.Hide()

    End Sub

    Private Sub FormatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatToolStripMenuItem.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        update_1.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        clean_1.Show()
        Me.Hide()

    End Sub



    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        Me.Hide()
        format_1.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Hide()
        management_1.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        MessageBox.Show("ليس ضمن الدروس")
    End Sub

    Private Sub MapNetworkDrivesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapNetworkDrivesToolStripMenuItem.Click
        MessageBox.Show("ليس ضمن الدروس")
    End Sub

    Private Sub CreateShortcutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateShortcutToolStripMenuItem.Click
        MessageBox.Show("ليس ضمن الدروس")
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click
        Me.Hide()
        computer_properties.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        about.Show()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        mynetwork.Show()


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        recyclebin.Show()

    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pic As Control
        For Each pic In Me.Controls
            If (pic.GetType() Is GetType(PictureBox)) Then

                AddHandler pic.MouseDown, AddressOf Event_MouseDown
                AddHandler pic.MouseMove, AddressOf Event_MouseMove
                AddHandler pic.MouseUp, AddressOf Event_MouseUp

            End If
        Next
    End Sub

    Private Sub main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        welcome.Close()
    End Sub

    Private Sub ContextMenuStrip3_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip3.Opening

    End Sub

    Private Sub FolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolderToolStripMenuItem.Click
        AddPicture("folder", "new folder")
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim pt As String
        Dim t As String

        pt = selectedPictureBox.Name.ToString
        t = selectedTxtBox.Text.ToString
        'MessageBox.Show(pt)
        Dim result As Integer = MessageBox.Show("Are you sure you want to move this file to the RecycleBin?", "حذف الملف", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then
            'MessageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            'MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then

            recyclebin.AddDeletedPicture(pt, t, selectedPictureBox.Location)
            Me.selectedPictureBox.Dispose()
            Me.selectedTxtBox.Dispose()
            oDragPoint = Nothing
        End If




    End Sub

    Private Sub pc2_Click(sender As Object, e As EventArgs) Handles pc2.Click
        Me.Hide()
        mynetwork.Show()
    End Sub

    Private Sub pc3_Click(sender As Object, e As EventArgs) Handles pc3.Click
        Me.Hide()
        recyclebin.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub pc1_Click(sender As Object, e As EventArgs) Handles pc1.Click
        Me.Hide()
        format_1.Show()
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        selectedTxtBox.Enabled = True
        selectedTxtBox.Select()
    End Sub

    Private Sub LargeIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LargeIconsToolStripMenuItem.Click
        changeIconsSize(80)


    End Sub

    Private Sub changeIconsSize(mySize As Integer)
        customsize = mySize
        Dim pic As Control
        Dim tbox As TextBox


        For Each pic In Me.Controls
            If (pic.GetType() Is GetType(PictureBox)) Then

                If (pic.Name.StartsWith("word2016") Or pic.Name.StartsWith("powerpoint") Or pic.Name.StartsWith("folder") Or pic.Name.StartsWith("txt") Or pic.Name.StartsWith("winzip") Or pic.Name.StartsWith("winrar")) Then


                    pic.Location = New System.Drawing.Point(pic.Location.X, pic.Location.Y + customsize)
                    pic.MaximumSize = New System.Drawing.Size(150, 150)
                    pic.Size = New System.Drawing.Size(customsize, customsize)


                    tbox = Me.Controls.Item("txtbox" + pic.Name.ToString)
                    tbox.Location = New System.Drawing.Point(pic.Location.X, pic.Location.Y + pic.Height)
                End If

            End If
        Next

        pc1.Size = New System.Drawing.Size(customsize, customsize)
        pc2.Size = New System.Drawing.Size(customsize, customsize)
        pc3.Size = New System.Drawing.Size(customsize, customsize)
        pc4.Size = New System.Drawing.Size(customsize, customsize)



        pc1.Location = New System.Drawing.Point(pc1.Location.X, pc1.Location.Y + 0)
        pc2.Location = New System.Drawing.Point(pc2.Location.X, pc1.Location.Y + customsize + 25)
        pc3.Location = New System.Drawing.Point(pc3.Location.X, pc2.Location.Y + customsize + 25)
        pc4.Location = New System.Drawing.Point(pc4.Location.X, pc3.Location.Y + customsize + 25)




        txtboxpc1.Location = New System.Drawing.Point(pc1.Location.X + 5, pc1.Location.Y + pc1.Height)
        txtboxpc2.Location = New System.Drawing.Point(pc2.Location.X + 5, pc2.Location.Y + pc2.Height)
        txtboxpc3.Location = New System.Drawing.Point(pc3.Location.X + 5, pc3.Location.Y + pc3.Height)
        txtboxpc4.Location = New System.Drawing.Point(pc4.Location.X + 5, pc4.Location.Y + pc4.Height)
    End Sub

    Private Sub MediumIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediumIconsToolStripMenuItem.Click
        changeIconsSize(60)
    End Sub

    Private Sub SmallIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmallIconsToolStripMenuItem.Click
        changeIconsSize(40)
    End Sub

    Private Sub txtboxpc4_TextChanged(sender As Object, e As EventArgs) Handles txtboxpc4.TextChanged

    End Sub

    Private Sub CopyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem1.Click
        Dim pt As String
        Dim t As String

        pt = selectedPictureBox.Name.ToString
        t = selectedTxtBox.Text.ToString
        'MessageBox.Show(pt)
        AddPicture(pt, "copy of " + t)

    End Sub

    Private Sub TextDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextDocumentToolStripMenuItem.Click
        AddPicture("txt", "New Document txt")

    End Sub

    Private Sub WinZippedFileملفمضغوطToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WinZippedFileملفمضغوطToolStripMenuItem.Click
        AddPicture("winzip", "New zipped file")
    End Sub

    Private Sub WinRarFileملفمضغوطToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WinRarFileملفمضغوطToolStripMenuItem.Click
        AddPicture("winrar", "New Winrar file")
    End Sub

    Private Sub ShortCutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShortCutToolStripMenuItem.Click
        MessageBox.Show("عمل طريق مختصر shortcut")
    End Sub

    Private Sub MicrosoftWord2016ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftWord2016ToolStripMenuItem.Click
        AddPicture("word2016", "New Word file")
    End Sub

    Private Sub MicrosoftPowerPointToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftPowerPointToolStripMenuItem.Click
        AddPicture("powerpoint", "New powerpoint file")
        saveLocation()

    End Sub

    Private Sub ShowDesktopIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowDesktopIconsToolStripMenuItem.Click
        Dim pic As Control
        Dim tbox As TextBox
        If show Then

            For Each pic In Me.Controls
                If (pic.GetType() Is GetType(PictureBox)) Then
                    pic.Hide()
                    tbox = Me.Controls.Item("txtbox" + pic.Name.ToString)
                    tbox.Hide()
                End If
            Next
            show = Not show

        Else
            For Each pic In Me.Controls
                If (pic.GetType() Is GetType(PictureBox)) Then
                    pic.Show()
                    tbox = Me.Controls.Item("txtbox" + pic.Name.ToString)
                    tbox.Show()
                End If
            Next
            show = Not show
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        listPrint()
    End Sub

    Private Sub NameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NameToolStripMenuItem.Click
        arrangeIcons()
    End Sub

    Private Sub OpenToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem2.Click
        Me.Hide()
        recyclebin.Show()
    End Sub

    Private Sub RenameToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem1.Click
        selectedTxtBox.Enabled = True
        selectedTxtBox.Select()
    End Sub

    Private Sub main_CausesValidationChanged(sender As Object, e As EventArgs) Handles Me.CausesValidationChanged

    End Sub

    Private Sub main_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim pic As Control
        For Each pic In Me.Controls
            If (pic.GetType() Is GetType(PictureBox)) Then

                AddHandler pic.MouseDown, AddressOf Event_MouseDown
                AddHandler pic.MouseMove, AddressOf Event_MouseMove
                AddHandler pic.MouseUp, AddressOf Event_MouseUp

            End If
        Next
    End Sub

    Private Sub EmptyRecycleBinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmptyRecycleBinToolStripMenuItem.Click


        Dim count = 0
        Dim pic As Control
        Dim result As Integer = MessageBox.Show("Are you sure you want to permanently delete " + ((recyclebin.Controls.Count - 1) / 2).ToString + " files ?", "حذف الملف", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then
            'MessageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            'MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then

            For Each pic In recyclebin.Controls
                If (pic.GetType() Is GetType(PictureBox)) Then
                    pic.Dispose()
                End If
            Next
        End If




        'recyclebin.Controls.Clear()
    End Sub
End Class
