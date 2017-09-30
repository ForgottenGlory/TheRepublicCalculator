Public Class WarDesigner
    Dim aggScore As Double
    Dim defScore As Double

    Private Sub DrpdwnAgg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpdwnAgg.SelectedIndexChanged
        RecalcWar()
    End Sub

    Private Sub DrpdwnDef_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpdwnDef.SelectedIndexChanged
        RecalcWar()
    End Sub

    Private Sub ChkAggAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAggAll.CheckedChanged
        RecalcWar()
    End Sub

    Private Sub ChkDefAllies_CheckedChanged(sender As Object, e As EventArgs) Handles chkDefAllies.CheckedChanged
        RecalcWar()
    End Sub

    Private Sub RecalcWar()
        aggScore = 0
        defScore = 0

        For Each Nation In RepubCalc.game.Nations
            If drpdwnAgg.SelectedItem = Nation.Name Then
                aggScore += Nation.MilitaryRating
            End If
            If drpdwnDef.SelectedItem = Nation.Name Then
                defScore += Nation.MilitaryRating
            End If
            If chkAggAll.Checked = True Then
                Try
                    For Each ally In Nation.Allies
                        For Each allyNat In RepubCalc.game.Nations
                            If ally = allyNat.Name Then
                                aggScore += allyNat.MilitaryRating
                            End If
                        Next
                    Next
                Catch ex As Exception
                    Console.WriteLine("Allies list empty, ignore this.")
                End Try
            End If
            If chkDefAllies.Checked = True Then
                Try
                    For Each ally In Nation.Allies
                        For Each allyNat In RepubCalc.game.Nations
                            If ally = allyNat.Name Then
                                defScore += allyNat.MilitaryRating
                            End If
                        Next
                    Next
                Catch ex As Exception
                    Console.WriteLine("Allies list empty, ignore this.")
                End Try
            End If
        Next

        lblAggTot.Text = aggScore
        lblDefTot.Text = defScore
    End Sub

    Private Sub BtnSaveWar_Click(sender As Object, e As EventArgs) Handles btnSaveWar.Click
        'Make a new law and pull info from text boxes
        Dim newWar As New War() With {
                .Name = txtWarName.Text,
                .Aggressor = drpdwnAgg.SelectedItem,
                .Defender = drpdwnDef.SelectedItem,
                .AggressorTotalScore = aggScore,
                .AggressorAllies = chkAggAll.Checked,
                .DefenderAllies = chkDefAllies.Checked,
                .DefenderTotalScore = defScore,
                .AggressorWinCount = updwnAggWins.Value,
                .DefenderWinCount = updwnDefWins.Value,
                .Description = txtWarDescr.Text
            }

        'if there are no wars
        If RepubCalc.game.Wars.Length = 0 Then
            'just add the new war
            Array.Resize(RepubCalc.game.Wars, RepubCalc.game.Wars.Length + 1)
            RepubCalc.game.Wars(RepubCalc.game.Wars.Length - 1) = newWar
        Else
            'else check if there is an existing war with the name in the war name text box
            'then if there is an existing war with the same name
            If txtWarName.Text = RepubCalc.drpdwnWars.SelectedItem.ToString Then
                'modify the existing war with the changes made
                RepubCalc.game.Wars(RepubCalc.drpdwnWars.SelectedIndex) = newWar
            Else
                'else just add the war to the end of the list
                Array.Resize(RepubCalc.game.Wars, RepubCalc.game.Wars.Length + 1)
                RepubCalc.game.Wars(RepubCalc.game.Wars.Length - 1) = newWar
            End If
        End If

        RepubCalc.ReloadUI()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub WarDesigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class