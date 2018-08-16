Public Class calculator
    Dim entering As Boolean = False
    Private Sub multiplier_Click(sender As Object, e As EventArgs) Handles multiplier.Click
        If multiplier.Text = "1" Then
            multiplier.Text = "2"
        ElseIf multiplier.Text = "2" Then
            multiplier.Text = "0.5"
        ElseIf multiplier.Text = "0.5" Then
            multiplier.Text = "1"
        Else
        End If
        calc_pts()
    End Sub
    Private Sub calc_pts()
        If Me.Tag = "1" Then
            points.Text = (Val(factor.Text) * Val(multiplier.Text) * Val(elements.Text))
        Else
            routers.Text = elements.Text
        End If
    End Sub

    Private Sub clear_elements(sender As Object, e As EventArgs) Handles c.Click
        If Me.Tag = "1" Then elements.Text = 1 : calc_pts() Else routers.Text = ""
        entering = False
    End Sub

    Private Sub add_elements(sender As Object, e As EventArgs) Handles b1.Click, b2.Click, b3.Click, b4.Click, b5.Click, b6.Click, b7.Click, b8.Click, b9.Click, b0.Click
        If Not entering Then
            entering = True
            elements.Text = sender.text
        Else
            elements.Text = elements.Text + sender.text
        End If
        calc_pts()
    End Sub

    Private Sub add_firepoints(sender As Object, e As EventArgs) Handles add.Click
        Firing_AOE.firepoints.Text = Val(Firing_AOE.firepoints.Text) + Val(points.Text)
        Firing_AOE.adjustfirepoints.Value = Val(Firing_AOE.firepoints.Text)
        Me.Hide()
    End Sub

    Private Sub calculator_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        calc_pts()
        entering = False
        If Me.Tag = "rout" Then
            For Each c As Control In Me.Controls
                If c.Tag <> "c" Then c.Visible = False
            Next
            routers.Visible = True
            add_routers.Visible = True
            routers.Text = "0"
            Me.Width = 224
            Me.Text = "Add Routers"
        Else
            For Each c As Control In Me.Controls
                c.Visible = True
            Next
            routers.Visible = False
            add_routers.Visible = False
            Me.Width = 344
            Me.Text = "Fire Points calculator"

        End If

    End Sub
    Private Sub calculator_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Me.Tag = "rout" Then
            For Each c As Control In Me.Controls
                If c.Tag <> "c" Then c.Visible = True
            Next
            routers.Visible = False
            add_routers.Visible = False
            Me.Width = 334
            Me.Text = "Fire Points Calculator"
        End If

    End Sub

    Private Sub add_routers_Click(sender As Object, e As EventArgs) Handles add_routers.Click
        tactical.runaway = Val(routers.Text)
        Me.Hide()
    End Sub
End Class