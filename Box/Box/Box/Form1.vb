Public Class Form1
    Dim Box As LPBox
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LengthTB_Scroll(sender As System.Object, e As System.EventArgs) Handles LengthTB.Scroll
        Box.SetLength(LengthTB.Value)
    End Sub

    Private Sub WidthTB_Scroll(sender As System.Object, e As System.EventArgs) Handles WidthTB.Scroll
        Box.SetWidth(WidthTB.Value)
    End Sub

    Private Sub HeightTB_Scroll(sender As System.Object, e As System.EventArgs) Handles HeightTB.Scroll
        Box.SetHeight(HeightTB.Value)
    End Sub

    Private Sub MakeBoxButton_Click(sender As System.Object, e As System.EventArgs) Handles MakeBoxButton.Click
        Box = New LPBox
    End Sub
End Class
