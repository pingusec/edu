Public MustInherit Class Sprite
    Inherits PictureBox
    Protected SpriteA As Bitmap
    Protected IsOof As Boolean
    Protected Pos As Point

    Sub New(ByVal inFilePath1 As String)
        Me.SpriteA = New Bitmap(inFilePath1)
        Me.Image = Me.SpriteA
        Me.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Public MustOverride Sub MoveSprite()
    Public MustOverride Sub Oof()
    Public Overridable Sub MoveSprite(Dir As Integer)

    End Sub

    ' +=========+
    ' | Getters |
    ' +=========+

    Function GetIsOof() As Boolean
        Return IsOof
    End Function

    Function GetPos()
        Return Me.Pos
    End Function
End Class
