Public Class Faction
    Dim factionName As String
    Dim perc As Double
    Dim descr As String
    Dim hap As Double

    Public Property Name As String
        Get
            Return factionName
        End Get
        Set(value As String)
            factionName = value
        End Set
    End Property

    Public Property Percent As Double
        Get
            Return perc * 10
        End Get
        Set(value As Double)
            perc = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return descr
        End Get
        Set(value As String)
            descr = value
        End Set
    End Property

    Public Property Happiness As Double
        Get
            Return hap
        End Get
        Set(value As Double)
            hap = value
        End Set
    End Property

End Class
