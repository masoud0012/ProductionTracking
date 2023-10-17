using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using OA.Common.Constants;
using OA.Service_.Toural.Contracts.ControllerService;
using OA.Service_.Toural.Contracts.JWTService;
using OA.Service_.Toural.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OA.WebApiClient.Controllers
{
    public class BaseController : Controller
    {
        protected IActionService _actionService;
        protected IControllService _controllService;
        protected IJWService _jWtService;
        protected IHttpContextAccessor _httpContextAccessor;
        protected IConfiguration Configuration { get; }
        protected Int64 UserID;
        protected string RoleName;
        protected string userName;
        protected List<PersmissionActionsDto> PersmissionActionsDtos;
        public BaseController(IServiceProvider provider, IConfiguration Configuration)
        {
            this._jWtService = provider.GetRequiredService<IJWService>();
            this._controllService = provider.GetRequiredService<IControllService>();
            this._actionService = provider.GetRequiredService<IActionService>();
            this._httpContextAccessor = provider.GetRequiredService<IHttpContextAccessor>();
            this.Configuration = Configuration;
        }


        public override void OnActionExecuting(ActionExecutingContext context)
        {

            //RoleName = _httpContextAccessor.HttpContext.User.Claims.First(i => i.Type == ClaimTypes.Role).Value;
            //userName = _httpContextAccessor.HttpContext.User.Claims.First(i => i.Type == ClaimTypes.Name).Value;
            string controllerName = ControllerContext.ActionDescriptor.ControllerName;
            string actionName = ControllerContext.ActionDescriptor.ActionName;
            if (actionName != "Login")
            {
                var data = Configuration.GetSection("PermissionActions").Get<PersmissionActionsDto[]>();
                PersmissionActionsDtos = data.ToList();
                var Claims = _jWtService.GetPrincipal();
                if (Claims == null)
                {
                    context.Result = BadRequest(new BaseVM
                    {
                        Code = ConstantsValue.NotTokenValidCode,
                        ErrorMessage = ConstantsValue.NotTokenValidMessage
                    });
                }
                else
                {
                    UserID = Int64.Parse(Claims.Claims.First(i => i.Type == ClaimTypes.NameIdentifier).Value);
                    if (data.Any(z => z.ControllerName == controllerName && z.Acttion == actionName) == false)
                    {
                        var controller = _controllService.GetByName(controllerName);
                        var action = controller.ControllerDto.ActionDtos.Where(z => z.ActionName == actionName).FirstOrDefault();
                        var checkHasAccess = _actionService.ChecHasAccess(UserID, action.ID);
                        if (checkHasAccess.Code == ConstantsValue.HasAccessCode)
                        {
                            base.OnActionExecuting(context);
                        }
                        else
                        {
                            context.Result = BadRequest(new BaseVM
                            {
                                Code = ConstantsValue.NotHasAccessCode,
                                ErrorMessage = "کاربر گرامی شما مجاز به عملیات " + actionName + " در صفحه " + controllerName + "نمی باشید. لطفا با مدیر سایت تماس بگیرید"
                            });

                        }

                    }
                }

                base.OnActionExecuting(context);
            }
        }
    }
}
