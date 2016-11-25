Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = ListBox1.SelectedItem.ToString
        ListBox1.Items.Remove(Label3.Text)
        ListBox2.Items.Add(Label3.Text)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str() As String = {"業問2", "鋼鐵人2", "史瑞克", "火影忍者", "將是神通", "慾望城市"}
        For i = 0 To 5
            ListBox1.Items.Add(str(i))
        Next

        Label3.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.Text = ListBox2.SelectedItem.ToString
            ListBox2.Items.Remove(Label3.Text)
            ListBox1.Items.Add(Label3.Text)
    End Sub
End Class
