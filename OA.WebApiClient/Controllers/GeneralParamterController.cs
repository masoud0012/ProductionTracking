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
    [Route("api/GeneralParamter")]
    public class GeneralParamterController : BaseController
    {
        private readonly IGeneralParameterService _generalParameterService;
        public GeneralParamterController(IGeneralParameterService generalParameterService, IServiceProvider serviceProvider, IConfiguration Configuration)
            : base(serviceProvider, Configuration)
        {
            _generalParameterService = generalParameterService;
        }


        [HttpGet("GetAll")]
        public async Task<InitialBalanceVM> GetAll()
        {
            await Task.FromResult(0);
            return _generalParameterService.GetAll();
        }

        [HttpGet("GetChildsByParents")]
        public async Task<InitialBalanceVM> GetChildsByParents([FromQuery]string[] Code)
        {
            await Task.FromResult(0);
            return _generalParameterService.GetGeneralParamters(Code);
        }


        [HttpGet("GetParentCodes")]
        public async Task<InitialBalanceVM> GetParentsCode()
        {
            await Task.FromResult(0);
            return _generalParameterService.GetGeneralParamters();
        }

        [Route("get/{Id}")]
        [HttpGet]
        public async Task<InitialBalanceVM> get(int id)
        {
            await Task.FromResult(0);
            return _generalParameterService.GetByID(id);
        }

        [Route("GetByCode/{code}")]
        [HttpGet]
        public async Task<InitialBalanceVM> GetByCode( string code)
        {
            var result = new InitialBalanceVM();
            ParentEnum parentCode ;
            try
            {
                await Task.FromResult(0);
                parentCode = CommonUtility.GetValueFromDescription<ParentEnum>(code);
                result = _generalParameterService.GetGeneralParamterByParentCode(parentCode);
            }
            catch(CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        [Route("Search")]
        [HttpGet]
        public async Task<InitialBalanceVM> Search([FromQuery] GeneralParamterPoco body)
        {
            await Task.FromResult(0);
            return _generalParameterService.Search(body);
        }

        [Route("RemoveByIds")]
        [HttpPost]
        public async Task<InitialBalanceVM> RemoveByIds([FromBody] GeneralParamterPoco ids)
        {
            await Task.FromResult(0);
            return _generalParameterService.Remove(ids.ids);
        }

        [Route("Edit")]
        [HttpPost]
        public async Task<InitialBalanceVM> Edit([FromBody] GeneralParamterPoco entity)
        {
            await Task.FromResult(0);
            return  _generalParameterService.Edit(entity);
        }

        [Route("Insert")]
        [HttpPost]
        public async Task<InitialBalanceVM> Insert([FromBody] GeneralParamterPoco entity)
        {
            await Task.FromResult(0);
            return _generalParameterService.Insert(entity);
        }

        [HttpGet("GetCurrentDaysOfMonth")]
        public int getCurrentDaysOfMonth()
        {
           return _generalParameterService.getCurrentDaysOfMonth();
        }

    }
}
