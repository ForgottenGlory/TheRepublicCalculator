Public Class Report

    Dim repName As String
    Dim ses As Integer
    Dim descr As String
    Dim isCust As Boolean

    Public Property Name As String
        Get
            Return repName
        End Get
        Set(value As String)
            repName = value
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
    Public Property Description As String
        Get
            Return descr
        End Get
        Set(value As String)
            descr = value
        End Set
    End Property
    Public Property IsCustom As Boolean
        Get
            Return isCust
        End Get
        Set(value As Boolean)
            isCust = value
        End Set
    End Property
End Class
