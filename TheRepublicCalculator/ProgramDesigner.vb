Public Class ProgramDesigner
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub BtnSaveProgram_Click(sender As Object, e As EventArgs) Handles btnSaveProgram.Click
        Dim newProgram As New Program() With {
            .Name = txtProgramName.Text,
            .IsExpired = chkExpired.Checked,
            .Description = txtDescription.Text
        }

        'if there are no programs
        If RepubCalc.game.Programs.Length = 0 Then
            'just add the new program
            Array.Resize(RepubCalc.game.Programs, RepubCalc.game.Programs.Length + 1)
            RepubCalc.game.Programs(RepubCalc.game.Programs.Length - 1) = newProgram
        Else
            'else check if there is an existing program with the name in the program name text box
            'then if there is an existing program with the same name
            If txtProgramName.Text = RepubCalc.drpdwnPrograms.SelectedItem.ToString Then
                'modify the existing program with the changes made
                RepubCalc.game.Programs(RepubCalc.drpdwnPrograms.SelectedIndex) = newProgram
            Else
                'else just add the program to the end of the list
                Array.Resize(RepubCalc.game.Programs, RepubCalc.game.Programs.Length + 1)
                RepubCalc.game.Programs(RepubCalc.game.Programs.Length - 1) = newProgram
            End If
        End If

        RepubCalc.ReloadUI()
    End Sub

    Private Sub ProgramDesigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class