Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str() As String = {"farman", "wolf", "goat", "菜"}

        ListBox1.Items.AddRange(str)
        Button3.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox2.Enabled = True
        Button2.Enabled = True

        If ListBox1.SelectedItem.ToString <> "farman" Then
            ListBox2.Items.Add(ListBox1.SelectedItem.ToString)
            ListBox1.Items.Remove(ListBox1.SelectedItem.ToString)
        End If

        ListBox2.Items.Add("farman")
        ListBox1.Items.Remove("farman")

        judge()

        ListBox1.Enabled = False
        Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Enabled = True
        Button1.Enabled = True

        If ListBox2.SelectedItem.ToString <> "farman" Then
            ListBox1.Items.Add(ListBox2.SelectedItem.ToString)
            ListBox2.Items.Remove(ListBox2.SelectedItem.ToString)
        End If

        ListBox1.Items.Add("farman")
        ListBox2.Items.Remove("farman")

        judge()

        ListBox2.Enabled = False
        Button2.Enabled = False

    End Sub
    Public Sub stoped()
        Button3.Enabled = True
        ListBox1.Enabled = False
        Button1.Enabled = False
        ListBox2.Enabled = False
        Button2.Enabled = False
    End Sub
    Sub judge()
        If ListBox1.FindString("wolf") <> -1 And ListBox1.FindString("goat") <> -1 And ListBox1.Items.Count = 2 Then Label1.Text = "wolf eat goat" : stoped()
        If ListBox1.FindString("菜") <> -1 And ListBox1.FindString("goat") <> -1 And ListBox1.Items.Count = 2 Then Label1.Text = " goat eat 菜" : stoped()

        If ListBox2.FindString("wolf") <> -1 And ListBox2.FindString("goat") <> -1 And ListBox2.Items.Count = 2 Then Label1.Text = "wolf eat goat" : stoped()
        If ListBox2.FindString("菜") <> -1 And ListBox2.FindString("goat") <> -1 And ListBox2.Items.Count = 2 Then Label1.Text = " goat eat 菜" : stoped()

        If ListBox2.Items.Count = 4 Then Label1.Text = "you win" : stoped()

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Enabled = True
        ListBox2.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True

        ListBox2.Items.Clear()
        ListBox1.Items.Clear()

        Label1.Text = ""
        Form1_Load(sender, e)
    End Sub
End Class
