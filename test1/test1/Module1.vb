Module Module1

    Sub Main()
        Dim product$, price%
        Console.Write("請輸出商品名稱：") '輸出文字，但是沒有換行
        product = Console.ReadLine() '讀取使用者所輸入的一行文字

        Console.Write("請輸出單價：")
        price = Integer.Parse(Console.ReadLine()) 'integer.parse()將字串轉換為整數

        Console.WriteLine("您買的商品為{0} 單價是{1}，打折後的價格是{2}", product, price.ToString, price * 0.8)
        'price.tostring將它轉為字串，而writeline是直接印出一行（有換行）
        Console.ReadLine() '等待使用者輸入中…（可以讓螢幕不會馬上就跑掉，即結束）
    End Sub

End Module
