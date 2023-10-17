using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using OA.Service_.Toural.Contracts.JWTService;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.JWTService
{
    public  class JWTService: IJWService
    {
        private IHttpContextAccessor _httpContextAccessor;
        public JWTService(IHttpContextAccessor httpContextAccessor)
        {
            this._httpContextAccessor = httpContextAccessor;
        }
        public ClaimsPrincipal GetPrincipal()
        {

            try
            {
                string token = _httpContextAccessor.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes("rpkxqlogetsimiuqsvleidldgvmbjtrpfhghf454");
                var claim = tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                return claim;
            }
            catch (Exception ex)
            {
                //should write log
                return null;
            }
        }

        public Int64 GetUserID()
        {
            var Claims = GetPrincipal();
           return Int64.Parse(Claims.Claims.First(i => i.Type == ClaimTypes.NameIdentifier).Value);
        }
    }
}
