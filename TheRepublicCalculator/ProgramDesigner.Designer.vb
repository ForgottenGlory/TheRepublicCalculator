<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgramDesigner
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.chkExpired = New System.Windows.Forms.CheckBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtProgramName = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnSaveProgram = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'chkExpired
        '
        Me.chkExpired.AutoSize = True
        Me.chkExpired.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkExpired.Location = New System.Drawing.Point(12, 39)
        Me.chkExpired.Name = "chkExpired"
        Me.chkExpired.Size = New System.Drawing.Size(67, 17)
        Me.chkExpired.TabIndex = 1
        Me.chkExpired.Text = "Expired?"
        Me.chkExpired.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(12, 68)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "Description"
        '
        'txtProgramName
        '
        Me.txtProgramName.Location = New System.Drawing.Point(70, 6)
        Me.txtProgramName.Name = "txtProgramName"
        Me.txtProgramName.Size = New System.Drawing.Size(262, 20)
        Me.txtProgramName.TabIndex = 3
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(15, 84)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(636, 136)
        Me.txtDescription.TabIndex = 4
        '
        'btnSaveProgram
        '
        Me.btnSaveProgram.Location = New System.Drawing.Point(250, 226)
        Me.btnSaveProgram.Name = "btnSaveProgram"
        Me.btnSaveProgram.Size = New System.Drawing.Size(82, 23)
        Me.btnSaveProgram.TabIndex = 5
        Me.btnSaveProgram.Text = "Save Program"
        Me.btnSaveProgram.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(338, 226)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ProgramDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSaveProgram)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtProgramName)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.chkExpired)
        Me.Controls.Add(Me.lblName)
        Me.Name = "ProgramDesigner"
        Me.Text = "Program Designer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents chkExpired As CheckBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtProgramName As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnSaveProgram As Button
    Friend WithEvents btnClose As Button
End Class
