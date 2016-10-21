Module Module1

    Class employee
        Public Property _salary As Integer '也可用property直接宣告成有set and get的型態
        'public shared property hello as integer (前面加上shared的是可以在employee中直接跑的)
        'ex： employee.hello = 10(不用再dim a as new employee而可以直接用employee去存取，當然sub中也可以這樣用)

    End Class
    Class manger
        Inherits employee
        Public Property _bouns As Integer

        Public Sub showtotalsalary()
            Console.WriteLine("{0}", _salary + _bouns)
        End Sub
    End Class



    Sub Main()
        Dim a As New employee
        a._salary = 10000
        Console.WriteLine(a._salary)

        Dim b As New manger
        b._salary = 30000
        b._bouns = 20000
        Console.WriteLine(b._salary)
        b.showtotalsalary()
        Console.Read()
    End Sub

End Module
