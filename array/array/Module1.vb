Module Module1

    Sub Main()
        Dim role(,) As String = {{"魯夫", "300000000"}, {"索隆", "320000000"}, {"喬巴", "50"}}
        'role(,)是2維中給初始值得宣告方法  以上是等同於role(2,1)
        Console.WriteLine("人物{0}賞金", vbTab)

        For i = 0 To role.GetUpperBound(0) 'getupperbound(0)是2， 因為0是指(2,1)中的2 ，而如果是1的話則是(2,1)中的1
            Console.WriteLine("{0}{1}{2:C}", role(i, 0), vbTab, Integer.Parse(role(i, 1))) 'C是貨幣格式
        Next

        Console.Read()
    End Sub

End Module

'c 貨幣格式
'd 十近位
'e 小數點 3e(小數點到第三位)
'x 16近位

'不規則陣列（用於2維）
'dim a(2)() as integer
'a(0) = new integer() {1000, 2000, 3000}
'a(1) = new integer() {1000, 2000}
'a(2) = new integer() {1000, 2000, 3000, 4000}
