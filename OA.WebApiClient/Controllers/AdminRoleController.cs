using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OA.Data.Toural.UserEntity;
using OA.Service_.Toural.Contracts.UserContracts;
using OA.Service_.Toural.ViewModels.UserVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WebApiClient.Controllers
{
    [ApiController]
    [Route("api/AdminRole")]
    public class AdminRoleController : BaseController
    {
        private IRoleServices _roleServices;
        private IMapper _mapper;

        public AdminRoleController(IRoleServices roleServices, IMapper mapper, 
            IServiceProvider serviceProvider, IConfiguration Configuration) 
            : base(serviceProvider,Configuration)
        {
            this._roleServices = roleServices;
            this._mapper = mapper;
        }


        [Route("GetRoles")]
        [HttpGet]
        public async Task<RoleVM> GetRoles()
        {
            await Task.FromResult(0);
            return _roleServices.GetRoles();
        }

        [Route("Get/{Id}")]
        [HttpGet]
        public async Task<RoleVM> GetById(long Id)
        {
            await Task.FromResult(0);
            return _roleServices.GetRole(Id);
        }

        [Route("Remove/{Id}")]
        [HttpGet]
        public async Task<RoleVM> Remove(long Id)
        {
            await Task.FromResult(0);
            return _roleServices.Remove(Id);
        }

        [Route("Insert")]
        [HttpPost]
        public async Task<RoleVM> Insert(RoleDto role)
        {
            await Task.FromResult(0);
            return _roleServices.InsertRole(role);
        }

        [Route("Edit")]
        [HttpPost]
        public async Task<RoleVM> Edit(RoleDto role)
        {
            await Task.FromResult(0);
            return _roleServices.UpdateRole(role);
        }
    }
}
