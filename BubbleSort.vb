    Function BubbleSort(ByVal Array() As Card) As Card()
        Dim temp As Card
        For i = 0 To Array.Length - 2
            For z = 0 To Array.Length - 2
                If Array(z).Face.CardValue < Array(z + 1).Face.CardValue Then
                    temp = Array(z)
                    Array(z) = Array(z + 1)
                    Array(z + 1) = temp
                End If
            Next
        Next
        Return Array
    End Function
