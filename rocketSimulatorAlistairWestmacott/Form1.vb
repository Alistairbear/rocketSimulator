Public Class Form1

    ' COMPLETELY ANNOTATED

    Dim mainSimulation As simulation ' instatiate the main simulation class
    Dim g As Graphics ' create a local copy of the graphics handler. This is passed into subs which draw on the main simulation
    Dim realTime As Integer = 0 ' stores the number of seconds elapsed since the start of the simulation (from when launch is pressed)
    Dim simulationValues() As Single ' stores information, namely initial values, about the simulation before it launches
    Private escapeVConst As Single = Math.Sqrt(2 * 6.67 * 6 * 10 ^ 13) ' stores the square root of 2 * G * mass of earth

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mainSimulation = New simulation(txtDrag.Text, txtGoal.Text) ' create a new simulation
        AddHandler pctSimulation.Paint, AddressOf Me.pctOutput_Paint ' this line links the pctOutput_paint() sub to the event of the simulation picture box being painted
        ' it basically means that whenever the form refreshes, the 
    End Sub

    Private Sub pctOutput_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        ' Create a local version of the graphics object for the PictureBox.
        g = e.Graphics
        mainSimulation.drawAxes(g) ' draw the axes and grid for the simulation box. This also includes the goal point and the particle loop
        mainSimulation.mainRocket.drawForces(g, New vectorQuantity, mainSimulation.particleAnchor) ' this draws the forces onto the simulation box
    End Sub

    Private Sub launch(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaunch.Click
        txtDrag.Enabled = False ' disable the drag text box
        txtGoal.Enabled = False ' disable the mass text box
        btnLaunch.Enabled = False ' disable the launch button
        btnStop.Enabled = True ' enable the stop button
        btnAssumptions.Enabled = False ' disable the assumptions button
        btnValues.Enabled = False ' disable the initial values button

        tmrMain.Interval = 40 ' set the interval for the timer to 40ms
        tmrMain.Start() ' start the timer for the simulation
        tmrReal.Start() ' start the timer for the realtime counter

    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        tmrMain.Stop() ' stop the main timer
        tmrReal.Stop() ' stop the realtime timer

        txtGoal.Enabled = True ' enable the mass text box
        txtDrag.Enabled = True ' enable the drag text box
        btnAssumptions.Enabled = True ' Enables the assumptions button
        btnValues.Enabled = True ' Enables the initial values button
        btnLaunch.Enabled = True ' enable the launch button
        btnStop.Enabled = False ' disable the stop button
        mainSimulation.time = 0.0 ' reset the time for the simulation
        mainSimulation.restart() ' restart all values for the simulation

        Me.Refresh() ' refresh the window so that the rocket is in the start position
    End Sub

    Private Sub nextFrame(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMain.Tick
        mainSimulation.time += tmrMain.Interval ' increase the time in the simulation by the interval of the timer
        ' calculate the next set of values for the rocket
        mainSimulation.mainRocket.nextframe(tmrMain.Interval * (sldSpeed.Value + 1) / 1000, g)
        ' output some of the variables for the rocket on the main form
        mainSimulation.mainRocket.updateLabels(lblHeight, lblSpeed, lblAcc)
        ' output the time in the simulation
        lblTime.Text = "Time: " & (mainSimulation.time * (sldSpeed.Value + 1) / 1000)
        'update the progress on the fuel progress bar
        pgbFuel.Value = mainSimulation.mainRocket.fuelPercent
        'refresh the form so the rocket appears in it's new position
        Me.Refresh()
        ' export the rocket's variables into the temporary .csv file so that it can be saved later
        mainSimulation.export()
        ' if the rocket's vertical velocity is greater than the escape velocity constant over the square root of the distance from the centre of the earth then inform the user they have reached escape velocity
        If mainSimulation.mainRocket.velocity.y > escapeVConst / (Math.Sqrt(6371000 + mainSimulation.mainRocket.displacement.y)) Then
            MsgBox("You have reached escape velocity")
        End If
    End Sub

    Private Sub tmrReal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrReal.Tick
        realTime += 1 ' increases the realtime variable by 1 second
        lblRealtime.Text = "Realtime: " & realTime ' ouputs the realtime variable
    End Sub

    ' This sub is for initial values. That form doesn't work great so this sub actually isn't currently accessible through the code
    Private Sub btnValues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValues.Click
        Dim form2 As New initialValues ' instatiating a new initial values form to display
        form2.startSimValueChange(mainSimulation) ' linking the main simulation to that form through association/aggregation
        form2.ShowDialog() ' show as a dialog (main form is disabled)
    End Sub

    ' this form handles the loading and management of the assumptions window when the assumptions button is pressed
    Private Sub btnAssumptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssumptions.Click
        Dim form2 As New assumptions ' instatiating a new assumptions form to display
        form2.startSimValueChange(mainSimulation) ' links simulation by association/aggregation
        form2.ShowDialog() ' show as a dialog (main form is disabled)
    End Sub

    ' the rocket has a control sub which does different things depending on what's programmed into it. It's meant to be a macro for the rocket and may be programmable by the user.
    Private Sub btnControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControl.Click
        'If mainSimulation.time > 0 Then ' making sure the launch is taking place for the button to do anything
        '    mainSimulation.mainRocket.control() ' activates the control function of the rocket
        'End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim saveValues As New saving ' create a new instance of the saving form
        saveValues.ShowDialog() ' show this new instance as a dialog (meaning the main form can't be accessed until this form closes

        Dim SaveFileDlg As New SaveFileDialog ' creates a new save dialog
        SaveFileDlg.FileName = "" ' set default file name
        SaveFileDlg.DefaultExt = ".csv" ' Set default file extension
        SaveFileDlg.Filter = "Comma Separated Value (*.csv)|*.csv" ' filter only .csv files (and directories)
        SaveFileDlg.ShowDialog() ' show the dialog

        tmrSave.Start()

        My.Computer.FileSystem.DeleteFile(SaveFileDlg.FileName)
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("temp.csv") ' this object is the file reader. It's reading temp.csv which holds the information about the last launch. It's also a text parser so it will parse the file in some way
            Dim count As Integer = 0 ' a simple count variable starting at 0
            MyReader.TextFieldType = FileIO.FieldType.Delimited ' sets the parsing type to delimited meaning the data is split by a character of some sort
            MyReader.SetDelimiters(",") ' set the delimiter to the "," character because it's reading a comma separated value file (.csv)
            Dim currentRow As String() ' holds the current row being read
            While Not MyReader.EndOfData ' while the reader is not at the end of the file:
                Try ' this is in a try statement which catches corrupt lines. Adds robustness to the reader
                    currentRow = MyReader.ReadFields() ' current row is set to the next line in the file
                    Dim currentField As String ' instantiate a string which holds the current field
                    For Each currentField In currentRow ' for each element in current row
                        If saveValues.getValues(count) Then ' if the user has selected this property to be saved then
                            My.Computer.FileSystem.WriteAllText(SaveFileDlg.FileName, currentField & ", ", True) ' add that property to the ouput file along with a comma to separate it into a new field
                        End If
                        count += 1 ' increment count by 1
                    Next
                    My.Computer.FileSystem.WriteAllText(SaveFileDlg.FileName, vbCrLf, True) ' add a new line to the file so each group of data are stored in separate lines rather than on one long line. Makes analysis easier
                    count = 0 ' reset count
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException ' catches corrupt lines (ie lines which are not formatted correctly
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.") ' Inform the user that a line has been skipped.
                End Try
            End While
        End Using
        MsgBox("Saved")
    End Sub

    Private Sub tmrSave_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSave.Tick

    End Sub

    Private Sub btnBuild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuild.Click
        Dim form2 As New rocketBuilder ' instatiating a new assumptions form to display
        form2.loadRocket(mainSimulation.mainRocket) ' links rocket by association/aggregation
        form2.ShowDialog() ' show as a dialog (main form is disabled)
    End Sub

    Private Sub btnSetGoal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetGoal.Click
        If IsNumeric(txtGoal.Text) Then ' check to make sure the text box is actually a number
            mainSimulation.setGoal = txtGoal.Text ' set the main simulation's goal to the text in the "goal" text box
            Me.Refresh() ' refresh the screen so that the goal displays in the correct place on the grid
        Else ' if it's not:
            MsgBox("Please only enter numbers.") ' tell the user to only enter numbers
            txtGoal.Text = "100" ' reset the text box to 100 to deter them from doing it again
        End If
    End Sub
End Class
