Module Module1


    Sub Main()
        Dim state() As String = {"兒童", "青年", "中年", "老年"}
        Dim age%, birth% '跟以前一樣可以這樣寫

        Console.WriteLine("please birth year")
        birth = Integer.Parse(Console.ReadLine())
        age = Year(Now) - birth

        Select Case age
            Case Is < 14 : Console.WriteLine("your age is {0}, and you state is {1}", age.ToString, state(0))
            Case 15 To 30 : Console.WriteLine("your age is {0}, and you state is {1}", age.ToString, state(1))
            Case 31 To 65 : Console.WriteLine("your age is {0}, and you state is {1}", age.ToString, state(2))
            Case Else : Console.WriteLine("your age is {0}, and you state is {1}", age.ToString, state(3))
        End Select

        Console.Read()
    End Sub

End Module
