<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActionDesigner
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
        Me.btnSaveAction = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.chkExpired = New System.Windows.Forms.CheckBox()
        Me.txtActionName = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSaveAction
        '
        Me.btnSaveAction.Location = New System.Drawing.Point(253, 226)
        Me.btnSaveAction.Name = "btnSaveAction"
        Me.btnSaveAction.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveAction.TabIndex = 0
        Me.btnSaveAction.Text = "Save Action"
        Me.btnSaveAction.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(334, 226)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(12, 65)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "Description"
        '
        'chkExpired
        '
        Me.chkExpired.AutoSize = True
        Me.chkExpired.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkExpired.Location = New System.Drawing.Point(11, 37)
        Me.chkExpired.Name = "chkExpired"
        Me.chkExpired.Size = New System.Drawing.Size(67, 17)
        Me.chkExpired.TabIndex = 5
        Me.chkExpired.Text = "Expired?"
        Me.chkExpired.UseVisualStyleBackColor = True
        '
        'txtActionName
        '
        Me.txtActionName.Location = New System.Drawing.Point(62, 6)
        Me.txtActionName.Name = "txtActionName"
        Me.txtActionName.Size = New System.Drawing.Size(282, 20)
        Me.txtActionName.TabIndex = 6
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(12, 82)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(639, 138)
        Me.txtDescription.TabIndex = 7
        '
        'ActionDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtActionName)
        Me.Controls.Add(Me.chkExpired)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSaveAction)
        Me.Name = "ActionDesigner"
        Me.Text = "Action Designer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaveAction As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents chkExpired As CheckBox
    Friend WithEvents txtActionName As TextBox
    Friend WithEvents txtDescription As TextBox
End Class
