using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice_1.Services.Interfaces
{
    public interface IJwtService
    {
        int? ValidateJwtToken(string token);
    }
}
