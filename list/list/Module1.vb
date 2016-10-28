Module Module1



    Sub main()
        Dim a As New List(Of Integer) '類似陣列(但是也是可以加入class)
        'ex: dim b as new list(of member)  -->而member是你弄得class

        a.Add(10)
        a.Add(30)
        a.Insert(1, 20) '在第1項加入20

        For i = 0 To 2
            Console.WriteLine(a(i))
        Next

        Console.Read()
    End Sub


End Module

