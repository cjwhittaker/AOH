Public Class scenariodefaults
    Public quit As Boolean, scenario As String, p1 As String, p2 As String, phase As Integer, playerphase As Integer, cohesion As Integer
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        reset_form()
        currdir = My.Computer.FileSystem.SpecialDirectories.MyDocuments() & "\Wargames Automated Play Assistants\Age of Honour"
        Randomize(Hour(Now) * 3600 + Minute(Now) * 60 + Second(Now))
        load_doctrine()
        If Not My.Computer.FileSystem.FileExists(currdir + "\solo.txt") Then
            solo.Visible = False
            solo_setup.Visible = False
        Else
            solo.Checked = False
        End If

    End Sub

    Private Sub start_time_inc_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles start_time_inc.ValueChanged
        Dim mins As Integer, duskmins As Integer
        duskmins = Hour(TimeValue(Dusk.Text)) * 60 + Minute(TimeValue(Dusk.Text))
        mins = (300 + 30 * start_time_inc.Value)
        If mins > duskmins Then start_time_inc.Value = start_time_inc.Value - 1 : Exit Sub
        start_time.Text = Format(TimeSerial(0, mins, 0), "HH:mm")
        Current_time.Text = start_time.Text

    End Sub

    Private Sub dusk_inc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dusk_inc.ValueChanged
        Dim duskmins As Integer, mins As Integer
        duskmins = (16 * 60 + 30 + 30 * dusk_inc.Value)
        mins = Hour(TimeValue(start_time.Text)) * 60 + Minute(TimeValue(start_time.Text))
        If duskmins < mins Then dusk_inc.Value = dusk_inc.Value + 1 : Exit Sub

        Dusk.Text = Format(TimeSerial(0, duskmins, 0), "HH:mm")
    End Sub
    Private Function scenario_ready()
        scenario_ready = False
        If player1.Text <> "" And player2.Text <> "" And player2_stands.Text <> "" And player1_stands.Text <> "" And player1_init.Text <> "" And player2_init.Text <> "" And solo_ready() Then scenario_ready = True
        'And (Not solo.Checked Or (solo.Checked And generals.Count > 0))
    End Function
    Private Function solo_ready()
        solo_ready = False
        If Not solo.Visible Or Not solo.Checked Then solo_ready = True : Exit Function
        If generals Is Nothing Then Exit Function
        If Not generals.Contains(player1.Text + "CinC") Or Not generals.Contains(player2.Text + "CinC") Then Exit Function
        If generals(player1.Text + "CinC").plan = "" Or generals(player2.Text + "CinC").plan = "" Then Exit Function
        solo_ready = True

    End Function

    Private Sub nextturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextturn.Click
        Dim p1_roll As Integer, p2_roll As Integer, init_option As String, temp As String
        If Not scenario_ready() Then Exit Sub
        Me.Hide()
        If player1.Text = "" Or player2.Text = "" Or Current_time.Text = Dusk.Text Then GoTo avoidturninc
        If gameturn.Text = 1 Then enable_data_entry(False)
        'initiative phase?
        If playerphase = 0 Then playerphase = 1
        If playerphase = 1 And phase = 0 Then
            Do
                p1_roll = dice(10) : p2_roll = dice(10)
                If Not player1_cinc_attached And Not player1_cinc_superceding Then p1_roll = p1_roll + player1_init.Text
                If player1_cinc_attached Or player1_cinc_superceding Or player1_cinc_dead Then p1_roll = -1
                If Not player2_cinc_attached And Not player2_cinc_superceding Then p2_roll = p2_roll + player2_init.Text
                If player2_cinc_attached Or player2_cinc_superceding Or player2_cinc_dead Then p2_roll = -1
                If p1_roll = -1 And p2_roll = -1 And player1_init.Text <> player2_init.Text Then
                    If player1_init.Text > player2_init.Text Then p1_roll = 100 Else p2_roll = 100
                ElseIf p1_roll = -1 And p2_roll = -1 And player1_init.Text = player2_init.Text Then
                    p1_roll = dice(10) : p2_roll = dice(10)
                Else
                End If
            Loop Until p1_roll <> p2_roll
            If p1_roll > p2_roll Then init_option = player1.Text Else init_option = player2.Text
            With resultform
                .adjust.Visible = False
                .Text = "Initiative Phase"
                .confirm.Visible = False
                .first_player.Visible = True
                .second_player.Visible = True
                .reverse.Visible = False
                .result.Text = "Initiative Inter Phase" + vbNewLine + vbNewLine + init_option + " has the choice of being First or Second Player " + vbNewLine + "Choose below"
                .ShowDialog()
                .confirm.Visible = True
                .reverse.Visible = True
                .first_player.Visible = False
                .second_player.Visible = False
            End With
            If (resultform.Tag = "First" And init_option = player1.Text) Or (resultform.Tag = "Second" And init_option = player2.Text) Then
                p1 = player1.Text : p2 = player2.Text
            Else
                p1 = player2.Text : p2 = player1.Text
            End If
        End If

        goback = False

        Do
            If phase = 0 Then
                phase = 1
                If playerphase = 2 Then
                    temp = p1
                    p1 = p2
                    p2 = temp
                End If
                If Not generals Is Nothing Then test_for_decisions(p1)
                test_for_events(p1, Current_time.Text)
            End If
