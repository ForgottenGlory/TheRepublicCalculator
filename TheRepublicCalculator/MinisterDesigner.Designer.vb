<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MinisterDesigner
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
        Me.lblMinisterName = New System.Windows.Forms.Label()
        Me.lblMinisterGoals = New System.Windows.Forms.Label()
        Me.lblMinisterDescr = New System.Windows.Forms.Label()
        Me.txtMinisterName = New System.Windows.Forms.TextBox()
        Me.txtMinisterGoals = New System.Windows.Forms.TextBox()
        Me.txtMinisterDescr = New System.Windows.Forms.TextBox()
        Me.btnSaveMinister = New System.Windows.Forms.Button()
        Me.btnMinClose = New System.Windows.Forms.Button()
        Me.imgMinister = New System.Windows.Forms.PictureBox()
        CType(Me.imgMinister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMinisterName
        '
        Me.lblMinisterName.AutoSize = True
        Me.lblMinisterName.Location = New System.Drawing.Point(12, 9)
        Me.lblMinisterName.Name = "lblMinisterName"
        Me.lblMinisterName.Size = New System.Drawing.Size(35, 13)
        Me.lblMinisterName.TabIndex = 0
        Me.lblMinisterName.Text = "Name"
        '
        'lblMinisterGoals
        '
        Me.lblMinisterGoals.AutoSize = True
        Me.lblMinisterGoals.Location = New System.Drawing.Point(13, 33)
        Me.lblMinisterGoals.Name = "lblMinisterGoals"
        Me.lblMinisterGoals.Size = New System.Drawing.Size(34, 13)
        Me.lblMinisterGoals.TabIndex = 1
        Me.lblMinisterGoals.Text = "Goals"
        '
        'lblMinisterDescr
        '
        Me.lblMinisterDescr.AutoSize = True
        Me.lblMinisterDescr.Location = New System.Drawing.Point(12, 72)
        Me.lblMinisterDescr.Name = "lblMinisterDescr"
        Me.lblMinisterDescr.Size = New System.Drawing.Size(60, 13)
        Me.lblMinisterDescr.TabIndex = 2
        Me.lblMinisterDescr.Text = "Description"
        '
        'txtMinisterName
        '
        Me.txtMinisterName.Location = New System.Drawing.Point(57, 6)
        Me.txtMinisterName.Name = "txtMinisterName"
        Me.txtMinisterName.Size = New System.Drawing.Size(457, 20)
        Me.txtMinisterName.TabIndex = 3
        '
        'txtMinisterGoals
        '
        Me.txtMinisterGoals.Location = New System.Drawing.Point(57, 30)
        Me.txtMinisterGoals.Multiline = True
        Me.txtMinisterGoals.Name = "txtMinisterGoals"
        Me.txtMinisterGoals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMinisterGoals.Size = New System.Drawing.Size(457, 39)
        Me.txtMinisterGoals.TabIndex = 4
        '
        'txtMinisterDescr
        '
        Me.txtMinisterDescr.Location = New System.Drawing.Point(15, 89)
        Me.txtMinisterDescr.Multiline = True
        Me.txtMinisterDescr.Name = "txtMinisterDescr"
        Me.txtMinisterDescr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMinisterDescr.Size = New System.Drawing.Size(499, 91)
        Me.txtMinisterDescr.TabIndex = 5
        '
        'btnSaveMinister
        '
        Me.btnSaveMinister.Location = New System.Drawing.Point(169, 191)
        Me.btnSaveMinister.Name = "btnSaveMinister"
        Me.btnSaveMinister.Size = New System.Drawing.Size(82, 23)
        Me.btnSaveMinister.TabIndex = 6
        Me.btnSaveMinister.Text = "Save Minister"
        Me.btnSaveMinister.UseVisualStyleBackColor = True
        '
        'btnMinClose
        '
        Me.btnMinClose.Location = New System.Drawing.Point(257, 191)
        Me.btnMinClose.Name = "btnMinClose"
        Me.btnMinClose.Size = New System.Drawing.Size(75, 23)
        Me.btnMinClose.TabIndex = 7
        Me.btnMinClose.Text = "Close"
        Me.btnMinClose.UseVisualStyleBackColor = True
        '
        'imgMinister
        '
        Me.imgMinister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgMinister.Location = New System.Drawing.Point(520, 6)
        Me.imgMinister.Name = "imgMinister"
        Me.imgMinister.Size = New System.Drawing.Size(131, 174)
        Me.imgMinister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgMinister.TabIndex = 8
        Me.imgMinister.TabStop = False
        '
        'MinisterDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 226)
        Me.ControlBox = False
        Me.Controls.Add(Me.imgMinister)
        Me.Controls.Add(Me.btnMinClose)
        Me.Controls.Add(Me.btnSaveMinister)
        Me.Controls.Add(Me.txtMinisterDescr)
        Me.Controls.Add(Me.txtMinisterGoals)
        Me.Controls.Add(Me.txtMinisterName)
        Me.Controls.Add(Me.lblMinisterDescr)
        Me.Controls.Add(Me.lblMinisterGoals)
        Me.Controls.Add(Me.lblMinisterName)
        Me.Name = "MinisterDesigner"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minister Designer"
        CType(Me.imgMinister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMinisterName As Label
    Friend WithEvents lblMinisterGoals As Label
    Friend WithEvents lblMinisterDescr As Label
    Friend WithEvents txtMinisterName As TextBox
    Friend WithEvents txtMinisterGoals As TextBox
    Friend WithEvents txtMinisterDescr As TextBox
    Friend WithEvents btnSaveMinister As Button
    Friend WithEvents btnMinClose As Button
    Friend WithEvents imgMinister As PictureBox
End Class
