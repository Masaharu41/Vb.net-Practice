<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShiftingArrays
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
        Me.PlotButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ArrayPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.ArrayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlotButton
        '
        Me.PlotButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlotButton.Location = New System.Drawing.Point(633, 473)
        Me.PlotButton.Name = "PlotButton"
        Me.PlotButton.Size = New System.Drawing.Size(162, 83)
        Me.PlotButton.TabIndex = 0
        Me.PlotButton.Text = "Plot"
        Me.PlotButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Location = New System.Drawing.Point(815, 473)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(162, 83)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ArrayPictureBox
        '
        Me.ArrayPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ArrayPictureBox.Location = New System.Drawing.Point(41, 12)
        Me.ArrayPictureBox.Name = "ArrayPictureBox"
        Me.ArrayPictureBox.Size = New System.Drawing.Size(999, 438)
        Me.ArrayPictureBox.TabIndex = 2
        Me.ArrayPictureBox.TabStop = False
        '
        'ShiftingArrays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 636)
        Me.Controls.Add(Me.ArrayPictureBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PlotButton)
        Me.Name = "ShiftingArrays"
        Me.Text = "Form1"
        CType(Me.ArrayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlotButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ArrayPictureBox As PictureBox
End Class
