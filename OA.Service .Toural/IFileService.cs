using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural
{
    public  interface IFileService
    {
        string Upload(IFormFile file);
    }
}
