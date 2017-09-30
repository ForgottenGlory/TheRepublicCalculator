Public Class PollConductor
    Dim numberOfLabels As Integer
    Dim labels() As Label

    Private Sub PollConductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numberOfLabels = RepubCalc.game.Factions.Length - 1

        ReDim labels(numberOfLabels)
        For i As Integer = 0 To numberOfLabels
            Dim mylabel As New Label With {
                .Visible = True,
                .Location = New Point(55, 33 + i * 13),
                .Text = "Button " + (i + 1).ToString
            }

        Next

    End Sub
End Class