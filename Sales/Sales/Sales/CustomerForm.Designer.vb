<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
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
        Me.B_CustomerBack = New System.Windows.Forms.Button()
        Me.B_AddCustomer = New System.Windows.Forms.Button()
        Me.B_EditCustomer = New System.Windows.Forms.Button()
        Me.Gr_Customer = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Country = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Gr_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer form"
        '
        'B_CustomerBack
        '
        Me.B_CustomerBack.Location = New System.Drawing.Point(610, 459)
        Me.B_CustomerBack.Name = "B_CustomerBack"
        Me.B_CustomerBack.Size = New System.Drawing.Size(48, 30)
        Me.B_CustomerBack.TabIndex = 1
        Me.B_CustomerBack.Text = "Back"
        Me.B_CustomerBack.UseVisualStyleBackColor = True
        '
        'B_AddCustomer
        '
        Me.B_AddCustomer.Location = New System.Drawing.Point(21, 459)
        Me.B_AddCustomer.Name = "B_AddCustomer"
        Me.B_AddCustomer.Size = New System.Drawing.Size(89, 30)
        Me.B_AddCustomer.TabIndex = 2
        Me.B_AddCustomer.Text = "Add customer"
        Me.B_AddCustomer.UseVisualStyleBackColor = True
        '
        'B_EditCustomer
        '
        Me.B_EditCustomer.Location = New System.Drawing.Point(116, 459)
        Me.B_EditCustomer.Name = "B_EditCustomer"
        Me.B_EditCustomer.Size = New System.Drawing.Size(89, 30)
        Me.B_EditCustomer.TabIndex = 3
        Me.B_EditCustomer.Text = "Edit customer"
        Me.B_EditCustomer.UseVisualStyleBackColor = True
        '
        'Gr_Customer
        '
        Me.Gr_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gr_Customer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.CustName, Me.Contact, Me.Address, Me.City, Me.Country})
        Me.Gr_Customer.Location = New System.Drawing.Point(21, 66)
        Me.Gr_Customer.Name = "Gr_Customer"
        Me.Gr_Customer.Size = New System.Drawing.Size(637, 368)
        Me.Gr_Customer.TabIndex = 4
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'CustName
        '
        Me.CustName.HeaderText = "Name"
        Me.CustName.Name = "CustName"
        '
        'Contact
        '
        Me.Contact.HeaderText = "Contact Name"
        Me.Contact.Name = "Contact"
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        '
        'City
        '
        Me.City.HeaderText = "City"
        Me.City.Name = "City"
        '
        'Country
        '
        Me.Country.HeaderText = "Country"
        Me.Country.Name = "Country"
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 501)
        Me.Controls.Add(Me.Gr_Customer)
        Me.Controls.Add(Me.B_EditCustomer)
        Me.Controls.Add(Me.B_AddCustomer)
        Me.Controls.Add(Me.B_CustomerBack)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CustomerForm"
        Me.Text = "CustomerForm"
        CType(Me.Gr_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents B_CustomerBack As System.Windows.Forms.Button
    Friend WithEvents B_AddCustomer As System.Windows.Forms.Button
    Friend WithEvents B_EditCustomer As System.Windows.Forms.Button
    Friend WithEvents Gr_Customer As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents City As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Country As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
