Public Class GameState
    Dim curSes As Integer
    Dim curPhase As Integer

    Public Property CurrentSession As Integer
        Get
            Return curSes
        End Get
        Set(value As Integer)
            curSes = value
        End Set
    End Property

    Public Property CurrentPhase As Integer
        Get
            Return curPhase
        End Get
        Set(value As Integer)
            curPhase = value
        End Set
    End Property

    Public Sub IncrementPhase()
        Select Case curPhase
            Case 0
                curPhase += 1
                MessageBox.Show("Phase changed from 'In Session' to 'Voting'.", "Phase Incremented", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Case 1
                Dim msg = "Progress phase from 'Voting' to 'Results'? Game will calculate all changes based on growth and laws. This cannot be undone."
                Dim title = "Increment Phase?"
                Dim style = MsgBoxStyle.YesNo
                Dim response = MsgBox(msg, style, title)

                If response = MsgBoxResult.Yes Then
                    'TODO: calculate all the things
                    Dim repub = RepubCalc.game.Nations(0)
                    Dim alphon = RepubCalc.game.Nations(1)
                    Dim betae = RepubCalc.game.Nations(2)
                    Dim deltis = RepubCalc.game.Nations(3)
                    Dim omegor = RepubCalc.game.Nations(4)
                    Dim epsilus = RepubCalc.game.Nations(5)
                    Dim zetiy = RepubCalc.game.Nations(6)
                    Dim thetidon = RepubCalc.game.Nations(7)
                    Dim taue = RepubCalc.game.Nations(8)
                    Dim omicrad = RepubCalc.game.Nations(9)
                    Dim gamman = RepubCalc.game.Nations(10)
                    Dim iotanis = RepubCalc.game.Nations(11)
                    Dim muphus = RepubCalc.game.Nations(12)

                    'calc other nations changes here
                    For k = 1 To 12
                        Dim nat = RepubCalc.game.Nations(k)
                        nat.EconomyRating = nat.EconomyRating + nat.EconomyGrowth
                        nat.EconomyGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        nat.MilitaryRating = nat.MilitaryRating + nat.MilitaryGrowth
                        nat.MilitaryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        nat.SecurityRating = nat.SecurityRating + nat.SecurityGrowth
                        nat.SecurityGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        nat.JusticeRating = nat.JusticeRating + nat.JusticeGrowth
                        nat.JusticeGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        nat.ForeignRating = nat.ForeignRating + nat.ForeignGrowth
                        nat.ForeignGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        nat.HappinessRating = nat.HappinessRating + nat.HappinessGrowth
                        nat.HappinessGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        nat.Treasury = nat.Treasury + nat.TreasuryGrowth
                        nat.TreasuryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 10), 2)
                        nat.Population = nat.Population + nat.PopulationGrowth
                        nat.PopulationGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 3), 2)
                    Next

                    'calc new opinion scores
                    'for each nation, set each opinion score equal to the initial score plus the change in score of the other nations
                    For op = 1 To 12
                        Dim nat = RepubCalc.game.Nations(op)
                        For opch = 0 To 12
                            nat.OpinionScores(opch) += nat.OpinionGrowth(opch)
                        Next
                    Next

                    'calculate new opinion growths
                    Dim alOpGrVals As New List(Of Double)
                    alOpGrVals.Add(repub.OpinionGrowth(1))
                    alOpGrVals.Add(0.00)

                    For i = 0 To 10
                        Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        alOpGrVals.Add(dbl)
                    Next

                    alphon.OpinionGrowth = alOpGrVals

                    Dim beOpGrVals As New List(Of Double)
                    beOpGrVals.Add(repub.OpinionGrowth(2))
                    beOpGrVals.Add(alphon.OpinionGrowth(2))
                    beOpGrVals.Add(0.00)

                    For i = 0 To 9
                        Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        beOpGrVals.Add(dbl)
                    Next

                    betae.OpinionGrowth = beOpGrVals

                    Dim deOpGrVals As New List(Of Double)

                    deOpGrVals.Add(repub.OpinionGrowth(3))
                    deOpGrVals.Add(alphon.OpinionGrowth(3))
                    deOpGrVals.Add(betae.OpinionGrowth(3))
                    deOpGrVals.Add(0.00)

                    For i = 0 To 8
                        Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        deOpGrVals.Add(dbl)
                    Next

                    deltis.OpinionGrowth = deOpGrVals

                    Dim omOpGrVals As New List(Of Double)

                    omOpGrVals.Add(repub.OpinionGrowth(4))
                    omOpGrVals.Add(alphon.OpinionGrowth(4))
                    omOpGrVals.Add(betae.OpinionGrowth(4))
                                omOpGrVals.Add(deltis.OpinionGrowth(4))
                                omOpGrVals.Add(0.00)

                    For i = 0 To 7
                        Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        omOpGrVals.Add(dbl)
                    Next

                    omegor.OpinionGrowth = omOpGrVals

                    Dim epOpGrVals As New List(Of Double)

                    epOpGrVals.Add(repub.OpinionGrowth(5))
                    epOpGrVals.Add(alphon.OpinionGrowth(5))
                    epOpGrVals.Add(betae.OpinionGrowth(5))
                    epOpGrVals.Add(deltis.OpinionGrowth(5))
                    epOpGrVals.Add(omegor.OpinionGrowth(5))
                    epOpGrVals.Add(0.00)

                    For i = 0 To 6
                        Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        epOpGrVals.Add(dbl)
                    Next

                    epsilus.OpinionGrowth = epOpGrVals

                    Dim zeOpGrVals As New List(Of Double)

                    zeOpGrVals.Add(repub.OpinionGrowth(6))
                    zeOpGrVals.Add(alphon.OpinionGrowth(6))
                    zeOpGrVals.Add(betae.OpinionGrowth(6))
                    zeOpGrVals.Add(deltis.OpinionGrowth(6))
                    zeOpGrVals.Add(omegor.OpinionGrowth(6))
                    zeOpGrVals.Add(epsilus.OpinionGrowth(6))
                    zeOpGrVals.Add(0.00)

                    For i = 0 To 5
                        Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        zeOpGrVals.Add(dbl)
                    Next

                    zetiy.OpinionGrowth = zeOpGrVals

                    Dim thOpGrVals As New List(Of Double)

                    thOpGrVals.Add(repub.OpinionGrowth(7))
                    thOpGrVals.Add(alphon.OpinionGrowth(7))
                    thOpGrVals.Add(betae.OpinionGrowth(7))
                    thOpGrVals.Add(deltis.OpinionGrowth(7))
                    thOpGrVals.Add(omegor.OpinionGrowth(7))
                    thOpGrVals.Add(epsilus.OpinionGrowth(7))
                    thOpGrVals.Add(zetiy.OpinionGrowth(7))
                    thOpGrVals.Add(0.00)

                    For i = 0 To 4
                        Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        thOpGrVals.Add(dbl)
                    Next

                    thetidon.OpinionGrowth = thOpGrVals

                    Dim taOpGrVals As New List(Of Double)

                    taOpGrVals.Add(repub.OpinionGrowth(8))
                    taOpGrVals.Add(alphon.OpinionGrowth(8))
                    taOpGrVals.Add(betae.OpinionGrowth(8))
                    taOpGrVals.Add(deltis.OpinionGrowth(8))
                    taOpGrVals.Add(omegor.OpinionGrowth(8))
                    taOpGrVals.Add(epsilus.OpinionGrowth(8))
                    taOpGrVals.Add(zetiy.OpinionGrowth(8))
                    taOpGrVals.Add(thetidon.OpinionGrowth(8))
                    taOpGrVals.Add(0.00)

                    For i = 0 To 3
                        Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        taOpGrVals.Add(dbl)
                    Next

                    taue.OpinionGrowth = taOpGrVals

                    Dim omiOpGrVals As New List(Of Double)

                    omiOpGrVals.Add(repub.OpinionGrowth(9))
                    omiOpGrVals.Add(alphon.OpinionGrowth(9))
                    omiOpGrVals.Add(betae.OpinionGrowth(9))
                    omiOpGrVals.Add(deltis.OpinionGrowth(9))
                    omiOpGrVals.Add(omegor.OpinionGrowth(9))
                    omiOpGrVals.Add(epsilus.OpinionGrowth(9))
                    omiOpGrVals.Add(zetiy.OpinionGrowth(9))
                    omiOpGrVals.Add(thetidon.OpinionGrowth(9))
                    omiOpGrVals.Add(taue.OpinionGrowth(9))
                    omiOpGrVals.Add(0.00)

                    For i = 0 To 2
                        Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        omiOpGrVals.Add(dbl)
                    Next

                    omicrad.OpinionGrowth = omiOpGrVals

                    Dim gaOpGrVals As New List(Of Double)

                    gaOpGrVals.Add(repub.OpinionGrowth(10))
                    gaOpGrVals.Add(alphon.OpinionGrowth(10))
                    gaOpGrVals.Add(betae.OpinionGrowth(10))
                    gaOpGrVals.Add(deltis.OpinionGrowth(10))
                    gaOpGrVals.Add(omegor.OpinionGrowth(10))
                    gaOpGrVals.Add(epsilus.OpinionGrowth(10))
                    gaOpGrVals.Add(zetiy.OpinionGrowth(10))
                    gaOpGrVals.Add(thetidon.OpinionGrowth(10))
                    gaOpGrVals.Add(taue.OpinionGrowth(10))
                    gaOpGrVals.Add(omicrad.OpinionGrowth(10))
                    gaOpGrVals.Add(0.00)

                    For i = 0 To 1
                        Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                        gaOpGrVals.Add(dbl)
                    Next

                    gamman.OpinionGrowth = gaOpGrVals

                    Dim ioOpGrVals As New List(Of Double)

                    ioOpGrVals.Add(repub.OpinionGrowth(11))
                    ioOpGrVals.Add(alphon.OpinionGrowth(11))
                    ioOpGrVals.Add(betae.OpinionGrowth(11))
                    ioOpGrVals.Add(deltis.OpinionGrowth(11))
                    ioOpGrVals.Add(omegor.OpinionGrowth(11))
                    ioOpGrVals.Add(epsilus.OpinionGrowth(11))
                    ioOpGrVals.Add(zetiy.OpinionGrowth(11))
                    ioOpGrVals.Add(thetidon.OpinionGrowth(11))
                    ioOpGrVals.Add(taue.OpinionGrowth(11))
                    ioOpGrVals.Add(omicrad.OpinionGrowth(11))
                    ioOpGrVals.Add(gamman.OpinionGrowth(11))
                    ioOpGrVals.Add(0.00)

                    Dim iodbl2 As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                    ioOpGrVals.Add(iodbl2)

                    iotanis.OpinionGrowth = ioOpGrVals

                    Dim muOpGrVals As New List(Of Double)

                    muOpGrVals.Add(repub.OpinionGrowth(12))
                    muOpGrVals.Add(alphon.OpinionGrowth(12))
                    muOpGrVals.Add(betae.OpinionGrowth(12))
                    muOpGrVals.Add(deltis.OpinionGrowth(12))
                    muOpGrVals.Add(omegor.OpinionGrowth(12))
                    muOpGrVals.Add(epsilus.OpinionGrowth(12))
                    muOpGrVals.Add(zetiy.OpinionGrowth(12))
                    muOpGrVals.Add(thetidon.OpinionGrowth(12))
                    muOpGrVals.Add(taue.OpinionGrowth(12))
                    muOpGrVals.Add(omicrad.OpinionGrowth(12))
                    muOpGrVals.Add(gamman.OpinionGrowth(12))
                    muOpGrVals.Add(iotanis.OpinionGrowth(12))
                    muOpGrVals.Add(0.00)

                    muphus.OpinionGrowth = muOpGrVals

                    'calc Republic changes
                    For opch = 0 To 12
                        repub.OpinionScores(opch) += repub.OpinionGrowth(opch) + (repub.ForeignGrowth / 10)
                    Next

                    Dim laws = RepubCalc.game.Laws

                    Try
                        For Each law In laws
                            If law.IsInEffect = True And law.IsExpired = False Then
                                repub.EconomyGrowth += law.BudgetChanges(0) / 10
                                repub.MilitaryGrowth += law.BudgetChanges(1) / 10
                                repub.SecurityGrowth += law.BudgetChanges(2) / 10
                                repub.JusticeGrowth += law.BudgetChanges(3) / 10
                                repub.ForeignGrowth += law.BudgetChanges(4) / 10
                                repub.HappinessGrowth += law.BudgetChanges(5) / 10
                                repub.TreasuryGrowth += law.BudgetChanges(6) / 10
                            End If
                        Next
                    Catch ex As Exception
                        Console.WriteLine("game.Laws is empty")
                    End Try


                    repub.PopulationGrowth = repub.PopulationGrowth + repub.HappinessGrowth

                    repub.EconomyRating = repub.EconomyRating + repub.EconomyGrowth
                    repub.MilitaryRating = repub.MilitaryRating + repub.MilitaryGrowth
                    repub.SecurityRating = repub.SecurityRating + repub.SecurityGrowth
                    repub.JusticeRating = repub.JusticeRating + repub.JusticeGrowth
                    repub.ForeignRating = repub.ForeignRating + repub.ForeignGrowth
                    repub.HappinessRating = repub.HappinessRating + repub.HappinessGrowth
                    repub.Treasury = repub.Treasury + repub.TreasuryGrowth
                    repub.Population = repub.Population + repub.PopulationGrowth

                    MessageBox.Show("Phase changed from 'Voting' to 'Results'. All calculations complete.", "Phase Incremented", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    curPhase += 1
                End If
            Case 2
                Dim msg = "Progress phase from 'Results' to 'In Session'? Session will increment. This cannot be undone."
                Dim title = "Next Session?"
                Dim style = MsgBoxStyle.YesNo
                Dim response = MsgBox(msg, style, title)

                If response = MsgBoxResult.Yes Then
                    curPhase = 0
                    IncrementSession()
                End If
        End Select
    End Sub

    Public Sub IncrementSession()
        curSes += 1
    End Sub

End Class
