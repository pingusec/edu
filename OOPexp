Imports System
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
    Dim CardVal As Integer
    Dim CardWord As String
    Dim CardSuit As Suit
    Dim CardFace As Face
End Structure
Module Program

    ' Demo code for Face struct

    Sub Main()
        Dim AllFaces() As Face = LoadFaces()
        Dim DotCoords() As String = LoadDots()

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

        FileOpen(1, "S:\PATH\TO\DOT.txt", OpenMode.Input)

        Do While Not EOF(1)
            ReDim Preserve DotCoords(index)


            index += 1
        Loop

        Return DotCoords
    End Function
End Module
