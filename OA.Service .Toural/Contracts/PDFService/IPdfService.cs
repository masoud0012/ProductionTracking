using OA.Service_.Toural.ViewModels.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Contracts.PDFService
{
    public  interface IPdfService
    {
        ProcessVM ProcessPDF(ProcessDto processDto);
    }
}
