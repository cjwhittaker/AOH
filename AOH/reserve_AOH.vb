Public Class reserve_AOH

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        resetform()
    End Sub
    Private Sub resetform()
        elsewhere.Checked = False
        attached.Checked = False
        last_turn.Checked = False
        disordered.Checked = False
        Failures.Text = "0"
        Failures.BackColor = defa
    End Sub
    Private Sub check_color(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
elsewhere.CheckedChanged, attached.CheckedChanged, last_turn.CheckedChanged, disordered.CheckedChanged
        If sender.checked Then sender.backcolor = Color.Goldenrod Else sender.backcolor = Control.DefaultBackColor

    End Sub

    Private Sub getresult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getresult.Click
        Dim modifier As Integer, result As Integer, msg As String
        modifier = 0
        If elsewhere.Checked Then
            modifier = modifier - 2
        ElseIf Player.Text = scenariodefaults.player1.Text Then
            modifier = scenariodefaults.player1_init.Text
        ElseIf Player.Text = scenariodefaults.player2.Text Then
            modifier = scenariodefaults.player2_init.Text
        Else
        End If
        If attached.Checked Then modifier = modifier + 1
        If last_turn.Checked Then modifier = modifier + 4
        If disordered.Checked Then modifier = modifier - 1
        If scenariodefaults.gameturn.Text = 1 Then modifier = modifier + 4
        modifier = modifier + Val(Failures.Text)
        modifier = modifier - get_cohesion(Me.Tag)

        Dim d As Integer = dice(10)
        result = d + modifier
        Dim droll As String = "[" + Str(d) + " + " + Str(modifier) + "]" + vbNewLine
        If Not display_dice Then droll = ""
        If result >= 7 Then
            msg = "Success" + vbNewLine + "The units conduct reserve movement"
        ElseIf result >= 5 Then
            msg = "Partial Success" + vbNewLine + "No movement, but non-irregular units rally"
        Else
            msg = "Failure" + vbNewLine + "No change in Unit status"
        End If
        With resultform
            .result.Text = droll + msg
            .reverse.Visible = False
            .ShowDialog()
            .reverse.Visible = False
        End With

    End Sub

    Private Sub adjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjust.Click
        casualties.ShowDialog()
    End Sub

    Private Sub nextphase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextphase.Click
        If movement_AOH.Visible Then movement_AOH.Hide()
        scenariodefaults.quit = False
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        movement_AOH.Show()
    End Sub

    Private Sub Manouvre_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If scenariodefaults.quit Then quitprogram()
    End Sub


    Private Sub turns_failed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles turns_failed.Click
        If Failures.Text = "0" Then
            Failures.Text = "+1"
            emph(Failures)
        ElseIf Failures.Text = "+1" Then
            Failures.Text = "+2"
        ElseIf Failures.Text = "+2" Then
            Failures.Text = "+3"
        ElseIf Failures.Text = "+3" Then
            Failures.Text = "0"
            emph(Failures)
        Else
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        scenariodefaults.quit = False
        goback = True
        Me.Hide()
    End Sub
End Class