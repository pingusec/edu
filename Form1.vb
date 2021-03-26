Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles LoadButton.Click
        Student.LoadStudents()
        UpdateStudentGrid()

    End Sub

    Private Sub StudentGrid_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentGrid.CellContentClick
        ' Cell content click
        ModTutorGroup.LoadTutorGroups()
        Dim Form As String = StudentGrid.Item(3, StudentGrid.CurrentRow.Index).Value
        ModTutorGroup.TutorGroups = SearchTutorGroup(Form)
        TutorGroupGrid.Rows.Clear()
        UpdateTutorGrid()

        Dim StaffCode As String = TeacherGrid.Item(0, TeacherGrid.CurrentRow.Index).Value
        ModTeacher.TeacherList = SearchTeachers(StaffCode)
        TeacherGrid.Rows.Clear()
        UpdateTeacherGrid()
    End Sub
    Private Sub SortButton_Click(sender As System.Object, e As System.EventArgs)
        Student.SortStudents()
        UpdateStudentGrid()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles LoadTeachers.Click ' LoadTeachers
        ModTeacher.LoadTeachers()
        UpdateTeacherGrid()
    End Sub
    Sub UpdateStudentGrid()
        For i = 0 To Student.StudentList.Length - 1
            StudentGrid.Rows.Add()
            StudentGrid.Item(0, i).Value = Student.StudentList(i).StudentNumber
            StudentGrid.Item(1, i).Value = Student.StudentList(i).FirstName
            StudentGrid.Item(2, i).Value = Student.StudentList(i).LastName
            StudentGrid.Item(3, i).Value = Student.StudentList(i).TutorGroup
        Next
    End Sub

    Sub UpdateTeacherGrid()
        For i = 0 To ModTeacher.TeacherList.Length - 1
            TeacherGrid.Rows.Add()
            TeacherGrid.Item(0, i).Value = ModTeacher.TeacherList(i).StaffCode
            TeacherGrid.Item(1, i).Value = ModTeacher.TeacherList(i).Title
            TeacherGrid.Item(2, i).Value = ModTeacher.TeacherList(i).Initial
            TeacherGrid.Item(3, i).Value = ModTeacher.TeacherList(i).Name
        Next
    End Sub

    Sub UpdateTutorGrid()
        For i = 0 To ModTutorGroup.TutorGroups.Length - 1
            TutorGroupGrid.Rows.Add()
            TutorGroupGrid.Item(0, i).Value = ModTutorGroup.TutorGroups(i).Form
            TutorGroupGrid.Item(1, i).Value = ModTutorGroup.TutorGroups(i).StaffCode
            TutorGroupGrid.Item(2, i).Value = ModTutorGroup.TutorGroups(i).RoomNumber
        Next
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        ModTutorGroup.LoadTutorGroups()
        UpdateTutorGrid()
    End Sub

    Private Sub StudentGrid_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentGrid.CellContentDoubleClick
        ' Cell double click
    End Sub

    Private Sub SaveChangesButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveChangesButton.Click
        ReDim Student.StudentList(StudentGrid.Rows.Count)
        For i = 0 To StudentGrid.Rows.Count - 2
            Student.StudentList(i).StudentNumber = StudentGrid.Item(0, i).Value
            Student.StudentList(i).FirstName = StudentGrid.Item(1, i).Value
            Student.StudentList(i).LastName = StudentGrid.Item(2, i).Value
            Student.StudentList(i).TutorGroup = StudentGrid.Item(3, i).Value
        Next

        FileOpen(1, "S:\StudentNames.txt", OpenMode.Output)

        For i = 0 To Student.StudentList.Length - 3
            PrintLine(1, Student.StudentList(i).StudentNumber)
            PrintLine(1, Student.StudentList(i).FirstName)
            PrintLine(1, Student.StudentList(i).LastName)
            PrintLine(1, Student.StudentList(i).TutorGroup)
        Next


        FileClose(1)
    End Sub

    Private Sub StudentDropdown_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles StudentDropdown.SelectedIndexChanged

    End Sub
End Class
