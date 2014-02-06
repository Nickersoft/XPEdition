Option Strict Off
Option Explicit On
Friend Class CFrmSettings
  Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
  Public Sub New()
    MyBase.New()
    'This call is required by the Windows Form Designer.
    InitializeComponent()
  End Sub
  'Form overrides dispose to clean up the component list.
  Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
    If Disposing Then
      If Not components Is Nothing Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(Disposing)
  End Sub
  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer
  Public ToolTip1 As System.Windows.Forms.ToolTip
  Public WithEvents txtKey As System.Windows.Forms.TextBox
  Public WithEvents chkCompress As System.Windows.Forms.CheckBox
  Public WithEvents Label6 As System.Windows.Forms.Label
  Public WithEvents Frame1 As System.Windows.Forms.GroupBox
  Public WithEvents chkServer As System.Windows.Forms.CheckBox
  Public WithEvents txtListenPort As System.Windows.Forms.TextBox
  Public WithEvents Label7 As System.Windows.Forms.Label
  Public WithEvents Frame4 As System.Windows.Forms.GroupBox
  Public WithEvents btnCancel As System.Windows.Forms.Button
  Public WithEvents btnOk As System.Windows.Forms.Button
  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
Me.components = New System.ComponentModel.Container
Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
Me.Frame1 = New System.Windows.Forms.GroupBox
Me.txtKey = New System.Windows.Forms.TextBox
Me.chkCompress = New System.Windows.Forms.CheckBox
Me.Label6 = New System.Windows.Forms.Label
Me.Frame4 = New System.Windows.Forms.GroupBox
Me.chkServer = New System.Windows.Forms.CheckBox
Me.txtListenPort = New System.Windows.Forms.TextBox
Me.Label7 = New System.Windows.Forms.Label
Me.btnCancel = New System.Windows.Forms.Button
Me.btnOk = New System.Windows.Forms.Button
Me.Frame1.SuspendLayout()
Me.Frame4.SuspendLayout()
Me.SuspendLayout()
'
'Frame1
'
Me.Frame1.BackColor = System.Drawing.SystemColors.Control
Me.Frame1.Controls.Add(Me.txtKey)
Me.Frame1.Controls.Add(Me.chkCompress)
Me.Frame1.Controls.Add(Me.Label6)
Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
Me.Frame1.Location = New System.Drawing.Point(10, 10)
Me.Frame1.Name = "Frame1"
Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Frame1.Size = New System.Drawing.Size(222, 126)
Me.Frame1.TabIndex = 5
Me.Frame1.TabStop = False
Me.Frame1.Text = "Options"
'
'txtKey
'
Me.txtKey.AcceptsReturn = True
Me.txtKey.AutoSize = False
Me.txtKey.BackColor = System.Drawing.SystemColors.Window
Me.txtKey.Cursor = System.Windows.Forms.Cursors.IBeam
Me.txtKey.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.txtKey.ForeColor = System.Drawing.SystemColors.WindowText
Me.txtKey.Location = New System.Drawing.Point(10, 48)
Me.txtKey.MaxLength = 0
Me.txtKey.Name = "txtKey"
Me.txtKey.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.txtKey.Size = New System.Drawing.Size(126, 23)
Me.txtKey.TabIndex = 7
Me.txtKey.Text = ""
'
'chkCompress
'
Me.chkCompress.BackColor = System.Drawing.SystemColors.Control
Me.chkCompress.Cursor = System.Windows.Forms.Cursors.Default
Me.chkCompress.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.chkCompress.ForeColor = System.Drawing.SystemColors.ControlText
Me.chkCompress.Location = New System.Drawing.Point(10, 87)
Me.chkCompress.Name = "chkCompress"
Me.chkCompress.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.chkCompress.Size = New System.Drawing.Size(203, 21)
Me.chkCompress.TabIndex = 6
Me.chkCompress.Text = "Use packet compression"
'
'Label6
'
Me.Label6.BackColor = System.Drawing.SystemColors.Control
Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
Me.Label6.Location = New System.Drawing.Point(10, 29)
Me.Label6.Name = "Label6"
Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Label6.Size = New System.Drawing.Size(126, 21)
Me.Label6.TabIndex = 8
Me.Label6.Text = "Secret key:"
'
'Frame4
'
Me.Frame4.BackColor = System.Drawing.SystemColors.Control
Me.Frame4.Controls.Add(Me.chkServer)
Me.Frame4.Controls.Add(Me.txtListenPort)
Me.Frame4.Controls.Add(Me.Label7)
Me.Frame4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
Me.Frame4.Location = New System.Drawing.Point(240, 10)
Me.Frame4.Name = "Frame4"
Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Frame4.Size = New System.Drawing.Size(222, 126)
Me.Frame4.TabIndex = 2
Me.Frame4.TabStop = False
Me.Frame4.Text = "Server"
'
'chkServer
'
Me.chkServer.BackColor = System.Drawing.SystemColors.Control
Me.chkServer.Checked = True
Me.chkServer.CheckState = System.Windows.Forms.CheckState.Checked
Me.chkServer.Cursor = System.Windows.Forms.Cursors.Default
Me.chkServer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.chkServer.ForeColor = System.Drawing.SystemColors.ControlText
Me.chkServer.Location = New System.Drawing.Point(10, 87)
Me.chkServer.Name = "chkServer"
Me.chkServer.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.chkServer.Size = New System.Drawing.Size(193, 21)
Me.chkServer.TabIndex = 9
Me.chkServer.Text = "Enable incoming connections"
'
'txtListenPort
'
Me.txtListenPort.AcceptsReturn = True
Me.txtListenPort.AutoSize = False
Me.txtListenPort.BackColor = System.Drawing.SystemColors.Window
Me.txtListenPort.Cursor = System.Windows.Forms.Cursors.IBeam
Me.txtListenPort.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.txtListenPort.ForeColor = System.Drawing.SystemColors.WindowText
Me.txtListenPort.Location = New System.Drawing.Point(10, 48)
Me.txtListenPort.MaxLength = 0
Me.txtListenPort.Name = "txtListenPort"
Me.txtListenPort.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.txtListenPort.Size = New System.Drawing.Size(126, 23)
Me.txtListenPort.TabIndex = 3
Me.txtListenPort.Text = "2222"
'
'Label7
'
Me.Label7.BackColor = System.Drawing.SystemColors.Control
Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
Me.Label7.Location = New System.Drawing.Point(10, 29)
Me.Label7.Name = "Label7"
Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Label7.Size = New System.Drawing.Size(174, 21)
Me.Label7.TabIndex = 4
Me.Label7.Text = "Listening port:"
'
'btnCancel
'
Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
Me.btnCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
Me.btnCancel.Location = New System.Drawing.Point(240, 173)
Me.btnCancel.Name = "btnCancel"
Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.btnCancel.Size = New System.Drawing.Size(88, 30)
Me.btnCancel.TabIndex = 1
Me.btnCancel.Text = "Cancel"
'
'btnOk
'
Me.btnOk.BackColor = System.Drawing.SystemColors.Control
Me.btnOk.Cursor = System.Windows.Forms.Cursors.Default
Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
Me.btnOk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlText
Me.btnOk.Location = New System.Drawing.Point(144, 173)
Me.btnOk.Name = "btnOk"
Me.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.btnOk.Size = New System.Drawing.Size(88, 30)
Me.btnOk.TabIndex = 0
Me.btnOk.Text = "Ok"
'
'CFrmSettings
'
Me.AcceptButton = Me.btnCancel
Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
Me.BackColor = System.Drawing.SystemColors.Control
Me.CancelButton = Me.btnCancel
Me.ClientSize = New System.Drawing.Size(474, 215)
Me.ControlBox = False
Me.Controls.Add(Me.Frame1)
Me.Controls.Add(Me.Frame4)
Me.Controls.Add(Me.btnCancel)
Me.Controls.Add(Me.btnOk)
Me.Cursor = System.Windows.Forms.Cursors.Default
Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
Me.Location = New System.Drawing.Point(4, 27)
Me.MaximizeBox = False
Me.MinimizeBox = False
Me.Name = "CFrmSettings"
Me.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.ShowInTaskbar = False
Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
Me.Text = "Settings"
Me.Frame1.ResumeLayout(False)
Me.Frame4.ResumeLayout(False)
Me.ResumeLayout(False)

  End Sub
#End Region

End Class