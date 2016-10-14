Public Class Form1
    Sub draw(ByVal a As Integer)
        Dim g As Graphics = Me.CreateGraphics '要多這一個（要先有初值，不然它不讓你執行）
        Dim p As New Pen(Color.Red)
        g.Clear(Color.White)

        Select Case a
            Case 1 : g.DrawLine(p, 50, 50, 200, 50)
            Case 2 : g.DrawArc(p, 150, 0, 90, 90, 0, 270)
            Case 3 : g.DrawEllipse(p, 0, 0, 90, 90)
        End Select

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        draw(3)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        draw(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        draw(2)
    End Sub
End Class
