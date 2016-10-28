Module Module1

    Class cal
        Public Shared Property x% 'protected是只能子類別用
        Public Shared Property y%
        Public Overridable Sub answer() '允許覆寫(overridable)

        End Sub
    End Class

    Class addcal
        Inherits cal
        Public Overrides Sub answer() 'overrides是覆寫(也可用overloads)
            Console.WriteLine("result = {0}", x + y)
        End Sub
    End Class

    Class subcal
        Inherits cal
        Public Overrides Sub answer()
            Console.WriteLine("result = {0}", x - y)
        End Sub
    End Class

    Class mulcal
        Inherits cal
        Public Overrides Sub answer()
            Console.WriteLine("result = {0}", x * y)
        End Sub
    End Class

    Class divcal
        Inherits cal
        Public Overrides Sub answer()
            Console.WriteLine("result = {0}", x / y)
        End Sub
    End Class

    Sub main()
        Dim r As cal '宣告一個可以指向別的

        Dim addnumber As New addcal
        Dim subnumber As New subcal
        Dim mulnumber As New mulcal
        Dim divnumber As New divcal

        While True
            Console.WriteLine("please input 1.+ 2.- 3.* 4./")
            Select Case Console.ReadLine()
                Case 1 : r = addnumber '讓r指向addnumber
                Case 2 : r = subnumber
                Case 3 : r = mulnumber
                Case 4 : r = divnumber
                Case Else : Console.WriteLine("重輸入")
            End Select

            Console.WriteLine("input x:")
            r.x = Val(Console.ReadLine)
            Console.WriteLine("input y:")
            r.y = Val(Console.ReadLine)

            r.answer()

        End While
    End Sub


End Module

