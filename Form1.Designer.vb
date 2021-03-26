<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.StudentGrid = New System.Windows.Forms.DataGridView()
        Me.StudentNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TutorGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadTeachers = New System.Windows.Forms.Button()
        Me.TeacherGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TutorGroupGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SaveChangesButton = New System.Windows.Forms.Button()
        Me.StudentDropdown = New System.Windows.Forms.ComboBox()
        CType(Me.StudentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutorGroupGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(472, 13)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(89, 33)
        Me.LoadButton.TabIndex = 0
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'StudentGrid
        '
        Me.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentNo, Me.FirstName, Me.LastName, Me.TutorGroup})
        Me.StudentGrid.Location = New System.Drawing.Point(12, 13)
        Me.StudentGrid.Name = "StudentGrid"
        Me.StudentGrid.Size = New System.Drawing.Size(444, 387)
        Me.StudentGrid.TabIndex = 3
        '
        'StudentNo
        '
        Me.StudentNo.HeaderText = "StudentNo"
        Me.StudentNo.Name = "StudentNo"
        '
        'FirstName
        '
        Me.FirstName.HeaderText = "FirstName"
        Me.FirstName.Name = "FirstName"
        '
        'LastName
        '
        Me.LastName.HeaderText = "LastName"
        Me.LastName.Name = "LastName"
        '
        'TutorGroup
        '
        Me.TutorGroup.HeaderText = "TutorGroup"
        Me.TutorGroup.Name = "TutorGroup"
        '
        'LoadTeachers
        '
        Me.LoadTeachers.Location = New System.Drawing.Point(1059, 13)
        Me.LoadTeachers.Name = "LoadTeachers"
        Me.LoadTeachers.Size = New System.Drawing.Size(89, 33)
        Me.LoadTeachers.TabIndex = 4
        Me.LoadTeachers.Text = "Load"
        Me.LoadTeachers.UseVisualStyleBackColor = True
        '
        'TeacherGrid
        '
        Me.TeacherGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeacherGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TeacherGrid.Location = New System.Drawing.Point(600, 13)
        Me.TeacherGrid.Name = "TeacherGrid"
        Me.TeacherGrid.Size = New System.Drawing.Size(444, 184)
        Me.TeacherGrid.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Staff Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Initial"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'TutorGroupGrid
        '
        Me.TutorGroupGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TutorGroupGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.TutorGroupGrid.Location = New System.Drawing.Point(600, 216)
        Me.TutorGroupGrid.Name = "TutorGroupGrid"
        Me.TutorGroupGrid.Size = New System.Drawing.Size(444, 184)
        Me.TutorGroupGrid.TabIndex = 8
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "TutorGroup"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "StaffCode"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Room"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1059, 216)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(89, 33)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Load"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'SaveChangesButton
        '
        Me.SaveChangesButton.Location = New System.Drawing.Point(472, 53)
        Me.SaveChangesButton.Name = "SaveChangesButton"
        Me.SaveChangesButton.Size = New System.Drawing.Size(89, 31)
        Me.SaveChangesButton.TabIndex = 10
        Me.SaveChangesButton.Text = "Save"
        Me.SaveChangesButton.UseVisualStyleBackColor = True
        '
        'StudentDropdown
        '
        Me.StudentDropdown.FormattingEnabled = True
        Me.StudentDropdown.Location = New System.Drawing.Point(472, 90)
        Me.StudentDropdown.Name = "StudentDropdown"
        Me.StudentDropdown.Size = New System.Drawing.Size(89, 21)
        Me.StudentDropdown.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 413)
        Me.Controls.Add(Me.StudentDropdown)
        Me.Controls.Add(Me.SaveChangesButton)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TutorGroupGrid)
        Me.Controls.Add(Me.TeacherGrid)
        Me.Controls.Add(Me.LoadTeachers)
        Me.Controls.Add(Me.StudentGrid)
        Me.Controls.Add(Me.LoadButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.StudentGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutorGroupGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoadButton As System.Windows.Forms.Button
    Friend WithEvents StudentGrid As System.Windows.Forms.DataGridView
    Friend WithEvents StudentNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TutorGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoadTeachers As System.Windows.Forms.Button
    Friend WithEvents TeacherGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TutorGroupGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaveChangesButton As System.Windows.Forms.Button
    Friend WithEvents StudentDropdown As System.Windows.Forms.ComboBox

End Class
