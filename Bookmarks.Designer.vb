<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bookmarks
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
        Me.editbmarkbttn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.removebmarkbttn = New System.Windows.Forms.Button()
        Me.newbmarkbttn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'editbmarkbttn
        '
        Me.editbmarkbttn.Location = New System.Drawing.Point(12, 330)
        Me.editbmarkbttn.Name = "editbmarkbttn"
        Me.editbmarkbttn.Size = New System.Drawing.Size(130, 21)
        Me.editbmarkbttn.TabIndex = 1
        Me.editbmarkbttn.Text = "Edit"
        Me.editbmarkbttn.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(2, 8)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(148, 316)
        Me.ListBox1.TabIndex = 2
        '
        'removebmarkbttn
        '
        Me.removebmarkbttn.Location = New System.Drawing.Point(84, 357)
        Me.removebmarkbttn.Name = "removebmarkbttn"
        Me.removebmarkbttn.Size = New System.Drawing.Size(58, 21)
        Me.removebmarkbttn.TabIndex = 3
        Me.removebmarkbttn.Text = "Remove"
        Me.removebmarkbttn.UseVisualStyleBackColor = True
        '
        'newbmarkbttn
        '
        Me.newbmarkbttn.Location = New System.Drawing.Point(12, 357)
        Me.newbmarkbttn.Name = "newbmarkbttn"
        Me.newbmarkbttn.Size = New System.Drawing.Size(55, 21)
        Me.newbmarkbttn.TabIndex = 4
        Me.newbmarkbttn.Text = "Add"
        Me.newbmarkbttn.UseVisualStyleBackColor = True
        '
        'Bookmarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(154, 383)
        Me.Controls.Add(Me.newbmarkbttn)
        Me.Controls.Add(Me.removebmarkbttn)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.editbmarkbttn)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Bookmarks"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Bookmarks"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents editbmarkbttn As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents removebmarkbttn As System.Windows.Forms.Button
    Friend WithEvents newbmarkbttn As System.Windows.Forms.Button
End Class
