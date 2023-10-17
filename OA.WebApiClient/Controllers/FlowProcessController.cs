using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OA.Service_.Toural.Contracts.FlowProcess;
using OA.Service_.Toural.ViewModels.FlowProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WebApiClient.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlowProcessController : BaseController
    {
        private readonly IFlowProcessService _service;
        public FlowProcessController(IFlowProcessService flowProcessService, IServiceProvider serviceProvider, IConfiguration Configuration)
            : base(serviceProvider, Configuration)
        {
            this._service = flowProcessService;
        }

        [Route("Get/{Id}")]
        [HttpGet]
        public async Task<FlowProcessVM> GetById(long Id)
        {
            await Task.FromResult(0);
            return _service.GetByID(Id);
        }

        [Route("Remove/{Id}")]
        [HttpGet]
        public async Task<FlowProcessVM> Remove(long Id)
        {
            await Task.FromResult(0);
            return _service.Remove(Id);
        }

        [Route("InsertToStack")]
        [HttpPost]
        public async Task<FlowProcessVM> InsertToStack(FlowProcessDto body)
        {
            await Task.FromResult(0);
            return _service.InsertToStack(body);
        }


        [Route("InsertToBalance")]
        [HttpPost]
        public async Task<FlowProcessVM> InsertToBalance(IFormFile file)
        {
            await Task.FromResult(0);
            var body = JsonConvert.DeserializeObject<FlowProcessDto>(Request.Form["body"]);
            return _service.InsertNewBalance(body,file);
        }


        [Route("Edit")]
        [HttpPut]
        public async Task<FlowProcessVM> Edit(FlowProcessDto role)
        {
            await Task.FromResult(0);
            return _service.Edit(role);
        }

        [Route("Search")]
        [HttpGet]
        public async Task<FlowProcessVM> Search([FromQuery] FlowProcessDto body)
        {
            await Task.FromResult(0);
            var data = _service.Search(body);
            return data;
        }


        [Route("RemoveByIds")]
        [HttpPut]
        public async Task<FlowProcessVM> RemoveByIds([FromBody] FlowProcessDto ids)
        {
            await Task.FromResult(0);
            return _service.Remove(ids.ids);
        }


        [Route("InsertWastage")]
        [HttpPost]
        public async Task<FlowProcessVM> InsertWastage(FlowProcessDto body)
        {
            await Task.FromResult(0);
            return _service.InsertWastages(body);
        }
    }
}