backbutton:
            If phase = 1 Then
                phase = 2 : quit = True
                With resultform
                    .adjust.Visible = False
                    .Text = "Tactical March Phase - GT" + Trim(Str(gameturn.Text)) + " at " + Current_time.Text + "hrs"
                    .confirm.Text = "Next Phase"
                    .reverse.Visible = IIf(playerphase = 1, False, True)
                    .result.Text = p1 + " Tactical March Phase" + vbNewLine + vbNewLine + "Replace fallen leaders" + vbNewLine + "Attach/detach Leaders"
                    .ShowDialog()
                End With
                If quit Then GoTo closeprogram
                If goback And playerphase = 2 Then
                    playerphase = 1
                    p1 = player1.Text
                    p2 = player2.Text
                    phase = 6
                    goback = False
                    GoTo backbutton
                Else
                    goback = False
                End If
            End If
            If phase = 2 Then
                phase = 3 : quit = True
                'With resultform
                '    .Text = "Tactical March Phase Results - GT" + Trim(Str(gameturn.Text)) + " at " + Current_time.Text + "hrs"
                '    .confirm.Text = "OK"
                'End With
                With tactical
                    .Text = "Tactical March Phase - GT" + Trim(Str(gameturn.Text)) + " at " + Current_time.Text + "hrs"
                    .Player.Text = p1 + " Tactical March Phase" + vbNewLine + " Move Brigades and Batteries"
                    .doctrine.Visible = IIf(solo.Checked, True, False)
                    .Tag = p1
                    .ShowDialog()
                End With

                If quit Then GoTo closeprogram
                If goback Then phase = 1 : goback = False : GoTo backbutton
            End If
            If phase = 3 Then
                phase = 4 : quit = True
                With resultform
                    .adjust.Visible = False
                    .Text = "Tactical March Phase - GT" + Trim(Str(gameturn.Text)) + " at " + Current_time.Text + "hrs"
                    .result.Text = p1 + " Tactical March Phase" + vbNewLine + vbNewLine + "Move Detached Leaders"
                    .confirm.Text = "Next Phase"
                    .reverse.Visible = True
                    .ShowDialog()
                    .adjust.Visible = True
                    .Text = "Results"
                    .result.Text = ""
                    .confirm.Text = "OK"
                End With
                If quit Then GoTo closeprogram
                If goback Then phase = 2 : goback = False : GoTo backbutton
            End If
            If phase = 4 Then
                phase = 5 : quit = True
                With Firing
                    .Text = "Firing Phase - GT" + Trim(Str(gameturn.Text)) + " at " + Current_time.Text + "hrs"
                    .Player.Text = p2 + " Defender's Fire Phase"
                    .Tag = p2
                    .ShowDialog()
                End With

                If quit Then GoTo closeprogram
                If goback Then phase = 3 : goback = False : GoTo backbutton
            End If
            If phase = 5 Then
                phase = 6 : quit = True
                With Firing
                    .Text = "Firing Phase - GT" + Trim(Str(gameturn.Text)) + " at " + Current_time.Text + "hrs"
                    .Player.Text = p1 + " Attacker's Fire Phase"
                    .Tag = p1
                    .ShowDialog()
                End With
                If quit Then GoTo closeprogram
                If goback Then phase = 4 : goback = False : GoTo backbutton
            End If
            If phase = 6 Then
                phase = 1 : quit = True
                With charge
                    .Text = "Charge Phase - GT" + Trim(Str(gameturn.Text)) + " at " + Current_time.Text + "hrs"
                    .Player.Text = p1 + " Charge Phase"
                    .attacker.Text = p1
                    .Defender.Text = p2
                    .ShowDialog()
                End With
                If quit Then GoTo closeprogram
                If goback Then phase = 5 : goback = False : GoTo backbutton
            End If
            playerphase = playerphase + 1
            phase = 0
        Loop Until playerphase > 2
        inc_turn()
