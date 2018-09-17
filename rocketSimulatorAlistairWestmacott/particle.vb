Public Class particle

    ' PARTIALLY ANNOTATED

    Protected s As New vectorQuantity ' displacement
    Protected v As New vectorQuantity ' velocity
    Protected a As New vectorQuantity ' acceleration
    Protected m As Single ' mass


    Protected forces As New List(Of vectorQuantity)
    Protected weightForce As New vectorQuantity ' weight
    Protected dragForce As New vectorQuantity ' drag
    Protected thrustForce As New vectorQuantity ' thrust
    Protected normalForce As New vectorQuantity ' normal reaction (for when the rocket is touching the ground)

    Protected massDecay As Boolean = False
    Protected finiteFuel As Boolean = False
    Protected vacuum As Boolean = False
    Protected floor As Boolean = True
    Protected airThinning As Boolean = False
    Protected gravityThinning As Boolean = False

    Protected dragConst As Single
    Protected gravity As Single
    Protected gravityConst As Single

    Protected gravityUnitVector As New vectorQuantity
    Protected xUnitVector As New vectorQuantity
    Protected earthCentre As New vectorQuantity

    'Protected mainSpring As spring

    Public Sub New(ByVal vacuum As Boolean, ByVal floor As Boolean, ByVal airThinning As Boolean, ByVal gravityThinning As Boolean, ByVal dragConst As Single, ByVal gravity As Single, ByVal massDecay As Boolean, ByVal finiteFuel As Boolean, ByVal initialValues As vectorQuantity())
        Me.vacuum = vacuum
        Me.floor = floor
        Me.dragConst = dragConst
        Me.gravity = gravity
        Me.gravityConst = gravity * 6400000 ^ 2 ' used as a constant for use in the gravity depleting equation. 6400 000 is the radius of the earth in metres
        Me.massDecay = massDecay
        Me.finiteFuel = finiteFuel
        Me.airThinning = airThinning
        Me.gravityThinning = gravityThinning

        weightForce.pen = Pens.Blue
        dragForce.pen = Pens.DarkGray
        thrustForce.pen = Pens.Red
        normalForce.pen = Pens.Green

        'forces.Add(weightForce)
        'forces.Add(dragForce)
        'forces.Add(thrustForce)
        'forces.Add(normalForce)

        Me.s = initialValues(0)
        Me.v = initialValues(1)
        Me.a = initialValues(2)
        Me.thrust = initialValues(3)


        earthCentre.y = -6400000

        xUnitVector.x = -1
    End Sub

    Public Overridable Sub nextFrame(ByVal time As Single, ByVal g As Graphics)

        gravityUnitVector.y = -1
        'gravityUnitVector = earthCentre - s
        'gravityUnitVector /= gravityUnitVector.magnitude

        If gravityThinning Then
            gravity = (6.67 * 5.972 * (10 ^ 13)) / ((6371000 + s.y) ^ 2)
        End If

        If Not vacuum Then
            If airThinning Then
                If displacement.y > 100000 Then
                    dragConst = 0.0
                Else
                    'dragConst = (100000 - displacement.y) / 100000
                    'dragConst = 1 / (displacement.y + 200)

                    dragConst = dragConst * 1.22 * Math.Exp(-s.y / 15000)
                End If
            End If
            dragForce = v * -dragConst * v.magnitude ' Drag from air resistance
        End If

        'dragForce = xUnitVector * normalForce.magnitude * (-1 / v.magnitude) ' Drag from the floor

        normalForce.reset()

        'thrustForce = mainSpring.tension() ' + secondSpring.tension('mainSpring.anchor)

        weightForce = gravityUnitVector * gravity * m

        a = resultantForce(True) / m ' a = f / m (rearrangement of F=ma)
        s += v * time + a * 0.5 * time ^ 2 ' s = s_0 + ut + 0.5at^2
        v += a * time ' v = u + at

        If floor Then
            If s.y <= 0 And v.y < 0 Then
                v.y = 0
                s.y = 0
                normalForce = gravityUnitVector * -resultantForce(False).magnitude
            End If
        End If

    End Sub

    Protected Function resultantForce(ByVal normal As Boolean) As vectorQuantity

        resultantForce = weightForce + dragForce + thrustForce
        If normal Then
            resultantForce += normalForce
        End If

    End Function

    Public Overridable Sub drawForces(ByRef g As Graphics, ByVal startPosition As vectorQuantity, ByVal particlePosition As vectorQuantity)
        For Each forceIndex In forces
            g.DrawLine(Pens.Purple, particlePosition.x + startPosition.x, particlePosition.y - startPosition.y, particlePosition.x + startPosition.x + forceIndex.x, particlePosition.y - startPosition.y - forceIndex.y)
        Next

        'g.DrawLine(Pens.Blue, 280 + startPosition.x, 310 - startPosition.y, 280 + startPosition.x + weightForce.x, 310 - startPosition.y - weightForce.y)
        'g.DrawLine(Pens.DarkGray, 280 + startPosition.x, 310 - startPosition.y, 280 + startPosition.x + dragForce.x, 310 - startPosition.y - dragForce.y)
        'g.DrawLine(Pens.Red, 280 + startPosition.x, 310 - startPosition.y, 280 + startPosition.x + thrustForce.x, 310 - startPosition.y - thrustForce.y)
        'g.DrawLine(Pens.Green, 280 + startPosition.x, 310 - startPosition.y, 280 + startPosition.x + normalForce.x, 310 - startPosition.y - normalForce.y)

        g.DrawLine(Pens.Blue, particlePosition.x + startPosition.x, particlePosition.y - startPosition.y, particlePosition.x + startPosition.x + (weightForce.x / 100000), particlePosition.y - startPosition.y - (weightForce.y / 100000))
        g.DrawLine(Pens.DarkGray, particlePosition.x + startPosition.x, particlePosition.y - startPosition.y, particlePosition.x + startPosition.x + (dragForce.x / 100000), particlePosition.y - startPosition.y - (dragForce.y / 100000))
        g.DrawLine(Pens.Red, particlePosition.x + startPosition.x, particlePosition.y - startPosition.y, particlePosition.x + startPosition.x + (thrustForce.x / 100000), particlePosition.y - startPosition.y - (thrustForce.y / 100000))
        g.DrawLine(Pens.Green, particlePosition.x + startPosition.x, particlePosition.y - startPosition.y, particlePosition.x + startPosition.x + (normalForce.x / 100000), particlePosition.y - startPosition.y - (normalForce.y / 100000))
    End Sub

    Public Sub updateLabels(ByRef lblHeight As Windows.Forms.Label, ByRef lblSpeed As Windows.Forms.Label, ByRef lblAcc As Windows.Forms.Label)
        lblHeight.Text = "Altitude: " & s.y
        lblSpeed.Text = "Speed: " & v.magnitude
        lblAcc.Text = "Acceleration: " & a.magnitude
    End Sub

    Public Sub attach(ByVal attachment As spring)
        'mainSpring = attachment
    End Sub

    Public ReadOnly Property displacement As vectorQuantity
        Get
            Return s
        End Get
    End Property
    Public ReadOnly Property velocity As vectorQuantity
        Get
            Return v
        End Get
    End Property

    Public ReadOnly Property acceleration As vectorQuantity
        Get
            Return a
        End Get
    End Property

    Public ReadOnly Property mass As Single
        Get
            Return m
        End Get
    End Property

    Public Property thrust As vectorQuantity
        Get
            Return thrustForce
        End Get
        Set(ByVal value As vectorQuantity)
            thrustForce = value
        End Set
    End Property

    Public Property weight As vectorQuantity
        Get
            Return weightForce
        End Get
        Set(ByVal value As vectorQuantity)
            weightForce = value
        End Set
    End Property

    Public Sub reset()
        s.reset()
        v.reset()
        a.reset()

        weightForce.reset()
    End Sub

    Private Sub drawArrow(ByVal pen As Pen, ByVal force As vectorQuantity, ByRef g As Graphics)
        If force.magnitude > 1 Then
            g.DrawLine(pen, 280, 310, 280 + force.x, 310 - force.y)

            g.DrawLine(pen, 280 + force.x, 310 - force.x, 280 + force.x + force.rotate(45).x * 10 / force.magnitude, 310 - force.y - force.rotate(45).y * 10 / force.magnitude)
            g.DrawLine(pen, 280 + force.x, 310 - force.x, 280 + force.x + force.rotate(45).x * 10 / force.magnitude, 310 - force.y - force.rotate(45).x * 10 / force.magnitude)
        End If
    End Sub
End Class
