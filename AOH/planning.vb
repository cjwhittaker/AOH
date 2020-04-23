Public Class planning
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox8.TextChanged, TextBox15.TextChanged,
        TextBox3.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged, TextBox6.TextChanged, TextBox7.TextChanged, TextBox9.TextChanged,
TextBox10.TextChanged, TextBox11.TextChanged, TextBox12.TextChanged, TextBox13.TextChanged, TextBox14.TextChanged, TextBox16.TextChanged, TextBox17.TextChanged, TextBox18.TextChanged, TextBox19.TextChanged, TextBox20.TextChanged, TextBox21.TextChanged

        If Val(sender.text) > 3 Then sender.text = "0" : Exit Sub
        Dim cat As Integer = Val(Replace(sender.name, "TextBox", ""))
        If cat <= 7 Then
            plan_a.Text = ""
        ElseIf cat > 7 And cat <= 14 Then
            plan_b.Text = ""
        ElseIf cat > 14 And cat <= 21 Then
            plan_c.Text = ""
        Else
        End If
        For Each ctrl As Control In Controls
            If TypeOf ctrl Is TextBox Then
                If cat <= 7 And Val(Replace(ctrl.Name, "TextBox", "")) <= 7 Then
                    plan_a.Text = Val(plan_a.Text) + Val(ctrl.Text)
                ElseIf cat > 7 And cat <= 14 And Val(Replace(ctrl.Name, "TextBox", "")) > 7 And Val(Replace(ctrl.Name, "TextBox", "")) <= 14 Then
                    plan_b.Text = Val(plan_b.Text) + Val(ctrl.Text)
                ElseIf cat > 14 And cat <= 21 And Val(Replace(ctrl.Name, "TextBox", "")) > 14 And Val(Replace(ctrl.Name, "TextBox", "")) <= 21 Then
                    plan_c.Text = Val(plan_c.Text) + Val(ctrl.Text)
                Else
                End If
            End If
        Next
        Dim assessment_complete As Boolean = True
        For Each ctrl As Control In Controls
            If TypeOf ctrl Is TextBox And Val(Replace(ctrl.Name, "TextBox", "")) <= 21 Then
                If ctrl.Text = "0" Or ctrl.Text = "" Then
                    assessment_complete = False : Exit For
                End If
            End If
        Next
        If assessment_complete Then determine_plan.Enabled = True Else determine_plan.Enabled = False
    End Sub

    Private Sub determine_plan_Click(sender As Object, e As EventArgs) Handles determine_plan.Click
        Dim ability As Integer, attitude As Integer, doctrine As String = ""
        For i = 1 To 6
            If plan_criteria(0, i) = generals(player.Text + "CinC").ability Then ability = i
            If plan_criteria(0, i) = generals(player.Text + "CinC").attitude Then attitude = i
        Next
        For Each ctrl As Control In Controls
            If TypeOf ctrl Is TextBox Then
                Dim cat As Integer = Val(Replace(ctrl.Name, "TextBox", ""))
                If cat > 0 And cat <= 7 Then
                    ctrl.Tag = Val(ctrl.Text) * Val(plan_criteria(cat, ability)) * Val(plan_criteria(cat, attitude))
                ElseIf cat > 7 And cat <= 14 Then
                    ctrl.Tag = Val(ctrl.Text) * Val(plan_criteria(cat - 7, ability)) * Val(plan_criteria(cat - 7, attitude))
                ElseIf cat > 14 And cat <= 21 Then
                    ctrl.Tag = Val(ctrl.Text) * Val(plan_criteria(cat - 14, ability)) * Val(plan_criteria(cat - 14, attitude))
                Else
                End If
            End If
        Next
        plan_a.Tag = "" : plan_b.Tag = "" : plan_c.Tag = ""
        For Each ctrl As Control In Controls
            If TypeOf ctrl Is TextBox Then
                Dim cat As Integer = Val(Replace(ctrl.Name, "TextBox", ""))
                If cat > 0 And cat <= 7 Then
                    plan_a.Tag = Val(plan_a.Tag) + Val(ctrl.Tag)
                ElseIf cat > 7 And cat <= 14 Then
                    plan_b.Tag = Val(plan_b.Tag) + Val(ctrl.Tag)
                ElseIf cat > 14 And cat <= 21 Then
                    plan_c.Tag = Val(plan_c.Tag) + Val(ctrl.Tag)
                Else
                End If
            End If
        Next
        If Val(plan_a.Tag) > Val(plan_b.Tag) And Val(plan_a.Tag) > Val(plan_c.Tag) Then
            generals(player.Text + "CinC").plan = "Plan A"
        ElseIf Val(plan_b.Tag) > Val(plan_a.Tag) And Val(plan_b.Tag) > Val(plan_c.Tag) Then
            generals(player.Text + "CinC").plan = "Plan B"
        Else
            generals(player.Text + "CinC").plan = "Plan C"
        End If
        If generals(player.Text + "CinC").attack Then
            For i As Integer = 1 To 3
                If generals(player.Text + "CinC").attitude = oom(0, i) Then
                    For j As Integer = 1 To 3
                        If generals(player.Text + "CinC").ability = oom(j, 0) Then
                            generals(player.Text + "CinC").oom = oom(j, i)
                            i = 3
                            Exit For
                        End If

                    Next
                End If
            Next
        Else
            generals(player.Text + "CinC").oom = "Troops are deployed on table in defensive positions"
        End If
        For Each g As cgeneral In generals
            If g.nation = player.Text Then
                For i As Integer = 1 To 3
                    If g.attitude = attack(0, i) Then
                        For j As Integer = 1 To 3
                            If g.ability = attack(j, 0) Then
                                g.doctrine = IIf(generals(player.Text + "CinC").attack, attack(j, i), defence(j, i))
                                doctrine = doctrine + vbNewLine + g.title + " - " + g.doctrine
                                i = 3
                                Exit For
                            End If
                        Next
                    End If
                Next
            End If
        Next
        generals(player.Text + "CinC").doctrine = Replace(doctrine, vbNewLine, "!")
        With resultform
            .adjust.Visible = False
            .reverse.Visible = False
            .Text = "Plan Selection Phase"
            .result.Text = "Plan Selection Phase" + vbNewLine +
                player.Text + " deploys From the " + generals(player.Text + "CinC").edge + vbNewLine +
                player.Text + " CinC has decided to adopt " + generals(player.Text + "CinC").plan + vbNewLine +
                IIf(generals(player.Text + "CinC").attack, "The Order of March chosen is ", " ") + generals(player.Text + "CinC").oom + doctrine
            .ShowDialog()
            .reverse.Visible = True
            .adjust.Visible = True
        End With
        determine_plan.Enabled = False
    End Sub

    Private Sub planning_Activated(sender As Object, e As EventArgs) Handles Me.Load
        For Each c As Control In Controls
            If TypeOf c Is TextBox And c.Name <> "player" Then c.Text = ""
        Next
        determine_plan.Enabled = True
    End Sub

End Class