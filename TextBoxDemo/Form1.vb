Public Class Form1

    ' 表單載入時執行
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim address() As String = {"台北市南港路三段52號7樓 7F", "台北市南港路二段12號7樓 7F", "台北市忠孝東路一段12號"}
        Dim myAdd As New AutoCompleteStringCollection()
        myAdd.AddRange(address)
        txtAdd.AutoCompleteCustomSource = myAdd
        txtAdd.AutoCompleteMode = AutoCompleteMode.Suggest
        txtAdd.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtPage.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtPage.AutoCompleteSource = AutoCompleteSource.HistoryList
    End Sub

    ' 按下 [確定] 時執行
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ' 在對話方塊上顯示使用者輸入的公司, 住址, 網站資訊
        MessageBox.Show("公司：" & txtCompany.Text & vbNewLine & "住址：" & txtAdd.Text & vbNewLine & "網站：" & txtPage.Text)
    End Sub

End Class
