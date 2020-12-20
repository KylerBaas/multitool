' MultiTool - DataBase.vb '
' Created by Kyler Baas '
' Created on 18/12/2019 '

Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing

Public Class DataBase
    'Relative paths containing required components (Collection database, Images folder)'
    Dim dbPath As String = IO.Path.Combine(IO.Directory.GetParent(Application.ExecutablePath).FullName, "Collection.mdf")
    Dim imagesPath As String = IO.Path.Combine(IO.Directory.GetParent(Application.ExecutablePath).FullName, "Images\")

    'SQL database objects required for connecting and altering the Collection database'
    Dim conn As New SqlConnection("Server=(localdb)\MSSQLLocalDB;AttachDBFilename=" + dbPath + ";")
    Dim cmd As New SqlCommand()
    Dim reader As SqlDataReader

    'Displays all of the items in the collection in the listbox'
    Private Sub viewAll()
        lstItems.Items.Clear()
        cmd.Connection = conn
        cmd = conn.CreateCommand
        cmd.CommandText = "SELECT item_name FROM Items ORDER BY item_name ASC;"

        conn.Open()

        reader = cmd.ExecuteReader()

        Dim results As String
        Do While reader.Read()
            results = reader.GetString(0)
            lstItems.Items.Add(results)
        Loop

        conn.Close()
    End Sub

    'Handles when the Collection database loads'
    Private Sub DataBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewAll()
    End Sub

    'Handles when a user selects a different item in the listbox'
    Private Sub lstItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItems.SelectedIndexChanged
        conn.Close()

        Dim current As String = lstItems.SelectedItem
        cmd.Connection = conn
        cmd = conn.CreateCommand
        cmd.CommandText = "SELECT Items.item_name, Items.image_name, Items.date_added, Types.type_name, Brands.brand_name FROM Items INNER JOIN Types ON Items.type_ID = Types.ID INNER JOIN Brands ON Items.brand_ID = Brands.ID WHERE items.item_name = '" & current & "'"

        conn.Open()
        reader = cmd.ExecuteReader()

        Dim result_item As String
        Dim result_image As String
        Dim result_date As Date
        Dim result_type As String
        Dim result_brand As String
        reader.Read()

        'Retrieve the field names of the item from the database reader'
        result_item = reader.GetString(0)
        result_image = reader.GetString(1)
        result_date = reader.GetDateTime(2)
        result_type = reader.GetString(3)
        result_brand = reader.GetString(4)

        'Set the labels to the respective field names'
        lblName.Text = result_item
        lblDate.Text = result_date
        lblType.Text = result_type
        lblBrand.Text = result_brand

        'If there is no image for the item'
        If result_image Is Nothing Then
            picImage.Image = My.Resources.ResourceManager.GetObject("none")
        Else
            picImage.Image = Image.FromFile(imagesPath + result_image)
        End If

        conn.Close()
    End Sub

    'Handles add button click'
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim name As String = txtName.Text
        Dim type As String = txtType.Text
        Dim brand As String = txtBrand.Text
        Dim image As String = txtImage.Text
        Dim savePath As String = imagesPath + txtImage.Text
        Dim answer As DialogResult

        'Check if an image was added'
        If image IsNot Nothing Then
            If System.IO.File.Exists(savePath) Then
                answer = MessageBox.Show("File " + txtImage.Text + " already exists, do you wish to overwrite " + image, "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = vbYes Then
                    IO.File.Delete(savePath)
                    IO.File.Copy(txtImageLink.Text, savePath)
                Else
                    Exit Sub
                End If
            Else
                IO.File.Copy(txtImageLink.Text, savePath)
            End If
        Else
            image = "none"
        End If


        'Check if the name field is empty'
        If String.IsNullOrEmpty(name) Then
            MsgBox("Must enter a name For the item")
            Exit Sub
        End If


        cmd.Connection = conn
        cmd = conn.CreateCommand

        'Retrieve the types from the Collection that match the selected type'
        cmd.CommandText = "Select * FROM Types WHERE type_name='" & type & "'"
        conn.Open()
        reader = cmd.ExecuteReader()
        If reader.Read() Or String.IsNullOrEmpty(type) Then
            conn.Close()
        Else
            conn.Close()
            cmd.CommandText = "INSERT INTO Types(type_name) VALUES('" & type & "')"
            conn.Open()
            reader = cmd.ExecuteReader()
            conn.Close()
        End If

        'Retrieve the brands from the Collection that match the selected type'
        cmd.CommandText = "SELECT * FROM Brands WHERE brand_name='" & brand & "'"
        conn.Open()
        reader = cmd.ExecuteReader()
        If reader.Read() Or String.IsNullOrEmpty(brand) Then
            conn.Close()
        Else
            conn.Close()
            cmd.CommandText = "INSERT INTO Brands(brand_name) VALUES('" & brand & "')"
            conn.Open()
            reader = cmd.ExecuteReader()
            conn.Close()
        End If

        'Retrieve the ID for the brand of the item to be added'
        cmd.CommandText = "SELECT ID FROM Types WHERE type_name='" & type & "'"
        conn.Open()
        reader = cmd.ExecuteReader()
        Dim typeID As Integer
        reader.Read()
        typeID = reader.GetInt32(0)
        conn.Close()

        'Retrieve the ID for the brand of the item to be added'
        cmd.CommandText = "SELECT ID FROM Brands WHERE brand_name='" & brand & "'"
        conn.Open()
        reader = cmd.ExecuteReader()
        Dim brandID As Integer
        reader.Read()
        brandID = reader.GetInt32(0)
        conn.Close()

        'Add the current item to the collection'
        cmd.CommandText = "INSERT INTO Items(item_name, image_name, type_ID, brand_ID) VALUES ('" & name & "', '" & image & "', '" & typeID & "', '" & brandID & "')"
        conn.Open()
        reader = cmd.ExecuteReader()
        conn.Close()

        MsgBox(name + " added to collection")
        txtName.Text = ""
        txtType.Text = ""
        txtBrand.Text = ""
        txtImage.Text = ""

        viewAll()
    End Sub

    'Handles delete button click'
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim name As String = lblName.Text

        cmd.Connection = conn
        cmd = conn.CreateCommand

        Dim answer As DialogResult
        answer = MessageBox.Show("Are you sure you want to remove " + name + " from collection?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'If the user chose to delete the item from the collection'
        If answer = vbYes Then
            'Clear the image from the picturebox'
            picImage.Image = Nothing
            picImage.Invalidate()

            cmd.CommandText = "SELECT image_name FROM Items WHERE item_name='" & name & "';"
            conn.Open()
            reader = cmd.ExecuteReader()
            Dim imageName As String
            reader.Read()
            imageName = reader.GetString(0)
            conn.Close()

            'Delete the item from the collection, and update the positions of the items in the listbox'
            cmd.CommandText = "DELETE FROM Items WHERE item_name='" & name & "'; declare @max int select @max=max([ID])from [Items]
                                if @max IS NULL SET @max = 0 DBCC CHECKIDENT ('[Items]', RESEED, @MAX);"
            conn.Open()
            reader = cmd.ExecuteReader()
            conn.Close()
        End If

        viewAll()
    End Sub

    'Handles search button click'
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim search As String = txtSearch.Text
        Dim filter As String = comFilter.Text
        Dim filName As String
        Dim result As String

        cmd.Connection = conn
        cmd = conn.CreateCommand

        'Determine which filter was chosen'
        Select Case (filter)
            Case "Name"
                result = search
                filName = "item_name"

            Case "Type"
                'Retrieve the ID for the type being searched'
                cmd.CommandText = "SELECT ID FROM Types WHERE type_name='" & search & "'"
                conn.Open()
                reader = cmd.ExecuteReader()
                If reader.Read() Then
                    result = reader.GetInt32(0)
                Else
                    MsgBox("No items found with type " + search)
                    conn.Close()
                    Exit Sub
                End If
                filName = "type_id"
                conn.Close()

            Case "Brand"
                'Retrieve the ID for the brand being searched'
                cmd.CommandText = "SELECT ID FROM Brands WHERE brand_name='" & search & "'"
                conn.Open()
                reader = cmd.ExecuteReader()
                If reader.Read() Then
                    result = reader.GetInt32(0)
                Else
                    MsgBox("No items found with brand " + search)
                    conn.Close()
                    Exit Sub
                End If
                filName = "brand_id"
                conn.Close()

            Case Else
                MsgBox("Choose a filter before searching!")
                Exit Sub
        End Select

        'Retreive an item that matches with the searched item'
        cmd.CommandText = "SELECT item_name FROM Items WHERE " & filName & "='" & result & "' ORDER BY item_name ASC;"
        conn.Open()
        reader = cmd.ExecuteReader()

        Dim results As String
        lstItems.Items.Clear()

        Do While reader.Read()
            results = reader.GetString(0)
            lstItems.Items.Add(results)
        Loop

    End Sub

    'Handles upload image button click'
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim open As New OpenFileDialog()
        'Filter file explorer so only files with jpg and png file extensions can be selected'
        open.Filter = "Images(*.jpg;*.png;) | *.jpg; *.png;"

        If (open.ShowDialog() = DialogResult.OK) Then
            txtImageLink.Text = open.FileName
            txtImage.Text = Path.GetFileName(open.FileName)
        End If
    End Sub

    'Handles clear filter button click'
    Private Sub btnClrFilter_Click(sender As Object, e As EventArgs) Handles btnClrFilter.Click
        viewAll()
        comFilter.Text = ""
        txtSearch.Text = ""
    End Sub
End Class