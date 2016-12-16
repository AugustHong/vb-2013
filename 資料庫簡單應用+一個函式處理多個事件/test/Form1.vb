Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO:  這行程式碼會將資料載入 'Database1DataSet.Table1' 資料表。您可以視需要進行移動或移除。
        Me.Table1TableAdapter.Fill(Me.Database1DataSet.Table1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Table1TableAdapter.Update(Me.Database1DataSet.Table1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fileReader As String 'read file
        fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\user\Desktop\資料庫簡單應用+一個函式處理多個事件\test\bin\Debug\test.txt")
        MsgBox(fileReader)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Table1BindingSource.MoveFirst()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Table1BindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Table1BindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Table1BindingSource.MoveLast()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Table1BindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Table1BindingSource.RemoveAt(Table1BindingSource.Position)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            Table1BindingSource.EndEdit()  '寫回資料表
            Me.Table1TableAdapter.Update(Me.Database1DataSet.Table1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button11_12_13_Click(sender As Object, e As EventArgs) Handles Button11.Click, Button12.Click, Button13.Click '一個處理多個
        Label4.Text = "你按的是"
        Dim a As Button
        a = CType(sender, Button) '轉為button
        Label4.Text = Label4.Text & a.Text
    End Sub
End Class
