Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()  '離開程式
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Label1.Text = "按一下表單..."
        Me.BackColor = Color.Yellow ' 表單背景色彩為黃色 
    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Label1.Text = "按兩下表單..."
        Me.BackColor = Color.Aqua   ' 表單背景色彩為淺藍色
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "表單載入時..."
        Label1.Font = New Font("細明體", 22, FontStyle.Regular)
        ' Me為目前表單
        Me.BackColor = Color.Red ' 表單背景色彩為紅色

        LinkLabel1.Text = "快請按我"
        LinkLabel1.Font = New Font("細明體", 20, FontStyle.Regular)

        ToolTip1.IsBalloon = True      ' 使用汽球的型式
        ToolTip1.ToolTipIcon = ToolTipIcon.Info    ' 顯示資訊圖示Icon
        ToolTip1.ToolTipTitle = "按我有好康的喔"     ' 設定工具提示標題
        ToolTip1.BackColor = Color.Orange  ' 設定工具提示背景色為橘色
        ToolTip1.SetToolTip(LinkLabel1, "按一下就好")

        LinkLabel2.Text = "觀迎進入"
        LinkLabel2.Font = New Font("細明體", 20, FontStyle.Regular)
        LinkLabel2.LinkArea = New LinkArea(2, 2)  ' 設定「進入」可以超連結

        ToolTip2.SetToolTip(LinkLabel2, "進去囉")

        Button1.Size = New Size(80, 30) '設定大小
        Button1.Font = New Font("細明體", 15, FontStyle.Regular)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://www.google.com.tw") '連結到網址
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("mailto:yyy@yahoo.com.tw") 'mail到信箱
    End Sub
End Class
