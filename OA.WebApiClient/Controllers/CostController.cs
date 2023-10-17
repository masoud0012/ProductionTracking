using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OA.Service_.Toural.Contracts.ControllerService;
using OA.Service_.Toural.Contracts.Cost;
using OA.Service_.Toural.ViewModels.Cost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OA.WebApiClient.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CostController : BaseController
    {
        private readonly ICostService _service;

        public CostController(ICostService service, IServiceProvider serviceProvider, IConfiguration Configuration)
            : base(serviceProvider, Configuration)
        {
            _service = service;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<CostVM> GetAll([FromQuery] CostDto body)
        {
            await Task.FromResult(0);
            return _service.GetAll();
        }
        [Route("Get/{Id}")]
        [HttpGet]
        public async Task<CostVM> GetById(long Id)
        {
            await Task.FromResult(0);
            return _service.GetByID(Id);
        }

        [Route("RunJob/{Id}")]
        [HttpGet]
        public async Task<CostVM> RunJob(long Id)
        {
            await Task.FromResult(0);
            return _service.CalculateCostPerMonth();
        }

        [Route("Remove/{Id}")]
        [HttpGet]
        public async Task<CostVM> Remove(long Id)
        {
            await Task.FromResult(0);
            return _service.Remove(Id);
        }

        [Route("Insert")]
        [HttpPost]
        public async Task<CostVM> Insert(CostDto body)
        {
            await Task.FromResult(0);
            return _service.Insert(body);
        }

        [Route("Edit")]
        [HttpPut]
        public async Task<CostVM> Edit(CostDto body)
        {
            await Task.FromResult(0);
            return _service.Edit(body);
        }

        [Route("Search")]
        [HttpGet]
        public async Task<CostVM> Search([FromQuery] CostDto body)
        {
            await Task.FromResult(0);
            return _service.Search(body);
        }

        [Route("PrintExcel")]
        [HttpGet]
        public FileContentResult PrintExcel()
        {
            var excelFile = _service.PrintExcel();
            return File(excelFile.Content, excelFile.contentType, excelFile.fileName);
        }

        [Route("RemoveByIds")]
        [HttpPut]
        public async Task<CostVM> RemoveByIds([FromBody] CostDto ids)
        {
            await Task.FromResult(0);
            return _service.Remove(ids.ids);
        }
    }
}
