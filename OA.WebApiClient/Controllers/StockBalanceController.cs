using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OA.Service_.Toural.Contracts.StockRoom;
using OA.Service_.Toural.ViewModels.StockRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WebApiClient.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockBalanceController : BaseController
    {
        private readonly IStockRoom_BalanceService _stockRoom_BalanceService;
        public StockBalanceController( IStockRoom_BalanceService stockRoom_BalanceService, IServiceProvider serviceProvider, IConfiguration Configuration)
            : base(serviceProvider, Configuration)
        {
            _stockRoom_BalanceService = stockRoom_BalanceService;
        }
        [Route("Insert")]
        [HttpPost]
        [Authorize]
        public async Task<StockRoomVM> InsertStockBalance([FromBody] StockRoom_InitialBalanceDto entity)
        {
            await Task.FromResult(0);
            return _stockRoom_BalanceService.Insert(entity);
        }

        [Route("Edit")]
        [HttpPost]
        public async Task<StockRoomVM> UpdateStockBalanc([FromBody] StockRoom_InitialBalanceDto entity)
        {
            await Task.FromResult(0);
            return _stockRoom_BalanceService.Updae(entity);
        }


        [HttpGet("Get/{Id}")]
        public async Task<StockRoomVM> Get(Int64 Id)
        {
            await Task.FromResult(0);
            return _stockRoom_BalanceService.GetByID(Id);
        }

        [HttpGet("Remove/{Id}")]
        public async Task<StockRoomVM> RemoveStockBalanceById(Int64 Id)
        {
            await Task.FromResult(0);
            return _stockRoom_BalanceService.Remove(Id);
        }

    }
}
