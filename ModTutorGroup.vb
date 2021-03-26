Module ModTutorGroup
    Structure TutorGroup
        Dim Form As String
        Dim StaffCode As String
        Dim RoomNumber As String
    End Structure

    Public TutorGroups() As TutorGroup
    Dim NoOfTutorGroups As Integer

    Sub LoadTutorGroups()
        FileOpen(1, "S:\TutorGroups.txt", OpenMode.Input)
        Do While Not EOF(1)
            ReDim Preserve TutorGroups(NoOfTutorGroups)
            TutorGroups(NoOfTutorGroups).Form = LineInput(1)
            TutorGroups(NoOfTutorGroups).StaffCode = LineInput(1)
            TutorGroups(NoOfTutorGroups).RoomNumber = LineInput(1)
            NoOfTutorGroups += 1
        Loop
        FileClose(1)
    End Sub

    Function SearchTutorGroup(ByVal Form As String)
        Dim TempForm As TutorGroup
        For i = 0 To ModTutorGroup.TutorGroups.Length - 1
            If ModTutorGroup.TutorGroups(i).Form = Form Then
                TempForm = ModTutorGroup.TutorGroups(i)
                ReDim ModTutorGroup.TutorGroups(0)
                ModTutorGroup.TutorGroups(0) = TempForm
                Return ModTutorGroup.TutorGroups
            End If
        Next
    End Function
End Module
