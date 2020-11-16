Module Module1
    'Test 
    Public currdir As String, goback As Boolean = False, event_list As Collection, generals As Collection, timed_event As cevents, display_dice As Boolean, solo_game As Boolean
    Public p1 As String, p2 As String
    Public cas As Single = 0, routed As Integer = 0, captured As Integer = 0
    Public p1_poor As Integer, p1_average As Integer, p1_cautious As Integer, p1_bold As Integer
    Public p2_poor As Integer, p2_average As Integer, p2_cautious As Integer, p2_bold As Integer
    Public player1_cinc_attached As Boolean, player1_cinc_superceding As Boolean, player2_cinc_attached As Boolean, player2_cinc_superceding As Boolean
    Public player1_cinc_dead As Boolean, player2_cinc_dead As Boolean
    Public losses(3, 5) As Single
    Public defa As Color = Control.DefaultBackColor, golden As Color = Color.Goldenrod
    Public plan_criteria(7, 6) As String, attack(3, 3) As String, loss_rate(13, 3) As String, deployment(24, 3) As String, defence(3, 3) As String
    Public oom(3, 3) As String
    Public firecharts = New Integer(50, 13) {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1},
                                            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2},
                                            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 2, 2},
                                            {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2},
                                            {0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 2},
                                            {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3},
                                            {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3},
                                            {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 3, 3},
                                            {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 3, 3},
                                            {0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3},
                                            {0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3},
                                            {0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3},
                                            {0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3},
                                            {0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3},
                                            {0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4},
                                            {0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4},
                                            {0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4},
                                            {0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4},
                                            {0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4},
                                            {0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4},
                                            {0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4},
                                            {0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4},
                                            {0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4},
                                            {0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4},
                                            {0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4},
                                            {0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4},
                                            {0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4},
                                            {0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4},
                                            {0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4},
                                            {0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4},
                                            {0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4},
                                            {0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4},
                                            {0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4},
                                            {0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4},
                                            {0, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4},
                                            {0, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4},
                                            {0, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4},
                                            {0, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4},
                                            {0, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4},
                                            {0, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4, 4},
                                            {0, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4, 4},
                                            {0, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4, 4},
                                            {0, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4, 4},
                                            {0, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4, 4},
                                            {0, 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4},
                                            {0, 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4},
                                            {0, 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4},
                                            {0, 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4},
                                            {0, 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4},
                                            {0, 1, 2, 2, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4}}
    Public Function get_cohesion(p As String)
        Dim x As Single = 0, y As Integer = 0, stands As Integer = 0
        get_cohesion = 0
        If p = My.Forms.scenariodefaults.player1.Text Then
            y = 1
            stands = Val(scenariodefaults.player1_stands.Text)
        Else
            y = 2
            stands = Val(scenariodefaults.player2_stands.Text)
        End If
        For i = 1 To 5 : x = x + Str(losses(y, i)) : Next
        x = 100 * x / stands
        'x = 100 * (My.Forms.casualties.p1_cas.Value + My.Forms.casualties.p1_ske.Value + My.Forms.casualties.p1_cap.Value + My.Forms.casualties.p1_ldr.Value + My.Forms.casualties.p1_art.Value) / Val(scenariodefaults.player1_stands.Text)
        'x = 100 * (My.Forms.casualties.p2_cas.Value + My.Forms.casualties.p2_ske.Value + My.Forms.casualties.p2_cap.Value + My.Forms.casualties.p2_ldr.Value + My.Forms.casualties.p2_art.Value) / Val(scenariodefaults.player2_stands.Text)
        get_cohesion = -(Int(x / 5) - 5)
        If get_cohesion >= 0 Then get_cohesion = 0
    End Function
    Public Sub test_sub()

    End Sub
    Public Sub emph(x As Object)
        If x.backcolor = defa Then x.backcolor = golden Else x.backcolor = defa
    End Sub
    Public Function get_modifier(obj As Object, ramp As Array, inc As Integer)
        get_modifier = 0
        For i As Integer = 0 To ramp.Length - 1
            If obj.text = ramp(i) Then
                If i = 0 Or i = ramp.Length - 1 Then emph(obj)
                If i < ramp.Length - 1 Then
                    get_modifier = inc
                    obj.text = ramp(i + 1)
                Else
                    get_modifier = -1 * inc * (ramp.Length - 1)
                    obj.text = ramp(0)
                End If
                Exit Function
            End If
        Next
    End Function
    Public Sub table_side()
        Dim compass() As String = {"", "N", "NE", "E", "SE", "S", "SW", "W", "NW"}, p1_roll As Integer, p2_roll As Integer, p1 As String, p2 As String
        Do
            p1_roll = dice(10) : p2_roll = dice(10)
            p1_roll = p1_roll + scenariodefaults.player1_init.Text
            p2_roll = p2_roll + scenariodefaults.player2_init.Text
        Loop Until p1_roll <> p2_roll
        If p1_roll > p2_roll Then
            p1 = scenariodefaults.player1.Text
            p2 = scenariodefaults.player2.Text
        Else
            p1 = scenariodefaults.player2.Text
            p2 = scenariodefaults.player1.Text
        End If
        p1_roll = dice(8)
        generals(p1 + "CinC").edge = compass(p1_roll)
        p2_roll = dice(3)
        generals(p2 + "CinC").edge = compass(IIf(p2_roll + p1_roll + 2 > 8, p2_roll + p1_roll - 6, p2_roll + p1_roll + 2))
    End Sub

    Function dice(ByVal die As Integer)
        dice = 1 + Int(die * Rnd())
    End Function

    Sub quitprogram()
        If MsgBox("Do you wish to quit the program", MsgBoxStyle.YesNo, "Quit Program") = MsgBoxResult.Yes Then
            If scenariodefaults.phase > 1 Then scenariodefaults.phase = scenariodefaults.phase - 1
            savedata(scenariodefaults.scenario)
        Else
            scenariodefaults.quit = False
        End If
    End Sub
    Public Sub logging(log As String)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(Replace(scenariodefaults.scenario, ".sce", ".his"), True)
        file.WriteLine(log)
        file.Close()
    End Sub
    Sub savedata(ByVal scenariofile As String)
        Dim file As System.IO.StreamWriter, loss As String = ""
        If scenariofile Is Nothing Then Exit Sub
        file = My.Computer.FileSystem.OpenTextFileWriter(scenariofile, False)
        file.WriteLine("player1=," + My.Forms.scenariodefaults.player1.Text + "," + (My.Forms.scenariodefaults.player1_init.Text) + "," + Str(player1_cinc_attached) + "," + Str(player1_cinc_superceding) + "," + Str(player1_cinc_dead))
        file.WriteLine("player2=," + My.Forms.scenariodefaults.player2.Text + "," + (My.Forms.scenariodefaults.player2_init.Text) + "," + Str(player2_cinc_attached) + "," + Str(player2_cinc_superceding) + "," + Str(player2_cinc_dead))
        file.WriteLine("player 1 Generals=," + Str(p1_average) + "," + Str(p1_bold) + "," + Str(p1_cautious) + "," + Str(p1_poor))
        file.WriteLine("player 2 Generals=," + Str(p2_average) + "," + Str(p2_bold) + "," + Str(p2_cautious) + "," + Str(p2_poor))
        file.WriteLine("starttime=," + scenariodefaults.start_time.Text)
        file.WriteLine("dusk=," + scenariodefaults.Dusk.Text)
        file.WriteLine("currenttime=," + scenariodefaults.Current_time.Text)
        file.WriteLine("gameturn=," + scenariodefaults.gameturn.Text)
        file.WriteLine("p1=," + p1)
        file.WriteLine("p2=," + p2)
        file.WriteLine("p1strength=," + scenariodefaults.player1_stands.Text)
        file.WriteLine("p2strength=," + scenariodefaults.player2_stands.Text)
        file.WriteLine("player phase=," + Str(scenariodefaults.playerphase))
        file.WriteLine("game phase=," + Str(scenariodefaults.phase))
        For i = 1 To 5 : loss = loss + Str(losses(1, i)) + IIf(i < 5, ",", "") : Next
        file.WriteLine("p1losses=," + loss)
        loss = ""
        For i = 1 To 5 : loss = loss + Str(losses(2, i)) + IIf(i < 5, ",", "") : Next
        file.WriteLine("p2losses=," + loss)
        file.Close()
        If event_list.Count > 0 Then
            scenariofile = Strings.Left(scenariofile, InStrRev(scenariofile, ".") - 1) + ".ent"
            file = My.Computer.FileSystem.OpenTextFileWriter(scenariofile, False)
            For Each e As cevents In event_list
                e.save_to_file(file)
            Next
            file.Close()
        End If
        If solo_game And Not generals Is Nothing Then
            scenariofile = Strings.Left(scenariofile, InStrRev(scenariofile, ".") - 1) + ".gen"
            file = My.Computer.FileSystem.OpenTextFileWriter(scenariofile, False)
            For Each g As cgeneral In generals
                g.save_to_file(file)
            Next
            file.Close()
        ElseIf Not solo_game Then
            scenariofile = Strings.Left(scenariofile, InStrRev(scenariofile, ".") - 1) + ".gen"
            If My.Computer.FileSystem.FileExists(scenariofile) Then My.Computer.FileSystem.DeleteFile(scenariofile)

        Else

        End If

    End Sub

    Public Sub load_events(ByVal scenariofile As String)
        scenariofile = Strings.Left(scenariofile, InStrRev(scenariofile, ".") - 1) + ".ent"
        If Not My.Computer.FileSystem.FileExists(scenariofile) Then Exit Sub
        event_list = New Collection
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(scenariofile)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            While Not MyReader.EndOfData
                Dim e = New cevents
                Try

                    e.load_from_file(MyReader.ReadFields)

                    event_list.Add(e)
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub
    Public Sub load_generals(ByVal scenariofile As String)
        scenariofile = Strings.Left(scenariofile, InStrRev(scenariofile, ".") - 1) + ".gen"
        If Not My.Computer.FileSystem.FileExists(scenariofile) Then Exit Sub
        generals = New Collection
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(scenariofile)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            While Not MyReader.EndOfData
                Dim g = New cgeneral
                Try

                    g.load_from_file(MyReader.ReadFields)

                    generals.Add(g, g.nation + g.title)
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub
    Public Sub load_doctrine()
        If Not My.Computer.FileSystem.FileExists(currdir + "\solo.txt") Then Exit Sub
        Dim lineread As Array
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(currdir + "\solo.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            While Not MyReader.EndOfData
                Try
                    lineread = MyReader.ReadFields
                    If lineread(0) = "Attitude" Then
                        Do
                            For j As Integer = 0 To 7
                                For i As Integer = 1 To 3
                                    plan_criteria(j, 3 + i) = lineread(i)
                                Next
                                lineread = MyReader.ReadFields
                                If lineread(0) = "Ability" Then Exit For
                            Next
                        Loop Until lineread(0) = "Ability"
                    End If
                    If lineread(0) = "Ability" Then
                        Do
                            For j As Integer = 0 To 7
                                For i As Integer = 1 To 3
                                    plan_criteria(j, i) = lineread(i)
                                Next
                                lineread = MyReader.ReadFields
                                If lineread(0) = "OOM" Then Exit For
                            Next
                        Loop Until lineread(0) = "OOM"
                    End If
                    If lineread(0) = "OOM" Then
                        Do
                            For j As Integer = 0 To 3
                                For i As Integer = 0 To 3
                                    oom(j, i) = lineread(i)
                                Next
                                lineread = MyReader.ReadFields
                                If lineread(0) = "Attack" Then Exit For
                            Next
                        Loop Until lineread(0) = "Attack"
                    End If
                    If lineread(0) = "Attack" Then
                        Do
                            For j As Integer = 0 To 3
                                For i As Integer = 0 To 3
                                    attack(j, i) = lineread(i)
                                Next
                                lineread = MyReader.ReadFields
                                If lineread(0) = "Defence" Then Exit For
                            Next
                        Loop Until lineread(0) = "Defence"
                    End If
                    If lineread(0) = "Defence" Then
                        Do
                            For j As Integer = 0 To 3
                                For i As Integer = 0 To 3
                                    defence(j, i) = lineread(i)
                                Next
                                lineread = MyReader.ReadFields
                                If lineread(0) = "Casualties" Then Exit For
                            Next
                        Loop Until lineread(0) = "Casualties"
                    End If

                    If lineread(0) = "Casualties" Then
                        Do
                            For j As Integer = 0 To 13
                                For i As Integer = 0 To 3
                                    loss_rate(j, i) = lineread(i)
                                Next
                                lineread = MyReader.ReadFields
                                If lineread(0) = "Deployment" Then Exit For
                            Next
                        Loop Until lineread(0) = "Deployment"
                    End If
                    If lineread(0) = "Deployment" Then
                        Do
                            For j As Integer = 0 To 24
                                For i As Integer = 0 To 3
                                    deployment(j, i) = lineread(i)
                                Next
                                lineread = MyReader.ReadFields
                            Next
                        Loop Until MyReader.EndOfData
                    End If

                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub


    Public Sub test_for_events(ByVal s As String, ByVal t As String)
        For Each e As cevents In event_list
            If Not e.tested Then
                If t >= e.time And (s = e.side Or e.side = "Both") Then
                    If e.die = "None" Then
                        e.tested = True
                    Else
                        Dim d6 As Integer = dice(6), d10 As Integer = dice(10)
                        If (e.die = "D6" And d6 >= e.score) Or (e.die = "D10" And d10 >= e.score) Then
                            e.tested = True
                        Else
                            If e.dec Then e.score = e.score - 1
                        End If
                    End If
                    If e.tested Then
                        With resultform
                            .Text = "Game Events - GT" + Trim(Str(scenariodefaults.gameturn.Text)) + " at " + scenariodefaults.Current_time.Text + "hrs"
                            .result.Text = e.text
                            .adjust.Visible = False
                            .reverse.Visible = False
                            .arty.Visible = False
                            .leader.Visible = False
                            .confirm.Visible = True
                            .ShowDialog()
                        End With
                    End If
                End If
            End If
        Next
    End Sub
    Public Sub test_for_decisions(s As String)
        With solo_settings
            .player.Text = s
            .generate_command_decisions()
            '.ShowDialog()
        End With
    End Sub

    Public Sub update_casualties(side As String)
        If generals Is Nothing Then Exit Sub
        Dim y As Integer, x As Integer
        'If side = scenariodefaults.player1.Text Then
        '    generals(side + "CinC").casualties = casualties.p1_cas.Value + casualties.p1_ske.Value + casualties.p1_cap.Value + casualties.p1_art.Value
        'Else
        '    generals(side + "CinC").casualties = casualties.p2_cas.Value + casualties.p2_ske.Value + casualties.p2_cap.Value + casualties.p2_art.Value
        'End If
        If side = My.Forms.scenariodefaults.player1.Text Then y = 1 Else y = 2
        For i = 1 To 5
            If i <> 4 Then x = x + Str(losses(y, i))
        Next
        generals(side + "CinC").casualties = x
    End Sub
    Public Sub display_adjust_casualties(side As String)
        With casualties
            .p1.Text = scenariodefaults.player1.Text
            .p2.Text = scenariodefaults.player2.Text
            .cas_adjust_mode = side
            .cas_adjust()
            .ShowDialog()
            .Dispose()
        End With
    End Sub
End Module
