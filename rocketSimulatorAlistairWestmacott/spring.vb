Public Class spring

    ' NOT ANNOTATED
    ' Also currently not used, this was more of an experiment just to see how springs would behave  in my physics engine

    Inherits particle

    Protected modulusOfElasticity As Single

    Protected naturalLength As Single

    Private connected As particle

    Public name As Integer = 0

    Protected snap As Boolean

    Sub New(ByVal vacuum As Boolean, ByVal floor As Boolean, ByVal airThinning As Boolean, ByVal gravityThinning As Boolean, ByVal dragConst As Single, ByVal mass As Single, ByVal massDecay As Boolean, ByVal finiteFuel As Boolean, ByVal lambda As Single, ByVal length As Single, ByVal anchorX As Single, ByVal anchorY As Single, ByVal name As Integer, ByVal initialValues As vectorQuantity(), ByVal planetMass As Double, ByVal planetRadius As Double)
        MyBase.New(vacuum, floor, airThinning, gravityThinning, dragConst, massDecay, finiteFuel, initialValues, planetMass, planetRadius)
        modulusOfElasticity = lambda
        naturalLength = length
        displacement.x = anchorX
        displacement.y = anchorY
        Me.m = 1
        Me.name = name
    End Sub

    Public Sub connect(ByVal toConnect As particle)
        connected = toConnect
    End Sub

    Public Function vectorRepresentation() As vectorQuantity
        Return displacement - connected.displacement
    End Function

    Public Function extensionVector() As vectorQuantity
        Dim result As vectorQuantity
        result = vectorRepresentation() / vectorRepresentation().magnitude
        result *= (vectorRepresentation().magnitude - naturalLength)
        Return result
    End Function

    Public Overridable Function tension() As vectorQuantity
        If Not snap Then
            Return extensionVector() * modulusOfElasticity / naturalLength
        Else
            Return New vectorQuantity
        End If
    End Function

    Public Sub drawWhatNow(ByVal mainPen As Pen, ByVal g As Graphics, ByVal startPoint As vectorQuantity)
        g.DrawLine(mainPen, 280 + startPoint.x, 310 - startPoint.y, 280 + vectorRepresentation().x, 310 - vectorRepresentation().y)
    End Sub

    Public Overrides Sub nextframe(ByVal time As Single, ByVal g As System.Drawing.Graphics)
        'thrustForce = 'mainSpring.tension(s) ' + secondSpring.tension('mainSpring.displacement)
        'If Not mainSpring Is Nothing Then
        'thrustForce = mainSpring.tension()
        'End If

        MyBase.nextFrame(time, g)
    End Sub

    Public Sub drawSpring(ByRef g As Graphics, ByVal startPoint As vectorQuantity, ByVal particlePosition As vectorQuantity)

        MyBase.drawForces(g, startPoint, particlePosition)

        'If Not 'mainSpring Is Nothing Then
        'mainSpring.drawSpring(Pens.Purple, g, 'mainSpring.vectorRepresentation())
        If name = 1 Then
            g.DrawLine(Pens.Purple, 280 + startPoint.x, 310 - startPoint.y, 280 + vectorRepresentation().x, 310 - vectorRepresentation().y)
        Else
            g.DrawLine(Pens.DarkCyan, 280 + startPoint.x, 310 - startPoint.y, 280 + vectorRepresentation().x, 310 - vectorRepresentation().y)
        End If
        'End If
    End Sub

    Public Sub snapped()

    End Sub

    Public WriteOnly Property setPivot As vectorQuantity
        Set(ByVal value As vectorQuantity)
            s = value
        End Set
    End Property
End Class
