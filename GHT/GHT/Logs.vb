Public Class Logs
    Private Sub Logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim time As Date = Now()
        Label2.Text = "[" & time & "]:" & "Getting User Auth"
        Label3.Text = "[" & time & "]:" & "Checking Server State"
        Label4.Text = "[" & time & "]:" & "Checking User State"
        If Form1.TextBox1.Text = "Admin" And Form1.TextBox2.Text = "root" Then Label5.Text = "[" & time & "]:" & "User Found Logging In Now" Else Label5.Text = "[" & time & "]:" & "CRITICAL ERROR USER IS NOT FOUND"
    End Sub
End Class