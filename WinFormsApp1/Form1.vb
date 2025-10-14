Public Class Form1
    Private Sub Button102_Click(sender As Object, e As EventArgs) Handles Button102.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button87_Click(sender As Object, e As EventArgs) Handles Button87.Click

    End Sub
    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        Button1.Location = New Point(Button1.Location.X + 2, Button1.Location.Y + 2)
    End Sub

    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
        Button1.Location = New Point(Button1.Location.X - 2, Button1.Location.Y - 2)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
