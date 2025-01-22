Imports ThoughtWorks.QRCode.Codec
Imports System.Drawing
Imports System.Drawing.Imaging






Public Class Form1
    Dim objQRCode As QRCodeEncoder = New QRCodeEncoder()
    Dim imgImage As Image
    Dim objBitmap As Bitmap

 

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        objQRCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
        objQRCode.QRCodeScale = 4
        objQRCode.QRCodeVersion = 5
        objQRCode.QRCodeErrorCorrect = ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.L
        imgImage = objQRCode.Encode(TextBox1.Text)
        objBitmap = New Bitmap(imgImage)
        'objBitmap.Save("C:\Users\ADMIN\Desktop\Barcodefull\MHBSQrcode\QRCode.jpeg")
        PictureBox1.Image = New Bitmap(imgImage)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Text As String = TextBox1.Text
        Dim FontColor As Color = Color.Blue
        Dim BackColor As Color = Color.Yellow
        Dim FontName As String = "Times New Roman"
        Dim FontSize As Integer = 14
        Dim Height As Integer = 40
        Dim Width As Integer = 200
        Dim FileName As String = "MyImage"
        Dim objBitmap As New Bitmap(Width, Height)
        Dim objGraphics As Graphics = Graphics.FromImage(objBitmap)
        Dim objColor As Color
        Dim objFont As New Font(FontName, FontSize)
        'Following PointF object defines where the text will be displayed in the
        'specified area of the image
        Dim objPoint As New PointF(5.0F, 5.0F)
        Dim objBrushForeColor As New SolidBrush(FontColor)
        Dim objBrushBackColor As New SolidBrush(BackColor)
        objGraphics.FillRectangle(objBrushBackColor, 0, 0, Width, Height)
        objGraphics.DrawString(Text, objFont, objBrushForeColor, objPoint)
        objBitmap.Save(Application.StartupPath & FileName & ".JPG", ImageFormat.Jpeg)
        PictureBox1.Image = objBitmap

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim format As StringFormat = New StringFormat()
        Dim g As Graphics
        Dim MyRect As Rectangle = New Rectangle(0, 0, 100, 100)
        Dim MyGraphics As Graphics = Me.CreateGraphics()
        Dim MyImg As Image = New Bitmap(MyRect.Width, MyRect.Height, MyGraphics)
        Dim imageGraphics As Graphics = Graphics.FromImage(MyImg)
        Dim FontName As String = "Times New Roman"
        Dim FontSize As Integer = 14
        Dim objFont As New Font(FontName, FontSize)
        'imageGraphics.FillRectangle(Brushes.Black, MyRect)
        'Dim imagegraphics As Image
        format.Alignment = StringAlignment.Center
        format.LineAlignment = StringAlignment.Center
        imageGraphics.DrawString("Hello Everyone", objFont, Brushes.Black, RectangleF.op_Implicit(MyRect)) 'objfont is of type Font
        'imageGraphics.DrawString("Drawing to an image", "Times New Roman", Brushes.Black, RectangleF.op_Implicit(MyRect), format) //The function has more arguments.
        MyGraphics.DrawImage(MyImg, MyRect)
        'g.DrawImage(MyImg, MyRect) // g does not have function by name draw image
        MyImg.Save("C:\Users\ADMIN\Desktop\Barcodefull\MHBSQrcode\Signature.tiff")
        PictureBox1.Image = New Bitmap(MyImg)

        objQRCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
        objQRCode.QRCodeScale = 4
        objQRCode.QRCodeVersion = 5
        objQRCode.QRCodeErrorCorrect = ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.L
        imgImage = objQRCode.Encode(TextBox1.Text)
        objBitmap = New Bitmap(imgImage)
        'objBitmap.Save("C:\Users\ADMIN\Desktop\Barcodefull\MHBSQrcode\QRCode.jpeg")
        PictureBox1.Image = New Bitmap(imgImage)

    End Sub
End Class
