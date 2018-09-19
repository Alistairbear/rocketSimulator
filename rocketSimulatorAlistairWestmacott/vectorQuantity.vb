Public Class vectorQuantity

    ' COMPLETELY ANNOTATED

    Public penColour As Pen 'this represents the colour to represent the vector

    Protected components(1) As Single ' stores the x and y components in one array to make it easier to refer to

    Public Sub New()
        components(0) = 0.0 ' sets x component to 0
        components(1) = 0.0 ' sets y component to 0
    End Sub

    'this sub is used to reset the vector (eg when the simulation ends)
    Public Sub reset()
        components(0) = 0.0 ' resets x component
        components(1) = 0.0 ' resets y component
    End Sub

    Public Property x As Single ' Simply returns or sets the x component
        Get
            Return components(0)
        End Get
        Set(ByVal value As Single)
            components(0) = value
        End Set
    End Property

    Public Property y As Single ' returns or sets the y component
        Get
            Return components(1)
        End Get
        Set(ByVal value As Single)
            components(1) = value
        End Set
    End Property

    ' This returns the component of a vector in a given angle to the normal (say you were measuring down a slope for example)
    Public Function angleComponent(ByVal angle As Single, ByVal x As Boolean) As Single ' x is a boolean value to determine whether or not to return the x component in that direction (hard to explain but very useful)
        If x Then
            angle = 90 - angle ' it basically means you return the component 90 degrees to the angle you provided
        End If
        Return Me.magnitude * Math.Cos(angle) ' returns the magnitude of this vector times the cos of the angle.
    End Function

    'Public Property vector As Single() ' This here is to make iterating through the movement of the rocket much easier to loop
    '    Get
    '        Return components
    '    End Get
    '    Set(ByVal value As Single())
    '        components = value ' This is the first problem with the code. The other element in value needs to be retrieved from the vector in question which is messy and not nice
    '    End Set
    'End Property

    Public ReadOnly Property unit As vectorQuantity
        Get
            If Me.magnitude = 0 Then
                Dim temp As New vectorQuantity
                temp.y = 1
                Return temp
            Else
                Return Me / Me.magnitude
            End If

        End Get
    End Property

    Public ReadOnly Property magnitude As Single
        Get
            Dim pythagoras As Single ' Pythagoras is a temporary variable used to store the result of a pythagoras' theorem calculation
            pythagoras += components(0) ^ 2 ' add the square of the x component
            pythagoras += components(1) ^ 2 ' add the square of the y component
            Return Math.Sqrt(pythagoras) ' square root the result and return it
        End Get
    End Property

    ' This returns the result of tan^-1 of the y component over the x component or in other words the angle to the normal (straight upwards)
    Public ReadOnly Property angle As Single
        Get
            Return Math.Atan(components(0) / components(1)) ' y over x so that the angle is to the normal 
        End Get
    End Property

    ' declaring the function which allows you to easily find the resultant of two vectors
    Public Shared Operator +(ByVal v1 As vectorQuantity, ByVal v2 As vectorQuantity) As vectorQuantity
        Dim sum As New vectorQuantity ' instantiating a temporary vectorQuantity to work on
        sum.x = v1.x + v2.x ' summing the two x components
        sum.y = v1.y + v2.y ' summing the two y components
        Return sum
    End Operator

    ' declaring the function which allows you to easily find the resultant of two vectors
    Public Shared Operator -(ByVal v1 As vectorQuantity, ByVal v2 As vectorQuantity) As vectorQuantity
        Dim sum As New vectorQuantity ' instantiating a temporary vectorQuantity to work on
        sum.x = v1.x - v2.x ' summing the two x components
        sum.y = v1.y - v2.y ' summing the two y components
        Return sum
    End Operator

    ' This subprocess is used to increase the magnitude by a scalar
    Public Shared Operator *(ByVal v1 As vectorQuantity, ByVal scalar As Single) As vectorQuantity
        Dim vectorResult As New vectorQuantity
        vectorResult.x = v1.x * scalar ' x component multiplied by scalar
        vectorResult.y = v1.y * scalar ' y component multiplied by scalar
        Return vectorResult
    End Operator

    ' This subprocess is used to divide the magnitude of the vector by the scalar
    Public Shared Operator /(ByVal v1 As vectorQuantity, ByVal scalar As Single) As vectorQuantity
        Dim vectorResult As New vectorQuantity
        vectorResult.x = v1.x / scalar ' x component multiplied by scalar
        vectorResult.y = v1.y / scalar ' y component multiplied by scalar
        Return vectorResult
    End Operator

    ' used to rotate a vector by an angle
    Public Function rotate(ByVal angle As Single) As vectorQuantity
        Dim transformation(1, 1) As Single ' creates a new (empty) transformation matrix
        Dim result As New vectorQuantity
        Dim oldMagnitude As Single = Me.magnitude ' records old magnitude so that it can't increase
        transformation(0, 0) = Math.Cos(angle)
        transformation(1, 0) = -Math.Sin(angle) ' / cosx  -sinx \
        transformation(0, 1) = Math.Sin(angle) '  \ sinx   cosx / is a transformation matrix which rotates a vector by x degrees
        transformation(1, 1) = Math.Cos(angle)
        result.x = Me.x * transformation(0, 0) + Me.y * transformation(0, 1) ' calculates new x coordinate
        result.y = Me.x * transformation(1, 0) + Me.y * transformation(1, 1) ' calculated new y coordinate
        result /= result.magnitude ' turns new vector into a unit vector
        result *= Me.magnitude ' multiplies by old magnitude so that it hasn't increased/decreased

        Return result
    End Function

    ' This property represents the colour used to draw the vector it's mostly used so that rather than having to call an individual pen, you can call vector.pen(). It makes code cleaner
    Public Property pen() As Pen
        Get
            Return penColour
        End Get
        Set(ByVal value As Pen)
            penColour = value ' set the pen colour. This still needs to be implemented
        End Set
    End Property

End Class
