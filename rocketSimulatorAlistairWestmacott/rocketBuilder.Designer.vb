<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rocketBuilder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rocketBuilder))
        Me.btnFuelFwd = New System.Windows.Forms.Button()
        Me.btnFuelBkw = New System.Windows.Forms.Button()
        Me.pctFuel = New System.Windows.Forms.PictureBox()
        Me.pctNose = New System.Windows.Forms.PictureBox()
        Me.btnNoseBkw = New System.Windows.Forms.Button()
        Me.btnNoseFwd = New System.Windows.Forms.Button()
        Me.pctThrust = New System.Windows.Forms.PictureBox()
        Me.btnThrustBkw = New System.Windows.Forms.Button()
        Me.btnThrustFwd = New System.Windows.Forms.Button()
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.pgbRadius = New System.Windows.Forms.ProgressBar()
        Me.pgbFuel = New System.Windows.Forms.ProgressBar()
        Me.lblFuel = New System.Windows.Forms.Label()
        Me.pgbMass = New System.Windows.Forms.ProgressBar()
        Me.lblMass = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomiseValuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUse = New System.Windows.Forms.Button()
        CType(Me.pctFuel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctNose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctThrust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFuelFwd
        '
        Me.btnFuelFwd.Location = New System.Drawing.Point(290, 271)
        Me.btnFuelFwd.Name = "btnFuelFwd"
        Me.btnFuelFwd.Size = New System.Drawing.Size(24, 23)
        Me.btnFuelFwd.TabIndex = 0
        Me.btnFuelFwd.Text = ">"
        Me.btnFuelFwd.UseVisualStyleBackColor = True
        '
        'btnFuelBkw
        '
        Me.btnFuelBkw.Location = New System.Drawing.Point(86, 271)
        Me.btnFuelBkw.Name = "btnFuelBkw"
        Me.btnFuelBkw.Size = New System.Drawing.Size(21, 23)
        Me.btnFuelBkw.TabIndex = 1
        Me.btnFuelBkw.Text = "<"
        Me.btnFuelBkw.UseVisualStyleBackColor = True
        '
        'pctFuel
        '
        Me.pctFuel.Location = New System.Drawing.Point(151, 179)
        Me.pctFuel.Name = "pctFuel"
        Me.pctFuel.Size = New System.Drawing.Size(100, 200)
        Me.pctFuel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctFuel.TabIndex = 2
        Me.pctFuel.TabStop = False
        '
        'pctNose
        '
        Me.pctNose.Location = New System.Drawing.Point(151, 30)
        Me.pctNose.Name = "pctNose"
        Me.pctNose.Size = New System.Drawing.Size(100, 150)
        Me.pctNose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctNose.TabIndex = 5
        Me.pctNose.TabStop = False
        '
        'btnNoseBkw
        '
        Me.btnNoseBkw.Location = New System.Drawing.Point(86, 105)
        Me.btnNoseBkw.Name = "btnNoseBkw"
        Me.btnNoseBkw.Size = New System.Drawing.Size(21, 23)
        Me.btnNoseBkw.TabIndex = 4
        Me.btnNoseBkw.Text = "<"
        Me.btnNoseBkw.UseVisualStyleBackColor = True
        '
        'btnNoseFwd
        '
        Me.btnNoseFwd.Location = New System.Drawing.Point(290, 105)
        Me.btnNoseFwd.Name = "btnNoseFwd"
        Me.btnNoseFwd.Size = New System.Drawing.Size(24, 23)
        Me.btnNoseFwd.TabIndex = 3
        Me.btnNoseFwd.Text = ">"
        Me.btnNoseFwd.UseVisualStyleBackColor = True
        '
        'pctThrust
        '
        Me.pctThrust.Location = New System.Drawing.Point(126, 378)
        Me.pctThrust.Name = "pctThrust"
        Me.pctThrust.Size = New System.Drawing.Size(150, 200)
        Me.pctThrust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctThrust.TabIndex = 8
        Me.pctThrust.TabStop = False
        '
        'btnThrustBkw
        '
        Me.btnThrustBkw.Location = New System.Drawing.Point(86, 468)
        Me.btnThrustBkw.Name = "btnThrustBkw"
        Me.btnThrustBkw.Size = New System.Drawing.Size(21, 23)
        Me.btnThrustBkw.TabIndex = 7
        Me.btnThrustBkw.Text = "<"
        Me.btnThrustBkw.UseVisualStyleBackColor = True
        '
        'btnThrustFwd
        '
        Me.btnThrustFwd.Location = New System.Drawing.Point(290, 468)
        Me.btnThrustFwd.Name = "btnThrustFwd"
        Me.btnThrustFwd.Size = New System.Drawing.Size(24, 23)
        Me.btnThrustFwd.TabIndex = 6
        Me.btnThrustFwd.Text = ">"
        Me.btnThrustFwd.UseVisualStyleBackColor = True
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Location = New System.Drawing.Point(355, 33)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(43, 13)
        Me.lblRadius.TabIndex = 9
        Me.lblRadius.Text = "Radius:"
        '
        'pgbRadius
        '
        Me.pgbRadius.Location = New System.Drawing.Point(358, 49)
        Me.pgbRadius.Name = "pgbRadius"
        Me.pgbRadius.Size = New System.Drawing.Size(164, 23)
        Me.pgbRadius.TabIndex = 10
        '
        'pgbFuel
        '
        Me.pgbFuel.Location = New System.Drawing.Point(358, 103)
        Me.pgbFuel.Name = "pgbFuel"
        Me.pgbFuel.Size = New System.Drawing.Size(164, 23)
        Me.pgbFuel.TabIndex = 12
        '
        'lblFuel
        '
        Me.lblFuel.AutoSize = True
        Me.lblFuel.Location = New System.Drawing.Point(355, 87)
        Me.lblFuel.Name = "lblFuel"
        Me.lblFuel.Size = New System.Drawing.Size(30, 13)
        Me.lblFuel.TabIndex = 11
        Me.lblFuel.Text = "Fuel:"
        '
        'pgbMass
        '
        Me.pgbMass.Location = New System.Drawing.Point(358, 158)
        Me.pgbMass.Name = "pgbMass"
        Me.pgbMass.Size = New System.Drawing.Size(164, 23)
        Me.pgbMass.TabIndex = 14
        '
        'lblMass
        '
        Me.lblMass.AutoSize = True
        Me.lblMass.Location = New System.Drawing.Point(355, 142)
        Me.lblMass.Name = "lblMass"
        Me.lblMass.Size = New System.Drawing.Size(35, 13)
        Me.lblMass.TabIndex = 13
        Me.lblMass.Text = "Mass:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(447, 495)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(447, 524)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 16
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(530, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.toolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomiseValuesToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'CustomiseValuesToolStripMenuItem
        '
        Me.CustomiseValuesToolStripMenuItem.Name = "CustomiseValuesToolStripMenuItem"
        Me.CustomiseValuesToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CustomiseValuesToolStripMenuItem.Text = "Customise values"
        '
        'btnUse
        '
        Me.btnUse.Location = New System.Drawing.Point(447, 554)
        Me.btnUse.Name = "btnUse"
        Me.btnUse.Size = New System.Drawing.Size(75, 23)
        Me.btnUse.TabIndex = 18
        Me.btnUse.Text = "Use"
        Me.btnUse.UseVisualStyleBackColor = True
        '
        'rocketBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 586)
        Me.Controls.Add(Me.btnUse)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.pgbMass)
        Me.Controls.Add(Me.lblMass)
        Me.Controls.Add(Me.pgbFuel)
        Me.Controls.Add(Me.lblFuel)
        Me.Controls.Add(Me.pgbRadius)
        Me.Controls.Add(Me.lblRadius)
        Me.Controls.Add(Me.pctThrust)
        Me.Controls.Add(Me.btnThrustBkw)
        Me.Controls.Add(Me.btnThrustFwd)
        Me.Controls.Add(Me.pctNose)
        Me.Controls.Add(Me.btnNoseBkw)
        Me.Controls.Add(Me.btnNoseFwd)
        Me.Controls.Add(Me.pctFuel)
        Me.Controls.Add(Me.btnFuelBkw)
        Me.Controls.Add(Me.btnFuelFwd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rocketBuilder"
        Me.Text = "Rocket Builder"
        CType(Me.pctFuel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctNose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctThrust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFuelFwd As System.Windows.Forms.Button
    Friend WithEvents btnFuelBkw As System.Windows.Forms.Button
    Friend WithEvents pctFuel As System.Windows.Forms.PictureBox
    Friend WithEvents pctNose As System.Windows.Forms.PictureBox
    Friend WithEvents btnNoseBkw As System.Windows.Forms.Button
    Friend WithEvents btnNoseFwd As System.Windows.Forms.Button
    Friend WithEvents pctThrust As System.Windows.Forms.PictureBox
    Friend WithEvents btnThrustBkw As System.Windows.Forms.Button
    Friend WithEvents btnThrustFwd As System.Windows.Forms.Button
    Friend WithEvents lblRadius As System.Windows.Forms.Label
    Friend WithEvents pgbRadius As System.Windows.Forms.ProgressBar
    Friend WithEvents pgbFuel As System.Windows.Forms.ProgressBar
    Friend WithEvents lblFuel As System.Windows.Forms.Label
    Friend WithEvents pgbMass As System.Windows.Forms.ProgressBar
    Friend WithEvents lblMass As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomiseValuesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUse As System.Windows.Forms.Button
End Class
