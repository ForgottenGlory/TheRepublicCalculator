Public Class MinisterDesigner
    Dim imgPath As String

    Private Sub MinisterDesigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles imgMinister.Click
        Dim openDialog As New OpenFileDialog() With {
            .Filter = "PNG | *.png | Bitmap | *.bmp | JPG | *.jpg | GIF | *.gif | All Files| *.*",
            .FileName = ""
        }

        If openDialog.ShowDialog(Me) = DialogResult.OK Then
            Dim img = openDialog.FileName
            'Create a new Bitmap and display it
            imgMinister.Image = Image.FromFile(img)
            imgPath = img
        End If
    End Sub

    Private Sub BtnMinClose_Click(sender As Object, e As EventArgs) Handles btnMinClose.Click
        Close()
    End Sub

    Private Sub BtnSaveMinister_Click(sender As Object, e As EventArgs) Handles btnSaveMinister.Click
        'Make a new law and pull info from text boxes
        Dim newMinister As New Minister() With {
                .Name = txtMinisterName.Text,
                .Goals = txtMinisterGoals.Text,
                .Description = txtMinisterDescr.Text,
                .ImageLoc = imgPath
            }

        'if there are no laws
        If RepubCalc.game.Ministers.Length = 0 Then
            'just add the new law
            Array.Resize(RepubCalc.game.Ministers, RepubCalc.game.Ministers.Length + 1)
            RepubCalc.game.Ministers(RepubCalc.game.Ministers.Length - 1) = newMinister
        Else
            'else check if there is an existing law with the name in the law name text box
            'then if there is an existing law with the same name
            If txtMinisterName.Text = RepubCalc.drpdwnMinisters.SelectedItem.ToString Then
                'modify the existing law with the changes made
                RepubCalc.game.Ministers(RepubCalc.drpdwnMinisters.SelectedIndex) = newMinister
            Else
                'else just add the law to the end of the list
                Array.Resize(RepubCalc.game.Ministers, RepubCalc.game.Ministers.Length + 1)
                RepubCalc.game.Ministers(RepubCalc.game.Ministers.Length - 1) = newMinister
            End If
        End If

        RepubCalc.ReloadUI()
    End Sub
End Class