Public Class Form1

    Private Sub ColorfirstToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorfirstToolStripMenuItem.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub

    Private Sub BackcolorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackcolorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then RichTextBox1.SelectionBackColor = ColorDialog1.Color
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then RichTextBox1.SelectionColor = FontDialog1.Color : RichTextBox1.SelectionFont = FontDialog1.Font
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Dock = DockStyle.Fill
        FontDialog1.ShowColor = True
        ColorDialog1.FullOpen = True
        OpenFileDialog1.Filter = "rtf(*.rtf)|*.rtf| word(*.doc or *.docx)|*.doc;docx|all file|*.*" '使用者看的文字|程式看的|使用者看的文字|程式看的(都用|隔開)
        SaveFileDialog1.Filter = "rtf(*.rtf)|*.rtf| word(*.doc or *.docx)|*.doc;docx"
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        RichTextBox1.Text = ""
    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
