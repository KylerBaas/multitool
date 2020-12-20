<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataBase
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tabCon = New System.Windows.Forms.TabControl()
        Me.tabView = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.comFilter = New System.Windows.Forms.ComboBox()
        Me.btnClrFilter = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.tabAdd = New System.Windows.Forms.TabPage()
        Me.txtImageLink = New System.Windows.Forms.TextBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtImage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tabCon.SuspendLayout()
        Me.tabView.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(11, 86)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(170, 20)
        Me.txtSearch.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(187, 84)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'tabCon
        '
        Me.tabCon.Controls.Add(Me.tabView)
        Me.tabCon.Controls.Add(Me.tabAdd)
        Me.tabCon.Location = New System.Drawing.Point(1, 0)
        Me.tabCon.Name = "tabCon"
        Me.tabCon.SelectedIndex = 0
        Me.tabCon.Size = New System.Drawing.Size(480, 349)
        Me.tabCon.TabIndex = 5
        '
        'tabView
        '
        Me.tabView.Controls.Add(Me.Label11)
        Me.tabView.Controls.Add(Me.Label10)
        Me.tabView.Controls.Add(Me.Label9)
        Me.tabView.Controls.Add(Me.Label8)
        Me.tabView.Controls.Add(Me.Label7)
        Me.tabView.Controls.Add(Me.comFilter)
        Me.tabView.Controls.Add(Me.btnClrFilter)
        Me.tabView.Controls.Add(Me.btnDel)
        Me.tabView.Controls.Add(Me.lblDate)
        Me.tabView.Controls.Add(Me.lblBrand)
        Me.tabView.Controls.Add(Me.lblType)
        Me.tabView.Controls.Add(Me.lblName)
        Me.tabView.Controls.Add(Me.Label2)
        Me.tabView.Controls.Add(Me.picImage)
        Me.tabView.Controls.Add(Me.lstItems)
        Me.tabView.Controls.Add(Me.txtSearch)
        Me.tabView.Controls.Add(Me.btnSearch)
        Me.tabView.Location = New System.Drawing.Point(4, 22)
        Me.tabView.Name = "tabView"
        Me.tabView.Padding = New System.Windows.Forms.Padding(3)
        Me.tabView.Size = New System.Drawing.Size(472, 323)
        Me.tabView.TabIndex = 0
        Me.tabView.Text = "My Collection"
        Me.tabView.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(300, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Date Added:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(300, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Brand:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(300, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Type:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(300, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Filter Item By:"
        '
        'comFilter
        '
        Me.comFilter.FormattingEnabled = True
        Me.comFilter.Items.AddRange(New Object() {"Name", "Type", "Brand"})
        Me.comFilter.Location = New System.Drawing.Point(83, 56)
        Me.comFilter.Name = "comFilter"
        Me.comFilter.Size = New System.Drawing.Size(97, 21)
        Me.comFilter.TabIndex = 18
        '
        'btnClrFilter
        '
        Me.btnClrFilter.Location = New System.Drawing.Point(187, 54)
        Me.btnClrFilter.Name = "btnClrFilter"
        Me.btnClrFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnClrFilter.TabIndex = 17
        Me.btnClrFilter.Text = "Clear Filter"
        Me.btnClrFilter.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(407, 273)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(59, 47)
        Me.btnDel.TabIndex = 16
        Me.btnDel.Text = "Delete Item"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(373, 236)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 13)
        Me.lblDate.TabIndex = 15
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Location = New System.Drawing.Point(373, 212)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(0, 13)
        Me.lblBrand.TabIndex = 14
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(373, 190)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(0, 13)
        Me.lblType.TabIndex = 13
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(373, 166)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 13)
        Me.lblName.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 30)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "My Collection"
        '
        'picImage
        '
        Me.picImage.Location = New System.Drawing.Point(303, 27)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(135, 120)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 7
        Me.picImage.TabStop = False
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Location = New System.Drawing.Point(11, 117)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(251, 199)
        Me.lstItems.TabIndex = 6
        '
        'tabAdd
        '
        Me.tabAdd.Controls.Add(Me.txtImageLink)
        Me.tabAdd.Controls.Add(Me.btnUpload)
        Me.tabAdd.Controls.Add(Me.Label6)
        Me.tabAdd.Controls.Add(Me.Label5)
        Me.tabAdd.Controls.Add(Me.Label4)
        Me.tabAdd.Controls.Add(Me.Label3)
        Me.tabAdd.Controls.Add(Me.txtImage)
        Me.tabAdd.Controls.Add(Me.Label1)
        Me.tabAdd.Controls.Add(Me.txtBrand)
        Me.tabAdd.Controls.Add(Me.txtType)
        Me.tabAdd.Controls.Add(Me.txtName)
        Me.tabAdd.Controls.Add(Me.btnAdd)
        Me.tabAdd.Location = New System.Drawing.Point(4, 22)
        Me.tabAdd.Name = "tabAdd"
        Me.tabAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAdd.Size = New System.Drawing.Size(472, 323)
        Me.tabAdd.TabIndex = 1
        Me.tabAdd.Text = "Add To Collection"
        Me.tabAdd.UseVisualStyleBackColor = True
        '
        'txtImageLink
        '
        Me.txtImageLink.Location = New System.Drawing.Point(320, 257)
        Me.txtImageLink.Name = "txtImageLink"
        Me.txtImageLink.Size = New System.Drawing.Size(100, 20)
        Me.txtImageLink.TabIndex = 18
        Me.txtImageLink.Visible = False
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(299, 194)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 16
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Image:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(77, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Brand:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Name:"
        '
        'txtImage
        '
        Me.txtImage.Location = New System.Drawing.Point(122, 197)
        Me.txtImage.Name = "txtImage"
        Me.txtImage.Size = New System.Drawing.Size(171, 20)
        Me.txtImage.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Add To Collection"
        '
        'txtBrand
        '
        Me.txtBrand.Location = New System.Drawing.Point(122, 160)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(252, 20)
        Me.txtBrand.TabIndex = 9
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(122, 121)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(252, 20)
        Me.txtType.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(122, 80)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(252, 20)
        Me.txtName.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(7, 257)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 59)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 349)
        Me.Controls.Add(Me.tabCon)
        Me.Name = "DataBase"
        Me.Text = "Collection"
        Me.tabCon.ResumeLayout(False)
        Me.tabView.ResumeLayout(False)
        Me.tabView.PerformLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAdd.ResumeLayout(False)
        Me.tabAdd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSearch As Windows.Forms.TextBox
    Friend WithEvents btnSearch As Windows.Forms.Button
    Friend WithEvents CollectionDataSetBindingSource As Windows.Forms.BindingSource
    Friend WithEvents tabCon As Windows.Forms.TabControl
    Friend WithEvents tabView As Windows.Forms.TabPage
    Friend WithEvents picImage As Windows.Forms.PictureBox
    Friend WithEvents lstItems As Windows.Forms.ListBox
    Friend WithEvents tabAdd As Windows.Forms.TabPage
    Friend WithEvents btnAdd As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtBrand As Windows.Forms.TextBox
    Friend WithEvents txtType As Windows.Forms.TextBox
    Friend WithEvents txtName As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents lblName As Windows.Forms.Label
    Friend WithEvents lblType As Windows.Forms.Label
    Friend WithEvents lblBrand As Windows.Forms.Label
    Friend WithEvents lblDate As Windows.Forms.Label
    Friend WithEvents txtImage As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents btnDel As Windows.Forms.Button
    Friend WithEvents btnClrFilter As Windows.Forms.Button
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents comFilter As Windows.Forms.ComboBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents btnUpload As Windows.Forms.Button
    Friend WithEvents txtImageLink As Windows.Forms.TextBox
End Class
