using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OA.Common.EnumValues;
using OA.Common.Exceptions;
using OA.Common.Utility;
using OA.Service_.Toural.Contracts;
using OA.Service_.Toural.ViewModels.InitialBalance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WebApiClient.Controllers
{
    [ApiController]
    [Route("api/Units")]
    public class UnitsController : BaseController
    {
        private readonly IGeneralParameterService _generalParameterService;
        public UnitsController(IGeneralParameterService generalParameterService, IServiceProvider serviceProvider, IConfiguration Configuration)
            : base(serviceProvider, Configuration)
        {
            _generalParameterService = generalParameterService;
        }


        #region Units Api
        [Route("GetAll")]
        [HttpGet]
        public async Task<InitialBalanceVM> GetAll()
        {
            await Task.FromResult(0);
            return _generalParameterService.GetAll();
        }
        [Route("InsertUnits")]
        [HttpPost]
        public async Task<InitialBalanceVM> InsertUnits([FromBody] GeneralParamterPoco entity)
        {
            await Task.FromResult(0);
            return _generalParameterService.Insert(entity);
        }


        [Route("EditUnits")]
        [HttpPost]
        public async Task<InitialBalanceVM> EditUnits([FromBody] GeneralParamterPoco entity)
        {
            await Task.FromResult(0);
            return _generalParameterService.Edit(entity);
        }

        [Route("RemoveByIdsUnits")]
        [HttpPost]
        public async Task<InitialBalanceVM> RemoveByIdsUnits([FromBody] GeneralParamterPoco ids)
        {
            await Task.FromResult(0);
            return _generalParameterService.Remove(ids.ids);
        }


        [Route("SearchUnits")]
        [HttpGet]
        public async Task<InitialBalanceVM> SearchUnits([FromQuery] GeneralParamterPoco body)
        {
            await Task.FromResult(0);
            return _generalParameterService.Search(body);
        }
        #endregion

    }
}
