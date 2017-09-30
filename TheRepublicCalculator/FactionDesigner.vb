Public Class FactionDesigner
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub BtnSaveFaction_Click(sender As Object, e As EventArgs) Handles btnSaveFaction.Click
        'Make a new faction and pull info from text boxes
        Dim newFaction As New Faction() With {
                .Name = txtFactionName.Text,
                .Percent = updwnPercent.Value / 10,
                .Description = txtFactionDescr.Text,
                .Happiness = updwnHap.Value
            }

        'if there are no factions
        If RepubCalc.game.Factions.Length = 0 Then
            'just add the new faction
            Array.Resize(RepubCalc.game.Factions, RepubCalc.game.Factions.Length + 1)
            RepubCalc.game.Factions(RepubCalc.game.Factions.Length - 1) = newFaction
        Else
            'else check if there is an existing faction with the name in the faction name text box
            'then if there is an existing faction with the same name
            If txtFactionName.Text = RepubCalc.drpdwnFactions.SelectedItem.ToString Then
                'modify the existing faction with the changes made
                RepubCalc.game.Factions(RepubCalc.drpdwnFactions.SelectedIndex) = newFaction
            Else
                'else just add the faction to the end of the list
                Array.Resize(RepubCalc.game.Factions, RepubCalc.game.Factions.Length + 1)
                RepubCalc.game.Factions(RepubCalc.game.Factions.Length - 1) = newFaction
            End If
        End If

        RepubCalc.ReloadUI()
    End Sub

    Private Sub FactionDesigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class