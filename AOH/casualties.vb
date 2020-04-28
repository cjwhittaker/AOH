Public Class casualties
    Public cas_adjust_mode As String
    Private Sub confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirm.Click
        If cas_adjust_mode = "both" Then
            For y As Integer = 1 To 2
                Dim ctrl As String = IIf(y = 1, "p1_", "p2_")
                For Each c As Control In Controls
                    If c.Name = ctrl + "cas" Then
                        Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                        losses(y, 1) = Val(chk.Value)
                    ElseIf c.Name = ctrl + "ske" Then
                        Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                        losses(y, 2) = Val(chk.Value)
                    ElseIf c.Name = ctrl + "cap" Then
                        Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                        losses(y, 3) = Val(chk.Value)
                    ElseIf c.Name = ctrl + "ldr" Then
                        Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                        losses(y, 4) = Val(chk.Value)
                    ElseIf c.Name = ctrl + "art" Then
                        Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                        losses(y, 5) = Val(chk.Value)
                    Else
                    End If
                Next
            Next
        Else
            Dim ctrl As String = IIf(scenariodefaults.player1.Text = cas_adjust_mode, "p1_", "p2_")
            Dim y As Integer = IIf(ctrl = "p1_", 1, 2)
            For Each c As Control In Controls
                If c.Name = ctrl + "cas" Then
                    Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                    losses(y, 1) = losses(y, 1) + Val(chk.Value)
                ElseIf c.Name = ctrl + "ske" Then
                    Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                    losses(y, 2) = losses(y, 2) + Val(chk.Value)
                ElseIf c.Name = ctrl + "cap" Then
                    Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                    losses(y, 3) = losses(y, 3) + Val(chk.Value)
                Else
                End If
            Next

        End If
        Close()
    End Sub
    Public Sub cas_adjust()
        If cas_adjust_mode <> "both" Then
            Dim ctrl As String = IIf(scenariodefaults.player1.Text = cas_adjust_mode, "p1_", "p2_")
            For Each c As Control In Controls
                If c.Name = ctrl + "cas" Then
                    Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                    chk.Value = cas
                ElseIf c.Name = ctrl + "ske" Then
                    Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                    chk.Value = routed
                ElseIf c.Name = ctrl + "cap" Then
                    Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                    chk.Value = captured
                Else
                End If
            Next
        Else
            For y As Integer = 1 To 2
                Dim ctrl As String = IIf(y = 1, "p1_", "p2_")
                For Each c As Control In Controls
                    If c.Name = ctrl + "cas" Then
                        Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                        chk.Value = losses(y, 1)
                    ElseIf c.Name = ctrl + "ske" Then
                        Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                        chk.Value = losses(y, 2)
                    ElseIf c.Name = ctrl + "cap" Then
                        Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                        chk.Value = losses(y, 3)
                    ElseIf c.Name = ctrl + "ldr" Then
                        Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                        chk.Value = losses(y, 4)
                    ElseIf c.Name = ctrl + "art" Then
                        Dim chk As NumericUpDown = DirectCast(c, NumericUpDown)
                        chk.Value = losses(y, 5)
                    Else
                    End If
                Next
            Next
        End If

    End Sub
    Private Sub casualties_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub casualties_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        confirm_Click(confirm, Nothing)
    End Sub
End Class