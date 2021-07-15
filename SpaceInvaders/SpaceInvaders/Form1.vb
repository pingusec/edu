Public Class Form1
    Dim Jim As Alien
    Dim Bob As Defender
    Dim Zoom As Missle
    Dim Game As Game

    Private Sub B_AddAlien_Click(sender As System.Object, e As System.EventArgs)
        Jim = New Alien("S:\UOL 2021\Images\Alien1a.jpg", "S:\UOL 2021\Images\Alien1b.jpg", "S:\UOL 2021\Images\AMDead.jpg", 10, 10)
    End Sub

    Private Sub Form1_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Me.BackColor = Color.Black
        Game = New Game
    End Sub

    Private Sub B_AddDef_Click(sender As System.Object, e As System.EventArgs)
        Bob = New Defender("S:\UOL 2021\Images\Defender.jpg", "S:\UOL 2021\Images\AMDead.jpg", 50, 580)
    End Sub

    Private Sub B_AddMisA_Click(sender As System.Object, e As System.EventArgs)
        Zoom = New Missle("S:\UOL 2021\Images\Missile1.jpg", "S:\UOL 2021\Images\Missile2.jpg", "S:\UOL 2021\Images\AMDead.jpg", 250, 300, "ATK")
    End Sub

    Private Sub B_AddMisD_Click(sender As System.Object, e As System.EventArgs)
        Zoom = New Missle("S:\UOL 2021\Images\DefMissile1.jpg", "S:\UOL 2021\Images\DefMissile2.jpg", "S:\UOL 2021\Images\AMDead.jpg", 250, 250, "DEF")
    End Sub

    Private Sub B_MvAlien_Click(sender As System.Object, e As System.EventArgs)
        Jim.MoveSprite()
    End Sub

    Private Sub B_MvDef_Click(sender As System.Object, e As System.EventArgs)
        Bob.MoveSprite()
    End Sub

    Private Sub B_MvMis_Click(sender As System.Object, e As System.EventArgs)
        Zoom.MoveSprite()
    End Sub

    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Then
            Game.MvDef(-10)
        ElseIf e.KeyCode = Keys.Right Then
            Game.MvDef(10)
        End If
        If e.KeyCode = Keys.Space Then
            Game.DefPew()
        End If
    End Sub

 
End Class
