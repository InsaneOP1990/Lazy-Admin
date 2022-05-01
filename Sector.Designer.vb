<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sector))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Sector_ComboBox = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 141)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(554, 448)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(223, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(67, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(204, 600)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 74)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save Sector list"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Sector_ComboBox
        '
        Me.Sector_ComboBox.DropDownHeight = 470
        Me.Sector_ComboBox.FormattingEnabled = True
        Me.Sector_ComboBox.IntegralHeight = False
        Me.Sector_ComboBox.Items.AddRange(New Object() {"ALL - - - All servers except the lobby. Senior Staff / Admin Only", "---------------------------------", "PVE - - - Any server that is Avalon (Planets Space KotH's)", "PVP - - - Any server that is Dead Worlds (Planets Space KotH's)", "NPC - - - Both Roach servers,", "---------------------------------", "tL - 1 - The Lobby server - Lobby Sector", "---------------------------------", "gS - 2 - Deep Space / General Sector or the everywhere else", "aS - 10 - Avalon Space Sector", "aS1 -12 - Avalon Space Inner 1 Dover Space", "aS2 - 13 - Avalon Space Inner 2 IK006 Space", "aS3 - 14 - Avalon Space Inner 3 Pelmuth Space", "wS - 51 - Waterloo Space Sector", "", "aDV - 11 - Avalon Dover Planet Sector", "aIK  - 15 - Avalon IK006 Planet Sector", "aPL - 17 - Avalon Pelmuth Planet Sector", "wP - 52 - Waterloo Planet Sector", "---------------------------------", "dS - 20 - Dead Worlds Space Sector", "dP - 21 - Dead Worlds Planets Sector", "", "dK - 22 - Dead Worlds Space KotH Sector", "cK - 23 - Crypt KotH Sector", "---------------------------------", "rI - 40 - Roach Inner Sector", "rO - 41 - Roach Outter Sector", "---------------------------------", "tR - 50 - Transit Server between Roach and Avalon / DW ", "---------------------------------", "sL - - - Special Lobby bot for scripting use and other powers. (Dont put a space " &
                "after the prefix here)", "tK --- The Space KotH Bot used by scripts to reset KotH", "tC --- The Crypt KotH Bot used by scripts to reset KotH", "tS --- Transit Server for use with Tech Bot"})
        Me.Sector_ComboBox.Location = New System.Drawing.Point(152, 2)
        Me.Sector_ComboBox.MaxDropDownItems = 21
        Me.Sector_ComboBox.Name = "Sector_ComboBox"
        Me.Sector_ComboBox.Size = New System.Drawing.Size(307, 21)
        Me.Sector_ComboBox.TabIndex = 4
        Me.Sector_ComboBox.Text = "tL - The Lobby server - Lobby Sector."
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(309, 61)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(62, 20)
        Me.TextBox2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(220, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Sector - SeverID - description "","""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Below is the format each line needs a comma at the end"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Server Prefix"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(306, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Server ID"
        '
        'Sector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 686)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Sector_ComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Sector"
        Me.Text = "Sector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Sector_ComboBox As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
