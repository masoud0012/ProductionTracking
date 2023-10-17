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
    public class InitialBalanceController : BaseController
    {
        private readonly IInitialBalanceService _initialBalanceService;

        public InitialBalanceController(IInitialBalanceService initialBalanceService, IServiceProvider serviceProvider, IConfiguration Configuration)
            : base(serviceProvider, Configuration)
        {
            _initialBalanceService = initialBalanceService;

        }

        [Route("EditBalanceStock")]
        [HttpPut]
        public async Task<InitialBalanceVM> EditBalanceStock([FromBody] InitialBalancePoco body)
        {
            await Task.FromResult(0);
            return _initialBalanceService.EditBalanceStock(body);
        }

        [Route("GetQuantityStock/{Id}")]
        [HttpGet]
        public async Task<InitialBalanceVM> GetQuantityStock(long Id)
        {
            await Task.FromResult(0);
            var result = _initialBalanceService.GetBalanceStockByID(Id);
            return result;
        }


        [Route("Edit")]
        [HttpPut]
        public async Task<InitialBalanceVM> Edit(IFormFile file)
        {
            await Task.FromResult(0);
            var body = new InitialBalancePoco();
            var data = JsonConvert.DeserializeObject<InitialBalancePoco>(Request.Form["body"]);
            return _initialBalanceService.Update(data, file);
        }

        [Route("Insert")]
        [HttpPost]
        public async Task<InitialBalanceVM> Insert(IFormFile file)
        {
            await Task.FromResult(0);
            var body = new InitialBalancePoco();
            var data = JsonConvert.DeserializeObject<InitialBalancePoco>(Request.Form["body"]);
            return _initialBalanceService.Insert(data, file,null);
        }


        [Route("RemoveByIds")]
        [HttpPut]
        public async Task<InitialBalanceVM> RemoveByIds([FromBody] InitialBalancePoco ids)
        {
            await Task.FromResult(0);
            return _initialBalanceService.Remove(ids.ids);
        }

        [Route("Search")]
        [HttpGet]
        public async Task<InitialBalanceVM> Search([FromQuery] InitialBalancePoco body)
        {
            await Task.FromResult(0);
            return _initialBalanceService.SearchBy(body);
        }

        [Route("SearchAutoComplete")]
        [HttpGet]
        public async Task<InitialBalanceVM> SearchAutComplete([FromQuery] InitialBalancePoco body)
        {
            await Task.FromResult(0);
            return _initialBalanceService.SearchAutoComplete(body);
        }

        [Route("SearchAutoCompleteExceptIds")]
        [HttpPost]
        public async Task<InitialBalanceVM> SearchAutoCompleteExceptIds(InitialBalancePoco body)
        {
            await Task.FromResult(0);
            return _initialBalanceService.SearchAutoCompleteExcept(body);
        }

        [Route("SearchAutoCompleteByID/{Id}")]
        [HttpGet]
        public async Task<InitialBalanceVM> SearchAutoCompleteByID(Int64 ID)
        {
            await Task.FromResult(0);
            return _initialBalanceService.SearchAutoCompleteByID(ID);
        }

        [Route("Get/{Id}")]
        public async Task<InitialBalanceVM> GetBalanceByID( Int64 Id)
        {
            await Task.FromResult(0);
            return _initialBalanceService.GetByID(Id);
        }

        [HttpGet("GetAll")]
        public async Task<InitialBalanceVM> GetAll()
        {
            await Task.FromResult(0);
            return _initialBalanceService.GetAll();
        }

        [Route("Remove/{Id}")]
        [HttpGet]
        public async Task<InitialBalanceVM> Remove(long Id)
        {
            await Task.FromResult(0);
            return _initialBalanceService.Remove(Id);
        }

        [Route("SearchFinalProducts")]
        [HttpGet]
        public async Task<InitialBalanceVM> SearchFinalProducts([FromQuery] InitialBalancePoco body)
        {
            await Task.FromResult(0);
            return _initialBalanceService.SearchFinalProduct(body);
        }


        [Route("PrintExcel")]
        [HttpGet]
        public FileContentResult PrintExcel()
        {
            var excelFile = _initialBalanceService.PrintExcel();
            return File(excelFile.Content, excelFile.contentType, excelFile.fileName);
        }

        [Route("GetWastage/{Id}")]
        [HttpGet]
        public async Task<InitialBalanceVM> GetWastage(long Id)
        {
            await Task.FromResult(0);
            return _initialBalanceService.GetWestage(new InitialBalancePoco {ID=Id });
        }

        [Route("PrintWastage/{Id}")]
        [HttpGet]
        public FileContentResult PrintWastage(long Id)
        {
            var excelFile = _initialBalanceService.PrintWastage(new InitialBalancePoco { ID=Id});
            return File(excelFile.Content, excelFile.contentType, excelFile.fileName);
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
