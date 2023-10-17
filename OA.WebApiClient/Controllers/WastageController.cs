using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OA.Service_.Toural.Contracts;
using OA.Service_.Toural.ViewModels.InitialBalance;
using System;
using System.Threading.Tasks;

namespace OA.WebApiClient.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WasstageController : BaseController
    {
        private readonly IInitialBalanceService _initialBalanceService;

        public WasstageController(IInitialBalanceService initialBalanceService, IServiceProvider serviceProvider, IConfiguration Configuration)
            : base(serviceProvider, Configuration)
        {
            _initialBalanceService = initialBalanceService;

        }

        [Route("SearchWastage")]
        [HttpGet]
        public async Task<InitialBalanceVM> SearchWastage([FromQuery] InitialBalancePoco body)
        {
            await Task.FromResult(0);
            return _initialBalanceService.SearchWastage(body);
        }

        [Route("PrintWastageExcel")]
        [HttpGet]
        public FileContentResult PrintWastageExcel([FromQuery] InitialBalancePoco body)
        {
            var excelFile = _initialBalanceService.PrintWastage();
            return File(excelFile.Content, excelFile.contentType, excelFile.fileName);
        }

    }
}
