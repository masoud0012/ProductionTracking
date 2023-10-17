using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Contracts.JWTService
{
    public interface IJWService
    {
        ClaimsPrincipal GetPrincipal();
        Int64 GetUserID();
    }
}
