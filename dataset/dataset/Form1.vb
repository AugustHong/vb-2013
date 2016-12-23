Imports System.Data  '一定要放在Imports System.Data.SqlClient上面
Imports System.Data.SqlClient


Public Class Form1
    Dim ds As New Data.DataSet() '設為全域
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using cn As New SqlConnection()
            cn.ConnectionString = "Data Source=(LocalDB)\v11.0;" & _
                "AttachDbFilename=|DataDirectory|Northwind.mdf;" & _
                "Integrated Security=True;"

            Dim staff As New SqlDataAdapter("Select * From 員工", cn)
            staff.Fill(ds, "員工")
            Dim customer As New SqlDataAdapter("Select * From 客戶", cn)
            customer.Fill(ds, "客戶")
            Dim product As New SqlDataAdapter("Select * From 產品類別", cn)
            product.Fill(ds, "產品類別")

            For i As Integer = 0 To ds.Tables.Count - 1
                ComboBox1.Items.Add(ds.Tables(i).TableName)
            Next

            ComboBox1.Text = ds.Tables("員工").TableName
            DataGridView1.DataSource = ds.Tables("員工")
        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        DataGridView1.DataSource = ds.Tables(ComboBox1.Text)
    End Sub
End Class
