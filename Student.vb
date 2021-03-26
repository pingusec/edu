Module Student
    Structure Student
        Dim StudentNumber As Integer
        Dim FirstName As String
        Dim LastName As String
        Dim TutorGroup As String
    End Structure

    Public StudentList() As Student
    Dim NoOfStudents As Integer


    Sub LoadStudents()
        FileOpen(1, "S:\StudentNames.txt", OpenMode.Input)
        Do While Not EOF(1)
            ReDim Preserve StudentList(NoOfStudents)
            StudentList(NoOfStudents).StudentNumber = LineInput(1)
            StudentList(NoOfStudents).FirstName = LineInput(1)
            StudentList(NoOfStudents).LastName = LineInput(1)
            StudentList(NoOfStudents).TutorGroup = LineInput(1)
            NoOfStudents += 1
        Loop
        FileClose(1)
    End Sub

    Sub SortStudents()
        Dim temp As Student

        For looper = 0 To StudentList.Length - 2
            If StudentList(looper).StudentNumber < StudentList(looper).StudentNumber Then
                temp = StudentList(looper + 1)
                StudentList(looper) = StudentList(looper + 1)
                StudentList(looper + 1) = temp
            End If
        Next
    End Sub




End Module
