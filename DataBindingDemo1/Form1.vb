Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) _
     Handles MyBase.Load
        Using cn As New SqlConnection()
            cn.ConnectionString = "Data Source=(LocalDB)\v11.0;" & _
                "AttachDbFilename=|DataDirectory|ch18DB.mdf;" & _
                "Integrated Security=True;"
            Dim daEmployee As New SqlDataAdapter _
             ("SELECT * FROM 員工 ORDER BY 編號 DESC", cn)
            Dim ds As New DataSet()
            daEmployee.Fill(ds, "員工")
            ' ComboBox控制項資料繫結
            cboId.DataSource = ds
            cboId.DisplayMember = "員工.編號"
            ' TextBox控制項資料繫結
            txtName.DataBindings.Add("Text", ds, "員工.姓名")
            txtTel.DataBindings.Add("Text", ds, "員工.電話")
            txtPosition.DataBindings.Add("Text", ds, "員工.職稱")
            txtSalary.DataBindings.Add("Text", ds, "員工.薪資")
            ' DataGridView1控制項資料繫結
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "員工"
        End Using
    End Sub

End Class
