Public Class Scripter_Text
    Private Sub Scripter_Text_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Scripter_Text_RichTextBox.Text = My.Settings.ScripterText
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.ScripterText = Scripter_Text_RichTextBox.Text
    End Sub
End Class