<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventDesigner
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
        Me.txtCrisisName = New System.Windows.Forms.TextBox()
        Me.txtCrisisDescr = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSession = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnGenEvent = New System.Windows.Forms.Button()
        Me.btnSaveEvent = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtSession = New System.Windows.Forms.NumericUpDown()
        Me.chkIsCrisis = New System.Windows.Forms.CheckBox()
        CType(Me.txtSession, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCrisisName
        '
        Me.txtCrisisName.Location = New System.Drawing.Point(116, 10)
        Me.txtCrisisName.Name = "txtCrisisName"
        Me.txtCrisisName.Size = New System.Drawing.Size(209, 20)
        Me.txtCrisisName.TabIndex = 0
        '
        'txtCrisisDescr
        '
        Me.txtCrisisDescr.Location = New System.Drawing.Point(16, 104)
        Me.txtCrisisDescr.Multiline = True
        Me.txtCrisisDescr.Name = "txtCrisisDescr"
        Me.txtCrisisDescr.Size = New System.Drawing.Size(635, 145)
        Me.txtCrisisDescr.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'lblSession
        '
        Me.lblSession.AutoSize = True
        Me.lblSession.Location = New System.Drawing.Point(12, 37)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(98, 13)
        Me.lblSession.TabIndex = 5
        Me.lblSession.Text = "Session Introduced"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(12, 88)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 7
        Me.lblDescription.Text = "Description"
        '
        'btnGenEvent
        '
        Me.btnGenEvent.Location = New System.Drawing.Point(561, 7)
        Me.btnGenEvent.Name = "btnGenEvent"
        Me.btnGenEvent.Size = New System.Drawing.Size(90, 23)
        Me.btnGenEvent.TabIndex = 8
        Me.btnGenEvent.Text = "Generate Event"
        Me.btnGenEvent.UseVisualStyleBackColor = True
        '
        'btnSaveEvent
        '
        Me.btnSaveEvent.Location = New System.Drawing.Point(250, 261)
        Me.btnSaveEvent.Name = "btnSaveEvent"
        Me.btnSaveEvent.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveEvent.TabIndex = 9
        Me.btnSaveEvent.Text = "Save Event"
        Me.btnSaveEvent.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(331, 261)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtSession
        '
        Me.txtSession.Location = New System.Drawing.Point(116, 35)
        Me.txtSession.Name = "txtSession"
        Me.txtSession.Size = New System.Drawing.Size(120, 20)
        Me.txtSession.TabIndex = 11
        '
        'chkIsCrisis
        '
        Me.chkIsCrisis.AutoSize = True
        Me.chkIsCrisis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIsCrisis.Location = New System.Drawing.Point(12, 63)
        Me.chkIsCrisis.Name = "chkIsCrisis"
        Me.chkIsCrisis.Size = New System.Drawing.Size(67, 17)
        Me.chkIsCrisis.TabIndex = 12
        Me.chkIsCrisis.Text = "Is Crisis?"
        Me.chkIsCrisis.UseVisualStyleBackColor = True
        '
        'EventDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 296)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkIsCrisis)
        Me.Controls.Add(Me.txtSession)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSaveEvent)
        Me.Controls.Add(Me.btnGenEvent)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblSession)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtCrisisDescr)
        Me.Controls.Add(Me.txtCrisisName)
        Me.Name = "EventDesigner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Event Designer"
        CType(Me.txtSession, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCrisisName As TextBox
    Friend WithEvents txtCrisisDescr As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblSession As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnGenEvent As Button
    Friend WithEvents btnSaveEvent As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtSession As NumericUpDown
    Friend WithEvents chkIsCrisis As CheckBox
End Class
