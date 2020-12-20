<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Converter
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
        Me.grpBox = New System.Windows.Forms.GroupBox()
        Me.combo2 = New System.Windows.Forms.ComboBox()
        Me.combo1 = New System.Windows.Forms.ComboBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.btnDec = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btnRes = New System.Windows.Forms.Button()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConv = New System.Windows.Forms.Button()
        Me.lblA = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBox
        '
        Me.grpBox.Controls.Add(Me.Label1)
        Me.grpBox.Controls.Add(Me.combo2)
        Me.grpBox.Controls.Add(Me.combo1)
        Me.grpBox.Location = New System.Drawing.Point(167, 57)
        Me.grpBox.Name = "grpBox"
        Me.grpBox.Size = New System.Drawing.Size(132, 110)
        Me.grpBox.TabIndex = 2
        Me.grpBox.TabStop = False
        Me.grpBox.Text = "Distance"
        '
        'combo2
        '
        Me.combo2.FormattingEnabled = True
        Me.combo2.Items.AddRange(New Object() {"cm", "m", "km", "in", "ft", "mi"})
        Me.combo2.Location = New System.Drawing.Point(3, 75)
        Me.combo2.Name = "combo2"
        Me.combo2.Size = New System.Drawing.Size(121, 21)
        Me.combo2.TabIndex = 1
        '
        'combo1
        '
        Me.combo1.FormattingEnabled = True
        Me.combo1.Items.AddRange(New Object() {"cm", "m", "km", "in", "ft", "mi"})
        Me.combo1.Location = New System.Drawing.Point(3, 19)
        Me.combo1.Name = "combo1"
        Me.combo1.Size = New System.Drawing.Size(121, 21)
        Me.combo1.TabIndex = 0
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(9, 12)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(120, 20)
        Me.txtNum1.TabIndex = 3
        '
        'btnDec
        '
        Me.btnDec.Location = New System.Drawing.Point(76, 223)
        Me.btnDec.Name = "btnDec"
        Me.btnDec.Size = New System.Drawing.Size(53, 23)
        Me.btnDec.TabIndex = 37
        Me.btnDec.Text = "Decimal"
        Me.btnDec.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(51, 173)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(36, 32)
        Me.btn0.TabIndex = 36
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(93, 135)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(36, 32)
        Me.btn3.TabIndex = 35
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(51, 135)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(36, 32)
        Me.btn2.TabIndex = 34
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(9, 135)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(36, 32)
        Me.btn1.TabIndex = 33
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(93, 97)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(36, 32)
        Me.btn6.TabIndex = 32
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(51, 97)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(36, 32)
        Me.btn5.TabIndex = 31
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(9, 97)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(36, 32)
        Me.btn4.TabIndex = 30
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(93, 57)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(36, 32)
        Me.btn9.TabIndex = 29
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(51, 57)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(36, 32)
        Me.btn8.TabIndex = 28
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(9, 57)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(36, 32)
        Me.btn7.TabIndex = 27
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btnRes
        '
        Me.btnRes.Location = New System.Drawing.Point(9, 223)
        Me.btnRes.Name = "btnRes"
        Me.btnRes.Size = New System.Drawing.Size(52, 23)
        Me.btnRes.TabIndex = 26
        Me.btnRes.Text = "Reset"
        Me.btnRes.UseVisualStyleBackColor = True
        '
        'lblAns
        '
        Me.lblAns.AutoSize = True
        Me.lblAns.Location = New System.Drawing.Point(281, 109)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(0, 13)
        Me.lblAns.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Converts to:"
        '
        'btnConv
        '
        Me.btnConv.Location = New System.Drawing.Point(167, 185)
        Me.btnConv.Name = "btnConv"
        Me.btnConv.Size = New System.Drawing.Size(132, 61)
        Me.btnConv.TabIndex = 39
        Me.btnConv.Text = "Convert"
        Me.btnConv.UseVisualStyleBackColor = True
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(205, 15)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(0, 13)
        Me.lblA.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "To"
        '
        'Converter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 258)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.btnConv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDec)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnRes)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.grpBox)
        Me.Name = "Converter"
        Me.Text = "Converter"
        Me.grpBox.ResumeLayout(False)
        Me.grpBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpBox As Windows.Forms.GroupBox
    Friend WithEvents combo1 As Windows.Forms.ComboBox
    Friend WithEvents combo2 As Windows.Forms.ComboBox
    Friend WithEvents txtNum1 As Windows.Forms.TextBox
    Friend WithEvents btnDec As Windows.Forms.Button
    Friend WithEvents btn0 As Windows.Forms.Button
    Friend WithEvents btn3 As Windows.Forms.Button
    Friend WithEvents btn2 As Windows.Forms.Button
    Friend WithEvents btn1 As Windows.Forms.Button
    Friend WithEvents btn6 As Windows.Forms.Button
    Friend WithEvents btn5 As Windows.Forms.Button
    Friend WithEvents btn4 As Windows.Forms.Button
    Friend WithEvents btn9 As Windows.Forms.Button
    Friend WithEvents btn8 As Windows.Forms.Button
    Friend WithEvents btn7 As Windows.Forms.Button
    Friend WithEvents btnRes As Windows.Forms.Button
    Friend WithEvents lblAns As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents btnConv As Windows.Forms.Button
    Friend WithEvents lblA As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
