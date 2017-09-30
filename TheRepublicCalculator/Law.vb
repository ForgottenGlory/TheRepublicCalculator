Public Class Law

    Dim lawName As String
    Dim lawDuration As Integer
    Dim budChanges As List(Of Double)
    Dim lawVotes As List(Of Boolean)
    Dim descrip As String
    Dim inEffect As Boolean
    Dim expired As Boolean

    Public Property Name As String
        Get
            Return lawName
        End Get
        Set(value As String)
            lawName = value
        End Set
    End Property
    Public Property Duration As Integer
        Get
            Return lawDuration
        End Get
        Set(value As Integer)
            lawDuration = value
        End Set
    End Property
    Public Property BudgetChanges As List(Of Double)
        Get
            Return budChanges
        End Get
        Set(value As List(Of Double))
            budChanges = value
        End Set
    End Property
    Public Property Votes As List(Of Boolean)
        Get
            Return lawVotes
        End Get
        Set(value As List(Of Boolean))
            lawVotes = value
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
    Public Property IsInEffect As Boolean
        Get
            Return inEffect
        End Get
        Set(value As Boolean)
            inEffect = value
        End Set
    End Property
    Public Property IsExpired As Boolean
        Get
            Return expired
        End Get
        Set(value As Boolean)
            expired = value
        End Set
    End Property

End Class
