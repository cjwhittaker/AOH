Public Class Firing_AOH

    Private Sub resetform()
        cover.Text = "0"
        cover.BackColor = defa
        Targetmode.Checked = False
        Artillery.Checked = False
        tirailleur.Checked = False
        firepoints.Text = 0
        adjustfirepoints.Value = 0
        cas = 0 : routed = 0 : captured = 0
    End Sub

    Private Sub check_color(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
Targetmode.CheckedChanged, Artillery.CheckedChanged, tirailleur.CheckedChanged

        If sender.checked Then sender.backcolor = Color.Goldenrod Else sender.backcolor = Control.DefaultBackColor

    End Sub


    Private Sub fire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fire.Click
        Dim x As Integer, cas As Single, modifier As Integer, result As Integer, msg As String, fire_eff As String
        modifier = 0
        If Targetmode.Checked Then modifier = modifier + 1
        If tirailleur.Checked Then modifier = modifier - light_inf

        modifier = modifier - Val(cover.Text)
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
        If Not display_dice Then droll = ""
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
            msg = droll + "Telling Fire" + vbNewLine + "Troops disordered and lose a stand" + vbNewLine + "Battery damaged and silenced"
            cas = 1
        ElseIf effect = 1 Then
            If Artillery.Checked Then fire_eff = "Battery silenced" Else fire_eff = "Troops are disordered"
            msg = droll + "Lively Fire" + vbNewLine + vbNewLine + fire_eff
        Else
            msg = droll + "Desultory Fire" + vbNewLine + "No effect"
        End If
        If result = 10 And low_ammo Then msg = msg + vbNewLine + "Firers are now low on Ammunition"
        If result = 10 Then
            result = dice(10)
            msg = msg + vbNewLine + "A leader, if attached, has "
            Select Case result
                Case 1 : msg = msg + "been felled by skirmisher"
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
        With resultform
            .result.Text = msg
            .reverse.Visible = False
            .leader.Visible = IIf(InStr(msg, "A leader, if attached, has ") > 0 And result <= 5, True, False)
            .Tag = IIf(Me.Tag = scenariodefaults.player1.Text, scenariodefaults.player2.Text, scenariodefaults.player1.Text)
            .ShowDialog()
            .reverse.Visible = False
            .leader.Visible = False
            .Tag = ""
        End With

        resetform()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        resetform()
        Targetmode.Text = My.Resources.TARGET_MODE
    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        resetform()
    End Sub

    Private Sub adjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjust.Click
        display_adjust_casualties("both")
    End Sub

    Private Sub nextphase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextphase.Click
        scenariodefaults.quit = False
        Me.Hide()
    End Sub

    Private Sub select_cover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_cover.Click
        If cover.Text = "0" Then
            cover.Text = "+1"
            emph(cover)
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

    Private Sub firepoints_selected(sender As Object, e As EventArgs) Handles f1.Click, f2.Click, f3.Click, f4.Click, f5.Click, f6.Click, f7.Click, f8.Click, f9.Click,
        f10.Click, f11.Click, f12.Click, f13.Click, f14.Click, f15.Click, f16.Click, f17.Click, f18.Click, f19.Click,
f20.Click, f21.Click, f22.Click, f23.Click, f24.Click, f25.Click, f26.Click, f27.Click, f28.Click, f29.Click,
f30.Click, f31.Click, f33.Click, f35.Click, f37.Click, f32.Click
        With calculator
            .factor.Text = sender.text
            .elements.Text = 1
            .multiplier.Text = 1
            .Tag = "1"
            .ShowDialog()
        End With

    End Sub

End Class