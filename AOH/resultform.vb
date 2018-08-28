Public Class resultform
    Private Sub confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirm.Click
        If scenariodefaults.phase <= 5 Then scenariodefaults.quit = False
        Me.Close()
    End Sub
    Private Sub resultform_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If scenariodefaults.phase = 1 Then
        '    If scenariodefaults.p1 = scenariodefaults.player1.Text Then
        '        If supercedes.Checked Then player1_cinc_superceding = True Else player1_cinc_superceding = False
        '        If attached.Checked Then player1_cinc_attached = True Else player1_cinc_attached = False
        '    Else
        '        If supercedes.Checked Then player2_cinc_superceding = True Else player2_cinc_superceding = False
        '        If attached.Checked Then player2_cinc_attached = True Else player2_cinc_attached = False
        '    End If
        'End If

        If scenariodefaults.phase <= 5 And scenariodefaults.quit Then quitprogram()
    End Sub
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub adjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjust.Click
        If Me.Tag <> "" Then
            If Not generals Is Nothing Then generals(Me.Tag).deployed = True
        Else
            casualties.ShowDialog()
        End If


    End Sub

    Private Sub leader_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leader.CheckedChanged
        If leader.Checked Then
            If Me.Tag = scenariodefaults.player1.Text Then
                casualties.p1_ldr.Value = casualties.p1_ldr.Value + 1
                casualties.p1_ldr_c.Text = "[1]"
                'player1_cinc_dead = True
            Else
                casualties.p2_ldr.Value = casualties.p2_ldr.Value + 1
                casualties.p2_ldr_c.Text = "[1]"
                'player2_cinc_dead = True
            End If
        Else
            If Me.Tag = scenariodefaults.player1.Text Then
                casualties.p1_ldr.Value = casualties.p1_ldr.Value - 1
                casualties.p1_ldr_c.Text = "[ ]"
                ''player1_cinc_dead = False
            Else
                casualties.p2_ldr.Value = casualties.p2_ldr.Value - 1
                casualties.p2_ldr_c.Text = "[ ]"
                'player2_cinc_dead = False
            End If
        End If
    End Sub

    Private Sub arty_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arty.CheckedChanged
        Dim artydamage As Boolean
        If InStr(Me.result.Text, "damage") > 0 Then artydamage = True Else artydamage = False
        If arty.Checked Then
            If Me.Tag = scenariodefaults.player1.Text Then
                If artydamage Then
                    casualties.p1_art.Value = casualties.p1_art.Value + 0.5
                    casualties.p1_art_c.Text = "[0.5]"
                Else
                    casualties.p1_cap.Value = casualties.p1_cap.Value + 1
                    casualties.p1_cap_c.Text = "[1]"
                End If
            Else
                If artydamage Then
                    casualties.p2_art.Value = casualties.p2_art.Value + 0.5
                    casualties.p2_art_c.Text = "[0.5]"
                Else
                    casualties.p2_cap.Value = casualties.p2_cap.Value + 1
                    casualties.p2_cap_c.Text = "[1]"
                End If
            End If
        Else
            If Me.Tag = scenariodefaults.player1.Text Then
                If artydamage Then
                    casualties.p1_art.Value = casualties.p1_art.Value - 0.5
                    casualties.p1_art_c.Text = "[ ]"
                Else
                    casualties.p1_cap.Value = casualties.p1_cap.Value - 1
                    casualties.p1_cap_c.Text = "[ ]"
                End If
            Else
                If artydamage Then
                    casualties.p2_art.Value = casualties.p2_art.Value - 0.5
                    casualties.p2_art_c.Text = "[ ]"
                Else
                    casualties.p2_cap.Value = casualties.p2_cap.Value - 1
                    casualties.p2_cap_c.Text = "[ ]"
                End If
            End If

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
    Private Sub check_color(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
 arty.CheckedChanged, leader.CheckedChanged
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa

    End Sub
End Class