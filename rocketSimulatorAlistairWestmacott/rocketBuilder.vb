Public Class rocketBuilder

    'thrust
    'fuel mass
    'rocket mass
    'air resistance constant

    'implement progress bar for fuel with simulation

    've(dm/dt)

    Private partSelection(2) As Integer
    Private nose() As String
    Private fuelTank() As String
    Private thruster() As String

    Private mainRocket As rocket

    'mech mass |        |
    'fuel mass | radius | v_e

    Private stats(1, 2, 3) As Single
    'Private statsTotal(1, 2, 3) As Single

    Private Sub rocketBuilder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        nose = System.IO.Directory.GetFiles("resources/parts/nose", "*.bmp")
        fuelTank = System.IO.Directory.GetFiles("resources/parts/fuelTank", "*.bmp")
        thruster = System.IO.Directory.GetFiles("resources/parts/thruster", "*.bmp")

        pctNose.Image = Image.FromFile(nose(0))
        pctFuel.Image = Image.FromFile(fuelTank(0))
        pctThrust.Image = Image.FromFile(thruster(0))

        For i As Integer = 0 To 2
            changeStats(i)
        Next
    End Sub

    Public Sub loadRocket(ByRef mainRocket As rocket)
        Me.mainRocket = mainRocket
    End Sub

    Private Sub changePart(ByVal direction As Integer, ByVal part As Integer)
        partSelection(part) += direction
        Select Case part
            Case 0
                partSelection(part) = loopPart(partSelection(part), nose.GetLength(0) - 1)
                pctNose.Image = Image.FromFile(nose(partSelection(part)))
            Case 1
                partSelection(part) = loopPart(partSelection(part), fuelTank.GetLength(0) - 1)
                pctFuel.Image = Image.FromFile(fuelTank(partSelection(part)))
            Case 2
                partSelection(part) = loopPart(partSelection(part), thruster.GetLength(0) - 1)
                pctThrust.Image = Image.FromFile(thruster(partSelection(part)))
        End Select
        changeStats(part)
    End Sub

    Private Function loopPart(ByVal part As Integer, ByVal limit As Integer)
        If part > limit Then
            Return 0
        ElseIf part < 0 Then
            Return limit
        Else
            Return part
        End If
    End Function

    Private Sub changeStats(ByVal part As Integer)

        Dim path As String = ""
        Select Case part
            Case 0
                path = "resources/parts/nose/nose" & partSelection(0) & ".csv"
            Case 1
                path = "resources/parts/fuelTank/fuel" & partSelection(1) & ".csv"
            Case 2
                path = "resources/parts/thruster/thruster" & partSelection(2) & ".csv"
        End Select

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(path)

            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()

            'Dim count As Integer
            'While Not MyReader.EndOfData
            '    Try
            '        'currentRow = MyReader.ReadFields()
            '        'Dim currentField As String
            '        'For Each currentField In currentRow
            '        '    If IsNumeric(currentField) And count < 3 Then
            '        '        stats(part, count) = currentField
            '        '        stats(3, count) = stats(0, count) + stats(1, count) + stats(2, count)
            '        '    Else
            '        '        stats(part, 3) = currentField
            '        '    End If
            '        'Next

            '        'currentRow()


            '    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException ' catches corrupt lines (ie lines which are not formatted correctly
            '        MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
            '    End Try
            '    count += 1
            'End While

            currentRow = MyReader.ReadFields()

            stats(0, 0, part) = currentRow(0)

            stats(0, 0, 3) = stats(0, 0, 0) + stats(0, 0, 1) + stats(0, 0, 2)

            currentRow = MyReader.ReadFields()
            For i As Integer = 0 To 2
                stats(1, i, part) = currentRow(i)
            Next
            For i As Integer = 0 To 2
                stats(1, i, 3) = stats(1, i, 0) + stats(1, i, 1) + stats(1, i, 2)
            Next


        End Using

        lblRadius.Text = "Radius: " & stats(1, 1, 3)
        If stats(1, 1, 3) > 0 Then
            pgbRadius.Value = stats(1, 1, 3) * 10
        Else
            pgbRadius.Value = 0
        End If

        lblFuel.Text = "Fuel: " & stats(1, 0, 3)
        If stats(1, 0, 3) > 0 Then
            pgbFuel.Value = stats(1, 0, 3) / 100000
        Else
            pgbFuel.Value = 0
        End If

        lblMass.Text = "Gross Mass: " & (stats(0, 0, 3) + stats(1, 0, 3))
        If stats(0, 0, 3) + stats(1, 0, 3) > 0 Then
            pgbMass.Value = (stats(0, 0, 3) + stats(1, 0, 3)) / 100000
        Else
            pgbMass.Value = 0
        End If

    End Sub

    Private Sub btnNoseFwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoseFwd.Click
        changePart(1, 0)
    End Sub

    Private Sub btnNoseBkw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoseBkw.Click
        changePart(-1, 0)
    End Sub

    Private Sub btnFuelBkw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFuelBkw.Click
        changePart(-1, 1)
    End Sub

    Private Sub btnFuelFwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFuelFwd.Click
        changePart(1, 1)
    End Sub

    Private Sub btnThrustBkw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThrustBkw.Click
        changePart(-1, 2)
    End Sub

    Private Sub btnThrustFwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThrustFwd.Click
        changePart(1, 2)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click, SaveToolStripMenuItem.Click
        Dim sure As Boolean = True
        Dim SaveFileDlg As New SaveFileDialog ' creates a new save dialog
        SaveFileDlg.FileName = "My Rocket" ' set default file name
        SaveFileDlg.DefaultExt = ".rkt" ' Set default file extension
        SaveFileDlg.Filter = "Rocket (*.rkt)|*.rkt" ' filter only .rkt files (and directories)
        SaveFileDlg.ShowDialog() ' show the dialog
        'Dim temp As String = stats(3, 0) & ", " & stats(3, 1) & ", " & stats(3, 2)

        'Dim temp As String = stats(3, 0) & ", " & stats(3, 1) & ", " & stats(3, 2) & vbCrLf & stats(0, 3) & ", " & stats(1, 3) & ", " & stats(2, 3)

        Dim temp As String = stats(0, 0, 3) & vbCrLf & stats(1, 0, 3) & ", " & stats(1, 1, 3) & ", " & stats(1, 2, 3)

        ' thrust, fuelmass, mass, thrust, 
        My.Computer.FileSystem.WriteAllText(SaveFileDlg.FileName(), temp, False)

        'Try
        '    My.Computer.FileSystem.CopyFile(IO.Path.Combine(My.Application.Info.DirectoryPath, "temp.csv"), SaveFileDlg.FileName()) ' copy the temporary data file into the desired location
        'Catch

        'End Try
    End Sub

    Private Sub CustomiseValuesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomiseValuesToolStripMenuItem.Click
        MsgBox("This doesn't work yet sorry")
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        MsgBox("This doesn't work yet sorry")
    End Sub


    ' must be reformatted to work with new stats formatting
    Private Sub btnUse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUse.Click
        'Dim temp As String = stats(3, 0) & ", " & stats(3, 1) & ", " & stats(3, 2) & vbCrLf & stats(0, 3) & ", " & stats(1, 3) & ", " & stats(2, 3)

        Dim temp As String = stats(0, 0, 3) & vbCrLf & stats(1, 0, 3) & ", " & stats(1, 1, 3) & ", " & stats(1, 2, 3)

        My.Computer.FileSystem.WriteAllText("temp.rkt", temp, False)
        mainRocket.loadNewRocket("temp.rkt")
        Me.Close()
    End Sub
End Class