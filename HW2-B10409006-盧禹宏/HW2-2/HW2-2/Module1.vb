Module Module1
    Dim judge% = 0 '判斷是否結束
    Class SetException
        Inherits System.Exception

        Public Overrides Function ToString() As String
            Return "身高或體重輸入小於零"
        End Function

    End Class

    Class BMIException
        Inherits System.Exception
        Private number#
        Public Sub New(a As Double)
            number = a
        End Sub
        Public Overrides Function ToString() As String
            Return "BMI不在正常範圍內(正常範圍：18.5≦BMI＜24)，你的BMI是" + (number.ToString)
        End Function

    End Class

    Class Student
        Private Sid(1000) As String, Name(1000) As String, High(1000) As Double, Weight(1000) As Double
        Public count% = 0

        Public Sub SetData(s As String, n As String, h As Double, w As Double)
            Dim h2# = h / 100
            If h < 0 Or w < 0 Then Throw New SetException
            If ((w / (h2 * h2)) > 24) Or ((w / (h2 * h2)) < 18.5) Then Throw New BMIException((w / (h2 * h2)))
            Sid(count) = s
            Name(count) = n
            High(count) = h
            Weight(count) = w
            count = count + 1
        End Sub

        Public Sub print()
            Console.WriteLine("總人數：{0}", count)
            For i = 0 To count - 1
                Console.WriteLine("{0} {1} {2} {3}", Sid(i), Name(i), High(i), Weight(i))
            Next
        End Sub
    End Class

    Sub main()
        Dim stu As New Student
        While True  '要一直讓它跑，不然到例外就跳走了！
            Try
                Console.WriteLine("請輸入 學號、姓名、身高、體重(中間用一格空白)  如要離開則輸入exit")
                Dim s() = Microsoft.VisualBasic.Split(Console.ReadLine(), " ")

                If UBound(s) = 0 And s(0) = "exit" Then stu.print() : Exit While

                If UBound(s) = 3 Then
                    stu.SetData(s(0), s(1), Val(s(2)), Val(s(3)))
                Else
                    Console.WriteLine("值沒輸入4個")
                End If

            Catch ex As SetException
                Console.WriteLine(ex.ToString)
            Catch ex As BMIException
                Console.WriteLine(ex.ToString)
            End Try

        End While

        Console.Read()
    End Sub


End Module
