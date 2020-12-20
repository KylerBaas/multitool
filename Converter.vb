' MultiTool - Converter '
' Created by Kyler Baas '
' December 16, 2019 '
Public Class Converter

    'Calculates the distance conversion'
    Sub distCalc(ByRef unit1 As String, ByRef unit2 As String)
        Dim value As Decimal = txtNum1.Text
        Dim ans As Decimal

        If unit1 = "cm" Then
            If unit2 = "m" Then
                ans = value / 100
            ElseIf unit2 = "km" Then
                ans = value / 100000
            ElseIf unit2 = "in" Then
                ans = value / 2.54
            ElseIf unit2 = "ft" Then
                ans = value / 30.48
            ElseIf unit2 = "mi" Then
                ans = value / 160934
            End If

        ElseIf unit1 = "m" Then
            If unit2 = "cm" Then
                ans = value * 100
            ElseIf unit2 = "km" Then
                ans = value / 1000
            ElseIf unit2 = "in" Then
                ans = value * 2.54
            ElseIf unit2 = "ft" Then
                ans = value * 3.28
            ElseIf unit2 = "mi" Then
                ans = value / 1609
            End If

        ElseIf unit1 = "km" Then
            If unit2 = "cm" Then
                ans = value * 100000
            ElseIf unit2 = "m" Then
                ans = value * 1000
            ElseIf unit2 = "in" Then
                ans = value * 39370
            ElseIf unit2 = "ft" Then
                ans = value * 3281
            ElseIf unit2 = "mi" Then
                ans = value / 1.609
            End If

        ElseIf unit1 = "in" Then
            If unit2 = "cm" Then
                ans = value * 2.54
            ElseIf unit2 = "m" Then
                ans = value / 39.37
            ElseIf unit2 = "km" Then
                ans = value / value / 39.37
            ElseIf unit2 = "ft" Then
                ans = value / 12
            ElseIf unit2 = "mi" Then
                ans = value / 63360
            End If

        ElseIf unit1 = "ft" Then
            If unit2 = "cm" Then
                ans = value * 30.48
            ElseIf unit2 = "m" Then
                ans = value * 1000
            ElseIf unit2 = "km" Then
                ans = value / 2.54
            ElseIf unit2 = "in" Then
                ans = value * 12
            ElseIf unit2 = "mi" Then
                ans = value / 5280
            End If

        ElseIf unit1 = "mi" Then
            If unit2 = "cm" Then
                ans = value * 160934
            ElseIf unit2 = "m" Then
                ans = value * 1609
            ElseIf unit2 = "km" Then
                ans = value * 1.609
            ElseIf unit2 = "in" Then
                ans = value / 30.48
            ElseIf unit2 = "ft" Then
                ans = value / 160934
            End If
        End If

        lblA.Text = ans
    End Sub

    'Calculates the mass conversion'
    Sub massCalc(ByRef unit1 As String, ByRef unit2 As String)
        Dim value As Decimal = txtNum1.Text
        Dim ans As Decimal

        If unit1 = "g" Then
            If unit2 = "kg" Then
                ans = value / 1000
            ElseIf unit2 = "oz" Then
                ans = value / 28.35
            ElseIf unit2 = "lb" Then
                ans = value / 454
            End If

        ElseIf unit1 = "kg" Then
            If unit2 = "g" Then
                ans = value * 1000
            ElseIf unit2 = "oz" Then
                ans = value * 35.274
            ElseIf unit2 = "lb" Then
                ans = value * 2.205
            End If

        ElseIf unit1 = "oz" Then
            If unit2 = "g" Then
                ans = value * 28.35
            ElseIf unit2 = "kg" Then
                ans = value / 35.274
            ElseIf unit2 = "lb" Then
                ans = value / 16
            End If

        ElseIf unit1 = "lb" Then
            If unit2 = "g" Then
                ans = value * 454
            ElseIf unit2 = "kg" Then
                ans = value / 2.205
            ElseIf unit2 = "oz" Then
                ans = value * 16
            End If
        End If

        lblA.Text = ans
    End Sub

    'Calculates the temperature conversion'
    Sub tempCalc(ByRef unit1 As String, ByRef unit2 As String)
        Dim value As Decimal = txtNum1.Text
        Dim ans As Decimal

        If unit1 = "c" Then
            If unit2 = "f" Then
                ans = (value * (9 / 5)) + 32
            ElseIf unit2 = "k" Then
                ans = value + 273.15
            End If

        ElseIf unit1 = "f" Then
            If unit2 = "c" Then
                ans = (value - 32) * (5 / 9)
            ElseIf unit2 = "k" Then
                ans = (value - 32) * (5 / 9) + 273.15
            End If

        ElseIf unit1 = "k" Then
            If unit2 = "c" Then
                ans = value - 273.15
            ElseIf unit2 = "f" Then
                ans = (value - 273.15) * (9 / 5) + 32
            End If
        End If

        lblA.Text = ans
    End Sub

    'Checks which number button was clicked'
    Sub number(num As String)
        Select Case (num)
            Case 0
                txtNum1.AppendText(0)
            Case 1
                txtNum1.AppendText(1)
            Case 2
                txtNum1.AppendText(2)
            Case 3
                txtNum1.AppendText(3)
            Case 4
                txtNum1.AppendText(4)
            Case 5
                txtNum1.AppendText(5)
            Case 6
                txtNum1.AppendText(6)
            Case 7
                txtNum1.AppendText(7)
            Case 8
                txtNum1.AppendText(8)
            Case 9
                txtNum1.AppendText(9)
            Case "."
                If txtNum1.Text.Contains(".") Then
                    MsgBox("Error: Decimal already in box")
                Else
                    txtNum1.AppendText(".")
                End If
        End Select
    End Sub

    'Handles reset button click'
    Private Sub btnRes_Click(sender As Object, e As EventArgs) Handles btnRes.Click
        combo1.Text = ""
        combo2.Text = ""
        txtNum1.Clear()
        lblA.Text = ""
    End Sub

    'Handles convert button click'
    Private Sub btnConv_Click(sender As Object, e As EventArgs) Handles btnConv.Click
        If String.IsNullOrEmpty(txtNum1.Text) Or String.IsNullOrEmpty(combo1.Text) Or String.IsNullOrEmpty(combo2.Text) Then
            MsgBox("Must fill out all fields")
        Else
            Dim unit1 As String = combo1.Text
            Dim unit2 As String = combo2.Text
            If grpBox.Text = "Distance" Then
                distCalc(unit1, unit2)
            ElseIf grpBox.Text = "Mass" Then
                massCalc(unit1, unit2)
            ElseIf grpBox.Text = "Temperature" Then
                tempCalc(unit1, unit2)
            End If
        End If
    End Sub

    '************************************************** Number Action Listeners **************************************************'
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        number(0)
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        number(1)
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        number(2)
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        number(3)
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        number(4)
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        number(5)
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        number(6)
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        number(7)
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        number(8)
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        number(9)
    End Sub
    Private Sub btnDec_Click(sender As Object, e As EventArgs) Handles btnDec.Click
        number(".")
    End Sub
End Class