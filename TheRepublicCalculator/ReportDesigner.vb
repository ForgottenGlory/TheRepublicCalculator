Public Class ReportDesigner
    Private Sub BtnSaveReport_Click(sender As Object, e As EventArgs) Handles btnSaveReport.Click
        Dim newReport As New Report With {
            .Name = txtReportName.Text,
            .Session = updwnSession.Text,
            .Description = txtReportDescr.Text
        }

        If chkIsCustom.Checked = True Then
            newReport.IsCustom = True
        Else
            newReport.IsCustom = False
        End If

        If RepubCalc.game.Reports.Length = 0 Then
            'just add the new event
            Array.Resize(RepubCalc.game.Reports, RepubCalc.game.Reports.Length + 1)
            RepubCalc.game.Reports(RepubCalc.game.Reports.Length - 1) = newReport

        Else
            'else check if there is an existing event with the name in the event name text box
            'then if there is an existing event with the same name
            If txtReportName.Text = RepubCalc.drpdwnReports.SelectedItem.ToString Then
                'modify the existing event with the changes made
                RepubCalc.game.Reports(RepubCalc.drpdwnReports.SelectedIndex) = newReport
            Else
                'else just add the event to the end of the list
                Array.Resize(RepubCalc.game.Reports, RepubCalc.game.Reports.Length + 1)
                RepubCalc.game.Reports(RepubCalc.game.Reports.Length - 1) = newReport
            End If
        End If

        RepubCalc.ReloadUI()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub ReportDesigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class