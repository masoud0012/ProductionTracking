using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OA.Service_.Toural.Contracts;
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
    public class StockRoomController : BaseController
    {
        private readonly IStockRoomService _stockRoomService;
        public StockRoomController(IStockRoomService stockRoomService, IServiceProvider serviceProvider, IConfiguration Configuration)
            : base(serviceProvider, Configuration)
        {
            _stockRoomService = stockRoomService;
        }


        [HttpGet("GetAll")]
        public StockRoomVM GetAll()
        {
            return  _stockRoomService.GetAll();
        }

        [Route("Insert")]
        [HttpPost]
        public async Task<StockRoomVM> Insert([FromBody] StockRoomDto entity)
        {
            await Task.FromResult(0);
            return _stockRoomService.Insert(entity);
        }

        [Route("Edit")]
        [HttpPost]
        public async Task<StockRoomVM> Edit([FromBody]StockRoomDto entity)
        {
            await Task.FromResult(0);
            return _stockRoomService.Edit(entity);
        }



        [Route("Get/{Id}")]
        public async Task<StockRoomVM> Get( Int64 Id)
        {
            await Task.FromResult(0);
            return _stockRoomService.GetByID(Id);
        }

        [Route("RemoveByIds")]
        [HttpPost]
        public async Task<StockRoomVM> RemoveByIds([FromBody] StockRoomDto ids)
        {
            await Task.FromResult(0);
            return _stockRoomService.Remove(ids.ids);
        }

        [Route("Search")]
        [HttpGet]
        public async Task<StockRoomVM> Search([FromQuery] StockRoomDto body)
        {
            await Task.FromResult(0);
            return _stockRoomService.Search(body);
        }

        [Route("Remove/{Id}")]
        [HttpGet]
        public async Task<StockRoomVM> Remove(long Id)
        {
            await Task.FromResult(0);
            return _stockRoomService.Remove(Id);
        }

    }
}
