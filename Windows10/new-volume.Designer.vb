<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class new_volume
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(new_volume))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSimpleVolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSpannedVolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewStripedVolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(716, 411)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 139)
        Me.Label4.TabIndex = 8
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.NewSimpleVolumeToolStripMenuItem, Me.NewSpannedVolumeToolStripMenuItem, Me.NewStripedVolumeToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(405, 194)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(404, 38)
        '
        'NewSimpleVolumeToolStripMenuItem
        '
        Me.NewSimpleVolumeToolStripMenuItem.Name = "NewSimpleVolumeToolStripMenuItem"
        Me.NewSimpleVolumeToolStripMenuItem.Size = New System.Drawing.Size(404, 38)
        Me.NewSimpleVolumeToolStripMenuItem.Text = "New Simple Volume              "
        '
        'NewSpannedVolumeToolStripMenuItem
        '
        Me.NewSpannedVolumeToolStripMenuItem.Name = "NewSpannedVolumeToolStripMenuItem"
        Me.NewSpannedVolumeToolStripMenuItem.Size = New System.Drawing.Size(404, 38)
        Me.NewSpannedVolumeToolStripMenuItem.Text = "New Spanned Volume"
        '
        'NewStripedVolumeToolStripMenuItem
        '
        Me.NewStripedVolumeToolStripMenuItem.Name = "NewStripedVolumeToolStripMenuItem"
        Me.NewStripedVolumeToolStripMenuItem.Size = New System.Drawing.Size(404, 38)
        Me.NewStripedVolumeToolStripMenuItem.Text = "New Striped Volume"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(404, 38)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'new_volume
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1174, 829)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1200, 900)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1200, 900)
        Me.Name = "new_volume"
        Me.Text = "new_volume"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NewSimpleVolumeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewSpannedVolumeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewStripedVolumeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
End Class
