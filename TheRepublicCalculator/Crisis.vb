Public Class Crisis

    Dim criName As String
    Dim ses As Integer
    Dim isCri As Boolean
    Dim descr As String

    Public Property Name As String
        Get
            Return criName
        End Get
        Set(value As String)
            criName = value
        End Set
    End Property
    Public Property Session As Integer
        Get
            Return ses
        End Get
        Set(value As Integer)
            ses = value
        End Set
    End Property
    Public Property IsCrisis As Boolean
        Get
            Return isCri
        End Get
        Set(value As Boolean)
            isCri = value
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
