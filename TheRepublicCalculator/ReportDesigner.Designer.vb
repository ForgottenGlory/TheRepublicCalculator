<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportDesigner
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
        Me.txtReportName = New System.Windows.Forms.TextBox()
        Me.txtReportDescr = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSession = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.chkIsCustom = New System.Windows.Forms.CheckBox()
        Me.updwnSession = New System.Windows.Forms.NumericUpDown()
        Me.btnSaveReport = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.updwnSession, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtReportName
        '
        Me.txtReportName.Location = New System.Drawing.Point(90, 10)
        Me.txtReportName.Name = "txtReportName"
        Me.txtReportName.Size = New System.Drawing.Size(234, 20)
        Me.txtReportName.TabIndex = 1
        '
        'txtReportDescr
        '
        Me.txtReportDescr.Location = New System.Drawing.Point(16, 106)
        Me.txtReportDescr.Multiline = True
        Me.txtReportDescr.Name = "txtReportDescr"
        Me.txtReportDescr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReportDescr.Size = New System.Drawing.Size(635, 143)
        Me.txtReportDescr.TabIndex = 2
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
        Me.lblSession.Location = New System.Drawing.Point(13, 39)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(71, 13)
        Me.lblSession.TabIndex = 5
        Me.lblSession.Text = "As of Session"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(13, 90)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 6
        Me.lblDescription.Text = "Description"
        '
        'chkIsCustom
        '
        Me.chkIsCustom.AutoSize = True
        Me.chkIsCustom.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIsCustom.Location = New System.Drawing.Point(12, 64)
        Me.chkIsCustom.Name = "chkIsCustom"
        Me.chkIsCustom.Size = New System.Drawing.Size(78, 17)
        Me.chkIsCustom.TabIndex = 7
        Me.chkIsCustom.Text = "Is Custom?"
        Me.chkIsCustom.UseVisualStyleBackColor = True
        '
        'updwnSession
        '
        Me.updwnSession.Location = New System.Drawing.Point(90, 36)
        Me.updwnSession.Name = "updwnSession"
        Me.updwnSession.Size = New System.Drawing.Size(58, 20)
        Me.updwnSession.TabIndex = 8
        '
        'btnSaveReport
        '
        Me.btnSaveReport.Location = New System.Drawing.Point(235, 254)
        Me.btnSaveReport.Name = "btnSaveReport"
        Me.btnSaveReport.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveReport.TabIndex = 9
        Me.btnSaveReport.Text = "Save Report"
        Me.btnSaveReport.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(316, 255)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ReportDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 289)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSaveReport)
        Me.Controls.Add(Me.updwnSession)
        Me.Controls.Add(Me.chkIsCustom)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblSession)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtReportDescr)
        Me.Controls.Add(Me.txtReportName)
        Me.Name = "ReportDesigner"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Report Designer"
        CType(Me.updwnSession, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReportName As TextBox
    Friend WithEvents txtReportDescr As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblSession As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents chkIsCustom As CheckBox
    Friend WithEvents updwnSession As NumericUpDown
    Friend WithEvents btnSaveReport As Button
    Friend WithEvents btnClose As Button
End Class
