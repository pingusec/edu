Public Class Alien
    Inherits Sprite
    Protected SpriteB As Bitmap
    Protected SpriteOof As Bitmap
    ' Dancing Vars
    Private Shared StepCount As Integer
    Protected Shared LorR As Boolean



    Sub New(ByVal SpriteAPath As String, ByVal SpriteBPath As String, ByVal SpriteOofPath As String, ByVal XPos As Integer, ByVal YPos As Integer)
        MyBase.New(SpriteAPath)
        Me.SpriteB = New Bitmap(SpriteBPath)
        Me.SpriteOof = New Bitmap(SpriteOofPath)
        Me.Width = 50
        Me.Height = 30
        Me.Pos = New Point With {.X = XPos, .Y = YPos}
        Me.Location = Pos
        Me.StepCount = 1
        'Me.CanShoot = CanShootV
        Form1.Controls.Add(Me)
    End Sub

    Private Property CanShoot As Boolean

    Public Overrides Sub MoveSprite()


        'smart way
        If (StepCount \ 30) Mod 2 = 0 Then
            Me.Pos.X += 10
        Else
            Me.Pos.X -= 10
        End If

        If StepCount > 0 And StepCount Mod 30 = 0 Then
            Me.Pos.Y += 20
        End If

        If StepCount Mod 2 = 0 Then
            Me.Image = SpriteA
        Else
            Me.Image = SpriteB
        End If

        ' StepCount += 1

        Me.Location = Pos
    End Sub

    Public Shared Sub IncStepCounter()
        StepCount += 1
    End Sub
    Public Overrides Sub Oof()
        Me.Image = SpriteOof
        Application.DoEvents()
        Threading.Thread.Sleep(300)
        Form1.Controls.Remove(Me)
        Me.Dispose()

    End Sub
End Class
