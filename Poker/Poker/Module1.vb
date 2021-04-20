Module Module1

    Sub Main()

        Console.SetWindowSize(120, 45)

        Randomize()
        Dim AllFaces() As CardFace = MakeFaces()
        Dim AllSuits() As Suit
        Dim GameDeck As Deck
        Dim SingleCard As Card
        Dim TheHand() As Card
        AllSuits = MakeSuits()
        GameDeck = MakeADeck(AllSuits, AllFaces)

        ' Testing out the card and hand creation and drawing ......
        'SingleCard = TakeCardFromTopOfDeck(GameDeck)
        'DrawACard(0, 0, SingleCard)
        TheHand = BubbleSort(DealAHand(GameDeck))
        DrawAHand(30, 0, TheHand)
        Console.ReadLine()


        Dim Result As Integer

        If TestForFour(TheHand) = 8 Then
            Result = 8
        ElseIf TestForThree(TheHand) = 4 Then
            Result = 4
        ElseIf TestForPair(TheHand) = 2 Then
            Result = 2
        Else
            Result = 1
        End If

        Console.SetCursorPosition(0, 0)
        Console.WriteLine(Result)

        Console.ReadLine()

    End Sub

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


    Function TestForPair(ByVal Hand() As Card) As Integer
        Hand = BubbleSort(Hand)
        For i = 0 To 3
            If Hand(i).Face.CardValue = Hand(i + 1).Face.CardValue Then
                Return 2
            End If
        Next
        Return 0
    End Function

    Function TestForThree(ByVal Hand() As Card) As Integer
        Hand = BubbleSort(Hand)
        For i = 0 To 2
            If Hand(i).Face.CardValue = Hand(i + 2).Face.CardValue Then
                Return 4
            End If
        Next
        Return 0
    End Function

    Function TestForFour(ByVal Hand() As Card) As Integer
        Hand = BubbleSort(Hand)
        For i = 0 To 1
            If Hand(i).Face.CardValue = Hand(i + 3).Face.CardValue Then
                Return 8
            End If
        Next
        Return 0
    End Function
End Module
