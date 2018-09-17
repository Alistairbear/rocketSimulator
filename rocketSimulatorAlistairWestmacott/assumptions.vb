Public Class assumptions

    ' NOT ANNOTATED

    Dim mainSim As simulation

    Private Sub assumptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub startSimValueChange(ByRef sim As simulation)
        mainSim = sim
        cbxFloor.Checked = mainSim.floorEdit
        cbxVacuum.Checked = mainSim.vacuumEdit
        cbxMassDecay.Checked = mainSim.massDecayEdit

        cbxAirThinning.Checked = mainSim.airThinningEdit
        cbxGravityThinning.Checked = mainSim.gravityThinningEdit
    End Sub

    Private Sub cbxMassDecay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMassDecay.CheckedChanged
        cbxFiniteFuel.Enabled = Not cbxFiniteFuel.Enabled
    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        mainSim.massDecayEdit = cbxMassDecay.Checked
        If cbxMassDecay.Checked Then
            mainSim.finiteFuelEdit = True
        Else
            mainSim.finiteFuelEdit = cbxFiniteFuel.Checked
        End If
        mainSim.vacuumEdit = cbxVacuum.Checked
        mainSim.floorEdit = cbxFloor.Checked
        mainSim.airThinningEdit = cbxAirThinning.Checked
        mainSim.gravityThinningEdit = cbxGravityThinning.Checked
        mainSim.refreshRocket()
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cbxFiniteFuel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFiniteFuel.CheckedChanged
        MsgBox("This doesn't do anything but it's already integrated into the code so that's great")
    End Sub
End Class