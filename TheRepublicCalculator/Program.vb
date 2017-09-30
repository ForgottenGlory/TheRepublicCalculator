Public Class Program

    Dim programName As String
    Dim expired As Boolean
    Dim descr As String

    Public Property Name As String
        Get
            Return programName
        End Get
        Set(value As String)
            programName = value
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
