Module CustomerModule
    Structure Cust
        Dim ID As String
        Dim CompanyName As String
        Dim ContactName As String
        Dim Address As String
        Dim City As String
        Dim Country As String
    End Structure


    Public CustomerList() As Cust
    Public CustomerTotal As Integer


    Public Sub LoadCustomers()
        FileOpen(1, "S:\Customers.txt", OpenMode.Input)
        CustomerTotal = 0
        Do While Not (EOF(1))
            ReDim Preserve CustomerList(CustomerTotal + 1)
            CustomerList(CustomerTotal).ID = LineInput(1)
            CustomerList(CustomerTotal).CompanyName = LineInput(1)
            CustomerList(CustomerTotal).ContactName = LineInput(1)
            CustomerList(CustomerTotal).Address = LineInput(1)
            CustomerList(CustomerTotal).City = LineInput(1)
            CustomerList(CustomerTotal).Country = LineInput(1)
            CustomerTotal += 1
        Loop
        ReDim Preserve CustomerList(CustomerTotal)
        FileClose(1)
        MsgBox("Loaded " & CustomerTotal & " customers from database.")
    End Sub

    Public Sub AddCustomer(ByVal Customer As Cust)
        ReDim Preserve CustomerList(CustomerTotal)
        CustomerList(CustomerList.Length - 1) = Customer

        ' Write to file

        FileOpen(1, "S:\Customers.txt", OpenMode.Output)

        For i = 0 To CustomerList.Length - 1
            PrintLine(1, CustomerList(i).ID)
            PrintLine(1, CustomerList(i).CompanyName)
            PrintLine(1, CustomerList(i).ContactName)
            PrintLine(1, CustomerList(i).Address)
            PrintLine(1, CustomerList(i).City)
            PrintLine(1, CustomerList(i).Country)
        Next
        FileClose(1)
    End Sub
End Module
