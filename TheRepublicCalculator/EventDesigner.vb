Public Class EventDesigner
    Private Sub BtnSaveEvent_Click(sender As Object, e As EventArgs) Handles btnSaveEvent.Click
        Dim newEvent As New Crisis With {
            .Name = txtCrisisName.Text,
            .Session = txtSession.Text,
            .Description = txtCrisisDescr.Text
        }

        If chkIsCrisis.Checked = True Then
            newEvent.IsCrisis = True
        Else
            newEvent.IsCrisis = False
        End If

        If RepubCalc.game.Crises.Length = 0 Then
            'just add the new event
            Array.Resize(RepubCalc.game.Crises, RepubCalc.game.Crises.Length + 1)
            RepubCalc.game.Crises(RepubCalc.game.Crises.Length - 1) = newEvent

        Else
            'else check if there is an existing event with the name in the event name text box
            'then if there is an existing event with the same name
            If txtCrisisName.Text = RepubCalc.drpdwnEventCrises.SelectedItem.ToString Then
                'modify the existing event with the changes made
                RepubCalc.game.Crises(RepubCalc.drpdwnEventCrises.SelectedIndex) = newEvent
            Else
                'else just add the event to the end of the list
                Array.Resize(RepubCalc.game.Crises, RepubCalc.game.Crises.Length + 1)
                RepubCalc.game.Crises(RepubCalc.game.Crises.Length - 1) = newEvent
            End If
        End If

        RepubCalc.ReloadUI()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub BtnGenEvent_Click(sender As Object, e As EventArgs) Handles btnGenEvent.Click
        Dim msg = "Generate a new event?"
        Dim title = "Event Generation"
        Dim style = MsgBoxStyle.YesNo
        Dim response = MsgBox(msg, style, title)

        If response = MsgBoxResult.Yes Then
            Dim myRandom As New Random()
            If myRandom.Next(1, 100) < 51 Then
                chkIsCrisis.Checked = True
                txtCrisisName.Text = "Crisis!"
                txtCrisisDescr.Text = "This is a crisis! Come up with something bad for The Republic to deal with."
            Else
                chkIsCrisis.Checked = False
                txtCrisisName.Text = "Event!"
                txtCrisisDescr.Text = "This is an event! Come up with something good for The Republic to take advantage of."
            End If
        End If
    End Sub
End Class