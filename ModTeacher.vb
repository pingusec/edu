Module ModTeacher
    Structure Teacher
        Dim StaffCode As String
        Dim Title As String
        Dim Initial As String
        Dim name As String
    End Structure

    Public TeacherList() As Teacher
    Dim NoOfTeachers As Integer

    Sub LoadTeachers()
        FileOpen(1, "S:\TeacherNames.txt", OpenMode.Input)
        Do While Not (EOF(1))
            ReDim Preserve TeacherList(NoOfTeachers)
            TeacherList(NoOfTeachers).StaffCode = LineInput(1)
            TeacherList(NoOfTeachers).Title = LineInput(1)
            TeacherList(NoOfTeachers).Initial = LineInput(1)
            TeacherList(NoOfTeachers).name = LineInput(1)
            NoOfTeachers += 1
        Loop
        FileClose(1)
    End Sub

    Function SearchTeachers(ByVal staffcode As String)
        Dim temp(0) As Teacher
        For i = 0 To TeacherList.Length - 1
            If TeacherList(i).StaffCode = staffcode Then
                temp(0) = TeacherList(i)
                Return temp
            End If
        Next
    End Function
End Module
