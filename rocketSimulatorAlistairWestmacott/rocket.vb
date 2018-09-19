Public Class rocket

    ' BARELY ANNOTATED

    'thrust
    'fuel mass
    'rocket mass

    'So dm/dt is usually called the 'mass flow rate' as it's usefully conserved;
    'the loss in fuel mass = the amount of mass being jettisoned at exhaust velocity V.
    'Typical exhaust velocities for most rockets (even mini ones) are a couple of thousand m/s.
    'Pick a radius for your rocket engine, and density of exhaust gases, typically about 1kg/m3, 
    'and you can use m = 1 x pi r-squared v to find the mass flow per second, and hence mass flow rate.
    'So here I guess you'd just need to decide on an r to use and the rest should work out.

    'In a large rocket like Saturn V, each booster had a mass flow rate of 13tonnes/sec;
    'about 0.4% of the initial mass of the rocket each second. I should imagine this percentage could be applied to any rocket;
    'though bear in mind this did launch it to the moon!

    ' remove form1 variable if possible

    Inherits particle
    
    Private bounce As Boolean = True
    Private e As Single = 0.8

    Private fuelMass As Single
    Private mechanicalMass As Single
    Private rocketThrust As Single
    Private dmdt As Single
    Private exhaustV As Single
    Private radius As Single

    Private startFuel As Single

    'Private forces As New List(Of vectorQuantity)

    'Private form1 As Form

    Public Sub New(ByVal vacuum As Boolean, ByVal floor As Boolean, ByVal airThinning As Boolean, ByVal gravityThinning As Boolean, ByVal dragConst As String, ByVal massDecay As Boolean, ByVal finiteFuel As Boolean, ByVal initialValues As vectorQuantity(), ByVal planetMass As Double, ByVal planetRadius As Double)

        MyBase.New(vacuum, floor, airThinning, gravityThinning, dragConst, massDecay, finiteFuel, initialValues, planetMass, planetRadius)
        loadNewRocket("default.rkt")
    End Sub

    Public Sub loadNewRocket(ByVal path As String)
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(path)
            'Dim count As Integer
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()

            currentRow = MyReader.ReadFields()
            mechanicalMass = currentRow(0)
            currentRow = MyReader.ReadFields()
            fuelMass = currentRow(0)
            startFuel = currentRow(0)
            radius = currentRow(1)
            exhaustV = currentRow(2)

            dmdt = Math.PI * exhaustV * (radius ^ 2)
        End Using
    End Sub

    Public Overrides Sub nextframe(ByVal time As Single, ByVal g As System.Drawing.Graphics)

        If massDecay Then ' The maths here needs to be properly calculated
            If fuelMass > 0 Then ' thrust is based on thrusters and fuel mass is based on tank used

                ' thrustForce = V_e * dm/dt

                ' this line of code assumes the rocket is two dimentional and can tilt not just 
                'thrustForce = velocity.unit * -exhaustV * dmdt

                'fuelMass -= rocketThrust * 10 / time ' This needs to be properly calculated

                fuelMass -= dmdt * time
                If fuelMass < 0 Then
                    fuelMass = 0
                End If
                thrustForce.x = 0
                'thrustForce.y = rocketThrust
                'thrustForce.y = exhaustV * dmdt
                thrustForce = velocity.unit * exhaustV * dmdt
            Else
                thrustForce.reset()
            End If
        End If

        m = fuelMass + mechanicalMass



        'If 'mainSpring.tension(s).magnitude > 100 Then
        '    'mainSpring.snapped() = True
        'End If

        'thrustForce = mainSpring.tension() ' + secondSpring.tension('mainSpring.displacement)

        MyBase.nextFrame(time, g)

    End Sub

    Public Sub control()
        thrustForce = thrustForce.rotate(1)
    End Sub

    Public ReadOnly Property fuelPercent As Integer
        Get
            Return 100 * fuelMass / startFuel
        End Get
    End Property

End Class
