Public Class simulation

    ' NOT ANNOTATED

    ' lines to check: 9, 10, 57

    Public mainRocket As rocket ' instatiating the rocket in the simulation

    ' ALL OF THESE ASSUMPTIONS NEED TO BE ACCUMULATED INTO ONE ARRAY SO IT IS EASIER TO MODIFY THE NUMBER OF ASSUMPTIONS

    Private floor As Boolean = True ' stores whether a floor is to be used
    Private finiteFuel As Boolean = False ' UNNECESSARY stores whether the rocket burns fuel as it launches
    Private massDecay As Boolean = True ' NEEDS TO BE RENAMED stores whether the program uses rocket mode or not
    Private vacuum As Boolean = False ' whether the simulation is a vacuum
    Private airThinning As Boolean = False ' whether the air density gets lower as altitude increases
    Private gravityThinning As Boolean = False ' whether gravitational field strength decreases as altitude increases. I.e. whether a uniform field is assumed


    Private mainPlanet As celestial ' Holds the planet being used for this simulation. Needs to be used so that it changes within hte simulation when the user changes the planet on the form

    Private escapeVConst As Single = Math.Sqrt(2 * 6.67 * 6 * 10 ^ 13) ' stores the square root of 2 * G * mass of earth, used to determine the escape velocity for a given planet

    Public Enum celestial
        ' this enum lets you choose one of the available celestial bodies, makes declaring dictionaries and passing variables easier.
        ' Public so that other classes can pass this enum into function in this class
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
    End Enum

    Private radius As New Dictionary(Of celestial, Single) ' stores the radii of each celestial body in a dictionary so it is easily found
    Private celestialMass As New Dictionary(Of celestial, Single) ' stores the mass of each celestial body in a dictionary so it is easily found
    Private groundColour As New Dictionary(Of celestial, Brush) ' stores the ground colour of each celestial body in a dictionary so it is easily found 
    Private skyColour As New Dictionary(Of celestial, Brush) ' stores the sky colour of each celestial body in a dictionary so it is easily found

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
    Private particleSize As Single = 30 ' this is the radius of the circle drawn on screen. it is completely visual and not required at all for physics calculations in the program
    Private goal As New goal ' Stores the vertical displacement at which the goal is currently set

    Sub New(ByVal drag As Single, ByVal goal As Single)
        initialiseDictionaries() ' populate the dictionaries with data
        mainPlanet = celestial.earth ' the simulation needs a planet to begin so earth is chosen as it is the most common used in A-level questions
        Me.gravity = 9.81 ' UNSURE OF USE gravity is calculated in other parts of the program and is independant of other gravitational values
        Me.drag = drag ' this holds the drag constant. Similar to before the drag calculations need to be revamped so they are physically accurate
        Me.goal.setGoal(goal) ' creates the goal point for this simulation
        particleLocation.x = 270 ' x coordinate of where the particle is onscreen
        particleLocation.y = 255 ' y coordinate of where the particle is onscreen
        mainRocket = New rocket(vacuum, floor, airThinning, gravityThinning, drag, massDecay, finiteFuel, initialValues, celestialMass(celestial.earth), radius(celestial.earth)) ' set the rocket to a new rocket with the current initial values.
        path = IO.Path.Combine(My.Application.Info.DirectoryPath, "temp.csv") ' locate the csv file which holds the temporary simulation data before it is saved
        ' This adds the titles for the table of data to the output spreadsheet
        Dim output As String = "time, mass, displacement x, displacement y, displacement, velocity x, velocity y, velocity, acceleration x, acceleration y, acceleration" & vbCrLf
        My.Computer.FileSystem.WriteAllText(path, output, False) ' adds the string to the output .csv file. path is the location, output is the string to be added and false means don't append, overwrite instead
    End Sub

    ' adds radius, mass, ground colour and sky colour of all celestial bodies in dictionaries
    Private Sub initialiseDictionaries()

        ' radius of planet
        ' mass of planet
        ' groundcolour of planet
        ' skycolour of planet

        radius.Add(celestial.mercury, 2440000.0) ' mercury
        celestialMass.Add(celestial.mercury, 3.285E+23)
        groundColour.Add(celestial.mercury, Brushes.DarkSlateGray)
        skyColour.Add(celestial.mercury, Brushes.Black)

        radius.Add(celestial.venus, 6052000.0) ' venus
        celestialMass.Add(celestial.venus, 4.867E+24)
        groundColour.Add(celestial.venus, Brushes.Olive)
        skyColour.Add(celestial.venus, Brushes.Yellow)

        radius.Add(celestial.earth, 6371000.0) ' earth
        celestialMass.Add(celestial.earth, 5.972E+24)
        groundColour.Add(celestial.earth, Brushes.LightGreen)
        skyColour.Add(celestial.earth, Brushes.LightSkyBlue)

        radius.Add(celestial.mars, 3390000.0) ' mars
        celestialMass.Add(celestial.mars, 6.39E+23)
        groundColour.Add(celestial.mars, Brushes.Chocolate)
        skyColour.Add(celestial.mars, Brushes.BurlyWood)

        radius.Add(celestial.jupiter, 69911000.0) ' jupiter
        celestialMass.Add(celestial.jupiter, 1.898E+27)
        groundColour.Add(celestial.jupiter, Brushes.Chocolate)
        skyColour.Add(celestial.jupiter, Brushes.Black)

        radius.Add(celestial.saturn, 58232000.0) ' saturn
        celestialMass.Add(celestial.saturn, 5.683E+26)
        groundColour.Add(celestial.saturn, Brushes.DarkKhaki)
        skyColour.Add(celestial.saturn, Brushes.Black)

        radius.Add(celestial.uranus, 25362000.0) ' uranus
        celestialMass.Add(celestial.uranus, 8.681E+25)
        groundColour.Add(celestial.uranus, Brushes.DeepSkyBlue)
        skyColour.Add(celestial.uranus, Brushes.Black)

        radius.Add(celestial.neptune, 24622000.0) ' neptune
        celestialMass.Add(celestial.neptune, 1.024E+26)
        groundColour.Add(celestial.neptune, Brushes.CornflowerBlue)
        skyColour.Add(celestial.neptune, Brushes.Black)

        radius.Add(celestial.pluto, 1188000.0) ' pluto
        celestialMass.Add(celestial.pluto, 1.309E+22)
        groundColour.Add(celestial.pluto, Brushes.Chocolate)
        skyColour.Add(celestial.pluto, Brushes.Black)

        radius.Add(celestial.moon, 1737000.0) ' moon
        celestialMass.Add(celestial.moon, 7.348E+22)
        groundColour.Add(celestial.moon, Brushes.DimGray)
        skyColour.Add(celestial.moon, Brushes.Black)

        radius.Add(celestial.sun, 695508000.0) ' sun
        celestialMass.Add(celestial.sun, 1.989E+30)
        groundColour.Add(celestial.sun, Brushes.White)
        skyColour.Add(celestial.sun, Brushes.Black)

    End Sub

    Public Sub updatePlanet(ByVal planet As celestial) ' this sub is called when the user changes the planet used on the form
        mainPlanet = planet ' reset the planet in this class
        mainRocket.updatePlanet(celestialMass(planet), radius(planet)) ' reset the celestial values for the rocket to calculate it's gravitational force of attraction
    End Sub

    Public Sub refreshRocket() ' reset the rocket. Used when the initial values or assumptions are changed by the user
        mainRocket = New rocket(vacuum, floor, airThinning, gravityThinning, drag, massDecay, finiteFuel, initialValues, celestialMass(mainPlanet), radius(mainPlanet))
    End Sub

    Public Sub drawAxes(ByVal colours As Boolean, ByRef g As Graphics)

        ' draw the sky
        If colours Then
            g.FillRectangle(skyColour(mainPlanet), 20, 5, 500, 500)
        Else
            g.FillRectangle(skyColour(celestial.earth), 20, 5, 500, 500)
        End If


        If floor Then ' if there is a floor
            If mainRocket.displacement.y < 250 * scale Then ' if the rocket is near the floor
                If colours Then
                    ' draw in the floor
                    g.FillRectangle(groundColour(mainPlanet), 20, particleLocation.y + mainRocket.displacement.y, 500, (scale * 250) - mainRocket.displacement.y)
                Else
                    g.FillRectangle(groundColour(celestial.earth), 20, particleLocation.y + mainRocket.displacement.y, 500, (scale * 250) - mainRocket.displacement.y)
                End If
            End If
        End If

        ' draw the gridlines
        axisStart.x = (mainRocket.displacement.x * -scale) Mod 50 ' modulo 50 because the grid lines are drawn every 50 pixels
        axisStart.y = (mainRocket.displacement.y * -scale) Mod 50
        'While axisStart.x >= 50
        '    axisStart.x = axisStart.x Mod 50
        'End While

        'While axisStart.y >= 50
        '    axisStart.y = axisStart.y Mod 50
        'End While


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

    Public Function escaped() As Boolean
        If mainRocket.velocity.y > escapeVConst / (Math.Sqrt(radius(mainPlanet) + mainRocket.displacement.y)) Then ' if the y component of the rocket's velocity is greater than the body's escape velocity
            Return True ' the rocket has escaped so return true
        End If
        Return False ' otherwise return false
    End Function

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
