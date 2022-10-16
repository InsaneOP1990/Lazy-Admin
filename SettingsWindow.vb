Public Class SettingsWindow
    Private Sub Main_Tab_Click(sender As Object, e As EventArgs) Handles Main_Tab.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Scriptertext_Button = TextBox1.Text

        My.Settings.Bar1Label_Text = Bar1Label_TextBox.Text
        My.Settings.Bar1Com_Text = Bar1Com_TextBox.Text
        My.Settings.Bar2Label_Text = Bar2Label_TextBox.Text
        My.Settings.Bar2Com_Text = Bar2Com_TextBox.Text
        My.Settings.Bar3Label_Text = Bar3Label_TextBox.Text
        My.Settings.Bar3Com_Text = Bar3Com_TextBox.Text
        My.Settings.Bar4Label_Text = Bar4Label_TextBox.Text
        My.Settings.Bar4Com_Text = Bar4Com_TextBox.Text


        My.Settings.Bar5Label_Text = Bar5Label_TextBox.Text
        My.Settings.Bar5List_Text = Bar5List_TextBox.Text
        My.Settings.Bar5Value_Text = Bar5Value_TextBox.Text
        My.Settings.Bar6Label_Text = Bar6Label_TextBox.Text
        My.Settings.Bar6List_Text = Bar6List_TextBox.Text
        My.Settings.Bar6Value_Text = Bar6Value_TextBox.Text
        My.Settings.Bar7Label_Text = Bar7Label_TextBox.Text
        My.Settings.Bar7List_Text = Bar7List_TextBox.Text
        My.Settings.Bar7Value_Text = Bar7Value_TextBox.Text
        My.Settings.Bar8Label_Text = Bar8Label_TextBox.Text
        My.Settings.Bar8List_Text = Bar8List_TextBox.Text
        My.Settings.Bar8Value_Text = Bar8Value_TextBox.Text

        My.Settings.Bar9Label_Text = Bar9Label_TextBox.Text
        My.Settings.Bar9List_Text = Bar9List_TextBox.Text
        My.Settings.Bar9Value_Text = Bar9Value_TextBox.Text


        My.Settings.Bar13List_Text = Bar13List_TextBox.Text

        My.Settings.TextTab1 = RichTextBox1.Text
        My.Settings.TextTab2 = RichTextBox2.Text
        My.Settings.TextTab3 = RichTextBox3.Text
        My.Settings.TextTab4 = RichTextBox4.Text
        My.Settings.TextTab5 = RichTextBox5.Text
        My.Settings.TextTab6 = RichTextBox6.Text
        My.Settings.TextTab7 = RichTextBox7.Text
        My.Settings.TextTab8 = RichTextBox8.Text
        My.Settings.TextTab9 = RichTextBox9.Text
        My.Settings.TextTab10 = RichTextBox10.Text

        My.Settings.TabLabel1 = TextBox2.Text
        My.Settings.TabLabel2 = TextBox3.Text
        My.Settings.TabLabel3 = TextBox4.Text
        My.Settings.TabLabel4 = TextBox5.Text
        My.Settings.TabLabel5 = TextBox6.Text
        My.Settings.TabLabel6 = TextBox7.Text
        My.Settings.TabLabel7 = TextBox8.Text
        My.Settings.TabLabel8 = TextBox9.Text
        My.Settings.TabLabel9 = TextBox10.Text
        My.Settings.TabLabel10 = TextBox11.Text

        MessageBox.Show("Restart app for most settings to take effect")
    End Sub

    Private Sub SettingsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.Scriptertext_Button = TextBox1.Text

        Bar1Label_TextBox.Text = My.Settings.Bar1Label_Text
        Bar1Com_TextBox.Text = My.Settings.Bar1Com_Text
        Bar2Label_TextBox.Text = My.Settings.Bar2Label_Text
        Bar2Com_TextBox.Text = My.Settings.Bar2Com_Text
        Bar3Label_TextBox.Text = My.Settings.Bar3Label_Text
        Bar3Com_TextBox.Text = My.Settings.Bar3Com_Text
        Bar4Label_TextBox.Text = My.Settings.Bar4Label_Text
        Bar4Com_TextBox.Text = My.Settings.Bar4Com_Text


        Bar5Label_TextBox.Text = My.Settings.Bar5Label_Text
        Bar5List_TextBox.Text = My.Settings.Bar5List_Text
        Bar5Value_TextBox.Text = My.Settings.Bar5Value_Text
        Bar6Label_TextBox.Text = My.Settings.Bar6Label_Text
        Bar6List_TextBox.Text = My.Settings.Bar6List_Text
        Bar6Value_TextBox.Text = My.Settings.Bar6Value_Text
        Bar7Label_TextBox.Text = My.Settings.Bar7Label_Text
        Bar7List_TextBox.Text = My.Settings.Bar7List_Text
        Bar7Value_TextBox.Text = My.Settings.Bar7Value_Text
        Bar8Label_TextBox.Text = My.Settings.Bar8Label_Text
        Bar8List_TextBox.Text = My.Settings.Bar8List_Text
        Bar8Value_TextBox.Text = My.Settings.Bar8Value_Text

        Bar9Label_TextBox.Text = My.Settings.Bar9Label_Text
        Bar9List_TextBox.Text = My.Settings.Bar9List_Text
        Bar9Value_TextBox.Text = My.Settings.Bar9Value_Text


        Bar13List_TextBox.Text = My.Settings.Bar13List_Text

        RichTextBox1.Text = My.Settings.TextTab1
        RichTextBox2.Text = My.Settings.TextTab2
        RichTextBox3.Text = My.Settings.TextTab3
        RichTextBox4.Text = My.Settings.TextTab4
        RichTextBox5.Text = My.Settings.TextTab5
        RichTextBox6.Text = My.Settings.TextTab6
        RichTextBox7.Text = My.Settings.TextTab7
        RichTextBox8.Text = My.Settings.TextTab8
        RichTextBox9.Text = My.Settings.TextTab9
        RichTextBox10.Text = My.Settings.TextTab10

        TextBox2.Text = My.Settings.TabLabel1
        TextBox3.Text = My.Settings.TabLabel2
        TextBox4.Text = My.Settings.TabLabel3
        TextBox5.Text = My.Settings.TabLabel4
        TextBox6.Text = My.Settings.TabLabel5
        TextBox7.Text = My.Settings.TabLabel6
        TextBox8.Text = My.Settings.TabLabel7
        TextBox9.Text = My.Settings.TabLabel8
        TextBox10.Text = My.Settings.TabLabel9
        TextBox11.Text = My.Settings.TabLabel10
    End Sub
End Class