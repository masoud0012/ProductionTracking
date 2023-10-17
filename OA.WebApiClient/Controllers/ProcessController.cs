using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OA.Service_.Toural.Contracts.Process;
using OA.Service_.Toural.ViewModels.InitialBalance;
using OA.Service_.Toural.ViewModels.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WebApiClient.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessController : BaseController
    {
        private readonly IProcessService _service;
        public ProcessController(IProcessService processService, IServiceProvider serviceProvider, IConfiguration Configuration)
            : base(serviceProvider, Configuration)
        {
            this._service = processService;
        }


        [Route("GetAll")]
        [HttpGet]
        public async Task<ProcessVM> GetAll([FromQuery] ProcessDto body)
        {
            await Task.FromResult(0);
            return _service.GetAll();
        }
        [Route("Get/{Id}")]
        [HttpGet]
        public async Task<ProcessVM> Get(long Id)
        {
            await Task.FromResult(0);
            return _service.GetByID(Id);
        }

        [Route("Remove/{Id}")]
        [HttpGet]
        public async Task<ProcessVM> Remove(long Id)
        {
            await Task.FromResult(0);
            return _service.Remove(Id);
        }


        [Route("RemoveByIds")]
        [HttpPut]
        public async Task<ProcessVM> RemoveByIds([FromBody] ProcessDto ids)
        {
            await Task.FromResult(0);
            return _service.Remove(ids.ids);
        }


        [Route("Insert")]
        [HttpPost]
        public async Task<ProcessVM> Insert(ProcessDto body)
        {
            await Task.FromResult(0);
            return _service.Insert(body);
        }

        [Route("InsertBalance")]
        [HttpPost]
        public async Task<ProcessVM> InsertBalance(ProcessBalanceDto body)
        {
            await Task.FromResult(0);
            return _service.InsertBalance(body);
        }

        [Route("EditBalance")]
        [HttpPut]
        public async Task<ProcessVM> EditBalance(ProcessBalanceDto body)
        {
            await Task.FromResult(0);
            return _service.EditBalance(body);
        }
        [Route("GetUserContractors/{Id}")]
        [HttpGet]
        public async Task<ProcessDto> GetUserContractors(long Id)
        {
            await Task.FromResult(0);
            return _service.GetUserContractors(Id);
        }

        [Route("GetProcessProducts/{Id}")]
        [HttpGet]
        public async Task<ProcessDto> GetProcessProducts(long Id)
        {
            await Task.FromResult(0);
            return _service.GetProcessBalances(Id);
        }

        [Route("RollBackProcess/{Id}")]
        [HttpGet]
        public async Task<ProcessVM> RollBackProcess(long Id)
        {
            await Task.FromResult(0);
            var ids = new List<Int64>();
            ids.Add(Id);
            return _service.Remove(ids.ToArray());
        }

        [Route("Edit")]
        [HttpPut]
        public async Task<ProcessVM> Edit(ProcessDto body)
        {
            await Task.FromResult(0);
            return _service.Edit(body);
        }

        [Route("Search")]
        [HttpGet]
        public async Task<ProcessVM> Search([FromQuery] ProcessDto body)
        {
            await Task.FromResult(0);
            return _service.Search(body);
        }
    }
}
