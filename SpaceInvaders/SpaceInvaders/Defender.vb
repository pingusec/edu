Public Class Defender
    Inherits Sprite
    Protected SpriteOof As Bitmap
    Sub New(ByVal SpriteAPath As String, ByVal SpriteOofPath As String, ByVal XPos As Integer, ByVal YPos As Integer)
        MyBase.New(SpriteAPath)
        Me.SpriteOof = New Bitmap(SpriteOofPath)
        Me.Width = 50
        Me.Height = 30
        Me.Pos = New Point With {.X = XPos, .Y = YPos}
        Me.Location = Pos
        Form1.Controls.Add(Me)
    End Sub
    Public Overrides Sub MoveSprite()

    End Sub
    Public Overrides Sub MoveSprite(Dir As Integer)
        Me.Pos.X += Dir
        Me.Location = Pos
    End Sub

    Public Overrides Sub Oof()
     
    End Sub
End Class
