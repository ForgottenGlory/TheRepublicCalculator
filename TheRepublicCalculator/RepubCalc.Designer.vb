<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepubCalc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepubCalc))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNextPhase = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tabWarsEnemiesAllies = New System.Windows.Forms.TabPage()
        Me.btnEditWar = New System.Windows.Forms.Button()
        Me.txtWars = New System.Windows.Forms.TextBox()
        Me.btnCalcWarProgress = New System.Windows.Forms.Button()
        Me.btnShowEnAl = New System.Windows.Forms.Button()
        Me.drpdwnWars = New System.Windows.Forms.ComboBox()
        Me.lblWars = New System.Windows.Forms.Label()
        Me.btnEndWar = New System.Windows.Forms.Button()
        Me.btnDeclareWar = New System.Windows.Forms.Button()
        Me.tabReports = New System.Windows.Forms.TabPage()
        Me.txtReports = New System.Windows.Forms.TextBox()
        Me.btnGenerateReports = New System.Windows.Forms.Button()
        Me.btnDeleteReport = New System.Windows.Forms.Button()
        Me.btnEditReport = New System.Windows.Forms.Button()
        Me.btnNewCustomReport = New System.Windows.Forms.Button()
        Me.drpdwnReports = New System.Windows.Forms.ComboBox()
        Me.lblReports = New System.Windows.Forms.Label()
        Me.tabThePeople = New System.Windows.Forms.TabPage()
        Me.btnDeleteFaction = New System.Windows.Forms.Button()
        Me.btnEditFaction = New System.Windows.Forms.Button()
        Me.drpdwnFactions = New System.Windows.Forms.ComboBox()
        Me.lblFactions = New System.Windows.Forms.Label()
        Me.btnCreateFaction = New System.Windows.Forms.Button()
        Me.txtPeople = New System.Windows.Forms.TextBox()
        Me.btnConductPoll = New System.Windows.Forms.Button()
        Me.tabEventsCrises = New System.Windows.Forms.TabPage()
        Me.txtEvents = New System.Windows.Forms.TextBox()
        Me.drpdwnEventCrises = New System.Windows.Forms.ComboBox()
        Me.lblEventCrises = New System.Windows.Forms.Label()
        Me.btnDeleteEvent = New System.Windows.Forms.Button()
        Me.btnEditEvent = New System.Windows.Forms.Button()
        Me.btnNewEvent = New System.Windows.Forms.Button()
        Me.tabBudget = New System.Windows.Forms.TabPage()
        Me.btnShowBudget = New System.Windows.Forms.Button()
        Me.txtBudget = New System.Windows.Forms.TextBox()
        Me.btnEditBudget = New System.Windows.Forms.Button()
        Me.tabMinisters = New System.Windows.Forms.TabPage()
        Me.pboxMinister = New System.Windows.Forms.PictureBox()
        Me.txtMinisters = New System.Windows.Forms.TextBox()
        Me.btnDeleteMinister = New System.Windows.Forms.Button()
        Me.btnEditMinister = New System.Windows.Forms.Button()
        Me.btnNewMinister = New System.Windows.Forms.Button()
        Me.drpdwnMinisters = New System.Windows.Forms.ComboBox()
        Me.lblMinisters = New System.Windows.Forms.Label()
        Me.tabLaws = New System.Windows.Forms.TabPage()
        Me.txtLaws = New System.Windows.Forms.TextBox()
        Me.btnDeleteLaw = New System.Windows.Forms.Button()
        Me.btnEditLaw = New System.Windows.Forms.Button()
        Me.lblExistingLaws = New System.Windows.Forms.Label()
        Me.drpdwnExistingLaws = New System.Windows.Forms.ComboBox()
        Me.btnNewLaw = New System.Windows.Forms.Button()
        Me.tabNations = New System.Windows.Forms.TabPage()
        Me.lblNations = New System.Windows.Forms.Label()
        Me.drpdwnNations = New System.Windows.Forms.ComboBox()
        Me.txtNations = New System.Windows.Forms.TextBox()
        Me.tabCurrentState = New System.Windows.Forms.TabPage()
        Me.txtGameStatus = New System.Windows.Forms.RichTextBox()
        Me.btnBBCodeFormat = New System.Windows.Forms.Button()
        Me.btnTextOnly = New System.Windows.Forms.Button()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabMinisterActions = New System.Windows.Forms.TabPage()
        Me.btnDeleteAction = New System.Windows.Forms.Button()
        Me.btnEditAction = New System.Windows.Forms.Button()
        Me.btnNewAction = New System.Windows.Forms.Button()
        Me.lblMinisterActions = New System.Windows.Forms.Label()
        Me.drpdwnActions = New System.Windows.Forms.ComboBox()
        Me.txtActions = New System.Windows.Forms.RichTextBox()
        Me.tabPrograms = New System.Windows.Forms.TabPage()
        Me.btnDeleteProgram = New System.Windows.Forms.Button()
        Me.btnEditProgram = New System.Windows.Forms.Button()
        Me.btnNewProgram = New System.Windows.Forms.Button()
        Me.lblPrograms = New System.Windows.Forms.Label()
        Me.drpdwnPrograms = New System.Windows.Forms.ComboBox()
        Me.txtPrograms = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.tabWarsEnemiesAllies.SuspendLayout()
        Me.tabReports.SuspendLayout()
        Me.tabThePeople.SuspendLayout()
        Me.tabEventsCrises.SuspendLayout()
        Me.tabBudget.SuspendLayout()
        Me.tabMinisters.SuspendLayout()
        CType(Me.pboxMinister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLaws.SuspendLayout()
        Me.tabNations.SuspendLayout()
        Me.tabCurrentState.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.tabMinisterActions.SuspendLayout()
        Me.tabPrograms.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.toolStripSeparator, Me.btnNextPhase, Me.ToolStripSeparator1, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(839, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'btnNextPhase
        '
        Me.btnNextPhase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNextPhase.Image = CType(resources.GetObject("btnNextPhase.Image"), System.Drawing.Image)
        Me.btnNextPhase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNextPhase.Name = "btnNextPhase"
        Me.btnNextPhase.Size = New System.Drawing.Size(23, 22)
        Me.btnNextPhase.Text = "Next Phase"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'tabWarsEnemiesAllies
        '
        Me.tabWarsEnemiesAllies.Controls.Add(Me.btnEditWar)
        Me.tabWarsEnemiesAllies.Controls.Add(Me.txtWars)
        Me.tabWarsEnemiesAllies.Controls.Add(Me.btnCalcWarProgress)
        Me.tabWarsEnemiesAllies.Controls.Add(Me.btnShowEnAl)
        Me.tabWarsEnemiesAllies.Controls.Add(Me.drpdwnWars)
        Me.tabWarsEnemiesAllies.Controls.Add(Me.lblWars)
        Me.tabWarsEnemiesAllies.Controls.Add(Me.btnEndWar)
        Me.tabWarsEnemiesAllies.Controls.Add(Me.btnDeclareWar)
        Me.tabWarsEnemiesAllies.Location = New System.Drawing.Point(4, 22)
        Me.tabWarsEnemiesAllies.Name = "tabWarsEnemiesAllies"
        Me.tabWarsEnemiesAllies.Padding = New System.Windows.Forms.Padding(3)
        Me.tabWarsEnemiesAllies.Size = New System.Drawing.Size(807, 495)
        Me.tabWarsEnemiesAllies.TabIndex = 9
        Me.tabWarsEnemiesAllies.Text = "Wars, Enemies, Allies"
        Me.tabWarsEnemiesAllies.UseVisualStyleBackColor = True
        '
        'btnEditWar
        '
        Me.btnEditWar.Location = New System.Drawing.Point(9, 82)
        Me.btnEditWar.Name = "btnEditWar"
        Me.btnEditWar.Size = New System.Drawing.Size(121, 23)
        Me.btnEditWar.TabIndex = 18
        Me.btnEditWar.Text = "Edit War"
        Me.btnEditWar.UseVisualStyleBackColor = True
        '
        'txtWars
        '
        Me.txtWars.Location = New System.Drawing.Point(136, 19)
        Me.txtWars.Multiline = True
        Me.txtWars.Name = "txtWars"
        Me.txtWars.ReadOnly = True
        Me.txtWars.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWars.Size = New System.Drawing.Size(665, 470)
        Me.txtWars.TabIndex = 17
        '
        'btnCalcWarProgress
        '
        Me.btnCalcWarProgress.Location = New System.Drawing.Point(9, 140)
        Me.btnCalcWarProgress.Name = "btnCalcWarProgress"
        Me.btnCalcWarProgress.Size = New System.Drawing.Size(121, 23)
        Me.btnCalcWarProgress.TabIndex = 13
        Me.btnCalcWarProgress.Text = "Progress War"
        Me.btnCalcWarProgress.UseVisualStyleBackColor = True
        '
        'btnShowEnAl
        '
        Me.btnShowEnAl.Location = New System.Drawing.Point(9, 169)
        Me.btnShowEnAl.Name = "btnShowEnAl"
        Me.btnShowEnAl.Size = New System.Drawing.Size(121, 23)
        Me.btnShowEnAl.TabIndex = 12
        Me.btnShowEnAl.Text = "Show Enemies/Allies"
        Me.btnShowEnAl.UseVisualStyleBackColor = True
        '
        'drpdwnWars
        '
        Me.drpdwnWars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpdwnWars.FormattingEnabled = True
        Me.drpdwnWars.Location = New System.Drawing.Point(9, 19)
        Me.drpdwnWars.Name = "drpdwnWars"
        Me.drpdwnWars.Size = New System.Drawing.Size(121, 21)
        Me.drpdwnWars.TabIndex = 11
        '
        'lblWars
        '
        Me.lblWars.AutoSize = True
        Me.lblWars.Location = New System.Drawing.Point(6, 3)
        Me.lblWars.Name = "lblWars"
        Me.lblWars.Size = New System.Drawing.Size(32, 13)
        Me.lblWars.TabIndex = 10
        Me.lblWars.Text = "Wars"
        '
        'btnEndWar
        '
        Me.btnEndWar.Location = New System.Drawing.Point(9, 111)
        Me.btnEndWar.Name = "btnEndWar"
        Me.btnEndWar.Size = New System.Drawing.Size(121, 23)
        Me.btnEndWar.TabIndex = 9
        Me.btnEndWar.Text = "End War"
        Me.btnEndWar.UseVisualStyleBackColor = True
        '
        'btnDeclareWar
        '
        Me.btnDeclareWar.Location = New System.Drawing.Point(9, 53)
        Me.btnDeclareWar.Name = "btnDeclareWar"
        Me.btnDeclareWar.Size = New System.Drawing.Size(121, 23)
        Me.btnDeclareWar.TabIndex = 8
        Me.btnDeclareWar.Text = "Declare War"
        Me.btnDeclareWar.UseVisualStyleBackColor = True
        '
        'tabReports
        '
        Me.tabReports.Controls.Add(Me.txtReports)
        Me.tabReports.Controls.Add(Me.btnGenerateReports)
        Me.tabReports.Controls.Add(Me.btnDeleteReport)
        Me.tabReports.Controls.Add(Me.btnEditReport)
        Me.tabReports.Controls.Add(Me.btnNewCustomReport)
        Me.tabReports.Controls.Add(Me.drpdwnReports)
        Me.tabReports.Controls.Add(Me.lblReports)
        Me.tabReports.Location = New System.Drawing.Point(4, 22)
        Me.tabReports.Name = "tabReports"
        Me.tabReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReports.Size = New System.Drawing.Size(807, 495)
        Me.tabReports.TabIndex = 7
        Me.tabReports.Text = "Reports"
        Me.tabReports.UseVisualStyleBackColor = True
        '
        'txtReports
        '
        Me.txtReports.Location = New System.Drawing.Point(136, 19)
        Me.txtReports.Multiline = True
        Me.txtReports.Name = "txtReports"
        Me.txtReports.ReadOnly = True
        Me.txtReports.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReports.Size = New System.Drawing.Size(665, 470)
        Me.txtReports.TabIndex = 16
        '
        'btnGenerateReports
        '
        Me.btnGenerateReports.Location = New System.Drawing.Point(9, 75)
        Me.btnGenerateReports.Name = "btnGenerateReports"
        Me.btnGenerateReports.Size = New System.Drawing.Size(121, 23)
        Me.btnGenerateReports.TabIndex = 10
        Me.btnGenerateReports.Text = "Generate Reports"
        Me.btnGenerateReports.UseVisualStyleBackColor = True
        '
        'btnDeleteReport
        '
        Me.btnDeleteReport.Location = New System.Drawing.Point(9, 133)
        Me.btnDeleteReport.Name = "btnDeleteReport"
        Me.btnDeleteReport.Size = New System.Drawing.Size(121, 23)
        Me.btnDeleteReport.TabIndex = 9
        Me.btnDeleteReport.Text = "Delete Report"
        Me.btnDeleteReport.UseVisualStyleBackColor = True
        '
        'btnEditReport
        '
        Me.btnEditReport.Location = New System.Drawing.Point(9, 104)
        Me.btnEditReport.Name = "btnEditReport"
        Me.btnEditReport.Size = New System.Drawing.Size(121, 23)
        Me.btnEditReport.TabIndex = 8
        Me.btnEditReport.Text = "Edit Report"
        Me.btnEditReport.UseVisualStyleBackColor = True
        '
        'btnNewCustomReport
        '
        Me.btnNewCustomReport.Location = New System.Drawing.Point(9, 46)
        Me.btnNewCustomReport.Name = "btnNewCustomReport"
        Me.btnNewCustomReport.Size = New System.Drawing.Size(121, 23)
        Me.btnNewCustomReport.TabIndex = 7
        Me.btnNewCustomReport.Text = "New Custom Report"
        Me.btnNewCustomReport.UseVisualStyleBackColor = True
        '
        'drpdwnReports
        '
        Me.drpdwnReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpdwnReports.FormattingEnabled = True
        Me.drpdwnReports.Location = New System.Drawing.Point(9, 19)
        Me.drpdwnReports.Name = "drpdwnReports"
        Me.drpdwnReports.Size = New System.Drawing.Size(121, 21)
        Me.drpdwnReports.TabIndex = 6
        '
        'lblReports
        '
        Me.lblReports.AutoSize = True
        Me.lblReports.Location = New System.Drawing.Point(6, 3)
        Me.lblReports.Name = "lblReports"
        Me.lblReports.Size = New System.Drawing.Size(44, 13)
        Me.lblReports.TabIndex = 1
        Me.lblReports.Text = "Reports"
        '
        'tabThePeople
        '
        Me.tabThePeople.Controls.Add(Me.btnDeleteFaction)
        Me.tabThePeople.Controls.Add(Me.btnEditFaction)
        Me.tabThePeople.Controls.Add(Me.drpdwnFactions)
        Me.tabThePeople.Controls.Add(Me.lblFactions)
        Me.tabThePeople.Controls.Add(Me.btnCreateFaction)
        Me.tabThePeople.Controls.Add(Me.txtPeople)
        Me.tabThePeople.Controls.Add(Me.btnConductPoll)
        Me.tabThePeople.Location = New System.Drawing.Point(4, 22)
        Me.tabThePeople.Name = "tabThePeople"
        Me.tabThePeople.Padding = New System.Windows.Forms.Padding(3)
        Me.tabThePeople.Size = New System.Drawing.Size(807, 495)
        Me.tabThePeople.TabIndex = 6
        Me.tabThePeople.Text = "The People"
        Me.tabThePeople.UseVisualStyleBackColor = True
        '
        'btnDeleteFaction
        '
        Me.btnDeleteFaction.Location = New System.Drawing.Point(6, 133)
        Me.btnDeleteFaction.Name = "btnDeleteFaction"
        Me.btnDeleteFaction.Size = New System.Drawing.Size(121, 23)
        Me.btnDeleteFaction.TabIndex = 22
        Me.btnDeleteFaction.Text = "Delete Faction"
        Me.btnDeleteFaction.UseVisualStyleBackColor = True
        '
        'btnEditFaction
        '
        Me.btnEditFaction.Location = New System.Drawing.Point(6, 104)
        Me.btnEditFaction.Name = "btnEditFaction"
        Me.btnEditFaction.Size = New System.Drawing.Size(121, 23)
        Me.btnEditFaction.TabIndex = 21
        Me.btnEditFaction.Text = "Edit Faction"
        Me.btnEditFaction.UseVisualStyleBackColor = True
        '
        'drpdwnFactions
        '
        Me.drpdwnFactions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpdwnFactions.FormattingEnabled = True
        Me.drpdwnFactions.Location = New System.Drawing.Point(7, 19)
        Me.drpdwnFactions.Name = "drpdwnFactions"
        Me.drpdwnFactions.Size = New System.Drawing.Size(121, 21)
        Me.drpdwnFactions.TabIndex = 20
        '
        'lblFactions
        '
        Me.lblFactions.AutoSize = True
        Me.lblFactions.Location = New System.Drawing.Point(6, 3)
        Me.lblFactions.Name = "lblFactions"
        Me.lblFactions.Size = New System.Drawing.Size(47, 13)
        Me.lblFactions.TabIndex = 19
        Me.lblFactions.Text = "Factions"
        '
        'btnCreateFaction
        '
        Me.btnCreateFaction.Location = New System.Drawing.Point(6, 75)
        Me.btnCreateFaction.Name = "btnCreateFaction"
        Me.btnCreateFaction.Size = New System.Drawing.Size(121, 23)
        Me.btnCreateFaction.TabIndex = 18
        Me.btnCreateFaction.Text = "Create Faction"
        Me.btnCreateFaction.UseVisualStyleBackColor = True
        '
        'txtPeople
        '
        Me.txtPeople.Location = New System.Drawing.Point(133, 8)
        Me.txtPeople.Multiline = True
        Me.txtPeople.Name = "txtPeople"
        Me.txtPeople.ReadOnly = True
        Me.txtPeople.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPeople.Size = New System.Drawing.Size(668, 481)
        Me.txtPeople.TabIndex = 17
        '
        'btnConductPoll
        '
        Me.btnConductPoll.Location = New System.Drawing.Point(6, 46)
        Me.btnConductPoll.Name = "btnConductPoll"
        Me.btnConductPoll.Size = New System.Drawing.Size(121, 23)
        Me.btnConductPoll.TabIndex = 1
        Me.btnConductPoll.Text = "Conduct Poll"
        Me.btnConductPoll.UseVisualStyleBackColor = True
        '
        'tabEventsCrises
        '
        Me.tabEventsCrises.Controls.Add(Me.txtEvents)
        Me.tabEventsCrises.Controls.Add(Me.drpdwnEventCrises)
        Me.tabEventsCrises.Controls.Add(Me.lblEventCrises)
        Me.tabEventsCrises.Controls.Add(Me.btnDeleteEvent)
        Me.tabEventsCrises.Controls.Add(Me.btnEditEvent)
        Me.tabEventsCrises.Controls.Add(Me.btnNewEvent)
        Me.tabEventsCrises.Location = New System.Drawing.Point(4, 22)
        Me.tabEventsCrises.Name = "tabEventsCrises"
        Me.tabEventsCrises.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEventsCrises.Size = New System.Drawing.Size(807, 495)
        Me.tabEventsCrises.TabIndex = 5
        Me.tabEventsCrises.Text = "Events & Crises"
        Me.tabEventsCrises.UseVisualStyleBackColor = True
        '
        'txtEvents
        '
        Me.txtEvents.Location = New System.Drawing.Point(133, 19)
        Me.txtEvents.Multiline = True
        Me.txtEvents.Name = "txtEvents"
        Me.txtEvents.ReadOnly = True
        Me.txtEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEvents.Size = New System.Drawing.Size(668, 470)
        Me.txtEvents.TabIndex = 16
        '
        'drpdwnEventCrises
        '
        Me.drpdwnEventCrises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpdwnEventCrises.FormattingEnabled = True
        Me.drpdwnEventCrises.Location = New System.Drawing.Point(6, 19)
        Me.drpdwnEventCrises.Name = "drpdwnEventCrises"
        Me.drpdwnEventCrises.Size = New System.Drawing.Size(121, 21)
        Me.drpdwnEventCrises.TabIndex = 4
        '
        'lblEventCrises
        '
        Me.lblEventCrises.AutoSize = True
        Me.lblEventCrises.Location = New System.Drawing.Point(3, 3)
        Me.lblEventCrises.Name = "lblEventCrises"
        Me.lblEventCrises.Size = New System.Drawing.Size(92, 13)
        Me.lblEventCrises.TabIndex = 3
        Me.lblEventCrises.Text = "Events and Crises"
        '
        'btnDeleteEvent
        '
        Me.btnDeleteEvent.Location = New System.Drawing.Point(6, 105)
        Me.btnDeleteEvent.Name = "btnDeleteEvent"
        Me.btnDeleteEvent.Size = New System.Drawing.Size(121, 23)
        Me.btnDeleteEvent.TabIndex = 2
        Me.btnDeleteEvent.Text = "Delete Event"
        Me.btnDeleteEvent.UseVisualStyleBackColor = True
        '
        'btnEditEvent
        '
        Me.btnEditEvent.Location = New System.Drawing.Point(6, 76)
        Me.btnEditEvent.Name = "btnEditEvent"
        Me.btnEditEvent.Size = New System.Drawing.Size(121, 23)
        Me.btnEditEvent.TabIndex = 1
        Me.btnEditEvent.Text = "Edit Event"
        Me.btnEditEvent.UseVisualStyleBackColor = True
        '
        'btnNewEvent
        '
        Me.btnNewEvent.Location = New System.Drawing.Point(6, 46)
        Me.btnNewEvent.Name = "btnNewEvent"
        Me.btnNewEvent.Size = New System.Drawing.Size(121, 23)
        Me.btnNewEvent.TabIndex = 0
        Me.btnNewEvent.Text = "New Event"
        Me.btnNewEvent.UseVisualStyleBackColor = True
        '
        'tabBudget
        '
        Me.tabBudget.Controls.Add(Me.btnShowBudget)
        Me.tabBudget.Controls.Add(Me.txtBudget)
        Me.tabBudget.Controls.Add(Me.btnEditBudget)
        Me.tabBudget.Location = New System.Drawing.Point(4, 22)
        Me.tabBudget.Name = "tabBudget"
        Me.tabBudget.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBudget.Size = New System.Drawing.Size(807, 495)
        Me.tabBudget.TabIndex = 4
        Me.tabBudget.Text = "Budget"
        Me.tabBudget.UseVisualStyleBackColor = True
        '
        'btnShowBudget
        '
        Me.btnShowBudget.Location = New System.Drawing.Point(6, 8)
        Me.btnShowBudget.Name = "btnShowBudget"
        Me.btnShowBudget.Size = New System.Drawing.Size(121, 23)
        Me.btnShowBudget.TabIndex = 17
        Me.btnShowBudget.Text = "Show Budget"
        Me.btnShowBudget.UseVisualStyleBackColor = True
        '
        'txtBudget
        '
        Me.txtBudget.Location = New System.Drawing.Point(133, 8)
        Me.txtBudget.Multiline = True
        Me.txtBudget.Name = "txtBudget"
        Me.txtBudget.ReadOnly = True
        Me.txtBudget.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBudget.Size = New System.Drawing.Size(668, 481)
        Me.txtBudget.TabIndex = 16
        '
        'btnEditBudget
        '
        Me.btnEditBudget.Location = New System.Drawing.Point(6, 37)
        Me.btnEditBudget.Name = "btnEditBudget"
        Me.btnEditBudget.Size = New System.Drawing.Size(121, 23)
        Me.btnEditBudget.TabIndex = 4
        Me.btnEditBudget.Text = "Manual Budget Edit"
        Me.btnEditBudget.UseVisualStyleBackColor = True
        '
        'tabMinisters
        '
        Me.tabMinisters.Controls.Add(Me.pboxMinister)
        Me.tabMinisters.Controls.Add(Me.txtMinisters)
        Me.tabMinisters.Controls.Add(Me.btnDeleteMinister)
        Me.tabMinisters.Controls.Add(Me.btnEditMinister)
        Me.tabMinisters.Controls.Add(Me.btnNewMinister)
        Me.tabMinisters.Controls.Add(Me.drpdwnMinisters)
        Me.tabMinisters.Controls.Add(Me.lblMinisters)
        Me.tabMinisters.Location = New System.Drawing.Point(4, 22)
        Me.tabMinisters.Name = "tabMinisters"
        Me.tabMinisters.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMinisters.Size = New System.Drawing.Size(807, 495)
        Me.tabMinisters.TabIndex = 3
        Me.tabMinisters.Text = "Ministers"
        Me.tabMinisters.UseVisualStyleBackColor = True
        '
        'pboxMinister
        '
        Me.pboxMinister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pboxMinister.Location = New System.Drawing.Point(623, 19)
        Me.pboxMinister.Name = "pboxMinister"
        Me.pboxMinister.Size = New System.Drawing.Size(178, 215)
        Me.pboxMinister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxMinister.TabIndex = 16
        Me.pboxMinister.TabStop = False
        '
        'txtMinisters
        '
        Me.txtMinisters.Location = New System.Drawing.Point(136, 19)
        Me.txtMinisters.Multiline = True
        Me.txtMinisters.Name = "txtMinisters"
        Me.txtMinisters.ReadOnly = True
        Me.txtMinisters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMinisters.Size = New System.Drawing.Size(481, 470)
        Me.txtMinisters.TabIndex = 15
        '
        'btnDeleteMinister
        '
        Me.btnDeleteMinister.Location = New System.Drawing.Point(9, 104)
        Me.btnDeleteMinister.Name = "btnDeleteMinister"
        Me.btnDeleteMinister.Size = New System.Drawing.Size(121, 23)
        Me.btnDeleteMinister.TabIndex = 5
        Me.btnDeleteMinister.Text = "Delete Minister"
        Me.btnDeleteMinister.UseVisualStyleBackColor = True
        '
        'btnEditMinister
        '
        Me.btnEditMinister.Location = New System.Drawing.Point(9, 75)
        Me.btnEditMinister.Name = "btnEditMinister"
        Me.btnEditMinister.Size = New System.Drawing.Size(121, 23)
        Me.btnEditMinister.TabIndex = 4
        Me.btnEditMinister.Text = "Edit Minister"
        Me.btnEditMinister.UseVisualStyleBackColor = True
        '
        'btnNewMinister
        '
        Me.btnNewMinister.Location = New System.Drawing.Point(9, 46)
        Me.btnNewMinister.Name = "btnNewMinister"
        Me.btnNewMinister.Size = New System.Drawing.Size(121, 23)
        Me.btnNewMinister.TabIndex = 3
        Me.btnNewMinister.Text = "New Minister"
        Me.btnNewMinister.UseVisualStyleBackColor = True
        '
        'drpdwnMinisters
        '
        Me.drpdwnMinisters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpdwnMinisters.FormattingEnabled = True
        Me.drpdwnMinisters.Location = New System.Drawing.Point(9, 19)
        Me.drpdwnMinisters.Name = "drpdwnMinisters"
        Me.drpdwnMinisters.Size = New System.Drawing.Size(121, 21)
        Me.drpdwnMinisters.TabIndex = 2
        '
        'lblMinisters
        '
        Me.lblMinisters.AutoSize = True
        Me.lblMinisters.Location = New System.Drawing.Point(6, 3)
        Me.lblMinisters.Name = "lblMinisters"
        Me.lblMinisters.Size = New System.Drawing.Size(48, 13)
        Me.lblMinisters.TabIndex = 0
        Me.lblMinisters.Text = "Ministers"
        '
        'tabLaws
        '
        Me.tabLaws.Controls.Add(Me.txtLaws)
        Me.tabLaws.Controls.Add(Me.btnDeleteLaw)
        Me.tabLaws.Controls.Add(Me.btnEditLaw)
        Me.tabLaws.Controls.Add(Me.lblExistingLaws)
        Me.tabLaws.Controls.Add(Me.drpdwnExistingLaws)
        Me.tabLaws.Controls.Add(Me.btnNewLaw)
        Me.tabLaws.Location = New System.Drawing.Point(4, 22)
        Me.tabLaws.Name = "tabLaws"
        Me.tabLaws.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLaws.Size = New System.Drawing.Size(807, 495)
        Me.tabLaws.TabIndex = 2
        Me.tabLaws.Text = "Laws & Policies"
        Me.tabLaws.UseVisualStyleBackColor = True
        '
        'txtLaws
        '
        Me.txtLaws.Location = New System.Drawing.Point(136, 19)
        Me.txtLaws.Multiline = True
        Me.txtLaws.Name = "txtLaws"
        Me.txtLaws.ReadOnly = True
        Me.txtLaws.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLaws.Size = New System.Drawing.Size(665, 470)
        Me.txtLaws.TabIndex = 14
        '
        'btnDeleteLaw
        '
        Me.btnDeleteLaw.Location = New System.Drawing.Point(9, 104)
        Me.btnDeleteLaw.Name = "btnDeleteLaw"
        Me.btnDeleteLaw.Size = New System.Drawing.Size(121, 23)
        Me.btnDeleteLaw.TabIndex = 4
        Me.btnDeleteLaw.Text = "Delete Law"
        Me.btnDeleteLaw.UseVisualStyleBackColor = True
        '
        'btnEditLaw
        '
        Me.btnEditLaw.Location = New System.Drawing.Point(9, 75)
        Me.btnEditLaw.Name = "btnEditLaw"
        Me.btnEditLaw.Size = New System.Drawing.Size(121, 23)
        Me.btnEditLaw.TabIndex = 3
        Me.btnEditLaw.Text = "Edit Law"
        Me.btnEditLaw.UseVisualStyleBackColor = True
        '
        'lblExistingLaws
        '
        Me.lblExistingLaws.AutoSize = True
        Me.lblExistingLaws.Location = New System.Drawing.Point(6, 3)
        Me.lblExistingLaws.Name = "lblExistingLaws"
        Me.lblExistingLaws.Size = New System.Drawing.Size(71, 13)
        Me.lblExistingLaws.TabIndex = 2
        Me.lblExistingLaws.Text = "Existing Laws"
        '
        'drpdwnExistingLaws
        '
        Me.drpdwnExistingLaws.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpdwnExistingLaws.FormattingEnabled = True
        Me.drpdwnExistingLaws.Location = New System.Drawing.Point(9, 19)
        Me.drpdwnExistingLaws.Name = "drpdwnExistingLaws"
        Me.drpdwnExistingLaws.Size = New System.Drawing.Size(121, 21)
        Me.drpdwnExistingLaws.TabIndex = 1
        '
        'btnNewLaw
        '
        Me.btnNewLaw.Location = New System.Drawing.Point(9, 46)
        Me.btnNewLaw.Name = "btnNewLaw"
        Me.btnNewLaw.Size = New System.Drawing.Size(121, 23)
        Me.btnNewLaw.TabIndex = 0
        Me.btnNewLaw.Text = "New Law"
        Me.btnNewLaw.UseVisualStyleBackColor = True
        '
        'tabNations
        '
        Me.tabNations.Controls.Add(Me.lblNations)
        Me.tabNations.Controls.Add(Me.drpdwnNations)
        Me.tabNations.Controls.Add(Me.txtNations)
        Me.tabNations.Location = New System.Drawing.Point(4, 22)
        Me.tabNations.Name = "tabNations"
        Me.tabNations.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNations.Size = New System.Drawing.Size(807, 495)
        Me.tabNations.TabIndex = 1
        Me.tabNations.Text = "Nations"
        Me.tabNations.UseVisualStyleBackColor = True
        '
        'lblNations
        '
        Me.lblNations.AutoSize = True
        Me.lblNations.Location = New System.Drawing.Point(6, 3)
        Me.lblNations.Name = "lblNations"
        Me.lblNations.Size = New System.Drawing.Size(43, 13)
        Me.lblNations.TabIndex = 15
        Me.lblNations.Text = "Nations"
        '
        'drpdwnNations
        '
        Me.drpdwnNations.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.drpdwnNations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpdwnNations.FormattingEnabled = True
        Me.drpdwnNations.Location = New System.Drawing.Point(7, 19)
        Me.drpdwnNations.Name = "drpdwnNations"
        Me.drpdwnNations.Size = New System.Drawing.Size(121, 21)
        Me.drpdwnNations.TabIndex = 14
        '
        'txtNations
        '
        Me.txtNations.Location = New System.Drawing.Point(134, 19)
        Me.txtNations.Multiline = True
        Me.txtNations.Name = "txtNations"
        Me.txtNations.ReadOnly = True
        Me.txtNations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNations.Size = New System.Drawing.Size(667, 470)
        Me.txtNations.TabIndex = 13
        '
        'tabCurrentState
        '
        Me.tabCurrentState.Controls.Add(Me.txtGameStatus)
        Me.tabCurrentState.Controls.Add(Me.btnBBCodeFormat)
        Me.tabCurrentState.Controls.Add(Me.btnTextOnly)
        Me.tabCurrentState.Location = New System.Drawing.Point(4, 22)
        Me.tabCurrentState.Name = "tabCurrentState"
        Me.tabCurrentState.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCurrentState.Size = New System.Drawing.Size(807, 495)
        Me.tabCurrentState.TabIndex = 0
        Me.tabCurrentState.Text = "Current Game State"
        Me.tabCurrentState.UseVisualStyleBackColor = True
        '
        'txtGameStatus
        '
        Me.txtGameStatus.Location = New System.Drawing.Point(133, 8)
        Me.txtGameStatus.Name = "txtGameStatus"
        Me.txtGameStatus.ReadOnly = True
        Me.txtGameStatus.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtGameStatus.Size = New System.Drawing.Size(668, 481)
        Me.txtGameStatus.TabIndex = 4
        Me.txtGameStatus.Text = ""
        '
        'btnBBCodeFormat
        '
        Me.btnBBCodeFormat.Location = New System.Drawing.Point(6, 35)
        Me.btnBBCodeFormat.Name = "btnBBCodeFormat"
        Me.btnBBCodeFormat.Size = New System.Drawing.Size(121, 23)
        Me.btnBBCodeFormat.TabIndex = 2
        Me.btnBBCodeFormat.Text = "BBCode Formatting"
        Me.btnBBCodeFormat.UseVisualStyleBackColor = True
        '
        'btnTextOnly
        '
        Me.btnTextOnly.Location = New System.Drawing.Point(6, 6)
        Me.btnTextOnly.Name = "btnTextOnly"
        Me.btnTextOnly.Size = New System.Drawing.Size(121, 23)
        Me.btnTextOnly.TabIndex = 1
        Me.btnTextOnly.Text = "Text Only"
        Me.btnTextOnly.UseVisualStyleBackColor = True
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabCurrentState)
        Me.tabControl.Controls.Add(Me.tabNations)
        Me.tabControl.Controls.Add(Me.tabLaws)
        Me.tabControl.Controls.Add(Me.tabMinisters)
        Me.tabControl.Controls.Add(Me.tabBudget)
        Me.tabControl.Controls.Add(Me.tabEventsCrises)
        Me.tabControl.Controls.Add(Me.tabThePeople)
        Me.tabControl.Controls.Add(Me.tabReports)
        Me.tabControl.Controls.Add(Me.tabWarsEnemiesAllies)
        Me.tabControl.Controls.Add(Me.tabMinisterActions)
        Me.tabControl.Controls.Add(Me.tabPrograms)
        Me.tabControl.Location = New System.Drawing.Point(12, 28)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(815, 521)
        Me.tabControl.TabIndex = 2
        '
        'tabMinisterActions
        '
        Me.tabMinisterActions.Controls.Add(Me.btnDeleteAction)
        Me.tabMinisterActions.Controls.Add(Me.btnEditAction)
        Me.tabMinisterActions.Controls.Add(Me.btnNewAction)
        Me.tabMinisterActions.Controls.Add(Me.lblMinisterActions)
        Me.tabMinisterActions.Controls.Add(Me.drpdwnActions)
        Me.tabMinisterActions.Controls.Add(Me.txtActions)
        Me.tabMinisterActions.Location = New System.Drawing.Point(4, 22)
        Me.tabMinisterActions.Name = "tabMinisterActions"
        Me.tabMinisterActions.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMinisterActions.Size = New System.Drawing.Size(807, 495)
        Me.tabMinisterActions.TabIndex = 10
        Me.tabMinisterActions.Text = "Minister Actions"
        Me.tabMinisterActions.UseVisualStyleBackColor = True
        '
        'btnDeleteAction
        '
        Me.btnDeleteAction.Location = New System.Drawing.Point(6, 108)
        Me.btnDeleteAction.Name = "btnDeleteAction"
        Me.btnDeleteAction.Size = New System.Drawing.Size(121, 23)
        Me.btnDeleteAction.TabIndex = 16
        Me.btnDeleteAction.Text = "Delete Action"
        Me.btnDeleteAction.UseVisualStyleBackColor = True
        '
        'btnEditAction
        '
        Me.btnEditAction.Location = New System.Drawing.Point(6, 79)
        Me.btnEditAction.Name = "btnEditAction"
        Me.btnEditAction.Size = New System.Drawing.Size(121, 23)
        Me.btnEditAction.TabIndex = 15
        Me.btnEditAction.Text = "Edit Action"
        Me.btnEditAction.UseVisualStyleBackColor = True
        '
        'btnNewAction
        '
        Me.btnNewAction.Location = New System.Drawing.Point(6, 50)
        Me.btnNewAction.Name = "btnNewAction"
        Me.btnNewAction.Size = New System.Drawing.Size(121, 23)
        Me.btnNewAction.TabIndex = 14
        Me.btnNewAction.Text = "New Action"
        Me.btnNewAction.UseVisualStyleBackColor = True
        '
        'lblMinisterActions
        '
        Me.lblMinisterActions.AutoSize = True
        Me.lblMinisterActions.Location = New System.Drawing.Point(6, 7)
        Me.lblMinisterActions.Name = "lblMinisterActions"
        Me.lblMinisterActions.Size = New System.Drawing.Size(81, 13)
        Me.lblMinisterActions.TabIndex = 13
        Me.lblMinisterActions.Text = "Minister Actions"
        '
        'drpdwnActions
        '
        Me.drpdwnActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpdwnActions.FormattingEnabled = True
        Me.drpdwnActions.Location = New System.Drawing.Point(6, 23)
        Me.drpdwnActions.Name = "drpdwnActions"
        Me.drpdwnActions.Size = New System.Drawing.Size(121, 21)
        Me.drpdwnActions.TabIndex = 12
        '
        'txtActions
        '
        Me.txtActions.Location = New System.Drawing.Point(133, 8)
        Me.txtActions.Name = "txtActions"
        Me.txtActions.ReadOnly = True
        Me.txtActions.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtActions.Size = New System.Drawing.Size(668, 481)
        Me.txtActions.TabIndex = 5
        Me.txtActions.Text = ""
        '
        'tabPrograms
        '
        Me.tabPrograms.Controls.Add(Me.btnDeleteProgram)
        Me.tabPrograms.Controls.Add(Me.btnEditProgram)
        Me.tabPrograms.Controls.Add(Me.btnNewProgram)
        Me.tabPrograms.Controls.Add(Me.lblPrograms)
        Me.tabPrograms.Controls.Add(Me.drpdwnPrograms)
        Me.tabPrograms.Controls.Add(Me.txtPrograms)
        Me.tabPrograms.Location = New System.Drawing.Point(4, 22)
        Me.tabPrograms.Name = "tabPrograms"
        Me.tabPrograms.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPrograms.Size = New System.Drawing.Size(807, 495)
        Me.tabPrograms.TabIndex = 11
        Me.tabPrograms.Text = "Programs"
        Me.tabPrograms.UseVisualStyleBackColor = True
        '
        'btnDeleteProgram
        '
        Me.btnDeleteProgram.Location = New System.Drawing.Point(6, 109)
        Me.btnDeleteProgram.Name = "btnDeleteProgram"
        Me.btnDeleteProgram.Size = New System.Drawing.Size(121, 23)
        Me.btnDeleteProgram.TabIndex = 16
        Me.btnDeleteProgram.Text = "Delete Program"
        Me.btnDeleteProgram.UseVisualStyleBackColor = True
        '
        'btnEditProgram
        '
        Me.btnEditProgram.Location = New System.Drawing.Point(6, 80)
        Me.btnEditProgram.Name = "btnEditProgram"
        Me.btnEditProgram.Size = New System.Drawing.Size(121, 23)
        Me.btnEditProgram.TabIndex = 15
        Me.btnEditProgram.Text = "Edit Program"
        Me.btnEditProgram.UseVisualStyleBackColor = True
        '
        'btnNewProgram
        '
        Me.btnNewProgram.Location = New System.Drawing.Point(6, 51)
        Me.btnNewProgram.Name = "btnNewProgram"
        Me.btnNewProgram.Size = New System.Drawing.Size(121, 23)
        Me.btnNewProgram.TabIndex = 14
        Me.btnNewProgram.Text = "New Program"
        Me.btnNewProgram.UseVisualStyleBackColor = True
        '
        'lblPrograms
        '
        Me.lblPrograms.AutoSize = True
        Me.lblPrograms.Location = New System.Drawing.Point(6, 8)
        Me.lblPrograms.Name = "lblPrograms"
        Me.lblPrograms.Size = New System.Drawing.Size(51, 13)
        Me.lblPrograms.TabIndex = 13
        Me.lblPrograms.Text = "Programs"
        '
        'drpdwnPrograms
        '
        Me.drpdwnPrograms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpdwnPrograms.FormattingEnabled = True
        Me.drpdwnPrograms.Location = New System.Drawing.Point(6, 24)
        Me.drpdwnPrograms.Name = "drpdwnPrograms"
        Me.drpdwnPrograms.Size = New System.Drawing.Size(121, 21)
        Me.drpdwnPrograms.TabIndex = 12
        '
        'txtPrograms
        '
        Me.txtPrograms.Location = New System.Drawing.Point(133, 8)
        Me.txtPrograms.Name = "txtPrograms"
        Me.txtPrograms.ReadOnly = True
        Me.txtPrograms.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtPrograms.Size = New System.Drawing.Size(668, 481)
        Me.txtPrograms.TabIndex = 5
        Me.txtPrograms.Text = ""
        '
        'RepubCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(839, 561)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RepubCalc"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Republic Calculator"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tabWarsEnemiesAllies.ResumeLayout(False)
        Me.tabWarsEnemiesAllies.PerformLayout()
        Me.tabReports.ResumeLayout(False)
        Me.tabReports.PerformLayout()
        Me.tabThePeople.ResumeLayout(False)
        Me.tabThePeople.PerformLayout()
        Me.tabEventsCrises.ResumeLayout(False)
        Me.tabEventsCrises.PerformLayout()
        Me.tabBudget.ResumeLayout(False)
        Me.tabBudget.PerformLayout()
        Me.tabMinisters.ResumeLayout(False)
        Me.tabMinisters.PerformLayout()
        CType(Me.pboxMinister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLaws.ResumeLayout(False)
        Me.tabLaws.PerformLayout()
        Me.tabNations.ResumeLayout(False)
        Me.tabNations.PerformLayout()
        Me.tabCurrentState.ResumeLayout(False)
        Me.tabControl.ResumeLayout(False)
        Me.tabMinisterActions.ResumeLayout(False)
        Me.tabMinisterActions.PerformLayout()
        Me.tabPrograms.ResumeLayout(False)
        Me.tabPrograms.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents btnNextPhase As ToolStripButton
    Friend WithEvents tabWarsEnemiesAllies As TabPage
    Friend WithEvents drpdwnWars As ComboBox
    Friend WithEvents lblWars As Label
    Friend WithEvents btnEndWar As Button
    Friend WithEvents btnDeclareWar As Button
    Friend WithEvents tabReports As TabPage
    Friend WithEvents txtReports As TextBox
    Friend WithEvents btnGenerateReports As Button
    Friend WithEvents btnDeleteReport As Button
    Friend WithEvents btnEditReport As Button
    Friend WithEvents btnNewCustomReport As Button
    Friend WithEvents drpdwnReports As ComboBox
    Friend WithEvents lblReports As Label
    Friend WithEvents tabThePeople As TabPage
    Friend WithEvents btnConductPoll As Button
    Friend WithEvents tabEventsCrises As TabPage
    Friend WithEvents txtEvents As TextBox
    Friend WithEvents drpdwnEventCrises As ComboBox
    Friend WithEvents lblEventCrises As Label
    Friend WithEvents btnDeleteEvent As Button
    Friend WithEvents btnEditEvent As Button
    Friend WithEvents btnNewEvent As Button
    Friend WithEvents tabBudget As TabPage
    Friend WithEvents txtBudget As TextBox
    Friend WithEvents btnEditBudget As Button
    Friend WithEvents tabMinisters As TabPage
    Friend WithEvents txtMinisters As TextBox
    Friend WithEvents btnDeleteMinister As Button
    Friend WithEvents btnEditMinister As Button
    Friend WithEvents btnNewMinister As Button
    Friend WithEvents drpdwnMinisters As ComboBox
    Friend WithEvents lblMinisters As Label
    Friend WithEvents tabLaws As TabPage
    Friend WithEvents txtLaws As TextBox
    Friend WithEvents btnDeleteLaw As Button
    Friend WithEvents btnEditLaw As Button
    Friend WithEvents lblExistingLaws As Label
    Friend WithEvents drpdwnExistingLaws As ComboBox
    Friend WithEvents btnNewLaw As Button
    Friend WithEvents tabNations As TabPage
    Friend WithEvents lblNations As Label
    Friend WithEvents drpdwnNations As ComboBox
    Friend WithEvents txtNations As TextBox
    Friend WithEvents tabCurrentState As TabPage
    Friend WithEvents tabControl As TabControl
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnBBCodeFormat As Button
    Friend WithEvents btnTextOnly As Button
    Friend WithEvents btnCalcWarProgress As Button
    Friend WithEvents btnShowEnAl As Button
    Friend WithEvents txtWars As TextBox
    Friend WithEvents txtPeople As TextBox
    Friend WithEvents txtGameStatus As RichTextBox
    Friend WithEvents pboxMinister As PictureBox
    Friend WithEvents btnShowBudget As Button
    Friend WithEvents drpdwnFactions As ComboBox
    Friend WithEvents lblFactions As Label
    Friend WithEvents btnCreateFaction As Button
    Friend WithEvents btnDeleteFaction As Button
    Friend WithEvents btnEditFaction As Button
    Friend WithEvents btnEditWar As Button
    Friend WithEvents tabMinisterActions As TabPage
    Friend WithEvents btnDeleteAction As Button
    Friend WithEvents btnEditAction As Button
    Friend WithEvents btnNewAction As Button
    Friend WithEvents lblMinisterActions As Label
    Friend WithEvents drpdwnActions As ComboBox
    Friend WithEvents txtActions As RichTextBox
    Friend WithEvents tabPrograms As TabPage
    Friend WithEvents btnDeleteProgram As Button
    Friend WithEvents btnEditProgram As Button
    Friend WithEvents btnNewProgram As Button
    Friend WithEvents lblPrograms As Label
    Friend WithEvents drpdwnPrograms As ComboBox
    Friend WithEvents txtPrograms As RichTextBox
End Class
