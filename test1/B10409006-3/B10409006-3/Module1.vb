Module Module1

    Sub Main()
        Dim r As New Random()
        Dim s(3) As String
        Dim b As String = ""
        Dim a%, c%
        Dim f1 As New System.IO.FileInfo("D:\B10409006-盧禹宏\B10409006-3\B10409006-3\123.txt")
        Dim fw As System.IO.StreamWriter = f1.AppendText()

        For i = 1 To 3
            For j = 1 To 8
                a = r.Next(0, 10)
                s(i) = s(i) + a.ToString
            Next
            Console.WriteLine("{0}:  {1}", i, s(i))
        Next

        Do While True
            Console.WriteLine("請輸入一組號碼")
            b = Console.ReadLine()
            If b = "exit" Then Exit Do : fw.Close()
            c = CheckInvoice(b, s)
            If c <> 0 Then fw.WriteLine("*{0}:${1}", b, c) : fw.Flush()
            If c = 0 Then fw.WriteLine("{0}:無", b) : fw.Flush()
        Loop

        Console.Read()
    End Sub

    Function CheckInvoice(b As String, s() As String)
        Dim money() As Integer = {40000, 10000, 4000, 1000, 200}
        Dim n$, m$
        For i = 1 To 3
            For j = 2 To 6
                n = Mid(s(i), j, 9 - j)
                m = Mid(b, j, 9 - j)
                If n = m Then Return money(j - 2) : Exit Function
            Next
        Next
        Return 0
    End Function

End Module
