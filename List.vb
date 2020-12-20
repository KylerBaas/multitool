' MultiTool - List.vb '
' Created by Kyler Baas '
' Created on 18/12/2019 '

Public Class List
    'Handles add button click'
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        listBox.Items.Add(txtBox1.Text)
        txtBox1.Clear()
    End Sub

    'Handles save button click'
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim fileName As String = InputBox("Enter file name to save to:", "Save File", "")

        Dim write As IO.StreamWriter = IO.File.CreateText("SavedLists/" + fileName + ".txt")

        If fileName = "" Or fileName = " " Then
            MsgBox("List not saved to file")
            Exit Sub
        End If

        For Each i As String In listBox.Items
            write.WriteLine(i)
        Next

        MsgBox(fileName + ".txt created")

        write.Close()
    End Sub

    'Handles read button click'
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim b As Boolean = False

        Dim fileName As String = InputBox("Enter file name to read from:", "Read File", "")

        'Loops until a valid file is chosen, or if the file could not be read'
        While b = False
            If System.IO.File.Exists("SavedLists/" + fileName + ".txt") Then
                b = True
            Else
                MsgBox(fileName + ".txt Does not exist")
                fileName = InputBox("Enter file name to read from:", "Read File", "")
                If fileName = "" Or fileName = " " Then
                    MsgBox("File not read to list")
                    b = True
                    Exit Sub
                End If
            End If
        End While

        If checkAppend.Checked = False Then
            If fileName = "" Or fileName = " " Then
                MsgBox("File not read to list")
                Exit Sub
            Else
                listBox.Items.Clear()
            End If
        End If

        Dim read As IO.StreamReader = IO.File.OpenText("SavedLists/" + fileName + ".txt")
        While read.Peek <> -1
            listBox.Items.Add(read.ReadLine())
        End While

        read.Close()
    End Sub

    'Handles clear button click'
    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        txtBox1.Clear()
        listBox.Items.Clear()
    End Sub
End Class