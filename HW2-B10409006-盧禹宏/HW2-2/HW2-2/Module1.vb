Module Module1
    Class SetException
        Inherits System.Exception

        Public Overrides Function ToString() As String
            Return "身高或體重輸入小於零"
        End Function

    End Class

    Class BMIException
        Inherits System.Exception

        Public Overrides Function ToString() As String
            Return "BMI不在正常範圍內(正常範圍：18.5≦BMI＜24)"
        End Function

    End Class

    Class Student
        Public Sid$, Name$, High#, Weight#
        Public count% = 0

        Public WriteOnly Property SetData() As String
            Set(s As String)
                Dim y() = Microsoft.VisualBasic.Split(s, " ")
                Sid = y(0)
                Name = y(1)
                High = Val(y(2)) / 100
                Weight = Val(y(3))
                If High < 0 Or Weight < 0 Then Throw New SetException
                If ((Weight / (High * High)) > 24) Or ((Weight / (High * High)) < 18.5) Then Throw New BMIException
                count = count + 1
            End Set
        End Property
    End Class

    Sub start()
        Dim x$
        Dim stu As New Student
        While True
            Console.WriteLine("請輸入 學號、姓名、身高、體重(中間用一格空白)  如要離開則輸入exit")
            x = Console.ReadLine()

            If x = "exit" Then Console.WriteLine("總人數是：{0}", stu.count) : Exit While

            stu.SetData = x
        End While
    End Sub
    Sub Main()
        Try
            start()
        Catch ex As SetException
            Console.WriteLine(ex.ToString)
        Catch ex As BMIException
            Console.WriteLine(ex.ToString)
        End Try

        Console.Read()
    End Sub

End Module
