using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using OA.Data.UserEntity;
using OA.Service_.Toural.Configuration;
using OA.Service_.Toural.Contracts.UserContracts;
using OA.Service_.Toural.ViewModels.ControllVM;
using OA.Service_.Toural.ViewModels.UserVM;
using System;
using System.Threading.Tasks;

namespace OA.WebApiClient.Controllers
{
    [ApiController]
    [Route("api/AdminUser")]
    [AllowAnonymous]
    public class AdminUserController : BaseController
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserService _userService;

    
        public AdminUserController(UserManager<User> userManager,
            IUserService userService,
            IServiceProvider serviceProvider, IConfiguration Configuration)
            : base(serviceProvider, Configuration)
        {
            this._userManager = userManager;
            this._userService = userService;
        }

        [Route("GetUsers")]
        [HttpGet]
        public async Task<UserVM> GetUsers()
        {
            await Task.FromResult(0);
            return _userService.GetUsers();
        }

        [Route("Get/{Id}")]
        [HttpGet]
        public async Task<UserVM> GetById(long Id)
        {
            await Task.FromResult(0);
            return _userService.GetUser(Id);
        }


  

        [Route("Remove/{Id}")]
        [HttpGet]
        public async Task<UserVM> Remove(long Id)
        {
            await Task.FromResult(0);
            return _userService.Remove(Id);
        }

        [Route("Active/{Id}")]
        [HttpGet]
        public async Task<UserVM> Active(long Id)
        {
            await Task.FromResult(0);
            return _userService.Active(Id);
        }


        [Route("RemoveByIds")]
        [HttpPut]
        public async Task<UserVM> RemoveByIds([FromBody] UserDto ids)
        {
            await Task.FromResult(0);
            return _userService.Remove(ids.ids);
        }


        [Route("Insert")]
        [HttpPost]
        public async Task<UserVM> Insert(UserDto user)
        {
            await Task.FromResult(0);
            return _userService.InsertUser(user);
        }

        [Route("Edit")]
        [HttpPut]
        public async Task<UserVM> Edit(UserDto user)
        {
            await Task.FromResult(0);
            return _userService.UpdateUser(user);
        }

        [Route("ChangePassword")]
        [HttpPost]
        public async Task<UserVM> ChangePassword(UserDto user)
        {
            await Task.FromResult(0);
            return _userService.ChangePassword(user);
        }


        [Route("Login")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<UserVM> Login(UserDto user)
        {
            return await _userService.Login(user);
        }

        [Route("Search")]
        [HttpGet]
        public async Task<UserVM> Search([FromQuery] UserDto body)
        {
            await Task.FromResult(0);
            return _userService.Search(body);
        }


    }
}
