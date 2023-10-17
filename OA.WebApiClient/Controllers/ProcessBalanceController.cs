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
    public class ProcessBalanceController : BaseController
    {
        private readonly IProcessBalanceService _service;
        public ProcessBalanceController(IProcessBalanceService processService, IServiceProvider serviceProvider, IConfiguration Configuration)
            : base(serviceProvider, Configuration)
        {
            this._service = processService;
        }

        [Route("Edit")]
        [HttpPut]
        public async Task<ProcessVM> Edit(ProcessDto processDto)
        {
            await Task.FromResult(0);
            return _service.Edit(processDto);
        }

        [HttpPost("Insert")]
        public async Task<ProcessVM> Insert(ProcessDto processDto)
        {
            await Task.FromResult(0);
            return _service.Insert(processDto);
        }
    }
}
