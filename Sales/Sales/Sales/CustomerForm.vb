Public Class CustomerForm

    Private Sub B_CustomerBack_Click(sender As System.Object, e As System.EventArgs) Handles B_CustomerBack.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub B_AddCustomer_Click(sender As System.Object, e As System.EventArgs) Handles B_AddCustomer.Click
        AddCustomer.Show()
        Me.Close()
    End Sub

    Private Sub B_EditCustomer_Click(sender As System.Object, e As System.EventArgs) Handles B_EditCustomer.Click
        EditCustomer.Show()
        Me.Close()
    End Sub

    Private Sub CustomerForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CustomerModule.LoadCustomers()
        For i = 0 To CustomerModule.CustomerTotal
            Gr_Customer.Rows.Add()
            Gr_Customer.Item(0, i).Value = CustomerModule.CustomerList(i).ID
            Gr_Customer.Item(1, i).Value = CustomerModule.CustomerList(i).CompanyName
            Gr_Customer.Item(2, i).Value = CustomerModule.CustomerList(i).ContactName
            Gr_Customer.Item(3, i).Value = CustomerModule.CustomerList(i).Address
            Gr_Customer.Item(4, i).Value = CustomerModule.CustomerList(i).City
            Gr_Customer.Item(5, i).Value = CustomerModule.CustomerList(i).Country
        Next
    End Sub
End Class