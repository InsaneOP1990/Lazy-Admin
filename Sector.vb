Public Class Sector
    Private Sub Sector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = My.Settings.SectorDrop

        Dim sectorlist As String = My.Settings.SectorDrop
        Dim sectorlistarray() As String = Split(sectorlist, ",")

        Sector_ComboBox.Items.Clear()
        Sector_ComboBox.Items.AddRange(sectorlistarray.ToArray)

        My.Settings.SectorDrop = RichTextBox1.Text
        Dim sector As String = Sector_ComboBox.Text
        Dim sectorArray() As String = Split(sector)
        TextBox1.Text = sectorArray.First
        TextBox2.Text = sectorArray(2)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Settings.SectorDrop = RichTextBox1.Text
        Dim sector As String = Sector_ComboBox.Text
        Dim sectorArray() As String = Split(sector)
        TextBox1.Text = sectorArray.First
        TextBox2.Text = sectorArray(2)

        '--------------------------------------
        Dim sectorlist As String = My.Settings.SectorDrop
        Dim sectorlistarray() As String = Split(sectorlist, ",")

        Sector_ComboBox.Items.Clear()
        Sector_ComboBox.Items.AddRange(sectorlistarray.ToArray)


    End Sub

    Private Sub Sector_ComboBox_TextChanged(sender As Object, e As EventArgs) Handles Sector_ComboBox.TextChanged
        Dim sector As String = Sector_ComboBox.Text
        Dim sectorArray() As String = Split(sector)
        TextBox1.Text = sectorArray.First
        TextBox2.Text = sectorArray(2)
    End Sub

    Private Sub Sector_ComboBox_TextUpdate(sender As Object, e As EventArgs) Handles Sector_ComboBox.TextUpdate

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class