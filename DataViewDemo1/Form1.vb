Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim dvScore As DataView   ' 宣告DataView物件dvScore
    ' 表單載入時執行此事件
    Private Sub Form1_Load(sender As Object, e As EventArgs) _
      Handles MyBase.Load
        Using cn As New SqlConnection()
            cn.ConnectionString = "Data Source=(LocalDB)\v11.0;" & _
                "AttachDbFilename=|DataDirectory|ch18DB.mdf;" & _
                "Integrated Security=True;"
            Dim daScore As New SqlDataAdapter _
                ("SELECT * FROM 成績單 ORDER BY 國文 DESC", cn)
            Dim ds As New DataSet()
            daScore.Fill(ds, "成績單")
            dvScore = ds.Tables("成績單").DefaultView
        End Using
        DataGridView1.DataSource = dvScore
        rdbChi.Checked = True    ' 國文選項按鈕預設選取
        rdbDesc.Checked = True   ' 遞增選項按鈕預設選取
    End Sub

    ' 按下 [確定] 鈕執行此事件 
    Private Sub btnOk_Click(sender As Object, e As EventArgs) _
      Handles btnOk.Click
        Dim sortStr As String = ""
        If rdbChi.Checked Then sortStr &= rdbChi.Text
        If rdbEng.Checked Then sortStr &= rdbEng.Text
        If rdbMath.Checked Then sortStr &= rdbMath.Text
        If rdbDesc.Checked Then sortStr &= " DESC"
        If rdbAsc.Checked Then sortStr &= " ASC"
        dvScore.RowFilter = txtFilter.Text
        dvScore.Sort = sortStr
        DataGridView1.DataSource = dvScore
    End Sub
End Class
