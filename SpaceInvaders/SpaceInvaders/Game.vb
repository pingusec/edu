Public Class Game
    Private SpriteList As New List(Of Sprite)
    ' Private CanPewPew As New List(Of Alien)
    Private Defender As Defender
    Private DefenderPew As Missle
    Private PewPewOut As Boolean
    Private TextaBoxa As Label
    Private Score As Integer

    Protected WithEvents DanceClock As Timer

    Public Sub New()
        PewPewOut = False
        For i = 0 To 9
            SpriteList.Add(New Alien("S:\UOL 2021\Images\Alien1a.jpg", "S:\UOL 2021\Images\Alien1b.jpg", "S:\UOL 2021\Images\AMDead.jpg", i * 55 + 10, 10))
        Next
        For i = 0 To 9
            SpriteList.Add(New Alien("S:\UOL 2021\Images\Alien2a.jpg", "S:\UOL 2021\Images\Alien2b.jpg", "S:\UOL 2021\Images\AMDead.jpg", i * 55 + 10, 50))
        Next
        For i = 0 To 9
            SpriteList.Add(New Alien("S:\UOL 2021\Images\Alien3a.jpg", "S:\UOL 2021\Images\Alien3b.jpg", "S:\UOL 2021\Images\AMDead.jpg", i * 55 + 10, 90))
        Next
        For i = 0 To 9
            SpriteList.Add(New Alien("S:\UOL 2021\Images\Alien4a.jpg", "S:\UOL 2021\Images\Alien4b.jpg", "S:\UOL 2021\Images\AMDead.jpg", i * 55 + 10, 130))
        Next
        Defender = New Defender("S:\UOL 2021\Images\Defender.jpg", "S:\UOL 2021\Images\AMDead.jpg", 50, 580)
        DanceClock = New Timer With {.Interval = 100}
        DanceClock.Start()
        TextaBoxa = New Label With {.Text = "Score: " & Score}
    End Sub
    Public Sub Move() Handles DanceClock.Tick
        For Each Sprite In SpriteList
            If Sprite IsNot Nothing Then
                Sprite.MoveSprite()
            End If

        Next
        CanFireCheck()
        'If DefenderPew IsNot Nothing Then
        '    DefenderPew.MoveSprite()
        '    For Each Sprite In SpriteList
        '        If DefenderPew IsNot Nothing Then
        '            If DefenderPew.Bounds.IntersectsWith(Sprite.Bounds) And Sprite IsNot Nothing Then
        '                PewPewOut = False


        '                DefenderPew.Oof()
        '                DefenderPew = Nothing
        '                Sprite.Oof()
        '                Sprite = Nothing
        '            End If
        '        End If
        '        If DefenderPew IsNot Nothing Then
        '            If DefenderPew.Location.Y = 0 Then
        '                DefenderPew.Oof()
        '                DefenderPew = Nothing
        '            End If
        '        End If
        '    Next
        'End If
        If DefenderPew IsNot Nothing Then
            DefenderPew.MoveSprite()
            For i = 0 To Me.SpriteList.Count() - 1
                If DefenderPew IsNot Nothing Then
                    If SpriteList(i) IsNot Nothing Then
                        If DefenderPew.Bounds.IntersectsWith(SpriteList(i).Bounds) Then
                            PewPewOut = False


                            DefenderPew.Oof()
                            DefenderPew = Nothing
                            SpriteList(i).Oof()
                            SpriteList(i) = Nothing
                        End If
                    End If
                End If
            Next
        End If

        Application.DoEvents()
        Alien.IncStepCounter()

        ' Alien Pew Pew
    End Sub
    Sub CanFireCheck()
        Dim TempSprite As Alien
        For x = 0 To 9
            For y = 0 To 3
                If SpriteList(y * 10 + x) IsNot Nothing Then
                    TempSprite = SpriteList(y * 10 + x)
                End If
            Next
            If Int(100 * Rnd()) < 2 Then
                SpriteList.Add(New Missle("S:\UOL 2021\Images\Missile1.jpg", "S:\UOL 2021\Images\Missile2.jpg", "S:\UOL 2021\Images\AMDead.jpg", TempSprite.GetPos.x + 20, TempSprite.GetPos.y - 4, "ATK"))
            End If

        Next
    End Sub
    Public Sub MvDef(Dir As Integer)
        Defender.MoveSprite(Dir)
    End Sub

    Public Sub AlPew()

    End Sub

    Public Sub DefPew()
        If DefenderPew Is Nothing Then
            DefenderPew = New Missle("S:\UOL 2021\Images\DefMissile1.jpg", "S:\UOL 2021\Images\DefMissile2.jpg", "S:\UOL 2021\Images\AMDead.jpg", Defender.GetPos.x + 20, Defender.GetPos.y - 4, "DEF")
            PewPewOut = True
        End If

    End Sub
    Public Sub CheckPewPew()
        ' For Each Sprite In SpriteList
        ' If DefenderPew.GetPos.
        'Next Then
    End Sub
End Class
