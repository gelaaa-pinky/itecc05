Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, ans As Integer

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        Label3.Text = num1 + num2
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub MULTIPLY_Click(sender As Object, e As EventArgs) Handles MULTIPLY.Click
        Dim num1, num2, ans As Integer

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        Label3.Text = num1 * num2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1, num2, ans As Integer

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        Label3.Text = num1 / num2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1, num2, ans As Integer

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        Label3.Text = num1 - num2
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
