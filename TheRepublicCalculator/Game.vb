Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports System.Xml.Serialization

<Serializable()> Public Class Game
    Public Property Path As String

    <XmlArray("Nations")>
    <XmlArrayItem(GetType(Nation))>
    Public Property Nations As Nation()

    <XmlArray("Ministers")>
    <XmlArrayItem(GetType(Minister))>
    Public Property Ministers As Minister()

    <XmlArray("Laws")>
    <XmlArrayItem(GetType(Law))>
    Public Property Laws As Law()

    <XmlArray("Crises")>
    <XmlArrayItem(GetType(Crisis))>
    Public Property Crises As Crisis()

    <XmlArray("Reports")>
    <XmlArrayItem(GetType(Report))>
    Public Property Reports As Report()

    <XmlArray("Factions")>
    <XmlArrayItem(GetType(Faction))>
    Public Property Factions As Faction()

    <XmlArray("Wars")>
    <XmlArrayItem(GetType(War))>
    Public Property Wars As War()

    <XmlArray("Programs")>
    <XmlArrayItem(GetType(Program))>
    Public Property Programs As Program()

    <XmlArray("Actions")>
    <XmlArrayItem(GetType(Action))>
    Public Property Actions As Action()

    <XmlArray("Game State")>
    <XmlArrayItem(GetType(GameState))>
    Public Property GameStates As GameState()

    Public Function Serialize(FileInfo As System.IO.FileInfo)
        Try
            If File.Exists(FileInfo.FullName) Then
                File.Delete(FileInfo.FullName)
            End If

            If Not Directory.Exists(FileInfo.DirectoryName) Then
                Directory.CreateDirectory(FileInfo.DirectoryName)
            End If

            Me.Path = FileInfo.FullName

            Dim serializer As XmlSerializer = New XmlSerializer(GetType(Game))
            Dim writer As StreamWriter = New StreamWriter(FileInfo.FullName)

            serializer.Serialize(writer, Me)
            writer.Close()
        Catch ex As Exception
            Console.WriteLine("Error serializing")
        End Try
    End Function

    Public Shared Function Deserialize(FileInfo As FileInfo) As Game
        Dim serializedType As Game = Nothing

        Dim path As String = FileInfo.FullName

        If (Not File.Exists(path)) Then
            Deserialize = serializedType
        Else
            Try
                Dim serializer As XmlSerializer = New XmlSerializer(GetType(Game))
                Dim reader As StreamReader = New StreamReader(path)
                serializedType = serializer.Deserialize(reader)
                reader.Close()
                Deserialize = serializedType
            Catch ex As Exception
                Console.WriteLine("Error deserializing")
            End Try
        End If

        Return serializedType
    End Function

    Public Sub RemoveAt(Of T)(ByRef arr As T(), ByVal index As Integer)
        Dim uBound = arr.GetUpperBound(0)
        Dim lBound = arr.GetLowerBound(0)
        Dim arrLen = uBound - lBound

        If index < lBound OrElse index > uBound Then
            Throw New ArgumentOutOfRangeException(
            String.Format("Index must be from {0} to {1}.", lBound, uBound))
        Else
            'create an array 1 element less than the input array
            Dim outArr(arrLen - 1) As T
            'copy the first part of the input array
            Array.Copy(arr, 0, outArr, 0, index)
            'then copy the second part of the input array
            Array.Copy(arr, index + 1, outArr, index, uBound - index)

            arr = outArr
        End If
    End Sub
End Class
