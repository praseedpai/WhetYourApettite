Imports System.Runtime.CompilerServices

Module Program

    <Extension()>
    Sub BSort(Of T As Structure)(arr As T(), strategy As Func(Of T, T, Integer))
        Dim i, j As Integer
        Dim size As Integer = arr.Length - 1
        For i = 0 To size
            For j = 0 To size - i - 1
                If strategy(arr(j), arr(j + 1)) > 0 Then
                    Dim temp = arr(j)
                    arr(j) = arr(j + 1)
                    arr(j + 1) = temp
                End If
            Next
        Next
    End Sub

    Sub Main(args As String())
        If args.Length = 0 Then
            Console.WriteLine("No Command Line Arguments")
            Console.ReadLine()
            Return
        End If

        Dim i As Integer
        Dim size As Integer = args.Length - 1
        Dim arr As Integer() = New Integer(size) {}

        ' Copy string args to int array
        For i = 0 To size
            arr(i) = Convert.ToInt32(args(i))
        Next

        'Sort
        Dim strategy As Func(Of Integer, Integer, Integer) = Function(a, b) IIf(a > b, 1, IIf(b > a, -1, 0))
        arr.BSort(strategy)

        ' Print
        Console.WriteLine(String.Join(" ", arr))
        Console.ReadLine()
    End Sub
End Module
