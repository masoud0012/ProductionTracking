using Microsoft.AspNetCore.Mvc;
using OA.Service_.Toural.Contracts.ControllerService;
using OA.Service_.Toural.Contracts.Cost;
using OA.Service_.Toural.JobService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WebApiClient.Controllers
{
    [ApiController]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        protected IActionService _actionService;
        protected IControllService _controllService;
        private ICostService costService;
        public UsersController(IActionService actionService,
            ICostService costService,
                   IControllService controllService)
        {
            this._controllService = controllService;
            this._actionService = actionService;
            this.costService = costService;
        }
        [Route("Get")]
        [HttpGet]
        public void GetUsers()
        {
            this.costService.CalculateCostPerMonth();
        }
    }
}
