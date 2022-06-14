Public Class DiscordWindow

    Private Sub Discord_WebHook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        webhookLink.Text = My.Settings.WebHook
        username.Text = My.Settings.WebUserName
        profilePicLink.Text = My.Settings.WebProfilelink
        InGameNameTextbox.Text = My.Settings.InGameName
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.WebHook = webhookLink.Text
        My.Settings.WebUserName = username.Text
        My.Settings.WebProfilelink = profilePicLink.Text
        My.Settings.InGameName = InGameNameTextbox.Text
    End Sub


End Class