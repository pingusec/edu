Module Module1

    Sub Main()

        Console.SetWindowSize(120, 45)

        Randomize()
        Dim AllFaces() As CardFace = MakeFaces()
        Dim AllSuits() As Suit
        Dim GameDeck As Deck
        Dim SingleCard As Card
        Dim TheHand() As Card
        Dim WinLevel As Integer
        AllSuits = MakeSuits()
        GameDeck = MakeADeck(AllSuits, AllFaces)

        ' Get Hand > Sort Hand > DrawHand > Assign Win level

        TheHand = BubbleSort(DealAHand(GameDeck))
        DrawAHand(30, 0, TheHand)

        Console.SetCursorPosition(0, 0)
        Console.WriteLine(WinLevel)
        Console.ReadLine()

        ' implement fix level after the sort hand

        ' Testing out the card and hand creation and drawing ......
        'SingleCard = TakeCardFromTopOfDeck(GameDeck)
        'DrawACard(0, 0, SingleCard)



        WinLevel = AssignWinLevel(TheHand)


        Console.SetCursorPosition(0, 0)
        Console.WriteLine(WinLevel)



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

    Function AssignWinLevel(Hand() As Card) As Integer
        Dim WinLvl As Integer = 1 ' < Weakest hand value
        ' test from weakest hand to strongest
        If TF_OnePair(Hand) Then
            WinLvl = 2
        End If
        If TF_TwoPair(Hand) Then
            WinLvl = 3
        End If
        If TF_ThreeKind(Hand) Then
            WinLvl = 4
        End If
        If TF_Straight(Hand) Then
            WinLvl = 5
        End If
        If TF_Flush(Hand) Then
            WinLvl = 6
        End If
        If TF_FullHouse(Hand) Then
            WinLvl = 7
        End If
        If TF_FourKind(Hand) Then
            WinLvl = 8
        End If
        If TF_StrightFlush(Hand) Then
            WinLvl = 9
        End If
        Return WinLvl
    End Function

    Function TF_StrightFlush(ByVal Hand() As Card) As Boolean
        ' everthing in order and same suit
        If TF_Straight(Hand) And TF_Flush(Hand) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function TF_FullHouse(ByVal Hand() As Card) As Boolean
        ' 1 three and 1 pair

    End Function

    Function TF_Flush(ByVal Hand() As Card) As Boolean
        ' everying same suit
        Dim i As Integer
        Dim Flag As Boolean = True
        Do While Flag = True And i < 4
            Console.WriteLine(i)
            If Hand(i).CardSuit.CharCode <> Hand(i + 1).CardSuit.CharCode Then
                Flag = False
            End If
            i += 1
        Loop
        Return Flag
    End Function

    Function TF_Straight(ByVal Hand() As Card) As Boolean
        ' everthing in order
        Dim i As Integer
        Dim Flag As Boolean = True
        Do While Flag = True And i < 4
            Console.WriteLine(i)
            If Hand(i).Face.CardValue <> Hand(i + 1).Face.CardValue - 1 Then
                Flag = False
            End If
            i += 1
        Loop
        Return Flag
    End Function

    Function TF_TwoPair(ByVal Hand() As Card) As Boolean
        If (Hand(0).Face.CardValue = Hand(1).Face.CardValue And Hand(2).Face.CardValue = Hand(3).Face.CardValue) Or (Hand(1).Face.CardValue = Hand(2).Face.CardValue And Hand(3).Face.CardValue = Hand(4).Face.CardValue) Or (Hand(0).Face.CardValue = Hand(1).Face.CardValue And Hand(4).Face.CardValue = Hand(5).Face.CardValue) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function TF_OnePair(ByVal Hand() As Card) As Boolean
        Hand = BubbleSort(Hand)
        For i = 0 To 3
            If Hand(i).Face.CardValue = Hand(i + 1).Face.CardValue Then
                Return True
            End If
        Next
        Return False
    End Function

    Function TF_ThreeKind(ByVal Hand() As Card) As Boolean
        Hand = BubbleSort(Hand)
        For i = 0 To 2
            If Hand(i).CardSuit.CharCode = Hand(i + 2).CardSuit.CharCode Then
                Return True
            End If
        Next
        Return False
    End Function

    Function TF_FourKind(ByVal Hand() As Card) As Boolean
        Hand = BubbleSort(Hand)
        For i = 0 To 1
            If Hand(i).CardSuit.CharCode = Hand(i + 3).CardSuit.CharCode Then
                Return True
            End If
        Next
        Return False
    End Function
End Module
