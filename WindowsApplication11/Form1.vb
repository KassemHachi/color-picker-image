Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        Try
            Dim COLOR1 As Color
            Dim x As Integer = 0
            Dim y As Integer = 0
            Dim Image1 As New Bitmap(PictureBox1.Image, PictureBox1.Width, PictureBox1.Height)
            For x = 0 To PictureBox1.Width
            Next
            For y = 0 To PictureBox1.Height
            Next
            COLOR1 = New Bitmap(Image1).GetPixel(e.X, e.Y)
            Me.BackColor = COLOR1
            Dim s As String = "#"
            s += COLOR1.ToArgb.ToString("X6")
            s = s.Remove(1, 2)

            TextBox1.Text = s
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clipboard.SetText(TextBox1.Text)
    End Sub
End Class
