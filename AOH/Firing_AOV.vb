Public Class Firing_AOV
    Public factor_selected As Boolean
    Private Sub resetform()
        cover.Text = "0"
        cover.BackColor = defa
        Targetmode.Checked = False
        Artillery.Checked = False
        tirailleur.Checked = False
        cavalry_charging.checked = False
        firepoints.Text = 0
        adjustfirepoints.Value = 0
    End Sub

    Private Sub check_color(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
Targetmode.CheckedChanged, Artillery.CheckedChanged, tirailleur.CheckedChanged, cavalry_charging.CheckedChanged
        If sender.checked Then sender.backcolor = Color.Goldenrod Else sender.backcolor = Control.DefaultBackColor
        If sender.name = "Artillery" And sender.backcolor = Color.Goldenrod Then tirailleur.Checked = False : cavalry_charging.Checked = False
        If sender.name = "tirailleur" And sender.backcolor = Color.Goldenrod Then Artillery.Checked = False : cavalry_charging.Checked = False
        If sender.name = "cavalry_charging" And sender.backcolor = Color.Goldenrod Then tirailleur.Checked = False : Artillery.Checked = False

    End Sub


    Private Sub fire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fire.Click
        Dim cas As Single, modifier As Integer, result As Integer, msg As String, fire_eff As String
        Dim effect As Integer = 0, f As Integer = Val(firepoints.Text)
        If f <= 0 Then f = 0
        modifier = 0
        If Targetmode.Checked Then modifier = modifier + 1
        If tirailleur.Checked Then modifier = modifier - 2
        If Cavalry_charging.Checked Then modifier = modifier + 3
        modifier = modifier - Val(cover.Text)
        For i As Integer = 1 To 10
            If i = 10 Then modifier = modifier + firecharts(1, i) : Exit For
            If f <= firecharts(0, i) Then modifier = modifier + firecharts(1, i) : Exit For
        Next
        cas = 0
        result = dice(10)
        effect = result + modifier
        Dim droll As String = "[" + Str(f) + " @ " + Str(result) + " + " + Str(modifier) + "]" + vbNewLine
        If Not display_dice Then droll = ""
        If effect >= 11 Then
            If Artillery.Checked Then fire_eff = "Battery wrecked" Else fire_eff = "Troops lose 3 stands" + vbNewLine + "Cavalry disordered, Infantry suppressed" + vbNewLine + "Movers halt where fire receivied" + vbNewLine + "Chargers retire 1/2 move away from firers"
            msg = droll + "Gone to Ground" + vbNewLine + fire_eff
            cas = 3
        ElseIf effect >= 9 Then
            If Artillery.Checked Then fire_eff = "Battery damaged and silenced" Else fire_eff = "Troops lose 2 stands and is disordered"
            msg = droll + "Deadly Fire" + vbNewLine + fire_eff
            cas = 2
        ElseIf effect >= 6 Then
            If Artillery.Checked Then fire_eff = "Battery damaged " Else fire_eff = "Troops lose 1 stand and is disordered"
            msg = droll + "Telling Fire" + vbNewLine + fire_eff
            cas = 1
        ElseIf effect >= 4 Then
            If Artillery.Checked Then fire_eff = "Battery silenced" Else fire_eff = "Troops are disordered"
            msg = droll + "Lively Fire" + vbNewLine + fire_eff
        Else
            msg = droll + "Desultory Fire" + vbNewLine + "No effect"
        End If
        'If result = 10 Then msg = msg + vbNewLine + "Firers are now low On Ammunition"
        If result = 10 Then
            result = dice(10)
            msg = msg + vbNewLine + "A leader, If attached, has "
            Select Case result
                Case 1 : msg = msg + "been felled by skirmisher"
                Case 2 : msg = msg + "been shot dead In the saddle"
                Case 3 : msg = msg + "been mortally Stricken"
                Case 4 : msg = msg + "been grieveously wounded"
                Case 5 : msg = msg + "been disabled"
                Case 6 : msg = msg + "received a mere Flesh Wound"
                Case 7 : msg = msg + "had his coat pierced, but he Is unscathed"
                Case 8 : msg = msg + "had his horse shot from under"
                Case 9 : msg = msg + "one Of his staff officer's struck"
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
        With resultform
            .result.Text = msg
            .reverse.Visible = False
            .ShowDialog()
            .reverse.Visible = False
        End With

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

    Private Sub select_cover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_cover.Click
        If cover.Text = "0" Then
            emph(cover)
            cover.Text = "+1"
        ElseIf cover.Text = "+1" Then
            cover.Text = "+2"
        ElseIf cover.Text = "+2" Then
            cover.Text = "+3"
        ElseIf cover.Text = "+3" Then
            cover.Text = "0"
            emph(cover)
        Else
        End If
    End Sub

    Private Sub Firing_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If scenariodefaults.quit Then quitprogram()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        scenariodefaults.quit = False
        goback = True
        Me.Hide()
    End Sub

    Private Sub adjustfirepoints_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjustfirepoints.ValueChanged
        firepoints.Text = adjustfirepoints.Value
    End Sub

    Private Sub inc_dec_fire_points(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inc_fire_points.Click, dec_fire_points.Click
        If Strings.Left(sender.name, 3) = "dec" And firepoints.Text = 0 Then Exit Sub
        firepoints.Text = firepoints.Text + IIf(Strings.Left(sender.name, 3) = "dec", -1, 1)
        adjustfirepoints.Value = firepoints.Text
    End Sub

    Private Sub firepoints_Click(sender As Object, e As EventArgs) Handles firepoints.Click
        firepoints.Text = 0
        adjustfirepoints.Value = firepoints.Text
    End Sub

    Private Sub select_factor(sender As Object, e As EventArgs) Handles f1.Click, f2.Click, f3.Click, f4.Click, f5.Click,
        f6.Click, f7.Click, f8.Click, f9.Click, f10.Click, f11.Click, f12.Click, f13.Click, f14.Click, f15.Click, f16.Click, f17.Click, f18.Click, f19.Click, f20.Click, f21.Click, f22.Click, f23.Click, f24.Click, f25.Click, f26.Click
        With calculator
            .factor.Text = sender.text
            .elements.Text = 1
            .multiplier.Text = 1
            .Tag = "1"
            .ShowDialog()
        End With
    End Sub

End Class