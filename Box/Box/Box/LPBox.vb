Public Class LPBox
    Private Length As Integer
    Private Width As Integer
    Private Height As Integer
    Private Volume As Integer
    Private TotalSurfaceArea As Integer
    Private PlanViewArea As Integer
    Private SideViewArea As Integer
    Private EndViewArea As Integer
    Private PlanView As TextBox


    Public Sub New()
        Length = 100
        Width = 50
        Height = 25
        Volume = Width * Height * Length
        TotalSurfaceArea = ((Width * Height) * 2) + ((Width * Length) * 2) + ((Length * Height) * 2)




    End Sub

    Public Function GetLength() As Integer
        Return Me.Length
    End Function
    Public Function GetWidth() As Integer
        Return Me.Width
    End Function
    Public Function GetHeight() As Integer
        Return Me.Height
    End Function
    Public Function GetVolume() As Integer
        Return Me.Volume
    End Function
    Public Function GetTotalSurfaceArea() As Integer
        Return Me.TotalSurfaceArea
    End Function
    Public Function GetPlanViewArea() As Integer
        Return Me.PlanViewArea
    End Function
    Public Function GetSideViewArea() As Integer
        Return Me.SideViewArea
    End Function
    Public Function GetEndViewArea() As Integer
        Return Me.EndViewArea
    End Function

    Public Sub SetLength(i As Integer)
        Me.Length = i
        CalculateVolume()
        CalculateSurfaceArea()
        CalculateSide()
        CalculatePlan()
        UpdateAllViews()
    End Sub
    Public Sub SetWidth(i As Integer)
        Me.Width = i
        CalculateVolume()
        CalculateSurfaceArea()
        CalculatePlan()
        CalculateEnd()
        UpdateAllViews()
    End Sub
    Public Sub SetHeight(i As Integer)
        Me.Height = i
        CalculateVolume()
        CalculateSurfaceArea()
        CalculateEnd()
        CalculateSide()
        UpdateAllViews()
    End Sub

    Private Sub CalculateVolume()
        Me.Volume = Height * Width * Length
    End Sub
    Private Sub CalculateSurfaceArea()
        Me.TotalSurfaceArea = ((Width * Height) * 2) + ((Width * Length) * 2) + ((Length * Height) * 2)
    End Sub
    Private Sub CalculateSide()
        Me.SideViewArea = Height * Length
    End Sub
    Private Sub CalculatePlan()
        Me.PlanViewArea = Width * Length
    End Sub
    Private Sub CalculateEnd()
        Me.EndViewArea = Width * Height
    End Sub
    Public Sub UpdateAllViews()
        Form1.HeightValueLabel.Text = Height
        Form1.WidthValueLabel.Text = Width
        Form1.LengthValueLabel.Text = Length
    End Sub

End Class
