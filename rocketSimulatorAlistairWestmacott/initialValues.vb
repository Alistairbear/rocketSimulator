Public Class initialValues

    ' NOT ANNOTATED

    Dim simulationValues() As Single
    Dim mainSim As simulation

    Private Sub initialValues_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub startSimValueChange(ByRef sim As simulation)
        mainSim = sim
    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        If IsNumeric(txtVelocityX.Text) Then
            mainSim.initialValues(1).x = txtVelocityX.Text
        End If
        If IsNumeric(txtVelocityY.Text) Then
            mainSim.initialValues(1).y = txtVelocityY.Text
        End If

        If IsNumeric(txtThrustX.Text) Then
            mainSim.initialValues(3).x = txtThrustX.Text
        End If
        If IsNumeric(txtThrustY.Text) Then
            mainSim.initialValues(3).y = txtThrustY.Text
        End If

        mainSim.refreshRocket()
        Me.Close()
    End Sub



End Class