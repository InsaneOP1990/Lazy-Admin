<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.Month_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Day_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Player_NameLabel = New System.Windows.Forms.Label()
        Me.Month_Label = New System.Windows.Forms.Label()
        Me.Day_Label = New System.Windows.Forms.Label()
        Me.Grid_Lebel = New System.Windows.Forms.Label()
        Me.Player_NameText = New System.Windows.Forms.TextBox()
        Me.Grid_NameText = New System.Windows.Forms.TextBox()
        Me.Sector_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Sector_Label = New System.Windows.Forms.Label()
        Me.GetSteamID_TextBox = New System.Windows.Forms.TextBox()
        Me.GetSteamID_Label = New System.Windows.Forms.Label()
        Me.Copy_SteamID_Button = New System.Windows.Forms.Button()
        Me.Update_Button = New System.Windows.Forms.Button()
        Me.GiveScripterButton = New System.Windows.Forms.Button()
        Me.GiveScripterRole_TextBox = New System.Windows.Forms.TextBox()
        Me.GiveScripter_Label = New System.Windows.Forms.Label()
        Me.ListGrid_PVE_NameButton = New System.Windows.Forms.Button()
        Me.ListGrid_PVE_NameTextBox = New System.Windows.Forms.TextBox()
        Me.ListGrid_PVE_Label = New System.Windows.Forms.Label()
        Me.DiscordID_TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SteamID_Texbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Scriptertext_Button = New System.Windows.Forms.Button()
        Me.ScripterText_Lebel = New System.Windows.Forms.Label()
        Me.Scripter_Text_RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ListGrid_PVE_SteamIDButton = New System.Windows.Forms.Button()
        Me.ListGrid_PVE_SteamIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListGridBackupSteamTextBox = New System.Windows.Forms.TextBox()
        Me.ListGridBackupSteamButton = New System.Windows.Forms.Button()
        Me.ListGridBackupNameButton = New System.Windows.Forms.Button()
        Me.ListGridBackupNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HangarComboBox = New System.Windows.Forms.ComboBox()
        Me.PlayerEComboBox = New System.Windows.Forms.ComboBox()
        Me.GridEComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RenameGridNewTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Log_TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListGridBackupComboBox = New System.Windows.Forms.ComboBox()
        Me.ServerLogButton = New System.Windows.Forms.Button()
        Me.ServerLogTextBox = New System.Windows.Forms.TextBox()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.RestoreNumoneComboBox = New System.Windows.Forms.ComboBox()
        Me.GridRestoreSteamTextBox = New System.Windows.Forms.TextBox()
        Me.GridRestoreSteamButton = New System.Windows.Forms.Button()
        Me.GridRestoreNameButton = New System.Windows.Forms.Button()
        Me.GridRestoreNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RestoreNumtwoComboBox = New System.Windows.Forms.ComboBox()
        Me.RestoreQComboBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RestoreForceComboBox = New System.Windows.Forms.ComboBox()
        Me.HangarSteamIDTextBox = New System.Windows.Forms.TextBox()
        Me.HangarSteamIDButton = New System.Windows.Forms.Button()
        Me.HangarNameButton = New System.Windows.Forms.Button()
        Me.HangarNameTextBox = New System.Windows.Forms.TextBox()
        Me.PlayerEsteamTextBox = New System.Windows.Forms.TextBox()
        Me.PlayerEsteamButton = New System.Windows.Forms.Button()
        Me.PlayerEnameButton = New System.Windows.Forms.Button()
        Me.PlayerEnameTextBox = New System.Windows.Forms.TextBox()
        Me.GridEnameButton = New System.Windows.Forms.Button()
        Me.GridEnameTextBox = New System.Windows.Forms.TextBox()
        Me.RestoreQLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.HangarRemoveComboBox = New System.Windows.Forms.ComboBox()
        Me.RenameGridButton = New System.Windows.Forms.Button()
        Me.RenameGridTextBox = New System.Windows.Forms.TextBox()
        Me.RenameLabel = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Month_ComboBox
        '
        Me.Month_ComboBox.FormattingEnabled = True
        Me.Month_ComboBox.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.Month_ComboBox.Location = New System.Drawing.Point(679, 154)
        Me.Month_ComboBox.Name = "Month_ComboBox"
        Me.Month_ComboBox.Size = New System.Drawing.Size(37, 21)
        Me.Month_ComboBox.TabIndex = 2
        '
        'Day_ComboBox
        '
        Me.Day_ComboBox.FormattingEnabled = True
        Me.Day_ComboBox.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.Day_ComboBox.Location = New System.Drawing.Point(722, 154)
        Me.Day_ComboBox.Name = "Day_ComboBox"
        Me.Day_ComboBox.Size = New System.Drawing.Size(55, 21)
        Me.Day_ComboBox.TabIndex = 3
        '
        'Player_NameLabel
        '
        Me.Player_NameLabel.AutoSize = True
        Me.Player_NameLabel.Location = New System.Drawing.Point(260, 86)
        Me.Player_NameLabel.Name = "Player_NameLabel"
        Me.Player_NameLabel.Size = New System.Drawing.Size(67, 13)
        Me.Player_NameLabel.TabIndex = 6
        Me.Player_NameLabel.Text = "Player Name"
        '
        'Month_Label
        '
        Me.Month_Label.AutoSize = True
        Me.Month_Label.Location = New System.Drawing.Point(679, 134)
        Me.Month_Label.Name = "Month_Label"
        Me.Month_Label.Size = New System.Drawing.Size(37, 13)
        Me.Month_Label.TabIndex = 7
        Me.Month_Label.Text = "Month"
        '
        'Day_Label
        '
        Me.Day_Label.AutoSize = True
        Me.Day_Label.Location = New System.Drawing.Point(722, 133)
        Me.Day_Label.Name = "Day_Label"
        Me.Day_Label.Size = New System.Drawing.Size(55, 13)
        Me.Day_Label.TabIndex = 8
        Me.Day_Label.Text = "Day Label"
        '
        'Grid_Lebel
        '
        Me.Grid_Lebel.AutoSize = True
        Me.Grid_Lebel.Location = New System.Drawing.Point(469, 85)
        Me.Grid_Lebel.Name = "Grid_Lebel"
        Me.Grid_Lebel.Size = New System.Drawing.Size(57, 13)
        Me.Grid_Lebel.TabIndex = 9
        Me.Grid_Lebel.Text = "Grid Name"
        '
        'Player_NameText
        '
        Me.Player_NameText.Location = New System.Drawing.Point(263, 105)
        Me.Player_NameText.Name = "Player_NameText"
        Me.Player_NameText.Size = New System.Drawing.Size(200, 20)
        Me.Player_NameText.TabIndex = 1
        '
        'Grid_NameText
        '
        Me.Grid_NameText.Location = New System.Drawing.Point(469, 105)
        Me.Grid_NameText.Name = "Grid_NameText"
        Me.Grid_NameText.Size = New System.Drawing.Size(200, 20)
        Me.Grid_NameText.TabIndex = 2
        '
        'Sector_ComboBox
        '
        Me.Sector_ComboBox.FormattingEnabled = True
        Me.Sector_ComboBox.Items.AddRange(New Object() {"ALL - All servers except the lobby. Senior Staff / Admin Only please", "PVE - Any server that is Avalon (Planets Space KotH's)", "PVP - Any server that is Dead Worlds (Planets Space KotH's)", "NPC - Both Roach servers", "tL - The Lobby server - Lobby Sector.", "gS - Deep Space / General Sector or the everywhere else.", "aS - Avalon Space Sector", "aS1 -Avalon Space Inner 1 Dover Space", "aS2 - Avalon Space Inner 2 IK006 Space", "aS3 - Avalon Space Inner 3 Pelmuth Space", "dS - Dead Worlds Space Sector", "aDV - Avalon Dover Planet Sector", "aIK  - Avalon IK006 Planet Sector", "aPL - Avalon Pelmuth Planet Sector", "dP - Dead Worlds Planets Sector", "dK - Dead Worlds Space KotH Sector", "cK - Crypt KotH Sector", "rI - Roach Inner Sector", "rO - Roach Outter Sector", "tR - Transit Server between Roach and Avalon / DW ", "wS - Waterloo Space Sector", "wP - Waterloo Planet Sector", "---------------------------------", "sL - Special Lobby bot for scripting use and other powers. (Dont put a space afte" &
                "r the prefix here)", "tK - The Space KotH Bot used by scripts to reset KotH", "tC - The Crypt KotH Bot used by scripts to reset KotH", "tS - Transit Server for use with Tech Bot "})
        Me.Sector_ComboBox.Location = New System.Drawing.Point(675, 104)
        Me.Sector_ComboBox.Name = "Sector_ComboBox"
        Me.Sector_ComboBox.Size = New System.Drawing.Size(307, 21)
        Me.Sector_ComboBox.TabIndex = 3
        Me.Sector_ComboBox.Text = "PVE - Any server that is Avalon (Planets Space KotH's)"
        '
        'Sector_Label
        '
        Me.Sector_Label.AutoSize = True
        Me.Sector_Label.Location = New System.Drawing.Point(675, 89)
        Me.Sector_Label.Name = "Sector_Label"
        Me.Sector_Label.Size = New System.Drawing.Size(81, 13)
        Me.Sector_Label.TabIndex = 13
        Me.Sector_Label.Text = "Name of Sector"
        '
        'GetSteamID_TextBox
        '
        Me.GetSteamID_TextBox.BackColor = System.Drawing.Color.Silver
        Me.GetSteamID_TextBox.Location = New System.Drawing.Point(26, 262)
        Me.GetSteamID_TextBox.Name = "GetSteamID_TextBox"
        Me.GetSteamID_TextBox.Size = New System.Drawing.Size(223, 20)
        Me.GetSteamID_TextBox.TabIndex = 15
        '
        'GetSteamID_Label
        '
        Me.GetSteamID_Label.AutoSize = True
        Me.GetSteamID_Label.Location = New System.Drawing.Point(23, 243)
        Me.GetSteamID_Label.Name = "GetSteamID_Label"
        Me.GetSteamID_Label.Size = New System.Drawing.Size(71, 13)
        Me.GetSteamID_Label.TabIndex = 14
        Me.GetSteamID_Label.Text = "Get Steam ID"
        '
        'Copy_SteamID_Button
        '
        Me.Copy_SteamID_Button.Location = New System.Drawing.Point(255, 262)
        Me.Copy_SteamID_Button.Name = "Copy_SteamID_Button"
        Me.Copy_SteamID_Button.Size = New System.Drawing.Size(75, 23)
        Me.Copy_SteamID_Button.TabIndex = 16
        Me.Copy_SteamID_Button.Text = "Copy"
        Me.Copy_SteamID_Button.UseVisualStyleBackColor = True
        '
        'Update_Button
        '
        Me.Update_Button.Location = New System.Drawing.Point(519, 563)
        Me.Update_Button.Name = "Update_Button"
        Me.Update_Button.Size = New System.Drawing.Size(75, 23)
        Me.Update_Button.TabIndex = 17
        Me.Update_Button.Text = "Update"
        Me.Update_Button.UseVisualStyleBackColor = True
        '
        'GiveScripterButton
        '
        Me.GiveScripterButton.Location = New System.Drawing.Point(255, 315)
        Me.GiveScripterButton.Name = "GiveScripterButton"
        Me.GiveScripterButton.Size = New System.Drawing.Size(75, 23)
        Me.GiveScripterButton.TabIndex = 20
        Me.GiveScripterButton.Text = "Copy"
        Me.GiveScripterButton.UseVisualStyleBackColor = True
        '
        'GiveScripterRole_TextBox
        '
        Me.GiveScripterRole_TextBox.BackColor = System.Drawing.Color.Silver
        Me.GiveScripterRole_TextBox.Location = New System.Drawing.Point(26, 315)
        Me.GiveScripterRole_TextBox.Name = "GiveScripterRole_TextBox"
        Me.GiveScripterRole_TextBox.Size = New System.Drawing.Size(223, 20)
        Me.GiveScripterRole_TextBox.TabIndex = 19
        '
        'GiveScripter_Label
        '
        Me.GiveScripter_Label.AutoSize = True
        Me.GiveScripter_Label.Location = New System.Drawing.Point(23, 296)
        Me.GiveScripter_Label.Name = "GiveScripter_Label"
        Me.GiveScripter_Label.Size = New System.Drawing.Size(93, 13)
        Me.GiveScripter_Label.TabIndex = 18
        Me.GiveScripter_Label.Text = "Give Scripter Role"
        '
        'ListGrid_PVE_NameButton
        '
        Me.ListGrid_PVE_NameButton.Location = New System.Drawing.Point(1001, 262)
        Me.ListGrid_PVE_NameButton.Name = "ListGrid_PVE_NameButton"
        Me.ListGrid_PVE_NameButton.Size = New System.Drawing.Size(95, 23)
        Me.ListGrid_PVE_NameButton.TabIndex = 23
        Me.ListGrid_PVE_NameButton.Text = "Copy W/Name"
        Me.ListGrid_PVE_NameButton.UseVisualStyleBackColor = True
        '
        'ListGrid_PVE_NameTextBox
        '
        Me.ListGrid_PVE_NameTextBox.BackColor = System.Drawing.Color.Silver
        Me.ListGrid_PVE_NameTextBox.Location = New System.Drawing.Point(772, 262)
        Me.ListGrid_PVE_NameTextBox.Name = "ListGrid_PVE_NameTextBox"
        Me.ListGrid_PVE_NameTextBox.Size = New System.Drawing.Size(223, 20)
        Me.ListGrid_PVE_NameTextBox.TabIndex = 22
        '
        'ListGrid_PVE_Label
        '
        Me.ListGrid_PVE_Label.AutoSize = True
        Me.ListGrid_PVE_Label.Location = New System.Drawing.Point(769, 243)
        Me.ListGrid_PVE_Label.Name = "ListGrid_PVE_Label"
        Me.ListGrid_PVE_Label.Size = New System.Drawing.Size(98, 13)
        Me.ListGrid_PVE_Label.TabIndex = 21
        Me.ListGrid_PVE_Label.Text = "List Grid Per Sector"
        '
        'DiscordID_TextBox
        '
        Me.DiscordID_TextBox.Location = New System.Drawing.Point(263, 154)
        Me.DiscordID_TextBox.Name = "DiscordID_TextBox"
        Me.DiscordID_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.DiscordID_TextBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Paste Discord ID"
        '
        'SteamID_Texbox
        '
        Me.SteamID_Texbox.Location = New System.Drawing.Point(472, 154)
        Me.SteamID_Texbox.Name = "SteamID_Texbox"
        Me.SteamID_Texbox.Size = New System.Drawing.Size(200, 20)
        Me.SteamID_Texbox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(469, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Paste Steam ID"
        '
        'Scriptertext_Button
        '
        Me.Scriptertext_Button.Location = New System.Drawing.Point(26, 215)
        Me.Scriptertext_Button.Name = "Scriptertext_Button"
        Me.Scriptertext_Button.Size = New System.Drawing.Size(104, 23)
        Me.Scriptertext_Button.TabIndex = 31
        Me.Scriptertext_Button.Text = "Scrpter Text Copy"
        Me.Scriptertext_Button.UseVisualStyleBackColor = True
        '
        'ScripterText_Lebel
        '
        Me.ScripterText_Lebel.AutoSize = True
        Me.ScripterText_Lebel.Location = New System.Drawing.Point(9, 520)
        Me.ScripterText_Lebel.Name = "ScripterText_Lebel"
        Me.ScripterText_Lebel.Size = New System.Drawing.Size(67, 13)
        Me.ScripterText_Lebel.TabIndex = 36
        Me.ScripterText_Lebel.Text = "Scripter Text"
        '
        'Scripter_Text_RichTextBox
        '
        Me.Scripter_Text_RichTextBox.Location = New System.Drawing.Point(12, 536)
        Me.Scripter_Text_RichTextBox.Name = "Scripter_Text_RichTextBox"
        Me.Scripter_Text_RichTextBox.Size = New System.Drawing.Size(318, 96)
        Me.Scripter_Text_RichTextBox.TabIndex = 37
        Me.Scripter_Text_RichTextBox.Text = resources.GetString("Scripter_Text_RichTextBox.Text")
        '
        'ListGrid_PVE_SteamIDButton
        '
        Me.ListGrid_PVE_SteamIDButton.Location = New System.Drawing.Point(1001, 285)
        Me.ListGrid_PVE_SteamIDButton.Name = "ListGrid_PVE_SteamIDButton"
        Me.ListGrid_PVE_SteamIDButton.Size = New System.Drawing.Size(110, 23)
        Me.ListGrid_PVE_SteamIDButton.TabIndex = 38
        Me.ListGrid_PVE_SteamIDButton.Text = "Copy W/SteamID"
        Me.ListGrid_PVE_SteamIDButton.UseVisualStyleBackColor = True
        '
        'ListGrid_PVE_SteamIDTextBox
        '
        Me.ListGrid_PVE_SteamIDTextBox.BackColor = System.Drawing.Color.Silver
        Me.ListGrid_PVE_SteamIDTextBox.Location = New System.Drawing.Point(772, 288)
        Me.ListGrid_PVE_SteamIDTextBox.Name = "ListGrid_PVE_SteamIDTextBox"
        Me.ListGrid_PVE_SteamIDTextBox.Size = New System.Drawing.Size(223, 20)
        Me.ListGrid_PVE_SteamIDTextBox.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(394, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Hangar Commands"
        '
        'ListGridBackupSteamTextBox
        '
        Me.ListGridBackupSteamTextBox.BackColor = System.Drawing.Color.Silver
        Me.ListGridBackupSteamTextBox.Location = New System.Drawing.Point(772, 363)
        Me.ListGridBackupSteamTextBox.Name = "ListGridBackupSteamTextBox"
        Me.ListGridBackupSteamTextBox.Size = New System.Drawing.Size(223, 20)
        Me.ListGridBackupSteamTextBox.TabIndex = 61
        '
        'ListGridBackupSteamButton
        '
        Me.ListGridBackupSteamButton.Location = New System.Drawing.Point(1001, 360)
        Me.ListGridBackupSteamButton.Name = "ListGridBackupSteamButton"
        Me.ListGridBackupSteamButton.Size = New System.Drawing.Size(110, 23)
        Me.ListGridBackupSteamButton.TabIndex = 60
        Me.ListGridBackupSteamButton.Text = "Copy W/SteamID"
        Me.ListGridBackupSteamButton.UseVisualStyleBackColor = True
        '
        'ListGridBackupNameButton
        '
        Me.ListGridBackupNameButton.Location = New System.Drawing.Point(1001, 337)
        Me.ListGridBackupNameButton.Name = "ListGridBackupNameButton"
        Me.ListGridBackupNameButton.Size = New System.Drawing.Size(95, 23)
        Me.ListGridBackupNameButton.TabIndex = 59
        Me.ListGridBackupNameButton.Text = "Copy W/Name"
        Me.ListGridBackupNameButton.UseVisualStyleBackColor = True
        '
        'ListGridBackupNameTextBox
        '
        Me.ListGridBackupNameTextBox.BackColor = System.Drawing.Color.Silver
        Me.ListGridBackupNameTextBox.Location = New System.Drawing.Point(772, 337)
        Me.ListGridBackupNameTextBox.Name = "ListGridBackupNameTextBox"
        Me.ListGridBackupNameTextBox.Size = New System.Drawing.Size(223, 20)
        Me.ListGridBackupNameTextBox.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(772, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "List Gridbackup Per Sector"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(394, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Player Entities Commands"
        '
        'HangarComboBox
        '
        Me.HangarComboBox.FormattingEnabled = True
        Me.HangarComboBox.Items.AddRange(New Object() {"list", "save", "refresh", "remove", "info", "load"})
        Me.HangarComboBox.Location = New System.Drawing.Point(580, 240)
        Me.HangarComboBox.Name = "HangarComboBox"
        Me.HangarComboBox.Size = New System.Drawing.Size(121, 21)
        Me.HangarComboBox.TabIndex = 65
        Me.HangarComboBox.Text = "list"
        '
        'PlayerEComboBox
        '
        Me.PlayerEComboBox.FormattingEnabled = True
        Me.PlayerEComboBox.Items.AddRange(New Object() {"eject", "kill"})
        Me.PlayerEComboBox.Location = New System.Drawing.Point(579, 312)
        Me.PlayerEComboBox.Name = "PlayerEComboBox"
        Me.PlayerEComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PlayerEComboBox.TabIndex = 66
        Me.PlayerEComboBox.Text = "eject"
        '
        'GridEComboBox
        '
        Me.GridEComboBox.FormattingEnabled = True
        Me.GridEComboBox.Items.AddRange(New Object() {"refresh", "stop", "delete", "poweroff", "poweron"})
        Me.GridEComboBox.Location = New System.Drawing.Point(580, 387)
        Me.GridEComboBox.Name = "GridEComboBox"
        Me.GridEComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GridEComboBox.TabIndex = 70
        Me.GridEComboBox.Text = "stop"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(394, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Grid Entities Commands"
        '
        'RenameGridNewTextBox
        '
        Me.RenameGridNewTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RenameGridNewTextBox.Location = New System.Drawing.Point(783, 154)
        Me.RenameGridNewTextBox.Name = "RenameGridNewTextBox"
        Me.RenameGridNewTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RenameGridNewTextBox.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(783, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "New Grid Name"
        '
        'Log_TypeComboBox
        '
        Me.Log_TypeComboBox.FormattingEnabled = True
        Me.Log_TypeComboBox.Items.AddRange(New Object() {"keen", "torch", "ownerships", "deleted", "blocklimiter"})
        Me.Log_TypeComboBox.Location = New System.Drawing.Point(464, 483)
        Me.Log_TypeComboBox.Name = "Log_TypeComboBox"
        Me.Log_TypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Log_TypeComboBox.TabIndex = 74
        Me.Log_TypeComboBox.Text = "ownerships"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(394, 486)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Server Logs"
        '
        'ListGridBackupComboBox
        '
        Me.ListGridBackupComboBox.FormattingEnabled = True
        Me.ListGridBackupComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.ListGridBackupComboBox.Location = New System.Drawing.Point(912, 316)
        Me.ListGridBackupComboBox.Name = "ListGridBackupComboBox"
        Me.ListGridBackupComboBox.Size = New System.Drawing.Size(37, 21)
        Me.ListGridBackupComboBox.TabIndex = 75
        '
        'ServerLogButton
        '
        Me.ServerLogButton.Location = New System.Drawing.Point(626, 510)
        Me.ServerLogButton.Name = "ServerLogButton"
        Me.ServerLogButton.Size = New System.Drawing.Size(95, 23)
        Me.ServerLogButton.TabIndex = 79
        Me.ServerLogButton.Text = "Copy"
        Me.ServerLogButton.UseVisualStyleBackColor = True
        '
        'ServerLogTextBox
        '
        Me.ServerLogTextBox.BackColor = System.Drawing.Color.Silver
        Me.ServerLogTextBox.Location = New System.Drawing.Point(397, 510)
        Me.ServerLogTextBox.Name = "ServerLogTextBox"
        Me.ServerLogTextBox.Size = New System.Drawing.Size(223, 20)
        Me.ServerLogTextBox.TabIndex = 78
        '
        'Clear_Button
        '
        Me.Clear_Button.Location = New System.Drawing.Point(519, 592)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(75, 23)
        Me.Clear_Button.TabIndex = 80
        Me.Clear_Button.Text = "Clear"
        Me.Clear_Button.UseVisualStyleBackColor = True
        '
        'RestoreNumoneComboBox
        '
        Me.RestoreNumoneComboBox.FormattingEnabled = True
        Me.RestoreNumoneComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.RestoreNumoneComboBox.Location = New System.Drawing.Point(922, 401)
        Me.RestoreNumoneComboBox.Name = "RestoreNumoneComboBox"
        Me.RestoreNumoneComboBox.Size = New System.Drawing.Size(37, 21)
        Me.RestoreNumoneComboBox.TabIndex = 86
        Me.RestoreNumoneComboBox.Text = "1"
        '
        'GridRestoreSteamTextBox
        '
        Me.GridRestoreSteamTextBox.BackColor = System.Drawing.Color.Silver
        Me.GridRestoreSteamTextBox.Location = New System.Drawing.Point(772, 450)
        Me.GridRestoreSteamTextBox.Name = "GridRestoreSteamTextBox"
        Me.GridRestoreSteamTextBox.Size = New System.Drawing.Size(223, 20)
        Me.GridRestoreSteamTextBox.TabIndex = 85
        '
        'GridRestoreSteamButton
        '
        Me.GridRestoreSteamButton.Location = New System.Drawing.Point(1001, 447)
        Me.GridRestoreSteamButton.Name = "GridRestoreSteamButton"
        Me.GridRestoreSteamButton.Size = New System.Drawing.Size(110, 23)
        Me.GridRestoreSteamButton.TabIndex = 84
        Me.GridRestoreSteamButton.Text = "Copy W/SteamID"
        Me.GridRestoreSteamButton.UseVisualStyleBackColor = True
        '
        'GridRestoreNameButton
        '
        Me.GridRestoreNameButton.Location = New System.Drawing.Point(1001, 424)
        Me.GridRestoreNameButton.Name = "GridRestoreNameButton"
        Me.GridRestoreNameButton.Size = New System.Drawing.Size(95, 23)
        Me.GridRestoreNameButton.TabIndex = 83
        Me.GridRestoreNameButton.Text = "Copy W/Name"
        Me.GridRestoreNameButton.UseVisualStyleBackColor = True
        '
        'GridRestoreNameTextBox
        '
        Me.GridRestoreNameTextBox.BackColor = System.Drawing.Color.Silver
        Me.GridRestoreNameTextBox.Location = New System.Drawing.Point(772, 424)
        Me.GridRestoreNameTextBox.Name = "GridRestoreNameTextBox"
        Me.GridRestoreNameTextBox.Size = New System.Drawing.Size(223, 20)
        Me.GridRestoreNameTextBox.TabIndex = 82
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(772, 408)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 13)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Grid BackRestore Per Sector"
        '
        'RestoreNumtwoComboBox
        '
        Me.RestoreNumtwoComboBox.FormattingEnabled = True
        Me.RestoreNumtwoComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.RestoreNumtwoComboBox.Location = New System.Drawing.Point(965, 401)
        Me.RestoreNumtwoComboBox.Name = "RestoreNumtwoComboBox"
        Me.RestoreNumtwoComboBox.Size = New System.Drawing.Size(37, 21)
        Me.RestoreNumtwoComboBox.TabIndex = 87
        Me.RestoreNumtwoComboBox.Text = "1"
        '
        'RestoreQComboBox
        '
        Me.RestoreQComboBox.FormattingEnabled = True
        Me.RestoreQComboBox.Items.AddRange(New Object() {"true", "false"})
        Me.RestoreQComboBox.Location = New System.Drawing.Point(1008, 402)
        Me.RestoreQComboBox.Name = "RestoreQComboBox"
        Me.RestoreQComboBox.Size = New System.Drawing.Size(58, 21)
        Me.RestoreQComboBox.TabIndex = 88
        Me.RestoreQComboBox.Text = "false"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(275, -3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(684, 73)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "North's Lazy SI Admin"
        '
        'RestoreForceComboBox
        '
        Me.RestoreForceComboBox.FormattingEnabled = True
        Me.RestoreForceComboBox.Items.AddRange(New Object() {"true", "false"})
        Me.RestoreForceComboBox.Location = New System.Drawing.Point(1072, 401)
        Me.RestoreForceComboBox.Name = "RestoreForceComboBox"
        Me.RestoreForceComboBox.Size = New System.Drawing.Size(58, 21)
        Me.RestoreForceComboBox.TabIndex = 91
        Me.RestoreForceComboBox.Text = "false"
        '
        'HangarSteamIDTextBox
        '
        Me.HangarSteamIDTextBox.BackColor = System.Drawing.Color.Silver
        Me.HangarSteamIDTextBox.Location = New System.Drawing.Point(397, 291)
        Me.HangarSteamIDTextBox.Name = "HangarSteamIDTextBox"
        Me.HangarSteamIDTextBox.Size = New System.Drawing.Size(223, 20)
        Me.HangarSteamIDTextBox.TabIndex = 95
        '
        'HangarSteamIDButton
        '
        Me.HangarSteamIDButton.Location = New System.Drawing.Point(626, 288)
        Me.HangarSteamIDButton.Name = "HangarSteamIDButton"
        Me.HangarSteamIDButton.Size = New System.Drawing.Size(110, 23)
        Me.HangarSteamIDButton.TabIndex = 94
        Me.HangarSteamIDButton.Text = "Copy W/SteamID"
        Me.HangarSteamIDButton.UseVisualStyleBackColor = True
        '
        'HangarNameButton
        '
        Me.HangarNameButton.Location = New System.Drawing.Point(626, 265)
        Me.HangarNameButton.Name = "HangarNameButton"
        Me.HangarNameButton.Size = New System.Drawing.Size(95, 23)
        Me.HangarNameButton.TabIndex = 93
        Me.HangarNameButton.Text = "Copy W/Name"
        Me.HangarNameButton.UseVisualStyleBackColor = True
        '
        'HangarNameTextBox
        '
        Me.HangarNameTextBox.BackColor = System.Drawing.Color.Silver
        Me.HangarNameTextBox.Location = New System.Drawing.Point(397, 265)
        Me.HangarNameTextBox.Name = "HangarNameTextBox"
        Me.HangarNameTextBox.Size = New System.Drawing.Size(223, 20)
        Me.HangarNameTextBox.TabIndex = 92
        '
        'PlayerEsteamTextBox
        '
        Me.PlayerEsteamTextBox.BackColor = System.Drawing.Color.Silver
        Me.PlayerEsteamTextBox.Location = New System.Drawing.Point(397, 363)
        Me.PlayerEsteamTextBox.Name = "PlayerEsteamTextBox"
        Me.PlayerEsteamTextBox.Size = New System.Drawing.Size(223, 20)
        Me.PlayerEsteamTextBox.TabIndex = 99
        '
        'PlayerEsteamButton
        '
        Me.PlayerEsteamButton.Location = New System.Drawing.Point(626, 360)
        Me.PlayerEsteamButton.Name = "PlayerEsteamButton"
        Me.PlayerEsteamButton.Size = New System.Drawing.Size(110, 23)
        Me.PlayerEsteamButton.TabIndex = 98
        Me.PlayerEsteamButton.Text = "Copy W/SteamID"
        Me.PlayerEsteamButton.UseVisualStyleBackColor = True
        '
        'PlayerEnameButton
        '
        Me.PlayerEnameButton.Location = New System.Drawing.Point(626, 337)
        Me.PlayerEnameButton.Name = "PlayerEnameButton"
        Me.PlayerEnameButton.Size = New System.Drawing.Size(95, 23)
        Me.PlayerEnameButton.TabIndex = 97
        Me.PlayerEnameButton.Text = "Copy W/Name"
        Me.PlayerEnameButton.UseVisualStyleBackColor = True
        '
        'PlayerEnameTextBox
        '
        Me.PlayerEnameTextBox.BackColor = System.Drawing.Color.Silver
        Me.PlayerEnameTextBox.Location = New System.Drawing.Point(397, 337)
        Me.PlayerEnameTextBox.Name = "PlayerEnameTextBox"
        Me.PlayerEnameTextBox.Size = New System.Drawing.Size(223, 20)
        Me.PlayerEnameTextBox.TabIndex = 96
        '
        'GridEnameButton
        '
        Me.GridEnameButton.Location = New System.Drawing.Point(626, 412)
        Me.GridEnameButton.Name = "GridEnameButton"
        Me.GridEnameButton.Size = New System.Drawing.Size(95, 23)
        Me.GridEnameButton.TabIndex = 101
        Me.GridEnameButton.Text = "Copy"
        Me.GridEnameButton.UseVisualStyleBackColor = True
        '
        'GridEnameTextBox
        '
        Me.GridEnameTextBox.BackColor = System.Drawing.Color.Silver
        Me.GridEnameTextBox.Location = New System.Drawing.Point(397, 412)
        Me.GridEnameTextBox.Name = "GridEnameTextBox"
        Me.GridEnameTextBox.Size = New System.Drawing.Size(223, 20)
        Me.GridEnameTextBox.TabIndex = 100
        '
        'RestoreQLabel
        '
        Me.RestoreQLabel.AutoSize = True
        Me.RestoreQLabel.Location = New System.Drawing.Point(1005, 387)
        Me.RestoreQLabel.Name = "RestoreQLabel"
        Me.RestoreQLabel.Size = New System.Drawing.Size(50, 13)
        Me.RestoreQLabel.TabIndex = 104
        Me.RestoreQLabel.Text = "Restore?"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1071, 387)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 105
        Me.Label12.Text = "Force?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(883, 563)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 106
        Me.Button1.Text = "Staff Commands"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(883, 592)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 23)
        Me.Button2.TabIndex = 107
        Me.Button2.Text = "Staff Training"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(880, 547)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Discord Links"
        '
        'HangarRemoveComboBox
        '
        Me.HangarRemoveComboBox.FormattingEnabled = True
        Me.HangarRemoveComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.HangarRemoveComboBox.Location = New System.Drawing.Point(707, 240)
        Me.HangarRemoveComboBox.Name = "HangarRemoveComboBox"
        Me.HangarRemoveComboBox.Size = New System.Drawing.Size(37, 21)
        Me.HangarRemoveComboBox.TabIndex = 109
        '
        'RenameGridButton
        '
        Me.RenameGridButton.Location = New System.Drawing.Point(626, 457)
        Me.RenameGridButton.Name = "RenameGridButton"
        Me.RenameGridButton.Size = New System.Drawing.Size(95, 23)
        Me.RenameGridButton.TabIndex = 112
        Me.RenameGridButton.Text = "Copy"
        Me.RenameGridButton.UseVisualStyleBackColor = True
        '
        'RenameGridTextBox
        '
        Me.RenameGridTextBox.BackColor = System.Drawing.Color.Silver
        Me.RenameGridTextBox.Location = New System.Drawing.Point(397, 457)
        Me.RenameGridTextBox.Name = "RenameGridTextBox"
        Me.RenameGridTextBox.Size = New System.Drawing.Size(223, 20)
        Me.RenameGridTextBox.TabIndex = 111
        '
        'RenameLabel
        '
        Me.RenameLabel.AutoSize = True
        Me.RenameLabel.Location = New System.Drawing.Point(394, 438)
        Me.RenameLabel.Name = "RenameLabel"
        Me.RenameLabel.Size = New System.Drawing.Size(66, 13)
        Me.RenameLabel.TabIndex = 110
        Me.RenameLabel.Text = "RenameGrid"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1008, 592)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 23)
        Me.Button3.TabIndex = 113
        Me.Button3.Text = "Watch List"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1008, 563)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 23)
        Me.Button4.TabIndex = 114
        Me.Button4.Text = "Bot Spam"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 637)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.RenameGridButton)
        Me.Controls.Add(Me.RenameGridTextBox)
        Me.Controls.Add(Me.RenameLabel)
        Me.Controls.Add(Me.HangarRemoveComboBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.RestoreQLabel)
        Me.Controls.Add(Me.GridEnameButton)
        Me.Controls.Add(Me.GridEnameTextBox)
        Me.Controls.Add(Me.PlayerEsteamTextBox)
        Me.Controls.Add(Me.PlayerEsteamButton)
        Me.Controls.Add(Me.PlayerEnameButton)
        Me.Controls.Add(Me.PlayerEnameTextBox)
        Me.Controls.Add(Me.HangarSteamIDTextBox)
        Me.Controls.Add(Me.HangarSteamIDButton)
        Me.Controls.Add(Me.HangarNameButton)
        Me.Controls.Add(Me.HangarNameTextBox)
        Me.Controls.Add(Me.RestoreForceComboBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.RestoreQComboBox)
        Me.Controls.Add(Me.RestoreNumtwoComboBox)
        Me.Controls.Add(Me.RestoreNumoneComboBox)
        Me.Controls.Add(Me.GridRestoreSteamTextBox)
        Me.Controls.Add(Me.GridRestoreSteamButton)
        Me.Controls.Add(Me.GridRestoreNameButton)
        Me.Controls.Add(Me.GridRestoreNameTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Clear_Button)
        Me.Controls.Add(Me.ServerLogButton)
        Me.Controls.Add(Me.ServerLogTextBox)
        Me.Controls.Add(Me.ListGridBackupComboBox)
        Me.Controls.Add(Me.Log_TypeComboBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RenameGridNewTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GridEComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PlayerEComboBox)
        Me.Controls.Add(Me.HangarComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListGridBackupSteamTextBox)
        Me.Controls.Add(Me.ListGridBackupSteamButton)
        Me.Controls.Add(Me.ListGridBackupNameButton)
        Me.Controls.Add(Me.ListGridBackupNameTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListGrid_PVE_SteamIDTextBox)
        Me.Controls.Add(Me.ListGrid_PVE_SteamIDButton)
        Me.Controls.Add(Me.Scripter_Text_RichTextBox)
        Me.Controls.Add(Me.ScripterText_Lebel)
        Me.Controls.Add(Me.Scriptertext_Button)
        Me.Controls.Add(Me.SteamID_Texbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DiscordID_TextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListGrid_PVE_NameButton)
        Me.Controls.Add(Me.ListGrid_PVE_NameTextBox)
        Me.Controls.Add(Me.ListGrid_PVE_Label)
        Me.Controls.Add(Me.GiveScripterButton)
        Me.Controls.Add(Me.GiveScripterRole_TextBox)
        Me.Controls.Add(Me.GiveScripter_Label)
        Me.Controls.Add(Me.Update_Button)
        Me.Controls.Add(Me.Copy_SteamID_Button)
        Me.Controls.Add(Me.GetSteamID_TextBox)
        Me.Controls.Add(Me.GetSteamID_Label)
        Me.Controls.Add(Me.Sector_Label)
        Me.Controls.Add(Me.Sector_ComboBox)
        Me.Controls.Add(Me.Grid_NameText)
        Me.Controls.Add(Me.Player_NameText)
        Me.Controls.Add(Me.Grid_Lebel)
        Me.Controls.Add(Me.Day_Label)
        Me.Controls.Add(Me.Month_Label)
        Me.Controls.Add(Me.Player_NameLabel)
        Me.Controls.Add(Me.Day_ComboBox)
        Me.Controls.Add(Me.Month_ComboBox)
        Me.Name = "MainWindow"
        Me.Text = "North's Lazy SI Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Month_ComboBox As ComboBox
    Friend WithEvents Day_ComboBox As ComboBox
    Friend WithEvents Player_NameLabel As Label
    Friend WithEvents Month_Label As Label
    Friend WithEvents Day_Label As Label
    Friend WithEvents Grid_Lebel As Label
    Friend WithEvents Player_NameText As TextBox
    Friend WithEvents Grid_NameText As TextBox
    Friend WithEvents Sector_ComboBox As ComboBox
    Friend WithEvents Sector_Label As Label
    Friend WithEvents GetSteamID_TextBox As TextBox
    Friend WithEvents GetSteamID_Label As Label
    Friend WithEvents Copy_SteamID_Button As Button
    Friend WithEvents Update_Button As Button
    Friend WithEvents GiveScripterButton As Button
    Friend WithEvents GiveScripterRole_TextBox As TextBox
    Friend WithEvents GiveScripter_Label As Label
    Friend WithEvents ListGrid_PVE_NameButton As Button
    Friend WithEvents ListGrid_PVE_NameTextBox As TextBox
    Friend WithEvents ListGrid_PVE_Label As Label
    Friend WithEvents DiscordID_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SteamID_Texbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Scriptertext_Button As Button
    Friend WithEvents ScripterText_Lebel As Label
    Friend WithEvents Scripter_Text_RichTextBox As RichTextBox
    Friend WithEvents ListGrid_PVE_SteamIDButton As Button
    Friend WithEvents ListGrid_PVE_SteamIDTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListGridBackupSteamTextBox As TextBox
    Friend WithEvents ListGridBackupSteamButton As Button
    Friend WithEvents ListGridBackupNameButton As Button
    Friend WithEvents ListGridBackupNameTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents HangarComboBox As ComboBox
    Friend WithEvents PlayerEComboBox As ComboBox
    Friend WithEvents GridEComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RenameGridNewTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Log_TypeComboBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ListGridBackupComboBox As ComboBox
    Friend WithEvents ServerLogButton As Button
    Friend WithEvents ServerLogTextBox As TextBox
    Friend WithEvents Clear_Button As Button
    Friend WithEvents RestoreNumoneComboBox As ComboBox
    Friend WithEvents GridRestoreSteamTextBox As TextBox
    Friend WithEvents GridRestoreSteamButton As Button
    Friend WithEvents GridRestoreNameButton As Button
    Friend WithEvents GridRestoreNameTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RestoreNumtwoComboBox As ComboBox
    Friend WithEvents RestoreQComboBox As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents RestoreForceComboBox As ComboBox
    Friend WithEvents HangarSteamIDTextBox As TextBox
    Friend WithEvents HangarSteamIDButton As Button
    Friend WithEvents HangarNameButton As Button
    Friend WithEvents HangarNameTextBox As TextBox
    Friend WithEvents PlayerEsteamTextBox As TextBox
    Friend WithEvents PlayerEsteamButton As Button
    Friend WithEvents PlayerEnameButton As Button
    Friend WithEvents PlayerEnameTextBox As TextBox
    Friend WithEvents GridEnameButton As Button
    Friend WithEvents GridEnameTextBox As TextBox
    Friend WithEvents RestoreQLabel As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents HangarRemoveComboBox As ComboBox
    Friend WithEvents RenameGridButton As Button
    Friend WithEvents RenameGridTextBox As TextBox
    Friend WithEvents RenameLabel As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer1 As Timer
End Class
