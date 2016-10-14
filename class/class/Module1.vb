Class hello '類別
    Sub helloword()

    End Sub

    Function hello1()
        Return 1
    End Function
End Class

Namespace apple 'namespace是相同類別名稱但可以用命名空間去分開來用
    Class notebook

    End Class
End Namespace

Namespace ibm
    Class notebook

    End Class
End Namespace


Module Module1

    Sub Main()

        Dim a = New hello '新增類別物件
        Dim b = New apple.notebook
        Dim c = New ibm.notebook
    End Sub

End Module
