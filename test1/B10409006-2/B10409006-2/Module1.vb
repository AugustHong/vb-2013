Module Module1
    Class StopException
        Inherits System.Exception

        Public Overrides Function ToString() As String
            Return "該商品過期或暫停供貨!!"
        End Function

    End Class

    Class QtyException
        Inherits System.Exception

        Public Overrides Function ToString() As String
            Return "該商品的現貨量過低，請暫停銷售並立即補貨!!"
        End Function

    End Class
    Class LimitedException
        Inherits System.Exception

        Public Overrides Function ToString() As String
            Return "該商品限量供應，一次僅能購買一個!!"
        End Function

    End Class
    Class Commodity
        Public QRCode(4) As String
        Public Price(4) As Integer
        Public Quantity(4) As Integer
        Public Status(4) As String
        Public Shared TotalAmt As Integer
        Public Shared record(7) As Integer
        Public Overridable Sub sell(a As String, b As Integer)

        End Sub
    End Class

    Class Freshfood
        Inherits Commodity
        Public Type(4) As String
        Public Sub Setting()

            QRCode(0) = "001"
            Price(0) = 2000
            Quantity(0) = 200
            Status(0) = "Available"
            Type(0) = "果"

            QRCode(1) = "002"
            Price(1) = 200
            Quantity(1) = 200
            Status(1) = "Available"
            Type(1) = "肉"

            QRCode(2) = "003"
            Price(2) = 100
            Quantity(2) = 10
            Status(2) = "Limited"
            Type(2) = "菜"

            QRCode(3) = "004"
            Price(3) = 200
            Quantity(3) = 10
            Status(3) = "Suspended"
            Type(3) = "海鮮"

            Console.WriteLine("freshfood")
            Console.WriteLine("qrcode price quantity status type")
            For i = 0 To 3
                Console.WriteLine("{0} {1} {2} {3} {4}", QRCode(i), Price(i), Quantity(i), Status(i), Type(i))
            Next
        End Sub

        Public Overrides Sub sell(a As String, b As Integer)
            Select Case a
                Case "001"
                    If Status(0) = "Expired" Or Status(0) = "Suspended" Then Throw New StopException()
                    If b > Quantity(0) Then Throw New LimitedException()
                    If Quantity(0) < 2 Then Status(0) = "Suspended" : Throw New QtyException()
                    Quantity(0) = Quantity(0) - b
                    TotalAmt += Price(0) * b
                    record(0) = b
                Case "002"
                    If Status(1) = "Expired" Or Status(1) = "Suspended" Then Throw New StopException()
                    If b > Quantity(1) Then Throw New LimitedException()
                    If Quantity(1) < 2 Then Status(1) = "Suspended" : Throw New QtyException()
                    Quantity(1) = Quantity(1) - b
                    TotalAmt += Price(1) * b
                    record(1) = b
                Case "003"
                    If Status(2) = "Expired" Or Status(2) = "Suspended" Then Throw New StopException()
                    If b > Quantity(2) Then Throw New LimitedException()
                    If Quantity(2) < 2 Then Status(2) = "Suspended" : Throw New QtyException()
                    Quantity(2) = Quantity(2) - b
                    TotalAmt += Price(2) * b
                    record(2) = b
                Case "004"
                    If Status(3) = "Expired" Or Status(3) = "Suspended" Then Throw New StopException()
                    If b > Quantity(3) Then Throw New LimitedException()
                    If Quantity(3) < 2 Then Status(3) = "Suspended" : Throw New QtyException()
                    Quantity(3) = Quantity(3) - b
                    TotalAmt += Price(3) * b
                    record(3) = b
                Case Else
                    Console.WriteLine("error")
            End Select
        End Sub
    End Class

    Class Cookie
        Inherits Commodity
        Public Calory(3) As Integer
        Public Sub Setting()

            QRCode(0) = "010"
            Price(0) = 500
            Quantity(0) = 20
            Status(0) = "Expired"
            Calory(0) = 1000


            QRCode(1) = "011"
            Price(1) = 5000
            Quantity(1) = 200
            Status(1) = "Available"
            Calory(1) = 2000

            QRCode(2) = "012"
            Price(2) = 600
            Quantity(2) = 100
            Status(2) = "Available"
            Calory(2) = 1500

            Console.WriteLine("cookie")
            Console.WriteLine("qrcode price quantity status calory")
            For i = 0 To 2
                Console.WriteLine("{0} {1} {2} {3} {4}", QRCode(i), Price(i), Quantity(i), Status(i), Calory(i))
            Next
        End Sub

        Public Overrides Sub sell(a As String, b As Integer)
            Select Case a
                Case "010"
                    If Status(0) = "Expired" Or Status(0) = "Suspended" Then Throw New StopException()
                    If b > Quantity(0) Then Throw New LimitedException()
                    If Quantity(0) < 2 Then Status(0) = "Suspended" : Throw New QtyException()
                    Quantity(0) = Quantity(0) - b
                    TotalAmt += Price(0) * b
                    record(4) = b
                Case "011"
                    If Status(1) = "Expired" Or Status(1) = "Suspended" Then Throw New StopException()
                    If b > Quantity(1) Then Throw New LimitedException()
                    If Quantity(1) < 2 Then Status(1) = "Suspended" : Throw New QtyException()
                    Quantity(1) = Quantity(1) - b
                    TotalAmt += Price(1) * b
                    record(5) = b
                Case "012"
                    If Status(2) = "Expired" Or Status(2) = "Suspended" Then Throw New StopException()
                    If b > Quantity(2) Then Throw New LimitedException()
                    If Quantity(2) < 2 Then Status(2) = "Suspended" : Throw New QtyException()
                    Quantity(2) = Quantity(2) - b
                    TotalAmt += Price(2) * b
                    record(6) = b
                Case Else
                    Console.WriteLine("error")
            End Select
        End Sub
    End Class
    Sub Main()
        Dim a As Integer
        Dim b$, c%
        Dim r As Commodity
        Dim fresh As New Freshfood
        Dim cook As New Cookie
        Dim qr() As String = {"001", "002", "003", "004", "010", "011", "012"}
        fresh.Setting()
        cook.Setting()

        Do While True
            Try
                Console.WriteLine("1.freshfood 2.cookie 3.exit")
                a = Val(Console.ReadLine())
                Select Case a
                    Case 1
                        r = fresh
                        Console.WriteLine("input qrcode")
                        b = Console.ReadLine()
                        Console.WriteLine("input number")
                        c = Val(Console.ReadLine())
                        r.sell(b, c)
                    Case 2
                        r = cook
                        Console.WriteLine("input qrcode")
                        b = Console.ReadLine()
                        Console.WriteLine("input number")
                        c = Val(Console.ReadLine())
                        r.sell(b, c)
                    Case 3
                        Console.WriteLine(Commodity.TotalAmt)
                        For i = 0 To 6
                            If r.record(i) > 0 Then Console.WriteLine("{0} have {1}個", qr(i), r.record(i)) : r.record(i) = 0
                        Next
                        Exit Do
                    Case Else
                        Console.WriteLine("error")
                End Select


            Catch ex As StopException
                Console.WriteLine(ex.ToString)
            Catch ex As QtyException
                Console.WriteLine(ex.ToString)
            Catch ex As LimitedException
                Console.WriteLine(ex.ToString)
            End Try
        Loop

        Console.Read()

    End Sub

End Module
