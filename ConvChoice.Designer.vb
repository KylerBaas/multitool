<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConvChoice
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
        Me.btnDistance = New System.Windows.Forms.Button()
        Me.btnMass = New System.Windows.Forms.Button()
        Me.btnTemp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDistance
        '
        Me.btnDistance.Location = New System.Drawing.Point(12, 58)
        Me.btnDistance.Name = "btnDistance"
        Me.btnDistance.Size = New System.Drawing.Size(85, 80)
        Me.btnDistance.TabIndex = 0
        Me.btnDistance.Text = "Distance"
        Me.btnDistance.UseVisualStyleBackColor = True
        '
        'btnMass
        '
        Me.btnMass.Location = New System.Drawing.Point(103, 58)
        Me.btnMass.Name = "btnMass"
        Me.btnMass.Size = New System.Drawing.Size(85, 80)
        Me.btnMass.TabIndex = 1
        Me.btnMass.Text = "Mass"
        Me.btnMass.UseVisualStyleBackColor = True
        '
        'btnTemp
        '
        Me.btnTemp.Location = New System.Drawing.Point(56, 144)
        Me.btnTemp.Name = "btnTemp"
        Me.btnTemp.Size = New System.Drawing.Size(85, 80)
        Me.btnTemp.TabIndex = 3
        Me.btnTemp.Text = "Temperature"
        Me.btnTemp.UseVisualStyleBackColor = True
        '
        'ConvChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(202, 240)
        Me.Controls.Add(Me.btnTemp)
        Me.Controls.Add(Me.btnMass)
        Me.Controls.Add(Me.btnDistance)
        Me.Name = "ConvChoice"
        Me.Text = "ConvChoice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDistance As Windows.Forms.Button
    Friend WithEvents btnMass As Windows.Forms.Button
    Friend WithEvents btnTemp As Windows.Forms.Button
End Class
