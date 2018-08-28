Public Class tactical_AOV
    Public runaway As Integer
    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        resetform()
    End Sub
    Private Sub resetform()
        suppressed.Checked = False
        detached.Text = "0"
        detached.BackColor = defa
        attached.Text = "0"
        attached.BackColor = defa
        Column.Checked = False
        Fresh.Checked = False
        spent.Checked = False
        disordered.Checked = False
    End Sub

    Private Sub Fresh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fresh.CheckedChanged
        If Fresh.Checked Then spent.Checked = False
    End Sub

    Private Sub spent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spent.CheckedChanged
        If spent.Checked Then Fresh.Checked = False
    End Sub
    Private Sub cavalry_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cavalry.CheckedChanged
        If Cavalry.Checked Then disordered.Checked = True : suppressed.Checked = False
    End Sub
    Private Sub disordered_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disordered.CheckedChanged
        If Not disordered.Checked And Cavalry.Checked Then disordered.Checked = True : suppressed.Checked = False
        If disordered.Checked And Not Cavalry.Checked Then suppressed.Checked = False
    End Sub
    Private Sub suppressed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles suppressed.CheckedChanged
        If Not suppressed.Checked And Cavalry.Checked Then suppressed.Checked = False
        If suppressed.Checked And Not Cavalry.Checked Then disordered.Checked = False
    End Sub


    Private Sub check_color(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    spent.CheckedChanged, Fresh.CheckedChanged, suppressed.CheckedChanged,
    disordered.CheckedChanged, Cavalry.CheckedChanged, Column.CheckedChanged
        If sender.checked Then sender.backcolor = Color.Goldenrod Else sender.backcolor = Control.DefaultBackColor

    End Sub

    Private Sub getresult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getresult.Click
        Dim quitfield As Boolean, broken As Boolean, modifier As Integer, result As Integer, msg As String
        modifier = 0 : quitfield = False : broken = False
        modifier = modifier + IIf(Val(attached.Text) + Val(detached.Text) > 4, 4, Val(attached.Text) + Val(detached.Text))
        If Column.Checked Then modifier = modifier + 1
        If Fresh.Checked Then modifier = modifier + 2
        If spent.Checked Then modifier = modifier - 2
        If Cavalry.Checked And disordered.Checked Then modifier = modifier - 3
        Dim d As Integer = dice(10)
        modifier = modifier + get_cohesion(Me.Tag)
        result = d + modifier
        Dim droll As String = "[" + Str(d) + " + " + Str(modifier) + "]" + vbNewLine
        If Not display_dice Then droll = ""
        If disordered.Checked Then
            If result <= 0 Then
                msg = "Broken" + vbNewLine + "The Brigade does not rally it retreats a full move disordered and one stand lost "
                broken = True
            ElseIf result <= 2 Then
                msg = "Retreat" + vbNewLine + "The Brigade does not rally it retreats a full move disordered"
            ElseIf result <= 4 Then
                msg = "Retire" + vbNewLine + "The Brigade does not rally it retreats a half move disordered"
            ElseIf result <= 6 Then
                msg = "Stalled" + vbNewLine + "Rallies and holds ground, but cannot move or change formation"
            ElseIf result <= 9 Then
                msg = "Cautious" + vbNewLine + "Rallies and may move half but cannot change formation"
            Else
                msg = "En Avant" + vbNewLine + "Rallies and may move normally and can change formation"
            End If
        ElseIf suppressed.Checked Then
            If result <= 0 Then
                msg = "Rout" + vbNewLine + "The Brigade has been destroyed and is removed from play"
                quitfield = True
            ElseIf result <= 6 Then
                msg = "Pinned" + vbNewLine + "The Brigade remains suppressed and may not move or change formation"
            ElseIf result <= 9 Then
                msg = "Stalled" + vbNewLine + "Rallies and holds ground, but cannot move or change formation"
            Else
                msg = "Cautious" + vbNewLine + "Rallies and may move half but cannot change formation"
            End If

        Else
            If result <= 0 Then
                msg = "Retreat" + vbNewLine + "The Brigade retreats a full move disordered in good order"
            ElseIf result <= 2 Then
                msg = "Retire" + vbNewLine + "The Brigade retreats a half move disordered in good order"
            ElseIf result <= 4 Then
                msg = "Stalled" + vbNewLine + "Cannot move or change formation"
            ElseIf result <= 6 Then
                msg = "Cautious" + vbNewLine + "May move half but cannot change formation"
            ElseIf result <= 9 Then
                msg = "En Avant" + vbNewLine + "May move normally and can change formation"
            Else
                msg = "Pas de Charge" + vbNewLine + "May move normally and can change formation and may move at double time if Infantry"
            End If


        End If
        With resultform
            .result.Text = droll + msg
            .reverse.Visible = False
            .ShowDialog()
            .reverse.Visible = False
        End With

        If quitfield Or broken Then
            If quitfield Then
                calculator.Tag = "rout"
                calculator.ShowDialog()
            Else
                runaway = 1
            End If
            If Me.Tag = scenariodefaults.player1.Text Then
                casualties.p1_ske.Value = casualties.p1_ske.Value + runaway
            Else
                casualties.p2_ske.Value = casualties.p2_ske.Value + runaway
            End If
        End If

        resetform()

    End Sub

    Private Sub adjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjust.Click
        casualties.ShowDialog()
    End Sub

    Private Sub nextphase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextphase.Click
        If movement_AOV.Visible Then movement_AOV.Hide()
        scenariodefaults.quit = False
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        movement_AOV.Show()
    End Sub

    Private Sub Tactical_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        resetform()
        If generals Is Nothing Then doctrine.Enabled = False
    End Sub

    Private Sub Manouvre_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If scenariodefaults.quit Then quitprogram()
    End Sub

    Private Sub attached_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles attached_leader.Click
        If attached.Text = "0" Then
            attached.Text = "+2"
            emph(attached)
        ElseIf attached.Text = "+2" Then
            attached.Text = "+3"
        ElseIf attached.Text = "+3" Then
            attached.Text = "+4"
        ElseIf attached.Text = "+4" Then
            attached.Text = "0"
            emph(attached)
        Else
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        scenariodefaults.quit = False
        goback = True
        Me.Hide()
    End Sub

    Private Sub detached_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles detached_leader.Click
        If detached.Text = "0" Then
            detached.Text = "+1"
            emph(detached)
        ElseIf detached.Text = "+1" Then
            detached.Text = "+2"
        ElseIf detached.Text = "+2" Then
            detached.Text = "+3"
        ElseIf detached.Text = "+3" Then
            detached.Text = "+4"
        ElseIf detached.Text = "+4" Then
            detached.Text = "0"
            emph(detached)
        Else
        End If
    End Sub
    Private Sub doctrine_Click(sender As Object, e As EventArgs) Handles doctrine.Click

    End Sub
End Class