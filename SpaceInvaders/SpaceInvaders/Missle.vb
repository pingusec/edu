Public Class Missle
    Inherits Sprite
    Protected SpriteB As Bitmap
    Protected SpriteOof As Bitmap
    Protected MissleType As String ' (DEF / ATK)

    Sub New(ByVal SpriteAPath As String, ByVal SpriteBPath As String, ByVal SpriteOofPath As String, ByVal XPos As Integer, ByVal YPos As Integer, ByVal MissleType As String)
        MyBase.New(SpriteAPath)
        Me.SpriteB = New Bitmap(SpriteBPath)
        Me.SpriteOof = New Bitmap(SpriteOofPath)
        Me.Width = 10
        Me.Height = 50
        Me.Pos = New Point With {.X = XPos, .Y = YPos}
        Me.Location = Pos
        Me.MissleType = MissleType
        Form1.Controls.Add(Me)
    End Sub
    Public Overrides Sub MoveSprite()
        If MissleType = "DEF" Then
            Me.Pos.Y -= 20
            Me.Location = Pos
        Else
            Me.Pos.Y += 30
            Me.Location = Pos
        End If

        If Me.Image Is SpriteA Then
            Me.Image = SpriteB
        Else
            Me.Image = SpriteA
        End If
    End Sub

    Public Overrides Sub Oof()
        Form1.Controls.Remove(Me)

    End Sub
End Class
