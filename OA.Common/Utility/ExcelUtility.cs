using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Common.Utility
{
    public  class ExcelUtility
    {
        //public void DownloadExcelDocument()
        //{
        //    string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        //    string fileName = "authors.xlsx";
        //    try
        //    {
        //        using (var workbook = new XLWorkbook())
        //        {
        //            IXLWorksheet worksheet =
        //            workbook.Worksheets.Add("Authors");
        //            worksheet.Cell(1, 1).Value = "Id";
        //            worksheet.Cell(1, 2).Value = "FirstName";
        //            worksheet.Cell(1, 3).Value = "LastName";
        //            for (int index = 1; index <= authors.Count; index++)
        //            {
        //                worksheet.Cell(index + 1, 1).Value =
        //                authors[index - 1].Id;
        //                worksheet.Cell(index + 1, 2).Value =
        //                authors[index - 1].FirstName;
        //                worksheet.Cell(index + 1, 3).Value =
        //                authors[index - 1].LastName;
        //            }
        //            using (var stream = new MemoryStream())
        //            {
        //                workbook.SaveAs(stream);
        //                var content = stream.ToArray();
        //                return File(content, contentType, fileName);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Error();
        //    }
        //}
    }
}
