<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class partitions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(partitions))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeDriveLetterAndPathesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteVolumesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(1228, 621)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 169)
        Me.Label4.TabIndex = 6
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ChangeDriveLetterAndPathesToolStripMenuItem, Me.FormatToolStripMenuItem, Me.DeleteVolumesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(434, 148)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(433, 36)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ChangeDriveLetterAndPathesToolStripMenuItem
        '
        Me.ChangeDriveLetterAndPathesToolStripMenuItem.Name = "ChangeDriveLetterAndPathesToolStripMenuItem"
        Me.ChangeDriveLetterAndPathesToolStripMenuItem.Size = New System.Drawing.Size(433, 36)
        Me.ChangeDriveLetterAndPathesToolStripMenuItem.Text = "Change Drive letter and pathes.."
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(433, 36)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'DeleteVolumesToolStripMenuItem
        '
        Me.DeleteVolumesToolStripMenuItem.Name = "DeleteVolumesToolStripMenuItem"
        Me.DeleteVolumesToolStripMenuItem.Size = New System.Drawing.Size(433, 36)
        Me.DeleteVolumesToolStripMenuItem.Text = "Delete Volumes ..."
        '
        'partitions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1974, 1229)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(2000, 1300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(2000, 1300)
        Me.Name = "partitions"
        Me.Text = "partitions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeDriveLetterAndPathesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteVolumesToolStripMenuItem As ToolStripMenuItem
End Class
