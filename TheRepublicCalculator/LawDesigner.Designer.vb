<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LawDesigner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LawDesigner))
        Me.btnSaveLaw = New System.Windows.Forms.Button()
        Me.btnCloseLaw = New System.Windows.Forms.Button()
        Me.lblLawName = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblLawBudget = New System.Windows.Forms.Label()
        Me.lblLawDescription = New System.Windows.Forms.Label()
        Me.txtLawName = New System.Windows.Forms.TextBox()
        Me.txtLawDescription = New System.Windows.Forms.TextBox()
        Me.updwnMilLaw = New System.Windows.Forms.NumericUpDown()
        Me.lblEconomyLaw = New System.Windows.Forms.Label()
        Me.lblMilitaryLaw = New System.Windows.Forms.Label()
        Me.lblSecLaw = New System.Windows.Forms.Label()
        Me.lblJusLaw = New System.Windows.Forms.Label()
        Me.lblForLaw = New System.Windows.Forms.Label()
        Me.lblPeopLaw = New System.Windows.Forms.Label()
        Me.lblTreasLaw = New System.Windows.Forms.Label()
        Me.updwnEconLaw = New System.Windows.Forms.NumericUpDown()
        Me.updwnSecLaw = New System.Windows.Forms.NumericUpDown()
        Me.updwnJusLaw = New System.Windows.Forms.NumericUpDown()
        Me.updwnForLaw = New System.Windows.Forms.NumericUpDown()
        Me.updwnPeopLaw = New System.Windows.Forms.NumericUpDown()
        Me.updwnTreasLaw = New System.Windows.Forms.NumericUpDown()
        Me.updwnDurationLaw = New System.Windows.Forms.NumericUpDown()
        Me.chkInEffect = New System.Windows.Forms.CheckBox()
        Me.chkExpired = New System.Windows.Forms.CheckBox()
        CType(Me.updwnMilLaw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnEconLaw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnSecLaw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnJusLaw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnForLaw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnPeopLaw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnTreasLaw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnDurationLaw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveLaw
        '
        Me.btnSaveLaw.Location = New System.Drawing.Point(184, 324)
        Me.btnSaveLaw.Name = "btnSaveLaw"
        Me.btnSaveLaw.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveLaw.TabIndex = 0
        Me.btnSaveLaw.Text = "Save Law"
        Me.btnSaveLaw.UseVisualStyleBackColor = True
        '
        'btnCloseLaw
        '
        Me.btnCloseLaw.Location = New System.Drawing.Point(265, 324)
        Me.btnCloseLaw.Name = "btnCloseLaw"
        Me.btnCloseLaw.Size = New System.Drawing.Size(75, 23)
        Me.btnCloseLaw.TabIndex = 1
        Me.btnCloseLaw.Text = "Close"
        Me.btnCloseLaw.UseVisualStyleBackColor = True
        '
        'lblLawName
        '
        Me.lblLawName.AutoSize = True
        Me.lblLawName.Location = New System.Drawing.Point(12, 15)
        Me.lblLawName.Name = "lblLawName"
        Me.lblLawName.Size = New System.Drawing.Size(70, 13)
        Me.lblLawName.TabIndex = 2
        Me.lblLawName.Text = "Name of Law"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(12, 53)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(47, 13)
        Me.lblDuration.TabIndex = 3
        Me.lblDuration.Text = "Duration"
        '
        'lblLawBudget
        '
        Me.lblLawBudget.AutoSize = True
        Me.lblLawBudget.Location = New System.Drawing.Point(319, 9)
        Me.lblLawBudget.Name = "lblLawBudget"
        Me.lblLawBudget.Size = New System.Drawing.Size(140, 13)
        Me.lblLawBudget.TabIndex = 4
        Me.lblLawBudget.Text = "Budget Changes (in Millions)"
        '
        'lblLawDescription
        '
        Me.lblLawDescription.AutoSize = True
        Me.lblLawDescription.Location = New System.Drawing.Point(12, 136)
        Me.lblLawDescription.Name = "lblLawDescription"
        Me.lblLawDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblLawDescription.TabIndex = 6
        Me.lblLawDescription.Text = "Description"
        '
        'txtLawName
        '
        Me.txtLawName.Location = New System.Drawing.Point(94, 12)
        Me.txtLawName.Name = "txtLawName"
        Me.txtLawName.Size = New System.Drawing.Size(146, 20)
        Me.txtLawName.TabIndex = 7
        '
        'txtLawDescription
        '
        Me.txtLawDescription.Location = New System.Drawing.Point(94, 133)
        Me.txtLawDescription.Multiline = True
        Me.txtLawDescription.Name = "txtLawDescription"
        Me.txtLawDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLawDescription.Size = New System.Drawing.Size(413, 185)
        Me.txtLawDescription.TabIndex = 9
        '
        'updwnMilLaw
        '
        Me.updwnMilLaw.DecimalPlaces = 2
        Me.updwnMilLaw.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.updwnMilLaw.Location = New System.Drawing.Point(303, 55)
        Me.updwnMilLaw.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.updwnMilLaw.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.updwnMilLaw.Name = "updwnMilLaw"
        Me.updwnMilLaw.Size = New System.Drawing.Size(50, 20)
        Me.updwnMilLaw.TabIndex = 11
        '
        'lblEconomyLaw
        '
        Me.lblEconomyLaw.AutoSize = True
        Me.lblEconomyLaw.Location = New System.Drawing.Point(246, 31)
        Me.lblEconomyLaw.Name = "lblEconomyLaw"
        Me.lblEconomyLaw.Size = New System.Drawing.Size(51, 13)
        Me.lblEconomyLaw.TabIndex = 16
        Me.lblEconomyLaw.Text = "Economy"
        '
        'lblMilitaryLaw
        '
        Me.lblMilitaryLaw.AutoSize = True
        Me.lblMilitaryLaw.Location = New System.Drawing.Point(246, 57)
        Me.lblMilitaryLaw.Name = "lblMilitaryLaw"
        Me.lblMilitaryLaw.Size = New System.Drawing.Size(39, 13)
        Me.lblMilitaryLaw.TabIndex = 17
        Me.lblMilitaryLaw.Text = "Military"
        '
        'lblSecLaw
        '
        Me.lblSecLaw.AutoSize = True
        Me.lblSecLaw.Location = New System.Drawing.Point(246, 83)
        Me.lblSecLaw.Name = "lblSecLaw"
        Me.lblSecLaw.Size = New System.Drawing.Size(45, 13)
        Me.lblSecLaw.TabIndex = 18
        Me.lblSecLaw.Text = "Security"
        '
        'lblJusLaw
        '
        Me.lblJusLaw.AutoSize = True
        Me.lblJusLaw.Location = New System.Drawing.Point(379, 31)
        Me.lblJusLaw.Name = "lblJusLaw"
        Me.lblJusLaw.Size = New System.Drawing.Size(40, 13)
        Me.lblJusLaw.TabIndex = 19
        Me.lblJusLaw.Text = "Justice"
        '
        'lblForLaw
        '
        Me.lblForLaw.AutoSize = True
        Me.lblForLaw.Location = New System.Drawing.Point(379, 57)
        Me.lblForLaw.Name = "lblForLaw"
        Me.lblForLaw.Size = New System.Drawing.Size(74, 13)
        Me.lblForLaw.TabIndex = 20
        Me.lblForLaw.Text = "Foreign Affairs"
        '
        'lblPeopLaw
        '
        Me.lblPeopLaw.AutoSize = True
        Me.lblPeopLaw.Location = New System.Drawing.Point(379, 83)
        Me.lblPeopLaw.Name = "lblPeopLaw"
        Me.lblPeopLaw.Size = New System.Drawing.Size(62, 13)
        Me.lblPeopLaw.TabIndex = 21
        Me.lblPeopLaw.Text = "The People"
        '
        'lblTreasLaw
        '
        Me.lblTreasLaw.AutoSize = True
        Me.lblTreasLaw.Location = New System.Drawing.Point(379, 109)
        Me.lblTreasLaw.Name = "lblTreasLaw"
        Me.lblTreasLaw.Size = New System.Drawing.Size(48, 13)
        Me.lblTreasLaw.TabIndex = 23
        Me.lblTreasLaw.Text = "Treasury"
        '
        'updwnEconLaw
        '
        Me.updwnEconLaw.DecimalPlaces = 2
        Me.updwnEconLaw.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.updwnEconLaw.Location = New System.Drawing.Point(303, 29)
        Me.updwnEconLaw.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.updwnEconLaw.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.updwnEconLaw.Name = "updwnEconLaw"
        Me.updwnEconLaw.Size = New System.Drawing.Size(50, 20)
        Me.updwnEconLaw.TabIndex = 24
        '
        'updwnSecLaw
        '
        Me.updwnSecLaw.DecimalPlaces = 2
        Me.updwnSecLaw.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.updwnSecLaw.Location = New System.Drawing.Point(303, 81)
        Me.updwnSecLaw.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.updwnSecLaw.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.updwnSecLaw.Name = "updwnSecLaw"
        Me.updwnSecLaw.Size = New System.Drawing.Size(50, 20)
        Me.updwnSecLaw.TabIndex = 25
        '
        'updwnJusLaw
        '
        Me.updwnJusLaw.DecimalPlaces = 2
        Me.updwnJusLaw.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.updwnJusLaw.Location = New System.Drawing.Point(457, 29)
        Me.updwnJusLaw.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.updwnJusLaw.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.updwnJusLaw.Name = "updwnJusLaw"
        Me.updwnJusLaw.Size = New System.Drawing.Size(50, 20)
        Me.updwnJusLaw.TabIndex = 26
        '
        'updwnForLaw
        '
        Me.updwnForLaw.DecimalPlaces = 2
        Me.updwnForLaw.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.updwnForLaw.Location = New System.Drawing.Point(457, 55)
        Me.updwnForLaw.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.updwnForLaw.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.updwnForLaw.Name = "updwnForLaw"
        Me.updwnForLaw.Size = New System.Drawing.Size(50, 20)
        Me.updwnForLaw.TabIndex = 27
        '
        'updwnPeopLaw
        '
        Me.updwnPeopLaw.DecimalPlaces = 2
        Me.updwnPeopLaw.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.updwnPeopLaw.Location = New System.Drawing.Point(457, 81)
        Me.updwnPeopLaw.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.updwnPeopLaw.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.updwnPeopLaw.Name = "updwnPeopLaw"
        Me.updwnPeopLaw.Size = New System.Drawing.Size(50, 20)
        Me.updwnPeopLaw.TabIndex = 28
        '
        'updwnTreasLaw
        '
        Me.updwnTreasLaw.DecimalPlaces = 2
        Me.updwnTreasLaw.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.updwnTreasLaw.Location = New System.Drawing.Point(457, 107)
        Me.updwnTreasLaw.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.updwnTreasLaw.Minimum = New Decimal(New Integer() {50, 0, 0, -2147483648})
        Me.updwnTreasLaw.Name = "updwnTreasLaw"
        Me.updwnTreasLaw.Size = New System.Drawing.Size(50, 20)
        Me.updwnTreasLaw.TabIndex = 29
        '
        'updwnDurationLaw
        '
        Me.updwnDurationLaw.Location = New System.Drawing.Point(94, 51)
        Me.updwnDurationLaw.Name = "updwnDurationLaw"
        Me.updwnDurationLaw.Size = New System.Drawing.Size(120, 20)
        Me.updwnDurationLaw.TabIndex = 30
        '
        'chkInEffect
        '
        Me.chkInEffect.AutoSize = True
        Me.chkInEffect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkInEffect.Location = New System.Drawing.Point(12, 77)
        Me.chkInEffect.Name = "chkInEffect"
        Me.chkInEffect.Size = New System.Drawing.Size(72, 17)
        Me.chkInEffect.TabIndex = 31
        Me.chkInEffect.Text = "In Effect?"
        Me.chkInEffect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkInEffect.UseVisualStyleBackColor = True
        '
        'chkExpired
        '
        Me.chkExpired.AutoSize = True
        Me.chkExpired.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkExpired.Location = New System.Drawing.Point(12, 100)
        Me.chkExpired.Name = "chkExpired"
        Me.chkExpired.Size = New System.Drawing.Size(67, 17)
        Me.chkExpired.TabIndex = 32
        Me.chkExpired.Text = "Expired?"
        Me.chkExpired.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkExpired.UseVisualStyleBackColor = True
        '
        'LawDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 359)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkExpired)
        Me.Controls.Add(Me.chkInEffect)
        Me.Controls.Add(Me.updwnDurationLaw)
        Me.Controls.Add(Me.updwnTreasLaw)
        Me.Controls.Add(Me.updwnPeopLaw)
        Me.Controls.Add(Me.updwnForLaw)
        Me.Controls.Add(Me.updwnJusLaw)
        Me.Controls.Add(Me.updwnSecLaw)
        Me.Controls.Add(Me.updwnEconLaw)
        Me.Controls.Add(Me.lblTreasLaw)
        Me.Controls.Add(Me.lblPeopLaw)
        Me.Controls.Add(Me.lblForLaw)
        Me.Controls.Add(Me.lblJusLaw)
        Me.Controls.Add(Me.lblSecLaw)
        Me.Controls.Add(Me.lblMilitaryLaw)
        Me.Controls.Add(Me.lblEconomyLaw)
        Me.Controls.Add(Me.updwnMilLaw)
        Me.Controls.Add(Me.txtLawDescription)
        Me.Controls.Add(Me.txtLawName)
        Me.Controls.Add(Me.lblLawDescription)
        Me.Controls.Add(Me.lblLawBudget)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblLawName)
        Me.Controls.Add(Me.btnCloseLaw)
        Me.Controls.Add(Me.btnSaveLaw)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LawDesigner"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Law Designer"
        CType(Me.updwnMilLaw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnEconLaw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnSecLaw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnJusLaw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnForLaw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnPeopLaw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnTreasLaw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnDurationLaw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaveLaw As Button
    Friend WithEvents btnCloseLaw As Button
    Friend WithEvents lblLawName As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblLawBudget As Label
    Friend WithEvents lblLawDescription As Label
    Friend WithEvents txtLawName As TextBox
    Friend WithEvents txtLawDescription As TextBox
    Friend WithEvents updwnMilLaw As NumericUpDown
    Friend WithEvents lblEconomyLaw As Label
    Friend WithEvents lblMilitaryLaw As Label
    Friend WithEvents lblSecLaw As Label
    Friend WithEvents lblJusLaw As Label
    Friend WithEvents lblForLaw As Label
    Friend WithEvents lblPeopLaw As Label
    Friend WithEvents lblTreasLaw As Label
    Friend WithEvents updwnEconLaw As NumericUpDown
    Friend WithEvents updwnSecLaw As NumericUpDown
    Friend WithEvents updwnJusLaw As NumericUpDown
    Friend WithEvents updwnForLaw As NumericUpDown
    Friend WithEvents updwnPeopLaw As NumericUpDown
    Friend WithEvents updwnTreasLaw As NumericUpDown
    Friend WithEvents updwnDurationLaw As NumericUpDown
    Friend WithEvents chkInEffect As CheckBox
    Friend WithEvents chkExpired As CheckBox
End Class
