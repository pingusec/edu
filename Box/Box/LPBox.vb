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
    Private SideView As TextBox
    Private EndView As TextBox


    Public Sub New()
        Length = 100
        Width = 50
        Height = 25
        Volume = Width * Height * Length
        TotalSurfaceArea = ((Width * Height) * 2) + ((Width * Length) * 2) + ((Length * Height) * 2)

        ' Initialise boxes
        InitaliseBoxes()


    End Sub

    Private Sub InitaliseBoxes()
        PlanView = New TextBox
        SideView = New TextBox
        EndView = New TextBox

        PlanView.Multiline = True
        PlanView.Width = Length
        PlanView.Height = Width
        PlanView.BackColor = Color.YellowGreen
        PlanView.Location = New Point(10, 10)
        PlanView.Text = "Top"

        SideView.Multiline = True
        SideView.Width = Length
        SideView.Height = Height
        SideView.BackColor = Color.Green
        SideView.Location = New Point(10, PlanView.Location.Y + PlanView.Height + 10)
        SideView.Text = "Side"

        EndView.Multiline = True
        EndView.Width = Width
        EndView.Height = Height
        EndView.BackColor = Color.MediumVioletRed
        EndView.Location = New Point(10, SideView.Location.Y + SideView.Height + 10)
        EndView.Text = "End"

        Form1.Controls.Add(PlanView)
        Form1.Controls.Add(SideView)
        Form1.Controls.Add(EndView)
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

        ' Change box sizes woo
        PlanView.Width = Length
        PlanView.Height = Width
        SideView.Width = Length
        SideView.Height = Height
        EndView.Width = Width
        EndView.Height = Height
        SideView.Location = New Point(10, PlanView.Location.Y + PlanView.Height + 10)
        EndView.Location = New Point(10, SideView.Location.Y + SideView.Height + 10)
    End Sub
    Public Sub Inspect()
        Dim Str As String = " Len: " & Me.Length & vbCrLf &
            " Width: " & Me.Width & vbCrLf &
            " Height " & Me.Height & vbCrLf &
            " Volume " & Me.Volume & vbCrLf &
            " Surface area " & Me.TotalSurfaceArea & vbCrLf &
            " Plan " & Me.PlanViewArea & vbCrLf &
            " Side " & Me.SideViewArea & vbCrLf &
            " End " & Me.EndViewArea
        MsgBox(Str)
    End Sub


End Class