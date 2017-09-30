Public Class Nation

    Dim nationName As String
    Dim econRtg As Double
    Dim econGrw As Double
    Dim milRtg As Double
    Dim milGrw As Double
    Dim secRtg As Double
    Dim secGrw As Double
    Dim jusRtg As Double
    Dim jusGrw As Double
    Dim forRtg As Double
    Dim forGrw As Double
    Dim hapRtg As Double
    Dim hapGrw As Double
    Dim treas As Double
    Dim treasGrw As Double
    Dim pop As Double
    Dim popGrw As Double
    Dim all As List(Of String)
    Dim ene As List(Of String)
    Dim war As List(Of String)
    Dim opNats As List(Of String)
    Dim opScores As List(Of Double)
    Dim opGrw As List(Of Double)
    Dim budTotal As Double
    Dim spnd As List(Of Double)
    Dim spy As Integer
    Dim fac As List(Of String)

    Public Property Name As String
        Get
            Return nationName
        End Get
        Set(value As String)
            nationName = value
        End Set
    End Property
    Public Property EconomyRating As Double
        Get
            Return econRtg
        End Get
        Set(value As Double)
            econRtg = value
        End Set
    End Property
    Public Property EconomyGrowth As Double
        Get
            Return econGrw
        End Get
        Set(value As Double)
            econGrw = value
        End Set
    End Property
    Public Property MilitaryRating As Double
        Get
            Return milRtg
        End Get
        Set(value As Double)
            milRtg = value
        End Set
    End Property
    Public Property MilitaryGrowth As Double
        Get
            Return milGrw
        End Get
        Set(value As Double)
            milGrw = value
        End Set
    End Property
    Public Property SecurityRating As Double
        Get
            Return secRtg
        End Get
        Set(value As Double)
            secRtg = value
        End Set
    End Property
    Public Property SecurityGrowth As Double
        Get
            Return secGrw
        End Get
        Set(value As Double)
            secGrw = value
        End Set
    End Property
    Public Property JusticeRating As Double
        Get
            Return jusRtg
        End Get
        Set(value As Double)
            jusRtg = value
        End Set
    End Property
    Public Property JusticeGrowth As Double
        Get
            Return jusGrw
        End Get
        Set(value As Double)
            jusGrw = value
        End Set
    End Property
    Public Property ForeignRating As Double
        Get
            Return forRtg
        End Get
        Set(value As Double)
            forRtg = value
        End Set
    End Property
    Public Property ForeignGrowth As Double
        Get
            Return forGrw
        End Get
        Set(value As Double)
            forGrw = value
        End Set
    End Property
    Public Property HappinessRating As Double
        Get
            Return hapRtg
        End Get
        Set(value As Double)
            hapRtg = value
        End Set
    End Property
    Public Property HappinessGrowth As Double
        Get
            Return hapGrw
        End Get
        Set(value As Double)
            hapGrw = value
        End Set
    End Property
    Public Property Treasury As Double
        Get
            Return treas
        End Get
        Set(value As Double)
            treas = value
        End Set
    End Property
    Public Property TreasuryGrowth As Double
        Get
            Return treasGrw
        End Get
        Set(value As Double)
            treasGrw = value
        End Set
    End Property
    Public Property Population As Double
        Get
            Return pop
        End Get
        Set(value As Double)
            pop = value
        End Set
    End Property
    Public Property PopulationGrowth As Double
        Get
            Return popGrw
        End Get
        Set(value As Double)
            popGrw = value
        End Set
    End Property
    Public Property Allies As List(Of String)
        Get
            Return all
        End Get
        Set(value As List(Of String))
            all = value
        End Set
    End Property
    Public Property Enemies As List(Of String)
        Get
            Return ene
        End Get
        Set(value As List(Of String))
            ene = value
        End Set
    End Property
    Public Property Wars As List(Of String)
        Get
            Return war
        End Get
        Set(value As List(Of String))
            war = value
        End Set
    End Property
    Public Property OpinionNations As List(Of String)
        Get
            Return opNats
        End Get
        Set(value As List(Of String))
            opNats = value
        End Set
    End Property
    Public Property OpinionScores As List(Of Double)
        Get
            Return opScores
        End Get
        Set(value As List(Of Double))
            opScores = value
        End Set
    End Property
    Public Property OpinionGrowth As List(Of Double)
        Get
            Return opGrw
        End Get
        Set(value As List(Of Double))
            opGrw = value
        End Set
    End Property
    Public Property BudgetTotal As Double
        Get
            Return budTotal
        End Get
        Set(value As Double)
            budTotal = value
        End Set
    End Property
    Public Property Spending As List(Of Double)
        Get
            Return spnd
        End Get
        Set(value As List(Of Double))
            spnd = value
        End Set
    End Property
    Public Property SpyRating As Double
        Get
            Return spy
        End Get
        Set(value As Double)
            spy = value
        End Set
    End Property
    Public Property Factions As List(Of String)
        Get
            Return fac
        End Get
        Set(value As List(Of String))
            fac = value
        End Set
    End Property

End Class
