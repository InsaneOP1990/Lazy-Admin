Public Class ingamename
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.InGameName = TextBox1.Text
        Me.Close()
    End Sub
End Class