' MultiTool - Menu '
' Created by Kyler Baas '
' December 15, 2019 '

Public Class Menu
    'Handles the calculator button click'
    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        If radCalc.Checked Then
            Dim calc = New Calculator()
            calc.Show()
        ElseIf radConv.Checked Then
            Dim conv = New ConvChoice()
            conv.Show()
        Else
            MsgBox("Select one of the radio buttons, then press Calculator")
        End If
    End Sub

    'Handles the list button click'
    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Dim l = New List()
        l.Show()
    End Sub

    'Handles the database button click'
    Private Sub btnDB_Click(sender As Object, e As EventArgs) Handles btnDB.Click
        Dim db = New DataBase()
        db.Show()
    End Sub
End Class