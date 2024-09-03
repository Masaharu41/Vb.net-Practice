<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DartBoard
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
        Me.CircleButton = New System.Windows.Forms.Button()
        Me.DartBoardPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.DartBoardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CircleButton
        '
        Me.CircleButton.Location = New System.Drawing.Point(28, 522)
        Me.CircleButton.Name = "CircleButton"
        Me.CircleButton.Size = New System.Drawing.Size(98, 41)
        Me.CircleButton.TabIndex = 0
        Me.CircleButton.Text = "Circle"
        Me.CircleButton.UseVisualStyleBackColor = False
        '
        'DartBoardPictureBox
        '
        Me.DartBoardPictureBox.Location = New System.Drawing.Point(50, 40)
        Me.DartBoardPictureBox.Name = "DartBoardPictureBox"
        Me.DartBoardPictureBox.Size = New System.Drawing.Size(1057, 441)
        Me.DartBoardPictureBox.TabIndex = 1
        Me.DartBoardPictureBox.TabStop = False
        '
        'DartBoard
        '
        Me.ClientSize = New System.Drawing.Size(1154, 581)
        Me.Controls.Add(Me.DartBoardPictureBox)
        Me.Controls.Add(Me.CircleButton)
        Me.Name = "DartBoard"
        CType(Me.DartBoardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DartBoard As PictureBox
    Friend WithEvents CircleButton As Button
    Friend WithEvents DartBoardPictureBox As PictureBox
End Class
