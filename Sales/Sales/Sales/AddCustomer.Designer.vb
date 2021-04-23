<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_SalesOk = New System.Windows.Forms.Button()
        Me.In_ID = New System.Windows.Forms.TextBox()
        Me.In_Name = New System.Windows.Forms.TextBox()
        Me.In_ContactName = New System.Windows.Forms.TextBox()
        Me.In_Adress = New System.Windows.Forms.TextBox()
        Me.In_City = New System.Windows.Forms.TextBox()
        Me.In_Country = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Customer"
        '
        'B_SalesOk
        '
        Me.B_SalesOk.Location = New System.Drawing.Point(240, 240)
        Me.B_SalesOk.Name = "B_SalesOk"
        Me.B_SalesOk.Size = New System.Drawing.Size(48, 30)
        Me.B_SalesOk.TabIndex = 3
        Me.B_SalesOk.Text = "Ok"
        Me.B_SalesOk.UseCompatibleTextRendering = True
        Me.B_SalesOk.UseVisualStyleBackColor = True
        '
        'In_ID
        '
        Me.In_ID.Location = New System.Drawing.Point(91, 55)
        Me.In_ID.Name = "In_ID"
        Me.In_ID.Size = New System.Drawing.Size(170, 20)
        Me.In_ID.TabIndex = 4
        '
        'In_Name
        '
        Me.In_Name.Location = New System.Drawing.Point(91, 81)
        Me.In_Name.Name = "In_Name"
        Me.In_Name.Size = New System.Drawing.Size(170, 20)
        Me.In_Name.TabIndex = 5
        '
        'In_ContactName
        '
        Me.In_ContactName.Location = New System.Drawing.Point(91, 107)
        Me.In_ContactName.Name = "In_ContactName"
        Me.In_ContactName.Size = New System.Drawing.Size(170, 20)
        Me.In_ContactName.TabIndex = 6
        '
        'In_Adress
        '
        Me.In_Adress.Location = New System.Drawing.Point(91, 133)
        Me.In_Adress.Name = "In_Adress"
        Me.In_Adress.Size = New System.Drawing.Size(170, 20)
        Me.In_Adress.TabIndex = 7
        '
        'In_City
        '
        Me.In_City.Location = New System.Drawing.Point(92, 159)
        Me.In_City.Name = "In_City"
        Me.In_City.Size = New System.Drawing.Size(169, 20)
        Me.In_City.TabIndex = 8
        '
        'In_Country
        '
        Me.In_Country.Location = New System.Drawing.Point(92, 185)
        Me.In_Country.Name = "In_Country"
        Me.In_Country.Size = New System.Drawing.Size(169, 20)
        Me.In_Country.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Contact name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "City"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Country"
        '
        'AddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 282)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.In_Country)
        Me.Controls.Add(Me.In_City)
        Me.Controls.Add(Me.In_Adress)
        Me.Controls.Add(Me.In_ContactName)
        Me.Controls.Add(Me.In_Name)
        Me.Controls.Add(Me.In_ID)
        Me.Controls.Add(Me.B_SalesOk)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddCustomer"
        Me.Text = "AddCustomer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents B_SalesOk As System.Windows.Forms.Button
    Friend WithEvents In_ID As System.Windows.Forms.TextBox
    Friend WithEvents In_Name As System.Windows.Forms.TextBox
    Friend WithEvents In_ContactName As System.Windows.Forms.TextBox
    Friend WithEvents In_Adress As System.Windows.Forms.TextBox
    Friend WithEvents In_City As System.Windows.Forms.TextBox
    Friend WithEvents In_Country As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
