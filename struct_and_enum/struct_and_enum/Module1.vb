Module Module1
    Structure student
        Dim student_id As String
        Dim name As String
        Dim sorce As Integer
    End Structure

    Enum day As Integer
        monday = 1
        t = 2
        w = 3
        r = 4
        f = 5
    End Enum

    Sub Main()
        Dim students(2) As student
        For i As Integer = 0 To 1  '也可用for each i as integer in students(這會像python的for in一樣把陣列中的一個一個讀出來))   as integer可寫可不寫
            Console.WriteLine("please input student_id")
            students(i).student_id = Console.ReadLine()

            Console.WriteLine("please input student name")
            students(i).name = Console.ReadLine()

            Console.WriteLine("please input student sorce")
            students(i).sorce = Console.ReadLine()
        Next

        For i As Integer = 0 To 1
            Console.WriteLine("{0} student id is {1}, and name is {2} , and sorce is {3}", i, students(i).student_id, students(i).name, students(i).sorce.ToString)
        Next

        Console.WriteLine("{0}   {1}   {2}   {3}   {4}", CType(day.monday, Integer), CType(day.t, Integer), CType(day.w, Integer), CType(day.r, Integer), CType(day.f, Integer))
        '要用ctype去轉型態，不然會是monday等這種
        Console.Read()
    End Sub

End Module

