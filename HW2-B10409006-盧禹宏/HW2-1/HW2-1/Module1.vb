Module Module1

    Class Shape
        Public Shared Property high#  '高
        Public Shared Property width# '寬
        Public Shared Property r# '半徑
        Public Shared Property t1# '邊長1
        Public Shared Property t2# '邊長2
        Public Shared Property t3# '邊長3

        Public Overridable Sub Area()

        End Sub
    End Class

    Class Circle
        Inherits Shape

        Public Overrides Sub Area()
            Console.WriteLine("circle area is {0}", r * r * 3.14)
        End Sub

    End Class

    Class Triangle
        Inherits Shape

        Public Overrides Sub Area()
            Dim a%
            a = (t1 + t2 + t3) / 2
            Console.WriteLine("triangle area is {0}", System.Math.Sqrt(a * (a - t1) * (a - t2) * (a - t3)))
        End Sub

    End Class

    Class Rectangle
        Inherits Shape

        Public Overrides Sub Area()
            Console.WriteLine("rectangle area is {0}", high * width)
        End Sub

    End Class

    Sub Main()
        Dim x$
        Dim s As Shape
        Dim cir As New Circle
        Dim tri As New Triangle
        Dim rec As New Rectangle

        Console.WriteLine("請輸入所以求的形狀1.圓形2.三角形3.長方形")
        x = Val(Console.ReadLine())

        Select Case x
            Case 1
                s = cir
                While True
                    Console.WriteLine("請輸入半徑")
                    s.r = Val(Console.ReadLine())
                    If s.r > 0 Then
                        s.Area()
                        Exit While
                    Else
                        Console.WriteLine("不能少於零")
                    End If
                End While
            Case 2
                s = tri
                While True
                    Console.WriteLine("請輸入三邊長，中間各用一個空白")
                    Dim g() = Microsoft.VisualBasic.Split(Console.ReadLine(), " ")
                    If UBound(g) = 2 Then
                        If ((Val(g(0)) + Val(g(1))) > Val(g(2))) And ((Val(g(0)) + Val(g(2))) > Val(g(1))) And ((Val(g(2)) + Val(g(1))) > Val(g(0))) And g(0) > 0 And g(1) > 0 And g(2) > 0 Then
                            s.t1 = g(0)
                            s.t2 = g(1)
                            s.t3 = g(2)
                            s.Area()
                            Exit While
                        Else
                            Console.WriteLine("1.兩邊之合必大於第3邊 2.輸入負值")
                        End If
                    Else
                        Console.WriteLine("沒輸入3個值")
                    End If
                End While
            Case 3
                s = rec
                While True
                    Console.WriteLine("請輸入長寬，中間各用一個空白")
                    Dim g() = Microsoft.VisualBasic.Split(Console.ReadLine(), " ")
                    If UBound(g) = 1 Then
                        If g(0) > 0 And g(1) > 0 Then
                            s.high = g(0)
                            s.width = g(1)
                            s.Area()
                            Exit While
                        Else
                            Console.WriteLine("1.輸入負值")
                        End If
                    Else
                        Console.WriteLine("沒輸入2個值")
                    End If
                End While
            Case Else : Console.WriteLine("輸入錯誤！！")
        End Select

        Console.Read()

    End Sub

End Module
