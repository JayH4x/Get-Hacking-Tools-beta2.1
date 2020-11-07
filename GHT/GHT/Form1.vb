Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Logs.Show()
        If TextBox1.Text = "Admin" And TextBox2.Text = "root" Then main.Show()
    End Sub
End Class
