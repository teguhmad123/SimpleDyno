Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class Screenshot
    Public Sub CaptureControl(control As Control, outputPath As String)
        ' Buat Bitmap dengan ukuran yang sama seperti elemen kontrol
        Dim bmp As New Bitmap(control.Width, control.Height)

        ' Gambar kontrol ke Bitmap
        control.DrawToBitmap(bmp, New System.Drawing.Rectangle(0, 0, control.Width, control.Height))

        ' Simpan Bitmap ke file
        bmp.Save(outputPath, ImageFormat.Png)
        MessageBox.Show($"Screenshot saved to {outputPath}")

        ' Bersihkan objek Bitmap dari memori
        bmp.Dispose()
    End Sub
    Public Sub ConvertElementToPDF(control As Control, pdfPath As String)
        ' Tangkap elemen ke Bitmap
        Dim bmp As New Bitmap(control.Width, control.Height)
        control.DrawToBitmap(bmp, New System.Drawing.Rectangle(0, 0, control.Width, control.Height))

        ' Konversi Bitmap ke PDF menggunakan iTextSharp
        Dim document As New iTextSharp.text.Document(New iTextSharp.text.Rectangle(330 / 25.4 * 72, 210 / 25.4 * 72))
        PdfWriter.GetInstance(document, New FileStream(pdfPath, FileMode.Create))
        document.Open()
        Dim img As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(bmp, Imaging.ImageFormat.Png)
        'img.ScaleToFit(CSng(document.PageSize.Width - (20 / 25.4 * 72)), CSng(document.PageSize.Height - (20 / 25.4 * 72)))
        img.ScaleToFit(document.PageSize.Width, document.PageSize.Height)
        img.Alignment = Element.ALIGN_CENTER
        img.BorderWidth = 20
        img.BorderColor = iTextSharp.text.Color.BLACK
        document.Add(img)

        document.Close()

        MessageBox.Show($"PDF saved at {pdfPath}")

        ' Bersihkan objek Bitmap
        bmp.Dispose()
    End Sub
End Class
