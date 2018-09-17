<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class saving
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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.cbxTime = New System.Windows.Forms.CheckBox()
        Me.cbxMass = New System.Windows.Forms.CheckBox()
        Me.cbxDispX = New System.Windows.Forms.CheckBox()
        Me.cbxDispY = New System.Windows.Forms.CheckBox()
        Me.cbxDispM = New System.Windows.Forms.CheckBox()
        Me.cbxVeloX = New System.Windows.Forms.CheckBox()
        Me.cbxVeloY = New System.Windows.Forms.CheckBox()
        Me.cbxVeloM = New System.Windows.Forms.CheckBox()
        Me.cbxAccX = New System.Windows.Forms.CheckBox()
        Me.cbxAccM = New System.Windows.Forms.CheckBox()
        Me.cbxAccY = New System.Windows.Forms.CheckBox()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 9)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(222, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Which constants would you like to be saved?"
        '
        'cbxTime
        '
        Me.cbxTime.AutoSize = True
        Me.cbxTime.Location = New System.Drawing.Point(15, 40)
        Me.cbxTime.Name = "cbxTime"
        Me.cbxTime.Size = New System.Drawing.Size(49, 17)
        Me.cbxTime.TabIndex = 1
        Me.cbxTime.Text = "Time"
        Me.cbxTime.UseVisualStyleBackColor = True
        '
        'cbxMass
        '
        Me.cbxMass.AutoSize = True
        Me.cbxMass.Location = New System.Drawing.Point(15, 63)
        Me.cbxMass.Name = "cbxMass"
        Me.cbxMass.Size = New System.Drawing.Size(51, 17)
        Me.cbxMass.TabIndex = 2
        Me.cbxMass.Text = "Mass"
        Me.cbxMass.UseVisualStyleBackColor = True
        '
        'cbxDispX
        '
        Me.cbxDispX.AutoSize = True
        Me.cbxDispX.Location = New System.Drawing.Point(15, 86)
        Me.cbxDispX.Name = "cbxDispX"
        Me.cbxDispX.Size = New System.Drawing.Size(156, 17)
        Me.cbxDispX.TabIndex = 3
        Me.cbxDispX.Text = "Displacement X component"
        Me.cbxDispX.UseVisualStyleBackColor = True
        '
        'cbxDispY
        '
        Me.cbxDispY.AutoSize = True
        Me.cbxDispY.Location = New System.Drawing.Point(15, 109)
        Me.cbxDispY.Name = "cbxDispY"
        Me.cbxDispY.Size = New System.Drawing.Size(156, 17)
        Me.cbxDispY.TabIndex = 4
        Me.cbxDispY.Text = "Displacement Y component"
        Me.cbxDispY.UseVisualStyleBackColor = True
        '
        'cbxDispM
        '
        Me.cbxDispM.AutoSize = True
        Me.cbxDispM.Location = New System.Drawing.Point(15, 132)
        Me.cbxDispM.Name = "cbxDispM"
        Me.cbxDispM.Size = New System.Drawing.Size(142, 17)
        Me.cbxDispM.TabIndex = 5
        Me.cbxDispM.Text = "Displacement magnitude"
        Me.cbxDispM.UseVisualStyleBackColor = True
        '
        'cbxVeloX
        '
        Me.cbxVeloX.AutoSize = True
        Me.cbxVeloX.Location = New System.Drawing.Point(15, 155)
        Me.cbxVeloX.Name = "cbxVeloX"
        Me.cbxVeloX.Size = New System.Drawing.Size(129, 17)
        Me.cbxVeloX.TabIndex = 6
        Me.cbxVeloX.Text = "Velocity X component"
        Me.cbxVeloX.UseVisualStyleBackColor = True
        '
        'cbxVeloY
        '
        Me.cbxVeloY.AutoSize = True
        Me.cbxVeloY.Location = New System.Drawing.Point(15, 178)
        Me.cbxVeloY.Name = "cbxVeloY"
        Me.cbxVeloY.Size = New System.Drawing.Size(129, 17)
        Me.cbxVeloY.TabIndex = 7
        Me.cbxVeloY.Text = "Velocity Y component"
        Me.cbxVeloY.UseVisualStyleBackColor = True
        '
        'cbxVeloM
        '
        Me.cbxVeloM.AutoSize = True
        Me.cbxVeloM.Location = New System.Drawing.Point(15, 201)
        Me.cbxVeloM.Name = "cbxVeloM"
        Me.cbxVeloM.Size = New System.Drawing.Size(119, 17)
        Me.cbxVeloM.TabIndex = 8
        Me.cbxVeloM.Text = "Veloctity Magnitude"
        Me.cbxVeloM.UseVisualStyleBackColor = True
        '
        'cbxAccX
        '
        Me.cbxAccX.AutoSize = True
        Me.cbxAccX.Location = New System.Drawing.Point(15, 224)
        Me.cbxAccX.Name = "cbxAccX"
        Me.cbxAccX.Size = New System.Drawing.Size(149, 17)
        Me.cbxAccX.TabIndex = 9
        Me.cbxAccX.Text = "Acceleration x component"
        Me.cbxAccX.UseVisualStyleBackColor = True
        '
        'cbxAccM
        '
        Me.cbxAccM.AutoSize = True
        Me.cbxAccM.Location = New System.Drawing.Point(15, 270)
        Me.cbxAccM.Name = "cbxAccM"
        Me.cbxAccM.Size = New System.Drawing.Size(137, 17)
        Me.cbxAccM.TabIndex = 11
        Me.cbxAccM.Text = "Acceleration magnitude"
        Me.cbxAccM.UseVisualStyleBackColor = True
        '
        'cbxAccY
        '
        Me.cbxAccY.AutoSize = True
        Me.cbxAccY.Location = New System.Drawing.Point(15, 247)
        Me.cbxAccY.Name = "cbxAccY"
        Me.cbxAccY.Size = New System.Drawing.Size(149, 17)
        Me.cbxAccY.TabIndex = 10
        Me.cbxAccY.Text = "Acceleration y component"
        Me.cbxAccY.UseVisualStyleBackColor = True
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(160, 327)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(75, 23)
        Me.btnOkay.TabIndex = 12
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'saving
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 362)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.cbxAccM)
        Me.Controls.Add(Me.cbxAccY)
        Me.Controls.Add(Me.cbxAccX)
        Me.Controls.Add(Me.cbxVeloM)
        Me.Controls.Add(Me.cbxVeloY)
        Me.Controls.Add(Me.cbxVeloX)
        Me.Controls.Add(Me.cbxDispM)
        Me.Controls.Add(Me.cbxDispY)
        Me.Controls.Add(Me.cbxDispX)
        Me.Controls.Add(Me.cbxMass)
        Me.Controls.Add(Me.cbxTime)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "saving"
        Me.Text = "saving"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents cbxTime As System.Windows.Forms.CheckBox
    Friend WithEvents cbxMass As System.Windows.Forms.CheckBox
    Friend WithEvents cbxDispX As System.Windows.Forms.CheckBox
    Friend WithEvents cbxDispY As System.Windows.Forms.CheckBox
    Friend WithEvents cbxDispM As System.Windows.Forms.CheckBox
    Friend WithEvents cbxVeloX As System.Windows.Forms.CheckBox
    Friend WithEvents cbxVeloY As System.Windows.Forms.CheckBox
    Friend WithEvents cbxVeloM As System.Windows.Forms.CheckBox
    Friend WithEvents cbxAccX As System.Windows.Forms.CheckBox
    Friend WithEvents cbxAccM As System.Windows.Forms.CheckBox
    Friend WithEvents cbxAccY As System.Windows.Forms.CheckBox
    Friend WithEvents btnOkay As System.Windows.Forms.Button
End Class
