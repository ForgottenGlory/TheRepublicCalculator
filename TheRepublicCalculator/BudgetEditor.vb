Public Class BudgetEditor
    Private Sub BudgetEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdwnEcon_ValueChanged(sender As Object, e As EventArgs) Handles updwnEcon.ValueChanged
        recalcTotal()
    End Sub

    Private Sub UpdwnMil_ValueChanged(sender As Object, e As EventArgs) Handles updwnMil.ValueChanged
        recalcTotal()
    End Sub

    Private Sub UpdwnSec_ValueChanged(sender As Object, e As EventArgs) Handles updwnSec.ValueChanged
        recalcTotal()
    End Sub

    Private Sub UpdwnJus_ValueChanged(sender As Object, e As EventArgs) Handles updwnJus.ValueChanged
        recalcTotal()
    End Sub

    Private Sub UpdwnFor_ValueChanged(sender As Object, e As EventArgs) Handles updwnFor.ValueChanged
        recalcTotal()
    End Sub

    Private Sub UpdwnPeo_ValueChanged(sender As Object, e As EventArgs) Handles updwnPeo.ValueChanged
        recalcTotal()
    End Sub

    Private Sub UpdwnTreas_ValueChanged(sender As Object, e As EventArgs) Handles updwnTreas.ValueChanged
        recalcTotal()
    End Sub

    Public Sub RecalcTotal()
        Dim newTotal As Double

        newTotal = updwnEcon.Value + updwnMil.Value + updwnSec.Value + updwnJus.Value + updwnFor.Value + updwnPeo.Value + updwnTreas.Value

        lblTotNum.Text = newTotal
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub BtnSaveBudget_Click(sender As Object, e As EventArgs) Handles btnSaveBudget.Click
        Dim repub = RepubCalc.game.Nations(0)

        repub.EconomyGrowth = updwnEcon.Value / 10
        repub.MilitaryGrowth = updwnMil.Value / 10
        repub.SecurityGrowth = updwnSec.Value / 10
        repub.JusticeGrowth = updwnJus.Value / 10
        repub.ForeignGrowth = updwnFor.Value / 10
        repub.HappinessGrowth = updwnPeo.Value / 10
        repub.TreasuryGrowth = updwnTreas.Value

        MessageBox.Show("New Budget saved successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class