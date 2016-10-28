Module Module1

    Interface ifly '多重繼承(讓一個物件可以用此方法)(又稱作介面)
        Sub fly()
    End Interface

    Class car
        Implements ifly

        Public Sub speed(a As Integer)
            Console.WriteLine("you car speed is {0}", a)
        End Sub

        Public Sub fly() Implements ifly.fly
            Console.WriteLine("you car is fly !!")
        End Sub
    End Class

    Sub main()
        Dim bmz As New car
        bmz.speed(50)
        bmz.fly()
        Console.Read()
    End Sub


End Module

