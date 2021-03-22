Module Module1
    Structure Suit
        Dim Name As String
        Dim Colour As ConsoleColor
        Dim SymbolChar As Integer
    End Structure
    Structure Card
        Dim CardVal As Integer
        Dim CardWord As String
        Dim CardSuit As Suit
    End Structure
    Structure Deck
        Dim TheDeck() As Card
        Dim CardDrawn As Boolean
        Dim HandDrawn As Boolean
        Function GetCard()
            Dim Card As Card = TheDeck(0)
            For i = 1 To TheDeck.Length - 1
                TheDeck(i - 1) = TheDeck(i)
            Next
            ReDim Preserve TheDeck(TheDeck.Length - 2)
            Return Card
        End Function
        Sub ReturnCard(RetCard As Card)
            ReDim Preserve TheDeck(TheDeck.Length)
            TheDeck(TheDeck.Length - 1) = RetCard
        End Sub
        Function GetHand()
            Dim Hand(4) As Card ' Hand size hardcoded
            For i = 0 To Hand.Length - 1
                Hand(i) = TheDeck(i)
            Next
            For i = 1 To TheDeck.Length - 1
                TheDeck(i - 1) = TheDeck(i)
            Next
            ReDim Preserve TheDeck(TheDeck.Length - 6)
            Return Hand
        End Function
        Sub ReturnHand(RetHand() As Card)
            Dim Index As Integer
            ReDim Preserve TheDeck(TheDeck.Length + (RetHand.Length - 1))
            For i = TheDeck.Length - RetHand.Length To TheDeck.Length - 1
                TheDeck(i) = RetHand(Index)
                Index += 1
            Next
        End Sub
    End Structure
    Sub Main()
        Dim AllSuits() As Suit = MakeSuits()
        Dim Deck As Deck = MakeDeck(AllSuits)
        Console.Title = "Card Deck functionality demo"
        ' Budget struct solution 
        Console.SetWindowSize(200, 60)
        Console.BackgroundColor = ConsoleColor.DarkGreen
        Console.Clear()
        Dim CardX As Integer = 10
        Dim CardY As Integer = 8
        Dim StartCard = {2, 2}
        For i = 1 To Deck.TheDeck.Length
            DrawCard(StartCard, CardX, CardY, Deck.TheDeck(i - 1))
            StartCard(0) += CardX - 2
            If i Mod 13 = 0 Then
                StartCard(0) = 2
                StartCard(1) += CardY + 1
            End If
        Next

        ' Deck functionality demo 
        Dim Choice As String = " "
        Dim SingleCard As New Card
        Dim SingleHand(4) As Card
        Do
            Console.SetCursorPosition(3, 40)
            Console.BackgroundColor = ConsoleColor.DarkGreen
            Console.ForegroundColor = ConsoleColor.Black
            Console.Write("(D)eck   |   (C)ard   |   (H)and   |   (R)eturn card   |   Return H(A)nd   |   (Q)uit")
            Choice = ChrW(Console.ReadKey().Key)
            Console.WriteLine("")
            Select Case Choice
                Case Is = "D"
                    Deck = MakeDeck(AllSuits)
                    DrawDeck(Deck)
                Case Is = "C"
                    If Deck.CardDrawn Then
                        Console.WriteLine("A card has already been drawn!")
                    Else
                        SingleCard = Deck.GetCard()
                        StartCard = {2, 45}
                        DrawDeck(Deck)
                        DrawCard(StartCard, CardX, CardY, SingleCard)
                    End If
                Case Is = "H"
                    SingleHand = Deck.GetHand()
                    StartCard = {40, 45}
                    DrawDeck(Deck)
                    For i = 0 To SingleHand.Length - 1
                        DrawCard(StartCard, CardX, CardY, SingleHand(i))
                        StartCard(0) += CardX - 2
                    Next
                Case Is = "R"
                    Deck.ReturnCard(SingleCard)
                    SingleCard = New Card
                    Console.Clear()
                    DrawDeck(Deck)
                Case Is = "A"
                    Deck.ReturnHand(SingleHand)
                    SingleHand(4) = New Card
                    Console.Clear()
                    DrawDeck(Deck)
            End Select
        Loop Until Choice = "Q"
        'Console.ReadLine() 
    End Sub
    Function DrawDeck(ByVal Deck As Deck)
        Console.SetWindowSize(200, 60)
        Console.BackgroundColor = ConsoleColor.DarkGreen
        Console.Clear()
        Dim CardX As Integer = 10
        Dim CardY As Integer = 8
        Dim StartCard = {2, 2}

        For i = 1 To Deck.TheDeck.Length
            DrawCard(StartCard, CardX, CardY, Deck.TheDeck(i - 1))
            StartCard(0) += CardX - 2
            If i Mod 13 = 0 Then
                StartCard(0) = 2
                StartCard(1) += CardY + 1
            End If
        Next
    End Function
    Function MakeSuits()
        Dim AllSuits(3) As Suit
        Dim Names() As String = {"Hearts", "Diamonds", "Clubs", "Spades"}
        Dim CharCodes() As Integer = {3, 4, 5, 6}
        For i = 0 To AllSuits.Length - 1
            AllSuits(i).Name = Names(i)
            AllSuits(i).SymbolChar = CharCodes(i)
            If i < 2 Then
                AllSuits(i).Colour = ConsoleColor.Red
            Else
                AllSuits(i).Colour = ConsoleColor.Black
            End If
        Next
        Return AllSuits
    End Function
    Function MakeCard(ByVal CardVal As Integer, ByVal CardWord As String, ByVal CardSuit As Suit)
        Dim i As New Card With {.CardVal = CardVal, .CardWord = CardWord, .CardSuit = CardSuit}
        Return i
    End Function
    Function MakeDeck(ByVal Suits() As Suit)
        Dim ADeck As Deck
        Dim Index As Integer = 0
        Dim TempCard As Card
        ' Make 52 unique cards    
        ' - Ace, 2 - 10, J, Q, K    
        ' - For each suit    
        ' Randomise the deck    
        ' Make array of cards logically / in order    
        ' Copy card in proper array in a random order, if value = null ingore and try again    
        ' Remove card from prev array    
        ' Once all the cards are null    
        For i = 0 To 3 ' 4 suits    
            For y = 1 To 13
                ReDim Preserve ADeck.TheDeck(Index)
                TempCard.CardSuit = Suits(i)
                TempCard.CardVal = y
                Select Case y
                    Case 1
                        TempCard.CardWord = "Ace"
                    Case 11
                        TempCard.CardWord = "Jack"
                    Case 12
                        TempCard.CardWord = "Queen"
                    Case 13
                        TempCard.CardWord = "King"
                    Case Else
                        TempCard.CardWord = y
                End Select
                ADeck.TheDeck(Index) = TempCard
                Index += 1
            Next
        Next
        'Dim ShuffledDeck As Deck = 
        ShuffleDeck(ADeck.TheDeck)
        Return ADeck
    End Function
    Function GenRndNum(z As Integer)
        Return Int(z * Rnd() + 1)
    End Function
    Sub DrawCard(ByVal StartCard As Integer(), ByVal CardX As Integer, ByVal CardY As Integer, ByVal Card As Card)
        ' Draw Back of card      
        Console.BackgroundColor = ConsoleColor.White
        For x = 1 To CardX
            For y = 1 To CardY
                Console.ForegroundColor = ConsoleColor.Blue
                Console.SetCursorPosition(StartCard(0) + x, StartCard(1) + y)
                Console.Write(" ")
                If (y = 1 Or y = CardY) Xor (x <> 1 Or x <> CardX) Then
                    Console.SetCursorPosition(StartCard(0) + x, StartCard(1) + y)
                    Console.Write(ChrW(9579))
                End If
                Console.SetCursorPosition(StartCard(0) + x, StartCard(1) + y)
                If (y = 1 Or y = CardY) Or (x = 1 Or x = CardX) Then
                    If y = 1 And x = 1 Then
                        Console.Write(ChrW(9555))
                    ElseIf y = CardY And x = CardX Then
                        Console.Write(ChrW(9564))
                    ElseIf y = 1 And x = CardX Then
                        Console.Write(ChrW(9558))
                    ElseIf y = CardY And x = 1 Then
                        Console.Write(ChrW(9561))
                    ElseIf x = 1 Or x = CardX Then
                        Console.Write(ChrW(9553))
                    Else
                        Console.Write(ChrW(9552))
                    End If
                End If
            Next
        Next
        ' Delay card turnover      
        'Threading.Thread.Sleep(5) 
        ' Draw front of card      
        Console.BackgroundColor = ConsoleColor.White
        Console.ForegroundColor = ConsoleColor.Blue
        For x = 1 To CardX
            For y = 1 To CardY
                Console.SetCursorPosition(StartCard(0) + x, StartCard(1) + y)
                Console.Write(" ")
                Console.SetCursorPosition(StartCard(0) + x, StartCard(1) + y)
                If (y = 1 Or y = CardY) Or (x = 1 Or x = CardX) Then
                    If y = 1 And x = 1 Then
                        Console.Write(ChrW(9555))
                    ElseIf y = CardY And x = CardX Then
                        Console.Write(ChrW(9564))
                    ElseIf y = 1 And x = CardX Then
                        Console.Write(ChrW(9558))
                    ElseIf y = CardY And x = 1 Then
                        Console.Write(ChrW(9561))
                    ElseIf x = 1 Or x = CardX Then
                        Console.Write(ChrW(9553))
                    Else
                        Console.Write(ChrW(9552))
                    End If
                End If
            Next
            'Threading.Thread.Sleep(5) 
        Next
        Console.ForegroundColor = Card.CardSuit.Colour
        Console.SetCursorPosition(StartCard(0) + 2, StartCard(1) + 2)
        If Card.CardVal = "10" Then
            Console.Write(Left(Card.CardWord, 2))
        Else
            Console.Write(Left(Card.CardWord, 1))
        End If

        If Card.CardVal = "10" Then
            Console.SetCursorPosition(StartCard(0) + (CardX - 1), StartCard(1) + (CardY - 2))
            Console.Write(Left(Card.CardWord, 2))
        Else
            Console.SetCursorPosition(StartCard(0) + (CardX - 1), StartCard(1) + (CardY - 1))
            Console.Write(Left(Card.CardWord, 1))
        End If

        Console.SetCursorPosition(StartCard(0) + 2, StartCard(1) + 3)
        Console.Write(ChrW(Card.CardSuit.SymbolChar))
        Console.SetCursorPosition(StartCard(0) + (CardX - 1), StartCard(1) + (CardY - 1))
        Console.Write(ChrW(Card.CardSuit.SymbolChar))
    End Sub
    Sub ShuffleDeck(ByRef items() As Card)
        Dim max_index As Integer = items.Length - 1
        Dim rnd As New Random
        For i As Integer = 0 To max_index - 1
            Dim j As Integer = rnd.Next(i, max_index + 1)

            Dim temp As Card = items(i)
            items(i) = items(j)
            items(j) = temp
        Next i
    End Sub
End Module
