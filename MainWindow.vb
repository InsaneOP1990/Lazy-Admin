Public Class MainWindow
    Private Sub Copy_SteamID_Button_Click(sender As Object, e As EventArgs) Handles Copy_SteamID_Button.Click
        If GetSteamID_TextBox.TextLength > 0 Then Clipboard.SetText(GetSteamID_TextBox.Text)
    End Sub

    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click, MyBase.Enter
        'Settings updates
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

        'get sector
        If Sector_ComboBox.Text = "" Then
            My.Settings.Sector = ""
            MsgBox("pick a sector", vbExclamation, "Warning")
        Else
            If Sector_ComboBox.Text = "ALL - All servers except the lobby. Senior Staff / Admin Only please" Then
                My.Settings.Sector = "ALL"
                My.Settings.logserver = "!!ERROR!!!"
            End If
            If Sector_ComboBox.Text = "PVE - Any server that is Avalon (Planets Space KotH's)" Then
                My.Settings.Sector = "PVE"
                My.Settings.logserver = "!!ERROR!!!"
            End If
            If Sector_ComboBox.Text = "PVP - Any server that is Dead Worlds (Planets Space KotH's)" Then
                My.Settings.Sector = "PVP"
                My.Settings.logserver = "!!ERROR!!!"
            End If
            If Sector_ComboBox.Text = "NPC - Both Roach servers" Then
                My.Settings.Sector = "NPC"
                My.Settings.logserver = "!!ERROR!!!"
            End If
            If Sector_ComboBox.Text = "tL - The Lobby server - Lobby Sector." Then
                My.Settings.Sector = "tL"
                My.Settings.logserver = "1"
            End If
            If Sector_ComboBox.Text = "gS - Deep Space / General Sector or the everywhere else." Then
                My.Settings.Sector = "gS"
                My.Settings.logserver = "2"
            End If
            If Sector_ComboBox.Text = "aS - Avalon Space Sector" Then
                My.Settings.Sector = "aS"
                My.Settings.logserver = "10"
            End If
            If Sector_ComboBox.Text = "aS1 -Avalon Space Inner 1 Dover Space" Then
                My.Settings.Sector = "aS1"
                My.Settings.logserver = "12"
            End If
            If Sector_ComboBox.Text = "aS2 - Avalon Space Inner 2 IK006 Space" Then
                My.Settings.Sector = "aS2"
                My.Settings.logserver = "13"
            End If
            If Sector_ComboBox.Text = "aS3 - Avalon Space Inner 3 Pelmuth Space" Then
                My.Settings.Sector = "aS3"
                My.Settings.logserver = "14"
            End If
            If Sector_ComboBox.Text = "dS - Dead Worlds Space Sector" Then
                My.Settings.Sector = "dS"
                My.Settings.logserver = "20"
            End If
            If Sector_ComboBox.Text = "aDV - Avalon Dover Planet Sector" Then
                My.Settings.Sector = "aDV"
                My.Settings.logserver = "11"
            End If
            If Sector_ComboBox.Text = "aIK  - Avalon IK006 Planet Sector" Then
                My.Settings.Sector = "aIK"
                My.Settings.logserver = "15"
            End If
            If Sector_ComboBox.Text = "aPL - Avalon Pelmuth Planet Sector" Then
                My.Settings.Sector = "aPL"
                My.Settings.logserver = "17"
            End If
            If Sector_ComboBox.Text = "dP - Dead Worlds Planets Sector" Then
                My.Settings.Sector = "dP"
                My.Settings.logserver = "21"
            End If
            If Sector_ComboBox.Text = "dK - Dead Worlds Space KotH Sector" Then
                My.Settings.Sector = "dK"
                My.Settings.logserver = "22"
            End If
            If Sector_ComboBox.Text = "cK - Crypt KotH Sector" Then
                My.Settings.Sector = "cK"
                My.Settings.logserver = "23"
            End If
            If Sector_ComboBox.Text = "rI - Roach Inner Sector" Then
                My.Settings.Sector = "rI"
                My.Settings.logserver = "40"
            End If
            If Sector_ComboBox.Text = "rO - Roach Outter Sector" Then
                My.Settings.Sector = "rO"
                My.Settings.logserver = "41"
            End If
            If Sector_ComboBox.Text = "tR - Transit Server between Roach and Avalon / DW " Then
                My.Settings.Sector = "tR"
                My.Settings.logserver = "50"
            End If
            If Sector_ComboBox.Text = "wS - Waterloo Space Sector" Then
                My.Settings.Sector = "wS"
                My.Settings.logserver = "51"
            End If
            If Sector_ComboBox.Text = "wP - Waterloo Planet Sector" Then
                My.Settings.Sector = "wP"
                My.Settings.logserver = "52"
            End If
            If Sector_ComboBox.Text = "sL - Special Lobby bot for scripting use and other powers. (Dont put a space after the prefix here)" Then
                My.Settings.Sector = "sL"
                My.Settings.logserver = "!!ERROR!!!"
            End If
            If Sector_ComboBox.Text = "tK - The Space KotH Bot used by scripts to reset KotH" Then
                My.Settings.Sector = "tK"
                My.Settings.logserver = "!!ERROR!!!"
            End If
            If Sector_ComboBox.Text = "tC - The Crypt KotH Bot used by scripts to reset KotH" Then
                My.Settings.Sector = "tC"
                My.Settings.logserver = "!!ERROR!!!"
            End If
            If Sector_ComboBox.Text = "tS - Transit Server for use with Tech Bot " Then
                My.Settings.Sector = "tS"
                My.Settings.logserver = "!!ERROR!!!"
            End If
        End If

        'Get Steam ID
        If Player_NameText.TextLength > 0 Then
            GetSteamID_TextBox.Text = "tL getsteamid" + " " + Chr(34) + Player_NameText.Text + Chr(34)
        End If

        'GIve Scripter ROLe
        If DiscordID_TextBox.TextLength > 0 Then
            If SteamID_Texbox.TextLength > 0 Then
                GiveScripterRole_TextBox.Text = "s!addscripter" & " " & DiscordID_TextBox.Text & " " & SteamID_Texbox.Text
            End If
        End If

        'ListGrid
        If Player_NameText.TextLength > 0 Then
            If SteamID_Texbox.TextLength > 0 Then
                ListGrid_PVE_SteamIDTextBox.Text = My.Settings.Sector & " " & "listgridsowner" & " " & SteamID_Texbox.Text
            End If
            If Player_NameText.TextLength > 0 Then
                ListGrid_PVE_NameTextBox.Text = My.Settings.Sector & " " & "listgridsowner" & " " & Chr(34) & Player_NameText.Text & Chr(34)
            End If
        End If

        'ListGrid backup
        If ListGridBackupComboBox.Text = "" Then
            If SteamID_Texbox.TextLength > 0 Then
                ListGridBackupSteamTextBox.Text = My.Settings.Sector & " " & "gridbackup" & " " & "list" & " " & SteamID_Texbox.Text
            End If
            If Player_NameText.TextLength > 0 Then
                ListGridBackupNameTextBox.Text = My.Settings.Sector & " " & "gridbackup" & " " & "list" & " " & Chr(34) & Player_NameText.Text & Chr(34)
            End If
        Else
            If SteamID_Texbox.TextLength > 0 Then
                ListGridBackupSteamTextBox.Text = My.Settings.Sector & " " & "gridbackup" & " " & "list" & " " & SteamID_Texbox.Text & " " & My.Settings.ListGrid
            End If
            If Player_NameText.TextLength > 0 Then
                ListGridBackupNameTextBox.Text = My.Settings.Sector & " " & "gridbackup" & " " & "list" & " " & Chr(34) & Player_NameText.Text & Chr(34) & " " & My.Settings.ListGrid
            End If
        End If

        'Grid Restore
        If RestoreNumoneComboBox.Text = "" Then
        Else
            If SteamID_Texbox.TextLength > 0 Then
                GridRestoreSteamTextBox.Text = My.Settings.Sector & " " & "gridbackup" & " " & "restore" & " " & SteamID_Texbox.Text & " " & My.Settings.RestoreNumone & " " & My.Settings.RestoreNumtwo & " " & My.Settings.RestoreQ & " " & My.Settings.RestoreForce
            End If
            If Player_NameText.TextLength > 0 Then
                GridRestoreNameTextBox.Text = My.Settings.Sector & " " & "gridbackup" & " " & "restore" & " " & Chr(34) & Player_NameText.Text & Chr(34) & " " & My.Settings.RestoreNumone & " " & My.Settings.RestoreNumtwo & " " & My.Settings.RestoreQ & " " & My.Settings.RestoreForce
            End If
        End If

        'hangar List
        If HangarComboBox.Text = "list" Then
            If SteamID_Texbox.TextLength > 0 Then
                HangarSteamIDTextBox.Text = My.Settings.Sector & " " & "hm list" & " " & SteamID_Texbox.Text
            End If
            If Player_NameText.TextLength > 0 Then
                HangarNameTextBox.Text = My.Settings.Sector & " " & "hm list" & " " & Chr(34) & Player_NameText.Text & Chr(34)
            End If
        End If

        'hangar save
        If HangarComboBox.Text = "save" Then
            If Grid_NameText.TextLength > 0 Then
                HangarNameTextBox.Text = My.Settings.Sector & " " & "hm save" & " " & Chr(34) & Grid_NameText.Text & Chr(34)
                HangarSteamIDTextBox.Text = ""
            End If
        End If

        'hangar remove
        If HangarComboBox.Text = "remove" Then
            If HangarRemoveComboBox.Text = "" Then
            Else
                If SteamID_Texbox.TextLength > 0 Then
                    HangarSteamIDTextBox.Text = My.Settings.Sector & " " & "hm remove" & " " & SteamID_Texbox.Text & " " & My.Settings.HangarRemove
                End If
                If Player_NameText.TextLength > 0 Then
                    HangarNameTextBox.Text = My.Settings.Sector & " " & "hm remove" & " " & Chr(34) & Player_NameText.Text & Chr(34) & " " & My.Settings.HangarRemove
                End If
            End If
        End If

        'hangar load
        If HangarComboBox.Text = "load" Then
            If HangarRemoveComboBox.Text = "" Then
            Else
                If SteamID_Texbox.TextLength > 0 Then
                    HangarSteamIDTextBox.Text = My.Settings.Sector & " " & "hm load" & " " & SteamID_Texbox.Text & " " & My.Settings.HangarRemove
                End If
                If Player_NameText.TextLength > 0 Then
                    HangarNameTextBox.Text = My.Settings.Sector & " " & "hm load" & " " & Chr(34) & Player_NameText.Text & Chr(34) & " " & My.Settings.HangarRemove
                End If
            End If
        End If

        'hangar info
        If HangarComboBox.Text = "info" Then
            If SteamID_Texbox.TextLength > 0 Then
                HangarSteamIDTextBox.Text = My.Settings.Sector & " " & "hm info" & " " & SteamID_Texbox.Text & " " & My.Settings.HangarRemove
            End If
            If Player_NameText.TextLength > 0 Then
                HangarNameTextBox.Text = My.Settings.Sector & " " & "hm info" & " " & Chr(34) & Player_NameText.Text & Chr(34) & " " & My.Settings.HangarRemove
            End If
        End If

        'Player Entities eject
        If PlayerEComboBox.Text = "eject" Then
            If SteamID_Texbox.TextLength > 0 Then
                PlayerEsteamTextBox.Text = My.Settings.Sector & " " & "entities eject" & " " & SteamID_Texbox.Text
            End If
            If Player_NameText.TextLength > 0 Then
                PlayerEnameTextBox.Text = My.Settings.Sector & " " & "entities eject" & " " & Chr(34) & Player_NameText.Text & Chr(34)
            End If
        End If
        'Player Entities kill
        If PlayerEComboBox.Text = "kill" Then
            If SteamID_Texbox.TextLength > 0 Then
                PlayerEsteamTextBox.Text = My.Settings.Sector & " " & "entities kill" & " " & SteamID_Texbox.Text
            End If
            If Player_NameText.TextLength > 0 Then
                PlayerEnameTextBox.Text = My.Settings.Sector & " " & "entities kill" & " " & Chr(34) & Player_NameText.Text & Chr(34)
            End If
        End If

        'Grid Entities delete
        If GridEComboBox.Text = "delete" Then
            If Grid_NameText.TextLength > 0 Then
                GridEnameTextBox.Text = My.Settings.Sector & " " & "entities delete" & " " & Chr(34) & Grid_NameText.Text & Chr(34)
            End If
        End If
        'Grid Entities stop
        If GridEComboBox.Text = "stop" Then
            If Grid_NameText.TextLength > 0 Then
                GridEnameTextBox.Text = My.Settings.Sector & " " & "entities stop" & " " & Chr(34) & Grid_NameText.Text & Chr(34)
            End If
        End If
        'Grid Entities refresh
        If GridEComboBox.Text = "refresh" Then
            If Grid_NameText.TextLength > 0 Then
                GridEnameTextBox.Text = My.Settings.Sector & " " & "entities refresh" & " " & Chr(34) & Grid_NameText.Text & Chr(34)
            End If
        End If
        'Grid Entities poweroff
        If GridEComboBox.Text = "poweroff" Then
            If Grid_NameText.TextLength > 0 Then
                GridEnameTextBox.Text = My.Settings.Sector & " " & "entities poweroff" & " " & Chr(34) & Grid_NameText.Text & Chr(34)
            End If
        End If
        'Grid Entities poweron
        If GridEComboBox.Text = "poweron" Then
            If Grid_NameText.TextLength > 0 Then
                GridEnameTextBox.Text = My.Settings.Sector & " " & "entities poweron" & " " & Chr(34) & Grid_NameText.Text & Chr(34)
            End If
        End If

        'Logs
        If Month_ComboBox.Text = "" Then
        Else
            'Get logs keen
            If Log_TypeComboBox.Text = "keen" Then
                ServerLogTextBox.Text = "/nexus log " & My.Settings.logserver & " " & "keen" & " " & Month_ComboBox.Text & "/" & Day_ComboBox.Text
            End If
            'Get logs torch
            If Log_TypeComboBox.Text = "torch" Then
                ServerLogTextBox.Text = "/nexus log " & My.Settings.logserver & " " & "torch" & " " & Month_ComboBox.Text & "/" & Day_ComboBox.Text
            End If
            'Get logs ownerships
            If Log_TypeComboBox.Text = "ownerships" Then
                ServerLogTextBox.Text = "/nexus log " & My.Settings.logserver & " " & "ownerships" & " " & Month_ComboBox.Text & "/" & Day_ComboBox.Text
            End If
            'Get logs deleted
            If Log_TypeComboBox.Text = "deleted" Then
                ServerLogTextBox.Text = "/nexus log " & My.Settings.logserver & " " & "deleted" & " " & Month_ComboBox.Text & "/" & Day_ComboBox.Text
            End If
            'Get logs blocklimiter
            If Log_TypeComboBox.Text = "blocklimiter" Then
                ServerLogTextBox.Text = "/nexus log " & My.Settings.logserver & " " & "blocklimiter" & " " & Month_ComboBox.Text & "/" & Day_ComboBox.Text
            End If
        End If

        If RenameGridNewTextBox.TextLength > 0 Then
            If Grid_NameText.TextLength > 0 Then
                RenameGridTextBox.Text = My.Settings.Sector & " " & "admin rename" & " " & Chr(34) & Grid_NameText.Text & Chr(34) & " " & Chr(34) & RenameGridNewTextBox.Text & Chr(34)
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Sector = ""
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
    End Sub

    Private Sub Scriptertext_Button_Click(sender As Object, e As EventArgs) Handles Scriptertext_Button.Click
        If Scripter_Text_RichTextBox.TextLength > 0 Then Clipboard.SetText(Scripter_Text_RichTextBox.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GiveScripterButton.Click
        If GiveScripterRole_TextBox.TextLength > 0 Then Clipboard.SetText(GiveScripterRole_TextBox.Text)
    End Sub

    Private Sub ListGrid_PVE_NameButton_Click(sender As Object, e As EventArgs) Handles ListGrid_PVE_NameButton.Click
        If ListGrid_PVE_NameTextBox.TextLength > 0 Then Clipboard.SetText(ListGrid_PVE_NameTextBox.Text)
    End Sub

    Private Sub ListGrid_PVE_SteamIDButton_Click(sender As Object, e As EventArgs) Handles ListGrid_PVE_SteamIDButton.Click
        If ListGrid_PVE_SteamIDTextBox.TextLength > 0 Then Clipboard.SetText(ListGrid_PVE_SteamIDTextBox.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles ListGridBackupNameButton.Click
        If ListGridBackupNameTextBox.TextLength > 0 Then Clipboard.SetText(ListGridBackupNameTextBox.Text)
    End Sub

    Private Sub MainWindow_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        My.Settings.ListGrid = ListGridBackupComboBox.Text
        Update_Button.PerformClick()
    End Sub

    Private Sub HangarNameButton_Click(sender As Object, e As EventArgs) Handles HangarNameButton.Click
        If HangarNameTextBox.TextLength > 0 Then Clipboard.SetText(HangarNameTextBox.Text)

    End Sub

    Private Sub HangarSteamIDButton_Click(sender As Object, e As EventArgs) Handles HangarSteamIDButton.Click
        If HangarSteamIDTextBox.TextLength > 0 Then Clipboard.SetText(HangarSteamIDTextBox.Text)
    End Sub

    Private Sub PlayerEnameButton_Click(sender As Object, e As EventArgs) Handles PlayerEnameButton.Click
        If PlayerEnameTextBox.TextLength > 0 Then Clipboard.SetText(PlayerEnameTextBox.Text)
    End Sub

    Private Sub PlayerEsteamButton_Click(sender As Object, e As EventArgs) Handles PlayerEsteamButton.Click
        If PlayerEsteamTextBox.TextLength > 0 Then Clipboard.SetText(PlayerEsteamTextBox.Text)
    End Sub

    Private Sub GridEnameButton_Click(sender As Object, e As EventArgs) Handles GridEnameButton.Click
        If GridEnameTextBox.TextLength > 0 Then Clipboard.SetText(GridEnameTextBox.Text)
    End Sub

    Private Sub RenameGridButton_Click(sender As Object, e As EventArgs) Handles RenameGridButton.Click
        If RenameGridTextBox.TextLength > 0 Then Clipboard.SetText(RenameGridTextBox.Text)
    End Sub

    Private Sub ServerLogButton_Click(sender As Object, e As EventArgs) Handles ServerLogButton.Click
        If ServerLogTextBox.TextLength > 0 Then Clipboard.SetText(ServerLogTextBox.Text)
    End Sub

    Private Sub ListGridBackupSteamButton_Click(sender As Object, e As EventArgs) Handles ListGridBackupSteamButton.Click
        If ListGridBackupSteamTextBox.TextLength > 0 Then Clipboard.SetText(ListGridBackupSteamTextBox.Text)
    End Sub

    Private Sub GridRestoreNameButton_Click(sender As Object, e As EventArgs) Handles GridRestoreNameButton.Click
        If GridRestoreNameTextBox.TextLength > 0 Then Clipboard.SetText(GridRestoreNameTextBox.Text)
    End Sub

    Private Sub GridRestoreSteamButton_Click(sender As Object, e As EventArgs) Handles GridRestoreSteamButton.Click
        If GridRestoreSteamTextBox.TextLength > 0 Then Clipboard.SetText(GridRestoreSteamTextBox.Text)
    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        Player_NameText.Text = ""
        Month_ComboBox.Text = ""
        Day_ComboBox.Text = ""
        Grid_NameText.Text = ""
        RenameGridNewTextBox.Text = ""
        DiscordID_TextBox.Text = ""
        Sector_ComboBox.Text = ""
        SteamID_Texbox.Text = ""
        GetSteamID_TextBox.Text = ""
        GiveScripterRole_TextBox.Text = ""
        HangarComboBox.Text = ""
        HangarRemoveComboBox.Text = ""
        HangarNameTextBox.Text = ""
        HangarSteamIDTextBox.Text = ""
        PlayerEnameTextBox.Text = ""
        PlayerEsteamTextBox.Text = ""
        GridEComboBox.Text = ""
        GridEnameTextBox.Text = ""
        RenameGridTextBox.Text = ""
        ServerLogTextBox.Text = ""
        ListGrid_PVE_NameTextBox.Text = ""
        ListGrid_PVE_SteamIDTextBox.Text = ""
        ListGridBackupComboBox.Text = ""
        ListGridBackupNameTextBox.Text = ""
        ListGridBackupSteamTextBox.Text = ""
        RestoreNumoneComboBox.Text = ""
        RestoreNumtwoComboBox.Text = ""
        RestoreQComboBox.Text = ""
        RestoreForceComboBox.Text = ""
        GridRestoreNameTextBox.Text = ""
        GridRestoreSteamTextBox.Text = ""

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
End Class
