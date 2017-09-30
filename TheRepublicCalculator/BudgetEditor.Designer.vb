<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BudgetEditor
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
        Me.lblEconomy = New System.Windows.Forms.Label()
        Me.lblMilitary = New System.Windows.Forms.Label()
        Me.lblSecurity = New System.Windows.Forms.Label()
        Me.lblJustice = New System.Windows.Forms.Label()
        Me.lblForeign = New System.Windows.Forms.Label()
        Me.lblPeople = New System.Windows.Forms.Label()
        Me.lblTreasury = New System.Windows.Forms.Label()
        Me.updwnEcon = New System.Windows.Forms.NumericUpDown()
        Me.updwnMil = New System.Windows.Forms.NumericUpDown()
        Me.updwnSec = New System.Windows.Forms.NumericUpDown()
        Me.updwnJus = New System.Windows.Forms.NumericUpDown()
        Me.updwnFor = New System.Windows.Forms.NumericUpDown()
        Me.updwnPeo = New System.Windows.Forms.NumericUpDown()
        Me.updwnTreas = New System.Windows.Forms.NumericUpDown()
        Me.lblNewTotal = New System.Windows.Forms.Label()
        Me.lblTotNum = New System.Windows.Forms.Label()
        Me.btnSaveBudget = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.updwnEcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnMil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnJus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnFor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnPeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnTreas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEconomy
        '
        Me.lblEconomy.AutoSize = True
        Me.lblEconomy.Location = New System.Drawing.Point(12, 9)
        Me.lblEconomy.Name = "lblEconomy"
        Me.lblEconomy.Size = New System.Drawing.Size(51, 13)
        Me.lblEconomy.TabIndex = 0
        Me.lblEconomy.Text = "Economy"
        '
        'lblMilitary
        '
        Me.lblMilitary.AutoSize = True
        Me.lblMilitary.Location = New System.Drawing.Point(12, 38)
        Me.lblMilitary.Name = "lblMilitary"
        Me.lblMilitary.Size = New System.Drawing.Size(39, 13)
        Me.lblMilitary.TabIndex = 1
        Me.lblMilitary.Text = "Military"
        '
        'lblSecurity
        '
        Me.lblSecurity.AutoSize = True
        Me.lblSecurity.Location = New System.Drawing.Point(12, 67)
        Me.lblSecurity.Name = "lblSecurity"
        Me.lblSecurity.Size = New System.Drawing.Size(45, 13)
        Me.lblSecurity.TabIndex = 2
        Me.lblSecurity.Text = "Security"
        '
        'lblJustice
        '
        Me.lblJustice.AutoSize = True
        Me.lblJustice.Location = New System.Drawing.Point(12, 96)
        Me.lblJustice.Name = "lblJustice"
        Me.lblJustice.Size = New System.Drawing.Size(40, 13)
        Me.lblJustice.TabIndex = 3
        Me.lblJustice.Text = "Justice"
        '
        'lblForeign
        '
        Me.lblForeign.AutoSize = True
        Me.lblForeign.Location = New System.Drawing.Point(12, 125)
        Me.lblForeign.Name = "lblForeign"
        Me.lblForeign.Size = New System.Drawing.Size(42, 13)
        Me.lblForeign.TabIndex = 4
        Me.lblForeign.Text = "Foreign"
        '
        'lblPeople
        '
        Me.lblPeople.AutoSize = True
        Me.lblPeople.Location = New System.Drawing.Point(12, 154)
        Me.lblPeople.Name = "lblPeople"
        Me.lblPeople.Size = New System.Drawing.Size(62, 13)
        Me.lblPeople.TabIndex = 5
        Me.lblPeople.Text = "The People"
        '
        'lblTreasury
        '
        Me.lblTreasury.AutoSize = True
        Me.lblTreasury.Location = New System.Drawing.Point(12, 183)
        Me.lblTreasury.Name = "lblTreasury"
        Me.lblTreasury.Size = New System.Drawing.Size(48, 13)
        Me.lblTreasury.TabIndex = 6
        Me.lblTreasury.Text = "Treasury"
        '
        'updwnEcon
        '
        Me.updwnEcon.DecimalPlaces = 2
        Me.updwnEcon.Location = New System.Drawing.Point(80, 7)
        Me.updwnEcon.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.updwnEcon.Name = "updwnEcon"
        Me.updwnEcon.Size = New System.Drawing.Size(120, 20)
        Me.updwnEcon.TabIndex = 7
        '
        'updwnMil
        '
        Me.updwnMil.DecimalPlaces = 2
        Me.updwnMil.Location = New System.Drawing.Point(80, 36)
        Me.updwnMil.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.updwnMil.Name = "updwnMil"
        Me.updwnMil.Size = New System.Drawing.Size(120, 20)
        Me.updwnMil.TabIndex = 8
        '
        'updwnSec
        '
        Me.updwnSec.DecimalPlaces = 2
        Me.updwnSec.Location = New System.Drawing.Point(80, 65)
        Me.updwnSec.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.updwnSec.Name = "updwnSec"
        Me.updwnSec.Size = New System.Drawing.Size(120, 20)
        Me.updwnSec.TabIndex = 9
        '
        'updwnJus
        '
        Me.updwnJus.DecimalPlaces = 2
        Me.updwnJus.Location = New System.Drawing.Point(80, 94)
        Me.updwnJus.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.updwnJus.Name = "updwnJus"
        Me.updwnJus.Size = New System.Drawing.Size(120, 20)
        Me.updwnJus.TabIndex = 10
        '
        'updwnFor
        '
        Me.updwnFor.DecimalPlaces = 2
        Me.updwnFor.Location = New System.Drawing.Point(80, 123)
        Me.updwnFor.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.updwnFor.Name = "updwnFor"
        Me.updwnFor.Size = New System.Drawing.Size(120, 20)
        Me.updwnFor.TabIndex = 11
        '
        'updwnPeo
        '
        Me.updwnPeo.DecimalPlaces = 2
        Me.updwnPeo.Location = New System.Drawing.Point(80, 152)
        Me.updwnPeo.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.updwnPeo.Name = "updwnPeo"
        Me.updwnPeo.Size = New System.Drawing.Size(120, 20)
        Me.updwnPeo.TabIndex = 12
        '
        'updwnTreas
        '
        Me.updwnTreas.DecimalPlaces = 2
        Me.updwnTreas.Location = New System.Drawing.Point(80, 181)
        Me.updwnTreas.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.updwnTreas.Name = "updwnTreas"
        Me.updwnTreas.Size = New System.Drawing.Size(120, 20)
        Me.updwnTreas.TabIndex = 13
        '
        'lblNewTotal
        '
        Me.lblNewTotal.AutoSize = True
        Me.lblNewTotal.Location = New System.Drawing.Point(12, 218)
        Me.lblNewTotal.Name = "lblNewTotal"
        Me.lblNewTotal.Size = New System.Drawing.Size(59, 13)
        Me.lblNewTotal.TabIndex = 14
        Me.lblNewTotal.Text = "New Total:"
        '
        'lblTotNum
        '
        Me.lblTotNum.AutoSize = True
        Me.lblTotNum.Location = New System.Drawing.Point(80, 218)
        Me.lblTotNum.Name = "lblTotNum"
        Me.lblTotNum.Size = New System.Drawing.Size(25, 13)
        Me.lblTotNum.TabIndex = 15
        Me.lblTotNum.Text = "000"
        '
        'btnSaveBudget
        '
        Me.btnSaveBudget.Location = New System.Drawing.Point(28, 252)
        Me.btnSaveBudget.Name = "btnSaveBudget"
        Me.btnSaveBudget.Size = New System.Drawing.Size(90, 23)
        Me.btnSaveBudget.TabIndex = 16
        Me.btnSaveBudget.Text = "Save Budget"
        Me.btnSaveBudget.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(124, 252)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BudgetEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveBudget)
        Me.Controls.Add(Me.lblTotNum)
        Me.Controls.Add(Me.lblNewTotal)
        Me.Controls.Add(Me.updwnTreas)
        Me.Controls.Add(Me.updwnPeo)
        Me.Controls.Add(Me.updwnFor)
        Me.Controls.Add(Me.updwnJus)
        Me.Controls.Add(Me.updwnSec)
        Me.Controls.Add(Me.updwnMil)
        Me.Controls.Add(Me.updwnEcon)
        Me.Controls.Add(Me.lblTreasury)
        Me.Controls.Add(Me.lblPeople)
        Me.Controls.Add(Me.lblForeign)
        Me.Controls.Add(Me.lblJustice)
        Me.Controls.Add(Me.lblSecurity)
        Me.Controls.Add(Me.lblMilitary)
        Me.Controls.Add(Me.lblEconomy)
        Me.Name = "BudgetEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Budget Editor"
        CType(Me.updwnEcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnMil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnJus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnFor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnPeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnTreas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEconomy As Label
    Friend WithEvents lblMilitary As Label
    Friend WithEvents lblSecurity As Label
    Friend WithEvents lblJustice As Label
    Friend WithEvents lblForeign As Label
    Friend WithEvents lblPeople As Label
    Friend WithEvents lblTreasury As Label
    Friend WithEvents updwnEcon As NumericUpDown
    Friend WithEvents updwnMil As NumericUpDown
    Friend WithEvents updwnSec As NumericUpDown
    Friend WithEvents updwnJus As NumericUpDown
    Friend WithEvents updwnFor As NumericUpDown
    Friend WithEvents updwnPeo As NumericUpDown
    Friend WithEvents updwnTreas As NumericUpDown
    Friend WithEvents lblNewTotal As Label
    Friend WithEvents lblTotNum As Label
    Friend WithEvents btnSaveBudget As Button
    Friend WithEvents btnCancel As Button
End Class
