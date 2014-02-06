<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatSettings
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
        Me.txtkey = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtkey
        '
        Me.txtkey.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.XPEdition.My.MySettings.Default, "cpwrd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtkey.Location = New System.Drawing.Point(60, 142)
        Me.txtkey.Name = "txtkey"
        Me.txtkey.Size = New System.Drawing.Size(301, 20)
        Me.txtkey.TabIndex = 0
        Me.txtkey.Text = Global.XPEdition.My.MySettings.Default.cpwrd
        '
        'ChatSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 371)
        Me.Controls.Add(Me.txtkey)
        Me.Name = "ChatSettings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtkey As System.Windows.Forms.TextBox
End Class
