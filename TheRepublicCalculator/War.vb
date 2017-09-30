Public Class War

    Dim warName As String
    Dim warAggressor As String
    Dim warAggScores As List(Of Double)
    Dim warAggTotScore As Double
    Dim warAggAll As Boolean
    Dim warAggWinCount As Integer
    Dim warDefender As String
    Dim warDefAll As Boolean
    Dim warDefScores As List(Of Double)
    Dim warDefTotScore As Double
    Dim warDefWinCount As Integer
    Dim warProgressCount As Integer
    Dim descrip As String

    Public Property Name As String
        Get
            Return warName
        End Get
        Set(value As String)
            warName = value
        End Set
    End Property
    Public Property Aggressor As String
        Get
            Return warAggressor
        End Get
        Set(value As String)
            warAggressor = value
        End Set
    End Property
    Public Property AggressorScores As List(Of Double)
        Get
            Return warAggScores
        End Get
        Set(value As List(Of Double))
            warAggScores = value
        End Set
    End Property
    Public Property AggressorTotalScore As Double
        Get
            Return warAggTotScore
        End Get
        Set(value As Double)
            warAggTotScore = value
        End Set
    End Property
    Public Property AggressorAllies As Boolean
        Get
            Return warAggAll
        End Get
        Set(value As Boolean)
            warAggAll = value
        End Set
    End Property
    Public Property AggressorWinCount As Integer
        Get
            Return warAggWinCount
        End Get
        Set(value As Integer)
            warAggWinCount = value
        End Set
    End Property
    Public Property Defender As String
        Get
            Return warDefender
        End Get
        Set(value As String)
            warDefender = value
        End Set
    End Property
    Public Property DefenderAllies As Boolean
        Get
            Return warDefAll
        End Get
        Set(value As Boolean)
            warDefAll = value
        End Set
    End Property
    Public Property DefenderScores As List(Of Double)
        Get
            Return warDefScores
        End Get
        Set(value As List(Of Double))
            warDefScores = value
        End Set
    End Property
    Public Property DefenderTotalScore As Double
        Get
            Return warDefTotScore
        End Get
        Set(value As Double)
            warDefTotScore = value
        End Set
    End Property
    Public Property DefenderWinCount As Integer
        Get
            Return warDefWinCount
        End Get
        Set(value As Integer)
            warDefWinCount = value
        End Set
    End Property
    Public Property ProgressCount As Integer
        Get
            Return warProgressCount
        End Get
        Set(value As Integer)
            warProgressCount = value
        End Set
    End Property
    Public Property Description As String
        Get
            Return descrip
        End Get
        Set(value As String)
            descrip = value
        End Set
    End Property

    Public Sub ProgressWar()
        '0 = aggressor, 1 = defender, 2 = evenly matched
        Dim whoIsWinning As Integer
        'calculate difference in scores
        Dim winner = warAggTotScore - warDefTotScore

        If winner >= 1 Then
            whoIsWinning = 0
            AggressorWinCount += 1
        ElseIf winner <= -1 Then
            whoIsWinning = 1
            DefenderWinCount += 1
        Else
            whoIsWinning = 2
        End If

        ProgressCount += 1



    End Sub

End Class
