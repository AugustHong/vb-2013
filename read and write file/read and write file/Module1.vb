
Imports System.IO
Module Module1

    Sub Main()
        Dim dir As New DirectoryInfo("C:\Users\偉德\Documents\vb 2013\read and write file\read and write file") 'path can change
        '如果路徑一開始是不存在的 要dir.create()

        Dim f1 As New FileInfo("C:\Users\偉德\Documents\vb 2013\read and write file\read and write file\123.txt")

        Dim fw As StreamWriter = f1.CreateText()  'createtext()是直接寫入  appendtext()就是append了
        fw.WriteLine("ok")  '寫一行
        fw.Write("hello")
        fw.Flush() '將寫在buffer的資料寫入
        fw.Close()


        Dim fr As StreamReader = f1.OpenText()
        Console.WriteLine(fr.ReadToEnd())  '讀自結尾
        fr.Close()

        Dim fr1 As StreamReader = f1.OpenText() '讀檔
        Do While fr1.Peek() >= 0  'peek() = -1時是結尾
            Console.WriteLine(fr1.ReadLine()) '讀一行
        Loop
        fr1.Close()

        Dim fr2 As StreamReader = f1.OpenText()
        Do While fr2.Peek() >= 0
            Console.Write(Chr(fr2.Read())) '讀一字  (chr是把ascii轉字   asc是把字轉ascii)
        Loop
        fr2.Close()

        Console.WriteLine()

        Dim f() As FileInfo = dir.GetFiles()  '目錄下的所有檔案(同目錄)
        For Each i As FileInfo In f
            Console.WriteLine("路徑:{0}", i.FullName)
            Console.WriteLine("寫入時間:{0}", i.LastWriteTime.ToString)
            Console.WriteLine("檔案大小:{0}", i.Length.ToString)
        Next

        Console.Read()

    End Sub

End Module



