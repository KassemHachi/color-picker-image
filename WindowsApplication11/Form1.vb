Public Class Form1
    Dim pathApp As String = My.Application.Info.DirectoryPath

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
            previewColor.BackColor = COLOR1
            Dim s As String = "#"
            s += COLOR1.ToArgb.ToString("X6")
            s = s.Remove(1, 2)
            colorCode.Text = s
            RColor.Value = COLOR1.R
            GColor.Value = COLOR1.G
            BColor.Value = COLOR1.B
            rgbCode.Text = ("rgb(" + COLOR1.R.ToString + "," + COLOR1.G.ToString + "," + COLOR1.B.ToString + ")")
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
        Try
            Clipboard.SetText(colorCode.Text)
            MsgBox("Color was copied !")
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Clipboard.SetText(rgbCode.Text)
            MsgBox("Color was copied !")
        Catch ex As Exception

        End Try
    End Sub
End Class
