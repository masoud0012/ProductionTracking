using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OA.Service_.Toural.Contracts.Process;
using OA.Service_.Toural.ViewModels.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WebApiClient.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessDefinitionController : BaseController
    {
        private readonly IProcessDefinitionService _service;
        public ProcessDefinitionController(IProcessDefinitionService processService, IServiceProvider serviceProvider, IConfiguration Configuration)
            : base(serviceProvider, Configuration)
        {
            this._service = processService;
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

        [Route("Insert")]
        [HttpPost]
        public async Task<ProcessVM> Insert(ProcessDefinitionDto body)
        {
            await Task.FromResult(0);
            return _service.Insert(body);
        }

        [Route("Edit")]
        [HttpPut]
        public async Task<ProcessVM> Edit(ProcessDefinitionDto body)
        {
            await Task.FromResult(0);
            return _service.Edit(body);
        }

        [Route("Search")]
        [HttpGet]
        public async Task<ProcessVM> Search([FromQuery] ProcessDefinitionDto body)
        {
            await Task.FromResult(0);
            return _service.Search(body);
        }

        [Route("RemoveByIds")]
        [HttpPut]
        public async Task<ProcessVM> RemoveByIds([FromBody] ProcessDefinitionDto ids)
        {
            await Task.FromResult(0);
            return _service.Remove(ids.ids);
        }
    }
}
