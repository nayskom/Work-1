Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X As Single
        Dim Y As Single
        X = Val(TextBox2.Text)
        Y = 7.51 * X ^ 2 + 1.2 * Math.Tan(1) ^ 4 * (X + X / (X ^ 3 + 3)) - 3.5 + 1 / (Math.Sqrt(X ^ 3) - Math.Sqrt(X + 1))
        TextBox3.Text = Format(Y, "0.000")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
