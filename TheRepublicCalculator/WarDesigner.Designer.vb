<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WarDesigner
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
        Me.lblWarName = New System.Windows.Forms.Label()
        Me.lblAgg = New System.Windows.Forms.Label()
        Me.lblDefender = New System.Windows.Forms.Label()
        Me.drpdwnAgg = New System.Windows.Forms.ComboBox()
        Me.drpdwnDef = New System.Windows.Forms.ComboBox()
        Me.txtWarName = New System.Windows.Forms.TextBox()
        Me.lblAggScore = New System.Windows.Forms.Label()
        Me.lblDefScore = New System.Windows.Forms.Label()
        Me.chkAggAll = New System.Windows.Forms.CheckBox()
        Me.chkDefAllies = New System.Windows.Forms.CheckBox()
        Me.lblAggTot = New System.Windows.Forms.Label()
        Me.lblDefTot = New System.Windows.Forms.Label()
        Me.lblAggWins = New System.Windows.Forms.Label()
        Me.lblDefWins = New System.Windows.Forms.Label()
        Me.updwnAggWins = New System.Windows.Forms.NumericUpDown()
        Me.updwnDefWins = New System.Windows.Forms.NumericUpDown()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtWarDescr = New System.Windows.Forms.TextBox()
        Me.btnSaveWar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.updwnAggWins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnDefWins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWarName
        '
        Me.lblWarName.AutoSize = True
        Me.lblWarName.Location = New System.Drawing.Point(13, 13)
        Me.lblWarName.Name = "lblWarName"
        Me.lblWarName.Size = New System.Drawing.Size(35, 13)
        Me.lblWarName.TabIndex = 0
        Me.lblWarName.Text = "Name"
        '
        'lblAgg
        '
        Me.lblAgg.AutoSize = True
        Me.lblAgg.Location = New System.Drawing.Point(12, 48)
        Me.lblAgg.Name = "lblAgg"
        Me.lblAgg.Size = New System.Drawing.Size(54, 13)
        Me.lblAgg.TabIndex = 1
        Me.lblAgg.Text = "Aggressor"
        '
        'lblDefender
        '
        Me.lblDefender.AutoSize = True
        Me.lblDefender.Location = New System.Drawing.Point(12, 79)
        Me.lblDefender.Name = "lblDefender"
        Me.lblDefender.Size = New System.Drawing.Size(51, 13)
        Me.lblDefender.TabIndex = 2
        Me.lblDefender.Text = "Defender"
        '
        'drpdwnAgg
        '
        Me.drpdwnAgg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpdwnAgg.FormattingEnabled = True
        Me.drpdwnAgg.Location = New System.Drawing.Point(105, 45)
        Me.drpdwnAgg.Name = "drpdwnAgg"
        Me.drpdwnAgg.Size = New System.Drawing.Size(121, 21)
        Me.drpdwnAgg.TabIndex = 3
        '
        'drpdwnDef
        '
        Me.drpdwnDef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpdwnDef.FormattingEnabled = True
        Me.drpdwnDef.Location = New System.Drawing.Point(105, 76)
        Me.drpdwnDef.Name = "drpdwnDef"
        Me.drpdwnDef.Size = New System.Drawing.Size(121, 21)
        Me.drpdwnDef.TabIndex = 4
        '
        'txtWarName
        '
        Me.txtWarName.Location = New System.Drawing.Point(105, 13)
        Me.txtWarName.Name = "txtWarName"
        Me.txtWarName.Size = New System.Drawing.Size(222, 20)
        Me.txtWarName.TabIndex = 5
        '
        'lblAggScore
        '
        Me.lblAggScore.AutoSize = True
        Me.lblAggScore.Location = New System.Drawing.Point(242, 48)
        Me.lblAggScore.Name = "lblAggScore"
        Me.lblAggScore.Size = New System.Drawing.Size(88, 13)
        Me.lblAggScore.TabIndex = 6
        Me.lblAggScore.Text = "Aggressor Score:"
        '
        'lblDefScore
        '
        Me.lblDefScore.AutoSize = True
        Me.lblDefScore.Location = New System.Drawing.Point(242, 79)
        Me.lblDefScore.Name = "lblDefScore"
        Me.lblDefScore.Size = New System.Drawing.Size(85, 13)
        Me.lblDefScore.TabIndex = 7
        Me.lblDefScore.Text = "Defender Score:"
        '
        'chkAggAll
        '
        Me.chkAggAll.AutoSize = True
        Me.chkAggAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAggAll.Location = New System.Drawing.Point(410, 47)
        Me.chkAggAll.Name = "chkAggAll"
        Me.chkAggAll.Size = New System.Drawing.Size(88, 17)
        Me.chkAggAll.TabIndex = 8
        Me.chkAggAll.Text = "Allies Called?"
        Me.chkAggAll.UseVisualStyleBackColor = True
        '
        'chkDefAllies
        '
        Me.chkDefAllies.AutoSize = True
        Me.chkDefAllies.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDefAllies.Location = New System.Drawing.Point(410, 78)
        Me.chkDefAllies.Name = "chkDefAllies"
        Me.chkDefAllies.Size = New System.Drawing.Size(88, 17)
        Me.chkDefAllies.TabIndex = 9
        Me.chkDefAllies.Text = "Allies Called?"
        Me.chkDefAllies.UseVisualStyleBackColor = True
        '
        'lblAggTot
        '
        Me.lblAggTot.AutoSize = True
        Me.lblAggTot.Location = New System.Drawing.Point(336, 48)
        Me.lblAggTot.Name = "lblAggTot"
        Me.lblAggTot.Size = New System.Drawing.Size(25, 13)
        Me.lblAggTot.TabIndex = 10
        Me.lblAggTot.Text = "000"
        '
        'lblDefTot
        '
        Me.lblDefTot.AutoSize = True
        Me.lblDefTot.Location = New System.Drawing.Point(336, 79)
        Me.lblDefTot.Name = "lblDefTot"
        Me.lblDefTot.Size = New System.Drawing.Size(25, 13)
        Me.lblDefTot.TabIndex = 11
        Me.lblDefTot.Text = "000"
        '
        'lblAggWins
        '
        Me.lblAggWins.AutoSize = True
        Me.lblAggWins.Location = New System.Drawing.Point(529, 48)
        Me.lblAggWins.Name = "lblAggWins"
        Me.lblAggWins.Size = New System.Drawing.Size(31, 13)
        Me.lblAggWins.TabIndex = 12
        Me.lblAggWins.Text = "Wins"
        '
        'lblDefWins
        '
        Me.lblDefWins.AutoSize = True
        Me.lblDefWins.Location = New System.Drawing.Point(529, 79)
        Me.lblDefWins.Name = "lblDefWins"
        Me.lblDefWins.Size = New System.Drawing.Size(31, 13)
        Me.lblDefWins.TabIndex = 13
        Me.lblDefWins.Text = "Wins"
        '
        'updwnAggWins
        '
        Me.updwnAggWins.Location = New System.Drawing.Point(566, 46)
        Me.updwnAggWins.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.updwnAggWins.Name = "updwnAggWins"
        Me.updwnAggWins.Size = New System.Drawing.Size(85, 20)
        Me.updwnAggWins.TabIndex = 14
        '
        'updwnDefWins
        '
        Me.updwnDefWins.Location = New System.Drawing.Point(566, 77)
        Me.updwnDefWins.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.updwnDefWins.Name = "updwnDefWins"
        Me.updwnDefWins.Size = New System.Drawing.Size(85, 20)
        Me.updwnDefWins.TabIndex = 15
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(13, 110)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 17
        Me.lblDescription.Text = "Description"
        '
        'txtWarDescr
        '
        Me.txtWarDescr.Location = New System.Drawing.Point(16, 126)
        Me.txtWarDescr.Multiline = True
        Me.txtWarDescr.Name = "txtWarDescr"
        Me.txtWarDescr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWarDescr.Size = New System.Drawing.Size(635, 123)
        Me.txtWarDescr.TabIndex = 18
        '
        'btnSaveWar
        '
        Me.btnSaveWar.Location = New System.Drawing.Point(253, 255)
        Me.btnSaveWar.Name = "btnSaveWar"
        Me.btnSaveWar.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveWar.TabIndex = 19
        Me.btnSaveWar.Text = "Save War"
        Me.btnSaveWar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(334, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'WarDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSaveWar)
        Me.Controls.Add(Me.txtWarDescr)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.updwnDefWins)
        Me.Controls.Add(Me.updwnAggWins)
        Me.Controls.Add(Me.lblDefWins)
        Me.Controls.Add(Me.lblAggWins)
        Me.Controls.Add(Me.lblDefTot)
        Me.Controls.Add(Me.lblAggTot)
        Me.Controls.Add(Me.chkDefAllies)
        Me.Controls.Add(Me.chkAggAll)
        Me.Controls.Add(Me.lblDefScore)
        Me.Controls.Add(Me.lblAggScore)
        Me.Controls.Add(Me.txtWarName)
        Me.Controls.Add(Me.drpdwnDef)
        Me.Controls.Add(Me.drpdwnAgg)
        Me.Controls.Add(Me.lblDefender)
        Me.Controls.Add(Me.lblAgg)
        Me.Controls.Add(Me.lblWarName)
        Me.Name = "WarDesigner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "War Designer"
        CType(Me.updwnAggWins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnDefWins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWarName As Label
    Friend WithEvents lblAgg As Label
    Friend WithEvents lblDefender As Label
    Friend WithEvents drpdwnAgg As ComboBox
    Friend WithEvents drpdwnDef As ComboBox
    Friend WithEvents txtWarName As TextBox
    Friend WithEvents lblAggScore As Label
    Friend WithEvents lblDefScore As Label
    Friend WithEvents chkAggAll As CheckBox
    Friend WithEvents chkDefAllies As CheckBox
    Friend WithEvents lblAggTot As Label
    Friend WithEvents lblDefTot As Label
    Friend WithEvents lblAggWins As Label
    Friend WithEvents lblDefWins As Label
    Friend WithEvents updwnAggWins As NumericUpDown
    Friend WithEvents updwnDefWins As NumericUpDown
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtWarDescr As TextBox
    Friend WithEvents btnSaveWar As Button
    Friend WithEvents Button2 As Button
End Class
