<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblAcc = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.txtDrag = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tmrReal = New System.Windows.Forms.Timer(Me.components)
        Me.lblRealtime = New System.Windows.Forms.Label()
        Me.btnValues = New System.Windows.Forms.Button()
        Me.btnAssumptions = New System.Windows.Forms.Button()
        Me.btnControl = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pctSimulation = New System.Windows.Forms.PictureBox()
        Me.lblAirResistance = New System.Windows.Forms.Label()
        Me.lblGoal = New System.Windows.Forms.Label()
        Me.txtGoal = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.btnBuild = New System.Windows.Forms.Button()
        Me.pgbFuel = New System.Windows.Forms.ProgressBar()
        Me.btnSetGoal = New System.Windows.Forms.Button()
        Me.sldSpeed = New System.Windows.Forms.TrackBar()
        Me.lblSlider = New System.Windows.Forms.Label()
        Me.tmrSave = New System.Windows.Forms.Timer(Me.components)
        Me.cmbPlanets = New System.Windows.Forms.ComboBox()
        Me.lblPlanet = New System.Windows.Forms.Label()
        Me.btnPlanet = New System.Windows.Forms.Button()
        Me.cbxColours = New System.Windows.Forms.CheckBox()
        Me.btnPause = New System.Windows.Forms.Button()
        CType(Me.pctSimulation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sldSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrMain
        '
        '
        'btnLaunch
        '
        Me.btnLaunch.Location = New System.Drawing.Point(12, 12)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(75, 23)
        Me.btnLaunch.TabIndex = 0
        Me.btnLaunch.Text = "LAUNCH"
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(834, 179)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(41, 13)
        Me.lblSpeed.TabIndex = 2
        Me.lblSpeed.Text = "Speed:"
        '
        'lblAcc
        '
        Me.lblAcc.AutoSize = True
        Me.lblAcc.Location = New System.Drawing.Point(806, 207)
        Me.lblAcc.Name = "lblAcc"
        Me.lblAcc.Size = New System.Drawing.Size(69, 13)
        Me.lblAcc.TabIndex = 3
        Me.lblAcc.Text = "Acceleration:"
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(93, 12)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 6
        Me.btnStop.Text = "STOP"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'txtDrag
        '
        Me.txtDrag.Location = New System.Drawing.Point(857, 117)
        Me.txtDrag.Name = "txtDrag"
        Me.txtDrag.Size = New System.Drawing.Size(100, 20)
        Me.txtDrag.TabIndex = 7
        Me.txtDrag.Text = "0.005"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(842, 234)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 13)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "Time:"
        '
        'tmrReal
        '
        Me.tmrReal.Interval = 1000
        '
        'lblRealtime
        '
        Me.lblRealtime.AutoSize = True
        Me.lblRealtime.Location = New System.Drawing.Point(824, 260)
        Me.lblRealtime.Name = "lblRealtime"
        Me.lblRealtime.Size = New System.Drawing.Size(51, 13)
        Me.lblRealtime.TabIndex = 9
        Me.lblRealtime.Text = "Realtime:"
        '
        'btnValues
        '
        Me.btnValues.Location = New System.Drawing.Point(862, 293)
        Me.btnValues.Name = "btnValues"
        Me.btnValues.Size = New System.Drawing.Size(75, 23)
        Me.btnValues.TabIndex = 10
        Me.btnValues.Text = "intial values"
        Me.btnValues.UseVisualStyleBackColor = True
        '
        'btnAssumptions
        '
        Me.btnAssumptions.Location = New System.Drawing.Point(862, 322)
        Me.btnAssumptions.Name = "btnAssumptions"
        Me.btnAssumptions.Size = New System.Drawing.Size(75, 23)
        Me.btnAssumptions.TabIndex = 11
        Me.btnAssumptions.Text = "Assumptions"
        Me.btnAssumptions.UseVisualStyleBackColor = True
        '
        'btnControl
        '
        Me.btnControl.Location = New System.Drawing.Point(336, 12)
        Me.btnControl.Name = "btnControl"
        Me.btnControl.Size = New System.Drawing.Size(75, 23)
        Me.btnControl.TabIndex = 12
        Me.btnControl.Text = "Control"
        Me.btnControl.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(862, 352)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save results"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'pctSimulation
        '
        Me.pctSimulation.BackColor = System.Drawing.Color.White
        Me.pctSimulation.Location = New System.Drawing.Point(174, 64)
        Me.pctSimulation.Name = "pctSimulation"
        Me.pctSimulation.Size = New System.Drawing.Size(540, 530)
        Me.pctSimulation.TabIndex = 14
        Me.pctSimulation.TabStop = False
        '
        'lblAirResistance
        '
        Me.lblAirResistance.AutoSize = True
        Me.lblAirResistance.Location = New System.Drawing.Point(734, 120)
        Me.lblAirResistance.Name = "lblAirResistance"
        Me.lblAirResistance.Size = New System.Drawing.Size(117, 13)
        Me.lblAirResistance.TabIndex = 16
        Me.lblAirResistance.Text = "Air resistance constant:"
        '
        'lblGoal
        '
        Me.lblGoal.AutoSize = True
        Me.lblGoal.Location = New System.Drawing.Point(815, 17)
        Me.lblGoal.Name = "lblGoal"
        Me.lblGoal.Size = New System.Drawing.Size(32, 13)
        Me.lblGoal.TabIndex = 18
        Me.lblGoal.Text = "Goal:"
        '
        'txtGoal
        '
        Me.txtGoal.Location = New System.Drawing.Point(856, 12)
        Me.txtGoal.Name = "txtGoal"
        Me.txtGoal.Size = New System.Drawing.Size(100, 20)
        Me.txtGoal.TabIndex = 17
        Me.txtGoal.Text = "100"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(830, 152)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(45, 13)
        Me.lblHeight.TabIndex = 20
        Me.lblHeight.Text = "Altitude:"
        '
        'btnBuild
        '
        Me.btnBuild.Location = New System.Drawing.Point(862, 381)
        Me.btnBuild.Name = "btnBuild"
        Me.btnBuild.Size = New System.Drawing.Size(75, 36)
        Me.btnBuild.TabIndex = 23
        Me.btnBuild.Text = "Build a Rocket"
        Me.btnBuild.UseVisualStyleBackColor = True
        '
        'pgbFuel
        '
        Me.pgbFuel.Location = New System.Drawing.Point(779, 555)
        Me.pgbFuel.Name = "pgbFuel"
        Me.pgbFuel.Size = New System.Drawing.Size(157, 30)
        Me.pgbFuel.TabIndex = 24
        '
        'btnSetGoal
        '
        Me.btnSetGoal.Location = New System.Drawing.Point(881, 35)
        Me.btnSetGoal.Name = "btnSetGoal"
        Me.btnSetGoal.Size = New System.Drawing.Size(75, 23)
        Me.btnSetGoal.TabIndex = 26
        Me.btnSetGoal.Text = "Set Goal"
        Me.btnSetGoal.UseVisualStyleBackColor = True
        '
        'sldSpeed
        '
        Me.sldSpeed.Location = New System.Drawing.Point(779, 591)
        Me.sldSpeed.Name = "sldSpeed"
        Me.sldSpeed.Size = New System.Drawing.Size(160, 45)
        Me.sldSpeed.TabIndex = 20
        '
        'lblSlider
        '
        Me.lblSlider.AutoSize = True
        Me.lblSlider.Location = New System.Drawing.Point(718, 591)
        Me.lblSlider.Name = "lblSlider"
        Me.lblSlider.Size = New System.Drawing.Size(55, 13)
        Me.lblSlider.TabIndex = 27
        Me.lblSlider.Text = "Time flow:"
        '
        'tmrSave
        '
        Me.tmrSave.Interval = 1000
        '
        'cmbPlanets
        '
        Me.cmbPlanets.FormattingEnabled = True
        Me.cmbPlanets.Location = New System.Drawing.Point(856, 63)
        Me.cmbPlanets.Name = "cmbPlanets"
        Me.cmbPlanets.Size = New System.Drawing.Size(100, 21)
        Me.cmbPlanets.TabIndex = 30
        '
        'lblPlanet
        '
        Me.lblPlanet.AutoSize = True
        Me.lblPlanet.Location = New System.Drawing.Point(776, 71)
        Me.lblPlanet.Name = "lblPlanet"
        Me.lblPlanet.Size = New System.Drawing.Size(75, 13)
        Me.lblPlanet.TabIndex = 31
        Me.lblPlanet.Text = "Celestial body:"
        '
        'btnPlanet
        '
        Me.btnPlanet.Location = New System.Drawing.Point(881, 90)
        Me.btnPlanet.Name = "btnPlanet"
        Me.btnPlanet.Size = New System.Drawing.Size(75, 23)
        Me.btnPlanet.TabIndex = 32
        Me.btnPlanet.Text = "Set Body"
        Me.btnPlanet.UseVisualStyleBackColor = True
        '
        'cbxColours
        '
        Me.cbxColours.AutoSize = True
        Me.cbxColours.Location = New System.Drawing.Point(749, 94)
        Me.cbxColours.Name = "cbxColours"
        Me.cbxColours.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbxColours.Size = New System.Drawing.Size(128, 17)
        Me.cbxColours.TabIndex = 33
        Me.cbxColours.Text = "Use planetary colours"
        Me.cbxColours.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(174, 12)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 34
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 643)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.cbxColours)
        Me.Controls.Add(Me.btnPlanet)
        Me.Controls.Add(Me.lblPlanet)
        Me.Controls.Add(Me.cmbPlanets)
        Me.Controls.Add(Me.lblSlider)
        Me.Controls.Add(Me.sldSpeed)
        Me.Controls.Add(Me.btnSetGoal)
        Me.Controls.Add(Me.pgbFuel)
        Me.Controls.Add(Me.btnBuild)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblGoal)
        Me.Controls.Add(Me.txtGoal)
        Me.Controls.Add(Me.lblAirResistance)
        Me.Controls.Add(Me.pctSimulation)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnControl)
        Me.Controls.Add(Me.btnAssumptions)
        Me.Controls.Add(Me.btnValues)
        Me.Controls.Add(Me.lblRealtime)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtDrag)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lblAcc)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.btnLaunch)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Rocket Simulator"
        CType(Me.pctSimulation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sldSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents btnLaunch As System.Windows.Forms.Button
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents lblAcc As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents txtDrag As System.Windows.Forms.TextBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents tmrReal As System.Windows.Forms.Timer
    Friend WithEvents lblRealtime As System.Windows.Forms.Label
    Friend WithEvents btnValues As System.Windows.Forms.Button
    Friend WithEvents btnAssumptions As System.Windows.Forms.Button
    Friend WithEvents btnControl As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents pctSimulation As System.Windows.Forms.PictureBox
    Friend WithEvents lblAirResistance As System.Windows.Forms.Label
    Friend WithEvents lblGoal As System.Windows.Forms.Label
    Friend WithEvents txtGoal As System.Windows.Forms.TextBox
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents btnBuild As System.Windows.Forms.Button
    Friend WithEvents pgbFuel As System.Windows.Forms.ProgressBar
    Friend WithEvents btnSetGoal As System.Windows.Forms.Button
    Friend WithEvents sldSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents lblSlider As System.Windows.Forms.Label
    Friend WithEvents tmrSave As System.Windows.Forms.Timer
    Friend WithEvents cmbPlanets As System.Windows.Forms.ComboBox
    Friend WithEvents lblPlanet As System.Windows.Forms.Label
    Friend WithEvents btnPlanet As System.Windows.Forms.Button
    Friend WithEvents cbxColours As System.Windows.Forms.CheckBox
    Friend WithEvents btnPause As System.Windows.Forms.Button

End Class
