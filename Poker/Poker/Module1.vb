Module Module1
    Sub Main()

        Console.SetWindowSize(120, 45)

        Randomize()
        Dim AllFaces() As CardFace = MakeFaces()
        Dim AllSuits() As Suit
        Dim GameDeck As Deck
        Dim TheHand As Hand


        AllSuits = MakeSuits()
        GameDeck = MakeADeck(AllSuits, AllFaces)

        ' Get Hand > Sort Hand > Draw Hand > Assign Win Level > Ask for cards to switch > take out cards > place in deck > get new cards > draw hand > assign win level
        ' Get Win Level with value on how good that win level is?

        ' Hand 1
        TheHand.HandCards = BubbleSort(DealAHand(GameDeck))
        DrawAHand(30, 0, TheHand.HandCards)
        TheHand.WinLevel = AssignWinLevel(TheHand)
        Console.SetCursorPosition(0, 0)
        Console.WriteLine("hand lvl: " & TheHand.WinLevel.Level)
        Console.SetCursorPosition(15, 15)
        SwapHand(GameDeck, TheHand.HandCards)
        DrawAHand(30, 0, TheHand.HandCards)
        TheHand.WinLevel = AssignWinLevel(TheHand)
        Console.SetCursorPosition(0, 0)
        Console.WriteLine("hand lvl: " & TheHand.WinLevel.Level)
        Console.ReadLine()
        ' End hand 1


        ' Hand 2
        Dim Player2 As Hand
        Player2.HandCards = BubbleSort(DealAHand(GameDeck))
        DrawAHand(30, 20, Player2.HandCards)
        Player2.WinLevel = AssignWinLevel(Player2)
        Console.SetCursorPosition(0, 20)
        Console.WriteLine("hand lvl: " & Player2.WinLevel.Level)
        Console.SetCursorPosition(15, 45)
        SwapHand(GameDeck, Player2.HandCards)
        DrawAHand(30, 20, Player2.HandCards)
        Player2.WinLevel = AssignWinLevel(Player2)
        Console.SetCursorPosition(0, 20)
        Console.WriteLine("hand lvl: " & Player2.WinLevel.Level)
        Console.ReadLine()
        ' End Hand 2

        ' Find Winner
        Console.SetCursorPosition(0, 40)
        FindWinner(TheHand.WinLevel, Player2.WinLevel)

        Console.ReadLine()
    End Sub
    Sub FindWinner(Player1 As WinLevel, Player2 As WinLevel)
        If Player1.Level > Player2.Level Then
            Console.WriteLine("Player 1 has won with " & Player1.Name)
        ElseIf Player1.Level < Player2.Level Then
            Console.WriteLine("Player 2 has won with " & Player2.Name)
        ElseIf Player1.Value > Player2.Value Then
            Console.WriteLine("It was a draw, but Player 1 has a stronger hand of " & Player1.Name)
        Else
            Console.WriteLine("It was a draw, but player 2 has a stronger hand of " & Player2.Name)
        End If
    End Sub
    Sub SwapHand(ByRef GameDeck As Deck, ByRef TheHand() As Card)
        Dim SwapStr() As String = Split(InputBox("What cards would you like to switch out? (0=none, 1=card one, 1,2,3=card one, two and three)"), ",")
        If SwapStr(0) = "0" Then
        Else
            Dim SwapCards(SwapStr.Length - 1) As Card
            If SwapStr.Length = 5 Then
                GameDeck = ReturnHandToBottomOfDeck(TheHand, GameDeck)
                TheHand = DealAHand(GameDeck)
            Else
                For i = 1 To SwapCards.Length
                    If InStr(SwapStr(i - 1), "12345") <> 0 Then
                    Else
                        GameDeck = ReturnCardToBottomOfDeck(TheHand(SwapStr(i - 1) - 1), GameDeck)
                        TheHand(SwapStr(i - 1) - 1) = TakeCardFromTopOfDeck(GameDeck)
                        GameDeck = PushCardsForwardByOne(GameDeck)
                    End If
                Next
            End If
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

    Function AssignWinLevel(Hand As Hand) As WinLevel
        Dim WinLvl As New WinLevel With {.Level = 1, .Value = 1, .Name = Hand.HandCards(0).Face.CardAsWord} ' < Weakest hand value

        If TF_OnePair(Hand.HandCards).Level > WinLvl.Level Then
            WinLvl = TF_OnePair(Hand.HandCards)
        End If
        If TF_TwoPair(Hand.HandCards).Level > WinLvl.Level Then
            WinLvl = TF_TwoPair(Hand.HandCards)
        End If
        If TF_ThreeKind(Hand.HandCards).Level > WinLvl.Level Then
            WinLvl = TF_ThreeKind(Hand.HandCards)
        End If
        If TF_Straight(Hand.HandCards).Level > WinLvl.Level Then
            WinLvl = TF_ThreeKind(Hand.HandCards)
        End If
        If TF_Flush(Hand.HandCards).Level > WinLvl.Level Then
            WinLvl = TF_Flush(Hand.HandCards)
        End If
        If TF_FullHouse(Hand.HandCards).Level > WinLvl.Level Then
            WinLvl = TF_FullHouse(Hand.HandCards)
        End If
        If TF_FourKind(Hand.HandCards).Level > WinLvl.Level Then
            WinLvl = TF_FourKind(Hand.HandCards)
        End If
        If TF_StrightFlush(Hand.HandCards).Level > WinLvl.Level Then
            WinLvl = TF_StrightFlush(Hand.HandCards)
        End If
        Return WinLvl
    End Function

    Function TF_StrightFlush(ByVal Hand() As Card) As WinLevel
        ' everthing in order and same suit
        If TF_Straight(Hand).Level <> -1 And TF_Flush(Hand).Level <> -1 Then
            Return New WinLevel With {.Level = 9, .Value = 1, .Name = "Straight Flush"}
        Else
            Return New WinLevel With {.Level = -1, .Value = -1}
        End If
    End Function

    Function TF_FullHouse(ByVal Hand() As Card) As WinLevel
        ' 1 three and 1 pair
        If (Hand(0).Face.CardValue = Hand(1).Face.CardValue And Hand(2).Face.CardValue = Hand(4).Face.CardValue) Or (Hand(0).Face.CardValue = Hand(2).Face.CardValue And Hand(0).Face.CardValue = Hand(2).Face.CardValue And Hand(3).Face.CardValue = Hand(4).Face.CardValue And Hand(1).Face.CardValue = Hand(2).Face.CardValue) Then
            Return New WinLevel With {.Level = 7, .Value = 1, .Name = "Full House"}
        Else
            Return New WinLevel With {.Level = -1, .Value = -1}
        End If

    End Function

    Function TF_Flush(ByVal Hand() As Card) As WinLevel
        ' everying same suit
        Dim i As Integer
        Dim Flag As New WinLevel With {.Level = 6, .Value = 1, .Name = "Flush"}
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
        Dim Flag As New WinLevel With {.Level = 5, .Value = 1, .Name = "Straight"}
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
            Return New WinLevel With {.Level = 3, .Value = Hand(3).Face.CardValue, .Name = "Two Pair"}
        Else
            Return New WinLevel With {.Level = -1, .Value = -1}
        End If
    End Function

    Function TF_OnePair(ByVal Hand() As Card) As WinLevel
        Hand = BubbleSort(Hand)
        For i = 0 To 3
            If Hand(i).Face.CardValue = Hand(i + 1).Face.CardValue Then
                Return New WinLevel With {.Level = 2, .Value = Hand(i).Face.CardValue, .Name = "One Pair"}
            End If
        Next
        Return New WinLevel With {.Level = -1, .Value = -1}
    End Function

    Function TF_ThreeKind(ByVal Hand() As Card) As WinLevel
        Hand = BubbleSort(Hand)
        For i = 0 To 2
            If Hand(i).Face.CardValue = Hand(i + 2).Face.CardValue Then
                Return New WinLevel With {.Level = 4, .Value = Hand(i).Face.CardValue, .Name = "Three of a kind"}
            End If
        Next
        Return New WinLevel With {.Level = -1, .Value = -1}
    End Function

    Function TF_FourKind(ByVal Hand() As Card) As WinLevel
        Hand = BubbleSort(Hand)
        For i = 0 To 1
            If Hand(i).Face.CardValue = Hand(i + 3).Face.CardValue Then
                Return New WinLevel With {.Level = 8, .Value = Hand(i).Face.CardValue, .Name = "Four of a kind"}
            End If
        Next
        Return New WinLevel With {.Level = -1, .Value = -1}
    End Function
End Module
