<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scripter_Text
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scripter_Text))
        Me.Scripter_Text_RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Scripter_Text_RichTextBox
        '
        Me.Scripter_Text_RichTextBox.Location = New System.Drawing.Point(12, 65)
        Me.Scripter_Text_RichTextBox.Name = "Scripter_Text_RichTextBox"
        Me.Scripter_Text_RichTextBox.Size = New System.Drawing.Size(871, 364)
        Me.Scripter_Text_RichTextBox.TabIndex = 38
        Me.Scripter_Text_RichTextBox.Text = resources.GetString("Scripter_Text_RichTextBox.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 55)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Scripter Text"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(381, 455)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 43)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Update text"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Scripter_Text
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 505)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Scripter_Text_RichTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Scripter_Text"
        Me.Text = "Scripter Text"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Scripter_Text_RichTextBox As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
