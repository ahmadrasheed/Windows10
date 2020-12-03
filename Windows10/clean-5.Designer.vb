<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clean_5
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(457, 858)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 72)
        Me.Label4.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1521, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(360, 106)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "الرجوع الى سطج  المكتب"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'clean_5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Windows10.My.Resources.Resources.cleanup_5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1974, 1229)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(2000, 1300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(2000, 1300)
        Me.Name = "clean_5"
        Me.Text = "clean_5"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
