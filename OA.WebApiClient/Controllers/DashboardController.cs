using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OA.Service_.Toural.Contracts;
using OA.Service_.Toural.ViewModels.DashboardVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WebApiClient.Controllers
{
    [ApiController]
    [Route("api/Dashboard")]
    public class DashboardController : BaseController
    {
        private readonly IDashboardService _service;
        public DashboardController( IServiceProvider serviceProvider, IDashboardService service, IConfiguration Configuration)
            : base(serviceProvider, Configuration)
        {
            _service = service;
        }

        [Route("GetLastActivity")]
        [HttpGet]
        public async Task<DashboardVM> GetLastActivity()
        {
            await Task.FromResult(0);
            return _service.GetLastActivity(base.UserID);
        }

        [Route("GetLastInitialBalance")]
        [HttpGet]
        public async Task<DashboardVM> GetLastInitialBalance()
        {
            await Task.FromResult(0);
            return _service.GetLastInitialBalance(base.UserID);
        }

        [Route("GetLastStockActivity")]
        [HttpGet]
        public async Task<DashboardVM> GetLastStockActivity()
        {
            await Task.FromResult(0);
            return _service.GetLastStockActivity(base.UserID);
        }

        [Route("GetProcessChart")]
        [HttpGet]
        public async Task<DashboardVM> GetProcessChart()
        {
            await Task.FromResult(0);
            return _service.GetProcessChart();
        }

        [Route("GetCostChart")]
        [HttpGet]
        public async Task<DashboardVM> GetCostChart()
        {
            await Task.FromResult(0);
            return _service.GetCostChart();
        }
        [Route("GetLogEntities")]
        [HttpGet]
        public async Task<DashboardVM> GetLogEntities([FromQuery] DashboardDto body)
        {
            await Task.FromResult(0);
            return _service.GetLogEntities(body);
        }

    }
}
