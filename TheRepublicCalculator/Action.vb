Public Class Action

    Dim actionName As String
    Dim expired As Boolean
    Dim descr As String

    Public Property Name As String
        Get
            Return actionName
        End Get
        Set(value As String)
            actionName = value
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

    Public Property Description As String
        Get
            Return descr
        End Get
        Set(value As String)
            descr = value
        End Set
    End Property

End Class
