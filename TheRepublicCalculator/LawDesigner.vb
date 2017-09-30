Public Class LawDesigner
    Private Sub BtnCloseLaw_Click(sender As Object, e As EventArgs) Handles btnCloseLaw.Click
        'close the window
        Close()
    End Sub

    Private Sub BtnSaveLaw_Click(sender As Object, e As EventArgs) Handles btnSaveLaw.Click
        'initialize budget changes
        Dim budChanges As New List(Of Double) From {
            updwnEconLaw.Value,
            updwnMilLaw.Value,
            updwnSecLaw.Value,
            updwnJusLaw.Value,
            updwnForLaw.Value,
            updwnPeopLaw.Value,
            updwnTreasLaw.Value
        }

        'determine checkbox status
        Dim inEffect = chkInEffect.Checked
        Dim expired = chkExpired.Checked

        'Make a new law and pull info from text boxes
        Dim newLaw As New Law() With {
                .Name = txtLawName.Text,
                .Duration = updwnDurationLaw.Value,
                .Description = txtLawDescription.Text,
                .BudgetChanges = budChanges,
                .IsInEffect = inEffect,
                .IsExpired = expired
            }

        'if there are no laws
        If RepubCalc.game.Laws.Length = 0 Then
            'just add the new law
            Array.Resize(RepubCalc.game.Laws, RepubCalc.game.Laws.Length + 1)
            RepubCalc.game.Laws(RepubCalc.game.Laws.Length - 1) = newLaw

        Else
            'else check if there is an existing law with the name in the law name text box
            'then if there is an existing law with the same name
            If txtLawName.Text = RepubCalc.drpdwnExistingLaws.SelectedItem.ToString Then
                'modify the existing law with the changes made
                RepubCalc.game.Laws(RepubCalc.drpdwnExistingLaws.SelectedIndex) = newLaw
            Else
                'else just add the law to the end of the list
                Array.Resize(RepubCalc.game.Laws, RepubCalc.game.Laws.Length + 1)
                RepubCalc.game.Laws(RepubCalc.game.Laws.Length - 1) = newLaw
            End If
        End If

        RepubCalc.ReloadUI()
    End Sub

    Private Sub LawDesigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class