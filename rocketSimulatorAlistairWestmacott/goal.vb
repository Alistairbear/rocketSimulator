Public Class goal ' This class makes goal management a lot easier.

    ' COMPLETELY ANNOTATED

    Private goalHeight As Single ' Holds the height of the goal
    Private reachedByParticle As Boolean ' True or false, represents whether the goal has been reached or not
    Private toExport As Boolean ' this variable is hard to explain and it makes more sense when reading the export() and isGoalReached() functions

    ' This sub is for setting the goal
    Public Sub setGoal(ByVal value As Single) ' having a separate sub for this makes the code easier to read
        goalHeight = value ' sets the height to the value provided
        reachedByParticle = False ' This is included so that the goal is reset in the simulation when it is set
    End Sub


    'When exporting the data from the simulation, the program adds the word goal reached to the spreadsheet at the point the goal was reached to make analysis easier.
    Public Function export() As Boolean
        export = False ' The result of the function is set to the default value of false.
        If toExport Then ' if the word "goal reached" has not yet been exported (ie it is to be exported) then:
            export = True ' the result of the function is set to true meaning the value will be exported
        End If
        toExport = False ' the value of toExport is then reset to false so that the program doesn't export it again the next loop round.
    End Function

    ' This returns false when the goal has not been reached yet, ie it needs to be displayed on screen
    Public Function isGoalReached(ByVal particleHeight As Single) As Boolean ' takes the particle's height as a parameter
        If reachedByParticle Then Return True ' firstly checks to see whether the particle has already reached the goal and if so, no more computation is required and the function immediately returns true
        ' otherwise:
        If particleHeight > goalHeight Then ' if the particle's current height is higher than the goal then
            reachedByParticle = True ' the goal has been reached by the particle
            toExport = True ' the words "goal reached" is to be exported to the spreadsheet
            ' this works because if the goal has been reached already then the program never reaches this line as it has already exited on the first line of the function
            ' if the goal hasn't been reached then these conditional statements won't be run. These lines should only run once per simulation
            Return True ' the goal has indeed been reached
        End If
        Return False ' If all else fails then that means the particle hasn't reached the goal
    End Function

    ' used to reset the goal when running a new simulation
    Public Sub resetGoal()
        reachedByParticle = False
    End Sub

    ' allows other classes to access the goals height. Necessary because otherwise the goal would be pointless because no other code could find out what the goal actually is
    Public ReadOnly Property height As Single
        Get
            Return goalHeight
        End Get
    End Property

End Class
