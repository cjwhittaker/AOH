Public Class tactical_FF
    Public runaway As Integer
    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        resetform()
    End Sub
    Private Sub resetform()
        exceptional.Checked = False
        detached.Checked = False
        attached.Checked = False
        Brigade.Checked = False
        Column.Checked = False
        fresh.Checked = False
        spent.Checked = False
        disordered.Checked = False
    End Sub
    Private Sub toggle_checks(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles attached.CheckedChanged, detached.CheckedChanged, spent.CheckedChanged, fresh.CheckedChanged
        If Not sender.checked Then Exit Sub
        If sender.name = "attached" Then
            detached.Checked = False
        ElseIf sender.name = "detached" Then
            attached.Checked = False
        ElseIf sender.name = "fresh" Then
            spent.Checked = False
        ElseIf sender.name = "spent" Then
            fresh.Checked = False
        Else
        End If
    End Sub
    Private Sub check_color(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        attached.CheckedChanged, detached.CheckedChanged, spent.CheckedChanged, fresh.CheckedChanged,
        disordered.CheckedChanged, exceptional.CheckedChanged, Brigade.CheckedChanged, Column.CheckedChanged
        If sender.checked Then sender.backcolor = Color.Goldenrod Else sender.backcolor = Control.DefaultBackColor

    End Sub

    Private Sub getresult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getresult.Click
        Dim quitfield As Boolean, modifier As Integer, result As Integer, msg As String, broken As Boolean
        modifier = 0 : quitfield = False : broken = False
        If exceptional.Checked Then modifier = modifier + 1
        If attached.Checked Then modifier = modifier + 2
        If detached.Checked Then modifier = modifier + 1
        If Brigade.Checked Then modifier = modifier + 1
        If Column.Checked Then modifier = modifier + 1
        If fresh.Checked Then modifier = modifier + 2
        If spent.Checked Then modifier = modifier - 2
        modifier = modifier + get_cohesion(Me.Tag)
        Dim d As Integer = dice(10)
        result = d + modifier
        Dim droll As String = "[" + Str(d) + " + " + Str(modifier) + "]" + vbNewLine
        If Not display_dice Then droll = ""

        If disordered.Checked Then
            If result <= 0 Then
                msg = "Quits the Field" + vbNewLine + "The entire Brigade skedaddles"
                quitfield = True
            ElseIf result <= 2 Then
                msg = "Broken" + vbNewLine + "Retreat a full move disordered and one stand skedaddles"
                broken = True
            ElseIf result <= 4 Then
                msg = "Wavering" + vbNewLine + "Hold ground in disorder"
            ElseIf result <= 6 Then
                msg = "Shaken" + vbNewLine + "Rallies and holds ground"
            ElseIf result <= 9 Then
                msg = "Rally" + vbNewLine + "Rallies and may move half but cannot change formation"
            Else
                msg = "Rally with Elan" + vbNewLine + "Rallies and may move normally and can change formation"
            End If
        Else
            If result <= 0 Then
                msg = "Retire" + vbNewLine + "Brigade retreats a full move"
            ElseIf result <= 2 Then
                msg = "Disengage" + vbNewLine + "Brigade retreats out of musket range"
            ElseIf result <= 4 Then
                msg = "Hold Ground" + vbNewLine + "Cannot move or change formation"
            ElseIf result <= 6 Then
                msg = "Tardy" + vbNewLine + "May move half but cannot change formation"
            Else
                msg = "Well Handled" + vbNewLine + "May move normally and can change formation"
            End If


        End If
        resultform.result.Text = droll + msg
        resultform.ShowDialog()
        If quitfield Or broken Then
            If quitfield Then
                calculator.Tag = "rout"
                calculator.ShowDialog()
                calculator.Tag = ""
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

    Private Sub Tactical_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        resetform()
        If generals Is Nothing Then doctrine.Enabled = False
    End Sub


    Private Sub adjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjust.Click
        casualties.ShowDialog()
    End Sub

    Private Sub nextphase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextphase.Click
        If movement_FF.Visible Then movement_FF.Hide()
        scenariodefaults.quit = False
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        movement_FF.Show()
    End Sub

    Private Sub Manouvre_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If scenariodefaults.quit Then quitprogram()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        scenariodefaults.quit = False
        goback = True
        Me.Hide()
    End Sub

    Private Sub doctrine_Click(sender As Object, e As EventArgs) Handles doctrine.Click
        With resultform
            .adjust.Visible = False
            .reverse.Visible = False
            .Text = "Battle Doctrine "
            .result.Text = "Battle Doctrine" + vbNewLine + Me.Tag + " CinC has adopted " + generals(Me.Tag + "CinC").plan + vbNewLine + "The Order of March chosen is " + generals(Me.Tag + "CinC").oom + Replace(generals(Me.Tag + "CinC").doctrine, "!", vbNewLine)
            .ShowDialog()
            .reverse.Visible = True
            .adjust.Visible = True
        End With
    End Sub
End Class