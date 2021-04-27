Module Module1
    Sub Main()

        Console.SetWindowSize(120, 45)

        Randomize()
        Dim AllFaces() As CardFace = MakeFaces()
        Dim AllSuits() As Suit
        Dim GameDeck As Deck
        Dim SingleCard As Card
        Dim TheHand() As Card
        Dim WinLevel As WinLevel
        Dim Index As String

        AllSuits = MakeSuits()
        GameDeck = MakeADeck(AllSuits, AllFaces)

        ' Get Hand > Sort Hand > Draw Hand > Assign Win Level > Ask for cards to switch > take out cards > place in deck > get new cards > draw hand > assign win level
        ' Get Win Level with value on how good that win level is?


        TheHand = BubbleSort(DealAHand(GameDeck))
        DrawAHand(30, 0, TheHand)

        WinLevel = AssignWinLevel(TheHand)

        Console.SetCursorPosition(0, 0)
        Console.WriteLine("hand lvl: " & WinLevel)

        Console.SetCursorPosition(30, 15)

        SwapHand(GameDeck, TheHand)

        DrawAHand(30, 30, TheHand)
        WinLevel = AssignWinLevel(TheHand)

        Console.SetCursorPosition(30, 29)
        Console.WriteLine("hand lvl: " & WinLevel)
        Console.ReadLine()

    End Sub
    Sub SwapHand(ByRef GameDeck As Deck, ByRef TheHand() As Card)
        Console.WriteLine("What cards would you like to switch out? (1=card one, 1,2,3=card one, two and three)")
        Dim SwapStr() As String = Split(Console.ReadLine(), ",")
        Dim SwapCards(SwapStr.Length - 1) As Card
        If SwapStr.Length = 5 Then
            GameDeck = ReturnHandToBottomOfDeck(TheHand, GameDeck)
            TheHand = DealAHand(GameDeck)
        Else
            For i = 1 To SwapCards.Length
                GameDeck = ReturnCardToBottomOfDeck(TheHand(SwapStr(i - 1) - 1), GameDeck)
                TheHand(SwapStr(i - 1) - 1) = TakeCardFromTopOfDeck(GameDeck)
                GameDeck = PushCardsForwardByOne(GameDeck)
            Next
        End If
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

    Function AssignWinLevel(Hand() As Card) As WinLevel
        Dim WinLvl As New WinLevel With {.Level = 1, .Value = 1} ' < Weakest hand value
        ' Modify the checks to return a winvalue structure

        ' test from weakest hand to strongest
        'If TF_OnePair(Hand) Then
        '    WinLvl = 2
        'End If
        'If TF_TwoPair(Hand) Then
        '    WinLvl = 3
        'End If
        'If TF_ThreeKind(Hand) Then
        '    WinLvl = 4
        'End If
        'If TF_Straight(Hand) Then
        '    WinLvl = 5
        'End If
        'If TF_Flush(Hand) Then
        '    WinLvl = 6
        'End If
        'If TF_FullHouse(Hand) Then
        '    WinLvl = 7
        'End If
        'If TF_FourKind(Hand) Then
        '    WinLvl = 8
        'End If
        'If TF_StrightFlush(Hand) Then
        '    WinLvl = 9
        'End If
        If TF_OnePair(Hand).Level > WinLvl.Level Then
            WinLvl = TF_OnePair(Hand)
        End If
        If TF_TwoPair(Hand).Level > WinLvl.
        Return WinLvl
    End Function

    Function TF_StrightFlush(ByVal Hand() As Card) As WinLevel
        ' everthing in order and same suit
        If TF_Straight(Hand).Level <> -1 And TF_Flush(Hand).Level <> -1 Then
            Return New WinLevel With {.Level = 9, .Value = 1}
        Else
            Return New WinLevel With {.Level = -1, .Value = -1}
        End If
    End Function

    Function TF_FullHouse(ByVal Hand() As Card) As WinLevel
        ' 1 three and 1 pair
        If (Hand(0).Face.CardValue = Hand(1).Face.CardValue And Hand(2).Face.CardValue = Hand(4).Face.CardValue) Or (Hand(0).Face.CardValue = Hand(2).Face.CardValue And Hand(0).Face.CardValue = Hand(2).Face.CardValue And Hand(3).Face.CardValue = Hand(4).Face.CardValue And Hand(1).Face.CardValue = Hand(2).Face.CardValue) Then
            Return New WinLevel With {.Level = 7, .Value = 1}
        Else
            Return New WinLevel With {.Level = -1, .Value = -1}
        End If

    End Function

    Function TF_Flush(ByVal Hand() As Card) As WinLevel
        ' everying same suit
        Dim i As Integer
        Dim Flag As New WinLevel With {.Level = 6, .Value = 1}
        Do While Flag.Value <> 6 And i < 4
            If Hand(i).CardSuit.CharCode <> Hand(i + 1).CardSuit.CharCode Then
                Flag.Level = -1
                Flag.Value = -1
            End If
            i += 1
        Loop
        Return Flag
    End Function

    Function TF_Straight(ByVal Hand() As Card) As WinLevel
        ' everthing in order
        Dim i As Integer
        Dim Flag As New WinLevel With {.Level = 5, .Value = 1}
        Do While Flag.Value <> 6 And i < 4
            If Hand(i).Face.CardValue <> Hand(i + 1).Face.CardValue + 1 Then
                Flag.Level = -1
                Flag.Value = -1
            End If
            i += 1
        Loop
        Return Flag
    End Function

    Function TF_TwoPair(ByVal Hand() As Card) As WinLevel
        If (Hand(0).Face.CardValue = Hand(1).Face.CardValue And Hand(2).Face.CardValue = Hand(3).Face.CardValue) Or (Hand(1).Face.CardValue = Hand(2).Face.CardValue And Hand(3).Face.CardValue = Hand(4).Face.CardValue) Or (Hand(0).Face.CardValue = Hand(1).Face.CardValue And Hand(3).Face.CardValue = Hand(4).Face.CardValue) Then
            Return New WinLevel With {.Level = 3, .Value = Hand(3).Face.CardValue}
        Else
            Return New WinLevel With {.Level = -1, .Value = -1}
        End If
    End Function

    Function TF_OnePair(ByVal Hand() As Card) As WinLevel
        Hand = BubbleSort(Hand)
        For i = 0 To 3
            If Hand(i).Face.CardValue = Hand(i + 1).Face.CardValue Then
                Return New WinLevel With {.Level = 2, .Value = Hand(i).Face.CardValue}
            End If
        Next
        Return New WinLevel With {.Level = -1, .Value = -1}
    End Function

    Function TF_ThreeKind(ByVal Hand() As Card) As WinLevel
        Hand = BubbleSort(Hand)
        For i = 0 To 2
            If Hand(i).Face.CardValue = Hand(i + 2).Face.CardValue Then
                Return New WinLevel With {.Level = 4, .Value = Hand(i).Face.CardValue}
            End If
        Next
        Return New WinLevel With {.Level = -1, .Value = -1}
    End Function

    Function TF_FourKind(ByVal Hand() As Card) As WinLevel
        Hand = BubbleSort(Hand)
        For i = 0 To 1
            If Hand(i).Face.CardValue = Hand(i + 3).Face.CardValue Then
                Return New WinLevel With {.Level = 8, .Value = Hand(i).Face.CardValue}
            End If
        Next
        Return New WinLevel With {.Level = -1, .Value = -1}
    End Function
End Module
