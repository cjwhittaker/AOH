Public Class cgeneral
    Private pnation As String
    Private ptitle As String
    Private pability As String
    Private pattitude As String
    Private pstrength As Integer
    Private pcasualties As Integer
    Private pdeployed As Boolean
    Private pdefensive As Boolean
    Private pmission As String
    Private pedge As String
    Private pplan As String
    Private poom As String
    Private pdoctrine As String
    Property nation() As String
        Get
            Return pnation
        End Get
        Set(ByVal Value As String)
            pnation = Value
        End Set
    End Property
    Property title() As String
        Get
            Return ptitle
        End Get
        Set(ByVal Value As String)
            ptitle = Value
        End Set
    End Property
    Property ability() As String
        Get
            Return pability
        End Get
        Set(ByVal Value As String)
            pability = Value
        End Set
    End Property
    Property attitude() As String
        Get
            Return pattitude
        End Get
        Set(ByVal Value As String)
            pattitude = Value
        End Set
    End Property
    Property strength() As Integer
        Get
            Return pstrength
        End Get
        Set(ByVal Value As Integer)
            pstrength = Value
        End Set
    End Property
    Property casualties() As Integer
        Get
            Return pcasualties
        End Get
        Set(ByVal Value As Integer)
            pcasualties = Value
        End Set
    End Property
    Property deployed() As Boolean
        Get
            Return pdeployed
        End Get
        Set(ByVal Value As Boolean)
            pdeployed = Value
        End Set
    End Property
    Property defensive() As Boolean
        Get
            Return pdefensive
        End Get
        Set(ByVal Value As Boolean)
            pdefensive = Value
        End Set
    End Property
    Property mission() As String
        Get
            Return pmission
        End Get
        Set(ByVal Value As String)
            pmission = Value
        End Set
    End Property
    Property edge() As String
        Get
            Return pedge
        End Get
        Set(ByVal Value As String)
            pedge = Value
        End Set
    End Property
    Property plan() As String
        Get
            Return pplan
        End Get
        Set(ByVal Value As String)
            pplan = Value
        End Set
    End Property
    Property oom() As String
        Get
            Return poom
        End Get
        Set(ByVal Value As String)
            poom = Value
        End Set
    End Property
    Property doctrine() As String
        Get
            Return pdoctrine
        End Get
        Set(ByVal Value As String)
            pdoctrine = Value
        End Set
    End Property


    Public Sub load_from_file(ByVal x As Array)
        Dim i As Integer = 1, currentfield As String
        For Each currentfield In x
            Select Case i
                Case 1 : pnation = currentfield
                Case 2 : ptitle = currentfield
                Case 3 : pability = currentfield
                Case 4 : pattitude = currentfield
                Case 5 : pstrength = Val(currentfield)
                Case 5 : pcasualties = Val(currentfield)
                Case 7 : pdeployed = CBool(currentfield)
                Case 8 : pdefensive = CBool(currentfield)
                Case 9 : pmission = currentfield
                Case 10 : pedge = currentfield
                Case 11 : pplan = currentfield
                Case 12 : poom = currentfield
                Case 13 : pdoctrine = currentfield
            End Select
            i = i + 1
        Next
    End Sub
    Public Sub save_to_file(ByVal x As Object)
        x.WriteLine(nation + "," + title + "," + ability + "," + attitude + "," + Str(strength) + "," + Str(casualties) + "," + Str(deployed) + "," + Str(defensive) + "," + mission + "," + edge + "," + plan + "," + oom + "," + doctrine)
    End Sub
    Public Function finished() As Boolean
        finished = False
        If InStr(title, "CinC") = 0 Then Exit Function
        If plan = "" Or doctrine = "" Or oom = "" Then Exit Function
        finished = True
    End Function
    Public Sub reset()
        With Me
            .nation = ""
            .title = ""
            .ability = ""
            .strength = 0
            .deployed = False
        End With

    End Sub
    Public Function attack()
        If mission = "Attack" Or mission = "Advance" Then attack = True Else attack = False
    End Function
    Public Function defence()
        If mission = "Defend" Then defence = True Else defence = False
    End Function
    Public Function delay()
        If mission = "Delay" Then delay = True Else delay = False
    End Function
End Class
