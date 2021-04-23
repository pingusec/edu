Public Class Form1



    Private Sub B_Customer_Click(sender As System.Object, e As System.EventArgs) Handles B_Customer.Click
        CustomerForm.Show()
        Me.Close()
    End Sub

    Private Sub B_Sales_Click(sender As System.Object, e As System.EventArgs) Handles B_Sales.Click
        ProductForm.Show()
        Me.Close()
    End Sub
End Class
