<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FactionDesigner
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
        Me.updwnPercent = New System.Windows.Forms.NumericUpDown()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtFactionDescr = New System.Windows.Forms.TextBox()
        Me.txtFactionName = New System.Windows.Forms.TextBox()
        Me.btnSaveFaction = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.updwnHap = New System.Windows.Forms.NumericUpDown()
        Me.lblHap = New System.Windows.Forms.Label()
        CType(Me.updwnPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnHap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'updwnPercent
        '
        Me.updwnPercent.DecimalPlaces = 2
        Me.updwnPercent.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.updwnPercent.Location = New System.Drawing.Point(63, 33)
        Me.updwnPercent.Name = "updwnPercent"
        Me.updwnPercent.Size = New System.Drawing.Size(120, 20)
        Me.updwnPercent.TabIndex = 17
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(8, 56)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 16
        Me.lblDescription.Text = "Description"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Location = New System.Drawing.Point(8, 35)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(49, 13)
        Me.lblPercent.TabIndex = 15
        Me.lblPercent.Text = "% of Pop"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(9, 11)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "Name"
        '
        'txtFactionDescr
        '
        Me.txtFactionDescr.Location = New System.Drawing.Point(11, 72)
        Me.txtFactionDescr.Multiline = True
        Me.txtFactionDescr.Name = "txtFactionDescr"
        Me.txtFactionDescr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFactionDescr.Size = New System.Drawing.Size(635, 145)
        Me.txtFactionDescr.TabIndex = 13
        '
        'txtFactionName
        '
        Me.txtFactionName.Location = New System.Drawing.Point(63, 8)
        Me.txtFactionName.Name = "txtFactionName"
        Me.txtFactionName.Size = New System.Drawing.Size(209, 20)
        Me.txtFactionName.TabIndex = 12
        '
        'btnSaveFaction
        '
        Me.btnSaveFaction.Location = New System.Drawing.Point(253, 223)
        Me.btnSaveFaction.Name = "btnSaveFaction"
        Me.btnSaveFaction.Size = New System.Drawing.Size(80, 23)
        Me.btnSaveFaction.TabIndex = 18
        Me.btnSaveFaction.Text = "Save Faction"
        Me.btnSaveFaction.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(339, 223)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'updwnHap
        '
        Me.updwnHap.DecimalPlaces = 2
        Me.updwnHap.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.updwnHap.Location = New System.Drawing.Point(307, 33)
        Me.updwnHap.Name = "updwnHap"
        Me.updwnHap.Size = New System.Drawing.Size(120, 20)
        Me.updwnHap.TabIndex = 20
        '
        'lblHap
        '
        Me.lblHap.AutoSize = True
        Me.lblHap.Location = New System.Drawing.Point(206, 35)
        Me.lblHap.Name = "lblHap"
        Me.lblHap.Size = New System.Drawing.Size(95, 13)
        Me.lblHap.TabIndex = 21
        Me.lblHap.Text = "Faction Happiness"
        '
        'FactionDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblHap)
        Me.Controls.Add(Me.updwnHap)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSaveFaction)
        Me.Controls.Add(Me.updwnPercent)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtFactionDescr)
        Me.Controls.Add(Me.txtFactionName)
        Me.Name = "FactionDesigner"
        Me.Text = "Faction Designer"
        CType(Me.updwnPercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnHap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents updwnPercent As NumericUpDown
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtFactionDescr As TextBox
    Friend WithEvents txtFactionName As TextBox
    Friend WithEvents btnSaveFaction As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents updwnHap As NumericUpDown
    Friend WithEvents lblHap As Label
End Class
