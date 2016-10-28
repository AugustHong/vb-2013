Module Module1
    Class elseException  '建一個新的例外（可以覆寫exception的tostring message ……等）
        Inherits System.Exception  '要用system.exception

        Public Overrides Function ToString() As String
            Return "發生特別例外"
        End Function

    End Class

    Sub Main()

        Try
            start()
        Catch ex As ArgumentOutOfRangeException
            Console.WriteLine("引數超出呼叫方法所規定的範圍時")
            Console.WriteLine("取得物件的型別{0}", ex.GetType)
            Console.WriteLine("取得例外說明文字{0}", ex.ToString)
            Console.WriteLine("取得讀取或設定說明檔的路徑{0}", ex.HelpLink)
            Console.WriteLine("取得造成目前例外的例外物件{0}", ex.InnerException)
            Console.WriteLine("取得例外的描述{0}", ex.Message)
            Console.WriteLine("取得發生物件的例外來源物件{0}", ex.Source)
            Console.WriteLine("取得發生例外的函式{0}", ex.StackTrace)
        Catch ex As DivideByZeroException
            Console.WriteLine("這是除以0時")
        Catch ex As IndexOutOfRangeException
            Console.WriteLine("超出陣列索引值")
        Catch ex As InvalidCastException
            Console.WriteLine("資料型別轉換錯誤，例如：字串轉數值")
        Catch ex As OverflowException
            Console.WriteLine("溢位時")
        Catch ex As StackOverflowException
            Console.WriteLine("堆疊溢位時")
        Catch ex As elseException
            Console.WriteLine("這是我自已新設的exception")
        Catch ex As system.Exception
            Console.WriteLine("其他都沒成立時的例外")
        Finally  '不管如何都會執行的
            Console.WriteLine("hope to not accuss exception")
        End Try

        Console.Read()
    End Sub

    Sub start()
        Dim a%
        Console.WriteLine("please input score")
        a = Integer.Parse(Console.ReadLine)
        If a < 0 Or a > 100 Then
            Throw New ArgumentOutOfRangeException()  '直接指定給所要的例外
        Else
            Console.WriteLine(a)
        End If

    End Sub

End Module
