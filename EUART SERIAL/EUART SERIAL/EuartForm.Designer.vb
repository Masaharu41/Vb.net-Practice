<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EuartForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.PwTrackBar = New System.Windows.Forms.TrackBar()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.ScanTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PortLabel = New System.Windows.Forms.Label()
        Me.TempLabel = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        CType(Me.PwTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort
        '
        '
        'PwTrackBar
        '
        Me.PwTrackBar.Location = New System.Drawing.Point(35, 26)
        Me.PwTrackBar.Maximum = 20
        Me.PwTrackBar.Name = "PwTrackBar"
        Me.PwTrackBar.Size = New System.Drawing.Size(742, 90)
        Me.PwTrackBar.TabIndex = 0
        '
        'SendButton
        '
        Me.SendButton.Location = New System.Drawing.Point(35, 122)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(155, 46)
        Me.SendButton.TabIndex = 1
        Me.SendButton.Text = "&Send"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(196, 122)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(153, 46)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Location = New System.Drawing.Point(30, 227)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(77, 25)
        Me.DisplayLabel.TabIndex = 3
        Me.DisplayLabel.Text = "Label1"
        '
        'ScanTimer
        '
        Me.ScanTimer.Enabled = True
        Me.ScanTimer.Interval = 500
        '
        'PortLabel
        '
        Me.PortLabel.AutoSize = True
        Me.PortLabel.Location = New System.Drawing.Point(30, 290)
        Me.PortLabel.Name = "PortLabel"
        Me.PortLabel.Size = New System.Drawing.Size(77, 25)
        Me.PortLabel.TabIndex = 4
        Me.PortLabel.Text = "Label1"
        '
        'TempLabel
        '
        Me.TempLabel.AutoSize = True
        Me.TempLabel.Location = New System.Drawing.Point(30, 202)
        Me.TempLabel.Name = "TempLabel"
        Me.TempLabel.Size = New System.Drawing.Size(213, 25)
        Me.TempLabel.TabIndex = 5
        Me.TempLabel.Text = "Degrees In Farenheit"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(30, 265)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(118, 25)
        Me.Label.TabIndex = 6
        Me.Label.Text = "Port Status"
        '
        'EuartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 583)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.TempLabel)
        Me.Controls.Add(Me.PortLabel)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.PwTrackBar)
        Me.Name = "EuartForm"
        Me.Text = "Form1"
        CType(Me.PwTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents PwTrackBar As TrackBar
    Friend WithEvents SendButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents ScanTimer As Timer
    Friend WithEvents PortLabel As Label
    Friend WithEvents TempLabel As Label
    Friend WithEvents Label As Label
End Class
