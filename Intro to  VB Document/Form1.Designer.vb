<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.buttonLoad = New System.Windows.Forms.Button()
        Me.buttonExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'buttonLoad
        '
        Me.buttonLoad.AutoSize = True
        Me.buttonLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonLoad.Location = New System.Drawing.Point(41, 237)
        Me.buttonLoad.Name = "buttonLoad"
        Me.buttonLoad.Size = New System.Drawing.Size(152, 54)
        Me.buttonLoad.TabIndex = 0
        Me.buttonLoad.Text = "Load Object Demo"
        Me.buttonLoad.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.buttonLoad.UseVisualStyleBackColor = True
        '
        'buttonExit
        '
        Me.buttonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonExit.Location = New System.Drawing.Point(582, 237)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Size = New System.Drawing.Size(84, 54)
        Me.buttonExit.TabIndex = 1
        Me.buttonExit.Text = "EXIT"
        Me.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.buttonExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buttonExit)
        Me.Controls.Add(Me.buttonLoad)
        Me.Name = "Form1"
        Me.Text = "Welcoming Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonLoad As Button
    Friend WithEvents buttonExit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
