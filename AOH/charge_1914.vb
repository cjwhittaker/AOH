Public Class charge_1914
    Dim result As Integer, resetting As Boolean, a As String = "a", d As String = "d", o As Object, s As String
    Private Sub inc_mod(ByVal x, side)
        If side = a Then a_mod.Text = Val(a_mod.Text) + x Else d_mod.Text = Val(d_mod.Text) + x
    End Sub

    Private Sub select_leader(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a_select_leader.Click, d_select_leader.Click
        s = Strings.Left(sender.name, 1)
        If s = a Then o = a_leader Else o = d_leader
        inc_mod(get_modifier(o, {"None", "Leader", "Charismatic Leader"}, 1), s)
    End Sub
    Private Sub toggle_checks(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
a_fresh.Click, a_spent.Click, d_spent.Click, d_fresh.Click
        s = Strings.Left(sender.name, 1)
        Dim effectiveness As String = Strings.Mid(sender.name, 3)
        Dim x As Integer
        If sender.BackColor = Color.Goldenrod Then
            If effectiveness = "fresh" Then
                x = -2
            Else
                x = 2
            End If
            sender.BackColor = DefaultBackColor
        ElseIf effectiveness = "fresh" Then
            If s = a And a_spent.BackColor = Color.Goldenrod Then
                a_spent.BackColor = DefaultBackColor
                x = 4
            ElseIf s = a Then
                x = 2
            ElseIf s = d And d_spent.BackColor = Color.Goldenrod Then
                d_spent.BackColor = DefaultBackColor
                x = 4
            ElseIf s = d Then
                x = 2
            Else
            End If
            sender.backcolor = Color.Goldenrod
        ElseIf effectiveness = "spent" Then
            If s = a And a_fresh.BackColor = Color.Goldenrod Then
                a_fresh.BackColor = DefaultBackColor
                x = -4
            ElseIf s = a Then
                x = -2
            ElseIf s = d And d_fresh.BackColor = Color.Goldenrod Then
                d_fresh.BackColor = DefaultBackColor
                x = -4
            ElseIf s = d Then
                x = -2
            Else
            End If
            sender.backcolor = Color.Goldenrod
        Else
        End If

        inc_mod(x, s)
    End Sub
    Private Sub select_rating(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a_select_rating.Click, d_select_rating.Click
        s = Strings.Left(sender.name, 1)
        If s = a Then o = a_rating Else o = d_rating
        inc_mod(get_modifier(o, {"N/A", "Regular", "Elite"}, 1), s)
    End Sub
    Private Sub select_lancers(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a_lancers.CheckedChanged, d_lancers.CheckedChanged
        If d_ground.Text <> "0" Then sender.Checked = False : Exit Sub
        s = Strings.Left(sender.name, 1)
        If sender.Checked Then inc_mod(1, s) Else inc_mod(-1, s)
    End Sub
    Private Sub select_heavy_cav(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a_heavy.CheckedChanged, d_heavy.CheckedChanged
        s = Strings.Left(sender.name, 1)
        If sender.Checked Then inc_mod(1, s) Else inc_mod(-1, s)
    End Sub
    Private Sub select_armoured_cavd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a_armd.CheckedChanged, d_armd.CheckedChanged
        s = Strings.Left(sender.name, 1)
        If sender.Checked Then inc_mod(2, s) Else inc_mod(-2, s)
    End Sub
    Private Sub select_breakthrough(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a_break.CheckedChanged
        If a_break.Checked Then inc_mod(1, a) Else inc_mod(-1, a)
    End Sub
    Private Sub select_supported(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a_supported.CheckedChanged, d_supported.CheckedChanged
        s = Strings.Left(sender.name, 1)
        If sender.Checked Then inc_mod(1, s) Else inc_mod(-1, s)
    End Sub
    Private Sub select_odds(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a_odds.Click, d_odds.Click
        s = Strings.Left(sender.name, 1)
        If (s = a And d_ratio.Text <> "1:1") Or (s = d And a_ratio.Text <> "1:1") Then Exit Sub
        If s = a Then o = a_ratio Else o = d_ratio
        inc_mod(get_modifier(o, {"1:1", "3:2", "2:1", "3:1", "4:1"}, -1), s)
    End Sub
    Private Sub select_disordered(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a_disorder.CheckedChanged, d_disorder.CheckedChanged
        s = Strings.Left(sender.name, 1)
        If sender.Checked Then inc_mod(-2, s) Else inc_mod(2, s)
    End Sub
    Private Sub select_firefight_Cas(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a_Firefight.Click, d_firefight.Click
        s = Strings.Left(sender.name, 1)
        If s = a Then o = a_cas Else o = d_cas
        inc_mod(get_modifier(o, {"0", "1", "2", "3"}, -1), s)
    End Sub

    Private Sub select_ground(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_select_ground.Click
        inc_mod(get_modifier(d_ground, {"0", "+1", "+2", "+3"}, 1), d)
        If d_ground.Text <> "0" And a_lancers.Checked Then a_lancers.Checked = False : inc_mod(-1, a)
        If d_ground.Text <> "0" And d_lancers.Checked Then d_lancers.Checked = False : inc_mod(-1, d)
    End Sub

    Private Sub select_flanked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_flanked.CheckedChanged
        If d_flanked.Checked Then inc_mod(-3, d) Else inc_mod(3, d)
    End Sub

    Private Sub select_suppressed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_suppressed.CheckedChanged
        If d_suppressed.Checked Then inc_mod(-3, d) Else inc_mod(3, d)
    End Sub
    Private Sub select_french_defenders(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d_french.CheckedChanged
        If d_french.Checked Then inc_mod(1, d) Else inc_mod(-1, d)
    End Sub


    Private Sub Fight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fight.Click
        Dim lost As Integer, a_msg As String, d_msg As String, msg As String, player As String
        Dim ad As Integer = dice(10), dd As Integer = dice(10)
        result = (ad + Val(a_mod.Text)) - (dd + Val(d_mod.Text))
        Dim droll As String = "[" + Str(result) + " =a(" + Str(ad) + " + " + a_mod.Text + ") - d(" + Str(dd) + " + " + d_mod.Text + ")]" + vbNewLine
        If Not display_dice Then droll = ""
        msg = "" : d_msg = "" : a_msg = "" : player = ""
        If result >= 7 Then
            d_msg = "Shattered!" + vbNewLine _
                + "Defender retreats a full move and is disordered/silenced" + vbNewLine _
                + "2 stands Lost, and 1 leader and 1 battery is wrecked if present" + vbNewLine _
            '+ IIf(captured > 0, Str(captured) + " stands/batterys captured", "")
            a_msg = "Attackers breakthrough and must continue to charge a 1/2 move" + vbNewLine + _
                "towards the nearest enemy with the breakthrough modifier"
            player = Defender.Text : lost = 2
        ElseIf result >= 4 Then
            d_msg = "Defender Driven Back" + vbNewLine _
                + "Defender disordered/silenced half move away from the enemy" + vbNewLine _
                + "A battery is silenced and damaged if present" + vbNewLine _
                + "1 stand lost"
            a_msg = "Attackers either occupy the position, or may" + vbNewLine _
                + "breakthrough and continue to charge a 1/2 move" + vbNewLine _
                + "towards the nearest enemy with the breakthrough modifier"
            player = Defender.Text : lost = 1
        ElseIf result >= 1 Then
            d_msg = "Defender Withdraws" + vbNewLine _
                + "Defender retreats one third of a move and is disordered" + vbNewLine _
                + "batterys if present retreat half move silenced"
            a_msg = "Attackers occupy the position"
        ElseIf result = 0 Then
            msg = "Locked in Combat" + vbNewLine _
                + "Both attacker and defender are disordered/silenced" + vbNewLine _
                + "Both lose 1 stand or 1 gun wrecked" + vbNewLine _
                + "Continue the charge combat with new modifiers"
            casualties.p1_cas.Value = casualties.p1_cas.Value + 1
            casualties.p1_cas_c.Text = "[1]"
            casualties.p2_cas.Value = casualties.p2_cas.Value + 1
            casualties.p2_cas_c.Text = "[1]"

        ElseIf result >= -3 Then
            a_msg = "Attacker Withdraws" + vbNewLine _
                + "Attackers retreats one third of a move and is disordered" + vbNewLine
            d_msg = "Defenders hold their position" + vbNewLine + "Infantry in the open form square if victorious against Cavalry"
        ElseIf result >= -6 Then
            a_msg = "Attack Driven Back" + vbNewLine _
                + "Attacker retreats half move and is disordered/silenced" + vbNewLine _
                + "1 stand lost"
            d_msg = "Defenders hold their position"
            player = attacker.Text : lost = 1
        Else
            'If Math.Abs(result) > 10 Then captured = 1 + Math.Abs(result) - 10 Else captured = 1
            a_msg = "Attacker Shattered" + vbNewLine _
                + "Attackers retreats a full move and is disordered/silenced, 2 stands lost" + vbNewLine _
                + "A leader is captured if present" + vbNewLine _
            '+ IIf(captured > 0, Str(captured) + " stands captured", "")

            d_msg = "Defenders hold their position"
            player = attacker.Text : lost = 2

        End If
        If result <> 0 Then
            If player = scenariodefaults.player1.Text Then
                casualties.p1_cas.Value = casualties.p1_cas.Value + lost
            Else
                casualties.p2_cas.Value = casualties.p2_cas.Value + lost
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
        resultform.reverse.Visible = False
        If result = 0 Then
            resultform.result.Text = droll + msg
            resultform.ShowDialog()
        ElseIf result > 0 Then
            With resultform
                .arty.Visible = True
                .result.Text = droll + d_msg
                .ShowDialog()
                .result.Text = droll + a_msg
                .arty.Visible = False
                .ShowDialog()
                .arty.Visible = True
            End With
        Else
            With resultform
                .result.Text = droll + a_msg
                .ShowDialog()
                .result.Text = droll + d_msg
                .ShowDialog()
            End With
        End If
        With resultform
            .Tag = ""
            .arty.Visible = False
            .leader.Visible = False
            .reverse.Visible = True
        End With
        reset_defaults()
    End Sub

    Private Sub reset_defaults()
        a_leader.Text = "None"
        a_disorder.Checked = False
        a_ratio.Text = "1:1"
        a_rating.Text = "N/A"
        a_lancers.Checked = False
        a_heavy.Checked = False
        a_armd.Checked = False
        a_supported.Checked = False
        a_fresh.Checked = False
        a_spent.Checked = False
        a_cas.Text = "0"
        d_fresh.Checked = False
        d_spent.Checked = False
        d_leader.Text = "None"
        d_disorder.Checked = False
        d_ratio.Text = "1:1"
        d_rating.Text = "N/A"
        d_lancers.Checked = False
        d_heavy.Checked = False
        d_armd.Checked = False
        d_supported.Checked = False
        d_cas.Text = "0"
        d_flanked.Checked = False
        d_suppressed.Checked = False
        d_french.Checked = False
        d_ground.Text = "0"
        a_break.Checked = False
        a_mod.Text = "0"
        d_mod.Text = "0"
        For Each c As Control In Me.Controls
            If c.BackColor = golden Then c.BackColor = defa
        Next
    End Sub
    Private Sub check_color(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        a_disorder.CheckedChanged, a_lancers.CheckedChanged, a_heavy.CheckedChanged, a_armd.CheckedChanged,
a_supported.CheckedChanged, d_disorder.CheckedChanged, d_heavy.CheckedChanged, d_armd.CheckedChanged,
d_supported.CheckedChanged, d_flanked.CheckedChanged, a_break.CheckedChanged, d_lancers.CheckedChanged, d_french.CheckedChanged, d_suppressed.CheckedChanged

        If sender.checked Then sender.backcolor = Color.Goldenrod Else sender.backcolor = Control.DefaultBackColor

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