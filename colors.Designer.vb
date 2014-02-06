<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class colors
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.colorbutton = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.applybutton = New System.Windows.Forms.Button()
        Me.resetbutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 71)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to the color editor. Changing the color of this box changes the backgroun" & _
            "d color of all other forms, toolbars, desktop, etc.  Click the button below to e" & _
            "dit the color of this dialog box."
        '
        'colorbutton
        '
        Me.colorbutton.Location = New System.Drawing.Point(88, 83)
        Me.colorbutton.Name = "colorbutton"
        Me.colorbutton.Size = New System.Drawing.Size(93, 21)
        Me.colorbutton.TabIndex = 1
        Me.colorbutton.Text = "Change Color"
        Me.colorbutton.UseVisualStyleBackColor = True
        '
        'applybutton
        '
        Me.applybutton.Location = New System.Drawing.Point(88, 110)
        Me.applybutton.Name = "applybutton"
        Me.applybutton.Size = New System.Drawing.Size(93, 21)
        Me.applybutton.TabIndex = 2
        Me.applybutton.Text = "Apply"
        Me.applybutton.UseVisualStyleBackColor = True
        '
        'resetbutton
        '
        Me.resetbutton.Location = New System.Drawing.Point(88, 137)
        Me.resetbutton.Name = "resetbutton"
        Me.resetbutton.Size = New System.Drawing.Size(93, 21)
        Me.resetbutton.TabIndex = 3
        Me.resetbutton.Text = "Reset All Colors"
        Me.resetbutton.UseVisualStyleBackColor = True
        '
        'colors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.XPEdition.My.MySettings.Default.myBackColor
        Me.ClientSize = New System.Drawing.Size(265, 173)
        Me.Controls.Add(Me.resetbutton)
        Me.Controls.Add(Me.applybutton)
        Me.Controls.Add(Me.colorbutton)
        Me.Controls.Add(Me.Label1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.XPEdition.My.MySettings.Default, "myBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "colors"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Colors"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colorbutton As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents applybutton As System.Windows.Forms.Button
    Friend WithEvents resetbutton As System.Windows.Forms.Button
End Class
