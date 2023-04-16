Imports System.Collections.Specialized
Imports System.Net
Imports System.IO
Imports System.Management

Public Class MainWindow
    '=================================================


    Private Function Clean(ByVal Cleaning As String) As String

        Dim CleanCommandHangar0 As String = Cleaning
        If CleanCommandHangar0.Contains("<sec>") Then
            Cleaning = CleanCommandHangar0.Replace("<sec>", My.Settings.Sector)
            GoTo c1
        Else
c1:
            Dim CleanCommandHangar1 As String = Cleaning
            Dim namecode As String

            If SteamCheckBox.Checked = False Then
                namecode = Player_NameText.Text
            Else
                namecode = SteamID_Texbox.Text
            End If

            If CleanCommandHangar1.Contains("<PlayerName>") Then
                Cleaning = CleanCommandHangar1.Replace("<PlayerName>", namecode)
                GoTo c2
            Else
c2:
                Dim CleanCommandHangar2 As String = Cleaning
                If CleanCommandHangar2.Contains("<GridName>") Then
                    Cleaning = CleanCommandHangar2.Replace("<GridName>", Grid_NameText.Text)
                    GoTo c3
                Else
c3:
                    Dim CleanCommandHangar3 As String = Cleaning
                    If CleanCommandHangar3.Contains("<Hnum>") Then
                        Cleaning = CleanCommandHangar3.Replace("<Hnum>", HangarRemoveComboBox.Text)
                        GoTo c4
                    Else
c4:
                        Dim CleanCommandHangar4 As String = Cleaning
                        If CleanCommandHangar4.Contains("<DiscordID>") Then
                            Cleaning = CleanCommandHangar4.Replace("<DiscordID>", DiscordID_TextBox.Text)
                            GoTo c5
                        Else
c5:
                            Dim CleanCommandHangar5 As String = Cleaning
                            If CleanCommandHangar5.Contains("<SteamID>") Then
                                Cleaning = CleanCommandHangar5.Replace("<SteamID>", SteamID_Texbox.Text)
                                GoTo c6
                            Else
c6:
                                Dim CleanCommandHangar6 As String = Cleaning
                                If CleanCommandHangar6.Contains("<NewGridName>") Then
                                    Cleaning = CleanCommandHangar6.Replace("<NewGridName>", RenameGridNewTextBox.Text)
                                    GoTo c7
                                Else
c7:
                                    Dim CleanCommandHangar7 As String = Cleaning
                                    Dim logserversave As String = My.Settings.logserver
                                    If CleanCommandHangar7.Contains("<ServerID>") Then
                                        Cleaning = CleanCommandHangar7.Replace("<ServerID>", logserversave)
                                        GoTo c8
                                    Else
c8:
                                        Dim CleanCommandHangar8 As String = Cleaning
                                        Dim dateentry As String = Month_ComboBox.Text & "/" & Day_ComboBox.Text
                                        If CleanCommandHangar8.Contains("<Date>") Then
                                            Cleaning = CleanCommandHangar8.Replace("<Date>", dateentry)
                                            GoTo D1
                                        Else
                                            GoTo D1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    GoTo D1
                End If
