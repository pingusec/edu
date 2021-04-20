Module Module2
    ' Set console to Courier New size 16 OR Raster Fonts 8 x 12
    ' Create a notepad file with the data below
    ' Get rid of first character (') on each line
    ' Save the file in the root of your user area. Call the file Card Data
    ' [Cross check in the function MakeFaces() below.]
    '1;Ace;10
    '2;two;7,13
    '3;three;4,10,16
    '4;four;6,8,12,14
    '5;five;6,8,10,12,14
    '6;six;3,5,9,11,15,17
    '7;seven;3,5,7,9,11,15,17
    '8;eight;0,2,6,8,12,14,18,20
    '9;nine;0,2,4,6,8,12,14,18,20
    '10;ten;0,2,4,6,8,12,14,16,18,20
    '11;Jack;Picture Card
    '12;Queen;Picture Card
    '13;King;Picture Card
    Structure Suit
        Dim Name As String
        Dim Colour As ConsoleColor
        Dim CharCode As Integer
        Dim AcePattern As String
    End Structure
    Structure CardFace
        Dim CardValue As Integer
        Dim CardAsWord As String
        Dim DotPositions() As String
    End Structure
    Structure Card
        Dim CardSuit As Suit
        Dim Face As CardFace
    End Structure
    Structure Deck
        Dim DeckCards() As Card
        Dim DeckSize As Integer
    End Structure
    Structure Hand
        Dim HandCards() As Card
    End Structure
    Function MakeFaces() As CardFace()
        Dim TheFaces(12) As CardFace
        Dim TempArray() As String
        FileOpen(1, "S:\Card Data.txt", OpenMode.Input)
        For Looper = 0 To 12
            TempArray = Split(LineInput(1), ";")
            TheFaces(Looper).CardValue = TempArray(0)
            TheFaces(Looper).CardAsWord = TempArray(1)
            TheFaces(Looper).DotPositions = Split(TempArray(2), ",")
        Next
        FileClose(1)
        Return TheFaces
    End Function
    Function MakeSuits() As Suit()
        Dim SuitNames() As String = {"Hearts", "Diamonds", "Clubs", "Spades"}
        Dim AceStrings() As String = {"0101011111111110111000100",
        "0010001110111110111000100",
        "0111010101111111010100100",
        "0010001110111110010001110"}
        Dim SuitCharCodes() As Integer = {3, 4, 5, 6}
        Dim TheSuits(3) As Suit
        For Looper = 0 To 3
            TheSuits(Looper).Name = SuitNames(Looper)
            TheSuits(Looper).CharCode = SuitCharCodes(Looper)
            TheSuits(Looper).AcePattern = AceStrings(Looper)
            If Looper < 2 Then
                TheSuits(Looper).Colour = ConsoleColor.Red
            Else
                TheSuits(Looper).Colour = ConsoleColor.Black
            End If
        Next
        Return TheSuits
    End Function
    Function MakeACard(ByVal AllSuits() As Suit,
    ByVal AllFaces() As CardFace) As Card
        Dim TheCard As Card
        Dim CardNo As Integer = Int(13 * Rnd() + 1)
        Dim SuitNo As Integer = Int(4 * Rnd())
        TheCard.CardSuit = AllSuits(SuitNo)
        TheCard.Face = AllFaces(CardNo - 1)
        Return TheCard
    End Function
    Function MakeADeck(ByVal AllSuits() As Suit,
    ByVal AllFaces() As CardFace) As Deck
        Dim TheDeck As Deck
        Dim PossibleCard As Card
        Dim CheckArray(3, 12) As Boolean
        ReDim TheDeck.DeckCards(51)
        For Looper = 0 To 51
            Do
                PossibleCard = MakeACard(AllSuits, AllFaces)
            Loop Until CheckArray(PossibleCard.CardSuit.CharCode - 3,
            PossibleCard.Face.CardValue - 1) = False
            ' put possible card into deck
            TheDeck.DeckCards(Looper) = PossibleCard
            ' set the check array element to TRUE
            CheckArray(PossibleCard.CardSuit.CharCode - 3,
            PossibleCard.Face.CardValue - 1) = True
        Next
        TheDeck.DeckSize = 52
        Return TheDeck
    End Function
    Sub DrawTheDeck(ByVal StartX As Integer,
     ByVal StartY As Integer,
     ByVal TheDeck As Deck)
        Dim StartOnScreen As Integer = 55
        StartX = StartOnScreen
        For Looper = 0 To TheDeck.DeckSize - 1
            DrawCardFaceDown(StartX, StartY)
            'System.Threading.Thread.Sleep(30)
            DrawACard(StartX, StartY, TheDeck.DeckCards(Looper))
            If Looper > 0 And (Looper + 1) Mod 13 = 0 Then
                StartOnScreen -= 17
                StartX = StartOnScreen
                StartY = 0
                ' StartY += 12
                ' StartX = 0
            Else
                StartX += 3
                StartY += 1
            End If
        Next
    End Sub
    Sub DrawAHand(ByVal StartX As Integer,
    ByVal StartY As Integer,
    ByVal TheHand() As Card)
        For Looper = 0 To TheHand.Length - 1
            DrawCardFaceDown(StartX, StartY)
            'System.Threading.Thread.Sleep(100)
            DrawACard(StartX, StartY, TheHand(Looper))
            StartX += 8
            'StartY += 1
        Next
    End Sub
    Sub DrawCardFaceDown(ByVal StartX As Integer, ByVal StartY As Integer)
        Console.BackgroundColor = ConsoleColor.White
        Console.ForegroundColor = ConsoleColor.Red
        Dim CharacterCodeToPrint As Integer
        For XLoop = 1 To 11
            For YLoop = 1 To 11
                CharacterCodeToPrint = 9579 ' set to print a ╫ character (most common) ......
                Console.SetCursorPosition(StartX + XLoop, StartY + YLoop)
                If XLoop = 1 And YLoop = 1 Then
                    CharacterCodeToPrint = 9555 ' .. for top left corner set to print a ╓ character
                ElseIf YLoop = 1 And XLoop = 11 Then
                    CharacterCodeToPrint = 9558 ' .. for top right corner set to print a ╖ character
                ElseIf YLoop = 11 And XLoop = 1 Then
                    CharacterCodeToPrint = 9561 ' .. for bottom left corner set to print a ╙ character
                ElseIf YLoop = 11 And XLoop = 11 Then
                    CharacterCodeToPrint = 9564 ' .. for bottom right corner set to print a ╜ character
                ElseIf YLoop = 1 Then
                    CharacterCodeToPrint = 9573 ' .. for top row
                ElseIf YLoop = 11 Then
                    CharacterCodeToPrint = 9576 ' .. for bottom row
                ElseIf XLoop = 1 Then
                    CharacterCodeToPrint = 9567 ' .. for left column
                ElseIf XLoop = 11 Then
                    CharacterCodeToPrint = 9570 ' .. for right column
                End If
                Console.Write(ChrW(CharacterCodeToPrint))
            Next
        Next
    End Sub
    Sub DrawACard(ByVal StartX As Integer,
    ByVal StartY As Integer,
    ByVal AnyCard As Card)
        Console.BackgroundColor = ConsoleColor.White
        Console.ForegroundColor = ConsoleColor.Blue
        Dim CharacterCodeToPrint As Integer
        For XLoop = 1 To 11
            For YLoop = 1 To 11
                CharacterCodeToPrint = 32 ' 32 is the code for a space ...... most common
                Console.SetCursorPosition(StartX + XLoop, StartY + YLoop)
                If XLoop = 1 And YLoop = 1 Then
                    CharacterCodeToPrint = 9555 ' .. or top left corner
                ElseIf YLoop = 1 And XLoop = 11 Then
                    CharacterCodeToPrint = 9558 ' .. or top right corner
                ElseIf YLoop = 11 And XLoop = 1 Then
                    CharacterCodeToPrint = 9561 ' .. or bottom left corner
                ElseIf YLoop = 11 And XLoop = 11 Then
                    CharacterCodeToPrint = 9564 ' .. or bottom right corner
                ElseIf YLoop = 1 Or YLoop = 11 Then
                    CharacterCodeToPrint = 9552 ' .. or top or bottom row
                ElseIf XLoop = 1 Or XLoop = 11 Then
                    CharacterCodeToPrint = 9553 ' .. or left or right column
                End If
                Console.Write(ChrW(CharacterCodeToPrint))
            Next
        Next
        Console.ForegroundColor = AnyCard.CardSuit.Colour
        Console.SetCursorPosition(StartX + 2, StartY + 2)
        Console.Write(GetCardTextFromValue(AnyCard))
        Console.SetCursorPosition(StartX + 2, StartY + 3)
        Console.Write(ChrW(AnyCard.CardSuit.CharCode))
        Dim XOffset As Integer
        Console.SetCursorPosition(StartX + 10, StartY + 9)
        Console.Write(ChrW(AnyCard.CardSuit.CharCode))
        If AnyCard.Face.CardValue = "10" Then XOffset = 9 Else XOffset = 10
        Console.SetCursorPosition(StartX + XOffset, StartY + 10)
        Console.Write(GetCardTextFromValue(AnyCard))
        Select Case AnyCard.Face.CardValue
            Case 1
                DrawAceCard(StartX, StartY, AnyCard)
            Case 11, 12, 13
                DrawPictureCard(StartX, StartY, AnyCard)
            Case Else
                DrawCardDots(StartX, StartY, AnyCard)
        End Select
    End Sub
    Sub DrawCardDots(ByVal StartX As Integer,
    ByVal StartY As Integer,
    ByVal AnyCard As Card)
        Dim DotCoordinates() As String = Split("4,3;6,3;8,3;4,4;6,4;8,4;4,5;6,5;8,5;4,6;6,6;8,6;4,7;6,7;8,7;4,8;6,8;8,8;4,9;6,9;8,9", ";")
        Dim TempXY() As String
        For Looper = 0 To AnyCard.Face.DotPositions.Length - 1
            TempXY = Split(DotCoordinates(AnyCard.Face.DotPositions(Looper)), ",")
            Console.SetCursorPosition(StartX + TempXY(0), StartY + TempXY(1))
            Console.Write(ChrW(AnyCard.CardSuit.CharCode))
        Next
    End Sub
    Sub DrawAceCard(ByVal StartX As Integer,
    ByVal StartY As Integer,
    ByVal AnyCard As Card)
        Dim PixelCounter As Integer
        For Looper1 = 4 To 8
            For Looper2 = 4 To 8
                If AnyCard.CardSuit.AcePattern(PixelCounter) = "1" Then
                    Console.BackgroundColor = AnyCard.CardSuit.Colour
                Else
                    Console.BackgroundColor = 15
                End If
                Console.SetCursorPosition(Looper2 + StartX, Looper1 + StartY)
                Console.Write(" ")
                PixelCounter += 1
            Next
        Next
    End Sub
    Sub DrawPictureCard(ByVal StartX As Integer,
    ByVal StartY As Integer,
    ByVal AnyCard As Card)
        For Looper1 = 4 To 8
            For Looper2 = 3 To 9
                Console.BackgroundColor = Int(15 * Rnd())
                Console.SetCursorPosition(Looper1 + StartX, Looper2 + StartY)
                Console.Write(" ")
            Next
        Next
    End Sub
    Function GetCardTextFromValue(ByVal AnyCard As Card) As String
        Dim TempChar As String
        If AnyCard.Face.CardValue > 1 And AnyCard.Face.CardValue < 11 Then
            TempChar = AnyCard.Face.CardValue
        Else
            TempChar = Left(AnyCard.Face.CardAsWord, 1)
        End If
        Return TempChar
    End Function
    Function TakeCardFromTopOfDeck(ByVal TheDeck As Deck) As Card
        Dim RemovedCard As Card
        RemovedCard = TheDeck.DeckCards(0)
        Return RemovedCard
    End Function
    Function PushCardsForwardByOne(ByVal TheDeck As Deck) As Deck
        For Looper = 0 To TheDeck.DeckSize - 1
            TheDeck.DeckCards(Looper) = TheDeck.DeckCards(Looper + 1)
        Next
        Return TheDeck
    End Function
    Function DealAHand(ByRef TheDeck As Deck) As Card()
        Dim TheHand(4) As Card
        For Looper = 0 To 4
            TheHand(Looper) = TakeCardFromTopOfDeck(TheDeck)
            TheDeck.DeckSize -= 1
            TheDeck = PushCardsForwardByOne(TheDeck)
        Next
        Return TheHand
    End Function
    Function ReturnCardToBottomOfDeck(ByVal TheCard As Card, ByVal TheDeck As Deck) As Deck
        TheDeck.DeckSize += 1
        TheDeck.DeckCards(TheDeck.DeckSize - 1) = TheCard
        Return TheDeck
    End Function
    Function ReturnHandToBottomOfDeck(ByVal TheHand() As Card, ByVal TheDeck As Deck) As Deck
        For Looper = 0 To 4
            TheDeck = ReturnCardToBottomOfDeck(TheHand(Looper), TheDeck)
        Next
        Return TheDeck
    End Function
End Module
