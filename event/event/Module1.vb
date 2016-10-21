Module Module1

    Class car
        Private _speed As Integer
        Public Event danger(a As Integer)  '宣告事件

        Public Property Speed() As Integer   'property會自行產生get set函式    (可在property前加上 readonly(唯獨)  writeonly(只可寫))
            Get
                Return _speed
            End Get
            Set(value As Integer)
                If value > 200 Then RaiseEvent danger(value) : value = 200 '啟動事件
                _speed = value
            End Set
        End Property
    End Class

    Sub toofast(a As Integer)
        Console.WriteLine("your speed is {0} too fast , please slow", a)
    End Sub

    Sub Main()
        Dim benz As New car()
        AddHandler(benz.danger), AddressOf toofast
        benz.Speed = 205
        Console.Read()
    End Sub

End Module

'全域事件
'dim withevents benz as car (用withevents來宣告 且car後不能有() )
'public sub benz_danger(a as integer) handles benz.danger
'console.writeline("too fast")
'end sub


