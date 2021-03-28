Structure Face
    Dim CardValue As Integer
    Dim CardWord As String
    Dim DotPos() As String
End Structure
Structure Suit
    Dim Name As String
    Dim Colour As ConsoleColor
    Dim SymbolChar As Integer
End Structure
Structure Card
    Dim CardSuit As Suit
    Dim CardFace As Face
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
Module Program

    Dim DotCoords() As String = LoadDots()

    ' Demo code for Face struct


    Sub Main()
        ' Setup funcs
        ' -----------
        Dim AllFaces() As Face = LoadFaces()

        Dim AllSuits() As Suit = MakeSuits()

        ' Default vals
        ' ------------
        Dim CardX As Integer = 11
        Dim CardY As Integer = 11
        Dim StartCard = {2, 2}

        Console.Title = "Card Deck functionality demo"
        Console.SetWindowSize(200, 70)
        Console.BackgroundColor = ConsoleColor.DarkGreen
        Console.Clear()

        ' Deck generation
        ' ---------------
        Dim Deck As Deck = MakeDeck(AllSuits, AllFaces)

        'DrawCard(StartCard, CardX, CardY, Deck.TheDeck(1))

        DrawDeck(Deck)

        ' Deck functionality demo 
        Dim Choice As String = " "
        Dim SingleCard As New Card
        Dim SingleHand(4) As Card
        Do
            Console.SetCursorPosition(3, 52)
            Console.BackgroundColor = ConsoleColor.DarkGreen
            Console.ForegroundColor = ConsoleColor.Black
            Console.Write("(D)eck   |   (C)ard   |   (H)and   |   (R)eturn card   |   Return H(A)nd   |   (Q)uit")
            Choice = ChrW(Console.ReadKey().Key)
            Console.WriteLine("")
            Select Case Choice
                Case Is = "D"
                    Deck = MakeDeck(AllSuits, AllFaces)
                    DrawDeck(Deck)
                Case Is = "C"
                    If Deck.CardDrawn Then
                        Console.WriteLine("A card has already been drawn!")
                    Else
                        SingleCard = Deck.GetCard()
                        StartCard = {2, 55}
                        DrawDeck(Deck)
                        DrawCard(StartCard, CardX, CardY, SingleCard)
                    End If
                Case Is = "H"
                    SingleHand = Deck.GetHand()
                    StartCard = {40, 55}
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

    End Sub
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
    Function MakeDeck(ByVal Suits() As Suit, ByVal Faces() As Face)
        Dim Deck As Deck
        Dim Index As Integer = 0
        Dim TempCard As Card
        For i = 0 To 3 ' 4 suits    
            For y = 1 To 13
                ReDim Preserve Deck.TheDeck(Index)
                TempCard.CardSuit = Suits(i)
                TempCard.CardFace = Faces(y - 1)
                Deck.TheDeck(Index) = TempCard
                Index += 1
            Next
        Next
        Dim ShuffledDeck As Deck
        ShuffleDeck(Deck.TheDeck)
        Return Deck
    End Function
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
    Sub DrawCard(ByVal StartCard As Integer(), ByVal CardX As Integer, ByVal CardY As Integer, ByVal Card As Card)
        ' Draw back of card
        ' -----------------
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
        ' Draw front of card 
        ' ------------------
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
        Next
        Console.ForegroundColor = Card.CardSuit.Colour
        Console.SetCursorPosition(StartCard(0) + 2, StartCard(1) + 2)
        If Card.CardFace.CardValue = "10" Then
            Console.Write(Card.CardFace.CardWord)
        Else
            Console.Write(Left(Card.CardFace.CardWord, 1))
        End If

        If Card.CardFace.CardValue = "10" Then
            Console.SetCursorPosition(StartCard(0) + (CardX - 2), StartCard(1) + (CardY - 2))
            Console.Write(Card.CardFace.CardWord, 2)
        Else
            Console.SetCursorPosition(StartCard(0) + (CardX - 1), StartCard(1) + (CardY - 2))
            Console.Write(Left(Card.CardFace.CardWord, 1))
        End If

        ' Writing suit symbol in corners
        ' ------------------------------
        Console.SetCursorPosition(StartCard(0) + 2, StartCard(1) + 3)
        Console.Write(ChrW(Card.CardSuit.SymbolChar))
        Console.SetCursorPosition(StartCard(0) + (CardX - 1), StartCard(1) + (CardY - 1))
        Console.Write(ChrW(Card.CardSuit.SymbolChar))

        ' Drawing card designs
        ' --------------------

        ' this is exactly why I took gcse graphics

        Dim xy() As String
        Dim colours() As ConsoleColor = LoadColours()
        Select Case Card.CardFace.CardValue
            Case 1 To 10
                For i = 0 To Card.CardFace.DotPos.Length - 1
                    xy = Split(DotCoords(Card.CardFace.DotPos(i)), ",")
                    Console.SetCursorPosition(StartCard(0) + xy(0), StartCard(1) + xy(1))
                    Console.Write(ChrW(Card.CardSuit.SymbolChar))
                Next
            Case Else
                For x = 3 To CardX - 3
                    For y = 3 To CardY - 2
                        Console.ForegroundColor = colours(GenRndNum(colours.Length - 1))
                        Console.SetCursorPosition(StartCard(0) + x, StartCard(1) + y)
                        Console.Write(ChrW(&H2588))
                    Next
                Next
        End Select



    End Sub
    Sub DrawDeck(ByVal Deck As Deck)
        Console.BackgroundColor = ConsoleColor.DarkGreen
        Console.Clear()
        Dim CardX As Integer = 11
        Dim CardY As Integer = 11
        Dim StartCard = {2, 2}

        For i = 1 To Deck.TheDeck.Length
            DrawCard(StartCard, CardX, CardY, Deck.TheDeck(i - 1))
            StartCard(0) += CardX - 2
            If i Mod 13 = 0 Then
                StartCard(0) = 2
                StartCard(1) += CardY + 1
            End If
        Next
    End Sub

    Function LoadFaces() As Face()
        Dim Faces() As Face
        Dim Line() As String

        FileOpen(1, "D:\Documents\AllFaces.txt", OpenMode.Input)

        For i = 0 To 12
            ReDim Preserve Faces(i)
            Line = Split(LineInput(1), ";")
            Faces(i).CardValue = Line(0)
            Faces(i).CardWord = Line(1)
            Faces(i).DotPos = Split(Line(2), ",")
        Next

        FileClose(1)

        Return Faces
    End Function
    Function LoadDots() As String()
        Dim DotCoords() As String
        Dim index As Integer

        FileOpen(1, "D:\Documents\DotCoords.txt", OpenMode.Input)

        Do While Not EOF(1)
            ReDim Preserve DotCoords(index + 1)
            DotCoords(index) = LineInput(1) ' gotta split the line later <-----

            index += 1
        Loop
        FileClose(1)
        Return DotCoords
    End Function
    Function GenRndNum(z As Integer)
        Return Int(z * Rnd() + 1)
    End Function

    Function LoadColours() As ConsoleColor()
        Dim Colours() As ConsoleColor = {ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue, ConsoleColor.DarkCyan}
        Return Colours
    End Function
End Module
