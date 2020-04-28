Public Class Tactical
    Public runaway As Integer
    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        resetform()
    End Sub
    Private Sub resetform()
        disengage.Checked = False
        detached.Text = "0"
        attached.Text = "0"
        detached.BackColor = defa
        attached.BackColor = defa
        Impulse.Checked = False
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

    Private Sub check_color(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    spent.CheckedChanged, Fresh.CheckedChanged, Impulse.CheckedChanged, Unsecure.CheckedChanged, disengage.CheckedChanged, _
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
        If Impulse.Checked Then modifier = modifier + 1
        If Unsecure.Checked Then modifier = modifier - 1
        If disengage.Checked Then modifier = modifier - 2
        If Cavalry.Checked And disordered.Checked Then modifier = modifier - 3
        modifier = modifier - get_cohesion(Me.Tag)
        Dim d As Integer = dice(10)
        result = d + modifier
        Dim droll As String = "[" + Str(d) + " + " + Str(modifier) + "]" + vbNewLine
        If Not display_dice Then droll = ""
        If disordered.Checked Then
            If result <= 0 Then
                msg = "Routs" + vbNewLine + "The entire Brigade removed from play"
                quitfield = True
            ElseIf result <= 2 Then
                msg = "Broken" + vbNewLine + "Retreat a full move disordered and one stand lost"
                broken = True
            ElseIf result <= 4 Then
                msg = "Wavering" + vbNewLine + "Hold ground in disorder"
            ElseIf result <= 6 Then
                msg = "Shaken" + vbNewLine + "Rallies and holds ground, but cannot move or change formation"
            ElseIf result <= 9 Then
                msg = "Rally" + vbNewLine + "Rallies and may move half but cannot change formation"
            Else
                msg = "Rally with Elan" + vbNewLine + "Rallies and may move normally and can change formation"
            End If
        Else
            If result <= 0 Then
                msg = "Fall Back" + vbNewLine + "Brigade retreats a full move disordered"
            ElseIf result <= 2 Then
                msg = "Retire" + vbNewLine + "Brigade retreats out of musket range"
            ElseIf result <= 4 Then
                msg = "Hold Ground" + vbNewLine + "Cannot move or change formation"
            ElseIf result <= 6 Then
                msg = "Cautious" + vbNewLine + "May move half but cannot change formation"
            ElseIf result <= 9 Then
                msg = "En Avant" + vbNewLine + "May move normally and can change formation"
            Else
                msg = "A la Bayonette" + vbNewLine + "May move normally and can change formation"
            End If


        End If
        With resultform
            .result.Text = droll + msg
            .reverse.Visible = False
            .ShowDialog()
            .reverse.Visible = False
        End With

        'If quitfield Or broken Then
        '    If quitfield Then
        '        calculator.Tag = "rout"
        '        calculator.ShowDialog()
        '    Else
        '        runaway = 1
        '    End If
        '    If Tag = scenariodefaults.player1.Text Then losses(1, 2) = losses(1, 2) + runaway Else losses(2, 2) = losses(2, 2) + runaway
        'End If

        resetform()
    End Sub

    Private Sub adjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjust.Click
        display_adjust_casualties("both")
    End Sub

    Private Sub nextphase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextphase.Click
        If movement.Visible Then movement.Hide()
        scenariodefaults.quit = False
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        movement.Show()
    End Sub

    Private Sub Tactical_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        resetform()
        If generals Is Nothing Then doctrine.Enabled = False
    End Sub

    Private Sub Manouvre_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If scenariodefaults.quit Then quitprogram()
    End Sub

    Private Sub b2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2.Click
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

    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
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