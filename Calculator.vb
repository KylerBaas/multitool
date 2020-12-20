' MultiTool - Calculator '
' Created by Kyler Baas '
' December 15, 2019 '

Public Class Calculator

    'Checks if data in the textboxes are valid'
    Sub verify(ByRef num1 As Decimal, ByRef num2 As Decimal)
        Try
            num1 = txtNum1.Text
            num2 = txtNum2.Text
        Catch ex As Exception
            MsgBox("Error: Invalid data!")
            txtNum2.Clear()
        End Try
    End Sub

    'Runs the algorithm for the calculations'
    Sub algo(op As Integer)
        Dim num1, num2 As Decimal
        Dim ans As Nullable(Of Decimal)
        Dim b As Boolean = False

        verify(num1, num2)

        While b = False
            If ans.HasValue Then
                txtNum1.Text = ans
                txtNum2.Clear()
                b = True
            Else
                Select Case (op)
                    Case 0 'Add'
                        ans = num1 + num2
                    Case 1 'Subtract'
                        ans = num1 - num2
                    Case 2 'Multiply'
                        ans = num1 * num2
                    Case 3 'Divide'
                        If (num2 = 0) Then
                            MsgBox("Error: Cannot divide by 0!")
                            txtNum2.Clear()
                            b = True
                        Else
                            ans = num1 / num2
                        End If
                    Case 4 'Exponent'
                        Try
                            ans = num1 ^ num2
                        Catch ex As Exception
                            MsgBox("Error: Number too large to compute!")
                            txtNum2.Clear()
                            b = True
                        End Try
                End Select
            End If
        End While
    End Sub

    'Checks which number button was clicked'
    Sub number(num As String)
        If btnSwiClicked Then
            Select Case (num)
                Case 0
                    txtNum2.AppendText(0)
                Case 1
                    txtNum2.AppendText(1)
                Case 2
                    txtNum2.AppendText(2)
                Case 3
                    txtNum2.AppendText(3)
                Case 4
                    txtNum2.AppendText(4)
                Case 5
                    txtNum2.AppendText(5)
                Case 6
                    txtNum2.AppendText(6)
                Case 7
                    txtNum2.AppendText(7)
                Case 8
                    txtNum2.AppendText(8)
                Case 9
                    txtNum2.AppendText(9)
                Case "."
                    If txtNum2.Text.Contains(".") Then
                        MsgBox("Error: Decimal already in box")
                    Else
                        txtNum2.AppendText(".")
                    End If
            End Select
        Else
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
        End If



    End Sub

    '************************************************** Operator Action Listeners **************************************************'
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        algo(0)
    End Sub
    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        algo(1)
    End Sub
    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        algo(2)
    End Sub
    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        algo(3)
    End Sub
    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        algo(4)
    End Sub
    'Check for switch button click'
    Dim btnSwiClicked As Boolean = False

    'Handles switch button click'
    Private Sub btnSwi_Click(sender As Object, e As EventArgs) Handles btnSwi.Click
        If String.IsNullOrEmpty(txtNum1.Text) Then
            MsgBox("Input number in the left textbox first")
        Else
            btnSwiClicked = True
            lblBox1.Visible = False
            lblBox2.Visible = True
            btnSwi.Enabled = False
        End If
    End Sub

    'Handles reset button click'
    Private Sub btnRes_Click(sender As Object, e As EventArgs) Handles btnRes.Click
        txtNum1.Clear()
        txtNum2.Clear()
        btnSwiClicked = False
        lblBox1.Visible = True
        lblBox2.Visible = False
        btnSwi.Enabled = True
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