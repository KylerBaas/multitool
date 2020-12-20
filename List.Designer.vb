<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List
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
        Me.listBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.checkAppend = New System.Windows.Forms.CheckBox()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listBox
        '
        Me.listBox.FormattingEnabled = True
        Me.listBox.Location = New System.Drawing.Point(12, 78)
        Me.listBox.Name = "listBox"
        Me.listBox.Size = New System.Drawing.Size(185, 225)
        Me.listBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "My List"
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(12, 25)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(104, 20)
        Me.txtBox1.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(122, 22)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add To List"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 309)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save List"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(122, 309)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(75, 23)
        Me.btnRead.TabIndex = 5
        Me.btnRead.Text = "Load List"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'checkAppend
        '
        Me.checkAppend.AutoSize = True
        Me.checkAppend.Location = New System.Drawing.Point(122, 342)
        Me.checkAppend.Name = "checkAppend"
        Me.checkAppend.Size = New System.Drawing.Size(63, 17)
        Me.checkAppend.TabIndex = 6
        Me.checkAppend.Text = "Append"
        Me.checkAppend.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(12, 338)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(75, 23)
        Me.btnClr.TabIndex = 7
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'ToDoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 371)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.checkAppend)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listBox)
        Me.Name = "ToDoList"
        Me.Text = "ToDoList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listBox As Windows.Forms.ListBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtBox1 As Windows.Forms.TextBox
    Friend WithEvents btnAdd As Windows.Forms.Button
    Friend WithEvents btnSave As Windows.Forms.Button
    Friend WithEvents btnRead As Windows.Forms.Button
    Friend WithEvents checkAppend As Windows.Forms.CheckBox
    Friend WithEvents btnClr As Windows.Forms.Button
End Class