D1:
                Dim Cleaned As String = Cleaning
                Return Cleaned
            End If
        End If

    End Function

    Private Function nexuscommand(ByVal text As String, ByVal text2 As String, ByVal text3 As String) As String
        Dim Hang As String = text
        Dim HangList As String = text2
        Dim HangArray() As String = Split(Hang, ",")
        Dim HangListArray() As String = Split(HangList, ",")
        Dim comboboxtext As String = text3

        Try
            If Hang.Contains(comboboxtext) Then
                If comboboxtext = HangArray(0) Then
                    Dim Command As String = HangListArray(0)
                    Return Command
                Else
                    If comboboxtext = HangArray(1) Then
                        Dim Command As String = HangListArray(1)
                        Return Command
                    Else
                        If comboboxtext = HangArray(2) Then
                            Dim Command As String = HangListArray(2)
                            Return Command
                        Else
                            If comboboxtext = HangArray(3) Then
                                Dim Command As String = HangListArray(3)
                                Return Command
                            Else
                                If comboboxtext = HangArray(4) Then
                                    Dim Command As String = HangListArray(4)
                                    Return Command
                                Else
                                    If comboboxtext = HangArray(5) Then
                                        Dim Command As String = HangListArray(5)
                                        Return Command
                                    Else
                                        If comboboxtext = HangArray(6) Then
                                            Dim Command As String = HangListArray(6)
                                            Return Command
                                        Else
                                            If comboboxtext = HangArray(7) Then
                                                Dim Command As String = HangListArray(7)
                                                Return Command
                                            Else
                                                If comboboxtext = HangArray(8) Then
                                                    Dim Command As String = HangListArray(8)
                                                    Return Command
                                                Else
                                                    If comboboxtext = HangArray(9) Then
                                                        Dim Command As String = HangListArray(9)
                                                        Return Command
                                                    Else
                                                        If comboboxtext = HangArray(10) Then
                                                            Dim Command As String = HangListArray(10)
                                                            Return Command
                                                        Else
                                                            If comboboxtext = HangArray(11) Then
                                                                Dim Command As String = HangListArray(11)
                                                                Return Command
                                                            Else
                                                                If comboboxtext = HangArray(12) Then
                                                                    Dim Command As String = HangListArray(12)
                                                                    Return Command
                                                                Else
                                                                    If comboboxtext = HangArray(13) Then
                                                                        Dim Command As String = HangListArray(13)
                                                                        Return Command
                                                                    Else
                                                                        If comboboxtext = HangArray(14) Then
                                                                            Dim Command As String = HangListArray(14)
                                                                            Return Command
                                                                        Else
                                                                            If comboboxtext = HangArray(15) Then
                                                                                Dim Command As String = HangListArray(15)
                                                                                Return Command
                                                                            Else
                                                                                If comboboxtext = HangArray(16) Then
                                                                                    Dim Command As String = HangListArray(16)
                                                                                    Return Command
                                                                                Else
                                                                                    If comboboxtext = HangArray(17) Then
                                                                                        Dim Command As String = HangListArray(17)
                                                                                        Return Command
                                                                                    Else
                                                                                        If comboboxtext = HangArray(18) Then
                                                                                            Dim Command As String = HangListArray(18)
                                                                                            Return Command
                                                                                        Else
                                                                                            If comboboxtext = HangArray(19) Then
                                                                                                Dim Command As String = HangListArray(19)
                                                                                                Return Command
                                                                                            Else
                                                                                                If comboboxtext = HangArray(20) Then
                                                                                                    Dim Command As String = HangListArray(20)
                                                                                                    Return Command
                                                                                                Else
                                                                                                    If comboboxtext = HangArray(21) Then
                                                                                                        Dim Command As String = HangListArray(21)
                                                                                                        Return Command
                                                                                                    Else
                                                                                                        If comboboxtext = HangArray(22) Then
                                                                                                            Dim Command As String = HangListArray(22)
                                                                                                            Return Command
                                                                                                        Else
                                                                                                            If comboboxtext = HangArray(23) Then
                                                                                                                Dim Command As String = HangListArray(23)
                                                                                                                Return Command
                                                                                                            Else
                                                                                                                If comboboxtext = HangArray(24) Then
                                                                                                                    Dim Command As String = HangListArray(24)
                                                                                                                    Return Command
                                                                                                                Else
                                                                                                                    If comboboxtext = HangArray(25) Then
                                                                                                                        Dim Command As String = HangListArray(25)
                                                                                                                        Return Command
                                                                                                                    Else
                                                                                                                        If comboboxtext = HangArray(26) Then
                                                                                                                            Dim Command As String = HangListArray(26)
                                                                                                                            Return Command
                                                                                                                        Else
                                                                                                                            If comboboxtext = HangArray(27) Then
                                                                                                                                Dim Command As String = HangListArray(27)
                                                                                                                                Return Command
                                                                                                                            Else
                                                                                                                                If comboboxtext = HangArray(28) Then
                                                                                                                                    Dim Command As String = HangListArray(28)
                                                                                                                                    Return Command
                                                                                                                                Else
                                                                                                                                    If comboboxtext = HangArray(29) Then
                                                                                                                                        Dim Command As String = HangListArray(29)
                                                                                                                                        Return Command
                                                                                                                                    Else
                                                                                                                                        If comboboxtext = HangArray(30) Then
                                                                                                                                            Dim Command As String = HangListArray(30)
                                                                                                                                            Return Command
                                                                                                                                        Else
                                                                                                                                            If comboboxtext = HangArray(31) Then
                                                                                                                                                Dim Command As String = HangListArray(31)
                                                                                                                                                Return Command
                                                                                                                                            Else
                                                                                                                                                If comboboxtext = HangArray(32) Then
                                                                                                                                                    Dim Command As String = HangListArray(32)
                                                                                                                                                    Return Command
                                                                                                                                                Else
                                                                                                                                                    If comboboxtext = HangArray(33) Then
                                                                                                                                                        Dim Command As String = HangListArray(33)
                                                                                                                                                        Return Command
                                                                                                                                                    Else
                                                                                                                                                        If comboboxtext = HangArray(34) Then
                                                                                                                                                            Dim Command As String = HangListArray(34)
                                                                                                                                                            Return Command
                                                                                                                                                        Else
                                                                                                                                                            If comboboxtext = HangArray(35) Then
                                                                                                                                                                Dim Command As String = HangListArray(35)
                                                                                                                                                                Return Command
                                                                                                                                                            Else
                                                                                                                                                                If comboboxtext = HangArray(36) Then
                                                                                                                                                                    Dim Command As String = HangListArray(36)
                                                                                                                                                                    Return Command
                                                                                                                                                                Else
                                                                                                                                                                    If comboboxtext = HangArray(37) Then
                                                                                                                                                                        Dim Command As String = HangListArray(37)
                                                                                                                                                                        Return Command
                                                                                                                                                                    Else
                                                                                                                                                                        If comboboxtext = HangArray(38) Then
                                                                                                                                                                            Dim Command As String = HangListArray(38)
                                                                                                                                                                            Return Command
                                                                                                                                                                        Else
                                                                                                                                                                            If comboboxtext = HangArray(39) Then
                                                                                                                                                                                Dim Command As String = HangListArray(39)
                                                                                                                                                                                Return Command
                                                                                                                                                                            Else
                                                                                                                                                                                If comboboxtext = HangArray(40) Then
                                                                                                                                                                                    Dim Command As String = HangListArray(40)
                                                                                                                                                                                    Return Command
                                                                                                                                                                                Else
                                                                                                                                                                                    If comboboxtext = HangArray(41) Then
                                                                                                                                                                                        Dim Command As String = HangListArray(41)
                                                                                                                                                                                        Return Command
                                                                                                                                                                                    Else
                                                                                                                                                                                        If comboboxtext = HangArray(42) Then
                                                                                                                                                                                            Dim Command As String = HangListArray(42)
                                                                                                                                                                                            Return Command
                                                                                                                                                                                        Else
                                                                                                                                                                                            If comboboxtext = HangArray(43) Then
                                                                                                                                                                                                Dim Command As String = HangListArray(43)
                                                                                                                                                                                                Return Command
                                                                                                                                                                                            Else
                                                                                                                                                                                                If comboboxtext = HangArray(44) Then
                                                                                                                                                                                                    Dim Command As String = HangListArray(44)
                                                                                                                                                                                                    Return Command
                                                                                                                                                                                                Else
                                                                                                                                                                                                    If comboboxtext = HangArray(45) Then
                                                                                                                                                                                                        Dim Command As String = HangListArray(45)
                                                                                                                                                                                                        Return Command
                                                                                                                                                                                                    Else
                                                                                                                                                                                                        If comboboxtext = HangArray(46) Then
                                                                                                                                                                                                            Dim Command As String = HangListArray(46)
                                                                                                                                                                                                            Return Command
                                                                                                                                                                                                        Else
                                                                                                                                                                                                            If comboboxtext = HangArray(47) Then
                                                                                                                                                                                                                Dim Command As String = HangListArray(47)
                                                                                                                                                                                                                Return Command
                                                                                                                                                                                                            Else
                                                                                                                                                                                                                If comboboxtext = HangArray(48) Then
                                                                                                                                                                                                                    Dim Command As String = HangListArray(48)
                                                                                                                                                                                                                    Return Command
                                                                                                                                                                                                                Else
                                                                                                                                                                                                                    If comboboxtext = HangArray(49) Then
                                                                                                                                                                                                                        Dim Command As String = HangListArray(49)
                                                                                                                                                                                                                        Return Command
                                                                                                                                                                                                                    Else
                                                                                                                                                                                                                        If comboboxtext = HangArray(50) Then
                                                                                                                                                                                                                            Dim Command As String = HangListArray(50)
                                                                                                                                                                                                                            Return Command
                                                                                                                                                                                                                        Else
                                                                                                                                                                                                                            If comboboxtext = HangArray(51) Then
                                                                                                                                                                                                                                Dim Command As String = HangListArray(51)
                                                                                                                                                                                                                                Return Command
                                                                                                                                                                                                                            Else
                                                                                                                                                                                                                                Dim Command As String = "ERROR"
                                                                                                                                                                                                                                Return Command
                                                                                                                                                                                                                                GoTo opps
                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                End If
                                                                                                                                                                                                            End If
                                                                                                                                                                                                        End If
                                                                                                                                                                                                    End If
                                                                                                                                                                                                End If
                                                                                                                                                                                            End If
                                                                                                                                                                                        End If
                                                                                                                                                                                    End If
                                                                                                                                                                                End If
                                                                                                                                                                            End If
                                                                                                                                                                        End If
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            GoTo opps
        End Try
