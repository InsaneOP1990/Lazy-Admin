Imports System.Collections.Specialized
Imports System.Net
Imports System.IO
Imports System.Management

Public Class MainWindow
    Private Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" &
        "{impersonationLevel=impersonate}!\\" &
        computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from " &
        "Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids =
        cpu_ids.Substring(2)

        Return cpu_ids
    End Function
    Public Function GetDriveSerialNumber() As String
        Dim DriveSerial As Long
        Dim fso As Object, Drv As Object
        'Create a FileSystemObject object
        fso = CreateObject("Scripting.FileSystemObject")
        Drv = fso.GetDrive(fso.GetDriveName(AppDomain.CurrentDomain.BaseDirectory))
        With Drv
            If .IsReady Then
                DriveSerial = .SerialNumber
            Else    '"Drive Not Ready!"
                DriveSerial = -1
            End If
        End With
        'Clean up
        Drv = Nothing
        fso = Nothing
        GetDriveSerialNumber = Hex(DriveSerial)
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            ingamename.Show()

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
        If username.TextLength < 80 Then
            username.Text = My.Settings.WebUserName + GetDriveSerialNumber() + "-" + My.Settings.InGameName + "-"
        Else
            username.Text = GetDriveSerialNumber() + "-" + My.Settings.InGameName + "-"
        End If
        profilePicLink.Text = My.Settings.WebProfilelink

        'discord tab
        If Player_NameText.TextLength > 0 Then

            Dim olddiscord As String = Tab_DiscordRichTextBox2.Text

            If olddiscord.Contains("<discordID>") Then
                Dim newdiscord As String
                newdiscord = olddiscord.Replace("<discordID>", DiscordID_TextBox.Text)

                Tab_DiscordRichTextBox.Text = newdiscord
            End If
            'bank tab
            Dim olddiscord1 As String = Tab_BankRichTextBox2.Text

            If olddiscord1.Contains("<discordID>") Then
                Dim newdiscord1 As String
                newdiscord1 = olddiscord1.Replace("<discordID>", DiscordID_TextBox.Text)
                Dim newdiscord2 As String
                newdiscord2 = newdiscord1.Replace("<sec>", My.Settings.Sector)
                Dim newdiscord3 As String
                newdiscord3 = newdiscord2.Replace("<playername>", Player_NameText.Text)
                Dim newdiscord4 As String
                newdiscord4 = newdiscord3.Replace("<steamid>", SteamID_Texbox.Text)

                Tab_BankRichTextBox.Text = newdiscord4
            End If

            'ale tab
            Dim oldsec As String = Tab_AleRichTextBox2.Text

            If oldsec.Contains("<sec>") Then
                Dim newsec As String
                newsec = oldsec.Replace("<sec>", My.Settings.Sector)
                Dim newgrid As String
                newgrid = newsec.Replace("<GridName>", Grid_NameText.Text)
                Dim newplayer As String
                newplayer = newgrid.Replace("<PlayerName>", Player_NameText.Text)

                Tab_AleRichTextBox.Text = newplayer
            End If

            'Block tab
            Dim olddblock As String = Tab_BlocksRichTextBox2.Text

            If olddblock.Contains("<GridName>") Then
                Dim newblock1 As String
                newblock1 = olddblock.Replace("<GridName>", Grid_NameText.Text)
                Dim newblock2 As String
                newblock2 = newblock1.Replace("<sec>", My.Settings.Sector)
                Dim newblock3 As String
                newblock3 = newblock2.Replace("<PlayerName>", Player_NameText.Text)

                Tab_BlocksRichTextBox.Text = newblock3
            End If

            'Clean tab
            Dim oldClean As String = Tab_CleanRichTextBox2.Text

            If oldClean.Contains("<sec") Then
                Dim newClean As String
                newClean = oldClean.Replace("<sec>", My.Settings.Sector)

                Tab_CleanRichTextBox.Text = newClean
            End If

            'Slime tab
            Dim olddSlime As String = Tab_SlimeRichTextBox2.Text

            If olddSlime.Contains("<Gridname>") Then
                Dim newSlime1 As String
                newSlime1 = olddSlime.Replace("<Gridname>", Grid_NameText.Text)
                Dim newSlime2 As String
                newSlime2 = newSlime1.Replace("<sec>", My.Settings.Sector)
                Dim newSlime3 As String
                newSlime3 = newSlime2.Replace("<PlayerName>", Player_NameText.Text)

                Tab_SlimeRichTextBox.Text = newSlime3
            End If

            'Grids tab
            Dim olddGridss As String = Tab_GridsRichTextBox2.Text

            If olddGridss.Contains("<Gridname>") Then
                Dim newGridss1 As String
                newGridss1 = olddGridss.Replace("<Gridname>", Grid_NameText.Text)
                Dim newGridss2 As String
                newGridss2 = newGridss1.Replace("<sec>", My.Settings.Sector)
                Dim newGridss3 As String
                newGridss3 = newGridss2.Replace("<PlayerName>", Player_NameText.Text)

                Tab_GridsRichTextBox.Text = newGridss3
            End If
        Else
            Tab_DiscordRichTextBox.Text = Tab_DiscordRichTextBox2.Text
            Tab_BankRichTextBox.Text = Tab_BankRichTextBox2.Text
            Tab_AleRichTextBox.Text = Tab_AleRichTextBox2.Text
            Tab_BlocksRichTextBox.Text = Tab_BlocksRichTextBox2.Text
            Tab_CleanRichTextBox.Text = Tab_CleanRichTextBox2.Text
            Tab_SlimeRichTextBox.Text = Tab_SlimeRichTextBox2.Text
            Tab_GridsRichTextBox.Text = Tab_GridsRichTextBox2.Text
        End If

        'Misc tab
        Dim olddMisc As String = Tab_MiscRichTextBox2.Text

        If olddMisc.Contains("<Gridname>") Then
            Dim newMisc1 As String
            newMisc1 = olddMisc.Replace("<Gridname>", Grid_NameText.Text)
            Dim newMisc2 As String
            newMisc2 = newMisc1.Replace("<sec>", My.Settings.Sector)
            Dim newMisc3 As String
            newMisc3 = newMisc2.Replace("<PlayerName>", Player_NameText.Text)

            Tab_MiscRichTextBox.Text = newMisc3
        End If

        'If steam check box empty then uncheck
        If SteamID_Texbox.TextLength = 0 Then
            SteamCheckBox.Checked = False
        End If

        'get sector
        Try
            Dim sectorlist As String = My.Settings.SectorDrop
            Dim sectorlistarray() As String = Split(sectorlist, ",")
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
        'OLD WAY TO GET SECTOR

        '  If Sector_ComboBox.Text = "" Then
        '     Clear_Button.PerformClick()
        ' Else
        ' If Sector_ComboBox.Text = "ALL - All servers except the lobby. Senior Staff / Admin Only" Then
        '      My.Settings.Sector = "ALL"
        '     My.Settings.logserver = "!!ERROR!!!"
        ' End If
        ' If Sector_ComboBox.Text = "PVE - Any server that is Avalon (Planets Space KotH's)" Then
        '    My.Settings.Sector = "PVE"
        '     My.Settings.logserver = "!!ERROR!!!"
        ' End If
        ' If Sector_ComboBox.Text = "PVP - Any server that is Dead Worlds (Planets Space KotH's)" Then
        '     My.Settings.Sector = "PVP"
        '     My.Settings.logserver = "!!ERROR!!!"
        '  End If
        '  If Sector_ComboBox.Text = "NPC - Both Roach servers" Then
        '      My.Settings.Sector = "NPC"
        '      My.Settings.logserver = "!!ERROR!!!"
        '  End If
        ' If Sector_ComboBox.Text = "tL - The Lobby server - Lobby Sector." Then
        '     My.Settings.Sector = "tL"
        '    My.Settings.logserver = "1"
        ' End If
        'If Sector_ComboBox.Text = "gS - Deep Space / General Sector or the everywhere else." Then
        '     My.Settings.Sector = "gS"
        '     My.Settings.logserver = "2"
        '  End If
        ' If Sector_ComboBox.Text = "aS - Avalon Space Sector" Then
        '     My.Settings.Sector = "aS"
        '     My.Settings.logserver = "10"
        ' End If
        ' If Sector_ComboBox.Text = "aS1 -Avalon Space Inner 1 Dover Space" Then
        '     My.Settings.Sector = "aS1"
        '     My.Settings.logserver = "12"
        ' End If
        ' If Sector_ComboBox.Text = "aS2 - Avalon Space Inner 2 IK006 Space" Then
        '     My.Settings.Sector = "aS2"
        '     My.Settings.logserver = "13"
        ' End If
        ' If Sector_ComboBox.Text = "aS3 - Avalon Space Inner 3 Pelmuth Space" Then
        '     My.Settings.Sector = "aS3"
        '     My.Settings.logserver = "14"
        '  End If
        '  If Sector_ComboBox.Text = "dS - Dead Worlds Space Sector" Then
        '      My.Settings.Sector = "dS"
        '      My.Settings.logserver = "20"
        '  End If
        '  If Sector_ComboBox.Text = "aDV - Avalon Dover Planet Sector" Then
        ' My.Settings.Sector = "aDV"
        '      My.Settings.logserver = "11"
        '  End If
        '  If Sector_ComboBox.Text = "aIK  - Avalon IK006 Planet Sector" Then
        '    My.Settings.Sector = "aIK"
        '    My.Settings.logserver = "15"
        ' End If
        'If Sector_ComboBox.Text = "aPL - Avalon Pelmuth Planet Sector" Then
        '     My.Settings.Sector = "aPL"
        '      My.Settings.logserver = "17"
        ' End If
        ' If Sector_ComboBox.Text = "dP - Dead Worlds Planets Sector" Then
        '     My.Settings.Sector = "dP"
        '     My.Settings.logserver = "21"
        ' End If
        ' If Sector_ComboBox.Text = "dK - Dead Worlds Space KotH Sector" Then
        '    My.Settings.Sector = "dK"
        '    My.Settings.logserver = "22"
        '  End If
        ' If Sector_ComboBox.Text = "cK - Crypt KotH Sector" Then
        '   My.Settings.Sector = "cK"
        '  My.Settings.logserver = "23"
        '  End If
        '  If Sector_ComboBox.Text = "rI - Roach Inner Sector" Then
        '     My.Settings.Sector = "rI"
        '      My.Settings.logserver = "40"
        ' End If
        ' If Sector_ComboBox.Text = "rO - Roach Outter Sector" Then
        '     My.Settings.Sector = "rO"
        '   My.Settings.logserver = "41"
        'End If
        'If Sector_ComboBox.Text = "tR - Transit Server between Roach and Avalon / DW " Then
        '  My.Settings.Sector = "tR"
        '   My.Settings.logserver = "50"
        'End If
        ' If Sector_ComboBox.Text = "wS - Waterloo Space Sector" Then
        '   My.Settings.Sector = "wS"
        '    My.Settings.logserver = "51"
        ' End If
        '  If Sector_ComboBox.Text = "wP - Waterloo Planet Sector" Then
        '      My.Settings.Sector = "wP"
        '     My.Settings.logserver = "52"
        '  End If
        '  If Sector_ComboBox.Text = "sL - Special Lobby bot for scripting use and other powers. (Dont put a space after the prefix here)" Then
        '      My.Settings.Sector = "sL"
        '     My.Settings.logserver = "!!ERROR!!!"
        '  End If
        '  If Sector_ComboBox.Text = "tK - The Space KotH Bot used by scripts to reset KotH" Then
        '      My.Settings.Sector = "tK"
        '      My.Settings.logserver = "!!ERROR!!!"
        ' End If
        '  If Sector_ComboBox.Text = "tC - The Crypt KotH Bot used by scripts to reset KotH" Then
        '     My.Settings.Sector = "tC"
        '      My.Settings.logserver = "!!ERROR!!!"
        '   End If
        '   If Sector_ComboBox.Text = "tS - Transit Server for use with Tech Bot " Then
        '       My.Settings.Sector = "tS"
        '      My.Settings.logserver = "!!ERROR!!!"
        '  End If
        ' End If

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

        'hangar List
        If SteamCheckBox.Checked = True Then
            If HangarComboBox.Text = "list" Then
                If SteamID_Texbox.TextLength > 0 Then
                    HangarNameTextBox.Text = My.Settings.Sector & " " & "hm list" & " " & SteamID_Texbox.Text
                End If
            End If
        Else
            If HangarComboBox.Text = "list" Then
                If Player_NameText.TextLength > 0 Then
                    HangarNameTextBox.Text = My.Settings.Sector & " " & "hm list" & " " & Chr(34) & Player_NameText.Text & Chr(34)
                End If
            End If
        End If



        'hangar save
        If HangarComboBox.Text = "save" Then
            If Grid_NameText.TextLength > 0 Then
                HangarNameTextBox.Text = My.Settings.Sector & " " & "hm save" & " " & Chr(34) & Grid_NameText.Text & Chr(34)
            End If
        End If

        'hangar remove
        If SteamCheckBox.Checked = True Then
            If HangarComboBox.Text = "remove" Then
                If HangarRemoveComboBox.Text = "" Then
                Else
                    If SteamID_Texbox.TextLength > 0 Then
                        HangarNameTextBox.Text = My.Settings.Sector & " " & "hm remove" & " " & SteamID_Texbox.Text & " " & My.Settings.HangarRemove
                    End If
                End If
            End If
        Else
            If HangarComboBox.Text = "remove" Then
                If HangarRemoveComboBox.Text = "" Then
                Else
                    If Player_NameText.TextLength > 0 Then
                        HangarNameTextBox.Text = My.Settings.Sector & " " & "hm remove" & " " & Chr(34) & Player_NameText.Text & Chr(34) & " " & My.Settings.HangarRemove
                    End If
                End If
            End If
        End If



        'hangar load
        If SteamCheckBox.Checked = True Then
            If HangarComboBox.Text = "load" Then
                If HangarRemoveComboBox.Text = "" Then
                Else
                    If SteamID_Texbox.TextLength > 0 Then
                        HangarNameTextBox.Text = My.Settings.Sector & " " & "hm load" & " " & SteamID_Texbox.Text & " " & My.Settings.HangarRemove
                    End If
                End If
            End If
        Else
            If HangarComboBox.Text = "load" Then
                If HangarRemoveComboBox.Text = "" Then
                Else
                    If Player_NameText.TextLength > 0 Then
                        HangarNameTextBox.Text = My.Settings.Sector & " " & "hm load" & " " & Chr(34) & Player_NameText.Text & Chr(34) & " " & My.Settings.HangarRemove
                    End If
                End If
            End If
        End If


        'hangar info
        If SteamCheckBox.Checked = True Then
            If HangarComboBox.Text = "info" Then
                If SteamID_Texbox.TextLength > 0 Then
                    HangarNameTextBox.Text = My.Settings.Sector & " " & "hm info" & " " & SteamID_Texbox.Text & " " & My.Settings.HangarRemove
                End If
            End If
        Else
            If HangarComboBox.Text = "info" Then
                If Player_NameText.TextLength > 0 Then
                    HangarNameTextBox.Text = My.Settings.Sector & " " & "hm info" & " " & Chr(34) & Player_NameText.Text & Chr(34) & " " & My.Settings.HangarRemove
                End If
            End If
        End If

        'hangar saveall
        If HangarComboBox.Text = "saveall" Then
            HangarNameTextBox.Text = My.Settings.Sector & " hm saveall"
        End If


        'Player Entities eject
        If SteamCheckBox.Checked = True Then
            If PlayerEComboBox.Text = "eject" Then
                If SteamID_Texbox.TextLength > 0 Then
                    PlayerEnameTextBox.Text = My.Settings.Sector & " " & "entities eject" & " " & SteamID_Texbox.Text
                End If
            End If
        Else
            If PlayerEComboBox.Text = "eject" Then
                If Player_NameText.TextLength > 0 Then
                    PlayerEnameTextBox.Text = My.Settings.Sector & " " & "entities eject" & " " & Chr(34) & Player_NameText.Text & Chr(34)
                End If
            End If
        End If


        'Player Entities kill
        If SteamCheckBox.Checked = True Then
            If PlayerEComboBox.Text = "kill" Then
                If SteamID_Texbox.TextLength > 0 Then
                    PlayerEnameTextBox.Text = My.Settings.Sector & " " & "entities kill" & " " & SteamID_Texbox.Text
                End If
            End If
        Else
            If PlayerEComboBox.Text = "kill" Then
                If Player_NameText.TextLength > 0 Then
                    PlayerEnameTextBox.Text = My.Settings.Sector & " " & "entities kill" & " " & Chr(34) & Player_NameText.Text & Chr(34)
                End If
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
        'Grid Entities checkauthor
        If GridEComboBox.Text = "checkauthor" Then
            If Grid_NameText.TextLength > 0 Then
                GridEnameTextBox.Text = My.Settings.Sector & " " & "checkauthor" & " " & Chr(34) & Grid_NameText.Text & Chr(34)
            End If
        End If
        'Grid Entities admin makeship
        If GridEComboBox.Text = "admin makeship" Then
            If Grid_NameText.TextLength > 0 Then
                GridEnameTextBox.Text = My.Settings.Sector & " " & "admin makeship" & " " & Chr(34) & Grid_NameText.Text & Chr(34)
            End If
        End If
        'Grid Entities admin makestation
        If GridEComboBox.Text = "admin makestation" Then
            If Grid_NameText.TextLength > 0 Then
                GridEnameTextBox.Text = My.Settings.Sector & " " & "admin makestation" & " " & Chr(34) & Grid_NameText.Text & Chr(34)
            End If
        End If
        'Grid Entities fixshipmod
        If GridEComboBox.Text = "fixshipmod" Then
            If Grid_NameText.TextLength > 0 Then
                GridEnameTextBox.Text = My.Settings.Sector & " " & "fixshipmod" & " " & Chr(34) & Grid_NameText.Text & Chr(34)
            End If
        End If
        'Grid Entities Transfer
        If GridEComboBox.Text = "transfer" Then
            If Grid_NameText.TextLength > 0 Then
                GridEnameTextBox.Text = My.Settings.Sector & " " & "transfer" & " " & Chr(34) & Player_NameText.Text & Chr(34) & " " & Chr(34) & Grid_NameText.Text & Chr(34)
            End If
        End If


        'Common command - MovePlayer
        If CommonComboBox.Text = "Move Player" Then
            If Player_NameText.TextLength > 0 Then
                CommonTextBox.Text = "/nexus setserverid " & Chr(34) & Player_NameText.Text & Chr(34) & " " & My.Settings.logserver
            End If
        End If

        'Common command - whatsmyip
        If CommonComboBox.Text = "whatsmyip" Then
            If SteamID_Texbox.TextLength > 0 Then
                CommonTextBox.Text = My.Settings.Sector & " whatsmyip " & SteamID_Texbox.Text
            End If
        End If

        'Common command - help
        If CommonComboBox.Text = "help" Then
            CommonTextBox.Text = My.Settings.Sector & " help"
        End If

        'Common command - longhelp
        If CommonComboBox.Text = "longhelp" Then
            CommonTextBox.Text = My.Settings.Sector & " longhelp"
        End If

        'Common command - ver
        If CommonComboBox.Text = "ver" Then
            CommonTextBox.Text = My.Settings.Sector & " ver"
        End If

        'Common command - plugins
        If CommonComboBox.Text = "plugins" Then
            CommonTextBox.Text = My.Settings.Sector & " plugins"
        End If

        'Common command - onlineservers
        If CommonComboBox.Text = "onlineservers" Then
            CommonTextBox.Text = "/nexus onlineservers"
        End If

        'Common command - uptime
        If CommonComboBox.Text = "uptime" Then
            CommonTextBox.Text = My.Settings.Sector & " uptime"
        End If

        'Common command - fix physics 1 1
        If CommonComboBox.Text = "fix physics 1 1" Then
            CommonTextBox.Text = My.Settings.Sector & " fix physics 1 1"
        End If
        'Common command - fix physics 2
        If CommonComboBox.Text = "fix physics 2" Then
            CommonTextBox.Text = My.Settings.Sector & " fix physics 2"
        End If
        'Common command - fix physics 2 3
        If CommonComboBox.Text = "fix physics 2 3" Then
            CommonTextBox.Text = My.Settings.Sector & " fix physics 2 3"
        End If


        'Common command - profile grids
        If CommonComboBox.Text = "profile grids" Then
            CommonTextBox.Text = My.Settings.Sector & " profile grids"
        End If
        'Common command - admin playerlist
        If CommonComboBox.Text = "admin playerlist" Then
            CommonTextBox.Text = My.Settings.Sector & " admin playerlist"
        End If
        'Common command - admin mute
        If CommonComboBox.Text = "admin mute" Then
            If Player_NameText.TextLength > 0 Then
                CommonTextBox.Text = My.Settings.Sector & " admin mute " & Player_NameText.Text
            End If
        End If


        'Common command - Cleanup nobody
        If CommonComboBox.Text = "Cleanup nobody" Then
            CommonTextBox.Text = My.Settings.Sector & " cleanup delete ownedby nobody"
        End If
        'Common command - Cleanup Void NPC
        If CommonComboBox.Text = "Cleanup Void NPC" Then
            CommonTextBox.Text = My.Settings.Sector & " cleanup delete ownedby " & Chr(34) & "Emptiness" & Chr(34)
        End If
        'Common command - Cleanup GiRR NPC
        If CommonComboBox.Text = "Cleanup GiRR NPC" Then
            CommonTextBox.Text = My.Settings.Sector & " cleanup delete ownedby " & Chr(34) & "Geraldine Schultz" & Chr(34)
        End If
        'Common command - Cleanup PRTH NPC
        If CommonComboBox.Text = "Cleanup PRTH NPC" Then
            CommonTextBox.Text = My.Settings.Sector & " cleanup delete ownedby " & Chr(34) & "Triton" & Chr(34)
        End If
        'Common command - CCleanup GKNT NPC
        If CommonComboBox.Text = "Cleanup GKNT NPC" Then
            CommonTextBox.Text = My.Settings.Sector & " cleanup delete ownedby " & Chr(34) & "Ace Gold" & Chr(34)
        End If
        'Common command - Cleanup ECHO NPC
        If CommonComboBox.Text = "Cleanup ECHO NPC" Then
            CommonTextBox.Text = My.Settings.Sector & " cleanup delete ownedby " & Chr(34) & "Haxor Black" & Chr(34)
        End If
        'Common command -Cleanup Bass NPC
        If CommonComboBox.Text = "Cleanup Bass NPC" Then
            CommonTextBox.Text = My.Settings.Sector & " cleanup delete ownedby " & Chr(34) & "Manny" & Chr(34)
        End If
        'Common command - Cleanup Pirates
        If CommonComboBox.Text = "Cleanup Pirates" Then
            CommonTextBox.Text = My.Settings.Sector & " cleanup delete ownedby " & Chr(34) & "Space Pirates" & Chr(34)
        End If




        'Common command - giveitem
        If Player_NameText.TextLength > 0 Then
            GiveItem_TextBox.Text = My.Settings.Sector & " giveitem " & Chr(34) & Player_NameText.Text & Chr(34) & " Component " & Component_ComboBox.Text & " " & ComponentAmount_TextBox.Text & " true"
        End If



        'Logs
        If My.Settings.logserver = "!!ERROR!!!" Then
            ServerLogTextBox.Text = ""
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

        If SteamID_Texbox.TextLength > 0 Then
            SetAdminTextBox.Text = My.Settings.Sector & " admin setrank " & SteamID_Texbox.Text & " 1"
        End If

        'uh center textcent
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

    Private Sub WeaponsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeaponsToolStripMenuItem.Click
        Weapon_limit_Window.Show()
    End Sub

    Private Sub ProductionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductionToolStripMenuItem.Click
        Production_LimitWindow.Show()
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub ScripterTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScripterTextToolStripMenuItem.Click
        Scripter_Text.Show()
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

    Private Sub SectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectorToolStripMenuItem.Click
        Sector.Show()
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
            dcWeb.UserName = ""
        Else
            dcWeb.UserName = username.Text
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

    Private Sub DiscordWebHookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscordWebHookToolStripMenuItem.Click
        DiscordWindow.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        MsgBox(GetDriveSerialNumber)
        MsgBox(CpuId)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

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
            MsgBox("The webhook link and message are required!", vbCritical + vbOKOnly)
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
