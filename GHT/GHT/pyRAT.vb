Public Class pyRAT
    Private Sub pyRAT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FatRat As String = "https://github.com/Screetsec/TheFatRat"
        Process.Start(FatRat)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Stitch As String = "https://github.com/nathanlopez/Stitch"
        Process.Start(Stitch)
    End Sub
End Class