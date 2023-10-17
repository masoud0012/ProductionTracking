using Microsoft.AspNetCore.Hosting;
using OA.Service_.Toural.Contracts.PDFService;
using OA.Service_.Toural.ViewModels.Process;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.PdfService
{
    public class PdfService : IPdfService
    {
        private IHostingEnvironment Environment;

        public PdfService(IHostingEnvironment _environment)
        {
            Environment = _environment;
        }
        public ProcessVM ProcessPDF(ProcessDto processDto)
        {

            var result = new ProcessVM();
            //using (var document = new Document(PageSize.A4))
            //{
            //    string wwwPath = this.Environment.WebRootPath;
            //    string contentPath = this.Environment.ContentRootPath;
            //    var x = wwwPath + "/process.pdf";
            //    var writer = PdfWriter.GetInstance(document, new FileStream(contentPath+"\\Resources\\pdf\\"+"Sample-PDF-File.pdf", FileMode.Create));
            //    document.Open();

            //    document.Add(new Paragraph("Test"));

            //    PdfContentByte cb = writer.DirectContent;
            //    BaseFont bf = BaseFont.CreateFont();
            //    cb.BeginText();
            //    cb.SetFontAndSize(bf, 12);
            //    cb.MoveText(88.66f, 367);
            //    cb.ShowText("ld");
            //    cb.MoveText(-22f, 0);
            //    cb.ShowText("Wor");
            //    cb.MoveText(-15.33f, 0);
            //    cb.ShowText("llo");
            //    cb.MoveText(-15.33f, 0);
            //    cb.ShowText("He");
            //    cb.EndText();

            //    PdfTemplate tmp = cb.CreateTemplate(250, 25);
            //    tmp.BeginText();
            //    tmp.SetFontAndSize(bf, 12);
            //    tmp.MoveText(0, 7);
            //    tmp.ShowText("Hello People");
            //    tmp.EndText();
            //    cb.AddTemplate(tmp, 36, 343);

            //    readPdf();
            return result;

        }
    }

    //private static void readPdf()
    //{
    //    //var reader = new PdfReader("./wwwRoot/process.pdf");
    //    //int intPageNum = reader.NumberOfPages;
    //    //for (int i = 1; i <= intPageNum; i++)
    //    //{
    //    //    byte[] contentBytes = reader.GetPageContent(i);
    //    //    File.WriteAllBytes("page-" + i + ".txt", contentBytes);
    //    //}
    //    //reader.Close();
    //}
}
