Module Module1

    Class car
        Private _speed As Integer

        Sub New()  '用new函式設定初值 (用重構的方式)

        End Sub

        Sub New(a As Integer)
            _speed = a
        End Sub

        Public Property Speed() As Integer   'property會自行產生get set函式    (可在property前加上 readonly(唯獨)  writeonly(只可寫))
            Get
                Return _speed
            End Get
            Set(value As Integer)
                _speed = value
            End Set
        End Property

        Public Sub rise_speend()
            Me.Speed += 1  '呼叫Speed()  (me是自己函式)
        End Sub

        Protected Overrides Sub Finalize()  '覆寫原本的函式(Finalize()是物件消滅時的函式)
            Console.WriteLine("car is over")
        End Sub
    End Class
    Sub Main()
        Dim benz As New car
        benz.Speed = 100 '直接設定初值(會自己傳入set)-->benz.Speed 的Speed是property的函式名稱
        Console.WriteLine(benz.Speed) '(會自己傳入get)
        benz.rise_speend()
        Console.WriteLine("rise speed : now speed is {0}", benz.Speed)
        benz.Speed += 1  '且可直接加減
        Console.WriteLine("rise speed : now speed is {0}" & vbCrLf, benz.Speed)

        Dim bmw As New car(200)
        Console.WriteLine("bmw speed is {0}", bmw.Speed)

        benz = Nothing '讓benz消滅(讓記憶體回歸，但不知何時)
        GC.Collect() '強制收回記憶體

        Console.Read()
    End Sub

End Module