opps:

    End Function

    'Public Function GetDriveSerialNumber() As String
    '    Dim DriveSerial As Long
    '    Dim fso As Object, Drv As Object
    '    'Create a FileSystemObject object
    '    fso = CreateObject("Scripting.FileSystemObject")
    '    Drv = fso.GetDrive(fso.GetDriveName(AppDomain.CurrentDomain.BaseDirectory))
    '    With Drv
    '        If .IsReady Then
    '            DriveSerial = .SerialNumber
    '        Else    '"Drive Not Ready!"
    '            DriveSerial = -1
    '        End If
    '    End With
    '    'Clean up
    '    Drv = Nothing
    '    fso = Nothing
    '    GetDriveSerialNumber = Hex(DriveSerial)
    'End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.InGameName = "toolazytologin" Then
            My.Settings.AutoSend = "False"
            AutoSend.Hide()
            messageField.Visible = False
            Send.Visible = False
            ' DiscordWebHookToolStripMenuItem.Visible = False
            My.Settings.WebHook = ""
        Else
            Me.Text = "North's Lazy Admin - " & My.Settings.InGameName
            My.Settings.AutoSend = "True"
        End If
        My.Settings.Sector = "PVE - Any server that is Avalon (Planets Space KotH's)"
        My.Settings.ListGrid = ""
        My.Settings.RestoreNumone = ""
        My.Settings.RestoreNumtwo = ""
        My.Settings.RestoreQ = ""
        My.Settings.RestoreForce = ""
        My.Settings.Hangar = ""
        My.Settings.HangarRemove = ""
        My.Settings.PlayerE = ""
        My.Settings.GridE = ""
        My.Settings.LogType = ""
        Dim formattedDate As String = Date.Today.ToString("dd")
        Dim formattedDate2 As String = Date.Today.ToString("MM")
        Month_ComboBox.Text = formattedDate2
        Day_ComboBox.Text = formattedDate
        Timer1.Start()
        AutoSend.Checked = My.Settings.AutoSend

        Scriptertext_Button.Text = My.Settings.Scriptertext_Button
        GetSteamID_Label.Text = My.Settings.Bar1Label_Text
        GiveScripter_Label.Text = My.Settings.Bar2Label_Text
        Label25.Text = My.Settings.Bar3Label_Text
        RenameLabel.Text = My.Settings.Bar4Label_Text
        Label3.Text = My.Settings.Bar5Label_Text
        Label1.Text = My.Settings.Bar6Label_Text
        Label2.Text = My.Settings.Bar7Label_Text
        Label26.Text = My.Settings.Bar8Label_Text
        Label8.Text = My.Settings.Bar9Label_Text

        Tab_DiscordRichTextBox.Text = My.Settings.TextTab1
        Tab_BankRichTextBox.Text = My.Settings.TextTab2
        Tab_AleRichTextBox.Text = My.Settings.TextTab3
        Tab_NexusRichTextBox.Text = My.Settings.TextTab4
        Tab_HangarRichTextBox.Text = My.Settings.TextTab5
        TabControl1.Text = My.Settings.TextTab6
        Tab_CleanRichTextBox.Text = My.Settings.TextTab7
        Tab_GridsRichTextBox.Text = My.Settings.TextTab8
        Tab_SlimeRichTextBox.Text = My.Settings.TextTab9
        Tab_MiscRichTextBox.Text = My.Settings.TextTab10

        Tab_DiscordRichTextBox2.Text = My.Settings.TextTab1
        Tab_BankRichTextBox2.Text = My.Settings.TextTab2
        Tab_AleRichTextBox2.Text = My.Settings.TextTab3
        Tab_NexusRichTextBox2.Text = My.Settings.TextTab4
        Tab_HangarRichTextBox2.Text = My.Settings.TextTab5
        Tab_BlocksRichTextBox2.Text = My.Settings.TextTab6
        Tab_CleanRichTextBox2.Text = My.Settings.TextTab7
        Tab_GridsRichTextBox2.Text = My.Settings.TextTab8
        Tab_SlimeRichTextBox2.Text = My.Settings.TextTab9
        Tab_MiscRichTextBox2.Text = My.Settings.TextTab10



        TabControl1.TabPages(1).Text = My.Settings.TabLabel1
        TabControl1.TabPages(2).Text = My.Settings.TabLabel2
        TabControl1.TabPages(3).Text = My.Settings.TabLabel3
        TabControl1.TabPages(4).Text = My.Settings.TabLabel4
        TabControl1.TabPages(5).Text = My.Settings.TabLabel5
        TabControl1.TabPages(6).Text = My.Settings.TabLabel6
        TabControl1.TabPages(7).Text = My.Settings.TabLabel7
        TabControl1.TabPages(8).Text = My.Settings.TabLabel8
        TabControl1.TabPages(9).Text = My.Settings.TabLabel9
        TabControl1.TabPages(10).Text = My.Settings.TabLabel10

        Me.BackColor = My.Settings.BackColor
        TabControl1.TabPages(0).BackColor = My.Settings.BackColor
        TabControl1.TabPages(1).BackColor = My.Settings.BackColor
        TabControl1.TabPages(2).BackColor = My.Settings.BackColor
        TabControl1.TabPages(3).BackColor = My.Settings.BackColor
        TabControl1.TabPages(4).BackColor = My.Settings.BackColor
        TabControl1.TabPages(5).BackColor = My.Settings.BackColor
        TabControl1.TabPages(6).BackColor = My.Settings.BackColor
        TabControl1.TabPages(7).BackColor = My.Settings.BackColor
        TabControl1.TabPages(8).BackColor = My.Settings.BackColor
        TabControl1.TabPages(9).BackColor = My.Settings.BackColor
        TabControl1.TabPages(10).BackColor = My.Settings.BackColor


    End Sub

    Private Sub Copy_SteamID_Button_Click(sender As Object, e As EventArgs) Handles Copy_SteamID_Button.Click
        If GetSteamID_TextBox.TextLength > 0 Then Clipboard.SetText(GetSteamID_TextBox.Text)

        Dim text As String
        text = GetSteamID_TextBox.Text

        If AutoSend.Checked = True Then
            messageField.Text = text
            Send.PerformClick()
        End If
    End Sub

    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click, MyBase.Enter
        'Autosend discord
        My.Settings.AutoSend = AutoSend.Checked
        'start timmer
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
            Timer1.Start()
        Else
            statusTextBox.BackColor = Color.FromArgb(0, 255, 0)
            Label13.Visible = False
            Label14.Visible = False
            Label15.Visible = False
            Label16.Visible = False
            Label17.Visible = False
            Label18.Visible = False
            Label19.Visible = False
            Label20.Visible = False
            Label21.Visible = False
            Label22.Visible = False
        End If

        'warning
        If My.Settings.Sector = "ALL" Then
            WarningLabel.Visible = True
        Else
            WarningLabel.Visible = False
        End If

        If AutoSend.Checked = True Then
            Copy_SteamID_Button.Text = "Send"
            GiveScripterButton.Text = "Send"
            PlayerEnameButton.Text = "Send"
            GridEnameButton.Text = "Send"
            RenameGridButton.Text = "Send"
            Common_copyButton.Text = "Send"
            ServerLogButton.Text = "Send"
            ListGrid_PVE_NameButton.Text = "Send"
            ListGridBackupNameButton.Text = "Send"
            GridRestoreNameButton.Text = "Send"
            GiveItem_CopyButton.Text = "Send"
            HangarNameButton.Text = "Send"
            SetRankButton.Text = "Send"
        Else
            Copy_SteamID_Button.Text = "Copy Text"
            GiveScripterButton.Text = "Copy Text"
            PlayerEnameButton.Text = "Copy Text"
            GridEnameButton.Text = "Copy Text"
            RenameGridButton.Text = "Copy Text"
            Common_copyButton.Text = "Copy Text"
            ServerLogButton.Text = "Copy Text"
            ListGrid_PVE_NameButton.Text = "Copy Text"
            ListGridBackupNameButton.Text = "Copy Text"
            GridRestoreNameButton.Text = "Copy Text"
            GiveItem_CopyButton.Text = "Copy Text"
            HangarNameButton.Text = "Copy Text"
            SetRankButton.Text = "Copy Text"
        End If

        If My.Settings.InGameName = "InGameName" Then

            Register.Show()

        End If

        ' Settings updates
        My.Settings.ListGrid = ListGridBackupComboBox.Text
        My.Settings.RestoreNumone = RestoreNumoneComboBox.Text
        My.Settings.RestoreNumtwo = RestoreNumtwoComboBox.Text
        My.Settings.RestoreQ = RestoreQComboBox.Text
        My.Settings.RestoreForce = RestoreForceComboBox.Text
        My.Settings.Hangar = HangarComboBox.Text
        My.Settings.HangarRemove = HangarRemoveComboBox.Text
        My.Settings.PlayerE = PlayerEComboBox.Text
        My.Settings.GridE = GridEComboBox.Text
        My.Settings.LogType = Log_TypeComboBox.Text
        webhookLink.Text = My.Settings.WebHook
        'If username.TextLength < 80 Then
        '    username.Text = My.Settings.WebUserName + GetDriveSerialNumber() + "-" + My.Settings.InGameName + "-"
        'Else
        '    username.Text = GetDriveSerialNumber() + "-" + My.Settings.InGameName + "-"
        'End If
        profilePicLink.Text = My.Settings.WebProfilelink
        '====================================================REPLACE TAB TEXT START ===================================================
        'discord tab
        If Player_NameText.TextLength > 0 Then

            Dim olddiscord As String = Tab_DiscordRichTextBox2.Text
            Tab_DiscordRichTextBox.Text = Clean(olddiscord)
            'bank tab
            Dim olddiscord1 As String = Tab_BankRichTextBox2.Text
            Tab_BankRichTextBox.Text = Clean(olddiscord1)




            '          If olddiscord1.Contains("<discordID>") Then
            '           Dim newdiscord1 As String
            '         newdiscord1 = olddiscord1.Replace("<discordID>", DiscordID_TextBox.Text)
            '          Dim newdiscord2 As String
            '         newdiscord2 = newdiscord1.Replace("<sec>", My.Settings.Sector)
            '            Dim newdiscord3 As String
            '          newdiscord3 = newdiscord2.Replace("<playername>", Player_NameText.Text)
            '         Dim newdiscord4 As String
            '           newdiscord4 = newdiscord3.Replace("<steamid>", SteamID_Texbox.Text)

            '          Tab_BankRichTextBox.Text = newdiscord4
            '     End If

            'ale tab
            Dim oldsec As String = Tab_AleRichTextBox2.Text
            Tab_AleRichTextBox.Text = Clean(oldsec)


            Dim oldnexus As String = Tab_NexusRichTextBox2.Text
            Tab_NexusRichTextBox.Text = Clean(oldnexus)

            Dim oldHangar As String = Tab_HangarRichTextBox2.Text
            Tab_HangarRichTextBox.Text = Clean(oldHangar)


            'Block tab
            Dim olddblock As String = Tab_BlocksRichTextBox2.Text
            Tab_BlocksRichTextBox.Text = Clean(olddblock)
            'If olddblock.Contains("<GridName>") Then
            '    Dim newblock1 As String
            '    newblock1 = olddblock.Replace("<GridName>", Grid_NameText.Text)
            '    Dim newblock2 As String
            '    newblock2 = newblock1.Replace("<sec>", My.Settings.Sector)
            '    Dim newblock3 As String
            '    newblock3 = newblock2.Replace("<PlayerName>", Player_NameText.Text)

            '    Tab_BlocksRichTextBox.Text = newblock3
            'End If

            'Clean tab
            Dim oldClean As String = Tab_CleanRichTextBox2.Text
            Tab_CleanRichTextBox.Text = Clean(oldClean)
            'If oldClean.Contains("<sec") Then
            '    Dim newClean As String
            '    newClean = oldClean.Replace("<sec>", My.Settings.Sector)

            '    Tab_CleanRichTextBox.Text = newClean
            'End If

            'Slime tab
            Dim olddSlime As String = Tab_SlimeRichTextBox2.Text
            Tab_SlimeRichTextBox.Text = Clean(olddSlime)
            'If olddSlime.Contains("<Gridname>") Then
            '    Dim newSlime1 As String
            '    newSlime1 = olddSlime.Replace("<Gridname>", Grid_NameText.Text)
            '    Dim newSlime2 As String
            '    newSlime2 = newSlime1.Replace("<sec>", My.Settings.Sector)
            '    Dim newSlime3 As String
            '    newSlime3 = newSlime2.Replace("<PlayerName>", Player_NameText.Text)

            '    Tab_SlimeRichTextBox.Text = newSlime3
            'End If

            'Grids tab
            Dim olddGridss As String = Tab_GridsRichTextBox2.Text
            Tab_GridsRichTextBox.Text = Clean(olddGridss)
            'If olddGridss.Contains("<Gridname>") Then
            '    Dim newGridss1 As String
            '    newGridss1 = olddGridss.Replace("<Gridname>", Grid_NameText.Text)
            '    Dim newGridss2 As String
            '    newGridss2 = newGridss1.Replace("<sec>", My.Settings.Sector)
            '    Dim newGridss3 As String
            '    newGridss3 = newGridss2.Replace("<PlayerName>", Player_NameText.Text)

            '    Tab_GridsRichTextBox.Text = newGridss3
            'End If
            'Else
            '    Tab_DiscordRichTextBox.Text = Tab_DiscordRichTextBox2.Text
            '    Tab_BankRichTextBox.Text = Tab_BankRichTextBox2.Text
            '    Tab_AleRichTextBox.Text = Tab_AleRichTextBox2.Text
            '    Tab_BlocksRichTextBox.Text = Tab_BlocksRichTextBox2.Text
            '    Tab_CleanRichTextBox.Text = Tab_CleanRichTextBox2.Text
            '    Tab_SlimeRichTextBox.Text = Tab_SlimeRichTextBox2.Text
            '    Tab_GridsRichTextBox.Text = Tab_GridsRichTextBox2.Text
            'End If

            'Misc tab
            Dim olddMisc As String = Tab_MiscRichTextBox2.Text
            Tab_MiscRichTextBox.Text = Clean(olddMisc)
            '    If olddMisc.Contains("<Gridname>") Then
            '    Dim newMisc1 As String
            '    newMisc1 = olddMisc.Replace("<Gridname>", Grid_NameText.Text)
            '    Dim newMisc2 As String
            '    newMisc2 = newMisc1.Replace("<sec>", My.Settings.Sector)
            '    Dim newMisc3 As String
            '    newMisc3 = newMisc2.Replace("<PlayerName>", Player_NameText.Text)

            '    Tab_MiscRichTextBox.Text = newMisc3
        End If

        'If steam check box empty then uncheck
        If SteamID_Texbox.TextLength = 0 Then
            SteamCheckBox.Checked = False
        End If
        '====================================================REPLACE TAB TEXT END ===================================================


        '====================================================New get sector===================================================
        Try
            Dim sectorlist As String = My.Settings.SectorDrop
            Dim sectorlistarray() As String = Split(sectorlist, ",")
            If Sector_ComboBox.Text = "" Then
                Sector_ComboBox.Text = sectorlistarray(0)
            End If
            '-------------------------------------------
            If My.Settings.SectorDropOpen = False Then
                Sector_ComboBox.Items.Clear()
                Sector_ComboBox.Items.AddRange(sectorlistarray.ToArray)
            Else
            End If
            '-------------------------------------------
            Dim sector As String = Sector_ComboBox.Text
            Dim sectorArray() As String = Split(sector)
            My.Settings.Sector = sectorArray.First
            My.Settings.logserver = sectorArray(2)
        Catch ex As Exception

        End Try
        '====================================================New get sector END ===================================================

        '======================================== New bar 1 & 2 code=========================================
        'Get Steam ID
        If Player_NameText.TextLength > 0 Then
            Dim commandBar1 As String = My.Settings.Bar1Com_Text
            'GetSteamID_TextBox.Text = "tL getsteamid" + " " + Chr(34) + Player_NameText.Text + Chr(34)
            GetSteamID_TextBox.Text = Clean(commandBar1)
        End If

        'GIve Scripter ROLe
        If Player_NameText.TextLength > 0 Then
            If Player_NameText.TextLength > 0 Then
                Dim commandBar2 As String = My.Settings.Bar2Com_Text
                ' GiveScripterRole_TextBox.Text = "s!addscripter" & " " & DiscordID_TextBox.Text & " " & SteamID_Texbox.Text
                GiveScripterRole_TextBox.Text = Clean(commandBar2)
            End If
        End If
        '======================================== New bar 1 & 2 code END=========================================

        '======================================== New bar 3 & 4 code=========================================
        If Player_NameText.TextLength > 0 Then
            Dim commandBar3 As String = My.Settings.Bar3Com_Text
            'SetAdminTextBox.Text = My.Settings.Sector & " admin setrank " & SteamID_Texbox.Text & " 1"
            SetAdminTextBox.Text = Clean(commandBar3)
        End If

        If Player_NameText.TextLength > 0 Then
            If Player_NameText.TextLength > 0 Then
                Dim commandBar4 As String = My.Settings.Bar4Com_Text
                'RenameGridTextBox.Text = My.Settings.Sector & " " & "admin rename" & " " & Chr(34) & Grid_NameText.Text & Chr(34) & " " & Chr(34) & RenameGridNewTextBox.Text & Chr(34)
                RenameGridTextBox.Text = Clean(commandBar4)
            End If
        End If
        '======================================== New bar 3 & 4 code END=========================================

        '==================================== New BAR 5 Code====================================================
        'Created two new fuctions to do the brute work for the others see nexuscommand and clean possibly a clean2 for steam ID 
        Dim Hangar As String = My.Settings.Bar5List_Text
        Dim HangarArray() As String = Split(Hangar, ",")
        If HangarComboBox.Text = "" Then
            HangarComboBox.Text = HangarArray(0)
        End If
        If My.Settings.Bar5DropOpen = False Then
            My.Settings.Hangarchoice = nexuscommand(My.Settings.Bar5List_Text, My.Settings.Bar5Value_Text, HangarComboBox.Text)

            'hangar List
            If Player_NameText.TextLength > 0 Then
                If My.Settings.Hangarchoice = Nothing Then
                Else
                    HangarNameTextBox.Text = Clean(My.Settings.Hangarchoice)
                End If
            End If
            HangarComboBox.Items.Clear()
            HangarComboBox.Items.AddRange(HangarArray.ToArray)
        End If
        '==================================== New BAR 5 COde end====================================================

        '============================================== NEW BAR 6 CODE =============================================
        Dim Player As String = My.Settings.Bar6List_Text
        Dim PlayerArray() As String = Split(Player, ",")
        If PlayerEComboBox.Text = "" Then
            PlayerEComboBox.Text = PlayerArray(0)
        End If
        If My.Settings.Bar6DropOpen = False Then
            My.Settings.Playerchoice = nexuscommand(My.Settings.Bar6List_Text, My.Settings.Bar6Value_Text, PlayerEComboBox.Text)

            If Player_NameText.TextLength > 0 Then
                If My.Settings.Playerchoice = Nothing Then
                Else
                    PlayerEnameTextBox.Text = Clean(My.Settings.Playerchoice)
                End If
            End If

            PlayerEComboBox.Items.Clear()
            PlayerEComboBox.Items.AddRange(PlayerArray.ToArray)
        End If
        '============================================== NEW BAR 6 CODE END =======================================================






        '=============================================== SOON TO BE REPLACED BAR 7 ===================================

        Dim Grid As String = My.Settings.Bar7List_Text
        Dim GridArray() As String = Split(Grid, ",")
        If GridEComboBox.Text = "" Then
            GridEComboBox.Text = GridArray(1)
        End If
        If My.Settings.Bar7DropOpen = False Then
            My.Settings.Gridchoice = nexuscommand(My.Settings.Bar7List_Text, My.Settings.Bar7Value_Text, GridEComboBox.Text)

            If Player_NameText.TextLength > 0 Then
                If My.Settings.Gridchoice = Nothing Then
                Else
                    GridEnameTextBox.Text = Clean(My.Settings.Gridchoice)
                End If
            End If
            GridEComboBox.Items.Clear()
            GridEComboBox.Items.AddRange(GridArray.ToArray)
        End If

        '=============================================== SOON TO BE REPLACED end bAR 7  ===================================





        '=================================================New Bar 8 Code =================================================
        Dim COMMON As String = My.Settings.Bar8List_Text
        Dim COMMONArray() As String = Split(COMMON, ",")
        If CommonComboBox.Text = "" Then
            CommonComboBox.Text = COMMONArray(0)
        End If
        If My.Settings.Bar8DropOpen = False Then
            My.Settings.Customchoice = nexuscommand(My.Settings.Bar8List_Text, My.Settings.Bar8Value_Text, CommonComboBox.Text)

            If Player_NameText.TextLength > 0 Then
                If My.Settings.Customchoice = Nothing Then
                Else
                    CommonTextBox.Text = Clean(My.Settings.Customchoice)
                End If
            End If
            CommonComboBox.Items.Clear()
            CommonComboBox.Items.AddRange(COMMONArray.ToArray)
        End If
        '=================================================New Bar 8 Code  end=================================================



        '=============================================== bAR 9 CODE TO BE REPLACED ==================================================


        Dim Bar9 As String = My.Settings.Bar9List_Text
        Dim Bar9Array() As String = Split(Bar9, ",")
        If Log_TypeComboBox.Text = "" Then
            Log_TypeComboBox.Text = Bar9Array(0)
        End If
        If My.Settings.Bar9DropOpen = False Then
            My.Settings.Logchoice = nexuscommand(My.Settings.Bar9List_Text, My.Settings.Bar9Value_Text, Log_TypeComboBox.Text)

            If Player_NameText.TextLength > 0 Then
                If My.Settings.Logchoice = Nothing Then
                Else
                    ServerLogTextBox.Text = Clean(My.Settings.Logchoice)
                End If
            End If
            Log_TypeComboBox.Items.Clear()
            Log_TypeComboBox.Items.AddRange(Bar9Array.ToArray)
        End If
        '=============================================== bAR 9 CODE TO BE REPLACED end ==================================================





        '=============================================== bAR 10 CODE ====================================================================
        'ListGrid

        If Player_NameText.TextLength > 0 Then
            If SteamCheckBox.Checked = True Then
                If SteamID_Texbox.TextLength > 0 Then
                    ListGrid_PVE_NameTextBox.Text = My.Settings.Sector & " " & "listgridsowner" & " " & SteamID_Texbox.Text
                End If
            Else
                If Player_NameText.TextLength > 0 Then
                    ListGrid_PVE_NameTextBox.Text = My.Settings.Sector & " " & "listgridsowner" & " " & Chr(34) & Player_NameText.Text & Chr(34)
                End If
            End If
        End If
        '=============================================== bAR 10 CODE end ====================================================================


        '=============================================== bAR 11 CODE ====================================================================

        'ListGrid backup
        If SteamCheckBox.Checked = True Then
            If ListGridBackupComboBox.Text = "" Then
                If SteamID_Texbox.TextLength > 0 Then
                    ListGridBackupNameTextBox.Text = My.Settings.Sector & " " & "gridbackup" & " " & "list" & " " & SteamID_Texbox.Text
                End If
            Else
                If SteamID_Texbox.TextLength > 0 Then
                    ListGridBackupNameTextBox.Text = My.Settings.Sector & " " & "gridbackup" & " " & "list" & " " & SteamID_Texbox.Text & " " & My.Settings.ListGrid
                End If
            End If
        Else
            If ListGridBackupComboBox.Text = "" Then
                If Player_NameText.TextLength > 0 Then
                    ListGridBackupNameTextBox.Text = My.Settings.Sector & " " & "gridbackup" & " " & "list" & " " & Chr(34) & Player_NameText.Text & Chr(34)
                End If
            Else
                If Player_NameText.TextLength > 0 Then
                    ListGridBackupNameTextBox.Text = My.Settings.Sector & " " & "gridbackup" & " " & "list" & " " & Chr(34) & Player_NameText.Text & Chr(34) & " " & My.Settings.ListGrid
                End If
            End If
        End If
        '=============================================== bAR 11 CODE end ====================================================================



        '=============================================== bAR 12 CODE ====================================================================
        'Grid Restore
        If SteamCheckBox.Checked = True Then
            If RestoreNumoneComboBox.Text = "" Then
            Else
                If SteamID_Texbox.TextLength > 0 Then
                    GridRestoreNameTextBox.Text = My.Settings.Sector & " " & "gridbackup" & " " & "restore" & " " & SteamID_Texbox.Text & " " & My.Settings.RestoreNumone & " " & My.Settings.RestoreNumtwo & " " & My.Settings.RestoreQ & " " & My.Settings.RestoreForce
                End If
            End If
        Else
            If RestoreNumoneComboBox.Text = "" Then
            Else
                If Player_NameText.TextLength > 0 Then
                    GridRestoreNameTextBox.Text = My.Settings.Sector & " " & "gridbackup" & " " & "restore" & " " & Chr(34) & Player_NameText.Text & Chr(34) & " " & My.Settings.RestoreNumone & " " & My.Settings.RestoreNumtwo & " " & My.Settings.RestoreQ & " " & My.Settings.RestoreForce
                End If
            End If
        End If


        '=============================================== bAR 12 CODE end ====================================================================




        '====================================================== bAR 13 NO REPLACE =======================================================

        'Common command - giveitem
        If Player_NameText.TextLength > 0 Then
            GiveItem_TextBox.Text = My.Settings.Sector & " giveitem " & Chr(34) & Player_NameText.Text & Chr(34) & " Component " & Component_ComboBox.Text & " " & ComponentAmount_TextBox.Text & " true"
        End If
        '====================================================== bAR 13 NO REPLACE =======================================================

        'uh center textcent ==============NOT SURE i LIKE THIS 10-10-22
        Tab_DiscordRichTextBox.SelectionStart = 0
        Tab_DiscordRichTextBox.SelectionLength = Len(Tab_DiscordRichTextBox.Text)
        Tab_DiscordRichTextBox.SelectionAlignment = HorizontalAlignment.Center

        Tab_BankRichTextBox.SelectionStart = 0
        Tab_BankRichTextBox.SelectionLength = Len(Tab_BankRichTextBox.Text)
        Tab_BankRichTextBox.SelectionAlignment = HorizontalAlignment.Center

        Tab_AleRichTextBox.SelectionStart = 0
        Tab_AleRichTextBox.SelectionLength = Len(Tab_AleRichTextBox.Text)
        Tab_AleRichTextBox.SelectionAlignment = HorizontalAlignment.Center

        Tab_NexusRichTextBox.SelectionStart = 0
        Tab_NexusRichTextBox.SelectionLength = Len(Tab_NexusRichTextBox.Text)
        Tab_NexusRichTextBox.SelectionAlignment = HorizontalAlignment.Center

        Tab_HangarRichTextBox.SelectionStart = 0
        Tab_HangarRichTextBox.SelectionLength = Len(Tab_HangarRichTextBox.Text)
        Tab_HangarRichTextBox.SelectionAlignment = HorizontalAlignment.Center

        Tab_BlocksRichTextBox.SelectionStart = 0
        Tab_BlocksRichTextBox.SelectionLength = Len(Tab_BlocksRichTextBox.Text)
        Tab_BlocksRichTextBox.SelectionAlignment = HorizontalAlignment.Center

        Tab_CleanRichTextBox.SelectionStart = 0
        Tab_CleanRichTextBox.SelectionLength = Len(Tab_CleanRichTextBox.Text)
        Tab_CleanRichTextBox.SelectionAlignment = HorizontalAlignment.Center

        Tab_GridsRichTextBox.SelectionStart = 0
        Tab_GridsRichTextBox.SelectionLength = Len(Tab_GridsRichTextBox.Text)
        Tab_GridsRichTextBox.SelectionAlignment = HorizontalAlignment.Center

        Tab_SlimeRichTextBox.SelectionStart = 0
        Tab_SlimeRichTextBox.SelectionLength = Len(Tab_SlimeRichTextBox.Text)
        Tab_SlimeRichTextBox.SelectionAlignment = HorizontalAlignment.Center

        Tab_MiscRichTextBox.SelectionStart = 0
        Tab_MiscRichTextBox.SelectionLength = Len(Tab_MiscRichTextBox.Text)
        Tab_MiscRichTextBox.SelectionAlignment = HorizontalAlignment.Center




    End Sub

    Private Sub Scriptertext_Button_Click(sender As Object, e As EventArgs) Handles Scriptertext_Button.Click
        Clipboard.SetText(My.Settings.ScripterText)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GiveScripterButton.Click
        If GiveScripterRole_TextBox.TextLength > 0 Then Clipboard.SetText(GiveScripterRole_TextBox.Text)
        Dim text As String
        text = GiveScripterRole_TextBox.Text

        If AutoSend.Checked = True Then
            messageField.Text = text
            Send.PerformClick()
        End If
    End Sub

    Private Sub ListGrid_PVE_NameButton_Click(sender As Object, e As EventArgs) Handles ListGrid_PVE_NameButton.Click
        If ListGrid_PVE_NameTextBox.TextLength > 0 Then Clipboard.SetText(ListGrid_PVE_NameTextBox.Text)
        Dim text As String
        text = ListGrid_PVE_NameTextBox.Text

        If AutoSend.Checked = True Then
            messageField.Text = text
            Send.PerformClick()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles ListGridBackupNameButton.Click
        If ListGridBackupNameTextBox.TextLength > 0 Then Clipboard.SetText(ListGridBackupNameTextBox.Text)
        Dim text As String
        text = ListGridBackupNameTextBox.Text

        If AutoSend.Checked = True Then
            messageField.Text = text
            Send.PerformClick()
        End If
    End Sub

    Private Sub MainWindow_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        My.Settings.ListGrid = ListGridBackupComboBox.Text
        Update_Button.PerformClick()
    End Sub

    Private Sub HangarNameButton_Click(sender As Object, e As EventArgs) Handles HangarNameButton.Click
        If HangarNameTextBox.TextLength > 0 Then Clipboard.SetText(HangarNameTextBox.Text)
        Dim text As String
        text = HangarNameTextBox.Text

        If AutoSend.Checked = True Then
            messageField.Text = text
            Send.PerformClick()
        End If

    End Sub

    Private Sub PlayerEnameButton_Click(sender As Object, e As EventArgs) Handles PlayerEnameButton.Click
        If PlayerEnameTextBox.TextLength > 0 Then Clipboard.SetText(PlayerEnameTextBox.Text)
        Dim text As String
        text = PlayerEnameTextBox.Text

        If AutoSend.Checked = True Then
            messageField.Text = text
            Send.PerformClick()
        End If
    End Sub

    Private Sub GridEnameButton_Click(sender As Object, e As EventArgs) Handles GridEnameButton.Click
        If GridEnameTextBox.TextLength > 0 Then Clipboard.SetText(GridEnameTextBox.Text)
        Dim text As String
        text = GridEnameTextBox.Text

        If AutoSend.Checked = True Then
            messageField.Text = text
            Send.PerformClick()
        End If
    End Sub

    Private Sub RenameGridButton_Click(sender As Object, e As EventArgs) Handles RenameGridButton.Click
        If RenameGridTextBox.TextLength > 0 Then Clipboard.SetText(RenameGridTextBox.Text)
        Dim text As String
        text = RenameGridTextBox.Text

        If AutoSend.Checked = True Then
            messageField.Text = text
            Send.PerformClick()
        End If
    End Sub

    Private Sub ServerLogButton_Click(sender As Object, e As EventArgs) Handles ServerLogButton.Click
        If ServerLogTextBox.TextLength > 0 Then Clipboard.SetText(ServerLogTextBox.Text)
        Dim text As String
        text = ServerLogTextBox.Text

        If AutoSend.Checked = True Then
            messageField.Text = text
            Send.PerformClick()
        End If
    End Sub

    Private Sub GridRestoreNameButton_Click(sender As Object, e As EventArgs) Handles GridRestoreNameButton.Click
        If GridRestoreNameTextBox.TextLength > 0 Then Clipboard.SetText(GridRestoreNameTextBox.Text)
        Dim text As String
        text = GridRestoreNameTextBox.Text

        If AutoSend.Checked = True Then
            messageField.Text = text
            Send.PerformClick()
        End If
    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        Player_NameText.Text = ""
        Grid_NameText.Text = ""
        RenameGridNewTextBox.Text = ""
        DiscordID_TextBox.Text = ""
        Sector_ComboBox.Text = "PVE - Any server that is Avalon (Planets Space KotH's)"
        SteamID_Texbox.Text = ""
        GetSteamID_TextBox.Text = ""
        GiveScripterRole_TextBox.Text = ""
        HangarRemoveComboBox.Text = ""
        HangarNameTextBox.Text = ""
        PlayerEnameTextBox.Text = ""
        GridEnameTextBox.Text = ""
        RenameGridTextBox.Text = ""
        ServerLogTextBox.Text = ""
        ListGrid_PVE_NameTextBox.Text = ""
        ListGridBackupNameTextBox.Text = ""
        RestoreNumoneComboBox.Text = "1"
        RestoreNumtwoComboBox.Text = "1"
        GridRestoreNameTextBox.Text = ""
        My.Settings.Sector = "PVE - Any server that is Avalon (Planets Space KotH's)"
        My.Settings.ListGrid = ""
        My.Settings.RestoreNumone = ""
        My.Settings.RestoreNumtwo = ""
        My.Settings.RestoreQ = ""
        My.Settings.RestoreForce = ""
        My.Settings.Hangar = ""
        My.Settings.HangarRemove = ""
        My.Settings.PlayerE = ""
        My.Settings.GridE = ""
        My.Settings.LogType = ""
        Dim formattedDate As String = Date.Today.ToString("dd")
        Dim formattedDate2 As String = Date.Today.ToString("MM")
        Month_ComboBox.Text = formattedDate2
        Day_ComboBox.Text = formattedDate

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim webAddress As String = "https://discord.com/channels/622173015404314664/663795269795840030/663795811313909760"
        Process.Start(webAddress)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim webAddress As String = "https://discord.com/channels/622173015404314664/770361625617367041/939469433234157578"
        Process.Start(webAddress)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim webAddress As String = "https://discord.com/channels/622173015404314664/"
        Process.Start(webAddress)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim webAddress As String = "https://discord.com/channels/622173015404314664/948614783106711695"
        Process.Start(webAddress)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Update_Button.PerformClick()
    End Sub

    Private Sub SteamCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SteamCheckBox.CheckedChanged

    End Sub

    Private Sub StopUpdate_Button_Click(sender As Object, e As EventArgs) Handles StopUpdate_Button.Click
        Timer1.Stop()
        Timer1.Enabled = False
        statusTextBox.BackColor = Color.FromArgb(255, 0, 0)

        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label22.Visible = True

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles WarningLabel.Click

    End Sub

    Private Sub Tab_DiscordRichTextBox_MouseHover(sender As Object, e As EventArgs) Handles Tab_DiscordRichTextBox.MouseHover
        StopUpdate_Button.PerformClick()
    End Sub

    Private Sub Tab_DiscordRichTextBox_MouseLeave(sender As Object, e As EventArgs) Handles Tab_DiscordRichTextBox.MouseLeave
        Pause(1000)
        Sector_ComboBox.Select()
        Update_Button.PerformClick()
    End Sub

    Private Sub Tab_BankRichTextBox_MouseHover(sender As Object, e As EventArgs) Handles Tab_BankRichTextBox.MouseHover
        StopUpdate_Button.PerformClick()
    End Sub

    Private Sub Tab_BankRichTextBox_MouseLeave(sender As Object, e As EventArgs) Handles Tab_BankRichTextBox.MouseLeave
        Pause(1000)
        Sector_ComboBox.Select()
        Update_Button.PerformClick()
    End Sub

    Private Sub Tab_AleRichTextBox_MouseHover(sender As Object, e As EventArgs) Handles Tab_AleRichTextBox.MouseHover
        StopUpdate_Button.PerformClick()
    End Sub

    Private Sub Tab_AleRichTextBox_MouseLeave(sender As Object, e As EventArgs) Handles Tab_AleRichTextBox.MouseLeave
        Pause(1000)
        Sector_ComboBox.Select()
        Update_Button.PerformClick()
    End Sub

    Private Sub Tab_HangarRichTextBox_MouseHover(sender As Object, e As EventArgs) Handles Tab_HangarRichTextBox.MouseHover
        StopUpdate_Button.PerformClick()
    End Sub

    Private Sub Tab_HangarRichTextBox_MouseLeave(sender As Object, e As EventArgs) Handles Tab_HangarRichTextBox.MouseLeave
        Pause(1000)
        Sector_ComboBox.Select()
        Update_Button.PerformClick()
    End Sub

    Private Sub Tab_BlocksRichTextBox_MouseHover(sender As Object, e As EventArgs) Handles Tab_BlocksRichTextBox.MouseHover
        StopUpdate_Button.PerformClick()
    End Sub

    Private Sub Tab_BlocksRichTextBox_MouseLeave(sender As Object, e As EventArgs) Handles Tab_BlocksRichTextBox.MouseLeave
        Pause(1000)
        Sector_ComboBox.Select()
        Update_Button.PerformClick()
    End Sub

    Private Sub Tab_CleanRichTextBox_MouseHover(sender As Object, e As EventArgs) Handles Tab_CleanRichTextBox.MouseHover
        StopUpdate_Button.PerformClick()
    End Sub

    Private Sub Tab_CleanRichTextBox_MouseLeave(sender As Object, e As EventArgs) Handles Tab_CleanRichTextBox.MouseLeave
        Pause(1000)
        Sector_ComboBox.Select()
        Update_Button.PerformClick()
    End Sub

    Private Sub Tab_GridsRichTextBox_MouseHover(sender As Object, e As EventArgs) Handles Tab_GridsRichTextBox.MouseHover
        StopUpdate_Button.PerformClick()
    End Sub

    Private Sub Tab_GridsRichTextBox_MouseLeave(sender As Object, e As EventArgs) Handles Tab_GridsRichTextBox.MouseLeave
        Pause(1000)
        Sector_ComboBox.Select()
        Update_Button.PerformClick()
    End Sub

    Private Sub Tab_SlimeRichTextBox_MouseHover(sender As Object, e As EventArgs) Handles Tab_SlimeRichTextBox.MouseHover
        StopUpdate_Button.PerformClick()
    End Sub

    Private Sub Tab_SlimeRichTextBox_MouseLeave(sender As Object, e As EventArgs) Handles Tab_SlimeRichTextBox.MouseLeave
        Pause(1000)
        Sector_ComboBox.Select()
        Update_Button.PerformClick()
    End Sub

    Private Sub Tab_MiscRichTextBox_MouseHover(sender As Object, e As EventArgs) Handles Tab_MiscRichTextBox.MouseHover
        StopUpdate_Button.PerformClick()
    End Sub

    Private Sub Tab_MiscRichTextBox_MouseLeave(sender As Object, e As EventArgs) Handles Tab_MiscRichTextBox.MouseLeave
        Pause(1000)
        Sector_ComboBox.Select()
        Update_Button.PerformClick()
    End Sub

    Private Sub Tab_NexusRichTextBox_MouseHover(sender As Object, e As EventArgs) Handles Tab_NexusRichTextBox.MouseHover
        StopUpdate_Button.PerformClick()
    End Sub

    Private Sub Tab_NexusRichTextBox_MouseLeave(sender As Object, e As EventArgs) Handles Tab_NexusRichTextBox.MouseLeave
        Pause(1000)
        Sector_ComboBox.Select()
        Update_Button.PerformClick()
    End Sub

    Private Sub SetAdminTextBox_TextChanged(sender As Object, e As EventArgs) Handles SetAdminTextBox.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles SetRankButton.Click
        If SetAdminTextBox.TextLength > 0 Then Clipboard.SetText(SetAdminTextBox.Text)
        Dim text As String
        text = SetAdminTextBox.Text

        If AutoSend.Checked = True Then
            messageField.Text = text
            Send.PerformClick()
        End If
    End Sub

    Private Sub AboutMeToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AboutMeToolStripMenuItem2.Click
        AboutBox1.Show()
    End Sub

    Private Sub Common_copyButton_Click(sender As Object, e As EventArgs) Handles Common_copyButton.Click
        If CommonTextBox.TextLength > 0 Then Clipboard.SetText(CommonTextBox.Text)
        Dim text As String
        text = CommonTextBox.Text

        If AutoSend.Checked = True Then
            messageField.Text = text
            Send.PerformClick()
        End If
    End Sub

    Private Sub GiveItem_CopyButton_Click(sender As Object, e As EventArgs) Handles GiveItem_CopyButton.Click
        If GiveItem_TextBox.TextLength > 0 Then Clipboard.SetText(GiveItem_TextBox.Text)
        Dim text As String
        text = GiveItem_TextBox.Text

        If AutoSend.Checked = True Then
            messageField.Text = text
            Send.PerformClick()
        End If
    End Sub

    Private Sub WeaponsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Weapon_limit_Window.Show()
    End Sub

    Private Sub ProductionToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Production_LimitWindow.Show()
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub ScripterTextToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub
    Sub Pause(ByVal milliseconds As Long)
        If milliseconds <= 0 Then Return
        Dim sw As New Stopwatch()
        sw.Start()
        Dim i As Long = 0
        Do
            If i Mod 50000 = 0 Then ' Check the timer every 50,000th iteration
                sw.Stop()
                If sw.ElapsedMilliseconds >= milliseconds Then
                    Exit Do
                Else
                    sw.Start()
                End If
            End If
            i += 1
        Loop
    End Sub

    Private Sub SectorToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Sector_ComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles Sector_ComboBox.DropDownClosed
        My.Settings.SectorDropOpen = False
    End Sub

    Private Sub Sector_ComboBox_DropDown(sender As Object, e As EventArgs) Handles Sector_ComboBox.DropDown
        My.Settings.SectorDropOpen = True
    End Sub
    '---------------------------------------------------------------------------------------------------
    'discord webhook stuffs
    '---------------------------------------------------------------------------------------------------

    Public pfc As New Text.PrivateFontCollection
    Private Sub ProfilePicLink_TextChanged(sender As Object, e As EventArgs) Handles profilePicLink.TextChanged
        If profilePicLink.Text = "" Then
            profilePic.SizeMode = ImageLayout.Zoom
            Return
        End If
        Try
            Dim tClient As WebClient = New WebClient
            Dim tImage As Bitmap = Image.FromStream(New MemoryStream(tClient.DownloadData(profilePicLink.Text)))
            profilePic.Image = tImage
            profilePic.SizeMode = ImageLayout.Zoom
        Catch
            profilePic.SizeMode = ImageLayout.Zoom
        End Try
    End Sub

    Private Sub Send_Click(sender As Object, e As EventArgs) Handles Send.Click
        Dim dcWeb As dWebHook = New dWebHook
        If username.Text = "Webhook" Then
            dcWeb.UserName = "test"
        Else
            dcWeb.UserName = My.Settings.InGameName
        End If
        dcWeb.WebHook = webhookLink.Text
        dcWeb.ProfilePicture = profilePicLink.Text
        dcWeb.SendMessage(messageField.Text)
    End Sub

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged
        If username.Text = "" Then
            username.Text = "Webhook"
        End If
    End Sub

    Private Sub DiscordWebHookToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Splash.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        My.Settings.InGameName = ""
        Login.Show()
        Me.Close()

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles Common.Click

    End Sub

    Private Sub HangarComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles HangarComboBox.DropDownClosed
        My.Settings.Bar5DropOpen = False
    End Sub

    Private Sub HangarComboBox_DropDown(sender As Object, e As EventArgs) Handles HangarComboBox.DropDown
        My.Settings.Bar5DropOpen = True
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click

    End Sub

    Private Sub PlayerEComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles PlayerEComboBox.DropDownClosed
        My.Settings.Bar6DropOpen = False
    End Sub
    Private Sub PlayerEComboBox_DropDown(sender As Object, e As EventArgs) Handles PlayerEComboBox.DropDown
        My.Settings.Bar6DropOpen = True
    End Sub

    Private Sub GridEComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles GridEComboBox.DropDownClosed
        My.Settings.Bar7DropOpen = False
    End Sub

    Private Sub GridEComboBox_DropDown(sender As Object, e As EventArgs) Handles GridEComboBox.DropDown
        My.Settings.Bar7DropOpen = True
    End Sub

    Private Sub CommonComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles CommonComboBox.DropDownClosed
        My.Settings.Bar8DropOpen = False
    End Sub

    Private Sub CommonComboBox_DropDown(sender As Object, e As EventArgs) Handles CommonComboBox.DropDown
        My.Settings.Bar8DropOpen = True
    End Sub

    Private Sub Log_TypeComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles Log_TypeComboBox.DropDownClosed
        My.Settings.Bar9DropOpen = False
    End Sub

    Private Sub Log_TypeComboBox_DropDown(sender As Object, e As EventArgs) Handles Log_TypeComboBox.DropDown
        My.Settings.Bar9DropOpen = True
    End Sub

    Private Sub CommandSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommandSettingsToolStripMenuItem.Click
        SettingsWindow.Show()
    End Sub

    Private Sub SectorSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectorSettingsToolStripMenuItem.Click
        Sector.Show()
    End Sub

    Private Sub CopyTextButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyTextButtonToolStripMenuItem.Click
        Scripter_Text.Show()
    End Sub

    Private Sub AutoSend_CheckedChanged(sender As Object, e As EventArgs) Handles AutoSend.CheckedChanged

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Dim colordig As New ColorDialog
        colordig.ShowDialog()
        My.Settings.BackColor = colordig.Color
        Me.BackColor = colordig.Color

        TabControl1.TabPages(0).BackColor = My.Settings.BackColor
        TabControl1.TabPages(1).BackColor = My.Settings.BackColor
        TabControl1.TabPages(2).BackColor = My.Settings.BackColor
        TabControl1.TabPages(3).BackColor = My.Settings.BackColor
        TabControl1.TabPages(4).BackColor = My.Settings.BackColor
        TabControl1.TabPages(5).BackColor = My.Settings.BackColor
        TabControl1.TabPages(6).BackColor = My.Settings.BackColor
        TabControl1.TabPages(7).BackColor = My.Settings.BackColor
        TabControl1.TabPages(8).BackColor = My.Settings.BackColor
        TabControl1.TabPages(9).BackColor = My.Settings.BackColor
        TabControl1.TabPages(10).BackColor = My.Settings.BackColor

    End Sub

    'Private Sub WebhookLink_TextChanged(sender As Object, e As EventArgs) Handles webhookLink.TextChanged
    'If autoFetch.Checked = True Then
    'fetchWHinfo(1, 1)
    'End If
    'End Sub
    'Sub fetchWHinfo(uCheck As String, pCheck As String)
    'Dim request As HttpWebRequest
    'Dim response As HttpWebResponse = Nothing
    'Dim reader As StreamReader
    'Try
    'request = DirectCast(WebRequest.Create(webhookLink.Text), HttpWebRequest)

    'response = DirectCast(request.GetResponse(), HttpWebResponse)
    'reader = New StreamReader(response.GetResponseStream())
    'Dim rawresp As String = reader.ReadToEnd()
    'Dim jss As New JavaScriptSerializer()
    'Dim dict As Dictionary(Of String, String) = jss.Deserialize(Of Dictionary(Of String, String))(rawresp)
    '
    'If uCheck = 1 Then
    'username.Text = dict("name")
    'End If
    'If pCheck = 1 Then
    'profilePicLink.Text = "https://cdn.discordapp.com/avatars/" + dict("id") + "/" + dict("avatar") + ".png?size=128"
    'End If
    'Catch ex As Exception
    'End Try
    'End Sub
