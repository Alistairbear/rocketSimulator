<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class initialValues
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(initialValues))
        Me.txtVelocityX = New System.Windows.Forms.TextBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.tblMain = New System.Windows.Forms.TableLayoutPanel()
        Me.lblProperty = New System.Windows.Forms.Label()
        Me.txtVelocityY = New System.Windows.Forms.TextBox()
        Me.txtThrustX = New System.Windows.Forms.TextBox()
        Me.txtThrustY = New System.Windows.Forms.TextBox()
        Me.lblXComponent = New System.Windows.Forms.Label()
        Me.lblYComponent = New System.Windows.Forms.Label()
        Me.lblVelocity = New System.Windows.Forms.Label()
        Me.lbThrust = New System.Windows.Forms.Label()
        Me.tblMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtVelocityX
        '
        Me.txtVelocityX.Location = New System.Drawing.Point(80, 56)
        Me.txtVelocityX.Name = "txtVelocityX"
        Me.txtVelocityX.Size = New System.Drawing.Size(100, 20)
        Me.txtVelocityX.TabIndex = 0
        Me.txtVelocityX.Text = "0.0"
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(288, 227)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 1
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'tblMain
        '
        Me.tblMain.ColumnCount = 3
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.90987!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.09013!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tblMain.Controls.Add(Me.txtVelocityX, 1, 1)
        Me.tblMain.Controls.Add(Me.lblProperty, 0, 0)
        Me.tblMain.Controls.Add(Me.txtVelocityY, 2, 1)
        Me.tblMain.Controls.Add(Me.txtThrustX, 1, 2)
        Me.tblMain.Controls.Add(Me.txtThrustY, 2, 2)
        Me.tblMain.Controls.Add(Me.lblXComponent, 1, 0)
        Me.tblMain.Controls.Add(Me.lblYComponent, 2, 0)
        Me.tblMain.Controls.Add(Me.lblVelocity, 0, 1)
        Me.tblMain.Controls.Add(Me.lbThrust, 0, 2)
        Me.tblMain.Location = New System.Drawing.Point(12, 12)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.RowCount = 4
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.tblMain.Size = New System.Drawing.Size(351, 209)
        Me.tblMain.TabIndex = 2
        '
        'lblProperty
        '
        Me.lblProperty.AutoSize = True
        Me.lblProperty.Location = New System.Drawing.Point(3, 0)
        Me.lblProperty.Name = "lblProperty"
        Me.lblProperty.Size = New System.Drawing.Size(46, 13)
        Me.lblProperty.TabIndex = 1
        Me.lblProperty.Text = "Property"
        '
        'txtVelocityY
        '
        Me.txtVelocityY.Location = New System.Drawing.Point(213, 56)
        Me.txtVelocityY.Name = "txtVelocityY"
        Me.txtVelocityY.Size = New System.Drawing.Size(100, 20)
        Me.txtVelocityY.TabIndex = 2
        Me.txtVelocityY.Text = "0.0"
        '
        'txtThrustX
        '
        Me.txtThrustX.Location = New System.Drawing.Point(80, 109)
        Me.txtThrustX.Name = "txtThrustX"
        Me.txtThrustX.Size = New System.Drawing.Size(100, 20)
        Me.txtThrustX.TabIndex = 3
        Me.txtThrustX.Text = "0.0"
        '
        'txtThrustY
        '
        Me.txtThrustY.Location = New System.Drawing.Point(213, 109)
        Me.txtThrustY.Name = "txtThrustY"
        Me.txtThrustY.Size = New System.Drawing.Size(100, 20)
        Me.txtThrustY.TabIndex = 4
        Me.txtThrustY.Text = "0.0"
        '
        'lblXComponent
        '
        Me.lblXComponent.AutoSize = True
        Me.lblXComponent.Location = New System.Drawing.Point(80, 0)
        Me.lblXComponent.Name = "lblXComponent"
        Me.lblXComponent.Size = New System.Drawing.Size(70, 13)
        Me.lblXComponent.TabIndex = 5
        Me.lblXComponent.Text = "X component"
        '
        'lblYComponent
        '
        Me.lblYComponent.AutoSize = True
        Me.lblYComponent.Location = New System.Drawing.Point(213, 0)
        Me.lblYComponent.Name = "lblYComponent"
        Me.lblYComponent.Size = New System.Drawing.Size(70, 13)
        Me.lblYComponent.TabIndex = 6
        Me.lblYComponent.Text = "Y component"
        '
        'lblVelocity
        '
        Me.lblVelocity.AutoSize = True
        Me.lblVelocity.Location = New System.Drawing.Point(3, 53)
        Me.lblVelocity.Name = "lblVelocity"
        Me.lblVelocity.Size = New System.Drawing.Size(71, 13)
        Me.lblVelocity.TabIndex = 7
        Me.lblVelocity.Text = "Velocity (m/s)"
        '
        'lbThrust
        '
        Me.lbThrust.AutoSize = True
        Me.lbThrust.Location = New System.Drawing.Point(3, 106)
        Me.lbThrust.Name = "lbThrust"
        Me.lbThrust.Size = New System.Drawing.Size(54, 13)
        Me.lbThrust.TabIndex = 8
        Me.lbThrust.Text = "Thrust (N)"
        '
        'initialValues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 259)
        Me.Controls.Add(Me.tblMain)
        Me.Controls.Add(Me.btnDone)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "initialValues"
        Me.Text = "Initial Values"
        Me.tblMain.ResumeLayout(False)
        Me.tblMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtVelocityX As System.Windows.Forms.TextBox
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents tblMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblProperty As System.Windows.Forms.Label
    Friend WithEvents txtVelocityY As System.Windows.Forms.TextBox
    Friend WithEvents txtThrustX As System.Windows.Forms.TextBox
    Friend WithEvents txtThrustY As System.Windows.Forms.TextBox
    Friend WithEvents lblXComponent As System.Windows.Forms.Label
    Friend WithEvents lblYComponent As System.Windows.Forms.Label
    Friend WithEvents lblVelocity As System.Windows.Forms.Label
    Friend WithEvents lbThrust As System.Windows.Forms.Label
End Class
