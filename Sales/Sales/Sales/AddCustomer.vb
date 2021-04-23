Public Class AddCustomer

    Private Sub B_SalesOk_Click(sender As System.Object, e As System.EventArgs) Handles B_SalesOk.Click
        Dim TempCustomer As Cust
        Dim Valid As Boolean = True

        TempCustomer.ID = In_ID.Text
        TempCustomer.CompanyName = In_Name.Text
        TempCustomer.ContactName = In_ContactName.Text
        TempCustomer.Address = In_Adress.Text
        TempCustomer.City = In_City.Text
        TempCustomer.Country = In_Country.Text

        If Len(TempCustomer.ID) <> 5 Then
            Valid = False
        ElseIf TempCustomer.ID = Nothing or TempCustomer.CompanyName = Nothing or TempCustomer.ContactName = Nothing or

        End If

        If Valid Then
            CustomerModule.AddCustomer(TempCustomer)
        Else
            MsgBox("Invalid customer, please try again")
        End If

        CustomerForm.Show()
        Me.Close()
    End Sub

    Private Sub In_Country_TextChanged(sender As System.Object, e As System.EventArgs) Handles In_Country.TextChanged

    End Sub
End Class