Public Class ConvChoice
    Private Sub btnDistance_Click(sender As Object, e As EventArgs) Handles btnDistance.Click
        Dim c = New Converter()
        c.grpBox.Text = "Distance"

        c.combo1.Items.Clear()
        c.combo2.Items.Clear()

        c.combo1.Items.Add("cm")
        c.combo1.Items.Add("m")
        c.combo1.Items.Add("km")
        c.combo1.Items.Add("in")
        c.combo1.Items.Add("ft")
        c.combo1.Items.Add("mi")

        c.combo2.Items.Add("cm")
        c.combo2.Items.Add("m")
        c.combo2.Items.Add("km")
        c.combo2.Items.Add("in")
        c.combo2.Items.Add("ft")
        c.combo2.Items.Add("mi")

        c.Show()
    End Sub

    Private Sub btnMass_Click(sender As Object, e As EventArgs) Handles btnMass.Click
        Dim c = New Converter()
        c.grpBox.Text = "Mass"

        c.combo1.Items.Clear()
        c.combo2.Items.Clear()

        c.combo1.Items.Add("g")
        c.combo1.Items.Add("kg")
        c.combo1.Items.Add("oz")
        c.combo1.Items.Add("lb")

        c.combo2.Items.Add("g")
        c.combo2.Items.Add("kg")
        c.combo2.Items.Add("oz")
        c.combo2.Items.Add("lb")

        c.Show()
    End Sub

    Private Sub btnTemp_Click(sender As Object, e As EventArgs) Handles btnTemp.Click
        Dim c = New Converter()
        c.grpBox.Text = "Temperature"

        c.combo1.Items.Clear()
        c.combo2.Items.Clear()

        c.combo1.Items.Add("c")
        c.combo1.Items.Add("f")
        c.combo1.Items.Add("k")

        c.combo2.Items.Add("c")
        c.combo2.Items.Add("f")
        c.combo2.Items.Add("k")

        c.Show()
    End Sub
End Class