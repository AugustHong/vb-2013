Public Class Form1
    Dim r1%, r2%, sum%
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = Now
        TextBox1.Enabled = False
        CheckBox1.Checked = True
        RadioButton3.Checked = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        RadioButton1.Text = "one day"
        RadioButton2.Text = "two day"

        If DateTimePicker1.Value.DayOfWeek = DayOfWeek.Saturday Or DateTimePicker1.Value.DayOfWeek = DayOfWeek.Sunday Then
            RadioButton1.Text = RadioButton1.Text + "(400 dollars)"
            r1 = 400
        Else
            RadioButton1.Text = RadioButton1.Text + "(360 dollars)"
            r1 = 360
        End If

        If DateTimePicker1.Value.DayOfWeek = DayOfWeek.Saturday Or DateTimePicker1.Value.DayOfWeek = DayOfWeek.Sunday Or DateTimePicker1.Value.DayOfWeek = DayOfWeek.Friday Then
            RadioButton2.Text = RadioButton2.Text + "(700 dollars)"
            r2 = 700
        Else
            RadioButton2.Text = RadioButton2.Text + "(630 dollars)"
            r2 = 630
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Text = ""
            TextBox1.Enabled = False
            RadioButton3.Enabled = True
            RadioButton4.Enabled = True
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            RadioButton8.Enabled = True

            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox1.Enabled = True
            RadioButton3.Enabled = False
            RadioButton4.Enabled = False
            RadioButton5.Enabled = False
            RadioButton6.Enabled = False
            RadioButton7.Enabled = False
            RadioButton8.Enabled = False

            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            RadioButton8.Checked = False

            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = True
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False

        Label4.Text = "total:$"

        TextBox1.Text = ""
        RadioButton1.Checked = True
        RadioButton2.Checked = False
        RadioButton3.Checked = True
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False

        DateTimePicker1.Value = DateTimePicker1.MinDate

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) < 7 And CheckBox2.Checked = True Then
            MessageBox.Show("please input over 7")
        Else
            If RadioButton1.Checked = True Then sum += r1
            If RadioButton2.Checked = True Then sum += r2
            If CheckBox3.Checked = True Then sum += 110
            If CheckBox4.Checked = True Then sum += 70

            If RadioButton3.Checked = True Then sum *= 1
            If RadioButton4.Checked = True Then sum *= 2
            If RadioButton5.Checked = True Then sum *= 3
            If RadioButton6.Checked = True Then sum *= 4
            If RadioButton7.Checked = True Then sum *= 5
            If RadioButton8.Checked = True Then sum *= 6

            If CheckBox2.Checked = True Then sum *= Val(TextBox1.Text) : sum *= 0.9

            Label4.Text = Label4.Text + sum.ToString
            sum = 0
        End If

    End Sub
End Class
