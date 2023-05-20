using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using System.IO;
using UnityEngine;

public class PrintProcess : MonoBehaviour
{
    public string pathOfImage = Application.streamingAssetsPath+ "/Umais.jpg";

    private void Start()
    {
        CreationPDF();
    }

    public void CreationPDF()
    {
        ///create pdf
        PdfDocument pdfDoc = new PdfDocument();

        ///Add a page to the document.
        PdfPage page = pdfDoc.Pages.Add();

        ///Create PDF graphics for the page.
        PdfGraphics graphics = page.Graphics;

        ///Set the standard font and size and other things.
        PdfFont font1 = new PdfStandardFont(PdfFontFamily.Helvetica, 25, PdfFontStyle.Bold);//main heading
        PdfFont font2 = new PdfStandardFont(PdfFontFamily.Helvetica, 20, PdfFontStyle.Bold);//sub main heading
        PdfFont font3 = new PdfStandardFont(PdfFontFamily.Helvetica, 15, PdfFontStyle.Bold);//label heading
        PdfFont font4 = new PdfStandardFont(PdfFontFamily.Helvetica, 12/*, PdfFontStyle.Underline*/);//label heading
        PdfCheckBoxField checkBoxField = new PdfCheckBoxField(page, "CheckBox");//checkbox
        PdfPen pdfPen = new PdfPen(Syncfusion.Drawing.Color.Black, 1);
        Stream imageStream = File.OpenRead(pathOfImage);
        PdfBitmap image = new PdfBitmap(imageStream);

        ///writing in pixel page-width(0-350)
        //image
        graphics.DrawImage(image, 390, 80, 100, 100);
        //heading
        //graphics.DrawString("Uamis.. Builder", font1, PdfBrushes.Black, new Syncfusion.Drawing.PointF(175, 0));
        graphics.DrawString("Registration Form", font2, PdfBrushes.Black, new Syncfusion.Drawing.PointF(186, 30));
        //project
        graphics.DrawString("Project Name: ", font3, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, 80));
        graphics.DrawLine(pdfPen, new Syncfusion.Drawing.PointF(110, 95), new Syncfusion.Drawing.PointF(360, 95));
        graphics.DrawString("Anwaria builder", font4, PdfBrushes.Black, new Syncfusion.Drawing.PointF(110, 80));
        //plot no.
        graphics.DrawString("Plot No.: ", font3, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, 110));
        graphics.DrawLine(pdfPen, new Syncfusion.Drawing.PointF(110, 125), new Syncfusion.Drawing.PointF(360, 125));
        graphics.DrawString("223", font4, PdfBrushes.Black, new Syncfusion.Drawing.PointF(110, 110));
        //block no.
        graphics.DrawString("Block No.: ", font3, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, 140));
        graphics.DrawLine(pdfPen, new Syncfusion.Drawing.PointF(110, 155), new Syncfusion.Drawing.PointF(360, 155));
        graphics.DrawString("222", font4, PdfBrushes.Black, new Syncfusion.Drawing.PointF(110, 140));
        //occupation
        graphics.DrawString("Occupation: ", font3, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, 170));
        graphics.DrawLine(pdfPen, new Syncfusion.Drawing.PointF(110, 185), new Syncfusion.Drawing.PointF(360, 185));
        graphics.DrawString("Goverment Officer", font4, PdfBrushes.Black, new Syncfusion.Drawing.PointF(110, 170));
        //DOB
        graphics.DrawString("Date of Birth: ", font3, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, 200));
        graphics.DrawLine(pdfPen, new Syncfusion.Drawing.PointF(110, 215), new Syncfusion.Drawing.PointF(360, 215));
        graphics.DrawString("12-12-2022", font4, PdfBrushes.Black, new Syncfusion.Drawing.PointF(110, 200));
        //File no.
        graphics.DrawString("File No.: ", font3, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, 230));
        graphics.DrawLine(pdfPen, new Syncfusion.Drawing.PointF(110, 245), new Syncfusion.Drawing.PointF(360, 245));
        graphics.DrawString("155", font4, PdfBrushes.Black, new Syncfusion.Drawing.PointF(110, 230));
        //Size.
        graphics.DrawString("Size: ", font3, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, 260));
        graphics.DrawLine(pdfPen, new Syncfusion.Drawing.PointF(110, 275), new Syncfusion.Drawing.PointF(360, 275));
        graphics.DrawString("5 ekar", font4, PdfBrushes.Black, new Syncfusion.Drawing.PointF(110, 260));
        //Name
        graphics.DrawString("Name: ", font3, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, 290));
        graphics.DrawLine(pdfPen, new Syncfusion.Drawing.PointF(110, 305), new Syncfusion.Drawing.PointF(360, 305));
        graphics.DrawString("Riyam Sarfaraz", font4, PdfBrushes.Black, new Syncfusion.Drawing.PointF(110, 290));
        //CNIC
        graphics.DrawString("CNIC: ", font3, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, 320));
        graphics.DrawLine(pdfPen, new Syncfusion.Drawing.PointF(110, 335), new Syncfusion.Drawing.PointF(360, 335));
        graphics.DrawString("12451245784532", font4, PdfBrushes.Black, new Syncfusion.Drawing.PointF(110, 320));
        //Contact
        graphics.DrawString("Contact: ", font3, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, 350));
        graphics.DrawLine(pdfPen, new Syncfusion.Drawing.PointF(110, 365), new Syncfusion.Drawing.PointF(230, 365));
        graphics.DrawString("03325698745", font4, PdfBrushes.Black, new Syncfusion.Drawing.PointF(110, 350));
        //Refered By
        graphics.DrawString("Referred By: ", font3, PdfBrushes.Black, new Syncfusion.Drawing.PointF(250, 350));
        graphics.DrawLine(pdfPen, new Syncfusion.Drawing.PointF(360, 365), new Syncfusion.Drawing.PointF(470, 365));
        graphics.DrawString("Ahmed", font4, PdfBrushes.Black, new Syncfusion.Drawing.PointF(360, 350));
        //Address
        graphics.DrawString("Address: ", font3, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, 380));
        graphics.DrawLine(pdfPen, new Syncfusion.Drawing.PointF(110, 395), new Syncfusion.Drawing.PointF(470, 395));
        graphics.DrawString("CC6 Block-D Al-Falah Society Extenssion Malir Halt Karachi", font4, PdfBrushes.Black, new Syncfusion.Drawing.PointF(110, 380));
        //Category
        graphics.DrawString("Category: ", font3, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, 410));
        graphics.DrawLine(pdfPen, new Syncfusion.Drawing.PointF(110, 425), new Syncfusion.Drawing.PointF(230, 425));
        graphics.DrawString("Residential", font4, PdfBrushes.Black, new Syncfusion.Drawing.PointF(110, 410));
        //Cash -> Create Check Box field.
        graphics.DrawString("On Cash: ", font3, PdfBrushes.Black, new Syncfusion.Drawing.PointF(250, 410));
        ///Set Check box properties and Add the form field to the document.
        checkBoxField.Bounds = new Syncfusion.Drawing.RectangleF(360, 415, 12, 12);
        checkBoxField.Style = PdfCheckBoxStyle.Check;
        checkBoxField.Checked = true;
        pdfDoc.Form.Fields.Add(checkBoxField);

        ///Create the stream object.
        MemoryStream stream = new MemoryStream();

        ///Save the document into memory stream.
        pdfDoc.Save(stream);

        ///If the position is not set to '0' then the PDF will be empty.
        stream.Position = 0;

        ///Close the document.
        string path = Application.streamingAssetsPath + "/Sample.pdf";
        File.WriteAllBytes(path, stream.ToArray());

        ///open pdf
        System.Diagnostics.Process.Start(path);
    }
}
