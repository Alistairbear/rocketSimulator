Public Class simulation

    ' NOT ANNOTATED

    Public mainRocket As rocket
    Private floor As Boolean = True
    Private finiteFuel As Boolean = False
    Private massDecay As Boolean = True
    Private vacuum As Boolean = False
    Private airThinning As Boolean = False
    Private gravityThinning As Boolean = False

    Public Enum celestial
        mercury
        venus
        earth
        mars
        jupiter
        saturn
        uranus
        neptune
        pluto
        moon
        sun
        neutron
    End Enum

    ' Stores the initial conditions for the rocket
    ' displacement, velocity, acceleration, thrust
    Public initialValues() As vectorQuantity = {New vectorQuantity, New vectorQuantity, New vectorQuantity, New vectorQuantity}

    Dim path As String ' This stores the location of the temporary export data .csv file
    Private t As Single = 0.0 ' stores the current time (since launch) for the simulation
    Public gravity As Single ' Stores the acceleration due to gravity
    Private drag As Single

    Private axisStart As New vectorQuantity ' this is used to keep track of what value the axis should start at
    Private particleLocation As New vectorQuantity ' This keeps track of the fixed position where the particle is on the screen
    Private scale As Integer = 1 ' This is the scale for the simulation output. It can be interpretted as n pixels per meter.
    Private particleSize As Single = 30
    Private goal As New goal ' Stores the vertical displacement at which the goal is currently set

    Sub New(ByVal drag As Single, ByVal goal As Single, ByVal planet As celestial)
        Dim radius As Single
        Dim planetMass As Single
        Select Case planet
            Case celestial.earth
                radius = 6
                planetMass = 0
        End Select
        Me.gravity = 9.81
        Me.drag = drag
        Me.goal.setGoal(goal)
        particleLocation.x = 270
        particleLocation.y = 255
        mainRocket = New rocket(vacuum, floor, airThinning, gravityThinning, drag, gravity, massDecay, finiteFuel, initialValues)
        path = IO.Path.Combine(My.Application.Info.DirectoryPath, "temp.csv")
        ' This adds the titles for the table of data to the output spreadsheet
        Dim output As String = "time, mass, displacement x, displacement y, displacement, velocity x, velocity y, velocity, acceleration x, acceleration y, acceleration" & vbCrLf
        My.Computer.FileSystem.WriteAllText(path, output, False) ' adds the string to the output .csv file. path is the location, output is the string to be added and false means don't append, overwrite instead
    End Sub

    Public Sub refreshRocket()
        mainRocket = New rocket(vacuum, floor, airThinning, gravityThinning, drag, gravity, massDecay, finiteFuel, initialValues)
    End Sub

    Public Sub drawAxes(ByRef g As Graphics)

        ' draw the sky
        g.FillRectangle(Brushes.LightSkyBlue, 20, 5, 500, 500)

        If floor Then ' if there is a floor
            If mainRocket.displacement.y < 250 * scale Then ' if the rocket is near the floor
                g.FillRectangle(Brushes.LightGreen, 20, particleLocation.y + mainRocket.displacement.y, 500, (scale * 250) - mainRocket.displacement.y) ' draw in the floor
            End If
        End If

        axisStart.x = (mainRocket.displacement.x * -scale) Mod 50
        axisStart.y = (mainRocket.displacement.y * -scale) Mod 50
        While axisStart.x >= 50
            axisStart.x = axisStart.x Mod 50
        End While

        While axisStart.y >= 50
            axisStart.y = axisStart.y Mod 50
        End While


        ' draw the lines marking the axis points

        For i As Integer = 0 To 450 Step scale * 50 ' y axis
            g.DrawLine(Pens.LightGray, 15, 455 - axisStart.y - i, 520, 455 - axisStart.y - i)
        Next
        For i As Integer = 0 To 450 Step scale * 50 ' x axis
            g.DrawLine(Pens.LightGray, 70 + i + axisStart.x, 510, 70 + i + axisStart.x, 5)
        Next

        ' draw the particle
        g.DrawEllipse(Pens.Black, particleLocation.x - particleSize / 2, particleLocation.y - particleSize / 2, particleSize, particleSize)

        'draw the axes
        g.DrawLine(Pens.Black, 20, 5, 20, 505) ' y axis
        g.DrawLine(Pens.Black, 20, 505, 520, 505) ' x axis

        ' draw the goal line
        If Not goal.isGoalReached(mainRocket.displacement.y) Then
            If mainRocket.displacement.y >= (goal.height * scale) - 250 And mainRocket.displacement.y <= (goal.height * scale) + 250 Then
                g.DrawLine(Pens.Red, 15, mainRocket.displacement.y - goal.height + 255, 520, mainRocket.displacement.y - goal.height + 255)
            End If
        End If

        'draw the rocket and it's forces.
        'mainRocket.drawForces(g, New vectorQuantity, particleLocation)


    End Sub

    Sub export()
        Dim variables As String() = {t / 1000, mainRocket.mass, mainRocket.displacement.x, mainRocket.displacement.y, mainRocket.displacement.magnitude, mainRocket.velocity.x, mainRocket.velocity.y, mainRocket.velocity.magnitude, mainRocket.acceleration.x, mainRocket.acceleration.y, mainRocket.acceleration.magnitude}
        Dim output As String = String.Empty
        For Each value In variables
            output += value & ", "
        Next
        If goal.export Then
            output += "Goal Reached"
        End If
        output += vbCrLf
        Try ' In a try statement because it can be a bit unstable when running off a usb in college
            My.Computer.FileSystem.WriteAllText(path, output, True)
        Catch
        End Try
    End Sub

    Public Property time As Single
        Get
            Return t
        End Get
        Set(ByVal value As Single)
            t = value
        End Set
    End Property

    Public Sub restart()
        mainRocket.reset()
        goal.resetGoal()
    End Sub

    Public WriteOnly Property finiteFuelEdit As Boolean
        Set(ByVal value As Boolean)
            finiteFuel = value
        End Set
    End Property

    Public Property massDecayEdit As Boolean
        Get
            Return massDecay
        End Get
        Set(ByVal value As Boolean)
            massDecay = value
        End Set
    End Property

    Public Property vacuumEdit As Boolean
        Get
            Return vacuum
        End Get
        Set(ByVal value As Boolean)
            vacuum = value
        End Set
    End Property

    Public Property floorEdit As Boolean
        Get
            Return floor
        End Get
        Set(ByVal value As Boolean)
            floor = value
        End Set
    End Property

    Public Property airThinningEdit As Boolean
        Get
            Return airThinning
        End Get
        Set(ByVal value As Boolean)
            airThinning = value
        End Set
    End Property

    Public Property gravityThinningEdit As Boolean
        Get
            Return gravityThinning
        End Get
        Set(ByVal value As Boolean)
            gravityThinning = value
        End Set
    End Property

    Public ReadOnly Property particleAnchor As vectorQuantity
        Get
            Return particleLocation
        End Get
    End Property

    Public WriteOnly Property setGoal As Single
        Set(ByVal value As Single)
            goal.setGoal(value)
        End Set
    End Property



End Class
