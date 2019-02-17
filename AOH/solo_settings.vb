Public Class solo_settings
    Dim selected_row As String = "", new_e As Boolean, newgen As cgeneral
    Private Sub resize_label(sender As Object, e As MouseEventArgs) Handles poor.MouseClick, cautious.MouseClick, bold.MouseClick, average.MouseClick, skilled.MouseClick, aggressive.MouseClick
        Dim obj As Label = sender, obj_l As Label = obj, obj_r As Label = obj
        If sender.name = "poor" Or sender.name = "average" Or sender.name = "skilled" Then
            If obj.Name = "poor" Then obj_r = average : obj_l = obj_r
            If obj.Name = "average" Then obj_r = skilled : obj_l = poor
            If obj.Name = "skilled" Then obj_l = average : obj_r = obj_l
            If e.X <= obj.Width / 2 And (obj.Name = "average" Or obj.Name = "skilled") Then obj.Tag = "left"
            If e.X > obj.Width / 2 And (obj.Name = "poor" Or obj.Name = "average") Then obj.Tag = "right"

        Else
            If obj.Name = "cautious" Then obj_r = bold : obj_l = obj_r
            If obj.Name = "bold" Then obj_r = aggressive : obj_l = cautious
            If obj.Name = "aggressive" Then obj_l = bold : obj_r = obj_l
            If e.X <= obj.Width / 2 And (obj.Name = "bold" Or obj.Name = "aggressive") Then obj.Tag = "left"
            If e.X > obj.Width / 2 And (obj.Name = "cautious" Or obj.Name = "bold") Then obj.Tag = "right"
        End If
        If obj.Tag = "left" And obj_l.Width > 20 Then
            obj.Width = obj.Width + 20
            obj_l.Width = obj_l.Width - 20
            obj.Left = obj.Left - 20
        ElseIf obj.Tag = "right" And obj_r.Width > 20 Then
            obj.Width = obj.Width + 20
            obj_r.Width = obj_r.Width - 20
            obj_r.Left = obj_r.Left + 20
        Else
        End If
        obj = Nothing
        obj_l = Nothing
        obj_r = Nothing
    End Sub
    Private Sub me_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        enable_edits(False)
        If generals Is Nothing Then
            settings(True)
            edit_comd.Enabled = False
            delete_comd.Enabled = False
            generals_list.Enabled = False
            strength.Enabled = False
            title.Enabled = False
            reset_sliders()
            generals = New Collection
        ElseIf Not generals.Contains(player.Text + "CinC") Then
            settings(True)
            edit_comd.Enabled = False
            delete_comd.Enabled = False
            generals_list.Enabled = False
            strength.Enabled = False
            title.Enabled = False
            generals_list.Items.Clear()
            reset_sliders()
        Else
            If player.Text = scenariodefaults.player1.Text Then
                poor.Width = p1_poor * 4
                average.Width = (p1_average - p1_poor) * 4
                cautious.Width = p1_cautious * 4
                bold.Width = (p1_bold - p1_cautious) * 4
            Else
                poor.Width = p2_poor * 4
                average.Width = (p2_average - p2_poor) * 4
                cautious.Width = p2_cautious * 4
                bold.Width = (p2_bold - p2_cautious) * 4
            End If
            average.Left = poor.Width + poor.Left
            skilled.Left = average.Left + average.Width
            skilled.Width = 400 - (poor.Width + average.Width)
            bold.Left = cautious.Width + cautious.Left
            aggressive.Left = bold.Left + bold.Width
            aggressive.Width = 400 - (cautious.Width + bold.Width)
            If generals(player.Text + "CinC").mission <> "" Then mission.Text = generals(player.Text + "CinC").mission
            settings(False)
            populate_generals()
        End If

        'If event_list Is Nothing Then
        '    Dim event_list As New Collection
        'End If
    End Sub
    Private Sub reset_sliders()
        poor.Left = 100
        poor.Width = 120
        average.Left = 220
        average.Width = 160
        skilled.Left = 380
        skilled.Width = 120
        cautious.Left = 100
        cautious.Width = 120
        bold.Left = 220
        bold.Width = 160
        aggressive.Left = 380
        aggressive.Width = 120

    End Sub
    Public Sub enable_command_decisions(setting As Boolean)
        If setting Then Me.Text = "Solo Command Decisions" Else Me.Text = "Solo Command Settings"
        new_comd.Enabled = Not setting
        delete_comd.Enabled = Not setting
        edit_comd.Enabled = Not setting
        discard_comd.Enabled = Not setting
        save_comd.Enabled = Not setting
        command_decisions.Enabled = setting
        new_comd.Visible = Not setting
        delete_comd.Visible = Not setting
        edit_comd.Visible = Not setting
        discard_comd.Visible = Not setting
        save_comd.Visible = Not setting
        command_decisions.Visible = setting
        comd_name.Visible = Not setting
        title.Visible = Not setting
        comd_strength.Visible = Not setting
        strength.Visible = Not setting
        poor.Visible = Not setting
        average.Visible = Not setting
        skilled.Visible = Not setting
        cautious.Visible = Not setting
        bold.Visible = Not setting
        aggressive.Visible = Not setting
        Label1.Visible = Not setting
        Label2.Visible = Not setting

    End Sub
    Private Sub populate_generals()
        generals_list.Items.Clear()
        If generals.Count = 0 Then Exit Sub
        For Each g As cgeneral In generals
            If g.nation = player.Text Then
                Dim lv As ListViewItem
                lv = New ListViewItem
                With lv
                    .Text = g.title
                    .SubItems.Add(g.ability)
                    .SubItems.Add(g.attitude)
                    .SubItems.Add(g.strength)
                    .SubItems.Add(g.casualties)
                End With
                generals_list.Items.Add(lv)
            End If
        Next

    End Sub
    Private Sub generals_list_Selection(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generals_list.Click
        If generals.Count = 0 Then selected_row = "" : Exit Sub
        selected_row = player.Text + generals_list.FocusedItem.Text
        'Dim x As Integer = selected_row
    End Sub

    Private Sub new_comd_Click(sender As Object, e As EventArgs) Handles new_comd.Click
        If Not generals.Contains(player.Text + "CinC") And poor.Enabled = True Then
            settings(False)
            If player.Text = scenariodefaults.player1.Text Then
                p1_poor = poor.Width / 4
                p1_average = average.Width / 4 + poor.Width / 4
                p1_cautious = cautious.Width / 4
                p1_bold = bold.Width / 4 + cautious.Width / 4
            Else
                p2_poor = poor.Width / 4
                p2_average = average.Width / 4 + poor.Width / 4
                p2_cautious = cautious.Width / 4
                p2_bold = bold.Width / 4 + cautious.Width / 4
            End If
            title.Text = "CinC"
            strength.Text = IIf(player.Text = scenariodefaults.player1.Text, scenariodefaults.player1_stands.Text, scenariodefaults.player2_stands.Text)
            newgen = New cgeneral
            save_comd_Click(save_comd, Nothing)
        Else
            newgen = New cgeneral
            'v.reset()
            title.Enabled = True
            strength.Enabled = True
            'generals.Add(g)
            'selected_row = generals.Count
            enable_edits(True)
            new_e = True

        End If

    End Sub
    Private Sub edit_comd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_comd.Click
        If selected_row <> "" And generals.Count <> 0 Then
            Dim g As New cgeneral
            g = generals(selected_row)
            title.Enabled = True
            strength.Enabled = True
            title.Text = g.title
            If title.Text = "CinC" Then title.Enabled = False
            strength.Text = g.strength
            enable_edits(True)
        End If


    End Sub
    Private Sub enable_edits(ByVal setting As Boolean)
        generals_list.Enabled = Not setting
        delete_comd.Enabled = Not setting
        edit_comd.Enabled = Not setting
        new_comd.Enabled = Not setting
        save_comd.Enabled = setting
        discard_comd.Enabled = setting
    End Sub

    Private Sub settings(setting As Boolean)
        poor.Enabled = setting
        average.Enabled = setting
        skilled.Enabled = setting
        cautious.Enabled = setting
        bold.Enabled = setting
        aggressive.Enabled = setting
        mission.Enabled = setting
    End Sub

    Private Sub delete_comd_Click(sender As Object, e As EventArgs) Handles delete_comd.Click
        If selected_row <> "" And selected_row <> player.Text + "CinC" Then
            generals.Remove(selected_row)
            'generals_list.Clear()
            populate_generals()
        End If
        selected_row = ""
    End Sub

    Private Sub discard_comd_Click(sender As Object, e As EventArgs) Handles discard_comd.Click
        If selected_row <> "" And selected_row <> player.Text + "CinC" Then
            If new_e Then
                generals.Remove(selected_row)
                new_e = False
            End If
            selected_row = ""
        End If
        title.Enabled = False
        title.Text = ""
        strength.Enabled = False
        strength.Text = ""
        enable_edits(False)

    End Sub


    Private Sub save_comd_Click(sender As Object, e As EventArgs) Handles save_comd.Click
        If (title.Text <> "" And strength.Text <> "") Or title.Text = "CinC" Then
            If generals.Contains(selected_row) Then
                With generals(selected_row)
                    .title = title.Text
                    .strength = strength.Text
                End With
            Else
                Dim dice1 As Integer = dice(100), dice2 As Integer = dice(100)
                With newgen
                    .nation = player.Text
                    .title = title.Text
                    .strength = Val(strength.Text)
                    .ability = IIf(.ability = "", IIf(dice1 <= poor.Width / 4, "Poor", IIf(dice1 <= poor.Width / 4 + average.Width / 4, "Average", "Skilled")), .ability)
                    .attitude = IIf(.attitude = "", IIf(dice2 <= cautious.Width / 4, "Cautious", IIf(dice2 <= cautious.Width / 4 + bold.Width / 4, "Bold", "Aggressive")), .attitude)
                    .mission = IIf(mission.Text = "", "Advance", mission.Text)
                End With
                generals.Add(newgen, player.Text + newgen.title)
            End If
            populate_generals()
            selected_row = ""
        End If
        title.Enabled = False
        title.Text = ""
        strength.Enabled = False
        strength.Text = ""
        enable_edits(False)

    End Sub

    Private Sub generate_command_decisions()
        Dim m As String = "", dice_roll As Integer = 0, cas_rate As Integer = 0, must_deploy As Boolean = False
        If generals.Count = 0 Then
        End If
        For Each g As cgeneral In generals
            If g.nation = player.Text Then
                dice_roll = dice(100)
                For i As Integer = 1 To 3
                    m = ""
                    If losses(0, i) = g.attitude Then
                        For j As Integer = 1 To 24
                            If Not g.deployed And g.attack And dice_roll <= Val(deployment(j, i)) Then
                                m = g.title + " - must deploy into battle formation if there is enemy in sight within " + Str(deployment(j, 0)) + vbNewLine
                                Exit For
                            End If
                        Next
                        If Not g.defensive And g.attack Then
                            cas_rate = Int(1 + 20 * (g.casualties / g.strength))
                            If cas_rate > 13 Then cas_rate = 13
                            If dice_roll <= Val(losses(cas_rate, i)) Then m = m + g.title + " - orders a halt to the attack and to adopt defensive positions" + vbNewLine
                            g.defensive = True
                            Exit For
                        ElseIf g.defence Then
                            cas_rate = Int(1 + 24 * (g.casualties / g.strength))
                            If cas_rate > 13 Then cas_rate = 13
                            If dice_roll <= Val(losses(cas_rate, i)) Then m = m + g.title + " - orders the withdrawal to a reserve defensive position" + vbNewLine
                            Exit For
                        ElseIf g.delay Then
                            cas_rate = Int(1 + 40 * (g.casualties / g.strength))
                            If cas_rate > 13 Then cas_rate = 13
                            If dice_roll <= Val(losses(cas_rate, i)) Then m = m + g.title + " - orders the withdrawal to the next delaying position" + vbNewLine
                            Exit For
                        Else
                        End If
                    End If

                Next
                If InStr(m, "must deploy") > 0 Then must_deploy = True Else must_deploy = False

                With My.Forms.resultform
                    .adjust.Visible = IIf(must_deploy, True, False)
                    .adjust.Text = IIf(must_deploy, "Deploy?", resultform.adjust.Text)
                    .Tag = IIf(must_deploy, player.Text + g.title, "")
                    .Text = player.Text + " Solo Command Decisions"
                    .confirm.Visible = True
                    .reverse.Visible = False
                    .result.Text = player.Text + " Solo Command Decisions" + vbNewLine + IIf(m = "", g.title + " - No Command Interventions and Decisions this turn", m)
                    .ShowDialog()
                    .adjust.Visible = False
                    .confirm.Visible = True
                End With
            End If
        Next
        With resultform
            .adjust.Visible = True
            .adjust.Text = "Adjust Cas"
            .confirm.Visible = True
            .reverse.Visible = True

        End With
        Me.Close()

    End Sub

    Private Sub title_TextChanged(sender As Object, e As EventArgs) Handles title.TextChanged
        If title.Text = "" Or generals.Count > 0 Then Exit Sub
        If generals.Contains(player.Text + title.Text) Then title.Text = ""
    End Sub

    Private Sub command_decisions_Click(sender As Object, e As EventArgs) Handles command_decisions.Click
        generate_command_decisions()
    End Sub


    Private Sub generals_list_MouseClick(sender As Object, e As MouseEventArgs) Handles generals_list.MouseClick
        If selected_row = "" Or Not command_decisions.Visible Then Exit Sub
        If e.X <= generals_list.Width / 2 And generals(selected_row).casualties > 0 Then
            generals(selected_row).casualties = generals(selected_row).casualties - 1
            generals_list.FocusedItem.SubItems(4).Text = generals(selected_row).casualties
        ElseIf e.X > generals_list.Width / 2 Then
            generals(selected_row).casualties = generals(selected_row).casualties + 1
            generals_list.FocusedItem.SubItems(4).Text = generals(selected_row).casualties
        Else
        End If
    End Sub

    Private Sub solo_settings_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not generals.Contains(player.Text + "CinC") And poor.Enabled = True Then
            new_comd_Click(new_comd, Nothing)
        End If
    End Sub
End Class