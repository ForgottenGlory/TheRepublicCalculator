Public Class Minister

    Dim minName As String
    Dim goa As String
    Dim descr As String
    Dim img As String

    Public Property Name As String
        Get
            Return minName
        End Get
        Set(value As String)
            minName = value
        End Set
    End Property
    Public Property Goals As String
        Get
            Return goa
        End Get
        Set(value As String)
            goa = value
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
    Public Property ImageLoc As String
        Get
            Return img
        End Get
        Set(value As String)
            img = value
        End Set
    End Property

End Class
