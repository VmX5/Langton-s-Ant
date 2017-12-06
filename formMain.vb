Public Class formMain

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        GameField1.playLife(numSteps.Value)
    End Sub

    Private Sub btnStep_Click(sender As Object, e As EventArgs) Handles btnStep.Click
        GameField1.stepForward()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        GameField1.restart()
    End Sub

    Private Sub timerStep_Tick(sender As Object, e As EventArgs) Handles timerStep.Tick
        GameField1.stepForward()
    End Sub

    Private Sub btnStartTimer_Click(sender As Object, e As EventArgs) Handles btnStartTimer.Click
        timerStep.Start()
    End Sub

    Private Sub btnStopTimer_Click(sender As Object, e As EventArgs) Handles btnStopTimer.Click
        timerStep.Stop()
    End Sub
End Class

Public Class gameField
    Inherits Control

    Private initialPoint As New Point(16, 13)
    Private usedTiles As New List(Of Point)
    Private ant As New Ant(initialPoint, Direction.West)

    Sub New()
        DoubleBuffered = True
    End Sub

    Public Sub restart()
        usedTiles.Clear()
        ant = New Ant(initialPoint, Direction.West)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.Clear(Color.White)

        For Each tile As Point In usedTiles
            g.FillRectangle(Brushes.Gray, tile.X * 10, tile.Y * 10, 10, 10)
        Next

        g.FillRectangle(Brushes.Red, ant.location.X * 10, ant.location.Y * 10, 10, 10)
        Select Case ant.direction
            Case Direction.North
                g.FillRectangle(Brushes.Black, ant.location.X * 10 + 2, ant.location.Y * 10 + 2, 7, 2)
            Case Direction.East
                g.FillRectangle(Brushes.Black, ant.location.X * 10 + 6, ant.location.Y * 10 + 2, 2, 7)
            Case Direction.South
                g.FillRectangle(Brushes.Black, ant.location.X * 10 + 2, ant.location.Y * 10 + 6, 7, 2)
            Case Direction.West
                g.FillRectangle(Brushes.Black, ant.location.X * 10 + 2, ant.location.Y * 10 + 2, 2, 7)
        End Select
 
        For y As Integer = 0 To Height / 10
            g.DrawLine(Pens.Black, New Point(0, y * 10), New Point(Width, y * 10))
        Next
        For x As Integer = 0 To Width / 10
            g.DrawLine(Pens.Black, New Point(x * 10, 0), New Point(x * 10, Width))
        Next
    End Sub

    Public Sub playLife(x As Integer)
        For i As Integer = 0 To x - 1
            stepForward()
        Next
        Invalidate()
    End Sub 

    Public Sub stepForward()
        If (usedTiles.Contains(New Point(ant.location))) Then
            usedTiles.Remove(ant.location)
            Select Case ant.direction
                Case Direction.North
                    ant.location = New Point(ant.location.X - 1, ant.location.Y)
                    ant.direction = Direction.West
                Case Direction.East
                    ant.location = New Point(ant.location.X, ant.location.Y - 1)
                    ant.direction = Direction.North
                Case Direction.South
                    ant.location = New Point(ant.location.X + 1, ant.location.Y)
                    ant.direction = Direction.East
                Case Direction.West
                    ant.location = New Point(ant.location.X, ant.location.Y + 1)
                    ant.direction = Direction.South
            End Select
        Else
            usedTiles.Add(New Point(ant.location))
            Select Case ant.direction
                Case Direction.North
                    ant.location = New Point(ant.location.X + 1, ant.location.Y)
                    ant.direction = Direction.East
                Case Direction.East
                    ant.location = New Point(ant.location.X, ant.location.Y + 1)
                    ant.direction = Direction.South
                Case Direction.South
                    ant.location = New Point(ant.location.X - 1, ant.location.Y)
                    ant.direction = Direction.West
                Case Direction.West
                    ant.location = New Point(ant.location.X, ant.location.Y - 1)
                    ant.direction = Direction.North
            End Select
        End If
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        ant.location = New Point(Math.Floor(e.X / 10), Math.Floor(e.Y / 10))
        Invalidate()
    End Sub
End Class

Public Class Ant
    Public Property location As Point
    Public Property direction As Direction
    Sub New(loc As Point, dir As Direction)
        location = loc
        direction = dir
    End Sub
End Class

Public Enum Direction
    North = 1
    East = 2
    South = 3
    West = 4
End Enum