End Class

Public Class dWebHook
    Implements IDisposable

    Private ReadOnly client As WebClient
    Private Shared discordValues As NameValueCollection = New NameValueCollection()
    Public Property WebHook As String
    Public Property UserName As String
    Public Property ProfilePicture As String

    Public Sub New()
        client = New WebClient()
    End Sub

    Public Sub SendMessage(ByVal msgSend As String)
        If msgSend = "" Or WebHook = "" Then
            MsgBox("The webhook link and message are required!(did you forget to add the webhook on the login page?)", vbCritical + vbOKOnly)
            Return
        End If
        discordValues.Add("username", UserName)
        discordValues.Add("avatar_url", ProfilePicture)
        discordValues.Add("content", msgSend)
        Try
            client.UploadValues(WebHook, discordValues)
        Catch
            MsgBox("Unable to send message!" & vbNewLine & vbNewLine & "This issue can be caused by one or more of the following:" & vbNewLine & "- The webhook link is incorrect." & vbNewLine & "- There is no connection to the Internet." & vbNewLine & "- Another program or firewall is blocking this application's access to the Internet." & vbNewLine & "- Discord's servers are down." & vbNewLine & vbNewLine & "If you believe everything is in working order and this problem persists, please submit an issue on this program's Github page.", vbCritical + vbOKOnly, "Discord Webhook Announcer")
        End Try
        discordValues.Remove("username")
        discordValues.Remove("avatar_url")
        discordValues.Remove("content")
    End Sub

    Public Sub Dispose()
        client.Dispose()
    End Sub

    Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
        DirectCast(client, IDisposable).Dispose()
    End Sub

End Class
