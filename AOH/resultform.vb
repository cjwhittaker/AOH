Public Class resultform
    Private Sub confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirm.Click
        If scenariodefaults.phase <= 5 Then scenariodefaults.quit = False
        Me.Close()
    End Sub
    Private Sub resultform_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If scenariodefaults.phase = 1 Then
        '    If p1 = scenariodefaults.player1.Text Then
        '        If supercedes.Checked Then player1_cinc_superceding = True Else player1_cinc_superceding = False
        '        If attached.Checked Then player1_cinc_attached = True Else player1_cinc_attached = False
        '    Else
        '        If supercedes.Checked Then player2_cinc_superceding = True Else player2_cinc_superceding = False
        '        If attached.Checked Then player2_cinc_attached = True Else player2_cinc_attached = False
        '    End If
        'End If

        If scenariodefaults.phase <= 5 And scenariodefaults.quit Then quitprogram()
        If scenariodefaults.phase > 5 Or scenariodefaults.phase = 4 Then
            assign_losses()
            logging(scenariodefaults.gameturn.Text + "," + Text + "," + Replace(result.Text, vbNewLine, " ") + "," + Str(cas) + "," + Str(routed) + "," + Str(captured))
        End If
        cas = 0 : captured = 0 : routed = 0
    End Sub
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub adjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjust.Click
        If Me.Tag <> "" And Not generals Is Nothing And adjust.Text = "Deploy?" Then
            generals(Me.Tag).deployed = True

        ElseIf adjust.Text = "Adjust Cas" Then
            display_adjust_casualties(Tag)
        Else
        End If


    End Sub

    Private Sub assign_losses()
        Dim damaged As Boolean = IIf(InStr(result.Text, "damaged") > 0, True, False)
        Dim wrecked As Boolean = IIf(InStr(result.Text, "wrecked") > 0, True, False)
        'If Not damaged And Not wrecked Then Exit Sub
        Dim y As Integer = IIf(Tag = scenariodefaults.player1.Text, 1, 2)
        If InStr(result.Text, "Locked in Combat") > 0 Then
            losses(y, 1) = losses(y, 1) + 1
            y = IIf(y = 1, 2, 1)
            If arty.Checked Then losses(y, 5) = losses(y, 5) + 1 Else losses(y, 1) = losses(y, 1) + 1
        ElseIf InStr(result.Text, "Shattered!") > 0 Then
            If arty.Checked Then losses(y, 5) = losses(y, 5) + 1
            If leader.Checked Then losses(y, 4) = losses(y, 4) + 1
            losses(y, 2) = losses(y, 2) + routed
            losses(y, 3) = losses(y, 3) + captured
        ElseIf damaged And InStr(result.Text, "Defender Driven Back") > 0 Then
            losses(y, 2) = losses(y, 2) + routed
            If arty.Checked Then losses(y, 5) = losses(y, 5) + 0.5
        ElseIf InStr(result.Text, "Attacker Shattered") Then
            If leader.Checked Then losses(y, 4) = losses(y, 4) + 1
            If y = 1 Then player1_cinc_dead = True Else player2_cinc_dead = True
            losses(y, 2) = losses(y, 2) + routed
            losses(y, 3) = losses(y, 3) + captured
        ElseIf InStr(result.Text, "Attack Driven Back") Then
            losses(y, 2) = losses(y, 2) + routed
        ElseIf damaged Or wrecked Then
            losses(y, 5) = losses(y, 5) + IIf(damaged, 0.5, 1)
        ElseIf InStr(result.Text, "Rout" + vbNewLine) > 0 Then
            calculator.Tag = "rout"
            calculator.ShowDialog()
            losses(y, 2) = losses(y, 2) + routed
        ElseIf InStr(result.Text, "Broken" + vbNewLine) > 0 Then
            routed = 1
            losses(y, 2) = losses(y, 2) + routed
        ElseIf InStr(result.Text, "Desultory Fire") = 0 Then
            losses(y, 1) = losses(y, 1) + cas
        Else
        End If

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reverse.Click
        scenariodefaults.quit = False
        goback = True
        Me.Hide()
    End Sub
    Private Sub first_player_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first_player.Click
        Me.Tag = "First" : Me.Hide()
    End Sub

    Private Sub second_player_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second_player.Click
        Me.Tag = "Second" : Me.Hide()
    End Sub
    Private Sub check_color(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arty.CheckedChanged, leader.CheckedChanged
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa

    End Sub
End Class