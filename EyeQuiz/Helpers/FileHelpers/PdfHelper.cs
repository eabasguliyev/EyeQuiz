using System.Collections.Generic;
using System.Drawing;
using EyeQuiz.Entities;
using EyeQuiz.Enums;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using Image = iText.Layout.Element.Image;

namespace EyeQuiz.Helpers.FileHelpers
{
    public static class PdfHelper
    {
        public static void ManipulatePdf(string dest, QuizResult quizResult)
        {
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(dest));
            Document doc = new Document(pdfDoc);
            Table table = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth();

            table.SetWidth(500);


            foreach (var bitmap in quizResult.QuestionImages)
            {
                Image img = new Image(ImageDataFactory.Create((System.Drawing.Image) bitmap, null));
                img.SetAutoScaleWidth(true);

                table.AddCell(img);
            }

            doc.Add(table);

            var spacer = new Paragraph();

            doc.Add(spacer);
            doc.Add(spacer);

            Table resultTable = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth();
            
            resultTable.AddCell($"Correct answers: {quizResult.result.Results[AnswerStatus.CorrectAnswer]}");
            resultTable.AddCell($"Not sure answers: {quizResult.result.Results[AnswerStatus.NotSure]}");
            resultTable.AddCell($"Incorrect answers: {quizResult.result.Results[AnswerStatus.IncorrectAnswer]}");
            resultTable.AddCell($"Not answered: {quizResult.result.Results[AnswerStatus.NotAnswered]}");

            resultTable.SetWidth(500);

            Image resultImage = new Image(ImageDataFactory.Create((System.Drawing.Image)quizResult.Result, null));
            resultImage.SetAutoScaleWidth(true);

            resultTable.AddCell(resultImage);

            doc.Add(resultTable);

            doc.Close();
        }
    }
}