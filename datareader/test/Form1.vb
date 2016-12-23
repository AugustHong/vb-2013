Imports System.Data.SqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using cn = New SqlConnection()
            cn.ConnectionString = "Data Source=(LocalDB)\v11.0;" & _
                "AttachDbFilename=|DataDirectory|ch17DB.mdf;" & _
                "Integrated Security=True;"
            'ch17DB.mdf這是檔名  可改
            cn.Open()
            Dim cmd As New SqlCommand("Select * From 成績單", cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader() '不加new 

            For i As Integer = 0 To dr.FieldCount - 1
                TextBox1.Text &= dr.GetName(i) & vbTab
            Next
            TextBox1.Text &= vbCrLf

            Do While dr.Read()
                For i As Integer = 0 To dr.FieldCount - 1
                    TextBox1.Text &= dr.Item(i).ToString & vbTab
                Next
                TextBox1.Text &= vbCrLf
            Loop
        End Using
    End Sub
End Class
