<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class assumptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(assumptions))
        Me.cbxVacuum = New System.Windows.Forms.CheckBox()
        Me.cbxFloor = New System.Windows.Forms.CheckBox()
        Me.cbxMassDecay = New System.Windows.Forms.CheckBox()
        Me.cbxFiniteFuel = New System.Windows.Forms.CheckBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.cbxAirThinning = New System.Windows.Forms.CheckBox()
        Me.cbxGravityThinning = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxVacuum
        '
        Me.cbxVacuum.AutoSize = True
        Me.cbxVacuum.Location = New System.Drawing.Point(13, 13)
        Me.cbxVacuum.Name = "cbxVacuum"
        Me.cbxVacuum.Size = New System.Drawing.Size(199, 17)
        Me.cbxVacuum.TabIndex = 0
        Me.cbxVacuum.Text = "The launch takes place in a vacuum"
        Me.cbxVacuum.UseVisualStyleBackColor = True
        '
        'cbxFloor
        '
        Me.cbxFloor.AutoSize = True
        Me.cbxFloor.Location = New System.Drawing.Point(13, 37)
        Me.cbxFloor.Name = "cbxFloor"
        Me.cbxFloor.Size = New System.Drawing.Size(96, 17)
        Me.cbxFloor.TabIndex = 1
        Me.cbxFloor.Text = "There is a floor"
        Me.cbxFloor.UseVisualStyleBackColor = True
        '
        'cbxMassDecay
        '
        Me.cbxMassDecay.AutoSize = True
        Me.cbxMassDecay.Location = New System.Drawing.Point(13, 61)
        Me.cbxMassDecay.Name = "cbxMassDecay"
        Me.cbxMassDecay.Size = New System.Drawing.Size(263, 17)
        Me.cbxMassDecay.TabIndex = 2
        Me.cbxMassDecay.Text = "The rocket burns fuel when applying a thrust force"
        Me.cbxMassDecay.UseVisualStyleBackColor = True
        '
        'cbxFiniteFuel
        '
        Me.cbxFiniteFuel.AutoSize = True
        Me.cbxFiniteFuel.Location = New System.Drawing.Point(13, 85)
        Me.cbxFiniteFuel.Name = "cbxFiniteFuel"
        Me.cbxFiniteFuel.Size = New System.Drawing.Size(143, 17)
        Me.cbxFiniteFuel.TabIndex = 3
        Me.cbxFiniteFuel.Text = "The rocket has finite fuel"
        Me.cbxFiniteFuel.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(197, 227)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 4
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'cbxAirThinning
        '
        Me.cbxAirThinning.AutoSize = True
        Me.cbxAirThinning.Location = New System.Drawing.Point(13, 109)
        Me.cbxAirThinning.Name = "cbxAirThinning"
        Me.cbxAirThinning.Size = New System.Drawing.Size(227, 17)
        Me.cbxAirThinning.TabIndex = 5
        Me.cbxAirThinning.Text = "The air density lowers as altitude increases"
        Me.cbxAirThinning.UseVisualStyleBackColor = True
        '
        'cbxGravityThinning
        '
        Me.cbxGravityThinning.AutoSize = True
        Me.cbxGravityThinning.Location = New System.Drawing.Point(12, 132)
        Me.cbxGravityThinning.Name = "cbxGravityThinning"
        Me.cbxGravityThinning.Size = New System.Drawing.Size(180, 30)
        Me.cbxGravityThinning.TabIndex = 6
        Me.cbxGravityThinning.Text = "Acceleration due to gravity lower" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "as altitude increases"
        Me.cbxGravityThinning.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(116, 227)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'assumptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cbxGravityThinning)
        Me.Controls.Add(Me.cbxAirThinning)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.cbxFiniteFuel)
        Me.Controls.Add(Me.cbxMassDecay)
        Me.Controls.Add(Me.cbxFloor)
        Me.Controls.Add(Me.cbxVacuum)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "assumptions"
        Me.Text = "Assumptions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxVacuum As System.Windows.Forms.CheckBox
    Friend WithEvents cbxFloor As System.Windows.Forms.CheckBox
    Friend WithEvents cbxMassDecay As System.Windows.Forms.CheckBox
    Friend WithEvents cbxFiniteFuel As System.Windows.Forms.CheckBox
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents cbxAirThinning As System.Windows.Forms.CheckBox
    Friend WithEvents cbxGravityThinning As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
