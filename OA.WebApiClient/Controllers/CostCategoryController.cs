using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OA.Service_.Toural.Contracts.Cost;
using OA.Service_.Toural.ViewModels.Cost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WebApiClient.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CostCategoryController : BaseController
    {
        private readonly ICostCategoryService _service;
        public CostCategoryController(ICostCategoryService service, IServiceProvider serviceProvider, IConfiguration Configuration)
            : base(serviceProvider, Configuration)
        {
            this._service = service;
        }
        [Route("GetAll")]
        [HttpGet]
        public async Task<CostVM> GetAll()
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

        [Route("Remove/{Id}")]
        [HttpGet]
        public async Task<CostVM> Remove(long Id)
        {
            await Task.FromResult(0);
            return _service.Remove(Id);
        }

        [Route("Active/{Id}")]
        [HttpGet]
        public async Task<CostVM> Active(long Id)
        {
            await Task.FromResult(0);
            return _service.Active(Id);
        }


        [Route("Insert")]
        [HttpPost]
        public async Task<CostVM> Insert(CostCategoryDto body)
        {
            await Task.FromResult(0);
            return _service.Insert(body);
        }

        [Route("Edit")]
        [HttpPut]
        public async Task<CostVM> Edit(CostCategoryDto body)
        {
            await Task.FromResult(0);
            return _service.Edit(body);
        }

        [Route("Search")]
        [HttpGet]
        public async Task<CostVM> Search([FromQuery] CostCategoryDto body)
        {
            await Task.FromResult(0);
            return _service.Search(body);
        }

        [Route("RemoveByIds")]
        [HttpPut]
        public async Task<CostVM> RemoveByIds([FromBody] CostCategoryDto ids)
        {
            await Task.FromResult(0);
            return _service.Remove(ids.ids);
        }
    }
}
