Option Strict On
Option Explicit On
Option Compare Binary

Module StringExperiment

    Sub Main()
        Dim testString As String = "Testing, Testing, 1 2 3"
        Dim money = 3.5@
        Dim length As Integer
        Dim temp() As String


        'Console.WriteLine(StrReverse(testString))
        'Console.WriteLine(testString(3))
        'Console.WriteLine(Len(testString))
        'For i = Len(testString) To 0 Step -1
        '    Console.WriteLine(testString(i))
        'Next
        'Console.WriteLine(UCase(testString))
        'Console.WriteLine(money.ToString("C")) 'C shows it is currency
        'Console.WriteLine(money.ToString("e")) 'e shows it is exponential
        'testString = Left(testString, 14)
        'Console.WriteLine(testString)
        'testString = Right(testString, 7)
        'Console.WriteLine(testString)
        'testString = Mid(testString, 5)
        'Console.WriteLine(testString)
        temp = Split(testString, " ")
        Console.WriteLine(temp(3))
        Console.WriteLine(temp(1))
        Console.WriteLine(temp(4))



        Console.ReadLine()
    End Sub

End Module
