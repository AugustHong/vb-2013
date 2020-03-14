Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    ' 定義ShowData()程序將銀行帳戶資料表所有記錄顯示於DataGridView1上
    Sub ShowData()
        Using cn As New SqlConnection()
            cn.ConnectionString = "Data Source=(LocalDB)\v11.0;" & _
                "AttachDbFilename=|DataDirectory|ch17DB.mdf;" & _
                "Integrated Security=True;"
            Dim daEmployee As New SqlDataAdapter("SELECT * FROM 銀行帳戶", cn)
            Dim ds As New DataSet()
            daEmployee.Fill(ds, "銀行帳戶")
            DataGridView1.DataSource = ds.Tables("銀行帳戶")
        End Using
    End Sub

    ' 表單載入時執行此事件
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
    End Sub

    ' 按下 [轉帳] 鈕執行此事件
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 若使用者餘額小於轉入金額，則執行下列敘述
        If 0 >= Val(txtIncomeMoney.Text) Then
            MessageBox.Show("存款不可小於等於零")
            Exit Sub
        End If

        Using cn As New SqlConnection()
            cn.ConnectionString = "Data Source=(LocalDB)\v11.0;" & _
                     "AttachDbFilename=|DataDirectory|ch17DB.mdf;" & _
                    "Integrated Security=True;"
            cn.Open()

            ' 建立SqlCommand物件selectCmd1，用來查詢使用者帳號是否存在
            Dim selectCmd1 As New SqlCommand("SELECT * FROM 銀行帳戶 WHERE 帳號='" & txtMyId.Text.Replace("'", "''") & "'", cn)
            ' 建立SqlCommand物件selectCmd1，用來查詢轉入帳號是否存在
            Dim selectCmd2 As New SqlCommand("SELECT * FROM 銀行帳戶 WHERE 帳號='" & txtIncomeId.Text.Replace("'", "''") & "'", cn)
            ' 宣告SqlDataReader物件dr1與dr2
            Dim dr1, dr2 As SqlDataReader
            ' 傳回SqlDataReader物件dr1，用來查詢使用者帳號是否存在
            dr1 = selectCmd1.ExecuteReader()
            If Not dr1.Read() Then   ' 使用者帳號不存在執行下列敘述
                MessageBox.Show("你的帳號" & txtMyId.Text & "錯誤")
                Exit Sub
            End If
            ' 取得使用者的餘額並定給myMoney
            Dim myMoney As Integer = Val(dr1.Item("餘額").ToString())
            dr1.Close()  ' 關閉SqlDataRader物件dr1
            ' 傳回SqlDataReader物件dr2，用來查詢轉入帳號是否存在
            dr2 = selectCmd2.ExecuteReader()
            If Not dr2.Read() Then ' 轉入帳號不存在執行下列敘述
                MessageBox.Show("轉入帳號" & txtIncomeId.Text & "錯誤")
                Exit Sub
            End If
            dr2.Close()  ' 關閉SqlDataRader物件dr2

            ' 若使用者餘額小於轉入金額，則執行下列敘述
            If myMoney < Val(txtIncomeMoney.Text) Then
                MessageBox.Show(txtMyId.Text & "帳號沒這麼多存款")
                Exit Sub
            End If

            ' 建立SqlTransaction交易物件tran
            Dim tran As SqlTransaction = cn.BeginTransaction()
            Try
                ' 使用者帳號扣款的SQL語法
                Dim updateCmd1 As New SqlCommand("UPDATE 銀行帳戶 SET 餘額=餘額-" & txtIncomeMoney.Text & " WHERE 帳號='" & txtMyId.Text.Replace("'", "''") & "'", cn, tran)
                ' 設定轉入帳號匯款的SQL語法
                Dim updateCmd2 As New SqlCommand("UPDATE 銀行帳戶 SET 餘額=餘額+" & txtIncomeMoney.Text & " WHERE 帳號='" & txtIncomeId.Text.Replace("'", "''") & "'", cn, tran)
                updateCmd1.ExecuteNonQuery()
                updateCmd2.ExecuteNonQuery()
                tran.Commit() ' 認可交易
                MessageBox.Show("轉帳成功", "交易成功")
                txtIncomeId.Text = ""
                txtIncomeMoney.Text = ""
                txtMyId.Text = ""
            Catch ex As Exception
                tran.Rollback() ' 回復交易
                MessageBox.Show("轉帳失敗" & vbNewLine & ex.Message, "交易失敗")
            End Try
            ShowData()
        End Using
    End Sub

End Class
