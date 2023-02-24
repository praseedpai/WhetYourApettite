Module Program
    Sub Main(args As String())
        If args.Length = 0 Then
            Console.WriteLine("No Command Line Arguments")
            Console.ReadLine()
            Return
        End If

        Dim i, j As Integer
        Dim size As Integer = args.Length - 1
        Dim arr As Integer() = New Integer(size) {}

        ' Copy string args to int array
        For i = 0 To size
            arr(i) = Convert.ToInt32(args(i))
        Next

        'Sort
        For i = 0 To size
            For j = 0 To size - i - 1
                If arr(j) > arr(j + 1) Then
                    Dim temp = arr(j)
                    arr(j) = arr(j + 1)
                    arr(j + 1) = temp
                End If
            Next
        Next

        ' Print
        Console.WriteLine(String.Join(" ", arr))
        Console.ReadLine()
    End Sub
End Module