avoidturninc:
        If Not Me.Visible Then Me.Show()
        Exit Sub
closeprogram:
        If quit Then Me.Close()
    End Sub

    Private Sub loadscenario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadscenario.Click
        Dim y As String
        OpenFileDialog1.Filter = "Scenario files (*.sce)|*.sce|All files (*.*)|*.*"
        OpenFileDialog1.InitialDirectory = currdir
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then scenario = OpenFileDialog1.FileName : y = OpenFileDialog1.SafeFileName Else Exit Sub
        y = Strings.Left(y, (Len(y) - 4))
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(scenario)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    If currentRow(0) = "player1=" Then
                        player1.Text = currentRow(1)
                        player1_init.Text = currentRow(2)
                        player1_cinc_attached = currentRow(3)
                        player1_cinc_superceding = currentRow(4)
                        player1_cinc_dead = currentRow(5)
                    ElseIf currentRow(0) = "player2=" Then
                        player2.Text = currentRow(1)
                        player2_init.Text = currentRow(2)
                        player2_cinc_attached = currentRow(3)
                        player2_cinc_superceding = currentRow(4)
                        player2_cinc_dead = currentRow(5)
                    ElseIf currentRow(0) = "Player 1 Generals=" Then
                        p1_average = Val(currentRow(1))
                        p1_bold = Val(currentRow(2))
                        p1_cautious = Val(currentRow(3))
                        p1_poor = Val(currentRow(4))
                    ElseIf currentRow(0) = "Player 2 Generals=" Then
                        p2_average = Val(currentRow(1))
                        p2_bold = Val(currentRow(2))
                        p2_cautious = Val(currentRow(3))
                        p2_poor = Val(currentRow(4))
                    ElseIf currentRow(0) = "starttime=" Then
                        start_time.Text = currentRow(1)
                    ElseIf currentRow(0) = "dusk=" Then
                        Dusk.Text = currentRow(1)
                    ElseIf currentRow(0) = "currenttime=" Then
                        Current_time.Text = currentRow(1)
                    ElseIf currentRow(0) = "gameturn=" Then
                        gameturn.Text = currentRow(1)
                    ElseIf currentRow(0) = "p1=" Then
                        p1 = currentRow(1)
                    ElseIf currentRow(0) = "p2=" Then
                        p2 = currentRow(1)
                    ElseIf currentRow(0) = "p1strength=" Then
                        player1_stands.Text = currentRow(1)
                    ElseIf currentRow(0) = "p2strength=" Then
                        player2_stands.Text = currentRow(1)
                    ElseIf currentRow(0) = "player phase=" Then
                        playerphase = currentRow(1)
                    ElseIf currentRow(0) = "game phase=" Then
                        phase = currentRow(1)
                    ElseIf Microsoft.VisualBasic.Left(currentRow(0), 6) = casualties.p1_cas.Name Then
                        casualties.p1_cas.Value = currentRow(1)
                    ElseIf Microsoft.VisualBasic.Left(currentRow(0), 6) = casualties.p1_ske.Name Then
                        casualties.p1_ske.Value = currentRow(1)
                    ElseIf Microsoft.VisualBasic.Left(currentRow(0), 6) = casualties.p1_ldr.Name Then
                        casualties.p1_ldr.Value = currentRow(1)
                    ElseIf Microsoft.VisualBasic.Left(currentRow(0), 6) = casualties.p1_cap.Name Then
                        casualties.p1_cap.Value = currentRow(1)
                    ElseIf Microsoft.VisualBasic.Left(currentRow(0), 6) = casualties.p1_art.Name Then
                        casualties.p1_art.Value = currentRow(1)
                    ElseIf Microsoft.VisualBasic.Left(currentRow(0), 6) = casualties.p2_cas.Name Then
                        casualties.p2_cas.Value = currentRow(1)
                    ElseIf Microsoft.VisualBasic.Left(currentRow(0), 6) = casualties.p2_ske.Name Then
                        casualties.p2_ske.Value = currentRow(1)
                    ElseIf Microsoft.VisualBasic.Left(currentRow(0), 6) = casualties.p2_ldr.Name Then
                        casualties.p2_ldr.Value = currentRow(1)
                    ElseIf Microsoft.VisualBasic.Left(currentRow(0), 6) = casualties.p2_cap.Name Then
                        casualties.p2_cap.Value = currentRow(1)
                    ElseIf Microsoft.VisualBasic.Left(currentRow(0), 6) = casualties.p2_art.Name Then
                        casualties.p2_art.Value = currentRow(1)

                    Else
                    End If
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using
        load_events(scenario)
        load_generals(scenario)
        If Not generals Is Nothing Then solo.Checked = True
        If scenario_ready() Then
            solo.Enabled = False
            solo_setup.Enabled = False
        End If
        casualties.p1.Text = Me.player1.Text
        casualties.p2.Text = Me.player2.Text
        If Val(gameturn.Text) + phase + playerphase > 1 Then enable_data_entry(False)
        If Not generals Is Nothing Then
            solo_game = True
            solo.Checked = True
            solo.Enabled = False
        End If
    End Sub

    Private Sub savescenario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savescenario.Click
        Dim newscenario As String
        With SaveFileDialog1
            .Filter = "Scenario files (*.sce)|*.sce|All files (*.*)|*.*"
            .InitialDirectory = currdir
            .FileName = IIf(scenario = "", "", scenario)
            .ShowDialog()
        End With

        If SaveFileDialog1.FileName <> "" Then
            newscenario = SaveFileDialog1.FileName
            savedata(newscenario)
            scenario = newscenario
        End If
    End Sub

    Private Sub inc_turn()
        gameturn.Text = gameturn.Text + 1
        Current_time.Text = Format(TimeSerial(Hour(TimeValue(Current_time.Text)), Minute(TimeValue(Current_time.Text)) + 30, 0), "HH:mm")
        phase = 0
        playerphase = 1
    End Sub

    Private Sub enable_data_entry(ByRef setting As Boolean)
        start_time_inc.Enabled = setting
        dusk_inc.Enabled = setting
        start_time.Enabled = setting
        Dusk.Enabled = setting
        Current_time.Enabled = setting
        gameturn.Enabled = setting
        player1.Enabled = setting
        player2.Enabled = setting
        player1_init.Enabled = setting
        player2_init.Enabled = setting
        player1_stands.Enabled = setting
        player2_stands.Enabled = setting
    End Sub

    Private Sub newscenario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newscenario.Click
        reset_form()
    End Sub




    Private Sub reset_form()
        start_time.Text = TimeValue("10:00")
        Dusk.Text = TimeValue("18:00")
        start_time_inc.Value = (Hour(start_time.Text) * 60 + Minute(start_time.Text) - 390) / 30
        dusk_inc.Value = (Hour(Dusk.Text) * 60 + Minute(Dusk.Text) - (16 * 60 + 30)) / 30
        Current_time.Text = start_time.Text
        player1.Text = "" : player1_init.Text = "" : player1_stands.Text = ""
        player2.Text = "" : player2_init.Text = "" : player2_stands.Text = ""
        player1.SelectedIndex = -1
        player2.SelectedIndex = -1
        gameturn.Text = 1
        enable_data_entry(True)
        dicerolls.Checked = False
        solo.Checked = False
        solo.BackColor = defa
        dicerolls.BackColor = defa
        solo_setup.Enabled = False
        generals = Nothing
        phase = 0
        playerphase = 0
        quit = True
        event_list = New Collection
        planning.Close()
        solo_settings.Close()
        event_manager.Close()
    End Sub



    Private Sub player1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If sender.name = "player1" And player1.SelectedIndex = 0 Then
            player2.SelectedIndex = 1
        ElseIf sender.name = "player1" And player1.SelectedIndex = 1 Then
            player2.SelectedIndex = 0
        ElseIf sender.name = "player2" And player2.SelectedIndex = 0 Then
            player1.SelectedIndex = 1
        ElseIf sender.name = "player2" And player2.SelectedIndex = 1 Then
            player1.SelectedIndex = 0
        Else
        End If
        casualties.p1.Text = player1.Text
        casualties.p2.Text = player2.Text

    End Sub

    Private Sub solo_setup_Click(sender As Object, e As EventArgs) Handles solo_setup.Click
        With solo_settings
            .enable_command_decisions(False)
            .player.Text = player1.Text
            .ShowDialog()
            .enable_command_decisions(False)
            .player.Text = player2.Text
            .ShowDialog()
        End With
        If generals(player1.Text + "CinC").edge = "" Then
            table_side()
            With resultform
                .adjust.Visible = False
                .reverse.Visible = False
                .Text = "Table Edge Selection Phase"
                .result.Text = player1.Text + " deploys From the " + generals(player1.Text + "CinC").edge + vbNewLine + player2.Text + " deploys From the " + generals(player2.Text + "CinC").edge
                .ShowDialog()
                .reverse.Visible = True
                .adjust.Visible = True
            End With
        End If
        If generals(player1.Text + "CinC").plan = "" Then
            With planning
                .player.Text = player1.Text
                .ShowDialog()
            End With
        End If
        If generals(player1.Text + "CinC").plan = "" Then Exit Sub

        If generals(player2.Text + "CinC").plan = "" Then
            With planning
                .player.Text = player2.Text
                .ShowDialog()
            End With
        End If
        If generals(player2.Text + "CinC").plan = "" Then Exit Sub

    End Sub

    Private Sub solo_CheckedChanged(sender As Object, e As EventArgs) Handles solo.CheckedChanged
        If solo.Checked And gameturn.Text = "1" Then
            solo_setup.Enabled = True
            solo_game = True
        Else
            solo_setup.Enabled = False
            solo_game = False
        End If
    End Sub

    Private Sub adjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjust.Click
        casualties.ShowDialog()
    End Sub

    'Private Sub player1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player1_stands.TextChanged, player1_init.TextChanged
    '    casualties.p1.Text = Me.player1.Text
    'End Sub

    'Private Sub player2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player2_stands.TextChanged, player2_init.TextChanged
    '    casualties.p2.Text = Me.player2.Text
    'End Sub

    Private Sub manage_events_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles manage_events.Click
        If player1.Text = "" Or player2.Text = "" Or Current_time.Text = Dusk.Text Then Exit Sub
        event_manager.ShowDialog()
    End Sub

    Private Sub dicerolls_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dicerolls.CheckedChanged, solo.CheckedChanged
        If sender.Checked Then
            emph(sender)
            If sender.name = "dicerolls" Then display_dice = True
        Else
            emph(sender)
            sender = False
        End If
    End Sub
    Private Sub check_color(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles solo.CheckedChanged, dicerolls.CheckedChanged
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub

End Class
