Imports System.Runtime.CompilerServices

Module Program

    Interface IComparitorStrategy(Of T)
        Function Execute(ByVal a As T, ByVal b As T) As Integer
    End Interface

    Class IntComparitor
        Implements IComparitorStrategy(Of Integer)

        Public Function Execute(a As Integer, b As Integer) As Integer Implements IComparitorStrategy(Of Integer).Execute
            Return IIf(a > b, 1, IIf(b > a, -1, 0))
        End Function
    End Class

    Class DoubleComparitor
        Implements IComparitorStrategy(Of Double)

        Public Function Execute(a As Double, b As Double) As Integer Implements IComparitorStrategy(Of Double).Execute
            Return IIf(a > b, 1, IIf(b > a, -1, 0))
        End Function
    End Class

    <Extension()>
    Sub BSort(Of T As Structure)(arr As T(), strategy As IComparitorStrategy(Of T))
        Dim i, j As Integer
        Dim size As Integer = arr.Length - 1
        For i = 0 To size
            For j = 0 To size - i - 1
                If strategy.Execute(arr(j), arr(j + 1)) > 0 Then
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
        arr.BSort(New IntComparitor())

        ' Print
        Console.WriteLine(String.Join(" ", arr))
        Console.ReadLine()
    End Sub
End Module
