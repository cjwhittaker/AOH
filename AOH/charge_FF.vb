Public Class charge_FF
    Dim result As Integer, resetting As Boolean, a As String = "a", d As String = "d", o As Object, s As String
    Private Sub inc_mod(ByVal x, side)
        If side = a Then a_mod.Text = Val(a_mod.Text) + x Else d_mod.Text = Val(d_mod.Text) + x
    End Sub

    Private Sub toggle_checks(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    a_fresh.CheckedChanged, a_spent.CheckedChanged, d_spent.CheckedChanged, d_fresh.CheckedChanged
        If Not sender.checked Then Exit Sub
        If sender.name = "a_fresh" Then
            a_spent.Checked = False
        ElseIf sender.name = "a_spent" Then
            a_fresh.Checked = False
        ElseIf sender.name = "d_fresh" Then
            d_spent.Checked = False
        ElseIf sender.name = "d_spent" Then
            d_fresh.Checked = False
        Else
        End If
    End Sub
    Private Sub check_color(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        a_spent.CheckedChanged, a_fresh.CheckedChanged, d_spent.CheckedChanged, d_fresh.CheckedChanged,
        a_leaders.CheckedChanged, d_leaders.CheckedChanged, a_confed.CheckedChanged, a_break.CheckedChanged,
        a_mounted.CheckedChanged, a_supported.CheckedChanged, a_lowammo.CheckedChanged, a_disorder.CheckedChanged,
        d_flanked.CheckedChanged, d_mounted.CheckedChanged, d_supported.CheckedChanged, d_lowammo.CheckedChanged, d_disorder.CheckedChanged

        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa

    End Sub
    Private Sub increment_factors(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        a_spent.CheckedChanged, a_fresh.CheckedChanged, d_spent.CheckedChanged, d_fresh.CheckedChanged,
        a_leaders.CheckedChanged, d_leaders.CheckedChanged, a_confed.CheckedChanged, a_break.CheckedChanged,
        a_mounted.CheckedChanged, a_supported.CheckedChanged, a_lowammo.CheckedChanged, a_disorder.CheckedChanged,
        d_flanked.CheckedChanged, d_mounted.CheckedChanged, d_supported.CheckedChanged, d_lowammo.CheckedChanged, d_disorder.CheckedChanged
        s = Strings.Left(sender.name, 1)
        inc_mod(IIf(sender.checked, 1, -1) * Val(sender.tag), s)
    End Sub

    Private Sub select_odds(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a_odds.Click, d_odds.Click
        s = Strings.Left(sender.name, 1)
        If (s = a And d_ratio.Text <> "1:1") Or (s = d And a_ratio.Text <> "1:1") Then Exit Sub
        If s = a Then o = a_ratio Else o = d_ratio
        inc_mod(get_modifier(o, {"1:1", "3:2", "2:1", "3:1", "4:1"}, -1), s)
    End Sub
    Private Sub select_firefight_cas(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a_Firefight.Click, d_firefight.Click
        s = Strings.Left(sender.name, 1)
        If s = a Then o = a_cas Else o = d_cas
        inc_mod(get_modifier(o, {"0", "1", "2", "3"}, -1), s)
    End Sub
    Private Sub select_defences(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_ground.Click, d_linear.Click
        If sender.name = "d_ground" Then o = def1 Else o = def2
        inc_mod(get_modifier(o, {"0", "+1", "+2", "+3"}, 1), d)
    End Sub

    Private Sub Fight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fight.Click
        Dim captured As Integer, skeddadled As Integer, msg As String, d_msg As String, a_msg As String, player As String
        Dim ad As Integer = dice(10), dd As Integer = dice(10)
        result = (ad + Val(a_mod.Text)) - (dd + Val(d_mod.Text))
        a_msg = "" : d_msg = "" : msg = "" : player = ""
        Dim droll As String = "[" + Str(result) + " =a(" + Str(ad) + " + " + a_mod.Text + ") - d(" + Str(dd) + " + " + d_mod.Text + ")]" + vbNewLine
        If Not display_dice Then droll = ""

        If result >= 7 Then
            If result > 10 Then captured = 1 + result - 10 Else captured = 1
            d_msg = "Defender Swept from the Field" + vbNewLine _
                + "Defender retreats a full move and is disordered/silenced" + vbNewLine _
                + "A leader/battery is captured if present" + vbNewLine _
                + Str(captured) + " stands captured, 1 stand skedaddles"
            msg = "Attackers breakthrough and must continue to charge a 1/2 move" + vbNewLine +
                "towards the nearest enemy with the breakthrough modifier"
            player = Defender.Text : captured = captured : skeddadled = 1
        ElseIf result >= 4 Then
            d_msg = "Defender Driven Back" + vbNewLine _
                + "Defender retreats beyond musketry range and is disordered/silenced" + vbNewLine _
                + "A battery is damaged if present" + vbNewLine _
                + "1 stand skedaddles"
            msg = "Attackers either carry the position, or may" + vbNewLine _
                + "breakthrough and continue to charge a 1/2 move" + vbNewLine _
                + "towards the nearest enemy with the breakthrough modifier"
            player = Defender.Text : captured = 0 : skeddadled = 1
        ElseIf result >= 1 Then
            d_msg = "Defender Hard Pressed" + vbNewLine _
                + "Defender retreats 2 inches and is disordered" + vbNewLine _
                + "batterys if present retreat beyond musketry range silenced"
            msg = "Attackers carry the position"
        ElseIf result = 0 Then
            msg = "A desperate struggle ensues" + vbNewLine _
                + "Both attacker and defnder are disordered" + vbNewLine _
                + "Both lose 1 stand or 1 gun" + vbNewLine _
                + "Continue the charge combat with new modifiers"
            casualties.p1_cas.Value = casualties.p1_cas.Value + 1
            casualties.p1_cas_c.Text = "[1]"
            casualties.p2_cas.Value = casualties.p2_cas.Value + 1
            casualties.p2_cas_c.Text = "[1]"

        ElseIf result >= -3 Then
            msg = "Assault has been checked" + vbNewLine _
                + "Attackers retreats 2 inches and is disordered" + vbNewLine
            d_msg = "Defenders hold their position"
        ElseIf result >= -6 Then
            msg = "Attack Falters" + vbNewLine _
                + "Attacker retreats beyond musketry range and is disordered/silenced" + vbNewLine _
                + "1 stand skedaddles"
            d_msg = "Defenders hold their position"
            player = attacker.Text : captured = 0 : skeddadled = 1
        Else
            If Math.Abs(result) > 10 Then captured = 1 + Math.Abs(result) - 10 Else captured = 1
            msg = "Charge Repulsed" + vbNewLine _
                + "Attackers retreats a full move and is disordered" + vbNewLine _
                + "A leader is captured if present" + vbNewLine _
                + Str(captured) + " stands captured, 1 stand skedaddles"

            d_msg = "Defenders hold their position"
            player = attacker.Text : captured = captured : skeddadled = 1

        End If
        If result <> 0 Then
            If player = scenariodefaults.player1.Text Then
                casualties.p1_ske.Value = casualties.p1_ske.Value + skeddadled
                casualties.p1_cap.Value = casualties.p1_cap.Value + captured
            Else
                casualties.p2_ske.Value = casualties.p2_ske.Value + skeddadled
                casualties.p2_cap.Value = casualties.p2_cap.Value + captured
            End If
        End If
        If result >= 7 Then
            resultform.arty.Visible = True
            resultform.leader.Visible = True
        ElseIf result >= 4 Then
            resultform.arty.Visible = True
        ElseIf result < -6 Then
            resultform.leader.Visible = True
        Else
        End If
        resultform.Tag = player
        If result = 0 Then
            resultform.result.Text = droll + msg
            resultform.ShowDialog()
        ElseIf result > 0 Then
            With resultform
                .result.Text = droll + d_msg
                .ShowDialog()
                .result.Text = droll + msg
                .arty.Checked = False
                .arty.Visible = False
                .ShowDialog()
            End With
        Else
            With resultform
                .result.Text = droll + msg
                .arty.Visible = False
                .ShowDialog()
                .arty.Visible = True
                .result.Text = droll + d_msg
                .ShowDialog()
            End With
        End If
        With resultform
            .Tag = ""
            .arty.Visible = False
            .leader.Visible = False
        End With
        update_casualties(player)
        reset_defaults()
    End Sub

    Private Sub reset_defaults()
        a_leaders.Checked = False
        a_disorder.Checked = False
        a_ratio.Text = "1:1"
        a_fresh.Checked = False
        a_spent.Checked = False
        a_mounted.Checked = False
        a_supported.Checked = False
        a_lowammo.Checked = False
        a_cas.Text = "0"
        d_leaders.Checked = False
        d_disorder.Checked = False
        d_ratio.Text = "1:1"
        d_fresh.Checked = False
        d_spent.Checked = False
        d_mounted.Checked = False
        d_supported.Checked = False
        d_lowammo.Checked = False
        d_cas.Text = "0"
        d_flanked.Checked = False
        def1.Text = "0"
        def2.Text = "0"
        a_confed.Checked = False
        a_break.Checked = False
        a_mod.Text = "0"
        d_mod.Text = "0"
        For Each c As Control In Me.Controls
            If c.BackColor = golden Then c.BackColor = defa
        Next

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        reset_defaults()
    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        reset_defaults()

    End Sub

    Private Sub adjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjust.Click
        casualties.ShowDialog()

    End Sub

    Private Sub nextphase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextphase.Click
        scenariodefaults.quit = False
        Me.Hide()
    End Sub

    Private Sub charge_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If scenariodefaults.quit Then quitprogram()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        scenariodefaults.quit = False
        goback = True
        Me.Hide()
    End Sub
End Class