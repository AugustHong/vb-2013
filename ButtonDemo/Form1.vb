Public Class Form1

    Dim guess As Integer   ' 要猜的數字，即電腦產生的亂數，亂數範圍1-3

    ' CheckAns程序用來判斷答案是否正確
    Sub CheckAns(ans As Integer)
        ' 如果guess(電腦產生的亂數)等於ans(使用者的答案)
        If guess = ans Then
            lblShow.Text = "太棒了...答對了!!"
            ' 如果ans等於1即Button1顯示snowman.jpg影像圖
            If ans = 1 Then Button1.Image = New Bitmap("snowman.jpg")
            ' 如果ans等於2即button2顯示snowman.jpg影像圖
            If ans = 2 Then Button2.Image = New Bitmap("snowman.jpg")
            ' 如果ans等於3即button3顯示snowman.jpg影像圖
            If ans = 3 Then Button3.Image = New Bitmap("snowman.jpg")
        Else
            lblShow.Text = "不在這裡...猜錯了"
        End If
    End Sub

    ' 表單載入時執行
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        ' 呼叫btnAgain_Click事件處理程序，產生1-3的亂數並指定給guess
        btnAgain_Click(sender, e)
        Me.Text = "找雪人遊戲"
        lblShow.Text = "請問雪人在哪個按鈕"
        ' 設定lblShow字型大小為14
        lblShow.Font = New Font(lblShow.Font.FontFamily, 14, FontStyle.Regular)
    End Sub

    ' 按 [重玩] 鈕執行
    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        Dim r As New Random()  ' 建立Random亂數物件r
        guess = r.Next(1, 4)          ' 產生1-3亂數並指定給guess
        lblShow.Text = ""
        ' 設定Button1, Button2, Button3三個按鈕有效
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        ' 設定Button1, Button2, Button3三個按鈕不顯示影像圖示
        Button1.Image = Nothing
        Button2.Image = Nothing
        Button3.Image = Nothing
    End Sub

    ' 按 [離開] 鈕執行
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' 按下 Button1 表示指定答案 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckAns(1)  ' 呼叫CheckAns程序，並傳入答案1
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    '  按下 Button2 表示指定答案 2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckAns(2)   ' 呼叫CheckAns程序，並傳入答案2
        Button1.Enabled = False
        Button3.Enabled = False
    End Sub

    ' 按下 Button3 表示指定答案 3
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckAns(3)     ' 呼叫CheckAns程序，並傳入答案3
        Button1.Enabled = False
        Button2.Enabled = False
    End Sub

End Class
