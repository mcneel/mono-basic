Imports System

Module IntegerTypeCharTest
    Function Main() As Integer
        Dim m As Integer
        m = f(20)
        If m <> 20 Then
            System.Console.WriteLine("IntegerTypeCharTest: failed") : Return 1
        End If
        Exit Function
    End Function

    Function f%(ByVal param%)
        f% = param
    End Function
End Module
