Public Class ActionDesigner
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub BtnSaveAction_Click(sender As Object, e As EventArgs) Handles btnSaveAction.Click
        Dim newAction As New Action() With {
            .Name = txtActionName.Text,
            .IsExpired = chkExpired.Checked,
            .Description = txtDescription.Text
        }

        'if there are no actions
        If RepubCalc.game.Actions.Length = 0 Then
            'just add the new action
            Array.Resize(RepubCalc.game.Actions, RepubCalc.game.Actions.Length + 1)
            RepubCalc.game.Actions(RepubCalc.game.Actions.Length - 1) = newAction
        Else
            'else check if there is an existing action with the name in the action name text box
            'then if there is an existing action with the same name
            If txtActionName.Text = RepubCalc.drpdwnActions.SelectedItem.ToString Then
                'modify the existing action with the changes made
                RepubCalc.game.Actions(RepubCalc.drpdwnActions.SelectedIndex) = newAction
            Else
                'else just add the action to the end of the list
                Array.Resize(RepubCalc.game.Actions, RepubCalc.game.Actions.Length + 1)
                RepubCalc.game.Actions(RepubCalc.game.Actions.Length - 1) = newAction
            End If
        End If

        RepubCalc.ReloadUI()
    End Sub

End Class