Module Module1

    Sub Main()
        Dim dir As New System.IO.DirectoryInfo("C:\vb") '建一個新的directoryinfo

        If dir.Exists Then '看是否存在
            Console.WriteLine("路徑已存在，不建立目錄")
        Else
            Console.WriteLine("目錄建置中")
            dir.Create() '建立
            dir.Refresh()  '重新整理目錄
        End If

        Console.WriteLine("{0}檔案資訊如下", dir.FullName)  '整個路徑
        Console.WriteLine("目前屬性{0}", dir.Attributes)
        Console.WriteLine("建立時間{0}", dir.CreationTime.ToString)
        Console.WriteLine("存取時間{0}", dir.LastAccessTime.ToString)
        Console.WriteLine("資料夾名稱：{0}", dir.Name)
        Console.WriteLine("根目錄{0}", dir.Parent)
        Console.WriteLine("根：{0}", dir.Root)
        Console.WriteLine("取得副檔名{0}", dir.Extension)
        Console.WriteLine()

        Dim dir2 As System.IO.DirectoryInfo = dir.CreateSubdirectory("hello") '在一個目錄下直接再建一個
        Console.WriteLine("{0}檔案資訊如下", dir2.FullName)  '整個路徑
        Console.WriteLine("目前屬性{0}", dir2.Attributes)
        Console.WriteLine("建立時間{0}", dir2.CreationTime.ToString)
        Console.WriteLine("存取時間{0}", dir2.LastAccessTime.ToString)
        Console.WriteLine("資料夾名稱：{0}", dir2.Name)
        Console.WriteLine("根目錄{0}", dir2.Parent)
        Console.WriteLine("根：{0}", dir2.Root)
        Console.WriteLine("取得副檔名{0}", dir2.Extension)
        Console.WriteLine()

        For Each diSourceSubDir As System.IO.DirectoryInfo In dir.GetDirectories()  '讓dir下的每個目錄列出來(會是個陣列)(如要全檔案的話For Each fi As FileInfo In dir.GetFiles())
            Console.WriteLine("資料夾名稱：{0}", diSourceSubDir.Name)
            Console.WriteLine("建立時間{0}", diSourceSubDir.CreationTime.ToString)
        Next

        dir2.Delete() '刪除
        dir.Delete() '刪除
        Console.WriteLine("delete success")

        Console.Read()
    End Sub

End Module
