Module Module1

    Sub Main()
        Dim intarray() As Integer = New Integer() {2, 3, 4} '宣告一個整數陣列

        Dim action As New Action(Of Integer)(AddressOf showarea) '宣告動作並指定是哪個方法
        Array.ForEach(intarray, action) '將每個值丟進去方法中
        '可直接用：
        'for i = 0 to 2
        '    showarea(intarray(i))
        'next
        Console.Read()
    End Sub
    Sub showarea(r As Integer)
        Console.WriteLine("r = {0}", (r * r * 3.14).ToString("#.00"))
    End Sub
End Module

'array.Clear 清除範圍內的值(陣列,起始位置, 清除個數) ex:array.clear(intarray, 0, 3)
'array.BinarySearch 尋找資料(如沒有會回傳-1)(且要先array.Sort後才行用) ex:array.binarysearch(intarray, 2)
'array.IndexOf 尋找資料(如沒有會回傳-1)(陣列, 要搜尋的值) ex:array.indexof(intarray, 2)
'array.Sort 由小到大排 ex:array.sort(intarray)
'(可寫成array.sort(要排陣列, 跟要排陣列一起改變之陣列))
'array.Revrse 相反排序(全反轉) ex:array.reverse(intarray)
