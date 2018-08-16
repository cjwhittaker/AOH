Public Class Firing_FF


    Private Sub resetform()
        heavycover.Checked = False
        lightcover.Checked = False
        Targetmode.Checked = False
        Artillery.Checked = False
        adjustfirepoints.Value = 0
    End Sub

    Private Sub toggle_check(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lightcover.CheckedChanged, heavycover.CheckedChanged

        If Not sender.Checked Then Exit Sub
        If sender.name = "heavycover" Then
            lightcover.Checked = False
        ElseIf sender.name = "lightcover" Then
            heavycover.Checked = False
        Else

        End If
    End Sub

    Private Sub check_color(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        lightcover.CheckedChanged, heavycover.CheckedChanged, Targetmode.CheckedChanged, Artillery.CheckedChanged
        If sender.checked Then sender.backcolor = Color.Goldenrod Else sender.backcolor = Control.DefaultBackColor

    End Sub

    Private Sub fire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fire.Click
        Dim x As Integer, cas As Single, modifier As Integer, result As Integer, msg As String, fire_eff As String
        modifier = 0
        If heavycover.Checked Then modifier = modifier - 2
        If lightcover.Checked Then modifier = modifier - 1
        If Targetmode.Checked Then modifier = modifier + 1
        cas = 0
        result = dice(10)
        x = 2 + result + modifier
        If x < 1 Then x = 1
        If x > 13 Then x = 13
        Dim effect As Integer = 0, f As Integer = Val(firepoints.Text)
        If f > 50 Then f = 50
        If f <= 0 Then f = 0
        Dim droll As String = "[" + Str(f) + " @ " + Str(result) + " + " + Str(modifier) + "]" + vbNewLine
        effect = firecharts(f, x)
        'If Not display_dice Then droll = ""
        If effect = 4 Then
            If Artillery.Checked Then fire_eff = "Battery wrecked" Else fire_eff = "Troops disordered and lose 3 stands"
            msg = droll + "Withering Fire" + vbNewLine + fire_eff
            cas = 3
        ElseIf effect = 3 Then
            If Artillery.Checked Then fire_eff = "Battery damaged" Else fire_eff = "Troops lose 2 stands and is disordered"
            msg = droll + "Deadly Fire" + vbNewLine + fire_eff
            cas = 2
        ElseIf effect = 2 Then
            If Artillery.Checked Then fire_eff = "Battery damaged and silenced" Else fire_eff = "Troops lose 1 stand and is disordered"
            msg = droll + "Telling Fire" + vbNewLine + fire_eff
            cas = 1
        ElseIf effect = 1 Then
            If Artillery.Checked Then fire_eff = "Battery silenced" Else fire_eff = "Troops are disordered"
            msg = droll + "Lively Fire" + vbNewLine + fire_eff
        Else
            msg = droll + "Desultory Fire" + vbNewLine + "No effect"
        End If

        If result = 10 Then msg = msg + vbNewLine + "Firers are now low on Ammunition"
        If result = 10 Then
            result = dice(10)
            msg = msg + vbNewLine + "A leader, if attached, has "
            Select Case result
                Case 1 : msg = msg + "been felled by Sniper"
                Case 2 : msg = msg + "been shot dead in the saddle"
                Case 3 : msg = msg + "been mortally Stricken"
                Case 4 : msg = msg + "been grieveously wounded"
                Case 5 : msg = msg + "been disabled"
                Case 6 : msg = msg + "received a mere Flesh Wound"
                Case 7 : msg = msg + "had his coat pierced, but he is unscathed"
                Case 8 : msg = msg + "had his horse shot from under"
                Case 9 : msg = msg + "one of his staff officer's struck"
                Case 10 : msg = msg + "cooly ignored the fire"
            End Select
        End If
        If Not Artillery.Checked Then
            If Me.Tag = scenariodefaults.player1.Text Then
                casualties.p2_cas.Value = casualties.p2_cas.Value + cas
                casualties.p2_cas_c.Text = "[" + Str(cas) + "]"
            Else
                casualties.p1_cas.Value = casualties.p1_cas.Value + cas
                casualties.p1_cas_c.Text = "[" + Str(cas) + "]"
            End If
        Else
            If InStr(msg, "damaged") > 0 Then
                cas = 0.5
            ElseIf InStr(msg, "wrecked") > 0 Then
                cas = 1
            Else
                cas = 0
            End If
            If Me.Tag = scenariodefaults.player1.Text Then
                casualties.p2_art.Value = casualties.p2_art.Value + cas
                casualties.p2_art_c.Text = "[" + Str(cas) + "]"
            Else
                casualties.p1_art.Value = casualties.p1_art.Value + cas
                casualties.p1_art_c.Text = "[" + Str(cas) + "]"
            End If
        End If
        update_casualties(Me.Tag)
        resultform.result.Text = msg
        resultform.ShowDialog()
        resetform()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        resetform()
    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        resetform()
    End Sub

    Private Sub adjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjust.Click
        casualties.ShowDialog()
    End Sub

    Private Sub nextphase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextphase.Click
        scenariodefaults.quit = False
        Me.Hide()
    End Sub

    Private Sub Firing_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If scenariodefaults.quit Then quitprogram()
    End Sub

    Private Sub adjustfirepoints_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjustfirepoints.ValueChanged
        firepoints.Text = adjustfirepoints.Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        scenariodefaults.quit = False
        goback = True
        Me.Hide()
    End Sub

    Private Sub inc_dec_fire_points(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inc_fire_points.Click, dec_fire_points.Click
        If Strings.Left(sender.name, 3) = "dec" And firepoints.Text = 0 Then Exit Sub
        firepoints.Text = firepoints.Text + IIf(Strings.Left(sender.name, 3) = "dec", -1, 1)
        adjustfirepoints.Value = firepoints.Text
    End Sub

    Private Sub select_firePoints(sender As Object, e As EventArgs) Handles f1.Click, f2.Click, f3.Click, f4.Click, f5.Click,
        f6.Click, f7.Click, f8.Click, f9.Click, f10.Click, f11.Click, f12.Click
        With calculator
            .factor.Text = sender.text
            .elements.Text = 1
            .multiplier.Text = 1
            .Tag = "1"
            .ShowDialog()
        End With

    End Sub
End Class