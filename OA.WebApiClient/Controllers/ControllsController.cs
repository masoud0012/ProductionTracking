
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OA.Service_.Toural.Contracts.ControllerService;
using OA.Service_.Toural.ViewModels.ControllVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WebApiClient.Controllers
{
    [ApiController]
    [Route("api/Controlls")]
    public class ControllsController : BaseController
    {
        protected IActionService _actionService;
        protected IControllService _controllService;


        public ControllsController(IControllService _controllService,
            IActionService _actionService, IServiceProvider serviceProvider, IConfiguration Configuration)
            : base(serviceProvider, Configuration)
        {
            this._actionService = _actionService;
            this._controllService = _controllService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("GetControls")]
        [HttpGet]
        public async Task<ControllerVM> GetAll()
        {
            await Task.FromResult(0);
            return _controllService.GetAll(base.PersmissionActionsDtos);
        }

        [Route("GetActions")]
        [HttpGet]
        public async Task<ControllerVM> GetActions()
        {
            await Task.FromResult(0);
            return _actionService.GetAll(base.PersmissionActionsDtos);
        }

        [Route("GetControlsUserGrants/{Id}")]
        [HttpGet]
        public async Task<ControllerVM> GetControlsUserGrants(long Id)
        {
            await Task.FromResult(0);
            return _controllService.GetUserGrants(Id);
        }

        [Route("GetActionsUserGrants/{Id}")]
        [HttpGet]
        public async Task<ControllerVM> GetActionsUserGrants(long Id)
        {
            await Task.FromResult(0);
            return _actionService.GetUserGrants(Id, base.PersmissionActionsDtos);
        }


        [Route("SetGrantToUser")]
        [HttpPut]
        public async Task<ControllerVM> SetGrantToUser([FromBody] ActionDto body)
        {
            await Task.FromResult(0);
            return _actionService.SetUserGrants(body);
        }
    }
}
