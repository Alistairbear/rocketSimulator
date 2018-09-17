Public Class saving

    Private values(11) As Boolean

    Private Sub saving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        values(11) = True
    End Sub

    Public ReadOnly Property getValues As Boolean()
        Get
            Return values
        End Get
    End Property

    Private Sub cbxTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTime.CheckedChanged
        values(0) = cbxTime.Checked
    End Sub

    Private Sub cbxMass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMass.CheckedChanged
        values(1) = cbxMass.Checked
    End Sub

    Private Sub cbxDispX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxDispX.CheckedChanged
        values(2) = cbxDispX.Checked
    End Sub

    Private Sub cbxDispY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxDispY.CheckedChanged
        values(3) = cbxDispY.Checked
    End Sub

    Private Sub cbxDispM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxDispM.CheckedChanged
        values(4) = cbxDispM.Checked
    End Sub

    Private Sub cbxVeloX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxVeloX.CheckedChanged
        values(5) = cbxVeloX.Checked
    End Sub

    Private Sub cbxVeloY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxVeloY.CheckedChanged
        values(6) = cbxVeloY.Checked
    End Sub

    Private Sub cbxVeloM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxVeloM.CheckedChanged
        values(7) = cbxVeloM.Checked
    End Sub

    Private Sub cbxAccX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxAccX.CheckedChanged
        values(8) = cbxAccX.Checked
    End Sub

    Private Sub cbxAccY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxAccY.CheckedChanged
        values(9) = cbxAccY.Checked
    End Sub

    Private Sub cbxAccM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxAccM.CheckedChanged
        values(10) = cbxAccM.Checked
    End Sub

    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        Me.Close()
    End Sub
End Class