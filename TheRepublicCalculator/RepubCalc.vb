Imports System
Imports System.Xml
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports System.Xml.Serialization
<Assembly: log4net.Config.XmlConfigurator(ConfigFile:="Log4Net.Config.xml", Watch:=True)>

Public Class RepubCalc

    Private Shared ReadOnly log As log4net.ILog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

    Dim strPath As String = ""
    Public game As New Game() With {
        .Nations = New Nation() {},
        .Ministers = New Minister() {},
        .Laws = New Law() {},
        .Crises = New Crisis() {},
        .Reports = New Report() {},
        .GameStates = New GameState() {},
        .Wars = New War() {},
        .Factions = New Faction() {},
        .Actions = New Action() {},
        .Programs = New Program() {}
    }

    Private Sub RepubCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGameStatus.Text = "Welcome to The Republic Calculator!"
        txtGameStatus.Text &= vbNewLine & vbNewLine & "To get started, click the 'New Game' button in the top left corner."
        txtGameStatus.Text &= vbNewLine & vbNewLine & "If you haven't already, it's strongly suggested that you read the rules for The Republic."

        log.Info("Program started successfully!")
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click

        log.Info("New game button clicked.")

        'Initialize Randomizer
        Randomize()

        Dim saveDialog As New SaveFileDialog() With {
            .Filter = "XML-File | *.xml"
        }

        If saveDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Set strPath equal to the file the user specified
            strPath = saveDialog.FileName

            log.Info("New game created at " & saveDialog.FileName)

            'Set initial game state
            Array.Resize(game.GameStates, game.GameStates.Length + 1)
            game.GameStates(game.GameStates.Length - 1) = New GameState With {
                .CurrentSession = 1,
                .CurrentPhase = 0
            }

            log.Info("GameState initialized")

            'Initialize starting values for The Republic
            Dim repub As New Nation() With {
                .Name = "The Republic",
                .EconomyRating = 10,
                .EconomyGrowth = 0,
                .MilitaryRating = 10,
                .MilitaryGrowth = 0,
                .SecurityRating = 10,
                .SecurityGrowth = 0,
                .JusticeRating = 10,
                .JusticeGrowth = 0,
                .ForeignRating = 10,
                .ForeignGrowth = 0,
                .HappinessRating = 10,
                .HappinessGrowth = 0,
                .Treasury = 0,
                .TreasuryGrowth = 40,
                .Population = 100,
                .PopulationGrowth = 1,
                .Allies = New List(Of String),
                .Enemies = New List(Of String),
                .Wars = New List(Of String)
            }

            'Create list of local nations
            Dim nats As New List(Of String) From {
                "Alphon",
                "Betae",
                "Deltis",
                "Omegor",
                "Epsilus",
                "Zetiy",
                "Thetidon",
                "Taue",
                "Omicrad",
                "Gamman",
                "Iotanis",
                "Muphus"
            }

            repub.OpinionNations = nats

            'Randomize starting opinions of non-Republic nations
            Dim vals1 As New List(Of Double) From {
                0.00
            }

            For i = 0 To 11
                Dim dbl As Double = Math.Round(CDbl((Rnd() * ((-1) ^ Int(Rnd() * 10))) * 8), 2)
                vals1.Add(dbl)
            Next

            repub.OpinionScores = vals1

            'Randomize opinion growth of non-republic nations
            Dim vals2 As New List(Of Double) From {
                0.00
            }

            For i = 0 To 11
                Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                vals2.Add(dbl)
            Next

            repub.OpinionGrowth = vals2

            'set initial republic budget total
            repub.BudgetTotal = 100

            'set initial republic spending values
            Dim vals3 As New List(Of Double) From {
                10.0,
                10.0,
                10.0,
                10.0,
                10.0,
                10.0,
                40.0
            }

            repub.Spending = vals3

            log.Info("Republic created.")

            'Generate Alphon
            Dim alphon As New Nation() With {
                .Name = "Alphon",
                .EconomyRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .EconomyGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .MilitaryRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .MilitaryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .SecurityRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .SecurityGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .JusticeRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .JusticeGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .ForeignRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .ForeignGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .HappinessRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .HappinessGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .Treasury = CDbl(Math.Floor((20 - 0 + 1) * Rnd())) + 0,
                .TreasuryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 10), 2),
                .Population = CDbl(Math.Floor((130 - 80 + 1) * Rnd())) + 80,
                .PopulationGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 3), 2)
            }

            Dim alOpVals As New List(Of Double)
            Dim alOpGrVals As New List(Of Double)
            alOpVals.Add(repub.OpinionScores(1))
            alOpVals.Add(0.00)

            alOpGrVals.Add(repub.OpinionGrowth(1))
            alOpGrVals.Add(0.00)

            For i = 0 To 10
                Dim dbl As Double = Math.Round(CDbl((Rnd() * ((-1) ^ Int(Rnd() * 10))) * 5), 2)
                alOpVals.Add(dbl)
            Next
            For i = 0 To 10
                Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                alOpGrVals.Add(dbl)
            Next

            alphon.OpinionScores = alOpVals
            alphon.OpinionGrowth = alOpGrVals

            log.Info("Alphon created.")

            'Generate Betae
            Dim betae As New Nation() With {
                .Name = "Betae",
                .EconomyRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .EconomyGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .MilitaryRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .MilitaryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .SecurityRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .SecurityGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .JusticeRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .JusticeGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .ForeignRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .ForeignGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .HappinessRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .HappinessGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .Treasury = CDbl(Math.Floor((20 - 0 + 1) * Rnd())) + 0,
                .TreasuryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 10), 2),
                .Population = CDbl(Math.Floor((130 - 80 + 1) * Rnd())) + 80,
                .PopulationGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 3), 2)
            }

            Dim beOpVals As New List(Of Double)
            Dim beOpGrVals As New List(Of Double)
            beOpVals.Add(repub.OpinionScores(2))
            beOpVals.Add(alphon.OpinionScores(2))
            beOpVals.Add(0.00)

            beOpGrVals.Add(repub.OpinionGrowth(2))
            beOpGrVals.Add(alphon.OpinionGrowth(2))
            beOpGrVals.Add(0.00)

            For i = 0 To 9
                Dim dbl As Double = Math.Round(CDbl((Rnd() * ((-1) ^ Int(Rnd() * 10))) * 5), 2)
                beOpVals.Add(dbl)
            Next
            For i = 0 To 9
                Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                beOpGrVals.Add(dbl)
            Next

            betae.OpinionScores = beOpVals
            betae.OpinionGrowth = beOpGrVals

            log.Info("Betae created.")

            'Generate Deltis
            Dim deltis As New Nation() With {
                .Name = "Deltis",
                .EconomyRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .EconomyGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .MilitaryRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .MilitaryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .SecurityRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .SecurityGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .JusticeRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .JusticeGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .ForeignRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .ForeignGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .HappinessRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .HappinessGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .Treasury = CDbl(Math.Floor((20 - 0 + 1) * Rnd())) + 0,
                .TreasuryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 10), 2),
                .Population = CDbl(Math.Floor((130 - 80 + 1) * Rnd())) + 80,
                .PopulationGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 3), 2)
            }

            Dim deOpVals As New List(Of Double)
            Dim deOpGrVals As New List(Of Double)
            deOpVals.Add(repub.OpinionScores(3))
            deOpVals.Add(alphon.OpinionScores(3))
            deOpVals.Add(betae.OpinionScores(3))
            deOpVals.Add(0.00)

            deOpGrVals.Add(repub.OpinionGrowth(3))
            deOpGrVals.Add(alphon.OpinionGrowth(3))
            deOpGrVals.Add(betae.OpinionGrowth(3))
            deOpGrVals.Add(0.00)

            For i = 0 To 8
                Dim dbl As Double = Math.Round(CDbl((Rnd() * ((-1) ^ Int(Rnd() * 10))) * 5), 2)
                deOpVals.Add(dbl)
            Next
            For i = 0 To 8
                Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                deOpGrVals.Add(dbl)
            Next

            deltis.OpinionScores = deOpVals
            deltis.OpinionGrowth = deOpGrVals

            log.Info("Deltis created.")

            'Generate Omegor
            Dim omegor As New Nation() With {
                .Name = "Omegor",
                .EconomyRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .EconomyGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .MilitaryRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .MilitaryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .SecurityRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .SecurityGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .JusticeRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .JusticeGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .ForeignRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .ForeignGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .HappinessRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .HappinessGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .Treasury = CDbl(Math.Floor((20 - 0 + 1) * Rnd())) + 0,
                .TreasuryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 10), 2),
                .Population = CDbl(Math.Floor((130 - 80 + 1) * Rnd())) + 80,
                .PopulationGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 3), 2)
            }

            Dim omOpVals As New List(Of Double)
            Dim omOpGrVals As New List(Of Double)
            omOpVals.Add(repub.OpinionScores(4))
            omOpVals.Add(alphon.OpinionScores(4))
            omOpVals.Add(betae.OpinionScores(4))
            omOpVals.Add(deltis.OpinionScores(4))
            omOpVals.Add(0.00)

            omOpGrVals.Add(repub.OpinionGrowth(4))
            omOpGrVals.Add(alphon.OpinionGrowth(4))
            omOpGrVals.Add(betae.OpinionGrowth(4))
            omOpGrVals.Add(deltis.OpinionGrowth(4))
            omOpGrVals.Add(0.00)

            For i = 0 To 7
                Dim dbl As Double = Math.Round(CDbl((Rnd() * ((-1) ^ Int(Rnd() * 10))) * 5), 2)
                omOpVals.Add(dbl)
            Next
            For i = 0 To 7
                Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                omOpGrVals.Add(dbl)
            Next

            omegor.OpinionScores = omOpVals
            omegor.OpinionGrowth = omOpGrVals

            log.Info("Omegor created.")

            'Generate Epsilus
            Dim epsilus As New Nation() With {
                .Name = "Epsilus",
                .EconomyRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .EconomyGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .MilitaryRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .MilitaryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .SecurityRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .SecurityGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .JusticeRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .JusticeGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .ForeignRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .ForeignGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .HappinessRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .HappinessGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .Treasury = CDbl(Math.Floor((20 - 0 + 1) * Rnd())) + 0,
                .TreasuryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 10), 2),
                .Population = CDbl(Math.Floor((130 - 80 + 1) * Rnd())) + 80,
                .PopulationGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 3), 2)
            }

            Dim epOpVals As New List(Of Double)
            Dim epOpGrVals As New List(Of Double)
            epOpVals.Add(repub.OpinionScores(5))
            epOpVals.Add(alphon.OpinionScores(5))
            epOpVals.Add(betae.OpinionScores(5))
            epOpVals.Add(deltis.OpinionScores(5))
            epOpVals.Add(omegor.OpinionScores(5))
            epOpVals.Add(0.00)

            epOpGrVals.Add(repub.OpinionGrowth(5))
            epOpGrVals.Add(alphon.OpinionGrowth(5))
            epOpGrVals.Add(betae.OpinionGrowth(5))
            epOpGrVals.Add(deltis.OpinionGrowth(5))
            epOpGrVals.Add(omegor.OpinionGrowth(5))
            epOpGrVals.Add(0.00)

            For i = 0 To 6
                Dim dbl As Double = Math.Round(CDbl((Rnd() * ((-1) ^ Int(Rnd() * 10))) * 5), 2)
                epOpVals.Add(dbl)
            Next
            For i = 0 To 6
                Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                epOpGrVals.Add(dbl)
            Next

            epsilus.OpinionScores = epOpVals
            epsilus.OpinionGrowth = epOpGrVals

            log.Info("Epsilus created.")

            'Generate Zetiy
            Dim zetiy As New Nation() With {
                .Name = "Zetiy",
                .EconomyRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .EconomyGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .MilitaryRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .MilitaryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .SecurityRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .SecurityGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .JusticeRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .JusticeGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .ForeignRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .ForeignGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .HappinessRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .HappinessGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .Treasury = CDbl(Math.Floor((20 - 0 + 1) * Rnd())) + 0,
                .TreasuryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 10), 2),
                .Population = CDbl(Math.Floor((130 - 80 + 1) * Rnd())) + 80,
                .PopulationGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 3), 2)
            }

            Dim zeOpVals As New List(Of Double)
            Dim zeOpGrVals As New List(Of Double)
            zeOpVals.Add(repub.OpinionScores(6))
            zeOpVals.Add(alphon.OpinionScores(6))
            zeOpVals.Add(betae.OpinionScores(6))
            zeOpVals.Add(deltis.OpinionScores(6))
            zeOpVals.Add(omegor.OpinionScores(6))
            zeOpVals.Add(epsilus.OpinionScores(6))
            zeOpVals.Add(0.00)

            zeOpGrVals.Add(repub.OpinionGrowth(6))
            zeOpGrVals.Add(alphon.OpinionGrowth(6))
            zeOpGrVals.Add(betae.OpinionGrowth(6))
            zeOpGrVals.Add(deltis.OpinionGrowth(6))
            zeOpGrVals.Add(omegor.OpinionGrowth(6))
            zeOpGrVals.Add(epsilus.OpinionGrowth(6))
            zeOpGrVals.Add(0.00)

            For i = 0 To 5
                Dim dbl As Double = Math.Round(CDbl((Rnd() * ((-1) ^ Int(Rnd() * 10))) * 5), 2)
                zeOpVals.Add(dbl)
            Next
            For i = 0 To 5
                Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                zeOpGrVals.Add(dbl)
            Next

            zetiy.OpinionScores = zeOpVals
            zetiy.OpinionGrowth = zeOpGrVals

            log.Info("Zetiy created.")

            'Generate Thetidon
            Dim thetidon As New Nation() With {
                .Name = "Thetidon",
                .EconomyRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .EconomyGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .MilitaryRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .MilitaryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .SecurityRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .SecurityGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .JusticeRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .JusticeGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .ForeignRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .ForeignGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .HappinessRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .HappinessGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .Treasury = CDbl(Math.Floor((20 - 0 + 1) * Rnd())) + 0,
                .TreasuryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 10), 2),
                .Population = CDbl(Math.Floor((130 - 80 + 1) * Rnd())) + 80,
                .PopulationGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 3), 2)
            }

            Dim thOpVals As New List(Of Double)
            Dim thOpGrVals As New List(Of Double)
            thOpVals.Add(repub.OpinionScores(7))
            thOpVals.Add(alphon.OpinionScores(7))
            thOpVals.Add(betae.OpinionScores(7))
            thOpVals.Add(deltis.OpinionScores(7))
            thOpVals.Add(omegor.OpinionScores(7))
            thOpVals.Add(epsilus.OpinionScores(7))
            thOpVals.Add(zetiy.OpinionScores(7))
            thOpVals.Add(0.00)

            thOpGrVals.Add(repub.OpinionGrowth(7))
            thOpGrVals.Add(alphon.OpinionGrowth(7))
            thOpGrVals.Add(betae.OpinionGrowth(7))
            thOpGrVals.Add(deltis.OpinionGrowth(7))
            thOpGrVals.Add(omegor.OpinionGrowth(7))
            thOpGrVals.Add(epsilus.OpinionGrowth(7))
            thOpGrVals.Add(zetiy.OpinionGrowth(7))
            thOpGrVals.Add(0.00)

            For i = 0 To 4
                Dim dbl As Double = Math.Round(CDbl((Rnd() * ((-1) ^ Int(Rnd() * 10))) * 5), 2)
                thOpVals.Add(dbl)
            Next
            For i = 0 To 4
                Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                thOpGrVals.Add(dbl)
            Next

            thetidon.OpinionScores = thOpVals
            thetidon.OpinionGrowth = thOpGrVals

            log.Info("Thetidon created.")

            'Generate Taue
            Dim taue As New Nation() With {
                .Name = "Taue",
                .EconomyRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .EconomyGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .MilitaryRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .MilitaryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .SecurityRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .SecurityGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .JusticeRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .JusticeGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .ForeignRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .ForeignGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .HappinessRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .HappinessGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .Treasury = CDbl(Math.Floor((20 - 0 + 1) * Rnd())) + 0,
                .TreasuryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 10), 2),
                .Population = CDbl(Math.Floor((130 - 80 + 1) * Rnd())) + 80,
                .PopulationGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 3), 2)
            }

            Dim taOpVals As New List(Of Double)
            Dim taOpGrVals As New List(Of Double)
            taOpVals.Add(repub.OpinionScores(8))
            taOpVals.Add(alphon.OpinionScores(8))
            taOpVals.Add(betae.OpinionScores(8))
            taOpVals.Add(deltis.OpinionScores(8))
            taOpVals.Add(omegor.OpinionScores(8))
            taOpVals.Add(epsilus.OpinionScores(8))
            taOpVals.Add(zetiy.OpinionScores(8))
            taOpVals.Add(thetidon.OpinionScores(8))
            taOpVals.Add(0.00)

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
                Dim dbl As Double = Math.Round(CDbl((Rnd() * ((-1) ^ Int(Rnd() * 10))) * 5), 2)
                taOpVals.Add(dbl)
            Next
            For i = 0 To 3
                Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                taOpGrVals.Add(dbl)
            Next

            taue.OpinionScores = taOpVals
            taue.OpinionGrowth = taOpGrVals

            log.Info("Taue created.")

            'Generate Omicrad
            Dim omicrad As New Nation() With {
                .Name = "Omicrad",
                .EconomyRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .EconomyGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .MilitaryRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .MilitaryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .SecurityRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .SecurityGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .JusticeRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .JusticeGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .ForeignRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .ForeignGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .HappinessRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .HappinessGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .Treasury = CDbl(Math.Floor((20 - 0 + 1) * Rnd())) + 0,
                .TreasuryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 10), 2),
                .Population = CDbl(Math.Floor((130 - 80 + 1) * Rnd())) + 80,
                .PopulationGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 3), 2)
            }

            Dim omiOpVals As New List(Of Double)
            Dim omiOpGrVals As New List(Of Double)
            omiOpVals.Add(repub.OpinionScores(9))
            omiOpVals.Add(alphon.OpinionScores(9))
            omiOpVals.Add(betae.OpinionScores(9))
            omiOpVals.Add(deltis.OpinionScores(9))
            omiOpVals.Add(omegor.OpinionScores(9))
            omiOpVals.Add(epsilus.OpinionScores(9))
            omiOpVals.Add(zetiy.OpinionScores(9))
            omiOpVals.Add(thetidon.OpinionScores(9))
            omiOpVals.Add(taue.OpinionScores(9))
            omiOpVals.Add(0.00)

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
                Dim dbl As Double = Math.Round(CDbl((Rnd() * ((-1) ^ Int(Rnd() * 10))) * 5), 2)
                omiOpVals.Add(dbl)
            Next
            For i = 0 To 2
                Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                omiOpGrVals.Add(dbl)
            Next

            omicrad.OpinionScores = omiOpVals
            omicrad.OpinionGrowth = omiOpGrVals

            log.Info("Omicrad created.")

            'Generate Gamman
            Dim gamman As New Nation() With {
                .Name = "Gamman",
                .EconomyRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .EconomyGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .MilitaryRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .MilitaryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .SecurityRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .SecurityGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .JusticeRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .JusticeGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .ForeignRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .ForeignGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .HappinessRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .HappinessGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .Treasury = CDbl(Math.Floor((20 - 0 + 1) * Rnd())) + 0,
                .TreasuryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 10), 2),
                .Population = CDbl(Math.Floor((130 - 80 + 1) * Rnd())) + 80,
                .PopulationGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 3), 2)
            }

            Dim gaOpVals As New List(Of Double)
            Dim gaOpGrVals As New List(Of Double)
            gaOpVals.Add(repub.OpinionScores(10))
            gaOpVals.Add(alphon.OpinionScores(10))
            gaOpVals.Add(betae.OpinionScores(10))
            gaOpVals.Add(deltis.OpinionScores(10))
            gaOpVals.Add(omegor.OpinionScores(10))
            gaOpVals.Add(epsilus.OpinionScores(10))
            gaOpVals.Add(zetiy.OpinionScores(10))
            gaOpVals.Add(thetidon.OpinionScores(10))
            gaOpVals.Add(taue.OpinionScores(10))
            gaOpVals.Add(omicrad.OpinionScores(10))
            gaOpVals.Add(0.00)

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
                Dim dbl As Double = Math.Round(CDbl((Rnd() * ((-1) ^ Int(Rnd() * 10))) * 5), 2)
                gaOpVals.Add(dbl)
            Next
            For i = 0 To 1
                Dim dbl As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
                gaOpGrVals.Add(dbl)
            Next

            gamman.OpinionScores = gaOpVals
            gamman.OpinionGrowth = gaOpGrVals

            log.Info("Gamman created.")

            'Generate Iotanis
            Dim iotanis As New Nation() With {
                .Name = "Iotanis",
                .EconomyRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .EconomyGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .MilitaryRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .MilitaryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .SecurityRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .SecurityGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .JusticeRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .JusticeGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .ForeignRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .ForeignGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .HappinessRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .HappinessGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .Treasury = CDbl(Math.Floor((20 - 0 + 1) * Rnd())) + 0,
                .TreasuryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 10), 2),
                .Population = CDbl(Math.Floor((130 - 80 + 1) * Rnd())) + 80,
                .PopulationGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 3), 2)
            }

            Dim ioOpVals As New List(Of Double)
            Dim ioOpGrVals As New List(Of Double)
            ioOpVals.Add(repub.OpinionScores(11))
            ioOpVals.Add(alphon.OpinionScores(11))
            ioOpVals.Add(betae.OpinionScores(11))
            ioOpVals.Add(deltis.OpinionScores(11))
            ioOpVals.Add(omegor.OpinionScores(11))
            ioOpVals.Add(epsilus.OpinionScores(11))
            ioOpVals.Add(zetiy.OpinionScores(11))
            ioOpVals.Add(thetidon.OpinionScores(11))
            ioOpVals.Add(taue.OpinionScores(11))
            ioOpVals.Add(omicrad.OpinionScores(11))
            ioOpVals.Add(gamman.OpinionScores(11))
            ioOpVals.Add(0.00)

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

            Dim iodbl As Double = Math.Round(CDbl((Rnd() * ((-1) ^ Int(Rnd() * 10))) * 5), 2)
            ioOpVals.Add(iodbl)

            Dim iodbl2 As Double = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2)
            ioOpGrVals.Add(iodbl2)

            iotanis.OpinionScores = ioOpVals
            iotanis.OpinionGrowth = ioOpGrVals

            log.Info("Iotanis created.")

            'Generate Muphus
            Dim muphus As New Nation() With {
                .Name = "Muphus",
                .EconomyRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .EconomyGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .MilitaryRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .MilitaryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .SecurityRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .SecurityGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .JusticeRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .JusticeGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .ForeignRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .ForeignGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .HappinessRating = CDbl(Math.Floor((13 - 8 + 1) * Rnd())) + 8,
                .HappinessGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10))), 2),
                .Treasury = CDbl(Math.Floor((20 - 0 + 1) * Rnd())) + 0,
                .TreasuryGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 10), 2),
                .Population = CDbl(Math.Floor((130 - 80 + 1) * Rnd())) + 80,
                .PopulationGrowth = Math.Round(CDbl(Rnd() * ((-1) ^ Int(Rnd() * 10)) * 3), 2)
            }

            Dim muOpVals As New List(Of Double)
            Dim muOpGrVals As New List(Of Double)
            muOpVals.Add(repub.OpinionScores(12))
            muOpVals.Add(alphon.OpinionScores(12))
            muOpVals.Add(betae.OpinionScores(12))
            muOpVals.Add(deltis.OpinionScores(12))
            muOpVals.Add(omegor.OpinionScores(12))
            muOpVals.Add(epsilus.OpinionScores(12))
            muOpVals.Add(zetiy.OpinionScores(12))
            muOpVals.Add(thetidon.OpinionScores(12))
            muOpVals.Add(taue.OpinionScores(12))
            muOpVals.Add(omicrad.OpinionScores(12))
            muOpVals.Add(gamman.OpinionScores(12))
            muOpVals.Add(iotanis.OpinionScores(12))
            muOpVals.Add(0.00)

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

            muphus.OpinionScores = muOpVals
            muphus.OpinionGrowth = muOpGrVals

            log.Info("Muphus created.")

            'Add all nations to the game
            game.Nations = New Nation(12) {repub, alphon, betae, deltis, omegor, epsilus, zetiy, thetidon, taue, omicrad, gamman, iotanis, muphus}

            log.Info("Nations added to game.")

            'Write all information to the xml file
            game.Serialize(New IO.FileInfo(strPath))

            log.Info("Game written to file.")

            'clear text boxes for fresh start
            drpdwnNations.Items.Clear()
            drpdwnExistingLaws.Items.Clear()
            drpdwnMinisters.Items.Clear()
            drpdwnReports.Items.Clear()
            drpdwnEventCrises.Items.Clear()
            txtGameStatus.Clear()
            txtNations.Clear()
            txtLaws.Clear()
            txtMinisters.Clear()
            txtBudget.Clear()
            txtEvents.Clear()
            txtPeople.Clear()
            txtReports.Clear()
            txtWars.Clear()

            'populate dropdowns
            Try
                For Each Nation In game.Nations()
                    drpdwnNations.Items.Add(Nation.Name)
                Next
                For Each Law In game.Laws()
                    drpdwnExistingLaws.Items.Add(Law.Name)
                Next

                For Each Report In game.Reports()
                    drpdwnReports.Items.Add(Report.Name)
                Next

                For Each Minister In game.Ministers()
                    drpdwnMinisters.Items.Add(Minister.Name)
                Next

                For Each Crisis In game.Crises()
                    drpdwnEventCrises.Items.Add(Crisis.Name)
                Next
            Catch ex As Exception
                log.Error("Error populating dropdowns when initializing the game")
            End Try

            log.Info("UI reloaded.")

            BtnGenerateReports_Click(Me, EventArgs.Empty)

            log.Info("Generated initial reports.")

            'Confirm game creation
            MessageBox.Show("New Game created successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        'Initialize dialog
        Dim openDialog As New OpenFileDialog() With {
            .Filter = "XML-File | *.xml"
        }

        log.Info("Open button clicked.")

        'Load game from user-selected file
        If openDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            strPath = openDialog.FileName

            game = Game.Deserialize(New IO.FileInfo(strPath))

            Try
                ReloadUI()
            Catch ex As Exception
                log.Error("Error reloading ui when opening a file")
            End Try

            log.Info("Game opened from " & openDialog.FileName)
            MessageBox.Show("Game opened successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

        ReloadUI()

    End Sub

    Private Sub DrpdwnNations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpdwnNations.SelectedIndexChanged
        'Clear the nations text box
        txtNations.Clear()

        'Assign the selected nation from the drop-down menu
        Dim selectedNation = drpdwnNations.SelectedItem

        log.Info("Nations dropdown index changed to " & selectedNation)

        'fuck all if I know how this works, but it does. Prints a nation's info to the nations text box
        For Each Nation In game.Nations
            If Nation.Name = selectedNation Then

                For Each p As Reflection.PropertyInfo In Nation.GetType().GetProperties()
                    If p.CanRead And p.GetValue(Nation) IsNot Nothing Then
                        Try
                            txtNations.Text &= p.Name & " "
                            If p.PropertyType() Is GetType(List(Of Double)) Then

                                For Each k As Double In p.GetValue(Nation)
                                    txtNations.Text &= k & " "
                                Next
                                txtNations.Text &= vbNewLine

                            ElseIf p.PropertyType() Is GetType(List(Of String)) Then

                                For Each k As String In p.GetValue(Nation)
                                    txtNations.Text &= k & " "
                                Next

                                txtNations.Text &= vbNewLine
                            Else
                                txtNations.Text &= p.GetValue(Nation, Nothing).ToString() & vbNewLine
                            End If
                        Catch ex As Exception
                            log.Error("Error printing nation info")
                        End Try

                    End If
                Next

            End If

        Next

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        'Initialize dialog
        Dim saveDialog As New SaveFileDialog() With {
            .Filter = "XML-File | *.xml"
        }

        log.Info("Save button clicked.")

        'Save the game
        If saveDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            strPath = saveDialog.FileName

            game.Serialize(New IO.FileInfo(strPath))
            log.Info("Game saved to " & strPath)
        End If
    End Sub

    Private Sub DrpdwnExistingLaws_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpdwnExistingLaws.SelectedIndexChanged
        txtLaws.Clear()

        Dim selectedLaw = drpdwnExistingLaws.SelectedItem
        log.Info("Laws dropdown index changed to " & selectedLaw)

        'fuck all if I know how this works, but it does. Prints a law's info to the laws textbox
        For Each Law In game.Laws
            If Law.Name = selectedLaw Then
                For Each p As Reflection.PropertyInfo In Law.GetType().GetProperties()
                    If p.CanRead And p.GetValue(Law) IsNot Nothing Then
                        Try
                            txtLaws.Text &= p.Name & " "
                            If p.PropertyType Is GetType(List(Of Double)) Then
                                For Each k As Double In p.GetValue(Law)
                                    txtLaws.Text &= k & " "
                                Next
                                txtLaws.Text &= vbNewLine
                            ElseIf p.PropertyType Is GetType(List(Of Boolean)) Then
                                For Each k As Boolean In p.GetValue(Law)
                                    txtLaws.Text &= k & " "
                                Next
                                txtLaws.Text &= vbNewLine
                            Else
                                txtLaws.Text &= p.GetValue(Law) & vbNewLine
                            End If
                        Catch ex As Exception
                            log.Error("Error printing law info")
                        End Try
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub BtnNewLaw_Click(sender As Object, e As EventArgs) Handles btnNewLaw.Click
        'open the law designer
        Dim newLawForm As New LawDesigner()
        newLawForm.Show(Me)
    End Sub

    Public Sub ReloadUI()
        'clear dropdown menus
        drpdwnNations.Items.Clear()
        drpdwnExistingLaws.Items.Clear()
        drpdwnMinisters.Items.Clear()
        drpdwnReports.Items.Clear()
        drpdwnEventCrises.Items.Clear()
        drpdwnFactions.Items.Clear()
        drpdwnWars.Items.Clear()
        drpdwnActions.Items.Clear()
        drpdwnPrograms.Items.Clear()
        txtGameStatus.Clear()
        txtNations.Clear()
        txtLaws.Clear()
        txtMinisters.Clear()
        txtBudget.Clear()
        txtEvents.Clear()
        txtPeople.Clear()
        txtReports.Clear()
        txtWars.Clear()
        txtActions.Clear()
        txtPrograms.Clear()

        'update the dropdown menus
        Try
            For Each Nation In game.Nations()
                drpdwnNations.Items.Add(Nation.Name)
            Next
            For Each Law In game.Laws()
                drpdwnExistingLaws.Items.Add(Law.Name)
            Next

            For Each Report In game.Reports()
                drpdwnReports.Items.Add(Report.Name)
            Next

            For Each Minister In game.Ministers()
                drpdwnMinisters.Items.Add(Minister.Name)
            Next

            For Each Crisis In game.Crises()
                drpdwnEventCrises.Items.Add(Crisis.Name)
            Next

            For Each Faction In game.Factions()
                drpdwnFactions.Items.Add(Faction.Name)
            Next

            For Each War In game.Wars()
                drpdwnWars.Items.Add(War.Name)
            Next

            For Each Action In game.Actions()
                drpdwnActions.Items.Add(Action.Name)
            Next

            For Each Program In game.Programs()
                drpdwnPrograms.Items.Add(Program.Name)
            Next
        Catch ex As Exception
            log.Error("Error reloading ui")
        End Try

        'clear picture boxes
        Try
            pboxMinister.ImageLocation = ""
        Catch ex As Exception
            log.Error("Error reloading images")
        End Try
    End Sub

    Private Sub BtnEditLaw_Click(sender As Object, e As EventArgs) Handles btnEditLaw.Click
        'open the Law Designer form
        Dim newLawForm As New LawDesigner()
        newLawForm.Show(Me)

        'store the law that is selected
        Dim selectedLaw = drpdwnExistingLaws.SelectedItem

        'find the appropriate law in the game.Laws array
        For Each Law In game.Laws

            'populate the LawDesigner form with the attributes of the selected law
            If Law.Name = selectedLaw Then
                newLawForm.txtLawName.Text = Law.Name
                newLawForm.txtLawDescription.Text = Law.Description
                newLawForm.updwnDurationLaw.Value = Law.Duration
                newLawForm.updwnEconLaw.Value = Law.BudgetChanges(0)
                newLawForm.updwnMilLaw.Value = Law.BudgetChanges(1)
                newLawForm.updwnSecLaw.Value = Law.BudgetChanges(2)
                newLawForm.updwnJusLaw.Value = Law.BudgetChanges(3)
                newLawForm.updwnForLaw.Value = Law.BudgetChanges(4)
                newLawForm.updwnPeopLaw.Value = Law.BudgetChanges(5)
                newLawForm.updwnTreasLaw.Value = Law.BudgetChanges(6)
            End If

        Next

        'note if there are no laws in game.Laws, it will open the law designer and populate default values

    End Sub

    Private Sub BtnDeleteLaw_Click(sender As Object, e As EventArgs) Handles btnDeleteLaw.Click
        'determine selected law
        Dim selectedLaw = drpdwnExistingLaws.SelectedItem
        Dim selectedLawIndex = drpdwnExistingLaws.SelectedIndex

        'remove the selected law
        For Each Law In game.Laws
            If Law.Name = selectedLaw Then
                game.RemoveAt(game.Laws, selectedLawIndex)
            End If
        Next

        ReloadUI()
    End Sub

    Private Sub DrpdwnMinisters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpdwnMinisters.SelectedIndexChanged
        txtMinisters.Clear()

        Dim selectedMinister = drpdwnMinisters.SelectedItem
        Dim selectedMinIndex = drpdwnMinisters.SelectedIndex

        'Prints a minister's info to the minister textbox
        For Each Minister In game.Ministers
            If Minister.Name = selectedMinister Then
                For Each p As Reflection.PropertyInfo In Minister.GetType().GetProperties()
                    If p.CanRead And p.GetValue(Minister) IsNot Nothing Then
                        Try
                            txtMinisters.Text &= p.Name & " "
                            If p.PropertyType Is GetType(List(Of Double)) Then
                                For Each k As Double In p.GetValue(Minister)
                                    txtMinisters.Text &= k & " "
                                Next
                                txtMinisters.Text &= vbNewLine
                            ElseIf p.PropertyType Is GetType(List(Of Boolean)) Then
                                For Each k As Boolean In p.GetValue(Minister)
                                    txtMinisters.Text &= k & " "
                                Next
                                txtMinisters.Text &= vbNewLine
                            Else
                                txtMinisters.Text &= p.GetValue(Minister) & vbNewLine
                            End If
                        Catch ex As Exception
                            log.Error("Error printing minister info")
                        End Try
                    End If
                Next
            End If
        Next

        For Each Minister In game.Ministers
            If Minister.Name = selectedMinister Then
                pboxMinister.Image = Image.FromFile(Minister.ImageLoc)
            End If
        Next
    End Sub

    Private Sub BtnNewMinister_Click(sender As Object, e As EventArgs) Handles btnNewMinister.Click
        'open the minister designer
        Dim newMinisterForm As New MinisterDesigner()
        newMinisterForm.Show(Me)
    End Sub

    Private Sub BtnEditMinister_Click(sender As Object, e As EventArgs) Handles btnEditMinister.Click
        'open the Minister Designer form
        Dim newMinisterForm As New MinisterDesigner()
        newMinisterForm.Show(Me)

        'store the minister that is selected
        Dim selectedMinister = drpdwnMinisters.SelectedItem

        'find the appropriate minister in the game.Ministers array
        For Each Minister In game.Ministers

            'populate the MinisterDesigner form with the attributes of the selected law
            If Minister.Name = selectedMinister Then
                newMinisterForm.txtMinisterName.Text = Minister.Name
                newMinisterForm.txtMinisterGoals.Text = Minister.Goals
                newMinisterForm.txtMinisterDescr.Text = Minister.Description
                newMinisterForm.imgMinister.Image = Image.FromFile(Minister.ImageLoc)
            End If

        Next

        'note if there are no ministers in game.Ministers, it will open the minister designer and populate default values
    End Sub

    Private Sub BtnDeleteMinister_Click(sender As Object, e As EventArgs) Handles btnDeleteMinister.Click
        'determine selected minister
        Dim selectedMinister = drpdwnExistingLaws.SelectedItem
        Dim selectedMinisterIndex = drpdwnMinisters.SelectedIndex

        'remove the selected minister
        For Each Minister In game.Ministers
            If Minister.Name = selectedMinister Then
                game.RemoveAt(game.Ministers, selectedMinisterIndex)
            End If
        Next

        ReloadUI()
    End Sub

    Private Sub BtnEditBudget_Click(sender As Object, e As EventArgs) Handles btnEditBudget.Click
        'TODO: Program ability to manually change Republic's budget values

        'need to allow total control of budget numbers, including rate of change

        'open the law designer
        Dim newBudgetForm As New BudgetEditor()
        newBudgetForm.Show(Me)

        Dim repub = game.Nations(0)

        'populate budget form with existing budget
        newBudgetForm.updwnEcon.Value = repub.EconomyGrowth * 10
        newBudgetForm.updwnMil.Value = repub.MilitaryGrowth * 10
        newBudgetForm.updwnSec.Value = repub.SecurityGrowth * 10
        newBudgetForm.updwnJus.Value = repub.JusticeGrowth * 10
        newBudgetForm.updwnFor.Value = repub.ForeignGrowth * 10
        newBudgetForm.updwnPeo.Value = repub.HappinessGrowth * 10
        newBudgetForm.updwnTreas.Value = repub.TreasuryGrowth

        newBudgetForm.recalcTotal()
    End Sub

    Private Sub DrpdwnEventCrises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpdwnEventCrises.SelectedIndexChanged
        txtEvents.Clear()

        Dim selectedCrisis = drpdwnEventCrises.SelectedItem

        'Prints a crisis's info to the crisis textbox
        For Each Crisis In game.Crises
            If Crisis.Name = selectedCrisis Then
                For Each p As Reflection.PropertyInfo In Crisis.GetType().GetProperties()
                    If p.CanRead And p.GetValue(Crisis) IsNot Nothing Then
                        Try
                            txtEvents.Text &= p.Name & " "
                            If p.PropertyType Is GetType(List(Of Double)) Then
                                For Each k As Double In p.GetValue(Crisis)
                                    txtEvents.Text &= k & " "
                                Next
                                txtEvents.Text &= vbNewLine
                            ElseIf p.PropertyType Is GetType(List(Of Boolean)) Then
                                For Each k As Boolean In p.GetValue(Crisis)
                                    txtEvents.Text &= k & " "
                                Next
                                txtEvents.Text &= vbNewLine
                            Else
                                txtEvents.Text &= p.GetValue(Crisis) & vbNewLine
                            End If
                        Catch ex As Exception
                            log.Error("Error printing crisis/event info")
                        End Try
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub BtnEditEvent_Click(sender As Object, e As EventArgs) Handles btnEditEvent.Click
        'open the Event Designer form
        Dim newCrisisForm As New EventDesigner()
        newCrisisForm.Show(Me)

        'store the crisis that is selected
        Dim selectedCrisis = drpdwnEventCrises.SelectedItem

        'find the appropriate event in the game.Crises array
        For Each Crisis In game.Crises

            'populate the Crisis Designer form with the attributes of the selected event
            If Crisis.Name = selectedCrisis Then
                newCrisisForm.txtCrisisName.Text = Crisis.Name
                newCrisisForm.txtSession.Text = Crisis.Session
                If selectedCrisis.IsCrisis = True Then
                    newCrisisForm.chkIsCrisis.Checked = True
                End If
                newCrisisForm.txtCrisisDescr.Text = Crisis.Description
            End If

        Next
    End Sub

    Private Sub BtnDeleteEvent_Click(sender As Object, e As EventArgs) Handles btnDeleteEvent.Click
        'determine selected crisis
        Dim selectedCrisis = drpdwnEventCrises.SelectedItem
        Dim selectedCrisisIndex = drpdwnEventCrises.SelectedIndex

        'remove the selected crisis
        For Each Crisis In game.Crises
            If Crisis.Name = selectedCrisis Then
                game.RemoveAt(game.Crises, selectedCrisisIndex)
            End If
        Next

        ReloadUI()
    End Sub

    Private Sub BtnConductPoll_Click(sender As Object, e As EventArgs) Handles btnConductPoll.Click
        'TODO: Program ability to conduct poll... requires factions from The People
        'calculate likelihood of faction to vote favorably based on opinion of gov't?
        'base results on calculations?

        'allow user to set likelihood of each faction to vote favorably?
        'RepubCalc is primarily a GM tool, so might make sense for GM to determine likelihood

        'need to add faction generation for republic and dropdown to view factions and edit as necessary

        Dim msg = "Poll the people?"
        Dim title = "Poll"
        Dim style = MsgBoxStyle.YesNo
        Dim response = MsgBox(msg, style, title)

        If response = MsgBoxResult.Yes Then
            Dim myRandom As New Random()

            Dim answer = myRandom.Next(1, 100)

            Try
                For Each faction In game.Factions
                    answer += faction.Happiness
                Next
            Catch ex As Exception
                log.Warn("factions are empty, ignore this")
            End Try

            If answer < 51 Then
                MessageBox.Show("The poll has come back negative: the people don't like that idea!", "Negative Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("The poll has come back favorably: the people like that idea!", "Positive Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub

    Private Sub DrpdwnReports_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpdwnReports.SelectedIndexChanged
        txtReports.Clear()

        Dim selectedReport = drpdwnReports.SelectedItem

        'Prints a report's info to the report textbox
        For Each Report In game.Reports
            If Report.Name = selectedReport Then
                For Each p As Reflection.PropertyInfo In Report.GetType().GetProperties()
                    If p.CanRead And p.GetValue(Report) IsNot Nothing Then
                        Try
                            txtReports.Text &= p.Name & " "
                            If p.PropertyType Is GetType(List(Of Double)) Then
                                For Each k As Double In p.GetValue(Report)
                                    txtReports.Text &= k & " "
                                Next
                                txtReports.Text &= vbNewLine
                            ElseIf p.PropertyType Is GetType(List(Of Boolean)) Then
                                For Each k As Boolean In p.GetValue(Report)
                                    txtReports.Text &= k & " "
                                Next
                                txtReports.Text &= vbNewLine
                            Else
                                txtReports.Text &= p.GetValue(Report) & vbNewLine
                            End If
                        Catch ex As Exception
                            log.Error("Error printing report info")
                        End Try
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub BtnNewCustomReport_Click(sender As Object, e As EventArgs) Handles btnNewCustomReport.Click
        'open the report designer
        Dim newReportForm As New ReportDesigner()
        newReportForm.Show(Me)
    End Sub

    Private Sub BtnGenerateReports_Click(sender As Object, e As EventArgs) Handles btnGenerateReports.Click

        'preserve custom reports
        Dim customReports(-1) As Report

        For Each Report In game.Reports
            If Report.IsCustom = True Then
                Array.Resize(customReports, customReports.Length + 1)
                customReports(customReports.Length - 1) = Report
            End If
        Next

        Erase game.Reports

        game.Reports = customReports

        'generate economic report
        Dim econReport As New Report With {
            .Name = "Economic",
            .Session = game.GameStates(game.GameStates.Length - 1).CurrentSession,
            .Description = "A report of the Economic Ratings and Economic Growths of all nations." & vbNewLine,
            .IsCustom = False
        }

        For Each Nation In game.Nations
            econReport.Description &= Nation.Name & ": " & Nation.EconomyRating & ", " & Nation.EconomyGrowth & vbNewLine
        Next

        Array.Resize(game.Reports, game.Reports.Length + 1)
        game.Reports(game.Reports.Length - 1) = econReport

        'generate Military report
        Dim milReport As New Report With {
            .Name = "Military",
            .Session = game.GameStates(game.GameStates.Length - 1).CurrentSession,
            .Description = "A report of the Military Ratings and Military Growths of all nations." & vbNewLine,
            .IsCustom = False
        }

        For Each Nation In game.Nations
            milReport.Description &= Nation.Name & ": " & Nation.MilitaryRating & ", " & Nation.MilitaryGrowth & vbNewLine
        Next

        Array.Resize(game.Reports, game.Reports.Length + 1)
        game.Reports(game.Reports.Length - 1) = milReport

        'generate security report
        Dim secReport As New Report With {
            .Name = "Security",
            .Session = game.GameStates(game.GameStates.Length - 1).CurrentSession,
            .Description = "A report of the Security Ratings and Security Growths of all nations." & vbNewLine,
            .IsCustom = False
        }

        For Each Nation In game.Nations
            secReport.Description &= Nation.Name & ": " & Nation.SecurityRating & ", " & Nation.SecurityGrowth & vbNewLine
        Next

        Array.Resize(game.Reports, game.Reports.Length + 1)
        game.Reports(game.Reports.Length - 1) = secReport

        'generate justice report
        Dim jusReport As New Report With {
            .Name = "Justice",
            .Session = game.GameStates(game.GameStates.Length - 1).CurrentSession,
            .Description = "A report of the Justice Ratings and Justice Growths of all nations." & vbNewLine,
            .IsCustom = False
        }

        For Each Nation In game.Nations
            jusReport.Description &= Nation.Name & ": " & Nation.JusticeRating & ", " & Nation.JusticeGrowth & vbNewLine
        Next

        Array.Resize(game.Reports, game.Reports.Length + 1)
        game.Reports(game.Reports.Length - 1) = jusReport

        'generate foreign report
        Dim forReport As New Report With {
            .Name = "Foreign",
            .Session = game.GameStates(game.GameStates.Length - 1).CurrentSession,
            .Description = "A report of the Foreign Ratings and Foreign Growths of all nations." & vbNewLine,
            .IsCustom = False
        }

        For Each Nation In game.Nations
            forReport.Description &= Nation.Name & ": " & Nation.ForeignRating & ", " & Nation.ForeignGrowth & vbNewLine
        Next

        Array.Resize(game.Reports, game.Reports.Length + 1)
        game.Reports(game.Reports.Length - 1) = forReport

        'generate happiness report
        Dim hapReport As New Report With {
            .Name = "Happiness",
            .Session = game.GameStates(game.GameStates.Length - 1).CurrentSession,
            .Description = "A report of the population Happiness Rating and Happiness Growth of all nations." & vbNewLine,
            .IsCustom = False
        }

        For Each Nation In game.Nations
            hapReport.Description &= Nation.Name & ": " & Nation.HappinessRating & ", " & Nation.HappinessGrowth & vbNewLine
        Next

        Array.Resize(game.Reports, game.Reports.Length + 1)
        game.Reports(game.Reports.Length - 1) = hapReport

        'generate treasury report
        Dim treasReport As New Report With {
            .Name = "Treasury",
            .Session = game.GameStates(game.GameStates.Length - 1).CurrentSession,
            .Description = "A report of the Treasury and Treasury Growths of all nations." & vbNewLine,
            .IsCustom = False
        }

        For Each Nation In game.Nations
            treasReport.Description &= Nation.Name & ": " & Nation.Treasury & ", " & Nation.TreasuryGrowth & vbNewLine
        Next

        Array.Resize(game.Reports, game.Reports.Length + 1)
        game.Reports(game.Reports.Length - 1) = treasReport

        'generate population report
        Dim popReport As New Report With {
            .Name = "Population",
            .Session = game.GameStates(game.GameStates.Length - 1).CurrentSession,
            .Description = "A report of the Population and Population Growths of all nations." & vbNewLine,
            .IsCustom = False
        }

        For Each Nation In game.Nations
            popReport.Description &= Nation.Name & ": " & Nation.Population & ", " & Nation.PopulationGrowth & vbNewLine
        Next

        Array.Resize(game.Reports, game.Reports.Length + 1)
        game.Reports(game.Reports.Length - 1) = popReport

        'generate opinion report
        Dim opinReport As New Report With {
            .Name = "Opinions",
            .Session = game.GameStates(game.GameStates.Length - 1).CurrentSession,
            .Description = "A report of the opinions of other nations towards the initial nation." & vbNewLine & vbNewLine,
            .IsCustom = False
        }

        For Each nat In game.Nations
            opinReport.Description &= nat.Name & ": "
            Dim selectedNat = 0
            For Each number In nat.OpinionScores
                Select Case selectedNat
                    Case 0
                        If nat.Name IsNot "The Republic" Then
                            opinReport.Description &= "The Republic: " & number & ", " & nat.OpinionGrowth(selectedNat) & "; "
                        End If
                    Case 1
                        If nat.Name IsNot "Alphon" Then
                            opinReport.Description &= "Alphon: " & number & ", " & nat.OpinionGrowth(selectedNat) & "; "
                        End If
                    Case 2
                        If nat.Name IsNot "Betae" Then
                            opinReport.Description &= "Betae: " & number & ", " & nat.OpinionGrowth(selectedNat) & "; "
                        End If
                    Case 3
                        If nat.Name IsNot "Deltis" Then
                            opinReport.Description &= "Deltis: " & number & ", " & nat.OpinionGrowth(selectedNat) & "; "
                        End If
                    Case 4
                        If nat.Name IsNot "Omegor" Then
                            opinReport.Description &= "Omegor: " & number & ", " & nat.OpinionGrowth(selectedNat) & "; "
                        End If
                    Case 5
                        If nat.Name IsNot "Epsilus" Then
                            opinReport.Description &= "Epsilus: " & number & ", " & nat.OpinionGrowth(selectedNat) & "; "
                        End If
                    Case 6
                        If nat.Name IsNot "Zetiy" Then
                            opinReport.Description &= "Zetiy: " & number & ", " & nat.OpinionGrowth(selectedNat) & "; "
                        End If
                    Case 7
                        If nat.Name IsNot "Thetidon" Then
                            opinReport.Description &= "Thetidon: " & number & ", " & nat.OpinionGrowth(selectedNat) & "; "
                        End If
                    Case 8
                        If nat.Name IsNot "Taue" Then
                            opinReport.Description &= "Taue: " & number & ", " & nat.OpinionGrowth(selectedNat) & "; "
                        End If
                    Case 9
                        If nat.Name IsNot "Omicrad" Then
                            opinReport.Description &= "Omicrad: " & number & ", " & nat.OpinionGrowth(selectedNat) & "; "
                        End If
                    Case 10
                        If nat.Name IsNot "Gamman" Then
                            opinReport.Description &= "Gamman: " & number & ", " & nat.OpinionGrowth(selectedNat) & "; "
                        End If
                    Case 11
                        If nat.Name IsNot "Iotanis" Then
                            opinReport.Description &= "Iotanis: " & number & ", " & nat.OpinionGrowth(selectedNat) & "; "
                        End If
                    Case 12
                        If nat.Name IsNot "Muphus" Then
                            opinReport.Description &= "Muphus: " & number & ", " & nat.OpinionGrowth(selectedNat) & "; "
                        End If
                End Select
                selectedNat += 1
            Next

            opinReport.Description &= vbNewLine & vbNewLine
        Next

        Array.Resize(game.Reports, game.Reports.Length + 1)
        game.Reports(game.Reports.Length - 1) = opinReport

        'generate allies report
        Dim allReport As New Report With {
            .Name = "Allies",
            .Session = game.GameStates(game.GameStates.Length - 1).CurrentSession,
            .Description = "A report of each nation's allies." & vbNewLine,
            .IsCustom = False
        }

        For Each Nation In game.Nations
            allReport.Description &= Nation.Name & ": "

            Try
                For Each ally In Nation.Allies
                    allReport.Description &= ally & ", "
                Next
            Catch ex As Exception
                allReport.Description &= "None."
                log.Warn("Allies list empty, ignore this")
            End Try
            allReport.Description &= vbNewLine
        Next

        Array.Resize(game.Reports, game.Reports.Length + 1)
        game.Reports(game.Reports.Length - 1) = allReport

        'generate enemies report
        Dim enemReport As New Report With {
            .Name = "Enemies",
            .Session = game.GameStates(game.GameStates.Length - 1).CurrentSession,
            .Description = "A report of each nation's enemies." & vbNewLine,
            .IsCustom = False
        }

        For Each Nation In game.Nations
            enemReport.Description &= Nation.Name & ": "

            Try
                For Each enem In Nation.Enemies
                    enemReport.Description &= enem & ", "
                Next
            Catch ex As Exception
                enemReport.Description &= "None."
                log.Warn("Enemies list empty, ignore this")
            End Try

            enemReport.Description &= vbNewLine
        Next

        Array.Resize(game.Reports, game.Reports.Length + 1)
        game.Reports(game.Reports.Length - 1) = enemReport

        'generate wars report
        Dim warsReport As New Report With {
            .Name = "Wars",
            .Session = game.GameStates(game.GameStates.Length - 1).CurrentSession,
            .Description = "A report of each nation's wars." & vbNewLine,
            .IsCustom = False
        }


        Try
            For Each war In game.Wars
                warsReport.Description &= war.Name & ", "
            Next
        Catch ex As Exception
            warsReport.Description &= "None."
            log.Warn("Wars list empty, ignore this")
        End Try

        Array.Resize(game.Reports, game.Reports.Length + 1)
        game.Reports(game.Reports.Length - 1) = warsReport

        'generate spending report
        Dim spendReport As New Report With {
            .Name = "Spending",
            .Session = game.GameStates(game.GameStates.Length - 1).CurrentSession,
            .Description = "A report of the total Spending of all nations." & vbNewLine,
            .IsCustom = False
        }

        For Each Nation In game.Nations
            Dim totSpend = Nation.EconomyGrowth + Nation.ForeignGrowth + Nation.HappinessGrowth + Nation.JusticeGrowth + Nation.MilitaryGrowth + Nation.SecurityGrowth + Nation.TreasuryGrowth
            spendReport.Description &= Nation.Name & ": " & totSpend & vbNewLine
        Next

        Array.Resize(game.Reports, game.Reports.Length + 1)
        game.Reports(game.Reports.Length - 1) = spendReport

        ReloadUI()
    End Sub

    Private Sub BtnEditReport_Click(sender As Object, e As EventArgs) Handles btnEditReport.Click
        'open the Report Designer form
        Dim newReportForm As New ReportDesigner()
        newReportForm.Show(Me)

        'store the report that is selected
        Dim selectedReport = drpdwnReports.SelectedItem

        'find the appropriate report in the game.Crises Reports
        For Each Report In game.Reports
            'populate the reports Designer form with the attributes of the selected event
            If Report.Name = selectedReport Then
                newReportForm.txtReportName.Text = Report.Name
                newReportForm.updwnSession.Text = Report.Session
                newReportForm.txtReportDescr.Text = Report.Description

                If Report.IsCustom = True Then
                    newReportForm.chkIsCustom.Checked = True
                End If
            End If

        Next
    End Sub

    Private Sub BtnDeleteReport_Click(sender As Object, e As EventArgs) Handles btnDeleteReport.Click
        'determine selected report
        Dim selectedReport = drpdwnReports.SelectedItem
        Dim selectedReportIndex = drpdwnReports.SelectedIndex

        'remove the selected report
        For Each Report In game.Reports
            If Report.Name = selectedReport Then
                game.RemoveAt(game.Reports, selectedReportIndex)
            End If
        Next

        ReloadUI()
    End Sub

    Private Sub BtnNewEvent_Click(sender As Object, e As EventArgs) Handles btnNewEvent.Click
        'open the event designer
        Dim newEventForm As New EventDesigner()
        newEventForm.Show(Me)
    End Sub

    Private Sub BtnTextOnly_Click(sender As Object, e As EventArgs) Handles btnTextOnly.Click
        txtGameStatus.Clear()
        Dim repub = game.Nations(0)

        txtGameStatus.Text &= "State of the Republic" & vbNewLine
        txtGameStatus.Text &= "As of Session: " & game.GameStates(game.GameStates.Length - 1).CurrentSession & vbNewLine & vbNewLine

        txtGameStatus.Text &= "Population: " & repub.Population & " (" & repub.PopulationGrowth & ")" & vbNewLine & vbNewLine

        txtGameStatus.Text &= "Economy Rating: " & repub.EconomyRating & " (" & repub.EconomyGrowth & ")" & vbNewLine
        txtGameStatus.Text &= "Military Rating: " & repub.MilitaryRating & " (" & repub.MilitaryGrowth & ")" & vbNewLine
        txtGameStatus.Text &= "Security Rating: " & repub.SecurityRating & " (" & repub.SecurityGrowth & ")" & vbNewLine
        txtGameStatus.Text &= "Justice Rating: " & repub.JusticeRating & " (" & repub.JusticeGrowth & ")" & vbNewLine
        txtGameStatus.Text &= "Foreign Affairs Rating: " & repub.ForeignRating & " (" & repub.ForeignGrowth & ")" & vbNewLine
        txtGameStatus.Text &= "People Happiness Rating: " & repub.HappinessRating & " (" & repub.HappinessGrowth & ")" & vbNewLine
        txtGameStatus.Text &= "Treasury Savings: " & repub.Treasury & " (" & repub.TreasuryGrowth & ")" & vbNewLine & vbNewLine

        txtGameStatus.Text &= "Budget: " & vbNewLine & vbNewLine 'budget stuff 

        txtGameStatus.Text &= "Other Nations: "

        For i = 1 To 12
            Dim nation = game.Nations(i)
            txtGameStatus.Text &= nation.Name & ", "
        Next

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "Neutral: "

        For i = 1 To 12
            Dim opinion = repub.OpinionScores(i)
            If opinion < 5 And opinion > -5 Then
                txtGameStatus.Text &= game.Nations(i).Name & " (" & opinion & ", " & repub.OpinionGrowth(i) & "), "
            End If
        Next

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "Friendly: "

        For i = 1 To 12
            Dim opinion = repub.OpinionScores(i)
            If opinion >= 5 Then
                txtGameStatus.Text &= game.Nations(i).Name & " (" & opinion & ", " & repub.OpinionGrowth(i) & "), "
            End If
        Next

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "Unfriendly: "

        For i = 1 To 12
            Dim opinion = repub.OpinionScores(i)
            If opinion <= -5 Then
                txtGameStatus.Text &= game.Nations(i).Name & " (" & opinion & ", " & repub.OpinionGrowth(i) & "), "
            End If
        Next

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "Allies: "

        Try
            For Each ally In repub.Allies
                txtGameStatus.Text &= ally & ", "
            Next
        Catch ex As Exception
            txtGameStatus.Text &= "None"
            log.Warn("Allies list empty, ignore this.")
        End Try

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "Enemies: "

        Try
            For Each enemy In repub.Enemies
                txtGameStatus.Text &= enemy & ", "
            Next
        Catch ex As Exception
            txtGameStatus.Text &= "None"
            log.Warn("Enemies list empty, ignore this.")
        End Try

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "Wars: "

        Try
            For Each war In game.Wars
                txtGameStatus.Text &= war.Name & ", "
            Next
        Catch ex As Exception
            txtGameStatus.Text &= "None"
            log.Warn("Wars list empty, ignore this.")
        End Try

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "Current Laws: "

        Try
            For Each law In game.Laws
                txtGameStatus.Text &= law.Name & ", "
            Next
        Catch ex As Exception
            txtGameStatus.Text &= "None"
            log.Warn("Laws list empty, ignore this.")
        End Try

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "Current Programs: "

        Try
            For Each program In game.Programs
                If program.IsExpired = False Then
                    txtGameStatus.Text &= program.Name & ", "
                End If
            Next
        Catch ex As Exception
            txtGameStatus.Text &= "None"
            log.Warn("Programs list empty, ignore this.")
        End Try

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "Minister Actions: "

        Try
            For Each action In game.Actions
                If action.IsExpired = False Then
                    txtGameStatus.Text &= action.Name & ", "
                End If
            Next
        Catch ex As Exception
            txtGameStatus.Text &= "None"
            log.Warn("Actions list empty, ignore this.")
        End Try

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "Expired Minister Actions: "

        Try
            For Each action In game.Actions
                If action.IsExpired = True Then
                    txtGameStatus.Text &= action.Name & ", "
                End If
            Next
        Catch ex As Exception
            txtGameStatus.Text &= "None"
            log.Warn("Actions list empty, ignore this.")
        End Try

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "View the reports tab to see reports."
    End Sub

    Private Sub BtnBBCodeFormat_Click(sender As Object, e As EventArgs) Handles btnBBCodeFormat.Click
        'TODO: Format output with BBCode prettification
        txtGameStatus.Clear()
        Dim repub = game.Nations(0)

        txtGameStatus.Text &= "[B][CENTER][SIZE=" & 5 & "]State of the Republic[/SIZE][/CENTER][/B]" & vbNewLine
        txtGameStatus.Text &= "[B]As of Session: [/B]" & game.GameStates(game.GameStates.Length - 1).CurrentSession & vbNewLine & vbNewLine

        txtGameStatus.Text &= "[B]Population: [/B]" & repub.Population & " (" & repub.PopulationGrowth & ")" & vbNewLine & vbNewLine

        txtGameStatus.Text &= "[B]Economy Rating: [/B]" & repub.EconomyRating & " (" & repub.EconomyGrowth & ")" & vbNewLine
        txtGameStatus.Text &= "[B]Military Rating: [/B]" & repub.MilitaryRating & " (" & repub.MilitaryGrowth & ")" & vbNewLine
        txtGameStatus.Text &= "[B]Security Rating: [/B]" & repub.SecurityRating & " (" & repub.SecurityGrowth & ")" & vbNewLine
        txtGameStatus.Text &= "[B]Justice Rating: [/B]" & repub.JusticeRating & " (" & repub.JusticeGrowth & ")" & vbNewLine
        txtGameStatus.Text &= "[B]Foreign Affairs Rating: [/B]" & repub.ForeignRating & " (" & repub.ForeignGrowth & ")" & vbNewLine
        txtGameStatus.Text &= "[B]People Happiness Rating: [/B]" & repub.HappinessRating & " (" & repub.HappinessGrowth & ")" & vbNewLine
        txtGameStatus.Text &= "[B]Treasury Savings: [/B]" & repub.Treasury & " (" & repub.TreasuryGrowth & ")" & vbNewLine & vbNewLine

        txtGameStatus.Text &= "[B]Budget: [/B]" & vbNewLine & vbNewLine 'budget stuff 

        txtGameStatus.Text &= "[B]Other Nations: [/B]"

        For i = 1 To 12
            Dim nation = game.Nations(i)
            txtGameStatus.Text &= nation.Name & ", "
        Next

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "[B]Neutral: [/B]"

        For i = 1 To 12
            Dim opinion = repub.OpinionScores(i)
            If opinion < 5 And opinion > -5 Then
                txtGameStatus.Text &= game.Nations(i).Name & " (" & opinion & ", " & repub.OpinionGrowth(i) & "), "
            End If
        Next

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "[B]Friendly: [/B]"

        For i = 1 To 12
            Dim opinion = repub.OpinionScores(i)
            If opinion >= 5 Then
                txtGameStatus.Text &= game.Nations(i).Name & " (" & opinion & ", " & repub.OpinionGrowth(i) & "), "
            End If
        Next

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "[B]Unfriendly: [/B]"

        For i = 1 To 12
            Dim opinion = repub.OpinionScores(i)
            If opinion <= -5 Then
                txtGameStatus.Text &= game.Nations(i).Name & " (" & opinion & ", " & repub.OpinionGrowth(i) & "), "
            End If
        Next

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "[B]Allies: [/B]"

        Try
            For Each ally In repub.Allies
                txtGameStatus.Text &= ally & ", "
            Next
        Catch ex As Exception
            txtGameStatus.Text &= "None"
            log.Warn("Allies list empty, ignore this.")
        End Try

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "[B]Enemies: [/B]"

        Try
            For Each enemy In repub.Enemies
                txtGameStatus.Text &= enemy & ", "
            Next
        Catch ex As Exception
            txtGameStatus.Text &= "None"
            log.Warn("Enemies list empty, ignore this.")
        End Try

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "[B]Wars: [/B]"

        Try
            For Each war In game.Wars
                txtGameStatus.Text &= war.Name & ", "
            Next
        Catch ex As Exception
            txtGameStatus.Text &= "None"
            log.Warn("Wars list empty, ignore this.")
        End Try

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "[B]Current Laws: [/B]"

        Try
            For Each law In game.Laws
                txtGameStatus.Text &= law.Name & ", "
            Next
        Catch ex As Exception
            txtGameStatus.Text &= "None"
            log.Warn("Laws list empty, ignore this.")
        End Try

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "[B]Current Programs: [/B]"

        Try
            For Each program In game.Programs
                If program.IsExpired = False Then
                    txtGameStatus.Text &= program.Name & ", "
                End If
            Next
        Catch ex As Exception
            txtGameStatus.Text &= "None"
            log.Warn("Programs list empty, ignore this.")
        End Try

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "[B]Minister Actions: [/B]"

        Try
            For Each action In game.Actions
                If action.IsExpired = False Then
                    txtGameStatus.Text &= action.Name & ", "
                End If
            Next
        Catch ex As Exception
            txtGameStatus.Text &= "None"
            log.Warn("Actions list empty, ignore this.")
        End Try

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "[B]Expired Minister Actions: [/B]"

        Try
            For Each action In game.Actions
                If action.IsExpired = True Then
                    txtGameStatus.Text &= action.Name & ", "
                End If
            Next
        Catch ex As Exception
            txtGameStatus.Text &= "None"
            log.Warn("Actions list empty, ignore this.")
        End Try

        txtGameStatus.Text &= vbNewLine & vbNewLine

        txtGameStatus.Text &= "View the reports tab to see reports."
    End Sub

    Private Sub BtnNextPhase_Click(sender As Object, e As EventArgs) Handles btnNextPhase.Click
        game.GameStates(game.GameStates.Length - 1).IncrementPhase()
    End Sub

    Private Sub BtnShowBudget_Click(sender As Object, e As EventArgs) Handles btnShowBudget.Click
        txtBudget.Clear()

        Dim repub = game.Nations(0)
        txtBudget.Text &= "The Republic's Budget:" & vbNewLine
        txtBudget.Text &= "Economy: " & repub.EconomyGrowth * 10 & vbNewLine
        txtBudget.Text &= "Military: " & repub.MilitaryGrowth * 10 & vbNewLine
        txtBudget.Text &= "Security: " & repub.SecurityGrowth * 10 & vbNewLine
        txtBudget.Text &= "Justice: " & repub.JusticeGrowth * 10 & vbNewLine
        txtBudget.Text &= "Foreign: " & repub.ForeignGrowth * 10 & vbNewLine
        txtBudget.Text &= "The People: " & repub.HappinessGrowth * 10 & vbNewLine
        txtBudget.Text &= "Treasury: " & repub.TreasuryGrowth & vbNewLine
        txtBudget.Text &= "Total Spending: " & repub.TreasuryGrowth + ((repub.EconomyGrowth + repub.MilitaryGrowth + repub.SecurityGrowth + repub.JusticeGrowth + repub.ForeignGrowth + repub.HappinessGrowth) * 10) & vbNewLine
    End Sub

    Private Sub DrpdwnFactions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpdwnFactions.SelectedIndexChanged
        txtPeople.Clear()

        Dim selectedFaction = drpdwnFactions.SelectedItem

        'Prints a faction's info to the crisis textbox
        For Each Faction In game.Factions
            If Faction.Name = selectedFaction Then
                For Each p As Reflection.PropertyInfo In Faction.GetType().GetProperties()
                    If p.CanRead And p.GetValue(Faction) IsNot Nothing Then
                        Try
                            txtPeople.Text &= p.Name & " "
                            If p.PropertyType Is GetType(List(Of Double)) Then
                                For Each k As Double In p.GetValue(Faction)
                                    txtPeople.Text &= k & " "
                                Next
                                txtEvents.Text &= vbNewLine
                            ElseIf p.PropertyType Is GetType(List(Of Boolean)) Then
                                For Each k As Boolean In p.GetValue(Faction)
                                    txtPeople.Text &= k & " "
                                Next
                                txtPeople.Text &= vbNewLine
                            Else
                                txtPeople.Text &= p.GetValue(Faction) & vbNewLine
                            End If
                        Catch ex As Exception
                            log.Error("Error printing faction info")
                        End Try
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub BtnCreateFaction_Click(sender As Object, e As EventArgs) Handles btnCreateFaction.Click
        'show faction designer
        Dim newFactionForm As New FactionDesigner()
        newFactionForm.Show(Me)
    End Sub

    Private Sub BtnEditFaction_Click(sender As Object, e As EventArgs) Handles btnEditFaction.Click
        'open the Report Designer form
        Dim newFactionForm As New FactionDesigner()
        newFactionForm.Show(Me)

        'store the report that is selected
        Dim selectedFaction = drpdwnFactions.SelectedItem

        'find the appropriate report in the game.Crises Reports
        For Each Faction In game.Factions
            'populate the reports Designer form with the attributes of the selected event
            If Faction.Name = selectedFaction Then
                newFactionForm.txtFactionName.Text = Faction.Name
                newFactionForm.updwnPercent.Value = Faction.Percent * 10
                newFactionForm.txtFactionDescr.Text = Faction.Description
                newFactionForm.updwnHap.Value = Faction.Happiness
            End If
        Next
    End Sub

    Private Sub BtnDeleteFaction_Click(sender As Object, e As EventArgs) Handles btnDeleteFaction.Click
        'determine selected minister
        Dim selectedFaction = drpdwnFactions.SelectedItem
        Dim selectedFactionIndex = drpdwnFactions.SelectedIndex

        'remove the selected minister
        For Each Faction In game.Factions
            If Faction.Name = selectedFaction Then
                game.RemoveAt(game.Factions, selectedFactionIndex)
            End If
        Next

        ReloadUI()
    End Sub

    Private Sub DrpdwnWars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpdwnWars.SelectedIndexChanged
        txtWars.Clear()

        Dim selectedWar = drpdwnWars.SelectedItem

        'Prints a faction's info to the crisis textbox
        For Each War In game.Wars
            If War.Name = selectedWar Then
                For Each p As Reflection.PropertyInfo In War.GetType().GetProperties()
                    If p.CanRead And p.GetValue(War) IsNot Nothing Then
                        Try
                            txtWars.Text &= p.Name & " "
                            If p.PropertyType Is GetType(List(Of Double)) Then
                                For Each k As Double In p.GetValue(War)
                                    txtWars.Text &= k & " "
                                Next
                                txtWars.Text &= vbNewLine
                            ElseIf p.PropertyType Is GetType(List(Of Boolean)) Then
                                For Each k As Boolean In p.GetValue(War)
                                    txtWars.Text &= k & " "
                                Next
                                txtWars.Text &= vbNewLine
                            Else
                                txtWars.Text &= p.GetValue(War) & vbNewLine
                            End If
                        Catch ex As Exception
                            log.Error("Error printing war info")
                        End Try
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub BtnDeclareWar_Click(sender As Object, e As EventArgs) Handles btnDeclareWar.Click
        'open the war designer
        Dim newWarForm As New WarDesigner()
        newWarForm.Show(Me)

        For Each Nation In game.Nations()
            newWarForm.drpdwnAgg.Items.Add(Nation.Name)
        Next

        For Each Nation In game.Nations()
            newWarForm.drpdwnDef.Items.Add(Nation.Name)
        Next
    End Sub

    Private Sub BtnEditWar_Click(sender As Object, e As EventArgs) Handles btnEditWar.Click
        'open the Report Designer form
        Dim newWarForm As New WarDesigner()
        newWarForm.Show(Me)

        For Each Nation In game.Nations()
            newWarForm.drpdwnAgg.Items.Add(Nation.Name)
        Next

        For Each Nation In game.Nations()
            newWarForm.drpdwnDef.Items.Add(Nation.Name)
        Next

        'store the report that is selected
        Dim selectedWar = drpdwnWars.SelectedItem

        'find the appropriate report in the game.Crises Reports
        For Each War In game.Wars
            'populate the reports Designer form with the attributes of the selected event
            If War.Name = selectedWar Then
                newWarForm.txtWarName.Text = War.Name
                newWarForm.txtWarDescr.Text = War.Description
                newWarForm.chkAggAll.Checked = War.AggressorAllies
                newWarForm.chkDefAllies.Checked = War.DefenderAllies
                newWarForm.lblAggTot.Text = War.AggressorTotalScore
                newWarForm.lblDefTot.Text = War.DefenderTotalScore
                newWarForm.updwnAggWins.Value = War.AggressorWinCount
                newWarForm.updwnDefWins.Value = War.DefenderWinCount

                For Each item In newWarForm.drpdwnAgg.Items
                    If item = War.Aggressor Then
                        newWarForm.drpdwnAgg.SelectedItem = item
                        Exit For
                    End If
                Next

                For Each item In newWarForm.drpdwnDef.Items
                    If item = War.Defender Then
                        newWarForm.drpdwnDef.SelectedItem = item
                        Exit For
                    End If
                Next

            End If
        Next
    End Sub

    Private Sub BtnCalcWarProgress_Click(sender As Object, e As EventArgs) Handles btnCalcWarProgress.Click
        Dim selectedWar = drpdwnWars.SelectedItem

        For Each war In game.Wars
            If war.Name = selectedWar Then

                Dim msg = "Progress this war?: " & war.Name & " This cannot be undone and should only be done once per war per session."
                Dim title = "Progress War"
                Dim style = MsgBoxStyle.YesNo
                Dim response = MsgBox(msg, style, title)

                If response = MsgBoxResult.Yes Then
                    Dim warWinner = war.AggressorTotalScore - war.DefenderTotalScore
                    If warWinner > 1 Then
                        war.AggressorWinCount += 1
                        MessageBox.Show("War progressed! " & war.Aggressor & " gained 1 win.", "Aggressor wins!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ElseIf warWinner < -1 Then
                        war.DefenderWinCount += 1
                        MessageBox.Show("War progressed! " & war.Defender & " gained 1 win.", "Defender wins!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        MessageBox.Show("War progressed! It's a tie, so no one ganed a win.", "It's a tie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                    Exit For
                End If
            End If
        Next
    End Sub

    Private Sub BtnShowEnAl_Click(sender As Object, e As EventArgs) Handles btnShowEnAl.Click
        Dim selectedWar = drpdwnWars.SelectedItem
        txtWars.Clear()

        For Each war In game.Wars
            If war.Name = selectedWar Then
                txtWars.Text &= "Aggressor: " & war.Aggressor & vbNewLine
                txtWars.Text &= "Aggressor Allies: "

                For Each nation In game.Nations
                    If nation.Name = war.Aggressor Then
                        Try
                            For Each ally In nation.Allies
                                txtWars.Text &= ally & ", "
                            Next
                        Catch ex As Exception
                            txtWars.Text &= "None."
                            log.Warn("Aggressor Allies list is empty.")
                            Exit For
                        End Try
                        Exit For
                    End If
                Next

                txtWars.Text &= vbNewLine

                txtWars.Text &= "Defender: " & war.Defender & vbNewLine
                txtWars.Text &= "Defender Allies: "
                For Each nation In game.Nations
                    If nation.Name = war.Defender Then
                        Try
                            For Each ally In nation.Allies
                                txtWars.Text &= ally & ", "
                            Next
                        Catch ex As Exception
                            txtWars.Text &= "None."
                            log.Warn("Defender Allies list is empty.")
                            Exit For
                        End Try
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub BtnEndWar_Click(sender As Object, e As EventArgs) Handles btnEndWar.Click
        'determine selected War
        Dim selectedWar = drpdwnWars.SelectedItem
        Dim selectedWarIndex = drpdwnWars.SelectedIndex

        'remove the selected War
        For Each War In game.Wars
            If War.Name = selectedWar Then
                game.RemoveAt(game.Wars, selectedWarIndex)
            End If
        Next

        ReloadUI()
    End Sub

    Private Sub DrpdwnActions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpdwnActions.SelectedIndexChanged
        txtActions.Clear()

        Dim selectedAction = drpdwnActions.SelectedItem

        'Prints a faction's info to the crisis textbox
        For Each Action In game.Actions
            If Action.Name = selectedAction Then
                For Each p As Reflection.PropertyInfo In Action.GetType().GetProperties()
                    If p.CanRead And p.GetValue(Action) IsNot Nothing Then
                        Try
                            txtActions.Text &= p.Name & " "
                            If p.PropertyType Is GetType(List(Of Double)) Then
                                For Each k As Double In p.GetValue(Action)
                                    txtActions.Text &= k & " "
                                Next
                                txtActions.Text &= vbNewLine
                            ElseIf p.PropertyType Is GetType(List(Of Boolean)) Then
                                For Each k As Boolean In p.GetValue(Action)
                                    txtActions.Text &= k & " "
                                Next
                                txtActions.Text &= vbNewLine
                            Else
                                txtActions.Text &= p.GetValue(Action) & vbNewLine
                            End If
                        Catch ex As Exception
                            log.Error("Error printing action info")
                        End Try
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub BtnNewAction_Click(sender As Object, e As EventArgs) Handles btnNewAction.Click
        Dim newActionForm As New ActionDesigner
        newActionForm.Show(Me)
    End Sub

    Private Sub BtnEditAction_Click(sender As Object, e As EventArgs) Handles btnEditAction.Click
        'open the Action Designer form
        Dim newActionForm As New ActionDesigner()
        newActionForm.Show(Me)

        'store the report that is selected
        Dim selectedAction = drpdwnActions.SelectedItem

        'find the appropriate report in the game.Crises Reports
        For Each Action In game.Actions
            'populate the reports Designer form with the attributes of the selected event
            If Action.Name = selectedAction Then
                newActionForm.txtActionName.Text = Action.Name
                newActionForm.txtDescription.Text = Action.Description

                If Action.IsExpired = True Then
                    newActionForm.chkExpired.Checked = True
                Else
                    newActionForm.chkExpired.Checked = False
                End If
            End If
        Next
    End Sub

    Private Sub BtnDeleteAction_Click(sender As Object, e As EventArgs) Handles btnDeleteAction.Click
        'determine selected action
        Dim selectedAction = drpdwnActions.SelectedItem
        Dim selectedActionIndex = drpdwnActions.SelectedIndex

        'remove the selected action
        For Each Action In game.Actions
            If Action.Name = selectedAction Then
                game.RemoveAt(game.Actions, selectedActionIndex)
            End If
        Next

        ReloadUI()
    End Sub

    Private Sub DrpdwnPrograms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpdwnPrograms.SelectedIndexChanged
        txtPrograms.Clear()

        Dim selectedProgram = drpdwnPrograms.SelectedItem

        'Prints a faction's info to the crisis textbox
        For Each Program In game.Programs
            If Program.Name = selectedProgram Then
                For Each p As Reflection.PropertyInfo In Program.GetType().GetProperties()
                    If p.CanRead And p.GetValue(Program) IsNot Nothing Then
                        Try
                            txtPrograms.Text &= p.Name & " "
                            If p.PropertyType Is GetType(List(Of Double)) Then
                                For Each k As Double In p.GetValue(Program)
                                    txtPrograms.Text &= k & " "
                                Next
                                txtPrograms.Text &= vbNewLine
                            ElseIf p.PropertyType Is GetType(List(Of Boolean)) Then
                                For Each k As Boolean In p.GetValue(Program)
                                    txtPrograms.Text &= k & " "
                                Next
                                txtPrograms.Text &= vbNewLine
                            Else
                                txtPrograms.Text &= p.GetValue(Program) & vbNewLine
                            End If
                        Catch ex As Exception
                            log.Error("Error printing programs info")
                        End Try
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub BtnNewProgram_Click(sender As Object, e As EventArgs) Handles btnNewProgram.Click
        Dim newProgramForm As New ProgramDesigner
        newProgramForm.Show(Me)
    End Sub

    Private Sub BtnEditProgram_Click(sender As Object, e As EventArgs) Handles btnEditProgram.Click
        'open the Program Designer form
        Dim newProgramForm As New ProgramDesigner()
        newProgramForm.Show(Me)

        'store the report that is selected
        Dim selectedProgram = drpdwnPrograms.SelectedItem

        'find the appropriate report in the game.Crises Reports
        For Each Program In game.Programs
            'populate the reports Designer form with the attributes of the selected event
            If Program.Name = selectedProgram Then
                newProgramForm.txtProgramName.Text = Program.Name
                newProgramForm.txtDescription.Text = Program.Description

                If Program.IsExpired = True Then
                    newProgramForm.chkExpired.Checked = True
                Else
                    newProgramForm.chkExpired.Checked = False
                End If
            End If
        Next
    End Sub

    Private Sub BtnDeleteProgram_Click(sender As Object, e As EventArgs) Handles btnDeleteProgram.Click
        'determine selected program
        Dim selectedProgram = drpdwnPrograms.SelectedItem
        Dim selectedProgramIndex = drpdwnPrograms.SelectedIndex

        'remove the selected program
        For Each Program In game.Programs
            If Program.Name = selectedProgram Then
                game.RemoveAt(game.Programs, selectedProgramIndex)
            End If
        Next

        ReloadUI()
    End Sub
End Class
