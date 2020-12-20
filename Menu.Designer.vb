<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.radCalc = New System.Windows.Forms.RadioButton()
        Me.radConv = New System.Windows.Forms.RadioButton()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnDB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalculator
        '
        Me.btnCalculator.Location = New System.Drawing.Point(105, 12)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(83, 45)
        Me.btnCalculator.TabIndex = 0
        Me.btnCalculator.Text = "Calculator"
        Me.btnCalculator.UseVisualStyleBackColor = True
        '
        'radCalc
        '
        Me.radCalc.AutoSize = True
        Me.radCalc.Location = New System.Drawing.Point(9, 12)
        Me.radCalc.Name = "radCalc"
        Me.radCalc.Size = New System.Drawing.Size(68, 17)
        Me.radCalc.TabIndex = 2
        Me.radCalc.TabStop = True
        Me.radCalc.Text = "Standard"
        Me.radCalc.UseVisualStyleBackColor = True
        '
        'radConv
        '
        Me.radConv.AutoSize = True
        Me.radConv.Location = New System.Drawing.Point(9, 40)
        Me.radConv.Name = "radConv"
        Me.radConv.Size = New System.Drawing.Size(71, 17)
        Me.radConv.TabIndex = 3
        Me.radConv.TabStop = True
        Me.radConv.Text = "Converter"
        Me.radConv.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(9, 91)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(179, 45)
        Me.btnList.TabIndex = 4
        Me.btnList.Text = "List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'btnDB
        '
        Me.btnDB.Location = New System.Drawing.Point(9, 167)
        Me.btnDB.Name = "btnDB"
        Me.btnDB.Size = New System.Drawing.Size(179, 45)
        Me.btnDB.TabIndex = 5
        Me.btnDB.Text = "Collection"
        Me.btnDB.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(202, 244)
        Me.Controls.Add(Me.btnDB)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.radConv)
        Me.Controls.Add(Me.radCalc)
        Me.Controls.Add(Me.btnCalculator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu"
        Me.Text = "MultiTool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculator As Windows.Forms.Button
    Friend WithEvents radCalc As Windows.Forms.RadioButton
    Friend WithEvents radConv As Windows.Forms.RadioButton
    Friend WithEvents btnList As Windows.Forms.Button
    Friend WithEvents btnDB As Windows.Forms.Button
End Class
